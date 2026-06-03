using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Metro_Operation
{

    public partial class ManageShiftStatisticsForm
    {
        public ManageShiftStatisticsForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Dis()
        {
            ReservBoxA.Text = "0";
            ReservBoxB.Text = "0";
            ReservBoxC.Text = "0";
            TripBoxA.Text = "0";
            TripBoxB.Text = "0";
            TripBoxC.Text = "0";
            DelBoxA.Text = "0";
            DelBoxB.Text = "0";
            DelBoxC.Text = "0";
            NoTripBoxA.Text = "0";
            NoTripBoxB.Text = "0";
            NoTripBoxC.Text = "0";
            TimeLeaveBoxA.Text = "0";
            TimeLeaveBoxB.Text = "0";
            TimeLeaveBoxC.Text = "0";
            DailyLeaveBoxA.Text = "0";
            DailyLeaveBoxB.Text = "0";
            DailyLeaveBoxC.Text = "0";

            OvertimeReqBoxA.Text = "0";
            OvertimeReqBoxB.Text = "0";
            OvertimeReqBoxC.Text = "0";
            OKOvertimeReqBoxA.Text = "0";
            OKOvertimeReqBoxB.Text = "0";
            OKOvertimeReqBoxC.Text = "0";
            HamBoxA.Text = "0";
            HamBoxB.Text = "0";
            HamBoxC.Text = "0";
            FridayBoxA.Text = "0";
            FridayBoxB.Text = "0";
            FridayBoxC.Text = "0";
            OvertimeEctBoxA.Text = "0";
            OvertimeEctBoxB.Text = "0";
            OvertimeEctBoxC.Text = "0";
            NoReqBoxA.Text = "0";
            NoReqBoxB.Text = "0";
            NoReqBoxC.Text = "0";
        }

        public void ManageShiftStatisticsForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "070403");
        }

        public void ManageStatisticsForm_Load(object sender, EventArgs e)
        {
            LocalCombo.Items.Clear();
            if (AppState.UserLevel < 6)
            {
                LocalCombo.Items.Add("همه موارد");
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

            TimeCombo.SelectedIndex = 0;
            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate = ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate = ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                Dis();
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate == null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش را مشخص کنید");
                }
                else if (EndDate < StartDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی گزارش صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی گزارش صحیح نیست");
                }
                else
                {
                    int AReserv = 0;
                    int BReserv = 0;
                    int CReserv = 0;
                    int ATrip = 0;
                    int BTrip = 0;
                    int CTrip = 0;
                    int ADel = 0;
                    int BDel = 0;
                    int CDel = 0;
                    int ANoTrip = 0;
                    int BNoTrip = 0;
                    int CNoTrip = 0;
                    int ATimeLeave = 0;
                    int BTimeLeave = 0;
                    int CTimeLeave = 0;
                    int ADailyLeave = 0;
                    int BDailyLeave = 0;
                    int CDailyLeave = 0;
                    int AOvertimeReq = 0;
                    int BOvertimeReq = 0;
                    int COvertimeReq = 0;
                    int AOKOvertimeReq = 0;
                    int BOKOvertimeReq = 0;
                    int COKOvertimeReq = 0;
                    int AHam = 0;
                    int BHam = 0;
                    int CHam = 0;
                    int AFriday = 0;
                    int BFriday = 0;
                    int CFriday = 0;
                    //int ANoReq = 0;
                    //int BNoReq = 0;
                    //int CNoReq = 0;

                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled = false;

                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            Taghvim PersianDtae = new Taghvim(StartCalendar.Text);
                            bool Contin = true;

                            while (Contin)
                            {
                                //AReserv=0;
                                //BReserv=0;
                                //CReserv=0;
                                //ATrip=0;
                                //BTrip=0;
                                //CTrip=0;
                                //ADel=0;
                                //BDel=0;
                                //CDel=0;
                                //ANoTrip=0;
                                //BNoTrip=0;
                                //CNoTrip=0;
                                //ATimeLeave=0;
                                //BTimeLeave=0;
                                //CTimeLeave=0;
                                //ADailyLeave=0;
                                //BDailyLeave=0;
                                //CDailyLeave=0;
                                //AOvertimeReq=0;
                                //BOvertimeReq=0;
                                //COvertimeReq=0;
                                //AOKOvertimeReq=0;
                                //BOKOvertimeReq=0;
                                //COKOvertimeReq=0;
                                //AHam=0;
                                //BHam=0;
                                //CHam=0;
                                //AFriday=0;
                                //BFriday=0;
                                //CFriday=0;
                                //ANoReq=0;
                                //BNoReq=0;
                                //CNoReq=0;

                                string QueStr = "Select Person.P_Num, Person.Shift_name, Person.Shift_name, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3, Rezerv.Vis From Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.id>0 AND Rezerv.Mem<>'شانتر'";
                                if (AppState.UserLevel < 6)
                                {
                                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                                    {
                                        QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                    }
                                }
                                else
                                {
                                    QueStr += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }

                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                QueStr += " AND Rezerv.Tarikh='" + PersianDtae.Tarikh() + "'";

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        switch (Reader["Shift_name"].ToString())
                                        {
                                            case "A":
                                                if ((bool)Reader["Vis"])
                                                {
                                                    AReserv++;
                                                    if (Reader["Trip1"].ToString() != "" || Reader["Trip2"].ToString() != "" || Reader["Trip3"].ToString() != "")
                                                    {
                                                        if (Reader["Trip1"].ToString() != "")
                                                        {
                                                            ATrip++;
                                                        }

                                                        if (Reader["Trip2"].ToString() != "")
                                                        {
                                                            ATrip++;
                                                        }

                                                        if (Reader["Trip3"].ToString() != "")
                                                        {
                                                            ATrip++;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        ANoTrip++;
                                                    }
                                                }
                                                else
                                                {
                                                    ADel++;
                                                }

                                                break;

                                            case "B":
                                                if ((bool)Reader["Vis"])
                                                {
                                                    BReserv++;
                                                    if (Reader["Trip1"].ToString() != "" || Reader["Trip2"].ToString() != "" || Reader["Trip3"].ToString() != "")
                                                    {
                                                        if (Reader["Trip1"].ToString() != "")
                                                        {
                                                            BTrip++;
                                                        }

                                                        if (Reader["Trip2"].ToString() != "")
                                                        {
                                                            BTrip++;
                                                        }

                                                        if (Reader["Trip3"].ToString() != "")
                                                        {
                                                            BTrip++;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        BNoTrip++;
                                                    }
                                                }
                                                else
                                                {
                                                    BDel++;
                                                }
                                                break;

                                            case "C":
                                                if ((bool)Reader["Vis"])
                                                {
                                                    CReserv++;
                                                    if (Reader["Trip1"].ToString() != "" || Reader["Trip2"].ToString() != "" || Reader["Trip3"].ToString() != "")
                                                    {
                                                        if (Reader["Trip1"].ToString() != "")
                                                        {
                                                            CTrip++;
                                                        }

                                                        if (Reader["Trip2"].ToString() != "")
                                                        {
                                                            CTrip++;
                                                        }

                                                        if (Reader["Trip3"].ToString() != "")
                                                        {
                                                            CTrip++;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        CNoTrip++;
                                                    }
                                                }
                                                else
                                                {
                                                    CDel++;
                                                }
                                                break;
                                        }
                                    }
                                }

                                QueStr = "Select Person.P_Num, Person.Shift_name, Person.Shift_name From Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.OnvAmal='ساعتی' AND Amal.Vis=True AND Amal.Tarikh='" + PersianDtae.Tarikh() + "'";
                                if (AppState.UserLevel < 6)
                                {
                                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                                    {
                                        QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                    }
                                }
                                else
                                {
                                    QueStr += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        switch (Reader["Shift_name"].ToString())
                                        {
                                            case "A":
                                                ATimeLeave++;
                                                break;
                                            case "B":
                                                BTimeLeave++;
                                                break;
                                            case "C":
                                                CTimeLeave++;
                                                break;
                                        }
                                    }
                                }

                                QueStr = "Select Person.P_Num, Person.Shift_name, Person.Shift_name From Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Morakhasi.Vis=True AND Morakhasi.Tarikh='" + PersianDtae.Tarikh() + "'";
                                if (AppState.UserLevel < 6)
                                {
                                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                                    {
                                        QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                    }
                                }
                                else
                                {
                                    QueStr += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }

                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader = CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        switch (Reader["Shift_name"].ToString())
                                        {
                                            case "A":
                                                ADailyLeave++;
                                                break;
                                            case "B":
                                                BDailyLeave++;
                                                break;
                                            case "C":
                                                CDailyLeave++;
                                                break;
                                        }
                                    }
                                }

                                QueStr = "Select Person.P_Num, Person.Shift_name, Person.Shift_name From JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE JayGozin.Vis=True AND JayGozin.Tarikh='" + PersianDtae.Tarikh() + "'";
                                if (AppState.UserLevel < 6)
                                {
                                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                                    {
                                        QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                    }
                                }
                                else
                                {
                                    QueStr += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            switch (Reader["Shift_name"].ToString())
                                            {
                                                case "A":
                                                    AOvertimeReq++;
                                                    break;
                                                case "B":
                                                    BOvertimeReq++;
                                                    break;
                                                case "C":
                                                    COvertimeReq++;
                                                    break;
                                            }

                                        }
                                    }

                                }


                                QueStr = "Select Person.P_Num, Person.Shift_name, Person.Shift_name, Ezafeh.E_Kind, Ezafeh.E_Mem From Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Ezafeh.Vis=True AND Ezafeh.Tarikh='" + PersianDtae.Tarikh() + "' AND (E_Kind='اضافه کار' OR E_Kind='جایگزین مرخصی روزانه' OR E_Kind='همکاری با شیفت' OR E_Kind='' OR E_Kind='' OR E_Kind='')";
                                if (AppState.UserLevel < 6)
                                {
                                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                                    {
                                        QueStr += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                    }
                                }
                                else
                                {
                                    QueStr += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            switch (Reader["Shift_name"].ToString())
                                            {
                                                case "A":
                                                    //if (Reader["E_Kind"].ToString() == "جایگزین مرخصی روزانه" && (Reader["E_Mem"].ToString().IndexOf("(") + 1 == 0 || Reader["E_Mem"].ToString().IndexOf(")") + 1 == 0))
                                                    //{
                                                    //    AOKOvertimeReq++;
                                                    //}
                                                    //else
                                                    //{
                                                    //    ANoReq++;
                                                    //    if (PersianDtae.DayWeek() == "جمعه")
                                                    //    {
                                                    //        AFriday++;
                                                    //    }
                                                    //    if (Reader["E_Kind"].ToString() == "همکاری با شیفت")
                                                    //    {
                                                    //        AHam++;
                                                    //    }
                                                    //}

                                                    if (PersianDtae.DayWeek() == "جمعه")
                                                    {
                                                        AFriday++;
                                                    }
                                                    else
                                                    {
                                                        AHam++;
                                                    }
                                                    break;
                                                case "B":
                                                    //if (Reader["E_Kind"].ToString() == "جایگزین مرخصی روزانه" && (Reader["E_Mem"].ToString().IndexOf("(") + 1 == 0 || Reader["E_Mem"].ToString().IndexOf(")") + 1 == 0))
                                                    //{
                                                    //    BOKOvertimeReq++;
                                                    //}
                                                    //else
                                                    //{
                                                    //    BNoReq++;
                                                    //    if (PersianDtae.DayWeek() == "جمعه")
                                                    //    {
                                                    //        BFriday++;
                                                    //    }
                                                    //    if (Reader["E_Kind"].ToString() == "همکاری با شیفت")
                                                    //    {
                                                    //        BHam++;
                                                    //    }
                                                    //}
                                                    if (PersianDtae.DayWeek() == "جمعه")
                                                    {
                                                        BFriday++;
                                                    }
                                                    else
                                                    {
                                                        BHam++;
                                                    }
                                                    break;
                                                case "C":
                                                    //if (Reader["E_Kind"].ToString() == "جایگزین مرخصی روزانه" && (Reader["E_Mem"].ToString().IndexOf("(") + 1 == 0 || Reader["E_Mem"].ToString().IndexOf(")") + 1 == 0))
                                                    //{
                                                    //    COKOvertimeReq++;
                                                    //}
                                                    //else
                                                    //{
                                                    //    CNoReq++;
                                                    //    if (PersianDtae.DayWeek() == "جمعه")
                                                    //    {
                                                    //        CFriday++;
                                                    //    }
                                                    //    if (Reader["E_Kind"].ToString() == "همکاری با شیفت")
                                                    //    {
                                                    //        CHam++;
                                                    //    }
                                                    //}
                                                    if (PersianDtae.DayWeek() == "جمعه")
                                                    {
                                                        CFriday++;
                                                    }
                                                    else
                                                    {
                                                        CHam++;
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                }

                                ReservBoxA.Text = AReserv.ToString();
                                ReservBoxB.Text = BReserv.ToString();
                                ReservBoxC.Text = CReserv.ToString();
                                TripBoxA.Text = ATrip.ToString();
                                TripBoxB.Text = BTrip.ToString();
                                TripBoxC.Text = CTrip.ToString();
                                DelBoxA.Text = ADel.ToString();
                                DelBoxB.Text = BDel.ToString();
                                DelBoxC.Text = CDel.ToString();
                                NoTripBoxA.Text = ANoTrip.ToString();
                                NoTripBoxB.Text = BNoTrip.ToString();
                                NoTripBoxC.Text = CNoTrip.ToString();
                                TimeLeaveBoxA.Text = ATimeLeave.ToString();
                                TimeLeaveBoxB.Text = BTimeLeave.ToString();
                                TimeLeaveBoxC.Text = CTimeLeave.ToString();
                                DailyLeaveBoxA.Text = ADailyLeave.ToString();
                                DailyLeaveBoxB.Text = BDailyLeave.ToString();
                                DailyLeaveBoxC.Text = CDailyLeave.ToString();
                                OvertimeReqBoxA.Text = AOvertimeReq.ToString();
                                OvertimeReqBoxB.Text = BOvertimeReq.ToString();
                                OvertimeReqBoxC.Text = COvertimeReq.ToString();
                                OKOvertimeReqBoxA.Text = AOKOvertimeReq.ToString();
                                OKOvertimeReqBoxB.Text = BOKOvertimeReq.ToString();
                                OKOvertimeReqBoxC.Text = COKOvertimeReq.ToString();
                                HamBoxA.Text = AHam.ToString();
                                HamBoxB.Text = BHam.ToString();
                                HamBoxC.Text = CHam.ToString();
                                FridayBoxA.Text = AFriday.ToString();
                                FridayBoxB.Text = BFriday.ToString();
                                FridayBoxC.Text = CFriday.ToString();
                                //If AShift Then AOvertimeEctBox.Text += (ANoReq + BNoReq + CNoReq) - ANoTrip
                                //If BShift Then BOvertimeEctBox.Text += (ANoReq + BNoReq + CNoReq) - BNoTrip
                                //If CShift Then COvertimeEctBox.Text += (ANoReq + BNoReq + CNoReq) - CNoTrip
                                //If ANoReq - AOvertimeReq > 0 Then ANoReqBox.Text += ANoReq - AOvertimeReq
                                //If BNoReq - BOvertimeReq > 0 Then BNoReqBox.Text += BNoReq - BOvertimeReq
                                //If CNoReq - COvertimeReq > 0 Then CNoReqBox.Text += CNoReq - COvertimeReq

                                if (PersianDtae.Tarikh() == EndCalendar.Text)
                                {
                                    Contin = false;
                                }
                                PersianDtae.AddDay(1);
                            }
                        }

                        Enabled = true;
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

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TimeCombo.SelectedIndex >= 0)
            {
                TitrLabel.Text = TimeCombo.SelectedItem.ToString();
                Dis();
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeCombo.SelectedIndex = -1;
        }

        public void AReservBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='A' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BReservBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='B' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void CReservBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='C' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void ATripBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو تریپ رفته شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_mod, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='A' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND (Rezerv.Trip1<>'' OR Rezerv.Trip2<>'' OR Rezerv.Trip3<>'') AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BTripBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو تریپ رفته شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_mod, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='B' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND (Rezerv.Trip1<>'' OR Rezerv.Trip2<>'' OR Rezerv.Trip3<>'') AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void CTripBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو تریپ رفته شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_mod, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='C' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND (Rezerv.Trip1<>'' OR Rezerv.Trip2<>'' OR Rezerv.Trip3<>'') AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void ADelBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو حذف شده شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.U_Mod, Rezerv.Mem FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='A' AND Rezerv.Vis=False";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BDelBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو حذف شده شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.U_Mod, Rezerv.Mem FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='B' AND Rezerv.Vis=False";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void CDelBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو حذف شده شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.U_Mod, Rezerv.Mem FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='C' AND Rezerv.Vis=False";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void ANoTripBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو تریپ نرفته شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='A' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND (Rezerv.Trip1='' AND Rezerv.Trip2='' AND Rezerv.Trip3='') AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BNoTripBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو تریپ نرفته شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='B' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND (Rezerv.Trip1='' AND Rezerv.Trip2='' AND Rezerv.Trip3='') AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void CNoTripBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "رزرو تریپ نرفته شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.Tarikh, Rezerv.U_Reg, Rezerv.Mem, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Trip3 FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Person.Shift_name='C' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND (Rezerv.Trip1='' AND Rezerv.Trip2='' AND Rezerv.Trip3='') AND Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Rezerv.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void ATimeLeaveBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "مرخصی ساعتی شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Amal.Tarikh, Amal.U_Reg, Amal.Amal FROM Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Person.Shift_name='A' AND Amal.Vis=True AND Amal.OnvAmal='ساعتی'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Amal.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Amal.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BTimeLeaveBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "مرخصی ساعتی شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Amal.Tarikh, Amal.U_Reg, Amal.Amal FROM Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Person.Shift_name='B' AND Amal.Vis=True AND Amal.OnvAmal='ساعتی'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Amal.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Amal.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void CTimeLeaveBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "مرخصی ساعتی شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Amal.Tarikh, Amal.U_Reg, Amal.Amal FROM Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Person.Shift_name='C' AND Amal.Vis=True AND Amal.OnvAmal='ساعتی'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Amal.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Amal.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void ADailyLeaveBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "مرخصی روزانه شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Morakhasi.Tarikh, Morakhasi.U_Reg, Morakhasi.Kind FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Shift_name='A' AND Morakhasi.Vis=True";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Morakhasi.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Morakhasi.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BDailyLeaveBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "مرخصی روزانه شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Morakhasi.Tarikh, Morakhasi.U_Reg, Morakhasi.Kind FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Shift_name='B' AND Morakhasi.Vis=True";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Morakhasi.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Morakhasi.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void CDailyLeaveBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "مرخصی روزانه شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Morakhasi.Tarikh, Morakhasi.U_Reg, Morakhasi.Kind FROM Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Person.Shift_name='C' AND Morakhasi.Vis=True";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Morakhasi.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Morakhasi.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void AOvertimeReqBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            //ShowForm.TitrLabel.Text="مرخصی ساعتی";
            //ShowForm.TimeLabel.Text=PersianDate.FirstOfThisMonth() + " تا " + PersianDate.EndOfThisMonth();
            //ShowForm.FName=Name1Label.Text;
            //ShowForm.Family=Family1Label.Text;
            //ShowForm.Pnum=PNum1Label.Text;

            //ShowForm.Command="SELECT Tarikh, U_Reg, Amal FROM Amal WHERE Vis=True AND OnvAmal='ساعتی' AND P_Num='" + PNum1Label.Text + "' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + PersianDate.EndOfThisMonth() + "' ORDER BY Tarikh";
            //ShowForm.ShowDialog(this);

            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text = "درخواست اضافه کار شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, JayGozin.Tarikh, JayGozin.U_Reg, JayGozin.Shift_Loc, JayGozin.Olv1, JayGozin.Olv2, JayGozin.Olv3, JayGozin.Olv4 FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE Person.Shift_name='A' AND JayGozin.Vis=True";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND JayGozin.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY JayGozin.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void BOvertimeReqBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "درخواست اضافه کار شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, JayGozin.Tarikh, JayGozin.U_Reg, JayGozin.Shift_Loc, JayGozin.Olv1, JayGozin.Olv2, JayGozin.Olv3, JayGozin.Olv4 FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE Person.Shift_name='B' AND JayGozin.Vis=True";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND JayGozin.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY JayGozin.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void COvertimeReqBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "درخواست اضافه کار شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, JayGozin.Tarikh, JayGozin.U_Reg, JayGozin.Shift_Loc, JayGozin.Olv1, JayGozin.Olv2, JayGozin.Olv3, JayGozin.Olv4 FROM JayGozin INNER JOIN Person ON Person.P_Num=JayGozin.P_Num WHERE Person.Shift_name='C' AND JayGozin.Vis=True";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND JayGozin.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY JayGozin.Tarikh";
            ShowForm.ShowDialog(this);
        }

        public void AOKOvertimeReqBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "درخواست تایید شده شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='A' AND Ezafeh.Vis=True AND (Ezafeh.E_Kind NOT LIKE '%(%' OR Ezafeh.E_Kind NOT LIKE '%)%') ";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void BOKOvertimeReqBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "درخواست تایید شده شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='B' AND Ezafeh.Vis=True AND (Ezafeh.E_Kind NOT LIKE '%(%' OR Ezafeh.E_Kind NOT LIKE '%)%')";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void COKOvertimeReqBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "درخواست تایید شده شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='C' AND Ezafeh.Vis=True AND (Ezafeh.E_Kind NOT LIKE '%(%' OR Ezafeh.E_Kind NOT LIKE '%)%') ";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void AHamBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "همکاری با شیفت A";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='A' AND Ezafeh.Vis=True AND Ezafeh.E_Kind='همکاری با شیفت'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void BHamBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "همکاری با شیفت B";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='B' AND Ezafeh.Vis=True AND Ezafeh.E_Kind='همکاری با شیفت'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void CHamBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "همکاری با شیفت C";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='C' AND Ezafeh.Vis=True AND Ezafeh.E_Kind='همکاری با شیفت'";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.ShowDialog(this);
        }

        public void AFridayBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "اضافه کار جمعه شیفت A";
            ShowForm.Seprat = " ";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Kind, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='A' AND Ezafeh.Vis=True AND ((Ezafeh.E_Kind='جایگزین مرخصی روزانه' AND (Ezafeh.E_Mem LIKE '%(%' OR Ezafeh.E_Mem LIKE '%)%')) OR Ezafeh.E_Kind<>'جایگزین مرخصی روزانه')";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.Week = "Friday";
            ShowForm.ShowDialog(this);
        }

        public void BFridayBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "اضافه کار جمعه شیفت B";
            ShowForm.Seprat = " ";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Kind, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='B' AND Ezafeh.Vis=True AND ((Ezafeh.E_Kind='جایگزین مرخصی روزانه' AND (Ezafeh.E_Mem LIKE '%(%' OR Ezafeh.E_Mem LIKE '%)%')) OR Ezafeh.E_Kind<>'جایگزین مرخصی روزانه')";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.Week = "Friday";
            ShowForm.ShowDialog(this);
        }

        public void CFridayBox_Click(object sender, EventArgs e)
        {
            DetailShwoForm ShowForm = new DetailShwoForm();
            ShowForm.TimeLabel.Text = StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.UserLabel.Text = "";
            ShowForm.TitrLabel.Text = "اضافه کار جمعه شیفت C";
            ShowForm.Seprat = " ";
            ShowForm.Command = "SELECT Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.U_Reg, Ezafeh.E_Time, Ezafeh.E_Kind, Ezafeh.E_Mem FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Shift_name='C' AND Ezafeh.Vis=True AND ((Ezafeh.E_Kind='جایگزین مرخصی روزانه' AND (Ezafeh.E_Mem LIKE '%(%' OR Ezafeh.E_Mem LIKE '%)%')) OR Ezafeh.E_Kind<>'جایگزین مرخصی روزانه')";
            if ((string)TimeCombo.SelectedItem != "همه موارد")
            {
                ShowForm.Command += " AND Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
            }
            if (AppState.UserLevel < 6)
            {
                if ((string)LocalCombo.SelectedItem != "همه موارد")
                {
                    ShowForm.Command += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                }
            }
            else
            {
                ShowForm.Command += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
            }
            ShowForm.Command += " AND Ezafeh.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Ezafeh.Tarikh DESC";
            ShowForm.Week = "Friday";
            ShowForm.ShowDialog(this);
        }

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog()
                {
                    Filter = "Excel Files|*.xlsx|Excel Files 97-2003|*.xls"
                };

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();

                        DataTable Dt = new DataTable();
                        Dt.Columns.Add("عنوان");
                        Dt.Columns.Add("A");
                        Dt.Columns.Add("B");
                        Dt.Columns.Add("C");

                        foreach (Label lbl in Panel5.Controls.OfType<Label>().Where(l => l.Tag != null).OrderBy(l => l.Tag))
                        {
                            Dt.Rows.Add(lbl.Text, "", "", "");
                        }

                        int i = 0, j = 1;
                        foreach (TextBox txb in Panel5.Controls.OfType<TextBox>().OrderBy(t => t.Tag))
                        {
                            Dt.Rows[i][j] = txb.Text;
                            if (j == 3)
                            {
                                i++;
                                j = 1;
                            }
                            else
                                j++;
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
