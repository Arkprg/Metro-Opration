using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PaswordRecoveryForm
    {
        public PaswordRecoveryForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(UserBox.Text))
                {
                    ErrorShow(UserBox, " لطفا نام کاربری را وارد کنید");
                }
                else if (QuesCombo.SelectedIndex < 0)
                {
                    ErrorShow(QuesCombo, "لطفا سئوال امنیتی را تعیین کنید");
                }
                else if (AnswerBox.Text.Length < 4)
                {
                    ErrorShow(AnswerBox, "پاسخ سئوال امنیتی حداقل باید 4 حرف باشد");
                }
                else if (QuesCombo.Text == AnswerBox.Text)
                {
                    ErrorShow(AnswerBox, "پاسخ سئوال امنیتی نباید با سئوال امنیتی یکسان باشد");
                }
                else
                {

                    string SecQui="";
                    string SecAns="";

                    Enabled=false;

                    SecQui="";
                    SecAns="";

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT SecuQui, SecuAns FROM PUser WHERE UsersName=@Username", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Username", UserBox.Text.Trim());
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (string.IsNullOrEmpty(Reader["SecuQui"].ToString()) || string.IsNullOrEmpty(Reader["SecuAns"].ToString()))
                                    {
                                        StrConnec.Close();

                                        MessageBoxFa.Show(" سئوال و پاسخ امنیتی در دسترس نیست  \n  لطفا با ادمین نرم افزار تماس بگیرید", "خطا", MessageBoxIcon.Error);
                                        DialogResult=DialogResult.Cancel;
                                        return;
                                    }
                                    else
                                    {
                                        SecQui=Reader["SecuQui"].ToString();
                                        SecAns=Reader["SecuAns"].ToString();
                                    }
                                }
                            }
                        }

                        bool Rest=false;
                        if ((string)QuesCombo.SelectedItem == SecQui && AnswerBox.Text == SecAns)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("UPDATE PUser SET Pasw='12345', Mod_Date='', Acti=True, Atmp_fail=0 WHERE UsersName=@UserName", StrConnec))
                            {
                                CMD.Parameters.AddWithValue("@UserName", UserBox.Text.Trim());
                                CMD.ExecuteNonQuery();
                            }

                            Rest=true;
                        }
                        Enabled=true;

                        if (Rest)
                        {
                            MessageBoxFa.Show("حساب کاربری شما ریست شد \n\n  کلمه عبور جدید : 12345 ", "توجه", MessageBoxIcon.Exclamation);
                            Close();
                        }
                        else
                        {
                            MessageBoxFa.Show("سوال یا پاسخ امنیتی صحیح نمی باشد", "خطا", MessageBoxIcon.Error);
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

        private void PaswordRecoveryForm_Load(object sender, EventArgs e)
        {
            UserBox.Font=FontManager.Tahoma(11);
        }
    }
}
