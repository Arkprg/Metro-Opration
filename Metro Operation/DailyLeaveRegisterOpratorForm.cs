using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class DailyLeaveRegisterOpratorForm
    {
        public DailyLeaveRegisterOpratorForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PNum;
        private string PTime;
        private string PPost;
        private string ShName;
        private string ShLocal;
        private int Mon;
        private readonly Taghvim PersianDate=new Taghvim();
        private readonly List<string> SelectedDates=new List<string>(); // ذخیره‌ی تاریخ‌های 10 رقمی

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private void Clear()
        {
            RegButton.Enabled=false;
            DateGridView.Rows.Clear();
            PName="";
            PNum="";
            PTime="";
            PPost="";
            ShName="";
            ShLocal="";
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            Mon=0;
            PersianDate.SetDate(MainForm.PersianToday.Tarikh());
            SelectedDates.Clear();
            Height=370;
        }

        private bool ProcessCheck(string DayProcess, string Local, OleDbConnection StrConnec)
        {
            bool Process=false;

            using (OleDbCommand CMD=new OleDbCommand("SELECT U_Reg, P_Mod, Mem FROM DailyProcess WHERE Tarikh='" + DayProcess + "' AND L_Num='" + Local + "' AND Vis=True", StrConnec))
            using (OleDbDataReader Reader=CMD.ExecuteReader())
            {
                if (Reader.Read())
                {
                    Process=true;
                }
            }

            return Process;
        }

        private void Fill()
        {
            try
            {
                DateGridView.Rows.Clear();
                PersianDate.SetDate(DateTime.Today);
                PersianDate.AddMonth(Mon);
                MonthLabel.Text=PersianDate.MonthName() + " " + PersianDate.Year();
                DateLabel.Text="";
                DayLabel.Text="";

                DateGridView.RowTemplate.Height=35;
                DateGridView.Rows.Add();
                int i;
                int j=1;
                int w=0;
                int MonDay=0;

                if (Mon < 0)
                {
                    MonDay=PersianDate.DaysInThisMonth();
                    NextMonButton.Enabled=true;
                    RevMonButton.Enabled=false;

                }
                else if (Mon == 0)
                {
                    if (PersianDate.Day() < 8)
                    {
                        MonDay=PersianDate.DaysInThisMonth();
                        NextMonButton.Enabled=false;
                        RevMonButton.Enabled=true;
                    }
                    else if (0 < PersianDate.DaysInThisMonth() - (PersianDate.Day() + 20))
                    {
                        MonDay=PersianDate.Day() + 20;
                        NextMonButton.Enabled=false;
                        RevMonButton.Enabled=false;
                    }
                    else
                    {
                        MonDay=PersianDate.DaysInThisMonth();
                        NextMonButton.Enabled=true;
                        RevMonButton.Enabled=false;
                    }
                }
                else
                {
                    MonDay=PersianDate.Day() + 20 - PersianDate.DaysInThisMonth();
                    NextMonButton.Enabled=false;
                    RevMonButton.Enabled=true;
                }

                for (i=PersianDate.FisrtDayInMonth(); i <= 6; i++)
                {
                    DateGridView.Rows[0].Cells[i].Value=j.ToString("00");
                    j++;
                }

                j=0;
                w=1;
                DateGridView.Rows.Add();
                for (i=8 - PersianDate.FisrtDayInMonth(); i <= PersianDate.DaysInThisMonth(); i++)
                {
                    if (j == 7)
                    {
                        DateGridView.Rows.Add();
                        j=0;
                        w++;
                    }
                    DateGridView.Rows[w].Cells[j].Value=i.ToString("00");

                    if (i > MonDay)
                    {
                        DateGridView.Rows[w].Cells[j].Style.BackColor=Color.FromArgb(220, 220, 220);//i <= PersianDate.Day Or  
                    }

                    j++;
                }

                DateGridView.CurrentCell.Selected=false;

                Dictionary<string, DataRow> map=new Dictionary<string, DataRow>();
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand cmd=new OleDbCommand($"SELECT Tarikh, Rooz, Holi, Sobh, Asr FROM Taghvim WHERE Tarikh LIKE '{ PersianDate.Year() }/{ PersianDate.Month():00}%'", StrConnec))
                    using (OleDbDataAdapter da=new OleDbDataAdapter(cmd))
                    {
                        DataTable dt=new DataTable();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            string tar=row["Tarikh"].ToString();
                            map[tar]=row;
                        }
                    }
                }

                for (i=0; i <= DateGridView.RowCount - 1; i++)
                {
                    for (j=0; j <= 6; j++)
                    {
                        if ((DateGridView.Rows[i].Cells[j].Style.BackColor.Name == "0" || DateGridView.Rows[i].Cells[j].Style.BackColor == Color.White) && Convert.ToInt32(DateGridView.Rows[i].Cells[j].Value) != 0)
                        {

                            string tarikh=PersianDate.Tarikh().Substring(0, 8) + DateGridView.Rows[i].Cells[j].Value;
                            if (map.TryGetValue(tarikh, out DataRow row))
                            {
                                string rooz=row["Rooz"]?.ToString() ?? "";
                                bool holi=false;
                                if (row["Holi"] != DBNull.Value)
                                {
                                    bool.TryParse(row["Holi"].ToString(), out holi);
                                }

                                string sobh=row["Sobh"]?.ToString() ?? "";
                                string asr=row["Asr"]?.ToString() ?? "";

                                if (PTime == "ستادی")
                                {
                                    if (rooz == "6" || rooz == "7" || holi)
                                    {
                                        DateGridView.Rows[i].Cells[j].Style.BackColor=Color.FromArgb(255, 100, 100);
                                    }
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(sobh) && sobh == ShName)
                                    {
                                        DateGridView.Rows[i].Cells[j].Style.ForeColor=Color.DarkOrange;
                                    }
                                    else if (!string.IsNullOrEmpty(asr) && asr == ShName)
                                    {
                                        DateGridView.Rows[i].Cells[j].Style.ForeColor=Color.Blue;
                                    }
                                    else
                                    {
                                        DateGridView.Rows[i].Cells[j].Style.BackColor=Color.FromArgb(255, 100, 100);
                                    }
                                }
                            }
                            if (SelectedDates.IndexOf(tarikh) >= 0)
                            {
                                DateGridView.Rows[i].Cells[j].Style.BackColor=Color.Lime;
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

        public bool ProcessChecker(string Tarikh)
        {
            bool Reslt=true;
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM DailyProcess WHERE Tarikh='" + Tarikh + "' AND L_Num='" + AppState.UserLnum + "' AND Vis=True", StrConnec))
                using (OleDbDataReader Reader=CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Reslt=false;
                    }
                }
            }

            return Reslt;
        }

        public bool LeaveChecker(string Tarikh, OleDbConnection StrConnec)
        {
            using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Morakhasi WHERE Tarikh='" + Tarikh + "' AND P_Num='" + PNum + "' AND Vis=True", StrConnec))
            using (OleDbDataReader Reader=CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    return false;
                }
            }

            return true;
        }

        public int LeaveCounter(string Tarikh, OleDbConnection StrConnec)
        {
            int i=0;
            using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(Person.Family) AS Cou FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.P_Post='راهبر قطار' AND Person.Trip=True AND Person.Shift_name='" + ShName + "' AND Person.Shift_Loc ='" + ShLocal + "' AND Person.Vis=True AND Person.Shift_Time='" + PTime + "' And Person.Line_Num='" + AppState.UserLnum + "' AND Morakhasi.Vis=True AND Morakhasi.Tarikh='" + Tarikh + "'", StrConnec))
            using (OleDbDataReader Reader=CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    i=Convert.ToInt32(Reader["Cou"]);
                }
            }

            return i;
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PersonalSelectForm ShowForm=new PersonalSelectForm();
                if (ShowForm.ShowDialog() == DialogResult.OK)
                {
                    PName=PersonalSelectForm.PName + " " + PersonalSelectForm.PFamily;
                    PNum=PersonalSelectForm.PNum;
                    PTime=PersonalSelectForm.PTime;
                    PPost=PersonalSelectForm.PPost;
                    ShName=PersonalSelectForm.PShift;
                    ShLocal=PersonalSelectForm.PLocal;
                    NameBox.Text=PName;
                    NameButton.Image=Properties.Resources.cancel1;
                    Mon=0;
                    Fill();
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DailyLeaveRegisterOpratortForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "010101");
        }

        public void DailyLeaveRegisterOpratorForm_Load(object sender, EventArgs e)
        {
            try
            {
                Height=370;

                Mor12Sobh.Text="";
                Mor12Asr.Text="";
                Mor9Sobh.Text="";
                Mor9Asr.Text="";
                Req12Asr.Text="";
                Req12Sobh.Text="";
                Req9Asr.Text="";
                Req9Sobh.Text="";

                Label01.BackColor=Color.Silver;
                Label02.BackColor=Color.Lime;
                Label03.ForeColor=Color.DarkOrange;
                Label04.ForeColor=Color.Blue;
                Label05.BackColor=Color.FromArgb(255, 100, 100);


                NextMonButton.Enabled=false;
                RevMonButton.Enabled=false;
                MonthLabel.Text=PersianDate.MonthName() + " " + PersianDate.Year();
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum=AppState.UserPnum;
                    PName=AppState.UserName;
                    PTime=AppState.UserTime;
                    PPost=AppState.UserPost;
                    ShName=AppState.UserShift;
                    NameBox.Text=AppState.UserName;
                    NameButton.Enabled=false;

                    Mon=0;
                    Fill();
                }

                KindCombo.Items.Add("استحقاقی");
                KindCombo.Items.Add("استعلاجی");
                KindCombo.Items.Add("غیبت");

                if (AppState.UserLevel < 5)
                {
                    KindCombo.Items.Add("ماموریت");
                }

                KindCombo.SelectedIndex=0;
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
            try //' **** بررسی مجدد
            {
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پرسنل را مشخص کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع مرخصی را تعیین کنید");
                }
                else
                {
                    Enabled=false;

                    string DaysOK="";
                    string DaysNot="";
                    SelectedDates.Sort();

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        for (int i=SelectedDates.Count - 1; i >= 0; i--)
                        {
                            string day=SelectedDates[i];
                            if (!LeaveChecker(day, StrConnec))
                            {
                                DaysNot += day.Substring(5, 5) + " - ";
                                SelectedDates.Remove(day);
                            }
                            else
                            {
                                DaysOK += day.Substring(5, 5) + " - ";
                            }
                        }
                    }

                    if (DaysNot.Length > 3)
                    {
                        DaysNot=DaysNot.Substring(0, DaysNot.Length - 3);
                        MessageBoxFa.Show(" برای " + DaysNot + " قبلا مرخصی ثبت شده است ", "خطا", MessageBoxIcon.Error);
                    }

                    if (DaysOK.Length > 3)
                    {
                        DaysOK=DaysOK.Substring(0, DaysOK.Length - 3);

                        if (MessageBoxFa.Show($"{SelectedDates.Count } روز مرخصی قابل ثبت است \n\n {DaysOK}\n\n آیا { SelectedDates.Count } روز را تایید می کنید؟", "تایید مرخصی", MessageBoxIcon.Information, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();

                                // for (i=0; i <= RegDay - 1; i++)
                                foreach (string day in SelectedDates)
                                {
                                    //PersianDate.SetDate(PersianDate.Tarikh().Substring(0, 5) + DaysDate.Substring(0, 5));
                                    using (OleDbCommand CMD=new OleDbCommand($"UPDATE Rezerv SET Mem=Mem + ' - مرخصی روزانه' , Vis=False WHERE P_NUM='{PNum}' AND Tarikh='{day}'", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }

                                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Morakhasi (P_NUM, Tarikh, Kind, U_Reg, T_Reg, Vis) VALUES ('{PNum }', '{day}', '{KindCombo.Text}', '{ AppState.UserName }', '{ MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") }', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }


                                    // if (PersianDate.Miladi() <= MainForm.PersianToday.Miladi())
                                    if (ProcessCheck(PersianDate.Tarikh(), ShLocal, StrConnec))
                                    {
                                        if (PersianDate.Miladi() > MainForm.PersianToday.Miladi())
                                        {
                                            MessageBoxFa.Show($"برای تاریخ {PersianDate.Tarikh()} پردازش انجام شده است.", "توجه", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                                        }

                                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Amal (P_NUM, Tarikh, T_Reg, OnvAmal, U_Reg, Amal, Vis, Fad) VALUES ('{ PNum }', '{ PersianDate.Tarikh() }', '{ MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") }', 'منفی', '{AppState.UserName }', 'ثبت مرخصی بعد از پردازش لوحه', False, 0)", StrConnec))
                                        {
                                            CMD.ExecuteNonQuery();
                                        }
                                    }
                                }

                                Taghvim tgv=new Taghvim(MainForm.PersianToday.Tarikh());
                                tgv.AddDay(1);
                                OptimizationForm opt=new OptimizationForm();
                                opt.PersoOptim(PNum, tgv.Tarikh(), StrConnec);
                            }

                            Clear();
                            MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBoxFa.Show(" ثبت مرخصی توسط شما لغو گردید ", "خطا", MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        RegButton.Enabled=false;
                        MessageBoxFa.Show(" هیچ روزی انتخاب نشده است ", "خطا", MessageBoxIcon.Error);
                    }

                    Enabled=true;
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

        private void Button5_Click(object sender, EventArgs e)
        {
            HelpForm ShowForm=new HelpForm();
            ShowForm.WebBrowser1.Navigate(MainForm.Path + "\\Help\\Hlp26.mht");
            ShowForm.ShowDialog();
        }

        public void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mor12Sobh.Text="";
                Mor12Asr.Text="";
                Mor9Sobh.Text="";
                Mor9Asr.Text="";
                Req12Asr.Text="";
                Req12Sobh.Text="";
                Req9Asr.Text="";
                Req9Sobh.Text="";

                string Tarikh="";
                Tarikh=PersianDate.Tarikh().Substring(0, 8) + DateGridView.CurrentCell.Value.ToString();
                DateLabel.Text=Tarikh;
                LocalLabel.Text=ShLocal;
                DayLabel.Text=DateGridView.Columns[DateGridView.CurrentCell.ColumnIndex].HeaderText;

                if ((DateGridView.CurrentCell.Style.BackColor.Name == "0" || DateGridView.CurrentCell.Style.BackColor == Color.White) && int.TryParse(DateGridView.CurrentCell.Value.ToString(), out _))
                {
                    DateGridView.CurrentCell.Style.BackColor=Color.Lime;
                    SelectedDates.Add(Tarikh);
                    if (e.RowIndex >= 0 && ConvertClass.ShamsiToMiladi(Tarikh) > DateTime.Today && PPost == "راهبر قطار")
                    {
                        if (!ProcessChecker(Tarikh))
                        {
                            MessageBoxFa.Show(" برای تاریخ " + Tarikh + " پردازش لوحه انجام شده است ", "خطا", MessageBoxIcon.Error);
                        }
                        else
                        {
                            int Mor9S=0;
                            int Mor9A=0;
                            int Mor12R=0;
                            int Mor12Sh=0;
                            int Jay9S=0;
                            int Jay9A=0;
                            int Jay12R=0;
                            int Jay12SH=0;
                            string ShiftAsr; //ShiftSobh,

                            ShiftAsr="";

                            Height=540;
                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();

                                using (OleDbCommand CMD=new OleDbCommand("SELECT Asr FROM Taghvim WHERE Tarikh='" + Tarikh + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    if (Reader.Read())
                                    {
                                        //ShiftSobh=Reader.Item("Sobh").ToString
                                        ShiftAsr=Reader["Asr"].ToString();
                                    }
                                }

                                using (OleDbCommand CMD=new OleDbCommand("SELECT Person.P_Num, Person.Shift_Loc, Person.Shift_Time, Person.Shift_Time, Person.Shift_name FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh='" + Tarikh + "' AND Person.Shift_Loc ='" + ShLocal + "' AND Person.P_Post='" + PPost + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
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

                                using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, JayGozin.Olv1, JayGozin.Olv2, JayGozin.Olv3, JayGozin.Olv4 FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE JayGozin.Vis=True AND JayGozin.Tarikh='" + Tarikh + "' AND JayGozin.Shift_Loc='" + ShLocal + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
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
                                                Jay12SH++;
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
                                                Jay12SH++;
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
                                                Jay12SH++;
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
                                                Jay12SH++;
                                                break;
                                        }
                                    }
                                }
                            }

                            Mor12Sobh.Text=Mor12R.ToString() + " نفر";
                            Mor9Sobh.Text=Mor9S.ToString() + " نفر";
                            Mor12Asr.Text=Mor12Sh.ToString() + " نفر";
                            Mor9Asr.Text=Mor9A.ToString() + " نفر";
                            Req12Sobh.Text=Jay12R.ToString() + " عنوان";
                            Req12Asr.Text=Jay12SH.ToString() + " عنوان";
                            Req9Sobh.Text=Jay9S.ToString() + " عنوان";
                            Req9Asr.Text=Jay9A.ToString() + " عنوان";
                        }
                    }
                }
                else
                {
                    if (DateGridView.CurrentCell.Style.BackColor == Color.Lime)
                    {
                        DateGridView.CurrentCell.Style.BackColor=Color.White;
                        SelectedDates.Remove(Tarikh);
                    }
                }

                if (SelectedDates.Count > 0)
                {
                    RegButton.Enabled=true;
                }
                else
                {
                    RegButton.Enabled=false;
                }

                DateGridView.CurrentCell.Selected=false;
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateGridView.Sort(DateGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        public void NextMonButton_Click(object sender, EventArgs e)
        {
            Mon++;
            Fill();
        }

        public void RevMonButton_Click(object sender, EventArgs e)
        {
            Mon--;
            Fill();
        }
    }
}
