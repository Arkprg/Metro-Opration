using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class KeshikEditForm
    {
        public KeshikEditForm()
        {
            InitializeComponent();
        }


        private string Shift;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Fill()
        {
            try
            {
                NameCombo.SelectedIndex=-1;
                NameCombo.Items.Clear();
                DetailGridView.Rows.Clear();
                int i;
                RegButton.Enabled=true;

                string QueStr=$"Vis=True AND Trip=True AND OverTime=True AND P_Post LIKE '%راهبر%' AND Shift_Name='{Shift}' AND ";
                if ((string)LocalCombo.SelectedItem == "هشتگرد")
                {
                    QueStr += "(Shift_Loc ='گلشهر' OR Shift_Loc ='هشتگرد')";
                }
                else
                {
                    QueStr += $"Shift_Loc ='{LocalCombo.Text}'";
                }

                if (AppState.UserLevel > 1)
                {
                    QueStr += $" AND Line_Num='{AppState.UserLnum}'";
                }

                if (AppState.UserLevel > 5)
                {
                    QueStr += $" AND P_Staff='{AppState.UserStaff}'";
                }

                DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_name");
                foreach (DataRow DtR in DRow)
                {
                    NameCombo.Items.Add(DtR["Family"].ToString() + ", " + DtR["Fname"].ToString() + " (" + DtR["P_Num"].ToString() + ")");
                }

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string StrQuer=$"SELECT Person.Fname, Person.Family, Person.P_Num, Person.OverTime, Person.vis, Keshik.ID, Keshik.T_Keshik, Keshik.L_Keshik FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.Vis=True AND Keshik.Tarikh='{PersianCalendar.Text}' AND Keshik.L_Keshik='{LocalCombo.Text}'";
                    if (ShiftCombo.SelectedIndex > 0)
                    {
                        StrQuer += $" AND Keshik.T_Keshik='{ShiftCombo.SelectedItem}'";
                    }

                    StrQuer += " ORDER BY T_Keshik";

                    using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            //If Reader.Item("T_Keshik").ToString=ShiftCombo.Text Then
                            DetailGridView.Rows.Add(0, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Reader["T_Keshik"].ToString() + " " + Reader["L_Keshik"].ToString(), Reader["ID"].ToString());
                            if (!(bool)Reader["OverTime"] || !(bool)Reader["vis"])
                            {
                                DetailGridView.Rows[DetailGridView.RowCount - 1].DefaultCellStyle.BackColor=Color.Red;
                                Label2.Visible=true;
                            }
                            //End If
                            i=0;
                            while (i < NameCombo.Items.Count)
                            {
                                if (Reader["P_Num"].ToString() == NameCombo.Items[i].ToString().Substring(NameCombo.Items[i].ToString().IndexOf("(") + 1, Convert.ToInt32(Convert.ToInt32(NameCombo.Items[i].ToString().Length - (NameCombo.Items[i].ToString().IndexOf("(") + 1)) - 1)))
                                {
                                    NameCombo.Items.RemoveAt(i);
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }

                    NameCombo.Enabled=true;
                    RegButton.Enabled=true;
                    Panel2.Enabled=true;

                    //Using CMD As New OleDbCommand($"SELECT Ezafeh.ID FROM Ezafeh INNER JOIN Person ON Person.P_Num=Ezafeh.P_Num WHERE Person.Line_Num='" & AppState.UserLnum & "' AND Ezafeh.Tarikh='" & PersianCalendar.Text & "' AND Ezafeh.E_Kind='کشیک' AND Ezafeh.Vis=True"
                    using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM DailyProcess WHERE Tarikh='{PersianCalendar.Text}' AND L_Num='{AppState.UserLnum}' AND Vis=True", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            NameCombo.Enabled=false;
                            RegButton.Enabled=false;
                            Panel2.Enabled=false;

                            StrConnec.Close();
                            MessageBoxFa.Show("پردازش انجام شده است", "خطا", MessageBoxIcon.Hand);
                            return;
                        }
                    }

                    for (i=0; i <= DetailGridView.Rows.Count - 1; i++)
                    {
                        DetailGridView.Rows[i].Cells[0].Value=i + 1;
                    }

                    if (DetailGridView.RowCount > 0)
                    {
                        DetailGridView.CurrentRow.Selected=false;
                        DeletLabel.Text="";
                    }

                }

                if (DetailGridView.Rows.Count == 0)
                {
                    MessageBoxFa.Show(" داده ای یافت نشد ", "توجه", MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersianCalendar_Leave(object sender, EventArgs e)
        {
            try
            {
                LocalCombo.SelectedIndex=-1;
                Shift="";
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand($"SELECT Holi, Rooz, Sobh FROM Taghvim WHERE Tarikh='{PersianCalendar.Text}'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if ((bool)Reader["Holi"] || Reader["Rooz"].ToString() == "7")
                            {
                                MessageBoxFa.Show("تاریخ انتخاب شده روز تعطیل است", "توجه", MessageBoxIcon.Asterisk);
                                RegButton.Enabled=false;
                            }
                            else
                            {
                                RegButton.Enabled=true;
                            }
                            switch (Reader["Sobh"].ToString())
                            {
                                case "A":
                                    Shift="C";
                                    break;
                                case "B":
                                    Shift="A";
                                    break;
                                case "C":
                                    Shift="B";
                                    break;
                            }
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

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
            ShiftCombo.SelectedIndex=0;
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameCombo.SelectedIndex=-1;
            NameCombo.Items.Clear();
            DetailGridView.Rows.Clear();
            DeleButton.Enabled=false;

            if (!string.IsNullOrEmpty(PersianCalendar.Text) && ShiftCombo.SelectedIndex >= 0 && LocalCombo.SelectedIndex >= 0)
            {
                Fill();
            }
        }

        public void NameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameCombo.SelectedIndex < 0)
            {
                RegButton.Enabled=false;
            }
            else
            {
                RegButton.Enabled=true;
                DeletLabel.Text="";
                DeleButton.Enabled=false;
                if (DetailGridView.Rows.Count > 0)
                {
                    if (DetailGridView.CurrentRow.Index >= 0)
                    {
                        DetailGridView.CurrentRow.Selected=false;
                    }
                }
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                Label2.Visible=true;
                Panel2.Enabled=false;

                if (NameCombo.SelectedIndex < 0)
                {
                    ErrorShow(NameCombo, "نام راهبر را تعیین کنید");
                }
                else if (ShiftCombo.SelectedIndex <= 0)
                {
                    ErrorShow(ShiftCombo, "شیفت را تعیین کنید");
                }
                else
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        int FID=0;
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM JayGozin WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND P_Num='{NameCombo.SelectedItem.ToString().Substring(NameCombo.SelectedItem.ToString().IndexOf("(") + 1, NameCombo.SelectedItem.ToString().Length - (NameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                FID=Convert.ToInt32(Reader["ID"]);
                            }
                        }

                        if (FID > 0)
                        {
                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE JayGozin SET Vis=False WHERE ID={FID}", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, Vis, L_Keshik, T_Keshik, U_Reg, T_Reg) VALUES('{NameCombo.SelectedItem.ToString().Substring(NameCombo.SelectedItem.ToString().IndexOf("(") + 1, NameCombo.SelectedItem.ToString().Length - (NameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}', '{PersianCalendar.Text}', True, '{LocalCombo.Text}', '{ShiftCombo.Text}', '{AppState.UserName}','{MainForm.PersianToday.Tarikh(DateTime.Today)} {DateTime.Now:HH:mm:ss}')", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Fill();
                }
                Panel2.Enabled=true;

            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void KeshikEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0304");
        }

        public void KeshikRegForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.NextDay_Click(null, null);
            PersianCalendar.Focus();
            DeletLabel.Text="";

            LocalCombo.Items.Clear();
            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
        }

        public void DetailGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DeleButton.Enabled=true;
            DeletLabel.Text =$"کشیک {DetailGridView.CurrentRow.Cells[1].Value} {DetailGridView.CurrentRow.Cells[2].Value} حذف گردد؟";
            NameCombo.SelectedIndex=-1;
            RegButton.Enabled=false;
        }

        public void DetailGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            for (i=0; i <= DetailGridView.Rows.Count - 1; i++)
            {
                DetailGridView.Rows[i].Cells[0].Value=i + 1;
            }
        }

        public void DeleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show(" کشیک ثیت شده حذف شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Panel2.Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"UPDATE Keshik SET Vis=False WHERE P_Num='{DetailGridView.CurrentRow.Cells[3].Value}' AND Tarikh='{PersianCalendar.Text}'", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, L_Keshik, T_Keshik, U_Reg, T_Reg, Fad, Vis) VALUES('{DetailGridView.CurrentRow.Cells[3].Value}', '{PersianCalendar.Text}', '{LocalCombo.Text}', '{ShiftCombo.Text}', '{AppState.UserName}','{MainForm.PersianToday.Tarikh(DateTime.Today)} {DateTime.Now:HH:mm:ss}', {DetailGridView.CurrentRow.Cells[5].Value}, False)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    NameCombo.Focus();
                    DeleButton.Enabled=false;
                    DeletLabel.Text="";
                    MessageBoxFa.Show("خذف با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Panel1.Enabled=true;
                    Fill();
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        private void PersianCalendar_Enter(object sender, EventArgs e)
        {
            LocalCombo.SelectedIndex=-1;
            NameCombo.SelectedIndex=-1;
            NameCombo.Items.Clear();
            DetailGridView.Rows.Clear();
        }
    }
}
