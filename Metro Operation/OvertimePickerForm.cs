using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class OvertimePickerForm
    {
        public OvertimePickerForm()
        {
            InitializeComponent();
        }

        private string ProsTime;
        private string ProsDate;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public bool ProcessCheck(string DayProcess, string Local)
        {
            bool Process = false;
            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD = new OleDbCommand("SELECT T_Reg FROM DailyProcess WHERE Tarikh='" + DayProcess + "' AND L_Num='" + Local + "' AND Vis=True", StrConnec))
                using (OleDbDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Process = true;
                        ProsDate = Reader["T_Reg"].ToString().Substring(0, 10);
                        ProsTime = Reader["T_Reg"].ToString().Substring(11, 8);
                    }
                }
            }

            return Process;
        }

        public void OvertimePickerForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0307");
        }

        public void OvertimePickerForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);

            if (AppState.UserLevel == 0)
            {
                KindCombo.Items.AddRange(new[] { "جایگزین کشیک", "جایگزین مرخصی روزانه", "جایگزین مرخصی ساعتی", "همکاری با شیفت", "اضافه کار" });
            }
            else if (AppState.UserLevel == 4)
            {
                KindCombo.Items.AddRange(new[] { "جایگزین کشیک", "جایگزین مرخصی روزانه", "اضافه کار" });
            }
            else
            {
                KindCombo.Items.AddRange(new[] { "جایگزین کشیک", "جایگزین مرخصی روزانه", "جایگزین مرخصی ساعتی", "همکاری با شیفت" });
            }

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

            if (AppState.UserLevel == 0)
            {
                if (MessageBoxFa.Show(" جزئیات نمایش داده شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    DetailGridView.Visible = true;
                }
            }

            Panel1.Enabled = false;
            Panel2.Enabled = false;
            Panel3.Enabled = false;
            TimeBox.Visible = false;
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex = -1;
            ShiftCombo.Items.Clear();
            if (LocalCombo.SelectedIndex >= 0)
            {
                if ((string)LocalCombo.SelectedItem == "هشتگرد")
                {
                    ShiftCombo.Enabled = false;
                    ShiftCombo_SelectedIndexChanged(null, null);
                }
                else
                {
                    NameBox.Text = "";
                    PNumBox.Text = "";
                    PhoneBox.Text = "";

                    LeaveCombo.SelectedIndex = -1;
                    LeaveCombo.Items.Clear();
                    Panel1.Enabled = false;
                    Panel3.Enabled = false;

                    ShiftCombo.Enabled = true;
                    if (KindCombo.SelectedIndex == 0)
                    {
                        ShiftCombo.Items.Add("صبح");
                        ShiftCombo.Items.Add("عصر");
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
            }
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NameBox.Text = "";
                PNumBox.Text = "";
                PhoneBox.Text = "";

                LeaveCombo.SelectedIndex = -1;
                LeaveCombo.Items.Clear();
                Panel1.Enabled = false;
                Panel3.Enabled = false;

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    if (ShiftCombo.SelectedIndex >= 0 || (string)LocalCombo.SelectedItem == "هشتگرد")
                    {
                        if ((string)KindCombo.SelectedItem == "جایگزین مرخصی روزانه")
                        {
                            string Shft = "";
                            Shft = "";

                            using (OleDbCommand CMD = new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    switch (ShiftCombo.SelectedIndex)
                                    {
                                        case 0:
                                        case 2:
                                            Shft = Reader["Sobh"].ToString();
                                            break;
                                        case 1:
                                        case 3:
                                            Shft = Reader["Asr"].ToString();
                                            break;
                                        case 4:
                                            Shft = "";
                                            break;
                                    }
                                }
                            }

                            string QueStr = "SELECT Person.Fname, Person.Family, Person.P_Num, Morakhasi.T_Reg FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Morakhasi.Tarikh='" + PersianCalendar.Text + "' AND Morakhasi.Vis=True AND (Morakhasi.J_Num IS NULL OR Morakhasi.J_Num='بی جایگزین') AND Person.Trip=True AND Person.Shift_Loc='" + LocalCombo.Text + "' AND Person.Line_Num='" + AppState.UserLnum + "'";
                            switch (ShiftCombo.SelectedIndex)
                            {
                                case 0:
                                case 1:
                                    QueStr += " AND Person.Shift_Time='9 ساعته'";
                                    break;
                                case 2:
                                case 3:
                                    QueStr += " AND Person.Shift_Time='12 ساعته'";
                                    break;
                                case 4:
                                    QueStr += " AND Person.Shift_Time='ستادی'";
                                    break;
                            }
                            if (string.IsNullOrEmpty(Shft))
                            {
                                if ((string)LocalCombo.SelectedItem != "هشتگرد")
                                {
                                    QueStr += " And Person.Shift_Name IS NULL";
                                }
                            }
                            else
                            {
                                QueStr += " And Person.Shift_Name='" + Shft + "'";
                            }

                            using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (DateTime.Parse(Reader["T_Reg"].ToString().Substring(0, 10)) > DateTime.Parse(ProsDate) || (Convert.ToDateTime(Reader["T_Reg"].ToString().Substring(0, 10)) == DateTime.Parse(ProsDate) && DateTime.Parse(Reader["T_Reg"].ToString().Substring(11, 8)) > DateTime.Parse(ProsTime)))
                                    {
                                        LeaveCombo.Items.Add(Reader["Fname"].ToString() + " " + Reader["Family"].ToString() + " (" + Reader["P_Num"].ToString() + ")");
                                    }
                                }
                            }
                        }
                        else if ((string)KindCombo.SelectedItem == "جایگزین مرخصی ساعتی")
                        {
                            string Shft = "";
                            using (OleDbCommand CMD = new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "' ", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    switch (ShiftCombo.SelectedIndex)
                                    {
                                        case 0:
                                        case 1:
                                        case 4:
                                            Shft = Reader["Sobh"].ToString();
                                            break;
                                        case 2:
                                        case 3:
                                            Shft = Reader["Asr"].ToString();
                                            break;
                                    }
                                }
                            }

                            string QueStr = "SELECT Person.Fname, Person.Family, Person.P_Num FROM Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.Tarikh='" + PersianCalendar.Text + "' AND Amal.OnvAmal='ساعتی' AND Amal.Vis=True AND Person.Shift_Time='";
                            switch (ShiftCombo.SelectedIndex)
                            {
                                case 0:
                                case 1:
                                    QueStr += "9 ساعته'";
                                    break;
                                case 2:
                                case 3:
                                    QueStr += "12 ساعته'";
                                    break;
                            }
                            QueStr += " AND Amal.Mem='بی جا*****' AND Person.Trip=True AND Person.Shift_Name='" + Shft + "' AND Person.Shift_Loc='" + LocalCombo.Text + "' AND Person.Line_Num='" + AppState.UserLnum + "'";

                            using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    LeaveCombo.Items.Add(Reader["Fname"].ToString() + " " + Reader["Family"].ToString() + " (" + Reader["P_Num"].ToString() + ")");
                                }
                            }
                        }
                        else if ((string)KindCombo.SelectedItem == "جایگزین کشیک")
                        {
                            using (OleDbCommand CMD = new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Ezafeh.Tarikh='" + PersianCalendar.Text + "' AND (Ezafeh.E_Kind='کشیک' OR Ezafeh.E_Kind='جایگزین کشیک') AND Ezafeh.E_Mem LIKE '%" + ShiftCombo.SelectedItem + "%' AND Ezafeh.Vis=True AND Ezafeh.E_Local='" + LocalCombo.Text + "' AND Person.Line_Num='" + AppState.UserLnum + "'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    LeaveCombo.Items.Add(Reader["Fname"].ToString() + " " + Reader["Family"].ToString() + " (" + Reader["P_Num"].ToString() + ")");
                                }
                            }
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

        public void Panel1_EnabledChanged(object sender, EventArgs e)
        {
            if (!Panel1.Enabled)
            {
                RegButton.BackColor = DefaultBackColor;
                AddRadioButton.Checked = false;
                DelRadioButton.Checked = false;
            }
        }

        public void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
            {
                MemBox.Text = "";
                if (!TimeBox.Visible)
                {
                    MemBox.Enabled = false;
                    MemBox.BackColor = DefaultBackColor;
                }
                else if ((string)KindCombo.SelectedItem != "همکاری با شیفت" && (string)ShiftCombo.SelectedItem != "کشیک رزرو")
                {
                    MemBox.Enabled = true;
                    MemBox.Focus();
                }
                RegButton.BackColor = Color.Lime;
            }
            else if (DelRadioButton.Checked)
            {
                MemBox.Enabled = true;
                RegButton.BackColor = Color.Red;
                MemBox.Focus();
            }
        }

        public void MemBox_Enter(object sender, EventArgs e)
        {
            MemBox.BackColor = Color.Yellow;
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TimeBox.Visible && ConvertClass.TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "مدت اضافه کاری صحیح نیست");
                }
                else if (MemBox.Enabled && MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "توضیحات لازم را وارد کنید");
                }
                else if (AddRadioButton.Checked)
                {

                    double OvTime = ConvertClass.TimeToDouble(TimeBox.Text);
                    string MemStr = "";
                    Taghvim PersianDate = new Taghvim(PersianCalendar.Text);
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        if ((string)KindCombo.SelectedItem == "جایگزین مرخصی روزانه")
                        {
                            MemStr = LeaveCombo.SelectedItem.ToString().Substring(0, LeaveCombo.SelectedItem.ToString().Length - 8);
                            if ((string)ShiftCombo.SelectedItem == "12 ساعته روز")
                            {
                                if (PersianDate.DayWeek() == "جمعه")
                                {
                                    OvTime = 13;
                                }
                                else
                                {
                                    OvTime = 19.25;
                                }
                            }
                            else if ((string)ShiftCombo.SelectedItem == "12 ساعته شب")
                            {
                                if (PersianDate.DayWeek() == "پنجشنبه")
                                {
                                    OvTime = 8;
                                }
                                else
                                {
                                    OvTime = 4.5;
                                    using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, U_Reg, E_Time, E_Kind, E_Local, E_Mem, T_Reg, Vis) VALUES ('" + PNumBox.Text + "', '" + PersianDate.AddDay(1) + "', '" + AppState.UserName + "', '10:00', 'جایگزین مرخصی روزانه شب قبل', '" + LocalCombo.SelectedItem + "', '12 ساعته شب - " + MemStr + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }

                                    PersianDate.SetDate(PersianCalendar.Text);
                                }
                            }
                            else if (((string)ShiftCombo.SelectedItem == "9 ساعته عصر") || ((string)ShiftCombo.SelectedItem == "9 ساعته صبح") || ((string)ShiftCombo.SelectedItem == "ستادی"))
                            {
                                OvTime = 13;
                            }
                            else
                            {
                                OvTime = 12;
                            }
                        }
                        else if ((string)KindCombo.SelectedItem == "جایگزین مرخصی ساعتی")
                        {
                            using (OleDbCommand CMD = new OleDbCommand("UPDATE Amal SET Mem='با جا" + PNumBox.Text + "' WHERE P_Num='" + LeaveCombo.SelectedItem.ToString().Substring(LeaveCombo.SelectedItem.ToString().IndexOf("(") + 1, LeaveCombo.SelectedItem.ToString().Length - (LeaveCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1) + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            MemStr = LeaveCombo.SelectedItem.ToString().Substring(0, LeaveCombo.SelectedItem.ToString().Length - 8);
                            OvTime = 6.5;
                        }
                        else if ((string)KindCombo.SelectedItem == "جایگزین کشیک")
                        {
                            int FID = 0;
                            int FadID = 0;
                            using (OleDbCommand CMD = new OleDbCommand("SELECT ID, Fad FROM Ezafeh WHERE P_Num='" + LeaveCombo.SelectedItem.ToString().Substring(LeaveCombo.SelectedItem.ToString().IndexOf("(") + 1, LeaveCombo.SelectedItem.ToString().Length - (LeaveCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1) + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND E_Kind='کشیک'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    FID = Convert.ToInt32(Reader["ID"]);
                                    if (Reader["Fad"].ToString() != "")
                                    {
                                        FadID = Convert.ToInt32(Reader["Fad"]);
                                    }
                                }
                            }

                            if (FadID > 0)
                            {
                                using (OleDbCommand CMD = new OleDbCommand("UPDATE Ezafeh SET Vis=False, E_Mem=@Mem +' کاربر:" + AppState.UserName + "', Fad=" + (FadID * -1).ToString() + " WHERE ID=" + FID, StrConnec))
                                {
                                    CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                                    CMD.ExecuteNonQuery();
                                }

                            }
                            else
                            {
                                using (OleDbCommand CMD = new OleDbCommand("UPDATE Ezafeh SET Vis=False, E_Mem=@Mem +' کاربر:" + AppState.UserName + "', Fad=" + (FID * -1) + " WHERE ID=" + FID, StrConnec))
                                {
                                    CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                                    CMD.ExecuteNonQuery();
                                }

                            }

                            OvTime = 13;
                            MemStr = MemBox.Text.Trim();
                        }
                        else if ((string)KindCombo.SelectedItem == "همکاری با شیفت")
                        {
                            MemStr = MemBox.Text.Trim();

                            if ((string)ShiftCombo.SelectedItem == "12 ساعته شب" && OvTime > 4.5)
                            {
                                OvTime -= 4.5;
                                PersianDate.SetDate(PersianCalendar.Text);
                                PersianDate.AddDay(1);

                                using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Local, E_Kind, E_Mem, T_Reg, U_Reg, Vis) VALUES ('" + PNumBox.Text + "','" + PersianDate.Tarikh() + "', '" + ConvertClass.DoubleToTime(OvTime) + "', '" + LocalCombo.SelectedItem + "', 'همکاری با شیفت شب قبل" + "', @Mem, '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', '" + AppState.UserName + "', True)", StrConnec))
                                {
                                    CMD.Parameters.AddWithValue("@Mem", ShiftCombo.SelectedItem + " - " + MemBox.Text.Trim());
                                    CMD.ExecuteNonQuery();
                                }


                                PersianDate.SetDate(PersianCalendar.Text);
                                OvTime = 4.5;
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, U_Reg, E_Time, E_Kind, E_Local, E_Mem, T_Reg, Vis) VALUES ('" + PNumBox.Text + "','" + PersianCalendar.Text + "', '" + AppState.UserName + "', '" + ConvertClass.DoubleToTime(OvTime) + "', '" + KindCombo.SelectedItem + "', '" + LocalCombo.SelectedItem + "','" + ShiftCombo.SelectedItem + " - " + MemStr + " -', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        OptimizationForm ShowForm = new OptimizationForm();
                        ShowForm.PersoOptim(PNumBox.Text, PersianCalendar.Text, StrConnec);
                    }

                    Enabled = true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    LocalCombo.SelectedIndex = -1;

                }
                else if (DelRadioButton.Checked)
                {
                    string ID = "";
                    int i;
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM JayGozin WHERE Tarikh='" + PersianCalendar.Text + "' AND P_Num='" + PNumBox.Text + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ID = Reader["ID"].ToString();
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("UPDATE JayGozin SET Vis=False WHERE ID=" + ID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        string QueStr = "INSERT INTO JayGozin (P_NUM, Tarikh, U_Reg, Olv1, Olv2, Olv3, Olv4, T_Reg, Vis, Fad) VALUES ('" + PNumBox.Text + "','" + PersianCalendar.Text + "', '" + AppState.UserName + "', '";
                        for (i = 1; i <= 4; i++)
                        {
                            if (MemBox.Text.Trim().Length < 25)
                            {
                                QueStr += MemBox.Text.Trim() + "', '";
                                MemBox.Text = "";
                            }
                            else
                            {
                                QueStr += MemBox.Text.Trim().Substring(0, 25) + "', '";
                                MemBox.Text = MemBox.Text.Trim().Substring(25, MemBox.Text.Trim().Length - 25);
                            }
                        }
                        QueStr += MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, -" + ID + ")";
                        using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }


                    Enabled = true;
                    DetailGridView.Rows.RemoveAt(0);
                    if (DetailGridView.RowCount > 0)
                    {
                        NameBox.Text = DetailGridView.Rows[0].Cells[0].Value.ToString() + " " + DetailGridView.Rows[0].Cells[1].Value.ToString();
                        PNumBox.Text = DetailGridView.Rows[0].Cells[2].Value.ToString();
                        if ((bool)DetailGridView.Rows[0].Cells[5].Value == false)
                        {
                            MessageBoxFa.Show(NameBox.Text + " دارای مازاد اضافه کار است!", "توجه", MessageBoxIcon.Warning);
                        }
                        Panel1.Enabled = true;
                        Panel3.Enabled = true;
                        AddRadioButton.Checked = true;
                    }
                    else
                    {
                        Panel1.Enabled = false;
                        Panel3.Enabled = false;
                        MessageBoxFa.Show("درخواستی برای این شیفت کاری وجود ندارد", "خطا", MessageBoxIcon.Error);
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

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalCombo.SelectedIndex = -1;

            if ((string)KindCombo.SelectedItem == "")
            {
                Label1.Text = "مرخصی روزانه:";
                LeaveCombo.Visible = true;
                TimeBox.Visible = false;
            }
            else if ((string)KindCombo.SelectedItem == "جایگزین مرخصی روزانه")
            {
                Label1.Text = "مرخصی روزانه:";
                LeaveCombo.Visible = true;
                TimeBox.Visible = false;
                LeaveCombo.Items.Clear();
            }
            else if ((string)KindCombo.SelectedItem == "جایگزین مرخصی ساعتی")
            {
                Label1.Text = "مرخصی ساعتی:";
                LeaveCombo.Visible = true;
                TimeBox.Visible = false;
                LeaveCombo.Items.Clear();
            }
            else if ((string)KindCombo.SelectedItem == "جایگزین کشیک")
            {
                Label1.Text = "راهبر کشیک:";
                LeaveCombo.Visible = true;
                TimeBox.Visible = false;
                LeaveCombo.Items.Clear();
            }
            else if (((string)KindCombo.SelectedItem == "همکاری با شیفت") || ((string)KindCombo.SelectedItem == "اضافه کار"))
            {
                Label1.Text = "مدت اضافه کار:";
                LeaveCombo.Visible = false;
                TimeBox.Visible = true;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                FullGridView.Rows.Clear();
                Panel1.Enabled = false;
                Panel2.Enabled = false;
                Panel3.Enabled = false;
                KindCombo.SelectedIndex = -1;
                DateTime SelectDate = ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح را مشخص کنید");
                }
                else if (SelectDate < DateTime.Today && AppState.UserLevel > 0)
                {
                    ErrorShow(PersianCalendar, "امکان اولویت بندی برای این تاریخ وجود ندارد");
                }
                else if ((!ProcessCheck(PersianCalendar.Text, "تهران") || !ProcessCheck(PersianCalendar.Text, "گلشهر") || !ProcessCheck(PersianCalendar.Text, "هشتگرد")) && AppState.UserLevel > 0)
                {
                    MessageBoxFa.Show("در این تاریخ پردازش لوحه انجام نشده، امکان اولویت بندی وجود ندارد", "خطا", MessageBoxIcon.Error);
                }
                else
                {

                    int i = 0;
                    Enabled = false;
                    if (string.IsNullOrEmpty(ProsDate))
                    {
                        ProsDate = MainForm.PersianToday.Tarikh();
                    }

                    if (string.IsNullOrEmpty(ProsTime))
                    {
                        ProsTime = DateTime.Now.ToString("HH:mm:ss");
                    }

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open(); // پایانه و خط تفکیک شود

                        using (OleDbCommand CMD = new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, Person.Shift_Time, Person.Shift_name, Person.Shift_loc, Morakhasi.T_Reg FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Morakhasi.Tarikh='" + PersianCalendar.Text + "' AND Morakhasi.Vis=True AND Person.Trip=True AND Person.Line_Num='" + AppState.UserLnum + "' ORDER BY Person.Shift_loc, Person.Shift_Time, Shift_name", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                string TReg = (string)Reader["T_Reg"];
                                if (ConvertClass.ShamsiToMiladi(TReg.Substring(0, 10)) > ConvertClass.ShamsiToMiladi(ProsDate) || ConvertClass.ShamsiToMiladi(TReg.Substring(0, 10)) == ConvertClass.ShamsiToMiladi(ProsDate) && DateTime.Parse(TReg.Substring(10, 8)) > DateTime.Parse(ProsTime))
                                {
                                    i++;
                                    FullGridView.Rows.Add(i, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Shift_Time"].ToString() + " " + Reader["Shift_name"].ToString(), Reader["Shift_loc"].ToString(), "مرخصی روزانه");
                                }
                            }
                        }

                        using (OleDbCommand CMD = new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, Person.Shift_Time, Person.Shift_name, Person.Shift_loc, Amal.T_Reg FROM Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.Tarikh='" + PersianCalendar.Text + "' AND Amal.Vis=True AND Amal.OnvAmal='ساعتی' AND Person.Trip=True AND Person.Line_Num='" + AppState.UserLnum + "' ORDER BY Person.Shift_loc, Person.Shift_Time, Shift_name", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                i++;
                                FullGridView.Rows.Add(i, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Shift_Time"].ToString() + " " + Reader["Shift_name"].ToString(), Reader["Shift_loc"].ToString(), "مرخصی ساعتی");
                            }
                        }

                        i = 0;
                        string SN = "";
                        while (i < FullGridView.RowCount)
                        {
                            if (int.TryParse(FullGridView.Rows[i].Cells[3].Value.ToString(), out _))
                            {
                                SN = FullGridView.Rows[i].Cells[4].Value.ToString().Substring(FullGridView.Rows[i].Cells[4].Value.ToString().Length - 1, 1);
                                if (SN == "A" || SN == "B" || SN == "C")
                                {
                                    FullGridView.Rows[i].Cells[4].Value = FullGridView.Rows[i].Cells[4].Value.ToString().Substring(0, FullGridView.Rows[i].Cells[4].Value.ToString().Length - 2);
                                    using (OleDbCommand CMD = new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            if ((string)FullGridView.Rows[i].Cells[4].Value == "9 ساعته")
                                            {
                                                if (Reader["Sobh"].ToString() == SN)
                                                {
                                                    FullGridView.Rows[i].Cells[4].Value += " صبح";
                                                }

                                                if (Reader["Asr"].ToString() == SN)
                                                {
                                                    FullGridView.Rows[i].Cells[4].Value += " عصر";
                                                }
                                            }
                                            else if ((string)FullGridView.Rows[i].Cells[4].Value == "12 ساعته")
                                            {
                                                if (Reader["Sobh"].ToString() == SN)
                                                {
                                                    FullGridView.Rows[i].Cells[4].Value += " روز";
                                                }

                                                if (Reader["Asr"].ToString() == SN)
                                                {
                                                    FullGridView.Rows[i].Cells[4].Value += " شب";
                                                }
                                            }
                                        }
                                    }

                                    i++;
                                }
                                else
                                {
                                    FullGridView.Rows[i].Cells[4].Value = "ستادی";
                                    i++;
                                }
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }

                    Panel2.Enabled = true;

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

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DetailGridView.Rows.Clear();

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع اضافه کار را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (ShiftCombo.Enabled && ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "شیفت را مشخص کنید");
                }
                else if (LeaveCombo.SelectedIndex < 0 && LeaveCombo.Visible)
                {
                    ErrorShow(LeaveCombo, "مرخصی را مشخص کنید");
                }
                else if (ConvertClass.TimeToDouble(TimeBox.Text, true) <= 0 && TimeBox.Visible)
                {
                    ErrorShow(TimeBox, "مدت اضافه کاری را مشخص کنید");
                }
                else
                {
                    int i;
                    double TopOver = 0;
                    double Overtime = 0;
                    double Emt = 0;

                    Enabled = false;
                    DetailGridView.Rows.Clear();

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string Shift = "";
                        if ((string)KindCombo.SelectedItem == "جایگزین کشیک")
                        {
                            if ((string)ShiftCombo.SelectedItem == "صبح")
                            {
                                Shift = "9 ساعته صبح";
                            }
                            else if ((string)ShiftCombo.SelectedItem == "عصر")
                            {
                                Shift = "9 ساعته عصر";
                            }
                            else if ((string)ShiftCombo.SelectedItem == "روز")
                            {
                                Shift = "12 ساعته روز";
                            }
                            else if ((string)ShiftCombo.SelectedItem == "شب")
                            {
                                Shift = "12 ساعته شب";
                            }
                        }
                        else
                        {
                            Shift = (string)ShiftCombo.SelectedItem;
                        }

                        TopOver = 0;
                        using (OleDbCommand CMD = new OleDbCommand("SELECT MonthTime FROM ShKar WHERE Tarikh='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                TopOver = ConvertClass.TimeToDouble(Reader["MonthTime"].ToString());
                            }
                        }

                        string QueStr = "SELECT Person.Fname, Person.Family, Person.P_Num, Person.Shift_Time, Person.Phone, JayGozin.Shift_Loc, JayGozin.Olv1, JayGozin.Olv2, JayGozin.Olv3, JayGozin.Olv4 FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE JayGozin.Tarikh='" + PersianCalendar.Text + "' AND JayGozin.Vis=True AND Person.Line_Num='" + AppState.UserLnum + "' AND Person.OverTime=True"; // AND Person.Trip=True
                        if ((string)LocalCombo.SelectedItem == "هشتگرد")
                        {
                            QueStr += " AND ((JayGozin.Shift_Loc='گلشهر' AND JayGozin.Olv1='همه موارد') OR (JayGozin.Shift_Loc='هشتگرد' AND JayGozin.Olv1='همه موارد') OR (JayGozin.Shift_Loc='هشتگرد' OR JayGozin.Olv1='هشتگرد' OR JayGozin.Olv2='هشتگرد' OR JayGozin.Olv3='هشتگرد' OR JayGozin.Olv4='هشتگرد'))";
                        }
                        else
                        {
                            QueStr += " AND Person.Trip=True AND JayGozin.Shift_Loc='" + LocalCombo.SelectedItem + "' AND (JayGozin.Olv1='همه موارد' OR JayGozin.Olv1='" + Shift + "' OR JayGozin.Olv2='" + Shift + "' OR JayGozin.Olv3='" + Shift + "' OR JayGozin.Olv4='" + Shift + "')";
                        }

                        using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DetailGridView.Rows.Add(Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0.0, Reader["Phone"].ToString(), true);
                            }
                        }

                        i = 0;
                        while (DetailGridView.RowCount > i)
                        {
                            Overtime = 0;
                            Emt = 0;

                            using (OleDbCommand CMD = new OleDbCommand("SELECT E_Time FROM Ezafeh WHERE ViS=True AND P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Tarikh='" + PersianCalendar.Text + "' AND E_Kind<>'تشویقی' AND E_Kind<>'کلاس آموزشی' AND E_Kind<>'شیفت'", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Overtime += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                }
                            }

                            if (Overtime > 11)
                            {
                                DetailGridView.Rows.RemoveAt(i);
                            }
                            else
                            {
                                // Morakhasi adds to Emt
                                int mor = 0;
                                if (PersianCalendar.Text.Substring(5, 2) == "01")
                                {
                                    using (OleDbCommand CMD = new OleDbCommand("SELECT COUNT(Tarikh) AS Cou FROM Morakhasi WHERE Vis=True AND P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Tarikh BETWEEN '" + PersianCalendar.Text.Substring(0, 7) + "/31' AND '" + PersianCalendar.Text.Substring(0, 7) + "/01'", StrConnec))
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            mor = int.Parse(Reader["Cou"].ToString());
                                        }
                                    }
                                }

                                using (OleDbCommand CMD = new OleDbCommand("SELECT Shift, Tota, TotaJom, NexMo FROM TotaMonAdv WHERE P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Maah='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (Reader["Shift"].ToString() == "")
                                        {
                                            StrConnec.Close();
                                            MessageBoxFa.Show("راهبر بدون اطلاعات شیفت یافت شد", "خطا", MessageBoxIcon.Error);
                                            return;
                                        }
                                        else
                                        {
                                            if (Reader["Shift"].ToString().Substring(2, 1) == "T")  //  اعمال امتیاز برای راهبر 12ساعته
                                            {
                                                Emt -= mor * 7;
                                                Emt += 30;
                                            }
                                            else
                                            {
                                                Emt -= mor * 4;
                                            }
                                            Overtime = ConvertClass.TimeToDouble(Reader["Tota"].ToString()) + ConvertClass.TimeToDouble(Reader["TotaJom"].ToString()) + ConvertClass.TimeToDouble(Reader["NexMo"].ToString());
                                        }
                                    }
                                }

                                using (OleDbCommand CMD = new OleDbCommand("SELECT Tarikh, T_Keshik FROM Keshik WHERE Vis=True AND P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Tarikh BETWEEN '" + PersianCalendar.Text.Substring(0, 7) + "/31' AND '" + PersianCalendar.Text.Substring(0, 7) + "/01'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        string TKeshik = Reader["T_Keshik"].ToString();
                                        if (TKeshik == "صبح" || TKeshik == "عصر" || TKeshik == "روز" || TKeshik == "شب") Emt += 6.5;
                                        if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()) == ConvertClass.ShamsiToMiladi(PersianCalendar.Text))
                                        {
                                            Overtime += 200;
                                        }
                                        else if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()) > ConvertClass.ShamsiToMiladi(PersianCalendar.Text))
                                        {
                                            Overtime += 13;
                                        }
                                    }
                                }

                                using (OleDbCommand CMD = new OleDbCommand("SELECT E_Kind, E_Time, Tarikh FROM Ezafeh WHERE Vis=True AND Tarikh>='" + PersianCalendar.Text.Substring(0, 7) + "/01' AND P_Num ='" + DetailGridView.Rows[i].Cells[2].Value + "'", StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        string Kind = Reader["E_Kind"].ToString();
                                        double EzTime = ConvertClass.TimeToDouble(Reader["E_Time"].ToString());

                                        if ((Kind == "تشویقی" || Kind == "کلاس آموزشی" || Kind == "شیفت") && EzTime > 0)
                                        {
                                            Emt += EzTime;
                                        }

                                        if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()).DayOfWeek == DayOfWeek.Friday)
                                        {
                                            Emt -= EzTime * 0.5; // اضافه کار جمعه
                                        }
                                    }
                                }

                                if (Overtime > TopOver)
                                {
                                    if (Overtime > TopOver + 10 && AppState.UserLevel > 3)
                                        DetailGridView.Rows.RemoveAt(i);
                                    else
                                    {
                                        DetailGridView.Rows[i].Cells[3].Value = Overtime;
                                        DetailGridView.Rows[i].Cells[5].Value = false;
                                        i++;
                                    }
                                }
                                else
                                {
                                    DetailGridView.Rows[i].Cells[3].Value = Overtime - Emt;
                                    i++;
                                }
                            }
                        }
                    }

                    Enabled = true;
                    DetailGridView.Sort(DetailGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                    if (DetailGridView.RowCount > 0)
                    {
                        NameBox.Text = DetailGridView.Rows[0].Cells[0].Value.ToString() + " " + DetailGridView.Rows[0].Cells[1].Value.ToString();
                        PNumBox.Text = DetailGridView.Rows[0].Cells[2].Value.ToString();
                        PhoneBox.Text = DetailGridView.Rows[0].Cells[4].Value.ToString();
                        if ((bool)DetailGridView.Rows[0].Cells[5].Value == false)
                        {
                            MessageBoxFa.Show(NameBox.Text + " دارای مازاد اضافه کار است!", "توجه", MessageBoxIcon.Warning);
                        }

                        Panel1.Enabled = true;
                        Panel3.Enabled = true;
                        AddRadioButton.Checked = true;
                    }
                    else
                    {
                        Panel1.Enabled = false;
                        Panel3.Enabled = false;
                        MessageBoxFa.Show("درخواستی برای " + ShiftCombo.SelectedItem + " وجود ندارد", "خطا", MessageBoxIcon.Error);
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

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            FullGridView.Rows.Clear();
            Panel1.Enabled = false;
            Panel2.Enabled = false;
            Panel3.Enabled = false;
            KindCombo.SelectedIndex = -1;
        }
    }
}
