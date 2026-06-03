using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class AnnounceShowForm
    {
        public AnnounceShowForm()
        {
            InitializeComponent();
        }

        // Private UNum, ULine, UUnit, UPost, ULocal, UShift, UTime As String 'UName, UFamily,
        private int IDNum;
        private int ReadIDNum;
        private bool ShouldRead=false;

        public int ShowNew()
        {
            try
            {
                int NotiID=0;
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    if (AppState.UserLevel == 0)
                    {
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Notifi WHERE Kind='ارسال به ادمین' AND Vis=True ORDER BY Tarikh ASC, L_Show DESC", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                NotiID=Convert.ToInt32(Reader["ID"]);

                                using (OleDbCommand CMD1=new OleDbCommand($"SELECT ID FROM NotifiRead WHERE P_Num='{AppState.UserPnum}' AND Noti_ID={Reader["ID"]}", StrConnec))
                                using (OleDbDataReader Reader1=CMD1.ExecuteReader())
                                {
                                    while (Reader1.Read())
                                    {
                                        NotiID=0;
                                        ShouldRead=false;
                                    }
                                }

                                if (NotiID != 0)
                                {
                                    //MainForm.LearningPicture.Visible=true;
                                    //MainForm.LearningBox.Visible=true;
                                    break;
                                }
                            }
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand($"SELECT ID, Tarikh, L_Show FROM Notifi WHERE Tarikh<='{MainForm.PersianToday.Tarikh()}' AND EndDate>='{MainForm.PersianToday.Tarikh()}' AND (P_Staff='همه موارد' OR P_Staff='{AppState.UserStaff}') AND (P_Loc='همه موارد' OR P_Loc='{AppState.UserLocal}') AND (P_Post='همه موارد' OR P_Post='{AppState.UserPost}') AND (P_Time='همه موارد' OR P_Time='{AppState.UserTime}') AND (P_Shift='همه موارد' OR P_Shift='{AppState.UserShift}') ORDER BY Tarikh ASC, L_Show DESC", StrConnec)) //AND Vis=True AND (P_Line='همه موارد' OR P_Line='" & AppState. & "')
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            NotiID=Convert.ToInt32(Reader["ID"]);
                            if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()) < DateTime.Today.AddDays(-7) || Reader["L_Show"].ToString() == "فوری")
                            {
                                ShouldRead=true;
                            }

                            using (OleDbCommand CMD1=new OleDbCommand($"SELECT ID FROM NotifiRead WHERE P_Num='{AppState.UserPnum}' AND Noti_ID={Reader["ID"]}", StrConnec))
                            using (OleDbDataReader Reader1=CMD1.ExecuteReader())
                            {
                                while (Reader1.Read())
                                {
                                    NotiID=0;
                                    ShouldRead=false;
                                }
                            }

                            if (NotiID != 0)
                            {
                                //MainForm.LearningPicture.Visible=true;
                                //MainForm.LearningBox.Visible=true;
                                break;
                            }
                        }
                    }
                }

                if (ShouldRead)
                {
                    Show();
                }

                return NotiID;
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                return 0;
            }
        }

        public int FindRead(string Pos="")
        {
            try
            {
                int ID=ReadIDNum;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand($"SELECT TOP 1 * FROM NotifiRead WHERE P_Num='{AppState.UserPnum}'", StrConnec))
                    {
                        if (Pos.Length > 0)
                        {
                            CMD.CommandText += $" AND Noti_ID{Pos} ORDER BY Noti_ID";
                            if (Pos.Substring(0, 1) == "<")
                            {
                                CMD.CommandText += " DESC";
                            }
                        }
                        else
                        {
                            CMD.CommandText += " ORDER BY Noti_ID DESC";
                        }
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PrevNotifiButton.Enabled=true;
                                NextNotifiButton.Enabled=true;
                                ID=Convert.ToInt32(Reader["Noti_ID"]);
                            }
                        }
                    }
                }

                return ID;
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                return 0;
            }
        }

        public void ShowRead(int ID)
        {
            try
            {
                if (ID > 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Notifi WHERE ID={ID}", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                TitrLabel2.Text=Reader["Titr"].ToString();
                                DateLabel2.Text=Reader["Tarikh"].ToString();
                                KindLabel2.Text=Reader["Kind"].ToString();
                                PostLabel2.Text=Reader["P_Post"].ToString();
                                LocalLabel2.Text=Reader["P_Loc"].ToString();
                                ShiftTimeLabel2.Text=Reader["P_Time"].ToString();
                                ShiftNameLabel2.Text=Reader["P_Shift"].ToString();
                                LevelLabel2.Text=Reader["L_Show"].ToString();
                                RegLabel2.Text=Reader["U_Reg"].ToString();
                                WebBrowser2.Document.Write(Reader["Context"].ToString());
                                WebBrowser2.Refresh();
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

        public void LearningShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShouldRead)
            {
                if (MessageBoxFa.Show("از برنامه خارج می شوید؟", "خروج", MessageBoxIcon.Stop, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel=true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public void LearningShowForm_Load(object sender, EventArgs e)
        {
            try
            {
                IDNum=0;
                ReadIDNum=0;

                TitrLabel.Text="";
                DateLabel.Text="";
                KindLabel.Text="";
                PostLabel.Text="";
                LocalLabel.Text="";
                ShiftTimeLabel.Text="";
                ShiftNameLabel.Text="";
                LevelLabel.Text="";
                RegLabel.Text="";
                RegButton.Enabled=false;
                WebBrowser1.DocumentText="";
                WebBrowser2.DocumentText="";

                IDNum=ShowNew();
                if (IDNum > 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Notifi WHERE ID={IDNum}", StrConnec))
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
                                    WebBrowser1.Document.Write(Reader["Context"].ToString());
                                    WebBrowser1.Refresh();
                                    RegButton.Enabled=true;
                                }
                            }

                        }

                    }

                }
                else
                {
                    TabControl1.SelectedIndex=1;
                }

                ReadIDNum=FindRead();
                ShowRead(ReadIDNum);
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled=false;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO NotifiRead (P_Num, Noti_ID, T_Reg) VALUES ($'{AppState.UserPnum}', {IDNum}, '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}')", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }

                Enabled=true;
                //MainForm.LearningPicture.Visible=false;
                //MainForm.LearningBox.Visible=false;
                LearningShowForm_Load(sender, EventArgs.Empty);
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
                Panel3.Enabled=true;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PrevNotifiButton_Click(object sender, EventArgs e)
        {
            PrevNotifiButton.Enabled=false;
            ReadIDNum=FindRead("<" + ReadIDNum);
            ShowRead(ReadIDNum);
        }

        public void NextNotifiButton_Click(object sender, EventArgs e)
        {
            NextNotifiButton.Enabled=false;
            ReadIDNum=FindRead(">" + ReadIDNum);
            ShowRead(ReadIDNum);
        }
    }
}
