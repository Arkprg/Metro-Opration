using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TripHandlingForm
    {
        public TripHandlingForm()
        {
            InitializeComponent();
        }

        private int Mo;
        private int Da;
        private string PName;
        private string PFamily;
        private string PNum;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void Full()
        {
            Mo=0;
            Da=0;
            TodayBox.Text="";
            MonthBox.Text="";

            DataGridView1.Rows.Clear();

            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                string QueStr="P_Post='راهبر قطار' AND Shift_Name='" + ShiftCombo.Text + "' AND Shift_loc='" + LocalCombo.Text + "'";
                DataRow[] DRow=MainForm.PersonTable.Select(QueStr);
                foreach (DataRow DtR in DRow)
                {
                    int JA=0;

                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Amal WHERE P_Num='" + DtR["P_Num"].ToString() + "' And Tarikh LIKE '" + MainForm.PersianToday.Tarikh().Substring(0, 8) + "%' AND OnvAmal='جابجایی' AND Vis=True", StrConnec))
                    {
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                JA++;
                                Mo++;
                                if (Reader["Tarikh"].ToString() == MainForm.PersianToday.Tarikh())
                                {
                                    Da++;
                                }
                            }
                        }

                    }


                    DataGridView1.Rows.Add(DtR["Fname"].ToString(), DtR["Family"].ToString(), DtR["P_Num"].ToString(), JA);
                }
            }


            DataGridView1.Sort(DataGridView1.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            TodayBox.Text=Da.ToString();
            MonthBox.Text=Mo.ToString();
            TripMaskedBox.Text="";
        }

        public void LocalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftCombo.SelectedIndex=-1;
        }

        public void ShiftCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShiftCombo.SelectedIndex >= 0)
            {
                Full();
            }
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            DateTime SelectDate=ConvertClass.ShamsiToMiladi(PersianCalendar.Text);

            if (SelectDate == null)
            {
                ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
            }
            else if (SelectDate > DateTime.Today || SelectDate < DateTime.Today.AddDays(-7))
            {
                ErrorShow(PersianCalendar, "این تاریخ قابل دسترس نیست");
            }
            else if (TripMaskedBox.Text==null)
            {
                ErrorShow(TripMaskedBox, "زمان تریپ را تعیین کنید");
            }
            else
            {
                Panel3.Enabled=false;
                int Ja=0;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Amal WHERE P_Num='" + PNum + "' And Tarikh LIKE '" + MainForm.PersianToday.Tarikh().Substring(0, 8) + "%' AND OnvAmal='جابجایی' AND Vis=True", StrConnec))
                    {
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Ja++;
                            }
                        }

                    }

                    if (Ja >= 2)
                    {
                        StrConnec.Close();
                        MessageBoxFa.Show(" این راهبر حداکثر جابجایی های این ماه را انجام داده است ", "خطا", MessageBoxIcon.Error);
                        return;
                    }

                    using (OleDbCommand CMD=new OleDbCommand("INSERT INTO Amal (P_NUM, Tarikh, T_Reg, U_Reg, OnvAmal, Amal, Vis) VALUES ('" + PNum + "','" + PersianCalendar.Text + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', '" + AppState.UserName + "', 'جابجایی', '" + TripMaskedBox.Text + "', True)", StrConnec))
                    {
                        CMD.ExecuteNonQuery();
                    }


                }

                MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                Panel3.Enabled=true;
            }
            Full();
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i=0;

            DataGridView1.CurrentRow.Selected=true;
            TripLabel1.Visible=false;
            TripLabel2.Visible=false;
            TripLabel3.Visible=false;
            TripLabel4.Visible=false;
            Panel3.Enabled=true;

            PFamily=DataGridView1.CurrentRow.Cells[1].Value.ToString();
            PName=DataGridView1.CurrentRow.Cells[0].Value.ToString();
            PNum=DataGridView1.CurrentRow.Cells[2].Value.ToString();

            Label8.Text="ثبت جابجایی برای " + PName + " " + PFamily;
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Amal WHERE P_Num='" + DataGridView1.CurrentRow.Cells[2].Value + "' And Tarikh LIKE '" + MainForm.PersianToday.Tarikh().Substring(0, 8) + "%' AND OnvAmal='جابجایی' AND Vis=True", StrConnec))
                {
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            switch (i)
                            {
                                case 0:
                                    TripLabel1.Visible=true;
                                    TripLabel1.Text=Reader["Amal"].ToString() + " - " + Reader["Tarikh"].ToString();
                                    break;
                                case 1:
                                    TripLabel2.Visible=true;
                                    TripLabel2.Text=Reader["Amal"].ToString() + " - " + Reader["Tarikh"].ToString();
                                    break;
                                case 2:
                                    TripLabel3.Visible=true;
                                    TripLabel3.Text=Reader["Amal"].ToString() + " - " + Reader["Tarikh"].ToString();
                                    break;
                                case 3:
                                    TripLabel4.Visible=true;
                                    TripLabel4.Text=Reader["Amal"].ToString() + " - " + Reader["Tarikh"].ToString();
                                    break;
                            }
                            i++;
                        }
                    }

                }

            }

            Label8.Left=585 - Label8.Width;
        }

        private void Panel3_EnabledChanged(object sender, EventArgs e)
        {
            Label8.Text="";
            PersianCalendar.Text="";
            TripMaskedBox.Text="";
        }

        public void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            Panel3.Enabled=false;
            TripLabel1.Visible=false;
            TripLabel2.Visible=false;
            TripLabel3.Visible=false;
            TripLabel4.Visible=false;
        }

        public void TripHandlingForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0111");
        }

        public void TripHandlingForm_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);

            LocalCombo.Items.Clear();
            if (AppState.UserLevel < 6)
            {
                LocalCombo.Items.Add("همه موارد");
            }

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
    }
}
