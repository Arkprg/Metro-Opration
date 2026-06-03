using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ImportExcelForm
    {
        public ImportExcelForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            TripGridView.Rows.Clear();

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
                TripGridView.Columns.Clear();


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

                    int i;
                    int j=0;

                    for (i=0; i <= DtSet.Tables[0].Columns.Count - 1; i++)
                    {
                        TripGridView.Columns.Add(i.ToString(), DtSet.Tables[0].Columns[i].ColumnName.Trim());
                    }

                    for (j=0; j <= DtSet.Tables[0].Rows.Count - 1; j++)
                    {
                        TripGridView.Rows.Add();
                        for (i=0; i <= TripGridView.Columns.Count - 1; i++)
                        {
                            TripGridView.Rows[j].Cells[i].Value=DtSet.Tables[0].Rows[j].ItemArray[i].ToString().Trim();
                        }
                    }

                    ExcelConnection.Dispose();
                    DtSet.Dispose();
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
                using (WaitForm wait=new WaitForm())
                {
                    wait.Show();
                    wait.Refresh();
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string Qstr="";
                        int i;

                        for (i=0; i <= TripGridView.RowCount - 1; i++)
                        {
                            Qstr="";

                            if (TripGridView.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                Qstr += "ShenasNum='" + TripGridView.Rows[i].Cells[4].Value.ToString() + "', ";
                            }
                            if (TripGridView.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                Qstr += "FatherName='" + TripGridView.Rows[i].Cells[5].Value.ToString() + "', ";
                            }
                            if (TripGridView.Rows[i].Cells[6].Value.ToString() != "")
                            {
                                Qstr += "BirthLoc='" + TripGridView.Rows[i].Cells[6].Value.ToString() + "', ";
                            }
                            if (TripGridView.Rows[i].Cells[7].Value.ToString() != "")
                            {
                                Qstr += "ShenasLoc='" + TripGridView.Rows[i].Cells[7].Value.ToString() + "', ";
                            }
                            if (TripGridView.Rows[i].Cells[8].Value.ToString() != "")
                            {
                                Qstr += "InsurID ='" + TripGridView.Rows[i].Cells[8].Value.ToString() + "', ";
                            }
                            //  If TripGridView.Rows(i).Cells(9).Value.ToString <> "" Then Qstr += "HomeAddress='" & TripGridView.Rows(i).Cells(9).Value.ToString & "', "
                            if (TripGridView.Rows[i].Cells[10].Value.ToString() != "")
                            {
                                Qstr += "PostCode='" + TripGridView.Rows[i].Cells[10].Value.ToString() + "', ";
                            }
                            //If TripGridView.Rows(i).Cells(10).Value.ToString <> "" Then Qstr += "Phone='" & TripGridView.Rows(i).Cells(10).Value.ToString & "', "
                            if (TripGridView.Rows[i].Cells[12].Value.ToString() != "")
                            {
                                Qstr += "Marage='" + TripGridView.Rows[i].Cells[12].Value.ToString() + "', ";
                            }
                            if (TripGridView.Rows[i].Cells[13].Value.ToString() != "")
                            {
                                Qstr += "Childern=" + TripGridView.Rows[i].Cells[13].Value.ToString() + ", ";
                            }

                            if (Qstr.Length > 3)
                            {
                                Qstr=Qstr.Substring(0, Qstr.Length - 2);
                                using (OleDbCommand CMD=new OleDbCommand("UPDATE Person SET " + Qstr + " WHERE P_Num='" + TripGridView.Rows[i].Cells[3].Value.ToString() + "'", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                            }
                        }
                    }


                    Enabled=true;
                    wait.Close();
                }
                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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
