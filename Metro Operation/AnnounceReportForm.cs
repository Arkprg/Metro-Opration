using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class AnnounceReportForm
    {
        public AnnounceReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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

        public void ShiftTimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate=DateTime.Today;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);
                DataGridView1.Rows.Clear();

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع اطلاعیه را مشخص کنید");
                }
                else if (LevelCombo.SelectedIndex < 0)
                {
                    ErrorShow(LevelCombo, "اولویت نمایش اطلاعیه را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا بینندگان اطلاعیه را مشخص کنید");
                }
                else if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی بینندگان اطلاعیه را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت بینندگان اطلاعیه را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0 && ShiftCombo.Enabled)
                {
                    ErrorShow(ShiftCombo, "نام شیفت نمایش اطلاعیه را مشخص کنید");
                }
                //else if (!DateTime.TryParse(StartDate.ToShortDateString(), out _))
                //{
                //    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                //}
                //else if (EndDate==null)
                //{
                //    ErrorShow(StartCalendar, "تاریخ پایان گزارش را مشخص کنید");
                //}
                else if (StartDate > EndDate)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش را مشخص کنید");
                }
                else
                {

                    int i=1;
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;


                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Notifi WHERE Vis=True AND Kind='{KindCombo.SelectedItem}' AND Tarikh>='{StartCalendar.Text}' AND Tarikh<='{EndCalendar.Text}'  ORDER BY T_Reg DESC", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DataGridView1.Rows.Add(i, Reader["ID"].ToString(), Reader["Titr"].ToString(), Reader["Tarikh"].ToString(), Reader["Kind"].ToString(), Reader["L_Show"].ToString(), "", Reader["U_Reg"].ToString());
                                    i++;
                                }
                            }
                        }

                        Enabled=true;
                        wait.Close();
                    }
                    if (DataGridView1.RowCount > 0)
                    {
                        DataGridView1.CurrentRow.Selected=false;
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

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView1.RowCount > 0)
                {

                    int i=1;

                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;
                        DataGridView2.Rows.Clear();


                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, NotifiRead.T_Reg FROM NotifiRead INNER JOIN Person ON Person.P_Num=NotifiRead.P_Num WHERE NotifiRead.Noti_ID=" + DataGridView1.CurrentRow.Cells[1].Value, StrConnec))
                            {
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DataGridView2.Rows.Add(i, Reader["FName"].ToString(), Reader["Family"].ToString(), Reader["T_Reg"].ToString());
                                        i++;
                                    }
                                }

                            }


                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Notifi WHERE ID=" + DataGridView1.CurrentRow.Cells[1].Value, StrConnec))
                            {
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        TitrLabel.Text=Reader["Titr"].ToString();
                                        DateLabel.Text=Reader["Tarikh"].ToString();
                                        KindLabel.Text=Reader["Kind"].ToString();
                                        PostLabel.Text=Reader["P_Post"].ToString();
                                        LocalLabel.Text=Reader["P_Loc"].ToString();
                                        ShiftTimeLabel.Text=Reader["P_Time"].ToString();
                                        ShiftNameLabel.Text=Reader["P_Shift"].ToString();
                                        LevelLabel.Text=Reader["L_Show"].ToString();
                                        RegLabel.Text=Reader["U_Reg"].ToString();
                                        ShowBox.Document.Write(Reader["Context"].ToString());
                                        ShowBox.Refresh();
                                    }
                                }

                            }

                        }


                        Enabled=true;
                        wait.Close();
                    }

                    if (DataGridView2.RowCount > 0)
                    {
                        DataGridView2.CurrentRow.Selected=false;
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

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
        }

        private void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.Clear();
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

        private void LevelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
        }

        private void AnnounceReportForm_Load(object sender, EventArgs e)
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

            TitrLabel.Text="";
            DateLabel.Text="";
            KindLabel.Text="";
            PostLabel.Text="";
            LocalLabel.Text="";
            ShiftTimeLabel.Text="";
            ShiftNameLabel.Text="";
            LevelLabel.Text="";
            RegLabel.Text="";
            ShowBox.DocumentText="";
        }
    }
}
