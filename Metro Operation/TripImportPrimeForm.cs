using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripImportPrimeForm
    {
        public TripImportPrimeForm()
        {
            InitializeComponent();
        }

        public int FNum;
        private readonly DataTable Rahbar = new DataTable();

        //----------------------- ابزارها و توابع کمکی -----------------------
        private void ErrorShow(Control ctrl, string msg)
        {
            ToolTip tip = new ToolTip()
            {
                IsBalloon = true,
                ToolTipIcon = ToolTipIcon.Error,
                ToolTipTitle = "خطا"
            };
            tip.Show(msg, ctrl, 0, ctrl.Height, 3000);
        }

        public bool ImportChecker(string TripDay)
        {

            bool Process = false;
            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();

                using (OleDbCommand CMD = new OleDbCommand("SELECT Tarikh FROM DailyTripReg WHERE Tarikh='" + TripDay + "' AND T_Type='لوحه اولیه' AND Vis=True", StrConnec))
                {
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Process = true;
                        }
                    }

                }

            }


            return Process;
        }

        public void TripImportPrimeForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Rahbar.Columns.Count == 0)
                {
                    Rahbar.Columns.Add("FullName", typeof(string));
                    Rahbar.Columns.Add("Family", typeof(string));
                    Rahbar.Columns.Add("PNum", typeof(string));
                    Rahbar.Columns.Add("Type", typeof(string)); // "", رزرو, مرخصی
                    Rahbar.Columns.Add("Shift", typeof(string)); // صبح / عصر
                    Rahbar.Columns.Add("TripCount", typeof(int));
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        //----------------------- انتخاب فایل‌های اکسل -----------------------
        public void Select5Button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog() { Filter = "Excel Worksheets|*.xls;*.xlsx" };
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Name5Box.Text = dlg.FileName;
                    TripGridView.Rows.Clear();
                    Line5Label.Visible = false;
                    DateLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Select51Button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog() { Filter = "Excel Worksheets|*.xls;*.xlsx" };
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Name51Box.Text = dlg.FileName;
                    TripGridView.Rows.Clear();
                    Line51Label.Visible = false;
                    DateLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        //----------------------- تابع اصلی تحلیل فایل‌ها -----------------------
        public void Analys5Button_Click(object sender, EventArgs e)
        {
            try
            {
                TripGridView.Rows.Clear();
                DateLabel.Text = "";
                Line5Label.Visible = false;
                Line51Label.Visible = false;
                TotalBox.Text = "0";
                TripNBox.Text = "0";
                OddBox.Text = "0";
                RezFBox.Text = "0";
                MorFBox.Text = "0";
                Rahbar.Clear();

                if (string.IsNullOrEmpty(Name5Box.Text))
                {
                    ErrorShow(Name5Box, "فایل لوحه خط اصلی را انتخاب کنید");
                    return;
                }
                if (string.IsNullOrEmpty(Name51Box.Text))
                {
                    ErrorShow(Name51Box, "فایل لوحه خط هشتگرد را انتخاب کنید");
                    return;
                }

                Enabled = false;

                //Load Excel files into DataSet
                DataSet DtSet = new DataSet();
                string[] excelFiles = { Name5Box.Text, Name51Box.Text };
                string[] tableNames = { "Line5", "Line51" };
                for (int idx = 0; idx <= 1; idx++)
                {
                    //string connStr=@"Provider=Microsoft.Ace.OLEDB.16.0;Data Source='C:\Users\Alireza\Desktop\اوليه 14040230.xls';Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
                    using (OleDbConnection ExcelConnection = new OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;Data Source='" + excelFiles[idx] + "';Extended Properties=Excel 8.0"))
                    using (OleDbDataAdapter MyCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", ExcelConnection))
                    {
                        ExcelConnection.Open();
                        MyCommand.TableMappings.Add("Table", idx == 0 ? "Line5" : "Line51");
                        MyCommand.Fill(DtSet);
                        ExcelConnection.Close();
                    }
                    //string filePath=excelFiles[idx];
                    //string tableName=tableNames[idx];

                    //using (var workbook=new XLWorkbook(filePath))
                    //{
                    //    var ws=workbook.Worksheet("Sheet1"); // اگر اسم متفاوت بود، اینجا عوضش کن
                    //    DataTable dt=new DataTable(tableName);

                    //    bool firstRow=true;
                    //    foreach (var row in ws.RowsUsed())
                    //    {
                    //        if (firstRow)
                    //        {
                    //            // ساخت ستون‌ها
                    //            foreach (var cell in row.Cells())
                    //                dt.Columns.Add(cell.GetString());
                    //            firstRow=false;
                    //        }
                    //        else
                    //        {
                    //            // ساخت رکوردها
                    //            dt.Rows.Add(row.Cells().Select(c => c.Value).ToArray());
                    //        }
                    //    }

                    //    DtSet.Tables.Add(dt);
                    //}
                }

                // تغییر نام ستون‌ها
                Dictionary<int, string> colNames = new Dictionary<int, string>(){
                        {0, "T_Status"}, {6, "PNum"}, {10, "نام"}, {14, "خانوادگی"}, {16, "Maghsad"}, {18, "Mabdae"}, {23, "T_Time"}, {26, "Tarikh"}
                        };
                foreach (DataTable tbl in DtSet.Tables)
                {
                    foreach (KeyValuePair<int, string> kvp in colNames)
                    {
                        if (kvp.Key < tbl.Columns.Count)
                        {
                            tbl.Columns[kvp.Key].ColumnName = kvp.Value.ToString();
                        }
                    }
                }

                DateLabel.Text = DtSet.Tables[0].Rows[5]["Tarikh"].ToString();
                if (DtSet.Tables[0].Rows[0][19].ToString() == "5")
                {
                    Line5Label.Visible = true;
                }
                else
                {
                    MessageBoxFa.Show("فایل خط اصلی صحیح نیست", "خطا", MessageBoxIcon.Error);
                    Enabled = true;
                    return;
                }
                if (DtSet.Tables[1].Rows[0][19].ToString() == "51")
                {
                    Line51Label.Visible = true;
                }
                else
                {
                    MessageBoxFa.Show("فایل خط هشتگرد صحیح نیست", "خطا", MessageBoxIcon.Error);
                    Enabled = true;
                    return;
                }

                // ترکیب دو جدول Excel
                DtSet.Tables[0].Merge(DtSet.Tables[1]);

                // پاکسازی ردیف‌های بدون شماره پرسنلی
                int i = 0;
                while (i < DtSet.Tables[0].Rows.Count)
                {
                    if (!int.TryParse(DtSet.Tables[0].Rows[i]["PNum"].ToString(), out int temp_result))
                    {
                        DtSet.Tables[0].Rows.RemoveAt(i);
                    }
                    else
                    {
                        // اصلاح مقاصد تهران - صادقیه
                        if (AppState.UserLnum == "5")
                        {
                            if (DtSet.Tables[0].Rows[i]["Mabdae"].ToString() == "تهران - صادقيه")
                            {
                                DtSet.Tables[0].Rows[i]["Mabdae"] = "تهران";
                            }

                            if (DtSet.Tables[0].Rows[i]["Maghsad"].ToString() == "تهران - صادقيه")
                            {
                                DtSet.Tables[0].Rows[i]["Maghsad"] = "تهران";
                            }
                        }
                        else
                        {
                            if (DtSet.Tables[0].Rows[i]["Mabdae"].ToString() == "تهران - صادقيه")
                            {
                                DtSet.Tables[0].Rows[i]["Mabdae"] = "صادقیه";
                            }

                            if (DtSet.Tables[0].Rows[i]["Maghsad"].ToString() == "تهران - صادقيه")
                            {
                                DtSet.Tables[0].Rows[i]["Maghsad"] = "صادقیه";
                            }
                        }

                        // بررسی تاریخ
                        if (DtSet.Tables[0].Rows[i]["Tarikh"].ToString() != DateLabel.Text)
                        {
                            MessageBoxFa.Show("تاریخ فایل صحیح نیست", "خطا", MessageBoxIcon.Error);
                            Enabled = true;
                            return;
                        }
                        i++;
                    }
                }

                // تمیز کردن و بررسی تاریخ‌ها
                for (i = DtSet.Tables[0].Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = DtSet.Tables[0].Rows[i];
                    if (!int.TryParse(row["PNum"].ToString(), out int temp_result2))
                    {
                        DtSet.Tables[0].Rows.RemoveAt(i);
                    }
                    else if (row["Tarikh"].ToString() != DateLabel.Text)
                    {
                        MessageBoxFa.Show("تاریخ فایل صحیح نیست", "خطا", MessageBoxIcon.Error);
                        DtSet.Tables[0].Rows.Clear();
                        Enabled = true;
                        return;
                    }
                }

                // ایجاد دیکشنری برای دسترسی سریع به اطلاعات پرسنل
                Dictionary<string, DataRow> personDict = new Dictionary<string, DataRow>();
                foreach (DataRow row in MainForm.PersonTable.Rows)
                {
                    personDict[row["P_Num"].ToString()] = row;
                }

                // نمایش داده‌ها در Grid
                DataRow[] distinctRows = DtSet.Tables[0].DefaultView.ToTable(true, "T_Time", "Tarikh", "Mabdae", "Maghsad").Select("", "Tarikh, T_Time, Mabdae");
                int index = 1;
                foreach (DataRow dr in distinctRows)
                {
                    TripGridView.Rows.Add(index, dr["Tarikh"], dr["T_Time"], dr["Mabdae"], dr["Maghsad"], "", "", "", "", "", "");
                    index++;
                }

                // اتصال راهبران از PersonTable
                foreach (DataGridViewRow row in TripGridView.Rows)
                {
                    string tTime = row.Cells[2].Value.ToString();
                    string tarikh = row.Cells[1].Value.ToString();
                    string mabdae = row.Cells[3].Value.ToString();
                    DataRow[] drow = DtSet.Tables[0].Select($"T_Time='{tTime}' AND Tarikh='{tarikh}' AND Mabdae='{mabdae}'");
                    foreach (DataRow dr in drow)
                    {

                        if ((string)dr["T_Status"] == "راهبر" && row.Cells[6].Value.ToString() == "")
                        {
                            row.Cells[6].Value = dr["PNum"];
                            if (personDict.ContainsKey(dr["PNum"].ToString()))
                            {
                                row.Cells[5].Value = personDict[dr["PNum"].ToString()]["Fname"].ToString() + " " + personDict[dr["PNum"].ToString()]["Family"].ToString();
                            }
                        }
                        else if ((string)dr["T_Status"] == "كمك راهبر")
                        {
                            row.Cells[8].Value = dr["PNum"];
                            if (personDict.ContainsKey(dr["PNum"].ToString()))
                            {
                                row.Cells[7].Value = personDict[dr["PNum"].ToString()]["Fname"].ToString() + " " + personDict[dr["PNum"].ToString()]["Family"].ToString();
                            }
                        }
                        else if ((string)dr["T_Status"] == "راهبر آموزشي" || dr["PNum"].ToString() != "")
                        {
                            row.Cells[10].Value = dr["PNum"];
                            if (personDict.ContainsKey(dr["PNum"].ToString()))
                            {
                                row.Cells[9].Value = personDict[dr["PNum"].ToString()]["Fname"].ToString() + " " + personDict[dr["PNum"].ToString()]["Family"].ToString();
                            }
                        }
                    }
                }

                // دریافت اطلاعات روز و ساخت Rahbar
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string sobh = "";
                    string asr = "";
                    using (OleDbCommand cmd = new OleDbCommand($"SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='{DateLabel.Text}'", StrConnec))
                    using (dynamic rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            sobh = rdr["Sobh"].ToString();
                            asr = rdr["Asr"].ToString();
                        }
                    }

                    Rahbar.Clear();
                    DataRow[] sobhRows = MainForm.PersonTable.Select($"P_Post='راهبر قطار' AND Shift_name='{sobh}' AND Vis=True");
                    foreach (DataRow r in sobhRows)
                    {
                        Rahbar.Rows.Add(r["Fname"], r["Family"], r["P_Num"], "", "صبح", 0);
                    }

                    DataRow[] asrRows = MainForm.PersonTable.Select($"P_Post='راهبر قطار' AND Shift_name='{asr}' AND Vis=True");
                    foreach (DataRow r in asrRows)
                    {
                        Rahbar.Rows.Add(r["Fname"], r["Family"], r["P_Num"], "", "عصر", 0);
                    }

                    // رزرو
                    using (OleDbCommand cmd = new OleDbCommand($"SELECT Rezerv.P_Num FROM Rezerv INNER JOIN Person ON Rezerv.P_Num=Person.P_Num WHERE Rezerv.Vis=True AND Rezerv.Tarikh='{DateLabel.Text}' AND Person.P_Post='راهبر قطار'", StrConnec))
                    using (dynamic rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            DataRow[] rows = Rahbar.Select($"PNum='{rdr["P_Num"]}'");
                            if (rows.Length > 0)
                            {
                                rows[0]["Type"] = "رزرو";
                            }
                        }
                    }


                    // مرخصی
                    using (OleDbCommand cmd = new OleDbCommand($"SELECT Morakhasi.P_Num FROM Morakhasi INNER JOIN Person ON Morakhasi.P_Num=Person.P_Num WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh='{DateLabel.Text}' AND Person.P_Post='راهبر قطار'", StrConnec))
                    using (dynamic rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            DataRow[] rows = Rahbar.Select($"PNum='{rdr["P_Num"]}'");
                            if (rows.Length > 0)
                            {
                                rows[0]["Type"] = "مرخصی";
                            }
                        }
                    }


                    // شمارش سفرها
                    foreach (DataRow r in Rahbar.Rows)
                    {
                        string tripCount = DtSet.Tables[0].Select($"PNum='{r["PNum"]}'").Count().ToString();
                        r["TripCount"] = tripCount;
                    }
                }


                // بروزرسانی شمارنده‌ها
                RefreshRahbarStats();
                Enabled = true;

            }
            catch (Exception ex)
            {
                Enabled = true;
                MessageBoxFa.Show("خطا در تحلیل فایل‌ها: " + ex.Message, "خطا", MessageBoxIcon.Error);
            }
        }

        //----------------------- ثبت در دیتابیس -----------------------
        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TripGridView.Rows.Count == 0)
                {
                    ErrorShow(Analys5Button, "هیچ لوحه ای تحلیل نشده است");
                    return;
                }

                if (ImportChecker(DateLabel.Text) && AppState.UserLevel > 0)
                {
                    ErrorShow(DateLabel, "لوحه اولیه " + DateLabel.Text + " ثبت شده است");
                    return;
                }

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    Taghvim StartDate = new Taghvim(MainForm.PersianToday.Tarikh()), EndDate = new Taghvim(MainForm.PersianToday.Tarikh());
                    StartDate.AddDay(-2);
                    EndDate.AddDay(-9);
                    using (OleDbCommand CMD = new OleDbCommand($"UPDATE DailyTrip SET Vis=True AND Prime=True WHERE Tarikh BETWEEN {StartDate.Tarikh()} AND {EndDate.Tarikh()}", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }

                    foreach (DataGridViewRow row in TripGridView.Rows)
                    {
                        if (row.IsNewRow)
                        {
                            continue;
                        }

                        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO DailyTrip (Tarikh, T_Time, Mabdae, Maghsad, O1_NUM, O2_NUM, OT_NUM, Prime, Vis) VALUES (?,?,?,?,?,?,?,True,True)", StrConnec))
                        {
                            cmd.Parameters.AddWithValue("@Tarikh", row.Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@T_Time", row.Cells[2].Value.ToString());
                            cmd.Parameters.AddWithValue("@Mabdae", row.Cells[3].Value.ToString());
                            cmd.Parameters.AddWithValue("@Maghsad", row.Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@O1_NUM", row.Cells[6].Value.ToString());
                            cmd.Parameters.AddWithValue("@O2_NUM", row.Cells[8].Value.ToString());
                            cmd.Parameters.AddWithValue("@OT_NUM", row.Cells[10].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }

                    DateLabel.Text = TripGridView.Rows[TripGridView.Rows.Count - 1].Cells[1].Value.ToString();
                    using (OleDbCommand CMD = new OleDbCommand("INSERT INTO DailyTripReg (Tarikh, T_Type, U_Reg, T_Reg, Vis) VALUES ('" + DateLabel.Text + "','لوحه اولیه', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }


                // بازنشانی رابط کاربری
                //    wait.Close();
                //}
                Enabled = true;
                TotalBox.Text = "0";
                TripNBox.Text = "0";
                OddBox.Text = "0";
                RezFBox.Text = "0";
                MorFBox.Text = "0";
                Name5Box.Text = "";
                Name51Box.Text = "";
                TripGridView.Rows.Clear();
                DateLabel.Text = "";
                Line5Label.Visible = false;
                Line51Label.Visible = false;
                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }


        //----------------------- آمار راهبران -----------------------
        private void RefreshRahbarStats()
        {
            try
            {
                System.Int32 TripN = 0;
                System.Int32 TripF = 0;
                System.Int32 RezF = 0;
                System.Int32 MorF = 0;
                foreach (DataRow r in Rahbar.Rows)
                {
                    System.Int32 t = Convert.ToInt32(r["TripCount"]);
                    object typ = r["Type"].ToString();
                    if ((string)typ == "رزرو")
                    {
                        if (t != 0)
                        {
                            RezF++;
                        }
                    }
                    else if ((string)typ == "مرخصی")
                    {
                        if (t != 0)
                        {
                            MorF++;
                        }
                    }
                    else
                    {
                        if (t == 0)
                        {
                            TripN++;
                        }
                    }
                    if (t % 2 == 1)
                    {
                        TripF++;
                    }
                }
                TotalBox.Text = Rahbar.Rows.Count.ToString();
                TripNBox.Text = TripN.ToString();
                OddBox.Text = TripF.ToString();
                RezFBox.Text = RezF.ToString();
                MorFBox.Text = MorF.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void ShowRahbarList(string filter)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                switch (filter)
                {
                    case "TripN":
                        sb.AppendLine("راهبرانی که تریپ ندارند:");
                        foreach (DataRow r in Rahbar.Select("TripCount = 0 AND (Type='' OR Type IS NULL)"))
                        {
                            sb.AppendLine($"{r["FullName"]} {r["Family"]} - {r["PNum"]}");
                        }
                        break;
                    case "Odd":
                        sb.AppendLine("راهبرانی که تعداد تریپ شان فرد است:");
                        foreach (DataRow r in Rahbar.Select("TripCount Mod 2 = 1"))
                        {
                            sb.AppendLine($"{r["FullName"]} {r["Family"]} - {r["PNum"]}");
                        }
                        break;
                    case "Rez":
                        sb.AppendLine("رزرو شده‌ها با تریپ:");
                        foreach (DataRow r in Rahbar.Select("Type='رزرو' AND TripCount>0"))
                        {
                            sb.AppendLine($"{r["FullName"]} {r["Family"]} - {r["PNum"]}");
                        }
                        break;
                    case "Mor":
                        sb.AppendLine("مرخصی‌ها با تریپ:");
                        foreach (DataRow r in Rahbar.Select("Type='مرخصی' AND TripCount>0"))
                        {
                            sb.AppendLine($"{r["FullName"]} {r["Family"]} - {r["PNum"]}");
                        }
                        break;
                    default:
                        sb.AppendLine("کل راهبران:");
                        foreach (DataRow r in Rahbar.Rows)
                        {
                            sb.AppendLine($"{r["FullName"]} {r["Family"]} - {r["PNum"]} {r["Type"]} - نیم راه: {r["TripCount"]}");
                        }
                        break;
                }

                MessageBoxFa.Show(sb.Length == 0 ? "موردی یافت نشد" : sb.ToString(), "جزئیات راهبران", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TripNBox_Click(object sender, EventArgs e)
        {
            ShowRahbarList("TripN");
        }
        public void OddBox_Click(object sender, EventArgs e)
        {
            ShowRahbarList("Odd");
        }
        public void RezFBox_Click(object sender, EventArgs e)
        {
            ShowRahbarList("Rez");
        }
        public void MorFBox_Click(object sender, EventArgs e)
        {
            ShowRahbarList("Mor");
        }
        public void TotalBox_Click(object sender, EventArgs e)
        {
            ShowRahbarList("All");
        }

        //----------------------- بستن فرم -----------------------
        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
