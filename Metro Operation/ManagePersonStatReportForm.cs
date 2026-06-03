using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace Metro_Operation
{

    public partial class ManagePersonStatReportForm
    {
        public ManagePersonStatReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj=null;
            }
            catch { }
        }

        public void ManagePersonStatReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "070402");
        }

        public void ManagePersonStatReportForm_Load(object sender, EventArgs e)
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
                LocalCombo.SelectedIndex=0;
            }

            KindCombo.Enabled=false;
            KindCombo.SelectedIndex=0;

            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع گزارش را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "شیفت را مشخص کنید");
                }
                else if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate == null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش را مشخص کنید");
                }
                else if (StartDate > EndDate)
                {
                    ErrorShow(EndCalendar, "بازه تاریخی گزارش صحیح نیست");
                    ErrorShow(StartCalendar, "بازه تاریخی گزارش صحیح نیست");
                }
                else
                {

                    int i;
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        DataGridView1.Rows.Clear();
                        DataGridView2.Rows.Clear();
                        DataGridView3.Rows.Clear();
                        DataGridView4.Rows.Clear();
                        DataGridView5.Rows.Clear();

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            string QueStr="";
                            if (KindCombo.SelectedIndex == 1)
                            {
                                QueStr="SELECT Person.P_Num, Person.Line_Num, Person.Fname, Person.Family, Person.P_Post FROM PUser INNER JOIN Person ON Person.P_Num=PUser.P_Num WHERE PUser.Acc_Levl<9";
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " AND Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                                {
                                    QueStr += " AND Person.P_Staff='" + AppState.UserStaff + "'";
                                }

                                if ((string)ShiftCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Shift_name='" + ShiftCombo.SelectedItem + "'";
                                }

                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }

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

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DataGridView1.Rows.Add(0, Reader["FName"].ToString() + " " + Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0);
                                        DataGridView2.Rows.Add(0, Reader["FName"].ToString() + " " + Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0);
                                        DataGridView3.Rows.Add(0, Reader["FName"].ToString() + " " + Reader["Family"].ToString(), Reader["P_Num"].ToString(), "00:00", 0.0);
                                        DataGridView4.Rows.Add(0, Reader["FName"].ToString() + " " + Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0);
                                        DataGridView5.Rows.Add(0, Reader["FName"].ToString() + " " + Reader["Family"].ToString(), Reader["P_Num"].ToString(), 0);
                                    }
                                }
                            }
                            else if (KindCombo.SelectedIndex == 0)
                            {
                                QueStr="Vis=True";
                                if (AppState.UserLevel > 1)
                                {
                                    QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                                }

                                if ((string)LocalCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem + "'";
                                }

                                if ((string)PostCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                                }

                                if ((string)ShiftCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Shift_name='" + ShiftCombo.SelectedItem + "'";
                                }

                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }

                                DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                                foreach (DataRow DtR in DRow)
                                {
                                    DataGridView1.Rows.Add(0, DtR["FName"].ToString() + " " + DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0);
                                    DataGridView2.Rows.Add(0, DtR["FName"].ToString() + " " + DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0);
                                    DataGridView3.Rows.Add(0, DtR["FName"].ToString() + " " + DtR["Family"].ToString(), DtR["P_Num"].ToString(), "00:00", 0.0);
                                    DataGridView4.Rows.Add(0, DtR["FName"].ToString() + " " + DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0);
                                    DataGridView5.Rows.Add(0, DtR["FName"].ToString() + " " + DtR["Family"].ToString(), DtR["P_Num"].ToString(), 0);
                                }
                            }

                            DataGridView1.Rows.Add(0, "مجموع", "", 0);
                            DataGridView2.Rows.Add(0, "مجموع", "", 0);
                            DataGridView3.Rows.Add(0, "مجموع", "", "00:00", 0.0);
                            DataGridView4.Rows.Add(0, "مجموع", "", 0);
                            DataGridView5.Rows.Add(0, "مجموع", "", 0);


                            i=0;
                            int Sum=0;
                            while (i < DataGridView1.RowCount - 1)
                            {
                                QueStr="SELECT COUNT(Amal) AS Cou FROM Amal WHERE OnvAmal='منفی' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + DataGridView1.Rows[i].Cells[2].Value + "'";
                                }

                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + DataGridView1.Rows[i].Cells[1].Value + "'";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DataGridView1.Rows[i].Cells[3].Value=Reader["Cou"];
                                        Sum += Convert.ToInt32(Reader["Cou"]);
                                    }
                                }

                                if ((int)DataGridView1.Rows[i].Cells[3].Value == 0 && ZeroRowCheck.Checked)
                                {
                                    DataGridView1.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }
                            DataGridView1.Sort(DataGridView1.Columns[3], System.ComponentModel.ListSortDirection.Descending);
                            DataGridView1.Rows[i].Cells[3].Value=Sum;
                            for (i=0; i <= DataGridView1.RowCount - 1; i++)
                            {
                                DataGridView1.Rows[i].Cells[0].Value=i + 1;
                            }

                            i=0;
                            Sum=0;
                            while (i < DataGridView2.RowCount - 1)
                            {
                                QueStr="SELECT COUNT(Amal) AS Cou FROM Amal WHERE OnvAmal='مثبت' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + DataGridView2.Rows[i].Cells[2].Value + "'";
                                }

                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + DataGridView2.Rows[i].Cells[1].Value + "'";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DataGridView2.Rows[i].Cells[3].Value=Reader["Cou"];
                                        Sum += Convert.ToInt32(Reader["Cou"]);
                                    }
                                }

                                if ((int)DataGridView2.Rows[i].Cells[3].Value == 0 && ZeroRowCheck.Checked)
                                {
                                    DataGridView2.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }

                            DataGridView2.Sort(DataGridView2.Columns[3], System.ComponentModel.ListSortDirection.Descending);
                            DataGridView2.Rows[i].Cells[3].Value=Sum;
                            for (i=0; i <= DataGridView2.RowCount - 1; i++)
                            {
                                DataGridView2.Rows[i].Cells[0].Value=i + 1;
                            }

                            i=0;
                            double SumD=0;
                            while (i < DataGridView3.RowCount - 1)
                            {
                                double Ti=0;
                                QueStr="SELECT Amal FROM Amal WHERE OnvAmal='ساعتی' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + DataGridView3.Rows[i].Cells[2].Value + "'";
                                }

                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + DataGridView3.Rows[i].Cells[1].Value + "'";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        Ti=ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(9, 5));
                                        Ti -= ConvertClass.TimeToDouble(Reader["Amal"].ToString().Substring(0, 5));
                                        if (Ti < 0)
                                        {
                                            Ti += 24;
                                        }

                                        DataGridView3.Rows[i].Cells[4].Value=(double)DataGridView3.Rows[i].Cells[4].Value + Ti;
                                        SumD += Ti;
                                    }
                                }

                                DataGridView3.Rows[i].Cells[3].Value=ConvertClass.DoubleToTime(Convert.ToDouble(DataGridView3.Rows[i].Cells[4].Value));

                                if ((double)DataGridView3.Rows[i].Cells[4].Value == 0 && ZeroRowCheck.Checked)
                                {
                                    DataGridView3.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }
                            DataGridView3.Sort(DataGridView3.Columns[4], System.ComponentModel.ListSortDirection.Descending);
                            DataGridView3.Rows[i].Cells[3].Value=ConvertClass.DoubleToTime(SumD);
                            for (i=0; i <= DataGridView3.RowCount - 1; i++)
                            {
                                DataGridView3.Rows[i].Cells[0].Value=i + 1;
                            }

                            i=0;
                            Sum=0;
                            while (i < DataGridView4.RowCount - 1)
                            {
                                QueStr="SELECT COUNT(Kind) AS Cou FROM Morakhasi WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + DataGridView4.Rows[i].Cells[2].Value + "'";
                                }

                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + DataGridView4.Rows[i].Cells[1].Value + "'";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DataGridView4.Rows[i].Cells[3].Value=Reader["Cou"];
                                        Sum += Convert.ToInt32(Reader["Cou"]);
                                    }
                                }

                                if ((int)DataGridView4.Rows[i].Cells[3].Value == 0 && ZeroRowCheck.Checked)
                                {
                                    DataGridView4.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }

                            DataGridView4.Sort(DataGridView4.Columns[3], System.ComponentModel.ListSortDirection.Descending);
                            DataGridView4.Rows[i].Cells[3].Value=Sum;
                            for (i=0; i <= DataGridView4.RowCount - 1; i++)
                            {
                                DataGridView4.Rows[i].Cells[0].Value=i + 1;
                            }

                            i=0;
                            Sum=0;
                            while (i < DataGridView5.RowCount - 1)
                            {
                                QueStr="SELECT COUNT(Amal) AS Cou FROM Amal WHERE OnvAmal='جابجایی' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += " AND P_Num='" + DataGridView5.Rows[i].Cells[2].Value + "'";
                                }

                                if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += " AND U_Reg='" + DataGridView5.Rows[i].Cells[1].Value + "'";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        DataGridView5.Rows[i].Cells[3].Value=Reader["Cou"];
                                        Sum += Convert.ToInt32(Reader["Cou"]);
                                    }
                                }

                                if ((int)DataGridView5.Rows[i].Cells[3].Value == 0 && ZeroRowCheck.Checked)
                                {
                                    DataGridView5.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }

                            DataGridView5.Sort(DataGridView5.Columns[3], System.ComponentModel.ListSortDirection.Descending);
                            DataGridView5.Rows[i].Cells[3].Value=Sum;
                            for (i=0; i <= DataGridView5.RowCount - 1; i++)
                            {
                                DataGridView5.Rows[i].Cells[0].Value=i + 1;
                            }
                        }

                        if (DataGridView1.RowCount > 0)
                        {
                            DataGridView1.CurrentRow.Selected=false;
                        }

                        if (DataGridView2.RowCount > 0)
                        {
                            DataGridView2.CurrentRow.Selected=false;
                        }

                        if (DataGridView3.RowCount > 0)
                        {
                            DataGridView3.CurrentRow.Selected=false;
                        }

                        if (DataGridView4.RowCount > 0)
                        {
                            DataGridView4.CurrentRow.Selected=false;
                        }

                        if (DataGridView5.RowCount > 0)
                        {
                            DataGridView5.CurrentRow.Selected=false;
                        }

                        Enabled=true;
                        wait.Close();
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

        public void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="امتیاز منفی";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=DataGridView1.CurrentRow.Cells[1].Value.ToString();
            ShowForm.Family="";
            ShowForm.Pnum=DataGridView1.CurrentRow.Cells[2].Value.ToString();
            ShowForm.Command="SELECT Tarikh, U_Reg, Amal, Mem FROM Amal WHERE Vis=True AND OnvAmal='منفی' AND ";

            if (KindCombo.SelectedIndex == 0)
            {
                ShowForm.Command += "P_Num='" + DataGridView1.CurrentRow.Cells[2].Value + "'";
            }
            else
            {
                ShowForm.Command += "U_Reg='" + DataGridView1.CurrentRow.Cells[1].Value + "'";
            }
            ShowForm.Command += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
            DataGridView1.CurrentRow.Selected=false;
        }

        public void DataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="امتیاز مثبت";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=DataGridView2.CurrentRow.Cells[1].Value.ToString();
            ShowForm.Family="";
            ShowForm.Pnum=DataGridView2.CurrentRow.Cells[2].Value.ToString();
            ShowForm.Command="SELECT Tarikh, U_Reg, Amal, Mem FROM Amal WHERE Vis=True AND OnvAmal='مثبت' AND ";

            if (KindCombo.SelectedIndex == 0)
            {
                ShowForm.Command += "P_Num='" + DataGridView2.CurrentRow.Cells[2].Value + "'";
            }
            else
            {
                ShowForm.Command += "U_Reg='" + DataGridView2.CurrentRow.Cells[1].Value + "'";
            }
            ShowForm.Command += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
            DataGridView2.CurrentRow.Selected=false;
        }

        public void DataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="مرخصی ساعتی";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=DataGridView3.CurrentRow.Cells[1].Value.ToString();
            ShowForm.Family="";
            ShowForm.Pnum=DataGridView3.CurrentRow.Cells[2].Value.ToString();
            ShowForm.Command="SELECT Tarikh, U_Reg, Amal FROM Amal WHERE Vis=True AND OnvAmal='ساعتی' AND ";

            if (KindCombo.SelectedIndex == 0)
            {
                ShowForm.Command += "P_Num='" + DataGridView3.CurrentRow.Cells[2].Value + "'";
            }
            else
            {
                ShowForm.Command += "U_Reg='" + DataGridView3.CurrentRow.Cells[1].Value + "'";
            }
            ShowForm.Command += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
            DataGridView3.CurrentRow.Selected=false;
        }

        public void DataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="مرخصی روزانه";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=DataGridView4.CurrentRow.Cells[1].Value.ToString();
            ShowForm.Family="";
            ShowForm.Pnum=DataGridView4.CurrentRow.Cells[2].Value.ToString();
            ShowForm.Command="SELECT Tarikh, U_Reg, Kind FROM Morakhasi WHERE Vis=True AND ";

            if (KindCombo.SelectedIndex == 0)
            {
                ShowForm.Command += "P_Num='" + DataGridView4.CurrentRow.Cells[2].Value + "'";
            }
            else
            {
                ShowForm.Command += "U_Reg='" + DataGridView4.CurrentRow.Cells[1].Value + "'";
            }
            ShowForm.Command += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
            DataGridView4.CurrentRow.Selected=false;
        }

        public void DataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailShwoForm ShowForm=new DetailShwoForm();
            ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
            ShowForm.TitrLabel.Text="جابجایی تریپ";
            ShowForm.UserLabel.Text="";
            ShowForm.FName=DataGridView5.CurrentRow.Cells[1].Value.ToString();
            ShowForm.Family="";
            ShowForm.Pnum=DataGridView5.CurrentRow.Cells[2].Value.ToString();
            ShowForm.Command="SELECT Tarikh, U_Reg, Amal, Mem FROM Amal WHERE Vis=True AND OnvAmal='جابجایی' AND ";

            if (KindCombo.SelectedIndex == 0)
            {
                ShowForm.Command += "P_Num='" + DataGridView5.CurrentRow.Cells[2].Value + "'";
            }
            else
            {
                ShowForm.Command += "U_Reg='" + DataGridView5.CurrentRow.Cells[1].Value + "'";
            }
            ShowForm.Command += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";
            ShowForm.ShowDialog(this);
            DataGridView5.CurrentRow.Selected=false;
        }

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShiftCombo.SelectedIndex=-1;
                if (TimeCombo.SelectedIndex >= 0)
                {
                    ShiftCombo.Items.Clear();
                    ShiftCombo.Items.Add("همه موارد");
                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_name");
                    foreach (DataRow DtR in DRow)
                    {
                        if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                        {
                            ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                        }
                    }
                    ShiftCombo.SelectedIndex=0;
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
                PostCombo.SelectedIndex=-1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    PostCombo.Items.Clear();
                    PostCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "P_Post");
                    foreach (DataRow DtR in DRow)
                    {
                        if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                        {
                            PostCombo.Items.Add(DtR["P_Post"].ToString());
                        }
                    }
                    PostCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (PostCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_Time");
                    foreach (DataRow DtR in DRow)
                    {
                        if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                        {
                            TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                        }
                    }
                    TimeCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            DataGridView2.Rows.Clear();
            DataGridView3.Rows.Clear();
            DataGridView4.Rows.Clear();
            DataGridView5.Rows.Clear();
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            DataGridView2.Rows.Clear();
            DataGridView3.Rows.Clear();
            DataGridView4.Rows.Clear();
            DataGridView5.Rows.Clear();
        }

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1=new SaveFileDialog()
                {
                    Filter="Excel Files|*.xlsx|Excel Files 97-2003|*.xls"
                };
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        Excel.Application ExcelApp=new Excel.Application();
                        Excel.Worksheet Worksheet1;
                        Excel.Worksheet Worksheet2;
                        Excel.Worksheet Worksheet3;
                        Excel.Worksheet Worksheet4;
                        Excel.Worksheet Worksheet5;
                        Excel.Workbook Workbook;
                        System.Globalization.CultureInfo NewCulture;
                        System.Globalization.CultureInfo OldCulture;

                        OldCulture=System.Threading.Thread.CurrentThread.CurrentCulture;
                        NewCulture=new System.Globalization.CultureInfo(ExcelApp.LanguageSettings.get_LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI), true);
                        System.Threading.Thread.CurrentThread.CurrentCulture=NewCulture;

                        object misValue=System.Reflection.Missing.Value;
                        int i;
                        int j=0;

                        Workbook=ExcelApp.Workbooks.Add(misValue);

                        // ************* Worksheet1
                        Worksheet1=Workbook.Sheets["sheet1"];
                        Worksheet1.Name="امتیاز منفی";
                        Worksheet1.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet1.DisplayRightToLeft=true;
                        Worksheet1.Cells.Font.Name="Tahoma";
                        Worksheet1.Cells.Font.Size=10;
                        Worksheet1.Rows.RowHeight=18;
                        Worksheet1.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet1.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet1.Cells.NumberFormat="@";
                        Worksheet1.Rows[1].RowHeight=22;

                        for (i=0; i <= DataGridView1.Columns.Count - 1; i++)
                        {
                            Worksheet1.Cells[1, i + 1]=DataGridView1.Columns[i].HeaderText;
                            Worksheet1.Cells[1, i + 1].Font.Bold=true;
                            Worksheet1.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DataGridView1.RowCount; i++)
                        {
                            for (j=0; j <= DataGridView1.ColumnCount - 1; j++)
                            {
                                Worksheet1.Cells[i + 1, j + 1]=DataGridView1[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet1.Rows[DataGridView1.RowCount + 1].Font.Bold=true;
                        Worksheet1.Rows[DataGridView1.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet1.Columns.EntireColumn.AutoFit();
                        Worksheet1.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet2
                        Worksheet2=Workbook.Sheets.Add(Worksheet1);
                        Worksheet2.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet2.DisplayRightToLeft=true;
                        Worksheet2.Cells.Font.Name="Tahoma";
                        Worksheet2.Cells.Font.Size=10;
                        Worksheet2.Rows.RowHeight=18;
                        Worksheet2.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet2.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet2.Cells.NumberFormat="@";
                        Worksheet2.Rows[1].RowHeight=22;

                        for (i=0; i <= DataGridView2.Columns.Count - 1; i++)
                        {
                            Worksheet2.Cells[1, i + 1]=DataGridView2.Columns[i].HeaderText;
                            Worksheet2.Cells[1, i + 1].Font.Bold=true;
                            Worksheet2.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DataGridView2.RowCount; i++)
                        {
                            for (j=0; j <= DataGridView2.ColumnCount - 1; j++)
                            {
                                Worksheet2.Cells[i + 1, j + 1]=DataGridView2[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet2.Rows[DataGridView2.RowCount + 1].Font.Bold=true;
                        Worksheet2.Rows[DataGridView2.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet2.Columns.EntireColumn.AutoFit();
                        Worksheet2.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet3
                        Worksheet3=Workbook.Sheets.Add(Worksheet2);
                        Worksheet2.Name="مرخصی ساعتی";
                        Worksheet3.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet3.DisplayRightToLeft=true;

                        Worksheet3.Cells.Font.Name="Tahoma";
                        Worksheet3.Cells.Font.Size=10;
                        Worksheet3.Rows.RowHeight=18;
                        Worksheet3.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet3.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet3.Cells.NumberFormat="@";
                        Worksheet3.Rows[1].RowHeight=22;

                        for (i=0; i <= DataGridView3.Columns.Count - 2; i++)
                        {
                            Worksheet3.Cells[1, i + 1]=DataGridView3.Columns[i].HeaderText;
                            Worksheet3.Cells[1, i + 1].Font.Bold=true;
                            Worksheet3.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DataGridView3.RowCount; i++)
                        {
                            for (j=0; j <= DataGridView3.ColumnCount - 2; j++)
                            {
                                Worksheet3.Cells[i + 1, j + 1]=DataGridView3[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet3.Rows[DataGridView3.RowCount + 1].Font.Bold=true;
                        Worksheet3.Rows[DataGridView3.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet3.Columns.EntireColumn.AutoFit();
                        Worksheet3.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet4
                        Worksheet4=Workbook.Sheets.Add(Worksheet3);
                        Worksheet4.Name="مرخصی روزانه";
                        Worksheet4.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet4.DisplayRightToLeft=true;

                        Worksheet4.Cells.Font.Name="Tahoma";
                        Worksheet4.Cells.Font.Size=10;
                        Worksheet4.Rows.RowHeight=18;
                        Worksheet4.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet4.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet4.Cells.NumberFormat="@";
                        Worksheet4.Rows[1].RowHeight=22;

                        for (i=0; i <= DataGridView4.Columns.Count - 1; i++)
                        {
                            Worksheet4.Cells[1, i + 1]=DataGridView4.Columns[i].HeaderText;
                            Worksheet4.Cells[1, i + 1].Font.Bold=true;
                            Worksheet4.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DataGridView4.RowCount; i++)
                        {
                            for (j=0; j <= DataGridView4.ColumnCount - 1; j++)
                            {
                                Worksheet4.Cells[i + 1, j + 1]=DataGridView4[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet4.Rows[DataGridView4.RowCount + 1].Font.Bold=true;
                        Worksheet4.Rows[DataGridView4.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet4.Columns.EntireColumn.AutoFit();
                        Worksheet4.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet5
                        Worksheet5=Workbook.Sheets.Add(Worksheet4);
                        Worksheet5.Name="جابجایی تریپ";
                        Worksheet5.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4;
                        Worksheet5.DisplayRightToLeft=true;

                        Worksheet5.Cells.Font.Name="Tahoma";
                        Worksheet5.Cells.Font.Size=10;
                        Worksheet5.Rows.RowHeight=18;
                        Worksheet5.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet5.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet5.Cells.NumberFormat="@";
                        Worksheet5.Rows[1].RowHeight=22;

                        for (i=0; i <= DataGridView5.Columns.Count - 1; i++)
                        {
                            Worksheet5.Cells[1, i + 1]=DataGridView5.Columns[i].HeaderText;
                            Worksheet5.Cells[1, i + 1].Font.Bold=true;
                            Worksheet5.Cells[1, i + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }


                        for (i=1; i <= DataGridView5.RowCount; i++)
                        {
                            for (j=0; j <= DataGridView5.ColumnCount - 1; j++)
                            {
                                Worksheet5.Cells[i + 1, j + 1]=DataGridView5[j, i - 1].Value.ToString();
                            }
                        }
                        Worksheet5.Rows[DataGridView5.RowCount + 1].Font.Bold=true;
                        Worksheet5.Rows[DataGridView5.RowCount + 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        Worksheet5.Columns.EntireColumn.AutoFit();
                        Worksheet5.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        //     Workbook.Sheets("Sheet2").Delete
                        //     Workbook.Sheets("Sheet3").Delete
                        Worksheet1.SaveAs(SaveFileDialog1.FileName);
                        Workbook.Close();
                        ExcelApp.Quit();

                        ReleaseObject(ExcelApp);
                        ReleaseObject(Workbook);
                        ReleaseObject(Worksheet1);
                        System.Threading.Thread.CurrentThread.CurrentCulture=OldCulture;

                        Enabled=true;
                        wait.Close();
                    }
                    MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Enabled=true;
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }
    }
}
