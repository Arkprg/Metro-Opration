using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class KeshikReplaceForm
    {
        public KeshikReplaceForm()
        {
            InitializeComponent();
        }

        private string Shift, RepShift, PName, PFamily, PNum;
        private string Tar;
        private string Loc;
        private string Shi;
        private string RePNum;
        private string ReTar;
        private string ReLoc;
        private string ReShi;
        private int ID;
        private int ReID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clean()
        {
            ChangeRadio.Checked=false;
            ReplaseRadio.Checked=false;
            ChangeRadio.Enabled=false;
            ReplaseRadio.Enabled=false;
            DateLabel.Text="";
            LocalLabel.Text="";
            ShiftLabel.Text="";
        }

        public void KeshikReplaceForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0113");
        }

        public void KeshikEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                ReplaseLocalCombo.Items.Clear();
                DataGridView1.Rows.Clear();
                PictureBox1.Visible=false;

                Label10.Text="";
                Label9.Text="";

                ReplaseLocalCombo.Enabled=false;
                ReplaseShiftCombo.Enabled=false;
                ReplaseNameCombo.Enabled=false;

                ChangeRadio.Enabled=false;
                ReplaseRadio.Enabled=false;
                RegButton.Enabled=false;

                Taghvim PersianDate=new Taghvim(DateTime.Today);
                MonthCombo.Items.Add(PersianDate.MonthName());
                PersianDate.AddMonth(1);
                MonthCombo.Items.Add(PersianDate.MonthName());

                foreach (string Local in MainForm.Locals)
                {
                    if (!string.IsNullOrEmpty(Local))
                    {
                        ReplaseLocalCombo.Items.Add(Local);
                    }
                }

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                    {
                        PNum=AppState.UserPnum;
                        NameButton.Enabled=false;
                        NameBox.Text=AppState.UserName;
                        Shift=AppState.UserShift;

                        ReplaseRadio.Visible=false;

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT KeshikHist.FromID, KeshikHist.ToID, Keshik.ID, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik, Keshik.Fad FROM KeshikHist INNER JOIN Keshik ON KeshikHist.ToID=Keshik.ID WHERE Keshik.P_Num='{PNum}' AND KeshikHist.Vis=True ORDER BY Keshik.Tarikh", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DataGridView1.Rows.Add(Reader["FromID"].ToString(), 0, "", "", $"از {Reader["Tarikh"]} {Reader["T_Keshik"]} {Reader["L_Keshik"]}", ">>>>> ", "", Reader["ToID"]);
                            }
                        }

                        for (int i=0; i <= DataGridView1.RowCount - 1; i++)
                        {
                            DataGridView1.Rows[i].Cells[1].Value=i + 1;
                            using (OleDbCommand CMD=new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik, Keshik.Fad FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.ID={DataGridView1.Rows[i].Cells[0].Value}", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DataGridView1.Rows[i].Cells[2].Value=$"{Reader["Fname"]} {Reader["Family"]}";
                                    DataGridView1.Rows[i].Cells[3].Value=$"{ Reader["P_Num"]}";
                                    DataGridView1.Rows[i].Cells[4].Value=$"از {Reader["Tarikh"]} {Reader["T_Keshik"]} {Reader["L_Keshik"]}";
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik, Keshik.Fad FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.ID={DataGridView1.Rows[i].Cells[7].Value}", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DataGridView1.Rows[i].Cells[6].Value=$"به {Reader["Tarikh"]} {Reader["T_Keshik"]} {Reader["L_Keshik"]}";
                                }
                            }

                            DataGridView1.CurrentRow.Selected=false;
                            PictureBox1.Visible=true;
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

        public void ChangeRadio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PersianCalendar.Miladi=DateTime.Today;
                PersianCalendar.Enabled=false;
                ReplaseLocalCombo.Enabled=false;
                ReplaseShiftCombo.Enabled=false;
                ReplaseNameCombo.Enabled=false;
                if (ChangeRadio.Checked)
                {
                    PersianCalendar.Enabled=true;
                    ReplaseLocalCombo.Enabled=true;
                    ReplaseShiftCombo.Enabled=true;
                    ReplaseNameCombo.Enabled=true;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ReplaseRadio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PersianCalendar.Enabled=false;
                PersianCalendar.Text="";
                ReplaseLocalCombo.Enabled=false;
                ReplaseShiftCombo.Enabled=false;
                ReplaseNameCombo.Enabled=false;

                ReplaseNameCombo.SelectedIndex=-1;
                ReplaseNameCombo.Items.Clear();

                if (ReplaseRadio.Checked)
                {
                    ReplaseNameCombo.Enabled=true;

                    string QueStr=$"Vis=True AND Trip=True AND P_Post='راهبر قطار' AND Shift_Name='{Shift}'";
                    if (LocalLabel.Text == "هشتگرد")
                    {
                        QueStr += " AND (Shift_Loc='هشتگرد' OR Shift_Loc='گلشهر')";
                    }
                    else
                    {
                        QueStr += " AND Shift_Loc='" + LocalLabel.Text + "'";
                    }

                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                    foreach (DataRow DtR in DRow)
                    {
                        ReplaseNameCombo.Items.Add($"{DtR["Fname"]} {DtR["Family"]} ({DtR["P_Num"]})");
                    }

                    int i;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT P_Num FROM Keshik WHERE Vis=True AND Tarikh='{DateLabel.Text}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                i=0;
                                while (i < ReplaseNameCombo.Items.Count)
                                {
                                    if (Reader["P_Num"].ToString() == ReplaseNameCombo.Items[i].ToString().Substring(ReplaseNameCombo.Items[i].ToString().IndexOf("(") + 1, Convert.ToInt32(Convert.ToInt32(ReplaseNameCombo.Items[i].ToString().Length - (ReplaseNameCombo.Items[i].ToString().IndexOf("(") + 1)) - 1)))
                                    {
                                        ReplaseNameCombo.Items.RemoveAt(i);
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
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

        public void ReplaseLocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplaseShiftCombo.SelectedIndex=-1;
            ReplaseShiftCombo.Items.Clear();
            ReplaseShiftCombo.Items.Add($"صبح");
            ReplaseShiftCombo.Items.Add($"عصر");
        }

        public void ReplaseShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReplaseNameCombo.SelectedIndex=-1;
                ReplaseNameCombo.Items.Clear();
                if (ReplaseShiftCombo.SelectedIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.L_Keshik='{ReplaseLocalCombo.SelectedItem}' AND Keshik.Tarikh='{PersianCalendar.Text}' AND Keshik.T_Keshik='{ReplaseShiftCombo.SelectedItem}' AND Keshik.Vis=True", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ReplaseNameCombo.Items.Add($"{Reader["Fname"]} {Reader["Family"]} ({Reader["P_Num"]})");
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

        public void ReplaseNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReplaseNameCombo.SelectedIndex >= 0)
            {
                RegButton.Enabled=true;
            }
            else
            {
                RegButton.Enabled=false;
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try // اصلاح
            {
                if (DateLabel.Text == PersianCalendar.Text && LocalLabel.Text == (string)ReplaseLocalCombo.SelectedItem && ShiftLabel.Text == (string)ReplaseShiftCombo.SelectedItem)
                {
                    MessageBoxFa.Show("امکان این جابجایی وجود ندارد", "خطا", MessageBoxIcon.Error);
                    return;
                }

                if (AppState.UserLevel == 9 || AppState.UserLevel == 19)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{PNum}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ID=Convert.ToInt32(Reader["ID"]);
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM KeshikHist WHERE Vis=True AND (FromID={ID} OR ToID={ID})", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show("شما برای این کشیک، درخواست جابجایی بدون پاسخ دارید", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ReID=Convert.ToInt32(Reader["ID"]);
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM KeshikHist WHERE Vis=True AND (FromID={ReID} OR ToID={ReID})", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show(ReplaseNameCombo.SelectedItem.ToString().Substring(0, ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) + "درحال جابجایی کشیک مورد نظر است", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}' AND ID<>{ReID}", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show(ReplaseNameCombo.SelectedItem.ToString().Substring(0, ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) + "در این تاریخ کشیک است", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND P_Num='{PNum}' AND ID<>{ID}", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show("شما در این تاریخ در لیست کشیک هستید", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO KeshikHist (FromID, ToID, U_Reg, T_Reg, Vis) VALUES ({ID}, {ReID},'{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }
                    MessageBoxFa.Show($"در خواست جابجایی کشیک برای {ReplaseNameCombo.SelectedItem.ToString().Substring(0, ReplaseNameCombo.SelectedItem.ToString().IndexOf("("))}ارسال شد \n  در صورت تایید جابجایی انجام خواهد شد ", "توجه", MessageBoxIcon.Asterisk);
                    DateLabel.Text="";
                    PersianCalendar.Text="";
                    LocalLabel.Text="";
                    ShiftLabel.Text="";
                    ReplaseLocalCombo.SelectedIndex=-1;
                    ReplaseLocalCombo.Items.Clear();
                    ShowButton_Click(null, null);
                }
                else
                {
                    if (ChangeRadio.Checked)
                    {
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            if (DateLabel.Text != PersianCalendar.Text)
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND P_Num='{PNum}'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        StrConnec.Close();
                                        MessageBoxFa.Show(NameBox.Text + " در این تاریخ در لیست کشیک قرار دارد", "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }

                                using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}' ", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        StrConnec.Close();
                                        MessageBoxFa.Show(ReplaseNameCombo.SelectedItem.ToString().Substring(0, ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) + "در این تاریخ در لیست کشیک قرار دارد", "خطا", MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }

                            ID=0;
                            using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM JayGozin WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND P_Num='{PNum}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"]);
                                }
                            }

                            if (ID > 0)
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE JayGozin SET Vis=False WHERE ID={ID}", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                                MessageBoxFa.Show($"در خواست اضافه کار برای {NameBox.Text} در تاریخ {DateLabel.Text} حذف شد", "توجه", MessageBoxIcon.Asterisk);
                            }

                            ID=0;
                            using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM JayGozin WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"]);
                                }
                            }

                            if (ID > 0)
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE JayGozin SET Vis=False WHERE ID={ID}", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                                MessageBoxFa.Show($"در خواست اضافه کار برای {ReplaseNameCombo.SelectedItem.ToString().Substring(0, ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1)} در تاریخ {PersianCalendar.Text} حذف شد", "توجه", MessageBoxIcon.Asterisk);
                            }

                            ID=0;
                            ReID=0;
                            using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{PNum}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"]);
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM Keshik WHERE Vis=True AND Tarikh='{PersianCalendar.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ReID=Convert.ToInt32(Reader["ID"]);
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE Keshik SET Vis=False WHERE Tarikh='{DateLabel.Text}' AND P_Num='{PNum}'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE Keshik SET Vis=False WHERE Tarikh='{PersianCalendar.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE KeshikHist SET Vis=False WHERE FromID={ID} OR ToID={ReID}", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, L_Keshik, T_Keshik, U_Reg, T_Reg, Fad, Vis) VALUES ('{PNum}', '{PersianCalendar.Text}', '{ReplaseLocalCombo.SelectedItem}', '{ReplaseShiftCombo.SelectedItem}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', {ID}, True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, L_Keshik, T_Keshik, U_Reg, T_Reg, Fad, Vis) VALUES ('{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}', '{DateLabel.Text}', '{LocalLabel.Text}', '{ShiftLabel.Text}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', {ReID}, True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        DateLabel.Text="";
                        PersianCalendar.Text="";
                        LocalLabel.Text="";
                        ShiftLabel.Text="";
                        ReplaseLocalCombo.SelectedIndex=-1;
                        ReplaseLocalCombo.Items.Clear();
                    }
                    else if (ReplaseRadio.Checked)
                    {
                        ID=0;

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM JayGozin WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"].ToString());
                                }
                            }

                            if (ID > 0)
                            {
                                using (OleDbCommand CMD=new OleDbCommand($"UPDATE JayGozin SET Vis=False WHERE ID={ID}", StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }

                                MessageBoxFa.Show($"در خواست اضافه کار برای {ReplaseNameCombo.SelectedItem.ToString().Substring(0, ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1)} در تاریخ {DateLabel.Text} حذف شد", "توجه", MessageBoxIcon.Asterisk);
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"SELECT * FROM Keshik WHERE Vis=True AND Tarikh='{DateLabel.Text}' AND P_Num='{PNum}'", StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"].ToString());
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE Keshik SET Vis=False WHERE Tarikh='{DateLabel.Text}' AND P_Num='{PNum}'", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"UPDATE KeshikHist SET Vis=False WHERE FromID={ID} OR ToID={ReID}", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, L_Keshik, T_Keshik, U_Reg, T_Reg, Fad, Vis) VALUES ('{ReplaseNameCombo.SelectedItem.ToString().Substring(ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1, ReplaseNameCombo.SelectedItem.ToString().Length - (ReplaseNameCombo.SelectedItem.ToString().IndexOf("(") + 1) - 1)}', '{DateLabel.Text}', '{LocalLabel.Text}', '{ShiftLabel.Text}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', {ID}, True)", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        Clean();
                    }
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    ShowButton_Click(null, null);
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

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (Label10.Text.Length == 20)
            {
                Label10.Text="";
                Label9.Text="";
            }
            else
            {
                Label10.Text += ">";
                Label9.Text += ">";
            }
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            try
            {
                SobhGridView.Rows.Clear();
                AsrGridView.Rows.Clear();
                NameBox.Text="";
                NameButton.Image=Properties.Resources.user;
                Clean();
                PersonalSelectForm.Per="راهبر";
                PersonalSelectForm ShowForm=new PersonalSelectForm();
                if (ShowForm.ShowDialog() == DialogResult.OK)
                {
                    PFamily=PersonalSelectForm.PFamily;
                    PName=PersonalSelectForm.PName;
                    PNum=PersonalSelectForm.PNum;
                    Shift=PersonalSelectForm.PShift;
                    NameBox.Text=PName + " " + PFamily;
                    NameButton.Image=Properties.Resources.cancel1;
                }

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
                Clean();
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام راهبر را تعیین کنید");
                }
                else if (MonthCombo.SelectedIndex < 0)
                {
                    ErrorShow(MonthCombo, "تاریخ کشیک را تعیین کنید");
                }
                else
                {
                    Enabled=false;
                    SobhGridView.Rows.Clear();
                    AsrGridView.Rows.Clear();
                    Taghvim PersianDate=new Taghvim();
                    PersianDate.AddMonth(MonthCombo.SelectedIndex);
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        using (OleDbCommand CMD=new OleDbCommand($"SELECT Person.Fname, Person.Family, Person.P_Num, Keshik.ID, Keshik.Tarikh, Keshik.T_Keshik, Keshik.L_Keshik, Keshik.Fad FROM Keshik INNER JOIN Person ON Person.P_Num=Keshik.P_Num WHERE Keshik.P_Num='{PNum}' AND Keshik.Vis=True AND Keshik.Tarikh LIKE '{PersianDate.Tarikh().Substring(0, 7)}%' ORDER BY Keshik.Tarikh", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                PersianDate.SetDate(Reader["Tarikh"].ToString());
                                if (Reader["T_Keshik"].ToString() == SobhGridView.Columns[1].HeaderText)
                                {
                                    SobhGridView.Rows.Add(Reader["ID"].ToString(), $"{PersianDate.DayWeek()} { Reader["Tarikh"]} {Reader["L_Keshik"]}");
                                }
                                else if (Reader["T_Keshik"].ToString() == AsrGridView.Columns[1].HeaderText)
                                {
                                    AsrGridView.Rows.Add(Reader["ID"].ToString(), $"{PersianDate.DayWeek()} { Reader["Tarikh"]} {Reader["L_Keshik"]}");
                                }
                            }
                        }
                    }

                    if (SobhGridView.RowCount > 0)
                    {
                        SobhGridView.CurrentRow.Selected=false;
                        SobhGridView.Enabled=true;
                    }
                    else
                    {
                        SobhGridView.Enabled=false;
                    }
                    if (AsrGridView.RowCount > 0)
                    {
                        AsrGridView.CurrentRow.Selected=false;
                        AsrGridView.Enabled=true;
                    }
                    else
                    {
                        AsrGridView.Enabled=false;
                    }
                    Enabled=true;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void AsrGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clean();

                if (e.RowIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT Tarikh, L_Keshik, T_Keshik FROM Keshik WHERE ID={AsrGridView.CurrentRow.Cells[0].Value}", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DateLabel.Text=Reader["Tarikh"].ToString();
                                LocalLabel.Text=Reader["L_Keshik"].ToString();
                                ShiftLabel.Text=Reader["T_Keshik"].ToString();

                                ChangeRadio.Enabled=true;
                                ReplaseRadio.Enabled=true;
                            }
                        }
                    }

                    AsrGridView.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void SobhGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clean();

                if (e.RowIndex >= 0)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"SELECT Tarikh, L_Keshik, T_Keshik FROM Keshik WHERE ID={SobhGridView.CurrentRow.Cells[0].Value}", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                DateLabel.Text=Reader["Tarikh"].ToString();
                                LocalLabel.Text=Reader["L_Keshik"].ToString();
                                ShiftLabel.Text=Reader["T_Keshik"].ToString();

                                ChangeRadio.Enabled=true;
                                ReplaseRadio.Enabled=true;
                            }
                        }
                    }

                    SobhGridView.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SobhGridView.Rows.Clear();
            AsrGridView.Rows.Clear();
            Clean();
        }

        public void ReqAcsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int FID=0;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    FID=0;
                    using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM JayGozin WHERE Vis=True AND Tarikh='{ReTar}' AND P_Num='{PNum}'", StrConnec))
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

                    FID=0;
                    using (OleDbCommand CMD=new OleDbCommand($"SELECT ID FROM JayGozin WHERE Vis=True AND Tarikh='{Tar}' AND P_Num='{RePNum}'", StrConnec))
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

                    using (OleDbCommand CMD=new OleDbCommand($"UPDATE Keshik SET Vis=False WHERE ID={ID}", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }

                    using (OleDbCommand CMD=new OleDbCommand($"UPDATE Keshik SET Vis=False WHERE ID={ReID}", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }

                    using (OleDbCommand CMD=new OleDbCommand($"UPDATE KeshikHist SET Vis=False WHERE FromID={ID}", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }

                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, L_Keshik, T_Keshik, U_Reg, T_Reg, Fad, Vis) VALUES ('{RePNum}', '{ReTar}', '{ReLoc}', '{ReShi}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', {ID}, True)", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }

                    using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO Keshik (P_Num, Tarikh, L_Keshik, T_Keshik, U_Reg, T_Reg, Fad, Vis) VALUES ('{PNum}', '{Tar}', '{Loc}', '{Shi}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', {ReID}, True)", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }

                //MainForm.KarTableBox.Visible=false;
                //MainForm.KarTablePicture.Visible=false;
                if (int.Parse(Tar.Substring(5, 2)) == MainForm.PersianToday.Month())
                {
                    MonthCombo.SelectedIndex=0;
                }
                else
                {
                    MonthCombo.SelectedIndex=1;
                }
                RepPanel.Visible=false;
                KeshikEditForm_Load(null, null);
                ShowButton_Click(null, null);
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ReqRejButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("درخواست جابجایی کشیک رد می شود؟", "توجه", MessageBoxIcon.Asterisk, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"UPDATE KeshikHist SET Vis=False WHERE FromID={ID}", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }


                    RepPanel.Visible=false;
                    if (int.Parse(Tar.Substring(5, 2)) == MainForm.PersianToday.Month())
                    {
                        MonthCombo.SelectedIndex=0;
                    }
                    else
                    {
                        MonthCombo.SelectedIndex=1;
                    }
                    KeshikEditForm_Load(null, null);
                    ShowButton_Click(null, null);
                }
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    ID=Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value);
                    RePNum=DataGridView1.CurrentRow.Cells[3].Value.ToString();
                    ReID=Convert.ToInt32(DataGridView1.CurrentRow.Cells[7].Value);

                    using (OleDbCommand CMD=new OleDbCommand($"SELECT Tarikh, L_Keshik, T_Keshik FROM Keshik WHERE ID={ID}", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Tar=Reader["Tarikh"].ToString();
                            Loc=Reader["L_Keshik"].ToString();
                            Shi=Reader["T_Keshik"].ToString();
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand($"SELECT Tarikh, L_Keshik, T_Keshik FROM Keshik WHERE ID={ReID}", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ReTar=Reader["Tarikh"].ToString();
                            ReLoc=Reader["L_Keshik"].ToString();
                            ReShi=Reader["T_Keshik"].ToString();
                        }
                    }

                    KeshLabel1.Text=$"درخواست جابجایی کشیک از طرف {DataGridView1.CurrentRow.Cells[2].Value} را می پذیرید؟";
                }

                RepPanel.Visible=true;
            }
            catch (Exception ex)
            {
               MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(PersianCalendar.Text))
                {
                    bool Bol=false;
                    ReplaseLocalCombo.SelectedIndex=-1;
                    ReplaseLocalCombo.Items.Clear();

                    if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) != null)
                    {
                        if (ConvertClass.ShamsiToMiladi(PersianCalendar.Text) > DateTime.Today)
                        {
                            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                            {
                                StrConnec.Open();
                                using (OleDbCommand CMD=new OleDbCommand($"SELECT Sobh FROM Taghvim WHERE Tarikh='{PersianCalendar.Text}'", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        switch (Reader["Sobh"].ToString())
                                        {
                                            case "A":
                                                RepShift="C";
                                                break;
                                            case "B":
                                                RepShift="A";
                                                break;
                                            case "C":
                                                RepShift="B";
                                                break;
                                        }
                                    }
                                }
                            }
                            if (Shift == RepShift)
                            {
                                Bol=true;
                            }
                        }

                        if (Bol)
                        {
                            foreach (string Local in MainForm.Locals)
                            {
                                if (!string.IsNullOrEmpty(Local))
                                {
                                    ReplaseLocalCombo.Items.Add(Local);
                                }
                            }
                        }
                        else
                        {
                            MessageBoxFa.Show("تاریخ انتخاب شده صحیح نیست", "خطا", MessageBoxIcon.Error);
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
    }
}
