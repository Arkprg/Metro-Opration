using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class Reserve12Form
    {
        public Reserve12Form()
        {
            InitializeComponent();
        }


        private int Cont;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Fill()
        {
            MemBox.Text="";
            if (Cont < DetailGridView.RowCount)
            {
                NameBox.Text=DetailGridView.Rows[Cont].Cells[0].Value + " " + DetailGridView.Rows[Cont].Cells[1].Value.ToString();
                PNumBox.Text=DetailGridView.Rows[Cont].Cells[2].Value.ToString();
                ReservBox.Text=DetailGridView.Rows[Cont].Cells[3].Value.ToString();
            }
            else
            {
                MessageBoxFa.Show("تمام افراد این شیفت مورد پردازش قرار گرفته اند", "خطا", MessageBoxIcon.Error);
                NameBox.Text="";
                PNumBox.Text="";
                ReservBox.Text="";
                Panel1.Enabled=false;
            }
        }

        public void Colorring(int i)
        {
            if (RegGridView.Rows[i].Cells[4].Value.ToString() == ("روز " + LocalCombo.Items[0].ToString()))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.White;
            }
            else if (RegGridView.Rows[i].Cells[4].Value.ToString() == $"شب {LocalCombo.Items[0]}")
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.Yellow;
            }
            else if (RegGridView.Rows[i].Cells[4].Value.ToString() == ("شب " + LocalCombo.Items[1].ToString()))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.Thistle;
            }
            else if (RegGridView.Rows[i].Cells[4].Value.ToString() == ("روز " + LocalCombo.Items[1].ToString()))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.DeepSkyBlue;
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NameBox.Text="";
                PNumBox.Text="";
                ReservBox.Text="";
                Panel1.Enabled=false;
                RegGridView.Rows.Clear();
                DetailGridView.Rows.Clear();

                DateTime SelectDate;
                DateTime Dat;
                SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                if (ShiftCombo.SelectedIndex < 0)
                {
                    ShiftCombo.Focus(); //عدم نمایش در حالت خالی
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ را مشخص کنید");
                }
                else if (SelectDate < DateTime.Today || SelectDate > DateTime.Today.AddDays(7))
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح را انتخاب کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "ایستگاه مبدا را انتخاب کنید");
                    LocalCombo.Focus();
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "شیفت را مشخص کنید");
                    ShiftCombo.Focus();
                }
                else
                {
                    Taghvim PersianDate=new Taghvim(PersianCalendar.Text);
                    PersianDate.AddMonth(-2); //**************** بازه یک ماه برای بررسی تاریخجه راهبران

                    Cont=0;
                    string ShiftName="";
                    int Emer=0; //Trp, LTrip, MorSat, RezSum, RezMid,
                    int Rez=0;
                    int MorDay=0;
                    int i;
                    int j=0;
                    int TDel=0;
                    int TReg=0;
                    int WDel=0;
                    int WReg=0;
                    double Emt=0;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (ShiftCombo.SelectedIndex == 0)
                                {
                                    ShiftName=Reader["Sobh"].ToString();
                                }
                                else if (ShiftCombo.SelectedIndex == 1)
                                {
                                    ShiftName=Reader["Asr"].ToString();
                                }
                            }
                        }

                        DataRow[] DRow=MainForm.PersonTable.Select("Vis=True AND Reserv=True AND Shift_Time='12 ساعته' AND P_Post='راهبر قطار' AND Shift_Name='" + ShiftName + "' AND Shift_Loc='" + LocalCombo.Text + "' AND Line_Num='" + AppState.UserLnum + "'", "P_Post");
                        foreach (DataRow DtR in DRow)
                        {
                            DetailGridView.Rows.Add(DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0, 0, 0, 0, 0.0);
                        }

                        //CMD.CommandText="SELECT COUNT(Rezerv.Tarikh) AS COU FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh BETWEEN '" & PersianCalendar.Text & "' AND '" & PersianDate.Tarikh & "' AND Rezerv.Vis=True AND Person.Shift_Time='12 ساعته' AND Person.Shift_Loc='" & LocalCombo.Text & "' AND Person.Line_Num='" & AppState.UserLnum & "' AND Rezerv.Mem NOT LIKE 'اضطراری%' AND Person.Shift_name='" & ShiftName & "'"
                        //CMD.Connection=AppState.ConnectionString
                        // Using Reader As OleDbDataReader=CMD.ExecuteReader()
                        //While Reader.Read
                        //    RezSum=Reader.Item("COU")
                        //End While
                        //Reader.Close()
                        //RezMidl=Math.Floor(RezSum / (DetailGridView.Rows.Count * 1.5))

                        using (OleDbCommand CMD=new OleDbCommand("SELECT P_Num FROM Morakhasi WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                i=0;
                                while (i <= DetailGridView.Rows.Count - 1)
                                {
                                    if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                    {
                                        DetailGridView.Rows.RemoveAt(i);
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT Person.P_Num FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE Person.Shift_Time='12 ساعته' AND Person.Shift_Loc ='" + LocalCombo.SelectedItem + "' AND Person.Vis=True AND Person.Line_Num='" + AppState.UserLnum + "' AND TakTrip.Vis=True AND TakTrip.Trip='هشتگرد' AND TakTrip.Tarikh='" + PersianCalendar.Text + "' AND Shift_name='" + ShiftName + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                i=0;
                                while (i <= DetailGridView.Rows.Count - 1)
                                {
                                    if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                    {
                                        DetailGridView.Rows.RemoveAt(i);
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
                            }
                        }

                        j=1;
                        string QueStr="SELECT Person.Fname, Person.Family, Person.P_Num, Rezerv.R_Shift, Rezerv.Loca, Rezerv.Vis FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh='" + PersianCalendar.Text + "' AND Rezerv.Vis=True AND Rezerv.Mem<>'شانتر' AND Person.Shift_Time='12 ساعته' AND Rezerv.Loca='" + LocalCombo.SelectedItem + "'";
                        if (AppState.UserLevel > 1)
                        {
                            QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                        }

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                string ShfName="";
                                if (Reader["R_Shift"].ToString() == "صبح")
                                {
                                    ShfName="روز ";
                                }
                                else
                                {
                                    ShfName="شب ";
                                }
                                if ((bool)Reader["Vis"])
                                {
                                    RegGridView.Rows.Add(j, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), ShfName + Reader["Loca"].ToString());
                                    j++;
                                }

                                i=0;
                                while (i < DetailGridView.RowCount)
                                {
                                    if (Reader["P_Num"].ToString() == DetailGridView.Rows[i].Cells[2].Value.ToString())
                                    {
                                        DetailGridView.Rows.RemoveAt(i);
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
                                RegGridView.Sort(RegGridView.Columns[4], System.ComponentModel.ListSortDirection.Ascending);
                            }
                        }

                        for (i=0; i <= DetailGridView.RowCount - 1; i++)
                        {
                            Emer=0;
                            Rez=0;
                            Emt=0;
                            MorDay=0;
                            //Trp=0
                            //LTrip=0
                            //MorSat=0

                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Tarikh BETWEEN '" + PersianCalendar.Text + "' AND '" + PersianDate.Tarikh() + "' AND Vis=True AND Mem<>'شانتر'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Dat=ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                    if (Reader["Mem"].ToString().IndexOf("اضطراری") + 1 > 0)
                                    {
                                        Emer++;
                                    }
                                    else
                                    {
                                        Rez++;
                                    }

                                    if (Dat == SelectDate.AddDays(-1))
                                    {
                                        Emt += 2;
                                    }
                                    else if (Dat == SelectDate.AddDays(-2))
                                    {
                                        Emt += 1.5;
                                    }
                                    else if (Dat == SelectDate.AddDays(-3))
                                    {
                                        Emt++;
                                    }
                                    else if (Dat == SelectDate.AddDays(-4))
                                    {
                                        Emt += 0.5;
                                    }
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Morakhasi WHERE P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Vis=True AND Tarikh BETWEEN '" + PersianCalendar.Text + "' AND '" + PersianDate.Tarikh() + "'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Dat=ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                    MorDay++;

                                    if (Dat == SelectDate.AddDays(-1))
                                    {
                                        Emt += 2;
                                    }
                                    else if (Dat == SelectDate.AddDays(-2))
                                    {
                                        Emt++;
                                    }
                                }
                            }

                            DetailGridView.Rows[i].Cells[3].Value=Rez + Emer * 0.1;
                            DetailGridView.Rows[i].Cells[5].Value=MorDay;
                            DetailGridView.Rows[i].Cells[7].Value=Emt + Rez + Emer;
                        }

                        DetailGridView.Sort(DetailGridView.Columns[7], System.ComponentModel.ListSortDirection.Ascending);

                        using (OleDbCommand CMD=new OleDbCommand("SELECT Rezerv.Tarikh, Rezerv.Vis FROM Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh BETWEEN '" + PersianCalendar.Text + "' AND '" + PersianDate.Tarikh() + "' AND Person.Shift_Time='12 ساعته' AND Rezerv.Loca='" + LocalCombo.SelectedItem + "' AND Rezerv.Mem<>'شانتر'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Dat=ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString());
                                if ((bool)Reader["Vis"])
                                {
                                    TReg++;
                                    if (Dat > SelectDate.AddDays(-7))
                                    {
                                        WReg++;
                                    }
                                }
                                else
                                {
                                    TDel++;
                                    if (Dat > SelectDate.AddDays(-7))
                                    {
                                        WDel++;
                                    }
                                }
                            }
                        }

                        RegSumBox.Text=TReg.ToString();
                        DelSumBox.Text=TDel.ToString();
                        RegWeekBox.Text=WReg.ToString();
                        DelWeekBox.Text=WDel.ToString();
                    }

                    Panel1.Enabled=true;

                    AddRadioButton.Checked=true;
                    //Button3.BackColor=Color.LawnGreen
                    if (AppState.UserLevel == 1 || AppState.UserLevel == 2 || AppState.UserLevel == 3 || AppState.UserLevel == 8)
                    {
                        RegButton.Enabled=true;
                    }
                    Fill();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            LocalCombo.SelectedIndex=-1;
        }

        public void Reserve12Form_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "030104");
        }

        public void Reserve12Form_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);
            PersianCalendar.NextDay_Click(null, null);
            Panel1.Enabled=false;

            LocalCombo.Items.Clear();

             foreach (string Local in MainForm.Locals)
                    {
                        if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
                    if (LocalCombo.Items.Count > 0)
            {
                LocalCombo.SelectedIndex=0;
            }

            if (AppState.UserLevel == 0)
            {
                if (MessageBoxFa.Show(" جزئیات نمایش داده شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DetailGridView.Visible=true;
                }
            }

        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                RegButton.Enabled=false;

                if (int.TryParse(PNumBox.Text, out _))
                {
                    string ShiN="";
                    if (ShiftCombo.SelectedIndex == 0)
                    {
                        ShiN="صبح";
                    }
                    else if (ShiftCombo.SelectedIndex == 1)
                    {
                        ShiN="عصر";
                    }
                    if (AddRadioButton.Checked)
                    {
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Rezerv (P_NUM, Tarikh, R_Shift, Loca, U_Reg, Vis, Mem) VALUES ('" + DetailGridView.Rows[Cont].Cells[2].Value + "','" + PersianCalendar.Text + "', '" + ShiN + "', '" + LocalCombo.Text + "', '" + AppState.UserName + "', True, 'عادی')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }


                        RegGridView.Rows.Add(Cont, DetailGridView.Rows[Cont].Cells[0].Value, DetailGridView.Rows[Cont].Cells[1].Value, DetailGridView.Rows[Cont].Cells[2].Value, ShiftCombo.Text + " " + LocalCombo.Text);
                        Colorring(RegGridView.RowCount - 1);
                        Cont++;
                        Fill();
                        int i;
                        for (i=0; i <= RegGridView.RowCount - 1; i++)
                        {
                            RegGridView.Rows[i].Cells[0].Value=i + 1;
                        }
                    }
                    else
                    {
                        if (KindCombo.SelectedIndex < 1)
                        {
                            ErrorShow(KindCombo, "لطفا علت حذف را تعیین کنید");
                            KindCombo.Focus();
                        }
                        else if (MemBox.Text.Trim().Length < 5)
                        {
                            ErrorShow(MemBox, "لطفا توضیحات لازم را وارد کنید");
                            MemBox.Focus();
                        }
                        else
                        {
                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();
                                using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Rezerv (P_NUM, Tarikh, R_Shift, Loca, U_Reg, Vis, Mem) VALUES ('" + DetailGridView.Rows[Cont].Cells[2].Value + "','" + PersianCalendar.Text + "', '" + ShiN + "', '" + LocalCombo.Text + "', '" + AppState.UserName + "', False, '" + KindCombo.SelectedItem + "* " + MemBox.Text.Trim() + "')", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }

                            Cont++;
                            Fill();
                        }
                    }
                }
                RegButton.Enabled=true;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
            {
                MemBox.Text="";
                MemBox.Enabled=false;
                KindCombo.SelectedIndex=-1;
                KindCombo.Enabled=false;
                MemBox.BackColor=Color.LightBlue;
                RegButton.BackColor=Color.Lime;
            }
        }

        public void DelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DelRadioButton.Checked)
            {
                MemBox.Enabled=true;
                RegButton.BackColor=Color.Red;
                MemBox.BackColor=Color.Yellow;
                KindCombo.SelectedIndex=0;
                KindCombo.Enabled=true;
                KindCombo.Focus();
            }
        }
    }
}
