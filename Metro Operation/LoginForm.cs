using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeModernUI();
        }

        private void InitializeModernUI()
        {
            // تنظیمات کلی فرم
            BackColor = Color.FromArgb(245, 245, 245); // خاکستری روشن
            ForeColor = Color.FromArgb(40, 40, 40);
            Font = FontManager.Gandom();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;

            // گوشه‌های گرد
            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private static class NativeMethods
        {
            [DllImport("gdi32.dll")]
            public static extern IntPtr CreateRoundRectRgn(
                int nLeftRect,    // x-coordinate of upper-left corner
                int nTopRect,     // y-coordinate of upper-left corner
                int nRightRect,   // x-coordinate of lower-right corner
                int nBottomRect,  // y-coordinate of lower-right corner
                int nWidthEllipse,   // width of ellipse
                int nHeightEllipse   // height of ellipse
            );
        }

        private int TLog = 0;
        private string ModDate;
        private bool Secu = false;
        public static string VerDate = "";
        private readonly byte[] BytArr = new byte[1001];
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper(AppState.ConnectionString);

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }


        public void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Silver;
            PassBox.PasswordChar = '\0';
            PassBox.Font = FontManager.Tahoma(11);
        }

        public void PictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            PassBox.PasswordChar = '\u25CF';//'●'; //
            PassBox.Font = FontManager.Tahoma(10);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UserBox.Text))
                {
                    ErrorShow(UserBox, "نام کاربری را وارد کنید");
                    UserBox.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(PassBox.Text))
                {
                    ErrorShow(PassBox, "کلمه عبور را وارد کنید");
                    PassBox.Focus();
                    return;
                }

                Enabled = false;

                string username = UserBox.Text.Trim();
                string password = PassBox.Text.Trim();

                DataTable dt = _dbHelper.GetDataTable("SELECT * FROM PUser WHERE UsersName=?", new[] { username });

                if (dt.Rows.Count == 0)
                {
                    HandleFailedLogin(0, "");
                    Enabled = true;
                    return;
                }

                DataRow user = dt.Rows[0];

                string dbPassword = user["Pasw"]?.ToString() ?? "";
                bool isActive = user["Acti"] != DBNull.Value && Convert.ToBoolean(user["Acti"]);
                int attemptFail = user["Atmp_Fail"] == DBNull.Value ? 0 : Convert.ToInt32(user["Atmp_Fail"]);
                AppState.UserPnum = user["P_Num"]?.ToString() ?? "";
                AppState.UserLevel = user["Acc_levl"] == DBNull.Value ? 0 : Convert.ToInt32(user["Acc_levl"]);
                ModDate = user["Mod_date"]?.ToString() ?? "";
                //LastLog=user["Last_loggin"]?.ToString() ?? "";

                if (string.IsNullOrEmpty(dt.Rows[0]["SecuQui"].ToString()) || string.IsNullOrEmpty(dt.Rows[0]["SecuAns"].ToString()))
                {
                    Secu = true;
                }

                // بررسی صحت رمز عبور
                if (password == dbPassword)
                {
                    if (!isActive)
                    {
                        MessageBoxFa.Show("نام کاربری شما مسدود است!", "خطا", MessageBoxIcon.Error);
                        Enabled = true;
                        return;
                    }

                    AppState.LogginName = username;
                    UpdateUserLoginInfo(username);

                    // بررسی نیاز به تغییر رمز عبور
                    bool pDetail = false;
                    pDetail = CheckPasswordChangeRequirement();


                    if (pDetail)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Application.Exit();// DialogResult=DialogResult.Cancel;
                    }
                }
                else
                {
                    HandleFailedLogin(attemptFail, username);
                    PassBox.Focus();
                    Enabled = true;
                    if (++TLog >= 3)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo = $"LoginButton_Click: {ex.Message}\r\n\r\n{MainForm.ErrorLogo}";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// بروزرسانی اطلاعات ورود موفق کاربر
        /// </summary>
        private void UpdateUserLoginInfo(string username)
        {
            try
            {
                string nowPersian = MainForm.PersianToday.Tarikh();
                string nowTime = DateTime.Now.ToString("HH:mm:ss");
                string lastLogin = $"{nowPersian} {nowTime}";

                _dbHelper.ExecuteNonQuery(
                    "UPDATE PUser SET Atmp_Fail=0, Last_Loggin=? WHERE UsersName=?",
                    new[] { lastLogin, username });

                _dbHelper.ExecuteNonQuery(
                "INSERT INTO PUserLoggin (Uname, In_Date, In_Time, U_IP, U_Local, IsIn) VALUES (?, ?, ?, ?, ?, ?)",
                new object[] {
                    username,
                    nowPersian,
                    nowTime,
                    Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.ToString() ?? "0.0.0.0",
                    Environment.UserDomainName + "\\" + Environment.UserName,
                    true
                });
            }
            catch (Exception ex)
            {
                throw new Exception("خطا در بروزرسانی اطلاعات ورود: " + ex.Message);
            }
        }

        /// <summary>
        /// مدیریت ورود ناموفق کاربر
        /// </summary>
        private void HandleFailedLogin(int attemptFail, string username)
        {
            PassBox.Clear();
            PassBox.Focus();

            if (username != "")
            {
                attemptFail++;

                bool disableAccount = attemptFail >= 5;

                string query = disableAccount
                    ? "UPDATE PUser SET Atmp_Fail=?, Acti=False WHERE UsersName=?"
                    : "UPDATE PUser SET Atmp_Fail=? WHERE UsersName=?";

                _dbHelper.ExecuteNonQuery(query, new object[] { attemptFail, username });
            }
            MessageBoxFa.Show(" نام کاربری یا کلمه عبور صحیح نیست!", "خطا", MessageBoxIcon.Error, MessageBoxButtons.OK);
        }


        public void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo typeOfLanguage = new System.Globalization.CultureInfo("en");
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(typeOfLanguage);
            }
            catch (Exception)
            {
                MessageBoxFa.Show("تغییر خودکار زبان انجام نشد !", "خطا", MessageBoxIcon.Error);
            }
        }

        private bool CheckPasswordChangeRequirement()
        {
            if (string.IsNullOrEmpty(ModDate) || ConvertClass.ShamsiToMiladi(ModDate.Substring(0, 10)) < DateTime.Now.AddDays(-180))
            {
                PasswordChangeForm ShForm = new PasswordChangeForm
                {
                    Shou = true
                };

                if (Secu)
                {
                    ShForm.Sec = true;
                }

                if (ShForm.ShowDialog(this) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }


        // سایر متدهای کلاس بدون تغییر باقی می‌مانند
        // ...

        public void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // بررسی نسخه آزمایشی
                if (!CheckTrialVersion())
                {
                    MessageBoxFa.Show("زمان اجرای این نسخه پایان یافته! با ادمین نرم افزار تماس بگیرید ", "خطا  ***  اثر پروانگی '", MessageBoxIcon.Error);
                    Close();
                    return;
                }

                string ver = GetLatestAppVersion();
                if (ver != Application.ProductVersion)
                {
                    MessageBoxFa.Show("نرم افزار را بروز رسانی فرمایید", "خطا", MessageBoxIcon.Exclamation);
                    System.Diagnostics.Process.Start($"{AppState.AppPath}\\Update\\Updater.exe");
                    Close();
                    return;
                }

                UserBox.Font = FontManager.Tahoma(11);
                PassBox.Font = FontManager.Tahoma(10);
                PassBox.PasswordChar = '\u25CF';

                // تنظیم زبان انگلیسی برای ورود
                SetEnglishLanguage();
            }
            catch (Exception)
            {
                MessageBoxFa.Show("خطا در بررسی فایل های موجود! با ادمین نرم افزار تماس بگیرید !", "خطا           'دنیای گم شده'", MessageBoxIcon.Error);
                Close();
            }
        }

        private bool CheckTrialVersion()
        {
            try
            {
                int trialTime = 120;
                DateTime AdmDate = DateTime.Now;

                using (System.IO.FileStream myStream = System.IO.File.Open(AppState.AppPath + "\\Metro.alfa", System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    int i;
                    int j = 0;
                    string d = "";
                    string m = "";
                    string y = "";
                    myStream.Read(BytArr, 0, 1000);
                    j = 0;
                    d = "";
                    m = "";
                    y = "";

                    for (i = 0; i <= 999; i++)
                    {
                        if (j * 100 == i && j < 8)
                        {
                            j++;
                            switch (j)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                    y += BytArr[i].ToString();
                                    break;
                                case 5:
                                case 6:
                                    m += BytArr[i].ToString();
                                    break;
                                case 7:
                                case 8:
                                    d += BytArr[i].ToString();
                                    break;
                            }
                        }
                    }

                    myStream.Close();

                    AdmDate = ConvertClass.ShamsiToMiladi(y + "/" + m + "/" + d);

                    if (AdmDate.AddDays(trialTime) < DateTime.Now || AdmDate > DateTime.Now)
                    {
                        return false;
                    }
                }
                MainForm.TrlTime = trialTime - (DateTime.Now - AdmDate).Days;

                return true;
            }
            catch (Exception)
            {
                MessageBoxFa.Show("خطا در بررسی فایل های موجود! با ادمین نرم افزار تماس بگیرید !", "خطا           'دنیای گم شده'", MessageBoxIcon.Error);
                Close();
                return false;
            }
        }

        private string GetLatestAppVersion()
        {
            string ver = "";

            using (OleDbConnection StrConnec = AppState.GetConnection())
            {
                StrConnec.Open();
                using (OleDbCommand CMD = new OleDbCommand("SELECT TOP 1 Ver FROM AppVer WHERE Vis=True ORDER BY ID DESC", StrConnec))
                using (OleDbDataReader reader = CMD.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ver = reader["Ver"].ToString();
                    }
                }
            }
            return ver;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            HelpForm ShowForm = new HelpForm();
            ShowForm.WebBrowser1.Navigate(MainForm.Path + "\\Help\\Login.mht");
            ShowForm.ShowDialog(this);
        }

        public void PassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int KeyPress = e.KeyChar;
                ToolTip tool = new ToolTip();
                if ((KeyPress > 126 || KeyPress < 32) && KeyPress != 8)
                {
                    tool.Show("حرف غیر استاندار", UserBox, 120, 22, 2000);
                    Console.Beep();
                    e.KeyChar = '\0';
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                PaswordRecoveryForm ShowForm = new PaswordRecoveryForm();
                ShowForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void SetEnglishLanguage()
        {
            try
            {
                System.Globalization.CultureInfo typeOfLanguage = new System.Globalization.CultureInfo("en");
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(typeOfLanguage);
            }
            catch (Exception)
            {
                MessageBoxFa.Show("تغییر خودکار زبان انجام نشد !", "خطا", MessageBoxIcon.Error);
            }
        }
    }
}
