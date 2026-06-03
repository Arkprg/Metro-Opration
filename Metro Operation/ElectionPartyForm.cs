using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ElectionPartyForm
    {
        public ElectionPartyForm()
        {
            InitializeComponent();
        }

        private string ID;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void ElectionPartyForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    ID="";
                    string Candids="";
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM ElectionMember INNER JOIN Election ON Election.ID= ElectionMember.E_ID WHERE ElectionMember.Vis=True AND Election.Vis=True AND P_Num='" + AppState.UserPnum + "' AND E_Start<='" + MainForm.PersianToday.Tarikh() + "' AND E_End>='" + MainForm.PersianToday.Tarikh() + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (Reader["ElectionMember.T_Reg"].ToString() == "")
                            {
                                ID=Reader["E_ID"].ToString();
                                TitrBox.Text=Reader["E_Name"].ToString();
                                NumBox.Text=Reader["E_Num"].ToString();
                                Candids=Reader["E_Candids"].ToString();
                                StartCalendar.Text=Reader["E_Start"].ToString();
                                EndCalendar.Text=Reader["E_End"].ToString();
                                MemText.Text=Reader["E_Mem"].ToString();
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(ID))
                    {
                        MessageBoxFa.Show("انتخابات فعالی برای شما موجود نمی باشد", "خطا", MessageBoxIcon.Error);
                        Close();
                    }

                    while (Candids.Length > 1)
                    {
                        string Cand=Candids.Substring(0, Candids.IndexOf("-"));
                        Candids=Candids.Substring(Candids.IndexOf("-") + 1, Candids.Length - Candids.IndexOf("-") - 1);

                        DataRow[] Drw=MainForm.PersonTable.Select("SELECT Fname, Family, P_Num FROM Person WHERE Vis=True AND P_Num='" + Cand + "'");
                        foreach(DataRow Dr in Drw)
                        {
                            CandidListBox.Items.Add(Dr["Fname"].ToString() + " " + Dr["Family"].ToString() + " (" + Dr["P_Num"].ToString() + ")");
                        }
                        //using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Person WHERE Vis=True AND P_Num='" + Cand + "'", StrConnec))
                        //{
                        //    using (OleDbDataReader Reader=CMD.ExecuteReader())
                        //    {
                        //        while (Reader.Read())
                        //        {
                        //            CandidListBox.Items.Add(Reader["Fname"].ToString() + " " + Reader["Family"].ToString() + " (" + Reader["P_Num"].ToString() + ")");
                        //        }
                        //    }

                        //}
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
                if (CandidListBox.CheckedItems.Count == 0)
                {
                    ErrorShow(Label1, "حداقل یک مورد را انتخاب کنید");
                }
                else if (CandidListBox.CheckedItems.Count > double.Parse(NumBox.Text))
                {
                    ErrorShow(Label2, "تعداد انتخاب ها بیشتر از تعداد مشخص شده است");
                }
                else
                {
                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();

                        string Choice="";
                        for (int i=0; i <= CandidListBox.CheckedItems.Count - 1; i++)
                        {
                            Choice += CandidListBox.CheckedItems[i].ToString().Substring(CandidListBox.CheckedItems[i].ToString().IndexOf("(") + 1, Convert.ToInt32(Convert.ToInt32(CandidListBox.CheckedItems[i].ToString().Length - (CandidListBox.CheckedItems[i].ToString().IndexOf("(") + 1)) - 1)) + "-";
                        }

                        using (OleDbCommand CMD=new OleDbCommand("UPDATE ElectionMember SET E_Choice='" + Choice + "', U_Reg='" + AppState.UserName + "', T_Reg='" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "' WHERE P_Num='" + AppState.UserPnum + "' AND E_ID=" + ID, StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }

                    }



                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
                    AppState.AnsShould=false;
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

        public void ElectionPartyForm_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                if (AppState.AnsShould)
                {
                    if (MessageBoxFa.Show("از برنامه خارج می شوید؟", "خروج", MessageBoxIcon.Stop, MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        e.Cancel=true;
                    }
                    else
                    {
                        //MainForm.StatusStrip1.Visible=false;
                        //MainForm.Close();
                    }
                }
                else
                {
                    //
                    //               MainForm.Tables();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
