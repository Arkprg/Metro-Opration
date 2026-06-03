using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TerminalTableEditForm
    {
        public TerminalTableEditForm()
        {
            InitializeComponent();
        }


        private string TableID;
        private string TableMem;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void SearchKindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SearchNameCombo.SelectedIndex=-1;
                SearchNameCombo.Items.Clear();

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT T_Name FROM TerminalTable WHERE T_Kind='" + SearchKindCombo.SelectedItem + "' AND Vis=True And L_Num='" + AppState.UserLnum + "' ORDER BY T_Name", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            SearchNameCombo.Items.Add(Reader["T_Name"].ToString());
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

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView1.Rows.Clear();
                DataGridView2.Rows.Clear();

                if (SearchKindCombo.SelectedIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID, T_Kind, T_Name, Mem FROM TerminalTable WHERE T_Kind='" + SearchKindCombo.SelectedItem + "' AND T_Name='" + SearchNameCombo.SelectedItem + "' AND Vis=True And L_Num='" + AppState.UserLnum + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                TableID=Reader["ID"].ToString();
                                KindCombo.SelectedItem=Reader["T_Kind"].ToString();
                                NameBox.Text=Reader["T_Name"].ToString();
                                TableMem=Reader["Mem"].ToString();
                            }
                        }

                        if (!string.IsNullOrEmpty(TableID))
                        {
                            Panel1.Enabled=true;
                            RegButton.Enabled=true;
                            DelButton.Enabled=true;

                            using (OleDbCommand CMD=new OleDbCommand("SELECT E_Time, E_Kind, E_Start, E_END FROM TerminalTableTrip WHERE T_ID=" + TableID + " AND (E_Start='پایانه تهران' OR E_Start='تهران' OR E_END='پایانه تهران' OR E_END='تهران') ORDER BY E_Time", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DataGridView1.Rows.Add(DataGridView1.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_END"].ToString());
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand("SELECT E_Time, E_Kind, E_Start, E_END FROM TerminalTableTrip WHERE T_ID=" + TableID + " AND (E_Start='پایانه مهرشهر' OR E_Start='گلشهر' OR E_END='پایانه مهرشهر' OR E_END='گلشهر') ORDER BY E_Time", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DataGridView2.Rows.Add(DataGridView2.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_END"].ToString());
                                }
                            }
                        }
                        else
                        {
                            MessageBoxFa.Show("جدول مورد نظر پیدا نشد ", "خطا", MessageBoxIcon.Error);
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SearchNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel1.Enabled=false;
            RegButton.Enabled=false;
            DelButton.Enabled=false;
            DataGridView1.Rows.Clear();
            DataGridView2.Rows.Clear();
            KindCombo.SelectedIndex=-1;
            NameBox.Text="";
            TableID="";
        }

        public void Del2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView2.RowCount > 0)
                {
                    if (DataGridView2.CurrentRow.Index >= 0)
                    {
                        if (MessageBoxFa.Show("آیا حرکت " + DataGridView2.CurrentRow.Cells[1].Value.ToString() + " " + DataGridView2.CurrentRow.Cells[2].Value.ToString() + " از " + DataGridView2.CurrentRow.Cells[3].Value.ToString() + " حذف شود؟", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index);
                        }

                        int i;
                        for (i=0; i <= DataGridView2.RowCount - 1; i++)
                        {
                            DataGridView2.Rows[i].Cells[0].Value=i + 1;
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

        public void Del1Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView1.RowCount > 0)
                {
                    if (DataGridView1.CurrentRow.Index >= 0)
                    {
                        if (MessageBoxFa.Show("آیا حرکت " + DataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + DataGridView1.CurrentRow.Cells[2].Value.ToString() + " از " + DataGridView1.CurrentRow.Cells[3].Value.ToString() + " حذف شود؟", "توجه", MessageBoxIcon.Question, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index);
                        }

                        int i;
                        for (i=0; i <= DataGridView1.RowCount - 1; i++)
                        {
                            DataGridView1.Rows[i].Cells[0].Value=i + 1;
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
                    ErrorShow(Kind2Combo, "نوع حرکت را مشخص کنید");
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
                    for (i=0; i <= DataGridView2.RowCount - 1; i++)
                    {
                        if ((string)DataGridView2.Rows[i].Cells[1].Value == Time2Box.Text && DataGridView2.Rows[i].Cells[2].Value == Kind2Combo.SelectedItem && DataGridView2.Rows[i].Cells[3].Value == Mabd2Combo.SelectedItem && DataGridView2.Rows[i].Cells[4].Value == Magh2Combo.SelectedItem)
                        {
                            ErrorShow(Panel21, "این حرکت قبلا ثبت شده است");
                            return;
                        }
                    }

                    DataGridView2.Rows.Add(DataGridView2.RowCount + 1, Time2Box.Text, Kind2Combo.SelectedItem, Mabd2Combo.SelectedItem, Magh2Combo.SelectedItem);
                    DataGridView2.Sort(DataGridView2.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                    Time2Box.Text="";
                    Kind2Combo.SelectedIndex=-1;
                    Mabd2Combo.SelectedIndex=-1;
                    Magh2Combo.SelectedIndex=-1;
                    Time2Box.Focus();

                    for (i=0; i <= DataGridView2.RowCount - 1; i++)
                    {
                        DataGridView2.Rows[i].Cells[0].Value=i + 1;
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
                    for (i=0; i <= DataGridView1.RowCount - 1; i++)
                    {
                        if ((string)DataGridView1.Rows[i].Cells[1].Value == Time1Box.Text && DataGridView1.Rows[i].Cells[2].Value == Kind1Combo.SelectedItem && DataGridView1.Rows[i].Cells[3].Value == Mabd1Combo.SelectedItem && DataGridView1.Rows[i].Cells[4].Value == Magh1Combo.SelectedItem)
                        {
                            ErrorShow(Panel11, "این حرکت قبلا ثبت شده است");
                            return;
                        }
                    }

                    DataGridView1.Rows.Add(DataGridView1.RowCount + 1, Time1Box.Text, Kind1Combo.SelectedItem, Mabd1Combo.SelectedItem, Magh1Combo.SelectedItem);
                    DataGridView1.Sort(DataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                    Time1Box.Text="";
                    Kind1Combo.SelectedIndex=-1;
                    Mabd1Combo.SelectedIndex=-1;
                    Magh1Combo.SelectedIndex=-1;
                    Time1Box.Focus();

                    for (i=0; i <= DataGridView1.RowCount - 1; i++)
                    {
                        DataGridView1.Rows[i].Cells[0].Value=i + 1;
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
                if (DataGridView1.RowCount + DataGridView2.RowCount == 0)
                {
                    ErrorShow(DataGridView1, "اطلاعات حرکت را تعیین کنید");
                    ErrorShow(DataGridView2, "اطلاعات حرکت را تعیین کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع جدول را تعیین کنید");
                }
                else if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام جدول را تعیین کنید");
                }
                else
                {

                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE TerminalTable SET Vis=False, Mem='" + TableMem + " - ویرایش: " + AppState.UserName + " - " + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE ID=" + TableID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM TerminalTable WHERE T_Kind='" + KindCombo.SelectedItem + "' AND T_Name='" + NameBox.Text + "' AND Vis=True", StrConnec))
                           using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                                {
                                    StrConnec.Close();
                                    ErrorShow(NameBox, "جدول با این نام وجود دارد");
                                    return;
                                }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTable (T_Name, T_Kind, L_Num, U_Reg, T_Reg, Vis) VALUES (@TName , '" + KindCombo.SelectedItem + "', '" + AppState.UserLnum + "','" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@TName", NameBox.Text);
                            CMD.ExecuteNonQuery();
                        }


                        int IDNum=0;
                        using (OleDbCommand CMD=new OleDbCommand("SELECT TOP 1 ID FROM TerminalTable WHERE T_Name='" + NameBox.Text + "' AND T_Kind='" + KindCombo.SelectedItem + "' AND Vis=True ORDER BY ID DESC", StrConnec))
                           using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                IDNum=Convert.ToInt32(Reader["ID"]);
                            }
                        }

                        int i;
                        for (i=0; i <= DataGridView1.RowCount - 1; i++)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTableTrip (T_ID, E_Time, E_Kind, E_Start, E_End) VALUES (" + IDNum.ToString() + ", '" + DataGridView1.Rows[i].Cells[1].Value.ToString() + "', '" + DataGridView1.Rows[i].Cells[2].Value.ToString() + "', '" + DataGridView1.Rows[i].Cells[3].Value.ToString() + "', '" + DataGridView1.Rows[i].Cells[4].Value.ToString() + "')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }
                        for (i=0; i <= DataGridView2.RowCount - 1; i++)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO TerminalTableTrip (T_ID, E_Time, E_Kind, E_Start, E_End) VALUES (" + IDNum.ToString() + ", '" + DataGridView2.Rows[i].Cells[1].Value.ToString() + "', '" + DataGridView2.Rows[i].Cells[2].Value.ToString() + "', '" + DataGridView2.Rows[i].Cells[3].Value.ToString() + "', '" + DataGridView2.Rows[i].Cells[4].Value.ToString() + "')", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }
                    }


                    DataGridView1.Rows.Clear();
                    DataGridView2.Rows.Clear();
                    KindCombo.SelectedIndex=-1;
                    SearchKindCombo.SelectedIndex=-1;
                    NameBox.Text="";
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

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView1.RowCount + DataGridView2.RowCount == 0)
                {
                    ErrorShow(DataGridView1, "اطلاعات حرکت را تعیین کنید");
                    ErrorShow(DataGridView2, "اطلاعات حرکت را تعیین کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع جدول را تعیین کنید");
                }
                else if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام جدول را تعیین کنید");
                }
                else
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE TerminalTable SET Vis=False, Mem='" + TableMem + " - حذف: " + AppState.UserName + " - " + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE ID=" + TableID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    MessageBoxFa.Show("حذف با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);

                    DataGridView1.Rows.Clear();
                    DataGridView2.Rows.Clear();
                    KindCombo.SelectedIndex=-1;
                    SearchKindCombo.SelectedIndex=-1;
                    NameBox.Text="";
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }
    }
}
