using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PersonalDetailReportForm
    {
        public PersonalDetailReportForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        //private readonly string Img;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void AllClear()
        {
            NameBox.Text="";
            FamilyBox.Text="";
            PNumBox.Text="";
            PostBox.Text="";
            ShiftBox.Text="";
            TimeBox.Text="";
            LineBox.Text="";
            LocalBox.Text="";
            LicensNumBox.Text="";
            PhonBox.Text="";
            NatIDBox.Text="";
            BirthdayBox.Text="";
            EmployDayBox.Text="";
            PictureBox1.Image=null;
            DataClear();
        }

        public void DataClear()
        {
            FridayBox.Text="00:00";
            FullBox.Text="00:00";
            KeshikBox.Text="00:00";
            ClassBox.Text="00:00";
            TashvighBox.Text="00:00";
            OverTimeBox.Text="00:00";
            OrevtimeReqBox.Text="0";
            ReservBox.Text="0";
            MorDayBox.Text="0";
            MorSaatBox.Text="00:00";
        }

        public void PersonalButton_Click(object sender, EventArgs e)
        {
            PersonBox.Text="";
            PersonalButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;

                PersonBox.Text=PName + " " + PFamily;
                PersonalButton.Image=Properties.Resources.cancel1;
            }

            AllClear();
        }

        public void PersonnelDetailReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0504");
        }

        public void PersonDetailReport_Load(object sender, EventArgs e)
        {
            if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
            {
                PNum=AppState.UserPnum;
                PersonalButton.Enabled=false;
                PersonBox.Text=AppState.UserName;
            }

            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate1;
                DateTime EndDate1;
                StartDate1=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate1=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (PersonBox.Text == "")
                {
                    ErrorShow(PersonalButton, " لطفا نام پرسنل را مشخص کنید ");
                }
                else if (StartDate1 == null)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate1 == null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش را مشخص کنید");
                }
                else if (EndDate1 < StartDate1)
                {
                    ErrorShow(StartCalendar, "بازه زمانی گزارش صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی گزارش صحیح نیست");
                }
                else
                {

                    if (PersonBox.Text != "")
                    {
                        PictureBox1.Image=null;

                        using (WaitForm wait=new WaitForm())
                        {
                            wait.Show();
                            wait.Refresh();
                            Enabled=false;

                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();
                                using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Person WHERE Vis=True AND P_Num='" + PNum + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        NameBox.Text=Reader["Fname"].ToString();
                                        FamilyBox.Text=Reader["Family"].ToString();
                                        PNumBox.Text=Reader["P_Num"].ToString();
                                        PostBox.Text=Reader["P_Post"].ToString();
                                        UnitBox.Text=Reader["P_Staff"].ToString();
                                        ShiftBox.Text=Reader["Shift_Name"].ToString();
                                        TimeBox.Text=Reader["Shift_Time"].ToString();
                                        LineBox.Text=Reader["Line_Num"].ToString();
                                        LocalBox.Text=Reader["Shift_Loc"].ToString();
                                        LicensNumBox.Text=Reader["LicenseDegree"].ToString();
                                        PhonBox.Text=Reader["Phone"].ToString();
                                        NatIDBox.Text=Reader["NatID"].ToString();
                                        BirthdayBox.Text=Reader["Birthday"].ToString();
                                        EmployDayBox.Text=Reader["EmpoDate"].ToString();
                                        ChangeDateBox.Text=Reader["Tarikh"].ToString();

                                        DegreeBox.Text=Reader["CollegDegree"].ToString();
                                        SubjectBox.Text=Reader["CollegObject"].ToString();
                                        ShoeBox.Text=Reader["ShoeSize"].ToString();
                                        ShirtBox.Text=Reader["ShirtSize"].ToString();
                                        CoatBox.Text=Reader["CoatSize"].ToString();
                                        PantBox.Text=Reader["PantSize"].ToString();
                                        OverBox.Text=Reader["OverSize"].ToString();
                                        HitBox.Text=Reader["H_ShSize"].ToString();
                                        AddressBox.Text=$"استان {Reader["StateAddress"]}، شهر {Reader["CityAddress"]}، {Reader["HomeAddress"]}";
                                    }
                                }

                                if (System.IO.File.Exists(AppState.DatabasePath + "\\Pic\\" + PNumBox.Text))
                                {
                                    PictureBox1.Image=Image.FromFile(AppState.DatabasePath + "\\Pic\\" + PNumBox.Text);
                                }

                                double keshik=0;
                                double Clas=0;
                                double Tashvigh=0;
                                double Ect=0;
                                double Fri=0;
                                Fri=0;
                                keshik=0;
                                Clas=0;
                                Tashvigh=0;
                                Ect=0;

                                using (OleDbCommand CMD=new OleDbCommand("SELECT Tarikh, E_Kind, E_Time FROM Ezafeh WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND P_Num='" + PNumBox.Text + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()).DayOfWeek == DayOfWeek.Friday)
                                        {
                                            Fri += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }

                                        if (Reader["E_Kind"].ToString() == "کشیک")
                                        {
                                            keshik += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else if (Reader["E_Kind"].ToString() == "کلاس آموزشی")
                                        {
                                            Clas += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else if (Reader["E_Kind"].ToString() == "تشویقی")
                                        {
                                            Tashvigh += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                        else
                                        {
                                            Ect += ConvertClass.TimeToDouble(Reader["E_Time"].ToString());
                                        }
                                    }
                                }

                                FullBox.Text=ConvertClass.DoubleToTime(keshik + Clas + Tashvigh + Ect);
                                FridayBox.Text=ConvertClass.DoubleToTime(Fri);
                                KeshikBox.Text=ConvertClass.DoubleToTime(keshik);
                                ClassBox.Text=ConvertClass.DoubleToTime(Clas);
                                TashvighBox.Text=ConvertClass.DoubleToTime(Tashvigh);
                                OverTimeBox.Text=ConvertClass.DoubleToTime(Ect);

                                double TLeav=0;
                                using (OleDbCommand CMD=new OleDbCommand("SELECT Amal FROM Amal WHERE OnvAmal='ساعتی' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND P_Num='" + PNumBox.Text + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        double TLeav1=ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(9, 5)) - ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(0, 5));
                                        if (TLeav1 < 0)
                                        {
                                            TLeav1 += 24;
                                        }

                                        TLeav += TLeav1;
                                    }
                                }

                                MorSaatBox.Text=ConvertClass.DoubleToTime(TLeav);

                                using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(Kind) AS Cou FROM Morakhasi WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND P_Num='" + PNumBox.Text + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        MorDayBox.Text=Reader["Cou"].ToString();
                                    }
                                }

                                using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(Tarikh) AS Cou, COUNT(IIF(Trip1<>'', 1,NULL)) AS Cou1, COUNT(IIF(Trip2<>'', 1,NULL)) AS Cou2, COUNT(IIF(Trip3<>'', 1,NULL)) AS Cou3 FROM Rezerv WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND P_Num='" + PNumBox.Text + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        ReservBox.Text=Reader["Cou"].ToString();
                                    }
                                }

                                using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(Tarikh) AS Cou FROM JayGozin WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND P_Num='" + PNumBox.Text + "'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        OrevtimeReqBox.Text=Reader["Cou"].ToString();
                                    }
                                }
                            }

                            Enabled=true;
                            wait.Close();
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

        public void FullButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="مجموع اضافه کار";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void FridayButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="اضافه کار جمعه";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh DESC";
            ShowForm.Week="Friday";
            ShowForm.ShowDialog(this);
        }

        public void ClassButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="اضافه کار کلاس آموزشی";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND E_Kind='کلاس آموزشی'  ORDER BY Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void KeshikButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="اضافه کار کلاس آموزشی";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND E_Kind='کشیک'  ORDER BY Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void TashvighButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="اضافه کار تشویقی";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND E_Kind='تشویقی'  ORDER BY Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void OverTimeButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="اضافه کار کلاس آموزشی";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, E_Time, E_Kind, E_Mem FROM Ezafeh WHERE Vis=True AND P_Num='" + PNum + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND E_Kind<>'کلاس آموزشی' AND E_Kind<>'کشیک' AND E_Kind<>'تشویقی' ORDER BY Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void TimeLeavButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="تعداد رزرو";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            //DetailShwoForm.Command="SELECT Tarikh, U_Reg, Kind FROM Morakhasi WHERE Vis=True AND P_Num='" & PNumBox.Text & "' AND Tarikh BETWEEN '" & StartCalendar.Text & "' AND '" & EndCalendar.Text & "' ORDER BY Tarikh"

            ShowForm.Command="SELECT Tarikh, U_Reg, Amal FROM Amal WHERE Vis=True AND OnvAmal='ساعتی' AND P_Num='" + PNumBox.Text + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void DalyLeavButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="تعداد رزرو";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" ";
            ShowForm.Command="SELECT Tarikh, U_Reg, Kind FROM Morakhasi WHERE Vis=True AND P_Num='" + PNumBox.Text + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void ReservButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="تعداد رزرو";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" - ";
            ShowForm.Command="SELECT Tarikh, U_Reg, Mem, Trip1, Trip2, Trip3 FROM Rezerv WHERE Vis=True AND P_Num='" + PNumBox.Text + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void OrevtimeReqButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="تعداد درخواست اضافه کار";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=PName;
            ShowForm.Family=PFamily;
            ShowForm.Pnum=PNum;
            ShowForm.Seprat=" - ";
            ShowForm.Command="SELECT Tarikh, U_Reg, Shift_Loc, Olv1, Olv2, Olv3, Olv4 FROM JayGozin WHERE Vis=True AND P_Num='" + PNumBox.Text + "' AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
        }

        private void ReservTripButton_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="تعداد تریپ در رزرو";
            ShowForm.Command="SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE (Rezerv.Trip1<>'' OR Rezerv.Trip2<>'' OR Rezerv.Trip3<>'') AND Rezerv.Vis=True AND Rezerv.P_Num='" + PNumBox.Text + "' AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }
    }
}
