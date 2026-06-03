using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ManageFunctionReportForm
    {
        public ManageFunctionReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public static int EmtCalc(string Amal)
        {
            int Emt;

            switch (Amal)
            {
                case "ارائه گزارش های فنی مناسب":
                    Emt=2;
                    break;
                case "اطلاع رسانی به موقع معایب قطار":
                    Emt=2;
                    break;
                case "حضور در محل کار در شرایط حاد و انجام حرکت خارج از شیفت کاری":
                    Emt=2;
                    break;
                case "رفع معایب قطار در حداقل زمان (نظر کارشناسی)":
                    Emt=2;
                    break;
                case "هماهنگی در شرایط خاص":
                    Emt=2;
                    break;
                case "امتیاز مثبت (سایر)":
                    Emt=2;
                    break;
                case "برخورد نامناسب با مسئولین و سایر همکاران":
                    Emt=-2;
                    break;
                case "تعویض کشیک پس از پردازش لوحه":
                    Emt=-2;
                    break;
                case "جابجایی حرکت بدون هماهنگی با مسئول وقت":
                    Emt=-2;
                    break;
                case "حضور هر دو راهبر در لکوموتیو Master":
                    Emt=-2;
                    break;
                case "خروج از محل کار بدون هماهنگی با مسئول وقت":
                    Emt=-2;
                    break;
                case "حذف مرخصی بعد از پردازش لوحه":
                    Emt=-2;
                    break;
                case "درخواست مرخصی پس از پردازش لوحه":
                    Emt=-2;
                    break;
                case "عدم ارائه گزارش تاخیر":
                    Emt=-2;
                    break;
                case "عدم استفاده از لباس فرم":
                    Emt=-2;
                    break;
                case "عدم اعلام حضور در محل کار به مسئول وقت":
                    Emt=-2;
                    break;
                case "عدم تحویل و تحول به موقع قطار":
                    Emt=-2;
                    break;
                case "عدم حضور در محل کار (در زمان اضافه کار)":
                    Emt=-2;
                    break;
                case "عدم هماهنگی راهبر رزرو با مسئول وقت":
                    Emt=-2;
                    break;
                case "کشیدن سیگار در محل کار":
                    Emt=-2;
                    break;
                case "نرسیدن به حرکت":
                    Emt=-2;
                    break;
                case "امتیاز منفی (سایر)":
                    Emt=-2;
                    break;
                default:
                    Emt=-2;
                    break;
            }
            return Emt;
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();

                DateTime StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                DateTime EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (StartDate == null)
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش صحیح نیست");
                }
                else if (EndDate == null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان گزارش صحیح نیست");
                }
                else if (StartDate > EndDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی گزارش صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی گزارش صحیح نیست");
                }
                else if (UserCombo.SelectedIndex < 0)
                {
                    ErrorShow(UserCombo, "لطفا نام کاربر را مشخص نمایید");
                }
                else if (NegetiveBox.CheckedItems.Count + PosetiveBox.CheckedItems.Count == 0)
                {
                    ErrorShow(NegetiveBox, "انتخاب حداقل یک گزینه الزامی است");
                    ErrorShow(PosetiveBox, "انتخاب حداقل یک گزینه الزامی است");
                }
                else
                {
                    int i;
                    int j=0;
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        while (ShowGridView.Columns.Count > 8)
                        {
                            ShowGridView.Columns.RemoveAt(8);
                        }

                        for (i=0; i <= NegetiveBox.CheckedItems.Count - 1; i++)
                        {
                            ShowGridView.Columns.Add(i.ToString(), NegetiveBox.CheckedItems[i].ToString());
                        }
                        for (i=0; i <= PosetiveBox.CheckedItems.Count - 1; i++)
                        {
                            ShowGridView.Columns.Add(i.ToString(), PosetiveBox.CheckedItems[i].ToString());
                        }

                        for (i=7; i <= ShowGridView.ColumnCount - 1; i++)
                        {
                            if (ShowGridView.Columns[i].HeaderText.Length <= 20)
                            {
                                ShowGridView.Columns[i].Width=60;
                            }

                            if (ShowGridView.Columns[i].HeaderText.Length > 20)
                            {
                                ShowGridView.Columns[i].Width=75;
                            }

                            if (ShowGridView.Columns[i].HeaderText.Length > 30)
                            {
                                ShowGridView.Columns[i].Width=90;
                            }

                            if (ShowGridView.Columns[i].HeaderText.Length > 40)
                            {
                                ShowGridView.Columns[i].Width=110;
                            }
                        }

                        i=0;
                        string QueStr="P_Num<>''"; // "Vis=True"
                        if (AppState.UserLevel > 1)
                        {
                            QueStr += " And Line_Num='" + AppState.UserLnum + "'";
                        }

                        if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                        {
                            QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                        }

                        if (AppState.UserLevel < 6)
                        {
                            if ((string)LocalCombo.SelectedItem != "همه موارد")
                            {
                                QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                            }
                        }
                        else
                        {
                            QueStr += " And Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                        }
                        if ((string)TimeCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " And Shift_Time='" + TimeCombo.SelectedItem + "'";
                        }

                        if ((string)ShiftCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " And Shift_name='" + ShiftCombo.SelectedItem + "'";
                        }

                        DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                        foreach (DataRow DtR in DRow)
                        {
                            ShowGridView.Rows.Add(i + 1, DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["Shift_Time"].ToString() + " " + DtR["Shift_name"].ToString(), DtR["Shift_Loc"].ToString());
                            for (j=6; j <= ShowGridView.ColumnCount - 1; j++)
                            {
                                ShowGridView.Rows[i].Cells[j].Value=0;
                            }
                            i++;
                        }

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            for (i=0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                string StrQuer="SELECT Amal FROM Amal WHERE P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "' AND Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "'";
                                if ((string)UserCombo.SelectedItem != "همه موارد")
                                {
                                    StrQuer += " AND U_Reg='" + UserCombo.SelectedItem + "'";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        for (j=8; j <= ShowGridView.ColumnCount - 1; j++)
                                        {
                                            if (Reader["Amal"].ToString() == ShowGridView.Columns[j].HeaderText)
                                            {
                                                ShowGridView.Rows[i].Cells[6].Value=Convert.ToInt32(ShowGridView.Rows[i].Cells[6].Value) + EmtCalc(ShowGridView.Columns[j].HeaderText);
                                                ShowGridView.Rows[i].Cells[7].Value=Convert.ToInt32(ShowGridView.Rows[i].Cells[7].Value) + 1;
                                                ShowGridView.Rows[i].Cells[j].Value=Convert.ToInt32(ShowGridView.Rows[i].Cells[j].Value) + 1;
                                            }
                                        }
                                    }
                                }
                            }
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

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i=0; i <= ShowGridView.RowCount - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value=i + 1;
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

        public void ManageFunctionReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0702");
        }

        public void ManageFunctionReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                NegetiveBox.Items.Add("برخورد نامناسب با مسئولین و سایر همکاران");
                NegetiveBox.Items.Add("تعویض کشیک پس از پردازش لوحه");
                NegetiveBox.Items.Add("جابجایی حرکت بدون هماهنگی با مسئول وقت");
                NegetiveBox.Items.Add("حضور هر دو راهبر در لکوموتیو Master");
                NegetiveBox.Items.Add("حذف مرخصی بعد از پردازش لوحه");
                NegetiveBox.Items.Add("خروج از محل کار بدون هماهنگی با مسئول وقت");
                NegetiveBox.Items.Add("درخواست مرخصی پس از پردازش لوحه");
                NegetiveBox.Items.Add("عدم ارائه گزارش تاخیر");
                NegetiveBox.Items.Add("عدم استفاده از لباس فرم");
                NegetiveBox.Items.Add("عدم اعلام حضور در محل کار به مسئول وقت");
                NegetiveBox.Items.Add("عدم تحویل و تحول به موقع قطار");
                NegetiveBox.Items.Add("عدم حضور در محل کار (در زمان اضافه کار)");
                NegetiveBox.Items.Add("عدم هماهنگی راهبر رزرو با مسئول وقت");
                NegetiveBox.Items.Add("کشیدن سیگار در محل کار");
                NegetiveBox.Items.Add("نرسیدن به حرکت");
                NegetiveBox.Items.Add("امتیاز منفی (سایر)");

                PosetiveBox.Items.Add("ارائه گزارش های فنی مناسب");
                PosetiveBox.Items.Add("اطلاع رسانی به موقع معایب قطار");
                PosetiveBox.Items.Add("حضور در محل کار در شرایط حاد و انجام حرکت خارج از شیفت کاری");
                PosetiveBox.Items.Add("رفع معایب قطار در حداقل زمان (نظر کارشناسی)");
                PosetiveBox.Items.Add("هماهنگی در شرایط خاص");
                PosetiveBox.Items.Add("امتیاز مثبت (سایر)");

                UserCombo.Items.Add("همه کاربران");
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    string StrQuer="SELECT Person.P_Num, Person.Line_Num, Person.Fname, Person.Family FROM PUser INNER JOIN Person ON Person.P_Num=PUser.P_Num WHERE PUser.Acc_Levl<9";
                    if (AppState.UserLevel > 1)
                    {
                        StrQuer += " And Person.Line_Num='" + AppState.UserLnum + "'";
                    }

                    StrQuer += " ORDER BY Person.Fname";

                    using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            UserCombo.Items.Add(Reader["Fname"].ToString() + " " + Reader["Family"].ToString());
                        }
                    }
                }


                UserCombo.SelectedIndex=0;
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

        public void AllNegetCheck_CheckedChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
            int i;
            if (AllNegetCheck.CheckState == CheckState.Checked)
            {
                for (i=0; i <= NegetiveBox.Items.Count - 1; i++)
                {
                    NegetiveBox.SetItemChecked(i, true);
                }
            }
            if (AllNegetCheck.CheckState == CheckState.Unchecked)
            {
                for (i=0; i <= NegetiveBox.Items.Count - 1; i++)
                {
                    NegetiveBox.SetItemChecked(i, false);
                }
            }
        }

        public void AllPosetCheck_CheckedChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
            int i;
            if (AllPosetCheck.CheckState == CheckState.Checked)
            {
                for (i=0; i <= PosetiveBox.Items.Count - 1; i++)
                {
                    PosetiveBox.SetItemChecked(i, true);
                }
            }
            if (AllPosetCheck.CheckState == CheckState.Unchecked)
            {
                for (i=0; i <= PosetiveBox.Items.Count - 1; i++)
                {
                    PosetiveBox.SetItemChecked(i, false);
                }
            }
        }

        public void NegetiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NegetiveBox.CheckedItems.Count == NegetiveBox.Items.Count)
            {
                AllNegetCheck.CheckState=CheckState.Checked;
            }
            else
            {
                AllNegetCheck.CheckState=CheckState.Indeterminate;
            }

            if (NegetiveBox.CheckedItems.Count == 0)
            {
                AllNegetCheck.Checked=false;
            }
        }

        public void PosetiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PosetiveBox.CheckedItems.Count == PosetiveBox.Items.Count)
            {
                AllPosetCheck.CheckState=CheckState.Checked;
            }
            else
            {
                AllPosetCheck.CheckState=CheckState.Indeterminate;
            }

            if (PosetiveBox.CheckedItems.Count == 0)
            {
                AllPosetCheck.Checked=false;
            }
        }

        public void AllNegetCheck_Click(object sender, EventArgs e)
        {
            if (AllNegetCheck.CheckState == CheckState.Indeterminate)
            {
                AllNegetCheck.CheckState=CheckState.Unchecked;
            }
        }

        public void AllPosetCheck_Click(object sender, EventArgs e)
        {
            if (AllPosetCheck.CheckState == CheckState.Indeterminate)
            {
                AllPosetCheck.CheckState=CheckState.Unchecked;
            }
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ShowGridView.RowCount > 0)
                {
                    DetailShwoForm ShowForm=new DetailShwoForm();
                    ShowForm.TimeLabel.Text=StartCalendar.Text + " تا " + EndCalendar.Text;
                    ShowForm.UserLabel.Text=ShowGridView.CurrentRow.Cells[1].Value + " " + ShowGridView.CurrentRow.Cells[2].Value;
                    ShowForm.TitrLabel.Text="امتیاز انظباطی";
                    ShowForm.Command="SELECT Person.Fname, Person.Family, Person.P_Num, Amal.Tarikh, Amal.U_Reg, Amal.Amal, Amal.Mem FROM Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.Vis=True AND (Amal.OnvAmal='منفی' OR Amal.OnvAmal='مثبت') AND Amal.P_Num='" + ShowGridView.CurrentRow.Cells[3].Value + "' AND Amal.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Amal.Tarikh";
                    ShowForm.ShowDialog(this);
                    ShowGridView.CurrentRow.Selected=false;
                }
            }
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void UserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
            ShiftCombo.Items.Clear();
            if (TimeCombo.SelectedIndex >= 0)
            {
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

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
