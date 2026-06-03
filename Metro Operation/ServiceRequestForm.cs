using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ServiceRequestForm
    {
        public ServiceRequestForm()
        {
            InitializeComponent();
        }

        private string PName;
        private string PFamily;
        private string PNum;
        private string ID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void DataFill()
        {
            try
            {
                AddressLabel.Text="";
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT CityAddress, TownAddress, HomeAddress FROM Person WHERE P_Num='" + PNum + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            AddressLabel.Text=Reader["CityAddress"].ToString() + " " + Reader["TownAddress"].ToString() + " " + Reader["HomeAddress"].ToString();
                        }
                    }

                    ID="0";
                    using (OleDbCommand CMD=new OleDbCommand("SELECT ID, S_Time FROM ServiceRequst WHERE P_Num='" + PNum + "' AND Tarikh='" + DateLabel.Text + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ID=Reader["ID"].ToString();
                            TimeBox.Text=Reader["S_Time"].ToString();
                        }
                    }
                }

                if (double.Parse(ID) > 0)
                {
                    MessageBoxFa.Show("برای " + NameBox.Text + " درخواست سرویس ثبت شده است", "توجه", MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void GrideFull()
        {
            try
            {
                ShowGridView.Rows.Clear();
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    int i=1;
                    using (OleDbCommand CMD=new OleDbCommand("SELECT Fname, Family, Person.P_Num, S_Time, CityAddress, TownAddress, U_Reg, T_Reg FROM ServiceRequst INNER JOIN Person ON ServiceRequst.P_Num=Person.P_Num WHERE ServiceRequst.Tarikh='" + DateLabel.Text + "' AND ServiceRequst.Vis=True ORDER BY S_Time", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            ShowGridView.Rows.Add(i, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["Person.P_Num"].ToString(), Reader["S_Time"].ToString(), Reader["CityAddress"] + " - " + Reader["TownAddress"], Reader["U_Reg"], Reader["T_Reg"]);
                            i++;
                        }
                    }
                }

                if (ShowGridView.Rows.Count > 0)
                {
                    ShowGridView.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ServiceRequestForm_Load(object sender, EventArgs e)
        {
            try
            {
                DateLabel.Text=MainForm.PersianToday.Tarikh();
                AddressLabel.Text="";

                if (AppState.UserLevel == 9)
                {
                    Panel1.Left=12;
                    Width=730;
                    Height=175;

                    PNum=AppState.UserPnum;
                    NameButton.Enabled=false;
                    NameBox.Text=AppState.UserName;

                    DataFill();
                    if (AddressLabel.Text.Length < 10)
                    {
                        MessageBoxFa.Show("آدرس مقصد نامعتبر است", "خطا", MessageBoxIcon.Error);
                        NameBox.Text="";
                        NameButton.Image=Properties.Resources.user;
                    }
                }
                else
                {
                    GrideFull();
                    // Panel1.Enabled=False

                }
                if (string.Compare(DateTime.Now.ToString("HH:mm:ss"), "23:00:00") > 0)
                {
                    MessageBoxFa.Show("زمان ثبت درخواست سرویس به پایان رسیده است", "خطا", MessageBoxIcon.Error);
                    Panel1.Enabled=false;
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
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;

            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;

                NameBox.Text=PName + " " + PFamily;
                NameButton.Image=Properties.Resources.cancel1;

                DataFill();
            }

        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text.Length == 0)
                {
                    ErrorShow(NameBox, "نام را مشخص کنید");
                }
                else
                {
                    if (ConvertClass.TimeToDouble(TimeBox.Text) > 23.5 || ConvertClass.TimeToDouble(TimeBox.Text) < 18.5)
                    {
                        ErrorShow(TimeBox, "ساعت حرکت را وارد کنید");
                    }
                    else
                    {
                        // If TimeBox.Text="" Then If MessageBoxFa.Show("ساعت حضور سرویس بر اساس زمان پیاده شدن شما تنظیم شود؟", "تایید", MessageBoxIcon.Question, MessageBoxButtons.YesNo)=DialogResult.No Then Exit Sub

                        using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                        {
                            StrConnec.Open();
                            if (double.Parse(ID) > 0)
                            {
                                using (OleDbCommand CMD=new OleDbCommand("UPDATE ServiceRequst SET Vis=False WHERE ID=" + ID.ToString(), StrConnec))
                                {
                                    CMD.ExecuteNonQuery();
                                }
                            }

                            using (OleDbCommand CMD=new OleDbCommand("INSERT INTO ServiceRequst (P_Num, Tarikh, S_Time, U_Reg, T_Reg, Vis, Fad) VALUES ('" + PNum + "', '" + DateLabel.Text + "', '" + TimeBox.Text + "', '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True, " + ID + ")", StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }
                        }

                        MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);

                        PNum="";
                        NameBox.Text="";
                        NameButton.Image=Properties.Resources.user;
                        AddressLabel.Text="";
                        TimeBox.Text="";
                        GrideFull();
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
