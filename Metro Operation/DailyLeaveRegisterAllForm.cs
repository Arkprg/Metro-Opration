using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class DailyLeaveRegisterAllForm
    {
        public DailyLeaveRegisterAllForm()
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
        private string JPName;
        private string JPFamily;
        private string JPNum;
        //private string JPTime;
        //private string JPPost;
        private string JShName;
        //private string Btm;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void DailyLeaveRegisterAllForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "010102");
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            ReplaceBox.Text="";
            ReplaceButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                PTime=PersonalSelectForm.PTime;
                PPost=PersonalSelectForm.PPost;
                ShName=PersonalSelectForm.PShift;
                PLocal=PersonalSelectForm.PLocal;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }

            PersonPostLabel.Text="";
            ShiftLabel.Text="";
            DelayComboBox.SelectedIndex=-1;
            Panel2.Enabled=false;
            RegButton.Enabled=false;
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text).ToString();
                PersonPostLabel.Text="";
                ShiftLabel.Text="";

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پرسنل را انتخاب کنید");
                }
                //else if (SelectDate == null)
                //{
                //    ErrorShow(PersianCalendar, "تاریخ را انتخاب کنید");
                //}
                else if (!ConvertClass.DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else
                {

                    bool DaliProcess=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        if (PPost == "راهبر قطار")
                        {
                            using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM DailyProcess WHERE Tarikh='{PersianCalendar.Text}' AND L_Num='{AppState.UserLnum}' AND Vis=True", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                if (Reader.Read())
                                {
                                    DaliProcess=true;
                                }
                            }
                        }
                        else
                        {
                            DaliProcess=true;
                        }

                        PersonPostLabel.Text += PPost + " " + PTime;
                        if (ShName.Length > 0)
                        {
                            PersonPostLabel.Text += " شیفت " + ShName;
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Taghvim WHERE Tarikh='{PersianCalendar.Text}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (PTime == "9 ساعته")
                                {
                                    if (Reader["Sobh"].ToString() == ShName)
                                    {
                                        ShiftLabel.Text="شیفت صبح";
                                    }
                                    else if (Reader["Asr"].ToString() == ShName)
                                    {
                                        ShiftLabel.Text="شیفت عصر";
                                    }
                                    else
                                    {
                                        ShiftLabel.Text="روز استراحت";
                                    }
                                }
                                else if (PTime == "12 ساعته")
                                {
                                    if (Reader["Sobh"].ToString() == ShName)
                                    {
                                        ShiftLabel.Text="شیفت روز";
                                    }
                                    else if (Reader["Asr"].ToString() == ShName)
                                    {
                                        ShiftLabel.Text="شیفت شب";
                                    }
                                    else
                                    {
                                        ShiftLabel.Text="روز استراحت";
                                    }
                                }
                                else if (PTime == "ستادی")
                                {
                                    if ((string)Reader["rooz"] == "7" || (string)Reader["rooz"] == "6" || (bool)Reader["Holi"])
                                    {
                                        ShiftLabel.Text="روز تعطیل";
                                    }
                                    else
                                    {
                                        ShiftLabel.Text="روز غیر تعطیل";
                                    }
                                }
                            }
                        }
                    }


                    if (ShiftLabel.Text == "روز استراحت" || ShiftLabel.Text == "روز تعطیل")
                    {
                        ErrorShow(PersianCalendar, "در روز استراحت ثبت مرخصی مجاز نیست ");
                    }
                    else if (!DaliProcess)
                    {
                        ErrorShow(PersianCalendar, "پردازش لوحه برای این روز انجام نشده است");
                    }
                    else
                    {
                        RegButton.Enabled=true;
                        Panel2.Enabled=true;
                        if (PPost == "راهبر قطار")
                        {
                            DelayComboBox.Enabled=true;
                            ReplaceButton.Enabled=true;
                        }
                        else
                        {
                            DelayComboBox.Enabled=false;
                            ReplaceButton.Enabled=false;
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

        public void Button5_Click(object sender, EventArgs e)
        {
            ReplaceBox.Text="";
            ReplaceButton.Image=Properties.Resources.user;
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
                JPFamily=PersonalSelectForm.PFamily;
                JPName=PersonalSelectForm.PName;
                JPNum=PersonalSelectForm.PNum;
                //JPTime=PersonalSelectForm.PTime;
                //JPPost=PersonalSelectForm.PPost;
                JShName=PersonalSelectForm.PShift;
                ReplaceBox.Text=JPName + " " + JPFamily;
                ReplaceButton.Image=Properties.Resources.cancel1;
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                Taghvim PersianDate=new Taghvim(PersianCalendar.Text);

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع مرخصی را مشخص کنید");
                }
                else if (ShiftLabel.Text == "روز استراحت" || ShiftLabel.Text == "روز تعطیل")
                {
                    ErrorShow(DelayComboBox, "تاریخ درخواست مرخصی صحیح نیست");
                }
                else if (DelayComboBox.Enabled && DelayComboBox.SelectedIndex < 0)
                {
                    ErrorShow(DelayComboBox, "علت تاخیر در ثبت مرخصی را مشخص کنید");
                }
                else if (ShName == JShName)
                {
                    ErrorShow(ReplaceBox, "تعیین جایگزین هم شیفت مجاز نمی باشد");
                }
                else
                {
                    if (ReplaceButton.Enabled)
                    {
                        if (ReplaceBox.Text == "")
                        {
                            if (MessageBoxFa.Show("مرخصی بدون جایگزین ثبت شود؟", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.No)
                            {
                                ErrorShow(ReplaceBox, "جایگزین مرخصی را مشخص کنید");
                                return;
                            }
                        }
                        else
                        {
                            DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + JPNum + "'");
                            if (!(bool)DRow[0]["Vis"] || !(bool)DRow[0]["OverTime"])
                            {
                                ErrorShow(ReplaceBox, ReplaceBox.Text + " مجاز به اضافه کار نیست");
                                return;
                            }
                        }
                    }

                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Morakhasi WHERE P_Num='{PNum}' AND Tarikh='{PersianCalendar.Text}' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                Enabled=true;
                                StrConnec.Close();
                                MessageBoxFa.Show("قبلا ثبت شده است !", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string Jay="";

                        if (ShiftLabel.Text == "شیفت صبح")
                        {
                            Jay=PTime + " صبح";
                        }
                        else if (ShiftLabel.Text == "شیفت عصر")
                        {
                            Jay=PTime + " عصر";
                        }
                        else if (ShiftLabel.Text == "شیفت روز")
                        {
                            Jay=PTime + " روز";
                        }
                        else if (ShiftLabel.Text == "شیفت شب")
                        {
                            Jay=PTime + " شب";
                        }
                        else if (ShiftLabel.Text == "روز غیر تعطیل")
                        {
                            Jay=PTime;
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Morakhasi (P_NUM, Tarikh, Kind, U_Reg, T_Reg, Vis) VALUES ('{PNum}', '{PersianCalendar.Text}', '{KindCombo.Text}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        string KasStr="";

                        if (ReplaceBox.Text != "") // ثبت اضافه کار جایگزین
                        {
                            if (PPost == "راهبر قطار")
                            {
                                switch (Jay)
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
                                        if (PersianDate.DayWeek() == "پنج شنبه")
                                        {
                                            KasStr="07:00";
                                        }
                                        else
                                        {
                                            KasStr="04:00";

                                            PersianDate.AddDay(1);
                                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{JPNum}','{PersianDate.Tarikh()}', '09:00', 'جایگزین مرخصی روزانه شب قبل', '{PLocal}', '{Jay} ({NameBox.Text})', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                                            {
                                                CMD.ExecuteNonQuery();
                                            }

                                            PersianDate.AddDay(-1);
                                        }
                                        break;

                                    case "9 ساعته عصر":
                                        KasStr="13:00";
                                        break;

                                    case "9 ساعته صبح":
                                        KasStr="13:00";
                                        break;

                                    default:
                                        KasStr="13:00";
                                        break;
                                }
                            }
                            else
                            {
                                switch (Jay)
                                {
                                    case "12 ساعته روز":
                                        KasStr="13:00";
                                        break;

                                    case "12 ساعته شب":
                                        KasStr="04:00";
                                        break;

                                    default:
                                        KasStr="11:00";
                                        break;
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Local, E_Mem, U_Reg, T_Reg, Vis) VALUES ('{JPNum}','{PersianCalendar.Text}', '{KasStr}', 'جایگزین مرخصی روزانه', '{PLocal}', '{Jay} ({NameBox.Text})', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        //                                                    // ثبت امتیاز مرخصی بعد از پردازش
                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Amal (P_NUM, Tarikh, T_Reg, OnvAmal, U_Reg, Amal, Vis, Fad) VALUES ('{PNum}', '{PersianCalendar.Text}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', 'منفی', '{AppState.UserName}', 'ثبت مرخصی بعد از پردازش لوحه', False, 0)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    //If ReplaceBox.Text <> "" Then OptimizationForm.TotaEzafe(JPNum, PersianCalendar.Text)  ' محاسبات قدیم
                    //OptimizationForm.TotaEzafe(PNum, PersianCalendar.Text)
                    PersianCalendar.Focus();

                    NameBox.Text="";
                    NameButton.Image=Properties.Resources.user;
                    ReplaceBox.Text="";
                    ReplaceButton.Image=Properties.Resources.user;
                    DelayComboBox.SelectedIndex=-1;
                    KindCombo.SelectedIndex=-1;
                    Panel2.Enabled=false;
                    RegButton.Enabled=false;
                    PersonPostLabel.Text="";
                    ShiftLabel.Text="";
                    PersianDate=null;

                    Enabled=true;
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            ReplaceBox.Text="";
            ReplaceButton.Image=Properties.Resources.user;
            PersonPostLabel.Text="";
            ShiftLabel.Text="";
            DelayComboBox.SelectedIndex=-1;
            Panel2.Enabled=false;
            RegButton.Enabled=false;
        }

        public void DailyLeaveRegisterAllForm_Load(object sender, EventArgs e)
        {
            PersonPostLabel.Text="";
            ShiftLabel.Text="";
            Panel2.Enabled=false;
            RegButton.Enabled=false;
            PersianCalendar.Today_Click(null, null);

            KindCombo.Items.Add("استحقاقی");
            KindCombo.Items.Add("استعلاجی");
            KindCombo.Items.Add("غیبت");
            if (AppState.UserLevel < 5)
            {
                KindCombo.Items.Add("ماموریت");
            }
        }
    }
}
