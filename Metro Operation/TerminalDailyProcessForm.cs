using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TerminalDailyProcessForm
    {
        public TerminalDailyProcessForm()
        {
            InitializeComponent();
        }


        private int TableID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public bool ProcessChecker()
        {
            bool Process=false;
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM TerminalProcess WHERE Tarikh='" + PersianCalendar.Text + "' AND L_Num='" + AppState.UserLnum + "' AND Vis=True", StrConnec))
                using (OleDbDataReader Reader=CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Process=true;
                        //UserName=Reader.Item("U_Reg").ToString
                        //ProcessName=Reader.Item("P_Mod").ToString
                        //ProceString=Reader.Item("Mem").ToString
                    }
                }
            }

            return Process;
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.Clear();
                DataGridView2.Rows.Clear();

                KindCombo.SelectedIndex=-1;
                if (ProcessChecker())
                {
                    KindCombo.Enabled=false;
                    NameCombo.Enabled=false;
                    ProcessButton.Enabled=false;
                    MessageBoxFa.Show("قبلا پردازش انجام شده است", "توجه", MessageBoxIcon.Warning);
                }
                else
                {
                    KindCombo.Enabled=true;
                    NameCombo.Enabled=true;
                    ProcessButton.Enabled=true;
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
            try
            {
                NameCombo.SelectedIndex=-1;
                NameCombo.Items.Clear();
                DataGridView1.Rows.Clear();
                DataGridView2.Rows.Clear();

                if (PersianCalendar.Text == "")
                {
                    ErrorShow(PersianCalendar, "تاریخ پردازش را تعیین کنید");
                }
                else if (KindCombo.SelectedIndex >= 0)
                {

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT T_Name FROM TerminalTable WHERE T_Kind='" + KindCombo.SelectedItem + "' AND Vis=True And L_Num='" + AppState.UserLnum + "' ORDER BY T_Name", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                NameCombo.Items.Add(Reader["T_Name"].ToString());
                            }
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

        public void NameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.Clear();
                DataGridView2.Rows.Clear();
                Height=655;

                if (KindCombo.SelectedIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM TerminalTable WHERE T_Kind='" + KindCombo.SelectedItem + "' AND T_Name='" + NameCombo.SelectedItem + "' AND Vis=True And L_Num='" + AppState.UserLnum + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                TableID=Convert.ToInt32(Reader["ID"].ToString());
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT E_Time, E_Kind, E_Start, E_END FROM TerminalTableTrip WHERE T_ID=" + TableID + " AND (E_Start='پایانه تهران' OR E_Start='تهران' OR E_END='پایانه تهران' OR E_END='تهران') ORDER BY E_Time", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DataGridView1.Rows.Add(DataGridView1.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_END"].ToString());
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT E_Time, E_Kind, E_Start, E_END FROM TerminalTableTrip WHERE T_ID=" + TableID + " AND (E_Start='پایانه مهرشهر' OR E_Start='گلشهر' OR E_END='پایانه مهرشهر' OR E_END='گلشهر') ORDER BY E_Time", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DataGridView2.Rows.Add(DataGridView2.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_END"].ToString());
                            }
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

        public void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PersianCalendar.Text == "")
                {
                    ErrorShow(PersianCalendar, "تاریخ پردازش را تعیین کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع پردازش را تعیین کنید");
                }
                else if (NameCombo.SelectedIndex < 0)
                {
                    ErrorShow(NameCombo, "نام پردازش را تعیین کنید");
                }
                else if (DataGridView1.RowCount + DataGridView2.RowCount == 0)
                {
                    ErrorShow(PictureBox8, "جدول حرکتی را تعیین کنید");
                    ErrorShow(PictureBox9, "جدول حرکتی را تعیین کنید");
                }
                else if (MessageBoxFa.Show("پردازش اطلاعات لوحه انجام شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ProcessChecker())
                    {
                        KindCombo.SelectedIndex=-1;
                        KindCombo.Items.Clear();
                        MessageBoxFa.Show("قبلا پردازش انجام شده است", "توجه", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        using (WaitForm wait=new WaitForm())
                        {
                            wait.Show();
                            wait.Refresh();
                            Enabled=false;

                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();
                                string QueStr="";
                                int i;
                                for (i=0; i <= DataGridView1.RowCount - 1; i++)
                                {
                                    QueStr="INSERT INTO TerminalTrip (Tarikh, E_Loca, Trip_Time, E_Position, StartLocation, EndLocation, Vis, E_Kind) VALUES ('" + PersianCalendar.Text + "', 'پایانه تهران', '" + DataGridView1.Rows[i].Cells[1].Value.ToString() + "', 'طبق جدول اعزام', '" + DataGridView1.Rows[i].Cells[3].Value.ToString() + "', '" + DataGridView1.Rows[i].Cells[4].Value.ToString() + "', True, ";
                                    if (DataGridView1.Rows[i].Cells[2].Value.ToString() == "ورودی")
                                    {
                                        QueStr += "'ورود به خط اصلی')";
                                    }
                                    else
                                    {
                                        QueStr += "'خروج از خط اصلی')";
                                    }
                                    using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }

                                for (i=0; i <= DataGridView2.RowCount - 1; i++)
                                {
                                    QueStr="INSERT INTO TerminalTrip (Tarikh, E_Loca, Trip_Time, E_Position, StartLocation, EndLocation, Vis, E_Kind) VALUES ('" + PersianCalendar.Text + "', 'پایانه مهرشهر', '" + DataGridView2.Rows[i].Cells[1].Value.ToString() + "', 'طبق جدول اعزام', '" + DataGridView2.Rows[i].Cells[3].Value.ToString() + "', '" + DataGridView2.Rows[i].Cells[4].Value.ToString() + "', True, ";
                                    if (DataGridView2.Rows[i].Cells[2].Value.ToString() == "ورودی")
                                    {
                                        QueStr += "'ورود به خط اصلی')";
                                    }
                                    else
                                    {
                                        QueStr += "'خروج از خط اصلی')";
                                    }

                                    using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }

                                using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalProcess (Tarikh, L_Num, Table_Num, T_Reg , U_Reg, Vis) VALUES ('" + PersianCalendar.Text + "', '" + AppState.UserLnum + "', " + TableID + ", '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', '" + AppState.UserName + "', True)", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }


                            Enabled=true;
                            wait.Close();
                        }
                        MessageBoxFa.Show("پردازش با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                        Close();
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

        public void TerminalDailyProcessForm_Load(object sender, EventArgs e)
        {
            Height=110;
        }
    }
}
