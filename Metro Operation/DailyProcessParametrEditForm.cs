using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class DailyProcessParametrEditForm
    {
        public DailyProcessParametrEditForm()
        {
            InitializeComponent();
        }


        private string ID;
        private string FID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clear()
        {
            ID = "";
            FID = "";
            KindCombo.SelectedIndex = -1;
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
            Panel2.Enabled = false;
            RegButton.Enabled = false;
            DelButton.Enabled = false;
        }

        public bool ParameteNameExist()
        {
            bool Exis = false;

            using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD = new OleDbCommand($"SELECT ID FROM DailyProcessProgram WHERE P_Name='{NameBox.Text}' AND L_Num='{AppState.UserLnum}' AND Vis=True", StrConnec))
                using (OleDbDataReader Reader = CMD.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        Exis = true;
                    }
                }
            }


            return Exis;
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFa.Show("داده ها حذف شود؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Enabled = false;
                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand($"UPDATE DailyProcessProgram Set Vis=False WHERE ID={ID}", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyProcessProgram (U_Reg, T_Reg, Vis, Fad) VALUES ('{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', False, -{ID})", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }


                    SearchKindCombo.SelectedIndex = -1;
                    Enabled = true;
                    MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    //Me.Close()
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

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا پردازش را تعیین کنید");
                    LocalCombo.Focus();
                }
                else if (SearchKindCombo.SelectedIndex < 0)
                {
                    ErrorShow(SearchKindCombo, "نوع پردازش را تعیین کنید");
                    SearchKindCombo.Focus();
                }
                else if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام پردازش را تعیین کنید");
                    NameBox.Focus();
                }
                else if (int.Parse(Shift12Rooz1Box.Text) + int.Parse(Shift12Shab1Box.Text) + int.Parse(Shift9Sobh1Box.Text) + int.Parse(Shift9Asr1Box.Text) + int.Parse(ShiftSetadi1Box.Text) == 0)
                {
                    MessageBoxFa.Show("تعداد راهبران شیفت تعیین شده صحیح نیست", "خطا", MessageBoxIcon.Error);
                    //ElseIf CInt(Rez12Rooz1Box.Text) + CInt(Rez12Shab1Box.Text) + CInt(Rez9Sobh1Box.Text) + CInt(Rez9Asr1Box.Text) + CInt(RezSetadi1Box.Text)=0 Then
                    //    MessageBoxFa.Show("تعداد رزرو های تعیین شده صحیح نیست", "خطا", MessageBoxIcon.Error)
                }
                else if ((string)SearchNameCombo.SelectedItem != NameBox.Text && ParameteNameExist())
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

                        using (OleDbCommand CMD = new OleDbCommand($"INSERT INTO DailyProcessProgram (P_Kind, P_Name, L_Num, Shift12R1, Shift12S1, Shift9S1, Shift9A1, ShiftSet1, Res12R1, Res12S1, Res9S1, Res9A1, ResSet1, Mem, U_Reg, T_Reg, Vis, Fad) VALUES ('{SearchKindCombo.SelectedItem}', @Name, '{LocalCombo.SelectedItem}', {Shift12Rooz1Box.Text}, {Shift12Shab1Box.Text}, {Shift9Sobh1Box.Text}, {Shift9Asr1Box.Text}, {ShiftSetadi1Box.Text}, {Rez12Rooz1Box.Text}, {Rez12Shab1Box.Text}, {Rez9Sobh1Box.Text}, {Rez9Asr1Box.Text}, {RezSetadi1Box.Text}, @Mem, '{AppState.UserName}', '{MainForm.PersianToday.Tarikh()} {DateTime.Now:HH:mm:ss}', True, {ID})", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Name", NameBox.Text.Trim());
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }


                        using (OleDbCommand CMD = new OleDbCommand($"UPDATE DailyProcessProgram Set Vis=False WHERE ID={ID}", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    SearchNameCombo.SelectedIndex = -1;
                    SearchNameCombo.Items.Clear();
                    SearchKindCombo.SelectedIndex = -1;
                    LocalCombo.SelectedIndex = -1;
                    Clear();
                    Enabled = true;
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

        public void SearchNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clear();

                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا پردازش را تعیین کنید");
                    LocalCombo.Focus();
                }
                else if (SearchKindCombo.SelectedIndex < 0)
                {
                    ErrorShow(SearchKindCombo, "نوع پردازش را تعیین کنید");
                    SearchKindCombo.Focus();
                }
                else if (SearchNameCombo.SelectedIndex >= 0)
                {
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand($"SELECT * FROM DailyProcessProgram WHERE Vis=True AND P_Kind='{SearchKindCombo.SelectedItem}' AND P_Name='{SearchNameCombo.SelectedItem}' AND L_Num='{LocalCombo.SelectedItem}'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ID = Reader["ID"].ToString();
                                FID = Reader["Fad"].ToString();
                                KindCombo.SelectedItem = Reader["P_Kind"].ToString();
                                NameBox.Text = Reader["P_Name"].ToString();
                                Shift12Rooz1Box.Text = Reader["Shift12R1"].ToString();
                                Shift12Shab1Box.Text = Reader["Shift12S1"].ToString();
                                Shift9Sobh1Box.Text = Reader["Shift9S1"].ToString();
                                Shift9Asr1Box.Text = Reader["Shift9A1"].ToString();
                                ShiftSetadi1Box.Text = Reader["ShiftSet1"].ToString();
                                Rez12Rooz1Box.Text = Reader["Res12R1"].ToString();
                                Rez12Shab1Box.Text = Reader["Res12S1"].ToString();
                                Rez9Sobh1Box.Text = Reader["Res9S1"].ToString();
                                Rez9Asr1Box.Text = Reader["Res9A1"].ToString();
                                RezSetadi1Box.Text = Reader["ResSet1"].ToString();
                                MemBox.Text = Reader["Mem"].ToString();
                                Panel2.Enabled = true;
                                RegButton.Enabled = true;
                                DelButton.Enabled = true;
                            }
                        }
                    }

                    Shift1Label.Text = $"تعداد راهبران {LocalCombo.SelectedItem}";
                    Reserv1Label.Text = $"تعداد رزرو {LocalCombo.SelectedItem}";
                    Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void SearchKindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SearchNameCombo.SelectedIndex = -1;
                SearchNameCombo.Items.Clear();
                Clear();

                if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا پردازش را تعیین کنید");
                    LocalCombo.Focus();
                }
                else if (SearchKindCombo.SelectedIndex >= 0)
                {
                    Enabled = false;

                    using (OleDbConnection StrConnec = new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD = new OleDbCommand($"SELECT P_Name FROM DailyProcessProgram WHERE Vis=True AND P_Kind='{SearchKindCombo.SelectedItem}' AND L_Num='{LocalCombo.SelectedItem}'", StrConnec))
                        using (OleDbDataReader Reader = CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                SearchNameCombo.Items.Add(Reader["P_Name"].ToString());
                            }
                        }
                    }

                    Enabled = true;
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
            SearchNameCombo.SelectedIndex = -1;
            SearchNameCombo.Items.Clear();
            SearchKindCombo.SelectedIndex = -1;
            Clear();
        }
    }
}
