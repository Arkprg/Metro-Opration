using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UserRegisterForm
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }


        private string PName;
        private string PFamily;
        private string PNum;

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
                if (NameBox.Text.Length == 0)
                {
                    ErrorShow(NameBox, " پرسنل مورد نظر را اانتخاب کنید ");
                }
                else if (UnitCombo.SelectedIndex < 0)
                {
                    ErrorShow(UnitCombo, " واحد خدمتی را مشخص کنید ");
                }
                else if (UNameBox.Text.Length == 0)
                {
                    ErrorShow(UNameBox, " نام کاربری را وارد کنید ");
                }
                else if (UPassBox.Text.Length == 0)
                {
                    ErrorShow(UPassBox, " کلمه عبور را وارد کنید ");
                }
                else if (UPassBox.Text == UNameBox.Text)
                {
                    ErrorShow(UNameBox, " نام کاربری و کلمه عبور نباید یکسان باشد ");
                    ErrorShow(UPassBox, " نام کاربری و کلمه عبور نباید یکسان باشد ");
                }
                else if (!(RadioButton1.Checked || RadioButton2.Checked || RadioButton3.Checked || RadioButton4.Checked))
                {
                    ErrorShow(Panel2, " لطفا سطح دسترسی را تعین کنید ");
                }
                else
                {

                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT UsersName FROM PUser WHERE UsersName=@UName", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@UName", UNameBox.Text.ToLower());
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    StrConnec.Close();
                                    Enabled=true;

                                    MessageBoxFa.Show(" این نام کاربری قبلا تعریف شده است ", "خطا", MessageBoxIcon.Error);
                                    UNameBox.Select();
                                    UNameBox.SelectAll();
                                    return;
                                }
                            }
                        }


                        string le="";

                        if (UnitCombo.SelectedIndex == 0)
                        {
                            if (RadioButton1.Checked)
                            {
                                le="0";
                            }

                            if (RadioButton2.Checked)
                            {
                                le="1";
                            }

                            if (RadioButton3.Checked)
                            {
                                le="2";
                            }

                            if (RadioButton4.Checked)
                            {
                                le="3";
                            }
                        }
                        else if (UnitCombo.SelectedIndex == 1)
                        {
                            if (RadioButton1.Checked)
                            {
                                le="5";
                            }

                            if (RadioButton2.Checked)
                            {
                                le="7";
                            }

                            if (RadioButton3.Checked)
                            {
                                le="8";
                            }

                            if (RadioButton4.Checked)
                            {
                                le="9";
                            }
                        }
                        else if (UnitCombo.SelectedIndex == 2)
                        {
                            if (RadioButton1.Checked)
                            {
                                le="15";
                            }

                            if (RadioButton2.Checked)
                            {
                                le="17";
                            }

                            if (RadioButton3.Checked)
                            {
                                le="18";
                            }

                            if (RadioButton4.Checked)
                            {
                                le="19";
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO PUser (UsersName, Pasw, P_Num, Acc_levl, Acti, U_Reg, Reg_Date) VALUES ('" + UNameBox.Text.Trim() + "', '" + UPassBox.Text.Trim() + "', '" + PNum.ToString() + "', " + le + ", True, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "')", StrConnec))
                        {
                            //CMD.Parameters.AddWithValue("@UName", UNameBox.Text.Trim)
                            //CMD.Parameters.AddWithValue("@UPass", UPassBox.Text.Trim)
                            CMD.ExecuteNonQuery();
                        }

                    }


                    Enabled=true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);

                    PFamily="";
                    PName="";
                    PNum="";
                    UNameBox.Text=PNum;
                    UPassBox.Text="";
                    NameBox.Text=PName + " " + PFamily;
                    NameButton.Image=Properties.Resources.user;
                    UnitCombo.SelectedIndex=-1;
                }
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
            UnitCombo.SelectedIndex=-1;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                UNameBox.Text=PNum;
                UPassBox.Text="12345";
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }

        }

        public void UnitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel2.Enabled=true;
            RadioButton1.Checked=true;
            RadioButton1.Checked=false;

            switch (UnitCombo.SelectedIndex)
            {
                case -1:
                    Panel2.Enabled=false;

                    RadioButton1.Text="---";
                    RadioButton2.Text="---";
                    RadioButton3.Text="---";
                    RadioButton4.Text="---";
                    break;
                case 0:
                    RadioButton1.Text="ادمین";
                    RadioButton2.Text="مدیر عامل";
                    RadioButton3.Text="مدیر عملیات";
                    RadioButton4.Text="کارشناس عملیات";
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
    }
}
