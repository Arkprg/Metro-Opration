using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripPersonReportForm
    {
        public TripPersonReportForm()
        {
            InitializeComponent();
        }
        private string PName;
        private string PFamily;
        private string PNum;
        private string PLocal;
        private string PPost;
        private string PTime;
        private string PShift;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.Enabled)
                {
                    PostCombo.SelectedIndex=-1;
                    if (LocalCombo.SelectedIndex >= 0)
                    {
                        PostCombo.Items.Clear();
                        PostCombo.Items.Add("همه موارد");

                        string QueStr="Vis=True";
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

                        DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "P_Post");
                        foreach (DataRow DtR in DRow)
                        {
                            if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                            {
                                PostCombo.Items.Add(DtR["P_Post"].ToString());
                            }
                        }
                        PostCombo.SelectedIndex=0;
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

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (PostCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True";
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
                        string QueStr="Vis=True";
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

        public void LocalCombo_EnabledChanged(object sender, EventArgs e)
        {
            if (LocalCombo.Enabled)
            {
                PostCombo.Enabled=true;
                TimeCombo.Enabled=true;
                ShiftCombo.Enabled=true;
            }
            else
            {
                PostCombo.Enabled=false;
                TimeCombo.Enabled=false;
                ShiftCombo.Enabled=false;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (LocalCombo.Enabled && LocalCombo.SelectedIndex < 0)
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
                else if (StartDate==null )
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate==null)
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

                    int i=0;
                    //*
                    Enabled=false;

                    ShowGridView.Rows.Clear();
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string QueStr="Select Person.Fname, Person.Family, Person.P_Num, DailyTripExecu.Tarikh, DailyTripExecu.T_Time, DailyTripExecu.Mabdae, DailyTripExecu.Maghsad, DailyTripExecu.T_Status, DailyTripExecu.U_Reg, DailyTripExecu.T_Reg From DailyTripExecu INNER JOIN Person ON Person.P_Num=DailyTripExecu.P_Num WHERE DailyTripExecu.Vis=True";
                        if (NameBox.Text.Length > 0)
                        {
                            QueStr += " AND DailyTripExecu.P_Num='" + PNum + "'";
                        }
                        else
                        {
                            if (AppState.UserLevel > 1)
                            {
                                QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                            }
                            if ((string)PostCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND Person.P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                            }
                            if ((string)LocalCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                            }
                            if ((string)TimeCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND Person.Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                            }
                            if ((string)ShiftCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND Person.Shift_name='" + ShiftCombo.SelectedItem.ToString() + "'";
                            }
                        }
                        QueStr += " AND DailyTripExecu.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY DailyTripExecu.Tarikh DESC, DailyTripExecu.T_Time, DailyTripExecu.Mabdae";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    i++;
                                    ShowGridView.Rows.Add(i, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Tarikh"].ToString(), Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Reader["Maghsad"].ToString(), "راهبر " + Reader["T_Status"].ToString(), Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString());
                                }
                            }

                        }

                    }

                    ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    Enabled=true;
                    if (ShowGridView.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
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
            }
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;

            LocalCombo.Enabled=true;
            PostCombo.Enabled=true;
            TimeCombo.Enabled=true;
            ShiftCombo.Enabled=true;
            LocalCombo.SelectedIndex=-1;

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                LocalCombo.Enabled=false;
                PostCombo.Enabled=false;
                TimeCombo.Enabled=false;
                ShiftCombo.Enabled=false;

                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                PLocal=PersonalSelectForm.PLocal;
                PPost=PersonalSelectForm.PPost;
                PTime=PersonalSelectForm.PTime;
                PShift=PersonalSelectForm.PShift;

                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;

                LocalCombo.Text=PLocal;
                PostCombo.Items.Add(PPost);
                PostCombo.Text=PPost;
                TimeCombo.Items.Add(PTime);
                TimeCombo.Text=PTime;
                ShiftCombo.Items.Add(PShift);
                ShiftCombo.Text=PShift;
            }

        }

        public void TripReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.Items.Clear();

                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum=AppState.UserPnum;
                    NameButton.Enabled=false;
                    NameBox.Text=AppState.UserName;

                    LocalCombo.Enabled=false;
                    PostCombo.Enabled=false;
                    TimeCombo.Enabled=false;
                    ShiftCombo.Enabled=false;

                    LocalCombo.Text=AppState.UserLocal;
                    PostCombo.Text=AppState.UserPost;
                    TimeCombo.Text=AppState.UserTime;
                    ShiftCombo.Text=AppState.UserShift;
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
                        LocalCombo.SelectedIndex=0;
                    }
                }

                StartCalendar.FirstDayOfMonth_Click(null, null);
                EndCalendar.LastDayOfMonth_Click(null, null);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
