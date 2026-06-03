using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripImportExecutForm
    {
        public TripImportExecutForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public bool ImportChecker(string TripDay)
        {
            bool Process = false;
            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();

                using (OleDbCommand CMD = new OleDbCommand($"SELECT Tarikh FROM DailyTripReg WHERE Tarikh={TripDay} AND T_Type='لوحه اجرا شده' AND Vis=True", StrConnec))
                {
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Process = true;
                        }
                    }
                }
            }

            return Process;
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            TripGridView.Rows.Clear();
            DateLabel.Text = "";

            OpenFileDialog OpenFileDialog1 = new OpenFileDialog()
            {
                Filter = "Excel Worksheets|*.xls;*.xlsx"
            };

            DialogResult Resul = OpenFileDialog1.ShowDialog(this);
            if (Resul == DialogResult.OK)
            {
                NameBox.Text = OpenFileDialog1.FileName;
            }
        }

        public void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                TripGridView.Rows.Clear();
                DateLabel.Text = "";

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "فایل مورد نظر را انتخاب کنید");
                }
                else
                {
                    Enabled = false;

                    OleDbConnection ExcelConnection = new OleDbConnection($"provider=Microsoft.Ace.OLEDB.12.0; Data Source={NameBox.Text}; Extended Properties=Excel 12.0;");
                    OleDbDataAdapter MyCommand = new OleDbDataAdapter($"SELECT * FROM [Sheet1$]", ExcelConnection);

                    DataSet DtSet = new DataSet();
                    ExcelConnection.Open();
                    MyCommand.TableMappings.Add($"Table", "Test");
                    MyCommand.Fill(DtSet);
                    ExcelConnection.Close();

                    DateLabel.Text = DtSet.Tables[0].Rows[4][26].ToString();
                    DateLabel.Visible = true;
                    DtSet.Tables[0].Columns[0].ColumnName = "T_Status";
                    DtSet.Tables[0].Columns[6].ColumnName = "PNum";
                    DtSet.Tables[0].Columns[10].ColumnName = "نام";
                    DtSet.Tables[0].Columns[14].ColumnName = "خانوادگی";
                    DtSet.Tables[0].Columns[16].ColumnName = "Maghsad";
                    DtSet.Tables[0].Columns[18].ColumnName = "Mabdae";
                    DtSet.Tables[0].Columns[23].ColumnName = "T_Time";
                    DtSet.Tables[0].Columns[26].ColumnName = "Tarikh";

                    int i = 0;
                    while (DtSet.Tables[0].Rows.Count > i)
                    {
                        if (int.TryParse(DtSet.Tables[0].Rows[i][6].ToString(), out _))
                        {
                            if (AppState.UserLnum == "5")
                            {
                                if (DtSet.Tables[0].Rows[i][18].ToString() == "تهران - صادقيه")
                                {
                                    DtSet.Tables[0].Rows[i][18] = "تهران";
                                }
                                if (DtSet.Tables[0].Rows[i][16].ToString() == "تهران - صادقيه")
                                {
                                    DtSet.Tables[0].Rows[i][16] = "تهران";
                                }
                            }
                            else
                            {
                                if (DtSet.Tables[0].Rows[i][18].ToString() == "تهران - صادقيه")
                                {
                                    DtSet.Tables[0].Rows[i][18] = "صادقیه";
                                }
                                if (DtSet.Tables[0].Rows[i][16].ToString() == "تهران - صادقيه")
                                {
                                    DtSet.Tables[0].Rows[i][16] = "صادقیه";
                                }
                            }
                            if (DtSet.Tables[0].Rows[i][26].ToString() != DateLabel.Text && AppState.UserLevel > 0)
                            {
                                Enabled = true;
                                MessageBoxFa.Show($"تاریخ فایل صحیح نیست", "خطا", MessageBoxIcon.Error);
                                TripGridView.Rows.Clear();
                                return;
                            }
                            i++;
                        }
                        else
                        {
                            DtSet.Tables[0].Rows.RemoveAt(i);
                        }
                    }

                    i = 1;
                    TripGridView.Rows.Clear();
                    DataRow[] DRow = DtSet.Tables[0].DefaultView.ToTable(true, "T_Time", "Tarikh", "Mabdae", "Maghsad").Select($"", "Tarikh, T_Time, Mabdae");
                    foreach (DataRow DtR in DRow)
                    {
                        TripGridView.Rows.Add(i, DtR["Tarikh"].ToString(), DtR["T_Time"].ToString(), DtR["Mabdae"].ToString(), DtR["Maghsad"].ToString(), "", "", "", "", "", "");
                        i++;
                    }

                    for (i = 0; i <= TripGridView.Rows.Count - 1; i++)
                    {
                        DRow = DtSet.Tables[0].Select($"T_Time={TripGridView.Rows[i].Cells[2].Value} AND Tarikh={TripGridView.Rows[i].Cells[1].Value} AND Mabdae={TripGridView.Rows[i].Cells[3].Value}");
                        foreach (DataRow DtR in DRow)
                        {
                            if ((string)DtR["T_Status"] == "راهبر" && TripGridView.Rows[i].Cells[6].Value.ToString() == "")
                            {
                                TripGridView.Rows[i].Cells[6].Value = DtR["PNum"];
                                DRow = MainForm.PersonTable.Select($"P_Num={TripGridView.Rows[i].Cells[6].Value}");
                                if (DRow.Length > 0)
                                {
                                    TripGridView.Rows[i].Cells[5].Value = DRow[0][0] + " " + DRow[0][1];
                                }

                            }
                            else if ((string)DtR["T_Status"] == "كمك راهبر")
                            {
                                TripGridView.Rows[i].Cells[10].Value = DtR["PNum"];
                                DRow = MainForm.PersonTable.Select($"P_Num={TripGridView.Rows[i].Cells[10].Value}");
                                if (DRow.Length > 0)
                                {
                                    TripGridView.Rows[i].Cells[9].Value = DRow[0][0] + " " + DRow[0][1];
                                }

                            }
                            else if ((string)DtR["T_Status"] == "راهبر آموزشي" || DtR["PNum"].ToString() != "")
                            {
                                TripGridView.Rows[i].Cells[8].Value = DtR["PNum"];
                                DRow = MainForm.PersonTable.Select($"P_Num={TripGridView.Rows[i].Cells[8].Value}");
                                if (DRow.Length > 0)
                                {
                                    TripGridView.Rows[i].Cells[7].Value = DRow[0][0] + " " + DRow[0][1];
                                }
                            }
                        }
                    }
                    ExcelConnection.Dispose();
                    DtSet.Dispose();
                    Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                Taghvim PersianDate = new Taghvim(DateLabel.Text);
                if (TripGridView.Rows.Count == 0)
                {
                    ErrorShow(TripGridView, "هیچ لوحه ای تحلیل نشده است");
                }
                else if (ImportChecker(DateLabel.Text) && AppState.UserLevel > 0 && !((string)TripGridView.Rows[0].Cells[3].Value == "هشتگرد" || (string)TripGridView.Rows[0].Cells[4].Value == "هشتگرد"))
                {
                    ErrorShow(DateLabel, $"لوحه اجرا شده {DateLabel.Text} ثبت شده است");
                }
                else
                {
                    PersianDate.AddDay(-1);
                    if (!ImportChecker(PersianDate.Tarikh()))
                    {
                        MessageBoxFa.Show($"لوحه {PersianDate.Tarikh()} ثبت نشده است", "خطا", MessageBoxIcon.Error);
                        return;
                    }

                    TripGridView.Sort(TripGridView.Columns[0], ListSortDirection.Ascending);
                    DataTable TripTable = new DataTable();

                    using (WaitForm wait = new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled = false;


                        using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            OleDbDataAdapter Adap = new OleDbDataAdapter($"SELECT * FROM DailyTrip WHERE Vis=True AND Tarikh LIKE {TripGridView.Rows[0].Cells[1].Value.ToString().Substring(0, 7)}%'", StrConnec);
                            Adap.Fill(TripTable);
                            Adap.Dispose();

                            int i;
                            for (i = 0; i <= TripGridView.RowCount - 1; i++)
                            {
                                DataRow[] DRow = TripTable.Select($"Tarikh={TripGridView.Rows[i].Cells[1].Value} AND T_Time={TripGridView.Rows[i].Cells[2].Value} AND Mabdae={TripGridView.Rows[i].Cells[3].Value} AND Maghsad={TripGridView.Rows[i].Cells[4].Value}", "Execu DESC");

                                if (DRow.Length > 0)
                                {
                                    if (DRow[0][5].ToString() == TripGridView.Rows[i].Cells[6].Value.ToString() && DRow[0][6].ToString() == TripGridView.Rows[i].Cells[10].Value.ToString() && DRow[0][7].ToString() == TripGridView.Rows[i].Cells[8].Value.ToString())
                                    {
                                        using (OleDbCommand CMD = new OleDbCommand($"UPDATE DailyTrip SET Execu=True WHERE ID={DRow[0][0]}", StrConnec))
                                        {
                                            CMD.ExecuteNonQuery();
                                        }
                                    }
                                    else if (DRow[0][5].ToString() == TripGridView.Rows[i].Cells[6].Value.ToString() && DRow[0][6].ToString() == TripGridView.Rows[i].Cells[10].Value.ToString())
                                    {

                                        using (OleDbCommand CMD = new OleDbCommand($"UPDATE DailyTrip SET Execu=True, OT_NUM={TripGridView.Rows[i].Cells[8].Value}, OT_Time='' WHERE ID={DRow[0][0]}", StrConnec))
                                        {
                                            CMD.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        if ((bool)DRow[0][9])
                                        {
                                            using (OleDbCommand CMD = new OleDbCommand($"UPDATE DailyTrip SET Vis=False WHERE ID={DRow[0][0]}", StrConnec))
                                            {
                                                CMD.ExecuteNonQuery();
                                            }
                                        }

                                        using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyTrip (Tarikh, T_Time, Mabdae, Maghsad, O1_NUM, O2_NUM, OT_NUM, Execu, Vis) VALUES ({TripGridView.Rows[i].Cells[1].Value},{TripGridView.Rows[i].Cells[2].Value}, {TripGridView.Rows[i].Cells[3].Value}, {TripGridView.Rows[i].Cells[4].Value}, {TripGridView.Rows[i].Cells[6].Value}, {TripGridView.Rows[i].Cells[10].Value}, {TripGridView.Rows[i].Cells[8].Value}, True, True)", StrConnec))
                                        {
                                            CMD.ExecuteNonQuery();
                                        }
                                    }
                                }
                                else
                                {
                                    using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyTrip (Tarikh, T_Time, Mabdae, Maghsad, O1_NUM, O2_NUM, OT_NUM, Execu, Vis) VALUES ({TripGridView.Rows[i].Cells[1].Value},{TripGridView.Rows[i].Cells[2].Value}, {TripGridView.Rows[i].Cells[3].Value}, {TripGridView.Rows[i].Cells[4].Value}, {TripGridView.Rows[i].Cells[6].Value}, {TripGridView.Rows[i].Cells[10].Value}, {TripGridView.Rows[i].Cells[8].Value}, True, True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }

                            using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyTripReg (Tarikh, T_Type, U_Reg, T_Reg, Vis) VALUES ({DateLabel.Text},'لوحه اجرا شده', {AppState.UserName}, {MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}, True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        NameBox.Text = "";
                        DateLabel.Text = "";
                        TripGridView.Rows.Clear();

                        Enabled = true;
                        wait.Close();
                    }
                    MessageBoxFa.Show($"ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Enabled = true;
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show($"لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
