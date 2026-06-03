using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class DailyTripProcessForm : BaseForm
    {
        // ---------- مدل‌های داخلی (جایگزین DataGridViewها) ----------
        public class DetailItem
        {
            public string FName { get; set; }
            public string Family { get; set; }
            public string P_Num { get; set; }
            public string Local { get; set; } // مبدا
            public double Score { get; set; }
        }

        private class PersonItem
        {
            public string FName { get; set; }
            public string Family { get; set; }
            public string P_Num { get; set; }
            public string ShiftLabel { get; set; }
        }

        // ---------- فیلدها ----------
        private string Shift0;
        private string Shift1;
        private string Shift2;
        private string YesterDay;
        private string ProceString;
        private string ProcessName;
        private string UserName1;
        private string UserName2;
        private bool Holy;

        // in-memory collections (جایگزین ذخیره‌سازی داخل گریدها)
        private readonly List<DetailItem> _detailList = new List<DetailItem>();
        private readonly List<PersonItem> _personList = new List<PersonItem>();

        // لیست سراسری برای نگه داشتن افراد انتخاب شده
        private readonly HashSet<string> SelectedPersons = new HashSet<string>(); // کلید: P_Num

        // ---------- ctor ----------
        public DailyTripProcessForm()
        {
            InitializeComponent();
        }

        // ---------- UI helpers ----------
        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clear()
        {
            NameCombo.SelectedIndex = -1;
            NameCombo.Items.Clear();
            ProcessButton.Enabled = false;
            PrintButton.Enabled = false;
            Panel2.Enabled = false;

            OvertimeUseCheck.Checked = false;
            OvertimeUseCheck.Enabled = false;
            TrainnigUseCheck.Checked = false;
            TrainnigUseCheck.Enabled = false;

            foreach (Control MasBox in Panel2.Controls)
            {
                if (MasBox is MaskedTextBox m)
                {
                    m.Text = "0";
                    m.Enabled = false;
                    m.BackColor = HeadColor;
                    m.Font = FontManager.IranSans(14);
                }
            }
        }

        public string ProcessReader()
        {
            string SString = "0";
            int Loc = ProceString.IndexOf("-") + 1;
            if (Loc == 0)
            {
                if (!string.IsNullOrEmpty(ProceString)) SString = ProceString;
            }
            else
            {
                SString = ProceString.Substring(0, Loc - 1);
                ProceString = ProceString.Substring(Loc, ProceString.Length - Loc);
            }

            return SString;
        }

        public bool ProcessCheck(string DayProcess, string Local, OleDbConnection StrConnec)
        {
            bool Process = false;

            string sql = "SELECT U_Reg, P_Mod, Mem FROM DailyProcess WHERE Tarikh=? AND L_Num=? AND Vis=True";
            DataTable dt = DatabaseHelper.QueryToDataTable(sql, StrConnec, new Dictionary<string, object> { ["@Tarikh"] = DayProcess, ["@Lnum"] = Local });

            if (dt.Rows.Count > 0)
            {
                Process = true;
                if (Local == "تهران") UserName1 = dt.Rows[0]["U_Reg"].ToString(); else UserName2 = dt.Rows[0]["U_Reg"].ToString();
                ProcessName = dt.Rows[0]["P_Mod"].ToString();
                ProceString = dt.Rows[0]["Mem"].ToString();
            }

            return Process;
        }

        // ---------- OverTime processing (uses in-memory lists) ----------
        public void OverTime()
        {
            try
            {
                if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) != null && KindCombo.SelectedIndex >= 0)
                {
                    _personList.Clear();
                    SelectedPersons.Clear();
                    // reset boxes
                    Over12RBox.Text = Over12SBox.Text = Over9SBox.Text = Over9ABox.Text = OverSetBox.Text = "0";
                    Kasr12RBox.Text = Kasr12SBox.Text = Kasr9SBox.Text = Kasr9ABox.Text = KasrSetBox.Text = "-1";

                    // parse numeric inputs once
                    int.TryParse(All12RBox.Text, out int All12R);
                    int.TryParse(Shift12RBox.Text, out int Shift12R);
                    int.TryParse(Main12RBox.Text, out int Main12R);
                    int.TryParse(Keshik12RBox.Text, out int Keshik12R);
                    int.TryParse(Daem12RBox.Text, out int Daem12R);
                    int.TryParse(Leave12RBox.Text, out int Leave12R);
                    int.TryParse(Rez12RBox.Text, out int Rez12R);
                    int.TryParse(Class12RBox.Text, out int Class12R);

                    int.TryParse(All12SBox.Text, out int All12S);
                    int.TryParse(Shift12SBox.Text, out int Shift12S);
                    int.TryParse(Main12SBox.Text, out int Main12S);
                    int.TryParse(Keshik12SBox.Text, out int Keshik12S);
                    int.TryParse(Daem12SBox.Text, out int Daem12S);
                    int.TryParse(Leave12SBox.Text, out int Leave12S);
                    int.TryParse(Rez12SBox.Text, out int Rez12S);
                    int.TryParse(Class12SBox.Text, out int Class12S);

                    int.TryParse(All9SBox.Text, out int All9S);
                    int.TryParse(Shift9SBox.Text, out int Shift9S);
                    int.TryParse(Main9SBox.Text, out int Main9S);
                    int.TryParse(Keshik9SBox.Text, out int Keshik9S);
                    int.TryParse(Daem9SBox.Text, out int Daem9S);
                    int.TryParse(Leave9SBox.Text, out int Leave9S);
                    int.TryParse(Rez9SBox.Text, out int Rez9S);
                    int.TryParse(Class9SBox.Text, out int Class9S);

                    int.TryParse(All9ABox.Text, out int All9A);
                    int.TryParse(Shift9ABox.Text, out int Shift9A);
                    int.TryParse(Main9ABox.Text, out int Main9A);
                    int.TryParse(Keshik9ABox.Text, out int Keshik9A);
                    int.TryParse(Daem9ABox.Text, out int Daem9A);
                    int.TryParse(Leave9ABox.Text, out int Leave9A);
                    int.TryParse(Rez9ABox.Text, out int Rez9A);
                    int.TryParse(Class9ABox.Text, out int Class9A);

                    int.TryParse(AllSetBox.Text, out int AllSet);
                    int.TryParse(ShiftSetBox.Text, out int ShiftSet);
                    int.TryParse(MainSetBox.Text, out int MainSet);
                    int.TryParse(KeshikSetBox.Text, out int KeshikSet);
                    int.TryParse(DaemSetBox.Text, out int DaemSet);
                    int.TryParse(LeaveSetBox.Text, out int LeaveSet);
                    int.TryParse(RezSetBox.Text, out int RezSet);
                    int.TryParse(ClassSetBox.Text, out int ClassSet);

                    int Kasr12R = Shift12R + Main12R + Keshik12R + Daem12R - (All12R + Leave12R + Rez12R + Class12R);
                    int Kasr12S = Shift12S + Main12S + Keshik12S + Daem12S - (All12S + Leave12S + Rez12S + Class12S);
                    int Kasr9S = Shift9S + Main9S + Keshik9S + Daem9S - (All9S + Leave9S + Rez9S + Class9S);
                    int Kasr9A = Shift9A + Main9A + Keshik9A + Daem9A - (All9A + Leave9A + Rez9A + Class9A);
                    int KasrSet = ShiftSet + MainSet + KeshikSet + DaemSet - (AllSet + LeaveSet + RezSet + ClassSet);

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        if (Kasr12R < 0)
                        {
                            List<DetailItem> details = OverTimeTable("12 ساعته روز", LocalCombo.SelectedItem.ToString(), StrConnec);
                            details = details.OrderBy(d => d.Score).ToList();
                            int i = 0;
                            while (Kasr12R < 0 && i < details.Count)
                            {
                                _personList.Add(new PersonItem { FName = details[i].FName, Family = details[i].Family, P_Num = details[i].P_Num, ShiftLabel = "12 ساعته روز" });
                                SelectedPersons.Add(details[i].P_Num); // اضافه کردن به لیست سراسری
                                Over12RBox.Text = (int.Parse(Over12RBox.Text) + 1).ToString();
                                Kasr12R++;
                                i++;
                            }
                        }

                        if (Kasr12S < 0)
                        {
                            List<DetailItem> details = OverTimeTable("12 ساعته شب", LocalCombo.SelectedItem.ToString(), StrConnec);
                            details = details.OrderBy(d => d.Score).ToList();
                            int i = 0;
                            while (Kasr12S < 0 && i < details.Count)
                            {
                                _personList.Add(new PersonItem { FName = details[i].FName, Family = details[i].Family, P_Num = details[i].P_Num, ShiftLabel = "12 ساعته شب" });
                                SelectedPersons.Add(details[i].P_Num); // اضافه کردن به لیست سراسری
                                Over12SBox.Text = (int.Parse(Over12SBox.Text) + 1).ToString();
                                Kasr12S++;
                                i++;
                            }
                        }

                        if (Kasr9A < 0)
                        {
                            List<DetailItem> details = OverTimeTable("9 ساعته عصر", LocalCombo.SelectedItem.ToString(), StrConnec);
                            details = details.OrderBy(d => d.Score).ToList();
                            int i = 0;
                            while (Kasr9A < 0 && i < details.Count)
                            {
                                _personList.Add(new PersonItem { FName = details[i].FName, Family = details[i].Family, P_Num = details[i].P_Num, ShiftLabel = "9 ساعته عصر" });
                                SelectedPersons.Add(details[i].P_Num); // اضافه کردن به لیست سراسری
                                Over9ABox.Text = (int.Parse(Over9ABox.Text) + 1).ToString();
                                Kasr9A++;
                                i++;
                            }
                        }

                        if (Kasr9S < 0)
                        {
                            List<DetailItem> details = OverTimeTable("9 ساعته صبح", LocalCombo.SelectedItem.ToString(), StrConnec);
                            details = details.OrderBy(d => d.Score).ToList();
                            int i = 0;
                            while (Kasr9S < 0 && i < details.Count)
                            {
                                _personList.Add(new PersonItem { FName = details[i].FName, Family = details[i].Family, P_Num = details[i].P_Num, ShiftLabel = "9 ساعته صبح" });
                                SelectedPersons.Add(details[i].P_Num); // اضافه کردن به لیست سراسری
                                Over9SBox.Text = (int.Parse(Over9SBox.Text) + 1).ToString();
                                Kasr9S++;
                                i++;
                            }
                        }

                        if (KasrSet < 0)
                        {
                            List<DetailItem> details = OverTimeTable("ستادی", LocalCombo.SelectedItem.ToString(), StrConnec);
                            details = details.OrderBy(d => d.Score).ToList();
                            int i = 0;
                            while (KasrSet < 0 && i < details.Count)
                            {
                                _personList.Add(new PersonItem { FName = details[i].FName, Family = details[i].Family, P_Num = details[i].P_Num, ShiftLabel = "ستادی" });
                                SelectedPersons.Add(details[i].P_Num); // اضافه کردن به لیست سراسری
                                OverSetBox.Text = (int.Parse(OverSetBox.Text) + 1).ToString();
                                KasrSet++;
                                i++;
                            }
                        }
                    }

                    Kasr12RBox.Text = Kasr12R.ToString();
                    Kasr12SBox.Text = Kasr12S.ToString();
                    Kasr9SBox.Text = Kasr9S.ToString();
                    Kasr9ABox.Text = Kasr9A.ToString();
                    KasrSetBox.Text = KasrSet.ToString();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        // ---------- OverTimeTable: returns List<DetailItem>, does not use any UI grid ----------
        private List<DetailItem> OverTimeTable(string Shift, string Local, OleDbConnection StrConnec)
        {
            try
            {
                List<DetailItem> results = new List<DetailItem>();
                double TopOver = 0;
                DataTable dtTop = DatabaseHelper.QueryToDataTable(
                    "SELECT MonthTime FROM ShKar WHERE Tarikh=?",
                    StrConnec,
                    new Dictionary<string, object> { ["@Tarikh"] = PersianCalendar.Text.Substring(0, 7) }
                );
                if (dtTop.Rows.Count > 0)
                {
                    TopOver = ConvertClass.TimeToDouble(dtTop.Rows[0]["MonthTime"].ToString());
                }

                // Build candidate list from JayGozin
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT Person.Fname, Person.Family, Person.P_Num FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE JayGozin.Tarikh=? AND JayGozin.Vis=True AND Person.Line_Num=? AND Person.OverTime=True");
                Dictionary<string, object> param = new Dictionary<string, object> { ["@Tarikh"] = PersianCalendar.Text, ["@LineNum"] = AppState.UserLnum };

                if (!TrainnigUseCheck.Checked)
                {
                    sb.Append(" AND Person.Trip=True");
                }

                if ((string)LocalCombo.SelectedItem == "هشتگرد")
                {
                    sb.Append(" AND ((JayGozin.Shift_Loc='گلشهر' AND JayGozin.Olv1='همه موارد') OR (JayGozin.Shift_Loc='هشتگرد' AND JayGozin.Olv1='همه موارد') OR (JayGozin.Shift_Loc='هشتگرد' OR JayGozin.Olv1='هشتگرد' OR JayGozin.Olv2='هشتگرد' OR JayGozin.Olv3='هشتگرد' OR JayGozin.Olv4='هشتگرد'))");
                }
                else
                {
                    sb.Append(" AND JayGozin.Shift_Loc=? AND (JayGozin.Olv1='همه موارد' OR JayGozin.Olv1=? OR JayGozin.Olv2=? OR JayGozin.Olv3=? OR JayGozin.Olv4=?)");
                    param.Add("@Local1", Local);
                    param.Add("@Local2", Shift);
                    param.Add("@Local3", Shift);
                    param.Add("@Local4", Shift);
                    param.Add("@Local5", Shift);
                }

                DataTable dt = DatabaseHelper.QueryToDataTable(sb.ToString(), StrConnec, param);
                if (dt.Rows.Count == 0)
                {
                    return results;
                }

                // Build initial candidates list, حذف افرادی که قبلاً انتخاب شده‌اند
                List<DetailItem> candidates = new List<DetailItem>();
                foreach (DataRow r in dt.Rows)
                {
                    string pnum = r["P_Num"].ToString();
                    if (SelectedPersons.Contains(pnum))
                    {
                        continue; // اگر قبلاً انتخاب شده، حذف
                    }

                    candidates.Add(new DetailItem { FName = r["Fname"].ToString(), Family = r["Family"].ToString(), P_Num = pnum, Score = 0.0 });
                }

                // ترتیب شیفت‌ها
                //string[] shifts=new string[] { "روز", "شب", "صبح", "عصر" };
                //foreach (string shiftTime in shifts)
                //{
                for (int i = candidates.Count - 1; i >= 0; i--)
                {
                    double Overtime = 0;
                    double Emt = 0;
                    string pnum = candidates[i].P_Num;

                    // Ezafeh E_Time (exclude certain kinds)
                    DataTable dtez = DatabaseHelper.QueryToDataTable("SELECT E_Time FROM Ezafeh WHERE ViS=True AND P_Num=? AND Tarikh=? AND E_Kind <> 'تشویقی' AND E_Kind <> 'کلاس آموزشی' AND E_Kind <> 'شیفت'", StrConnec,
                        new Dictionary<string, object> { ["@Pnum"] = pnum, ["@Tarikh"] = PersianCalendar.Text });
                    foreach (DataRow r in dtez.Rows)
                    {
                        Emt += ConvertClass.TimeToDouble(r["E_Time"].ToString());
                    }

                    if (Emt > 11)
                    {
                        candidates.RemoveAt(i);
                        continue;
                    }

                    // Morakhasi adds to Emt
                    int mor = 0;
                    if (PersianCalendar.Text.Substring(5, 2) == "01")
                    {
                        DataTable dtmor = DatabaseHelper.QueryToDataTable("SELECT COUNT(Tarikh) AS Cou FROM Morakhasi WHERE Vis=True AND P_Num=? AND Tarikh BETWEEN ? AND ?", StrConnec,
                            new Dictionary<string, object> { ["@Pnum"] = pnum, ["@From"] = PersianCalendar.Text.Substring(0, 7) + "/01", ["@To"] = PersianCalendar.Text.Substring(0, 7) + "/31" });
                        if (dtmor.Rows.Count > 0)
                        {
                            mor = int.Parse(dtmor.Rows[0]["Cou"].ToString());
                        }
                    }

                    // TotaMonAdv
                    DataTable dttota = DatabaseHelper.QueryToDataTable("SELECT Shift, Tota, TotaJom, NexMo FROM TotaMonAdv WHERE P_Num=? AND Maah=?", StrConnec,
                        new Dictionary<string, object> { ["@Pnum"] = pnum, ["@Maah"] = PersianCalendar.Text.Substring(0, 7) });
                    foreach (DataRow r in dttota.Rows)
                    {
                        if (string.IsNullOrEmpty(r["Shift"].ToString()))
                        {
                            MessageBoxFa.Show("راهبر بدون اطلاعات شیفت یافت شد ", "خطا", MessageBoxIcon.Error);
                            Close();
                        }
                        else if (r["Shift"].ToString().Substring(2, 1) == "T")
                        {
                            Emt -= mor * 7;
                            Emt += 30;
                        }
                        else
                        {
                            Emt -= mor * 4;
                        }

                        Overtime = ConvertClass.TimeToDouble(r["Tota"].ToString()) + ConvertClass.TimeToDouble(r["TotaJom"].ToString()) + ConvertClass.TimeToDouble(r["NexMo"].ToString());
                    }

                    // Keshik adds to Emt
                    DataTable dtkesh = DatabaseHelper.QueryToDataTable("SELECT Tarikh FROM Keshik WHERE Vis=True AND P_Num=? AND Tarikh BETWEEN ? AND ?", StrConnec,
                        new Dictionary<string, object> { ["@Pnum"] = pnum, ["@From"] = PersianCalendar.Text.Substring(0, 7) + "/01", ["@To"] = PersianCalendar.Text.Substring(0, 7) + "/31" });
                    foreach (DataRow r in dtkesh.Rows)
                    {
                        Emt += 6.5;
                        if (ConvertClass.ShamsiToMiladi(r["Tarikh"].ToString()) == ConvertClass.ShamsiToMiladi(PersianCalendar.Text))
                        {
                            Overtime += 200;
                        }
                        else if (ConvertClass.ShamsiToMiladi(r["Tarikh"].ToString()) > ConvertClass.ShamsiToMiladi(PersianCalendar.Text))
                        {
                            Overtime += 13;
                        }
                    }

                    // Ezafeh range in month
                    DataTable dtezr = DatabaseHelper.QueryToDataTable("SELECT Tarikh, E_Kind, E_Time FROM Ezafeh WHERE Vis=True AND Tarikh >= ? AND P_Num=?", StrConnec,
                        new Dictionary<string, object> { ["@From"] = PersianCalendar.Text.Substring(0, 7) + "/01", ["@Pnum"] = pnum });
                    foreach (DataRow r in dtezr.Rows)
                    {
                        string Kind = r["E_Kind"].ToString();
                        double EzTime = ConvertClass.TimeToDouble(r["E_Time"].ToString());
                        if ((Kind == "تشویقی" || Kind == "کلاس آموزشی" || Kind == "شیفت") && EzTime > 0)
                        {
                            Emt += EzTime;
                        }

                        if (ConvertClass.ShamsiToMiladi(r["Tarikh"].ToString()).DayOfWeek == DayOfWeek.Friday)
                        {
                            Emt -= EzTime * 0.5;
                        }
                    }

                    if (Overtime > TopOver)
                    {
                        if (Overtime < TopOver + 10 && OvertimeUseCheck.Checked)
                            candidates[i].Score = Overtime;
                        else
                            candidates.RemoveAt(i);
                    }
                    else
                    {
                        candidates[i].Score = Overtime - Emt;
                    }
                }
                candidates.OrderByDescending(x => x.Score);
                return candidates;
            }
            catch
            {
                throw;
            }
        }

        // ---------- Counters ----------
        public string ShiftCounter(string ShiftTime, string ShiftName, string ShiftLocal, OleDbConnection StrConnec)
        {
            try
            {
                // Use MainForm.PersonTable to count baseline where available
                string sel = $"Shift_Time='{ShiftTime}' AND P_Post='راهبر قطار' AND Shift_Loc='{ShiftLocal}' AND Vis=True And Line_Num='{AppState.UserLnum}' AND Trip=True AND Shift_name='{ShiftName}'";
                DataRow[] rows = MainForm.PersonTable.Select(sel);
                int i = rows.Count();

                DataTable dtr = DatabaseHelper.QueryToDataTable("SELECT COUNT(Person.Family) AS Cou FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Shift_Time=? AND Person.Shift_Loc=? AND Person.Vis=True AND Person.Trip=True AND Person.Line_Num=? AND Rezerv.Vis=True AND (Rezerv.Mem LIKE 'اضطراری%' OR Rezerv.Mem='شانتر' OR Rezerv.Mem LIKE 'غیر فعال%') AND Rezerv.Tarikh=? AND Shift_name=?",
                    StrConnec, new Dictionary<string, object> { ["@time"] = ShiftTime, ["@loc"] = ShiftLocal, ["@line"] = AppState.UserLnum, ["@tarikh"] = PersianCalendar.Text, ["@sname"] = ShiftName });
                if (dtr.Rows.Count > 0)
                {
                    i -= Convert.ToInt32(dtr.Rows[0]["Cou"]);
                }

                DataTable dtt = DatabaseHelper.QueryToDataTable("SELECT COUNT(Person.Family) AS Cou FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE Person.Shift_Time=? AND Person.Shift_Loc=? AND Person.Vis=True AND Person.Line_Num=? AND TakTrip.Vis=True AND TakTrip.Trip='هشتگرد' AND TakTrip.Tarikh=? AND Shift_name=?",
                    StrConnec, new Dictionary<string, object> { ["@time"] = ShiftTime, ["@loc"] = ShiftLocal, ["@line"] = AppState.UserLnum, ["@tarikh"] = PersianCalendar.Text, ["@sname"] = ShiftName });
                if (dtt.Rows.Count > 0)
                {
                    i -= Convert.ToInt32(dtt.Rows[0]["Cou"]);
                }

                return i.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string KeshikCounter(string KeshikTime, string KeshikLocal, OleDbConnection StrConnec)
        {
            try
            {
                DataTable dt = DatabaseHelper.QueryToDataTable("SELECT COUNT(P_Num) AS Cou FROM Keshik WHERE Tarikh=? AND T_Keshik=? AND L_Keshik=? AND Vis=True", StrConnec,
                    new Dictionary<string, object> { ["@Tarikh"] = PersianCalendar.Text, ["@T_Keshik"] = KeshikTime, ["@L_Keshik"] = KeshikLocal });
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Cou"].ToString();
                }

                return "0";
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string LeaveCounter(string LeaveTime, string LeaveShift, string LeaveLocal, OleDbConnection StrConnec)
        {
            try
            {
                string StrQuer = "SELECT COUNT(Person.Family) AS Cou FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Trip=True AND Person.Shift_Loc =? AND Person.Vis=True AND Person.Shift_Time=? AND Person.Line_Num=? AND Morakhasi.Vis=True AND Morakhasi.Tarikh=?";
                if (!string.IsNullOrEmpty(LeaveShift))
                {
                    StrQuer += " AND Person.Shift_name=?";
                }

                Dictionary<string, object> param = new Dictionary<string, object> { ["@loc"] = LeaveLocal, ["@time"] = LeaveTime, ["@line"] = AppState.UserLnum, ["@tarikh"] = PersianCalendar.Text };
                if (!string.IsNullOrEmpty(LeaveShift))
                {
                    param.Add("@shiftName", LeaveShift);
                }

                DataTable dt = DatabaseHelper.QueryToDataTable(StrQuer, StrConnec, param);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Cou"].ToString();
                }

                return "0";
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string ClassCounter(string ClassTime, string ClassShift, string ClassLocal, OleDbConnection StrConnec)
        {
            try
            {
                string StrQuer = "SELECT COUNT(Person.Family) AS Cou FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Trip=True AND Person.Shift_Loc =? AND Person.Vis=True AND Person.Shift_Time=? AND Person.Line_Num=? AND Retraining.Vis=True AND Retraining.Tarikh=?";
                if (!string.IsNullOrEmpty(ClassShift))
                {
                    StrQuer += " AND Person.Shift_name=?";
                }

                Dictionary<string, object> param = new Dictionary<string, object> { ["@loc"] = ClassLocal, ["@time"] = ClassTime, ["@line"] = AppState.UserLnum, ["@tarikh"] = PersianCalendar.Text };
                if (!string.IsNullOrEmpty(ClassShift))
                {
                    param.Add("@shiftName", ClassShift);
                }

                DataTable dt = DatabaseHelper.QueryToDataTable(StrQuer, StrConnec, param);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Cou"].ToString();
                }

                return "0";
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        // ---------- Reserv (rewritten to use in-memory lists and parameterized queries) ----------
        public void Reserv(string ResLocal, string ShiftTime, string ShiftName, int ResNum, OleDbConnection StrConnec)
        {
            try
            {
                List<DetailItem> candidates = new List<DetailItem>();
                string ResShift = "";
                Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                PersianDate.AddMonth(-2);

                if (ShiftName == Shift2)
                {
                    ResShift = (ShiftTime == "12 ساعته") ? "شب" : "عصر";
                }
                else
                {
                    ResShift = (ShiftTime == "12 ساعته") ? "روز" : "صبح";
                }

                // Select candidates from MainForm.PersonTable for speed
                DataRow[] DRow = MainForm.PersonTable.Select($"Shift_Time='{ShiftTime}' AND P_Post='راهبر قطار' AND Shift_Loc='{ResLocal}' AND Vis=True AND Reserv=True AND Trip=True AND Shift_name='{ShiftName}'");
                foreach (DataRow DtR in DRow)
                {
                    candidates.Add(new DetailItem { FName = DtR["Fname"].ToString(), Family = DtR["Family"].ToString(), P_Num = DtR["P_Num"].ToString(), Score = 0.0 });
                }

                // Exclusions: Morakhasi, TakTrip, Retraining
                DataTable dtMor = DatabaseHelper.QueryToDataTable("SELECT Morakhasi.P_Num FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Shift_Time=? AND Person.Shift_Loc=? AND Person.Line_Num=? AND Morakhasi.Tarikh=? AND Morakhasi.Vis=True AND Person.Shift_name=?", StrConnec,
                    new Dictionary<string, object> { ["@time"] = ShiftTime, ["@loc"] = ResLocal, ["@line"] = AppState.UserLnum, ["@tarikh"] = PersianCalendar.Text, ["@sname"] = ShiftName });
                HashSet<string> exclude = new HashSet<string>();
                foreach (DataRow r in dtMor.Rows)
                {
                    exclude.Add(r["P_Num"].ToString());

                    SelectedPersons.Add(r["P_Num"].ToString()); // اضافه کردن به لیست سراسری
                }

                DataTable dtTak = DatabaseHelper.QueryToDataTable("SELECT P_Num FROM TakTrip WHERE Tarikh=? AND Vis=True", StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text });
                foreach (DataRow r in dtTak.Rows)
                {
                    exclude.Add(r["P_Num"].ToString());
                }

                DataTable dtRetr = DatabaseHelper.QueryToDataTable("SELECT Retraining.P_Num FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Person.Shift_Time=? AND Person.Shift_Loc=? AND Person.Line_Num=? AND Retraining.Tarikh=? AND Retraining.Vis=True AND Person.Shift_name=?", StrConnec,
                    new Dictionary<string, object> { ["@time"] = ShiftTime, ["@loc"] = ResLocal, ["@line"] = AppState.UserLnum, ["@tarikh"] = PersianCalendar.Text, ["@sname"] = ShiftName });
                foreach (DataRow r in dtRetr.Rows)
                {
                    exclude.Add(r["P_Num"].ToString());
                }

                candidates = candidates.Where(c => !exclude.Contains(c.P_Num)).ToList();

                // Existing Rezerv rows on this tariff
                DataTable dtRes = DatabaseHelper.QueryToDataTable("SELECT Person.Fname, Person.Family, Rezerv.Mem, Rezerv.P_Num FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh=? AND Rezerv.Vis=True AND Person.Shift_Time=? AND Person.Shift_Loc=? AND Person.Line_Num=? AND Person.Shift_name=?", StrConnec,
                    new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@time"] = ShiftTime, ["@loc"] = ResLocal, ["@line"] = AppState.UserLnum, ["@sname"] = ShiftName });

                foreach (DataRow r in dtRes.Rows)
                {
                    if (!(r["Mem"].ToString().IndexOf("غیر فعال") + 1 > 0))
                    {
                        ResNum--;
                    }

                    candidates.RemoveAll(c => c.P_Num == r["P_Num"].ToString());
                }

                if (ResNum <= 0)
                {
                    return;
                }

                // Score candidates based on recent Rezerv and Morakhasi
                for (int i = 0; i < candidates.Count; i++)
                {
                    int Emer = 0;
                    int Rez = 0;
                    double Emt = 0;
                    double LastRez = 0;
                    DateTime SelectDate = ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                    DataTable dtRezRange = DatabaseHelper.QueryToDataTable("SELECT Tarikh, Mem FROM Rezerv WHERE P_Num=? AND Tarikh BETWEEN ? AND ? AND Vis=True AND Mem <> 'شانتر'", StrConnec,
                        new Dictionary<string, object> { ["@pnum"] = candidates[i].P_Num, ["@from"] = PersianCalendar.Text, ["@to"] = PersianDate.Tarikh() });

                    foreach (DataRow r in dtRezRange.Rows)
                    {
                        DateTime Dat = ConvertClass.ShamsiToMiladi(r["Tarikh"].ToString());
                        LastRez = Convert.ToInt32(r["Tarikh"].ToString().Substring(2, 8).Replace("/", "")) / 1000000.0;

                        if (r["Mem"].ToString().IndexOf("اضطراری") + 1 > 0)
                        {
                            Emer++;
                        }
                        else
                        {
                            Rez++;
                        }

                        if (Dat == SelectDate.AddDays(-1))
                        {
                            Emt += 2;
                        }
                        else if (Dat == SelectDate.AddDays(-2))
                        {
                            Emt += 1.5;
                        }
                        else if (Dat == SelectDate.AddDays(-3))
                        {
                            Emt += 1;
                        }
                        else if (Dat == SelectDate.AddDays(-4))
                        {
                            Emt += 0.5;
                        }
                    }

                    DataTable dtMorRange = DatabaseHelper.QueryToDataTable("SELECT Tarikh FROM Morakhasi WHERE P_Num=? AND Vis=True AND Tarikh BETWEEN ? AND ?", StrConnec,
                        new Dictionary<string, object> { ["@pnum"] = candidates[i].P_Num, ["@from"] = PersianCalendar.Text, ["@to"] = PersianDate.Tarikh() });
                    foreach (DataRow r in dtMorRange.Rows)
                    {
                        DateTime Dat = ConvertClass.ShamsiToMiladi(r["Tarikh"].ToString());
                        if (Dat == SelectDate.AddDays(-1))
                        {
                            Emt += 2;
                        }
                        else if (Dat == SelectDate.AddDays(-2))
                        {
                            Emt += 1;
                        }
                    }

                    candidates[i].Score = Emt + Rez + Emer + LastRez;
                }

                candidates = candidates.OrderBy(c => c.Score).ToList();

                if (ResNum <= candidates.Count)
                {
                    for (int i = 0; i <= ResNum - 1; i++)
                    {
                        DatabaseHelper.ExecuteNonQuery("INSERT INTO Rezerv (P_NUM, Tarikh, R_Shift, Loca, U_Reg, Vis, Mem) VALUES (?, ?, ?, ?, ?, True, ?)", StrConnec,
                            new Dictionary<string, object> { ["@pnum"] = candidates[i].P_Num, ["@tarikh"] = PersianCalendar.Text, ["@R_Shift"] = ResShift, ["@Loca"] = ResLocal, ["@U_Reg"] = AppState.UserName, ["@Mem"] = "عادی" });
                    }
                }
                else
                {
                    StrConnec.Close();
                    MessageBoxFa.Show("راهبران " + ShiftTime + " " + ResShift + " " + ResLocal + " از تعداد رزروهای مورد نیاز کمتر است", "خطا", MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        // ---------- TakTrip (similar rewrite) ----------
        public void TakTrip(string TripLocal, string ShiftTime, string ShiftName, int TripNum, OleDbConnection StrConnec)
        {
            try
            {
                List<DetailItem> candidates = new List<DetailItem>();
                int Trp1 = 0;
                double DateCon = 0;
                string ResShift = "";
                Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                PersianDate.AddMonth(-3);

                ResShift = (ShiftName == Shift2) ? "عصر" : "صبح";

                DataRow[] rows = MainForm.PersonTable.Select($"Shift_Time='{ShiftTime}' AND P_Post='راهبر قطار' AND Shift_Loc='{TripLocal}' AND Line_Num='{AppState.UserLnum}' AND Vis=True AND Reserv=True AND Trip=True AND Shift_name='{ShiftName}'");
                foreach (DataRow DtR in rows)
                {
                    candidates.Add(new DetailItem { FName = DtR["Fname"].ToString(), Family = DtR["Family"].ToString(), P_Num = DtR["P_Num"].ToString(), Score = 0.0 });
                }

                for (int i = candidates.Count - 1; i >= 0; i--)
                {
                    DataTable d1 = DatabaseHelper.QueryToDataTable("SELECT ID FROM Morakhasi WHERE Vis=True AND Tarikh=? AND P_Num=?", StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@pnum"] = candidates[i].P_Num });
                    if (d1.Rows.Count > 0) { candidates.RemoveAt(i); continue; }

                    DataTable d2 = DatabaseHelper.QueryToDataTable("SELECT ID FROM Rezerv WHERE Vis=True AND Tarikh=? AND P_Num=?", StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@pnum"] = candidates[i].P_Num });
                    if (d2.Rows.Count > 0) { candidates.RemoveAt(i); continue; }

                    DataTable d3 = DatabaseHelper.QueryToDataTable("SELECT ID FROM TakTrip WHERE Tarikh=? AND Vis=True AND P_Num=?", StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@pnum"] = candidates[i].P_Num });
                    if (d3.Rows.Count > 0) { candidates.RemoveAt(i); continue; }

                    DataTable d4 = DatabaseHelper.QueryToDataTable("SELECT ID FROM Retraining WHERE Vis=True AND Tarikh=? AND P_Num=?", StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@pnum"] = candidates[i].P_Num });
                    if (d4.Rows.Count > 0) { candidates.RemoveAt(i); continue; }
                }

                for (int i = 0; i < candidates.Count; i++)
                {
                    Trp1 = 0;
                    DateCon = 0;
                    DataTable dtr = DatabaseHelper.QueryToDataTable("SELECT Tarikh FROM TakTrip WHERE P_Num=? AND Vis=True AND Tarikh BETWEEN ? AND ? AND Trip='هشتگرد' ORDER BY Tarikh", StrConnec,
                        new Dictionary<string, object> { ["@pnum"] = candidates[i].P_Num, ["@from"] = PersianCalendar.Text, ["@to"] = PersianDate.Tarikh() });
                    foreach (DataRow r in dtr.Rows)
                    {
                        if (ConvertClass.ShamsiToMiladi(r["Tarikh"].ToString()) > ConvertClass.ShamsiToMiladi(PersianCalendar.Text).AddDays(-5))
                        {
                            Trp1++;
                        }

                        DateCon = Convert.ToInt32(r["Tarikh"].ToString().Substring(2, 8).Replace("/", "")) / 1000000.0;
                        Trp1++;
                    }
                    candidates[i].Score = Trp1 + DateCon;
                }

                candidates = candidates.OrderBy(c => c.Score).ToList();
                if (TripNum <= candidates.Count)
                {
                    for (int i = 0; i <= TripNum - 1; i++)
                    {
                        DatabaseHelper.ExecuteNonQuery("INSERT INTO TakTrip (P_NUM, Tarikh, T_Shift, Trip, U_Reg, T_Reg, Vis) VALUES (?, ?, ?, 'هشتگرد', ?, ?, True)", StrConnec,
                            new Dictionary<string, object> { ["@pnum"] = candidates[i].P_Num, ["@tarikh"] = PersianCalendar.Text, ["@T_Shift"] = ResShift, ["@U_Reg"] = AppState.UserName, ["@T_Reg"] = MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") });
                    }
                }
                else
                {
                    StrConnec.Close();
                    MessageBoxFa.Show("راهبران " + ShiftTime + " " + ResShift + " " + TripLocal + " از تعداد راهبران مورد نیاز کمتر است", "خطا", MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        // ---------- Printing helpers (kept behavior like original) ----------
        public string ReservPrint(string ShiftTime, string ShiftName, string ShiftLocal, string ResDate, OleDbConnection StrConnec)
        {
            try
            {
                bool EmerRes = false;
                bool Shanter = false;
                StringBuilder sb = new StringBuilder();

                string StrQuer = "Select Person.Fname, Person.Family, Rezerv.Mem FROM Rezerv INNER JOIN Person On Person.P_Num=Rezerv.P_Num WHERE Person.Vis=True And Person.Trip=True And Person.Shift_Loc=? AND Person.Shift_name=? AND Person.Line_Num=? AND Rezerv.Vis=True AND Rezerv.Tarikh=? And Person.Shift_Time=?";
                Dictionary<string, object> param = new Dictionary<string, object> { ["@loc"] = ShiftLocal, ["@sname"] = ShiftName, ["@line"] = AppState.UserLnum, ["@tarikh"] = ResDate, ["@time"] = ShiftTime };

                DataTable dt = DatabaseHelper.QueryToDataTable(StrQuer, StrConnec, param);
                foreach (DataRow r in dt.Rows)
                {
                    string mem = r["Mem"].ToString();
                    if (mem.IndexOf("اضطراری") + 1 > 0 || mem.IndexOf("غیر فعال") + 1 > 0)
                    {
                        EmerRes = true;
                    }
                    else if (mem == "شانتر")
                    {
                        Shanter = true;
                    }
                    else
                    {
                        sb.Append(r["Fname"].ToString() + " " + r["Family"].ToString() + " - ");
                    }
                }

                string ResName = sb.ToString();
                if (ResName.Length > 3)
                {
                    ResName = ResName.Substring(0, ResName.Length - 3);
                }

                if (EmerRes)
                {
                    StringBuilder extra = new StringBuilder();
                    extra.Append(" ( راهبر غیرفعال : ");
                    string StrQ2 = "SELECT Person.Fname, Person.Family FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Vis=True AND Person.Trip=True AND Person.Shift_Loc=? AND Person.Shift_name=? AND Person.Line_Num=? AND Rezerv.Vis=True AND Rezerv.Tarikh=? AND (Rezerv.Mem LIKE '%اضطراری%' OR Rezerv.Mem LIKE '%غیر فعال%') And Person.Shift_Time=?";
                    DataTable dt2 = DatabaseHelper.QueryToDataTable(StrQ2, StrConnec, new Dictionary<string, object> { ["@loc"] = ShiftLocal, ["@sname"] = ShiftName, ["@line"] = AppState.UserLnum, ["@tarikh"] = ResDate, ["@time"] = ShiftTime });
                    foreach (DataRow r in dt2.Rows)
                    {
                        extra.Append(r["Fname"].ToString() + " " + r["Family"].ToString() + " - ");
                    }
                    if (extra.Length > 3)
                    {
                        extra.Length -= 3;
                    }

                    extra.Append(" )");
                    if (!string.IsNullOrEmpty(ResName))
                    {
                        ResName += " ";
                    }

                    ResName += extra.ToString();
                }
                if (Shanter)
                {
                    StringBuilder extra = new StringBuilder();
                    extra.Append(" ** شانتر شیفت : ");
                    string StrQ3 = "SELECT Person.Fname, Person.Family FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Vis=True AND Person.Trip=True AND Person.Shift_Time=? AND Person.Shift_Loc=? AND Person.Shift_name=? AND Person.Line_Num=? AND Rezerv.Vis=True AND Rezerv.Tarikh=? AND Rezerv.Mem='شانتر'";
                    DataTable dt3 = DatabaseHelper.QueryToDataTable(StrQ3, StrConnec, new Dictionary<string, object> { ["@time"] = ShiftTime, ["@loc"] = ShiftLocal, ["@sname"] = ShiftName, ["@line"] = AppState.UserLnum, ["@tarikh"] = ResDate });
                    foreach (DataRow r in dt3.Rows)
                    {
                        extra.Append(r["Fname"].ToString() + " " + r["Family"].ToString() + " - ");
                    }

                    if (extra.Length > 3)
                    {
                        extra.Length -= 3;
                    }

                    if (!string.IsNullOrEmpty(ResName))
                    {
                        ResName += " ";
                    }

                    ResName += extra.ToString();
                }

                return ResName;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string LeavePrint(string shiftTime, string shiftName, string shiftLocal, string leaveDate, OleDbConnection conn)
        {
            try
            {
                List<string> leaveNames = new List<string>();

                string sql = @"SELECT Person.Fname, Person.Family FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Vis=True AND Person.P_Post LIKE 'راهبر%' AND Person.Shift_Loc=? AND Person.Shift_name=? AND Person.Line_Num=? AND Morakhasi.Vis=True AND Morakhasi.Tarikh=?";

                if (!string.IsNullOrEmpty(shiftTime))
                {
                    sql += " AND Person.Shift_Time=?";
                }

                sql += " ORDER BY Person.Family, Person.Fname";

                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ShiftLoc", shiftLocal);
                    cmd.Parameters.AddWithValue("@ShiftName", shiftName);
                    cmd.Parameters.AddWithValue("@LineNum", AppState.UserLnum);
                    cmd.Parameters.AddWithValue("@Tarikh", leaveDate);

                    if (!string.IsNullOrEmpty(shiftTime))
                    {
                        cmd.Parameters.AddWithValue("@ShiftTime", shiftTime);
                    }

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            leaveNames.Add($"{reader["Fname"]} {reader["Family"]}");
                        }
                    }
                }

                return string.Join(" - ", leaveNames);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string SpesialTripPrint(string ShiftTime, string ShiftName, string ShiftLocal, string SpTrip, string TripDate, OleDbConnection StrConnec)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string sql = "SELECT Person.Fname, Person.Family FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE Person.Vis=True AND TakTrip.Vis=True AND TakTrip.Tarikh=? AND TakTrip.Trip=? AND Person.Shift_Loc=? AND Person.Shift_Time=? And Person.Shift_name=? ORDER BY Person.Family, Person.Fname";
                DataTable dt = DatabaseHelper.QueryToDataTable(sql, StrConnec, new Dictionary<string, object> { ["@tarikh"] = TripDate, ["@trip"] = SpTrip, ["@loc"] = ShiftLocal, ["@time"] = ShiftTime, ["@sname"] = ShiftName });
                foreach (DataRow r in dt.Rows)
                {
                    sb.Append(r["Fname"].ToString() + " " + r["Family"].ToString() + " - ");
                }

                string s = sb.ToString();
                if (s.Length > 3)
                {
                    s = s.Substring(0, s.Length - 3);
                }

                return s;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string OverTimePrint(string OverKind, string OverMem, string OverLocal, string OverDate, OleDbConnection StrConnec)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string StrQuer = "Select Person.Fname, Person.Family FROM Ezafeh INNER JOIN Person On Person.P_Num=Ezafeh.P_Num WHERE Person.Vis=True And Person.Line_Num=? AND Ezafeh.Vis=True AND Ezafeh.Tarikh=? AND Ezafeh.E_Local=? AND Ezafeh.E_Kind=?";
                if (!string.IsNullOrEmpty(OverMem))
                {
                    StrQuer += " AND Ezafeh.E_Mem LIKE ?";
                }

                StrQuer += " ORDER BY Person.Family, Person.Fname";

                Dictionary<string, object> param = new Dictionary<string, object> { ["@line"] = AppState.UserLnum, ["@tarikh"] = OverDate, ["@local"] = OverLocal, ["@kind"] = OverKind };
                if (!string.IsNullOrEmpty(OverMem))
                {
                    param.Add("@mem", "%" + OverMem + "%");
                }

                DataTable dt = DatabaseHelper.QueryToDataTable(StrQuer, StrConnec, param);
                foreach (DataRow r in dt.Rows)
                {
                    sb.Append(r["Fname"].ToString() + " " + r["Family"].ToString() + " - ");
                }

                string s = sb.ToString();
                if (s.Length > 3)
                {
                    s = s.Substring(0, s.Length - 3);
                }

                return s;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        public string ClassPrint(string ClassLocal, OleDbConnection StrConnec)
        {
            try
            {
                DataTable dt = DatabaseHelper.QueryToDataTable("SELECT Retraining.P_Num, Retraining.Kind, Retraining.L_Class, Retraining.T_Class, Person.Fname, Person.Family, Person.Shift_name FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Person.Shift_Loc=? AND Retraining.Vis=True AND Retraining.Tarikh=? AND Person.Line_Num=? ORDER BY Retraining.Kind, Retraining.L_Class, Retraining.T_Class, Person.Family, Person.Fname",
                    StrConnec, new Dictionary<string, object> { ["@loc"] = ClassLocal, ["@tarikh"] = PersianCalendar.Text, ["@line"] = AppState.UserLnum });

                StringBuilder classMember = new StringBuilder();
                string currentKind = null;
                foreach (DataRow r in dt.Rows)
                {
                    string kind = r["Kind"].ToString();
                    string name = r["Fname"].ToString() + " " + r["Family"].ToString();
                    if (kind == currentKind)
                    {
                        classMember.Append(" - " + name);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(currentKind))
                        {
                            classMember.Append(" ( " + currentKind + " ) ****  ");
                        }
                        currentKind = kind;
                        classMember.Append(name);
                    }
                }
                if (!string.IsNullOrEmpty(currentKind))
                {
                    classMember.Append(" ( " + currentKind + " )");
                }

                return classMember.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show(" لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return string.Empty;
            }
        }

        // ---------- Events ----------
        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.SelectedIndex = -1;
                WeekLabel.Visible = false;
                Clear();

                Taghvim PersianDate = new Taghvim();
                PersianDate.SetDate(PersianCalendar.Text);
                PersianDate.AddDay(-1);
                YesterDay = PersianDate.Tarikh();
                PersianDate.AddDay(1);

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    if ((!ProcessCheck(YesterDay, "تهران", StrConnec) || !ProcessCheck(YesterDay, "هشتگرد", StrConnec) || !ProcessCheck(YesterDay, "گلشهر", StrConnec)) && AppState.UserLevel > 0)
                    {
                        StrConnec.Close();
                        MessageBoxFa.Show("پردازش برای تاریخ " + YesterDay + " انجام نشده است", "خطا", MessageBoxIcon.Error);
                        LocalCombo.Enabled = false;
                        return;
                    }
                    else
                    {
                        LocalCombo.Enabled = true;
                        TehLabel.BackColor = Color.Tomato;
                        GolLabel.BackColor = Color.Tomato;
                        HgrLabel.BackColor = Color.Tomato;

                        if (ProcessCheck(PersianCalendar.Text, "تهران", StrConnec))
                        {
                            TehLabel.BackColor = Color.Lime;
                        }
                        if (ProcessCheck(PersianCalendar.Text, "هشتگرد", StrConnec))
                        {
                            HgrLabel.BackColor = Color.Lime;
                        }
                        if (ProcessCheck(PersianCalendar.Text, "گلشهر", StrConnec))
                        {
                            GolLabel.BackColor = Color.Lime;
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Taghvim WHERE Tarikh=? OR Tarikh=?", StrConnec))
                    {
                        CMD.Parameters.AddWithValue("@t1", PersianCalendar.Text);
                        CMD.Parameters.AddWithValue("@t2", YesterDay);
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (Reader["Tarikh"].ToString() == PersianCalendar.Text)
                                {
                                    Shift1 = Reader["Sobh"].ToString();
                                    Shift2 = Reader["Asr"].ToString();
                                    if (int.Parse(Reader["rooz"].ToString()) == 7 || (bool)Reader["Holi"])
                                    {
                                        Holy = true;
                                    }
                                    else
                                    {
                                        Holy = false;
                                    }
                                }
                                else
                                {
                                    Shift0 = Reader["Asr"].ToString();
                                }
                            }
                        }
                    }
                    if (TehLabel.BackColor != Color.Lime || GolLabel.BackColor != Color.Lime || HgrLabel.BackColor != Color.Lime)
                    {
                        Enabled = false;
                        if (PersianCalendar.Text.Substring(8, 2) == "01")
                        {
                            Enabled = false;
                            OptimizationForm ShowForm = new OptimizationForm
                            {
                                Tarikh = PersianCalendar.Text
                            };
                            ShowForm.Show();
                            Enabled = true;
                        }
                        else
                        {
                            using (WaitForm wtf = new WaitForm())
                            {
                                Enabled = false;
                                wtf.Show(this);
                                wtf.Refresh();
                                _detailList.Clear();
                                using (OleDbCommand CMD = new OleDbCommand("SELECT P_Num FROM JayGozin WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        _detailList.Add(new DetailItem { P_Num = Reader["P_Num"].ToString() });
                                    }
                                }

                                OptimizationForm ShowForm = new OptimizationForm();
                                for (int i = 0; i <= _detailList.Count - 1; i++)
                                {
                                    ShowForm.PersoOptim(_detailList[i].P_Num, PersianCalendar.Text, StrConnec);
                                }
                                _detailList.Clear();
                                Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show(" لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                KindCombo.SelectedIndex = -1;
                KindCombo.Items.Clear();
                Clear();

                if (LocalCombo.SelectedIndex >= 0)
                {
                    Panel1.Enabled = false;
                    int i;

                    Local1Label.Text = LocalCombo.SelectedItem.ToString();

                    using (OleDbConnection StrConnec1 = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec1.Open();
                        if (ProcessCheck(PersianCalendar.Text, LocalCombo.SelectedItem.ToString(), StrConnec1))
                        {
                            All12RBox.Text = ProcessReader();
                            All12SBox.Text = ProcessReader();
                            All9SBox.Text = ProcessReader();
                            All9ABox.Text = ProcessReader();
                            AllSetBox.Text = ProcessReader();

                            Shift12RBox.Text = ProcessReader();
                            Shift12SBox.Text = ProcessReader();
                            Shift9SBox.Text = ProcessReader();
                            Shift9ABox.Text = ProcessReader();
                            ShiftSetBox.Text = ProcessReader();

                            Keshik12RBox.Text = ProcessReader();
                            Keshik12SBox.Text = ProcessReader();
                            Keshik9SBox.Text = ProcessReader();
                            Keshik9ABox.Text = ProcessReader();
                            KeshikSetBox.Text = ProcessReader();

                            Main12RBox.Text = ProcessReader();
                            Main12SBox.Text = ProcessReader();
                            Main9SBox.Text = ProcessReader();
                            Main9ABox.Text = ProcessReader();
                            MainSetBox.Text = ProcessReader();

                            Daem12RBox.Text = ProcessReader();
                            Daem12SBox.Text = ProcessReader();
                            Daem9SBox.Text = ProcessReader();
                            Daem9ABox.Text = ProcessReader();
                            DaemSetBox.Text = ProcessReader();

                            Leave12RBox.Text = ProcessReader();
                            Leave12SBox.Text = ProcessReader();
                            Leave9SBox.Text = ProcessReader();
                            Leave9ABox.Text = ProcessReader();
                            LeaveSetBox.Text = ProcessReader();

                            Class12RBox.Text = ProcessReader();
                            Class12SBox.Text = ProcessReader();
                            Class9SBox.Text = ProcessReader();
                            Class9ABox.Text = ProcessReader();
                            ClassSetBox.Text = ProcessReader();

                            Rez12RBox.Text = ProcessReader();
                            Rez12SBox.Text = ProcessReader();
                            Rez9SBox.Text = ProcessReader();
                            Rez9ABox.Text = ProcessReader();
                            RezSetBox.Text = ProcessReader();

                            Over12RBox.Text = ProcessReader();
                            Over12SBox.Text = ProcessReader();
                            Over9SBox.Text = ProcessReader();
                            Over9ABox.Text = ProcessReader();
                            OverSetBox.Text = ProcessReader();

                            OvertimeUseCheck.Checked = ProcessReader() == "1";
                            TrainnigUseCheck.Checked = ProcessReader() == "1";

                            Kasr12RBox.Text = "0";
                            Kasr12SBox.Text = "0";
                            Kasr9SBox.Text = "0";
                            Kasr9ABox.Text = "0";
                            KasrSetBox.Text = "0";

                            ProcessButton.Enabled = false;
                            Panel2.Enabled = false;

                            string ProDay = "";
                            string ProName = "";
                            i = ProcessName.IndexOf("-") + 1;
                            ProDay = ProcessName.Substring(0, i - 2);
                            ProName = ProcessName.Substring(i + 1, ProcessName.Length - i - 1);
                            WeekLabel.Text = " جدول اجرا شده :" + "\r" + ProDay + "\r" + ProName;
                            WeekLabel.BackColor = Color.Silver;
                            WeekLabel.Visible = true;
                            WeekLabel.Left = Convert.ToInt32(147 - Math.Round((double)WeekLabel.Width / 2));

                            MessageBoxFa.Show("قبلا پردازش انجام شده، داده ی جدیدی وجود ندارد", "توجه", MessageBoxIcon.Warning);
                            TehLabel_BackColorChanged(null, null);
                        }
                        else
                        {
                            OvertimeUseCheck.Checked = false;
                            OvertimeUseCheck.Enabled = true;

                            if (Holy)
                            {
                                WeekLabel.Text = "جدول پیشنهادی: \n جمعه و روز تعطیل";
                                WeekLabel.BackColor = Color.Tomato;
                            }
                            else if (PersianCalendar.Miladi.DayOfWeek == DayOfWeek.Thursday)
                            {
                                WeekLabel.Text = "جدول پیشنهادی: \n پنجشنبه";
                                WeekLabel.BackColor = Color.Yellow;
                            }
                            else
                            {
                                WeekLabel.Text = "جدول پیشنهادی: \n عادی";
                                WeekLabel.BackColor = Color.LightGreen;
                            }

                            WeekLabel.Visible = true;
                            WeekLabel.Left = Convert.ToInt32(147 - Math.Round((double)WeekLabel.Width / 2));

                            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();

                                Shift12RBox.Text = ShiftCounter("12 ساعته", Shift1, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Shift12SBox.Text = ShiftCounter("12 ساعته", Shift2, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Shift9SBox.Text = ShiftCounter("9 ساعته", Shift1, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Shift9ABox.Text = ShiftCounter("9 ساعته", Shift2, LocalCombo.SelectedItem.ToString(), StrConnec);

                                Keshik12RBox.Text = KeshikCounter("روز", LocalCombo.SelectedItem.ToString(), StrConnec);
                                Keshik12SBox.Text = KeshikCounter("شب", LocalCombo.SelectedItem.ToString(), StrConnec);
                                Keshik9SBox.Text = KeshikCounter("صبح", LocalCombo.SelectedItem.ToString(), StrConnec);
                                Keshik9ABox.Text = KeshikCounter("عصر", LocalCombo.SelectedItem.ToString(), StrConnec);

                                Leave12RBox.Text = LeaveCounter("12 ساعته", Shift1, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Leave12SBox.Text = LeaveCounter("12 ساعته", Shift2, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Leave9SBox.Text = LeaveCounter("9 ساعته", Shift1, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Leave9ABox.Text = LeaveCounter("9 ساعته", Shift2, LocalCombo.SelectedItem.ToString(), StrConnec);

                                Class12RBox.Text = ClassCounter("12 ساعته", Shift1, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Class12SBox.Text = ClassCounter("12 ساعته", Shift2, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Class9SBox.Text = ClassCounter("9 ساعته", Shift1, LocalCombo.SelectedItem.ToString(), StrConnec);
                                Class9ABox.Text = ClassCounter("9 ساعته", Shift2, LocalCombo.SelectedItem.ToString(), StrConnec);

                                if (!Holy && ConvertClass.ShamsiToMiladi(PersianCalendar.Text).DayOfWeek != DayOfWeek.Thursday)
                                {
                                    KeshikSetBox.Text = KeshikCounter("ستادی", LocalCombo.SelectedItem.ToString(), StrConnec);
                                    LeaveSetBox.Text = LeaveCounter("ستادی", "ستادی", LocalCombo.SelectedItem.ToString(), StrConnec);
                                    ClassSetBox.Text = ClassCounter("ستادی", "ستادی", LocalCombo.SelectedItem.ToString(), StrConnec);
                                }
                                else
                                {
                                    KeshikSetBox.Text = "0";
                                    LeaveSetBox.Text = "0";
                                    ClassSetBox.Text = "0";
                                }

                                if (!Holy && ConvertClass.ShamsiToMiladi(PersianCalendar.Text).DayOfWeek != DayOfWeek.Thursday)
                                {
                                    ShiftSetBox.Text = ShiftCounter("ستادی", "ستادی", LocalCombo.SelectedItem.ToString(), StrConnec);
                                }
                                else
                                {
                                    ShiftSetBox.Text = "0";
                                }
                            }

                            KindCombo.SelectedIndex = -1;
                            KindCombo.Items.Clear();
                            //if (LocalCombo.SelectedIndex < 2)
                            //{
                            //    KindCombo.Items.Add("شنبه تا چهارشنبه");
                            //    KindCombo.Items.Add("پنج شنبه");
                            //    KindCombo.Items.Add("جمعه و تعطیل");
                            //}
                            //else
                            if (LocalCombo.SelectedItem.ToString() == "هشتگرد")
                            {
                                Main12RBox.BackColor = Color.White;
                                Main12RBox.Enabled = true;
                                Main12SBox.BackColor = Color.White;
                                Main12SBox.Enabled = true;
                                Main9SBox.BackColor = Color.White;
                                Main9SBox.Enabled = true;
                                Main9ABox.BackColor = Color.White;
                                Main9ABox.Enabled = true;
                                MainSetBox.BackColor = Color.White;
                                MainSetBox.Enabled = true;

                                TrainnigUseCheck.Checked = false;
                                TrainnigUseCheck.Enabled = true;
                            }
                            KindCombo.Items.Add("شنبه تا چهارشنبه");
                            KindCombo.Items.Add("پنج شنبه");
                            KindCombo.Items.Add("جمعه و تعطیل");
                            KindCombo.Items.Add("روز خاص");
                        }

                        Panel1.Enabled = true;
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

        public void ProcessEnable()
        {
            if (Kasr12RBox.BackColor == Color.Lime && Kasr12SBox.BackColor == Color.Lime && Kasr9SBox.BackColor == Color.Lime && Kasr9ABox.BackColor == Color.Lime && KasrSetBox.BackColor == Color.Lime && KindCombo.SelectedIndex >= 0)
            {
                ProcessButton.Enabled = true;
            }
            else
            {
                ProcessButton.Enabled = false;
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (KindCombo.SelectedIndex >= 0)
                {
                    Enabled = false;
                    NameCombo.Items.Clear();

                    if (string.IsNullOrEmpty(PersianCalendar.Text))
                    {
                        ErrorShow(PersianCalendar, "تاریخ پردازش را تعیین کنید");
                    }
                    else if (KindCombo.SelectedIndex >= 0)
                    {
                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            DataTable dtKesh = DatabaseHelper.QueryToDataTable("SELECT Keshik.T_Keshik, Keshik.L_Keshik FROM Keshik INNER JOIN Person ON Keshik.P_Num=Person.P_Num WHERE Keshik.Tarikh=? AND Keshik.Vis=True AND Person.OverTime=False AND Person.Vis=True", StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text });
                            if (dtKesh.Rows.Count > 0)
                            {
                                StrConnec.Close();
                                Enabled = true;
                                MessageBoxFa.Show("کشیک " + dtKesh.Rows[0]["T_Keshik"].ToString() + " " + dtKesh.Rows[0]["L_Keshik"].ToString() + " را اصلاح کنید", "خطا", MessageBoxIcon.Error);
                                return;
                            }

                            DataTable dt = DatabaseHelper.QueryToDataTable("SELECT P_Name, L_Num FROM DailyProcessProgram WHERE P_Kind=? AND Vis=True And L_Num=? ORDER BY P_Name", StrConnec, new Dictionary<string, object> { ["@kind"] = KindCombo.SelectedItem.ToString(), ["@lnum"] = LocalCombo.SelectedItem.ToString() });
                            foreach (DataRow r in dt.Rows)
                            {
                                NameCombo.Items.Add(r["P_Name"].ToString());
                            }
                        }

                        if (KindCombo.SelectedItem.ToString() == "روز خاص")
                        {
                            NameCombo.Enabled = false;

                            All12RBox.BackColor = ControlBack;
                            All12RBox.Enabled = true;
                            All12SBox.BackColor = ControlBack;
                            All12SBox.Enabled = true;
                            All9SBox.BackColor = ControlBack;
                            All9SBox.Enabled = true;
                            All9ABox.BackColor = ControlBack;
                            All9ABox.Enabled = true;
                            AllSetBox.BackColor = ControlBack;
                            AllSetBox.Enabled = true;

                            Daem12RBox.BackColor = ControlBack;
                            Daem12RBox.Enabled = true;
                            Daem12SBox.BackColor = ControlBack;
                            Daem12SBox.Enabled = true;
                            Daem9SBox.BackColor = ControlBack;
                            Daem9SBox.Enabled = true;
                            Daem9ABox.BackColor = ControlBack;
                            Daem9ABox.Enabled = true;
                            DaemSetBox.BackColor = ControlBack;
                            DaemSetBox.Enabled = true;

                            Rez12RBox.BackColor = ControlBack;
                            Rez12RBox.Enabled = true;
                            Rez12SBox.BackColor = ControlBack;
                            Rez12SBox.Enabled = true;
                            Rez9SBox.BackColor = ControlBack;
                            Rez9SBox.Enabled = true;
                            Rez9ABox.BackColor = ControlBack;
                            Rez9ABox.Enabled = true;
                            RezSetBox.BackColor = ControlBack;
                            RezSetBox.Enabled = true;

                            Rez12RBox.Text = "0";
                            Rez12SBox.Text = "0";
                            Rez9SBox.Text = "0";
                            Rez9ABox.Text = "0";
                            RezSetBox.Text = "0";

                            Panel2.Enabled = true;
                        }
                        else
                        {
                            All12RBox.BackColor = HeadColor;
                            All12RBox.Enabled = false;
                            All12SBox.BackColor = HeadColor;
                            All12SBox.Enabled = false;
                            All9SBox.BackColor = HeadColor;
                            All9SBox.Enabled = false;
                            All9ABox.BackColor = HeadColor;
                            All9ABox.Enabled = false;
                            AllSetBox.BackColor = HeadColor;
                            AllSetBox.Enabled = false;

                            Daem12RBox.BackColor = ControlBack;
                            Daem12RBox.Enabled = true;
                            Daem12SBox.BackColor = ControlBack;
                            Daem12SBox.Enabled = true;
                            Daem9SBox.BackColor = ControlBack;
                            Daem9SBox.Enabled = true;
                            Daem9ABox.BackColor = ControlBack;
                            Daem9ABox.Enabled = true;
                            DaemSetBox.BackColor = ControlBack;
                            DaemSetBox.Enabled = true;

                            Rez12RBox.BackColor = ControlBack;
                            Rez12RBox.Enabled = true;
                            Rez12SBox.BackColor = ControlBack;
                            Rez12SBox.Enabled = true;
                            Rez9SBox.BackColor = ControlBack;
                            Rez9SBox.Enabled = true;
                            Rez9ABox.BackColor = ControlBack;
                            Rez9ABox.Enabled = true;
                            RezSetBox.BackColor = ControlBack;
                            RezSetBox.Enabled = true;

                            NameCombo.Enabled = true;
                        }
                    }

                    Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void NameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (NameCombo.SelectedIndex >= 0)
                {
                    Enabled = false;

                    if (NameCombo.SelectedIndex < 0)
                    {
                        PrintButton.Enabled = false;
                        ProcessButton.Enabled = false;
                    }
                    else
                    {
                        string ProcessMemo = "";
                        int All12R1 = 0;
                        int All12S1 = 0;
                        int All9S1 = 0;
                        int All9A1 = 0;
                        int AllSet1 = 0;

                        int Rez12R1 = 0;
                        int Rez12S1 = 0;
                        int Rez9S1 = 0;
                        int Rez9A1 = 0;
                        int RezSet1 = 0;

                        using (WaitForm wait = new WaitForm())
                        {
                            wait.Show();
                            wait.Refresh();

                            ProcessMemo = "";
                            Daem12RBox.Text = "0";
                            Daem12SBox.Text = "0";
                            Daem9SBox.Text = "0";
                            Daem9ABox.Text = "0";
                            DaemSetBox.Text = "0";

                            Rez12RBox.Text = "0";
                            Rez12SBox.Text = "0";
                            Rez9SBox.Text = "0";
                            Rez9ABox.Text = "0";
                            RezSetBox.Text = "0";

                            Over12RBox.Text = "0";
                            Over12SBox.Text = "0";
                            Over9SBox.Text = "0";
                            Over9ABox.Text = "0";
                            OverSetBox.Text = "0";

                            Kasr12RBox.Text = "0";
                            Kasr12SBox.Text = "0";
                            Kasr9SBox.Text = "0";
                            Kasr9ABox.Text = "0";
                            KasrSetBox.Text = "0";

                            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();
                                DataTable dt = DatabaseHelper.QueryToDataTable("SELECT * FROM DailyProcessProgram WHERE P_Kind=? AND Vis=True AND P_Name=? And L_Num=?", StrConnec, new Dictionary<string, object> { ["@kind"] = KindCombo.SelectedItem.ToString(), ["@pname"] = NameCombo.SelectedItem.ToString(), ["@lnum"] = LocalCombo.SelectedItem.ToString() });
                                foreach (DataRow r in dt.Rows)
                                {
                                    All12R1 = Convert.ToInt32(r["Shift12R1"]);
                                    All12S1 = Convert.ToInt32(r["Shift12S1"]);
                                    All9S1 = Convert.ToInt32(r["Shift9S1"]);
                                    All9A1 = Convert.ToInt32(r["Shift9A1"]);
                                    AllSet1 = Convert.ToInt32(r["ShiftSet1"]);

                                    Rez12R1 = Convert.ToInt32(r["Res12R1"]);
                                    Rez12S1 = Convert.ToInt32(r["Res12S1"]);
                                    Rez9S1 = Convert.ToInt32(r["Res9S1"]);
                                    Rez9A1 = Convert.ToInt32(r["Res9A1"]);
                                    RezSet1 = Convert.ToInt32(r["ResSet1"]);

                                    ProcessMemo = r["Mem"].ToString();
                                }
                            }

                            if (ProcessMemo.Length > 3)
                            {
                                MessageBoxFa.Show(ProcessMemo, "توجه", MessageBoxIcon.Information);
                            }

                            All12RBox.Text = All12R1.ToString();
                            All12SBox.Text = All12S1.ToString();
                            All9SBox.Text = All9S1.ToString();
                            All9ABox.Text = All9A1.ToString();
                            AllSetBox.Text = AllSet1.ToString();

                            Rez12RBox.Text = Rez12R1.ToString();
                            Rez12SBox.Text = Rez12S1.ToString();
                            Rez9SBox.Text = Rez9S1.ToString();
                            Rez9ABox.Text = Rez9A1.ToString();
                            RezSetBox.Text = RezSet1.ToString();

                            Panel2.Enabled = true;

                            Enabled = true;
                            wait.Close();
                        }
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

        // ---------- Process & Print (final) ----------
        public void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("پردازش اطلاعات لوحه انجام شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled = false;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            // Reservations
                            Reserv(LocalCombo.SelectedItem.ToString(), "12 ساعته", Shift1, Convert.ToInt32(Rez12RBox.Text), StrConnec);
                            Reserv(LocalCombo.SelectedItem.ToString(), "12 ساعته", Shift2, Convert.ToInt32(Rez12SBox.Text), StrConnec);
                            Reserv(LocalCombo.SelectedItem.ToString(), "9 ساعته", Shift1, Convert.ToInt32(Rez9SBox.Text), StrConnec);
                            Reserv(LocalCombo.SelectedItem.ToString(), "9 ساعته", Shift2, Convert.ToInt32(Rez9ABox.Text), StrConnec);
                            Reserv(LocalCombo.SelectedItem.ToString(), "ستادی", "ستادی", Convert.ToInt32(RezSetBox.Text), StrConnec);

                            if ((string)LocalCombo.SelectedItem == "هشتگرد")
                            {
                                TakTrip("گلشهر", "12 ساعته", Shift1, Convert.ToInt32(Main12RBox.Text), StrConnec);
                                TakTrip("گلشهر", "12 ساعته", Shift2, Convert.ToInt32(Main12SBox.Text), StrConnec);
                                TakTrip("گلشهر", "9 ساعته", Shift1, Convert.ToInt32(Main9SBox.Text), StrConnec);
                                TakTrip("گلشهر", "9 ساعته", Shift2, Convert.ToInt32(Main9ABox.Text), StrConnec);
                                TakTrip("گلشهر", "ستادی", "ستادی", Convert.ToInt32(MainSetBox.Text), StrConnec);
                            }

                            // Keshik -> insert Ezafeh for each keshik record via query
                            DataTable dtKesh = DatabaseHelper.QueryToDataTable("SELECT Person.Fname, Person.Family, Person.P_Num, Person.Line_Num, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.Vis=True AND T_Keshik <> 'کلاس آموزش' AND Keshik.Tarikh=? AND Person.Line_Num=? AND Person.P_Staff=? AND L_Keshik=? ORDER BY Keshik.L_Keshik, Keshik.T_Keshik",
                                StrConnec, new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@linenum"] = AppState.UserLnum, ["@pstaff"] = AppState.UserStaff, ["@lkesh"] = LocalCombo.SelectedItem.ToString() });

                            foreach (DataRow r in dtKesh.Rows)
                            {
                                string pnum = r["P_Num"].ToString();
                                string l_kesh = r["L_Keshik"].ToString();
                                string t_kesh = r["T_Keshik"].ToString();
                                DatabaseHelper.ExecuteNonQuery("INSERT INTO Ezafeh (P_Num, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES (?, ?, '13:00', 'کشیک', ?, ?, ?, ?, True)", StrConnec,
                                    new Dictionary<string, object> { ["@pnum"] = pnum, ["@tarikh"] = PersianCalendar.Text, ["@elocal"] = l_kesh, ["@emem"] = t_kesh, ["@ureg"] = AppState.UserName, ["@treg"] = MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") });

                                SelectedPersons.Add(pnum); // اضافه کردن به لیست سراسری
                            }

                            Taghvim PersianDate = new Taghvim(PersianCalendar.Text);

                            // insert overtime assignments from _personList
                            foreach (PersonItem p in _personList)
                            {
                                PersianDate.SetDate(PersianCalendar.Text);
                                string KasStr = "13:00";
                                if (p.ShiftLabel == "12 ساعته روز")
                                {
                                    KasStr = (PersianDate.DayWeek() == "جمعه") ? "13:00" : "19:30";
                                }
                                else if (p.ShiftLabel == "12 ساعته شب")
                                {
                                    if (PersianDate.DayWeek() == "پنج شنبه")
                                    {
                                        KasStr = "08:00";
                                    }
                                    else
                                    {
                                        KasStr = "04:30";
                                        PersianDate.SetDate(PersianCalendar.Text);
                                        PersianDate.AddDay(1);
                                        DatabaseHelper.ExecuteNonQuery("INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES (?, ?, '10:00', 'اضافه کار شب قبل', ?, ?, ?, ?, True)", StrConnec,
                                            new Dictionary<string, object> { ["@pnum"] = p.P_Num, ["@tarikh"] = PersianDate.Tarikh(), ["@elocal"] = LocalCombo.SelectedItem.ToString(), ["@emem"] = p.ShiftLabel, ["@ureg"] = AppState.UserName, ["@treg"] = MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") });
                                        PersianDate.SetDate(PersianCalendar.Text);
                                    }
                                }
                                else if (p.ShiftLabel == "9 ساعته صبح" || p.ShiftLabel == "9 ساعته عصر" || p.ShiftLabel == "ستادی")
                                {
                                    KasStr = "13:00";
                                }

                                DatabaseHelper.ExecuteNonQuery("INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES (?, ?, ?, 'اضافه کار', ?, ?, ?, ?, True)", StrConnec,
                                    new Dictionary<string, object> { ["@pnum"] = p.P_Num, ["@tarikh"] = PersianCalendar.Text, ["@etime"] = KasStr, ["@elocal"] = LocalCombo.SelectedItem.ToString(), ["@emem"] = p.ShiftLabel, ["@ureg"] = AppState.UserName, ["@treg"] = MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") });


                                SelectedPersons.Add(p.P_Num); // اضافه کردن به لیست سراسری
                            }

                            OptimizationForm ShowForm = new OptimizationForm();
                            foreach (string pnum in SelectedPersons)
                            {
                                ShowForm.PersoOptim(pnum, PersianCalendar.Text, StrConnec);
                            }

                            // Build Process name and Mem string (kept like original but safe)
                            ProcessName = KindCombo.SelectedItem + " - " + NameCombo.SelectedItem;

                            List<string> memParts = new List<string>
                            {
                                All12RBox.Text, All12SBox.Text, All9SBox.Text, All9ABox.Text, AllSetBox.Text,
                                Shift12RBox.Text, Shift12SBox.Text, Shift9SBox.Text, Shift9ABox.Text, ShiftSetBox.Text,
                                Keshik12RBox.Text, Keshik12SBox.Text, Keshik9SBox.Text, Keshik9ABox.Text, KeshikSetBox.Text,
                                Main12RBox.Text, Main12SBox.Text, Main9SBox.Text, Main9ABox.Text, MainSetBox.Text,
                                Daem12RBox.Text, Daem12SBox.Text, Daem9SBox.Text, Daem9ABox.Text, DaemSetBox.Text,
                                Leave12RBox.Text, Leave12SBox.Text, Leave9SBox.Text, Leave9ABox.Text, LeaveSetBox.Text,
                                Class12RBox.Text, Class12SBox.Text, Class9SBox.Text, Class9ABox.Text, ClassSetBox.Text,
                                Rez12RBox.Text, Rez12SBox.Text, Rez9SBox.Text, Rez9ABox.Text, RezSetBox.Text,
                                Over12RBox.Text, Over12SBox.Text, Over9SBox.Text, Over9ABox.Text, OverSetBox.Text,
                                OvertimeUseCheck.Checked?"1":"0", TrainnigUseCheck.Checked?"1":"0"
                            };
                            string Mem = string.Join("-", memParts) + "-";

                            DatabaseHelper.ExecuteNonQuery("INSERT INTO DailyProcess (Tarikh, L_Num, P_Mod, Mem, T_Reg , U_Reg, Vis) VALUES (?, ?, ?, ?, ?, ?, True)", StrConnec,
                                new Dictionary<string, object> { ["@tarikh"] = PersianCalendar.Text, ["@lnum"] = LocalCombo.SelectedItem.ToString(), ["@pmod"] = ProcessName, ["@mem"] = Mem, ["@treg"] = MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss"), ["@ureg"] = AppState.UserName });
                        }

                        Enabled = true;
                        wait.Close();
                    }

                    if ((string)LocalCombo.SelectedItem == "تهران")
                    {
                        TehLabel.BackColor = Color.Lime;
                    }
                    else if ((string)LocalCombo.SelectedItem == "هشتگرد")
                    {
                        HgrLabel.BackColor = Color.Lime;
                    }
                    else if ((string)LocalCombo.SelectedItem == "گلشهر")
                    {
                        GolLabel.BackColor = Color.Lime;
                    }

                    Panel2.Enabled = false;

                    MessageBoxFa.Show("پردازش با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    ProcessButton.Enabled = false;
                    KindCombo.Items.Clear();
                    NameCombo.Items.Clear();
                    KindCombo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                using (WaitForm wait = new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        Dictionary<string, string> reservTehran = GetReservData("تهران", StrConnec);
                        Dictionary<string, string> reservGolshahr = GetReservData("گلشهر", StrConnec);
                        Dictionary<string, string> reservHashtgerd = GetReservData("هشتگرد", StrConnec);

                        Dictionary<string, string> leaveTehran = GetLeaveData("تهران", StrConnec);
                        Dictionary<string, string> leaveGolshahr = GetLeaveData("گلشهر", StrConnec);
                        Dictionary<string, string> leaveHashtgerd = GetLeaveData("هشتگرد", StrConnec);

                        Dictionary<string, string> KeshikTehran = GetKeshikData("تهران", StrConnec);
                        Dictionary<string, string> KeshikGolshahr = GetKeshikData("گلشهر", StrConnec);
                        Dictionary<string, string> KeshikHashtgerd = GetKeshikData("هشتگرد", StrConnec);

                        Dictionary<string, string> overTehran = GetOverTimeData("تهران", StrConnec);
                        Dictionary<string, string> overGolshahr = GetOverTimeData("گلشهر", StrConnec);
                        Dictionary<string, string> overHashtgerd = GetOverTimeData("هشتگرد", StrConnec);

                        Dictionary<string, string> TripHashtgerd = GetSpesialTripData("گلشهر", StrConnec);

                        string classTehran = ClassPrint("تهران", StrConnec);
                        string classGolshahr = ClassPrint("گلشهر", StrConnec);
                        string classHashtgerd = ClassPrint("هشتگرد", StrConnec);
                        if (!string.IsNullOrEmpty(classHashtgerd))
                        {
                            classGolshahr += " *** " + classHashtgerd;
                        }

                        // Load the exact report file you provided earlier
                        Report.Load(AppState.DatabasePath + "\\Metro.mrt");
                        Report.Compile();

                        // set report variables (same as before)
                        Report["DateProcess"] = PersianCalendar.Text;
                        if (string.IsNullOrEmpty(UserName1)) Report["UserProcess1"] = UserName2; else Report["UserProcess1"] = UserName1;
                        Report["UserProcess2"] = UserName2;
                        Report["LineProcess"] = AppState.UserLnum;
                        Report["NameProcess"] = ProcessName;
                        Report["Local1"] = "تهران";
                        Report["Local2"] = "گلشهر";

                        FillReport(Report, reservTehran, "Rez", "1");
                        FillReport(Report, reservGolshahr, "Rez", "2");
                        FillReport(Report, leaveTehran, "Leav", "1");
                        FillReport(Report, leaveGolshahr, "Leav", "2");
                        FillReport(Report, KeshikTehran, "Kesh", "1");
                        FillReport(Report, KeshikGolshahr, "Kesh", "2");
                        FillReport(Report, overTehran, "Over", "1");
                        FillReport(Report, overGolshahr, "Over", "2");

                        Report["Class1"] = classTehran;
                        Report["Class2"] = classGolshahr;
                        Report["Mem2"] = BuildHashtgerdMemo(reservHashtgerd, leaveHashtgerd, KeshikHashtgerd, overHashtgerd, TripHashtgerd);

                        wait.Close();
                    }

                    Report.Render();
                    Stimulsoft.Report.Viewer.StiViewerForm viw = new Stimulsoft.Report.Viewer.StiViewerForm(Report);
                    viw.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                Enabled = true;
            }
        }

        // ---------- helper wrappers used in Print ----------
        private Dictionary<string, string> GetReservData(string city, OleDbConnection conn)
        {
            return new Dictionary<string, string>
            {
                ["12R"] = ReservPrint("12 ساعته", Shift1, city, PersianCalendar.Text, conn),
                ["12S"] = ReservPrint("12 ساعته", Shift2, city, PersianCalendar.Text, conn),
                ["9S"] = ReservPrint("9 ساعته", Shift1, city, PersianCalendar.Text, conn),
                ["9A"] = ReservPrint("9 ساعته", Shift2, city, PersianCalendar.Text, conn),
                ["Set"] = ReservPrint("ستادی", "ستادی", city, PersianCalendar.Text, conn),
                ["12SLast"] = ReservPrint("12 ساعته", Shift0, city, YesterDay, conn)
            };
        }

        private Dictionary<string, string> GetLeaveData(string city, OleDbConnection conn)
        {
            return new Dictionary<string, string>
            {
                ["12R"] = LeavePrint("12 ساعته", Shift1, city, PersianCalendar.Text, conn),
                ["12S"] = LeavePrint("12 ساعته", Shift2, city, PersianCalendar.Text, conn),
                ["9S"] = LeavePrint("9 ساعته", Shift1, city, PersianCalendar.Text, conn),
                ["9A"] = LeavePrint("9 ساعته", Shift2, city, PersianCalendar.Text, conn),
                ["Set"] = LeavePrint("ستادی", "ستادی", city, PersianCalendar.Text, conn),
                ["12SLast"] = LeavePrint("12 ساعته", Shift0, city, YesterDay, conn)
            };
        }

        private Dictionary<string, string> GetSpesialTripData(string city, OleDbConnection conn)
        {
            return new Dictionary<string, string>
            {
                ["12R"] = SpesialTripPrint("12 ساعته", Shift1, city, "هشتگرد", PersianCalendar.Text, conn),
                ["12S"] = SpesialTripPrint("12 ساعته", Shift2, city, "هشتگرد", PersianCalendar.Text, conn),
                ["9S"] = SpesialTripPrint("9 ساعته", Shift1, city, "هشتگرد", PersianCalendar.Text, conn),
                ["9A"] = SpesialTripPrint("9 ساعته", Shift2, city, "هشتگرد", PersianCalendar.Text, conn),
                ["Set"] = SpesialTripPrint("ستادی", "ستادی", city, "هشتگرد", PersianCalendar.Text, conn),
                ["12SLast"] = SpesialTripPrint("12 ساعته", Shift0, city, "هشتگرد", YesterDay, conn)
            };
        }

        private Dictionary<string, string> GetKeshikData(string city, OleDbConnection conn)
        {
            return new Dictionary<string, string>
            {
                ["12R"] = OverTimePrint("کشیک", "روز", city, PersianCalendar.Text, conn),
                ["12S"] = OverTimePrint("کشیک", "شب", city, PersianCalendar.Text, conn),
                ["9S"] = OverTimePrint("کشیک", "صبح", city, PersianCalendar.Text, conn),
                ["9A"] = OverTimePrint("کشیک", "عصر", city, PersianCalendar.Text, conn),
                ["Set"] = OverTimePrint("کشیک", "ستادی", city, PersianCalendar.Text, conn),
                ["12SLast"] = OverTimePrint("کشیک", "شب", city, YesterDay, conn)
            };
        }

        private Dictionary<string, string> GetOverTimeData(string city, OleDbConnection conn)
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>
            {
                ["12R"] = OverTimePrint("جایگزین مرخصی روزانه", "12 ساعته روز", city, PersianCalendar.Text, conn),
                ["12S"] = OverTimePrint("جایگزین مرخصی روزانه", "12 ساعته شب", city, PersianCalendar.Text, conn),
                ["9S"] = OverTimePrint("جایگزین مرخصی روزانه", "9 ساعته صبح", city, PersianCalendar.Text, conn),
                ["9A"] = OverTimePrint("جایگزین مرخصی روزانه", "9 ساعته عصر", city, PersianCalendar.Text, conn),
                ["Set"] = OverTimePrint("جایگزین مرخصی روزانه", "ستادی", city, PersianCalendar.Text, conn),
                ["12SLast"] = OverTimePrint("جایگزین مرخصی روزانه", "12 ساعته شب", city, YesterDay, conn)
            };

            Dic["12R"] += " * " + OverTimePrint("اضافه کار", "12 ساعته روز", city, PersianCalendar.Text, conn);
            Dic["12S"] += " * " + OverTimePrint("اضافه کار", "12 ساعته شب", city, PersianCalendar.Text, conn);
            Dic["9S"] += " * " + OverTimePrint("اضافه کار", "9 ساعته صبح", city, PersianCalendar.Text, conn);
            Dic["9A"] += " * " + OverTimePrint("اضافه کار", "9 ساعته عصر", city, PersianCalendar.Text, conn);
            Dic["Set"] += " * " + OverTimePrint("اضافه کار", "ستادی", city, PersianCalendar.Text, conn);
            Dic["12SLast"] += " * " + OverTimePrint("اضافه کار", "12 ساعته شب", city, YesterDay, conn);
            return Dic;
        }

        private void FillReport(StiReport report, Dictionary<string, string> data, string prefix, string suffix)
        {
            foreach (KeyValuePair<string, string> kvp in data)
            {
                string fieldName = prefix + kvp.Key + suffix;
                report[fieldName] = kvp.Value;
            }
        }

        private string BuildHashtgerdMemo(Dictionary<string, string> reserv, Dictionary<string, string> leave, Dictionary<string, string> Kesh, Dictionary<string, string> over, Dictionary<string, string> trip)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (reserv["9S"].Length > 3 || reserv["9A"].Length > 3)
            {
                sb.AppendLine($"رزرو هشتگرد: صبح({reserv["9S"]}) ** عصر({reserv["9A"]})");
            }

            if (leave["9S"].Length > 3 || leave["9A"].Length > 3)
            {
                sb.AppendLine($"مرخصی هشتگرد: صبح({leave["9S"]}) ** عصر({leave["9A"]})");
            }

            if (Kesh["9S"].Length > 3 || Kesh["9A"].Length > 3)
            {
                sb.AppendLine($"کشیک هشتگرد: صبح({Kesh["9S"]}) ** عصر({Kesh["9A"]})");
            }

            if (over["9S"].Length > 3 || over["9A"].Length > 3)
            {
                sb.AppendLine($"اضافه کار هشتگرد: صبح({over["9S"]}) ** عصر({over["9A"]})");
            }

            if (trip["9S"].Length > 3 || trip["9A"].Length > 3)
            {
                sb.AppendLine($"تریپ هشتگرد: صبح({trip["9S"]}) ** عصر({trip["9A"]})");
            }

            return sb.ToString();
        }

        // ---------- simple event hooks ----------
        public void All12RBox_TextChanged(object sender, EventArgs e) => OverTime();
        public void All12SBox_TextChanged(object sender, EventArgs e) => OverTime();
        public void All9SBox_TextChanged(object sender, EventArgs e) => OverTime();
        public void All9ABox_TextChanged(object sender, EventArgs e) => OverTime();
        public void AllSetBox_TextChanged(object sender, EventArgs e) => OverTime();

        public void TehLabel_BackColorChanged(object sender, EventArgs e)
        {
            PrintButton.Enabled = (TehLabel.BackColor == Color.Lime || HgrLabel.BackColor == Color.Lime || GolLabel.BackColor == Color.Lime);
        }

        public void ProcessButton_EnabledChanged(object sender, EventArgs e)
        {
            ProcessButton.BackColor = ProcessButton.Enabled ? Color.FromArgb(255, 255, 120) : Color.Transparent;
        }

        public void TrainnigUseCheck_CheckedChanged(object sender, EventArgs e) => OverTime();

        public void PrintButton_EnabledChanged(object sender, EventArgs e)
        {
            PrintButton.BackColor = PrintButton.Enabled ? Color.FromArgb(255, 255, 120) : Color.Transparent;
        }

        private void SetKasrBackColor(MaskedTextBox box)
        {
            if (int.TryParse(box.Text, out int v))
            {
                if (v > 0)
                {
                    box.BackColor = Color.Yellow;
                }
                else if (v < 0)
                {
                    box.BackColor = Color.Red;
                }
                else
                {
                    box.BackColor = Color.Lime;
                }
            }
            else
            {
                box.BackColor = Color.LightGray;
            }
        }

        public void Kasr12RBox_TextChanged(object sender, EventArgs e) { SetKasrBackColor(Kasr12RBox); ProcessEnable(); }
        public void Kasr12SBox_TextChanged(object sender, EventArgs e) { SetKasrBackColor(Kasr12SBox); ProcessEnable(); }
        public void Kasr9sBox_TextChanged(object sender, EventArgs e) { SetKasrBackColor(Kasr9SBox); ProcessEnable(); }
        public void Kasr9aBox_TextChanged(object sender, EventArgs e) { SetKasrBackColor(Kasr9ABox); ProcessEnable(); }
        public void KasrsetBox_TextChanged(object sender, EventArgs e) { SetKasrBackColor(KasrSetBox); ProcessEnable(); }

        private void DailyTripProcessForm_Load(object sender, EventArgs e)
        {
            //PersianCalendar.Today_Click(null, null);
            Panel3.BackColor = label15.BackColor = Color.White;

        }
    }
}
