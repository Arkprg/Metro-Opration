using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TerminalTableTripRegForm
    {
        public TerminalTableTripRegForm()
        {
            InitializeComponent();
        }


        private string P1Name;
        private string P1Family;
        private string P1Num;
        private string P3Name;
        private string P3Family;
        private string P3Num;
        //private string Btm;
        //private readonly string PTime;
        //private readonly string PDate;
        //private readonly int ParkID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();

                if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) > DateTime.Today)
                {
                    ErrorShow(PersianCalendar, "تاریخ حرکت صحیح نیست");
                    PersianCalendar.Focus();
                    return;
                }

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    string QueStr="SELECT * FROM TerminalTrip WHERE Tarikh='" + PersianCalendar.Text + "' AND E_Position='طبق جدول اعزام' AND Vis=True";
                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND E_Loca='" + AppState.UserLocal + "'";
                    }

                    QueStr += " ORDER BY E_Loca, Trip_Time";

                    using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ShowGridView.Rows.Add(ShowGridView.RowCount + 1, Reader["Trip_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["StartLocation"].ToString(), Reader["ENDLocation"].ToString(), Reader["E_Time"].ToString(), "", Reader["O1_Num"].ToString(), "", Reader["O3_Num"].ToString(), Reader["Train"].ToString(), Reader["ID"].ToString(), Reader["E_Loca"].ToString());
                        }
                    }
                }


                if (ShowGridView.RowCount > 0)
                {
                    ShowGridView.CurrentRow.Selected=false;

                    int i;
                    for (i=0; i <= ShowGridView.RowCount - 1; i++)
                    {
                        if (ShowGridView.Rows[i].Cells[7].Value.ToString() != "")
                        {
                            DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[7].Value.ToString() + "'");
                            if (DRow.Length > 0)
                            {
                                ShowGridView.Rows[i].Cells[6].Value=DRow[0]["Fname"] + " " + DRow[0]["Family"];
                            }

                            ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.LightGreen;
                        }
                        if (ShowGridView.Rows[i].Cells[9].Value.ToString() != "")
                        {
                            DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[9].Value.ToString() + "'");
                            if (DRow.Length > 0)
                            {
                                ShowGridView.Rows[i].Cells[8].Value=DRow[0]["Fname"] + " " + DRow[0]["Family"];
                            }
                        }
                    }
                }
                else
                {
                    MessageBoxFa.Show("برای این تاریخ پردازش انجام نشده است", "خطا", MessageBoxIcon.Error);
                }
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
            if (ConvertClass.TimeToDouble(EndBox.Text, true) > 0 && ConvertClass.TimeToDouble(StartBox.Text, true) > 0)
            {
                double StartTime=0;
                double EndTime=0;

                if (KindLabel.Text == "ورود به خط اصلی")
                {
                    StartTime=ConvertClass.TimeToDouble(EndBox.Text);
                    EndTime=ConvertClass.TimeToDouble(StartBox.Text);
                }
                else if (KindLabel.Text == "خروج از خط اصلی")
                {
                    StartTime=ConvertClass.TimeToDouble(StartBox.Text);
                    EndTime=ConvertClass.TimeToDouble(EndBox.Text);
                }

                if (StartTime > EndTime)
                {
                    TimeLabel.Text=ConvertClass.DoubleToTime(EndTime - StartTime + 24);
                }
                else
                {
                    TimeLabel.Text=ConvertClass.DoubleToTime(EndTime - StartTime);
                }
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrainNumBox.Text.Replace(" ", "").Length < 5)
                {
                    ErrorShow(TrainNumBox, "شماره قطار صحیح نیست");
                }
                else if (TrainNumBox.Text.Substring(0, 2) == TrainNumBox.Text.Substring(3, 2))
                {
                    ErrorShow(TrainNumBox, "شماره قطار صحیح نیست");
                }
                else if (ConvertClass.TimeToDouble(StartBox.Text, true) <= 0)
                {
                    ErrorShow(EndBox, "ساعت شروع صحیح نیست");
                }
                else if (ConvertClass.TimeToDouble(EndBox.Text, true) <= 0)
                {
                    ErrorShow(EndBox, "ساعت پایان صحیح نیست");
                }
                else if (ConvertClass.TimeToDouble(TimeLabel.Text, true) <= 0)
                {
                    ErrorShow(TimeLabel, "مدت عملیات صحیح نیست");
                }
                else if (ConvertClass.TimeToDouble(TimeLabel.Text, true) > 2.5)
                {
                    ErrorShow(TimeLabel, "مدت عملیات صحیح نیست");
                }
                else if (StartLocaCombo.SelectedIndex < 0)
                {
                    ErrorShow(StartLocaCombo, "مبدا حرکت را انتخاب کنید");
                }
                else if (EndLocaCombo.SelectedIndex < 0)
                {
                    ErrorShow(EndLocaCombo, "مقصد حرکت را انتخاب کنید");
                }
                else if (Name1Box.Text == "")
                {
                    ErrorShow(Name1Box, "نام راهبر اصلی را مشخص کنید");
                }
                else if (Name3Box.Text == "")
                {
                    ErrorShow(Name3Box, "نام راهبر Slave را مشخص کنید");
                }
                else if (Name1Box.Text == Name3Box.Text)
                {
                    ErrorShow(Name1Box, "نام راهبران یکسان است");
                    ErrorShow(Name3Box, "نام راهبران یکسان است");
                }
                else
                {

                    Enabled=false;
                    int ProID=0;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Table_Num, U_Conf FROM TerminalProcess WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ProID=Convert.ToInt32(Reader["Table_Num"]);

                                if (Reader["U_Conf"].ToString() != "")
                                {
                                    Enabled=true;
                                    StrConnec.Close();
                                    MessageBoxFa.Show("برای این تاریخ تایید نهایی انجام شده است", "خطا", MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        if (ProID == 0)
                        {
                            Enabled=true;
                            StrConnec.Close();
                            MessageBoxFa.Show("برای این تاریخ پردازش انجام نشده است", "خطا", MessageBoxIcon.Error);
                            return;
                        }

                        bool Fi=true;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Navgan WHERE ((Loco1='" + TrainNumBox.Text.Substring(0, 2) + "' AND Loco2='" + TrainNumBox.Text.Substring(3, 2) + "') OR (Loco1='" + TrainNumBox.Text.Substring(3, 2) + "' OR Loco2='" + TrainNumBox.Text.Substring(0, 2) + "')) AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Fi=false;
                            }
                        }

                        if (Fi)
                        {
                            //  Me.Enabled=True
                            MessageBoxFa.Show("این شماره قطار در ناوگان فعال قرار ندارد", "خطا", MessageBoxIcon.Error);
                            //  Exit Sub
                        }

                        string query="SELECT * FROM TerminalTrip WHERE Tarikh=? AND (O1_Num=? OR O3_Num=?) AND Vis=True";
                        using (OleDbCommand cmd=new OleDbCommand(query, StrConnec))
                        {
                            cmd.Parameters.AddWithValue("?", PersianCalendar.Text);
                            cmd.Parameters.AddWithValue("?", P1Num);
                            cmd.Parameters.AddWithValue("?", P1Num);

                            using (OleDbDataReader reader=cmd.ExecuteReader())
                            {
                                if (!DateTime.TryParse(StartBox.Text, out DateTime startInput) || !DateTime.TryParse(EndBox.Text, out DateTime endInput))
                                {
                                    MessageBoxFa.Show("تاریخ یا ساعت نامعتبر است.", "خطا", MessageBoxIcon.Error);
                                    return;
                                }

                                // جابجایی مقادیر ورودی بر اساس KindLabel
                                if (KindLabel.Text == "ورود به خط اصلی")
                                {
                                    DateTime temp=startInput;
                                    startInput=endInput;
                                    endInput=temp;
                                }

                                while (reader.Read())
                                {
                                    bool isMain=reader["E_Kind"].ToString() == "ورود به خط اصلی";

                                    if (!DateTime.TryParse(isMain ? reader["E_Time"].ToString() : reader["Trip_Time"].ToString(), out DateTime eStart) ||
                                        !DateTime.TryParse(isMain ? reader["Trip_Time"].ToString() : reader["E_Time"].ToString(), out DateTime eEnd))
                                    {
                                        continue; // اگر تاریخ‌ها نامعتبر هستند، رد کن
                                    }

                                    // بررسی تداخل با 15 دقیقه اختلاف
                                    DateTime eStartPlus15=eStart.AddMinutes(15);
                                    DateTime eEndMinus15=eEnd.AddMinutes(-15);

                                    bool overlap=(eStartPlus15 < startInput && eEndMinus15 > startInput) ||
                                                   (eStartPlus15 < endInput && eEndMinus15 > endInput) ||
                                                   (eStartPlus15 > startInput && eEndMinus15 > startInput && eStartPlus15 < endInput && eEndMinus15 < endInput);

                                    if (overlap)
                                    {
                                        string mess="تداخل با حرکت ";
                                        mess += isMain ? eEnd.ToString() : eStart.ToString();
                                        mess += "  " + Name1Box.Text + Environment.NewLine + Environment.NewLine +
                                                reader["E_Kind"].ToString() + " قطار " + reader["Train"].ToString() +
                                                " از " + reader["StartLocation"].ToString();

                                        StrConnec.Close();
                                        Enabled=true;
                                        MessageBoxFa.Show(mess, "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        query="SELECT * FROM TerminalTrip WHERE Tarikh=? AND (O1_Num=? OR O3_Num=?) AND Vis=True";
                        using (OleDbCommand cmd=new OleDbCommand(query, StrConnec))
                        {
                            cmd.Parameters.AddWithValue("?", PersianCalendar.Text);
                            cmd.Parameters.AddWithValue("?", P3Num);
                            cmd.Parameters.AddWithValue("?", P3Num);

                            using (OleDbDataReader reader=cmd.ExecuteReader())
                            {
                                if (!DateTime.TryParse(StartBox.Text, out DateTime startInput) || !DateTime.TryParse(EndBox.Text, out DateTime endInput))
                                {
                                    MessageBoxFa.Show("تاریخ یا ساعت نامعتبر است.", "خطا", MessageBoxIcon.Error);
                                    return;
                                }

                                // جابجایی مقادیر ورودی بر اساس KindLabel
                                if (KindLabel.Text == "ورود به خط اصلی")
                                {
                                    DateTime temp=startInput;
                                    startInput=endInput;
                                    endInput=temp;
                                }

                                while (reader.Read())
                                {
                                    bool isMain=reader["E_Kind"].ToString() == "ورود به خط اصلی";

                                    if (!DateTime.TryParse(isMain ? reader["E_Time"].ToString() : reader["Trip_Time"].ToString(), out DateTime eStart) ||
                                        !DateTime.TryParse(isMain ? reader["Trip_Time"].ToString() : reader["E_Time"].ToString(), out DateTime eEnd))
                                    {
                                        continue; // اگر تاریخ‌ها نامعتبر هستند، رد کن
                                    }

                                    // بررسی تداخل با 15 دقیقه اختلاف
                                    DateTime eStartPlus15=eStart.AddMinutes(15);
                                    DateTime eEndMinus15=eEnd.AddMinutes(-15);

                                    bool overlap=(eStartPlus15 < startInput && eEndMinus15 > startInput) ||
                                                   (eStartPlus15 < endInput && eEndMinus15 > endInput) ||
                                                   (eStartPlus15 > startInput && eEndMinus15 > startInput && eStartPlus15 < endInput && eEndMinus15 < endInput);

                                    if (overlap)
                                    {
                                        string mess="تداخل با حرکت ";
                                        mess += isMain ? eEnd.ToString() : eStart.ToString();
                                        mess += "  " + Name1Box.Text + Environment.NewLine + Environment.NewLine +
                                                reader["E_Kind"].ToString() + " قطار " + reader["Train"].ToString() +
                                                " از " + reader["StartLocation"].ToString();

                                        StrConnec.Close();
                                        Enabled=true;
                                        MessageBoxFa.Show(mess, "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }



                        //If ShamsiToMiladi(PDate) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate=PersianCalendar.Text And PTime < StartBox.Text) Then
                        //   Using CMD As New OleDbCommand("UPDATE Parking SET Vis=False WHERE ID=" & ParkID
                        //    CMD.ExecuteNonQuery()

                        //    If KindLabel.Text="ورود به خط اصلی" Then
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & StartLocaCombo.SelectedItem & "', '', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True, " & ParkID & ", '" & ShowGridView.CurrentRow.Cells(12).Value & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    Else
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & EndLocaCombo.SelectedItem & "', '" & TrainNumBox.Text & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', True, " & ParkID & ", '" & ShowGridView.CurrentRow.Cells(12).Value & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    End If
                        //Else
                        //    If KindLabel.Text="ورود به خط اصلی" Then
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & StartLocaCombo.SelectedItem & "', '', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', False, 0, '" & ShowGridView.CurrentRow.Cells(12).Value & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    Else
                        //       Using CMD As New OleDbCommand("INSERT INTO Parking (P_Name, Train, U_Reg, T_Reg, Vis, Fad, E_Local, E_Time, E_Date) VALUES ('" & EndLocaCombo.SelectedItem & "', '" & TrainNumBox.Text & "', '" & AppState.UserName & "', '" & MainForm.PersianToday.Tarikh & " " & Now.ToString("HH:mm:ss") & "', False, 0, '" & ShowGridView.CurrentRow.Cells(12).Value & "', '" & StartBox.Text & "', '" & PersianCalendar.Text & "')"
                        //        CMD.ExecuteNonQuery()
                        //    End If
                        //End If

                        using (OleDbCommand CMD=new OleDbCommand("UPDATE TerminalTrip SET E_Time='" + EndBox.Text + "', Train='" + TrainNumBox.Text + "', E_Mine=" + ConvertClass.TimeToMinute(TimeLabel.Text) + ", O1_Num='" + P1Num + "', O3_Num='" + P3Num + "', StartLocation='" + StartLocaCombo.Text + "', EndLocation='" + EndLocaCombo.Text + "', U_Reg='" + AppState.UserName + "', T_Reg='" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE ID=" + ShowGridView.CurrentRow.Cells[11].Value.ToString(), StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }


                    ShowGridView.CurrentRow.DefaultCellStyle.BackColor=Color.LightGreen;
                    ShowGridView.CurrentRow.Cells[3].Value=StartLocaCombo.SelectedItem;
                    ShowGridView.CurrentRow.Cells[4].Value=EndLocaCombo.SelectedItem;
                    ShowGridView.CurrentRow.Cells[5].Value=EndBox.Text;
                    ShowGridView.CurrentRow.Cells[6].Value=Name1Box.Text;
                    ShowGridView.CurrentRow.Cells[7].Value=P1Num;
                    ShowGridView.CurrentRow.Cells[8].Value=Name3Box.Text;
                    ShowGridView.CurrentRow.Cells[9].Value=P3Num;
                    ShowGridView.CurrentRow.Cells[10].Value=TrainNumBox.Text;
                    EndBox.Text="";
                    EndBox.Text="";
                    TrainNumBox.Text="";
                    Name1Box.Text="";
                    Name1Button.Image=Properties.Resources.user;
                    Name3Box.Text="";
                    Name3Button.Image=Properties.Resources.user;
                    StartLocaCombo.Text="";
                    EndLocaCombo.Text="";

                    Enabled=true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    //   TerminalTableTripRegForm_Load(Nothing, Nothing)
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TerminalTableTripRegForm_Load(object sender, EventArgs e)
        {
            try
            {
                PersianCalendar.Today_Click(null, null);

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
                //If StartLocaCombo.SelectedIndex >= 0 And RegButton.Enabled Then
                //    If KindLabel.Text="ورود به خط اصلی" Then
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
                //            ' StartLocaCombo.SelectedIndex=-1     ** کنترل خطای مبدا
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
                //If StartLocaCombo.SelectedIndex >= 0 And RegButton.Enabled Then
                //    If KindLabel.Text="خروج از خط اصلی" Then
                //
                //        Reader
                //        Dim TrainNum As String
                //        ParkID=0
                //        TrainNum=""
                //        PDate=""
                //        PTime=""

                //       Using  ConnectionString  As New OleDbConnection(AppState.ConnectionString)        StrConnec.Open()
                //

                //       Using CMD As New OleDbCommand("SELECT TOP 1 * FROM Parking WHERE P_Name='" & EndLocaCombo.SelectedItem & "' ORDER BY T_Reg DESC"
                //         Using Reader As OleDbDataReader=CMD.ExecuteReader
                //        While Reader.Read
                //            ParkID=Reader.Item("ID")
                //            TrainNum=Reader.Item("Train").ToString
                //            PDate=Reader.Item("E_Date").ToString
                //            PTime=Reader.Item("E_Time").ToString
                //        End While
                //      End Using
                //       End Using

                //        If TrainNum <> "" Then
                //            If ShamsiToMiladi(PDate) < ShamsiToMiladi(PersianCalendar.Text) Or (PDate=PersianCalendar.Text And PTime < StartBox.Text) Then
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

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                KindLabel.Text="";
                StartBox.Text="";
                TrainNumBox.Text="";
                TimeLabel.Text="";
                EndBox.Text="";
                StartLocaCombo.SelectedIndex=-1;
                StartLocaCombo.Text="";
                EndLocaCombo.SelectedIndex=-1;
                EndLocaCombo.Text="";
                RegButton.Enabled=false;

                if (e.RowIndex >= 0)
                {
                    KindLabel.Text=ShowGridView.CurrentRow.Cells[2].Value.ToString();
                    StartBox.Text=ShowGridView.CurrentRow.Cells[1].Value.ToString();
                    TrainNumBox.Text=ShowGridView.CurrentRow.Cells[10].Value.ToString();
                    EndBox.Text=ShowGridView.CurrentRow.Cells[5].Value.ToString();
                    if (KindLabel.Text == "خروج از خط اصلی")
                    {
                        Label6.Text="زمان پایان:";
                        // TrainNumBox.Enabled=True    **کنترل خطا
                    }
                    else
                    {
                        Label6.Text="زمان شروع:";
                        //TrainNumBox.Enabled=False
                    }
                    StartLocaCombo.Text=ShowGridView.CurrentRow.Cells[3].Value.ToString();
                    EndLocaCombo.Text=ShowGridView.CurrentRow.Cells[4].Value.ToString();
                    Name1Box.Text=ShowGridView.CurrentRow.Cells[6].Value.ToString();
                    Name3Box.Text=ShowGridView.CurrentRow.Cells[8].Value.ToString();
                    if (ShowGridView.CurrentRow.DefaultCellStyle.BackColor != Color.LightGreen)
                    {
                        RegButton.Enabled=true;
                    }

                    StartBox_Leave(null, null);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void Name1Button_Click(object sender, EventArgs e)
        {
            Name1Box.Text="";
            Name1Button.Image=Properties.Resources.user;
            PersonalSelectForm.Per="پایانه";
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
            PersonalSelectForm.Per="پایانه";
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
