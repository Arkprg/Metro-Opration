using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class PhoneBookForm
    {
        public PhoneBookForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Search(object sender, EventArgs e)
        {
            try
            {
                PersonGridView.Rows.Clear();
                string CommandStr="Vis=True";
                if (NameBox.Text.Length > 0)
                {
                    CommandStr += " AND Fname LIKE '%" + NameBox.Text + "%'";
                }
                if (FamilyBox.Text.Length > 0)
                {
                    CommandStr += " AND Family LIKE '%" + FamilyBox.Text + "%'";
                }
                if (PNumBox.Text.Length > 0)
                {
                    CommandStr += " AND P_Num LIKE '%" + PNumBox.Text + "%'";
                }
                if (PhoneBox.Text.Length > 0)
                {
                    CommandStr += " AND Phone LIKE '%" + PhoneBox.Text + "%'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(CommandStr, " Family");
                foreach (DataRow DtR in DRow)
                {
                    PersonGridView.Rows.Add(DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["Phone"].ToString());
                }
                if (PersonGridView.RowCount > 0)
                {
                    PersonGridView.CurrentRow.Selected=false;
                }

                //Dim i As Integer
                //Dim Curect As Boolean=True

                //For i=0 To PersonGridView.Rows.Count - 1
                //    Curect=True
                //    If NameBox.Text.Length > 0 Then If InStr(PersonGridView.Rows(i).Cells(0).Value, NameBox.Text)=0 Then Curect=Curect And False
                //    If FamilyBox.Text.Length > 0 Then If InStr(PersonGridView.Rows(i).Cells(1).Value, FamilyBox.Text)=0 Then Curect=Curect And False
                //    If PNumBox.Text.Length > 0 Then If InStr(PersonGridView.Rows(i).Cells(2).Value, PNumBox.Text)=0 Then Curect=Curect And False
                //    If PhoneBox.Text.Length > 0 Then If InStr(PersonGridView.Rows(i).Cells(3).Value, PhoneBox.Text)=0 Then Curect=Curect And False

                //    PersonGridView.CurrentCell=Nothing
                //    If Not Curect Then
                //        PersonGridView.Rows(i).Visible=False
                //    Else
                //        PersonGridView.Rows(i).Visible=True
                //    End If
                //Next

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PhoneBookForm_Load(object sender, EventArgs e)
        {
            try
            {
                PhonBox1.Font=FontManager.Yekan(23, FontStyle.Bold);

                string CommandStr="Vis=True";
                if (AppState.UserLevel > 1)
                {
                    Height=465;
                    CommandStr += " And Line_Num='" + AppState.UserLnum + "'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(CommandStr, "Family, Fname");
                foreach (DataRow DtR in DRow)
                {
                    PersonGridView.Rows.Add(DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), DtR["Phone"].ToString(), "");
                }

                PersonGridView.CurrentRow.Selected=false;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        //Private Sub PNumBox_TextChanged(sender As Object, e As EventArgs) Handles PNumBox.TextChanged
        //    Search()
        //End Sub

        //Private Sub FamilyBox_TextChanged(sender As Object, e As EventArgs) Handles FamilyBox.TextChanged
        //    Search()
        //End Sub

        //Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        //    Search()
        //End Sub

        //Private Sub PhoneBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneBox.TextChanged
        //    Search()
        //End Sub

        public void PersonGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                PhonBox1.ReadOnly=true;
                //PhonBox1.BackColor=Color.Black;
                SaveButton.Enabled=false;

                if (PersonGridView.CurrentCellAddress.Y >= 0 && PersonGridView.CurrentCellAddress.X >= 0)
                {
                    PhonBox1.Visible=false;
                    NameLabel.Text=PersonGridView.CurrentRow.Cells[0].Value.ToString() + " " + PersonGridView.CurrentRow.Cells[1].Value.ToString();
                    if (PersonGridView.CurrentRow.Cells[3].Value.ToString() != "")
                    {
                        PhonBox1.Text=PersonGridView.CurrentRow.Cells[3].Value.ToString();
                        PhonBox1.Visible=true;
                    }
                    else if (PersonGridView.CurrentRow.Cells[4].Value.ToString() != "")
                    {
                        PhonBox1.Text=PersonGridView.CurrentRow.Cells[4].Value.ToString();
                        PhonBox1.Visible=true;
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

        public void EditButton_Click(object sender, EventArgs e)
        {
            PhonBox1.Visible=true;
            PhonBox1.ReadOnly=false;
            PhonBox1.BackColor=Color.Blue;
            SaveButton.Enabled=true;

            PhonBox1.Focus();
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Pho1="";
                Pho1=PhonBox1.Text.Replace(" ", "");
                if (Pho1.Length != 11)
                {
                    ErrorShow(PhonBox1, "شماره تلفن صحیح نیست");
                }
                else
                {

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Person SET Phone='" + Pho1 + "' WHERE P_Num='" + PersonGridView.CurrentRow.Cells[2].Value.ToString() + "'", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                    }


                    MessageBoxFa.Show("ثبت با موقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    PersonGridView.CurrentCell=PersonGridView.Rows[0].Cells[0];
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PhonBox1_Enter(object sender, EventArgs e)
        {
            PhonBox1.SelectionStart=0;
        }
    }
}
