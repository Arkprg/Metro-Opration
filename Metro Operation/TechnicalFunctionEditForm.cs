using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TechnicalFunctionEditForm
    {
        public TechnicalFunctionEditForm()
        {
            InitializeComponent();
        }

        public string PName;
        public string PFamily;
        public string PNum;
        public string SName;
        public string SFamily;
        public string SNum;
        public string Btm;
        private int FID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Dis()
        {
            NameBox.Text="";
            PersianCalendar.Text="";
            LocalCombo.SelectedIndex=-1;
            TimeBox.Text="";
            LocoBox.Text="";
            LetterBox.Text="";
            NachCheck.Checked=false;
            BerakeCheck.Checked=false;
            SignalCheck.Checked=false;
            NotDoorCheck.Checked=false;
            OpenDoorCheck.Checked=false;
            FaultCheck.Checked=false;
            AlarmCheck.Checked=false;
            RMCheck.Checked=false;
            SoozSpeedCheck.Checked=false;
            BlowerCheck.Checked=false;
            ArnoCheck.Checked=false;
            ATPCheck.Checked=false;
            ATPSpeedCheck.Checked=false;
            HighSpeedCheck.Checked=false;
            OtherNegaCheck.Checked=false;
            OtherPoseCheck.Checked=false;
            MemBox.Text="";
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            Dis();
            SearchNameBox.Text=" ";
            SearchNameButton.Image=Properties.Resources.user;
            Btm="Sear";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                SFamily=PersonalSelectForm.PFamily;
                SName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=SName + " " + SFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }

        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dis();

                int Count=0;
                string QueStr="SELECT * FROM Fanni WHERE Vis=True";
                if (SearchNameBox.Text != "")
                {
                    QueStr += " AND P_Num='" + PNum + "'";
                }

                if (ConvertClass.ShamsiToMiladi(SearchPersianCalendar.Text) == null)
                {
                    QueStr += " AND Tarikh='" + SearchPersianCalendar.Text + "'";
                }

                if (SearchLetterBox.Text != "")
                {
                    QueStr += " AND Shomare='" + SearchLetterBox.Text + "'";
                }

                if (ConvertClass.ShamsiToMiladi(SearchTimeBox.Text) == null)
                {
                    QueStr += " AND E_Time='" + SearchTimeBox.Text + "'";
                }

                if (SearchLocalCombo.SelectedIndex >= 0)
                {
                    QueStr += " AND E_Loc='" + SearchLocalCombo.Text + "'";
                }

                if (SearchLocoBox.Text != "")
                {
                    QueStr += " AND Loco='" + SearchLocoBox.Text + "'";
                }
                //If Using CMD As New OleDbCommand("SELECT * FROM Fanni WHERE Vis=True" Then
                //    MessageBoxFa.Show(" حداقل یکی از فیلدها باید پر شوند !", "خطا", MessageBoxIcon.Error)
                //Else
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand(QueStr, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Panel3.Enabled=true;
                            Panel4.Enabled=true;
                            Dis();
                            Count++;
                            if (Count == 1)
                            {
                                SNum=Reader["P_Num"].ToString();
                                PersianCalendar.Text=Reader["Tarikh"].ToString();
                                LocoBox.Text=Reader["Loco"].ToString();
                                LocalCombo.Text=Reader["E_Loc"].ToString();
                                TimeBox.Text=Reader["E_Time"].ToString();
                                LetterBox.Text=Reader["Shomare"].ToString();
                                AnalyzerCombo.Text=Reader["U_Extr"].ToString();
                                NachCheck.Checked=bool.Parse(Reader["Nach"].ToString());
                                BerakeCheck.Checked=bool.Parse(Reader["Tormoz"].ToString());
                                SignalCheck.Checked=bool.Parse(Reader["RedSig"].ToString());
                                NotDoorCheck.Checked=bool.Parse(Reader["NoDoor"].ToString());
                                OpenDoorCheck.Checked=bool.Parse(Reader["OpenDoor"].ToString());
                                FaultCheck.Checked=bool.Parse(Reader["Falt"].ToString());
                                AlarmCheck.Checked=bool.Parse(Reader["Etela"].ToString());
                                RMCheck.Checked=bool.Parse(Reader["RM_Teh"].ToString());
                                SoozSpeedCheck.Checked=bool.Parse(Reader["Hi_Sooz"].ToString());
                                BlowerCheck.Checked=bool.Parse(Reader["Bolo_Off"].ToString());
                                ArnoCheck.Checked=bool.Parse(Reader["Arno_Off"].ToString());
                                ATPCheck.Checked=bool.Parse(Reader["ATP_Off"].ToString());
                                ATPSpeedCheck.Checked=bool.Parse(Reader["EM_ATP"].ToString());
                                HighSpeedCheck.Checked=bool.Parse(Reader["Hi_Speed"].ToString());
                                OtherNegaCheck.Checked=bool.Parse(Reader["N_etc"].ToString());
                                OtherPoseCheck.Checked=bool.Parse(Reader["P_etc"].ToString());
                                MemBox.Text=Reader["Mem"].ToString();
                                FID=Convert.ToInt32(Reader["ID"].ToString());
                            }
                        }
                    }
                }

                if (Count == 1)
                {
                    DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + SNum + "'");
                    foreach (DataRow DtR in DRow)
                    {
                        NameBox.Text=DtR["Fname"].ToString() + " " + DtR["Family"].ToString();
                    }
                }
                else
                {
                    Panel3.Enabled=false;
                    Panel4.Enabled=false;
                    if (Count == 0)
                    {
                        MessageBoxFa.Show("موردی یافت نشد !", "خطا", MessageBoxIcon.Error);
                    }

                    if (Count > 1)
                    {
                        MessageBoxFa.Show("تعداد " + Count.ToString() + " مورد مشابه یافت شد  \n لطفا با افزایش فیلتر ها جستجو را دقیق تر کنید !", "خطا", MessageBoxIcon.Error);
                    }
                }
                // End If
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void SearchLocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dis();
        }

        public void SearchPersianCalendar_TextChanged(object sender, EventArgs e)
        {
            Dis();
        }

        public void TechnicalFunctionEditForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "020102");
        }

        public void Form48_Load(object sender, EventArgs e)
        {
            try
            {
                Panel3.Enabled=false;
                Panel4.Enabled=false;

                PersianCalendar.Miladi=DateTime.Today;
                SearchPersianCalendar.Miladi=DateTime.Today;

                LocalCombo.Items.Clear();

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

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT U_Extr FROM Fanni WHERE U_Extr<>'' ORDER BY U_Extr", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            AnalyzerCombo.Items.Add(Reader["U_Extr"].ToString());
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT DISTINCT U_Reg FROM Fanni WHERE U_Reg<>'' ORDER BY U_Reg", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            AnalyzerCombo.Items.Add(Reader["U_Reg"].ToString());
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

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام راهبر را مشخص کنید");
                }
                else if (ConvertClass.TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(PersianCalendar, "تاریخ را مشخص کنید");
                }
                else if (SelectDate > DateTime.Today)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (LetterBox.Text == "")
                {
                    ErrorShow(LetterBox, "شماره نامه را مشخص کنید");
                }
                else if (LocalCombo.SelectedIndex < 0)
                {
                    ErrorShow(LocalCombo, "مبدا حرکت را مشخص کنید");
                }
                else if (LocoBox.Text == "")
                {
                    ErrorShow(LocoBox, "شماره لکو صحیح را مشخص کنید");
                }
                else if (ConvertClass.TimeToDouble(TimeBox.Text, true) <= 0)
                {
                    ErrorShow(TimeBox, "ساعت اعزام را مشخص کنید");
                }
                else
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Fanni SET Vis=False WHERE ID=" + FID.ToString(), StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                        int Em=0;
                        if (NachCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (BerakeCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (SignalCheck.Checked)
                        {
                            Em -= 5;
                        }

                        if (NotDoorCheck.Checked)
                        {
                            Em -= 3;
                        }

                        if (OpenDoorCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (FaultCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (AlarmCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (RMCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (SoozSpeedCheck.Checked)
                        {
                            Em -= 3;
                        }

                        if (BlowerCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (ArnoCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (ATPCheck.Checked)
                        {
                            Em -= 5;
                        }

                        if (ATPSpeedCheck.Checked)
                        {
                            Em--;
                        }

                        if (HighSpeedCheck.Checked)
                        {
                            Em -= 3;
                        }

                        if (OtherNegaCheck.Checked)
                        {
                            Em -= 2;
                        }

                        if (OtherPoseCheck.Checked)
                        {
                            Em += 2;
                        }

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Fanni (P_Num, Tarikh, E_Loc, E_Time, Loco, Shomare, U_Reg, Nach, Tormoz, RedSig, NoDoor, OpenDoor, Falt, Etela, RM_Teh, Hi_Sooz, Bolo_Off, Arno_Off, ATP_Off, EM_ATP, Hi_Speed, N_etc, P_etc, Mem, Vis, Fad, Emt) VALUES ('" + SNum + "', '" + PersianCalendar.Text + "', '" + LocalCombo.SelectedItem + "', '" + TimeBox.Text + "', '" + LocoBox.Text + "', '" + LetterBox.Text + "', '" + AppState.UserName + "', " + NachCheck.Checked + ", " + BerakeCheck.Checked + ", " + SignalCheck.Checked + ", " + NotDoorCheck.Checked + ", " + OpenDoorCheck.Checked + ", " + FaultCheck.Checked + ", " + AlarmCheck.Checked + ", " + RMCheck.Checked + ", " + SoozSpeedCheck.Checked + ", " + BlowerCheck.Checked + ", " + ArnoCheck.Checked + ", " + ATPCheck.Checked + ", " + ATPSpeedCheck.Checked + ", " + HighSpeedCheck.Checked + ", " + OtherNegaCheck.Checked + ", " + OtherPoseCheck.Checked + ", '" + MemBox.Text.Trim() + "', True, " + FID.ToString() + ", " + Em.ToString() + ")", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    Panel3.Enabled=false;
                    Panel4.Enabled=false;
                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    Dis();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DeletButton_Click(object sender, EventArgs e)
        {
            if (MessageBoxFa.Show(" آیا مایلید اطلاعات حذف گردد؟ ", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("UPDATE Fanni SET Vis=False, Fad=-" + FID.ToString() + " WHERE ID=" + FID.ToString(), StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }
                }

                Dis();
                Panel3.Enabled=false;
                Panel4.Enabled=false;
                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            SearchNameBox.Text=" ";
            SearchNameButton.Image=Properties.Resources.user;
            Btm="Sear";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                SearchNameBox.Text=PName + " " + PFamily;
                SearchNameButton.Image=Properties.Resources.cancel1;
            }
        }
    }
}
