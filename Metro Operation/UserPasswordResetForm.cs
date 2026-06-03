using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UserPasswordResetForm
    {
        public UserPasswordResetForm()
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

        public void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand("UPDATE PUser SET Pasw='12345', Mod_Date='', SecuQui='', SecuAns='', Acti=True, Atmp_fail=0 WHERE P_Num='" + PNum + "'", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }

                Enabled = true;
                PersonBox.Text = "";
                PersonalButton.Image = Properties.Resources.user;
                UserNameLabel.Text = "";
                LastLoginLabel.Text = "";

                PersonBox.Select();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersonalButton_Click(object sender, EventArgs e)
        {
            PersonBox.Text = "";
            PersonalButton.Image = Properties.Resources.user;

            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;

                PersonBox.Text = PName + " " + PFamily;
                PersonalButton.Image = Properties.Resources.cancel1;

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand("SELECT UsersName, Last_Loggin FROM PUser WHERE P_Num='" + PNum + "'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            UserNameLabel.Text = Reader["UsersName"].ToString();
                            LastLoginLabel.Text = Reader["Last_Loggin"].ToString();
                        }
                    }
                }

                if (UserNameLabel.Text == "")
                {
                    ErrorShow(PersonBox, "این نام کاربری پیدا نشد");
                }
                else
                {
                    ResetButton.Focus();
                }
            }
        }
    }
}
