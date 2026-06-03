using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class OvertimeLimitForm
    {
        public OvertimeLimitForm()
        {
            InitializeComponent();
        }


        private string PName;
        private string PFamily;
        private string PNum;
        //private string PTime;
        //private string PPost;
        //private readonly string EzTim;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Fill()
        {
            try
            {
                DataGridView1.Rows.Clear();
                int i=0;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Person.Fname, Person.Family, Person.P_Num, Person.OverTime, TotaMonAdv.Tota, TotaMonAdv.TotaJom, TotaMonAdv.NexMo, TotaMonAdv.MaxEza FROM TotaMonAdv INNER JOIN Person ON Person.P_Num=TotaMonAdv.P_Num WHERE TotaMonAdv.Maah='" + MainForm.PersianToday.Tarikh().Substring(0, 7) + "' AND (TotaMonAdv.MaxEza<>'' OR NOT Person.OverTime) ORDER BY Person.Family, Person.Fname", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            DataGridView1.Rows.Add(i + 1, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), ConvertClass.DoubleToTime(ConvertClass.TimeToDouble(Reader["Tota"].ToString()) + ConvertClass.TimeToDouble(Reader["TotaJom"].ToString()) + ConvertClass.TimeToDouble(Reader["NexMo"].ToString())), Reader["MaxEza"].ToString(), "");
                            if ((bool)Reader["OverTime"])
                            {
                                DataGridView1.Rows[i].Cells[6].Value="دارد";
                            }
                            else
                            {
                                DataGridView1.Rows[i].Cells[6].Value="ندارد";
                            }
                            i++;
                        }
                    }

                    if (DataGridView1.RowCount > 0)
                    {
                        DataGridView1.CurrentRow.Selected=false;
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

        public void Button7_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                //PTime=PersonalSelectForm.PTime;
                //PPost=PersonalSelectForm.PPost;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Tota, TotaJom, NexMo, MaxEza FROM TotaMon WHERE Maah='" + MainForm.PersianToday.Tarikh().Substring(0, 7) + "' AND P_Num='" + PNum + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            OverTimeBox.Text=ConvertClass.DoubleToTime(ConvertClass.TimeToDouble(Reader["Tota"].ToString()) + ConvertClass.TimeToDouble(Reader["TotaJom"].ToString()) + ConvertClass.TimeToDouble(Reader["NexMo"].ToString()));
                            if (Reader["MaxEza"].ToString() != "")
                            {
                                LimitBox.Text=Reader["MaxEza"].ToString();
                            }
                            else
                            {
                                LimitBox.Text="120:00";
                            }
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT OverTime FROM Person WHERE P_Num='" + PNum + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if ((bool)Reader["OverTime"])
                            {
                                LiceCombo.SelectedIndex=0;
                            }
                            else
                            {
                                LiceCombo.SelectedIndex=1;
                            }
                        }
                    }
                }
            }
        }

        public void OvertimeLimitFor_FormClosing(object sender, FormClosingEventArgs e)
        {
            OptimizationForm ShowForm=new OptimizationForm();
            ShowForm.Show(this);
        }

        public void OvertimeLimitForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0604");
        }

        public void Form39_Load(object sender, EventArgs e)
        {
            if (MainForm.PersianToday.Day() < 7)
            {
                LastMonthCheck.Enabled=true;
            }
            else
            {
                LastMonthCheck.Enabled=false;
            }
            Fill();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, " نام پرسنل را انتخاب کنید");
                }
                else if (!(ConvertClass.TimeToDouble(OverTimeBox.Text) >= 0 && ConvertClass.TimeToDouble(OverTimeBox.Text) <= 120))
                {
                    ErrorShow(OverTimeBox, "سقف اضافه کاری صحیح نیست");
                }
                else if (LiceCombo.SelectedIndex < 0)
                {
                    ErrorShow(LiceCombo, "مجوز اضافه کاری صحیح نیست");
                }
                else
                {

                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        string QueStr="UPDATE TotaMon SET MaxEza='";
                        if (LimitBox.Text != "120:00")
                        {
                            QueStr += LimitBox.Text;
                        }

                        QueStr += "' WHERE P_Num='" + PNum + "' AND Maah='" + MainForm.PersianToday.Tarikh().Substring(0, 7) + "'";

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Person SET OverTime=" + Convert.ToBoolean(LiceCombo.SelectedIndex) + " WHERE P_Num='" + PNum + "'", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }


                    NameBox.Text="";
                    OverTimeBox.Text="";
                    LimitBox.Text="";
                    LiceCombo.SelectedIndex=-1;
                    Fill();
                    Enabled=true;
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

        public void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //If LastMonthCheck.Checked Then
            //    mainform.PersianToday.AddMonth(-1)
            //Else
            //    mainform.PersianToday.DaysInMonth(Today)
            //End If
            //MainForm.Focus()
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
