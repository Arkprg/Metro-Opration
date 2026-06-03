using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class MyDailyOperationForm
    {
        public MyDailyOperationForm()
        {
            InitializeComponent();
        }


        private string PName;
        private string PFamily;
        //private string PNum;
        //private string PLocal;
        //private string PPost;
        //private string PTime;
        //private string PShift;


        public void StartCalendar_TextChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();
                Enabled=false;
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    DataTable TempTable=new DataTable();
                    int i;

                    // *********** اضافه کار
                    TempTable.Clear();

                    using (OleDbDataAdapter Adap=new OleDbDataAdapter("Select Person.Fname, Person.Family, Person.P_Num, Ezafeh.Tarikh, Ezafeh.E_Time, Ezafeh.E_Kind, Ezafeh.E_Mem From Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Ezafeh.Vis=True AND Ezafeh.U_Reg='" + NameBox.Text + "' AND Ezafeh.T_Reg LIKE '" + StartCalendar.Text + "%' ORDER BY Ezafeh.Tarikh DESC, Person.Family, Person.Fname", StrConnec))
                    {
                        Adap.Fill(TempTable);
                    }

                    ShowGridView.RowTemplate.DefaultCellStyle.BackColor=Color.Pink;
                    for (i=0; i <= TempTable.Rows.Count - 1; i++)
                    {
                        ShowGridView.Rows.Add(ShowGridView.Rows.Count + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Tarikh"].ToString(), TempTable.Rows[i]["E_Time"].ToString() + " ساعت : " + TempTable.Rows[i]["E_Kind"].ToString() + " (" + TempTable.Rows[i]["E_Mem"].ToString() + ")");
                    }

                    // *********** مرخصی روزانه
                    TempTable.Clear();
                    using (OleDbDataAdapter Adap=new OleDbDataAdapter("Select Person.Fname, Person.Family, Person.P_Num, Morakhasi.Tarikh, Morakhasi.Kind From Morakhasi INNER JOIN Person ON Person.P_Num=Morakhasi.P_Num WHERE Morakhasi.Vis=True AND Morakhasi.U_Reg='" + NameBox.Text + "' AND Morakhasi.T_Reg LIKE '" + StartCalendar.Text + "%' ORDER BY Morakhasi.Tarikh DESC, Person.Family, Person.Fname", StrConnec))
                    {
                        Adap.Fill(TempTable);
                    }

                    ShowGridView.RowTemplate.DefaultCellStyle.BackColor=Color.LightGreen;
                    for (i=0; i <= TempTable.Rows.Count - 1; i++)
                    {
                        ShowGridView.Rows.Add(ShowGridView.Rows.Count + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Tarikh"].ToString(), TempTable.Rows[i]["E_Time"].ToString() + " مرخصی روزانه " + TempTable.Rows[i]["Kind"].ToString());
                    }

                    // *********** مرخصی ساعتی
                    TempTable.Clear();
                    using (OleDbDataAdapter Adap=new OleDbDataAdapter("Select Person.Fname, Person.Family, Person.P_Num, Amal.Tarikh, Amal.OnvAmal, Amal.Amal, Amal.U_Reg ,Amal.T_Reg ,Amal.Mem From Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.Vis=True And Amal.OnvAmal='ساعتی' AND Amal.U_Reg='" + NameBox.Text + "' AND Amal.T_Reg LIKE '" + StartCalendar.Text + "%' ORDER BY Amal.Tarikh DESC, Person.Family, Person.Fname", StrConnec))
                    {
                        Adap.Fill(TempTable);
                    }

                    ShowGridView.RowTemplate.DefaultCellStyle.BackColor=Color.Moccasin;
                    for (i=0; i <= TempTable.Rows.Count - 1; i++)
                    {
                        //        If Row Then ShowGridView.RowsDefaultCellStyle.BackColor=Color.White Else ShowGridView.RowsDefaultCellStyle.BackColor=Color.Moccasin
                        ShowGridView.Rows.Add(ShowGridView.Rows.Count + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Tarikh"].ToString(), "مرخصی ساعتی از " + TempTable.Rows[i]["Amal"].ToString());
                    }

                    // *********** عملکرد
                    TempTable.Clear();
                    using (OleDbDataAdapter Adap=new OleDbDataAdapter("Select Person.Fname, Person.Family, Person.P_Num, Amal.Tarikh, Amal.OnvAmal, Amal.Amal, Amal.U_Reg ,Amal.T_Reg ,Amal.Mem From Amal INNER JOIN Person ON Person.P_Num=Amal.P_Num WHERE Amal.Vis=True And (Amal.OnvAmal='منفی' OR Amal.OnvAmal='مثبت') AND Amal.U_Reg='" + NameBox.Text + "' AND Amal.T_Reg LIKE '" + StartCalendar.Text + "%' ORDER BY Amal.Tarikh DESC, Person.Family, Person.Fname", StrConnec))
                    {
                        Adap.Fill(TempTable);
                    }

                    ShowGridView.RowTemplate.DefaultCellStyle.BackColor=Color.White;
                    for (i=0; i <= TempTable.Rows.Count - 1; i++)
                    {
                        //        If Row Then ShowGridView.RowsDefaultCellStyle.BackColor=Color.White Else ShowGridView.RowsDefaultCellStyle.BackColor=Color.Moccasin
                        ShowGridView.Rows.Add(ShowGridView.Rows.Count + 1, TempTable.Rows[i]["Fname"].ToString(), TempTable.Rows[i]["Family"].ToString(), TempTable.Rows[i]["P_Num"].ToString(), TempTable.Rows[i]["Tarikh"].ToString(), "عملکرد " + TempTable.Rows[i]["OnvAmal"].ToString() + ": " + TempTable.Rows[i]["Amal"].ToString() + " (" + TempTable.Rows[i]["Mem"].ToString() + ")");
                    }

                }

                Enabled=true;

                if (ShowGridView.Rows.Count == 0)
                {
                    MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
                }
                else
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

        public void MyDailyOperationForm_Load(object sender, EventArgs e)
        {
            StartCalendar.Today_Click(null, null);
            NameBox.Text=AppState.UserName;

            if (AppState.UserLevel > 6 || AppState.UserLevel == 4)
            {
                NameButton.Enabled=false;
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

        public void NameButton_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                //PNum=PersonalSelectForm.PNum;
                //PLocal=PersonalSelectForm.PLocal;
                //PPost=PersonalSelectForm.PPost;
                //PTime=PersonalSelectForm.PTime;
                //PShift=PersonalSelectForm.PShift;

                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }

        }
    }
}
