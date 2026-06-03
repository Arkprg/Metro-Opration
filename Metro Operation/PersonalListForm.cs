using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PersonalListForm
    {
        public PersonalListForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                PersonGridView.Rows.Clear();
                PersonGridView2.Rows.Clear();
                PersonGridView3.Rows.Clear();

                if (UnitCombo.SelectedIndex < 0)
                {
                    ErrorShow(UnitCombo, "واحد خدمتی را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "محل شروع به کار را مشخص کنید");
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
                else
                {
                    int i = 1;
                    Enabled = false;

                    string CommandStr = "Vis=True ";
                    if (AppState.UserLevel > 1)
                    {
                        CommandStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if ((string)UnitCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND P_Staff='" + UnitCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND P_Post='" + PostCombo.Text + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND Shift_loc='" + LocalCombo.Text + "'";
                    }

                    if ((string)ShiftCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND Shift_Name='" + ShiftCombo.Text + "'";
                    }

                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND Shift_Time='" + TimeCombo.Text + "'";
                    }

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand("SELECT * FROM Person WHERE " + CommandStr + " ORDER BY Family", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PersonGridView.Rows.Add(i, Reader["FName"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["P_Staff"].ToString(), Reader["P_Post"].ToString(), Reader["Shift_loc"].ToString(), Reader["Shift_Time"].ToString(), Reader["Shift_Name"].ToString(), Reader["O_Group"].ToString(), Reader["LicenseDegree"].ToString());

                                if (AppState.UserLevel < 6)
                                {
                                    int BrthDays = ConvertClass.DateToDays(MainForm.PersianToday.Tarikh()) - ConvertClass.DateToDays(Reader["Birthday"].ToString());
                                    int EmpDays = ConvertClass.DateToDays(MainForm.PersianToday.Tarikh()) - ConvertClass.DateToDays(Reader["EmpoDate"].ToString());

                                    PersonGridView2.Rows.Add(i, Reader["FName"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["NatID"].ToString(), Reader["ShenasNum"].ToString(), Reader["FatherName"].ToString(), Reader["Birthday"].ToString(), ConvertClass.DaysToDate(BrthDays), BrthDays, Reader["BirthLoc"].ToString(), Reader["ShenasLoc"].ToString(), Reader["EmpoDate"].ToString(), ConvertClass.DaysToDate(EmpDays), EmpDays, Reader["InsurID"].ToString(), Reader["PostCode"].ToString(), Reader["Phone"].ToString(), Reader["CityAddress"].ToString() + " ، " + Reader["TownAddress"].ToString() + " ، " + Reader["HomeAddress"].ToString(), Reader["Marage"].ToString(), Reader["Childern"].ToString());

                                    PersonGridView3.Rows.Add(i, Reader["FName"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["ShoeSize"].ToString(), Reader["ShirtSize"].ToString(), Reader["CoatSize"].ToString(), Reader["PantSize"].ToString(), Reader["H_ShSize"].ToString(), Reader["OverSize"].ToString(), Reader["CollegDegree"].ToString(), Reader["CollegObject"].ToString());
                                }
                                i++;
                            }
                        }
                    }


                    Enabled = true;
                    if (PersonGridView.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        PersonGridView.CurrentRow.Selected = false;
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

        public void PersonnelListForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0503");
        }

        public void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    ExportButton.Visible = false;
                }

                if (AppState.UserLevel < 5)
                {
                    UnitCombo.Items.Clear();
                    UnitCombo.Items.Add("همه موارد");

                    string QueStr = "Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }
                    //     If LocalCombo.SelectedItem <> "همه موارد" Then QueStr += " AND Shift_Loc='" & LocalCombo.SelectedItem.ToString & "'"

                    DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "P_Staff");
                    foreach (DataRow DtR in DRow)
                    {
                        if (UnitCombo.Items.IndexOf(DtR["P_Staff"].ToString()) < 0)
                        {
                            UnitCombo.Items.Add(DtR["P_Staff"].ToString());
                        }
                    }
                    UnitCombo.SelectedIndex = 0;
                }
                else
                {
                    UnitCombo.Items.Add(AppState.UserStaff);
                    UnitCombo.SelectedIndex = 0;
                    UnitCombo.Enabled = false;

                    if (AppState.UserLevel != 12)
                    {
                        TabControl1.TabPages.RemoveAt(1);
                        TabControl1.TabPages.RemoveAt(1);
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

        public void PersonGridView3_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i = 0; i <= PersonGridView.RowCount - 1; i++)
            {
                PersonGridView.Rows[i].Cells[0].Value = i + 1;
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
                        DataTable Dt2 = new DataTable();
                        DataTable Dt3 = new DataTable();
                        foreach (DataGridViewColumn Column in PersonGridView.Columns)
                        {
                            Dt.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in PersonGridView.Rows)
                        {
                            Dt.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt.Rows[Dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }

                        foreach (DataGridViewColumn Column in PersonGridView2.Columns)
                        {
                            Dt2.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in PersonGridView2.Rows)
                        {
                            Dt2.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt2.Rows[Dt2.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }

                        foreach (DataGridViewColumn Column in PersonGridView3.Columns)
                        {
                            Dt3.Columns.Add(Column.HeaderText);
                        }
                        foreach (DataGridViewRow Row in PersonGridView3.Rows)
                        {
                            Dt3.Rows.Add();
                            foreach (DataGridViewCell cell in Row.Cells)
                            {
                                Dt3.Rows[Dt3.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }

                        using (XLWorkbook Wb = new XLWorkbook())
                        {
                            Wb.RightToLeft = true;
                            Wb.Style.Alignment.Horizontal = (XLAlignmentHorizontalValues)XLDrawingHorizontalAlignment.Center;
                            Wb.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            Wb.AddWorksheet(Dt, "Sheet1").AsRange();
                            Wb.AddWorksheet(Dt2, "Sheet2").AsRange();
                            Wb.AddWorksheet(Dt3, "Sheet3").AsRange();
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

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PostCombo.SelectedIndex = -1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    PostCombo.Items.Clear();
                    PostCombo.Items.Add("همه موارد");

                    string QueStr = "Vis=True";
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

                    DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "P_Post");
                    foreach (DataRow DtR in DRow)
                    {
                        if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                        {
                            PostCombo.Items.Add(DtR["P_Post"].ToString());
                        }
                    }
                    PostCombo.SelectedIndex = 0;
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
                TimeCombo.SelectedIndex = -1;
                if (PostCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr = "Vis=True";
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

                    DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "Shift_Time");
                    foreach (DataRow DtR in DRow)
                    {
                        if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                        {
                            TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                        }
                    }
                    TimeCombo.SelectedIndex = 0;
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
            ShiftCombo.SelectedIndex = -1;
            if (TimeCombo.SelectedIndex >= 0)
            {
                ShiftCombo.Items.Clear();
                ShiftCombo.Items.Add("همه موارد");

                string QueStr = "Vis=True";
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

                DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "Shift_name");
                foreach (DataRow DtR in DRow)
                {
                    if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                    {
                        ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                    }
                }
                ShiftCombo.SelectedIndex = 0;
            }
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonGridView.Rows.Clear();
            PersonGridView2.Rows.Clear();
            PersonGridView3.Rows.Clear();
        }

        public void UnitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.SelectedIndex = -1;
                LocalCombo.Items.Clear();

                if (AppState.UserLevel < 6)
                {
                    LocalCombo.Items.Add("همه موارد");
                    if (UnitCombo.SelectedIndex >= 0)
                    {
                        string QueStr = "Vis=True";
                        if (AppState.UserLevel > 1)
                        {
                            QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                        }
                        if ((string)UnitCombo.SelectedItem != "همه موارد")
                        {
                            QueStr += " AND P_Staff='" + UnitCombo.SelectedItem + "'";
                        }

                        DataRow[] DRow = MainForm.PersonTable.Select(QueStr, "Shift_Loc");
                        foreach (DataRow DtR in DRow)
                        {
                            if (LocalCombo.Items.IndexOf(DtR["Shift_Loc"].ToString()) < 0)
                            {
                                LocalCombo.Items.Add(DtR["Shift_Loc"].ToString());
                            }
                        }
                    }

                }
                else
                {
                    foreach (string Local in MainForm.Locals)
                    {
                        if (!string.IsNullOrEmpty(Local))
                        {
                            LocalCombo.Items.Add(Local);
                        }
                    }
                }

                if (LocalCombo.Items.Count > 0)
                {
                    LocalCombo.SelectedIndex = 0;
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
