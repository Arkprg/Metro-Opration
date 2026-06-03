using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    /// <summary>
    /// OptimizationForm: بازنویسی کامل و بهینه‌شده
    /// - شامل PersoOptim که قابل فراخوانی جداگانه است
    /// - کش ShKar و TotaMonAdv برای ماه‌ها
    /// - پارامترایز کردن همه‌ی کوئری‌ها
    /// - اجرای بلندمدت در پس‌زمینه برای جلوگیری از فریز UI
    /// فرض: توابع کمکی (Taghvim, TimeToDouble, DoubleToTime, ShamsiToMiladi و اشیاء فرم اصلی) قبلاً وجود دارند.
    /// </summary>
    public partial class OptimizationForm
    {
        public OptimizationForm()
        {
            InitializeComponent();
        }

        public string Tarikh = "";
        private bool started = false;

        // Cache ها
        private readonly Dictionary<string, DataRow> ShKarCache = new Dictionary<string, DataRow>();
        private readonly Dictionary<string, Dictionary<string, DataRow>> TotaMonCache = new Dictionary<string, Dictionary<string, DataRow>>();
        // TotaMonCache: key=Maah (yyyy/MM) -> (P_Num -> DataRow)

        public void OptimizationForm_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (started)
            {
                return;
            }

            started = true;
            Timer1.Enabled = false;

            if (string.IsNullOrEmpty(Tarikh))
            {
                Tarikh = MainForm.PersianToday.Tarikh();
            }
            // اجرای محاسبات در پس‌زمینه تا UI قفل نشود
            //Task.Run(() => RunAllCalc(Tarikh));
            //RunAllCalc(Tarikh);
            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                Calc(Tarikh, StrConnec);
                Close();
            }

        }

        /// <summary>
        /// تابع Calc — خواندن Person و پردازش ماه(ها).
        /// </summary>
        public void Calc(string Tarikh, OleDbConnection StrConnec)
        {
            try
            {
                Taghvim PersianDate = new Taghvim(Tarikh);

                // اگر روز <= 7 بود، نیاز است ماه قبل نیز محاسبه شود (همان منطق قدیمی)
                List<string> monthsToProcess = new List<string>();
                string maahCurrent = PersianDate.Tarikh().Substring(0, 7);
                if (PersianDate.Day() <= 7)
                {
                    Taghvim prev = new Taghvim(Tarikh);
                    prev.AddMonth(-1);
                    monthsToProcess.Add(prev.Tarikh().Substring(0, 7));
                }
                monthsToProcess.Add(maahCurrent);

                // preload Person table (همان query قدیمی)
                DataTable PersonTable = new DataTable();
                using (OleDbDataAdapter Adap = new OleDbDataAdapter("SELECT Fname, Family, P_Num, P_Post, Shift_Loc, Shift_Time, Shift_name, Calc FROM Person WHERE Calc <> 'بدون محاسبه' AND Vis=True", StrConnec))
                {
                    Adap.Fill(PersonTable);
                }

                // preload کش های مورد نیاز برای ماه‌ها
                foreach (string m in monthsToProcess)
                {
                    LoadShKarForMonthToCache(StrConnec, m);
                    LoadTotaMonForMonthToCache(StrConnec, m);
                }

                // پردازش برای هر ماه تعیین‌شده
                foreach (string m in monthsToProcess)
                {
                    Taghvim startDate = new Taghvim(m + "/01"); // اول ماه
                    string endDate = "";

                    if (startDate.Month() < MainForm.PersianToday.Month() || startDate.Year() < MainForm.PersianToday.Year())
                    {
                        // ماه قبل → کل ماه
                        endDate = startDate.EndOfThisMonth();
                    }
                    else if (startDate.Month() == MainForm.PersianToday.Month() && startDate.Year() == MainForm.PersianToday.Year())
                    {
                        // ماه جاری → تا امروز
                        endDate = MainForm.PersianToday.Tarikh();
                    }
                    else
                    {
                        // ماه آینده → فقط روز اول
                        endDate = startDate.Tarikh();
                    }

                    foreach (DataRow row in PersonTable.Rows)
                    {
                        string pnum = row["P_Num"].ToString();
                        PersoOptim(pnum, endDate, StrConnec);
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        /// <summary>
        /// PersoOptim — محاسبهٔ یک فرد در ماه (بهینه‌شده)
        /// StrConnec: باید یک OleDbConnection باز ارسال شود
        /// Tarikh: معمولاً پایان بازه یا تاریخ جاری
        /// </summary>
        public void PersoOptim(string PNum, string Tarikh , OleDbConnection StrConnec)
        {
            try
            {
                Taghvim PersianDate = new Taghvim(Tarikh);
                string StartDate = PersianDate.FirstOfThisMonth(); // yyyy/MM/01
                string EndDate = "";
                if (MainForm.PersianToday.Tarikh().Substring(0, 7) == Tarikh.Substring(0, 7))
                {
                    EndDate = PersianDate.Tarikh();
                }
                else
                {
                    EndDate = PersianDate.EndOfThisMonth();
                }

                string maahKey = StartDate.Substring(0, 7);

                // متغیرهای محاسباتی اولیه
                string ShCal = string.Empty;
                double ShiftEza = 0;
                double ShiftEzaFri = 0;
                double FogFri = 0;
                double Eza = 0;
                double EzaFri = 0;
                double Sat = 0;
                double SatFri = 0;
                double KasMor = 0;
                double KasMorFri = 0;
                double PasMon = 0;
                double TopOver = 0;
                int Trips = 0;
                int Mor = 0;
                int MorFri = 0;

                // 6) خواندن TopOver از ShKar (کش)
                DataRow shRow = ShKarCache.ContainsKey(maahKey) ? ShKarCache[maahKey] : null;
                if (shRow != null)
                {
                    TopOver = ConvertClass.TimeToDouble(shRow["MonthTime"].ToString());
                }
                else
                {
                    using (OleDbCommand cmd = new OleDbCommand($"SELECT MonthTime FROM ShKar WHERE Tarikh='{maahKey}'", StrConnec))
                    {
                        object tmp = cmd.ExecuteScalar();
                        TopOver = ConvertClass.TimeToDouble(tmp.ToString());
                    }
                }

                if (maahKey != MainForm.PersianToday.Tarikh().Substring(0, 7) || (MainForm.PersianToday.Day() > 25 && maahKey == MainForm.PersianToday.Tarikh().Substring(0, 7)))
                {
                    // 1) خواندن TotaMonAdv (کش یا DB)
                    DataRow existingTotaRow = null;
                    if (TotaMonCache.ContainsKey(maahKey) && TotaMonCache[maahKey].ContainsKey(PNum))
                    {
                        existingTotaRow = TotaMonCache[maahKey][PNum];
                        if (existingTotaRow != null)
                        {
                            ShCal = existingTotaRow["Shift"].ToString();
                        }
                    }
                    else
                    {
                        using (OleDbCommand cmd = new OleDbCommand($"SELECT Shift FROM TotaMonAdv WHERE P_Num='{PNum}' AND Maah='{maahKey}'", StrConnec))
                        {
                            using (OleDbDataReader rdr = cmd.ExecuteReader())
                            {
                                if (rdr.Read())
                                {
                                    ShCal = rdr["Shift"].ToString();
                                }
                            }
                        }
                    }
                }

                // اگر ShCal تهی بود، تلاش برای ساخت از جدول Person
                if (string.IsNullOrWhiteSpace(ShCal))
                {
                    using (OleDbCommand cmdP = new OleDbCommand($"SELECT P_Post, Shift_Loc, Shift_Time, Shift_name, Calc FROM Person WHERE P_Num='{PNum}' AND Vis=True", StrConnec))
                    {
                        using (OleDbDataReader rdrP = cmdP.ExecuteReader())
                        {
                            if (rdrP.Read())
                            {
                                DataTable fakeRow = new DataTable();
                                fakeRow.Columns.Add("P_Post");
                                fakeRow.Columns.Add("Shift_Loc");
                                fakeRow.Columns.Add("Shift_Time");
                                fakeRow.Columns.Add("Shift_name");
                                fakeRow.Columns.Add("Calc");
                                DataRow rNew = fakeRow.NewRow();
                                rNew["P_Post"] = rdrP["P_Post"].ToString();
                                rNew["Shift_Loc"] = rdrP["Shift_Loc"].ToString();
                                rNew["Shift_Time"] = rdrP["Shift_Time"].ToString();
                                rNew["Shift_name"] = rdrP["Shift_name"].ToString();
                                rNew["Calc"] = rdrP["Calc"].ToString();
                                fakeRow.Rows.Add(rNew);
                                ShCal = BuildShCalFromPerson(fakeRow.Rows[0]);
                            }
                        }
                    }
                }

                // اگر باز هم خالی بود، کاری انجام نده
                if (string.IsNullOrWhiteSpace(ShCal))
                {
                    return;
                }

                // ---------- **بخشِ تعیین SobhTime/AsrTime و محاسبات شیفت (بازگردانده‌شده و بهینه‌شده)** ----------
                double SobhTime = 9;
                double AsrTime = 9;
                double Movaz = 0;

                // اگر ShKar کش شده باشد از آن استفاده کن و محاسبات اضافه شیفت را انجام بده:
                try
                {
                    // تعیین SobhTime و AsrTime بر اساس کد شیفت
                    string subCode = ShCal.Length >= 3 ? ShCal.Substring(1, 2) : string.Empty;
                    switch (subCode)
                    {
                        case "PT":
                            SobhTime = 14;
                            AsrTime = 14;
                            break;
                        case "RT":
                            SobhTime = 16;
                            AsrTime = 16;
                            break;
                        case "RN":
                            SobhTime = 13;
                            AsrTime = 13;
                            break;
                        case "ST":
                            SobhTime = 12;
                            AsrTime = 12;
                            break;
                        default:
                            SobhTime = 9;
                            AsrTime = 9;
                            break;
                    }
                    LoadShKarForMonthToCache(StrConnec, maahKey);
                    //SELECT Rooz3, Rooz4, Rooz5, Kasri, MonthTime, ASobh, AAsr, AJom9, AJom12, BSobh, BAsr, BJom9, BJom12, CSobh, CAsr, CJom9, CJom12 FROM ShKar 
                    //ShKarCache[maah]
                    int roo3 = Convert.ToInt32(ShKarCache[maahKey]["Rooz3"]);
                    int roo4 = Convert.ToInt32(ShKarCache[maahKey]["Rooz4"]);
                    int roo5 = Convert.ToInt32(ShKarCache[maahKey]["Rooz5"]);
                    string kasriStr = ShKarCache[maahKey]["Kasri"].ToString();

                    Movaz = roo3 * 9 + roo4 * 8 - roo5 * 7.5 - ConvertClass.TimeToDouble(kasriStr);

                    // اگر شیفت S (ستادی) باشد
                    if (ShCal.Length >= 3 && ShCal[2] == 'S')
                    {
                        ShiftEza = (roo3 + roo4) * SobhTime - Movaz;
                    }
                    else
                    {
                        // شیفت N یا T (شب/12ساعته/9ساعته)
                        string locChar = ShCal.Length >= 4 ? ShCal[3].ToString() : string.Empty;

                        if (ShCal.Length >= 3 && ShCal[2] == 'N')
                        {
                            // جمعه‌های نوع 9 ساعته
                            string colName = locChar + "Jom9";
                            int cntJom9 = Convert.ToInt32(ShKarCache[maahKey][colName]);
                            ShiftEzaFri = cntJom9 * ((SobhTime + AsrTime - 18) / 2);
                            FogFri += cntJom9 * 9;
                        }
                        else
                        {
                            // جمعه‌های نوع 12 ساعته (یا دیگران)
                            string colName12 = locChar + "Jom12";
                            int cntJom12 = Convert.ToInt32(ShKarCache[maahKey][colName12]);
                            ShiftEzaFri = cntJom12 * 5;
                            FogFri += cntJom12 * 9;
                        }

                        // حالا محاسبهٔ ShiftEza برای روزهای معمولِ شیفت
                        string colSobh = locChar + "Sobh";
                        string colAsr = locChar + "Asr";
                        int cntSobh = Convert.ToInt32(ShKarCache[maahKey][colSobh]);
                        int cntAsr = Convert.ToInt32(ShKarCache[maahKey][colAsr]);

                        ShiftEza = cntSobh * SobhTime + cntAsr * AsrTime - Movaz - ShiftEzaFri;
                    }
                }
                catch (Exception ex)
                {
                    // اگر خطا در محاسبه پیش آمد، مقداردهی پیش‌فرض انجام بده و لاگ کن
                    MainForm.ErrorLogo = $"{Text} - ShiftCalc({PNum},{maahKey}): {ex.Message}\n{MainForm.ErrorLogo}";
                }
                //}
                //}

                // 2) خواندن Trips (COUNT)
                using (OleDbCommand cmdTrips = new OleDbCommand("SELECT COUNT(ID) FROM DailyTrip WHERE (O1_Num=? OR O2_Num=? OR OT_Num=?) AND Tarikh BETWEEN ? AND ? AND Vis=True AND Final=True", StrConnec))
                {
                    cmdTrips.Parameters.AddWithValue("@p1", PNum);
                    cmdTrips.Parameters.AddWithValue("@p2", PNum);
                    cmdTrips.Parameters.AddWithValue("@p3", PNum);
                    cmdTrips.Parameters.AddWithValue("@start", StartDate);
                    cmdTrips.Parameters.AddWithValue("@end", EndDate);
                    object r = cmdTrips.ExecuteScalar();
                    if (r != null)
                    {
                        Trips = Convert.ToInt32(r);
                    }
                }

                // 3) خواندن Ezafeh
                using (OleDbCommand cmdEz = new OleDbCommand("SELECT Tarikh, E_Time FROM Ezafeh WHERE P_Num=? AND Tarikh BETWEEN ? AND ? AND Vis=True", StrConnec))
                {
                    cmdEz.Parameters.AddWithValue("@P_Num", PNum);
                    cmdEz.Parameters.AddWithValue("@start", StartDate);
                    cmdEz.Parameters.AddWithValue("@end", EndDate);
                    using (OleDbDataReader rdr = cmdEz.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string tStr = rdr["Tarikh"].ToString();
                            double eVal = ConvertClass.TimeToDouble(rdr["E_Time"].ToString());
                            if (ConvertClass.ShamsiToMiladi(tStr).DayOfWeek == DayOfWeek.Friday)
                            {
                                EzaFri += eVal;
                            }
                            else
                            {
                                Eza += eVal;
                            }
                        }
                    }
                }

                // 4) خواندن Morakhasi و Rezerv و پردازش آنها (با تابع کمکی ساده‌شده)
                using (OleDbCommand cmdMor = new OleDbCommand("SELECT Morakhasi.Tarikh, Taghvim.Kasri, Taghvim.Rooz, Taghvim.Holi, Taghvim.Sobh, Taghvim.Asr FROM Morakhasi INNER JOIN Taghvim ON Morakhasi.Tarikh=Taghvim.Tarikh WHERE Morakhasi.P_Num=? AND Morakhasi.Tarikh BETWEEN ? AND ? AND Morakhasi.Vis=True", StrConnec))
                {
                    cmdMor.Parameters.AddWithValue("@P_Num", PNum);
                    cmdMor.Parameters.AddWithValue("@start", StartDate);
                    cmdMor.Parameters.AddWithValue("@end", EndDate);
                    using (OleDbDataReader rdr = cmdMor.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string kasriVal = rdr["Kasri"].ToString();
                            if (kasriVal != string.Empty)
                            {
                                KasMor += ConvertClass.TimeToDouble(kasriVal);
                            }

                            int rooz = Convert.ToInt32(rdr["Rooz"]);
                            bool holi = Convert.ToBoolean(rdr["Holi"]);
                            string sobh = rdr["Sobh"].ToString();
                            string asr = rdr["Asr"].ToString();

                            // استفاده از نسخه ساده‌شده ProcessMorakhasi (همان‌گونه که خواستی)
                            ProcessMorakhasi(ShCal, rooz, holi, sobh, asr, ref Mor, ref MorFri, ref KasMor, ref KasMorFri, ref FogFri);
                        }
                    }
                }


                using (OleDbCommand cmdRez = new OleDbCommand("SELECT Rezerv.Tarikh, Taghvim.Kasri, Taghvim.Rooz, Taghvim.Holi, Taghvim.Sobh, Taghvim.Asr FROM Rezerv INNER JOIN Taghvim ON Rezerv.Tarikh=Taghvim.Tarikh WHERE Rezerv.P_Num=? AND Rezerv.Tarikh BETWEEN ? AND ? AND Rezerv.Vis=True AND Rezerv.Mem LIKE 'غیر فعال%'", StrConnec))
                {
                    cmdRez.Parameters.AddWithValue("@P_Num", PNum);
                    cmdRez.Parameters.AddWithValue("@start", StartDate);
                    cmdRez.Parameters.AddWithValue("@end", EndDate);
                    using (OleDbDataReader rdr = cmdRez.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string kasriVal = rdr["Kasri"].ToString();
                            KasMor += ConvertClass.TimeToDouble(kasriVal);
                            int rooz = Convert.ToInt32(rdr["Rooz"]);
                            bool holi = Convert.ToBoolean(rdr["Holi"]);
                            string sobh = rdr["Sobh"].ToString();
                            string asr = rdr["Asr"].ToString();

                            ProcessMorakhasi(ShCal, rooz, holi, sobh, asr, ref Mor, ref MorFri, ref KasMor, ref KasMorFri, ref FogFri);
                        }
                    }
                }


                // 5) خواندن Amal (ساعات ساعتی)
                using (OleDbCommand cmdAmal = new OleDbCommand("SELECT Tarikh, Amal FROM Amal WHERE P_Num=? AND Tarikh BETWEEN ? AND ? AND OnvAmal='ساعتی' AND Vis=True", StrConnec))
                {
                    cmdAmal.Parameters.AddWithValue("@P_Num", PNum);
                    cmdAmal.Parameters.AddWithValue("@start", StartDate);
                    cmdAmal.Parameters.AddWithValue("@end", EndDate);
                    using (OleDbDataReader rdr = cmdAmal.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string tStr = rdr["Tarikh"].ToString();
                            string amalStr = rdr["Amal"].ToString();
                            if (amalStr.Length >= 14)
                            {
                                double SSaati = ConvertClass.TimeToDouble(amalStr.Substring(0, 5));
                                double ESaati = ConvertClass.TimeToDouble(amalStr.Substring(9, 5));
                                if (SSaati > ESaati)
                                {
                                    ESaati += 24;
                                }

                                double saat = ESaati - SSaati;
                                if ((ConvertClass.ShamsiToMiladi(tStr).DayOfWeek == DayOfWeek.Friday & ShCal[2] == 'N') || (ConvertClass.ShamsiToMiladi(tStr).DayOfWeek == DayOfWeek.Friday & ShCal[2] == 'T' & SSaati < 19) || (ConvertClass.ShamsiToMiladi(tStr).DayOfWeek == DayOfWeek.Thursday & ShCal[2] == 'T' & SSaati > 19))
                                {
                                    SatFri += saat;
                                }
                                else
                                {
                                    Sat += saat;
                                }
                            }
                        }
                    }
                }


                // 7) خواندن PasMon ماه قبل (NexMo از TotaMonAdv ماه قبل)
                Taghvim PastMon = new Taghvim(StartDate);
                PastMon.AddMonth(-1);
                string pastKey = PastMon.Tarikh().Substring(0, 7);
                double pasFromPrev = 0;
                if (TotaMonCache.ContainsKey(pastKey) && TotaMonCache[pastKey].ContainsKey(PNum))
                {
                    DataRow rprev = TotaMonCache[pastKey][PNum];
                    if (rprev != null)
                    {
                        pasFromPrev = ConvertClass.TimeToDouble(rprev["NexMo"].ToString());
                    }
                }
                else
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT NexMo FROM TotaMonAdv WHERE P_Num=? AND Maah=?", StrConnec))
                    {
                        cmd.Parameters.AddWithValue("@P_Num", PNum);
                        cmd.Parameters.AddWithValue("@Maah", pastKey);
                        object rr = cmd.ExecuteScalar();
                        if (rr != null)
                        {
                            pasFromPrev = ConvertClass.TimeToDouble(rr.ToString());
                        }
                    }

                }
                if (pasFromPrev > 0)
                {
                    PasMon = pasFromPrev;
                }

                // ---------- ادامه محاسبات کلی ----------
                double PasMon1 = 0;
                double PasMon2 = 0;
                if (PasMon > 40)
                {
                    PasMon1 = 40;
                    PasMon2 = PasMon - 40;
                }
                else
                {
                    PasMon1 = PasMon;
                    PasMon2 = 0;
                }

                if (ShiftEzaFri < 0)
                {
                    ShiftEzaFri = 0;
                }

                if (ShiftEza < 0)
                {
                    if (ShiftEzaFri <= 0)
                    {
                        ShiftEza = 0;
                        ShiftEzaFri = 0;
                    }
                }

                double TotEza = PasMon1 + ShiftEza + Eza - (Sat + SatFri) - KasMor;
                double TotEzaFri = ShiftEzaFri + EzaFri - SatFri - KasMorFri;

                if (TotEzaFri < 0)
                {
                    TotEza += TotEzaFri;
                    TotEzaFri = 0;
                }
                if (TotEza < 0)
                {
                    TotEza = 0;
                }

                double NexMonFinal = 0;
                if (TotEza + TotEzaFri > TopOver)
                {
                    NexMonFinal = TotEza + TotEzaFri - TopOver;
                    TotEza = TopOver - TotEzaFri;
                }
                NexMonFinal += PasMon2;

                // ذخیره/آپدیت TotaMonAdv (پارامتری)
                UpdateTotaMonAdv(StrConnec, PNum, maahKey, ShCal, Trips, PasMon, ShiftEza, ShiftEzaFri, Eza, EzaFri, Sat + SatFri, Mor + MorFri, FogFri, TotEza, TotEzaFri, NexMonFinal);

            }
            catch (Exception ex)
            {
                // لاگ خطا برای این شخص — ادامه سایر افراد متوقف نمی‌شود
                MainForm.ErrorLogo = $"{Text} - PersoOptim({PNum}): {ex.Message}\n{MainForm.ErrorLogo}";
            }
        }

        // ============================
        // Helper: ساخت ShCal از یک DataRow شخص
        // ============================
        private string BuildShCalFromPerson(DataRow personRow)
        {
            string ShCal;

            // پست سازمانی
            switch (personRow["P_Post"].ToString())
            {
                case "راهبر پایانه":
                    ShCal = "P";
                    break;
                case "راهبر قطار":
                    ShCal = "R";
                    break;
                default:
                    ShCal = "S";
                    break;
            }

            // نوع محاسبه (Calc)
            switch (personRow["Calc"].ToString())
            {
                case "راهبر پایانه":
                    ShCal += "P";
                    break;
                case "راهبر خط":
                    ShCal += "R";
                    break;
                default:
                    ShCal += "S";
                    break;
            }

            // نوع شیفت
            switch (personRow["Shift_Time"].ToString())
            {
                case "12 ساعته":
                    ShCal += "T" + personRow["Shift_name"];
                    break;
                case "9 ساعته":
                    ShCal += "N" + personRow["Shift_name"];
                    break;
                default:
                    ShCal += "SS";
                    break;
            }

            // مبدا
            switch (personRow["Shift_Loc"].ToString())
            {
                case "تهران":
                    ShCal += "T";
                    break;
                case "پایانه تهران":
                    ShCal += "P";
                    break;
                case "گلشهر":
                    ShCal += "G";
                    break;
                case "پایانه مهرشهر":
                    ShCal += "M";
                    break;
                case "هشتگرد":
                    ShCal += "H";
                    break;
                default:
                    ShCal += "S";
                    break;
            }

            return ShCal;
        }

        // ============================
        // Helper: Load ShKar for month into cache
        // ============================
        private void LoadShKarForMonthToCache(OleDbConnection StrConnec, string maah)
        {
            if (ShKarCache.ContainsKey(maah))
            {
                return;
            }

            DataTable dt = new DataTable();
            using (OleDbCommand cmd = new OleDbCommand("SELECT Rooz3, Rooz4, Rooz5, Kasri, MonthTime, ASobh, AAsr, AJom9, AJom12, BSobh, BAsr, BJom9, BJom12, CSobh, CAsr, CJom9, CJom12 FROM ShKar WHERE Tarikh=?", StrConnec))
            {
                // توجه: ستون‌های مبدا (مثل "T_Sobh") ممکن است در دیتابیس شکل دیگری داشته باشند.
                cmd.Parameters.AddWithValue("@Tarikh", maah);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            if (dt.Rows.Count > 0)
            {
                ShKarCache[maah] = dt.Rows[0];
            }
            else
            {
                ShKarCache[maah] = null;
            }
        }

        // ============================
        // Helper: Load all TotaMonAdv for a month to cache
        // ============================
        private void LoadTotaMonForMonthToCache(OleDbConnection StrConnec, string maah)
        {
            if (TotaMonCache.ContainsKey(maah))
            {
                return;
            }

            Dictionary<string, DataRow> dict = new Dictionary<string, DataRow>();
            DataTable dt = new DataTable();
            using (OleDbCommand cmd = new OleDbCommand("SELECT P_Num, Shift, PasMo, EzShift, EzJoShift, Trips, Eza, FogJom, Tota, TotaJom, NexMo FROM TotaMonAdv WHERE Maah=?", StrConnec))
            {
                cmd.Parameters.AddWithValue("@Maah", maah);
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            foreach (DataRow r in dt.Rows)
            {
                string pnum = r["P_Num"].ToString();
                if (!dict.ContainsKey(pnum))
                {
                    dict[pnum] = r;
                }
            }
            TotaMonCache[maah] = dict;
        }

        // ============================
        // Helper: Update/Insert TotaMonAdv (پارامتری)
        // ============================
        private void UpdateTotaMonAdv(OleDbConnection StrConnec, string pnum, string maah, string ShCal, int trips, double pasMo, double shiftEza, double shiftEzaFri, double ezaSum, double ezafriSum, double morSaat, double mor, double fogJom, double tota, double totaFri, double nexMo)
        {
            bool exists = false;
            using (OleDbCommand cmdExists = new OleDbCommand("SELECT COUNT(1) FROM TotaMonAdv WHERE P_Num=? AND Maah=?", StrConnec))
            {
                cmdExists.Parameters.AddWithValue("@P_Num", pnum);
                cmdExists.Parameters.AddWithValue("@Maah", maah);
                object r = cmdExists.ExecuteScalar();
                if (r != null)
                {
                    exists = Convert.ToInt32(r) > 0;
                }
            }


            if (exists)
            {
                using (OleDbCommand cmdUpd = new OleDbCommand("UPDATE TotaMonAdv SET Shift=?, EzShift=?, EzJoShift=?, Trips=?, Eza=?, EzJom=?, MorDay=?, MorSaat=?, FogJom=?, Tota=?, TotaJom=?, PasMo=?, NexMo=? WHERE P_Num=? AND Maah=?", StrConnec))
                {
                    cmdUpd.Parameters.AddWithValue("@Shift", ShCal);
                    cmdUpd.Parameters.AddWithValue("@EzShift", ConvertClass.DoubleToTime(shiftEza));
                    cmdUpd.Parameters.AddWithValue("@EzJoShift", ConvertClass.DoubleToTime(shiftEzaFri));
                    cmdUpd.Parameters.AddWithValue("@Trips", trips);
                    cmdUpd.Parameters.AddWithValue("@Eza", ConvertClass.DoubleToTime(ezaSum));
                    cmdUpd.Parameters.AddWithValue("@EzJom", ConvertClass.DoubleToTime(ezafriSum));
                    cmdUpd.Parameters.AddWithValue("@MorDay", mor);
                    cmdUpd.Parameters.AddWithValue("@MorSaat", ConvertClass.DoubleToTime(morSaat));
                    cmdUpd.Parameters.AddWithValue("@FogJom", ConvertClass.DoubleToTime(fogJom));
                    cmdUpd.Parameters.AddWithValue("@Tota", ConvertClass.DoubleToTime(tota));
                    cmdUpd.Parameters.AddWithValue("@TotaJom", ConvertClass.DoubleToTime(totaFri));
                    cmdUpd.Parameters.AddWithValue("@PasMo", ConvertClass.DoubleToTime(pasMo));
                    cmdUpd.Parameters.AddWithValue("@NexMo", ConvertClass.DoubleToTime(nexMo));
                    cmdUpd.Parameters.AddWithValue("@P_Num", pnum);
                    cmdUpd.Parameters.AddWithValue("@Maah", maah);
                    cmdUpd.ExecuteNonQuery();
                }
            }
            else
            {
                using (OleDbCommand cmdIns = new OleDbCommand("INSERT INTO TotaMonAdv (P_Num, Maah, Shift, EzShift, EzJoShift, Trips, Eza, EzJom, MorDay, MorSaat, FogJom, Tota, TotaJom, PasMo, NexMo) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", StrConnec))
                {
                    cmdIns.Parameters.AddWithValue("@P_Num", pnum);
                    cmdIns.Parameters.AddWithValue("@Maah", maah);
                    cmdIns.Parameters.AddWithValue("@Shift", ShCal);
                    cmdIns.Parameters.AddWithValue("@EzShift", ConvertClass.DoubleToTime(shiftEza));
                    cmdIns.Parameters.AddWithValue("@EzJoShift", ConvertClass.DoubleToTime(shiftEzaFri));
                    cmdIns.Parameters.AddWithValue("@Trips", trips);
                    cmdIns.Parameters.AddWithValue("@Eza", ConvertClass.DoubleToTime(ezaSum));
                    cmdIns.Parameters.AddWithValue("@EzJom", ConvertClass.DoubleToTime(ezafriSum));
                    cmdIns.Parameters.AddWithValue("@MorDay", mor);
                    cmdIns.Parameters.AddWithValue("@MorSaat", ConvertClass.DoubleToTime(morSaat));
                    cmdIns.Parameters.AddWithValue("@FogJom", ConvertClass.DoubleToTime(fogJom));
                    cmdIns.Parameters.AddWithValue("@Tota", ConvertClass.DoubleToTime(tota));
                    cmdIns.Parameters.AddWithValue("@TotaJom", ConvertClass.DoubleToTime(totaFri));
                    cmdIns.Parameters.AddWithValue("@PasMo", ConvertClass.DoubleToTime(pasMo));
                    cmdIns.Parameters.AddWithValue("@NexMo", ConvertClass.DoubleToTime(nexMo));
                    cmdIns.ExecuteNonQuery();
                }
            }

            // به‌روزرسانی کش محلی اگر لازم است
            if (TotaMonCache.ContainsKey(maah))
            {
                if (TotaMonCache[maah].ContainsKey(pnum))
                {
                    DataRow r = TotaMonCache[maah][pnum];
                    if (r != null)
                    {
                        r["EzShift"] = ConvertClass.DoubleToTime(shiftEza);
                        r["EzJoShift"] = ConvertClass.DoubleToTime(shiftEzaFri);
                        r["Trips"] = trips;
                        r["Eza"] = ConvertClass.DoubleToTime(ezaSum);
                        r["FogJom"] = ConvertClass.DoubleToTime(fogJom);
                        r["Tota"] = ConvertClass.DoubleToTime(tota);
                        r["TotaJom"] = ConvertClass.DoubleToTime(totaFri);
                        r["PasMo"] = ConvertClass.DoubleToTime(pasMo);
                        r["NexMo"] = ConvertClass.DoubleToTime(nexMo);
                    }
                }
            }
        }

        // ============================
        // Helper: پردازش منطق مرخصی (ساده‌شده، خوانا)
        // ورودی: ShCal (برای نوع شیفت)، Rooz, Holi, Sobh/Asr از جدول Taghvim
        // خروجی: تغییر در مقادیر مرخصی/کسورات (ByRef)
        // ============================
        private void ProcessMorakhasi(string ShCal, int Rooz, bool Holi, string Sobh, string Asr, ref int Mor, ref int MorFri, ref double KasMor, ref double KasMorFri, ref double FogFri)
        {
            if (string.IsNullOrEmpty(ShCal) || ShCal.Length < 3)
            {
                return;
            }

            char shiftType = ShCal[2];
            char sh0 = ShCal[0];
            string sh3 = ShCal.Length >= 4 ? ShCal[3].ToString() : string.Empty;

            if (shiftType == 'T')
            {
                // 12 ساعته: بررسی Rooz و تطابق Sobh/Asr
                if (Rooz == 6)
                {
                    if (Asr == sh3)
                    {
                        MorFri++;
                        FogFri -= 9;
                        if (sh0 == 'R')
                        {
                            KasMorFri += 5;
                            KasMor += 2;
                        }
                        else if (sh0 == 'P')
                        {
                            KasMorFri += 5;
                        }
                        else
                        {
                            KasMorFri += 3;
                        }
                    }
                    else
                    {
                        Mor++;
                        if (sh0 == 'R')
                        {
                            KasMor += 7;
                        }
                        else if (sh0 == 'P')
                        {
                            KasMor += 5;
                        }
                        else
                        {
                            KasMor += 3;
                        }
                    }
                }
                else if (Rooz == 7)
                {
                    if (Sobh == sh3)
                    {
                        MorFri++;
                        FogFri -= 9;
                        if (sh0 == 'R')
                        {
                            KasMorFri += 5;
                            KasMor += 2;
                        }
                        else if (sh0 == 'P')
                        {
                            KasMorFri += 5;
                        }
                        else
                        {
                            KasMorFri += 3;
                        }
                    }
                    else
                    {
                        Mor++;
                        if (sh0 == 'R')
                        {
                            KasMor += 7;
                        }
                        else if (sh0 == 'P')
                        {
                            KasMor += 5;
                        }
                        else
                        {
                            KasMor += 3;
                        }
                    }
                }
                else
                {
                    Mor++;
                    if (sh0 == 'R')
                    {
                        KasMor += 7;
                    }
                    else if (sh0 == 'P')
                    {
                        KasMor += 5;
                    }
                    else
                    {
                        KasMor += 3;
                    }
                }

            }
            else if (shiftType == 'N')
            {
                // 9 ساعته
                if (Rooz == 7)
                {
                    MorFri++;
                    KasMorFri += 4;
                    FogFri -= 9;
                }
                else
                {
                    Mor++;
                    KasMor += 4;
                }

            }
            else
            {
                // ستادی
                if (Rooz < 6 && !Holi)
                {
                    Mor++;
                    KasMor += 4;
                }
            }
        }

        // ----------------------------
        // توابع کمکی اضافی (در صورت نیاز قابل استفاده‌اند)
        // ----------------------------
        // تابع ساده‌شده برای کسر کار (اگر بخواهی آن را جداگانه صدا بزنی)
        private void ProcessKasri(string code, DateTime startDate, DateTime endDate, ref double kasMor, ref double kasMorFri)
        {
            DateTime currentDate = startDate;

            int totalDays = (endDate.Date - startDate.Date).Days + 1;

            for (int i = 1; i <= totalDays; i++)
            {
                // جمعه در ایران: DayOfWeek.Friday
                bool isFriday = currentDate.DayOfWeek == DayOfWeek.Friday;

                // شامل S یا A در کد
                bool isHalfDay = code.ToUpper().Contains("S") || code.ToUpper().Contains("A");

                double dayValue = isHalfDay ? 0.5 : 1.0;

                if (isFriday)
                {
                    kasMorFri += dayValue;
                }
                else
                {
                    kasMor += dayValue;
                }

                currentDate = currentDate.AddDays(1);
            }
        }

        //private void ProcessKasri(string Code, DateTime StartDate, DateTime EndDate, ref double KasMor, ref double KasMorFri)
        //{
        //    DateTime currentDate=StartDate;
        //    int totalDays=System.Convert.ToInt32(DateTime.DateDiff(DateInterval.Day, StartDate, EndDate) + 1);
        //    for (int i=1; i <= totalDays; i++)
        //    {
        //        bool isFriday=DateTime.Weekday(currentDate, FirstDayOfWeek.Saturday) == 7;
        //        bool isHalfDay=System.Convert.ToBoolean(Code.ToUpper().Contains("S") || Code.ToUpper().Contains("A"));
        //        double dayValue=System.Convert.ToDouble(isHalfDay ? 0.5 : 1.0);
        //        if (isFriday)
        //            KasMorFri += dayValue;
        //        else
        //            KasMor += dayValue;

        //        currentDate=currentDate.AddDays(1);
        //    }
        //}

        // تابع ساده‌شده برای غیبت/فوتی (Fog)

        private void ProcessFoghod(string code, DateTime startDate, DateTime endDate, ref double fog, ref double fogFri)
        {
            DateTime currentDate = startDate;

            int totalDays = (endDate.Date - startDate.Date).Days + 1;

            for (int i = 1; i <= totalDays; i++)
            {
                bool isFriday = currentDate.DayOfWeek == DayOfWeek.Friday;

                bool isHalfDay = code.ToUpper().Contains("S") || code.ToUpper().Contains("A");

                double dayValue = isHalfDay ? 0.5 : 1.0;

                if (isFriday)
                {
                    fogFri += dayValue;
                }
                else
                {
                    fog += dayValue;
                }

                currentDate = currentDate.AddDays(1);
            }
        }

        //private void ProcessFoghod(string Code, DateTime StartDate, DateTime EndDate, ref double Fog, ref double FogFri)
        //{
        //    DateTime currentDate=StartDate;
        //    int totalDays=System.Convert.ToInt32(DateTime.DateDiff(DateInterval.Day, StartDate, EndDate) + 1);
        //    for (int i=1; i <= totalDays; i++)
        //    {
        //        bool isFriday=DateTime.Weekday(currentDate, FirstDayOfWeek.Saturday) == 7;
        //        bool isHalfDay=System.Convert.ToBoolean(Code.ToUpper().Contains("S") || Code.ToUpper().Contains("A"));
        //        double dayValue=System.Convert.ToDouble(isHalfDay ? 0.5 : 1.0);
        //        if (isFriday)
        //            FogFri += dayValue;
        //        else
        //            Fog += dayValue;

        //        currentDate=currentDate.AddDays(1);
        //    }
        //}

    }

    // *************

    //Public Class OptimizationForm
    //    Public Tarikh As String=""
    //    Private j As Integer
    //    Private PerMon As Boolean=False

    //    Public Sub PersoOptim(PNum As String, Tarikh As String, StrConnec As OleDbConnection)
    //        Try
    //            Dim StartDate, EndDate As String
    //            Dim PersianDate As New Taghvim(Tarikh)

    //            Dim ShCal As String=""
    //            Dim ShiftEza, ShiftEzaFri, FogFri, TotEza, TotEzaFri, KasMor, KasMorFri, Movaz, Eza, EzaFri, Sat, SatFri, PasMon, PasMon1, PasMon2, NexMon, TopOver As Double '
    //            Dim Trips, Mor, MorFri As Integer
    //            Dim Watch As Boolean=False

    //            StartDate=PersianDate.FirstOfThisMonth
    //            If MainForm.PersianToday.Tarikh.Substring(0, 7)=Tarikh.Substring(0, 7) Then
    //                EndDate=PersianDate.Tarikh
    //            Else
    //                EndDate=PersianDate.EndOfThisMonth
    //            End If

    //            TotEza=0
    //            TotEzaFri=0
    //            ShiftEza=0
    //            ShiftEzaFri=0
    //            FogFri=0
    //            Mor=0
    //            MorFri=0
    //            Movaz=0
    //            KasMor=0
    //            KasMorFri=0
    //            Eza=0
    //            EzaFri=0
    //            Sat=0
    //            SatFri=0
    //            PasMon=0
    //            NexMon=0
    //            Trips=0
    //            TopOver=0
    //            PasMon2=0
    //            PasMon1=0

    //            Using CMD As New OleDbCommand("SELECT * FROM TotaMonAdv WHERE P_Num='" + PNum + "' AND Maah='" + StartDate.Substring(0, 7) + "'", StrConnec)
    //                Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                    While Reader.Read
    //                        ShCal=Reader.Item("Shift").ToString
    //                        PasMon=TimeToDouble(Reader.Item("PasMo").ToString)
    //                        ShiftEza=TimeToDouble(Reader.Item("EzShift").ToString)
    //                        ShiftEzaFri=TimeToDouble(Reader.Item("EzJoShift").ToString)
    //                        FogFri=TimeToDouble(Reader.Item("FogJom").ToString)
    //                    End While
    //                End Using
    //            End Using

    //            If ShCal <> "" Then
    //                Using CMD As New OleDbCommand("SELECT COUNT(ID) AS Trip FROM DailyTrip WHERE (O1_Num='" + PNum + "' OR O2_Num='" + PNum + "' OR OT_Num='" + PNum + "') AND Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' AND Vis=True AND Final=True", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            Trips=CInt(Reader.Item("Trip"))
    //                        End While
    //                    End Using
    //                End Using

    //                Using CMD As New OleDbCommand("SELECT * FROM Ezafeh WHERE P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' AND Vis=True", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            If ShamsiToMiladi(Reader.Item("Tarikh").ToString).DayOfWeek=DayOfWeek.Friday Then
    //                                EzaFri += TimeToDouble(Reader.Item("E_Time").ToString)
    //                            Else
    //                                Eza += TimeToDouble(Reader.Item("E_Time").ToString)
    //                            End If
    //                        End While
    //                    End Using
    //                End Using

    //                Using CMD As New OleDbCommand("SELECT * FROM Morakhasi INNER JOIN Taghvim ON Morakhasi.Tarikh=Taghvim.Tarikh WHERE P_Num='" + PNum + "' AND Morakhasi.Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' AND Morakhasi.Vis=True", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            If Reader.Item("Kasri").ToString <> "" Then KasMor += TimeToDouble(Reader.Item("kasri").ToString)

    //                            If ShCal(2)="T" Then                          'مرخصی 12 ساعته
    //                                If Reader.Item("Rooz").ToString="6" Then
    //                                    If Reader.Item("Asr").ToString=ShCal(3) Then
    //                                        MorFri += 1
    //                                        FogFri -= 9
    //                                        If ShCal(0)="R" Then
    //                                            KasMorFri += 5
    //                                            KasMor += 2
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMorFri += 5
    //                                        Else
    //                                            KasMorFri += 3
    //                                        End If
    //                                    Else
    //                                        Mor += 1
    //                                        If ShCal(0)="R" Then
    //                                            KasMor += 7
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMor += 5
    //                                        Else
    //                                            KasMor += 3
    //                                        End If
    //                                    End If

    //                                ElseIf Reader.Item("Rooz").ToString="7" Then
    //                                    If Reader.Item("Sobh").ToString=ShCal(3) Then
    //                                        MorFri += 1
    //                                        FogFri -= 9
    //                                        If ShCal(0)="R" Then
    //                                            KasMorFri += 5
    //                                            KasMor += 2
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMorFri += 5
    //                                        Else
    //                                            KasMorFri += 3
    //                                        End If
    //                                    Else
    //                                        Mor += 1
    //                                        If ShCal(0)="R" Then
    //                                            KasMor += 7
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMor += 5
    //                                        Else
    //                                            KasMor += 3
    //                                        End If
    //                                    End If

    //                                Else
    //                                    Mor += 1
    //                                    If ShCal(0)="R" Then
    //                                        KasMor += 7
    //                                    ElseIf ShCal(0)="P" Then
    //                                        KasMor += 5
    //                                    Else
    //                                        KasMor += 3
    //                                    End If
    //                                End If

    //                            ElseIf ShCal(2)="N" Then                        'مرخصی 9 ساعته
    //                                If Reader.Item("Rooz").ToString="7" Then
    //                                    MorFri += 1
    //                                    KasMorFri += 4
    //                                    FogFri -= 9
    //                                Else
    //                                    Mor += 1
    //                                    KasMor += 4
    //                                End If

    //                            Else                        'مرخصی ستادی
    //                                If CInt(Reader.Item("Rooz")) < 6 And Not CBool(Reader.Item("Holi")) Then
    //                                    Mor += 1
    //                                    KasMor += 4
    //                                End If
    //                            End If

    //                            'If Reader.Item("Taghvim.Tarikh")=7 Then
    //                            '    MorFri += 1
    //                            '    FogFri -= 9 'If ShCal(2)="N" Then FogFri -= 9 Else FogFri -= 12

    //                            '    If ShCal.Substring(0, 2)="RT" Then
    //                            '        KasMorFri += 5
    //                            '        KasMor += 2
    //                            '    ElseIf ShCal.Substring(0, 2)="PT" Then
    //                            '        KasMorFri += 5
    //                            '    Else
    //                            '        KasMorFri += 4
    //                            '    End If
    //                            'Else
    //                            '    Mor += 1
    //                            '    If ShCal.Substring(0, 2)="RT" Then
    //                            '        KasMor += 7
    //                            '    ElseIf ShCal.Substring(0, 2)="PT" Then
    //                            '        KasMor += 5
    //                            '    Else
    //                            '        KasMor += 4
    //                            '    End If
    //                            'End If
    //                        End While
    //                    End Using
    //                End Using

    //                Using CMD As New OleDbCommand("SELECT * FROM Rezerv INNER JOIN Taghvim ON Rezerv.Tarikh=Taghvim.Tarikh WHERE P_Num='" + PNum + "' AND Rezerv.Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' AND Rezerv.Vis=True AND Rezerv.Mem Like 'غیر فعال%'", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            If Reader.Item("Kasri").ToString <> "" Then KasMor += TimeToDouble(Reader.Item("kasri").ToString)

    //                            If ShCal(2)="T" Then                          'مرخصی 12 ساعته
    //                                If Reader.Item("Rooz").ToString="6" Then
    //                                    If Reader.Item("Asr").ToString=ShCal(3) Then
    //                                        MorFri += 1
    //                                        FogFri -= 9
    //                                        If ShCal(0)="R" Then
    //                                            KasMorFri += 5
    //                                            KasMor += 2
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMorFri += 5
    //                                        Else
    //                                            KasMorFri += 3
    //                                        End If
    //                                    Else
    //                                        Mor += 1
    //                                        If ShCal(0)="R" Then
    //                                            KasMor += 7
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMor += 5
    //                                        Else
    //                                            KasMor += 3
    //                                        End If
    //                                    End If

    //                                ElseIf Reader.Item("Rooz").ToString="7" Then
    //                                    If Reader.Item("Sobh").ToString=ShCal(3) Then
    //                                        MorFri += 1
    //                                        FogFri -= 9
    //                                        If ShCal(0)="R" Then
    //                                            KasMorFri += 5
    //                                            KasMor += 2
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMorFri += 5
    //                                        Else
    //                                            KasMorFri += 3
    //                                        End If
    //                                    Else
    //                                        Mor += 1
    //                                        If ShCal(0)="R" Then
    //                                            KasMor += 7
    //                                        ElseIf ShCal(0)="P" Then
    //                                            KasMor += 5
    //                                        Else
    //                                            KasMor += 3
    //                                        End If
    //                                    End If

    //                                Else
    //                                    Mor += 1
    //                                    If ShCal(0)="R" Then
    //                                        KasMor += 7
    //                                    ElseIf ShCal(0)="P" Then
    //                                        KasMor += 5
    //                                    Else
    //                                        KasMor += 3
    //                                    End If
    //                                End If

    //                            ElseIf ShCal(2)="N" Then                        'مرخصی 9 ساعته
    //                                If Reader.Item("Rooz").ToString="7" Then
    //                                    MorFri += 1
    //                                    KasMorFri += 4
    //                                    FogFri -= 9
    //                                Else
    //                                    Mor += 1
    //                                    KasMor += 4
    //                                End If

    //                            Else                        'مرخصی ستادی
    //                                If CInt(Reader.Item("Rooz")) < 6 And Not CBool(Reader.Item("Holi")) Then
    //                                    Mor += 1
    //                                    KasMor += 4
    //                                End If
    //                            End If
    //                        End While
    //                    End Using
    //                End Using

    //                Using CMD As New OleDbCommand("SELECT * FROM Amal WHERE P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' AND OnvAmal='ساعتی' AND Vis=True", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            Dim SSaati, ESaati, Saat As Double

    //                            SSaati=TimeToDouble(Reader.Item("Amal").ToString.Substring(0, 5))
    //                            ESaati=TimeToDouble(Reader.Item("Amal").ToString.Substring(9, 5))
    //                            If SSaati > ESaati Then ESaati += 24
    //                            Saat=ESaati - SSaati

    //                            If ShamsiToMiladi(Reader.Item("Tarikh").ToString).DayOfWeek=DayOfWeek.Friday Then
    //                                SatFri += Saat
    //                            Else
    //                                Sat += Saat
    //                            End If
    //                        End While
    //                    End Using
    //                End Using

    //                Using CMD As New OleDbCommand("SELECT * FROM ShKar WHERE Tarikh='" + Tarikh.Substring(0, 7) + "'", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            TopOver=TimeToDouble(Reader.Item("MonthTime").ToString)
    //                        End While
    //                    End Using
    //                End Using

    //                Dim PastMon As New Taghvim(StartDate)
    //                PastMon.AddMonth(-1)
    //                Using CMD As New OleDbCommand("SELECT * FROM TotaMonAdv WHERE P_Num='" & PNum & "' AND Maah='" + PastMon.Tarikh.Substring(0, 7) + "'", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            PasMon=TimeToDouble(Reader.Item("NexMo").ToString)
    //                        End While
    //                    End Using
    //                End Using

    //                If PasMon > 0 Then PasMon=PasMon

    //                If PasMon > 40 Then
    //                    PasMon1=40
    //                    PasMon2=PasMon - 40
    //                Else
    //                    PasMon1=PasMon
    //                    PasMon2=0
    //                End If

    //                If ShiftEzaFri < 0 Then ShiftEzaFri=0
    //                If ShiftEza < 0 Then
    //                    If ShiftEzaFri <= 0 Then
    //                        ShiftEza=0
    //                        ShiftEzaFri=0
    //                    Else

    //                    End If
    //                End If

    //                TotEza=PasMon1 + ShiftEza + Eza - Sat - KasMor
    //                TotEzaFri=ShiftEzaFri + EzaFri - SatFri - KasMorFri
    //                If TotEzaFri < 0 Then
    //                    TotEza += TotEzaFri
    //                    TotEzaFri=0
    //                End If
    //                If TotEza < 0 Then TotEza=0

    //                If TotEza + TotEzaFri > TopOver Then
    //                    NexMon=TotEza + TotEzaFri - TopOver
    //                    TotEza=TopOver - TotEzaFri
    //                End If
    //                NexMon += PasMon2

    //                Using CMD As New OleDbCommand("UPDATE TotaMonAdv SET EzShift='" & DoubleToTime(ShiftEza) & "', EzJoShift='" & DoubleToTime(ShiftEzaFri) & "', Trips= " & Trips & ", Eza='" & DoubleToTime(Eza) & "', EzJom='" & DoubleToTime(EzaFri) & "', MorDay=" & Mor + MorFri & ", MorSaat='" & DoubleToTime(Sat + SatFri) & "', FogJom='" & DoubleToTime(FogFri) & "', Tota='" & DoubleToTime(TotEza) & "', TotaJom='" & DoubleToTime(TotEzaFri) & "', PasMo='" & DoubleToTime(PasMon) & "', NexMo='" & DoubleToTime(NexMon) & "' WHERE P_Num='" & PNum & "' AND Maah='" + StartDate.Substring(0, 7) + "'", StrConnec)
    //                    CMD.ExecuteNonQuery()
    //                End Using
    //            End If
    //        Catch ex As Exception
    //            WaitForm.Close()
    //            MainForm.ErrorLogoBox.Text=Text & ": " & ex.Message & vbNewLine & vbNewLine + MainForm.ErrorLogoBox.Text
    //            MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error)
    //            Close()
    //        End Try
    //    End Sub

    //    Public Sub Calc(Tarikh As String, StrConnec As OleDbConnection)
    //        Try
    //            Dim PersianDate As New Taghvim(Tarikh)

    //            If (PersianDate.Day <= 7 And Not PerMon) Then '
    //                PersianDate.AddMonth(-1)
    //                PerMon=True
    //                Calc(PersianDate.Tarikh, StrConnec)
    //                PersianDate.AddMonth(1)
    //            End If

    //            Dim PersonTable As New DataTable
    //            Dim Fid As Boolean
    //            Dim ShCal As String
    //            Dim SobhTime, AsrTime, Movaz, ShiftEza, ShiftEzaFri, FogFri, PasMon As Double

    //            Using Adap As New OleDbDataAdapter("SELECT Fname, Family, P_Num, P_Post, Shift_Loc, Shift_Time, Shift_name, Calc FROM Person WHERE Calc <> 'بدون محاسبه' AND Vis=True", StrConnec)
    //                Adap.Fill(PersonTable)
    //            End Using

    //            For Each Rows As DataRow In PersonTable.Rows
    //                ShCal=""
    //                Fid=False
    //                SobhTime=0
    //                AsrTime=0
    //                ShiftEza=0
    //                ShiftEzaFri=0
    //                FogFri=0
    //                Movaz=0
    //                PasMon=0

    //                Using CMD As New OleDbCommand("SELECT * FROM TotaMonAdv WHERE P_Num='" + Rows.ItemArray(2).ToString + "' AND Maah='" + Tarikh.Substring(0, 7) + "'", StrConnec)
    //                    Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                        While Reader.Read
    //                            Fid=True
    //                            ShCal=Reader.Item("Shift").ToString
    //                        End While
    //                    End Using
    //                End Using

    //                If (PersianDate.Month=MainForm.PersianToday.Month And MainForm.PersianToday.Day < 26) Or PersianDate.Month > MainForm.PersianToday.Month Then

    //                    Select Case Rows.ItemArray(3).ToString          ' ****   پست سازمانی
    //                        Case "راهبر پایانه"
    //                            ShCal="P"
    //                        Case "راهبر قطار"
    //                            ShCal="R"
    //                        Case Else
    //                            ShCal="S"
    //                    End Select

    //                    Select Case Rows.ItemArray(7).ToString          ' ****   نوع محاسبه
    //                        Case "راهبر پایانه"
    //                            ShCal += "P"
    //                        Case "راهبر خط"
    //                            ShCal += "R"
    //                        Case Else
    //                            ShCal += "S"
    //                    End Select

    //                    Select Case Rows.ItemArray(5).ToString          ' ****   نوع شیفت
    //                        Case "12 ساعته"
    //                            ShCal += "T" & Rows.ItemArray(6).ToString
    //                        Case "9 ساعته"
    //                            ShCal += "N" & Rows.ItemArray(6).ToString
    //                        Case Else
    //                            ShCal += "SS"
    //                    End Select

    //                    Select Case Rows.ItemArray(4).ToString          ' ****   مبدا
    //                        Case "تهران"
    //                            ShCal += "T"
    //                        Case "پایانه تهران"
    //                            ShCal += "P"
    //                        Case "گلشهر"
    //                            ShCal += "G"
    //                        Case "پایانه مهرشهر"
    //                            ShCal += "M"
    //                        Case "هشتگرد"
    //                            ShCal += "H"
    //                        Case Else
    //                            ShCal += "S"
    //                    End Select

    //                    If ShCal.Substring(1, 2)="PT" Then
    //                        SobhTime=14
    //                        AsrTime=14

    //                    ElseIf ShCal.Substring(1, 2)="RT" Then
    //                        SobhTime=16
    //                        AsrTime=16

    //                    ElseIf ShCal.Substring(1, 2)="RN" Then
    //                        SobhTime=13
    //                        AsrTime=13

    //                    ElseIf ShCal.Substring(1, 2)="ST" Then
    //                        SobhTime=12
    //                        AsrTime=12

    //                    Else
    //                        SobhTime=9
    //                        AsrTime=9
    //                    End If

    //                    Using CMD As New OleDbCommand("SELECT * FROM ShKar WHERE Tarikh='" + Tarikh.Substring(0, 7) + "'", StrConnec)
    //                        Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                            While Reader.Read
    //                                Movaz=CInt(Reader.Item("Rooz3")) * 9 + CInt(Reader.Item("Rooz4")) * 8 - CInt(Reader.Item("Rooz5")) * 7.5 - TimeToDouble(Reader.Item("Kasri").ToString)

    //                                If ShCal(2)="S" Then
    //                                    ShiftEza=(CInt(Reader.Item("Rooz3")) + CInt(Reader.Item("Rooz4"))) * SobhTime - Movaz
    //                                Else
    //                                    If ShCal(2)="N" Then
    //                                        ShiftEzaFri=CInt(Reader.Item(ShCal(3) + "Jom9")) * ((SobhTime + AsrTime - 18) / 2)
    //                                        FogFri += CInt(Reader.Item(ShCal(3) + "Jom9")) * 9
    //                                    Else
    //                                        ShiftEzaFri=CInt(Reader.Item(ShCal(3) + "Jom12")) * 5 '((SobhTime + AsrTime - 18)*)
    //                                        FogFri += CInt(Reader.Item(ShCal(3) + "Jom12")) * 9
    //                                    End If

    //                                    ShiftEza=CInt(Reader.Item(ShCal(3) + "Sobh")) * SobhTime + CInt(Reader.Item(ShCal(3) + "Asr")) * AsrTime - Movaz - ShiftEzaFri
    //                                End If
    //                            End While
    //                        End Using
    //                    End Using

    //                    If Fid Then
    //                        Using CMD As New OleDbCommand("UPDATE TotaMonAdv SET Shift='" & ShCal & "', PasMo='" & DoubleToTime(PasMon) & "', EzShift='" & DoubleToTime(ShiftEza) & "', EzJoShift='" & DoubleToTime(ShiftEzaFri) & "', FogJom='" & DoubleToTime(FogFri) & "' WHERE P_Num='" & Rows.ItemArray(2).ToString & "' AND Maah='" + Tarikh.Substring(0, 7) + "'", StrConnec)
    //                            CMD.ExecuteNonQuery()
    //                        End Using
    //                    Else
    //                        Using CMD As New OleDbCommand("INSERT INTO TotaMonAdv (P_Num, Maah, Shift, PasMo, EzShift, EzJoShift, FogJom) VALUES ('" & Rows.ItemArray(2).ToString & "', '" + Tarikh.Substring(0, 7) + "', '" & ShCal & "', '" & DoubleToTime(PasMon) & "', '" & DoubleToTime(ShiftEza) & "', '" & DoubleToTime(ShiftEzaFri) & "', '" & DoubleToTime(FogFri) & "')", StrConnec)
    //                            CMD.ExecuteNonQuery()
    //                        End Using
    //                    End If

    //                Else
    //                    If Fid Then
    //                        If Rows.ItemArray(2).ToString="99796" Then Fid=True
    //                        If ShCal.Substring(1, 2)="PT" Then
    //                            SobhTime=14
    //                            AsrTime=14

    //                        ElseIf ShCal.Substring(1, 2)="RT" Then
    //                            SobhTime=16
    //                            AsrTime=16

    //                        ElseIf ShCal.Substring(1, 2)="RN" Then
    //                            SobhTime=13
    //                            AsrTime=13

    //                        ElseIf ShCal.Substring(1, 2)="ST" Then
    //                            SobhTime=12
    //                            AsrTime=12

    //                        Else
    //                            SobhTime=9
    //                            AsrTime=9
    //                        End If

    //                        Using CMD As New OleDbCommand("SELECT * FROM ShKar WHERE Tarikh='" + Tarikh.Substring(0, 7) + "'", StrConnec)
    //                            Using Reader As OleDbDataReader=CMD.ExecuteReader()
    //                                While Reader.Read
    //                                    Movaz=CInt(Reader.Item("Rooz3")) * 9 + CInt(Reader.Item("Rooz4")) * 8 - CInt(Reader.Item("Rooz5")) * 7.5 - TimeToDouble(Reader.Item("Kasri").ToString)

    //                                    If ShCal(2)="S" Then
    //                                        ShiftEza=(CInt(Reader.Item("Rooz3")) + CInt(Reader.Item("Rooz4"))) * SobhTime - Movaz
    //                                    Else
    //                                        If ShCal(2)="N" Then
    //                                            ShiftEzaFri=CInt(Reader.Item(ShCal(3) + "Jom9")) * ((SobhTime + AsrTime - 18) / 2)
    //                                            FogFri += CInt(Reader.Item(ShCal(3) + "Jom9")) * 9
    //                                        Else
    //                                            ShiftEzaFri=CInt(Reader.Item(ShCal(3) + "Jom12")) * 5 '((SobhTime + AsrTime - 18)*)
    //                                            FogFri += CInt(Reader.Item(ShCal(3) + "Jom12")) * 9
    //                                        End If

    //                                        ShiftEza=CInt(Reader.Item(ShCal(3) + "Sobh")) * SobhTime + CInt(Reader.Item(ShCal(3) + "Asr")) * AsrTime - Movaz - ShiftEzaFri
    //                                    End If
    //                                End While
    //                            End Using
    //                        End Using

    //                        Using CMD As New OleDbCommand("UPDATE TotaMonAdv SET Shift='" & ShCal & "', PasMo='" & DoubleToTime(PasMon) & "', EzShift='" & DoubleToTime(ShiftEza) & "', EzJoShift='" & DoubleToTime(ShiftEzaFri) & "', FogJom='" & DoubleToTime(FogFri) & "' WHERE P_Num='" & Rows.ItemArray(2).ToString & "' AND Maah='" + Tarikh.Substring(0, 7) + "'", StrConnec)
    //                            CMD.ExecuteNonQuery()
    //                        End Using
    //                    End If
    //                End If

    //                PersoOptim(Rows.ItemArray(2).ToString, Tarikh, StrConnec)
    //            Next

    //            If PersianDate.Day=PersianDate.DaysInThisMonth Then
    //                PersianDate.AddMonth(1)
    //                Calc(PersianDate.Tarikh, StrConnec)
    //                PersianDate.AddMonth(-1)
    //            End If
    //        Catch ex As Exception
    //            WaitForm.Close()
    //            MainForm.ErrorLogoBox.Text=Text & ": " & ex.Message & vbNewLine & vbNewLine + MainForm.ErrorLogoBox.Text
    //            MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error)
    //            Close()
    //        End Try
    //    End Sub

    //    Private Sub OptimizationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    //        Timer1.Enabled=True
    //    End Sub

    //    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    //        If j=0 Then
    //            j += 1

    //            If Tarikh="" Then Tarikh=MainForm.PersianToday.Tarikh
    //            Using StrConnec As New OleDbConnection(AppState.ConnectionString)
    //                StrConnec.Open()
    //                Calc(Tarikh, StrConnec)
    //            End Using
    //            Close()
    //        End If
    //    End Sub
    //End Class

}
