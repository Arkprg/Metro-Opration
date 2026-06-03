using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class OvertimeRequestRegForm
    {
        public OvertimeRequestRegForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string PTime;
        private string PPost;
        private string PLocal;
        private string ShName;
        private readonly string[] Over = new string[7];

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
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

        public void SumOverTime()
        {
            try
            {
                double Sum = 0;
                double Top = 0;

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand("SELECT Tota, TotaJom, NexMo FROM TotaMonAdv WHERE P_Num='" + PNum + "' AND Maah='" + MainForm.PersianToday.Tarikh().Substring(0, 7) + "'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Sum = ConvertClass.TimeToDouble(Reader["Tota"].ToString()) + ConvertClass.TimeToDouble(Reader["TotaJom"].ToString()) + ConvertClass.TimeToDouble(Reader["NexMo"].ToString());
                        }
                    }

                    using (OleDbCommand CMD = new OleDbCommand("SELECT MonthTime FROM ShKar WHERE Tarikh='" + MainForm.PersianToday.Tarikh().Substring(0, 7) + "'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Top = ConvertClass.TimeToDouble(Reader["MonthTime"].ToString());
                        }
                    }

                }
                RegButton.Enabled = true;
                if (Sum > Top + 15)
                {
                    ListLabel.Text = "اضافه کار " + PName + " " + PFamily + " " + ConvertClass.DoubleToTime(Sum) + " ساعت است و در اولویت اضافه کار قرار نمی گیرد";
                    Panel7.BackColor = Color.Tomato;
                    RegButton.Enabled = false;
                }
                else if (Sum > Top)
                {
                    ListLabel.Text = "اضافه کار " + PName + " " + PFamily + " در " + MainForm.PersianToday.MonthName() + " ماه " + MainForm.PersianToday.Year() + " مجموعا " + ConvertClass.DoubleToTime(Sum) + " است";
                    Panel7.BackColor = Color.Orange;
                }
                else
                {
                    ListLabel.Text = "اضافه کار " + PName + " " + PFamily + " در " + MainForm.PersianToday.MonthName() + " ماه " + MainForm.PersianToday.Year() + " مجموعا " + ConvertClass.DoubleToTime(Sum) + " است";
                    Panel7.BackColor = Color.LimeGreen;
                }

            }
            catch (Exception ex)
            {
                ErrorShow(ListLabel, "خطا در محاسبه مجموع اضافه کار");
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
            }
        }

        public void OvertimeRequestRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0109");
        }

        public void Form27_Load(object sender, EventArgs e)
        {
            try
            {
                TitrLabel1.BackColor = Color.Wheat;
                TitrLabel2.BackColor = Color.PaleGreen;
                TitrLabel3.BackColor = Color.PaleTurquoise;
                //HashtCheck.BackColor = Color.PaleGoldenrod;
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

                if (AppState.UserLevel == 9 | AppState.UserLevel == 19)
                {
                    NameButton.Enabled = false;
                    NameBox.Text = AppState.UserName;
                    PNum = AppState.UserPnum;
                    PTime = AppState.UserTime;
                    PPost = AppState.UserPost;
                    ShName = AppState.UserShift;
                    PLocal = AppState.UserLocal;
                    SumOverTime();
                }

                if (AppState.UserLevel == 0)
                {
                    if (MessageBoxFa.Show(" جزئیات نمایش داده شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DetailGridView.Visible = true;
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

        public void AllCheck_CheckedChanged(object sender, EventArgs e)
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
            OverCheck();
        }

        public void R12Check_CheckedChanged(object sender, EventArgs e)
        {
            OverCheck();
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            LocalCombo.SelectedIndex = -1;
            if (!string.IsNullOrEmpty(PersianCalendar.Text))
            {
                if (PersianCalendar.Text.Substring(0, 7) != MainForm.PersianToday.Tarikh().Substring(0, 7))
                {
                    Panel7.Visible = false;
                    RegButton.Enabled = true;
                }
                else
                {
                    Panel7.Visible = true;
                    if (Panel7.BackColor == Color.Tomato)
                        RegButton.Enabled = false;
                }
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پرسنل را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا حرکت را مشخص کنید");
                }
                else if ((LocalCombo.SelectedItem.ToString() == "گلشهر" || LocalCombo.SelectedItem.ToString() == "هشتگرد") && OverCheck() < 2)// && (HashtCheck.Checked && OverCheck() < 2)
                {
                    ErrorShow(Panel2, "حداقل دو گزینه را انتخاب کنید");
                }
                else if (OverCheck() > 4)
                {
                    ErrorShow(Panel2, "حداکثر 4 گزینه را انتخاب کنید");
                }
                else
                {
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand("INSERT INTO JayGozin (P_Num, Tarikh, Olv1, Olv2, Olv3, Olv4, Shift_Loc, U_Reg, T_Reg, Vis) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + Over[0] + "', '" + Over[1] + "', '" + Over[2] + "', '" + Over[3] + "', '" + LocalCombo.SelectedItem + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    if (NameButton.Enabled)
                    {
                        NameBox.Text = "";
                        NameButton.Image = Properties.Resources.user;
                    }

                    LocalCombo.SelectedIndex = -1;
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

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;
            LocalCombo.SelectedIndex = -1;
            PersonalSelectForm.Per = "راهبر قطار";
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;
                PTime = PersonalSelectForm.PTime;
                PPost = PersonalSelectForm.PPost;
                ShName = PersonalSelectForm.PShift;
                PLocal = PersonalSelectForm.PLocal;
                NameBox.Text = PName + " " + PFamily;
                NameButton.Image = Properties.Resources.cancel1;
                R12Check.Checked = false;
                S12Check.Checked = false;
                S9Check.Checked = false;
                A9Check.Checked = false;
                AllCheck.Checked = false;
                SumOverTime();
            }
        }

        public void LocaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mor12Sobh.Text = "";
                Mor12Asr.Text = "";
                Mor9Sobh.Text = "";
                Mor9Asr.Text = "";
                Req12Asr.Text = "";
                Req12Sobh.Text = "";
                Req9Asr.Text = "";
                Req9Sobh.Text = "";
                R12Check.Checked = false;
                S12Check.Checked = false;
                S9Check.Checked = false;
                A9Check.Checked = false;
                AllCheck.Checked = false;
                HashtCheck.Checked = false;

                DetailGridView.Rows.Clear();

                DateTime SelectDate = ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                if (LocalCombo.SelectedIndex >= 0)
                {
                    if (NameBox.Text == "")
                    {
                        ErrorShow(NameBox, "نام راهبر را مشخص کنید");
                    }
                    else if (SelectDate == null)
                    {
                        ErrorShow(PersianCalendar, "تاریخ را مشخص کنید");
                    }
                    else if (SelectDate == DateTime.Today.AddDays(1) && DateTime.Now.TimeOfDay > new TimeSpan(12, 0, 0) && (AppState.UserLevel == 9 | AppState.UserLevel == 19))
                    {
                        ErrorShow(PersianCalendar, "امکان ثبت درخواست برای فردا وجود ندارد");
                    }
                    else if (SelectDate > DateTime.Today.AddDays(10) || SelectDate <= DateTime.Today)
                    {
                        ErrorShow(PersianCalendar, "تاریخ وارد شده خارج از محدوده قابل دسترسی است");
                        LocalCombo.SelectedIndex = -1;
                    }
                    else
                    {
                        if (PLocal != (string)LocalCombo.SelectedItem)
                        {
                            if (PLocal != "هشتگرد" && (string)LocalCombo.SelectedItem == "هشتگرد" && AppState.UserLevel == 9)
                            {
                                MessageBoxFa.Show("این مبدا قابل انتخاب نیست", "خطا", MessageBoxIcon.Error, MessageBoxButtons.OK);
                                LocalCombo.SelectedIndex = -1;
                                LocalCombo.Focus();
                                return;
                            }
                            if (MessageBoxFa.Show("شما برای مبدا دیگری درخواست داده ای !  \n\n آیا ادامه می دهید؟", "توجه", MessageBoxIcon.Information, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            {
                                LocalCombo.SelectedIndex = -1;
                                LocalCombo.Focus();
                                return;
                            }
                        }
                        Enabled = false;

                        DataRow[] DRow = MainForm.PersonTable.Select("P_Num='" + PNum + "'");
                        if (!(bool)DRow[0]["OverTime"])
                        {
                            Enabled = true;
                            ErrorShow(NameBox, NameBox.Text + " مجوز اضافه کار ندارد");
                            LocalCombo.SelectedIndex = -1;
                            return;
                        }

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            //' *** بررسی مجدد
                            using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM DailyProcess WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND L_Num='" + AppState.UserLnum + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Enabled = true;
                                    StrConnec.Close();

                                    ErrorShow(PersianCalendar, "پردازش لوحه در این تاریخ انجام شده، امکان ثبت درخواست جدید وجود ندارد");
                                    LocalCombo.SelectedIndex = -1;
                                    return;
                                }
                            }

                            using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM JayGozin WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Enabled = true;
                                    StrConnec.Close();

                                    ErrorShow(PersianCalendar, "درخواست اضافه کار قبلا ثبت شده است");
                                    LocalCombo.SelectedIndex = -1;
                                    return;
                                }
                            }

                            using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM Keshik WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Enabled = true;
                                    StrConnec.Close();

                                    ErrorShow(PersianCalendar, NameBox.Text + " برای این تاریخ در لیست کشیک است");
                                    LocalCombo.SelectedIndex = -1;
                                    return;
                                }
                            }

                            int Mor9S = 0;
                            int Mor9A = 0;
                            int Mor12R = 0;
                            int Mor12Sh = 0;
                            int Jay9S = 0;
                            int Jay9A = 0;
                            int Jay12R = 0;
                            int Jay12Sh = 0;
                            string ShiftSobh;
                            string ShiftAsr;
                            string ShiftTomarow = "";
                            ShiftSobh = "";
                            ShiftAsr = "";
                            ShiftTomarow = "";
                            bool Holy = false;
                            using (OleDbCommand CMD = new OleDbCommand("SELECT Tarikh, Sobh, Asr, Holi FROM Taghvim WHERE Tarikh BETWEEN '" + PersianCalendar.Text + "' AND '" + ConvertClass.MiladiToShamsi(SelectDate.AddDays(1)) + "' ORDER BY Tarikh", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (Reader["Tarikh"].ToString() == PersianCalendar.Text)
                                    {
                                        ShiftSobh = Reader["Sobh"].ToString();
                                        ShiftAsr = Reader["Asr"].ToString();
                                        Holy = (bool)Reader["Holi"];
                                    }
                                    else
                                    {
                                        ShiftTomarow = Reader["Sobh"].ToString();
                                    }
                                }
                            }

                            if (PTime == "ستادی")
                            {
                                if (Holy | SelectDate.DayOfWeek == DayOfWeek.Friday)
                                {
                                    Enabled = true;
                                    StrConnec.Close();

                                    ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ مجاز به ثبت درخواست اضافه کار نیست");
                                    LocalCombo.SelectedIndex = -1;
                                    return;
                                }
                            }
                            else
                            {
                                if (ShiftSobh == ShName || ShiftAsr == ShName)
                                {
                                    Enabled = true;
                                    StrConnec.Close();

                                    ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ مجاز به ثبت درخواست اضافه کار نیست");
                                    LocalCombo.SelectedIndex = -1;
                                    return;
                                }
                            }

                            // AllCheck.Visible=False
                            R12Check.Visible = false;
                            S12Check.Visible = false;
                            S9Check.Visible = false;
                            A9Check.Visible = false;
                            HashtCheck.Visible = false;

                            if ((string)LocalCombo.SelectedItem != "هشتگرد")
                            {
                                if ((string)LocalCombo.SelectedItem == "گلشهر")
                                {
                                    HashtCheck.Visible = true;
                                }

                                using (OleDbCommand CMD = new OleDbCommand($"SELECT DISTINCT Shift_Time FROM Person WHERE Vis=True AND P_Post='{PPost}' AND Shift_Loc='{LocalCombo.SelectedItem}'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (Reader["Shift_Time"].ToString() == "12 ساعته")
                                        {
                                            R12Check.Visible = true;
                                            S12Check.Visible = true;
                                        }
                                        else if (Reader["Shift_Time"].ToString() == "9 ساعته")
                                        {
                                            S9Check.Visible = true;
                                            A9Check.Visible = true;
                                        }
                                    }
                                }
                            }
                            //else
                            //{
                            //    AllCheck.Visible=false;
                            //    S9Check.Visible=true;
                            //    A9Check.Visible=true;
                            //}
                            DetailGridView.Rows.Add(PNum, 0.0, PFamily + " " + PName);

                            if (PTime == "12 ساعته" && ShName == ShiftTomarow)
                            {
                                S12Check.Visible = false;
                            }

                            using (OleDbCommand CMD = new OleDbCommand("SELECT Person.P_Num, Person.Shift_Loc, Person.Shift_Time, Person.Shift_Time, Person.Shift_name FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh='" + PersianCalendar.Text + "' AND Person.Shift_Loc ='" + LocalCombo.SelectedItem + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (Reader["Shift_Time"].ToString() == "12 ساعته")
                                    {
                                        if (ShiftAsr == Reader["Shift_name"].ToString())
                                        {
                                            Mor12Sh++;
                                        }
                                        else
                                        {
                                            Mor12R++;
                                        }
                                    }
                                    else
                                    {
                                        if (ShiftAsr == Reader["Shift_name"].ToString())
                                        {
                                            Mor9A++;
                                        }
                                        else
                                        {
                                            Mor9S++;
                                        }
                                    }
                                }
                            }

                            using (OleDbCommand CMD = new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, JayGozin.Olv1, JayGozin.Olv2, JayGozin.Olv3, JayGozin.Olv4 FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE JayGozin.Vis=True AND JayGozin.Tarikh='" + PersianCalendar.Text + "' AND JayGozin.Shift_Loc='" + LocalCombo.SelectedItem + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DetailGridView.Rows.Add(Reader["P_Num"].ToString(), 0.0, Reader["Family"].ToString() + " " + Reader["Fname"].ToString());
                                    switch (Reader["Olv1"].ToString())
                                    {
                                        case "9 ساعته صبح": //Or "ستادی"
                                            Jay9S++;
                                            break;
                                        case "ستادی":
                                            Jay9S++;
                                            break;
                                        case "9 ساعته عصر":
                                            Jay9A++;
                                            break;
                                        case "12 ساعته روز":
                                            Jay12R++;
                                            break;
                                        case "12 ساعته شب":
                                            Jay12Sh++;
                                            break;
                                    }
                                    switch (Reader["Olv2"].ToString())
                                    {
                                        case "9 ساعته صبح":
                                            Jay9S++;
                                            break;
                                        case "ستادی":
                                            Jay9S++;
                                            break;
                                        case "9 ساعته عصر":
                                            Jay9A++;
                                            break;
                                        case "12 ساعته روز":
                                            Jay12R++;
                                            break;
                                        case "12 ساعته شب":
                                            Jay12Sh++;
                                            break;
                                    }
                                    switch (Reader["Olv3"].ToString())
                                    {
                                        case "9 ساعته صبح":
                                            Jay9S++;
                                            break;
                                        case "ستادی":
                                            Jay9S++;
                                            break;
                                        case "9 ساعته عصر":
                                            Jay9A++;
                                            break;
                                        case "12 ساعته روز":
                                            Jay12R++;
                                            break;
                                        case "12 ساعته شب":
                                            Jay12Sh++;
                                            break;
                                    }
                                    switch (Reader["Olv4"].ToString())
                                    {
                                        case "9 ساعته صبح":
                                            Jay9S++;
                                            break;
                                        case "ستادی":
                                            Jay9S++;
                                            break;
                                        case "9 ساعته عصر":
                                            Jay9A++;
                                            break;
                                        case "12 ساعته روز":
                                            Jay12R++;
                                            break;
                                        case "12 ساعته شب":
                                            Jay12Sh++;
                                            break;
                                    }
                                }
                            }


                            //Dim PersianDate As New Taghvim(PersianCalendar.Text)          ' *******  محاسبه نوبت درخواست کننده
                            //For i=0 To DetailGridView.RowCount - 1
                            //   Using CMD As New OleDbCommand("SELECT * FROM TotaMon WHERE P_Num='" & DetailGridView.Rows(i).Cells(0).Value.ToString & "' AND Maah='" & PersianCalendar.Text.Substring(0, 7) & "'"
                            //
                            //     Using Reader As OleDbDataReader=CMD.ExecuteReader()
                            //    While Reader.Read
                            //        DetailGridView.Rows(i).Cells(1).Value += TimeToDouble(Reader.Item("NexMo").ToString)
                            //    End While
                            //  End Using
                            //Next
                            //If ShamsiToMiladi(PersianCalendar.Text).DayOfWeek=DayOfWeek.Friday Then
                            //    PersianDate.AddYear(-1)
                            //    For i=0 To DetailGridView.RowCount - 1
                            //       Using CMD As New OleDbCommand("SELECT * FROM Ezafeh WHERE Vis=True AND P_Num='" & DetailGridView.Rows(i).Cells(0).Value.ToString & "' AND E_Kind<>'کشیک' AND E_Kind<>'کلاس آموزشی' AND E_Kind<>'تشویقی' AND Tarikh BETWEEN '" & PersianDate.Tarikh & "' AND '" & PersianCalendar.Text & "'"
                            //         Using Reader As OleDbDataReader=CMD.ExecuteReader()
                            //        While Reader.Read
                            //            If ShamsiToMiladi(Reader.Item("Tarikh").ToString).DayOfWeek=DayOfWeek.Friday Then DetailGridView.Rows(i).Cells(1).Value += TimeToDouble(Reader.Item("E_Time").ToString)
                            //        End While
                            //      End Using
                            //    Next
                            //Else
                            //    PersianDate.AddMonth(-1)
                            //    For i=0 To DetailGridView.RowCount - 1
                            //       Using CMD As New OleDbCommand("SELECT * FROM Ezafeh WHERE Vis=True AND P_Num='" & DetailGridView.Rows(i).Cells(0).Value.ToString & "' AND E_Kind<>'کشیک' AND E_Kind<>'کلاس آموزشی' AND E_Kind<>'تشویقی' AND Tarikh BETWEEN '" & PersianDate.Tarikh & "' AND '" & PersianCalendar.Text & "'"
                            //         Using Reader As OleDbDataReader=CMD.ExecuteReader()
                            //        While Reader.Read
                            //            DetailGridView.Rows(i).Cells(1).Value += TimeToDouble(Reader.Item("E_Time").ToString)
                            //        End While
                            //      End Using
                            //    Next
                            //End If

                            //DetailGridView.Sort(DetailGridView.Columns(1),  System.ComponentModel.ListSortDirection.Ascending)
                            //For i=0 To DetailGridView.RowCount - 1
                            //    If DetailGridView.Rows(i).Cells(0).Value.ToString=PNum Then
                            //        Select Case i
                            //            Case 0
                            //                ListLabel.Text="شما نفر اول در لیست اضافه کار هستید"
                            //            Case 2
                            //                ListLabel.Text="شما نفر سوم در لیست اضافه کار هستید"
                            //            Case Else
                            //                ListLabel.Text="شما نفر " & ConvertNumber(i + 1) & "م در لیست اضافه کار هستید"
                            //        End Select
                            //    End If
                            //Next
                            Mor12Sobh.Text = Mor12R.ToString() + " نفر";
                            Mor9Sobh.Text = Mor9S.ToString() + " نفر";
                            Mor12Asr.Text = Mor12Sh.ToString() + " نفر";
                            Mor9Asr.Text = Mor9A.ToString() + " نفر";
                            Req12Sobh.Text = Jay12R.ToString() + " مورد";
                            Req12Asr.Text = Jay12Sh.ToString() + " مورد";
                            Req9Sobh.Text = Jay9S.ToString() + " مورد";
                            Req9Asr.Text = Jay9A.ToString() + " مورد";
                            Enabled = true;
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
    }
}
