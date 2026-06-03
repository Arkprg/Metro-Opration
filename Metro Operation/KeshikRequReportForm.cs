using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class KeshikRequReportForm
    {
        public KeshikRequReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void KeshikRequReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0408");
        }

        public void KeshikRequReportForm_Load(object sender, EventArgs e)
        {
            LocalCombo.Items.Clear();
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
                LocalCombo.Items.Add(AppState.UserLocal);
                LocalCombo.SelectedItem=AppState.UserLocal;
                LocalCombo.Enabled=false;
                TimeCombo.SelectedItem=AppState.UserTime;
                TimeCombo.Enabled=false;
                ShiftCombo.SelectedItem=AppState.UserShift;
                ShiftCombo.Enabled=false;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                Taghvim PersianDate=new Taghvim();

                ShowGridView.Rows.Clear();
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا حرکت را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "نام شیفت را مشخص کنید");
                }
                else
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        DataTable TempTable=new DataTable();

                        string StrQuer="SELECT Person.Fname, Person.Family, Person.P_Num, Person.Line_Num, Person.Shift_Loc, Person.Shift_name, Person.Trip, Person.OverTime, KeshikRequ.Num, KeshikRequ.U_Reg, KeshikRequ.T_Reg FROM Person INNER JOIN KeshikRequ ON Person.P_Num=KeshikRequ.P_Num WHERE KeshikRequ.Vis=True AND Person.Vis=True AND Person.P_Post LIKE 'راهبر%'";
                        if (AppState.UserLevel > 1)
                        {
                            StrQuer += " And Person.Line_Num='" + AppState.UserLnum + "'";
                        }

                        if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                        {
                            StrQuer += " AND Person.P_Staff='" + AppState.UserStaff + "'";
                        }

                        if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                        {
                            StrQuer += " And Person.P_Num='" + AppState.UserPnum + "'";
                        }

                        if ((string)LocalCombo.SelectedItem != "همه موارد")
                        {
                            StrQuer += " And Person.Shift_Loc='" + LocalCombo.SelectedItem + "'";
                        }

                        if ((string)TimeCombo.SelectedItem != "همه موارد")
                        {
                            StrQuer += " And Person.Shift_Time='" + TimeCombo.SelectedItem + "'";
                        }

                        if ((string)ShiftCombo.SelectedItem != "همه موارد")
                        {
                            StrQuer += " And Person.Shift_name='" + ShiftCombo.SelectedItem + "'";
                        }

                        StrQuer += " ORDER BY Person.Family, Person.Fname";

                        using (OleDbDataAdapter Adap=new OleDbDataAdapter(StrQuer, StrConnec))
                        {
                            Adap.Fill(TempTable);
                        }

                        int i;
                        for (i=0; i <= TempTable.Rows.Count - 1; i++)
                        {
                            ShowGridView.Rows.Add(i + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"], TempTable.Rows[i]["Shift_Loc"], TempTable.Rows[i]["Shift_name"], TempTable.Rows[i]["Num"].ToString(), TempTable.Rows[i]["OverTime"].ToString(), TempTable.Rows[i]["Trip"].ToString(), TempTable.Rows[i]["U_Reg"], TempTable.Rows[i]["T_Reg"]);
                            if (ShowGridView.Rows[i].Cells[6].Value.ToString() == "5")
                            {
                                ShowGridView.Rows[i].Cells[6].Value="حداکثر";
                            }
                        }
                        TempTable.Dispose();

                        Enabled=true;
                    }


                    if (ShowGridView.RowCount == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ShowGridView.CurrentRow.Selected=false;
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

        public void ShowGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
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

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
            ShiftCombo.Items.Clear();
            if (TimeCombo.SelectedIndex >= 0)
            {
                ShiftCombo.Items.Add("همه موارد");

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
    }
}
