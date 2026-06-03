using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripReportForm
    {
        public TripReportForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string MorShift;
        private string AftShift;
        public bool MoreTrip = false;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;
            ShowGridView.Rows.Clear();

            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;

                NameBox.Text = PName + " " + PFamily;
                NameButton.Image = Properties.Resources.cancel1;
            }
            ShowButton.Select();
        }

        public void TripReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum = AppState.UserPnum;
                    NameButton.Enabled = false;
                    NameBox.Text = AppState.UserName;
                }

                KindCombo.SelectedIndex = 0;
                LineCombo.SelectedIndex = 0;
                if (AppState.UserLevel > 8)
                {
                    TransCheck.Visible = false;
                }

                if (MoreTrip)
                {
                    StartCalendar.Today_Click(null, null);
                    EndCalendar.LastDayOfMonth_Click(null, null);
                    KindCombo.SelectedIndex = 0;
                    ShowButton_Click(null, null);
                    int i = 10;
                    while (ShowGridView.Rows.Count > i + 10)
                    {
                        TimeSpan.TryParse(ShowGridView.Rows[i].Cells[2].Value.ToString(), out TimeSpan TripTime);
                        if (TripTime < DateTime.Now.TimeOfDay)
                        {
                            i++;
                        }
                        else
                        {
                            ShowGridView.FirstDisplayedScrollingRowIndex = i - 7;
                            ShowGridView.CurrentCell = ShowGridView.Rows[i].Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    StartCalendar.FirstDayOfMonth_Click(null, null);
                    EndCalendar.LastDayOfMonth_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void LineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
            LocaCombo.Items.Clear();

            switch (LineCombo.SelectedIndex)
            {
                case 0:
                    LocaCombo.Items.AddRange(new[] { "همه موارد", "تهران", "گلشهر", "هشتگرد" });
                    break;
                case 1:
                    LocaCombo.Items.AddRange(new[] { "همه موارد", "تهران", "گلشهر" });
                    ShowGridView.Columns[10].HeaderText = "راهبر آموزشی";
                    break;

                case 2:
                    LocaCombo.Items.AddRange(new[] { "همه موارد", "گلشهر", "هشتگرد" });
                    ShowGridView.Columns[10].HeaderText = "راهبر";
                    break;
            }
            LocaCombo.SelectedIndex = 0;
        }

        public void LocaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate = ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate = ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع لوحه را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate == null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش را مشخص کنید");
                }
                else if (EndDate < StartDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی گزارش صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی گزارش صحیح نیست");
                }
                else
                {

                    int i = 0;
                    Enabled = false;

                    ShowGridView.Rows.Clear();
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Taghvim WHERE Tarikh='" + StartCalendar.Text + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                MorShift = Reader["Sobh"].ToString();
                                AftShift = Reader["Asr"].ToString();
                            }
                        }

                        string QueStr = "SELECT * FROM DailyTrip WHERE Vis=True AND ";
                        if (KindCombo.SelectedIndex == 0)
                        {
                            QueStr += "Prime=True";
                        }
                        else if (KindCombo.SelectedIndex == 1)
                        {
                            QueStr += "Execu=True";
                        }
                        else
                        {
                            QueStr += "Final=True";
                        }
                        if (LineCombo.SelectedIndex == 1)
                        {
                            QueStr += " AND (Mabdae='تهران' OR Mabdae='گلشهر')";
                        }

                        if (LineCombo.SelectedIndex == 2)
                        {
                            QueStr += " AND (Maghsad='هشتگرد' OR Mabdae='هشتگرد')";
                        }

                        if ((string)LocaCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Mabdae LIKE '" + LocaCombo.SelectedItem + "%'";
                        }

                        if (NameBox.Text.Length > 0)
                        {
                            QueStr += " And (O1_Num='" + PNum + "' OR O2_Num='" + PNum + "' OR OT_Num='" + PNum + "')";
                        }

                        QueStr += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh, T_Time, Mabdae";

                        using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                i++;
                                ShowGridView.Rows.Add(i, Reader["Tarikh"].ToString(), Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Reader["Maghsad"].ToString(), "", Reader["O1_Num"].ToString(), Reader["O1_Time"].ToString(), "", "", "", "", Reader["OT_Num"].ToString(), Reader["OT_Time"].ToString(), "", "", "", "", Reader["O2_Num"].ToString(), Reader["O2_Time"].ToString(), "", "", "", Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString());
                                DateTime TrTime = DateTime.Parse(Reader["T_Time"].ToString());
                                if (!string.IsNullOrEmpty(Reader["O1_Time"].ToString())) ShowGridView.Rows[i - 1].Cells[8].Value = TrTime - DateTime.Parse(Reader["O1_Time"].ToString());
                                if (!string.IsNullOrEmpty(Reader["OT_Time"].ToString())) ShowGridView.Rows[i - 1].Cells[14].Value = TrTime - DateTime.Parse(Reader["OT_Time"].ToString());
                                if (!string.IsNullOrEmpty(Reader["O2_Time"].ToString())) ShowGridView.Rows[i - 1].Cells[20].Value = TrTime - DateTime.Parse(Reader["O2_Time"].ToString()); 
                            }
                        }
                    }

                    if (ShowGridView.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DataRow[] DRow;
                        for (i = 0; i <= ShowGridView.Rows.Count - 1; i++)
                        {
                            if (ShowGridView.Rows[i].Cells[6].Value.ToString() != "")
                            {
                                DRow = MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[6].Value.ToString() + "'");
                                if (DRow.Length > 0)
                                {
                                    ShowGridView.Rows[i].Cells[5].Value = DRow[0][0] + " " + DRow[0][1];
                                    ShowGridView.Rows[i].Cells[9].Value = DRow[0][7];
                                    ShowGridView.Rows[i].Cells[10].Value = DRow[0][8];
                                }
                            }

                            if (ShowGridView.Rows[i].Cells[12].Value.ToString() != "")
                            {
                                DRow = MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[12].Value.ToString() + "'");
                                if (DRow.Length > 0)
                                {
                                    ShowGridView.Rows[i].Cells[11].Value = DRow[0][0] + " " + DRow[0][1];
                                    ShowGridView.Rows[i].Cells[15].Value = DRow[0][7];
                                    ShowGridView.Rows[i].Cells[16].Value = DRow[0][8];
                                }
                            }

                            if (ShowGridView.Rows[i].Cells[18].Value.ToString() != "")
                            {
                                DRow = MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[18].Value.ToString() + "'");
                                if (DRow.Length > 0)
                                {
                                    ShowGridView.Rows[i].Cells[17].Value = DRow[0][0] + " " + DRow[0][1];
                                    ShowGridView.Rows[i].Cells[21].Value = DRow[0][7];
                                    ShowGridView.Rows[i].Cells[22].Value = DRow[0][8];
                                }
                            }

                            //If Not TransCheck.Checked Then
                            //    ShowGridView.Rows(i).Cells(7).Value=""
                            //    ShowGridView.Rows(i).Cells(10).Value=""
                            //    ShowGridView.Rows(i).Cells(13).Value=""
                            //End If
                        }
                    }
                    ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
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

                        if (!TransCheck.Checked)
                        {
                            Dt.Columns.RemoveAt(7);
                            Dt.Columns.RemoveAt(7);
                            Dt.Columns.RemoveAt(7);
                            Dt.Columns.RemoveAt(7);
                            Dt.Columns.RemoveAt(9);
                            Dt.Columns.RemoveAt(9);
                            Dt.Columns.RemoveAt(9);
                            Dt.Columns.RemoveAt(9);
                            Dt.Columns.RemoveAt(11);
                            Dt.Columns.RemoveAt(11);
                            Dt.Columns.RemoveAt(11);
                            Dt.Columns.RemoveAt(11);
                        }

                        if (StartCalendar.Text == EndCalendar.Text)
                        {
                            Dt.Columns.Add("______");
                            Dt.Columns.Add("مشخصات");
                            Taghvim PersianDate = new Taghvim(StartCalendar.Text);
                            Dt.Rows[0][Dt.Columns.Count - 1] = "تاریخ:";
                            Dt.Rows[1][Dt.Columns.Count - 1] = PersianDate.DayWeek();
                            Dt.Rows[2][Dt.Columns.Count - 1] = PersianDate.Tarikh();
                            Dt.Rows[3][Dt.Columns.Count - 1] = "";
                            Dt.Rows[4][Dt.Columns.Count - 1] = "شیفت صبح:";
                            Dt.Rows[5][Dt.Columns.Count - 1] = MorShift;
                            Dt.Rows[6][Dt.Columns.Count - 1] = "";
                            Dt.Rows[7][Dt.Columns.Count - 1] = "شیفت عصر:";
                            Dt.Rows[8][Dt.Columns.Count - 1] = AftShift;
                        }
                        using (XLWorkbook Wb = new XLWorkbook())
                        {
                            Wb.RightToLeft = true;
                            Wb.Style.Alignment.Horizontal = (XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            Wb.AddWorksheet(Dt, "Sheet1");
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
    }
}
