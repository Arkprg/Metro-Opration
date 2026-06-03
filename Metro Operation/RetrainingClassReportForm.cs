using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class RetrainingClassReportForm
    {
        public RetrainingClassReportForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void RetrainingClassReportForm_Load(object sender, EventArgs e)
        {
            Taghvim PersianDate = new Taghvim(DateTime.Today);
            MonthCombo.Items.Add(PersianDate.MonthName());
            PersianDate.AddMonth(1);
            MonthCombo.Items.Add(PersianDate.MonthName());
            MonthCombo.SelectedIndex = 0;

            LocalCombo.Items.Clear();
            if (AppState.UserLevel < 6)
            {
                LocalCombo.Items.Add("همه موارد");
            }

            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
            if (LocalCombo.Items.Count > 0)
            {
                LocalCombo.SelectedIndex = 0;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.Clear();

                if (MonthCombo.SelectedIndex < 0)
                {
                    ErrorShow(MonthCombo, "نوع شیفت پرسنل را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "نام شیفت پرسنل را مشخص کنید");
                }
                else
                {
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        DataTable TempTable = new DataTable();

                        string StrQuer = "SELECT Person.Fname, Person.Family, Person.P_Num, Person.Line_Num, Retraining.Tarikh, Retraining.Kind, Retraining.L_Class, Retraining.T_Class FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Retraining.Vis=True";
                        if (AllCheckBox.Checked)
                        {
                            StrQuer += " AND Retraining.Tarikh LIKE '" + MainForm.PersianToday.Tarikh().Substring(0, 8) + "%'";
                        }
                        else
                        {
                            StrQuer += " AND Retraining.Tarikh >= '" + MainForm.PersianToday.Tarikh() + "'";
                        }
                        if (AppState.UserLevel > 1)
                        {
                            StrQuer += " And Person.Line_Num='" + AppState.UserLnum + "'";
                        }
                        if ((string)LocalCombo.SelectedItem != "همه موارد")
                        {
                            StrQuer += " And Person.Shift_Loc='" + LocalCombo.SelectedItem + "'";
                        }
                        StrQuer += " ORDER BY Retraining.Tarikh, Retraining.Kind, Retraining.T_Class, Person.Family, Person.Fname";
                        using (OleDbDataAdapter Adap = new OleDbDataAdapter(StrQuer, StrConnec))
                        {
                            Adap.Fill(TempTable);
                        }

                        int i;
                        for (i = 0; i <= TempTable.Rows.Count - 1; i++)
                        {
                            DataGridView1.Rows.Add(i + 1, TempTable.Rows[i]["Fname"], TempTable.Rows[i]["Family"], TempTable.Rows[i]["P_Num"], TempTable.Rows[i]["Tarikh"], TempTable.Rows[i]["Kind"], TempTable.Rows[i]["T_Class"], TempTable.Rows[i]["L_Class"]);
                        }
                        TempTable.Dispose();
                    }

                    Enabled = true;
                    if (DataGridView1.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
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
