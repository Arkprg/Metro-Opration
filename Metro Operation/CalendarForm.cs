using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class CalendarForm : BaseForm
    {
        public CalendarForm()
        {
            InitializeComponent();
        }

        struct Shift
        {
            public string Sobh;
            public string Asr;
            public Shift(string s, string a) { Sobh = s; Asr = a; }
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        #region Display
        public void Display()
        {
            try
            {
                int rowIndex = 0, dayCounter = 1;
                CalendarGridView.Rows.Clear();
                //CalendarGridView.Rows.Add("شنبه", "یک شنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه");
                //CalendarGridView.Rows[0].DefaultCellStyle.BackColor = Color.Silver;
                //CalendarGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
                //CalendarGridView.Rows[0].Height = 45;
                CalendarGridView.Rows.Add("", "", "", "", "", "", "");

                using (var conn = new OleDbConnection(AppState.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand(
                        "SELECT Rooz, Kasri, Holi FROM Taghvim WHERE Tarikh LIKE ? ORDER BY Tarikh ASC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Tarikh", $"{YearComboBox.Text}/{MonthComboBox.SelectedIndex + 1:00}%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int col = int.Parse(reader["Rooz"].ToString()) - 1;
                                CalendarGridView.Rows[rowIndex].Cells[col].Value = dayCounter;

                                if (col >= 5)
                                    CalendarGridView.Rows[rowIndex].Cells[col].Style.BackColor = Color.Orange;

                                if (!string.IsNullOrWhiteSpace(reader["Kasri"].ToString()))
                                    CalendarGridView.Rows[rowIndex].Cells[col].Style.BackColor = Color.Yellow;

                                if ((bool)reader["Holi"])
                                {
                                    CalendarGridView.Rows[rowIndex].Cells[col].Style.BackColor = Color.Red;
                                    CalendarGridView.Rows[rowIndex].Cells[col].Style.ForeColor = Color.White;
                                }

                                if (col == 6)
                                {
                                    rowIndex++;
                                    CalendarGridView.Rows.Add("", "", "", "", "", "", "");
                                }

                                dayCounter++;
                            }
                        }
                    }
                }
                CalendarGridView.CurrentCell.Selected = false;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در نمایش تقویم", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion

        #region Calc
        public void Calc(string startDay)
        {
            try
            {
                startDay = startDay.Substring(0, 7);
                int Sh3 = 0, Sh4 = 0, Sh5 = 0;
                int ASob = 0, ABad = 0, BSob = 0, BBad = 0, CSob = 0, CBad = 0;
                int AJo9 = 0, BJo9 = 0, CJo9 = 0, AJo12 = 0, BJo12 = 0, CJo12 = 0;
                double kasr = 0;

                using (var conn = new OleDbConnection(AppState.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand("SELECT * FROM Taghvim WHERE Tarikh LIKE ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@Tarikh", $"{startDay}%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tarikh = reader["Tarikh"].ToString();
                                if (!tarikh.StartsWith(startDay)) continue;

                                int rooz = int.Parse(reader["Rooz"].ToString());
                                bool holi = (bool)reader["Holi"];
                                string kasriStr = reader["Kasri"].ToString();

                                if (rooz < 5 && !holi)
                                {
                                    Sh3++;
                                    if (!string.IsNullOrWhiteSpace(kasriStr) && kasriStr != "  :") kasr += ConvertClass.TimeToDouble(kasriStr);
                                }
                                else if (rooz == 5 && !holi)
                                {
                                    Sh4++;
                                    if (!string.IsNullOrWhiteSpace(kasriStr) && kasriStr != "  :") kasr += ConvertClass.TimeToDouble(kasriStr);
                                }
                                else if (rooz == 6 && holi) Sh5++;

                                switch (rooz)
                                {
                                    case 6:
                                        switch (reader["Asr"].ToString())
                                        {
                                            case "A": AJo12++; break;
                                            case "B": BJo12++; break;
                                            case "C": CJo12++; break;
                                        }
                                        break;
                                    case 7:
                                        switch (reader["Sobh"].ToString())
                                        {
                                            case "A": AJo9++; AJo12++; BJo9++; break;
                                            case "B": BJo9++; BJo12++; CJo9++; break;
                                            case "C": CJo9++; CJo12++; AJo9++; break;
                                        }
                                        break;
                                }

                                switch (reader["Sobh"].ToString())
                                {
                                    case "A": ASob++; BBad++; break;
                                    case "B": BSob++; CBad++; break;
                                    case "C": CSob++; ABad++; break;
                                }
                            }
                        }
                    }

                    bool exists;
                    using (var checkCmd = new OleDbCommand("SELECT Tarikh FROM ShKar WHERE Tarikh = ?", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Tarikh", startDay);
                        using (var reader = checkCmd.ExecuteReader()) exists = reader.Read();
                    }

                    if (exists)
                    {
                        using (var updateCmd = new OleDbCommand(
                            "UPDATE ShKar SET Rooz3=?, Rooz4=?, Rooz5=?, Kasri=?, ASobh=?, AAsr=?, AJom9=?, AJom12=?, BSobh=?, BAsr=?, BJom9=?, BJom12=?, CSobh=?, CAsr=?, CJom9=?, CJom12=? WHERE Tarikh=?", conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Rooz3", Sh3);
                            updateCmd.Parameters.AddWithValue("@Rooz4", Sh4);
                            updateCmd.Parameters.AddWithValue("@Rooz5", Sh5);
                            updateCmd.Parameters.AddWithValue("@Kasri", ConvertClass.DoubleToTime(kasr));
                            updateCmd.Parameters.AddWithValue("@ASobh", ASob);
                            updateCmd.Parameters.AddWithValue("@AAsr", ABad);
                            updateCmd.Parameters.AddWithValue("@AJom9", AJo9);
                            updateCmd.Parameters.AddWithValue("@AJom12", AJo12);
                            updateCmd.Parameters.AddWithValue("@BSobh", BSob);
                            updateCmd.Parameters.AddWithValue("@BAsr", BBad);
                            updateCmd.Parameters.AddWithValue("@BJom9", BJo9);
                            updateCmd.Parameters.AddWithValue("@BJom12", BJo12);
                            updateCmd.Parameters.AddWithValue("@CSobh", CSob);
                            updateCmd.Parameters.AddWithValue("@CAsr", CBad);
                            updateCmd.Parameters.AddWithValue("@CJom9", CJo9);
                            updateCmd.Parameters.AddWithValue("@CJom12", CJo12);
                            updateCmd.Parameters.AddWithValue("@TarikhEnd", startDay);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (var insertCmd = new OleDbCommand(
                            "INSERT INTO ShKar (Tarikh, Rooz3, Rooz4, Rooz5, Kasri, ASobh, AAsr, AJom9, AJom12, BSobh, BAsr, BJom9, BJom12, CSobh, CAsr, CJom9, CJom12, MonthTime) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Tarikh", startDay);
                            insertCmd.Parameters.AddWithValue("@Rooz3", Sh3);
                            insertCmd.Parameters.AddWithValue("@Rooz4", Sh4);
                            insertCmd.Parameters.AddWithValue("@Rooz5", Sh5);
                            insertCmd.Parameters.AddWithValue("@Kasri", ConvertClass.DoubleToTime(kasr));
                            insertCmd.Parameters.AddWithValue("@ASobh", ASob);
                            insertCmd.Parameters.AddWithValue("@AAsr", ABad);
                            insertCmd.Parameters.AddWithValue("@AJom9", AJo9);
                            insertCmd.Parameters.AddWithValue("@AJom12", AJo12);
                            insertCmd.Parameters.AddWithValue("@BSobh", BSob);
                            insertCmd.Parameters.AddWithValue("@BAsr", BBad);
                            insertCmd.Parameters.AddWithValue("@BJom9", BJo9);
                            insertCmd.Parameters.AddWithValue("@BJom12", BJo12);
                            insertCmd.Parameters.AddWithValue("@CSobh", CSob);
                            insertCmd.Parameters.AddWithValue("@CAsr", CBad);
                            insertCmd.Parameters.AddWithValue("@CJom9", CJo9);
                            insertCmd.Parameters.AddWithValue("@CJom12", CJo12);
                            insertCmd.Parameters.AddWithValue("@MonthTime", "120:00");
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در محاسبه شیفت‌ها", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion

        #region RegButton_Click
        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConvertClass.TimeToDouble(TimeBox.Text, true) < 0)
                {
                    ErrorShow(TimeBox, "ساعت کسری کار را مشخص کنید");
                    return;
                }

                int selectedMonth = int.Parse(YearComboBox.SelectedItem + (MonthComboBox.SelectedIndex + 1).ToString("00"));
                int todayMonth = int.Parse(MainForm.PersianToday.Tarikh().Substring(0, 7).Replace("/", ""));
                if (selectedMonth < todayMonth)
                {
                    ErrorShow(MonthComboBox, "امکان ویرایش این ماه وجود ندارد");
                    return;
                }

                string kas = ConvertClass.TimeToDouble(TimeBox.Text, true) > 0 ? TimeBox.Text : "";

                using (var conn = new OleDbConnection(AppState.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand("UPDATE Taghvim SET Holi=?, Kasri=?, Mem=? WHERE Tarikh=?", conn))
                    {
                        cmd.Parameters.AddWithValue("@Holi", HolidayCheckBox.Checked);
                        cmd.Parameters.AddWithValue("@Kasri", kas);
                        cmd.Parameters.AddWithValue("@Mem", ReasonTextBox.Text);
                        cmd.Parameters.AddWithValue("@Tarikh", DateLabel.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                Display();
                Panel1.Enabled = false;
                RegButton.Enabled = false;
                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در ثبت اطلاعات", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion

        #region Comboboxes
        public void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel1.Enabled = false;
            RegButton.Enabled = false;
            MonthComboBox.SelectedIndex = -1;
        }

        public void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalendarGridView.Rows.Clear();
            Panel1.Enabled = false;
            RegButton.Enabled = false;

            PervButton.Enabled = !(YearComboBox.SelectedIndex == 0 && MonthComboBox.SelectedIndex == 0);
            NextButton.Enabled = !(YearComboBox.SelectedIndex == 2 && MonthComboBox.SelectedIndex == 11);

            if (YearComboBox.SelectedIndex >= 0 && MonthComboBox.SelectedIndex >= 0)
                Display();
        }
        #endregion

        #region GridView Cell
        private void CalendarGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cell = CalendarGridView.CurrentCell;
                if (cell == null || cell.Value == null || !int.TryParse(cell.Value.ToString(), out int day))
                {
                    Panel1.Enabled = false;
                    RegButton.Enabled = false;
                    return;
                }

                DateLabel.Text = $"{YearComboBox.Text}/{(MonthComboBox.SelectedIndex + 1):00}/{day:00}";
                HolidayCheckBox.Checked = false;
                ReasonTextBox.Text = "";
                TimeBox.Text = "";

                using (var conn = new OleDbConnection(AppState.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new OleDbCommand("SELECT Holi, Kasri, Mem FROM Taghvim WHERE Tarikh = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@Tarikh", DateLabel.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                HolidayCheckBox.Checked = (bool)reader["Holi"];
                                TimeBox.Text = reader["Kasri"].ToString();
                                ReasonTextBox.Text = reader["Mem"].ToString();
                                Panel1.Enabled = true;
                                RegButton.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در بارگذاری اطلاعات سلول", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion

        #region Form Events
        public void CalendarForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0603");
        }

        public void CalendarForm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = -1; i <= 1; i++)
                    YearComboBox.Items.Add(MainForm.PersianToday.Year() + i);

                YearComboBox.Text = MainForm.PersianToday.Year().ToString();
                MonthComboBox.SelectedIndex = MainForm.PersianToday.Month() - 1;
                CalendarGridView.AllowUserToOrderColumns = false;

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در بارگذاری فرم", "خطا", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ExitButton_Click(object sender, EventArgs e) => Close();

        public void CalendarForm_Closing(object sender, CancelEventArgs e)
        {
            Taghvim PersianDate = new Taghvim(DateTime.Today);
            for (int i = 1; i < 7; i++)
            {
                Calc(PersianDate.Tarikh());
                PersianDate.AddMonth(1);
            }
            PersianDate.Dispose();
        }
        #endregion

        #region Navigation Buttons
        public void PervButton_Click(object sender, EventArgs e)
        {
            if (MonthComboBox.SelectedIndex > 0)
                MonthComboBox.SelectedIndex--;
            else
            {
                YearComboBox.SelectedIndex--;
                MonthComboBox.SelectedIndex = 11;
            }
        }

        public void NextButton_Click(object sender, EventArgs e)
        {
            if (MonthComboBox.SelectedIndex < 11)
                MonthComboBox.SelectedIndex++;
            else
            {
                YearComboBox.SelectedIndex++;
                MonthComboBox.SelectedIndex = 0;
            }
        }
        #endregion

        #region Month Generation
        private void MothGenerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (YearComboBox.SelectedIndex < 0)
                {
                    ErrorShow(YearComboBox, "ابتدا سال را انتخاب کنید");
                    return;
                }
                if (MonthComboBox.SelectedIndex < 0)
                {
                    ErrorShow(MonthComboBox, "ابتدا سال و ماه را انتخاب کنید");
                    return;
                }

                Taghvim PersianDate = new Taghvim($"{int.Parse(YearComboBox.Text)}/{MonthComboBox.SelectedIndex + 1:00}/01");

                if (ConvertClass.ShamsiToMiladi(PersianDate.AddMonth(-6)) > MainForm.PersianToday.Miladi())
                {
                    MessageBoxFa.Show("تقویم حداکثر 6 ماه آینده قابل ایجاد شدن است", "خطا", MessageBoxIcon.Error);
                    return;
                }
                PersianDate.AddMonth(6);
                using (var conn = new OleDbConnection(AppState.ConnectionString))
                {
                    conn.Open();

                    // آیا ماه وجود دارد؟
                    using (OleDbCommand cmd = new OleDbCommand(
                        $"SELECT COUNT(*) FROM Taghvim WHERE Tarikh LIKE ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@Tarikh", PersianDate.Tarikh().Substring(0, 8) + "%");
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            MessageBoxFa.Show("این ماه قبلاً ساخته شده است", "خطا", MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // گرفتن آخرین دو روز ماه قبل
                    Shift lastDay1 = new Shift();
                    Shift lastDay2 = new Shift();
                    using (var cmd = new OleDbCommand(
                        "SELECT TOP 2 Rooz, Sobh, Asr FROM Taghvim WHERE Tarikh LIKE ? ORDER BY Tarikh DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Tarikh", PersianDate.AddDay(-1).Substring(0, 8) + "%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                if (count == 0) lastDay1 = new Shift(reader["Sobh"].ToString(), reader["Asr"].ToString());
                                else lastDay2 = new Shift(reader["Sobh"].ToString(), reader["Asr"].ToString());
                                count++;
                            }
                        }
                    }

                    if (lastDay1.Sobh == null || lastDay2.Sobh == null)
                    {
                        MessageBoxFa.Show($"{PersianDate.MonthName()} ماه {PersianDate.Year()} ساخته نشده است", "خطا", MessageBoxIcon.Error);
                        return;
                    }

                    Shift[] pattern = new Shift[]
                    {
                        new Shift("A","B"),
                        new Shift("A","B"),
                        new Shift("C","A"),
                        new Shift("C","A"),
                        new Shift("B","C"),
                        new Shift("B","C")
                    };

                    PersianDate.AddDay(1);
                    int days = PersianDate.DaysInThisMonth();
                    int startIndex = 0;

                    if (lastDay1.Sobh == lastDay2.Sobh && lastDay1.Asr == lastDay2.Asr)
                    {
                        for (int i = 5; i >= 0; i--)
                        {
                            if (pattern[i].Sobh == lastDay2.Sobh && pattern[i].Asr == lastDay2.Asr)
                            {
                                startIndex = (i == 5) ? 0 : i + 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 5; i >= 0; i--)
                        {
                            if (pattern[i].Sobh == lastDay1.Sobh && pattern[i].Asr == lastDay1.Asr)
                            {
                                startIndex = i;
                                break;
                            }
                        }
                    }

                    for (int day = 1; day <= days; day++)
                    {
                        Shift shift = pattern[startIndex];
                        string tarikh = PersianDate.Tarikh();
                        int rooz = PersianDate.DayWeekNum();

                        using (var insertCmd = new OleDbCommand(
                            "INSERT INTO Taghvim (Tarikh, Rooz, Sobh, Asr, Holi, Kasri, Mem) VALUES (?,?,?,?,?,?,?)", conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Tarikh", tarikh);
                            insertCmd.Parameters.AddWithValue("@Rooz", rooz);
                            insertCmd.Parameters.AddWithValue("@Sobh", shift.Sobh);
                            insertCmd.Parameters.AddWithValue("@Asr", shift.Asr);
                            insertCmd.Parameters.AddWithValue("@Holi", false);
                            insertCmd.Parameters.AddWithValue("@Kasri", "");
                            insertCmd.Parameters.AddWithValue("@Mem", "");
                            insertCmd.ExecuteNonQuery();
                        }

                        PersianDate.AddDay(1);
                        startIndex = (startIndex + 1) % pattern.Length;
                    }

                    MessageBoxFa.Show("تولید ماه جدید با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Display();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در تولید ماه جدید", "خطا", MessageBoxIcon.Error);
            }
        }
        #endregion       
    }
}


//using System;
//using System.ComponentModel;
//using System.Data.OleDb;
//using System.Drawing;
//using System.Windows.Forms;

//namespace Metro_Operation
//{
//    public partial class CalendarForm
//    {
//        public CalendarForm()
//        {
//            InitializeComponent();
//        }

//        struct Shift
//        {
//            public string Sobh;
//            public string Asr;
//            public Shift(string s, string a) { Sobh = s; Asr = a; }
//        }

//        private void ErrorShow(Control control, string message)
//        {
//            MainForm.ErrorTip.Show(ErrorText, Contrl);
//            MainForm.ErrorTip.Show(ErrorText, Contrl, 3000);
//        }

//        public void Display()
//        {
//            try
//            {
//                int i = 1, j = 1, da = 1;
//                CalendarGridView.Rows.Clear();
//                CalendarGridView.Rows.Add("شنبه", "یک شنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه");
//                CalendarGridView.Rows[0].DefaultCellStyle.BackColor = Color.Silver;
//                CalendarGridView.Rows[0].DefaultCellStyle.ForeColor = Color.White;
//                CalendarGridView.Rows[0].Height = 45;
//                CalendarGridView.Rows.Add("", "", "", "", "", "", "");

//                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
//                {
//                    StrConnec.Open();
//                    using (OleDbCommand CMD = new OleDbCommand(
//                        $"SELECT Rooz, kasri, Holi FROM Taghvim WHERE Tarikh LIKE '{YearComboBox.Text}/{MonthComboBox.SelectedIndex + 1:00}%' ORDER BY Tarikh ASC",
//                        StrConnec))
//                    using (OleDbDataReader Reader = CMD.ExecuteReader())
//                    {
//                        while (Reader.Read())
//                        {
//                            if (j == 7)
//                            {
//                                i++;
//                                CalendarGridView.Rows.Add("", "", "", "", "", "", "");
//                            }
//                            j = int.Parse(Reader["Rooz"].ToString());
//                            CalendarGridView.Rows[i].Cells[j - 1].Value = da;

//                            if (Reader["Rooz"].ToString() == "6" || Reader["Rooz"].ToString() == "7")
//                                CalendarGridView.Rows[i].Cells[j - 1].Style.BackColor = Color.Orange;

//                            if (Reader["kasri"].ToString() != "")
//                                CalendarGridView.Rows[i].Cells[j - 1].Style.BackColor = Color.Yellow;

//                            if ((bool)Reader["Holi"])
//                            {
//                                CalendarGridView.Rows[i].Cells[j - 1].Style.BackColor = Color.Red;
//                                CalendarGridView.Rows[i].Cells[j - 1].Style.ForeColor = Color.White;
//                            }
//                            da++;
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
//                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
//                Close();
//            }
//        }

//        public void Calc(string StartDay)
//        {
//            try
//            {
//                StartDay = StartDay.Substring(0, 7);
//                int Sh3 = 0, Sh4 = 0, Sh5 = 0;
//                int ASob = 0, ABad = 0, BSob = 0, BBad = 0, CSob = 0, CBad = 0;
//                int AJo9 = 0, BJo9 = 0, CJo9 = 0, AJo12 = 0, BJo12 = 0, CJo12 = 0;
//                double kasr = 0;

//                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
//                {
//                    StrConnec.Open();

//                    using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM Taghvim WHERE Tarikh LIKE '{StartDay}%'", StrConnec))
//                    using (OleDbDataReader Reader = CMD.ExecuteReader())
//                    {
//                        while (Reader.Read())
//                        {
//                            if (Reader["Tarikh"].ToString().Substring(0, 7) == StartDay)
//                            {
//                                if (int.Parse(Reader["Rooz"].ToString()) < 5 && !(bool)Reader["Holi"])
//                                {
//                                    Sh3++;
//                                    if (Reader["Kasri"].ToString() != "" && Reader["Kasri"].ToString() != "  :")
//                                        kasr += ConvertClass.TimeToDouble(Reader["Kasri"].ToString());
//                                }
//                                if (int.Parse(Reader["Rooz"].ToString()) == 5 && !(bool)Reader["Holi"])
//                                {
//                                    Sh4++;
//                                    if (Reader["Kasri"].ToString() != "" && Reader["Kasri"].ToString() != "  :")
//                                        kasr += ConvertClass.TimeToDouble(Reader["Kasri"].ToString());
//                                }
//                                if (int.Parse(Reader["Rooz"].ToString()) == 6)
//                                {
//                                    if ((bool)Reader["Holi"])
//                                        Sh5++;

//                                    switch (Reader["Asr"].ToString())
//                                    {
//                                        case "A": AJo12++; break;
//                                        case "B": BJo12++; break;
//                                        case "C": CJo12++; break;
//                                    }
//                                }
//                                else if (int.Parse(Reader["Rooz"].ToString()) == 7)
//                                {
//                                    switch (Reader["Sobh"].ToString())
//                                    {
//                                        case "A": AJo9++; AJo12++; BJo9++; break;
//                                        case "B": BJo9++; BJo12++; CJo9++; break;
//                                        case "C": CJo9++; CJo12++; AJo9++; break;
//                                    }
//                                }
//                                switch (Reader["Sobh"].ToString())
//                                {
//                                    case "A": ASob++; BBad++; break;
//                                    case "B": BSob++; CBad++; break;
//                                    case "C": CSob++; ABad++; break;
//                                }
//                            }
//                        }
//                    }

//                    bool Exis = false;

//                    using (OleDbCommand CMD = new OleDbCommand($"SELECT Tarikh FROM ShKar WHERE Tarikh='{StartDay}'", StrConnec))
//                    using (OleDbDataReader Reader = CMD.ExecuteReader())
//                    {
//                        if (Reader.Read())
//                            Exis = true;
//                    }

//                    if (Exis)
//                    {
//                        using (OleDbCommand CMD = new OleDbCommand(
//                            $"UPDATE ShKar SET Rooz3='{Sh3}', Rooz4='{Sh4}', Rooz5='{Sh5}', Kasri='{ConvertClass.DoubleToTime(kasr)}', ASobh='{ASob}', AAsr='{ABad}', AJom9='{AJo9}', AJom12='{AJo12}', BSobh='{BSob}', BAsr='{BBad}', BJom9='{BJo9}', BJom12='{BJo12}', CSobh='{CSob}', CAsr='{CBad}', CJom9='{CJo9}', CJom12='{CJo12}' WHERE Tarikh='{StartDay}'",
//                            StrConnec))
//                        {
//                            CMD.ExecuteNonQuery();
//                        }
//                    }
//                    else
//                    {
//                        using (OleDbCommand CMD = new OleDbCommand(
//                            $"INSERT INTO ShKar (Tarikh, Rooz3, Rooz4, Rooz5, Kasri, ASobh, AAsr, AJom9, AJom12, BSobh, BAsr, BJom9, BJom12, CSobh, CAsr, CJom9, CJom12, MonthTime) VALUES ('{StartDay}', '{Sh3}', '{Sh4}', '{Sh5}', '{ConvertClass.DoubleToTime(kasr)}', '{ASob}', '{ABad}', '{AJo9}', '{AJo12}', '{BSob}', '{BBad}', '{BJo9}', '{BJo12}', '{CSob}', '{CBad}', '{CJo9}', '{CJo12}', '120:00')",
//                            StrConnec))
//                        {
//                            CMD.ExecuteNonQuery();
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
//                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
//                Close();
//            }
//        }

//        public void RegButton_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Taghvim PersianToday = new Taghvim();

//                if (ConvertClass.TimeToDouble(TimeBox.Text, true) < 0)
//                {
//                    ErrorShow(TimeBox, "ساعت کسری کار را مشخص کنید");
//                }
//                else if (int.Parse(YearComboBox.SelectedItem + (MonthComboBox.SelectedIndex + 1).ToString("00")) < int.Parse(MainForm.PersianToday.Tarikh().Substring(0, 7).Replace("/", "")))
//                {
//                    ErrorShow(MonthComboBox, "امکان ویرایش این ماه وجود ندارد");
//                }
//                else
//                {
//                    string Kas = "";

//                    if (ConvertClass.TimeToDouble(TimeBox.Text, true) > 0)
//                        Kas = TimeBox.Text;

//                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
//                    {
//                        StrConnec.Open();
//                        using (OleDbCommand CMD = new OleDbCommand($"UPDATE Taghvim SET Holi={HolidayCheckBox.Checked}, Kasri='{Kas}', Mem=@Reason WHERE Tarikh='{DateLabel.Text}'", StrConnec))
//                        {
//                            CMD.Parameters.AddWithValue("@Reason", ReasonTextBox.Text);
//                            CMD.ExecuteNonQuery();
//                        }

//                        Display();
//                    }

//                    Panel1.Enabled = false;
//                    RegButton.Enabled = false;
//                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
//                }
//            }
//            catch (Exception ex)
//            {
//                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
//                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
//                Close();
//            }
//        }

//        public void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            Panel1.Enabled = false;
//            RegButton.Enabled = false;
//            MonthComboBox.SelectedIndex = -1;
//        }

//        public void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            CalendarGridView.Rows.Clear();
//            Panel1.Enabled = false;
//            RegButton.Enabled = false;

//            if (YearComboBox.SelectedIndex == 0 && MonthComboBox.SelectedIndex == 0)
//            {
//                PervButton.Enabled = false;
//            }
//            else
//            {
//                PervButton.Enabled = true;
//            }

//            if (YearComboBox.SelectedIndex == 2 && MonthComboBox.SelectedIndex == 11)
//            {
//                NextButton.Enabled = false;
//            }
//            else
//            {
//                NextButton.Enabled = true;
//            }

//            if (YearComboBox.SelectedIndex >= 0 && MonthComboBox.SelectedIndex >= 0)
//                Display();
//        }

//        public void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
//        {
//            try
//            {
//                if (CalendarGridView.CurrentCellAddress.X >= 0)
//                {
//                    if (int.TryParse(CalendarGridView.CurrentCell.Value.ToString(), out _))
//                    {
//                        DateLabel.Text = $"{YearComboBox.Text}/{(MonthComboBox.SelectedIndex + 1).ToString("00").Trim()}/";

//                        if (int.TryParse(CalendarGridView.CurrentCell.Value.ToString(), out _))
//                        {
//                            if (int.Parse(CalendarGridView.CurrentCell.Value.ToString()) < 10)
//                                DateLabel.Text += $"0{CalendarGridView.CurrentCell.Value}";
//                            else
//                                DateLabel.Text += CalendarGridView.CurrentCell.Value.ToString();

//                            HolidayCheckBox.Checked = false;
//                            ReasonTextBox.Text = "";
//                            TimeBox.Text = "";
//                            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
//                            {
//                                StrConnec.Open();

//                                using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Taghvim", StrConnec))
//                                using (OleDbDataReader Reader = CMD.ExecuteReader())
//                                {
//                                    while (Reader.Read())
//                                    {
//                                        if (Reader["Tarikh"].ToString() == DateLabel.Text)
//                                        {
//                                            if ((bool)Reader["Holi"])
//                                                HolidayCheckBox.Checked = true;

//                                            if (Reader["Kasri"].ToString() != "")
//                                                TimeBox.Text = Reader["Kasri"].ToString();

//                                            if (Reader["mem"].ToString() != "")
//                                                ReasonTextBox.Text = Reader["mem"].ToString();

//                                            Panel1.Enabled = true;
//                                            RegButton.Enabled = true;
//                                        }
//                                    }
//                                }
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Panel1.Enabled = false;
//                        RegButton.Enabled = false;
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
//                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
//                Close();
//            }
//        }

//        public void CalendarForm_HelpButtonClicked(object sender, CancelEventArgs e)
//        {
//            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0603");
//        }

//        public void Form23_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                for (int i = -1; i <= 1; i++)
//                    YearComboBox.Items.Add(MainForm.PersianToday.Year() + i);

//                YearComboBox.Text = MainForm.PersianToday.Year().ToString();
//                MonthComboBox.SelectedIndex = MainForm.PersianToday.Month() - 1;
//            }
//            catch (Exception ex)
//            {
//                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
//                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
//                Close();
//            }
//        }

//        public void ExitButton_Click(object sender, EventArgs e)
//        {
//            Close();
//        }

//        public void CalendarForm_Closing(object sender, CancelEventArgs e)
//        {
//            Taghvim PersianDate = new Taghvim(DateTime.Today);
//            for (int i = 1; i <= 6; i++)
//            {
//                Calc(PersianDate.Tarikh());
//                PersianDate.AddMonth(1);
//            }
//            PersianDate.Dispose();
//        }

//        public void PervButton_Click(object sender, EventArgs e)
//        {
//            if (MonthComboBox.SelectedIndex > 0)
//                MonthComboBox.SelectedIndex--;
//            else
//            {
//                YearComboBox.SelectedIndex--;
//                MonthComboBox.SelectedIndex = 11;
//            }
//        }

//        public void NextButton_Click(object sender, EventArgs e)
//        {
//            if (MonthComboBox.SelectedIndex < 11)
//                MonthComboBox.SelectedIndex++;
//            else
//            {
//                YearComboBox.SelectedIndex++;
//                MonthComboBox.SelectedIndex = 0;
//            }
//        }

//        private void MothGenerButton_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (YearComboBox.SelectedIndex < 0 || MonthComboBox.SelectedIndex < 0)
//                {
//                    MessageBoxFa.Show("ابتدا سال و ماه را انتخاب کنید", "خطا", MessageBoxIcon.Warning);
//                    return;
//                }

//                int year = int.Parse(YearComboBox.Text);
//                int month = MonthComboBox.SelectedIndex + 1;

//                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
//                {
//                    StrConnec.Open();

//                    Taghvim PresianDate = new Taghvim($"{year}/{month:00}/01");

//                    // گرفتن آخرین دو روز ماه قبل
//                    using (OleDbCommand cmd = new OleDbCommand(
//                        $"SELECT TOP 2 Rooz, Sobh, Asr FROM Taghvim WHERE Tarikh LIKE '{PresianDate.AddDay(-1).Substring(0, 8)}%' ORDER BY Tarikh DESC", StrConnec))
//                    using (OleDbDataReader reader = cmd.ExecuteReader())
//                    {
//                        Shift lastDay1 = new Shift("A", "B"); // مقدار پیش‌فرض در صورت نبود داده
//                        Shift lastDay2 = new Shift("A", "B");
//                        int count = 0;

//                        while (reader.Read())
//                        {
//                            if (count == 0)
//                                lastDay1 = new Shift(reader["Sobh"].ToString(), reader["Asr"].ToString());
//                            else
//                                lastDay2 = new Shift(reader["Sobh"].ToString(), reader["Asr"].ToString());
//                            count++;
//                        }

//                        // الگوی چرخه شیفت‌ها
//                        Shift[] pattern = new Shift[]
//                        {
//                            new Shift("A","B"),
//                            new Shift("A","B"),
//                            new Shift("C","A"),
//                            new Shift("C","A"),
//                            new Shift("B","C"),
//                            new Shift("B","C")
//                        };

//                        PresianDate.AddDay(1);
//                        int days = PresianDate.DaysInThisMonth();
//                        int startIndex = 0;

//                        // تعیین startIndex بر اساس دو روز آخر ماه قبل
//                        if (lastDay1.Sobh == lastDay2.Sobh && lastDay1.Asr == lastDay2.Asr)
//                        {
//                            // هر دو مشابه → روز بعد از آخرین روز الگو
//                            for (int i = 5; i >= 0; i--)
//                            {
//                                if (pattern[i].Sobh == lastDay2.Sobh && pattern[i].Asr == lastDay2.Asr)
//                                {
//                                    if (i == 5) startIndex = 0; else startIndex = (i + 1) % pattern.Length;
//                                    break;
//                                }
//                            }
//                        }
//                        else
//                        {
//                            // متفاوت → همان روز آخر ماه قبل
//                            for (int i = 0; i < pattern.Length; i++)
//                            {
//                                if (pattern[i].Sobh == lastDay2.Sobh && pattern[i].Asr == lastDay2.Asr)
//                                {
//                                    startIndex = i;
//                                    break;
//                                }
//                            }
//                        }

//                        // تولید داده‌ها برای کل ماه جدید
//                        for (int day = 1; day <= days; day++)
//                        {
//                            Shift shift = pattern[startIndex];

//                            string tarikh = PresianDate.Tarikh();
//                            int rooz = PresianDate.DayWeekNum();

//                            using (OleDbCommand insertCmd = new OleDbCommand(
//                                $"INSERT INTO Taghvim (Tarikh, Rooz, Sobh, Asr, Holi, Kasri, mem) VALUES ('{tarikh}','{rooz}','{shift.Sobh}','{shift.Asr}', False, '', '')", StrConnec))
//                            {
//                                insertCmd.ExecuteNonQuery();
//                            }

//                            PresianDate.AddDay(1);
//                            startIndex = (startIndex + 1) % pattern.Length; // ادامه چرخه صحیح
//                        }

//                        MessageBoxFa.Show("تولید ماه جدید با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
//                        Display();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
//                MessageBoxFa.Show("خطا در تولید ماه جدید", "خطا", MessageBoxIcon.Error);
//            }
//        }
//    }
//}


