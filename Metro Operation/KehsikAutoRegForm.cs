using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class KehsikAutoRegForm
    {
        public KehsikAutoRegForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void DaysFill(OleDbConnection StrConnec)
        {
            try
            {
                Taghvim PersianDate = new Taghvim();
                string ShiftName = "";
                int Sob = 0;
                int Asr = 0;
                int i;
                int j = 0;

                if (TabControl1.SelectedIndex == 0)
                {
                    PersianDate.SetDate(DateTime.Today);
                    PersianDate.AddDay(-PersianDate.Day() + 1);
                    PersianDate.AddMonth(MonthCombo.SelectedIndex);
                }
                else
                {
                    PersianDate.SetDate(StartCalendar.Text);
                }

                j = 1;
                do
                {
                    using (OleDbCommand CMD = new OleDbCommand("SELECT Holi, Sobh FROM Taghvim WHERE Tarikh='" + PersianDate.Tarikh() + "'", StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if ((bool)Reader["Holi"] || PersianDate.DayWeek() == "جمعه")
                            {
                                Sob = int.Parse(SobhFBox.Text);
                                Asr = int.Parse(AsrFBox.Text);
                            }
                            else if (PersianDate.DayWeek() == "پنج شنبه")
                            {
                                Sob = int.Parse(Sobh5Box.Text);
                                Asr = int.Parse(Asr5Box.Text);
                            }
                            else
                            {
                                Sob = int.Parse(SobhBox.Text);
                                Asr = int.Parse(AsrBox.Text);
                            }

                            if ((string)Reader["Sobh"] == "A")
                            {
                                ShiftName = "C";
                            }
                            else if ((string)Reader["Sobh"] == "B")
                            {
                                ShiftName = "A";
                            }
                            else
                            {
                                ShiftName = "B";
                            }

                            for (i = 1; i <= Sob; i++)
                            {
                                ShowGridView.Rows.Add(j, "", "", "", PersianDate.DayWeek(), PersianDate.Tarikh(), LabelSobh.Text, LocalCombo.SelectedItem.ToString(), ShiftName, 1);
                                j++;
                            }

                            for (i = 1; i <= Asr; i++)
                            {
                                ShowGridView.Rows.Add(j, "", "", "", PersianDate.DayWeek(), PersianDate.Tarikh(), LabelAsr.Text, LocalCombo.SelectedItem.ToString(), ShiftName, 1);
                                j++;
                            }
                        }
                    }

                    ShiftName = PersianDate.Miladi().ToString();
                    PersianDate.AddDay(1);

                } while (!(PersianDate.Miladi() > ConvertClass.ShamsiToMiladi(EndCalendar.Text)));
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void FillPer(string shTime, OleDbConnection strConnec)
        {
            try
            {
                // 🔹 آماده‌سازی اولیه
                Taghvim persianDate = new Taghvim();
                DataTable detailView = new DataTable();
                detailView.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("Pname"),
                    new DataColumn("Family"),
                    new DataColumn("PNum"),
                    new DataColumn("ShName"),
                    new DataColumn("Mabda"),
                    new DataColumn("Max", typeof(decimal)),
                    new DataColumn("Sobh", typeof(double)),
                    new DataColumn("Asr", typeof(double)),
                    new DataColumn("TueNgh", typeof(double)),
                    new DataColumn("FriDay", typeof(double)),
                    new DataColumn("FriNgh", typeof(double)),
                    new DataColumn("Emt", typeof(double)),
                    new DataColumn("Day", typeof(int))
                });

                // 🔹 ساخت Query اصلی برای استخراج لیست افراد
                string strQuery = @"SELECT Person.FName, Person.Family, Person.P_Num, Person.Line_Num, Person.Shift_Time, Person.Shift_Name, Person.Shift_Loc, KeshikRequ.Num FROM KeshikRequ INNER JOIN Person ON Person.P_Num=KeshikRequ.P_Num WHERE KeshikRequ.Vis=True AND KeshikRequ.Num > 0 AND Person.P_Post='راهبر قطار' AND Person.Vis=True AND Person.Trip=True AND Person.Overtime=True AND Person.Shift_Time=? AND Person.Shift_Loc=?";

                if (AppState.UserLevel > 1)
                {
                    strQuery += " AND Person.Line_Num=?";
                }

                using (OleDbCommand cmd = new OleDbCommand(strQuery, strConnec))
                {
                    cmd.Parameters.AddWithValue("?", shTime);
                    cmd.Parameters.AddWithValue("?", LocalCombo.SelectedItem);
                    if (AppState.UserLevel > 1)
                    {
                        cmd.Parameters.AddWithValue("?", AppState.UserLnum);
                    }

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detailView.Rows.Add(
                                reader["FName"].ToString(),
                                reader["Family"].ToString(),
                                reader["P_Num"].ToString(),
                                reader["Shift_Name"].ToString(),
                                reader["Shift_Loc"].ToString(),
                                Convert.ToDouble(reader["Num"]),
                                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, -1
                            );

                            int.TryParse(Loc1CouBox.Text, out int current);
                            Loc1CouBox.Text = (current + 1).ToString();
                        }
                    }
                }

                // 🔹 پردازش تب دوم (TabControl1.SelectedIndex == 1)
                if (TabControl1.SelectedIndex == 1)
                {
                    persianDate.SetDate(StartCalendar.Text.Substring(0, 8) + "01");
                    string startDate = persianDate.FirstOfThisMonth();
                    string endDate = persianDate.EndOfThisMonth();

                    for (int i = 0; i < detailView.Rows.Count;)
                    {
                        string pNum = detailView.Rows[i]["PNum"].ToString();
                        using (OleDbCommand cmd = new OleDbCommand(@"SELECT Tarikh, T_Keshik FROM Keshik WHERE Vis=True AND Tarikh BETWEEN ? AND ? AND P_Num=? AND T_Keshik <> 'کلاس آموزش'", strConnec))
                        {
                            cmd.Parameters.AddWithValue("?", startDate);
                            cmd.Parameters.AddWithValue("?", endDate);
                            cmd.Parameters.AddWithValue("?", pNum);

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    detailView.Rows[i]["Day"] = int.Parse(reader["Tarikh"].ToString().Substring(8, 2));
                                    detailView.Rows[i]["Emt"] = Convert.ToDouble(detailView.Rows[i]["Emt"]) + 1;

                                    string tKeshik = reader["T_Keshik"].ToString();
                                    int cellIndex = (tKeshik == "صبح" || tKeshik == "روز") ? 6 : 7;
                                    detailView.Rows[i][cellIndex] = Convert.ToDouble(detailView.Rows[i][cellIndex]) + 1;
                                }
                            }
                        }

                        if (Convert.ToDouble(detailView.Rows[i]["Emt"]) >= Convert.ToDouble(detailView.Rows[i]["Max"]))
                        {
                            detailView.Rows.RemoveAt(i);
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                // 🔹 مرحله دوم بررسی بازه قبل و بعد از ماه جاری
                void updateDetail(string start, string end)
                {
                    for (int i = 0; i < detailView.Rows.Count; i++)
                    {
                        using (OleDbCommand cmd = new OleDbCommand(@"SELECT T_Keshik FROM Keshik WHERE Fad IS NULL AND Tarikh BETWEEN ? AND ? AND T_Keshik <> 'کلاس آموزش' AND P_Num=?", strConnec))
                        {
                            cmd.Parameters.AddWithValue("?", start);
                            cmd.Parameters.AddWithValue("?", end);
                            cmd.Parameters.AddWithValue("?", detailView.Rows[i]["PNum"]);

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string tKeshik = reader["T_Keshik"].ToString();
                                    int idx = (tKeshik == "صبح" || tKeshik == "روز") ? 6 : 7;
                                    detailView.Rows[i][idx] = Convert.ToDouble(detailView.Rows[i][idx]) + 0.01;
                                }
                            }
                        }

                        detailView.Rows[i]["Emt"] = Convert.ToDouble(detailView.Rows[i]["Sobh"]) + Convert.ToDouble(detailView.Rows[i]["Asr"]);
                    }
                }

                // ماه جاری
                persianDate.SetDate(StartCalendar.Text.Substring(0, 8) + "01");
                updateDetail(persianDate.FirstOfThisMonth(), persianDate.AddDay(-1));

                // ماه قبل
                updateDetail(persianDate.FirstOfThisMonth(), persianDate.AddMonth(-1));

                // 🔹 هماهنگ‌سازی با GridView
                for (int i = ShowGridView.RowCount - 1; i >= 0; i--)
                {
                    if (string.IsNullOrEmpty(ShowGridView.Rows[i].Cells[3].Value.ToString()))
                    {
                        string shiftType = ShowGridView.Rows[i].Cells[6].Value.ToString();
                        detailView.DefaultView.Sort = (shiftType == "صبح" || shiftType == "روز")
                            ? "Mabda, ShName, Emt, Sobh"
                            : "Mabda, ShName, Emt, Asr";

                        detailView = detailView.DefaultView.ToTable();

                        for (int j = 0; j < detailView.Rows.Count; j++)
                        {
                            if (detailView.Rows[j]["Mabda"].Equals(ShowGridView.Rows[i].Cells[7].Value) &&
                                detailView.Rows[j]["ShName"].Equals(ShowGridView.Rows[i].Cells[8].Value))
                            {
                                int days = int.Parse(ShowGridView.Rows[i].Cells[5].Value.ToString().Substring(8, 2));
                                int currentDay = Convert.ToInt32(detailView.Rows[j]["Day"]);

                                if (currentDay != days && currentDay != days - 1 && currentDay != days + 1)
                                {
                                    ShowGridView.Rows[i].Cells[1].Value = detailView.Rows[j]["Pname"];
                                    ShowGridView.Rows[i].Cells[2].Value = detailView.Rows[j]["Family"];
                                    ShowGridView.Rows[i].Cells[3].Value = detailView.Rows[j]["PNum"];

                                    int cellIndex = (shiftType == "صبح" || shiftType == "روز") ? 6 : 7;
                                    detailView.Rows[j][cellIndex] = Convert.ToDouble(detailView.Rows[j][cellIndex]) + 1;
                                    detailView.Rows[j]["Emt"] = Convert.ToDouble(detailView.Rows[j]["Emt"]) + 1;
                                    detailView.Rows[j]["Day"] = days;

                                    break;
                                }
                            }
                        }

                        // حذف رکوردهای تکمیل‌شده
                        for (int j = 0; j < detailView.Rows.Count;)
                        {
                            if (Convert.ToDouble(detailView.Rows[j]["Emt"]) >= Convert.ToDouble(detailView.Rows[j]["Max"]))
                            {
                                detailView.Rows.RemoveAt(j);
                            }
                            else
                            {
                                j++;
                            }
                        }
                    }
                }

                detailView.Dispose();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }


        public void KehsikAutoRegForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0601");
        }

        public void KehsikAutoRegForm_Load(object sender, EventArgs e)
        {
            DetailGridView.Visible = false;
            //if (AppState.UserLevel == 0)
            //{
            //    if (MessageBoxFa.Show(" جزئیات نمایش داده شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //    {
            //        DetailGridView.Visible=true;
            //    }
            //}
            Taghvim PersianDate = new Taghvim(DateTime.Today);
            MonthCombo.Items.Add(PersianDate.MonthName());
            PersianDate.AddMonth(1);
            MonthCombo.Items.Add(PersianDate.MonthName());
            PersianDate.AddMonth(1);
            MonthCombo.Items.Add(PersianDate.MonthName());

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
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Dim FI As Boolean=False
                Taghvim PersianDate = new Taghvim(DateTime.Today);

                DetailGridView.Rows.Clear();
                ShowGridView.Rows.Clear();

                PersianDate.SetDate(DateTime.Today.AddDays(-(PersianDate.Day() - 1)));
                PersianDate.AddMonth(MonthCombo.SelectedIndex);

                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را تعیین کنید");
                }
                else if (!R9Check.Checked && !R12Check.Checked)
                {
                    ErrorShow(R9Check, "نوع شیفت را مشخص کنید");
                }
                else if (TabControl1.SelectedIndex == 0 && MonthCombo.SelectedIndex < 0)
                {
                    ErrorShow(MonthCombo, "ماه مورد نظر را تعیین کنید");
                }
                else if (TabControl1.SelectedIndex == 1 && ConvertClass.ShamsiToMiladi(StartCalendar.Text) == null || ConvertClass.ShamsiToMiladi(EndCalendar.Text) == null)
                {
                    ErrorShow(MonthCombo, "تاریخ مورد نظر را تعیین کنید");
                }
                else if (!int.TryParse(SobhBox.Text, out _))
                {
                    ErrorShow(SobhBox, "تعداد کشیک صبح صحیح نسیت");
                }
                else if (!int.TryParse(AsrBox.Text, out _))
                {
                    ErrorShow(AsrBox, "تعداد کشیک عصر صحیح نسیت");
                }
                else if (!int.TryParse(Sobh5Box.Text, out _))
                {
                    ErrorShow(Sobh5Box, "تعداد کشیک صبح صحیح نسیت");
                }
                else if (!int.TryParse(Asr5Box.Text, out _))
                {
                    ErrorShow(Asr5Box, "تعداد کشیک عصر صحیح نسیت");
                }
                else if (!int.TryParse(SobhFBox.Text, out _))
                {
                    ErrorShow(SobhFBox, "تعداد کشیک صبح صحیح نسیت");
                }
                else if (!int.TryParse(AsrFBox.Text, out _))
                {
                    ErrorShow(AsrFBox, "تعداد کشیک عصر صحیح نسیت");
                }
                else
                {
                    int i;
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled = false;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            i = 0;

                            string StrQuer = "SELECT Person.FName, Person.Family, Person.P_Num, Person.Shift_Name, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.Vis=True AND Keshik.T_Keshik<>'کلاس آموزش' AND Person.Line_Num='" + AppState.UserLnum + "' AND Keshik.L_Keshik='" + LocalCombo.SelectedItem + "'";
                            if (TabControl1.SelectedIndex == 0)
                            {
                                StrQuer += " AND Keshik.Tarikh LIKE '" + PersianDate.Tarikh().Substring(0, 7) + "%'";
                            }
                            else
                            {
                                StrQuer += " AND Keshik.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                            }

                            if (int.Parse(SobhBox.Text) + int.Parse(AsrBox.Text) + int.Parse(Sobh5Box.Text) + int.Parse(Asr5Box.Text) + int.Parse(SobhFBox.Text) + int.Parse(AsrFBox.Text) == 0)
                            {
                                StrQuer += " ORDER BY Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik";
                            }

                            using (OleDbCommand CMD = new OleDbCommand(StrQuer, StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    i++;
                                    if (PersianDate.Tarikh() != Reader["Tarikh"].ToString())
                                    {
                                        PersianDate.SetDate(Reader["Tarikh"].ToString());
                                    }

                                    ShowGridView.Rows.Add(i, Reader["FName"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), PersianDate.DayWeek(), Reader["Tarikh"].ToString(), Reader["T_Keshik"].ToString(), Reader["L_Keshik"].ToString(), Reader["Shift_Name"].ToString(), 0);
                                }
                            }

                            if (ShowGridView.RowCount > 0 && AppState.UserLevel > 0)
                            {
                                Enabled = true;
                                wait.Close();
                                StrConnec.Close();
                                MessageBoxFa.Show(" برای این ماه کشیک تعیین شده است", "توجه", MessageBoxIcon.Information);
                                return;
                            }

                            if (int.Parse(SobhBox.Text) + int.Parse(AsrBox.Text) + int.Parse(Sobh5Box.Text) + int.Parse(Asr5Box.Text) + int.Parse(SobhFBox.Text) + int.Parse(AsrFBox.Text) == 0)
                            {
                                ErrorShow(Panel2, "تعداد کشیک تعیین شده صحیح نسیت");
                                ErrorShow(Panel3, "تعداد کشیک تعیین شده صحیح نسیت");
                                ErrorShow(Panel5, "تعداد کشیک تعیین شده صحیح نسیت");
                            }
                            else
                            {

                                AllCounBox.Text = "0";
                                Loc1CouBox.Text = "0";
                                EmptLoc1Box.Text = "0";

                                DaysFill(StrConnec);
                                if (R9Check.Checked)
                                {
                                    FillPer("9 ساعته", StrConnec);
                                }

                                if (R12Check.Checked)
                                {
                                    FillPer("12 ساعته", StrConnec);
                                }

                                for (i = 0; i <= ShowGridView.RowCount - 1; i++)
                                {
                                    ShowGridView.Rows[i].Cells[0].Value = i + 1;
                                    if ((string)ShowGridView.Rows[i].Cells[3].Value == "")
                                    {
                                        ShowGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                        ShowGridView.Rows[i].Cells[2].Value = " خالی ";
                                        EmptLoc1Box.Text = (int.Parse(EmptLoc1Box.Text) + 1).ToString();
                                    }
                                }
                                AllCounBox.Text = ShowGridView.RowCount.ToString();
                            }
                        }


                        Enabled = true;
                        wait.Close();
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

                if (int.Parse(EmptLoc1Box.Text) > 0)
                {
                    if (MessageBoxFa.Show("تعداد " + EmptLoc1Box.Text + " جای خالی وجود دارد \n\n جدول کشیک ذخیره شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                Taghvim PersianDate = new Taghvim();
                int i;

                using (WaitForm wait = new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    Enabled = false;

                    ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        for (i = 0; i <= ShowGridView.RowCount - 1; i++)
                        {
                            if (int.TryParse(ShowGridView.Rows[i].Cells[3].Value.ToString(), out _) && (int)ShowGridView.Rows[i].Cells[9].Value == 1)
                            {
                                using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, T_Keshik, L_Keshik, U_Reg, T_Reg, Vis) VALUES ('{ShowGridView.Rows[i].Cells[3].Value}', '{ShowGridView.Rows[i].Cells[5].Value}', '{ShowGridView.Rows[i].Cells[6].Value}', '{ShowGridView.Rows[i].Cells[7].Value}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }
                        }

                        PersianDate.SetDate(Convert.ToDateTime(ShowGridView.Rows[0].Cells[5].Value));
                        DetailGridView.Rows.Clear();

                        for (i = 0; i <= 15; i++)
                        {
                            using (OleDbCommand CMD = new OleDbCommand("SELECT JayGozin.ID, JayGozin.P_Num, JayGozin.Tarikh FROM JayGozin INNER JOIN Keshik ON Keshik.P_Num=JayGozin.P_Num WHERE JayGozin.Tarikh='" + PersianDate.Tarikh() + "' AND Keshik.Tarikh='" + PersianDate.Tarikh() + "' AND JayGozin.Vis=True AND Keshik.Vis=True", StrConnec))
                            using (OleDbDataReader Reader = CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DetailGridView.Rows.Add(Reader["ID"].ToString(), Reader["P_Num"].ToString(), Reader["Tarikh"].ToString());
                                }
                            }

                            PersianDate.AddDay(1);
                        }

                        for (i = 0; i <= DetailGridView.RowCount - 1; i++)
                        {
                            using (OleDbCommand CMD = new OleDbCommand("UPDATE JayGozin SET Vis=False WHERE ID=" + DetailGridView.Rows[i].Cells[0].Value.ToString(), StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }
                    }


                    Enabled = true;
                    wait.Close();
                }
                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void SeirRadio_CheckedChanged(object sender, EventArgs e)
        {

            R9Check.Checked = false;
            R12Check.Checked = false;

            if (LocalCombo.SelectedIndex < 3)
            {
                R9Check.Checked = true;
                R9Check.Visible = true;

                LabelSobh.Text = "صبح";
                LabelAsr.Text = "عصر";
                LabelSobh5.Text = "صبح";
                LabelAsr5.Text = "عصر";
                LabelSobhF.Text = "صبح";
                LabelAsrF.Text = "عصر";
            }
            else
            {

                R12Check.Checked = true;
                R9Check.Visible = false;

                LabelSobh.Text = "روز";
                LabelAsr.Text = "شب";
                LabelSobh5.Text = "روز";
                LabelAsr5.Text = "شب";
                LabelSobhF.Text = "روز";
                LabelAsrF.Text = "شب";
            }

            ShowGridView.Rows.Clear();
            SobhBox.Text = "0";
            AsrBox.Text = "0";
            Sobh5Box.Text = "0";
            Asr5Box.Text = "0";
            SobhFBox.Text = "0";
            AsrFBox.Text = "0";

            Label8.Text = "تعداد درخواست " + LocalCombo.SelectedItem;
            Label9.Text = "تعداد خالی " + LocalCombo.SelectedItem;
        }

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

                SaveFileDialog1.Filter = "Excel Files|*.xlsx|Excel Files 97-2003|*.xls";
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();

                        DataTable Dt = new DataTable();
                        foreach (DataGridViewColumn Column in ShowGridView.Columns)
                        {
                            Dt.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in ShowGridView.Rows)
                        {
                            Dt.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt.Rows[Dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }
                        using (XLWorkbook Wb = new XLWorkbook())
                        {
                            Wb.RightToLeft = true;
                            Wb.Style.Alignment.Horizontal = (XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            Wb.AddWorksheet(Dt, "Sheet1").AsRange();
                            Wb.SaveAs(SaveFileDialog1.FileName);
                        }


                        wait.Close();
                    }
                    MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
                SaveFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
            StartCalendar.Text = "";
            EndCalendar.Text = "";
            if (MonthCombo.SelectedIndex >= 0)
            {
                Taghvim PersianDate = new Taghvim();
                PersianDate.AddMonth(MonthCombo.SelectedIndex);
                StartCalendar.Text = PersianDate.FirstOfThisMonth() + "";
                EndCalendar.Text = PersianDate.EndOfThisMonth();
            }
        }

        public void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthCombo.SelectedIndex = -1;
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            R9Check.Checked = false;
            R12Check.Checked = false;

            if (LocalCombo.SelectedIndex < 3)
            {
                R9Check.Checked = true;
                R9Check.Visible = true;

                LabelSobh.Text = "صبح";
                LabelAsr.Text = "عصر";
                LabelSobh5.Text = "صبح";
                LabelAsr5.Text = "عصر";
                LabelSobhF.Text = "صبح";
                LabelAsrF.Text = "عصر";

            }
            else
            {
                R12Check.Checked = true;
                R9Check.Visible = false;

                LabelSobh.Text = "روز";
                LabelAsr.Text = "شب";
                LabelSobh5.Text = "روز";
                LabelAsr5.Text = "شب";
                LabelSobhF.Text = "روز";
                LabelAsrF.Text = "شب";
            }

            ShowGridView.Rows.Clear();
            SobhBox.Text = "0";
            AsrBox.Text = "0";
            Sobh5Box.Text = "0";
            Asr5Box.Text = "0";
            SobhFBox.Text = "0";
            AsrFBox.Text = "0";

            Label8.Text = "تعداد درخواست " + LocalCombo.SelectedItem;
            Label9.Text = "تعداد خالی " + LocalCombo.SelectedItem;
            AllCounBox.Text = "0";
            Loc1CouBox.Text = "0";
            EmptLoc1Box.Text = "0";
        }

        //----------------------- انتخاب فایل‌های اکسل -----------------------
        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog() { Filter = "Excel Worksheets|*.xls;*.xlsx" };
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    FileNameBox.Text = dlg.FileName;
                    ShowGridView.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        //----------------------- تابع اصلی تحلیل فایل‌ها -----------------------
        private void AnalysButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();

                if (string.IsNullOrEmpty(FileNameBox.Text))
                {
                    ErrorShow(FileNameBox, "فایل کشیک را انتخاب کنید");
                    return;
                }

                Enabled = false;

                //Load Excel files into DataSet
                DataSet DtSet = new DataSet();
                string excelFiles = FileNameBox.Text;
                using (OleDbConnection ExcelConnection = new OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0; Data Source='" + excelFiles + "'; Extended Properties=Excel 8.0"))
                using (OleDbDataAdapter MyCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", ExcelConnection))
                {
                    ExcelConnection.Open();
                    MyCommand.TableMappings.Add("Table", "Line5");
                    MyCommand.Fill(DtSet);
                    ExcelConnection.Close();
                }


                for (int i = 0; i < DtSet.Tables[0].Rows.Count; i++)
                {
                    ShowGridView.Rows.Add(i + 1, DtSet.Tables[0].Rows[i][1], DtSet.Tables[0].Rows[i][2], DtSet.Tables[0].Rows[i][3], DtSet.Tables[0].Rows[i][4], DtSet.Tables[0].Rows[i][5], DtSet.Tables[0].Rows[i][6], DtSet.Tables[0].Rows[i][7], DtSet.Tables[0].Rows[i][8], 1);
                }
                Enabled = true;
            }
            catch (Exception ex)
            {
                Enabled = true;
                MessageBoxFa.Show("خطا در تحلیل فایل‌ها: " + ex.Message, "خطا", MessageBoxIcon.Error);
            }
        }
    }
}
