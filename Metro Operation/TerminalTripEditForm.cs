using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class TerminalTripEditForm
    {
        public TerminalTripEditForm()
        {
            InitializeComponent();
        }

        private string ID; // WD,
        private string Fad;
        private string P1Name;
        private string P1Family;
        private string P1Num;
        private string P2Name;
        private string P2Family;
        private string P2Num;
        private string P3Name;
        private string P3Family;
        private string P3Num;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clean()
        {
            ID="";
            PersianCalendar.Text="";
            StartBox.Text="";
            EndBox.Text="";
            TrainNumBox.Text="";
            P1Num="";
            P2Num="";
            P3Num="";
            MemBox.Text="";
            Fad="";
            KindCombo.SelectedIndex=-1;
            LocalCombo.SelectedIndex=-1;
            StartLocaCombo.SelectedIndex=-1;
            EndLocaCombo.SelectedIndex=-1;
            Name1Box.Text="";
            Name1Button.Image=Properties.Resources.user;
            Name2Box.Text="";
            Name2Button.Image=Properties.Resources.user;
            Name3Box.Text="";
            Name3Button.Image=Properties.Resources.user;
            StartLocaCombo.Text="";
            EndLocaCombo.Text="";
            TimeLabel.Text="00:00";
            MemBox.Text="";
            Panel2.Enabled=false;
            RegButton.Enabled=false;
            DelButton.Enabled=false;
        }

        public void TerminalTripEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                Clean();
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

                if (AppState.UserLevel < 3 || AppState.UserLevel < 17)
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
                //    If KindCombo.SelectedItem="خروج از خط اصلی" Then
                //
                //        Reader

                //       Using  ConnectionString  As New OleDbConnection(AppState.ConnectionString)        StrConnec.Open()
                //

                //        Dim TrainNum As String=""
                //       Using CMD As New OleDbCommand("SELECT TOP 1 * FROM Parking WHERE P_Name='" & EndLocaCombo.SelectedItem & "' ORDER BY T_Reg DESC"
                //         Using Reader As OleDbDataReader=CMD.ExecuteReader
                //        While Reader.Read
                //            ParkID=Reader.Item("ID")
                //            TrainNum=Reader.Item("Train").ToString
                //        End While
                //      End Using
                //       End Using

                //        If TrainNum <> "" Then
                //            ErrorShow(EndLocaCombo, "قطار " & TrainNum & " در مقصد حرکت پارک شده است")
                //            '  EndLocaCombo.SelectedIndex=-1      کنترل خطای مقصد
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

        public void StartLocaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //If StartLocaCombo.SelectedIndex >= 0 Then
                //    If KindCombo.SelectedItem="ورود به خط اصلی" Then
                //
                //        Reader

                //       Using  ConnectionString  As New OleDbConnection(AppState.ConnectionString)        StrConnec.Open()
                //

                //        Dim TrainNum As String=""
                //       Using CMD As New OleDbCommand("SELECT TOP 1 * FROM Parking WHERE P_Name='" & StartLocaCombo.SelectedItem & "' ORDER BY T_Reg DESC"
                //         Using Reader As OleDbDataReader=CMD.ExecuteReader
                //        While Reader.Read
                //            ParkID=Reader.Item("ID")
                //            TrainNum=Reader.Item("Train").ToString
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

        public void SearchPersianCalendar_TextChanged(object sender, EventArgs e)
        {
            Clean();
        }

        public void SearchTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean();
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeCombo.Enabled)
                {
                    if (MessageBoxFa.Show(" حرکت حذف گردد؟", "تایید", MessageBoxIcon.Warning, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Enabled=false;

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            string QueStr="UPDATE TerminalTrip SET Vis=False, Fad=-";
                            if (!string.IsNullOrEmpty(Fad))
                            {
                                QueStr += Fad;
                            }
                            else
                            {
                                QueStr += ID;
                            }
                            QueStr += " WHERE ID=" + ID;

                            using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                        }


                        Clean();
                        Enabled=true;
                        MessageBoxFa.Show("حذف با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBoxFa.Show("شما مجاز به حذف این مورد نمی باشید", "خطا", MessageBoxIcon.Error);
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
                else if (TimeToDouble(TimeLabel.Text, true) <= 0)
                {
                    ErrorShow(StartBox, "مدت عملیات صحیح نیست");
                    ErrorShow(EndBox, "مدت عملیات صحیح نیست");
                }
                else if (Name1Box.Text == "")
                {
                    ErrorShow(Name1Box, "نام راهبر اصلی را مشخص کنید");
                }
                else if (Name3Box.Text == "")
                {
                    ErrorShow(Name3Box, "نام راهبر Slave را مشخص کنید");
                }
                else if (Name1Box.Text == Name2Box.Text)
                {
                    ErrorShow(Name1Box, "نام راهبران یکسان است");
                    ErrorShow(Name2Box, "نام راهبران یکسان است");
                }
                else if (Name2Box.Text == Name3Box.Text)
                {
                    ErrorShow(Name2Box, "نام راهبران یکسان است");
                    ErrorShow(Name3Box, "نام راهبران یکسان است");
                }
                else if (Name1Box.Text == Name3Box.Text)
                {
                    ErrorShow(Name1Box, "نام راهبران یکسان است");
                    ErrorShow(Name3Box, "نام راهبران یکسان است");
                    //ElseIf Name2Box.Text="" Then
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
                else if (MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "توضیحات تکمیلی را وارد کنید");
                }
                else
                {

                    string Trip="";
                    Enabled=false;

                    TimeSpan.TryParse(TimeLabel.Text, out TimeSpan labelTime);
                    if (labelTime > new TimeSpan(6, 0, 0))
                    {
                        if (MessageBoxFa.Show("زمان عملیات قطار بیشتر از حد مجاز است ! \n\n آیا تایید می کنید؟", "توجه", MessageBoxIcon.Warning, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        //CMD.CommandText="SELECT * FROM Navgan WHERE Loco1='" & TrainNumBox.Text.Substring(0, 2) & "' OR Loco2='" & TrainNumBox.Text.Substring(0, 2) & "' AND Vis=True"
                        // Using Reader As OleDbDataReader=CMD.ExecuteReader
                        //While Reader.Read
                        //    If Reader.Item("Loco1").ToString & "-" & Reader.Item("Loco2").ToString <> TrainNumBox.Text And Reader.Item("Loco2").ToString & "-" & Reader.Item("Loco1").ToString <> TrainNumBox.Text Then
                        //       End Using
                        //        MessageBoxFa.Show("این شماره قطار در ناوگان فعال قرار ندارد", "خطا", MessageBoxIcon.Error)
                        //        Me.Enabled=True
                        //        Exit Sub
                        //    End If
                        //End While
                        //Reader.Close()
                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM TerminalTrip WHERE Tarikh='" + PersianCalendar.Text + "' AND (O1_Num='" + P1Num + "' OR O3_Num='" + P1Num + "') AND Vis=True AND ID<>" + ID, StrConnec))
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
                                        Trip="تداخل با حرکت " + Name1Box.Text + "\n\n" + Reader["E_Kind"].ToString() + " قطار " + Reader["Train"].ToString() + " از " + Reader["StartLocation"].ToString();
                                    }
                                }
                            }

                        }


                        if (!string.IsNullOrEmpty(Trip))
                        {
                            StrConnec.Close();
                            MessageBoxFa.Show(Trip, "خطا", MessageBoxIcon.Error);
                            Enabled=true;
                            return;
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM TerminalTrip WHERE Tarikh='" + PersianCalendar.Text + "' AND (O1_Num='" + P3Num + "' OR O3_Num='" + P3Num + "') AND Vis=True AND ID<>" + ID, StrConnec))
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
                                        Trip="تداخل با حرکت " + Name3Box.Text + "\n\n" + Reader["E_Kind"].ToString() + " قطار " + Reader["Train"].ToString() + " از " + Reader["StartLocation"].ToString();
                                    }
                                }
                            }

                        }


                        if (!string.IsNullOrEmpty(Trip))
                        {
                            StrConnec.Close();
                            Enabled=true;
                            MessageBoxFa.Show(Trip, "خطا", MessageBoxIcon.Error);
                            return;
                        }

                        using (OleDbCommand CMD=new OleDbCommand("UPDATE TerminalTrip SET Vis=False WHERE ID=" + ID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }


                        if (CancelCheck.Checked)
                        {
                            MemBox.Text="کنسل شد * " + MemBox.Text.Trim();
                        }
                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTrip (Tarikh, E_Loca, Trip_Time, E_Time, E_Mine, Train, O1_Num, O2_Num, O3_Num, E_Kind, E_Position, StartLocation, EndLocation, Mem, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PersianCalendar.Text + "', '" + LocalCombo.SelectedItem + "', '" + StartBox.Text + "', '" + EndBox.Text + "', '" + TimeToMinute(TimeLabel.Text) + "', '" + TrainNumBox.Text + "', '" + P1Num + "', '" + P2Num + "', '" + P3Num + "', '" + KindCombo.SelectedItem + "', '" + TypeCombo.SelectedItem + "', '" + StartLocaCombo.Text + "', '" + EndLocaCombo.Text + "', @Mem, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + ID + ")", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }

                    }


                    Clean();
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

        public void Name1Button_Click(object sender, EventArgs e)
        {
            Name1Box.Text="";
            Name1Button.Image=Properties.Resources.user;
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

        public void Name3Button_Click(object sender, EventArgs e)
        {
            Name3Box.Text="";
            Name3Button.Image=Properties.Resources.user;
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeCombo.Items.Clear();

            if ((string)KindCombo.SelectedItem == "ورود به خط اصلی")
            {
                TypeCombo.Items.Add("قطار فوق العاده");
                TypeCombo.Items.Add("تعویض قطار معیوب");
                TypeCombo.Items.Add("قطار درخواستی");

                Label6.Text="زمان اعزام:";
                Label12.Text="زمان شروع:";
                Label4.Visible=true;

            }
            else if ((string)KindCombo.SelectedItem == "خروج از خط اصلی")
            {
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

        public void SearchKindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)SearchKindCombo.SelectedItem == "ورود به خط اصلی")
            {
                SearchTypeCombo.Items.Add("طبق جدول اعزام");
                SearchTypeCombo.Items.Add("قطار فوق العاده");
                SearchTypeCombo.Items.Add("تعویض قطار معیوب");
                SearchTypeCombo.Items.Add("قطار درخواستی");

            }
            else if ((string)SearchKindCombo.SelectedItem == "خروج از خط اصلی")
            {
                SearchTypeCombo.Items.Add("طبق جدول اعزام");
                SearchTypeCombo.Items.Add("قطار اضافی");
                SearchTypeCombo.Items.Add("قطار معیوب");
                SearchTypeCombo.Items.Add("قطار درخواستی");

            }
            else if ((string)SearchKindCombo.SelectedItem == "عملیات مانوری")
            {
                SearchTypeCombo.Items.Add("جابجایی قطار");
                SearchTypeCombo.Items.Add("قطار دوار");
                SearchTypeCombo.Items.Add("شستشوی قطار");
                SearchTypeCombo.Items.Add("تست بهسازی");
                SearchTypeCombo.Items.Add("تست تعمیرات");
                SearchTypeCombo.Items.Add("تست ATP");
            }
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clean();
                DateTime SelectDate=ShamsiToMiladi(SearchPersianCalendar.Text);

                if (SearchKindCombo.SelectedIndex < 0)
                {
                    ErrorShow(SearchKindCombo, "نوع اعزام را مشخص کنید");
                }
                else if (SearchTypeCombo.SelectedIndex < 0)
                {
                    ErrorShow(SearchTypeCombo, "وضعیت اعزام را مشخص کنید");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(SearchPersianCalendar, "تاریخ اعزام صحیح نیست");
                }
                else if (!DateChecker(SearchPersianCalendar.Text))
                {
                    ErrorShow(SearchPersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (SearchTrainNumBox.Text.Replace(" ", "").Length < 5)
                {
                    ErrorShow(SearchTrainNumBox, "شماره قطار صحیح نیست");
                }
                else if (SearchTrainNumBox.Text.Substring(0, 2) == SearchTrainNumBox.Text.Substring(3, 2))
                {
                    ErrorShow(SearchTrainNumBox, "شماره قطار صحیح نیست");
                }
                else if (SearchStartBox.Text == null)
                {
                    ErrorShow(SearchStartBox, "ساعت شروع صحیح نیست");
                }
                else
                {
                    string StartLoca="";
                    string EndLoca="";

                    StartLoca="";
                    EndLoca="";
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM TerminalTrip WHERE Tarikh='" + SearchPersianCalendar.Text + "' AND Trip_Time='" + SearchStartBox.Text + "' AND Train='" + SearchTrainNumBox.Text + "' AND E_Kind='" + SearchKindCombo.SelectedItem + "' AND E_Position='" + SearchTypeCombo.SelectedItem + "' AND Vis=True", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Reader["ID"].ToString();
                                    PersianCalendar.Text=Reader["Tarikh"].ToString();
                                    LocalCombo.SelectedItem=Reader["E_Loca"].ToString();
                                    TrainNumBox.Text=Reader["Train"].ToString();
                                    P1Num=Reader["O1_Num"].ToString();
                                    P2Num=Reader["O2_Num"].ToString();
                                    P3Num=Reader["O3_Num"].ToString();
                                    KindCombo.SelectedItem=Reader["E_Kind"].ToString();
                                    TypeCombo.Items.Add("طبق جدول اعزام");
                                    StartBox.Text=Reader["Trip_Time"].ToString();
                                    EndBox.Text=Reader["E_Time"].ToString();
                                    TypeCombo.SelectedItem=Reader["E_Position"].ToString();
                                    if ((string)TypeCombo.SelectedItem == "طبق جدول اعزام")
                                    {
                                        KindCombo.Enabled=false;
                                        TypeCombo.Enabled=false;
                                        PersianCalendar.Enabled=false;
                                        StartBox.Enabled=false;
                                        LocalCombo.Enabled=false;
                                    }
                                    else
                                    {
                                        KindCombo.Enabled=true;
                                        TypeCombo.Enabled=true;
                                        PersianCalendar.Enabled=true;
                                        StartBox.Enabled=true;
                                        LocalCombo.Enabled=true;
                                    }

                                    StartLoca=Reader["StartLocation"].ToString();
                                    EndLoca=Reader["EndLocation"].ToString();

                                    if (Reader["Mem"].ToString().Length > 9)
                                    {
                                        if (Reader["Mem"].ToString().Substring(0, 10) == "کنسل شد * ")
                                        {
                                            CancelCheck.Checked=true;
                                            MemBox.Text=Reader["Mem"].ToString().Substring(10, Convert.ToInt32(Reader["Mem"].ToString().Length - 10));
                                        }
                                        else
                                        {
                                            MemBox.Text=Reader["Mem"].ToString();
                                        }
                                    }
                                    Fad=Reader["Fad"].ToString();
                                }
                            }
                        }


                        DataRow[] DRow;
                        if (!string.IsNullOrEmpty(P1Num))
                        {
                            DRow=MainForm.PersonTable.Select("P_Num='" + P1Num + "'");
                            P1Family=DRow[0]["Family"].ToString();
                            P1Name=DRow[0]["Fname"].ToString();
                            Name1Box.Text=P1Name + " " + P1Family;
                            Name1Button.Image=Properties.Resources.cancel1;
                        }

                        if (!string.IsNullOrEmpty(P2Num))
                        {
                            DRow=MainForm.PersonTable.Select("P_Num='" + P2Num + "'");
                            P2Family=DRow[0]["Family"].ToString();
                            P2Name=DRow[0]["Fname"].ToString();
                            Name2Box.Text=P2Name + " " + P2Family;
                            Name2Button.Image=Properties.Resources.cancel1;
                        }

                        if (!string.IsNullOrEmpty(P3Num))
                        {
                            DRow=MainForm.PersonTable.Select("P_Num='" + P3Num + "'");
                            P3Family=DRow[0]["Family"].ToString();
                            P3Name=DRow[0]["Fname"].ToString();
                            Name3Box.Text=P3Name + " " + P3Family;
                            Name3Button.Image=Properties.Resources.cancel1;
                        }

                    }


                    StartBox_Leave(null, null);
                    StartLocaCombo.Text=StartLoca;
                    EndLocaCombo.Text=EndLoca;

                    if (string.IsNullOrEmpty(ID))
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Panel2.Enabled=true;
                        RegButton.Enabled=true;
                        DelButton.Enabled=true;
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
    }
}
