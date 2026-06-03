using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class NavganReportForm
    {
        public NavganReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clean()
        {
            Loco1Label.Text="";
            Wag1Label.Text="";
            Wag2Label.Text="";
            Wag3Label.Text="";
            Wag4Label.Text="";
            Wag5Label.Text="";
            Wag6Label.Text="";
            Wag7Label.Text="";
            Wag8Label.Text="";
            Wag9Label.Text="";
            Loco2Label.Text="";
            UserLabel.Text="";
            DateLabel.Text="";

            if (ShowGridView.Rows.Count > 0)
            {
                ShowGridView.CurrentRow.Selected=false;
            }
        }
        public void NavganReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                string StrQuer="SELECT * FROM Navgan WHERE Vis=True ORDER BY Loco1";

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    DataTable TempTable=new DataTable();
                    using (OleDbDataAdapter Adap=new OleDbDataAdapter(StrQuer, StrConnec))
                    {
                        Adap.Fill(TempTable);
                    }


                    int i;
                    for (i=0; i <= TempTable.Rows.Count - 1; i++)
                    {
                        ShowGridView.Rows.Add(i + 1, TempTable.Rows[i]["Loco1"].ToString(), TempTable.Rows[i]["Wag1"].ToString(), TempTable.Rows[i]["Wag2"].ToString(), TempTable.Rows[i]["Wag3"].ToString(), TempTable.Rows[i]["Wag4"].ToString(), TempTable.Rows[i]["Wag5"].ToString(), TempTable.Rows[i]["Wag6"].ToString(), TempTable.Rows[i]["Wag7"].ToString(), TempTable.Rows[i]["Wag8"].ToString(), TempTable.Rows[i]["Wag9"].ToString(), TempTable.Rows[i]["Loco2"].ToString(), TempTable.Rows[i]["U_Reg"].ToString(), TempTable.Rows[i]["T_Reg"].ToString());
                    }
                }


                if (ShowGridView.Rows.Count > 0)
                {
                    ShowGridView.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NumBox.Text.Length == 0)
                {
                    ErrorShow(NumBox, "شماره " + KindCombo.SelectedItem + " را مشخص کنید");
                }
                else
                {
                    int RowNum=-1;
                    Clean();

                    int i;
                    if ((string)KindCombo.SelectedItem == "لکوموتیو")
                    {
                        for (i=0; i <= ShowGridView.Rows.Count - 1; i++)
                        {
                            if (NumBox.Text == ShowGridView.Rows[i].Cells[1].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[11].Value.ToString())
                            {
                                RowNum=i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (i=0; i <= ShowGridView.Rows.Count - 1; i++)
                        {
                            if (NumBox.Text == ShowGridView.Rows[i].Cells[2].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[3].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[4].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[5].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[6].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[7].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[8].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[9].Value.ToString() || NumBox.Text == ShowGridView.Rows[i].Cells[10].Value.ToString())
                            {
                                RowNum=i;
                                break;
                            }
                        }
                    }

                    if (RowNum >= 0)
                    {
                        Loco1Label.Text=ShowGridView.Rows[RowNum].Cells[1].Value.ToString();
                        Loco2Label.Text=ShowGridView.Rows[RowNum].Cells[11].Value.ToString();

                        Wag1Label.Text=ShowGridView.Rows[RowNum].Cells[2].Value.ToString();
                        Wag2Label.Text=ShowGridView.Rows[RowNum].Cells[3].Value.ToString();
                        Wag3Label.Text=ShowGridView.Rows[RowNum].Cells[4].Value.ToString();
                        Wag4Label.Text=ShowGridView.Rows[RowNum].Cells[5].Value.ToString();
                        Wag5Label.Text=ShowGridView.Rows[RowNum].Cells[6].Value.ToString();
                        Wag6Label.Text=ShowGridView.Rows[RowNum].Cells[7].Value.ToString();
                        Wag7Label.Text=ShowGridView.Rows[RowNum].Cells[8].Value.ToString();
                        Wag8Label.Text=ShowGridView.Rows[RowNum].Cells[9].Value.ToString();
                        Wag9Label.Text=ShowGridView.Rows[RowNum].Cells[10].Value.ToString();

                        UserLabel.Text=ShowGridView.Rows[RowNum].Cells[12].Value.ToString();
                        DateLabel.Text=ShowGridView.Rows[RowNum].Cells[13].Value.ToString();
                    }
                    else
                    {
                        MessageBoxFa.Show(KindCombo.SelectedItem + " مورد نظر پیدا نشده است !", "توجه", MessageBoxIcon.Warning);
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

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean();
            NumBox.Text="";
            if (KindCombo.SelectedIndex == 0)
            {
                NumBox.Mask=">A0";
            }
            else
            {
                NumBox.Mask=">A00";
            }
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KindCombo.SelectedIndex=-1;
            Loco1Label.Text=ShowGridView.CurrentRow.Cells[1].Value.ToString();
            Loco2Label.Text=ShowGridView.CurrentRow.Cells[11].Value.ToString();

            Wag1Label.Text=ShowGridView.CurrentRow.Cells[2].Value.ToString();
            Wag2Label.Text=ShowGridView.CurrentRow.Cells[3].Value.ToString();
            Wag3Label.Text=ShowGridView.CurrentRow.Cells[4].Value.ToString();
            Wag4Label.Text=ShowGridView.CurrentRow.Cells[5].Value.ToString();
            Wag5Label.Text=ShowGridView.CurrentRow.Cells[6].Value.ToString();
            Wag6Label.Text=ShowGridView.CurrentRow.Cells[7].Value.ToString();
            Wag7Label.Text=ShowGridView.CurrentRow.Cells[8].Value.ToString();
            Wag8Label.Text=ShowGridView.CurrentRow.Cells[9].Value.ToString();
            Wag9Label.Text=ShowGridView.CurrentRow.Cells[10].Value.ToString();

            UserLabel.Text=ShowGridView.CurrentRow.Cells[12].Value.ToString();
            DateLabel.Text=ShowGridView.CurrentRow.Cells[13].Value.ToString();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if (Loco1Label.Text == "" && Loco2Label.Text == "")
            {
                ErrorShow(NumBox, "شماره " + KindCombo.SelectedItem + " را مشخص کنید");
            }
            else
            {
                NavganReportForm ShowForm=new NavganReportForm();
                ShowForm.KindCombo.SelectedIndex=0;
                if (Loco1Label.Text != "")
                {
                    ShowForm.NumBox.Text=Loco1Label.Text;
                }
                if (Loco2Label.Text != "")
                {
                    ShowForm.NumBox.Text=Loco2Label.Text;
                }
                Close();

                ShowForm.ShowDialog();
            }
        }
    }
}
