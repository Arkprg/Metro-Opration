using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class TimeLeaveEditForm
    {
        public TimeLeaveEditForm()
        {
            InitializeComponent();
        }


        private int FID;
        //private int FadID;
        private int Num;
        private double leaveTime;
        private double Ti;
        private string PName; //WDay,
        private string PFamily;
        private string PNum;
        private string PTime;
        private string PPost;
        private string ShName;
        private string JFamily;
        private string JName;
        private string JNum;
        private string JShName;
        private string Jay;
        private string StartTime;
        private string LeaveRepl;
        private string LeaveKind;
        private bool NextDay;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Dis()
        {
            StartBox.Text="";
            EndBox.Text="";
            ReplaceCombo.SelectedIndex=-1;
            ReleaseNameBox.Text="";
            MemBox.Text="";
            NextDay=false;
            Panel2.Enabled=false;
            RegButton.Enabled=false;
            DeletButton.Enabled=false;
            FID=-1;
            //FadID=-1;
            Jay="";
            JFamily="";
            JName="";
            JNum="";
            JShName="";
            ReleaseNameBox.Text="";
            ReleaseNameButton.Image=Properties.Resources.user;
        }

        public void TimeCalculate()
        {
            if (TimeToDouble(StartBox.Text, true) > 0 && PPost == "راهبر قطار")
            {
                if (AppState.UserLnum == "5")
                {
                    Ti=4;
                    //If Num=1 And (ReplaceCombo.SelectedItem="راهبر رزرو" Or ReplaceCombo.SelectedItem="بدون جایگزین") Then
                    //    Ti += 0
                    //Else
                    //If PTime="12 ساعته" Then
                    //    Ti=TimeToDouble("05:20")
                    //Else
                    //    If PLoc="هشتگرد" Then
                    //        Ti += TimeToDouble("04:20")
                    //    Else
                    //        Ti += TimeToDouble("06:30")
                    //    End If
                    //End If
                    double EndTime=TimeToDouble(StartBox.Text) + Ti;
                    if (EndTime >= 24)
                    {
                        EndTime -= 24;
                        NextDay=true;
                    }
                    EndBox.Text=DoubleToTime(EndTime);
                    Label6.Text=NumToWord.ConvertNumber(Num, true) + "ین مرخصی ساعتی ماه جاری - مدت محاسبه: " + DoubleToTime(Ti).ToString();
                }
            }
        }
        public void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Dis();

                DateTime SelectDate=ShamsiToMiladi(PersianCalendar.Text);

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
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID, Amal, Mem FROM Amal WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True AND OnvAmal='ساعتی' ", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StartBox.Text=Reader["Amal"].ToString().Substring(0, 5);
                                StartTime=StartBox.Text;
                                EndBox.Text=Reader["Amal"].ToString().Substring(9, 5);
                                leaveTime=TimeToDouble(Reader["Amal"].ToString().Substring(9, 5)) - TimeToDouble(Reader["Amal"].ToString().Substring(0, 5));
                                FID=Convert.ToInt32(Reader["ID"].ToString());
                                string ss=Reader["Mem"].ToString();
                                if (Reader["Mem"].ToString().Substring(0, 5) == "رزرو ")
                                {
                                    Jay="رزرو";
                                    ReplaceCombo.Text="راهبر رزرو";
                                    Label9.Text="تذکر: با حذف مرخصی ساعتی، تریپ راهبر رزرو حذف می گردد";
                                }
                                else if (Reader["Mem"].ToString().Substring(0, 5) == "با جا")
                                {
                                    Jay="با جا";
                                    ReplaceCombo.Text="با جایگزین";
                                    Label9.Text="تذکر: با حذف مرخصی ساعتی، اضافه کار جایگزین حذف می گردد";
                                }
                                else if (Reader["Mem"].ToString().Substring(0, 5) == "بی جا")
                                {
                                    Jay="بی جا";
                                    ReplaceCombo.Text="بدون جایگزین";
                                }
                                LeaveKind=ReplaceCombo.Text;
                                if (int.TryParse(Reader["Mem"].ToString().Substring(5, 5), out _))
                                {
                                    JNum=Reader["Mem"].ToString().Substring(5, 5);
                                    LeaveRepl=JNum;
                                }
                                MemBox.Text=Reader["Mem"].ToString().Substring(10, Convert.ToInt32(Reader["Mem"].ToString().Length - 10));
                                Panel2.Enabled=true;
                                RegButton.Enabled=true;
                                DeletButton.Enabled=true;
                            }
                        }

                        Num=1; // برای محاسبه اولین مرخصی بدون کسری صفر شود
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Amal WHERE OnvAmal='ساعتی' AND P_Num='" + PNum + "' AND Tarikh >='" + MainForm.PersianToday.FirstOfThisMonth() + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Num++;
                            }
                        }

                        TimeCalculate();
                    }


                    DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + JNum + "'");
                    foreach (DataRow DtR in DRow)
                    {
                        ReleaseNameBox.Text=DtR["Fname"].ToString() + " " + DtR["Family"].ToString();
                    }

                    if (!Panel2.Enabled)
                    {
                        MessageBoxFa.Show(" داده ای یافت نشد", "خطا", MessageBoxIcon.Warning);
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

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            Dis();
        }

        public void Button7_Click(object sender, EventArgs e)
        {
            Dis();
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {

                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                PTime=PersonalSelectForm.PTime;
                PPost=PersonalSelectForm.PPost;
                ShName=PersonalSelectForm.PShift;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;

                ReplaceCombo.Items.Clear();
                if (PPost == "راهبر قطار")
                {
                    StartBox.Enabled=true;

                    if (AppState.UserLnum == "5")
                    {
                        EndBox.Enabled=false;
                    }
                    else
                    {
                        EndBox.Enabled=true; // False
                    }

                    ReplaceCombo.Items.Add("با جایگزین");
                    ReplaceCombo.Items.Add("بدون جایگزین");
                    ReplaceCombo.Items.Add("راهبر رزرو");
                }
                else
                {
                    StartBox.Enabled=true;
                    EndBox.Enabled=true;
                    ReplaceCombo.Items.Add("با جایگزین");
                    ReplaceCombo.Items.Add("بدون جایگزین");
                }
            }
        }

        public void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show(" آیا از حذف مورد ثبت شده اطمینان دارید؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Amal SET Vis=False WHERE ID=" + FID.ToString(), StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }


                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Amal (P_Num, Tarikh, OnvAmal, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', 'ساعتی', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', False, -" + FID.ToString() + ")", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }


                        if (Jay == "با جا")
                        {
                            using (OleDbCommand CMD=new OleDbCommand("UPDATE Ezafeh SET Vis=False WHERE P_Num='" + JNum.ToString() + "' AND Tarikh='" + PersianCalendar.Text + "' AND E_Kind='جایگزین مرخصی ساعتی'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                        }
                    }


                    NameBox.Text="";
                    Dis();
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

        public void TimeLeaveEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0104");
        }

        public void Form20_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);
            Dis();
        }

        public void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            EndBox.Text="";
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TimeToDouble(StartBox.Text, true) <= 0)
                {
                    ErrorShow(StartBox, "ساعت شروع مرخصی ساعتی صحیح نیست");
                }
                else if (TimeToDouble(EndBox.Text, true) <= 0)
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
                else if (ReplaceCombo.SelectedIndex == 0 && ReleaseNameBox.Text == "")
                {
                    ErrorShow(ReleaseNameBox, "نام جایگزین را انتخاب کنید");
                }
                else if (ShName == JShName && (string)ReplaceCombo.SelectedItem == "با جایگزین")
                {
                    ErrorShow(ReleaseNameBox, "جایگزین هم شیفت مجاز نیست");
                }
                else if (MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "علت ویرایش را وارد کنید ");
                }
                else if (StartBox.Text != StartTime || leaveTime != TimeToDouble(EndBox.Text) - TimeToDouble(StartBox.Text) || (string)ReplaceCombo.SelectedItem != LeaveKind || LeaveRepl != JNum)
                {
                    string Jay="";
                    string Shift1="";
                    string Shift2="";
                    string ShiftLast="";
                    bool Holy=false;
                    Taghvim YesterDay=new Taghvim();

                    Enabled=false;

                    Shift1="";
                    Shift2="";
                    ShiftLast="";

                    YesterDay.SetDate(PersianCalendar.Text);
                    YesterDay.AddDay(-1);
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh, Asr, Holi FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Shift1=Reader["Sobh"].ToString();
                                Shift2=Reader["Asr"].ToString();
                                Holy=Convert.ToBoolean((bool)Reader["Holi"]);
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT Asr FROM taghvim WHERE Tarikh='" + YesterDay.Tarikh() + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ShiftLast=Reader["Asr"].ToString();
                            }
                        }

                        if (PTime == "ستادی" && Holy)
                        {
                            StrConnec.Close();
                            Enabled=true;

                            ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                            return;
                        }
                        else if (PTime == "9 ساعته" && ShName != Shift1 && ShName != Shift2)
                        {
                            StrConnec.Close();
                            Enabled=true;

                            ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                            return;
                        }
                        else if (PTime == "12 ساعته")
                        {
                            if (ShName != Shift1 && ShName != Shift2 && ShName != ShiftLast) // شیفت های جاری
                            {
                                StrConnec.Close();
                                Enabled=true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;

                            }
                            else if (string.Compare(StartBox.Text, "07:29") < 0 && ShName != ShiftLast) // شب کار دیشب
                            {
                                StrConnec.Close();
                                Enabled=true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;

                            }
                            else if (string.Compare(StartBox.Text, "07:29") > 0 && string.Compare(StartBox.Text, "19:29") < 0 && ShName != Shift1) // روزکار امروز
                            {
                                StrConnec.Close();
                                Enabled=true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;

                            }
                            else if (string.Compare(StartBox.Text, "19:29") > 0 && ShName != Shift2) // شب کار امشب
                            {
                                StrConnec.Close();
                                Enabled=true;
                                ErrorShow(PersianCalendar, NameBox.Text + " در این تاریخ استراحت است");
                                return;
                            }
                        }

                        Jay="";
                        if (ReplaceCombo.Text == "راهبر رزرو")
                        {
                            Jay="رزرو " + JNum;

                            int Tri=0;
                            bool Fi=false;
                            using (OleDbCommand CMD=new OleDbCommand("SELECT Trip1, Trip2, Trip3 FROM Rezerv WHERE P_Num='" + JNum + "' AND Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Fi=true;
                                    if (Reader["Trip1"].ToString().Length == 0)
                                    {
                                        Tri=1;
                                    }
                                    else if (Reader["Trip2"].ToString().Length == 0)
                                    {
                                        Tri=2;
                                    }
                                    else if (Reader["Trip3"].ToString().Length == 0)
                                    {
                                        Tri=3;
                                    }

                                    if (StartBox.Text == Reader["Trip1"].ToString() || StartBox.Text == Reader["Trip2"].ToString() || StartBox.Text == Reader["Trip2"].ToString())
                                    {
                                        Tri=0;
                                    }
                                }
                            }

                            if (!Fi)
                            {
                                StrConnec.Close();
                                ErrorShow(PersianCalendar, "راهبر رزرو در لیست رزروها نیست");
                                return;
                            }

                            if (Tri > 0)
                            {

                                string QueStr="UPDATE Rezerv SET";
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
                                QueStr += " U_Mod='" + AppState.UserName + "' WHERE P_Num='" + JNum + "' AND Tarikh='" + PersianCalendar.Text + "'";

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (ReplaceCombo.Text == "با جایگزین")
                        {

                            // ********** کنترل سقف اضافه کار جایگزین نمی ذارم ببینم کی پیداش می کنه :) :)

                            Jay="با جا" + JNum;
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, U_Reg, E_Time, E_Kind, E_Mem, T_Reg, Vis) VALUES ('" + JNum + "','" + PersianCalendar.Text + "', '" + AppState.UserName + "', '06:30', 'جایگزین مرخصی ساعتی', ' " + NameBox.Text + "', '" + MainForm.PersianToday.Tarikh(DateTime.Today) + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            OptimizationForm ShowForm=new OptimizationForm();
                            ShowForm.PersoOptim(JNum, PersianCalendar.Text, StrConnec);

                        }
                        else if (ReplaceCombo.Text == "بدون جایگزین")
                        {
                            Jay="بی جا*****";
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Amal (P_Num, Tarikh, OnvAmal, Amal, Mem, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', 'ساعتی', '" + StartBox.Text + " تا " + EndBox.Text + "', '" + Jay + "'+ @Mem, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + FID.ToString() + ")", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }


                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Amal SET Vis=False WHERE ID=" + FID.ToString(), StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        if (LeaveKind == "با جایگزین")
                        {
                            using (OleDbCommand CMD=new OleDbCommand("UPDATE Ezafeh SET Vis=False WHERE P_Num='" + LeaveRepl + "' AND Tarikh='" + PersianCalendar.Text + "' AND E_Kind='جایگزین مرخصی ساعتی'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        OptimizationForm ShowForm1=new OptimizationForm();
                        ShowForm1.PersoOptim(PNum, PersianCalendar.Text, StrConnec);
                    }


                    NameBox.Text="";
                    Dis();
                }
                else
                {
                    MessageBoxFa.Show("هیچ داده ای تغییر نکرده است ", "خطا", MessageBoxIcon.Error);
                }

                Enabled=true;
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
            ReleaseNameBox.Text="";
            ReleaseNameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                JFamily=PersonalSelectForm.PFamily;
                JName=PersonalSelectForm.PName;
                JNum=PersonalSelectForm.PNum;
                JShName=PersonalSelectForm.PShift;
                ReleaseNameBox.Text=JName + " " + JFamily;
                ReleaseNameButton.Image=Properties.Resources.cancel1;
            }
        }

        public void StartBox_Leave(object sender, EventArgs e)
        {
            EndBox.Text="";
            TimeCalculate();
        }

        public void ReplaceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReplaceCombo.Text == "بدون جایگزین")
            {
                ReleaseNameBox.Text="";
                ReleaseNameBox.Enabled=false;
                ReleaseNameButton.Enabled=false;
            }
            else
            {
                ReleaseNameBox.Enabled=true;
                ReleaseNameButton.Enabled=true;
            }
            TimeCalculate();
        }

    }
}
