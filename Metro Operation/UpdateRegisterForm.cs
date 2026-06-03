using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class UpdateRegisterForm
    {
        private int ChrCnt;

        public UpdateRegisterForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void CharCount()
        {
            ChrCnt=255 - (Box1.Text.Length + 1);
            if (Box2.Enabled)
            {
                ChrCnt -= Box2.Text.Length + 2;
            }

            if (Box3.Enabled)
            {
                ChrCnt -= Box3.Text.Length + 2;
            }

            if (Box4.Enabled)
            {
                ChrCnt -= Box4.Text.Length + 2;
            }

            if (Box5.Enabled)
            {
                ChrCnt -= Box5.Text.Length + 2;
            }

            if (Box6.Enabled)
            {
                ChrCnt -= Box6.Text.Length + 2;
            }

            if (Box7.Enabled)
            {
                ChrCnt -= Box7.Text.Length + 2;
            }

            if (Box8.Enabled)
            {
                ChrCnt -= Box8.Text.Length + 2;
            }

            if (Box9.Enabled)
            {
                ChrCnt -= Box9.Text.Length + 2;
            }

            if (Box10.Enabled)
            {
                ChrCnt -= Box10.Text.Length + 2;
            }

            ChrCountLabel.Text=ChrCnt.ToString();
            if (ChrCnt < 0)
            {
                RegButton.Enabled=false;
            }
            else
            {
                RegButton.Enabled=true;
            }
        }

        public void UpdateRegisterForm_Load(object sender, EventArgs e)
        {
            Version v=System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            VersionBox.Text =
                v.Major.ToString("00") +
                v.Minor.ToString("00") +
                v.Build.ToString("00") +
                v.Revision.ToString("000");

            PersianCalendar.Today_Click(null, null);
            TimeBox.Text=DateTime.Now.ToString("HH:mm:ss");
        }

        public void Box1_TextChanged(object sender, EventArgs e)
        {
            if (Box1.Text.Length > 0)
            {
                Box2.Enabled=true;
                CharCount();
            }
            else
            {
                Box2.Enabled=false;
            }
        }

        public void Box2_TextChanged(object sender, EventArgs e)
        {
            if (Box2.Text.Length > 0)
            {
                Box3.Enabled=true;
                CharCount();
            }
            else
            {
                Box3.Enabled=false;
            }
        }

        public void Box3_TextChanged(object sender, EventArgs e)
        {
            if (Box3.Text.Length > 0)
            {
                Box4.Enabled=true;
                CharCount();
            }
            else
            {
                Box4.Enabled=false;
            }
        }

        public void Box4_TextChanged(object sender, EventArgs e)
        {
            if (Box4.Text.Length > 0)
            {
                Box5.Enabled=true;
                CharCount();
            }
            else
            {
                Box5.Enabled=false;
            }
        }

        public void Box5_TextChanged(object sender, EventArgs e)
        {
            if (Box5.Text.Length > 0)
            {
                Box6.Enabled=true;
                CharCount();
            }
            else
            {
                Box6.Enabled=false;
            }
        }

        public void Box6_TextChanged(object sender, EventArgs e)
        {
            if (Box6.Text.Length > 0)
            {
                Box7.Enabled=true;
                CharCount();
            }
            else
            {
                Box7.Enabled=false;
            }
        }

        public void Box7_TextChanged(object sender, EventArgs e)
        {
            if (Box7.Text.Length > 0)
            {
                Box8.Enabled=true;
                CharCount();
            }
            else
            {
                Box8.Enabled=false;
            }
        }

        public void Box8_TextChanged(object sender, EventArgs e)
        {
            if (Box8.Text.Length > 0)
            {
                Box9.Enabled=true;
                CharCount();
            }
            else
            {
                Box8.Enabled=false;
            }
        }

        public void Box9_TextChanged(object sender, EventArgs e)
        {
            if (Box9.Text.Length > 0)
            {
                Box10.Enabled=true;
                CharCount();
            }
            else
            {
                Box10.Enabled=false;
            }
        }

        public void Box10_TextChanged(object sender, EventArgs e)
        {
            CharCount();
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (ConvertClass.TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "ساعت صحیح نیست");
                }
                else if (Box10.Enabled && !Box9.Enabled)
                {
                    ErrorShow(Box9, "خطا");
                }
                else if (Box9.Enabled && !Box8.Enabled)
                {
                    ErrorShow(Box8, "خطا");
                }
                else if (Box8.Enabled && !Box7.Enabled)
                {
                    ErrorShow(Box7, "خطا");
                }
                else if (Box7.Enabled && !Box6.Enabled)
                {
                    ErrorShow(Box6, "خطا");
                }
                else if (Box6.Enabled && !Box5.Enabled)
                {
                    ErrorShow(Box5, "خطا");
                }
                else if (Box5.Enabled && !Box4.Enabled)
                {
                    ErrorShow(Box4, "خطا");
                }
                else if (Box4.Enabled && !Box3.Enabled)
                {
                    ErrorShow(Box3, "خطا");
                }
                else if (Box3.Enabled && !Box2.Enabled)
                {
                    ErrorShow(Box2, "خطا");
                }
                else if (Box1.Text == "")
                {
                    ErrorShow(Box1, "خطا");
                }
                else
                {

                    string ChangeNew="";
                    string VerString;
                    int MainVer=0;
                    int MajVer=0;
                    int ReVer=0;
                    int ReBilt=0;
                    Enabled=false;

                    VerString=VersionBox.Text;
                    MainVer=int.Parse(VersionBox.Text.Substring(0, 2));
                    MajVer=int.Parse(VersionBox.Text.Substring(3, 2));
                    ReVer=int.Parse(VersionBox.Text.Substring(6, 2));
                    ReBilt=int.Parse(VersionBox.Text.Substring(9, 3));
                    ChangeNew=Box1.Text + ". ";
                    if (Box2.Text.Length > 0)
                    {
                        ChangeNew += Box2.Text + ". ";
                    }

                    if (Box3.Text.Length > 0)
                    {
                        ChangeNew += Box3.Text + ". ";
                    }

                    if (Box4.Text.Length > 0)
                    {
                        ChangeNew += Box4.Text + ". ";
                    }

                    if (Box5.Text.Length > 0)
                    {
                        ChangeNew += Box5.Text + ". ";
                    }

                    if (Box6.Text.Length > 0)
                    {
                        ChangeNew += Box6.Text + ". ";
                    }

                    if (Box7.Text.Length > 0)
                    {
                        ChangeNew += Box7.Text + ". ";
                    }

                    if (Box8.Text.Length > 0)
                    {
                        ChangeNew += Box8.Text + ". ";
                    }

                    if (Box9.Text.Length > 0)
                    {
                        ChangeNew += Box9.Text + ". ";
                    }

                    if (Box10.Text.Length > 0)
                    {
                        ChangeNew += Box10.Text + ". ";
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO AppVer (Ver, Mem, Tarikh, Vis, Show) VALUES ('{MainVer}.{MajVer}.{ReVer}.{ReBilt}', @ChangeNew, '{PersianCalendar.Text} {TimeBox.Text}:00',{UpdateCheck.Checked} ,{ShowCheck.Checked})", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@ChangeNew", ChangeNew);
                            CMD.ExecuteNonQuery();
                        }

                    }

                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            ShowCheck.Enabled=UpdateCheck.Checked;
            ShowCheck.Checked=false;
        }

        private void ChrCountLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppState.UserLevel == 0)
                {
                    using (System.IO.FileStream MYStream=System.IO.File.Open(AppState.DatabasePath + "\\metro.alfa", System.IO.FileMode.Open, System.IO.FileAccess.Write))
                    {
                        byte[] BytArr=new byte[1001];
                        int i;
                        int j=0;
                        string Dat=MainForm.PersianToday.Tarikh().Replace("/", "");

                        for (i=0; i <= 999; i++)
                        {
                            if (j * 100 == i && j < 8)
                            {
                                BytArr[i]=byte.Parse(Dat.Substring(j, 1));
                                j++;
                            }
                            else
                            {
                                Random Rnd=new Random();
                                BytArr[i]=(byte)Rnd.Next(0, 100);
                            }
                        }

                        //Important Line
                        MYStream.Write(BytArr, 0, BytArr.Length);
                        MYStream.Close();
                    }
                    MessageBoxFa.Show("");
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
