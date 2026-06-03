using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class DailyLeaveEditForm
    {
        public DailyLeaveEditForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PNum;
        private string PTime;
        private string PPost;
        private string ShName;
        private string SL;
        private string JPName;
        private string JPNum;
        //private string JPTime;
        //private string JPPost;
        //private string JShName;
        //private string Btm;
        private string JPName1;
        private string JPNum1;
        private string MorKind;
        private int ID;
        //private readonly string WD;
        //private readonly int FID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            ReleaseBox.Text="";
            ReleaseNameButton.Image=Properties.Resources.user;
            RegButton.Enabled=false;
            DeleButton.Enabled=false;
            ShiftNameLabel.Text="";

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PName=PersonalSelectForm.PName + " " + PersonalSelectForm.PFamily;
                PNum=PersonalSelectForm.PNum;
                PTime=PersonalSelectForm.PTime;
                PPost=PersonalSelectForm.PPost;
                ShName=PersonalSelectForm.PShift;
                SL=PersonalSelectForm.PLocal;
                NameBox.Text=PName;
                NameButton.Image=Properties.Resources.cancel1;
            }
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            KindCombo.SelectedIndex=-1;
            Panel2.Enabled=false;
            ReleaseBox.Enabled=false;
            ReleaseNameButton.Enabled=false;
            DeleButton.Enabled=false;
            RegButton.Enabled=false;
            ShiftNameLabel.Text="";
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Panel2.Enabled=false;
                ReleaseBox.Enabled=false;
                ReleaseNameButton.Enabled=false;
                DeleButton.Enabled=false;
                RegButton.Enabled=false;
                ShiftNameLabel.Text="";
                JPName1="";
                JPNum1="";

                DateTime SelectDate=ShamsiToMiladi(PersianCalendar.Text);
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پرسنل را انتخاب کنید");
                }
                //else if (SelectDate == null)
                //{
                //    ErrorShow(PersianCalendar, "تاریخ را انتخاب کنید");
                //}
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Morakhasi WHERE P_Num='{PNum}' AND Tarikh='{PersianCalendar.Text}' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ID=Convert.ToInt32(Reader["ID"]);
                                ShiftNameLabel.Text=Reader["P_Shift"].ToString();
                                MorKind=Reader["Kind"].ToString();
                                KindCombo.Text=MorKind;
                                if (SelectDate <= DateTime.Today)
                                {
                                    if (Reader["J_Num"].ToString() != "")
                                    {
                                        //ReleaseBox.Enabled=True   ' عدم ثبت توسط مسئولین
                                        //ReleaseNameButton.Enabled=True
                                        JPNum1=Reader["J_Num"].ToString();
                                    }
                                    RegButton.Enabled=true;
                                    Panel2.Enabled=true;
                                    ReleaseNameButton.Enabled=true;
                                }
                                DeleButton.Enabled=true;
                            }
                        }

                        if (DeleButton.Enabled)
                        {
                            ShiftNameLabel.Text=PTime;
                            string ShiftName="Sobh";

                            using (OleDbCommand CMD=new OleDbCommand($"SELECT Asr, Sobh FROM Taghvim WHERE Tarikh='{PersianCalendar.Text}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (Reader["Asr"].ToString() == ShName)
                                    {
                                        ShiftName="Asr";
                                    }
                                    else if (Reader["Sobh"].ToString() == ShName)
                                    {
                                        ShiftName="Sobh";
                                    }
                                }
                            }

                            if (PTime == "9 ساعته")
                            {
                                if (ShiftName == "Sobh")
                                {
                                    ShiftNameLabel.Text += " صبح";
                                }
                                else
                                {
                                    ShiftNameLabel.Text += " عصر";
                                }
                            }
                            else if (PTime == "12 ساعته")
                            {
                                if (ShiftName == "Sobh")
                                {
                                    ShiftNameLabel.Text += " روز";
                                }
                                else
                                {
                                    ShiftNameLabel.Text += " شب";
                                }
                            }
                        }
                    }


                    if (!string.IsNullOrEmpty(JPNum1))
                    {
                        if (JPNum1 == "بی جایگزین")
                        {
                            ReleaseBox.Text="بی جایگزین";
                            JPNum="بی جایگزین";
                        }

                        DataRow[] DRow=MainForm.PersonTable.Select($"P_Num='{JPNum1}'");
                        JPName1=DRow[0]["Fname"] + " " + DRow[0]["Family"];
                        ReleaseBox.Text=JPName1;
                    }

                    if (!DeleButton.Enabled)
                    {
                        MessageBoxFa.Show(" داده ای یافت نشد ", "خطا", MessageBoxIcon.Warning);
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

        public void ReleaseNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                JPName="";
                JPNum="";
                //JPTime="";
                //JPPost="";
                //JShName="";
                ReleaseBox.Text="";
                ReleaseNameButton.Image=Properties.Resources.user;

                if (Convert.ToBoolean(PPost.IndexOf("راهبر") + 1))
                {
                    PersonalSelectForm.Per="راهبر";
                }
                else
                {
                    PersonalSelectForm.Per=PPost;
                }

                PersonalSelectForm ShowForm=new PersonalSelectForm();
                if (ShowForm.ShowDialog() == DialogResult.OK)
                {
                    JPName=PersonalSelectForm.PName + " " + PersonalSelectForm.PFamily;
                    JPNum=PersonalSelectForm.PNum;
                    //JPTime=PersonalSelectForm.PTime;
                    //JPPost=PersonalSelectForm.PPost;
                    //JShName=PersonalSelectForm.PShift;
                    ReleaseBox.Text=JPName;
                    ReleaseNameButton.Image=Properties.Resources.cancel1;
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
                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(NameBox, "نوع مرخصی را انتخاب کنید");
                }
                else
                {
                    if (ReleaseBox.Text == "" || ReleaseBox.Text == "بی جایگزین")
                    {
                        if (MessageBoxFa.Show("مرخصی بدون جایگزین ثبت شود؟", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            ErrorShow(ReleaseNameButton, "جایگرین مرخصی را انتخاب کنید");
                            return;
                        }
                    }
                    else
                    {
                        DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + JPNum + "'");
                        if (!(bool)DRow[0]["Vis"] || !(bool)DRow[0]["OverTime"])
                        {
                            ErrorShow(ReleaseBox, ReleaseBox.Text + " مجاز به اضافه کار نیست");
                            return;
                        }
                    }

                    string KasStr="";
                    Taghvim PersianDate=new Taghvim(PersianCalendar.Text);
                    bool Change=false;
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        if (JPNum != JPNum1)
                        {
                            KasStr="";
                            if (PPost == "راهبر قطار")
                            {
                                switch (ShiftNameLabel.Text)
                                {
                                    case "12 ساعته روز":
                                        if (PersianDate.DayWeek() == "جمعه")
                                        {
                                            KasStr="13:00";
                                        }
                                        else
                                        {
                                            KasStr="19:30";
                                        }

                                        break;
                                    case "12 ساعته شب":
                                        KasStr="04:00";
                                        break;
                                    case "9 ساعته عصر":
                                        KasStr="13:00";
                                        break;
                                    case "9 ساعته صبح":
                                        KasStr="13:00";
                                        break;
                                    case "ستادی":
                                        KasStr="13:00";
                                        break;
                                    default:
                                        KasStr="12:00";
                                        break;
                                }
                            }
                            else
                            {
                                switch (ShiftNameLabel.Text)
                                {
                                    case "12 ساعته روز":
                                        KasStr="12:00";
                                        break;
                                    case "12 ساعته شب":
                                        KasStr="03:00";
                                        break;
                                }
                            }

                            // حذف اضافه کار جایگزین
                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE Ezafeh SET Vis=False WHERE P_Num='{JPNum1}' AND Tarikh='{PersianCalendar.Text}' AND E_Time='{KasStr}'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            if (ShiftNameLabel.Text == "12 ساعته شب")
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE Ezafeh SET Vis=False WHERE P_Num='{JPNum1}' AND Tarikh='{PersianDate.AddDay(1)}' AND E_Time='09:00'", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }

                            if (int.TryParse(JPNum, out _))
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE Morakhasi SET J_Num='{JPNum}' WHERE ID={ID}", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE Morakhasi SET J_Num='بی جایگزین' WHERE ID={ID}", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }

                            if (ReleaseBox.Text != "") // ثبت اضافه کار جایگزین
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, U_Reg, E_Time, E_Kind, E_Mem, T_Reg, Vis) VALUES ('{JPNum}','{PersianCalendar.Text}', '{AppState.UserName}', '{KasStr}', 'جایگزین مرخصی روزانه','({NameBox.Text})', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                                if (ShiftNameLabel.Text == "12 ساعته شب")
                                {
                                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, U_Reg, E_Time, E_Kind, E_Mem, T_Reg, Vis) VALUES ('{JPNum}', '{PersianDate.AddDay(1)}', '{AppState.UserName}', '09:00', 'جایگزین مرخصی روزانه','({NameBox.Text})', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }

                            //If IsNumeric(JPNum) Then OptimizationForm.TotaEzafe(JPNum, PersianCalendar.Text)  ' محاسبات قدیم
                            //If IsNumeric(JPNum1) Then OptimizationForm.TotaEzafe(JPNum1, PersianCalendar.Text)
                            Change=true;
                        }

                        if (KindCombo.Text != MorKind && KindCombo.SelectedIndex >= 0)
                        {
                            if (KindCombo.Text != MorKind)
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE Morakhasi SET Vis=False WHERE ID={ID}", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Morakhasi (P_NUM, Tarikh, Kind, U_Reg, T_Reg, Vis, Fad) VALUES ('{PNum}', '{PersianCalendar.Text}', '{KindCombo.Text}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True, {ID})", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            Change=true;
                        }

                        using (OptimizationForm optform=new OptimizationForm())
                        {
                            optform.PersoOptim(PNum, MainForm.PersianToday.Tarikh(), StrConnec);
                            if (!string.IsNullOrEmpty(JPNum))
                            {
                                optform.PersoOptim(JPNum, MainForm.PersianToday.Tarikh(), StrConnec);
                            }
                            if (!string.IsNullOrEmpty(JPNum1))
                            {
                                optform.PersoOptim(JPNum1, MainForm.PersianToday.Tarikh(), StrConnec);
                            }
                        }
                    }


                    if (Change)
                    {
                        NameBox.Text="";
                        ReleaseBox.Text="";
                        ShiftNameLabel.Text="";
                        KindCombo.Text="";
                        Panel2.Enabled=false;
                        RegButton.Enabled=false;
                        DeleButton.Enabled=false;
                        MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxFa.Show(" هیچ کدام از گزینه ها تغییر نکرده است ", "خطا", MessageBoxIcon.Error);
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

        public void DeleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show(" آیا مرخصی حذف شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {


                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        if (PersianCalendar.Miladi.Date <= DateTime.Today)
                        {
                            if (PPost == "راهبر قطار")
                            {
                                bool Pross=false;
                                using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM DailyProcess WHERE Tarikh='{PersianCalendar.Text}' AND Vis=True", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    if (Reader.Read())
                                    {
                                        Pross=true;
                                    }
                                }

                                if (Pross)
                                {
                                    string ShiftName="";
                                    string ShiftTime="";
                                    ShiftName="";
                                    ShiftTime="";
                                    switch (ShiftNameLabel.Text)
                                    {
                                        case "12 ساعته روز":
                                            ShiftName="روز";
                                            ShiftTime="12 ساعته";
                                            break;
                                        case "12 ساعته شب":
                                            ShiftName="شب";
                                            ShiftTime="12 ساعته";
                                            break;
                                        case "9 ساعته صبح":
                                            ShiftName="صبح";
                                            ShiftTime="9 ساعته";
                                            break;
                                        case "9 ساعته عصر":
                                            ShiftName="عصر";
                                            ShiftTime="9 ساعته";
                                            break;
                                    }

                                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Rezerv (P_NUM, Tarikh, U_Reg, R_Shift, Loca, Mem, Vis) VALUES ('{PNum}', '{PersianCalendar.Text}', '{AppState.UserName}', '{ShiftName}', '{SL}', 'حذف مرخصی {ShiftTime}', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }

                                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Amal (P_NUM, Tarikh, T_Reg, OnvAmal, U_Reg, Amal, Vis, Fad) VALUES ('{PNum}', '{PersianCalendar.Text}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', 'منفی', '{AppState.UserName}', 'حذف مرخصی بعد از پردازش لوحه', False, 0)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }
                            else
                            {
                                string KasSt="";
                                switch (ShiftNameLabel.Text)
                                {
                                    case "12 ساعته روز":
                                        KasSt="12:00";
                                        break;
                                    case "12 ساعته شب":
                                        KasSt="03:00";
                                        break;
                                    case "9 ساعته عصر":
                                        KasSt="11:00";
                                        break;
                                    case "9 ساعته صبح":
                                        KasSt="11:00";
                                        break;
                                    case "ستادی":
                                        KasSt="11:00";
                                        break;
                                }

                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE Ezafeh SET Vis=False WHERE P_Num='{JPNum1}' AND Tarikh='{PersianCalendar.Text}' AND E_Time='{KasSt}'", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }


                                if (ShiftNameLabel.Text == "12 ساعته شب")
                                {
                                    Taghvim PersianDate=new Taghvim(DateTime.Today);
                                    using (OleDbCommand CMD=new OleDbCommand($"UPDATE Ezafeh SET Vis=False WHERE P_Num='{JPNum1}' AND Tarikh='{PersianDate.AddDay(1)}' AND E_Time='09:00'", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        using (OleDbCommand CMD=new OleDbCommand($"UPDATE Morakhasi SET Vis=False WHERE ID={ID}", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Morakhasi (P_NUM, Tarikh, Kind, U_Reg, T_Reg, Vis, Fad) VALUES ('{PNum}', '{PersianCalendar.Text}', '{KindCombo.Text}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', False, -{ID})", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OptimizationForm optform=new OptimizationForm())
                        {
                            optform.PersoOptim(PNum, MainForm.PersianToday.Tarikh(), StrConnec);
                            if (!string.IsNullOrEmpty(JPNum1))
                            {
                                optform.PersoOptim(JPNum1, MainForm.PersianToday.Tarikh(), StrConnec);
                            }
                        }
                    }


                    NameBox.Text="";
                    ReleaseBox.Text="";
                    ShiftNameLabel.Text="";
                    Panel2.Enabled=false;
                    RegButton.Enabled=false;
                    DeleButton.Enabled=false;
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

        public void DailyLeaveEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0102");
        }

        public void Form35_Load(object sender, EventArgs e)
        {
            try
            {
                RegButton.Enabled=false;
                DeleButton.Enabled=false;
                Panel2.Enabled=false;
                PersianCalendar.Today_Click(null, null);

                KindCombo.Items.Add("استحقاقی");
                KindCombo.Items.Add("استعلاجی");
                KindCombo.Items.Add("غیبت");
                if (AppState.UserLevel < 5)
                {
                    KindCombo.Items.Add("ماموریت");
                }

                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum=AppState.UserPnum;
                    PName=AppState.UserName;
                    PTime=AppState.UserTime;
                    PPost=AppState.UserPost;
                    ShName=AppState.UserShift;
                    NameBox.Text=AppState.UserName;

                    NameButton.Enabled=false;
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
    }
}
