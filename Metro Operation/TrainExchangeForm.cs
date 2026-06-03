using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TrainExchangeForm
    {
        public TrainExchangeForm()
        {
            InitializeComponent();
        }


        private string PNum1;
        private string PNum2;
        private string PNum3;
        private int DisLine = 0;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void TableShow()
        {
            try
            {
                int i = 0;

                EzamBox.Text = "";
                EzamBox.Enabled = false;
                EzamLocalCombo.SelectedIndex = -1;
                EzamLocalCombo.Enabled = false;

                Name1Button.Image = Properties.Resources.user;
                Name1Box.Text = "";
                PNum1 = "";
                R1TimeBox.Text = "";

                Name2Button.Image = Properties.Resources.user;
                Name2Box.Text = "";
                PNum2 = "";
                R2TimeBox.Text = "";

                Name3Button.Image = Properties.Resources.user;
                Name3Box.Text = "";
                PNum3 = "";
                R3TimeBox.Text = "";

                ShowGridView.Rows.Clear();

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM DailyTrip WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND Mabdae LIKE '%{LocalCombo.SelectedItem}%' ORDER BY T_Time", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i++;
                            ShowGridView.Rows.Add(i, Reader["Tarikh"].ToString(), Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Reader["Maghsad"].ToString(), "", Reader["O1_Num"].ToString(), Reader["O1_Time"].ToString(), "", Reader["OT_Num"].ToString(), Reader["OT_Time"].ToString(), "", Reader["O2_Num"].ToString(), Reader["O2_Time"].ToString());
                        }
                    }
                }


                if (ShowGridView.Rows.Count == 0)
                {
                    MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                }
                else
                {
                    DataRow[] DRow;
                    for (i = 0; i <= ShowGridView.Rows.Count - 1; i++)
                    {
                        if (ShowGridView.Rows[i].Cells[6].Value.ToString() != "")
                        {
                            DRow = MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[6].Value.ToString() + "'");
                            if (DRow.Length > 0)
                            {
                                ShowGridView.Rows[i].Cells[5].Value = DRow[0][0] + " " + DRow[0][1];
                            }
                        }

                        if (ShowGridView.Rows[i].Cells[9].Value.ToString() != "")
                        {
                            DRow = MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[9].Value.ToString() + "'");
                            if (DRow.Length > 0)
                            {
                                ShowGridView.Rows[i].Cells[8].Value = DRow[0][0] + " " + DRow[0][1];
                            }
                        }

                        if (ShowGridView.Rows[i].Cells[12].Value.ToString() != "")
                        {
                            DRow = MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[12].Value.ToString() + "'");
                            if (DRow.Length > 0)
                            {
                                ShowGridView.Rows[i].Cells[11].Value = DRow[0][0] + " " + DRow[0][1];
                            }
                        }
                    }

                    ShowGridView.FirstDisplayedScrollingRowIndex = DisLine;
                    ShowGridView.CurrentRow.Selected = false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TianExchangeForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);

            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local)) LocalCombo.Items.Add(Local);
            }

            if (LocalCombo.Items.Count > 0)
            {
                LocalCombo.SelectedIndex = 0;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime MTar = ConvertClass.ShamsiToMiladi(PersianCalendar.Text);
                EzamBox.Enabled = false;
                EzamLocalCombo.Enabled = false;
                Panel2.BackColor = Color.FromArgb(224, 224, 224);
                ShowGridView.Rows.Clear();

                if ((MTar > DateTime.Today || MTar < DateTime.Today.AddDays(-1)) && AppState.UserLevel > 1)
                {
                    ErrorShow(PersianCalendar, "تاریخ خارج از بازه قابل ویرایش است");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا جدول را مشخص کنید");
                }
                else
                {
                    Panel2.Enabled = true;
                    DisLine = 0;
                    TableShow();
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
            ShowGridView.Rows.Clear();
        }

        public void Time1Button_Click(object sender, EventArgs e)
        {
            R1TimeBox.Text = DateTime.Now.ToString("HH:mm");
        }

        public void Time2Button_Click(object sender, EventArgs e)
        {
            R2TimeBox.Text = DateTime.Now.ToString("HH:mm");
        }

        public void Name1Button_Click(object sender, EventArgs e)
        {
            Name1Box.Text = "";
            PNum1 = "";
            Name1Button.Image = Properties.Resources.user;
            PersonalSelectForm.Per = "راهبر قطار";
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PNum1 = PersonalSelectForm.PNum;
                Name1Box.Text = PersonalSelectForm.PName + " " + PersonalSelectForm.PName;
                Name1Button.Image = Properties.Resources.cancel1;
            }
        }

        public void Name2Button_Click(object sender, EventArgs e)
        {
            Name2Box.Text = "";
            PNum2 = "";
            Name2Button.Image = Properties.Resources.user;
            PersonalSelectForm.Per = "راهبر قطار";
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {

                PNum2 = PersonalSelectForm.PNum;
                Name2Box.Text = PersonalSelectForm.PName + " " + PersonalSelectForm.PName;
                Name2Button.Image = Properties.Resources.cancel1;
            }
        }

        public void Name3Button_Click(object sender, EventArgs e)
        {
            Name3Box.Text = "";
            PNum3 = "";
            Name3Button.Image = Properties.Resources.user;
            PersonalSelectForm.Per = "راهبر قطار";
            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PNum3 = PersonalSelectForm.PNum;
                Name3Box.Text = PersonalSelectForm.PName + " " + PersonalSelectForm.PName;
                Name3Button.Image = Properties.Resources.cancel1;
            }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            EzamBox.Enabled = true;
            EzamLocalCombo.Enabled = true;
            Panel2.BackColor = Color.FromArgb(192, 255, 192);
            EzamBox.Text = "";
            EzamLocalCombo.SelectedIndex = -1;
            Name1Box.Text = "";
            PNum1 = "";
            R1TimeBox.Text = "";

            Name2Box.Text = "";
            PNum2 = "";
            R2TimeBox.Text = "";

            Name3Box.Text = "";
            PNum3 = "";
            R3TimeBox.Text = "";
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConvertClass.TimeToDouble(EzamBox.Text, true) <= 0)
                {
                    ErrorShow(EzamBox, "ساعت اعزام را مشخص کنید");
                }
                else if (EzamLocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(EzamLocalCombo, "مبدا اعزام را مشخص کنید");
                }
                else if (Name1Box.Text == "")
                {
                    ErrorShow(Name1Box, "نام راهبر اصلی را مشخص کنید");
                }
                else if (Name2Box.Text == "")
                {
                    ErrorShow(Name2Box, "نام راهبر کمکی را مشخص کنید");
                }
                else if (PNum1 == PNum2 || PNum1 == PNum3 || PNum2 == PNum3)
                {
                    ErrorShow(Name1Box, "راهبر تکراری انتخاب شده است");
                    ErrorShow(Name2Box, "راهبر تکراری انتخاب شده است");
                }
                else
                {
                    if (ConvertClass.TimeToDouble(R1TimeBox.Text, true) > 0)
                    {
                        if (string.Compare(EzamBox.Text, R1TimeBox.Text) < 0 || DateTime.Parse(EzamBox.Text) > DateTime.Parse(R1TimeBox.Text).AddMinutes(30))
                        {
                            ErrorShow(R1TimeBox, "زمان تحویل گیری راهبر اصلی خارج از بازه است");
                            return;
                        }
                    }

                    if (ConvertClass.TimeToDouble(R2TimeBox.Text, true) > 0)
                    {
                        if (string.Compare(EzamBox.Text, R2TimeBox.Text) < 0 || DateTime.Parse(EzamBox.Text) > DateTime.Parse(R2TimeBox.Text).AddMinutes(30))
                        {
                            ErrorShow(R2TimeBox, "زمان تحویل گیری راهبر کمکی خارج از بازه است");
                            return;
                        }
                    }

                    if (ConvertClass.TimeToDouble(R3TimeBox.Text, true) > 0)
                    {
                        if (string.Compare(EzamBox.Text, R3TimeBox.Text) < 0 || DateTime.Parse(EzamBox.Text) > DateTime.Parse(R3TimeBox.Text).AddMinutes(30))
                        {
                            ErrorShow(R3TimeBox, "زمان تحویل گیری راهبر آموزشی خارج از بازه است");
                            return;
                        }
                    }

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        if (EzamBox.Enabled)
                        {
                            int i;
                            for (i = 0; i <= ShowGridView.Rows.Count - 1; i++)
                            {
                                if (EzamBox.Text == (string)ShowGridView.Rows[i].Cells[2].Value)
                                {
                                    StrConnec.Close();
                                    MessageBoxFa.Show("این اعزام در جدول وجود دارد و امکان اضافه کردن وجود ندارد", "خطا", MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            string QueStr = $"INSERT INTO DailyTrip (Tarikh, T_Time, O1_NUM, O2_NUM, OT_NUM, Execu, U_Reg, T_Reg, Vis, O1_Time, O2_Time, OT_Time, Mabdae, Maghsad) VALUES ('{PersianCalendar.Text}','{EzamBox.Text}', '{PNum1}', '{PNum2}', '{PNum3}', True, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True, ";
                            if (ConvertClass.TimeToDouble(R1TimeBox.Text, true) > 0)
                            {
                                QueStr += $"'{R1TimeBox.Text}',";
                            }
                            else
                            {
                                QueStr += "'',";
                            }
                            if (ConvertClass.TimeToDouble(R2TimeBox.Text, true) > 0)
                            {
                                QueStr += $"'{R2TimeBox.Text}',";
                            }
                            else
                            {
                                QueStr += "'',";
                            }
                            if (ConvertClass.TimeToDouble(R3TimeBox.Text, true) > 0)
                            {
                                QueStr += $"'{R3TimeBox.Text}',";
                            }
                            else
                            {
                                QueStr += "'',";
                            }
                            if ((string)EzamLocalCombo.SelectedItem == "گلشهر")
                            {
                                QueStr += "'گلشهر', 'تهران')";
                            }
                            else
                            {
                                QueStr += "'تهران', 'گلشهر')";
                            }

                            using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                        }
                        else
                        {
                            int ID = 0;
                            bool Chang = false;

                            using (OleDbCommand CMD = new OleDbCommand("SELECT ID, O1_NUM, O2_NUM, OT_NUM FROM DailyTrip WHERE Vis=True AND Tarikh='" + PersianCalendar.Text + "' AND T_Time='" + EzamBox.Text + "' AND Mabdae='" + EzamLocalCombo.SelectedItem + "' ORDER BY ID", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID = Convert.ToInt32(Reader["ID"]);
                                    if (PNum1 != Reader["O1_NUM"].ToString() || PNum2 != Reader["O2_NUM"].ToString() || PNum3 != Reader["OT_NUM"].ToString())
                                    {
                                        Chang = true;
                                    }
                                }
                            }

                            if (ID == 0)
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show("خطا در ویرایش تریپ انتخاب شده", "خطا", MessageBoxIcon.Error);
                                return;
                            }

                            if (Chang)
                            {
                                using (OleDbCommand CMD = new OleDbCommand("UPDATE DailyTrip SET Vis=False WHERE ID=" + ID.ToString(), StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                                string QueStr = "INSERT INTO DailyTrip(Tarikh, T_Time, O1_NUM, O2_NUM, OT_NUM, Execu, U_Reg, T_Reg, Vis, O1_Time, O2_Time, OT_Time, Mabdae, Maghsad) VALUES ('" + PersianCalendar.Text + "','" + EzamBox.Text + "', '" + PNum1 + "', '" + PNum2 + "', '" + PNum3 + "', True, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, ";
                                if (ConvertClass.TimeToDouble(R1TimeBox.Text, true) > 0)
                                {
                                    QueStr += "'" + R1TimeBox.Text + "',";
                                }
                                else
                                {
                                    QueStr += "'',";
                                }
                                if (ConvertClass.TimeToDouble(R2TimeBox.Text, true) > 0)
                                {
                                    QueStr += "'" + R2TimeBox.Text + "',";
                                }
                                else
                                {
                                    QueStr += "'',";
                                }
                                if (ConvertClass.TimeToDouble(R3TimeBox.Text, true) > 0)
                                {
                                    QueStr += "'" + R3TimeBox.Text + "',";
                                }
                                else
                                {
                                    QueStr += "'',";
                                }
                                if ((string)EzamLocalCombo.SelectedItem == "گلشهر")
                                {
                                    QueStr += "'گلشهر', 'تهران')";
                                }
                                else
                                {
                                    QueStr += "'تهران', 'گلشهر')";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                using (OleDbCommand CMD = new OleDbCommand("UPDATE DailyTrip SET Execu=True,", StrConnec))
                                {
                                    if (ConvertClass.TimeToDouble(R1TimeBox.Text, true) > 0)
                                    {
                                        CMD.CommandText += " O1_Time ='" + R1TimeBox.Text + "',";
                                    }
                                    else
                                    {
                                        CMD.CommandText += " O1_Time ='',";
                                    }
                                    if (ConvertClass.TimeToDouble(R2TimeBox.Text, true) > 0)
                                    {
                                        CMD.CommandText += " O2_Time ='" + R2TimeBox.Text + "',";
                                    }
                                    else
                                    {
                                        CMD.CommandText += " O2_Time ='',";
                                    }
                                    if (ConvertClass.TimeToDouble(R3TimeBox.Text, true) > 0)
                                    {
                                        CMD.CommandText += " OT_Time ='" + R3TimeBox.Text + "',";
                                    }
                                    else
                                    {
                                        CMD.CommandText += " OT_Time ='',";
                                    }
                                    CMD.CommandText += " U_Reg='" + AppState.UserName + "', T_Reg='" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE ID=" + ID.ToString();
                                    CMD.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    DisLine = ShowGridView.FirstDisplayedScrollingRowIndex;

                    TableShow();
                }
            }
            catch (Exception ex)
            {
                Enabled = true;
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Time3Button_Click(object sender, EventArgs e)
        {
            R3TimeBox.Text = DateTime.Now.ToString("HH:mm");
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel2.Enabled = false;
            ShowGridView.Rows.Clear();
        }

        public void ShowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisLine = ShowGridView.FirstDisplayedScrollingRowIndex;

            EzamBox.Enabled = false;
            EzamLocalCombo.Enabled = false;
            Panel2.BackColor = Color.FromArgb(224, 224, 224);
            EzamLocalCombo.Items.Clear();

            if (ShowGridView.CurrentRow.Cells[3].Value.ToString() == "هشتگرد" || ShowGridView.CurrentRow.Cells[4].Value.ToString() == "هشتگرد")
            {
                LineCombo.SelectedIndex = 1;

                EzamLocalCombo.Items.Add("گلشهر (هشتگرد)");
                EzamLocalCombo.Items.Add("هشتگرد");
            }

            else
            {
                LineCombo.SelectedIndex = 0;

                EzamLocalCombo.Items.Add("تهران");
                EzamLocalCombo.Items.Add("گلشهر");
            }
            EzamLocalCombo.SelectedItem = ShowGridView.CurrentRow.Cells[3].Value.ToString();
            EzamBox.Text = ShowGridView.CurrentRow.Cells[2].Value.ToString();

            Name1Box.Text = ShowGridView.CurrentRow.Cells[5].Value.ToString();
            PNum1 = ShowGridView.CurrentRow.Cells[6].Value.ToString();
            R1TimeBox.Text = ShowGridView.CurrentRow.Cells[7].Value.ToString();

            Name2Box.Text = ShowGridView.CurrentRow.Cells[11].Value.ToString();
            PNum2 = ShowGridView.CurrentRow.Cells[12].Value.ToString();
            R2TimeBox.Text = ShowGridView.CurrentRow.Cells[13].Value.ToString();

            Name3Box.Text = ShowGridView.CurrentRow.Cells[8].Value.ToString();
            PNum3 = ShowGridView.CurrentRow.Cells[9].Value.ToString();
            R3TimeBox.Text = ShowGridView.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
