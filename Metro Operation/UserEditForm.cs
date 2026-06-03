using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UserEditForm
    {
        public UserEditForm()
        {
            InitializeComponent();
        }


        private string UName;
        private string PN;
        private string PF;
        private string PNu;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UNameBox.Text.Length == 0)
                {
                    ErrorShow(UNameBox, " لطفا نام کاربری را وارد کنید ");
                }
                else if (UnitCombo.SelectedIndex < 0)
                {
                    ErrorShow(UnitCombo, " واحد خدمتی را مشخص کنید ");
                }
                else if (!(RadioButton1.Checked || RadioButton2.Checked || RadioButton3.Checked || RadioButton4.Checked))
                {
                    ErrorShow(Panel4, " لطفا سطح دسترسی را تعین کنید ");
                }
                else
                {
                    Enabled=false;

                    int le=-1;

                    if (UnitCombo.SelectedIndex == 0)
                    {
                        if (RadioButton1.Checked)
                        {
                            le=0;
                        }

                        if (RadioButton2.Checked)
                        {
                            le=1;
                        }

                        if (RadioButton3.Checked)
                        {
                            le=2;
                        }

                        if (RadioButton4.Checked)
                        {
                            le=3;
                        }
                    }
                    else if (UnitCombo.SelectedIndex == 1)
                    {
                        if (RadioButton1.Checked)
                        {
                            le=5;
                        }

                        if (RadioButton2.Checked)
                        {
                            le=7;
                        }

                        if (RadioButton3.Checked)
                        {
                            le=8;
                        }

                        if (RadioButton4.Checked)
                        {
                            le=9;
                        }
                    }
                    else if (UnitCombo.SelectedIndex == 2)
                    {
                        if (RadioButton1.Checked)
                        {
                            le=15;
                        }

                        if (RadioButton2.Checked)
                        {
                            le=17;
                        }

                        if (RadioButton3.Checked)
                        {
                            le=18;
                        }

                        if (RadioButton4.Checked)
                        {
                            le=19;
                        }
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        if (UName != UNameBox.Text)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("SELECT UsersName FROM PUser", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (Reader["UsersName"].ToString().ToLower() == UNameBox.Text.ToLower())
                                    {
                                        StrConnec.Close();
                                        ErrorShow(UNameBox, " این نام کاربری قبلا تعریف شده است ");
                                        return;
                                    }
                                }
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("UPDATE PUser SET UsersName=@UName, Acc_levl='" + le.ToString() + "' WHERE P_Num='" + PNu + "'", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("UName", UNameBox.Text);
                            CMD.ExecuteNonQuery();
                        }

                    }


                    UNameBox.Text="";
                    UnitCombo.SelectedIndex=-1;
                    Enabled=true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void UnitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel4.Enabled=true;
            RadioButton1.Checked=true;
            RadioButton1.Checked=false;

            switch (UnitCombo.SelectedIndex)
            {
                case -1:
                    Panel4.Enabled=false;

                    RadioButton1.Text="---";
                    RadioButton2.Text="---";
                    RadioButton3.Text="---";
                    RadioButton4.Text="---";
                    break;
                case 0:
                    RadioButton1.Text="ادمین";
                    RadioButton2.Text="مدیر عامل";
                    RadioButton3.Text="مدیر عملیات";
                    RadioButton4.Text="کارشناس مدیر";
                    break;
                case 1:
                case 2:
                    RadioButton1.Text="رئیس";
                    RadioButton2.Text="مسئول";
                    RadioButton3.Text="تکنسین";
                    RadioButton4.Text="راهبر";
                    break;
            }
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            UNameBox.Text="";
            UnitCombo.SelectedIndex=-1;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PF=PersonalSelectForm.PFamily;
                PN=PersonalSelectForm.PName;
                PNu=PersonalSelectForm.PNum;
                UNameBox.Text=PNu;
                NameBox.Text=PN + " " + PF;
                NameButton.Image=Properties.Resources.user;

                int ULv=-1;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Acc_levl, UsersName FROM PUser WHERE P_Num='" + PNu + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ULv=int.Parse(Reader["Acc_levl"].ToString());
                            UName=Reader["UsersName"].ToString();
                            UNameBox.Text=UName;
                            RegButton.Enabled=true;
                        }
                    }
                }


                if (ULv >= 0 && ULv <= 3)
                {
                    UnitCombo.SelectedIndex=0;
                    if (ULv == 0)
                    {
                        RadioButton1.Select();
                    }

                    if (ULv == 1)
                    {
                        RadioButton2.Select();
                    }

                    if (ULv == 2)
                    {
                        RadioButton3.Select();
                    }

                    if (ULv == 3)
                    {
                        RadioButton4.Select();
                    }
                }
                else if (ULv >= 4 && ULv <= 9)
                {
                    UnitCombo.SelectedIndex=1;
                    if (ULv == 4)
                    {
                        RadioButton1.Select();
                    }

                    if (ULv == 6)
                    {
                        RadioButton2.Select();
                    }

                    if (ULv == 7)
                    {
                        RadioButton3.Select();
                    }

                    if (ULv == 9)
                    {
                        RadioButton4.Select();
                    }
                }
                else if (ULv >= 10 && ULv <= 19)
                {
                    UnitCombo.SelectedIndex=2;
                    if (ULv == 14)
                    {
                        RadioButton1.Select();
                    }

                    if (ULv == 16)
                    {
                        RadioButton2.Select();
                    }

                    if (ULv == 17)
                    {
                        RadioButton3.Select();
                    }

                    if (ULv == 19)
                    {
                        RadioButton4.Select();
                    }
                }
            }
        }
    }
}
