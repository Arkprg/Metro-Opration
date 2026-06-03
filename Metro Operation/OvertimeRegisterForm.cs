using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class OvertimeRegisterForm
    {
        public OvertimeRegisterForm()
        {
            InitializeComponent();
        }

        private string PNname;
        private string PFamily;
        private string PNum;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clear()
        {
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate = ShamsiToMiladi(PersianCalendar.Text);

                if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (SelectDate > DateTime.Today.AddDays(1))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "عنوان اضافه کاری صحیح نیست");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "شیفت اضافه کاری صحیح نیست");
                }
                else if (TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "مدت اضافه کار صحیح نیست");
                }
                else if ((string)KindCombo.SelectedItem == "تشویق فنی" && TimeToDouble(TimeBox.Text, true) > 5)
                {
                    ErrorShow(TimeBox, " مدت اضافه کاری صحیح نیست");
                }
                else if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, " نام پرسنل را مشخص کنید ");
                }
                else if (MemBox.Text.Length < 10 && (string)KindCombo.SelectedItem != "کشیک")
                {
                    ErrorShow(MemBox, "ارائه توضیحات تکمیلی الزامی است");
                }
                else
                {

                    Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                    double TopOver = 0;
                    double OverTime = 0;
                    TopOver = 0;
                    OverTime = 0;

                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        // ***  محدودیت سقف اضافه کار انتقالی به ماه بعد ****
                        using (OleDbCommand CMD = new OleDbCommand("SELECT MonthTime FROM ShKar WHERE Tarikh='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                TopOver = TimeToDouble(Reader["MonthTime"].ToString());
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("SELECT Tota, TotaJom, NexMo FROM TotaMonAdv WHERE P_Num='" + PNum + "' AND Maah='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                OverTime = TimeToDouble(Reader["NexMo"].ToString()) + TimeToDouble(Reader["Tota"].ToString()) + TimeToDouble(Reader["TotaJom"].ToString());
                            }
                        }

                        if (OverTime + TimeToDouble(TimeBox.Text) > TopOver + 10 && AppState.UserLevel > 2)
                        {
                            StrConnec.Close();
                            MessageBoxFa.Show("اضافه کار " + NameBox.Text + " بیشتر از سقف تعین شده است", "خطا", MessageBoxIcon.Error);
                            Enabled = true;
                            return;
                        }

                        double OvTime = 0;
                        using (OleDbCommand CMD = new OleDbCommand($"SELECT E_Time, E_Kind, U_Reg FROM Ezafeh WHERE P_Num='{PNum}' AND Tarikh='{PersianCalendar.Text}' AND Vis=True AND E_Kind<>'جایگزین مرخصی ساعتی'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                OvTime += TimeToDouble(Reader["E_Time"].ToString());
                                if (Reader["E_Kind"].ToString().IndexOf("شب قبل") + 1 == 0 && Reader["U_Reg"].ToString() == AppState.UserName)
                                {
                                    Enabled = true;
                                    StrConnec.Close();
                                    MessageBoxFa.Show("برای " + NameBox.Text + "در این تاریخ اضافه کار ثبت کرده اید!", "خطا", MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        if (OvTime > 24)
                        {
                            Enabled = true;
                            StrConnec.Close();

                            MessageBoxFa.Show("در این تاریخ برای " + NameBox.Text + " اضافه کار از سقف مجاز بیشتر است!", "خطا", MessageBoxIcon.Error);
                            return;
                        }

                        OvTime = TimeToDouble(TimeBox.Text);
                        if ((string)ShiftCombo.SelectedItem == "12 ساعته شب" && OvTime > 4.5)
                        {
                            OvTime -= 4.5;
                            PersianDate.SetDate(PersianCalendar.Text);
                            PersianDate.AddDay(1);

                            using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Local, E_Kind, E_Mem, T_Reg, U_Reg, Vis) VALUES ('{PNum}','{PersianDate.Tarikh()}', '{DoubleToTime(OvTime)}', '{LocalCombo.SelectedItem}', '{KindCombo.SelectedItem} شب قبل ', @Mem, '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', '{AppState.UserName}', True)", StrConnec))
                            {
                                CMD.Parameters.AddWithValue("@Mem", ShiftCombo.SelectedItem + " - " + MemBox.Text.Trim());
                                CMD.ExecuteNonQuery();
                            }

                            PersianDate.SetDate(PersianCalendar.Text);
                            OvTime = 4.5;
                        }

                        using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Local, E_Kind, E_Mem, T_Reg, U_Reg, Vis) VALUES ('{ PNum }','{PersianCalendar.Text }', '{ DoubleToTime(OvTime) }', '{ LocalCombo.SelectedItem}', '{KindCombo.SelectedItem}', @Mem, '{MainForm.PersianToday.Tarikh() } { DateTime.Now:HH:mm:ss}', '{ AppState.UserName }', True)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", ShiftCombo.SelectedItem + " - " + MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }
                        OptimizationForm ShowForm = new OptimizationForm();
                        ShowForm.PersoOptim(PNum, MainForm.PersianToday.Tarikh(), StrConnec);
                    }

                    Clear();
                    Enabled = true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    //End If
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void OvertimeRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0105");
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label10.Text = "مدت اضافه کار:";
            Label10.Visible = true;
            LeaveCombo.Visible = false;
            TimeBox.Visible = true;
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;

            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                if (AppState.UserLevel > 5 && PersonalSelectForm.PPost == AppState.UserPost)
                {
                    MessageBoxFa.Show("مجاز به ثبت اضافه کار برای این شخص نیستید !", "خطا", MessageBoxIcon.Error);
                }
                else
                {
                    PFamily = PersonalSelectForm.PFamily;
                    PNname = PersonalSelectForm.PName;
                    PNum = PersonalSelectForm.PNum;
                    //PTime=PersonalSelectForm.PTime;
                    //PPost=PersonalSelectForm.PPost;
                    NameBox.Text = PNname + " " + PFamily;
                    NameButton.Image = Properties.Resources.cancel1;

                    DataRow[] DRow = MainForm.PersonTable.Select("P_Num='" + PNum + "'");
                    if (!(bool)DRow[0]["OverTime"])
                    {
                        if (AppState.UserLevel < 6)
                        {
                            if (MessageBoxFa.Show("این شخص مجوز اضافه کار ندارد ! \n آیا اضافه کار را ثبت می نمایید؟", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button1) == DialogResult.No)
                            {
                                NameBox.Text = "";
                                return;
                            }
                        }
                        else
                        {
                            MessageBoxFa.Show("این شخص مجوز اضافه کار ندارد !", "خطا", MessageBoxIcon.Error);
                            NameBox.Text = "";
                            return;
                        }
                    }
                    else
                    {

                        double Sum = 0;
                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD = new OleDbCommand("SELECT E_Time FROM Ezafeh WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND E_Kind<>'جایگزین مرخصی ساعتی'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Sum += TimeToDouble(Reader["E_Time"].ToString());
                                }
                            }
                        }

                        if (Sum > 0)
                        {
                            MessageBoxFa.Show("در تاریخ " + PersianCalendar.Text + " برای " + NameBox.Text + " " + DoubleToTime(Sum) + " ساعت اضافه کار ثبت شده است !", "توجه", MessageBoxIcon.Information);
                        }
                    }
                }
            }

        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex = -1;
        }

        public void OvertimeRegisterForm_Load(object sender, EventArgs e)
        {
            Label10.Text = "مدت اضافه کار:";
            Label10.Visible = true;

            LocalCombo.Items.Clear();

            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
            if (LocalCombo.Items.Count > 0)
            {
                LocalCombo.SelectedItem = AppState.UserLocal;
            }

            LeaveCombo.Visible = false;
            TimeBox.Visible = true;
            if (AppState.UserLevel == 4)
            {
                KindCombo.Items.Add("اضافه کار");
            }
            else if (AppState.UserLevel < 6)
            {
                if (AppState.UserLevel == 0)
                {
                    KindCombo.Items.Add("شیفت");
                }
                KindCombo.Items.Add("اضافه کار");
                KindCombo.Items.Add("تشویقی");
                KindCombo.Items.Add("کشیک");
                KindCombo.Items.Add("کلاس آموزشی");
                KindCombo.Items.Add("قطار فوق العاده");
                KindCombo.Items.Add("همکاری با شیفت");
            }
            else if (AppState.UserLevel >= 6 && AppState.UserLevel < 9)
            {
                KindCombo.Items.Add("تشویقی");
                KindCombo.Items.Add("قطار فوق العاده");
                KindCombo.Items.Add("همکاری با شیفت");
            }
            else if (AppState.UserLevel > 10)
            {
                KindCombo.Items.Add("کشیک");
                KindCombo.Items.Add("همکاری با شیفت");
            }

            ShiftCombo.Items.Clear();
            if (AppState.UserStaff == "عملیات پارکینگ و مانور")
            {
                ShiftCombo.Items.Add("12 ساعته روز");
                ShiftCombo.Items.Add("12 ساعته شب");
            }
            else
            {
                ShiftCombo.Items.Add("9 ساعته صبح");
                ShiftCombo.Items.Add("9 ساعته عصر");
                ShiftCombo.Items.Add("12 ساعته روز");
                ShiftCombo.Items.Add("12 ساعته شب");
                ShiftCombo.Items.Add("ستادی");
            }
        }

        public void PersianCalendar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                    RegButton.Enabled = false;
                }
                else
                {
                    RegButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemBox.Copy();
        }

        public void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MemBox.Paste();
        }

        public void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemBox.Cut();
        }
    }
}
