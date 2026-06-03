using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class TimeLeaveRegisterForm
    {
        public TimeLeaveRegisterForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string PTime;
        private string PLoc;
        private string PPost;
        private string ShName;
        private string JPName;
        private string JPFamily;
        private string JPNum;
        private string JShName;
        private bool NextDay;
        private double Ti;
        private int Tri;
        private int Num;

        //    اصلاح شود
        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void TimeCalculate()
        {
            if (TimeToDouble(StartBox.Text, true) > 0 && PPost == "راهبر قطار")
            {
                if (AppState.UserLnum == "5")
                {
                    Ti = 4;
                    //If TimeZ Then ' اولین مرخصی ماه
                    //    Ti += 0
                    //Else
                    //If PTime="12 ساعته" Then
                    //    Ti += TimeToDouble("05:20")
                    //Else
                    //    If PLoc="هشتگرد" Then
                    //        Ti += TimeToDouble("04:20")
                    //    Else
                    //        Ti += TimeToDouble("06:30")
                    //    End If
                    //End If
                    if (TripBox.Checked)
                    {
                        Ti = 0;
                    }
                    double EndTime = TimeToDouble(StartBox.Text) + Ti;
                    if (EndTime >= 24)
                    {
                        EndTime -= 24;
                        NextDay = true;
                    }
                    EndBox.Text = DoubleToTime(EndTime);
                    Label6.Text = NumToWord.ConvertNumber(Num, true) + "ین مرخصی ساعتی ماه جاری"; // - مدت محاسبه: " & DoubleToTime(Ti).ToString
                }
            }
        }

        public void Clea()
        {
            NameBox.Text = "";
            StartBox.Text = "";
            EndBox.Text = "";
            NextDay = false;
            ReplaceCombo.SelectedIndex = -1;
            ReplaceCombo.Items.Clear();
            JNameBox.Text = "";
            Label6.Text = "";
            MemBox.Text = "";
            TripBox.Visible = false;
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate = ShamsiToMiladi(PersianCalendar.Text);

                if (NameBox.ToString().Length == 0)
                {
                    ErrorShow(NameBox, "نام پرسنل را انتخاب کنید");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (TimeToDouble(StartBox.Text, true) < 0)
                {
                    ErrorShow(StartBox, "ساعت شروع مرخصی ساعتی صحیح نیست");
                }
                else if (TimeToDouble(EndBox.Text, true) < 0)
                {
                    ErrorShow(EndBox, "ساعت پایان مرخصی ساعتی صحیح نیست");
                }
                else if (DateTime.Parse(StartBox.Text) > DateTime.Parse(EndBox.Text) && !NextDay)
                {
                    ErrorShow(StartBox, "بازه مرخصی ساعتی صحیح نیست");
                    ErrorShow(EndBox, "بازه مرخصی ساعتی صحیح نیست");
                }
                else if (ReplaceCombo.SelectedIndex < 0)
                {
                    ErrorShow(ReplaceCombo, "نوع جایگزین را انتخاب کنید");
                }
                else if (JNameBox.Enabled && JNameBox.Text.ToString().Length == 0)
                {
                    ErrorShow(JNameBox, "نام پرسنل را انتخاب کنید");
                }
                else if (ShName == JShName && (string)ReplaceCombo.SelectedItem == "با جایگزین")
                {
                    ErrorShow(JNameBox, "جایگزین هم شیفت مجاز نیست");
                }
                else if (((string)ReplaceCombo.SelectedItem == "بدون جایگزین" || TripBox.Checked) && MemBox.Text.Length < 10)
                {
                    ErrorShow(MemBox, "توضیحات لازم را وارد نمایید");
                }
                else
                {
                    string Shift1 = ""; //
                    string Shift2 = "";
                    string ShiftLast = "";
                    string Jay = "";
                    string Kind = "";
                    bool Holy = false;
                    Taghvim YesterDay = new Taghvim();

                    Enabled = false;
                    //WD=ConvertClass.ShamsiToMiladi(PersianCalendar.Text).DayOfWeek;

                    Shift1 = "";
                    Shift2 = "";
                    ShiftLast = "";

                    YesterDay.SetDate(PersianCalendar.Text);
                    YesterDay.AddDay(-1);
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD = new OleDbCommand("SELECT Sobh, Asr, Holi FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Shift1 = Reader["Sobh"].ToString();
                                Shift2 = Reader["Asr"].ToString();
                                Holy = Convert.ToBoolean((bool)Reader["Holi"]);
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("SELECT Asr FROM taghvim WHERE Tarikh='" + YesterDay.Tarikh() + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ShiftLast = Reader["Asr"].ToString();
                            }
                        }

                        if (PTime == "ستادی" && Holy)
                        {
                            StrConnec.Close();
                            Enabled = true;
                            ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                            return;

                        }
                        else if (PTime == "9 ساعته" && ShName != Shift1 && ShName != Shift2)
                        {
                            StrConnec.Close();
                            Enabled = true;
                            ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                            return;

                        }
                        else if (PTime == "12 ساعته")
                        {
                            if (ShName != Shift1 && ShName != Shift2 && ShName != ShiftLast) // شیفت های جاری
                            {
                                StrConnec.Close();
                                Enabled = true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;

                            }
                            else if (string.Compare(StartBox.Text, "07:29") < 0 && ShName != ShiftLast) // شب کار دیشب
                            {
                                StrConnec.Close();
                                Enabled = true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;

                            }
                            else if (string.Compare(StartBox.Text, "07:29") > 0 && string.Compare(StartBox.Text, "19:29") < 0 && ShName != Shift1) // روزکار امروز
                            {
                                StrConnec.Close();
                                Enabled = true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;

                            }
                            else if (string.Compare(StartBox.Text, "19:29") > 0 && ShName != Shift2) // شب کار امشب
                            {
                                StrConnec.Close();
                                Enabled = true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM Amal WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND (OnvAmal='ساعتی' OR OnvAmal='حذف تریپ')", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                Enabled = true;

                                ErrorShow(PersianCalendar, "در این تاریخ برای " + NameBox.Text + " مرخصی ساعتی ثبت شده است");
                                return;
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM Morakhasi WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                Enabled = true;

                                ErrorShow(PersianCalendar, "در این تاریخ برای " + NameBox.Text + " مرخصی روزانه ثبت شده است");
                                return;
                            }
                        }

                        Jay = "";
                        Kind = "ساعتی";

                        if (ReplaceCombo.Text == "راهبر رزرو")
                        {
                            Jay = "رزرو " + JPNum;
                            if (Tri > 0)
                            {

                                string QueStr = "UPDATE Rezerv SET";
                                if (Tri == 1)
                                {
                                    QueStr += " Trip1='" + StartBox.Text + "',";
                                }
                                else if (Tri == 2)
                                {
                                    QueStr += " Trip2='" + StartBox.Text + "',";
                                }
                                else if (Tri == 3)
                                {
                                    QueStr += " Trip3='" + StartBox.Text + "',";
                                }
                                QueStr += " U_Mod='" + AppState.UserName + "' WHERE P_Num='" + JPNum + "' AND Tarikh='";
                                Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                                if (PTime == "12 ساعته" && string.Compare(StartBox.Text, "07:30") < 0)
                                {
                                    QueStr += PersianDate.AddDay(-1) + "'";
                                }
                                else
                                {
                                    QueStr += PersianDate.Tarikh() + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                            }

                        }
                        else if (ReplaceCombo.Text == "با جایگزین")
                        {

                            double TopOver = 0;
                            double OverTime = 0;
                            TopOver = 0;
                            OverTime = 0;

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

                            if (TopOver < OverTime + 4 && AppState.UserLevel > 2)
                            {
                                StrConnec.Close();
                                Enabled = true;
                                MessageBoxFa.Show("اضافه کار " + JNameBox.Text + " بیشتر از سقف تعین شده است", "خطا", MessageBoxIcon.Error);
                                return;
                            }

                            Jay = "با جا" + JPNum;
                            using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, U_Reg, E_Time, E_Kind, E_Mem, T_Reg, Vis) VALUES ('" + JPNum + "','" + PersianCalendar.Text + "', '" + AppState.UserName + "', '06:30', 'جایگزین مرخصی ساعتی', ' " + NameBox.Text + "', '" + MainForm.PersianToday.Tarikh(DateTime.Today) + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            OptimizationForm ShowForm1 = new OptimizationForm();
                            ShowForm1.PersoOptim(JPNum, PersianCalendar.Text, StrConnec);

                        }
                        else if (ReplaceCombo.Text == "بدون جایگزین")
                        {
                            Jay = "بی جا*****";
                        }
                        else if (TripBox.Checked)
                        {
                            Kind = "حذف تریپ";

                        }

                        using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Amal (P_Num, Tarikh, OnvAmal, Amal, Mem, U_Reg, T_Reg, Vis) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + Kind + "', '" + StartBox.Text + " تا " + EndBox.Text + "', '" + Jay + "'+ @Mem, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }


                        //OptimizationForm.TotaEzafe(PNum, PersianCalendar.Text)  ' محاسبات قدیم
                        //If ReplaceCombo.Text="با جایگزین" Then OptimizationForm.TotaEzafe(JPNum, PersianCalendar.Text)

                        OptimizationForm ShowForm = new OptimizationForm();
                        ShowForm.PersoOptim(PNum, PersianCalendar.Text, StrConnec);
                    }


                    Clea();
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
                Enabled = true;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TripBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TripBox.Checked)
            {
                MessageBoxFa.Show("حذف تریپ تحت نظر مسئول شیفت بوده و بایستی گزارش شود", "توجه", MessageBoxIcon.Warning);
            }
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;
            Clea();
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                TripBox.Visible = false;
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;
                PTime = PersonalSelectForm.PTime;
                PPost = PersonalSelectForm.PPost;
                ShName = PersonalSelectForm.PShift;
                PLoc = PersonalSelectForm.PLocal;
                NameBox.Text = PName + " " + PFamily;
                NameButton.Image = Properties.Resources.cancel1;

                ReplaceCombo.Items.Clear();
                if (PPost == "راهبر قطار")
                {
                    if (PLoc == "تهران" && PTime == "12 ساعته")
                    {
                        TripBox.Visible = true;
                    }

                    StartBox.Enabled = true;
                    if (AppState.UserLnum == "5")
                    {
                        EndBox.Enabled = false;
                    }
                    else
                    {
                        EndBox.Enabled = true; // False
                    }

                    ReplaceCombo.Items.Add("با جایگزین");
                    ReplaceCombo.Items.Add("بدون جایگزین");
                    ReplaceCombo.Items.Add("راهبر رزرو");

                    Num = 1; // برای محاسبه اولین مرخصی بدون کسری صفر شود
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM Amal WHERE OnvAmal='ساعتی' AND P_Num='" + PNum + "' AND Tarikh >='" + MainForm.PersianToday.FirstOfThisMonth() + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Num++;
                            }
                        }
                    }

                    Label6.Text = NumToWord.ConvertNumber(Num, true) + "ین مرخصی ساعتی در ماه جاری";
                }
                else
                {
                    StartBox.Enabled = true;
                    EndBox.Enabled = true;
                    ReplaceCombo.Items.Add("با جایگزین");
                    ReplaceCombo.Items.Add("بدون جایگزین");
                }
            }
        }

        public void TimeLeaveRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0103");
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0103");
        }

        public void TimeLeaveRegisterForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);
        }

        public void JNameButton_Click(object sender, EventArgs e)
        {
            JNameBox.Text = "";
            PersonalSelectForm.Per = PPost;
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                TripBox.Visible = false;

                JPFamily = PersonalSelectForm.PFamily;
                JPName = PersonalSelectForm.PName;
                JPNum = PersonalSelectForm.PNum;
                JShName = PersonalSelectForm.PShift;
                JNameBox.Text = JPName + " " + JPFamily;
                JNameButton.Image = Properties.Resources.cancel1;

                if ((string)ReplaceCombo.SelectedItem == "راهبر رزرو")
                {
                    bool Fi = false;

                    Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string QueStr = "SELECT Trip1, Trip2, Trip3 FROM Rezerv WHERE P_Num='" + JPNum + "' AND Tarikh='";
                        if (PTime == "12 ساعته" && string.Compare(StartBox.Text, "07:30") < 0)
                        {
                            QueStr += PersianDate.AddDay(-1) + "'";
                        }
                        else
                        {
                            QueStr += PersianDate.Tarikh() + "'";
                        }

                        using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (PTime == "12 ساعته" && string.Compare(StartBox.Text, "07:30") < 0 && JShName != ShName)
                                {
                                    break;
                                }

                                Fi = true;
                                if (Reader["Trip1"].ToString().Length == 0)
                                {
                                    Tri = 1;
                                }
                                else if (Reader["Trip2"].ToString().Length == 0)
                                {
                                    Tri = 2;
                                }
                                else if (Reader["Trip3"].ToString().Length == 0)
                                {
                                    Tri = 3;
                                }
                                if (StartBox.Text == Reader["Trip1"].ToString() || StartBox.Text == Reader["Trip2"].ToString() || StartBox.Text == Reader["Trip2"].ToString())
                                {
                                    Tri = 0;
                                }
                            }
                        }
                    }

                    if (!Fi)
                    {
                        MessageBoxFa.Show(JNameBox.Text + " در تاریخ " + PersianCalendar.Text + " در لیست رزروها نیست ", "خطا", MessageBoxIcon.Error);
                        JNameBox.Text = "";
                        JNameButton.Image = Properties.Resources.user;
                    }
                }
            }
        }

        public void ReplaceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            JNameBox.Text = "";
            JNameButton.Image = Properties.Resources.user;

            if (ReplaceCombo.SelectedIndex == -1)
            {
                JNameBox.Enabled = false;
                JNameButton.Enabled = false;
            }
            else if ((string)ReplaceCombo.SelectedItem == "بدون جایگزین")
            {
                JNameBox.Enabled = false;
                JNameButton.Enabled = false;
            }
            else
            {
                JNameBox.Enabled = true;
                JNameButton.Enabled = true;
            }
            TimeCalculate();
        }

        public void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemBox.Cut();
        }

        public void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemBox.Copy();
        }

        public void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MemBox.Paste();
        }

        public void StartBox_Leave(object sender, EventArgs e)
        {
            EndBox.Text = "";
            TimeCalculate();
        }
    }
}
