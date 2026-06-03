using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class ManagePerformanceReportForm
    {
        public ManagePerformanceReportForm()
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
                ShowGridView.Rows.Clear();

                DateTime StartDate;
                DateTime EndDate;
                StartDate = ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate = ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع شیفت را مشخص کنید");
                }
                else if (LocalCombo.Enabled && LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا پرسنل را مشخص کنید");
                }
                else if (PostCombo.Enabled && PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی پرسنل را مشخص کنید");
                }
                else if (TimeCombo.Enabled && TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت پرسنل را مشخص کنید");
                }
                else if (ShiftCombo.Enabled && ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "نام شیفت پرسنل را مشخص کنید");
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
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled = false;

                        Label1S.Text = "0";
                        Label2S.Text = "0";
                        Label3S.Text = "0";
                        Label4S.Text = "0";
                        Label5S.Text = "0";
                        Label6S.Text = "0";
                        Label7S.Text = "0";
                        Label8S.Text = "0";
                        Label9S.Text = "0";
                        Label10S.Text = "0";
                        Label11S.Text = "0";

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            if (KindCombo.SelectedIndex == 1)
                            {
                                string QueStr = "SELECT Person.P_Num, Person.Line_Num, Person.Fname, Person.Family, Person.P_Post, Person.Shift_Name, Person.Shift_Time, Person.Shift_loc FROM PUser INNER JOIN Person ON Person.P_Num=PUser.P_Num WHERE Person.Vis=True";
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " AND Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                                {
                                    QueStr += " AND Person.P_Staff='" + AppState.UserStaff + "'";
                                }

                                if ((string)PostCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Person.P_Post='" + PostCombo.SelectedItem + "'";
                                }

                                if ((string)LocalCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                else
                                {
                                    QueStr += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }

                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Person.Shift_Time='" + PostCombo.SelectedItem + "'";
                                }

                                if ((string)ShiftCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Person.Shift_name='" + LocalCombo.SelectedItem + "'";
                                }

                                if (LocalCombo.SelectedItem.ToString().IndexOf("پایانه") + 1 > 0)
                                {
                                    QueStr += " AND (PUser.Acc_Levl<18 AND PUser.Acc_Levl>9) ";
                                }
                                else
                                {
                                    QueStr += " AND PUser.Acc_Levl<9 ";
                                }

                                QueStr += " ORDER BY Person.Family, Person.Fname";

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        ShowGridView.Rows.Add(0, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Shift_Name"].ToString(), Reader["Shift_Time"].ToString(), Reader["Shift_loc"].ToString(), Reader["P_Post"].ToString(), 0, 0, 0, 0, 0, 0, 0, 0, 0);
                                    }
                                }
                            }
                            else if (KindCombo.SelectedIndex == 0)
                            {
                                string QueStr = "Vis=True";
                                if (AppState.UserLevel > 3)
                                {
                                    QueStr += " AND P_Staff<>'مدیریت'";
                                }
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
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
                                if ((string)PostCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
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
                                    ShowGridView.Rows.Add(0, DtR["FName"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["Shift_Name"].ToString(), DtR["Shift_Time"].ToString(), DtR["Shift_loc"].ToString(), DtR["P_Post"].ToString(), 0, 0, 0, 0, 0, 0, 0, 0, 0);
                                }
                            }

                            int SumSat = 0;
                            int SumPos = 0;
                            int SumNeg = 0;
                            int SumJab = 0;
                            int SumKesh = 0;
                            int SumCla = 0;
                            int SumMot = 0;
                            int SumJay = 0;
                            int SumMor = 0;
                            int SumRez = 0;

                            for (int i = 0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                int Sat = 0;
                                int Pos = 0;
                                int Neg = 0;
                                int Jab = 0;
                                int Kesh = 0;
                                int Cla = 0;
                                int Mot = 0;
                                int Jay = 0;
                                int Mor = 0;
                                int Rez = 0;
                                string QueStr = "SELECT COUNT(IIF(E_Kind='کلاس آموزشی', 1,NULL)) AS Cou1, COUNT(IIF(E_Kind='کشیک', 1,NULL)) AS Cou2, COUNT(IIF(E_Kind<>'کلاس آموزشی' AND E_Kind<>'کشیک',1,NULL)) AS Cou3 " +
                                    "FROM Ezafeh WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "'";
                                }
                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + ShowGridView.Rows[i].Cells[1].Value + " " + ShowGridView.Rows[i].Cells[2].Value + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            Cla = Convert.ToInt32(Reader["Cou1"]);
                                            Kesh = Convert.ToInt32(Reader["Cou2"]);
                                            Mot = Convert.ToInt32(Reader["Cou3"]);
                                        }
                                    }
                                }


                                QueStr = "SELECT COUNT(IIF(OnvAmal='ساعتی',1,NULL)) AS Cou1, COUNT(IIF(OnvAmal='مثبت',1,NULL)) AS Cou2, COUNT(IIF(OnvAmal='منفی',1,NULL)) AS Cou3, " +
                                    "COUNT(IIF(OnvAmal='جابجایی',1,NULL)) AS Cou4 FROM Amal WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "'";
                                }
                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + ShowGridView.Rows[i].Cells[1].Value + " " + ShowGridView.Rows[i].Cells[2].Value + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            Sat = Convert.ToInt32(Reader["Cou1"]);
                                            Pos = Convert.ToInt32(Reader["Cou2"]);
                                            Neg = Convert.ToInt32(Reader["Cou3"]);
                                            Jab = Convert.ToInt32(Reader["Cou4"]);
                                        }
                                    }
                                }


                                QueStr = "SELECT COUNT(Kind) AS Cou FROM Morakhasi WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "'";
                                }
                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + ShowGridView.Rows[i].Cells[1].Value + " " + ShowGridView.Rows[i].Cells[2].Value + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            Mor = Convert.ToInt32(Reader["Cou"]);
                                        }
                                    }
                                }


                                QueStr = "SELECT COUNT(Loca) AS Cou FROM Rezerv WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "'";
                                }
                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + ShowGridView.Rows[i].Cells[1].Value + " " + ShowGridView.Rows[i].Cells[2].Value + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            Rez = Convert.ToInt32(Reader["Cou"]);
                                        }
                                    }

                                }


                                QueStr = "SELECT COUNT(Olv1) AS Cou FROM JayGozin WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "'";
                                }
                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + ShowGridView.Rows[i].Cells[1].Value + " " + ShowGridView.Rows[i].Cells[2].Value + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            Jay = Convert.ToInt32(Reader["Cou"]);
                                        }
                                    }
                                }

                                ShowGridView.Rows[i].Cells[0].Value = i + 1;
                                ShowGridView.Rows[i].Cells[8].Value = Mot;
                                ShowGridView.Rows[i].Cells[9].Value = Cla;
                                ShowGridView.Rows[i].Cells[10].Value = Kesh;
                                ShowGridView.Rows[i].Cells[11].Value = Sat;
                                ShowGridView.Rows[i].Cells[12].Value = Mor;
                                ShowGridView.Rows[i].Cells[13].Value = Pos;
                                ShowGridView.Rows[i].Cells[14].Value = Neg;
                                ShowGridView.Rows[i].Cells[15].Value = Jab;
                                ShowGridView.Rows[i].Cells[16].Value = Rez;
                                ShowGridView.Rows[i].Cells[17].Value = Jay;
                                ShowGridView.Rows[i].Cells[18].Value = Mot + Cla + Kesh + Sat + Mor + Pos + Neg + Jab + Rez + Jay;

                                SumMot += Mot;
                                SumCla += Cla;
                                SumKesh += Kesh;
                                SumSat += Sat;
                                SumMor += Mor;
                                SumPos += Pos;
                                SumNeg += Neg;
                                SumJab += Jab;
                                SumRez += Rez;
                                SumJay += Jay;
                            }

                            Label1S.Text = SumMot.ToString();
                            Label2S.Text = SumCla.ToString();
                            Label3S.Text = SumKesh.ToString();
                            Label4S.Text = SumSat.ToString();
                            Label5S.Text = SumMor.ToString();
                            Label6S.Text = SumPos.ToString();
                            Label7S.Text = SumNeg.ToString();
                            Label8S.Text = SumJab.ToString();
                            Label9S.Text = SumRez.ToString();
                            Label10S.Text = SumJay.ToString();
                            Label11S.Text = (SumMot + SumCla + SumKesh + SumSat + SumMor + SumPos + SumNeg + SumJab + SumRez + SumJay).ToString();
                        }

                        Enabled = true;
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
                Close();
            }
        }

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i = 0; i <= ShowGridView.RowCount - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void ManagePerformanceReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0701");
        }

        public void ManagePerformanceReportForm_Load(object sender, EventArgs e)
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

            KindCombo.SelectedIndex = 0;
            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
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
                ShiftCombo.SelectedIndex = -1;
                if (TimeCombo.SelectedIndex >= 0)
                {
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

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }
    }
}
