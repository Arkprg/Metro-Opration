using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class NavganHistorForm
    {
        public NavganHistorForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridView.Rows.Clear();
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

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGridView.Rows.Clear();

                if (NumBox.Text.Length == 0)
                {
                    ErrorShow(NumBox, "شماره " + KindCombo.SelectedItem + " را مشخص کنید");
                }
                else
                {
                    Enabled=false;
                    int i=1;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        string QueStr="SELECT * FROM Navgan WHERE ";
                        if ((string)KindCombo.SelectedItem == "لکوموتیو")
                        {
                            QueStr += " Loco1='" + NumBox.Text + "' OR Loco2='" + NumBox.Text + "'";
                        }
                        else
                        {
                            QueStr += " Wag1='" + NumBox.Text + "' OR Wag2='" + NumBox.Text + "' OR Wag3='" + NumBox.Text + "' OR Wag4='" + NumBox.Text + "' OR Wag5='" + NumBox.Text + "' OR Wag6='" + NumBox.Text + "' OR Wag7='" + NumBox.Text + "' OR Wag8='" + NumBox.Text + "' OR Wag9='" + NumBox.Text + "'";
                        }
                        QueStr += " ORDER BY ID";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ShowGridView.Rows.Add(i, Reader["Loco1"].ToString(), Reader["Wag1"].ToString(), Reader["Wag2"].ToString(), Reader["Wag3"].ToString(), Reader["Wag4"].ToString(), Reader["Wag5"].ToString(), Reader["Wag6"].ToString(), Reader["Wag7"].ToString(), Reader["Wag8"].ToString(), Reader["Wag9"].ToString(), Reader["Loco2"].ToString(), Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString());

                                if ((bool)Reader["Vis"])
                                {
                                    ShowGridView.Rows[ShowGridView.Rows.Count - 1].DefaultCellStyle.BackColor=Color.Yellow;
                                }

                                i++;
                            }
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
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShowGridView.Rows.Count > 0)
            {
                ShowGridView.CurrentRow.Selected=false;
            }
        }

        public void ShowGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowGridView.Sort(ShowGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            if (ShowGridView.Rows.Count > 0)
            {
                ShowGridView.CurrentRow.Selected=false;
            }
        }
    }
}
