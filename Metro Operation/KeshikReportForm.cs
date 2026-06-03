using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class KeshikReportForm
    {
        private string PName;
        private string PFamily;
        private string PNum;

        public KeshikReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void KeshikReportForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "040302");
        }

        public void KeshikReportForm_Load(object sender, EventArgs e)
        {
            Taghvim PersianDate = new Taghvim(DateTime.Today);
            PersianDate.AddMonth(-1);
            MonthCombo.Items.Add(PersianDate.MonthName());
            PersianDate.AddMonth(1);
            MonthCombo.Items.Add(PersianDate.MonthName());
            PersianDate.AddMonth(1);
            MonthCombo.Items.Add(PersianDate.MonthName());
            MonthCombo.SelectedIndex = 1;

            LocalCombo.Items.Clear();
            if (AppState.UserLevel < 6)
            {
                LocalCombo.Items.Add("همه موارد");
            }

            if (AppState.UserLevel == 9)
            {
                SelfCheck.Top = 17;
                Label4.Visible = false;
                NameBox.Visible = false;
                NameButton.Visible = false;
                PNum = AppState.UserPnum;
            }
            else
            {
                SelfCheck.Visible = false;
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
                LocalCombo.SelectedIndex = 0;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();
                if (MonthCombo.SelectedIndex < 0)
                {
                    ErrorShow(MonthCombo, "ماه گزارش را تعیین کنید");
                    MonthCombo.Focus();
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا گزارش را تعیین کنید");
                    LocalCombo.Focus();
                }
                else
                {
                    Enabled = false;

                    Taghvim PersianDate = new Taghvim(DateTime.Today);
                    PersianDate.AddMonth(-1 + MonthCombo.SelectedIndex);

                    string StrQuer = "SELECT Person.Fname, Person.Family, Person.P_Num, Person.Line_Num, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik, Keshik.U_Reg, Keshik.T_Reg FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.Tarikh Like '" + PersianDate.Tarikh().Substring(0, 8) + "%' AND Keshik.Vis=True";
                    if (SelfCheck.Checked || NameBox.Text != "")
                    {
                        StrQuer += " AND Keshik.P_Num='" + PNum + "'";
                    }                    
                    else
                    {
                        if ((string)LocalCombo.SelectedItem != "همه موارد")
                        {
                            StrQuer += " AND Keshik.L_Keshik='" + LocalCombo.SelectedItem + "'";
                        }

                        if (AppState.UserLevel > 1)
                        {
                            StrQuer += " And Person.Line_Num='" + AppState.UserLnum + "'";
                        }

                        if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                        {
                            StrQuer += " AND Person.P_Staff='" + AppState.UserStaff + "'";
                        }
                    }

                    StrQuer += " ORDER BY Keshik.Tarikh, Keshik.L_Keshik, Keshik.T_Keshik, Person.Family, Person.Fname";

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        DataTable TempTable = new DataTable();
                        OleDbDataAdapter Adap = new OleDbDataAdapter(StrQuer, StrConnec);
                        Adap.Fill(TempTable);

                        int i;
                        for (i = 0; i <= TempTable.Rows.Count - 1; i++)
                        {
                            ShowGridView.Rows.Add(i + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Tarikh"].ToString(), TempTable.Rows[i]["T_Keshik"].ToString(), TempTable.Rows[i]["L_Keshik"].ToString(), TempTable.Rows[i]["U_Reg"].ToString(), TempTable.Rows[i]["T_Reg"].ToString());
                        }
                    }


                    Enabled = true;

                    if (ShowGridView.Rows.Count == 0)
                    {
                        MessageBoxFa.Show("برای این تاریخ داده ای وجود ندارد", "خطا", MessageBoxIcon.Information);
                    }
                    else
                    {
                        ShowGridView.CurrentRow.Selected = false;
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

        public void DetailGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i = 0; i <= ShowGridView.Rows.Count - 1; i++)
            {
                ShowGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
            NameBox.Text = "";
            NameButton.Image = Properties.Resources.user;

            PersonalSelectForm ShowForm = new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily = PersonalSelectForm.PFamily;
                PName = PersonalSelectForm.PName;
                PNum = PersonalSelectForm.PNum;

                NameBox.Text = PName + " " + PFamily;
                NameButton.Image = Properties.Resources.cancel1;
            }
        }
    }
}
