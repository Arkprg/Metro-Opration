using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ElectionResultForm
    {
        public ElectionResultForm()
        {
            InitializeComponent();
        }


        private string ID;

        public void ElectionResultForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    string StrQuer="SELECT E_Name FROM Election INNER JOIN ElectionMember ON Election.ID=ElectionMember.E_ID WHERE ElectionMember.Vis=True";
                    if (AppState.UserLevel > 5)
                    {
                        StrQuer += " And P_Num='" + AppState.UserPnum + "' AND Ans_Type='عمومی' And E_End<'" + MainForm.PersianToday.Tarikh() + "'";
                        Label5.Visible=false;
                        TypeLabel.Visible=false;
                    }
                    using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            if (NameCombo.Items.IndexOf(Reader["E_Name"].ToString()) < 0)
                            {
                                NameCombo.Items.Add(Reader["E_Name"].ToString());
                            }
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

        public void NameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID="0";
            NumLabel.Text="";
            StartCalendar.Text="";
            EndCalendar.Text="";
            TypeLabel.Text="";
            CandidGridView.Rows.Clear();
            TotalLabel.Text="";
            AraLabel.Text="";
            PercentLabel.Text="";
        }

        public void CandidGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CandidGridView.Sort(CandidGridView.Columns[4], System.ComponentModel.ListSortDirection.Descending);
            int i;
            for (i=0; i <= CandidGridView.Rows.Count - 1; i++)
            {
                CandidGridView.Rows[i].Cells[0].Value=i + 1;
            }

            if (CandidGridView.Rows.Count > 0)
            {
                CandidGridView.CurrentRow.Selected=false;
            }
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int Ara=0;
                int Total=0;

                ID="";
                CandidGridView.Rows.Clear();
                string Candids="";

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Election WHERE Vis=True AND E_Name='" + NameCombo.Text + "'", StrConnec))
                       using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                            {
                                ID=Reader["ID"].ToString();
                                NumLabel.Text=Reader["E_Num"].ToString();
                                Candids=Reader["E_Candids"].ToString();
                                StartCalendar.Text=Reader["E_Start"].ToString();
                                EndCalendar.Text=Reader["E_End"].ToString();
                                TypeLabel.Text=Reader["Ans_Type"].ToString();
                            }
                    }

                    while (Candids.Length > 1)
                    {
                        string Cand=Candids.Substring(0, Candids.IndexOf("-"));
                        Candids=Candids.Substring(Candids.IndexOf("-") + 1, Candids.Length - Candids.IndexOf("-") - 1);
                        int Count=0;

                        using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(P_Num) AS Ara FROM ElectionMember WHERE Vis=True AND E_Choice LIKE '%" + Cand + "%' AND E_ID=" + ID, StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                Count=int.Parse(Reader["Ara"].ToString());
                            }
                        }

                        DataRow[] Drw=MainForm.PersonTable.Select("SELECT Fname, Family, P_Num FROM Person WHERE Vis=True AND P_Num='" + Cand + "'");
                        foreach (DataRow Dr in Drw)
                        {
                            CandidGridView.Rows.Add(Dr["Fname"].ToString(), Dr["Family"].ToString(), Dr["P_Num"].ToString(), Count, 0.0);
                        }

                        //using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Person WHERE Vis=True AND P_Num='" + Cand + "'", StrConnec))
                        //{
                        //    using (OleDbDataReader Reader=CMD.ExecuteReader())
                        //    {
                        //        while (Reader.Read())
                        //        {
                        //            CandidGridView.Rows.Add(0, Reader["Fname"].ToString(), Reader["Family"].ToString(), Reader["P_Num"].ToString(), Count, 0.0);
                        //        }
                        //    }
                        //}
                    }

                    Ara=0;
                    Total=0;
                    using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(P_Num) AS Ara FROM ElectionMember WHERE Vis=True AND E_ID=" + ID, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Total=Convert.ToInt32(Reader["Ara"].ToString());
                        }
                    }

                    using (OleDbCommand CMD=new OleDbCommand("SELECT COUNT(P_Num) AS Ara FROM ElectionMember WHERE Vis=True AND E_Choice<>'' AND E_ID=" + ID, StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Ara=Convert.ToInt32(Reader["Ara"].ToString());
                        }
                    }

                    TotalLabel.Text=Total + "  نفر";
                    AraLabel.Text=Ara + "  نفر";
                    PercentLabel.Text=((double)Ara * 100 / Total).ToString("0.##");
                }

                CandidGridView.Sort(CandidGridView.Columns[4], System.ComponentModel.ListSortDirection.Descending);
                int i;
                for (i=0; i <= CandidGridView.Rows.Count - 1; i++)
                {
                    CandidGridView.Rows[i].Cells[0].Value=i + 1;
                }

                if (CandidGridView.Rows.Count > 0)
                {
                    CandidGridView.CurrentRow.Selected=false;
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
