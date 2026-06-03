using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripTotalReportForm
    {
        public TripTotalReportForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string PLocal;
        private string PPost;
        private string PTime;
        private string PShift;

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;

            LocalCombo.Enabled=true;
            PostCombo.Enabled=true;
            TimeCombo.Enabled=true;
            ShiftCombo.Enabled=true;
            LocalCombo.SelectedIndex=-1;

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                PLocal=PersonalSelectForm.PLocal;
                PPost=PersonalSelectForm.PPost;
                PTime=PersonalSelectForm.PTime;
                PShift=PersonalSelectForm.PShift;

                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;

                LocalCombo.Text=PLocal;
                PostCombo.Items.Add(PPost);
                PostCombo.Text=PPost;
                TimeCombo.Items.Add(PTime);
                TimeCombo.Text=PTime;
                ShiftCombo.Items.Add(PShift);
                ShiftCombo.Text=PShift;
            }

        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "نام شیفت را مشخص کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع لوحه را مشخص کنید");
                }
                else if (StartDate==null )
                {
                    ErrorShow(StartCalendar, "تاریخ شروع گزارش را مشخص کنید");
                }
                else if (EndDate==null)
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
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        ShowGridView.Rows.Clear();


                        string CommandStr="Vis=True";
                        if (NameBox.Text.Length > 0)
                        {
                            CommandStr += " AND P_Num='" + PNum + "'";
                        }
                        else
                        {
                            if (AppState.UserLevel > 1)
                            {
                                CommandStr += " AND Line_Num='" + AppState.UserLnum + "'";
                            }
                            if ((string)LocalCombo.SelectedItem != "همه موارد")
                            {
                                CommandStr += " AND Shift_Loc='" + LocalCombo.SelectedItem + "'";
                            }
                            if ((string)PostCombo.SelectedItem != "همه موارد")
                            {
                                CommandStr += " AND P_Post='" + PostCombo.SelectedItem + "'";
                            }
                            if ((string)TimeCombo.SelectedItem != "همه موارد")
                            {
                                CommandStr += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                            }
                            if ((string)ShiftCombo.SelectedItem != "همه موارد")
                            {
                                CommandStr += " AND Shift_name='" + ShiftCombo.SelectedItem + "'";
                            }
                        }

                        int i=0;
                        DataRow[] DRow=MainForm.PersonTable.Select(CommandStr, "Family");
                        foreach (DataRow DtR in DRow)
                        {
                            i++;
                            ShowGridView.Rows.Add(i, DtR["FName"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["P_Post"].ToString(), DtR["Shift_Loc"].ToString(), DtR["Shift_Time"].ToString(), DtR["Shift_Name"].ToString(), 0, 0, 0, 0);
                        }



                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            int RMaster=0;
                            int RSlave=0;
                            int RTrain=0;
                            for (i=0; i <= ShowGridView.RowCount - 1; i++)
                            {
                                RMaster=0;
                                RSlave=0;
                                RTrain=0;
                                string QueStr="SELECT COUNT(IIF(O1_Num='" + ShowGridView.Rows[i].Cells[3].Value + "', 1, NULL)) AS R1, COUNT(IIF(O2_Num='" + ShowGridView.Rows[i].Cells[3].Value + "', 1, NULL)) AS R2, COUNT(IIF(OT_Num='" + ShowGridView.Rows[i].Cells[3].Value + "', 1, NULL)) AS R3 FROM DailyTrip WHERE Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND (O1_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' OR O2_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' OR OT_Num='" + ShowGridView.Rows[i].Cells[3].Value + "') AND "; //Vis=True AND
                                if (KindCombo.SelectedIndex == 0)
                                {
                                    QueStr += "Prime=True";
                                }
                                else if (KindCombo.SelectedIndex == 1)
                                {
                                    QueStr += "Execu=True";
                                }
                                else
                                {
                                    QueStr += "Final=True";
                                }

                                using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                                {
                                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            RMaster=int.Parse(Reader["R1"].ToString());
                                            RSlave=int.Parse(Reader["R2"].ToString());
                                            RTrain=int.Parse(Reader["R3"].ToString());
                                        }
                                    }

                                }

                                ShowGridView.Rows[i].Cells[8].Value=RMaster + RSlave + RTrain;
                                ShowGridView.Rows[i].Cells[9].Value=RMaster;
                                ShowGridView.Rows[i].Cells[10].Value=RSlave;
                                ShowGridView.Rows[i].Cells[11].Value=RTrain;
                            }
                        }


                        ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
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
                    //WaitForm.Show(Me)
                    //Dim ExcelApp As New Excel.Application()
                    //Dim Worksheet As Excel.Worksheet
                    //Dim Workbook As Excel.Workbook
                    //Dim NewCulture, OldCulture As Globalization.CultureInfo

                    //OldCulture= Threading.Thread.CurrentThread.CurrentCulture
                    //NewCulture=New Globalization.CultureInfo(ExcelApp.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI), True)
                    // Threading.Thread.CurrentThread.CurrentCulture=NewCulture

                    //Dim misValue As Object= Reflection.Missing.Value
                    //Dim i, j As Integer


                    //Application.DoEvents()                                      ' ************* Worksheet1
                    //ExcelApp=New Excel.Application
                    //Workbook=ExcelApp.Workbooks.Add(misValue)
                    //Worksheet=Workbook.Sheets("sheet1")
                    //Worksheet.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4
                    //Worksheet.DisplayRightToLeft=True
                    //Worksheet.Cells.Font.Name="Tahoma"
                    //Worksheet.Cells.Font.Size=10
                    //Worksheet.Rows.RowHeight=18
                    //Worksheet.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter
                    //Worksheet.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter

                    //Worksheet.Cells.NumberFormat="@"
                    //Worksheet.Rows(1).RowHeight=22

                    //For i=0 To ShowGridView.Columns.Count - 1
                    //    Worksheet.Cells(1, i + 1)=ShowGridView.Columns(i).HeaderText
                    //    Worksheet.Cells(1, i + 1).Font.Bold=True
                    //    Worksheet.Cells(1, i + 1).Interior.Color= Drawing.ColorTranslator.ToOle(Color.Yellow)
                    //Next
                    //Application.DoEvents()

                    //For i=1 To ShowGridView.RowCount
                    //    For j=0 To ShowGridView.ColumnCount - 1
                    //        Worksheet.Cells(i + 1, j + 1)=ShowGridView(j, i - 1).Value.ToString()
                    //    Next
                    //Next
                    //Worksheet.Columns.EntireColumn.AutoFit()
                    //Worksheet.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous

                    //Worksheet.SaveAs(SaveFileDialog.FileName)
                    //Workbook.Close()
                    //ExcelApp.Quit()

                    //ReleaseObject(ExcelApp)
                    //ReleaseObject(Workbook)
                    //ReleaseObject(Worksheet)

                    //WaitForm.Close()
                    //MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information)
                    // Threading.Thread.CurrentThread.CurrentCulture=OldCulture
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

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.Enabled)
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
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void TripTotalReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.Items.Clear();

                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum=AppState.UserPnum;
                    NameButton.Enabled=false;
                    NameBox.Text=AppState.UserName;

                    LocalCombo.Enabled=false;
                    PostCombo.Enabled=false;
                    TimeCombo.Enabled=false;
                    ShiftCombo.Enabled=false;

                    LocalCombo.Text=AppState.UserLocal;
                    PostCombo.Text=AppState.UserPost;
                    TimeCombo.Text=AppState.UserTime;
                    ShiftCombo.Text=AppState.UserShift;
                }
                else
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
    }
}
