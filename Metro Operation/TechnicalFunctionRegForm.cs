using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TechnicalFunctionRegForm
    {
        public TechnicalFunctionRegForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            PersonalSelectForm.Per="راهبر";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=PName + " " + PFamily;
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
                else if (SelectDate == null)
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
                        using (OleDbCommand CMD=new OleDbCommand("SELECT U_Reg FROM Fanni WHERE P_Num='" + PNum + "' AND Tarikh='" + PersianCalendar.Text + "' AND E_Time='" + TimeBox.Text + "'", StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                StrConnec.Close();
                                MessageBoxFa.Show(" داده ها قبلا توسط " + Reader["U_Reg"].ToString() + " ذخیره شده اند ", "خطا", MessageBoxIcon.Error);
                                return;
                            }
                        }

                        int Em=0;
                        if (NachCheck.Checked)
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

                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Fanni (P_Num, Tarikh, E_Loc, E_Time, Loco, Shomare, U_Reg, Nach, Tormoz, RedSig, NoDoor, OpenDoor, Falt, Etela, RM_Teh, Hi_Sooz, Bolo_Off, Arno_Off, ATP_Off, EM_ATP, Hi_Speed, N_etc, P_etc, Mem, Vis, Emt) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + LocalCombo.SelectedItem + "', '" + TimeBox.Text + "', '" + LocoBox.Text + "', '" + LetterBox.Text + "', '" + AppState.UserName + "', " + NachCheck.Checked + ", " + BrakeCheck.Checked + ", " + SignalCheck.Checked + ", " + NotDoorCheck.Checked + ", " + OpenDoorCheck.Checked + ", " + FaultCheck.Checked + ", " + AlarmCheck.Checked + ", " + RMCheck.Checked + ", " + SoozSpeedCheck.Checked + ", " + BlowerCheck.Checked + ", " + ArnoCheck.Checked + ", " + ATPCheck.Checked + ", " + ATPSpeedCheck.Checked + ", " + HighSpeedCheck.Checked + ", " + OtherNegaCheck.Checked + ", " + OtherPoseCheck.Checked + ", @Mem, True, " + Em.ToString() + ")", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }
                    }

                    NameBox.Text="";
                    LocalCombo.SelectedIndex=-1;
                    TimeBox.Text="";
                    LocoBox.Text="";
                    LetterBox.Text="";
                    NachCheck.Checked=false;
                    BrakeCheck.Checked=false;
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
                    AnalyzerCombo.Text="";
                    MemBox.Text="";
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        public void TechnicalFunctionRegForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "020101");
        }

        public void TechnicalFunctionRegForm_Load(object sender, EventArgs e)
        {
            try
            {
                PersianCalendar.Miladi=DateTime.Today;
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
