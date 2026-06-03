using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripSpecialRegisterForm
    {
        public TripSpecialRegisterForm()
        {
            InitializeComponent();
        }

        private readonly string Local1="", Local2="";
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
                ReservBox.Text=Convert.ToInt32(DetailGridView.Rows[Cont].Cells[3].Value).ToString();
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
            if (RegGridView.Rows[i].Cells[5].Value.ToString() == ("صبح " + Local1))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.White;
            }
            else if (RegGridView.Rows[i].Cells[5].Value.ToString() == ("عصر " + Local1))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.Thistle;
            }
            else if (RegGridView.Rows[i].Cells[5].Value.ToString() == ("صبح " + Local2))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.LightBlue;
            }
            else if (RegGridView.Rows[i].Cells[5].Value.ToString() == ("عصر " + Local2))
            {
                RegGridView.Rows[i].DefaultCellStyle.BackColor=Color.Yellow;
            }
        }

        public void SingleTripForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "030105");
        }

        public void SingleTripForm_Load(object sender, EventArgs e)
        {
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

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TripCombo.SelectedIndex=-1;
        }

        public void TripCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Panel1.Enabled=false;
                NameBox.Text="";
                PNumBox.Text="";
                ReservBox.Text="";

                if (ShiftCombo.SelectedIndex >= 0)
                {
                    DateTime SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                    if (SelectDate == null)
                    {
                        ErrorShow(PersianCalendar, "تاریخ را مشخص کنید");
                    }
                    else if (SelectDate < DateTime.Today || SelectDate > DateTime.Today.AddDays(7))
                    {
                        ErrorShow(PersianCalendar, "تاریخ وارد شده صحیح نیست");
                    }
                    else if (LocalCombo.SelectedIndex < 0)
                    {
                        ErrorShow(LocalCombo, "ایستگاه مبدا را انتخاب کنید");
                    }
                    else if (TripCombo.SelectedIndex < 0)
                    {
                        ErrorShow(TripCombo, "نوع تریپ را انتخاب کنید");
                    }
                    else
                    {
                        Taghvim PersianDate=new Taghvim(PersianCalendar.Text);
                        string ShName="";
                        string ShTime="";
                        int Trp1=0;
                        int i;
                        double Emt=0;
                        double DateCon=0;

                        PersianDate.AddMonth(-3);

                        DetailGridView.Rows.Clear();
                        Cont=0;
                        ShName="";
                        ShTime="";

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if ((string)ShiftCombo.SelectedItem == "صبح" || (string)ShiftCombo.SelectedItem == "روز")
                                    {
                                        ShName=Reader["Sobh"].ToString();
                                    }
                                    else
                                    {
                                        ShName=Reader["Asr"].ToString();
                                    }
                                }
                            }

                            if ((string)ShiftCombo.SelectedItem == "صبح" || (string)ShiftCombo.SelectedItem == "عصر")
                            {
                                ShTime="9 ساعته";
                            }
                            else
                            {
                                ShTime="12 ساعته";
                            }

                            DataRow[] DRow=MainForm.PersonTable.Select("Vis=True AND Shift_Time='" + ShTime + "' AND Trip=True AND P_Post='راهبر قطار' AND Shift_Name='" + ShName + "' AND Shift_Loc='" + LocalCombo.Text + "' ");
                            foreach (DataRow DtR in DRow)
                            {
                                DetailGridView.Rows.Add(DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0, 0.0, DtR["Shift_Time"].ToString());
                            }

                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Morakhasi WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
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

                            using (OleDbCommand CMD=new OleDbCommand("SELECT P_Num FROM Rezerv WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
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

                            using (OleDbCommand CMD=new OleDbCommand("SELECT P_Num FROM TakTrip WHERE Tarikh='" + PersianCalendar.Text + "' AND Vis=True", StrConnec))
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

                            for (i=0; i <= DetailGridView.RowCount - 1; i++)
                            {
                                Trp1=0;
                                Emt=0;
                                DateCon=0;

                                using (OleDbCommand CMD=new OleDbCommand("SELECT Tarikh FROM TakTrip WHERE P_Num='" + DetailGridView.Rows[i].Cells[2].Value + "' AND Vis=True AND Tarikh BETWEEN '" + PersianCalendar.Text + "' AND '" + PersianDate.Tarikh() + "' AND Trip='" + TripCombo.SelectedItem + "' ORDER BY Tarikh", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (ConvertClass.ShamsiToMiladi(Reader["Tarikh"].ToString()) > ConvertClass.ShamsiToMiladi(PersianCalendar.Text).AddDays(-5))
                                        {
                                            Emt++;
                                        }

                                        DateCon=(double)Convert.ToInt32(Reader["Tarikh"].ToString().Substring(2, 8).Replace("/", "")) / 1000000;
                                        Trp1++;
                                    }
                                }

                                DetailGridView.Rows[i].Cells[3].Value=Trp1;
                                DetailGridView.Rows[i].Cells[4].Value=Trp1 + Emt + DateCon;
                            }
                        }


                        DetailGridView.Sort(DetailGridView.Columns[4], System.ComponentModel.ListSortDirection.Ascending);

                        AddRadioButton.Checked=true;
                        if (AppState.UserLevel < 3 & AppState.UserLevel > 8)
                        {
                            Panel1.Enabled=false;
                        }
                        else
                        {
                            Panel1.Enabled=true;
                        }

                        Fill();
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                //  Me.Close()
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(PNumBox.Text, out _))
                {

                    if (AddRadioButton.Checked)
                    {
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TakTrip (P_NUM, Tarikh, T_Shift, Trip, U_Reg, T_Reg, Vis) VALUES ('" + DetailGridView.Rows[Cont].Cells[2].Value + "','" + PersianCalendar.Text + "', '" + ShiftCombo.SelectedItem + "', '" + TripCombo.SelectedItem + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        RegGridView.Rows.Add(Cont, DetailGridView.Rows[Cont].Cells[0].Value, DetailGridView.Rows[Cont].Cells[1].Value, DetailGridView.Rows[Cont].Cells[2].Value, TripCombo.SelectedItem, ShiftCombo.Text + " " + LocalCombo.Text);
                        Cont++;
                        Fill();
                        int i;
                        for (i=0; i <= RegGridView.RowCount - 1; i++)
                        {
                            RegGridView.Rows[i].Cells[0].Value=i + 1;
                        }
                    }
                    else if (DelRadioButton.Checked)
                    {
                        if (MemBox.Text.Trim().Length < 10)
                        {
                            MessageBoxFa.Show("لطفا توضیحات لازم را وارد کنید", "خطا", MessageBoxIcon.Error);
                            MemBox.Focus();
                        }
                        else
                        {
                            RegButton.Enabled=false;

                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();
                                using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TakTrip (P_NUM, Tarikh, T_Shift, Trip, U_Reg, T_Reg, Vis, Mem) VALUES ('" + DetailGridView.Rows[Cont].Cells[2].Value + "','" + PersianCalendar.Text + "', '" + ShiftCombo.SelectedItem + "', '" + TripCombo.SelectedItem + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', False, @Mem)", StrConnec))
                                {
                                    CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                                    CMD.ExecuteNonQuery();
                                }

                            }

                            Cont++;
                            Fill();
                            RegButton.Enabled=true;
                        }
                    }
                    Colorring(RegGridView.RowCount - 1);
                    RegGridView_ColumnHeaderMouseClick(null, null);
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
            try
            {
                int i;
                RegGridView.Rows.Clear();

                i=0;

                string QueStr="SELECT Person.Fname, Person.Family, Person.P_Num, Person.Shift_Loc, TakTrip.Tarikh, TakTrip.T_Shift, TakTrip.Trip FROM TakTrip INNER JOIN Person ON Person.P_Num=TakTrip.P_Num WHERE TakTrip.Tarikh='" + PersianCalendar.Text + "' AND TakTrip.Vis=True";
                if (AppState.UserLevel > 1)
                {
                    QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                }

                QueStr += " ORDER BY TakTrip.T_Shift, TakTrip.Trip, Person.Shift_Loc, Person.Family, Person.Fname";

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            RegGridView.Rows.Add(i + 1, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Trip"].ToString(), Reader["T_Shift"].ToString() + " " + Reader["Shift_Loc"].ToString());
                            Colorring(i);
                            i++;
                        }
                    }
                }

                LocalCombo.SelectedIndex=-1;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void RegGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RegGridView.Sort(RegGridView.Columns[5], System.ComponentModel.ListSortDirection.Ascending);
            int i;
            for (i=0; i <= RegGridView.RowCount - 1; i++)
            {
                RegGridView.Rows[i].Cells[0].Value=i + 1;
            }
        }
    }
}
