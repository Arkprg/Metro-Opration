using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripCompileForm
    {
        public TripCompileForm()
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

            bool Process=false;
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT TOP 1 Tarikh FROM DailyTrip WHERE Tarikh='" + TripDay + "' AND Vis=True", StrConnec))
                {
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Process=true;
                        }
                    }

                }

            }


            return Process;
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            TripGridView.Rows.Clear();
            DateLabel.Text="";

            OpenFileDialog OpenFileDialog1=new OpenFileDialog()
            {
                Filter="Excel Worksheets|*.xls;*.xlsx"
            };

            DialogResult Resul=OpenFileDialog1.ShowDialog(this);
            if (Resul == DialogResult.OK)
            {
                NameBox.Text=OpenFileDialog1.FileName;
            }
        }

        public void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                TripGridView.Rows.Clear();
                DateLabel.Text="";

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "فایل مورد نظر را انتخاب کنید");
                }
                else
                {
                    Enabled=false;


                    OleDbConnection ExcelConnection=new OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0; Data Source='" + NameBox.Text + "'; Extended Properties=Excel 12.0;");
                    OleDbDataAdapter MyCommand=new OleDbDataAdapter("SELECT * FROM [Sheet1$]", ExcelConnection);

                    DataSet DtSet=new DataSet();
                    ExcelConnection.Open();
                    MyCommand.TableMappings.Add("Table", "Test");
                    MyCommand.Fill(DtSet);
                    ExcelConnection.Close();

                    DtSet.Tables[0].Columns[3].ColumnName="PNum";
                    DtSet.Tables[0].Columns[4].ColumnName="Tarikh";
                    DtSet.Tables[0].Columns[5].ColumnName="T_Time";
                    DtSet.Tables[0].Columns[6].ColumnName="Mabdae";
                    DtSet.Tables[0].Columns[7].ColumnName="Maghsad";
                    DtSet.Tables[0].Columns[8].ColumnName="T_Status";

                    int i=1;
                    DataRow[] DRow=DtSet.Tables[0].DefaultView.ToTable(true, "T_Time", "Tarikh", "Mabdae", "Maghsad").Select("", "Tarikh, T_Time, Mabdae");
                    foreach (DataRow DtR in DRow)
                    {
                        TripGridView.Rows.Add(i, DtR["Tarikh"].ToString(), DtR["T_Time"].ToString(), DtR["Mabdae"].ToString(), DtR["Maghsad"].ToString(), "", "", "", "", "", "");
                        i++;
                    }

                    for (i=0; i <= TripGridView.Rows.Count - 1; i++)
                    {
                        DRow=DtSet.Tables[0].Select("T_Time='" + TripGridView.Rows[i].Cells[2].Value + "' AND Tarikh='" + TripGridView.Rows[i].Cells[1].Value + "' AND Mabdae='" + TripGridView.Rows[i].Cells[3].Value + "'");
                        foreach (DataRow DtR in DRow)
                        {
                            if ((string)DtR["T_Status"] == "راهبر اصلی")
                            {
                                TripGridView.Rows[i].Cells[6].Value=DtR["PNum"];
                                DRow=MainForm.PersonTable.Select("P_Num='" + TripGridView.Rows[i].Cells[6].Value.ToString() + "'");
                                TripGridView.Rows[i].Cells[5].Value=DRow[0][0] + " " + DRow[0][1];

                            }
                            else if ((string)DtR["T_Status"] == "راهبر کمکی")
                            {
                                TripGridView.Rows[i].Cells[8].Value=DtR["PNum"];
                                DRow=MainForm.PersonTable.Select("P_Num='" + TripGridView.Rows[i].Cells[8].Value.ToString() + "'");
                                TripGridView.Rows[i].Cells[7].Value=DRow[0][0] + " " + DRow[0][1];

                            }
                            else if ((string)DtR["T_Status"] == "راهبر آموزشی")
                            {
                                TripGridView.Rows[i].Cells[10].Value=DtR["PNum"];
                                DRow=MainForm.PersonTable.Select("P_Num='" + TripGridView.Rows[i].Cells[10].Value.ToString() + "'");
                                TripGridView.Rows[i].Cells[9].Value=DRow[0][0] + " " + DRow[0][1];
                            }
                        }
                    }

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

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TripGridView.Rows.Count == 0)
                {
                    ErrorShow(TripGridView, "هیچ لوحه ای تحلیل نشده است");
                }
                else
                {
                    TripGridView.Sort(TripGridView.Columns[0], ListSortDirection.Ascending);

                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            int i;
                            for (i=0; i <= TripGridView.RowCount - 1; i++)
                            {

                                using (OleDbCommand CMD=new OleDbCommand("INSERT INTO DailyTripExecu (Tarikh, T_Time, Mabdae, Maghsad, O1_NUM, O2_NUM, OT_NUM, U_Reg, T_Reg, Vis) VALUES ('" + TripGridView.Rows[i].Cells[1].Value.ToString() + "','" + TripGridView.Rows[i].Cells[2].Value.ToString() + "', '" + TripGridView.Rows[i].Cells[3].Value.ToString() + "', '" + TripGridView.Rows[i].Cells[4].Value.ToString() + "', '" + TripGridView.Rows[i].Cells[6].Value.ToString() + "', '" + TripGridView.Rows[i].Cells[8].Value.ToString() + "', '" + TripGridView.Rows[i].Cells[10].Value.ToString() + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                                {
                                    //     CMD.ExecuteNonQuery()
                                }

                            }
                        }


                        NameBox.Text="";
                        DateLabel.Text="";
                        TripGridView.Rows.Clear();

                        Enabled=true;
                        wait.Close();
                    }
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Enabled=true;
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
