using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace Metro_Operation
{


    public partial class TerminalTableRegForm
    {
        public TerminalTableRegForm()
        {
            InitializeComponent();
        }


        public bool Importting=false;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public dynamic ReadCell(string CellVal)
        {
            string CellStr;

            if (CellVal != null)
            {
                CellStr=DateTime.Parse(CellVal).ToShortTimeString();
            }
            else if (int.TryParse(CellVal, out _))
            {
                CellStr=Convert.ToDateTime(TimeSpan.FromHours(24 * double.Parse(CellVal)).ToString()).ToShortTimeString();
            }
            else
            {
                CellStr="";
            }


            return CellStr;
        }

        public void Add1Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConvertClass.TimeToDouble(Time1Box.Text, true) <= 0)
                {
                    ErrorShow(Time1Box, "زمان حرکت را مشخص کنید");
                }
                else if (Kind1Combo.SelectedIndex < 0)
                {
                    ErrorShow(Time1Box, "نوع حرکت را مشخص کنید");
                }
                else if (Mabd1Combo.SelectedIndex < 0)
                {
                    ErrorShow(Mabd1Combo, "مبدا حرکت را مشخص کنید");
                }
                else if (Magh1Combo.SelectedIndex < 0)
                {
                    ErrorShow(Magh1Combo, "مقصد حرکت را مشخص کنید");
                }
                else if (Kind1Combo.SelectedIndex == 0 && Mabd1Combo.SelectedIndex == 0)
                {
                    ErrorShow(Mabd1Combo, "نوع حرکت ورودی است");
                }
                else if (Kind1Combo.SelectedIndex == 1 && Mabd1Combo.SelectedIndex == 1)
                {
                    ErrorShow(Mabd1Combo, "نوع حرکت خروجی است");
                }
                else
                {
                    if (Magh1Combo.SelectedIndex == Mabd1Combo.SelectedIndex)
                    {
                        if (MessageBoxFa.Show("مبدا و مقصد یکسان است", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    int i;
                    for (i=0; i <= TehGridView.RowCount - 1; i++)
                    {
                        if ((string)TehGridView.Rows[i].Cells[1].Value == Time1Box.Text && TehGridView.Rows[i].Cells[2].Value == Kind1Combo.SelectedItem && TehGridView.Rows[i].Cells[3].Value == Mabd1Combo.SelectedItem && TehGridView.Rows[i].Cells[4].Value == Magh1Combo.SelectedItem)
                        {
                            ErrorShow(Panel11, "این حرکت قبلا ثبت شده است");
                            return;
                        }
                    }

                    TehGridView.Rows.Add(TehGridView.RowCount + 1, Time1Box.Text, Kind1Combo.SelectedItem, Mabd1Combo.SelectedItem, Magh1Combo.SelectedItem);
                    TehGridView.Sort(TehGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                    Time1Box.Text="";
                    Kind1Combo.SelectedIndex=-1;
                    Mabd1Combo.SelectedIndex=-1;
                    Magh1Combo.SelectedIndex=-1;
                    Time1Box.Focus();

                    for (i=0; i <= TehGridView.RowCount - 1; i++)
                    {
                        TehGridView.Rows[i].Cells[0].Value=i + 1;
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

        public void Add2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConvertClass.TimeToDouble(Time2Box.Text, true) <= 0)
                {
                    ErrorShow(Time2Box, "زمان حرکت را مشخص کنید");
                }
                else if (Kind2Combo.SelectedIndex < 0)
                {
                    ErrorShow(Time2Box, "نوع حرکت را مشخص کنید");
                }
                else if (Mabd2Combo.SelectedIndex < 0)
                {
                    ErrorShow(Mabd2Combo, "مبدا حرکت را مشخص کنید");
                }
                else if (Magh2Combo.SelectedIndex < 0)
                {
                    ErrorShow(Magh2Combo, "مقصد حرکت را مشخص کنید");
                }
                else
                {
                    if (Magh2Combo.SelectedIndex == Mabd2Combo.SelectedIndex)
                    {
                        if (MessageBoxFa.Show("مبدا و مقصد یکسان است", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    int i;
                    for (i=0; i <= MehGridView.RowCount - 1; i++)
                    {
                        if ((string)MehGridView.Rows[i].Cells[1].Value == Time2Box.Text && MehGridView.Rows[i].Cells[2].Value == Kind2Combo.SelectedItem && MehGridView.Rows[i].Cells[3].Value == Mabd2Combo.SelectedItem && MehGridView.Rows[i].Cells[4].Value == Magh2Combo.SelectedItem)
                        {
                            ErrorShow(Panel21, "این حرکت قبلا ثبت شده است");
                            return;
                        }
                    }

                    MehGridView.Rows.Add(MehGridView.RowCount + 1, Time2Box.Text, Kind2Combo.SelectedItem, Mabd2Combo.SelectedItem, Magh2Combo.SelectedItem);
                    MehGridView.Sort(MehGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                    Time2Box.Text="";
                    Kind2Combo.SelectedIndex=-1;
                    Mabd2Combo.SelectedIndex=-1;
                    Magh2Combo.SelectedIndex=-1;
                    Time2Box.Focus();

                    for (i=0; i <= MehGridView.RowCount - 1; i++)
                    {
                        MehGridView.Rows[i].Cells[0].Value=i + 1;
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

        public void Del1Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (TehGridView.RowCount > 0)
                {
                    if (TehGridView.CurrentRow.Index >= 0)
                    {
                        if (MessageBoxFa.Show("آیا حرکت " + TehGridView.CurrentRow.Cells[1].Value.ToString() + " " + TehGridView.CurrentRow.Cells[2].Value.ToString() + " از " + TehGridView.CurrentRow.Cells[3].Value.ToString() + " حذف شود؟", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            TehGridView.Rows.RemoveAt(TehGridView.CurrentRow.Index);
                        }

                        int i;
                        for (i=0; i <= TehGridView.RowCount - 1; i++)
                        {
                            TehGridView.Rows[i].Cells[0].Value=i + 1;
                        }
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

        public void Del2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (MehGridView.RowCount > 0)
                {
                    if (MehGridView.CurrentRow.Index >= 0)
                    {
                        if (MessageBoxFa.Show("آیا حرکت " + MehGridView.CurrentRow.Cells[1].Value.ToString() + " " + MehGridView.CurrentRow.Cells[2].Value.ToString() + " از " + MehGridView.CurrentRow.Cells[3].Value.ToString() + " حذف شود؟", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            MehGridView.Rows.RemoveAt(MehGridView.CurrentRow.Index);
                        }

                        int i;
                        for (i=0; i <= MehGridView.RowCount - 1; i++)
                        {
                            MehGridView.Rows[i].Cells[0].Value=i + 1;
                        }
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

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TehGridView.RowCount + MehGridView.RowCount == 0)
                {
                    ErrorShow(TehGridView, "اطلاعات حرکت را تعیین کنید");
                    ErrorShow(MehGridView, "اطلاعات حرکت را تعیین کنید");
                }
                else if (ImportKindCombo.SelectedIndex < 0)
                {
                    ErrorShow(ImportKindCombo, "نوع جدول را تعیین کنید");
                }
                else if (ImportTableNameBox.Text == "")
                {
                    ErrorShow(ImportTableNameBox, "نام جدول را تعیین کنید");
                }
                else
                {

                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM TerminalTable WHERE T_Kind='" + ImportKindCombo.SelectedItem + "' AND T_Name='" + ImportTableNameBox.Text + "' AND Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                ErrorShow(ImportTableNameBox, "جدول با این نام وجود دارد");
                                Enabled=true;
                                return;
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTable (T_Name, T_Kind, L_Num, U_Reg, T_Reg, Vis) VALUES (@TName , '" + ImportKindCombo.SelectedItem + "', '" + AppState.UserLnum + "','" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@TName", ImportTableNameBox.Text);
                            CMD.ExecuteNonQuery();
                        }


                        int IDNum=0;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT TOP 1 ID FROM TerminalTable WHERE T_Name='" + ImportTableNameBox.Text + "' AND T_Kind='" + ImportKindCombo.SelectedItem + "' AND Vis=True ORDER BY ID DESC", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                IDNum=Convert.ToInt32(Reader["ID"]);
                            }
                        }

                        int i;
                        for (i=0; i <= TehGridView.RowCount - 1; i++)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTableTrip (T_ID, E_Time, E_Kind, E_Start, E_End) VALUES (" + IDNum.ToString() + ", '" + TehGridView.Rows[i].Cells[1].Value.ToString() + "', '" + TehGridView.Rows[i].Cells[2].Value.ToString() + "', '" + TehGridView.Rows[i].Cells[3].Value.ToString() + "', '" + TehGridView.Rows[i].Cells[4].Value.ToString() + "')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        for (i=0; i <= MehGridView.RowCount - 1; i++)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTableTrip (T_ID, E_Time, E_Kind, E_Start, E_End) VALUES (" + IDNum.ToString() + ", '" + MehGridView.Rows[i].Cells[1].Value.ToString() + "', '" + MehGridView.Rows[i].Cells[2].Value.ToString() + "', '" + MehGridView.Rows[i].Cells[3].Value.ToString() + "', '" + MehGridView.Rows[i].Cells[4].Value.ToString() + "')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }
                    }


                    TehGridView.Rows.Clear();
                    MehGridView.Rows.Clear();
                    ImportKindCombo.SelectedIndex=-1;
                    NameBox.Text="";
                    ImportTableNameBox.Text="";
                    Enabled=true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                TehGridView.Rows.Clear();
                MehGridView.Rows.Clear();
                ImportKindCombo.SelectedIndex=-1;

                OpenFileDialog OpenFileDialog1=new OpenFileDialog()
                {
                    Filter="Excel Worksheets|*.xls;*.xlsx"
                };

                if (OpenFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    NameBox.Text=OpenFileDialog1.FileName;
                    Excel.Application Exl=new Excel.Application();
                    Excel.Workbook ExlWork;
                    string[] Sheets=new string[11];
                    string TableIndx="";
                    string Messag="";

                    int i=0;
                    ExlWork=Exl.Workbooks.Open(OpenFileDialog1.FileName);
                    foreach (Excel.Worksheets Sht in ExlWork.Worksheets)
                    {
                        Sheets[i]=Sht.Item[0];
                        i++;
                        //ImportKindCombo.Items.Add(Sht.Name)
                    }
                    Exl.ActiveWorkbook.Close();

                    Messag="";
                    for (i=0; i <= 9; i++)
                    {
                        if (Sheets[i] != "")
                        {
                            Messag += (i + 1).ToString() + "- " + Sheets[i] + "\n";
                        }
                    }
                    TableIndx=Microsoft.VisualBasic.Interaction.InputBox("شماره جدول را ورد کنید: " + "\n\n" + Messag);

                    if (int.TryParse(TableIndx, out _))
                    {
                        TehGridView.Rows.Clear();
                        MehGridView.Rows.Clear();

                        Enabled=false;
                        DataTable DtTable=new DataTable();


                        OleDbConnection ExcelConnection=new OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0; Data Source='" + NameBox.Text + "'; Extended Properties=Excel 12.0;");
                        OleDbDataAdapter MyCommand=new OleDbDataAdapter("SELECT * FROM [" + Sheets[(int)(double.Parse(TableIndx) - 1)] + "$]", ExcelConnection);
                        ExcelConnection.Open();
                        MyCommand.TableMappings.Add("Table", "Test");
                        MyCommand.Fill(DtTable);
                        ExcelConnection.Close();
                        ExcelConnection.Dispose();

                        int j=0;
                        int IdRow=-1;
                        for (i=0; i <= DtTable.Rows.Count - 1; i++)
                        {
                            for (j=0; j <= DtTable.Columns.Count - 1; j++)
                            {
                                if (DtTable.Rows[i][j].ToString() == "H")
                                {
                                    IdRow=i + 1;
                                    break;
                                }
                            }
                            if (IdRow >= 0)
                            {
                                break;
                            }
                        }

                        i=1;
                        for (i=IdRow; i <= DtTable.Rows.Count - 1; i++)
                        {
                            if (i == 70)
                            {
                                j=1;
                            }
                            if (DtTable.Rows[i][3].ToString() != "")
                            {
                                if (DtTable.Rows[i][1].ToString() != "" && DtTable.Rows[i][3].ToString() != "")
                                {
                                    MehGridView.Rows.Add(MehGridView.RowCount + 1, ReadCell(DtTable.Rows[i][3].ToString()), "ورودی", "پایانه مهرشهر", "گلشهر");
                                }
                                if (ReadCell(DtTable.Rows[i][29].ToString()) == null)
                                {
                                    MehGridView.Rows.Add(MehGridView.RowCount + 1, ReadCell(DtTable.Rows[i][28].ToString()), "خروجی", "گلشهر", "پایانه مهرشهر");
                                }

                                if (DtTable.Rows[i][16].ToString() != "" && DtTable.Rows[i][18].ToString() != "")
                                {
                                    TehGridView.Rows.Add(TehGridView.RowCount + 1, ReadCell(DtTable.Rows[i][18].ToString()), "ورودی", "پایانه تهران", "تهران");
                                }
                                if (ReadCell(DtTable.Rows[i][14].ToString()) == null)
                                {
                                    TehGridView.Rows.Add(TehGridView.RowCount + 1, ReadCell(DtTable.Rows[i][13].ToString()), "خروجی", "تهران", "پایانه تهران");
                                }
                            }
                        }

                        Enabled=true;
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void TerminalTableRegForm_Load(object sender, EventArgs e)
        {
            if (Importting)
            {
                NormalPanel.Visible=false;
                SelectButton_Click(null, null);
            }
            else
            {
                ImportPanel.Visible=false;
                PictureBox8.Top -= 60;
                PictureBox9.Top -= 60;
                Panel10.Top -= 60;
                Panel20.Top -= 60;
            }
        }
    }
}
