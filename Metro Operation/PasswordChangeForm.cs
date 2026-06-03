using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PasswordChangeForm
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }


        public bool Sec=false;
        public bool Shou=false;
        private readonly ToolTip Tool=new ToolTip();

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        //    Shared Function RandomString(Len As Integer)
        //        Dim s As String="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%&*.,;[]{}:?<>"
        //        Dim sb As New StringBuilder
        //        Randomize()
        //        Dim r As New Random()
        //        For i As Integer=1 To Len
        //            Dim idx As Integer=r.Next(0, s.Length)
        //            sb.Append(s.Substring(idx, 1))
        //        Next
        //        Return sb.ToString()
        //    End Function

        //    Public Shared Function Encrypt(ByVal plainText As String, ByVal passPhrase As String, ByVal saltValue As String, ByVal hashAlgorithm As String, ByVal passwordIterations As Integer, ByVal initVector As String, ByVal keySize As Integer) As String

        //        Dim initVectorBytes As Byte()=Encoding.ASCII.GetBytes(initVector)
        //        Dim saltValueBytes As Byte()=Encoding.ASCII.GetBytes(saltValue)
        //        Dim plainTextBytes As Byte()=Encoding.UTF8.GetBytes(plainText)
        //        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)
        //        Dim keyBytes As Byte()=password.GetBytes(keySize / 8)
        //        Dim symmetricKey As New RijndaelManaged With {
        //            .Mode=CipherMode.CBC
        //        }

        //        Dim encryptor As ICryptoTransform=symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        //        Dim memoryStream As New MemoryStream()

        //        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
        //        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        //        cryptoStream.FlushFinalBlock()

        //        Dim cipherTextBytes As Byte()=memoryStream.ToArray()

        //        memoryStream.Close()
        //        cryptoStream.Close()

        //        Dim cipherText As String=Convert.ToBase64String(cipherTextBytes)
        //        Encrypt=cipherText
        //    End Function

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentPasBox.Text == "")
                {
                    ErrorShow(CurrentPasBox, "کلمه عبور فعلی را وارد کنید");
                }
                else if (PasswordCheck.Checked && NewPassBox.Text.Length < 4)
                {
                    ErrorShow(NewPassBox, "کلمه عبور جدید حداقل باید 4 حرف باشد");
                }
                else if (!PasswordCheck.Checked && !QuestionCheck.Checked)
                {
                    ErrorShow(PasswordCheck, "نوع تغییر را مشخص کنید ");
                    ErrorShow(QuestionCheck, "نوع تغییر را مشخص کنید ");
                }
                else if (PasswordCheck.Checked && NewPassBox.Text != ReNewPassBox.Text)
                {
                    ErrorShow(NewPassBox, "کلمه های عبور جدید با هم برابر نیستند");
                }
                else if (PasswordCheck.Checked && CurrentPasBox.Text == NewPassBox.Text)
                {
                    ErrorShow(NewPassBox, "کلمه عبور جدید نباید با کلمه عبور فعلی یکسان باشد");
                }
                else if (QuestionCheck.Checked && QuesCombo.SelectedIndex < 0)
                {
                    ErrorShow(QuesCombo, "لطفا سئوال امنیتی را تعیین کنید");
                }
                else if (QuestionCheck.Checked && AnswerBox.Text.Length < 3)
                {
                    ErrorShow(AnswerBox, "پاسخ سئوال امنیتی حداقل باید 3 حرف باشد");
                }
                else if (QuestionCheck.Checked && QuesCombo.Text == AnswerBox.Text)
                {
                    ErrorShow(AnswerBox, "پاسخ سئوال امنیتی نباید با سئوال امنیتی یکسان باشد");
                }
                else
                {
                    Enabled=false;

                    string F="";
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Pasw, UsersName FROM PUser WHERE P_Num='" + AppState.UserPnum + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (CurrentPasBox.Text == Reader["Pasw"].ToString())
                                {
                                    F=Reader["UsersName"].ToString();
                                }
                            }
                        }

                        if (string.IsNullOrEmpty(F))
                        {
                            Enabled=true;
                            StrConnec.Close();
                            MessageBoxFa.Show(" کلمه عبور فعلی صحیح نیست ", "خطا", MessageBoxIcon.Error);
                            return;
                        }
                        else if (F == NewPassBox.Text)
                        {
                            Enabled=true;
                            StrConnec.Close();
                            MessageBoxFa.Show(" کلمه عبور جدید نباید با نام کاربری یکسان باشد ", "خطا", MessageBoxIcon.Error);
                            return;
                        }

                        //Dim passPhrase As String=RandomString(8)
                        //Dim saltValue As String=RandomString(8)
                        //Dim hashAlgorithm As String="SHA1"
                        //Dim passwordIterations As Integer=2
                        //Dim initVector As String=RandomString(16)
                        //Dim keySize As Integer=128

                        string QueStr="UPDATE PUser SET";
                        if (PasswordCheck.Checked)
                        {
                            QueStr += " Pasw=@NewPass,";
                        }

                        if (QuestionCheck.Checked)
                        {
                            QueStr += " SecuQui='" + QuesCombo.SelectedItem + "', SecuAns=@NewAnse,";
                        }

                        QueStr += " Mod_Date='" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE P_Num='" + AppState.UserPnum + "'";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@NewPass", NewPassBox.Text);
                            CMD.Parameters.AddWithValue("@NewAnse", AnswerBox.Text);

                            CMD.ExecuteNonQuery();
                        }
                    }
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد \n\n برای ایجاد تغییرات نرم افزار مجدد اجرا می شود", "تایید", MessageBoxIcon.Information);

                    if (Shou)
                    {
                        Shou=false;
                        MainForm.ShClose=true;
                    }
                    Close();
                    //Application.Exit();

                }
                System.Globalization.CultureInfo TypeOfLanguage=new System.Globalization.CultureInfo("fa-IR"); // or "fa-IR" for Farsi(Iran)
                InputLanguage.CurrentInputLanguage=InputLanguage.FromCulture(TypeOfLanguage);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo TypeOfLanguage=new System.Globalization.CultureInfo("en"); // or "fa-IR" for Farsi(Iran)
                InputLanguage.CurrentInputLanguage=InputLanguage.FromCulture(TypeOfLanguage);
                if (Shou)
                {
                    PasswordCheck.Checked=true;
                    PasswordCheck.Enabled=false;
                }

                if (Sec)
                {
                    QuestionCheck.Checked=true;
                    QuestionCheck.Enabled=false;
                }

            }
            catch (Exception)
            {
                MessageBoxFa.Show(" تغییر خودکار زبان انجام نشد ", "خطا", MessageBoxIcon.Error);
            }
        }

        public void PasswordChangeForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            System.Globalization.CultureInfo Lang=InputLanguage.CurrentInputLanguage.Culture;
            if (Lang.TwoLetterISOLanguageName == "fa")
            {
                Tool.Show("زبان فارسی است", CurrentPasBox, 120, 22, 1500);
            }
            else if (Lang.TwoLetterISOLanguageName == "en")
            {
                Tool.Show("زبان انگلیسی است", CurrentPasBox, 120, 22, 1500);
            }
        }

        public void PasswordChangeForm_Shown(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo Lang=InputLanguage.CurrentInputLanguage.Culture;
            if (Lang.TwoLetterISOLanguageName == "fa")
            {
                Tool.Show("زبان فارسی است", CurrentPasBox, 120, 22, 2000);
            }
            else if (Lang.TwoLetterISOLanguageName == "en")
            {
                Tool.Show("زبان انگلیسی است", CurrentPasBox, 120, 22, 2000);
            }
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyPress=e.KeyChar;

            // کاراکترهای غیرمجاز: خارج از بازه‌ی 32 تا 126 و غیر از Backspace (8)
            if ((keyPress < 32 || keyPress > 126) && keyPress != 8)
            {
                Tool.Show("حرف غیر استاندار", CurrentPasBox, 120, 22, 1000);
                System.Media.SystemSounds.Beep.Play();
                e.KeyChar='\0';   // جلوگیری از ورود کاراکتر
            }
        }


        public void PasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            PasswordPanel.Enabled=PasswordCheck.Checked;
        }

        public void QuestionCheck_CheckedChanged(object sender, EventArgs e)
        {
            QuestionPanel.Enabled=QuestionCheck.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasswordChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Shou)
                {
                    if (MessageBoxFa.Show("از برنامه خارج می شوید؟", "خروج", MessageBoxIcon.Stop, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        MainForm.ShClose=true;
                        DialogResult=DialogResult.Cancel;
                    }
                    else
                    {
                        e.Cancel=true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxFa.Show(" تغییر خودکار زبان انجام نشد ", "خطا", MessageBoxIcon.Error);
            }
        }
    }
}
