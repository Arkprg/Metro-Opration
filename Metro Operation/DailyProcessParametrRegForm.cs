using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class DailyProcessParametrRegForm
    {
        public DailyProcessParametrRegForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public bool ParameteNameExist()
        {
            try
            {
                bool Exis = false;
                using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD = new OleDbCommand("SELECT ID FROM DailyProcessProgram WHERE P_Name=@Name AND L_Num='" + LocalCombo.SelectedItem + "' AND Vis=True", StrConnec))
                    {
                        CMD.Parameters.AddWithValue("@Name", NameBox.Text.Trim());
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                Exis = true;
                            }
                        }
                    }
                }

                return Exis;
            }
            catch
            {
                return false;
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "مبدا پردازش را تعیین کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع پردازش را تعیین کنید");
                }
                else if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پردازش را تعیین کنید");
                }
                else if (!(int.TryParse(Shift12Rooz1Box.Text, out _) && int.TryParse(Shift12Shab1Box.Text, out _) && int.TryParse(Shift9Sobh1Box.Text, out _) && int.TryParse(Shift9Asr1Box.Text, out _) && int.TryParse(ShiftSetadi1Box.Text, out _)))
                {
                    MessageBoxFa.Show("تعداد راهبران شیفت تعیین شده صحیح نیست", "خطا", MessageBoxIcon.Error);
                }
                else if (!(int.TryParse(Rez12Rooz1Box.Text, out _) && int.TryParse(Rez12Shab1Box.Text, out _) && int.TryParse(Rez9Sobh1Box.Text, out _) && int.TryParse(Rez9Asr1Box.Text, out _) && int.TryParse(RezSetadi1Box.Text, out _)))
                {
                    MessageBoxFa.Show("تعداد رزرو های تعیین شده صحیح نیست", "خطا", MessageBoxIcon.Error);
                }
                else if (int.Parse(Shift12Rooz1Box.Text) + int.Parse(Shift12Shab1Box.Text) + int.Parse(Shift9Sobh1Box.Text) + int.Parse(Shift9Asr1Box.Text) + int.Parse(ShiftSetadi1Box.Text) == 0)
                {
                    MessageBoxFa.Show("تعداد راهبران شیفت تعیین شده صحیح نیست", "خطا", MessageBoxIcon.Error);
                    //ElseIf CInt(Rez12Rooz1Box.Text) + CInt(Rez12Shab1Box.Text) + CInt(Rez9Sobh1Box.Text) + CInt(Rez9Asr1Box.Text) + CInt(RezSetadi1Box.Text)=0 Then
                    //    MessageBoxFa.Show("تعداد رزرو های تعیین شده صحیح نیست", "خطا", MessageBoxIcon.Error)
                }
                else if (ParameteNameExist())
                {
                    ErrorShow(NameBox, "نام پردازش تکراری است");
                    NameBox.Focus();
                }
                else if (MessageBoxFa.Show("داده ها ذخیره شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyProcessProgram (P_Kind, P_Name, L_Num, Shift12R1, Shift12S1, Shift9S1, Shift9A1, ShiftSet1, Res12R1, Res12S1, Res9S1, Res9A1, ResSet1, Mem, U_Reg, T_Reg, Vis) VALUES ('{KindCombo.SelectedItem}', @Name, '{LocalCombo.SelectedItem}', {Shift12Rooz1Box.Text}, {Shift12Shab1Box.Text}, {Shift9Sobh1Box.Text}, {Shift9Asr1Box.Text}, {ShiftSetadi1Box.Text}, {Rez12Rooz1Box.Text}, {Rez12Shab1Box.Text}, {Rez9Sobh1Box.Text}, {Rez9Asr1Box.Text}, {RezSetadi1Box.Text}, @Mem, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Name", NameBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }

                    }
                    Enabled = true;

                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    KindCombo.SelectedItem = -1;
                    LocalCombo.SelectedItem = -1;
                    NameBox.Text = "";
                    Shift12Rooz1Box.Text = "";
                    Shift12Shab1Box.Text = "";
                    Shift9Sobh1Box.Text = "";
                    Shift9Asr1Box.Text = "";
                    ShiftSetadi1Box.Text = "";
                    Rez12Rooz1Box.Text = "";
                    Rez12Shab1Box.Text = "";
                    Rez9Sobh1Box.Text = "";
                    Rez9Asr1Box.Text = "";
                    RezSetadi1Box.Text = "";
                    MemBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                Enabled = true;
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shift1Label.Text = "تعداد راهبران " + LocalCombo.SelectedItem;
            Reserv1Label.Text = "تعداد رزرو " + LocalCombo.SelectedItem;
        }

    }
}
