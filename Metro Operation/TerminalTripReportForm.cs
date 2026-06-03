using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TerminalTripReportForm
    {
        public TerminalTripReportForm()
        {
            InitializeComponent();
        }


        private string PName;
        private string PFamily;
        private string PNum;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            ShowGridView.Rows.Clear();

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;

                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
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

                if (StartDate == null)
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

                    int i=0;
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string QueStr="SELECT * FROM TerminalTrip WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' AND Train<>''";
                        if (NameBox.Text.Length > 0)
                        {
                            QueStr += " AND (O1_Num='" + PNum + "' OR O3_Num ='" + PNum + "')";
                        }

                        if ((string)LocalCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND E_Loca='" + LocalCombo.SelectedItem + "'";
                        }

                        QueStr += " ORDER BY Tarikh DESC, E_Time DESC";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ShowGridView.Rows.Add(i + 1, Reader["Tarikh"].ToString(), Reader["E_Loca"].ToString(), Reader["Trip_Time"].ToString(), Reader["Train"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Position"].ToString(), Reader["E_Time"].ToString(), "", Reader["O1_Num"].ToString(), "", Reader["O3_Num"].ToString(), Reader["StartLocation"].ToString(), Reader["EndLocation"].ToString(), Reader["Mem"].ToString(), Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString(), Reader["E_Mine"].ToString(), "ویرایش");
                                i++;
                            }
                        }
                    }


                    if (ShowGridView.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DataRow[] DRow;
                        for (i=0; i <= ShowGridView.Rows.Count - 1; i++)
                        {
                            if (ShowGridView.Rows[i].Cells[9].Value.ToString() != "")
                            {
                                DRow=MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[9].Value.ToString() + "'");
                                if (DRow.Length > 0)
                                {
                                    ShowGridView.Rows[i].Cells[8].Value=DRow[0][0].ToString() + " " + DRow[0][1].ToString();
                                }
                            }

                            if (ShowGridView.Rows[i].Cells[11].Value.ToString() != "")
                            {
                                DRow=MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[11].Value.ToString() + "'");
                                if (DRow.Length > 0)
                                {
                                    ShowGridView.Rows[i].Cells[10].Value=DRow[0][0].ToString() + " " + DRow[0][1].ToString();
                                }
                            }
                        }
                    }
                    ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                    Enabled=true;
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

        public void DetailGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShowGridView.RowCount > 0)
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == 18)
                    {
                        if ((AppState.UserLevel > 10 && AppState.UserLevel < 18) || AppState.UserLevel < 3)
                        {
                            TerminalTripEditForm ShowForm=new TerminalTripEditForm();
                            ShowForm.SearchKindCombo.SelectedItem=ShowGridView.CurrentRow.Cells[5].Value.ToString();
                            ShowForm.SearchTypeCombo.SelectedItem=ShowGridView.CurrentRow.Cells[6].Value.ToString();
                            ShowForm.SearchPersianCalendar.Text=ShowGridView.CurrentRow.Cells[1].Value.ToString();
                            ShowForm.SearchTrainNumBox.Text=ShowGridView.CurrentRow.Cells[4].Value.ToString();
                            ShowForm.SearchStartBox.Text=ShowGridView.CurrentRow.Cells[3].Value.ToString();
                            ShowForm.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBoxFa.Show("شما مجاز به ویرایش نیستید", "خطا", MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxFa.Show("مبدا: " + ShowGridView.CurrentRow.Cells[12].Value.ToString() + "\nمقصد: " + ShowGridView.CurrentRow.Cells[13].Value.ToString() + "\n\n" + ShowGridView.CurrentRow.Cells[14].Value.ToString(), "توضیحات تریپ", MessageBoxIcon.None);
                    }
                }
            }
        }

        public void TerminalTripReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    PNum=AppState.UserPnum;
                    NameButton.Enabled=false;
                    NameBox.Text=AppState.UserName;
                }

                LocalCombo.SelectedIndex=0;
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

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i=0; i <= ShowGridView.RowCount - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value=i + 1;
            }
        }
    }
}
