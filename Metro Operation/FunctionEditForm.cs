using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class FunctionEditForm
    {
        public FunctionEditForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string LAmal;
        private int FI=-1;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Dis()
        {
            LevelCombo.SelectedIndex=-1;
            KindCombo.SelectedIndex=-1;
            MemBox.Text="";
            NameButton.Image=Properties.Resources.user;
            RegButton.Enabled=false;
            DelButton.Enabled=false;
        }

        public void Form14_Load(object sender, EventArgs e)
        {
            Dis();
            PersianCalendar.Today_Click(null, null);
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate=ShamsiToMiladi(PersianCalendar.Text);

                Dis();
                DataGridView1.Rows.Clear();
                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پرسنل را انتخاب کنید");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ را انتخاب کنید");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else
                {
                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        string StrQuer="Select OnvAmal, Amal, Mem, ID From Amal WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND (OnvAmal='مثبت' OR OnvAmal='منفی') AND Vis=True";
                        if (AppState.UserLevel > 5 || AppState.UserLevel > 15)
                        {
                            StrQuer += " AND U_Reg='" + AppState.UserName + "'";
                        }

                        using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                        {
                            int i=1;
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    DataGridView1.Rows.Add(i, Reader["OnvAmal"].ToString(), Reader["Amal"].ToString(), Reader["Mem"].ToString(), Reader["ID"].ToString());
                                }
                            }

                            i++;
                        }
                    }


                    Enabled=true;
                    if (DataGridView1.Rows.Count == 0)
                    {
                        MessageBoxFa.Show(" شما برای این شخص امتیازی ثبت نکرده اید ", "خطا", MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridView1.Rows[0].Selected=false;
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

        public void NameButton_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            Dis();
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PName=PersonalSelectForm.PName;
                PFamily=PersonalSelectForm.PFamily;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }

        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LevelCombo.SelectedIndex < -1)
                {
                    ErrorShow(LevelCombo, "نوع امتیاز را مشخص کنید ");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "عنوان امتیاز را تعین کنید");
                }
                else
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Amal SET Vis=False WHERE ID=" + FI.ToString(), StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        string StrQuer="INSERT INTO Amal (P_Num, Tarikh, OnvAmal, Amal, Mem, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + LevelCombo.SelectedItem + "', '" + KindCombo.SelectedItem + "', @Mem, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + FI.ToString() + ")";
                        using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }
                    }

                    NameBox.Text="";
                    PersianCalendar.Text="";
                    DataGridView1.Rows.Clear();
                    Dis();
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

        public void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show(" مورد انتخاب شده حذف شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Amal SET Vis=False WHERE ID=" + FI, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Amal (Tarikh, P_Num, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PersianCalendar.Text + "', '" + PNum + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, -" + FI.ToString() + ")", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    Close();
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

        public void PersianCalendar_TextChanged(object sender, EventArgs e)
        {
            Dis();
            DataGridView1.Rows.Clear();
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.CurrentRow.Cells[2].Value.ToString() == "حذف مرخصی بعد از پردازش لوحه" && AppState.UserLevel > 5)
            {
                MessageBoxFa.Show(" شما مجوز ویرایش این امتیاز را ندارید ", "خطا", MessageBoxIcon.Error);
            }
            else
            {
                Dis();
                FI=int.Parse(DataGridView1.CurrentRow.Cells[4].Value.ToString());
                LAmal=DataGridView1.CurrentRow.Cells[1].Value.ToString();

                if (LAmal == "مثبت")
                {
                    LevelCombo.SelectedIndex=0;
                }
                else if (LAmal == "منفی")
                {
                    LevelCombo.SelectedIndex=1;
                }

                KindCombo.SelectedItem=DataGridView1.CurrentRow.Cells[2].Value;
                MemBox.Text=DataGridView1.CurrentRow.Cells[3].Value.ToString();
                RegButton.Enabled=true;
                DelButton.Enabled=true;
            }
        }

        private void PersianCalendar_Enter(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            Dis();
        }

        public void FunctionEditForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0108");
        }

        private void LevelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            KindCombo.Text="";
            KindCombo.SelectedIndex=-1;
            KindCombo.Items.Clear();

            if (LevelCombo.SelectedIndex == 0)
            {
                KindCombo.Items.Add("ارائه گزارش های فنی مناسب");
                KindCombo.Items.Add("اطلاع رسانی به موقع معایب قطار");
                KindCombo.Items.Add("حضور در محل کار در شرایط حاد و انجام حرکت خارج از شیفت کاری");
                KindCombo.Items.Add("رفع معایب قطار در حداقل زمان (نظر کارشناسی)");
                KindCombo.Items.Add("هماهنگی در شرایط خاص");
                KindCombo.Items.Add("امتیاز مثبت (سایر)");
            }
            else
            {
                KindCombo.Items.Add("برخورد نامناسب با مسئولین و سایر همکاران");
                KindCombo.Items.Add("تعویض کشیک پس از پردازش لوحه");
                KindCombo.Items.Add("جابجایی حرکت بدون هماهنگی با مسئول وقت");
                KindCombo.Items.Add("حضور هر دو راهبر در لکوموتیو Master");
                KindCombo.Items.Add("خروج از محل کار بدون هماهنگی با مسئول وقت ");
                KindCombo.Items.Add("عدم ارائه گزارش تاخیر");
                KindCombo.Items.Add("عدم استفاده از لباس فرم");
                KindCombo.Items.Add("عدم اعلام حضور در محل کار به مسئول وقت");
                KindCombo.Items.Add("عدم تحویل و تحول به موقع قطار");
                KindCombo.Items.Add("عدم حضور در محل کار (در زمان اضافه کار)");
                KindCombo.Items.Add("کشیدن سیگار در محل کار");
                KindCombo.Items.Add("نرسیدن به حرکت");
                KindCombo.Items.Add("امتیاز منفی (سایر)");
            }
            KindCombo.Focus();
        }
    }
}
