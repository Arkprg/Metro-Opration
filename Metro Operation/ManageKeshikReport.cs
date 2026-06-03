using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ManageKeshikReport
    {
        public ManageKeshikReport()
        {
            InitializeComponent();
        }
        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
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

        public void ManageKeshikReport_Load(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.Items.Clear();
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    LocalCombo.Enabled=false;
                    TimeCombo.Enabled=false;
                    ShiftCombo.Enabled=false;

                    LocalCombo.Text=AppState.UserLocal;
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

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, " مبدا را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, " شیفت را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, " نوع شیفت را مشخص کنید");
                    TimeCombo.Focus();
                }
                else if (ConvertClass.ShamsiToMiladi(EndCalendar.Text) == null)
                {
                    ErrorShow(StartCalendar, " تاریخ وارد شده صحیح نیست");
                    EndCalendar.Focus();
                }
                else if (ConvertClass.ShamsiToMiladi(EndCalendar.Text) < ConvertClass.ShamsiToMiladi(EndCalendar.Text))
                {
                    ErrorShow(StartCalendar, " بازه انتخاب شده صحیح نیست");
                    EndCalendar.Focus();
                }
                else
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;
                        ShowGridView.Rows.Clear();

                        int i;
                        int j=0;
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
                        else
                        {
                            QueStr += " And Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                        }

                        if ((string)PostCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                        }

                        if ((string)TimeCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem + "'";
                        }

                        if ((string)ShiftCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND Shift_name='" + ShiftCombo.SelectedItem + "'";
                        }

                        i=1;
                        DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                        foreach (DataRow DtR in DRow)
                        {
                            ShowGridView.Rows.Add(i, DtR["FName"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["Shift_Time"].ToString() + " " + DtR["Shift_name"].ToString(), DtR["Shift_Loc"].ToString(), 0, 0, 0, 0, 0);
                            i++;
                        }

                        Taghvim PersianDate=new Taghvim(EndCalendar.Text);
                        PersianDate.AddMonth(-3);

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            string CommandStr="SELECT * FROM keshik WHERE Fad IS NULL AND T_Keshik<>'کلاس آموزش' AND Tarikh BETWEEN '" + PersianDate.FirstOfThisMonth() + "' AND '" + EndCalendar.Text.Substring(0, 8) + "31'";
                            DataTable DataT=new DataTable();
                            using (OleDbDataAdapter Adap=new OleDbDataAdapter(CommandStr, StrConnec))
                            {
                                Adap.Fill(DataT);

                                for (j=0; j <= 3; j++)
                                {
                                    for (i=0; i <= ShowGridView.RowCount - 1; i++)
                                    {
                                        QueStr="P_Num='" + ShowGridView.Rows[i].Cells[3].Value + "' AND Tarikh LIKE '" + PersianDate.Tarikh().Substring(0, 8) + "%'";
                                        DRow=DataT.Select(QueStr);

                                        ShowGridView.Rows[i].Cells[6 + j].Value=DRow.Length;
                                        ShowGridView.Rows[i].Cells[10].Value=(int) ShowGridView.Rows[i].Cells[10].Value + DRow.Length;
                                    }
                                    ShowGridView.Columns[6 + j].HeaderText="تعداد کشیک " + PersianDate.MonthName() + " ماه";
                                    PersianDate.AddMonth(1);
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
                Panel1.Enabled=true;
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    PostCombo.Items.Clear();
                    PostCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True AND P_Post LIKE 'راهبر%'";
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

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
            if (TimeCombo.SelectedIndex >= 0)
            {
                ShiftCombo.Items.Clear();
                ShiftCombo.Items.Add("همه موارد");
                string QueStr="Vis=True AND Shift_name<>'' AND P_Post LIKE 'راهبر%'";
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

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i=0; i <= ShowGridView.RowCount - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value=i + 1;
            }
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True AND P_Post LIKE 'راهبر%'";
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
    }
}
