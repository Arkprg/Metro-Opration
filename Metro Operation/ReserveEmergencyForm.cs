using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ReserveEmergencyForm
    {
        public ReserveEmergencyForm()
        {
            InitializeComponent();
        }


        private string PName;
        private string PFamily;
        private string PNum;
        private string PPost;
        private string ShName;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm.Per="گواهینامه";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                PPost=PersonalSelectForm.PLocal;
                ShName=PersonalSelectForm.PShift;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;
            }
        }

        public void ReserveEmergencyForm_Load(object sender, EventArgs e)
        {
            // If AppState.UserLevel < 6 Then KindCombo.Items.Add("رزرو اضطراری")
            StartCalendar.NextDay_Click(null, null);
            EndCalendar.Miladi=DateTime.Today;
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  If KindCombo.SelectedItem="رزرو اضطراری" Then MemBox.Enabled=True Else MemBox.Enabled=False
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate;
                DateTime EndDate;
                StartDate=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                EndDate=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, "نام راهبر را مشخص کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "عنوان را مشخص کنید");
                }
                else if (StartDate==null )
                {
                    ErrorShow(StartCalendar, "تاریخ شروع را مشخص کنید");
                }
                else if (EndDate==null)
                {
                    ErrorShow(EndCalendar, "تاریخ پایان را مشخص کنید");
                }
                else if (EndDate < StartDate)
                {
                    ErrorShow(StartCalendar, "بازه زمانی صحیح نیست");
                    ErrorShow(EndCalendar, "بازه زمانی صحیح نیست");
                }
                else if (MemBox.Text.Trim().Length < 10) //And KindCombo.SelectedItem="رزرو اضطراری" Then
                {
                    ErrorShow(MemBox, "ارائه توضیحات تکمیلی الزامی است");
                }
                else
                {
                    Taghvim PersianDate=new Taghvim(StartCalendar.Text);
                    string Shift="";
                    bool Exis=false;
                    Panel2.Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        while (PersianDate.Miladi() <= EndDate)
                        {
                            Shift="";
                            Exis=false;
                            using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Rezerv WHERE Vis=True AND Tarikh ='" + PersianDate.Tarikh() + "' AND P_Num='" + PNum + "'", StrConnec))
                               using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Exis=true;
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand("SELECT ID FROM Morakhasi WHERE Vis=True AND Tarikh ='" + PersianDate.Tarikh() + "' AND P_Num='" + PNum + "'", StrConnec))
                               using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Exis=true;
                                }
                            }

                            if (!Exis)
                            {
                                using (OleDbCommand CMD=new OleDbCommand("Select rooz, Sobh, Asr, Holi From Taghvim WHERE Tarikh ='" + PersianDate.Tarikh() + "'", StrConnec))
                                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                                {
                                    while (Reader.Read())
                                        {
                                            if (ShName == "ستادی" && double.Parse(Reader["rooz"].ToString()) < 6 && !(bool)Reader["Holi"])
                                            {
                                                Shift="صبح";
                                            }
                                            else if (ShName == Reader["Sobh"].ToString())
                                            {
                                                Shift="صبح";
                                            }
                                            else if (ShName == Reader["Asr"].ToString())
                                            {
                                                Shift="عصر";
                                            }
                                        }
                                }

                                if (!string.IsNullOrEmpty(Shift))
                                {
                                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Rezerv (P_NUM, Tarikh, R_Shift, Loca, U_Reg, Vis, Mem) VALUES ('" + PNum + "','" + PersianDate.Tarikh() + "', '" + Shift + "', '" + PPost + "', '" + AppState.UserName + "', True, 'غیر فعال '+@MeMo)", StrConnec))
                                    {
                                        CMD.Parameters.AddWithValue("@MeMo", MemBox.Text.Trim());
                                        //If KindCombo.SelectedItem="شانتر شیفت" Then
                                        //    CMD.CommandText += "'شانتر')"
                                        //ElseIf KindCombo.SelectedItem="رزرو اضطراری" Then
                                        //    CMD.CommandText += "'اضطراری '+@MeMo)"
                                        //    CMD.Parameters.AddWithValue("@MeMo", MemBox.Text.Trim)
                                        //End If

                                        CMD.ExecuteNonQuery();
                                    }
                                }
                            }
                            PersianDate.AddDay(1);
                        }
                    }

                    PersianDate.SetDate(DateTime.Today);
                    NameBox.Text="";
                    Panel2.Enabled=true;

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

        public void EmergencyReserveForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0601");
        }
    }
}
