using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class NavganEditForm
    {
        public NavganEditForm()
        {
            InitializeComponent();
        }

        private int ID;
        private int Fad;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public dynamic LocoFail(string LocoNum)
        {
            bool Find=false;

            if (LocoNum.Replace(" ", "").Length < 2)
            {
                return false;
            }

            if (int.TryParse(LocoNum, out _))
            {
                if (int.Parse(LocoNum) > 0 && int.Parse(LocoNum) < 63)
                {
                    Find=true;
                }
            }
            else
            {
                if (LocoNum.Substring(0, 1) == "H" && int.Parse(LocoNum.Substring(1, 1)) > 0 && int.Parse(LocoNum.Substring(1, 1)) < 5)
                {
                    Find=true;
                }
            }
            return Find;
        }

        public dynamic LocoChecker(string LocoNum)
        {
            bool Find=false;
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Navgan WHERE Vis=True AND ( Loco1='" + LocoNum + "' OR Loco2='" + LocoNum + "') AND ID<>" + ID, StrConnec))
                using (OleDbDataReader Reader=CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Find=true;
                    }
                }
            }

            return Find;
        }

        public dynamic WagonFail(string WagoNum)
        {
            bool Find=false;

            if (WagoNum.Replace(" ", "").Length < 3)
            {
                return false;
            }

            if (int.TryParse(WagoNum, out _))
            {
                if (int.Parse(WagoNum) > 0 && int.Parse(WagoNum) < 250)
                {
                    Find=true;
                }
            }
            else
            {
                if (WagoNum.Substring(0, 1) == "H" && int.Parse(WagoNum.Substring(1, 2)) > 0 && int.Parse(WagoNum.Substring(1, 2)) < 15)
                {
                    Find=true;
                }
            }
            return Find;
        }

        public dynamic WagonChecker(string WagonNum)
        {
            bool Find=false;
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Navgan WHERE Vis=True AND ( Wag1='" + WagonNum + "' OR Wag2='" + WagonNum + "' OR Wag3='" + WagonNum + "' OR Wag4='" + WagonNum + "' OR Wag5='" + WagonNum + "' OR Wag6='" + WagonNum + "' OR Wag7='" + WagonNum + "' OR Wag8='" + WagonNum + "' OR Wag9='" + WagonNum + "') AND ID<>" + ID, StrConnec))
                using (OleDbDataReader Reader=CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Find=true;
                    }
                }
            }

            return Find;
        }

        public void Clean()
        {
            ID=0;
            Loco1Box.Text="";
            Loco2Box.Text="";
            Wag1Box.Text="";
            Wag2Box.Text="";
            Wag3Box.Text="";
            Wag4Box.Text="";
            Wag5Box.Text="";
            Wag6Box.Text="";
            Wag7Box.Text="";
            Wag8Box.Text="";
            Wag9Box.Text="";
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clean();

                if (NumBox.Text.Length == 0)
                {
                    ErrorShow(NumBox, "شماره " + KindCombo.SelectedItem + " را مشخص کنید");
                }
                else
                {

                    Enabled=false;

                    ID=0;
                    Fad=0;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        string QueStr="SELECT * FROM Navgan WHERE Vis=True";
                        if ((string)KindCombo.SelectedItem == "لکوموتیو")
                        {
                            QueStr += " AND ( Loco1='" + NumBox.Text + "' OR Loco2='" + NumBox.Text + "')";
                        }
                        else
                        {
                            QueStr += " AND ( Wag1='" + NumBox.Text + "' OR Wag2='" + NumBox.Text + "' OR Wag3='" + NumBox.Text + "' OR Wag4='" + NumBox.Text + "' OR Wag5='" + NumBox.Text + "' OR Wag6='" + NumBox.Text + "' OR Wag7='" + NumBox.Text + "' OR Wag8='" + NumBox.Text + "' OR Wag9='" + NumBox.Text + "')";
                        }

                        using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                ID=Convert.ToInt32(Reader["ID"]);
                                Loco1Box.Text=Reader["Loco1"].ToString();
                                Loco2Box.Text=Reader["Loco2"].ToString();
                                Wag1Box.Text=Reader["Wag1"].ToString();
                                Wag2Box.Text=Reader["Wag2"].ToString();
                                Wag3Box.Text=Reader["Wag3"].ToString();
                                Wag4Box.Text=Reader["Wag4"].ToString();
                                Wag5Box.Text=Reader["Wag5"].ToString();
                                Wag6Box.Text=Reader["Wag6"].ToString();
                                Wag7Box.Text=Reader["Wag7"].ToString();
                                Wag8Box.Text=Reader["Wag8"].ToString();
                                Wag9Box.Text=Reader["Wag9"].ToString();
                                if (Reader["Fad"].ToString() != "")
                                {
                                    Fad=Convert.ToInt32(Reader["Fad"]);
                                }
                            }
                        }
                    }

                    Enabled=true;
                    if (ID == 0)
                    {
                        MessageBoxFa.Show(" داده ای ثبت نشده است !", "توجه", MessageBoxIcon.Warning);
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
                Enabled=false;

                if (ID == 0)
                {
                    ErrorShow(PictureBox1, "قطار را مشخص کنید");
                }
                else if (!LocoFail(Loco1Box.Text))
                {
                    ErrorShow(Loco1Box, "شماره لوکو را مشخص کنید");
                }
                else if (!LocoFail(Loco2Box.Text))
                {
                    ErrorShow(Loco2Box, "شماره لوکو را مشخص کنید");
                }
                else if (!WagonFail(Wag1Box.Text))
                {
                    ErrorShow(Wag1Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag2Box.Text))
                {
                    ErrorShow(Wag2Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag3Box.Text))
                {
                    ErrorShow(Wag3Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag4Box.Text))
                {
                    ErrorShow(Wag4Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag5Box.Text))
                {
                    ErrorShow(Wag5Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag6Box.Text))
                {
                    ErrorShow(Wag6Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag7Box.Text))
                {
                    ErrorShow(Wag7Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag8Box.Text))
                {
                    ErrorShow(Wag8Box, "شماره واگن را مشخص کنید");
                }
                else if (!WagonFail(Wag9Box.Text))
                {
                    ErrorShow(Wag9Box, "شماره واگن را مشخص کنید");
                }
                else if (Loco1Box.Text == Loco2Box.Text)
                {
                    ErrorShow(Loco1Box, "شماره لوکو مشابه است");
                    ErrorShow(Loco2Box, "شماره لوکو مشابه است");
                }
                else if (LocoChecker(Loco1Box.Text))
                {
                    ErrorShow(Loco1Box, "لوکو قبلا ثبت شده است");
                }
                else if (LocoChecker(Loco2Box.Text))
                {
                    ErrorShow(Loco2Box, "لوکو قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag1Box.Text))
                {
                    ErrorShow(Wag1Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag2Box.Text))
                {
                    ErrorShow(Wag2Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag3Box.Text))
                {
                    ErrorShow(Wag3Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag4Box.Text))
                {
                    ErrorShow(Wag4Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag5Box.Text))
                {
                    ErrorShow(Wag5Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag6Box.Text))
                {
                    ErrorShow(Wag6Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag7Box.Text))
                {
                    ErrorShow(Wag7Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag8Box.Text))
                {
                    ErrorShow(Wag8Box, "واگن قبلا ثبت شده است");
                }
                else if (WagonChecker(Wag9Box.Text))
                {
                    ErrorShow(Wag9Box, "واگن قبلا ثبت شده است");
                }
                else
                {
                    string[] CabNum=new string[] { Wag1Box.Text, Wag2Box.Text, Wag3Box.Text, Wag4Box.Text, Wag5Box.Text, Wag6Box.Text, Wag7Box.Text, Wag8Box.Text, Wag9Box.Text };
                    int i;
                    int j=0;
                    for (i=0; i <= 7; i++)
                    {
                        for (j=i; j <= 7; j++)
                        {
                            if (CabNum[i] != "" && CabNum[i] == CabNum[j + 1])
                            {
                                ErrorShow(PictureBox1, "شماره واگن ها تکراری است");
                                return;
                            }
                        }
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Navgan WHERE Vis=True AND Loco1='" + Loco1Box.Text + "' AND Loco2='" + Loco2Box.Text + "' AND Wag1='" + Wag1Box.Text + "' AND Wag2='" + Wag2Box.Text + "' AND Wag3='" + Wag3Box.Text + "' AND Wag4='" + Wag4Box.Text + "' AND Wag5='" + Wag5Box.Text + "' AND Wag6='" + Wag6Box.Text + "' AND Wag7='" + Wag7Box.Text + "' AND Wag8='" + Wag8Box.Text + "' AND Wag9='" + Wag9Box.Text + "' AND ID<>" + ID, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Enabled=true;
                                StrConnec.Close();
                                ErrorShow(PictureBox1, "این قطار قبلا ثبت شده است");
                                return;
                            }
                        }

                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Navgan SET Vis=False WHERE ID=" + ID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Navgan (Loco1, Loco2, Wag1, Wag2, Wag3, Wag4, Wag5, Wag6, Wag7, Wag8, Wag9, U_Reg, T_Reg, Vis, Fad) VALUES ('" + Loco1Box.Text + "', '" + Loco2Box.Text + "', '" + Wag1Box.Text + "', '" + Wag2Box.Text + "', '" + Wag3Box.Text + "', '" + Wag4Box.Text + "', '" + Wag5Box.Text + "', '" + Wag6Box.Text + "', '" + Wag7Box.Text + "', '" + Wag8Box.Text + "', '" + Wag9Box.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + ID + ")", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    Clean();
                    KindCombo.SelectedIndex=-1;
                    NumBox.Text="";

                    Enabled=true;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                }
                Enabled=true;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean();
            NumBox.Text="";
            if (KindCombo.SelectedIndex == 0)
            {
                NumBox.Mask=">A0";
            }
            else
            {
                NumBox.Mask=">A00";
            }
        }

        public void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    ErrorShow(PictureBox1, "قطار را مشخص کنید");
                }
                else
                {
                    SearchButton_Click(null, null);
                    if (MessageBoxFa.Show(" این قطار حذف گردد؟", "تایید", MessageBoxIcon.Warning, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            string QueStr="UPDATE Navgan SET Vis=False, Fad=-";
                            if (!string.IsNullOrEmpty(Fad.ToString()))
                            {
                                QueStr += Fad;
                            }
                            else
                            {
                                QueStr += ID;
                            }
                            QueStr += " WHERE ID=" + ID;

                            using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                        }


                        Clean();
                        NumBox.Text="";
                        KindCombo.SelectedIndex=-1;
                        MessageBoxFa.Show("ذخیره با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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

        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            Clean();
        }

        public void TurnButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    ErrorShow(PictureBox1, "قطار را مشخص کنید");
                }
                else
                {
                    SearchButton_Click(null, null);
                    if (MessageBoxFa.Show(" این قطار دوار گردد؟", "تایید", MessageBoxIcon.Warning, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Enabled=false;
                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Navgan WHERE ID=" + ID, StrConnec))
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    ID=Convert.ToInt32(Reader["ID"]);
                                    Loco1Box.Text=Reader["Loco1"].ToString();
                                    Loco2Box.Text=Reader["Loco2"].ToString();
                                    Wag1Box.Text=Reader["Wag1"].ToString();
                                    Wag2Box.Text=Reader["Wag2"].ToString();
                                    Wag3Box.Text=Reader["Wag3"].ToString();
                                    Wag4Box.Text=Reader["Wag4"].ToString();
                                    Wag5Box.Text=Reader["Wag5"].ToString();
                                    Wag6Box.Text=Reader["Wag6"].ToString();
                                    Wag7Box.Text=Reader["Wag7"].ToString();
                                    Wag8Box.Text=Reader["Wag8"].ToString();
                                    Wag9Box.Text=Reader["Wag9"].ToString();
                                    if (Reader["Fad"].ToString() != "")
                                    {
                                        Fad=Convert.ToInt32(Reader["Fad"]);
                                    }
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand("UPDATE Navgan SET Vis=False WHERE ID=" + ID, StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Navgan (Loco1, Loco2, Wag1, Wag2, Wag3, Wag4, Wag5, Wag6, Wag7, Wag8, Wag9, U_Reg, T_Reg, Vis, Fad) VALUES ('" + Loco2Box.Text + "', '" + Loco1Box.Text + "', '" + Wag9Box.Text + "', '" + Wag8Box.Text + "', '" + Wag7Box.Text + "', '" + Wag6Box.Text + "', '" + Wag5Box.Text + "', '" + Wag4Box.Text + "', '" + Wag3Box.Text + "', '" + Wag2Box.Text + "', '" + Wag1Box.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + ID + ")", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        Clean();
                        NumBox.Text="";
                        KindCombo.SelectedIndex=-1;

                        Enabled=true;
                        MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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
