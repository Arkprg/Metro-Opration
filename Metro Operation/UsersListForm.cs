using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UsersListForm
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        public void Form16_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    string QueStr = "Select PUser.UsersName, Person.Fname, Person.Family, PUser.P_Num, PUser.Acc_Levl, PUser.Reg_Date, PUser.Mod_date, PUser.U_Reg, PUser.Last_loggin, PUser.Acti From PUser INNER JOIN Person ON Person.P_Num=PUser.P_Num WHERE Person.Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += $" AND Person.Line_Num='{AppState.UserLnum}'";
                    }
                    QueStr += " ORDER BY Person.Family, Person.Fname";

                    using (OleDbCommand CMD = new OleDbCommand(QueStr, StrConnec))
                    using (OleDbDataReader Reader = CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            DataGridView1.Rows.Add(0, Reader["UsersName"].ToString(), Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["Acc_Levl"].ToString(), Reader["Reg_Date"].ToString(), Reader["Mod_date"].ToString(), Reader["U_Reg"].ToString(), Reader["Last_loggin"].ToString(), Reader["Acti"].ToString());
                        }
                    }

                    DataGridView1.Sort(DataGridView1.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                    int i;
                    for (i = 0; i <= DataGridView1.RowCount - 1; i++)
                    {
                        DataGridView1.Rows[i].Cells[0].Value = i + 1;

                         switch (DataGridView1.Rows[i].Cells[5].Value.ToString())
                        {
                            case "0":
                                DataGridView1.Rows[i].Cells[5].Value = "ادمین";
                                break;

                            case "1":
                                DataGridView1.Rows[i].Cells[5].Value = "مدیر عامل";
                                break;

                            case "2":
                                DataGridView1.Rows[i].Cells[5].Value = "مدیریت عملیات";
                                break;

                            case "3":
                                DataGridView1.Rows[i].Cells[5].Value = "کارشناس عملیات";
                                break;

                            case "4":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "5":
                                DataGridView1.Rows[i].Cells[5].Value = "رئیس سیر و حرکت";
                                break;

                            case "6":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "7":
                                DataGridView1.Rows[i].Cells[5].Value = "مسئول سیر و حرکت";
                                break;

                            case "8":
                                DataGridView1.Rows[i].Cells[5].Value = "تکنسین سیر و حرکت";
                                break;

                            case "9":
                                DataGridView1.Rows[i].Cells[5].Value = "راهبر سیر و حرکت";
                                break;

                            case "10":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "11":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "12":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "13":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "14":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "15":
                                DataGridView1.Rows[i].Cells[5].Value = "رئیس عملیات پارکینگ";
                                break;

                            case "16":
                                DataGridView1.Rows[i].Cells[5].Value = "--";
                                break;

                            case "17":
                                DataGridView1.Rows[i].Cells[5].Value = "مسئول عملیات پارکینگ";
                                break;

                            case "18":
                                DataGridView1.Rows[i].Cells[5].Value = "تکنسین عملیات پارکینگ";
                                break;

                            case "19":
                                DataGridView1.Rows[i].Cells[5].Value = "راهبر عملیات پارکینگ";
                                break;
                        }

                        if (DataGridView1.Rows[i].Cells[10].Value.ToString() == "False")
                        {
                            DataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
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

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i = 0; i <= DataGridView1.RowCount - 1; i++)
            {
                DataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
