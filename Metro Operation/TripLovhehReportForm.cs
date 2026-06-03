using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripLovhehReportForm
    {
        public TripLovhehReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void TripLovhehReportForm_Load(object sender, EventArgs e)
        {
            if (AppState.UserLevel == 0)
            {
                KindCombo.Items.Add("نهایی");
            }

            StartCalendar.FirstDayOfMonth_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            DateTime StartDate;
            DateTime EndDate;

            StartDate = ConvertClass.ShamsiToMiladi(StartCalendar.Text);
            EndDate = ConvertClass.ShamsiToMiladi(EndCalendar.Text);
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

                int i = 0;
                Enabled = false;

                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string QueStr = "SELECT DailyTripReg.Tarikh, DailyTripReg.T_Type, DailyTripReg.U_Reg, DailyTripReg.T_Reg, DailyProcess.L_Num, DailyProcess.U_Reg AS U_Reg1, DailyProcess.T_Reg AS T_Reg1 FROM DailyTripReg INNER JOIN DailyProcess ON DailyTripReg.Tarikh=DailyProcess.Tarikh WHERE DailyTripReg.Vis=True";
                    if (KindCombo.SelectedIndex > 0) QueStr += " AND DailyTripReg.T_Type='لوحه " + KindCombo.SelectedItem + "'";
                    QueStr += " AND DailyTripReg.Tarikh BETWEEN '" + StartCalendar.Text + "' AND '" + EndCalendar.Text + "' ORDER BY DailyTripReg.Tarikh";
                    using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            i++;
                            ShowGridView.Rows.Add(i, Reader["Tarikh"].ToString(), Reader["L_Num"].ToString(), Reader["U_Reg1"].ToString(), Reader["T_Reg1"].ToString(), Reader["T_Type"].ToString(), Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString());
                        }
                    }
                }

                Enabled = true;

                if (ShowGridView.Rows.Count == 0)
                {
                    MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                }
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog()
                {
                    Filter = "Excel Files|*.xlsx|Excel Files 97-2003|*.xls"
                };
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();

                        DataTable Dt = new DataTable();
                        foreach (DataGridViewColumn Column in ShowGridView.Columns)
                        {
                            Dt.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in ShowGridView.Rows)
                        {
                            Dt.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt.Rows[Dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }
                        using (XLWorkbook Wb = new XLWorkbook())
                        {
                            Wb.RightToLeft = true;
                            Wb.Style.Alignment.Horizontal = (XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
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
