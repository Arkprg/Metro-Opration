using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ParkingReportForm
    {
        public ParkingReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ParkingReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.Items.Clear();
                //For i=0 To 4
                //    If MainForm.Locals(i).ToString <> "" Then LocalCombo.Items.Add(MainForm.Locals(i).ToString)
                //Next

                LocalCombo.Items.Add("تهران");
                LocalCombo.Items.Add("گلشهر");
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا را مشخص کنید");
                }
                else
                {
                    if ((string)LocalCombo.SelectedItem == "تهران")
                    {
                        ShowGridView.Rows.Add("سکوی شمالی تهران", "", "", "");
                        ShowGridView.Rows.Add("سکوی جنوبی تهران", "", "", "");

                        ShowGridView.Rows.Add("خط 2 پارک 1 تهران", "", "", "");
                        ShowGridView.Rows.Add("خط 2 پارک 2 تهران", "", "", "");
                        ShowGridView.Rows.Add("خط 3 پارک 1 تهران", "", "", "");
                        ShowGridView.Rows.Add("خط 3 پارک 2 تهران", "", "", "");
                        ShowGridView.Rows.Add("چاله سرویس تهران", "", "", "");
                    }
                    else if ((string)LocalCombo.SelectedItem == "گلشهر")
                    {
                        ShowGridView.Rows.Add("ساید شمالی گلشهر", "", "", "");
                        ShowGridView.Rows.Add("سکوی شمالی گلشهر", "", "", "");
                        ShowGridView.Rows.Add("ساید جنوبی گلشهر", "", "", "");
                        ShowGridView.Rows.Add("سکوی جنوبی گلشهر", "", "", "");

                        ShowGridView.Rows.Add("خط 1 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 2 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 3 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 4 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 5 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 6 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 7 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 8 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 9 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 10 پارکینگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("دوار جنوبی 1 مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("دوار جنوبی 2 مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("دوار جنوبی 3 مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("دوار شمالی مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 3 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 4 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 5 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("بیرون خط 5 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 6 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("بیرون خط 6 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 7 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("بیرون خط 7 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 8 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 9 واگن سازی مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 10 واگن سازی مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 11 واگن سازی مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 12 تراش مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 13 سوله رنگ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 14 تعمیرات مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 15 دیزل شاپ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 16 دیزل شاپ مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط 17 OCS مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط شمالی AG مهرشهر", "", "", "");
                        ShowGridView.Rows.Add("خط جنوبی BG مهرشهر", "", "", "");
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        int i;
                        for (i=0; i <= ShowGridView.Rows.Count - 1; i++)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Parking WHERE Vis=True AND P_Name='" + ShowGridView.Rows[i].Cells[0].Value.ToString() + "' ORDER BY T_Reg DESC", StrConnec))
                            {
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        ShowGridView.Rows[i].Cells[1].Value=Reader["Train"].ToString();
                                        ShowGridView.Rows[i].Cells[2].Value=Reader["U_Reg"].ToString();
                                        ShowGridView.Rows[i].Cells[3].Value=Reader["T_Reg"].ToString();
                                        ShowGridView.Rows[i].Cells[4].Value=Reader["E_Date"].ToString() + " " + Reader["E_Time"].ToString();
                                    }
                                }

                            }

                        }
                    }


                    if (ShowGridView.Rows.Count > 0)
                    {
                        ShowGridView.CurrentRow.Selected=false;
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

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
        }

        public void ShowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((string)ShowGridView.CurrentRow.Cells[1].Value != "")
                {
                    MessageBoxFa.Show("تاریخ: " + ShowGridView.CurrentRow.Cells[4].Value.ToString().Substring(0, 10) + "  " + "اعزام: " + ShowGridView.CurrentRow.Cells[4].Value.ToString().Substring(11, 5), "توضیحات تریپ", MessageBoxIcon.None);
                }
            }
        }
    }
}
