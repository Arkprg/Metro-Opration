using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class OverTimeGroupForm
    {
        public OverTimeGroupForm()
        {
            InitializeComponent();
        }

        private bool Reg=false;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        private bool OverTimeChecker(string PNum, OleDbConnection StrConnec) //, OverTime As Double
        {
            try
            {
                bool Reslt=false;
                if (AppState.UserLevel > 4)
                {
                    double TopOver=0;
                    double OverTime=0;
                    TopOver=0;
                    OverTime=0;

                    using (OleDbCommand CMD=new OleDbCommand("SELECT MonthTime FROM ShKar WHERE Tarikh='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            TopOver=TimeToDouble(Reader["MonthTime"].ToString());
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT NexMo, Tota, TotaJom FROM TotaMonAdv WHERE P_Num='" + PNum + "' AND Maah='" + PersianCalendar.Text.Substring(0, 7) + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            OverTime += TimeToDouble(Reader["NexMo"].ToString()) + TimeToDouble(Reader["Tota"].ToString()) + TimeToDouble(Reader["TotaJom"].ToString());
                        }
                    }

                    if (TopOver > OverTime + TimeToDouble(TimeBox.Text))
                    {
                        Reslt=true;
                    }
                    else
                    {
                        Reslt=true;
                    }
                }
                else
                {
                    Reslt=true;
                }

                return Reslt;

            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                return false;
                //				Close();
            }
        }

        public void ManageOverTimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Reg)
            {
                OptimizationForm ShowForm=new OptimizationForm();
                ShowForm.Show(Owner); // محاسبات قدیم
            }
        }

        public void OverTimeGroupForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0602");
        }

        public void ManageOverTimeForm_Load(object sender, EventArgs e)
        {
            LocalCombo.Items.Clear();

            if (AppState.UserLevel == 0)
            {
                KindOverCombo.Items.Add("شیفت");
            }
            if (AppState.UserLevel < 6)
            {
                KindOverCombo.Items.Add("تشویقی");
                KindOverCombo.Items.Add("طب کار");
                LocalCombo.Items.Add("همه موارد");
            }

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

            PersianCalendar.Today_Click(null, null);

            //PostCombo.SelectedIndex=0
            //TimeCombo.SelectedIndex=0
            //ShiftCombo.SelectedIndex=0
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate=ShamsiToMiladi(PersianCalendar.Text);

                if (PersonListBox.Items.Count == 0)
                {
                    ErrorShow(ShowButton, "ابتدا نام پرسنل جهت ثبت اضافه کار را نمایش دهید");
                }
                else if (AllPosetCheck.Checked == false)
                {
                    ErrorShow(PersonListBox, "انتخاب حداقل یک گزینه اجباری است");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "مدت اضافه کاری صحیح نیست");
                }
                else if (KindOverCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindOverCombo, "عنوان اضافه کاری صحیح نیست");
                }
                else if (MemoBox.Text.Length < 9)
                {
                    ErrorShow(MemoBox, "توضیحات اضافه کاری صحیح نیست");
                }
                else
                {
                    Enabled=false;
                    using (WaitForm wait=new WaitForm())
                    {
                        wait.Show();
                        wait.Refresh();

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            string PNum="";
                            int i;
                            for (i=0; i <= PersonListBox.CheckedItems.Count - 1; i++)
                            {
                                PNum=PersonListBox.CheckedItems[i].ToString().Substring(PersonListBox.CheckedItems[i].ToString().IndexOf("(") + 1, Convert.ToInt32(Convert.ToInt32(PersonListBox.CheckedItems[i].ToString().Length - (PersonListBox.CheckedItems[i].ToString().IndexOf("(") + 1)) - 1));

                                if (OverTimeChecker(PNum, StrConnec))
                                {
                                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Ezafeh (P_NUM, Tarikh, E_Time, E_Kind, E_Mem, U_Reg, T_Reg, Vis) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + TimeBox.Text + "', '" + KindOverCombo.SelectedItem + "', @Mem,'" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)", StrConnec))
                                    {
                                        CMD.Parameters.AddWithValue("@Mem", MemoBox.Text.Trim() + "**");
                                        CMD.ExecuteNonQuery();

                                    } //OptimizationForm.PersoOptim(PNum, PersianCalendar.Text)
                                }
                                else
                                {
                                    MessageBoxFa.Show("اضافه کار " + PersonListBox.CheckedItems[i].ToString().Substring(0, PersonListBox.CheckedItems[i].ToString().IndexOf("(") + 1) + " بیشتر از سقف تعین شده است \n  اضافه کار برای ایشان ثبت نمی شود.", "خطا", MessageBoxIcon.Error);
                                }
                            }
                        }


                        AllPosetCheck.CheckState=CheckState.Unchecked;
                        Enabled=true;
                        wait.Close();
                    }
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Reg=true;

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

        public void AllPosetCheck_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            if (AllPosetCheck.CheckState == CheckState.Checked)
            {
                for (i=0; i <= PersonListBox.Items.Count - 1; i++)
                {
                    PersonListBox.SetItemChecked(i, true);
                }
            }
            if (AllPosetCheck.CheckState == CheckState.Unchecked)
            {
                for (i=0; i <= PersonListBox.Items.Count - 1; i++)
                {
                    PersonListBox.SetItemChecked(i, false);
                }
                CountLabel.Text="0";
            }
        }

        public void PosetiveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonListBox.CheckedItems.Count == 0)
            {
                AllPosetCheck.Checked=false;
            }
            else if (PersonListBox.CheckedItems.Count == PersonListBox.Items.Count)
            {
                AllPosetCheck.CheckState=CheckState.Checked;
            }
            else
            {
                AllPosetCheck.CheckState=CheckState.Indeterminate;
            }
            CountLabel.Text=PersonListBox.CheckedItems.Count.ToString();
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                PersonListBox.Items.Clear();
                AllPosetCheck.Checked=false;
                CountLabel.Text="0";

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
                    string QueStr="Vis=True";
                    if ((string)PostCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND P_Post='" + PostCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)LocalCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Loc='" + LocalCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)TimeCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_Time='" + TimeCombo.SelectedItem.ToString() + "'";
                    }

                    if ((string)ShiftCombo.SelectedItem != "همه موارد")
                    {
                        QueStr += " AND Shift_name='" + ShiftCombo.SelectedItem.ToString() + "'";
                    }

                    DataRow[] DRow=MainForm.PersonTable.Select(QueStr, "Family");
                    foreach (DataRow DtR in DRow)
                    {
                        PersonListBox.Items.Add(DtR["Family"].ToString() + " ، " + DtR["Fname"].ToString() + " (" + DtR["P_Num"].ToString() + ")");
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

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonListBox.Items.Clear();
            AllPosetCheck.Checked=false;
            CountLabel.Text="0";
        }
    }
}
