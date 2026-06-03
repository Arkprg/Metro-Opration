using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class PermisionEditForm
    {
        public PermisionEditForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private bool OverTime;
        private bool Trip;
        private bool Reserv;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Clean()
        {
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            OverTimeCombo.SelectedIndex=-1;
            ReservCombo.SelectedIndex=-1;
            TripCombo.SelectedIndex=-1;
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text.Length == 0)
                {
                    ErrorShow(NameBox, "نام را مشخص کنید");
                }
                else if (OverTimeCombo.SelectedIndex < 0)
                {
                    ErrorShow(OverTimeCombo, "مجوز اضافه کار صحیح نیست");
                }
                else if (ReservCombo.SelectedIndex < 0)
                {
                    ErrorShow(ReservCombo, "مجوز رزرو صحیح نیست");
                }
                else if (TripCombo.SelectedIndex < 0)
                {
                    ErrorShow(TripCombo, "مجوز تریپ صحیح نیست");
                }
                else if (MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "ارائه توضیحات الزامی می باشد");
                }
                else if (Convert.ToInt32(OverTime) == OverTimeCombo.SelectedIndex && Convert.ToInt32(Reserv) == ReservCombo.SelectedIndex && Convert.ToInt32(Trip) == TripCombo.SelectedIndex)
                {
                    ErrorShow(OverTimeCombo, "هیچ مجوزی تغییر نکرده است");
                    ErrorShow(ReservCombo, "هیچ مجوزی تغییر نکرده است");
                    ErrorShow(TripCombo, "هیچ مجوزی تغییر نکرده است");
                }
                else
                {
                    Enabled=false;
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("UPDATE Person SET OverTime=" + Convert.ToBoolean(OverTimeCombo.SelectedIndex) + ", Reserv=" + Convert.ToBoolean(ReservCombo.SelectedIndex) + ", Trip=" + Convert.ToBoolean(TripCombo.SelectedIndex) + " WHERE P_Num='" + PNum + "'", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }


                        using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Permis (P_Num, OverTime, Reserv, Trip, U_Reg, T_Reg, Mem) VALUES ('" + PNum + "', " + Convert.ToBoolean(OverTime) + ", " + Convert.ToBoolean(Reserv) + ", " + Convert.ToBoolean(Trip) + ", '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', @Mem)", StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());
                            CMD.ExecuteNonQuery();
                        }
                    }

                    Clean();
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void NameButton_Click(object sender, EventArgs e)
        {
            Clean();
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                Clean();
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.user;

                if (NameBox.Text != "")
                {
                    DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + PNum + "'");
                    OverTime=(bool)DRow[0]["OverTime"];
                    Reserv=(bool)DRow[0]["Reserv"];
                    Trip=(bool)DRow[0]["Trip"];

                    OverTimeCombo.SelectedIndex=Convert.ToInt32(OverTime);
                    ReservCombo.SelectedIndex=Convert.ToInt32(Reserv);
                    TripCombo.SelectedIndex=Convert.ToInt32(Trip);
                }
            }

        }
    }
}
