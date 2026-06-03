using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class RetrainingClassRegForm
    {
        public RetrainingClassRegForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Fill()
        {
            try
            {
                int i=0;

                DataGridView1.Rows.Clear();
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    string QueStr="SELECT Person.Fname, Person.Family, Person.P_Num, Person.Line_Num, Retraining.Tarikh, Retraining.Kind, Retraining.L_Class, Retraining.T_Class FROM Retraining INNER JOIN Person ON Person.P_Num=Retraining.P_Num WHERE Retraining.Vis=True AND Retraining.Tarikh>='" + MainForm.PersianToday.Tarikh() + "'";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " And Person.Line_Num='" + AppState.UserLnum + "'";
                    }
                    QueStr += " ORDER BY Retraining.Tarikh, Retraining.Kind, Person.Family, Person.Fname";

                    using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                    {
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                i++;
                                DataGridView1.Rows.Add(i, Reader["Fname"], Reader["Family"], Reader["P_Num"], Reader["Tarikh"], Reader["Kind"], Reader["T_Class"] + " - " + Reader["L_Class"]);
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

        public void RetrainingClassRegForm_Load(object sender, EventArgs e)
        {
            try
            {
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
                    LocalCombo.SelectedIndex=0;
                }

                PostCombo.Items.Add("همه موارد");
                DataRow[] DRow=MainForm.PersonTable.Select("Vis=True", "P_Post");
                foreach (DataRow DtR in DRow)
                {
                    if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                    {
                        PostCombo.Items.Add(DtR["P_Post"].ToString());
                    }
                }

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT Kind FROM Retraining WHERE Vis=True ORDER BY Kind", StrConnec))
                    {
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ClassKindCombo.Items.Add(Reader["Kind"].ToString());
                            }
                        }

                    }


                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT L_Class FROM Retraining WHERE Vis=True ORDER BY L_Class", StrConnec))
                    {
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ClassLocalCombo.Items.Add(Reader["L_Class"].ToString());
                            }
                        }

                    }

                }


                PersianCalendar.Today_Click(null, null);
                Fill();
                PostCombo.SelectedIndex=0;
                LocalCombo.SelectedIndex=0;
                TimeCombo.SelectedIndex=0;
                ShiftCombo.SelectedIndex=0;
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
                PosetiveBox.Items.Clear();
                if (PostCombo.SelectedIndex < 0)
                {
                    ErrorShow(PostCombo, "پست سازمانی پرسنل را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا پرسنل را مشخص کنید");
                }
                else if (TimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(TimeCombo, "نوع شیفت پرسنل را مشخص کنید");
                }
                else if (ShiftCombo.SelectedIndex < 0)
                {
                    ErrorShow(ShiftCombo, "نام شیفت پرسنل را مشخص کنید");
                }
                else
                {

                    string CommandStr="Vis=True";
                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }
                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }
                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                    }
                    if ((string)ShiftCombo.SelectedItem != "همه موارد")
                    {
                        CommandStr += " AND Shift_name='" + ShiftCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(CommandStr);
                    foreach (DataRow DtR in DRow)
                    {
                        PosetiveBox.Items.Add(DtR["Family"].ToString() + " ، " + DtR["Fname"].ToString() + " (" + DtR["P_Num"].ToString() + ")");
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
                DateTime SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                if (PosetiveBox.Items.Count == 0)
                {
                    ErrorShow(ShowButton, "ابتدا نام پرسنل را جهت ثبت کلاس بازآموزی نمایش دهید");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (SelectDate < DateTime.Today)
                {
                    ErrorShow(PersianCalendar, "این تاریخ قابل ثبت نیست");
                }
                else if (ConvertClass.TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "ساعت شروع کلاس آموزشی صحیح نیست");
                }
                else if (ClassKindCombo.Text.Length == 0)
                {
                    ErrorShow(ClassKindCombo, "عنوان کلاس آموزشی صحیح نیست");
                }
                else if (ClassLocalCombo.Text.Length == 0)
                {
                    ErrorShow(ClassLocalCombo, "محل برگزاری کلاس آموزشی صحیح نیست");
                }
                else
                {

                    string PNum="";
                    string ShiftName="";
                    string ShiftLoc="";
                    bool OverTime=false;
                    int i;

                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();

                            for (i=0; i <= PosetiveBox.CheckedItems.Count - 1; i++)
                            {
                                ShiftName="";
                                ShiftLoc="";
                                PNum=PosetiveBox.CheckedItems[i].ToString().Substring(PosetiveBox.CheckedItems[i].ToString().IndexOf("(") + 1, Convert.ToInt32(Convert.ToInt32(PosetiveBox.CheckedItems[i].ToString().Length - (PosetiveBox.CheckedItems[i].ToString().IndexOf("(") + 1)) - 1));

                                DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + PNum + "'");
                                foreach (DataRow DtR in DRow)
                                {
                                    ShiftName=DtR["Shift_name"].ToString();
                                    ShiftLoc=DtR["Shift_Loc"].ToString();
                                }

                                using (OleDbCommand CMD=new OleDbCommand("SELECT Sobh, Asr FROM Taghvim WHERE Tarikh='" + PersianCalendar.Text + "' ", StrConnec))
                                using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                    {
                                        if (ShiftName != Reader["Sobh"].ToString() && ShiftName != Reader["Asr"].ToString())
                                        {
                                            OverTime=true;
                                        }
                                    }
                                }

                                if (OverTime)
                                {
                                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Keshik (P_Num, Tarikh, T_Keshik, L_Keshik, U_Reg, T_Reg, Vis) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', 'کلاس آموزش', '" + ShiftLoc + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                                    {
                                        CMD.ExecuteNonQuery();
                                    }
                                }

                                using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Retraining (P_NUM, Tarikh, Kind, L_Class, T_Class, U_Reg, T_Reg, Vis) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', @Name, @Lca, '" + TimeBox.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                                {
                                    CMD.Parameters.AddWithValue("@Name", ClassKindCombo.Text.Trim());
                                    CMD.Parameters.AddWithValue("@Lca", ClassLocalCombo.Text.Trim());
                                    CMD.ExecuteNonQuery();
                                }
                            }
                        }


                        for (i=0; i <= PosetiveBox.Items.Count - 1; i++)
                        {
                            PosetiveBox.SetItemChecked(i, false);
                        }
                        AllPosetCheck.Checked=false;
                        Fill();

                        wait.Close();
                    }
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void AllPosetCheck_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            if (AllPosetCheck.CheckState == CheckState.Checked)
            {
                for (i=0; i <= PosetiveBox.Items.Count - 1; i++)
                {
                    PosetiveBox.SetItemChecked(i, true);
                }
            }
            if (AllPosetCheck.CheckState == CheckState.Unchecked)
            {
                for (i=0; i <= PosetiveBox.Items.Count - 1; i++)
                {
                    PosetiveBox.SetItemChecked(i, false);
                }
            }
        }

        public void PosetiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PosetiveBox.CheckedItems.Count == 0)
            {
                AllPosetCheck.Checked=false;
            }
            else if (PosetiveBox.CheckedItems.Count == PosetiveBox.Items.Count)
            {
                AllPosetCheck.CheckState=CheckState.Checked;
            }
            else
            {
                AllPosetCheck.CheckState=CheckState.Indeterminate;
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PostCombo.SelectedIndex=-1;
                if (LocalCombo.SelectedIndex >= 0)
                {
                    PostCombo.Items.Clear();
                    PostCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "P_Post");
                    foreach (DataRow DtR in DRow)
                    {
                        if (PostCombo.Items.IndexOf(DtR["P_Post"].ToString()) < 0)
                        {
                            PostCombo.Items.Add(DtR["P_Post"].ToString());
                        }
                    }
                    PostCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void PostCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TimeCombo.SelectedIndex=-1;
                if (PostCombo.SelectedIndex >= 0)
                {
                    TimeCombo.Items.Clear();
                    TimeCombo.Items.Add("همه موارد");

                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_Time");
                    foreach (DataRow DtR in DRow)
                    {
                        if (TimeCombo.Items.IndexOf(DtR["Shift_Time"].ToString()) < 0)
                        {
                            TimeCombo.Items.Add(DtR["Shift_Time"].ToString());
                        }
                    }
                    TimeCombo.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void TimeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ShiftCombo.SelectedIndex=-1;
                if (TimeCombo.SelectedIndex >= 0)
                {
                    ShiftCombo.Items.Clear();
                    ShiftCombo.Items.Add("همه موارد");
                    string QueStr="Vis=True";
                    if (AppState.UserLevel > 1)
                    {
                        QueStr += " AND Line_Num='" + AppState.UserLnum + "'";
                    }

                    if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                    {
                        QueStr += " AND P_Staff='" + AppState.UserStaff + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Shift_name");
                    foreach (DataRow DtR in DRow)
                    {
                        if (ShiftCombo.Items.IndexOf(DtR["Shift_name"].ToString()) < 0)
                        {
                            ShiftCombo.Items.Add(DtR["Shift_name"].ToString());
                        }
                    }
                    ShiftCombo.SelectedIndex=0;
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
