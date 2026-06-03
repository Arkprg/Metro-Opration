using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class OvertimeEditForm
    {
        private int FID;
        private string PName;
        private string PFamily;
        private string PNum;
        private string EzTim;

        public OvertimeEditForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private void Dis()
        {
            TimeBox.Text = "";
            MemBox.Text = "";
            NameButton.Image = Properties.Resources.user;
            KindCombo.SelectedIndex = -1;
            LocalCombo.SelectedIndex = -1;
            Panel2.Enabled = false;
            RegButton.Enabled = false;
            DeletButton.Enabled = false;
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            Dis();
            RegButton.Enabled = false;
            DeletButton.Enabled = false;
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;
                NameBox.Text = PName + " " + PFamily;
                NameButton.Image = Properties.Resources.cancel1;
            }
        }

        public void OvertimeEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0106");
        }

        public void Form36_Load(object sender, EventArgs e)
        {
            PersianCalendar.Text = MainForm.PersianToday.Tarikh();
            NameBox.Text = "";
            TimeBox.Text = "";
            MemBox.Text = "";
            Panel2.Enabled = false;
            RegButton.Enabled = false;
            DeletButton.Enabled = false;

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
                LocalCombo.SelectedIndex = 0;
            }

            KindCombo.Items.Clear();
            if (AppState.UserLevel < 6)
            {
                if (AppState.UserLevel == 0)
                {
                    KindCombo.Items.Add("شیفت");
                }

                KindCombo.Items.Add("تشویقی");
                KindCombo.Items.Add("کلاس آموزشی");
                KindCombo.Items.Add("کشیک");
                KindCombo.Items.Add("قطار فوق العاده");
                KindCombo.Items.Add("همکاری با شیفت");
            }
            else if (AppState.UserLevel == 6)
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
            PersianCalendar.Today_Click(null, null);
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dis();
                RegButton.Enabled = false;
                DeletButton.Enabled = false;
                DateTime SelectDate = ShamsiToMiladi(PersianCalendar.Text);

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, " نام پرسنل را انتخاب کنید");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, " تاریخ را انتخاب کنید");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else
                {
                    Enabled = false;
                    if (SelectDate.DayOfWeek == DayOfWeek.Friday)
                    {
                        DayLabel.Text = "اضافه کار روز جمعه";
                    }
                    else
                    {
                        DayLabel.Text = "اضافه کار روز عادی";
                    }

                    FID = -1;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Ezafeh WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND E_Kind<>'جایگزین مرخصی ساعتی' AND U_Reg='" + AppState.UserName + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (AppState.UserLevel > 5 && KindCombo.Items.IndexOf(Reader["E_Kind"].ToString()) < 0)
                                {
                                    KindCombo.Items.Add(Reader["E_Kind"].ToString());
                                    KindCombo.SelectedItem = Reader["E_Kind"].ToString();
                                    KindCombo.Enabled = false;
                                }
                                else
                                {
                                    KindCombo.Text = Reader["E_Kind"].ToString();
                                }
                                FID = Convert.ToInt32(Reader["ID"].ToString());
                                TimeBox.Text = Reader["E_Time"].ToString();
                                LocalCombo.Text = Reader["E_Local"].ToString();
                                MemBox.Text = Reader["E_Mem"].ToString();

                                Panel2.Enabled = true;
                                RegButton.Enabled = true;
                                DeletButton.Enabled = true;
                            }
                        }

                        if (FID < 0)
                        {
                            FID = -1;

                            using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Ezafeh WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND E_Kind<>'جایگزین مرخصی ساعتی'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (KindCombo.Items.IndexOf(Reader["E_Kind"].ToString()) < 0)
                                    {
                                        KindCombo.Items.Add(Reader["E_Kind"].ToString());
                                        KindCombo.SelectedItem = Reader["E_Kind"].ToString();
                                        if (AppState.UserLevel > 5) KindCombo.Enabled = false;
                                    }
                                    else
                                    {
                                        KindCombo.Text = Reader["E_Kind"].ToString();
                                    }
                                    FID = Convert.ToInt32(Reader["ID"].ToString());
                                    TimeBox.Text = Reader["E_Time"].ToString();
                                    LocalCombo.Text = Reader["E_Local"].ToString();
                                    MemBox.Text = Reader["E_Mem"].ToString();

                                    Panel2.Enabled = true;
                                    RegButton.Enabled = true;
                                    DeletButton.Enabled = true;
                                }
                            }
                        }
                    }

                    Enabled = true;
                    if (FID < 0)
                    {
                        MessageBoxFa.Show("اضافه کاری برای این شخص ثبت نشده است", "خطا", MessageBoxIcon.Error);
                    }
                    else
                    {
                        EzTim = TimeBox.Text;
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

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate = ShamsiToMiladi(PersianCalendar.Text);

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, " نام پرسنل را مشخص کنید ");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "مدت اضافه کار صحیح نیست");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "عنوان اضافه کاری صحیح نیست");
                }
                else if ((string)KindCombo.SelectedItem == "تشویق فنی" && TimeToDouble(TimeBox.Text) > 5)
                {
                    ErrorShow(TimeBox, " اضافه کاری صحیح نیست");
                }
                else if (MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "ارائه توضیحات تکمیلی الزامی است");
                }
                else
                {
                    if (EzTim != TimeBox.Text || MemBox.Text.Trim() != "")
                    {
                        double TopOver = 0;
                        double OverTime = 0;
                        TopOver = 0;
                        OverTime = 0;
                        Enabled = false;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            using (OleDbCommand CMD = new OleDbCommand("SELECT MonthTime FROM ShKar WHERE Tarikh='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    TopOver = TimeToDouble(Reader["MonthTime"].ToString());
                                }
                            }

                            using (OleDbCommand CMD = new OleDbCommand("SELECT NexMo, Tota, TotaJom FROM TotaMonAdv WHERE P_Num='" + PNum + "' AND Maah='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    OverTime = TimeToDouble(Reader["NexMo"].ToString()) + TimeToDouble(Reader["Tota"].ToString()) + TimeToDouble(Reader["TotaJom"].ToString());
                                }
                            }

                            if (OverTime > TopOver && TimeToDouble(TimeBox.Text) > TimeToDouble(EzTim) && AppState.UserLevel > 2)
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show("اضافه کار " + NameBox.Text + " بیشتر از سقف تعین شده است", "خطا", MessageBoxIcon.Error);
                                Enabled = true;
                                return;
                            }

                            using (OleDbCommand CMD = new OleDbCommand("UPDATE Ezafeh SET Vis=False WHERE ID=" + FID, StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Local, E_Kind, E_Mem, T_Reg, U_Reg, Fad, Vis) VALUES ('" + PNum + "','" + PersianCalendar.Text + "', '" + TimeBox.Text + "', '" + LocalCombo.SelectedItem + "', '" + KindCombo.Text + "', @Mem, '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', '" + AppState.UserName + "', " + FID + ", True)", StrConnec))
                            {
                                CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                                CMD.ExecuteNonQuery();
                            }

                            //OptimizationForm.TotaEzafe(PNum, PersianCalendar.Text)  ' محاسبات قدیم
                            OptimizationForm ShowForm = new OptimizationForm();
                            ShowForm.PersoOptim(PNum, MainForm.PersianToday.Tarikh(), StrConnec);
                        }

                        NameBox.Text = "";
                        TimeBox.Text = "";
                        MemBox.Text = "";
                        if (!KindCombo.Enabled)
                        {
                            KindCombo.Enabled = true;
                            KindCombo.Items.RemoveAt(KindCombo.SelectedIndex);
                        }
                        LocalCombo.SelectedIndex = -1;
                        RegButton.Enabled = false;
                        DeletButton.Enabled = false;

                        Enabled = true;
                        MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DeletButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("اضافه کاری ثبت شده، حذف شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Enabled = false;
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD = new OleDbCommand("UPDATE Ezafeh SET Vis=False WHERE ID=" + FID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, U_Reg, T_Reg, Fad, Vis) VALUES ('" + PNum + "','" + PersianCalendar.Text + "', '" + EzTim + "', '" + KindCombo.SelectedItem + "', '" + LocalCombo.SelectedItem + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', " + FID + ", False)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        OptimizationForm ShowForm = new OptimizationForm();
                        ShowForm.PersoOptim(PNum, PersianCalendar.Text, StrConnec);
                    }


                    NameBox.Text = "";
                    TimeBox.Text = "";
                    MemBox.Text = "";

                    if (!KindCombo.Enabled && KindCombo.SelectedIndex >= 0)
                    {
                        KindCombo.Enabled = true;
                        KindCombo.Items.RemoveAt(KindCombo.SelectedIndex);
                    }
                    LocalCombo.SelectedIndex = -1;
                    RegButton.Enabled = false;
                    DeletButton.Enabled = false;
                    Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersianCalendar_Leave(object sender, EventArgs e)
        {
            RegButton.Enabled = false;
            DeletButton.Enabled = false;
            Dis();
        }
    }
}
