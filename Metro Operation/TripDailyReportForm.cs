using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripDailyReportForm
    {
        public TripDailyReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private string TripKind(string Kind)
        {
            switch (Kind)
            {
                case "راهبر آموزشی":
                    return "T";
                case "راهبر کمکی":
                    return "S";
                case "راهبر اصلی":
                    return "H";
                default:
                    return string.Empty;
            }
        }

        private string TripLoc(string Loca)
        {
            switch (Loca)
            {
                case "تهران":
                    return "TH";
                case "هشتگرد":
                    return "HG";
                default:
                    return "GL";
            }
        }

        public void TripDailyReportForm_Load(object sender, EventArgs e)
        {
            StartCalendar.Today_Click(null, null);
            EndCalendar.Today_Click(null, null);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);
                ShowGridView.Rows.Clear();

                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع لوحه را مشخص کنید");
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

                    int i=0, j=0;
                    string[] Trip=new string[9];
                    string PNum="";
                    Enabled=false;

                    DataTable TripTable=new DataTable();
                    TripTable.Columns.Add("Tarikh"); //, GetType(String))
                    TripTable.Columns.Add("P_Num");
                    TripTable.Columns.Add("Kind");
                    TripTable.Columns.Add("Time");
                    TripTable.Columns.Add("Mabda");
                    TripTable.Columns.Add("Maghsad");

                    ShowGridView.Rows.Clear();
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string QueStr="SELECT * FROM DailyTrip WHERE Vis=True AND ";
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
                        QueStr += " AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {

                                    if (Reader["O1_Num"].ToString() != "")
                                    {
                                        TripTable.Rows.Add(Reader["Tarikh"].ToString(), Reader["O1_Num"].ToString(), "راهبر اصلی", Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Reader["Maghsad"].ToString());
                                    }

                                    if (Reader["O2_Num"].ToString() != "")
                                    {
                                        TripTable.Rows.Add(Reader["Tarikh"].ToString(), Reader["O2_Num"].ToString(), "راهبر کمکی", Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Reader["Maghsad"].ToString());
                                    }

                                    if (Reader["OT_Num"].ToString() != "")
                                    {
                                        TripTable.Rows.Add(Reader["Tarikh"].ToString(), Reader["OT_Num"].ToString(), "راهبر آموزشی", Reader["T_Time"].ToString(), Reader["Mabdae"].ToString(), Reader["Maghsad"].ToString());
                                    }
                                }
                            }

                        }


                        TripTable.DefaultView.Sort="Tarikh ASC, P_Num ASC, Time ASC";
                        TripTable=TripTable.DefaultView.ToTable();

                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Rezerv WHERE Vis=True AND Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY Tarikh, Loca, R_Shift", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    TripTable.Rows.Add(Reader["Tarikh"].ToString(), Reader["P_Num"].ToString(), "", "Reserv", Reader["Loca"].ToString(), "");
                                }
                            }

                        }

                    }


                    while (i < TripTable.Rows.Count)
                    {
                        Array.Clear(Trip, 0, 7);
                        j=1;
                        PNum=TripTable.Rows[i].ItemArray[1].ToString();
                        Trip[0]=TripTable.Rows[i].ItemArray[0].ToString();
                        do
                        {
                            if (ShowCheck.Checked)
                            {
                                Trip[j]=TripKind(TripTable.Rows[i].ItemArray[2].ToString()) + " ";
                            }
                            Trip[j] += TripTable.Rows[i].ItemArray[3].ToString();
                            if (ShowCheck.Checked && TripTable.Rows[i].ItemArray[3].ToString() != null)
                            {
                                Trip[j] += " " + TripLoc(TripTable.Rows[i].ItemArray[4].ToString()) + " ->" + TripLoc(TripTable.Rows[i].ItemArray[5].ToString());
                            }

                            i++;
                            j++;
                            if (i == TripTable.Rows.Count | j > 6)
                            {
                                break;
                            }
                        } while (PNum == TripTable.Rows[i].ItemArray[1].ToString());
                        ShowGridView.Rows.Add(0, "", "", PNum, Trip[0], Trip[1], Trip[2], Trip[3], Trip[4], Trip[5], Trip[6]);
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
                            DRow=MainForm.PersonTable.Select("P_Num='" + ShowGridView.Rows[i].Cells[3].Value.ToString() + "'");
                            if (DRow.Length > 0)
                            {
                                ShowGridView.Rows[i].Cells[1].Value=DRow[0][0].ToString();
                                ShowGridView.Rows[i].Cells[2].Value=DRow[0][1].ToString();
                            }
                        }
                    }

                    ShowGridView.Sort(ShowGridView.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
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

        public void ShowGridView_Sorted(object sender, EventArgs e)
        {
            int i;
            for (i=0; i <= ShowGridView.Rows.Count - 1; i++)
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
                                if (cell.Value == null)
                                {
                                    cell.Value += "";
                                }
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
    }
}
