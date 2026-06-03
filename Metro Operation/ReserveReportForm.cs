using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ReserveReportForm
    {
        public ReserveReportForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string PLocal;
        private string PTime;
        private string PShift;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private dynamic EnterShift(string Tarikh, string ShName)
        {
            string LaShName="";
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh FROM Taghvim WHERE Tarikh='" + Tarikh + "' ORDER BY Tarikh ASC", StrConnec))
                using (OleDbDataReader Reader=CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        LaShName=Reader["Sobh"].ToString();
                    }
                }

                if (ShName == LaShName)
                {
                    Taghvim PersianDate=new Taghvim(Tarikh);
                    PersianDate.AddDay(-1);
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Asr FROM Taghvim WHERE Tarikh='" + PersianDate.Tarikh() + "' ORDER BY Tarikh ASC", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            LaShName=Reader["Asr"].ToString();
                        }
                    }
                }
            }

            return LaShName;
        }

        public void ReserveReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "040601");
        }

        public void Form34_Load(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.Items.Clear();
                if (AppState.UserLevel < 6)
                {
                    LocalCombo.Items.Add("همه موارد");
                }
                else
                {
                    ShiftCheck.Visible=false;
                }

                if (AppState.UserLevel != 9)
                {
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
                }
                else
                {
                    PNum=AppState.UserPnum;
                    NameButton.Enabled=false;
                    NameBox.Text=AppState.UserName;

                    LocalCombo.Items.Add(AppState.UserLocal);

                    LocalCombo.Enabled=false;
                    TimeCombo.Enabled=false;
                    ShiftCombo.Enabled=false;

                    LocalCombo.Text=AppState.UserLocal;
                    TimeCombo.Text=AppState.UserTime;
                    ShiftCombo.Text=AppState.UserShift;
                }

                StartCalendar.FirstDayOfMonth_Click(null, null);
                EndCalendar.LastDayOfMonth_Click(null, null);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;

            LocalCombo.Enabled=true;
            TimeCombo.Enabled=true;
            ShiftCombo.Enabled=true;
            LocalCombo.SelectedIndex=-1;

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                LocalCombo.Enabled=false;
                TimeCombo.Enabled=false;
                ShiftCombo.Enabled=false;

                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                PLocal=PersonalSelectForm.PLocal;
                PTime=PersonalSelectForm.PTime;
                PShift=PersonalSelectForm.PShift;

                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;

                LocalCombo.Text=PLocal;
                TimeCombo.Items.Add(PTime);
                TimeCombo.Text=PTime;
                ShiftCombo.Items.Add(PShift);
                ShiftCombo.Text=PShift;
            }
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True AND P_Post='راهبر قطار'";
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

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TimeCombo.Enabled)
                {
                    ShiftCombo.SelectedIndex=-1;
                    if (TimeCombo.SelectedIndex >= 0)
                    {
                        ShiftCombo.Items.Clear();
                        ShiftCombo.Items.Add("همه موارد");
                        string QueStr="Vis=True AND P_Post='راهبر قطار'";
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
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
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

                        DataTable Dt=new DataTable();
                        foreach (DataGridViewColumn Column in ShowGridView.Columns)
                        {
                            Dt.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in ShowGridView.Rows)
                        {
                            Dt.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt.Rows[Dt.Rows.Count - 1][cell.ColumnIndex]=cell.Value.ToString();
                            }
                        }
                        using (XLWorkbook Wb=new XLWorkbook())
                        {
                            Wb.RightToLeft=true;
                            Wb.Style.Alignment.Horizontal=(XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder=XLBorderStyleValues.Thin;
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

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i=0; i <= ShowGridView.RowCount - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value=i + 1;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (LocalCombo.Enabled && LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا پرسنل را مشخص کنید");
                }
                else if (TimeCombo.Enabled && TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت پرسنل را مشخص کنید");
                }
                else if (ShiftCombo.Enabled && ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "نام شیفت پرسنل را مشخص کنید");
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
                    Enabled=false;
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();


                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            DataTable TempTable=new DataTable();

                            string StrQuer="Select Person.Fname, Person.Family, Person.P_Num, Person.Shift_Time, Person.Shift_name, Rezerv.Tarikh, Rezerv.Vorood, Rezerv.Khorooj, Rezerv.Trip1, Rezerv.Trip2, Rezerv.Mem, Rezerv.U_Reg, Rezerv.U_Mod, Rezerv.Vis From Rezerv INNER JOIN Person ON Person.P_Num=Rezerv.P_Num WHERE Rezerv.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                            if (ZeroRowCheck.Checked)
                            {
                                StrQuer += " And Rezerv.Vis=True";
                            }

                            if (NameBox.Text.Length > 0)
                            {
                                StrQuer += " And Rezerv.P_Num='" + PNum + "'";
                            }
                            else
                            {
                                if (AppState.UserLevel > 1)
                                {
                                    StrQuer += " And Person.Line_Num='" + AppState.UserLnum + "'";
                                }

                                if (AppState.UserLevel < 6)
                                {
                                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                                    {
                                        StrQuer += " AND Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                    }
                                }
                                else
                                {
                                    StrQuer += " And Person.Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                                }
                                if ((string)ShiftCombo.SelectedItem != "همه موارد")
                                {
                                    StrQuer += " And Person.Shift_name='" + ShiftCombo.SelectedItem + "'";
                                }

                                if ((string)TimeCombo.SelectedItem != "همه موارد")
                                {
                                    StrQuer += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                                }
                            }
                            StrQuer += " ORDER BY Rezerv.Tarikh DESC";
                            using (OleDbDataAdapter Adap=new OleDbDataAdapter(StrQuer, StrConnec))
                            {
                                Adap.Fill(TempTable);
                            }


                            string LastShift="";
                            LastShift="";
                            for (int i=0; i <= TempTable.Rows.Count - 1; i++)
                            {
                                string Users=TempTable.Rows[i]["U_Reg"].ToString();
                                if (TempTable.Rows[i]["U_Mod"].ToString() != "")
                                {
                                    Users=TempTable.Rows[i]["U_Mod"].ToString();
                                }

                                if (ShiftCheck.Checked)
                                {
                                    if (TempTable.Rows[i]["Shift_Time"].ToString() == "12 ساعته")
                                    {
                                        LastShift=TempTable.Rows[i]["Shift_name"].ToString();
                                    }
                                    else
                                    {
                                        //If Tarikh <> TempTable.Rows(i).Item("Tarikh").ToString Then
                                        //Tarikh=TempTable.Rows(i).Item("Tarikh").ToString
                                        LastShift=EnterShift(TempTable.Rows[i]["Tarikh"].ToString(), TempTable.Rows[i]["Shift_name"].ToString());
                                        //End If
                                    }
                                }

                                ShowGridView.Rows.Add(i + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Shift_Time"].ToString(), TempTable.Rows[i]["Shift_name"].ToString(), TempTable.Rows[i]["Tarikh"].ToString(), TempTable.Rows[i]["Vorood"].ToString(), TempTable.Rows[i]["Khorooj"].ToString(), TempTable.Rows[i]["Trip1"].ToString(), TempTable.Rows[i]["Trip2"].ToString(), TempTable.Rows[i]["Mem"].ToString(), Users, LastShift);

                                if (!(bool)TempTable.Rows[i]["Vis"])
                                {
                                    ShowGridView.Rows[i].DefaultCellStyle.BackColor=Color.FromArgb(255, 120, 120);
                                }
                            }
                            TempTable.Dispose();
                        }

                        Enabled=true;
                        wait.Close();
                    }

                    if (ShowGridView.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
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
