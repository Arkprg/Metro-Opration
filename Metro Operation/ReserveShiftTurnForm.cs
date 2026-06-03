using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ReserveShiftTurnForm
    {
        public ReserveShiftTurnForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public static bool LastTrip(DateTime Trip, string ShiftTime)
        {
            if (ShiftTime == "12 ساعته")
            {
                if (Trip.TimeOfDay < new TimeSpan(7, 1, 0))
                {
                    return true;
                }
            }
            else if (ShiftTime == "9 ساعته")
            {
                if ((Trip.TimeOfDay > new TimeSpan(11, 1, 0) && Trip.TimeOfDay < new TimeSpan(13, 30, 0)) || Trip.TimeOfDay > new TimeSpan(19, 01, 0))
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, " مبدا را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, " نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, " شیفت را مشخص کنید");
                }
                else
                {

                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        ShowGridView.Rows.Clear();

                        int i = 0;
                        ShowGridView.Rows.Clear();

                        string QueStr = "Vis=True AND P_Post='راهبر قطار'";
                        if (AppState.UserLevel > 1)
                        {
                            QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                        }
                        if ((string)LocalCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem + "'";
                        }
                        if ((string)ShiftCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_name='" + ShiftCombo.SelectedItem + "'";
                        }
                        if ((string)TimeCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                        }
                        DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "Family");
                        foreach (DataRow DtR in DRow)
                        {
                            ShowGridView.Rows.Add(i, DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0, 0, 0, 0, 0, "", 0.0);
                            i++;
                        }

                        int Emer = 0; //, LTrip, MorDay, MorTime, Pos, Neg
                        int Trp = 0;
                        int Rez = 0;
                        int MorDay = 0;
                        double Emt = 0;
                        double LastRez = 0;
                        Taghvim PersianDate = new Taghvim();
                        PersianDate.SetDate(DateTime.Today);
                        PersianDate.AddMonth(-(MonthCombo.SelectedIndex + 1));
                        DateTime SelectDate;
                        DateTime Dat;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            for (i = 0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                SelectDate = DateTime.Today;

                                Emer = 0;
                                Trp = 0;
                                Rez = 0;
                                MorDay = 0;
                                Emt = 0;
                                LastRez = 0;

                                using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' AND Tarikh BETWEEN '" + MainForm.PersianToday.Tarikh() + "' AND '" + PersianDate.Tarikh() + "' AND Vis=True AND Mem<>'شانتر'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        Dat = ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                        ShowGridView.Rows[i].Cells[9].Value = Reader["Tarikh"].ToString();

                                        if (!string.IsNullOrEmpty(Reader["Trip1"].ToString())) Trp += 1;
                                        if (!string.IsNullOrEmpty(Reader["Trip2"].ToString())) Trp += 1;
                                        if (!string.IsNullOrEmpty(Reader["Trip3"].ToString())) Trp += 1;

                                        LastRez = (double)Convert.ToInt32(Reader["Tarikh"].ToString().Substring(2, 8).Replace("/", "")) / 1000000;

                                        if (Reader["Mem"].ToString().IndexOf("اضطراری") + 1 > 0)
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
                                            Emt++;
                                        }
                                        else if (Dat == SelectDate.AddDays(-4))
                                        {
                                            Emt += 0.5;
                                        }
                                    }
                                }

                                using (OleDbCommand CMD = new OleDbCommand("SELECT Tarikh FROM Morakhasi WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' AND Vis=True AND Tarikh BETWEEN '" + MainForm.PersianToday.Tarikh() + "' AND '" + PersianDate.Tarikh() + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        Dat = ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                        if (Dat == SelectDate.AddDays(-1))
                                        {
                                            Emt += 2;
                                        }
                                        else if (Dat == SelectDate.AddDays(-2))
                                        {
                                            Emt++;
                                        }
                                    }
                                }

                                using (OleDbCommand CMD = new OleDbCommand("SELECT COUNT(Tarikh) AS Morakh FROM Morakhasi WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' AND Vis=True AND Tarikh BETWEEN '" + MainForm.PersianToday.Tarikh() + "' AND '" + PersianDate.Tarikh() + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        MorDay = Convert.ToInt32(Reader["Morakh"]);
                                    }
                                }

                                ShowGridView.Rows[i].Cells[4].Value = Rez;
                                ShowGridView.Rows[i].Cells[5].Value = Trp;
                                ShowGridView.Rows[i].Cells[6].Value = Emer;
                                ShowGridView.Rows[i].Cells[7].Value = MorDay;
                                ShowGridView.Rows[i].Cells[10].Value = Emt + Rez + Emer + LastRez;                               
                            }
                        }

                        if (ShowGridView.RowCount > 0)
                        {
                            ShowGridView.CurrentRow.Selected = false;
                            //if (AppState.UserLevel == 0)
                            //{
                            //    ShowGridView.Sort(ShowGridView.Columns[10], System.ComponentModel.ListSortDirection.Ascending);
                            //}
                        }
                        wait.Close();
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

        public void RezerveShiftTurnForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0305");
        }

        public void RezerveShiftTurnForm_Load(object sender, EventArgs e)
        {
            LocalCombo.Items.Clear();

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

            MonthCombo.SelectedIndex = 1;
            if (AppState.UserLevel > 0)
            {
                // MonthCombo.Visible = false;
                // Label2.Visible = false;
                ShowGridView.Columns[6].Visible = false;
                ShowGridView.Columns[10].Visible = false;

                if (AppState.UserLevel > 5)
                {
                    ExportButton.Visible = false;
                }
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

        public void DetailGridView_Sorted(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= ShowGridView.RowCount - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex = -1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr = "Vis=True AND P_Post='راهبر قطار'";
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
                if (TimeCombo.Enabled)
                {
                    ShiftCombo.SelectedIndex = -1;
                    if (TimeCombo.SelectedIndex >= 0)
                    {
                        ShiftCombo.Items.Clear();
                        ShiftCombo.Items.Add("همه موارد");
                        string QueStr = "Vis=True AND P_Post='راهبر قطار'";
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
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void ShowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShowGridView.RowCount > 0 && e.RowIndex >= 0)
            {
                Taghvim PersianDate = new Taghvim();
                PersianDate.SetDate(DateTime.Today);
                PersianDate.AddMonth(-(MonthCombo.SelectedIndex + 1));

                DetailShwoForm ShowForm = new DetailShwoForm();
                ShowForm.TitrLabel.Text = "رزرو راهبران";
                ShowForm.TimeLabel.Text = PersianDate.Tarikh() + " تا " + MainForm.PersianToday.Tarikh();
                ShowForm.FName = ShowGridView.CurrentRow.Cells[1].Value.ToString();
                ShowForm.Family = ShowGridView.CurrentRow.Cells[2].Value.ToString();
                ShowForm.Pnum = ShowGridView.CurrentRow.Cells[3].Value.ToString();

                ShowForm.Command = "SELECT Tarikh, U_Reg, R_Shift, Mem, Trip1, Trip2, Trip3 FROM Rezerv WHERE Vis=True AND P_Num='" + ShowGridView.CurrentRow.Cells[3].Value + "' AND Tarikh BETWEEN '" + MainForm.PersianToday.Tarikh() + "' AND '" + PersianDate.Tarikh() + "' ORDER BY Tarikh DESC";
                ShowForm.ShowDialog(this);
                ShowGridView.CurrentRow.Selected = false;
            }
        }
    }
}