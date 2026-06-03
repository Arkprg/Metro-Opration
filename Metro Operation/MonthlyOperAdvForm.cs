using ClosedXML.Excel;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class MonthlyOperAdvForm
    {
        public MonthlyOperAdvForm()
        {
            InitializeComponent();
        }


        private string PNum = "";
        private readonly Taghvim PersianDate = new Taghvim(DateTime.Today);
        private string Loc = "";

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private void Display()
        {
            try
            {
                using (WaitForm wait = new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    Enabled = false;

                    ShowGridView.Rows.Clear();

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        DataTable TempTable = new DataTable();
                        string StrQuer = "SELECT Person.Fname, Person.Family, Person.P_Num, Person.Shift_Loc, Person.Shift_Time, Person.Shift_name, TotaMonAdv.Days, TotaMonAdv.Shift, TotaMonAdv.Trips, TotaMonAdv.PasMo, TotaMonAdv.EzShift, TotaMonAdv.EzJoShift, TotaMonAdv.Eza, TotaMonAdv.EzJom, TotaMonAdv.PAmal, TotaMonAdv.NAmal, TotaMonAdv.MorSaat, TotaMonAdv.MorDay, TotaMonAdv.TotaJom, TotaMonAdv.FogJom, TotaMonAdv.Tota, TotaMonAdv.NexMo FROM TotaMonAdv INNER JOIN Person ON Person.P_Num=TotaMonAdv.P_Num WHERE Person.Vis=True And TotaMonAdv.Maah='" + PersianDate.Tarikh().Substring(0, 7) + "'";
                        if (AppState.UserLevel == 4 || AppState.UserLevel == 9 || AppState.UserLevel == 19)
                        {
                            StrQuer += " AND Person.P_Num='" + AppState.UserPnum + "'";
                        }
                        else
                        {
                            if (AppState.UserLevel > 1)
                            {
                                StrQuer += " And Person.Line_Num='" + AppState.UserLnum + "'";
                            }

                            if (AppState.UserLevel > 4)
                            {
                                StrQuer += " AND Person.P_Staff='" + AppState.UserStaff + "'";
                            }

                            if ((string)LocalCombo.SelectedItem != "همه موارد")
                            {
                                StrQuer += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                            }

                            //If LocalCombo.SelectedItem <> "همه موارد" Then StrQuer += " AND Person.Shift_Loc='" & LocalCombo.SelectedItem.ToString & "'"
                            //If AppState.UserLevel > 3 Then StrQuer += " AND Person.Shift_Loc='" & LocalCombo.SelectedItem.ToString & "'"
                            if ((string)PostCombo.SelectedItem != "همه موارد")
                            {
                                StrQuer += " AND Person.P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                            }

                            if ((string)TimeCombo.SelectedItem != "همه موارد")
                            {
                                StrQuer += " AND Person.Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                            }

                            if ((string)ShiftCombo.SelectedItem != "همه موارد")
                            {
                                StrQuer += " AND Person.Shift_name='" + ShiftCombo.SelectedItem.ToString() + "'";
                            }
                        }
                        StrQuer += " ORDER BY Person.Family, Person.Fname";
                        using (OleDbDataAdapter Adap = new OleDbDataAdapter(StrQuer, StrConnec))
                        {
                            Adap.Fill(TempTable);
                        }

                        Enabled = true;
                        string ShCal = "";
                        string LocName = "";
                        string ShTime = "";
                        string ShName = "";

                        int i;
                        for (i = 0; i <= TempTable.Rows.Count - 1; i++)
                        {
                            ShCal = "";
                            ShTime = "";
                            ShName = "";
                            LocName = TempTable.Rows[i]["Shift"].ToString();

                            if (TempTable.Rows[i]["Shift"].ToString().Length == 5)
                            {
                                if (TempTable.Rows[i]["Shift"].ToString().Substring(0, 1) == "P")
                                {
                                    ShCal = "راهبر پایانه";
                                }
                                else if (TempTable.Rows[i]["Shift"].ToString().Substring(0, 1) == "R")
                                {
                                    ShCal = "راهبر قطار";
                                }
                                else
                                {
                                    ShCal = "سایر پرسنل";
                                }

                                if (TempTable.Rows[i]["Shift"].ToString().Substring(2, 1) == "T")
                                {
                                    ShTime = "12 ساعته";
                                }
                                else if (TempTable.Rows[i]["Shift"].ToString().Substring(2, 1) == "N")
                                {
                                    ShTime = "9 ساعته";
                                }
                                else
                                {
                                    ShTime = "ستادی";
                                }

                                if (TempTable.Rows[i]["Shift"].ToString().Substring(3, 1) == "S")
                                {
                                    ShName = "ستادی";
                                }
                                else
                                {
                                    ShName = TempTable.Rows[i]["Shift"].ToString().Substring(3, 1);
                                }

                                if (TempTable.Rows[i]["Shift"].ToString().Substring(4, 1) == "T")
                                {
                                    LocName = "تهران";
                                }
                                else if (TempTable.Rows[i]["Shift"].ToString().Substring(4, 1) == "P")
                                {
                                    LocName = "پایانه تهران";
                                }
                                else if (TempTable.Rows[i]["Shift"].ToString().Substring(4, 1) == "G")
                                {
                                    LocName = "گلشهر";
                                }
                                else if (TempTable.Rows[i]["Shift"].ToString().Substring(4, 1) == "M")
                                {
                                    LocName = "پایانه مهرشهر";
                                }
                                else if (TempTable.Rows[i]["Shift"].ToString().Substring(4, 1) == "H")
                                {
                                    LocName = "هشتگرد";
                                }
                                else
                                {
                                    LocName = " ";
                                }
                            }

                            ShowGridView.Rows.Add(i + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Trips"].ToString(), TempTable.Rows[i]["PasMo"].ToString(), TempTable.Rows[i]["Days"].ToString(), TempTable.Rows[i]["EzShift"].ToString(), TempTable.Rows[i]["EzJoShift"].ToString(), TempTable.Rows[i]["Eza"].ToString(), TempTable.Rows[i]["EzJom"].ToString(), TempTable.Rows[i]["MorSaat"].ToString(), TempTable.Rows[i]["MorDay"].ToString(), TempTable.Rows[i]["FogJom"].ToString(), TempTable.Rows[i]["TotaJom"].ToString(), TempTable.Rows[i]["Tota"].ToString(), TempTable.Rows[i]["NexMo"].ToString(), ShCal, LocName, ShTime, ShName);
                        }

                        TempTable.Dispose();
                    }
                }


                if (ShowGridView.Rows.Count == 0)
                {
                    MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                }
                else
                {
                    ShowGridView.CurrentRow.Selected = false;
                    if (AppState.UserLevel == 4 || AppState.UserLevel == 9 || AppState.UserLevel == 19 || TabControl1.SelectedIndex > 0)
                    {
                        if (!string.IsNullOrEmpty(Loc))
                        {
                            for (int i = 0; i <= ShowGridView.Rows.Count - 1; i++)
                            {
                                if (Loc == ShowGridView.Rows[i].Cells[3].Value.ToString())
                                {
                                    ShowGridView.CurrentCell = ShowGridView.Rows[i].Cells[0];
                                    TabControl1_SelectedIndexChanged(null, null);
                                }
                            }
                        }
                    }
                }
                ShowButton.Focus();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public double DaysWeek(string Tarikh, OleDbConnection StrConnec)
        {
            double Resualt = 0;

            using (OleDbCommand CMD = new OleDbCommand("SELECT rooz, Holi, kasri FROM Taghvim WHERE Tarikh='" + Tarikh + "'", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    if (Reader["rooz"].ToString() == "7" || (bool)Reader["Holi"])
                    {
                        Resualt = -1;
                    }
                    else if (Reader["rooz"].ToString() == "6" && (bool)Reader["Holi"])
                    {
                        Resualt = -2;
                    }
                    else if (ConvertClass.TimeToDouble(Reader["kasri"].ToString()) > 0)
                    {
                        Resualt = ConvertClass.TimeToDouble(Reader["kasri"].ToString());
                    }
                }
            }

            return Resualt;
        }

        public string DailyShift(string Shift, string Tarikh, OleDbConnection StrConnec)
        {
            string Resualt = "";
            using (OleDbCommand CMD = new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + Tarikh + "'", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    if (Reader["Sobh"].ToString() == Shift)
                    {
                        Resualt = "صبح کار";
                    }
                    else if (Reader["Asr"].ToString() == Shift)
                    {
                        Resualt = "عصر کار";
                    }
                    else
                    {
                        Resualt = "استراحت";
                    }
                }
            }

            return Resualt;
        }

        public string DailyTrip(string Tarikh, OleDbConnection StrConnec)
        {
            string Resualt = "";
            using (OleDbCommand CMD = new OleDbCommand("SELECT COUNT(ID) AS Coun FROM DailyTrip WHERE Vis=True AND Tarikh='" + Tarikh + "'  AND Execu=True And (O1_Num ='" + PNum + "' OR O2_Num='" + PNum + "' OR OT_Num='" + PNum + "')", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Resualt = Reader["Coun"].ToString();
                }
            }

            return Resualt;
        }

        public bool DailyLeave(string Tarikh, OleDbConnection StrConnec)
        {
            bool Resualt = false;
            using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM Morakhasi WHERE Vis=True AND Tarikh='" + Tarikh + "' AND P_Num='" + PNum + "'", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Resualt = true;
                }
            }

            return Resualt;
        }

        public double TimeLeave(string Tarikh, OleDbConnection StrConnec)
        {
            double Resualt = 0;
            using (OleDbCommand CMD = new OleDbCommand("SELECT Amal FROM Amal WHERE Vis=True AND OnvAmal='ساعتی' AND Tarikh='" + Tarikh + "' AND P_Num='" + PNum + "'", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    double SSaati = 0;
                    double ESaati = 0;
                    SSaati = ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(0, 5));
                    ESaati = ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(9, 5));
                    if (SSaati > ESaati)
                    {
                        ESaati += 24;
                    }

                    Resualt = ESaati - SSaati;
                }
            }

            return Resualt;
        }

        public double OverTime(string Tarikh, OleDbConnection StrConnec)
        {
            double Resualt = 0;
            using (OleDbCommand CMD = new OleDbCommand("SELECT E_Time FROM Ezafeh WHERE Vis=True AND Tarikh='" + Tarikh + "' AND P_Num='" + PNum + "'", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Resualt += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                }
            }

            return Resualt;
        }

        public bool DailyReserv(string Tarikh, OleDbConnection StrConnec)
        {
            bool Resualt = false;
            using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Rezerv WHERE Vis=True AND Tarikh='" + Tarikh + "' AND P_Num='" + PNum + "'", StrConnec))
            using (OleDbDataReader Reader = CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Resualt = true;
                }
            }

            return Resualt;
        }

        public void MonthlyOperAdvForm_Load(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();
                LocalCombo.Items.Clear();
                LastMonthText.Font = ShiftOverText.Font = ShiftFriText.Font = OverText.Font = OverFriText.Font = TripText.Font = TimeLeavText.Font = DayLeavText.Font = SumOverText.Font = SumFriText.Font = FogFriText.Font = NextMonthText.Font = FontManager.Yekan(16);
                LastMonthText.BackColor = ShiftOverText.BackColor = ShiftFriText.BackColor = OverText.BackColor = OverFriText.BackColor = TripText.BackColor = TimeLeavText.BackColor = DayLeavText.BackColor = SumOverText.BackColor = SumFriText.BackColor = FogFriText.BackColor = NextMonthText.BackColor = Color.FromArgb(210, 210, 210);
                LastMonthText.BorderStyle = ShiftOverText.BorderStyle = ShiftFriText.BorderStyle = OverText.BorderStyle = OverFriText.BorderStyle = TripText.BorderStyle = TimeLeavText.BorderStyle = DayLeavText.BorderStyle = SumOverText.BorderStyle = SumFriText.BorderStyle = FogFriText.BorderStyle = NextMonthText.BorderStyle = BorderStyle.FixedSingle;
                ShowGridView.ColumnHeadersHeight = 60;

                if (AppState.UserLevel == 4 || AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    TabControl1.TabPages.Remove(TabPage3);
                    TabControl1.TabPages.Remove(TabPage1);
                    LocalCombo.Items.Add(AppState.UserLocal);

                    PNum = AppState.UserPnum;
                    Loc = PNum;
                    LocalCombo.SelectedItem = AppState.UserLocal;
                    LocalCombo.Enabled = false;
                    PostCombo.SelectedItem = AppState.UserPost;
                    PostCombo.Enabled = false;
                    TimeCombo.SelectedItem = AppState.UserTime;
                    TimeCombo.Enabled = false;
                    ShiftCombo.SelectedItem = AppState.UserShift;
                    ShiftCombo.Enabled = false;

                }
                else
                {
                    if (AppState.UserLevel < 6)
                    {
                        LocalCombo.Items.Add("همه موارد");
                    }

                    foreach (string Local in MainForm.Locals)
                    {
                        if (!string.IsNullOrEmpty(Local))
                        {
                            LocalCombo.Items.Add(Local);
                        }
                    }
                    if (LocalCombo.Items.Count > 0)
                    {
                        LocalCombo.SelectedIndex = 0;
                    }
                }

                YearCombo.Items.Add(PersianDate.Year() - 1);
                YearCombo.Items.Add(PersianDate.Year());

                YearCombo.Text = PersianDate.Year().ToString();
                MonthCombo.SelectedIndex = PersianDate.Month() - 1;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog()
                {
                    Filter = "Excel Files|*.xlsx|Excel Files 97-2003|*.xls"
                };

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();

                        DataTable Dt = new DataTable();
                        foreach (DataGridViewColumn Column in ShowGridView.Columns)
                        {
                            Dt.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in ShowGridView.Rows)
                        {
                            Dt.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt.Rows[Dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }
                        using (XLWorkbook Wb = new XLWorkbook())
                        {
                            Wb.RightToLeft = true;
                            Wb.Style.Alignment.Horizontal = (XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            Wb.AddWorksheet(Dt, "Sheet1").AsRange();
                            Wb.SaveAs(SaveFileDialog1.FileName);
                        }


                        wait.Close();
                    }
                    MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
            if (MonthCombo.SelectedIndex >= 0)
            {
                PersianDate.SetDate(YearCombo.SelectedItem + "/" + (MonthCombo.SelectedIndex + 1).ToString("00") + "/01");
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabControl1.SelectedIndex > 0 && PNum1Label.Text != "")
                {
                    PNum = PNum1Label.Text;
                }
                ShowGridView.Rows.Clear();
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "مبدا شروع به کار را مشخص کنید");
                }
                else if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "نام شیفت را مشخص کنید");
                }
                else if (YearCombo.SelectedIndex < 0)
                {
                    ErrorShow(YearCombo, "سال را مشخص کنید");
                }
                else if (MonthCombo.SelectedIndex < 0)
                {
                    ErrorShow(MonthCombo, "ماه را مشخص کنید");
                }
                else
                {
                    Display();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PostCombo.SelectedIndex = -1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    PostCombo.Items.Clear();
                    PostCombo.Items.Add("همه موارد");

                    string QueStr = "Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "P_Post");
                    foreach (DataRow DtR in DRow)
                    {
                        if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                        {
                            PostCombo.Items.Add(DtR["P_Post"].ToString());
                        }
                    }
                    PostCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex = -1;
                if (PostCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr = "Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "Shift_Time");
                    foreach (DataRow DtR in DRow)
                    {
                        if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                        {
                            TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                        }
                    }
                    TimeCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();
                if (TimeCombo.SelectedIndex >= 0 && ShiftCombo.Enabled)
                {
                    ShiftCombo.SelectedIndex = -1;
                    ShiftCombo.Items.Clear();
                    ShiftCombo.Items.Add("همه موارد");
                    string QueStr = "Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "Shift_name");
                    foreach (DataRow DtR in DRow)
                    {
                        if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                        {
                            ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                        }
                    }
                    ShiftCombo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PervButton_Click(object sender, EventArgs e)
        {
            PersianDate.AddMonth(-1);
            if (YearCombo.Items.IndexOf(PersianDate.Year()) >= 0)
            {
                YearCombo.Text = PersianDate.Year().ToString();
                MonthCombo.SelectedIndex = PersianDate.Month() - 1;
            }
            else
            {
                PersianDate.AddMonth(1);
            }

            Display();
        }

        public void NextButton_Click(object sender, EventArgs e)
        {
            PersianDate.AddMonth(1);
            if (YearCombo.Items.IndexOf(PersianDate.Year()) >= 0)
            {
                YearCombo.Text = PersianDate.Year().ToString();
                MonthCombo.SelectedIndex = PersianDate.Month() - 1;
            }
            else
            {
                PersianDate.AddMonth(-1);
            }

            Display();
        }

        public void YearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthCombo.SelectedIndex = -1;
        }

        public void ShowGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Loc = ShowGridView.CurrentRow.Cells[3].Value.ToString();
                TabControl1.SelectedIndex = 1;
            }
        }

        public void OverText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "اضافه کار ثبت شده";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            ShowForm.Command = "SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem, E_Local FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' AND NOT ISNULL(U_Reg) ORDER BY Tarikh DESC";
            ShowForm.Week = "NonFriday";
            ShowForm.ShowDialog(this);
        }

        public void PosText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "امتیاز مثبت";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            ShowForm.Command = "SELECT Tarikh, U_Reg, Amal, Mem FROM Amal WHERE Vis=True AND OnvAmal='مثبت' AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void NegText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "امتیاز منفی";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            ShowForm.Command = "SELECT Tarikh, U_Reg, Amal, Mem FROM Amal WHERE Vis=True AND OnvAmal='منفی' AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void TimeLeavText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "مرخصی ساعتی";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            ShowForm.Command = "SELECT Tarikh, U_Reg, Amal FROM Amal WHERE Vis=True AND OnvAmal='ساعتی' AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void DayLeavText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "مرخصی روزانه";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            //DetailShwoForm.Command="SELECT Tarikh, U_Reg, Kind FROM Morakhasi WHERE Vis=True AND P_Num='" & PNum1Label.Text & "' AND Tarikh BETWEEN '" & PersianDate.FirstOfThisMonth & "' AND '" & PersianDate.EndOfThisMonth & "' ORDER BY Tarikh"

            //DetailShwoForm.Command="SELECT Morakhasi.Tarikh, Morakhasi.U_Reg, Morakhasi.Kind, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem FROM Morakhasi LEFT JOIN Rezerv ON Rezerv.P_Num=Morakhasi.P_Num WHERE (Morakhasi.Vis=True AND Morakhasi.P_Num='" & PNum1Label.Text & "' AND Morakhasi.Tarikh BETWEEN '" & PersianDate.FirstOfThisMonth & "' AND '" & PersianDate.EndOfThisMonth & "') OR (Rezerv.Vis=True AND Rezerv.P_Num='" & PNum1Label.Text & "' AND Rezerv.Tarikh BETWEEN '" & PersianDate.FirstOfThisMonth & "' AND '" & PersianDate.EndOfThisMonth & "') ORDER BY Morakhasi.Tarikh"

            ShowForm.Command = "SELECT Tarikh, U_Reg, Kind FROM Morakhasi WHERE Vis=True AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' UNION SELECT Tarikh, U_Reg, Mem FROM Rezerv WHERE Vis=True AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' AND Mem Like 'غیر فعال%'";

            ShowForm.ShowDialog(this);
        }

        public void OverFriText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "اضافه کار جمعه ثبت شده";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            ShowForm.Command = "SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' ORDER BY Tarikh DESC";
            ShowForm.Week = "Friday";
            ShowForm.ShowDialog(this);
        }

        public void TripText_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TitrLabel.Text = "تریپ های نهایی";
            ShowForm.TimeLabel.Text = PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            ShowForm.FName = Name1Label.Text;
            ShowForm.Family = Family1Label.Text;
            ShowForm.Pnum = PNum1Label.Text;

            ShowForm.Command = "Select Tarikh, U_Reg, T_Time, Mabdae FROM DailyTrip WHERE Vis=True AND Final=True AND (O1_Num='" + PNum1Label.Text + "' OR O2_Num='" + PNum1Label.Text + "' OR OT_Num='" + PNum1Label.Text + "') AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' ORDER BY Tarikh DESC,T_Time";
            ShowForm.ShowDialog(this);
        }

        public void ShowGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i = 0; i <= ShowGridView.Rows.Count - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (WaitForm wait = new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    if (TabControl1.SelectedTab.Text == "نمایش جزئیات")
                    {                  
                        Name1Label.Text = "";
                        Family1Label.Text = "";
                        PNum1Label.Text = "";
                        Post1Label.Text = "";
                        Local1Label.Text = "";
                        Time1Label.Text = "";
                        Shift1Label.Text = "";

                        LastMonthText.Text = "";
                        ShiftOverText.Text = "";
                        ShiftFriText.Text = "";
                        OverText.Text = "";
                        OverFriText.Text = "";
                        PosText.Text = "";
                        NegText.Text = "";
                        TimeLeavText.Text = "";
                        DayLeavText.Text = "";
                        TripText.Text = "";
                        FogFriText.Text = "";
                        SumFriText.Text = "";
                        SumOverText.Text = "";
                        NextMonthText.Text = "";

                        if (!string.IsNullOrEmpty(Loc) && ShowGridView.Rows.Count > 0)
                        {
                            Name1Label.Text = ShowGridView.CurrentRow.Cells[1].Value.ToString();
                            Family1Label.Text = ShowGridView.CurrentRow.Cells[2].Value.ToString();
                            PNum = PNum1Label.Text = ShowGridView.CurrentRow.Cells[3].Value.ToString();
                            Post1Label.Text = ShowGridView.CurrentRow.Cells[17].Value.ToString();
                            Local1Label.Text = ShowGridView.CurrentRow.Cells[18].Value.ToString();
                            Time1Label.Text = ShowGridView.CurrentRow.Cells[19].Value.ToString();
                            Shift1Label.Text = ShowGridView.CurrentRow.Cells[20].Value.ToString();


                            TripText.Text = ShowGridView.CurrentRow.Cells[4].Value.ToString();
                            LastMonthText.Text = ShowGridView.CurrentRow.Cells[5].Value.ToString();
                            ShiftOverText.Text = ShowGridView.CurrentRow.Cells[7].Value.ToString();
                            ShiftFriText.Text = ShowGridView.CurrentRow.Cells[8].Value.ToString();
                            OverText.Text = ShowGridView.CurrentRow.Cells[9].Value.ToString();
                            OverFriText.Text = ShowGridView.CurrentRow.Cells[10].Value.ToString();

                            TimeLeavText.Text = ShowGridView.CurrentRow.Cells[11].Value.ToString();
                            DayLeavText.Text = ShowGridView.CurrentRow.Cells[12].Value.ToString();
                            //PosText.Text=ShowGridView.CurrentRow.Cells(11).Value
                            //NegText.Text=ShowGridView.CurrentRow.Cells(12).Value

                            SumFriText.Text = ShowGridView.CurrentRow.Cells[14].Value.ToString();
                            SumOverText.Text = ShowGridView.CurrentRow.Cells[15].Value.ToString();
                            FogFriText.Text = ShowGridView.CurrentRow.Cells[13].Value.ToString();
                            NextMonthText.Text = ShowGridView.CurrentRow.Cells[16].Value.ToString();                            
                        }
                    }
                    else if (TabControl1.SelectedTab.Text == "تحلیل کارکرد")
                    {                      
                        Name2Label.Text = "";
                        Family2Label.Text = "";
                        PNum2Label.Text = "";
                        Post2Label.Text = "";
                        Local2Label.Text = "";
                        Time2Label.Text = "";
                        Shift2Label.Text = "";

                        ShftNormLabel.Text = "0";
                        ShftFriLabel.Text = "0";
                        ShftTotaLabel.Text = "0";
                        ShftTripLabel.Text = "0";
                        MorNormLabel.Text = "0";
                        MorFriLabel.Text = "0";
                        MorTimeLabel.Text = "0";
                        RezNormLabel.Text = "0";
                        RezFriLabel.Text = "0";
                        RezTripLabel.Text = "0";

                        KeshOverLabel.Text = "00:00";
                        JayOverLabel.Text = "00:00";
                        HamkOverLabel.Text = "00:00";
                        FootOverLabel.Text = "00:00";
                        MotfOverLabel.Text = "00:00";

                        DailyTripLabel.Text = "0";
                        CalcTripLabel.Text = "0";
                        DiffrTripLabel.Text = "0";
                        DiffrTripLabel.BackColor = Color.Transparent;

                        if (!string.IsNullOrEmpty(Loc))
                        {
                            Name2Label.Text = ShowGridView.CurrentRow.Cells[1].Value.ToString();
                            Family2Label.Text = ShowGridView.CurrentRow.Cells[2].Value.ToString();
                            PNum = PNum2Label.Text = ShowGridView.CurrentRow.Cells[3].Value.ToString();
                            Post2Label.Text = ShowGridView.CurrentRow.Cells[17].Value.ToString();
                            Local2Label.Text = ShowGridView.CurrentRow.Cells[18].Value.ToString();
                            Time2Label.Text = ShowGridView.CurrentRow.Cells[19].Value.ToString();
                            Shift2Label.Text = ShowGridView.CurrentRow.Cells[20].Value.ToString();

                            TotalOver2Label.Text = ShowGridView.CurrentRow.Cells[15].Value.ToString();
                            TotalFri2Label.Text = ShowGridView.CurrentRow.Cells[14].Value.ToString();
                            TptalFog2Label.Text = ShowGridView.CurrentRow.Cells[13].Value.ToString();


                            Enabled = false;

                            int NormDay = 0;
                            int FriDay = 0;
                            int DailyTrip = 0;
                            int NormLeav = 0;
                            int FriLeav = 0;
                            int TimeLeave = 0;
                            int NormRez = 0;
                            int FriRez = 0;
                            int TripRez = 0;
                            double KeskOver = 0;
                            double JayOver = 0;
                            double HamkOver = 0;
                            double FootOver = 0;
                            double MotfOver = 0;


                            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();

                                NormDay = 0;
                                FriDay = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT Sobh, Asr, Holi, rooz FROM Taghvim WHERE Tarikh LIKE '" + YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "%'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if ((string)Reader["Sobh"] == Shift2Label.Text || (string)Reader["Asr"] == Shift2Label.Text)
                                        {
                                            if ((bool)Reader["Holi"] || int.Parse(Reader["rooz"].ToString()) == 7)
                                            {
                                                FriDay++;
                                            }
                                            else
                                            {
                                                NormDay++;
                                            }
                                        }
                                    }
                                }

                                NormLeav = 0;
                                FriLeav = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT Holi, rooz FROM Taghvim INNER JOIN Morakhasi ON Taghvim.Tarikh=Morakhasi.Tarikh WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh LIKE '" + YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "%' AND P_Num='" + PNum + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if ((bool)Reader["Holi"] || int.Parse(Reader["rooz"].ToString()) == 7)
                                        {
                                            FriLeav++;
                                        }
                                        else
                                        {
                                            NormLeav++;
                                        }
                                    }
                                }

                                NormRez = 0;
                                FriRez = 0;
                                TripRez = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT Trip1, Trip2, Holi, rooz FROM Taghvim INNER JOIN Rezerv ON Taghvim.Tarikh=Rezerv.Tarikh WHERE Rezerv.Vis=True AND Rezerv.Tarikh LIKE '" + YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "%' AND P_Num='" + PNum + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (ConvertClass.TimeToDouble(Reader["Trip1"].ToString()) > 0)
                                        {
                                            TripRez++;
                                        }

                                        if (ConvertClass.TimeToDouble(Reader["Trip2"].ToString()) > 0)
                                        {
                                            TripRez++;
                                        }

                                        if ((bool)Reader["Holi"] || int.Parse(Reader["rooz"].ToString()) == 7)
                                        {
                                            FriRez++;
                                        }
                                        else
                                        {
                                            NormRez++;
                                        }
                                    }
                                }

                                DailyTrip = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT COUNT(ID) AS Coun FROM DailyTrip WHERE Vis=True AND Tarikh LIKE '" + YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "%' AND (O1_Num='" + PNum + "' OR O2_Num='" + PNum + "' OR OT_Num='" + PNum + "') AND Execu=True", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DailyTrip = Convert.ToInt32(Reader["Coun"]);
                                    }
                                }

                                TimeLeave = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT COUNT(ID) AS Coun FROM Amal WHERE Vis=True AND OnvAmal='ساعتی' AND Tarikh LIKE '" + YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "%' AND P_Num='" + PNum + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        TimeLeave = Convert.ToInt32(Reader["Coun"]);
                                    }
                                }

                                KeskOver = 0;
                                JayOver = 0;
                                HamkOver = 0;
                                FootOver = 0;
                                MotfOver = 0;
                                using (OleDbCommand CMD = new OleDbCommand("SELECT E_Kind, E_Time FROM Ezafeh WHERE Vis=True AND Tarikh LIKE '" + YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "%' AND P_Num='" + PNum + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if ((string)Reader["E_Kind"] == "کشیک")
                                        {
                                            KeskOver += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else if ((string)Reader["E_Kind"] == "اضافه کار" || (string)Reader["E_Kind"] == "اضافه کار شب قبل" || (string)Reader["E_Kind"] == "جایگزین مرخصی روزانه" || (string)Reader["E_Kind"] == "جایگزین مرخصی روزانه شب قبل" || (string)Reader["E_Kind"] == "جایگزین مرخصی ساعتی")
                                        {
                                            JayOver += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else if ((string)Reader["E_Kind"] == "همکاری با شیفت")
                                        {
                                            HamkOver += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else if ((string)Reader["E_Kind"] == "قطار فوق العاده")
                                        {
                                            FootOver += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else
                                        {
                                            MotfOver += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                    }
                                }

                                ShftNormLabel.Text = NormDay.ToString();
                                ShftFriLabel.Text = FriDay.ToString();
                                ShftTotaLabel.Text = NormDay + FriDay.ToString();
                                MorNormLabel.Text = NormLeav.ToString();
                                MorFriLabel.Text = FriLeav.ToString();
                                MorTimeLabel.Text = TimeLeave.ToString();
                                RezNormLabel.Text = NormRez.ToString();
                                RezFriLabel.Text = FriRez.ToString();
                                RezTripLabel.Text = TripRez.ToString();

                                KeshOverLabel.Text = ConvertClass.DoubleToTime(KeskOver);
                                JayOverLabel.Text = ConvertClass.DoubleToTime(JayOver);
                                HamkOverLabel.Text = ConvertClass.DoubleToTime(HamkOver);
                                FootOverLabel.Text = ConvertClass.DoubleToTime(FootOver);
                                MotfOverLabel.Text = ConvertClass.DoubleToTime(MotfOver);

                                ShftTripLabel.Text = (NormDay * 4 + FriDay * 2).ToString();

                                CalcTripLabel.Text = ((NormDay - NormLeav - NormRez) * 4 + (FriDay - FriLeav - FriRez - TimeLeave + TripRez) * 2 + Convert.ToInt32((KeskOver + JayOver + HamkOver) / 3.25) + Convert.ToInt32(FootOver / 5)).ToString();
                                DailyTripLabel.Text = DailyTrip.ToString();
                                DiffrTripLabel.Text = (DailyTrip - double.Parse(CalcTripLabel.Text)).ToString();

                                //TripRez=(NormDay - NormLeav - NormRez) * 4
                                //TripRez=(FriDay - FriLeav - FriRez) * 2
                                //TripRez=TimeLeave * 2
                                //TripRez=TripRez * 2
                                //TripRez=CInt((KeskOver + JayOver + HamkOver) / 3.25)
                                //TripRez=CInt(FootOver / 5)

                                if (double.Parse(DiffrTripLabel.Text) > 0)
                                {
                                    DiffrTripLabel.BackColor = Color.Yellow;
                                }
                                else if (double.Parse(DiffrTripLabel.Text) < 0)
                                {
                                    DiffrTripLabel.BackColor = Color.Tomato;
                                }
                                else
                                {
                                    DiffrTripLabel.BackColor = Color.LightGreen;
                                }
                            }

                            Enabled = true;
                            wait.Close();
                        }
                    }
                    else if (TabControl1.SelectedTab.Text == "تحلیل روزانه")
                    {
                        Name3Label.Text = "";
                        Family3Label.Text = "";
                        PNum3Label.Text = "";
                        Post3Label.Text = "";
                        Local3Label.Text = "";
                        Time3Label.Text = "";
                        Time3Label.Text = "";
                        Shift3Label.Text = "";

                        TotalOver3Label.Text = "";
                        TotalFri3Label.Text = "";
                        TptalFog3Label.Text = "";

                        if (!string.IsNullOrEmpty(Loc) && ShowGridView.Rows.Count > 0)
                        {
                            Name3Label.Text = ShowGridView.CurrentRow.Cells[1].Value.ToString();
                            Family3Label.Text = ShowGridView.CurrentRow.Cells[2].Value.ToString();
                            PNum = PNum3Label.Text = ShowGridView.CurrentRow.Cells[3].Value.ToString();
                            Post3Label.Text = ShowGridView.CurrentRow.Cells[17].Value.ToString();
                            Local3Label.Text = ShowGridView.CurrentRow.Cells[18].Value.ToString();
                            Time3Label.Text = ShowGridView.CurrentRow.Cells[19].Value.ToString();
                            Shift3Label.Text = ShowGridView.CurrentRow.Cells[20].Value.ToString();

                            TotalOver3Label.Text = ShowGridView.CurrentRow.Cells[15].Value.ToString();
                            TotalFri3Label.Text = ShowGridView.CurrentRow.Cells[14].Value.ToString();
                            TptalFog3Label.Text = ShowGridView.CurrentRow.Cells[13].Value.ToString();

                            Daily1GridView.Rows.Clear();
                            Daily2GridView.Rows.Clear();

                            Enabled = false;
                            int i = 0, j = 0, Days = 0;
                            double Work = 0;
                            double Temp = 0;
                            string State = "";
                            string Shift = "";

                            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();

                                Taghvim PersianDate = new Taghvim();
                                PersianDate.SetDate(YearCombo.Text + "/" + (MonthCombo.SelectedIndex + 1).ToString("D2") + "/01");
                                Daily1GridView.Height = 445;
                                Daily2GridView.Height = 445;
                                if (PersianDate.DaysInThisMonth() == 31)
                                {
                                    j = 16;
                                    //Daily1GridView.Height=445;
                                    //Daily2GridView.Height=445;
                                }
                                else
                                {
                                    j = 15;
                                    //Daily1GridView.Height=413;
                                    //Daily2GridView.Height=413;
                                }

                                for (i = 1; i <= PersianDate.DaysInThisMonth(); i++)
                                {
                                    if (PersianDate.Tarikh() == MainForm.PersianToday.Tarikh())
                                    {
                                        break;
                                    }

                                    Shift = DailyShift(ShowGridView.CurrentRow.Cells[20].Value.ToString(), PersianDate.Tarikh(), StrConnec);
                                    Days = (int)DaysWeek(PersianDate.Tarikh(), StrConnec);
                                    if (Shift == "صبح کار" || Shift == "عصر کار")
                                    {
                                        State = "شیفت";

                                        switch (Time3Label.Text)
                                        {
                                            case "12 ساعته":
                                                Work = 16;
                                                break;
                                            case "9 ساعته":
                                                Work = 13;
                                                break;
                                            default:
                                                Work = 9;
                                                break;
                                        }

                                        if (DailyLeave(PersianDate.Tarikh(), StrConnec))
                                        {
                                            State = "مرخصی روزانه";
                                            Work = 9;
                                        }

                                        Temp = TimeLeave(PersianDate.Tarikh(), StrConnec);
                                        if (Temp > 0)
                                        {
                                            State = "مرخصی ساعتی";
                                            Work -= Temp;
                                        }

                                        if (DailyReserv(PersianDate.Tarikh(), StrConnec))
                                        {
                                            State = "رزرو";
                                        }
                                    }
                                    else
                                    {
                                        State = "";
                                        Work = 0;
                                    }

                                    Temp = OverTime(PersianDate.Tarikh(), StrConnec);
                                    if (Temp > 0)
                                    {
                                        if (Shift == "استراحت")
                                        {
                                            State = "اضافه کار";
                                            Work = Temp;
                                        }
                                        else
                                        {
                                            Work += Temp;
                                        }
                                    }

                                    if (i <= j)
                                    {
                                        Daily1GridView.Rows.Add(PersianDate.Tarikh(), Shift, DailyTrip(PersianDate.Tarikh(), StrConnec), State, ConvertClass.DoubleToTime(Work));
                                        if (Days == -1)
                                        {
                                            Daily1GridView.Rows[Daily1GridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                                        }

                                        if (Days == -2)
                                        {
                                            Daily1GridView.Rows[Daily1GridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                                        }

                                        if (State == "اضافه کار")
                                        {
                                            Daily1GridView.Rows[Daily1GridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                                        }

                                        PersianDate.AddDay(1);
                                    }
                                    else
                                    {
                                        Daily2GridView.Rows.Add(PersianDate.Tarikh(), Shift, DailyTrip(PersianDate.Tarikh(), StrConnec), State, ConvertClass.DoubleToTime(Work));
                                        if (Days == -1)
                                        {
                                            Daily2GridView.Rows[Daily2GridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                                        }

                                        if (Days == -2)
                                        {
                                            Daily2GridView.Rows[Daily2GridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                                        }

                                        if (State == "اضافه کار")
                                        {
                                            Daily2GridView.Rows[Daily2GridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                                        }

                                        PersianDate.AddDay(1);
                                    }
                                }
                            }

                        }
                        if (Daily1GridView.Rows.Count > 0)
                        {
                            Daily1GridView.CurrentRow.Selected = false;
                        }

                        Enabled = true;
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

        public void Daily1GridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Daily2GridView.RowCount > 0)
            {
                Daily2GridView.CurrentRow.Selected = false;
            }
        }

        public void Daily2GridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Daily1GridView.RowCount > 0)
            {
                Daily1GridView.CurrentRow.Selected = false;
            }
        }

        private void ShowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loc = ShowGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
