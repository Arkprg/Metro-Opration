using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ManageReservReportForm
    {
        public ManageReservReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "شیفت را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ وارد شده صحیح نیست");
                }
                else if (EndDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ وارد شده صحیح نیست");
                }
                else if (StartDate > EndDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی صحیح نیست");
                    ErrorShow(StartCalendar, "بازه زمانی صحیح نیست");
                }
                else
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        ShowGridView.Rows.Clear();

                        int i=1;

                        string QueStr="Vis=True AND P_Post='راهبر قطار'";
                        if (AppState.UserLevel > 1)
                        {
                            QueStr += " And Line_Num ='" + AppState.UserLnum + "'";
                        }

                        if (AppState.UserLevel < 6)
                        {
                            if ((string)LocalCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                            }
                        }
                        else
                        {
                            QueStr += " And Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                        }
                        if ((string)ShiftCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_name='" + ShiftCombo.SelectedItem + "'";
                        }

                        if ((string)TimeCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                        }

                        DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                        foreach (DataRow DtR in DRow)
                        {
                            ShowGridView.Rows.Add(i, DtR["FName"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["Shift_Loc"].ToString(), DtR["Shift_Time"].ToString(), DtR["Shift_name"].ToString(), 0, 0, 0, 0);
                            i++;
                        }

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            for (i=0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(Tarikh) AS Cou, COUNT(IIF(Vorood<>'', 1,NULL)) AS VorCou, COUNT(IIF(Khorooj<>'', 1,NULL)) AS KhorCou, COUNT(IIF(Trip1<>'', 1,NULL)) AS Cou1, COUNT(IIF(Trip2<>'', 1,NULL)) AS Cou2, COUNT(IIF(Trip3<>'', 1,NULL)) AS Cou3 FROM Rezerv WHERE Vis=True AND P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        ShowGridView.Rows[i].Cells[7].Value=Reader["Cou"];
                                        ShowGridView.Rows[i].Cells[8].Value=Convert.ToDouble(Reader["Cou1"]) + Convert.ToDouble(Reader["Cou2"]) + Convert.ToDouble(Reader["Cou3"]);
                                        ShowGridView.Rows[i].Cells[9].Value=Reader["VorCou"];
                                        ShowGridView.Rows[i].Cells[10].Value=Reader["KhorCou"];
                                    }
                                }
                            }
                        }

                        Enabled=true;
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

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1=new SaveFileDialog()
                {
                    Filter="Excel Files|*.xlsx|Excel Files 97-2003|*.xls"
                };
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();

                        DataTable Dt=new DataTable();
                        foreach (DataGridViewColumn Column in ShowGridView.Columns)
                        {
                            Dt.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in ShowGridView.Rows)
                        {
                            Dt.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt.Rows[Dt.Rows.Count - 1][cell.ColumnIndex]=cell.Value.ToString();
                            }
                        }
                        using (XLWorkbook Wb=new XLWorkbook())
                        {
                            Wb.RightToLeft=true;
                            Wb.Style.Alignment.Horizontal=(XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder=XLBorderStyleValues.Thin;
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
                Close();
            }
        }

        public void ManageReservReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0703");
        }

        public void ManageReservReportForm_Load(object sender, EventArgs e)
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
                LocalCombo.SelectedIndex=0;
            }

            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
        }

        public void StartCalendar_Enter(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True AND P_Post='راهبر قطار'";
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

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_Time");
                    foreach (DataRow DtR in DRow)
                    {
                        if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                        {
                            TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                        }
                    }
                    TimeCombo.SelectedIndex=0;
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
                    ShiftCombo.SelectedIndex=-1;
                    if (TimeCombo.SelectedIndex >= 0)
                    {
                        ShiftCombo.Items.Clear();
                        ShiftCombo.Items.Add("همه موارد");
                        string QueStr="Vis=True AND P_Post='راهبر قطار'";
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

                        DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_name");
                        foreach (DataRow DtR in DRow)
                        {
                            if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                            {
                                ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                            }
                        }
                        ShiftCombo.SelectedIndex=0;
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
    }
}
