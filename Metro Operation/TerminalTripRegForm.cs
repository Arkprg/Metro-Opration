using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class TerminalTripRegisterForm
    {
        public TerminalTripRegisterForm()
        {
            InitializeComponent();
        }

        private string P1Name; // PTime, PDate, PTime1, PDate1
        private string P1Family;
        private string P1Num;
        private string P3Name;
        private string P3Family;
        private string P3Num;
        // Dim ParkID, ParkID1 As Integer
        //Dim P2Name, P2Family, P2Num As String

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void TerminalTripRegisterForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);
            StartLocaCombo.Items.Clear();
            EndLocaCombo.Items.Clear();

            string[] TehSta=new string[] {
                    "سکوی شمالی تهران",
                    "سکوی جنوبی تهران"};

            string[] GolSta=new string[] {
                        "ساید شمالی گلشهر",
                        "سکوی شمالی گلشهر",
                        "ساید جنوبی گلشهر",
                        "سکوی جنوبی گلشهر"};

            string[] TehTerm=new string[] {
                            "خط 2 پارک 1 تهران",
                            "خط 2 پارک 2 تهران",
                            "خط 3 پارک 1 تهران",
                            "خط 3 پارک 2 تهران",
                            "چاله سرویس تهران"};

            string[] MehTerm=new string[] {
                                "خط 1 پارکینگ مهرشهر",
                                "خط 2 پارکینگ مهرشهر",
                                "خط 3 پارکینگ مهرشهر",
                                "خط 4 پارکینگ مهرشهر",
                                "خط 5 پارکینگ مهرشهر",
                                "خط 6 پارکینگ مهرشهر",
                                "خط 7 پارکینگ مهرشهر",
                                "خط 8 پارکینگ مهرشهر",
                                "خط 9 پارکینگ مهرشهر",
                                "خط 10 پارکینگ مهرشهر",
                                "دوار جنوبی 1 مهرشهر",
                                "دوار جنوبی 2 مهرشهر",
                                "دوار جنوبی 3 مهرشهر",
                                "دوار شمالی مهرشهر",
                                "خط 3 تعمیرات مهرشهر",
                                "خط 4 تعمیرات مهرشهر",
                                "خط 5 تعمیرات مهرشهر",
                                "بیرون خط 5 تعمیرات مهرشهر",
                                "خط 6 تعمیرات مهرشهر",
                                "بیرون خط 6 تعمیرات مهرشهر",
                                "خط 7 تعمیرات مهرشهر",
                                "بیرون خط 7 تعمیرات مهرشهر",
                                "خط 8 تعمیرات مهرشهر",
                                "خط 9 واگن سازی مهرشهر",
                                "خط 10 واگن سازی مهرشهر",
                                "خط 11 واگن سازی مهرشهر",
                                "خط 12 تراش مهرشهر",
                                "خط 13 سوله رنگ مهرشهر",
                                "خط 14 تعمیرات مهرشهر",
                                "خط 15 دیزل شاپ مهرشهر",
                                "خط 16 دیزل شاپ مهرشهر",
                                "خط 17 OCS مهرشهر",
                                "خط شمالی AG مهرشهر",
                                "خط جنوبی BG مهرشهر"};

            string[] LineSta=new string[] {
                                    "ایستگاه ارم سبز",
                                    "ایستگاه ورزشگاه آزادی",
                                    "ایستگاه چیتگر",
                                    "ایستگاه ایرانخودرو",
                                    "ایستگاه وردآورد",
                                    "ایستگاه گرمدره",
                                    "ایستگاه اتمسفر",
                                    "ایستگاه کرج",
                                    "سایر"};

            if (AppState.UserLevel < 3)
            {
                StartLocaCombo.Items.AddRange(TehSta);
                StartLocaCombo.Items.AddRange(TehTerm);
                StartLocaCombo.Items.AddRange(GolSta);
                StartLocaCombo.Items.AddRange(MehTerm);
            }
            else
            {
                if (AppState.UserLocal == "پایانه تهران")
                {
                    StartLocaCombo.Items.AddRange(TehSta);
                    StartLocaCombo.Items.AddRange(TehTerm);
                }
                else
                {
                    StartLocaCombo.Items.AddRange(GolSta);
                    StartLocaCombo.Items.AddRange(MehTerm);
                }
            }
            StartLocaCombo.Items.AddRange(LineSta);

            EndLocaCombo.Items.AddRange(StartLocaCombo.Items.Cast<string>().ToArray());
        }

        public void StartLocaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //If StartLocaCombo.SelectedIndex >= 0 Then
                //    If KindCombo.SelectedItem="ورود به خط اصلی" Or KindCombo.SelectedItem="عملیات مانوری" Then
                //
                //        Reader
                //        Dim TrainNum As String
                //        ParkID=0
                //        TrainNum=""
                //        PDate=""
                //        PTime=""

                //       Using  ConnectionString  As New OleDbConnection(AppState.ConnectionString)        StrConnec.Open()
                //
                //       Using CMD As New OleDbCommand("SELECT TOP 1 * FROM Parking WHERE P_Name='" & StartLocaCombo.SelectedItem & "' ORDER BY T_Reg DESC"
                //         Using Reader As OleDbDataReader=CMD.ExecuteReader
                //        While Reader.Read
                //            ParkID=Reader.Item("ID")
                //            TrainNum=Reader.Item("Train").ToString
                //            PDate=Reader.Item("E_Date").ToString
                //            PTime=Reader.Item("E_Time").ToString
                //        End While
                //      End Using
                //       End Using

                //        If TrainNum="" Then
                //            ErrorShow(StartLocaCombo, "قطاری در مبدا حرکت نیست")
                //            ' StartLocaCombo.SelectedIndex=-1      ** کنترل خطای مبدا
                //        Else
                //            TrainNumBox.Text=TrainNum
                //        End If
                //    End If
                //End If
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void EndLocaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //If StartLocaCombo.SelectedIndex >= 0 Then
                //    If KindCombo.SelectedItem="خروج از خط اصلی" Or KindCombo.SelectedItem="عملیات مانوری" Then
                //
                //        Reader
                //
                //        Dim TrainNum As String
                //        ParkID1=0
                //        TrainNum=""
                //        PDate1=""
                //        PTime1=""

                //       Using  ConnectionString  As New OleDbConnection(AppState.ConnectionString)        StrConnec.Open()
                //       Using CMD As New OleDbCommand("SELECT TOP 1 * FROM Parking WHERE P_Name='" & EndLocaCombo.SelectedItem & "' ORDER BY T_Reg DESC"
                //         Using Reader As OleDbDataReader=CMD.ExecuteReader
                //        While Reader.Read
                //            ParkID1=Reader.Item("ID")
                //            TrainNum=Reader.Item("Train").ToString
                //            PDate1=Reader.Item("E_Date").ToString
                //            PTime1=Reader.Item("E_Time").ToString
                //        End While
                //      End Using
                //       End Using

                //        If TrainNum <> "" Then
                //            If TrainNum <> TrainNumBox.Text And (ShamsiToMiladi(PDate1) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate1=PersianCalendar.Text And PTime1 < StartBox.Text)) Then
                //                ErrorShow(EndLocaCombo, "قطار " & TrainNum & " در مقصد حرکت پارک شده است")
                //                ' EndLocaCombo.SelectedIndex=-1     کنترل خطای مقصد
                //            Else
                //                TrainNumBox.Text=TrainNum
                //            End If
                //        End If
                //    End If
                //End If
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }


        public void StartBox_Leave(object sender, EventArgs e)
        {
            TimeLabel.Text="--:--";
            if (TimeToDouble(StartBox.Text, true) > 0 && TimeToDouble(EndBox.Text, true) > 0)
            {
                double StartTime=0;
                double EndTime=0;

                if ((string)KindCombo.SelectedItem == "ورود به خط اصلی")
                {
                    StartTime=TimeToDouble(EndBox.Text);
                    EndTime=TimeToDouble(StartBox.Text);
                }
                else if ((string)KindCombo.SelectedItem == "خروج از خط اصلی" || (string)KindCombo.SelectedItem == "عملیات مانوری")
                {
                    StartTime=TimeToDouble(StartBox.Text);
                    EndTime=TimeToDouble(EndBox.Text);
                }

                if (StartTime > EndTime)
                {
                    TimeLabel.Text=DoubleToTime(EndTime - StartTime + 24);
                }
                else
                {
                    TimeLabel.Text=DoubleToTime(EndTime - StartTime);
                }
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate=ShamsiToMiladi(PersianCalendar.Text);

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع اعزام را مشخص کنید");

                }
                else if (TypeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TypeCombo, "وضعیت اعزام را مشخص کنید");

                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ اعزام صحیح نیست");

                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");

                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "پایانه را مشخص کنید");

                }
                else if (TrainNumBox.Text.Replace(" ", "").Length < 5)
                {
                    ErrorShow(TrainNumBox, "شماره قطار صحیح نیست");

                }
                else if (TrainNumBox.Text.Substring(0, 2) == TrainNumBox.Text.Substring(3, 2))
                {
                    ErrorShow(TrainNumBox, "شماره قطار صحیح نیست");

                }
                else if (TimeToDouble(StartBox.Text, true) <= 0)
                {
                    ErrorShow(StartBox, "ساعت شروع صحیح نیست");

                }
                else if (TimeToDouble(EndBox.Text, true) <= 0)
                {
                    ErrorShow(EndBox, "ساعت پایان صحیح نیست");

                }
                else if (TimeToDouble(TimeLabel.Text) <= 0 || TimeToDouble(TimeLabel.Text) > 4)
                {
                    ErrorShow(StartBox, "مدت عملیات صحیح نیست");
                    ErrorShow(EndBox, "مدت عملیات صحیح نیست");

                }
                else if (Name1Box.Text.Length == 0)
                {
                    ErrorShow(Name1Box, "نام راهبر اصلی را مشخص کنید");

                }
                else if (Name3Box.Text.Length == 0)
                {
                    ErrorShow(Name3Box, "نام راهبر Slave را مشخص کنید");

                }
                else if (Name1Box.Text == Name3Box.Text)
                {
                    ErrorShow(Name1Box, "نام راهبران یکسان است");
                    ErrorShow(Name3Box, "نام راهبران یکسان است");
                    //ElseIf Name2Box.Text.Length=0 Then
                    //ErrorShow(Name2Box, "نام کمک راهبر Master را مشخص کنید")

                }
                else if (StartLocaCombo.SelectedIndex < 0)
                {
                    ErrorShow(StartLocaCombo, "مبدا حرکت را انتخاب کنید");

                }
                else if (EndLocaCombo.SelectedIndex < 0)
                {
                    ErrorShow(EndLocaCombo, "مقصد حرکت را انتخاب کنید");

                }
                else if (CancelCheck.Checked && MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "لطفا توضیحات تکمیلی در مورد کنسلی را وارد کنید");

                }
                else if (MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "لطفا توضیحات تکمیلی را وارد کنید");

                }
                else
                {
                    Enabled=false;
                    //Dim Trip As String=""
                    if (DateTime.Parse(TimeLabel.Text) > DateTime.Parse("04:00"))
                    {
                        if (MessageBoxFa.Show("زمان عملیات قطار بیشتر از حد مجاز است ! \n\n آیا تایید می کنید؟", "توجه", MessageBoxIcon.Warning, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    int ProID=0;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM TerminalProcess WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ProID=Convert.ToInt32(Reader["Table_Num"]);
                                    if (Reader["U_Conf"].ToString() != "")
                                    {
                                        StrConnec.Close();
                                        Enabled=true;
                                        MessageBoxFa.Show("برای این تاریخ تایید نهایی انجام شده است", "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }

                        }


                        if (ProID == 0)
                        {
                            StrConnec.Close();
                            Enabled=true;
                            MessageBoxFa.Show("برای این تاریخ پردازش انجام نشده است", "خطا", MessageBoxIcon.Error);
                            return;
                        }

                        //Dim Fi As Boolean=True
                        //CMD.CommandText="SELECT * FROM Navgan WHERE ((Loco1='" & TrainNumBox.Text.Substring(0, 2) & "' AND Loco2='" & TrainNumBox.Text.Substring(3, 2) & "') OR (Loco1='" & TrainNumBox.Text.Substring(3, 2) & "' OR Loco2='" & TrainNumBox.Text.Substring(0, 2) & "')) AND Vis=True"
                        // Using Reader As OleDbDataReader=CMD.ExecuteReader
                        //While Reader.Read
                        //    Fi=False
                        //End While
                        //Reader.Close()
                        //If Fi Then
                        //   End Using
                        //    Me.Enabled=True
                        //    MessageBoxFa.Show("این شماره قطار در ناوگان فعال قرار ندارد", "خطا", MessageBoxIcon.Error)
                        //    Exit Sub
                        //End If

                        if ((string)KindCombo.SelectedItem != "عملیات مانوری")
                        {

                            string QueStr="SELECT * FROM TerminalTableTrip WHERE T_ID=" + ProID.ToString() + " AND E_Time='" + StartBox.Text + "' AND E_Kind='";

                            using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                            {
                                if ((string)KindCombo.SelectedItem == "ورود به خط اصلی")
                                {
                                    CMD.CommandText += "ورودی'";
                                }
                                else if ((string)KindCombo.SelectedItem == "خروج از خط اصلی")
                                {
                                    CMD.CommandText += "خروجی'"; //AND (E_Start='" &  & "' OR E_End='') ** اصلاح : مقایسه مبدا
                                }
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        StrConnec.Close();
                                        Enabled=true;
                                        MessageBoxFa.Show("این حرکت در جدول حرکتی وجود دارد \n ", "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }

                            }

                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM TerminalTrip WHERE Tarikh='" + PersianCalendar.Text + "' AND (O1_Num='" + P1Num + "' OR O3_Num='" + P1Num + "') AND Vis=True", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DateTime E_strat;
                                    DateTime E_End;
                                    DateTime S_text;
                                    DateTime E_Text;
                                    if (Reader["E_Kind"].ToString() == "ورود به خط اصلی")
                                    {
                                        E_strat=Convert.ToDateTime(DateTime.Parse(Reader["E_Time"].ToString()).AddMinutes(15));
                                        E_End=Convert.ToDateTime(DateTime.Parse(Reader["Trip_Time"].ToString()).AddMinutes(-15));
                                    }
                                    else
                                    {
                                        E_strat=Convert.ToDateTime(DateTime.Parse(Reader["Trip_Time"].ToString()).AddMinutes(15));
                                        E_End=Convert.ToDateTime(DateTime.Parse(Reader["E_Time"].ToString()).AddMinutes(-15));
                                    }

                                    if ((string)KindCombo.SelectedItem == "ورود به خط اصلی")
                                    {
                                        S_text=DateTime.Parse(EndBox.Text);
                                        E_Text=DateTime.Parse(StartBox.Text);
                                    }
                                    else
                                    {
                                        S_text=DateTime.Parse(StartBox.Text);
                                        E_Text=DateTime.Parse(EndBox.Text);
                                    }

                                    if ((E_strat < S_text && E_End > S_text) || (E_strat < E_Text && E_End > E_Text) || (E_strat > S_text && E_End > S_text && E_strat < E_Text && E_End < E_Text))
                                    {
                                        string Mes="تداخل با حرکت " + Name1Box.Text + "\n\n" + Reader["E_Kind"].ToString() + " قطار " + Reader["Train"].ToString() + " از " + Reader["StartLocation"].ToString();
                                        StrConnec.Close();
                                        Enabled=true;
                                        MessageBoxFa.Show(Mes, "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }

                        }


                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM TerminalTrip WHERE Tarikh='" + PersianCalendar.Text + "' AND (O1_Num='" + P3Num + "' OR O3_Num='" + P3Num + "') AND Vis=True", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DateTime E_strat;
                                    DateTime E_End;
                                    DateTime S_text;
                                    DateTime E_Text;
                                    if (Reader["E_Kind"].ToString() == "ورود به خط اصلی")
                                    {
                                        E_strat=Convert.ToDateTime(DateTime.Parse(Reader["E_Time"].ToString()).AddMinutes(15));
                                        E_End=Convert.ToDateTime(DateTime.Parse(Reader["Trip_Time"].ToString()).AddMinutes(-15));
                                    }
                                    else
                                    {
                                        E_strat=Convert.ToDateTime(DateTime.Parse(Reader["Trip_Time"].ToString()).AddMinutes(15));
                                        E_End=Convert.ToDateTime(DateTime.Parse(Reader["E_Time"].ToString()).AddMinutes(-15));
                                    }

                                    if ((string)KindCombo.SelectedItem == "ورود به خط اصلی")
                                    {
                                        S_text=DateTime.Parse(EndBox.Text);
                                        E_Text=DateTime.Parse(StartBox.Text);
                                    }
                                    else
                                    {
                                        S_text=DateTime.Parse(StartBox.Text);
                                        E_Text=DateTime.Parse(EndBox.Text);
                                    }

                                    if ((E_strat < S_text && E_End > S_text) || (E_strat < E_Text && E_End > E_Text) || (E_strat > S_text && E_End > S_text && E_strat < E_Text && E_End < E_Text))
                                    {
                                        string Mes="تداخل با حرکت " + Name1Box.Text + "\n\n" + Reader["E_Kind"].ToString() + " قطار " + Reader["Train"].ToString() + " از " + Reader["StartLocation"].ToString();
                                        StrConnec.Close();
                                        Enabled=true;
                                        MessageBoxFa.Show(Mes, "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }

                        }


                        //If KindCombo.SelectedItem="ورود به خط اصلی" Then
                        //    If ShamsiToMiladi(PDate) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate=PersianCalendar.Text And PTime < StartBox.Text) Then
                        //       Using CMD As New OleDbCommand("UPDATE Parking SET Vis=False WHERE ID=" & ParkID
                        //        CMD.ExecuteNonQuery()

                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & StartLocaCombo.SelectedItem & "', '', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True, " & ParkID & ", '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()

                        //    Else
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & StartLocaCombo.SelectedItem & "', '', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', False, 0, '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    End If

                        //ElseIf KindCombo.SelectedItem="خروج از خط اصلی" Then
                        //    If ShamsiToMiladi(PDate1) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate1=PersianCalendar.Text And PTime1 < StartBox.Text) Then
                        //       Using CMD As New OleDbCommand("UPDATE Parking SET Vis=False WHERE ID=" & ParkID1
                        //        CMD.ExecuteNonQuery()

                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & EndLocaCombo.SelectedItem & "', '" & TrainNumBox.Text & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True, " & ParkID1 & ", '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()

                        //    Else
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & EndLocaCombo.SelectedItem & "', '" & TrainNumBox.Text & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', False, 0, '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    End If

                        //Else
                        //    If ShamsiToMiladi(PDate) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate=PersianCalendar.Text And PTime < StartBox.Text) Then
                        //       Using CMD As New OleDbCommand("UPDATE Parking SET Vis=False WHERE ID=" & ParkID
                        //        CMD.ExecuteNonQuery()

                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & StartLocaCombo.SelectedItem & "', '', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True, " & ParkID & ", '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()

                        //    Else
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & StartLocaCombo.SelectedItem & "', '', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', False, 0, '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    End If
                        //    If ShamsiToMiladi(PDate1) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate1=PersianCalendar.Text And PTime1 < StartBox.Text) Then
                        //       Using CMD As New OleDbCommand("UPDATE Parking SET Vis=False WHERE ID=" & ParkID1
                        //        CMD.ExecuteNonQuery()

                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & EndLocaCombo.SelectedItem & "', '" & TrainNumBox.Text & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True, " & ParkID1 & ", '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()

                        //    Else
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & EndLocaCombo.SelectedItem & "', '" & TrainNumBox.Text & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', False, 0, '" & LocalCombo.SelectedItem & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    End If
                        //End If

                        if (CancelCheck.Checked)
                        {
                            MemBox.Text="کنسل شد * " + MemBox.Text.Trim();
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTrip (Tarikh, E_Loca, Trip_Time, E_Time, E_Mine, Train, O1_Num, O3_Num, E_Kind, E_Position, StartLocation, EndLocation, Mem, U_Reg, T_Reg, Vis) VALUES ('" + PersianCalendar.Text + "', '" + LocalCombo.SelectedItem + "', '" + StartBox.Text + "', '" + EndBox.Text + "', '" + TimeToMinute(TimeLabel.Text) + "', '" + TrainNumBox.Text + "', '" + P1Num + "', '" + P3Num + "', '" + KindCombo.SelectedItem + "', '" + TypeCombo.SelectedItem + "', '" + StartLocaCombo.Text + "', '" + EndLocaCombo.Text + "', @Mem, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }

                    }


                    KindCombo.SelectedIndex=-1;
                    StartBox.Text="";
                    EndBox.Text="";
                    TrainNumBox.Text="";
                    Name1Box.Text="";
                    Name1Button.Image=Properties.Resources.user;
                    Name3Box.Text="";
                    Name3Button.Image=Properties.Resources.user;
                    TypeCombo.Text="";
                    StartLocaCombo.Text="";
                    EndLocaCombo.Text="";
                    MemBox.Text="";
                    StartLocaCombo.SelectedIndex=-1;
                    EndLocaCombo.SelectedIndex=-1;
                    LocalCombo.SelectedIndex=-1;

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

        public void Name3Button_Click(object sender, EventArgs e)
        {
            Name3Box.Text="";
            Name3Button.Image=Properties.Resources.user;
            PersonalSelectForm.Per="راهبر";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                P1Family=PersonalSelectForm.PFamily;
                P1Name=PersonalSelectForm.PName;
                P1Num=PersonalSelectForm.PNum;
                Name1Box.Text=P1Name + " " + P1Family;
                Name1Button.Image=Properties.Resources.cancel1;
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            TypeCombo.Items.Clear();

            if ((string)KindCombo.SelectedItem == "ورود به خط اصلی")
            {
                //  TypeCombo.Items.Add("طبق جدول اعزام")
                TypeCombo.Items.Add("قطار فوق العاده");
                TypeCombo.Items.Add("تعویض قطار معیوب");
                TypeCombo.Items.Add("قطار درخواستی");

                Label6.Text="زمان اعزام:";
                Label12.Text="زمان شروع:";
                Label4.Visible=true;

            }
            else if ((string)KindCombo.SelectedItem == "خروج از خط اصلی")
            {
                // TypeCombo.Items.Add("طبق جدول اعزام")
                TypeCombo.Items.Add("قطار اضافی");
                TypeCombo.Items.Add("قطار معیوب");
                TypeCombo.Items.Add("قطار درخواستی");

                Label6.Text="زمان اعزام:";
                Label12.Text="زمان پایان:";
                Label4.Visible=true;

            }
            else if ((string)KindCombo.SelectedItem == "عملیات مانوری")
            {
                TypeCombo.Items.Add("جابجایی قطار");
                TypeCombo.Items.Add("قطار دوار");
                TypeCombo.Items.Add("شستشوی قطار");
                TypeCombo.Items.Add("تست بهسازی");
                TypeCombo.Items.Add("تست تعمیرات");
                TypeCombo.Items.Add("تست ATP");

                Label6.Text="زمان شروع:";
                Label12.Text="زمان پایان:";
                Label4.Visible=false;
            }
            StartBox_Leave(null, null);
        }

        public void Name1Button_Click(object sender, EventArgs e)
        {
            Name1Box.Text="";
            Name1Button.Image=Properties.Resources.user;
            PersonalSelectForm.Per="راهبر";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                P3Family=PersonalSelectForm.PFamily;
                P3Name=PersonalSelectForm.PName;
                P3Num=PersonalSelectForm.PNum;
                Name3Box.Text=P3Name + " " + P3Family;
                Name3Button.Image=Properties.Resources.cancel1;
            }
        }
    }
}
