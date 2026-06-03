using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PersonalSelectForm
    {
        public PersonalSelectForm()
        {
            InitializeComponent();
        }

        public static string PName, PFamily, PNum, PLnum, PPost, PStaff, PLocal, PShift, PTime;
        public static string Per="";
        private int CL=0;


        private void PersonalSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                PFamily=PersonGridView.CurrentRow.Cells[0].Value.ToString();
                PName=PersonGridView.CurrentRow.Cells[1].Value.ToString();
                PNum=PersonGridView.CurrentRow.Cells[2].Value.ToString();
                PLocal=PersonGridView.CurrentRow.Cells[6].Value.ToString();
                PPost=PersonGridView.CurrentRow.Cells[4].Value.ToString();
                PTime=PersonGridView.CurrentRow.Cells[3].Value.ToString();
                PShift=PersonGridView.CurrentRow.Cells[5].Value.ToString();
            }
        }

        public void Form12_Load(object sender, EventArgs e)
        {
            PName=PFamily=PNum=PLnum=PPost=PStaff=PLocal=PShift=PTime=Per="";
            try
            {
                string Pstr="";

                Pstr="Vis=True";
                if (!string.IsNullOrEmpty(Per))
                {
                    switch (Per)
                    {
                        case "گواهینامه":
                            Pstr += " AND Trip=True";
                            break;
                        case "راهبر":
                            Pstr += " AND P_Post LIKE 'راهبر%'";
                            break;
                        case "راهبر قطار":
                            Pstr += " AND P_Post='راهبر قطار'";
                            break;
                        case "پایانه":
                            Pstr += " AND Shift_Loc LIKE '%پایانه%'";
                            break;
                        case "راهبر پایانه":
                            Pstr += " AND P_Post='راهبر پایانه'";
                            break;
                        default:
                            Pstr += " AND P_Post='" + Per + "'";
                            break;
                    }
                }
                if (AppState.UserLevel > 1)
                {
                    Pstr += " AND Line_Num='" + AppState.UserLnum + "'";
                }

                if ((AppState.UserLevel > 4 && AppState.UserLevel < 10) || AppState.UserLevel > 14)
                {
                    Pstr += " AND P_Staff='" + AppState.UserStaff + "'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(Pstr, "Family");
                foreach (DataRow DtR in DRow)
                {
                    PersonGridView.Rows.Add(DtR["Family"].ToString(), DtR["Fname"].ToString(), DtR["P_Num"].ToString(), DtR["Shift_Time"].ToString(), DtR["P_Post"].ToString(), DtR["Shift_name"].ToString(), DtR["Shift_Loc"].ToString(), DtR["P_Staff"].ToString());
                }
                //If PersonGridView.RowCount > 0 Then PersonGridView.CurrentRow.Selected=False
                SearchBox.Focus();
                BackColor=Color.SlateGray;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void SelectButton_Click(object sender, EventArgs e)
        {
            if (PersonGridView.SelectedCells.Count == 0)
            {
                MessageBoxFa.Show(" گزینه ای انتخاب نشده است", "خطا", MessageBoxIcon.Error);
            }
            else
            {
                DialogResult=DialogResult.OK;
            }

        }

        private void PersonGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (PersonGridView.CurrentCell != null && Label1.Text == "نام خانوادگی:")
            {
                if (CL != PersonGridView.CurrentCell.ColumnIndex)
                {
                    if (PersonGridView.CurrentCell.ColumnIndex == 0)
                    {
                        Label1.Text="نام خانوادگی:";
                        CL=0;
                    }
                    else if (PersonGridView.CurrentCell.ColumnIndex == 1)
                    {
                        Label1.Text="نام:";
                        CL=1;
                    }
                    else if (PersonGridView.CurrentCell.ColumnIndex == 2)
                    {
                        Label1.Text="شماره پرسنلی:";
                        CL=2;
                    }
                }
                SearchBox.Focus();
            }
        }

        public void PersonGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CL != e.ColumnIndex)
            {
                if (e.ColumnIndex == 0)
                {
                    Label1.Text="نام خانوادگی:";
                    CL=0;
                }
                else if (e.ColumnIndex == 1)
                {
                    Label1.Text="نام:";
                    CL=1;
                }
                else if (e.ColumnIndex == 2)
                {
                    Label1.Text="شماره پرسنلی:";
                    CL=2;
                }
            }

            SearchBox.Focus();
        }

        public void PersonGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult=DialogResult.OK;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PersonGridView.Rows.Clear();
                Regex Filt=new Regex("['*()\\+/&$%^@#!×}{:;'/\\|,<>?\\][\\-_=]");
                string CommandStr="Vis=True";
                string SeachText=Filt.Replace(SearchBox.Text, "");
                if (Label1.Text == "نام خانوادگی:")
                {
                    CommandStr += " AND Family LIKE '%" + SeachText + "%'";
                }

                if (Label1.Text == "نام:")
                {
                    CommandStr += " AND Fname LIKE '%" + SeachText + "%'";
                }

                if (Label1.Text == "شماره پرسنلی:")
                {
                    CommandStr += " AND P_Num LIKE '%" + SeachText + "%'";
                }

                if (!string.IsNullOrEmpty(Per))
                {
                    switch (Per)
                    {
                        case "گواهینامه":
                            CommandStr += " AND Trip=True";
                            break;
                        case "راهبر":
                            CommandStr += " AND P_Post LIKE 'راهبر%'";
                            break;
                        case "راهبر قطار":
                            CommandStr += " AND P_Post='راهبر قطار'";
                            break;
                        case "پایانه":
                            CommandStr += " AND Shift_Loc LIKE '%پایانه%'";
                            break;
                        case "راهبر پایانه":
                            CommandStr += " AND P_Post='راهبر پایانه'";
                            break;
                        default:
                            CommandStr += " AND P_Post='" + Per + "'";
                            break;
                    }
                }

                if (AppState.UserLevel > 1)
                {
                    CommandStr += " AND Line_Num='" + AppState.UserLnum + "'";
                }

                if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                {
                    CommandStr += " AND P_Staff='" + AppState.UserStaff + "'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(CommandStr, "Family");
                foreach (DataRow DtR in DRow)
                {
                    PersonGridView.Rows.Add(DtR["Family"].ToString(), DtR["Fname"].ToString(), DtR["P_Num"].ToString(), DtR["Shift_Time"].ToString(), DtR["P_Post"].ToString(), DtR["Shift_name"].ToString(), DtR["Shift_Loc"].ToString());
                }
                if (PersonGridView.CurrentCell != null)
                {
                    switch (CL)
                    {
                        case 0:
                            Label1.Text="نام خانوادگی:";
                            break;

                        case 1:
                            Label1.Text="نام:";
                            break;

                        case 2:
                            Label1.Text="شماره پرسنلی:";
                            break;

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
    }
}
