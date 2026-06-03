using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class KeshikRequRegisterForm
    {
        public KeshikRequRegisterForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string KNum;
        private int ID=0;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void KeshikRequRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0112");
        }

        public void KeshikRequstForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                    {
                        PNum=AppState.UserPnum;
                        NameButton.Enabled=false;
                        NameBox.Text=AppState.UserName;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, KeshikRequ.ID, KeshikRequ.Num FROM KeshikRequ INNER JOIN Person ON Person.P_Num=KeshikRequ.P_Num WHERE KeshikRequ.P_Num='" + PNum + "' AND KeshikRequ.Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PFamily=Reader["Family"].ToString();
                                PName=Reader["Fname"].ToString();
                                NameBox.Text=PName + " " + PFamily;
                                KNum=Reader["Num"].ToString();
                                TrackBar1.Value=Convert.ToInt32(Reader["Num"]);
                                ID=Convert.ToInt32(Reader["ID"]);
                            }
                        }
                    }
                }

                Label3.Text="تعداد کشیک در خواستی:" + TrackBar1.Value.ToString();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm.Per="راهبر";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                ID=0;
                TrackBar1.Value=0;
                KNum="0";

                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT ID, Num FROM KeshikRequ WHERE P_Num='" + PNum + "' AND Vis=True", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            KNum=Reader["Num"].ToString();
                            TrackBar1.Value=Convert.ToInt32(Reader["Num"]);
                            ID=Convert.ToInt32(Reader["ID"]);
                        }
                    }
                }
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام راهبر را تعیین کنید");
                }
                else if (KNum == TrackBar1.Value.ToString())
                {
                    ErrorShow(TrackBar1, "تعداد کشیک ماهانه تغییر نکرده است");
                }
                else
                {
                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE KeshikRequ SET Vis=False WHERE ID=" + ID.ToString(), StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO KeshikRequ (P_Num, Num, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "', '" + TrackBar1.Value.ToString() + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + ID.ToString() + ")", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    NameBox.Text="";
                    NameButton.Image=Properties.Resources.user;

                    TrackBar1.Value=0;
                    Label3.Text="تعداد کشیک در خواستی: 0";
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Enabled=true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Enabled=true;
            }
        }

        public void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (TrackBar1.Value < 5)
            {
                Label3.Text="تعداد کشیک در خواستی: " + TrackBar1.Value.ToString();
            }
            else
            {
                Label3.Text="تعداد کشیک در خواستی: حداکثر";
            }
        }
    }
}
