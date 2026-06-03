using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ReserveTripForm
    {
        public ReserveTripForm()
        {
            InitializeComponent();
        }


        private string PFamily; //PPost, PLocal,
        private string PName;
        private string PNum;
        private string PTime;
        private string PShName;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public static bool LastTrip(string Trip, string RShi)
        {
            bool Res=false;
            if (Trip.Length == 5)
            {
                if (RShi == "صبح")
                {
                    if (DateTime.Parse(Trip) > DateTime.Parse("11:01"))
                    {
                        Res=true;
                    }
                    else
                    {
                        Res=false;
                    }
                }
                if (RShi == "عصر")
                {
                    if (DateTime.Parse(Trip) > DateTime.Parse("19:01"))
                    {
                        Res=true;
                    }
                    else
                    {
                        Res=false;
                    }
                }
            }
            else
            {
                Res=false;
            }
            return Res;
        }

        public void ReservOrder()
        {
            int i=0;
            DataGridView1.Rows.Clear();

            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, Person.Shift_Time, Person.EmpoDate, Rezerv.R_Shift, Rezerv.Loca, Rezerv.Mem, Rezerv.Vis FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh='" + PersianCalendar.Text + "' AND Rezerv.Loca='" + LocalCombo.Text + "' AND Rezerv.Vis=True AND Person.Line_Num='" + AppState.UserLnum + "'", StrConnec)) // AND Rezerv.R_Shift='" & ShiftCombo.SelectedItem & "'"
                using (OleDbDataReader Reader=CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        string ss=Reader["Shift_Time"].ToString() + " " + Reader["R_Shift"].ToString() + " (" + Reader["Mem"].ToString() + ")";
                        DataGridView1.Rows.Add(i + 1, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0, 0, 0, 0, 0, 0, 0, Reader["Shift_Time"].ToString() + " " + Reader["R_Shift"].ToString() + " (" + Reader["Mem"].ToString() + ")", double.Parse(Reader["EmpoDate"].ToString().Substring(1, 6).Replace("/", "")) * -0.00001);
                        // DataGridView1.Rows.Add(i + 1, Reader.Item("Fname").ToString, Reader.Item("Family").ToString, Reader.Item("P_Num").ToString, Reader.Item("Mem").ToString & " " & Reader.Item("Shift_Time").ToString, 0, 0, 0, 0, 0, 0, 0, Double.Parse(Reader.Item("EmpoDate").ToString.Substring(1, 6).Replace("/", "")) * -0.00001)

                        if (Reader["Mem"].ToString().IndexOf("غیر فعال") + 1 > 0)
                        {
                            DataGridView1.Rows[i].DefaultCellStyle.BackColor=Color.Red;
                        }
                        else
                        {
                            if (Reader["Shift_Time"].ToString() == "12 ساعته")
                            {
                                DataGridView1.Rows[i].DefaultCellStyle.BackColor=Color.Yellow;
                            }
                        }
                        i++;
                    }
                }

                if (DataGridView1.RowCount == 0)
                {
                    MessageBoxFa.Show(" برای این شیفت راهبر رزرو ثبت نشده است ", "خطا", MessageBoxIcon.Error);
                }
                else
                {
                    int Rez=0; // LTrip, Pos, Neg,
                    int Trip=0;
                    int MorDay=0;
                    int MorTime=0;
                    int LastDate=0;
                    string StartDate="";
                    string EndDate="";
                    Taghvim PersianDate1=new Taghvim(PersianCalendar.Text);

                    Panel2.Enabled=false;
                    StartDate=PersianDate1.AddDay(-1);
                    EndDate=PersianDate1.AddMonth(-2);

                    for (i=0; i < DataGridView1.Rows.Count; i++)
                    {
                        Rez=0;
                        Trip=0;
                        //LTrip=0
                        //Pos=0
                        //Neg=0
                        MorDay=0;
                        MorTime=0;
                        LastDate=0;

                        // *********************
                        //CMD.CommandText="SELECT * FROM Amal WHERE Vis=True AND P_Num='" & DataGridView1.Rows(i).Cells(3).Value & "' AND Tarikh BETWEEN '" & StartDate & "' AND '" & EndDate & "'"
                        // Using Reader As OleDbDataReader=CMD.ExecuteReader()
                        //While Reader.Read
                        //    Select Case Reader.Item("OnvAmal").ToString
                        //        Case "مثبت"
                        //            Pos += 1
                        //        Case "منفی"
                        //            Neg += 1
                        //        Case "ساعتی"
                        //            MorTime += 1
                        //    End Select
                        //End While
                        //Reader.Close()

                        using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(Tarikh) AS Cou FROM Morakhasi WHERE Vis=True AND P_Num='" + DataGridView1.Rows[i].Cells[3].Value + "' AND Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                MorDay=Convert.ToInt32(Reader["Cou"]);
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT Tarikh, Trip1, Trip2, Trip3 FROM Rezerv WHERE P_Num='" + DataGridView1.Rows[i].Cells[3].Value + "' AND Vis=True AND (Mem NOT LIKE 'اضطراری%' AND Mem<>'شانتر' ) AND Tarikh BETWEEN '" + StartDate + "' AND '" + EndDate + "' ORDER BY Tarikh DESC", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Rez++;
                                if (Reader["Trip1"].ToString() != "")
                                {
                                    Trip++;
                                    if (LastDate == 0)
                                    {
                                        LastDate=Convert.ToInt32(Reader["Tarikh"].ToString().Substring(3, 7).Replace("/", ""));
                                    }
                                    //If LastTrip(Reader.Item("Trip1").ToString, Reader.Item("R_Shift").ToString) Then LTrip += 1
                                }
                                if (Reader["Trip2"].ToString() != "")
                                {
                                    Trip++;
                                    if (LastDate == 0)
                                    {
                                        LastDate=Convert.ToInt32(Reader["Tarikh"].ToString().Substring(3, 7).Replace("/", ""));
                                    }
                                    //If LastTrip(Reader.Item("Trip2").ToString, Reader.Item("R_Shift").ToString) Then LTrip += 1
                                }
                                if (Reader["Trip3"].ToString() != "")
                                {
                                    Trip++;
                                    if (LastDate == 0)
                                    {
                                        LastDate=Convert.ToInt32(Reader["Tarikh"].ToString().Substring(3, 7).Replace("/", ""));
                                    }
                                    //If LastTrip(Reader.Item("Trip3").ToString, Reader.Item("R_Shift").ToString) Then LTrip += 1
                                }
                            }
                        }

                        DataGridView1.Rows[i].Cells[4].Value=Rez;
                        DataGridView1.Rows[i].Cells[5].Value=Trip;
                        //DataGridView1.Rows(i).Cells(4).Value=LTrip
                        //DataGridView1.Rows(i).Cells(8).Value=Pos
                        //DataGridView1.Rows(i).Cells(9).Value=Neg
                        DataGridView1.Rows[i].Cells[9].Value=MorTime;
                        DataGridView1.Rows[i].Cells[10].Value=MorDay;

                        if (DataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                        {
                            DataGridView1.Rows[i].Cells[12].Value=5000000;
                        }
                        else if (DataGridView1.Rows[i].Cells[11].Value.ToString().IndexOf("9 ساعته صبح") + 1 > 0)
                        {
                            DataGridView1.Rows[i].Cells[12].Value=Convert.ToInt32(DataGridView1.Rows[i].Cells[12].Value) + Trip * 100000 + LastDate + 1000000;
                        }
                        else if (DataGridView1.Rows[i].Cells[11].Value.ToString().IndexOf("12 ساعته روز") + 1 > 0)
                        {
                            DataGridView1.Rows[i].Cells[12].Value=Convert.ToInt32(DataGridView1.Rows[i].Cells[12].Value) + Trip * 100000 + LastDate + 2000000;
                        }
                        else if (DataGridView1.Rows[i].Cells[11].Value.ToString().IndexOf("9 ساعته عصر") + 1 > 0)
                        {
                            DataGridView1.Rows[i].Cells[12].Value=Convert.ToInt32(DataGridView1.Rows[i].Cells[12].Value) + Trip * 100000 + LastDate + 3000000;
                        }
                        else if (DataGridView1.Rows[i].Cells[11].Value.ToString().IndexOf("12 ساعته شب") + 1 > 0)
                        {
                            DataGridView1.Rows[i].Cells[12].Value=Convert.ToInt32(DataGridView1.Rows[i].Cells[12].Value) + Trip * 100000 + LastDate + 4000000;
                        }

                        //If DataGridView1.Rows(i).DefaultCellStyle.BackColor=Color.Red Then
                        //    DataGridView1.Rows(i).Cells(12).Value=4000000.0
                        //ElseIf DataGridView1.Rows(i).DefaultCellStyle.BackColor=Color.Yellow Then
                        //    DataGridView1.Rows(i).Cells(12).Value += (Trip + 10) * 100000 + LastDate
                        //Else
                        //    DataGridView1.Rows(i).Cells(12).Value += Trip * 100000 + LastDate
                        //End If
                        //If DataGridView1.Rows(i).DefaultCellStyle.BackColor=Color.Red Then
                        //    DataGridView1.Rows(i).Cells(12).Value=-20.0
                        //ElseIf DataGridView1.Rows(i).DefaultCellStyle.BackColor=Color.Yellow Then
                        //    DataGridView1.Rows(i).Cells(12).Value=Rez - Trip * 0.4 - LTrip * 0.2 - Pos * 0.2 + Neg * 0.2 + MorTime * 0.2 + 10.0
                        //Else
                        //    DataGridView1.Rows(i).Cells(12).Value=Rez - Trip * 0.55 - LTrip * 0.2 - Pos * 0.2 + Neg * 0.2 + MorTime * 0.2 + MorDay * 0.2
                        //End If

                    }
                }
            }

            
            DataGridView1.Sort(DataGridView1.Columns[12], System.ComponentModel.ListSortDirection.Ascending);
            for (i=0; i <= DataGridView1.Rows.Count - 1; i++)
            {
                DataGridView1.Rows[i].Cells[0].Value=i + 1;
            }

            if (DataGridView1.CurrentRow != null)
            {
                DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected=false;
            }
        }

        public dynamic DailyLeaveChecker(string PNum, OleDbConnection StrConnec)
        {
            bool Fin=false;
            using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Morakhasi WHERE Vis=True AND Tarikh='" + PersianCalendar.Text + "' AND P_Num='" + PNum + "'", StrConnec))
            using (OleDbDataReader Reader=CMD.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Fin=true;
                }
            }

            return Fin;
        }

        public void ReserveTripForm_Load(object sender, EventArgs e)
        {
            Panel2.Enabled=false;
            AddButton.Enabled=false;
            AddButton.BackColor=DefaultBackColor;
            DelButton.Enabled=false;
            DelButton.BackColor=DefaultBackColor;
            PersianCalendar.Today_Click(null, null);

            if (AppState.UserLevel != 0)
            {
                DataGridView1.Columns[12].Visible=false;
            }

            LocalCombo.Items.Clear();
            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
            //if (LocalCombo.Items.Count > 0) LocalCombo.SelectedIndex=0;
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            bool Bol=true;
            DateTime SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);
            int Tim ;
            if (DateTime.Now.Hour >= 19)
            {
                Tim=1;
            }
            else
            {
                Tim=0;
            }

            if (AppState.UserLevel > 0)
            {
                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                {
                    MainForm.PersianToday.Tarikh(DateTime.Today);
                    if (MainForm.PersianToday.Day() < 3)
                    {
                        if (SelectDate > DateTime.Today.AddDays(Tim) || SelectDate < DateTime.Today.AddDays(Convert.ToDouble(-MainForm.PersianToday.Day())))
                        {
                            MessageBoxFa.Show("تاریخ وارد شده در بازه قابل ثبت نیست", "خطا", MessageBoxIcon.Error);
                            Bol=false;
                        }
                    }
                    else
                    {
                        if (SelectDate > DateTime.Today.AddDays(Tim) || SelectDate < DateTime.Today.AddDays(-(MainForm.PersianToday.DaysInThisMonth() + MainForm.PersianToday.DaysInPrevMonth())))
                        {
                            MessageBoxFa.Show("تاریخ وارد شده در بازه قابل ثبت نیست", "خطا", MessageBoxIcon.Error);
                            Bol=false;
                        }
                    }
                }
                else
                {
                    if (MainForm.PersianToday.Day() < 7)
                    {
                        if (SelectDate > DateTime.Today.AddDays(Tim) || SelectDate < DateTime.Today.AddDays(Convert.ToDouble(-MainForm.PersianToday.Day())))
                        {
                            MessageBoxFa.Show("تاریخ وارد شده در بازه قابل ثبت نیست", "خطا", MessageBoxIcon.Error);
                            Bol=false;
                        }
                    }
                    else
                    {
                        if (SelectDate > DateTime.Today.AddDays(Tim) || SelectDate < DateTime.Today.AddDays(-(MainForm.PersianToday.DaysInThisMonth() + MainForm.PersianToday.DaysInPrevMonth())))
                        {
                            MessageBoxFa.Show("تاریخ وارد شده در بازه قابل ثبت نیست", "خطا", MessageBoxIcon.Error);
                            Bol=false;
                        }
                    }
                }
            }
            if (Bol)
            {
                PersonalSelectForm.Per="راهبر قطار";
                PersonalSelectForm ShowForm=new PersonalSelectForm();
                if (ShowForm.ShowDialog() == DialogResult.OK)
                {
                    PFamily=PersonalSelectForm.PFamily;
                    PName=PersonalSelectForm.PName;
                    PNum=PersonalSelectForm.PNum;
                    PTime=PersonalSelectForm.PTime;
                    //PLocal=PersonalSelectForm.PersonGridView.CurrentRow.Cells(6).Value.ToString
                    //PPost=PersonalSelectForm.PersonGridView.CurrentRow.Cells(4).Value.ToString
                    PShName=PersonalSelectForm.PShift;

                    DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + PNum.ToString() + "'");
                    if (!(bool)DRow[0]["Reserv"] && AppState.UserLevel > 0)
                    {

                        MessageBoxFa.Show(PName + " " + PFamily + " مجوز رزرو ندارد ", "خطا", MessageBoxIcon.Error);
                        return;
                    }
                }

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    if (DailyLeaveChecker(PNum.ToString(), StrConnec))
                    {
                        StrConnec.Close();
                        MessageBoxFa.Show(PName + " " + PFamily + " در این تاریخ مرخصی روزانه است ", "خطا", MessageBoxIcon.Error);
                        return;
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Rezerv WHERE P_Num='" + PNum.ToString() + "' AND Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            StrConnec.Close();
                            MessageBoxFa.Show(PName + " " + PFamily + " در این تاریخ رزرو است ", "خطا", MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string Shift1="";
                    string Shift2="";
                    string ResShift="";

                    using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Shift1=Reader["Sobh"].ToString();
                            Shift2=Reader["Asr"].ToString();
                        }
                    }

                    if (PShName == Shift2)
                    {
                        if (PTime == "12 ساعته")
                        {
                            ResShift="شب";
                        }
                        else
                        {
                            ResShift="عصر";
                        }
                    }
                    else if (PShName == Shift1)
                    {
                        if (PTime == "12 ساعته")
                        {
                            ResShift="روز";
                        }
                        else
                        {
                            ResShift="صبح";
                        }
                    }
                    else
                    {
                        StrConnec.Close();
                        ErrorShow(ShiftCombo, PName + " " + PFamily + " مجاز به رزرو در این شیفت نیست");
                        return;
                    }

                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Rezerv (P_Num, Tarikh, Loca, R_Shift, U_Reg, Mem, Vis) VALUES (" + PNum + ", '" + PersianCalendar.Text + "', '" + LocalCombo.SelectedItem + "', '" + ResShift + "', '" + AppState.UserName + "', 'خارج از نوبت', True)", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }

                ReservOrder();
            }
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].DefaultCellStyle.BackColor == Color.Red && AppState.UserLevel > 1)
                {
                    MessageBoxFa.Show(" شما دسترسی لازم را ندارید ", "خطا", MessageBoxIcon.Error);
                    return;
                }

                string Messa="";
                Messa=Microsoft.VisualBasic.Interaction.InputBox("توضیحات لازم را در مورد حذف از لیست رزرو ها ارائه کنید", "حذف " + DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[1].Value + " " + DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                if (Messa != "")
                {
                    if (Messa.Length >= 10)
                    {
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand("UPDATE Rezerv SET Vis=False, U_Mod='" + AppState.UserName + "', Mem='" + Messa + "' WHERE P_Num='" + DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[3].Value + "' AND Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }


                        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex);
                    }
                    else
                    {
                        MessageBoxFa.Show(" توضیحات تکمیلی مناسب نیست ", "خطا", MessageBoxIcon.Error);
                    }
                }
                Panel2.Enabled=false;

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
                if (ConvertClass.TimeToDouble(EnterTimeBox.Text, true) < 0)
                {
                    ErrorShow(EnterTimeBox, "ساعت ورود را تعیین کنید");
                }
                else if (ConvertClass.TimeToDouble(ExitTimeBox.Text, true) < 0)
                {
                    ErrorShow(ExitTimeBox, "ساعت خروج را تعیین کنید");
                }
                else if (ConvertClass.TimeToDouble(Trip1TimeBox.Text, true) < 0)
                {
                    ErrorShow(Trip1TimeBox, "زمان تریپ اول را تعیین کنید");
                }
                else if (ConvertClass.TimeToDouble(Trip2TimeBox.Text, true) < 0)
                {
                    ErrorShow(Trip2TimeBox, "زمان تریپ دوم را تعیین کنید");
                }
                else if (ConvertClass.TimeToDouble(Trip3TimeBox.Text, true) < 0)
                {
                    ErrorShow(Trip3TimeBox, "زمان تریپ سوم را تعیین کنید");
                }
                else // نیاز به اصلاح مجدد
                {

                    if (ConvertClass.TimeToDouble(Trip2TimeBox.Text) > 0)
                    {
                        if (ConvertClass.TimeToDouble(Trip1TimeBox.Text) <= 0)
                        {
                            ErrorShow(Trip1TimeBox, "ابتدا تریپ اول را تعیین کنید");
                            return;

                        }
                        else if (ConvertClass.TimeToDouble(Trip1TimeBox.Text) > ConvertClass.TimeToDouble(Trip2TimeBox.Text) && DataGridView1.CurrentRow.DefaultCellStyle.BackColor != Color.Yellow)
                        {
                            ErrorShow(Trip1TimeBox, "زمان تریپ اول بعد از تریپ دوم است");
                            ErrorShow(Trip2TimeBox, "زمان تریپ اول بعد از تریپ دوم است");
                            return;

                        }
                        else if (ConvertClass.TimeToDouble(Trip1TimeBox.Text) + 2.5 > ConvertClass.TimeToDouble(Trip2TimeBox.Text) && DataGridView1.CurrentRow.DefaultCellStyle.BackColor != Color.Yellow)
                        {
                            ErrorShow(Trip1TimeBox, "تداخل در زمان تریپ اول و تریپ دوم");
                            ErrorShow(Trip2TimeBox, "تداخل در زمان تریپ اول و تریپ دوم");
                            return;
                        }
                    }

                    if (ConvertClass.TimeToDouble(Trip3TimeBox.Text) > 0)
                    {
                        if (ConvertClass.TimeToDouble(Trip2TimeBox.Text) <= 0)
                        {
                            ErrorShow(Trip2TimeBox, "ابتدا تریپ دوم را تعیین کنید");
                            return;

                        }
                        else if (ConvertClass.TimeToDouble(Trip2TimeBox.Text) > ConvertClass.TimeToDouble(Trip3TimeBox.Text))
                        {
                            ErrorShow(Trip2TimeBox, "زمان تریپ دوم بعد از تریپ سوم است");
                            ErrorShow(Trip3TimeBox, "زمان تریپ دوم بعد از تریپ سوم است");
                            return;

                        }
                        else if (ConvertClass.TimeToDouble(Trip2TimeBox.Text) + 2.5 > ConvertClass.TimeToDouble(Trip3TimeBox.Text))
                        {
                            ErrorShow(Trip2TimeBox, "تداخل در زمان تریپ دوم و تریپ سوم");
                            ErrorShow(Trip3TimeBox, "تداخل در زمان تریپ دوم و تریپ سوم");
                            return;
                        }
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string QueStr="UPDATE Rezerv SET U_Mod='" + AppState.UserName + "',";
                        if (ConvertClass.TimeToDouble(Trip1TimeBox.Text) > 0)
                        {
                            QueStr += " Trip1='" + Trip1TimeBox.Text + "',";
                        }
                        else
                        {
                            QueStr += " Trip1='',";
                        }

                        if (ConvertClass.TimeToDouble(Trip2TimeBox.Text) > 0)
                        {
                            QueStr += " Trip2='" + Trip2TimeBox.Text + "',";
                        }
                        else
                        {
                            QueStr += " Trip2='',";
                        }

                        if (ConvertClass.TimeToDouble(Trip3TimeBox.Text) > 0)
                        {
                            QueStr += " Trip3='" + Trip3TimeBox.Text + "',";
                        }
                        else
                        {
                            QueStr += " Trip3='',";
                        }

                        if (EnterTimeBox.Text.Replace(":", "").Length == 4)
                        {
                            QueStr += " Vorood='" + EnterTimeBox.Text + "',";
                        }
                        else
                        {
                            QueStr += " Vorood='',";
                        }

                        if (ExitTimeBox.Text.Replace(":", "").Length == 4)
                        {
                            QueStr += " Khorooj='" + ExitTimeBox.Text + "'";
                        }
                        else
                        {
                            QueStr += " Khorooj=''";
                        }

                        QueStr += " WHERE P_Num='" + DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[3].Value + "' AND Tarikh='" + PersianCalendar.Text + "'";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected=false;
                    Panel2.Enabled=false;

                }
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
                Trip1TimeBox.Text="";
                Trip2TimeBox.Text="";
                Trip3TimeBox.Text="";
                EnterTimeBox.Text="";
                ExitTimeBox.Text="";
                Panel2.Enabled=false;
                DelButton.Enabled=false;

                if (DataGridView1.CurrentRow.DefaultCellStyle.BackColor != Color.Red)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        Panel2.Enabled=true;
                        DateTime MTar=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);
                        if (MTar <= DateTime.Today.AddDays(1) && MTar >= DateTime.Today.AddDays(-10) && ShiftCombo.SelectedIndex >= 0)
                        {
                            DelButton.Enabled=false;
                            DelButton.BackColor=Color.Tomato;
                        }
                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + DataGridView1.Rows[DataGridView1.CurrentCell.RowIndex].Cells[3].Value + "' AND Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Trip1TimeBox.Text=Reader["Trip1"].ToString();
                                Trip2TimeBox.Text=Reader["Trip2"].ToString();
                                Trip3TimeBox.Text=Reader["Trip3"].ToString();
                                EnterTimeBox.Text=Reader["Vorood"].ToString();
                                ExitTimeBox.Text=Reader["Khorooj"].ToString();
                                Panel2.Enabled=true;
                                DelButton.Enabled=true;
                            }
                        }
                    }


                    if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) <= DateTime.Today && ConvertClass.ShamsiToMiladi(PersianCalendar.Text) > DateTime.Today.AddDays(-6))
                    {
                        EnterTimeBox.Enabled=true;
                        ExitTimeBox.Enabled=true;
                    }
                    else
                    {
                        EnterTimeBox.Enabled=false;
                        ExitTimeBox.Enabled=false;
                    }

                    Trip2TimeBox.Enabled=false;
                    Trip3TimeBox.Enabled=false;
                    if (ConvertClass.TimeToDouble(Trip1TimeBox.Text) > 0)
                    {
                        Trip2TimeBox.Enabled=true;
                    }

                    if (ConvertClass.TimeToDouble(Trip2TimeBox.Text) > 0)
                    {
                        Trip3TimeBox.Enabled=true;
                    }

                    Panel2.Focus();
                }
                else if (AppState.UserLevel == 0)
                {
                    DelButton.Enabled=true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.Clear();

                if (LocalCombo.SelectedIndex >= 0)
                {
                    //ShiftCombo.SelectedIndex=-1
                    AddButton.Enabled=false;
                    AddButton.BackColor=DefaultBackColor;
                    DelButton.Enabled=false;
                    DelButton.BackColor=DefaultBackColor;

                    DateTime MTar=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);
                    if (MTar <= DateTime.Today.AddDays(1) && MTar >= DateTime.Today.AddDays(-10))
                    {
                        AddButton.Enabled=true;
                        AddButton.BackColor=Color.Lime;
                    }
                    ReservOrder();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ShiftCombo.SelectedIndex >= 0)
                {
                    DateTime MTar=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);
                    if (MTar <= DateTime.Today.AddDays(1) && MTar >= DateTime.Today.AddDays(-10))
                    {
                        AddButton.Enabled=true;
                        AddButton.BackColor=Color.Lime;
                    }
                    ReservOrder();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            LocalCombo.SelectedIndex=-1;
        }

        public void LocalCombo_TextChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
            //ShiftCombo.Items.Clear()
            //ShiftCombo.Text=""
        }

        public void ExitMaskedBox_TextChanged(object sender, EventArgs e)
        {
            if (DataGridView1.DefaultCellStyle.BackColor == Color.Yellow)
            {

            }
        }

        public void ShiftCombo_TextChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            Panel2.Enabled=false;
        }

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView1.Sort(DataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Panel2_EnabledChanged(object sender, EventArgs e)
        {
            if (Panel2.Enabled)
            {
                DelButton.BackColor=Color.Tomato;
                DelButton.Enabled=true;
            }
            else
            {
                Trip1TimeBox.Text="";
                Trip3TimeBox.Text="";
                Trip2TimeBox.Text="";
                EnterTimeBox.Text="";
                ExitTimeBox.Text="";
                DelButton.BackColor=Color.Transparent;
            }
        }

        public void Panel2_Leave(object sender, EventArgs e)
        {
            Panel2.Enabled=false;
            if (DataGridView1.Rows.Count > 0)
            {
                DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected=false;
            }
        }

        public void ReserveTripForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0306");
        }
    }
}
