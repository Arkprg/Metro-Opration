using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace Metro_Operation
{
    public partial class ExamRportForm
    {
        public ExamRportForm()
        {
            InitializeComponent();
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SearchTitrCombo.Items.Clear();
                Enabled=false;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Ans_Type, U_Reg, Titr FROM Exam WHERE Kind='" + SearchKindCombo.SelectedItem + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (Reader["Ans_Type"].ToString() == "محرمانه")
                            {
                                if ((string)Reader["U_Reg"] == AppState.UserName || AppState.UserLevel < 7)
                                {
                                    SearchTitrCombo.Items.Add(Reader["Titr"]);
                                }
                            }
                            else
                            {
                                SearchTitrCombo.Items.Add(Reader["Titr"]);
                            }
                        }
                    }
                }

                Enabled=true;

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TitrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Enabled=false;
                int i;
                int j=0;
                int ExamID=0;

                while (ResultGridView.ColumnCount > 8)
                {
                    ResultGridView.Columns.RemoveAt(8);
                }
                if (QuizGridView.Columns.Count == 3)
                {
                    QuizGridView.Columns.Add("ج", "ج");
                }

                if (QuizGridView.Columns.Count == 4)
                {
                    QuizGridView.Columns.Add("د", "د");
                }

                ResultGridView.Rows.Clear();
                QuizGridView.Rows.Clear();

                bool Ans3=false;
                bool Ans4=false;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT ID, Titr, Tarikh FROM Exam WHERE Kind='" + SearchKindCombo.SelectedItem + "' AND Titr='" + SearchTitrCombo.SelectedItem + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ExamID=Convert.ToInt32(Reader["ID"]);
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Exam WHERE ID=" + ExamID.ToString(), StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            DateLabel.Text=Reader["Tarikh"].ToString();
                            EndLabel.Text=Reader["EndDate"].ToString();
                            LineLabel.Text=Reader["P_Line"].ToString();
                            PostLabel.Text=Reader["P_Post"].ToString();
                            LocalLabel.Text=Reader["P_Local"].ToString();
                            TimeLabel.Text=Reader["P_Time"].ToString();
                            ShiftLabel.Text=Reader["P_Shift"].ToString();
                            LevLabel.Text=Reader["L_Show"].ToString();
                        }
                    }

                    i=0;
                    Ans3=false;
                    Ans4=false;

                    using (OleDbCommand CMD=new OleDbCommand("SELECT Ansr1, Ansr2, Ansr3, Ansr4, Ques FROM ExamQues WHERE ExamID=" + ExamID.ToString(), StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ResultGridView.Columns.Add("Ans" + (i + 1).ToString(), "سوال " + (i + 1).ToString());
                            ResultGridView.Columns[i + 8].Width=60;
                            QuizGridView.Rows.Add();
                            QuizGridView.Rows[i].Cells[0].Value=i + 1 + ") " + Reader["Ques"].ToString();

                            if (Reader["Ansr1"].ToString() != "")
                            {
                                QuizGridView.Rows[i].Cells[1].Value=Reader["Ansr1"].ToString();
                            }

                            if (Reader["Ansr2"].ToString() != "")
                            {
                                QuizGridView.Rows[i].Cells[2].Value=Reader["Ansr2"].ToString();
                            }

                            if (Reader["Ansr3"].ToString() != "")
                            {
                                QuizGridView.Rows[i].Cells[3].Value=Reader["Ansr3"].ToString();
                                Ans3=true;
                            }
                            if (Reader["Ansr4"].ToString() != "")
                            {
                                QuizGridView.Rows[i].Cells[4].Value=Reader["Ansr4"].ToString();
                                Ans4=true;
                            }
                            i++;
                        }
                    }

                    if (!Ans4)
                    {
                        QuizGridView.Columns.RemoveAt(4);
                    }

                    if (!Ans3)
                    {
                        QuizGridView.Columns.RemoveAt(3);
                    }

                    i=0;
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, Shift_Loc, Shift_Time, Shift_name, ExamResult.ID, ExamResult.P_Num, ExamResult.T_Reg FROM ExamResult INNER JOIN Person ON ExamResult.P_Num=Person.P_Num WHERE ExamResult.Vis=True AND ExamResult.ExamID=" + ExamID.ToString() + " ORDER BY Family,Fname", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ResultGridView.Rows.Add(i + 1, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Shift_Loc"].ToString(), Reader["Shift_Time"].ToString(), Reader["Shift_name"].ToString(), Reader["T_Reg"].ToString(), "", "", "", "", "");
                            j=8;

                            using (OleDbCommand CMD1=new OleDbCommand("SELECT AnserNum FROM ExamAnsers WHERE ResultID=" + Reader["ID"].ToString(), StrConnec))
                            using (OleDbDataReader Reader1=CMD1.ExecuteReader())
                            {
                                while (Reader1.Read())
                                {
                                    if (Reader1["AnserNum"].ToString() == "0")
                                    {
                                        ResultGridView.Rows[i].Cells[j].Value="-";
                                    }
                                    else
                                    {
                                        ResultGridView.Rows[i].Cells[j].Value=Reader1["AnserNum"].ToString();
                                    }

                                    j++;
                                }
                            }

                            i++;
                        }
                    }
                }

                for (i=0; i <= ResultGridView.RowCount - 1; i++)
                {
                    ResultGridView.Rows[i].Cells[0].Value=i + 1;
                }

                Enabled=true;

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
            for (i=0; i <= ResultGridView.RowCount - 1; i++)
            {
                ResultGridView.Rows[i].Cells[0].Value=i + 1;
            }
        }

        public void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1=new SaveFileDialog()
                {
                    Filter="Excel Files|*.xlsx|Excel Files 97-2003|*.xls",
                    FileName=(string)SearchTitrCombo.SelectedItem
                };
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        Enabled=false;

                        Excel.Application ExcelApp=new Excel.Application();
                        Excel.Worksheet Worksheet1;
                        Excel.Worksheet Worksheet2;
                        // Dim Worksheet3 As Excel.Worksheet

                        Excel.Workbook Workbook;
                        System.Globalization.CultureInfo NewCulture;
                        System.Globalization.CultureInfo OldCulture;



                        OldCulture=System.Threading.Thread.CurrentThread.CurrentCulture;
                        NewCulture=new System.Globalization.CultureInfo(ExcelApp.LanguageSettings.get_LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI), true);
                        System.Threading.Thread.CurrentThread.CurrentCulture=NewCulture;

                        object misValue=System.Reflection.Missing.Value;
                        int i;
                        int j=0;

                        Workbook=ExcelApp.Workbooks.Add(misValue);

                        Worksheet1=Workbook.Sheets["Sheet1"];
                        Worksheet1.Name="مشخصات";
                        //  Worksheet1.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4
                        Worksheet1.DisplayRightToLeft=true;
                        Worksheet1.Cells.Font.Name="Tahoma";
                        Worksheet1.Cells.Font.Size=10;
                        Worksheet1.Rows.RowHeight=18;
                        Worksheet1.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet1.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet1.Cells.NumberFormat="@";
                        Worksheet1.Range["B3:C11"].Font.Bold=true;
                        Worksheet1.Columns[2].ColumnWidth=15;
                        Worksheet1.Columns[3].ColumnWidth=15;
                        Worksheet1.Range["B3:B11"].Interior.Color=ColorTranslator.ToOle(Color.Yellow);

                        Worksheet1.Cells[3, 2]="نوع";
                        Worksheet1.Cells[3, 3]=SearchKindCombo.SelectedItem;
                        Worksheet1.Cells[4, 2]="عنوان";
                        Worksheet1.Cells[4, 3]=SearchTitrCombo.SelectedItem;
                        Worksheet1.Cells[5, 2]="نوع پاسخگویی";
                        Worksheet1.Cells[5, 3]=LevLabel.Text;
                        Worksheet1.Cells[6, 2]="تاریخ شروع";
                        Worksheet1.Cells[6, 3]=DateLabel.Text;
                        Worksheet1.Cells[7, 2]="خط";
                        Worksheet1.Cells[7, 3]=LineLabel.Text;
                        Worksheet1.Cells[8, 2]="مبدا";
                        Worksheet1.Cells[8, 3]=LocalLabel.Text;
                        Worksheet1.Cells[9, 2]="پست سازمانی";
                        Worksheet1.Cells[9, 3]=PostLabel.Text;
                        Worksheet1.Cells[10, 2]="نوع شیفت";
                        Worksheet1.Cells[10, 3]=TimeLabel.Text;
                        Worksheet1.Cells[11, 2]="نام شیفت";
                        Worksheet1.Cells[11, 3]=ShiftLabel.Text;

                        for (i=0; i <= QuizGridView.Rows.Count - 1; i++)
                        {
                            Worksheet1.Cells[13 + i, 2]=QuizGridView.Rows[i].Cells[0].Value;
                            string Strn="";
                            if (QuizGridView.Columns.Count > 1)
                            {
                                Strn="الف) " + QuizGridView.Rows[i].Cells[1].Value;
                            }
                            if (QuizGridView.Columns.Count > 2)
                            {
                                Strn += "   ب) " + QuizGridView.Rows[i].Cells[2].Value;
                            }
                            if (QuizGridView.Columns.Count > 3)
                            {
                                Strn += "   ج) " + QuizGridView.Rows[i].Cells[3].Value;
                            }
                            if (QuizGridView.Columns.Count > 4)
                            {
                                Strn += "   د) " + QuizGridView.Rows[i].Cells[4].Value;
                            }
                            Worksheet1.Cells[13 + i, 3]=Strn;
                        }

                        Worksheet1.Columns.EntireColumn.AutoFit();
                        Worksheet1.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        // ************* Worksheet2
                        Worksheet2=Workbook.Sheets.Add(Worksheet1);
                        Worksheet2.Name="نتایج";
                        //   Worksheet2.PageSetup.PaperSize=Excel.XlPaperSize.xlPaperA4
                        Worksheet2.DisplayRightToLeft=true;
                        Worksheet2.Cells.Font.Name="Tahoma";
                        Worksheet2.Cells.Font.Size=10;
                        Worksheet2.Rows.RowHeight=18;
                        Worksheet2.Rows.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
                        Worksheet2.Rows.VerticalAlignment=Excel.XlVAlign.xlVAlignCenter;

                        Worksheet2.Cells.NumberFormat="@";
                        Worksheet2.Rows[1].RowHeight=22;

                        for (i=1; i <= 7; i++)
                        {
                            Worksheet2.Cells[i, 1]=ResultGridView.Columns[i].HeaderText;
                            Worksheet2.Cells[i, 1].Font.Bold=true;
                            Worksheet2.Cells[i, 1].Interior.Color=ColorTranslator.ToOle(Color.Yellow);
                        }
                        for (i=0; i <= QuizGridView.Rows.Count - 1; i++)
                        {
                            Worksheet2.Cells[i + 8, 1]=QuizGridView.Rows[i].Cells[0].Value;
                        }

                        for (i=1; i <= ResultGridView.RowCount; i++)
                        {
                            for (j=1; j <= ResultGridView.ColumnCount - 1; j++)
                            {
                                Worksheet2.Cells[j, i + 1]=ResultGridView[j, i - 1].Value.ToString();
                            }
                            Worksheet2.Rows[i + 1].RowHeight=20;
                        }

                        Worksheet2.Columns.EntireColumn.AutoFit();
                        Worksheet2.UsedRange.Borders.LineStyle=Excel.XlLineStyle.xlContinuous;

                        Workbook.SaveAs(SaveFileDialog1.FileName);
                        Workbook.Close();
                        ExcelApp.Quit();

                        //ReleaseObject(ExcelApp);
                        //ReleaseObject(Worksheet2);
                        //ReleaseObject(Worksheet1);
                        System.Threading.Thread.CurrentThread.CurrentCulture=OldCulture;

                        Enabled=true;
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
