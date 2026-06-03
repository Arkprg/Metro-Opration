using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class OvertimeRequestEditForm : BaseForm
    {
        public OvertimeRequestEditForm()
        {
            InitializeComponent();
        }

        private string ID;
        private string PName;
        private string PFamily;
        private string PNum;
        private string PLocal;
        private readonly string[] Over = new string[7];

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clean()
        {
            ID = "";
            RegButton.Enabled = false;
            DelButton.Enabled = false;
            LocalOptions();
        }

        public int OverCheck()
        {
            int i = 0;
            Over[0] = "";
            Over[1] = "";
            Over[2] = "";
            Over[3] = "";
            Over[4] = "";
            Over[5] = "";

            if (AllCheck.Checked)
            {
                Over[i] = "همه موارد";
                i = 4;
            }
            else
            {
                if (R12Check.Checked)
                {
                    Over[i] = "12 ساعته روز";
                    i++;
                }
                if (S12Check.Checked)
                {
                    Over[i] = "12 ساعته شب";
                    i++;
                }
                if (S9Check.Checked)
                {
                    Over[i] = "9 ساعته صبح";
                    i++;
                }
                if (A9Check.Checked)
                {
                    Over[i] = "9 ساعته عصر";
                    i++;
                }
                if (HashtCheck.Checked)
                {
                    Over[i] = "هشتگرد";
                    i++;
                }
            }
            return i;
        }

        private void LocalOptions()
        {
            R12Check.Visible = true;
            S12Check.Visible = true;
            HashtCheck.Visible = true;
            S9Check.Visible = true;
            A9Check.Visible = true;

            AllCheck.Checked = false;
            R12Check.Checked = false;
            S12Check.Checked = false;
            S9Check.Checked = false;
            A9Check.Checked = false;
            HashtCheck.Checked = false;

            if ((string)LocalCombo.SelectedItem == "هشتگرد")
            {
                R12Check.Visible = false;
                S12Check.Visible = false;
                HashtCheck.Visible = false;
                if (AppState.UserLevel == 9)
                {
                    S9Check.Visible = false;
                    A9Check.Visible = false;
                }

            }
            else if ((string)LocalCombo.SelectedItem != "گلشهر")
            {
                HashtCheck.Visible = false;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clean();

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پرسنل را مشخص کنید");
                }
                else if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) > DateTime.Today.AddDays(10) || ConvertClass.ShamsiToMiladi(PersianCalendar.Text) < DateTime.Today.AddDays(1))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده خارج از محدوده قابل ویرایش است");
                }
                else
                {

                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM DailyProcess WHERE Tarikh='" + PersianCalendar.Text + "' AND L_Num='" + AppState.UserLnum + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show("در این تاریخ پردازش لوحه انجام شده، امکان ویرایش وجود ندارد", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM JayGozin WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                LocalOptions();

                                LocalCombo.Text = Reader["Shift_loc"].ToString();

                                List<string> OptionList = new List<string>
                                {
                                    Reader["Olv1"].ToString(),
                                    Reader["Olv2"].ToString(),
                                    Reader["Olv3"].ToString(),
                                    Reader["Olv4"].ToString()
                                };

                                foreach (string Op in OptionList)
                                {
                                    switch (Op)
                                    {
                                        case "همه موارد":
                                            AllCheck.Checked = true;
                                            break;
                                        case "12 ساعته روز":
                                            R12Check.Checked = true;
                                            break;
                                        case "12 ساعته شب":
                                            S12Check.Checked = true;
                                            break;
                                        case "9 ساعته صبح":
                                            S9Check.Checked = true;
                                            break;
                                        case "9 ساعته عصر":
                                            A9Check.Checked = true;
                                            break;
                                        case "هشتگرد":
                                            HashtCheck.Checked = true;
                                            break;
                                    }
                                }

                                ID = Reader["ID"].ToString();
                            }
                        }
                    }


                    Enabled = true;
                    if (string.IsNullOrEmpty(ID))
                    {
                        MessageBoxFa.Show(" درخواستی برای این شخص ثبت نشده است", "خطا", MessageBoxIcon.Error);
                    }
                    else
                    {
                        RegButton.Enabled = true;
                        DelButton.Enabled = true;
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

        public void NameButton_Click(object sender, EventArgs e)
        {
            Clean();
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;
                PLocal = PersonalSelectForm.PLocal;
                NameBox.Text = PName + " " + PFamily;
                NameButton.Image = Properties.Resources.cancel1;
            }
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            Clean();
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocalCombo.SelectedIndex >= 0 && PLocal != (string)LocalCombo.SelectedItem)
            {
                if (MessageBoxFa.Show("آیا برای مبدا دیگری درخواست می دهید؟", "توجه", MessageBoxIcon.Information, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    LocalCombo.SelectedIndex = -1;
                    LocalCombo.Focus();
                    return;
                }
            }
            LocalOptions();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID))
                {
                    ErrorShow(ShowButton, "دوباره جستجو کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (OverCheck() < 2 && AppState.UserLevel > 8 && (LocalCombo.SelectedItem.ToString() == "گلشهر" || LocalCombo.SelectedItem.ToString() == "هشتگرد"))
                {
                    ErrorShow(Panel4, "حداقل دو گزینه را انتخاب کنید");
                }
                else if (OverCheck() > 4)
                {
                    ErrorShow(Panel4, "حداکثر 4 گزینه را انتخاب کنید");
                }
                else
                {

                    Enabled = false;
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD = new OleDbCommand("UPDATE JayGozin SET Vis=False WHERE ID=" + ID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD = new OleDbCommand("INSERT INTO JayGozin (P_Num, Tarikh, Olv1, Olv2, Olv3, Olv4, Shift_Loc, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + Over[0] + "', '" + Over[1] + "', '" + Over[2] + "', '" + Over[3] + "',  '" + LocalCombo.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + ID + ")", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    if (NameButton.Enabled)
                    {
                        NameBox.Text = "";
                    }

                    Clean();

                    Enabled = true;
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

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ID))
                {
                    ErrorShow(ShowButton, "دوباره جستجو کنید");
                }
                else
                {
                    if (MessageBoxFa.Show(" آیا مایلید داده ها حذف گردد؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Enabled = false;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD = new OleDbCommand("UPDATE JayGozin SET Vis=False WHERE ID=" + ID, StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD = new OleDbCommand("INSERT INTO JayGozin (P_NUM, Tarikh, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "','" + PersianCalendar.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', False, -" + ID + ")", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        NameBox.Text = "";
                        Clean();

                        Enabled = true;
                        MessageBoxFa.Show("حذف با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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

        public void OvertimeRequestEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0110");
        }

        public void OvertimeRequestEditForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.Miladi = DateTime.Today;
            LocalCombo.Items.Clear();

            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }

            if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
            {
                NameButton.Enabled = false;
                NameBox.Text = AppState.UserName;
                PLocal = AppState.UserLocal;
                LocalCombo.SelectedItem = AppState.UserLocal;
                PNum = AppState.UserPnum;
            }

            Clean();
        }

        private void PersianCalendar_Enter(object sender, EventArgs e)
        {
            Clean();
        }

        private void AllCheck_CheckedChanged(object sender, EventArgs e)
        {
            R12Check.Checked = false;
            S12Check.Checked = false;
            S9Check.Checked = false;
            A9Check.Checked = false;
            HashtCheck.Checked = false;

            if (AllCheck.Checked)
            {
                R12Check.Enabled = false;
                S12Check.Enabled = false;
                S9Check.Enabled = false;
                A9Check.Enabled = false;
                HashtCheck.Enabled = false;
            }
            else
            {
                R12Check.Enabled = true;
                S12Check.Enabled = true;
                S9Check.Enabled = true;
                A9Check.Enabled = true;
                HashtCheck.Enabled = true;
            }
        }
    }
}
