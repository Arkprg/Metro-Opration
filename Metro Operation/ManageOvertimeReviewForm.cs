using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class ManageOvertimeReviewForm
    {
        public ManageOvertimeReviewForm()
        {
            InitializeComponent();
        }
        public void Full(OleDbConnection StrConnec)
        {
            try
            {
                DataGridView1.Visible=true;
                DataGridView2.Visible=true;

                OleDbDataAdapter Adapter=new OleDbDataAdapter("Select * From Ezafeh WHERE Vis=True AND Fad>-1", StrConnec);
                DataSet DS=new DataSet();
                Adapter.Fill(DS, "Dtable");
                DataGridView1.DataSource=DS.Tables["Dtable"];

                DataGridView1.Columns[2].HeaderText="شماره پرسنلی";
                DataGridView1.Columns[3].HeaderText="تاریخ";
                DataGridView1.Columns[6].HeaderText="کاربر";
                DataGridView1.Columns[5].HeaderText="توضیحات";

                DataGridView1.Columns[0].Width=120;
                DataGridView1.Columns[2].Width=55;
                DataGridView1.Columns[3].Width=65;
                DataGridView1.Columns[6].Width=90;
                DataGridView1.Columns[5].Width=120;

                DataGridView1.Columns[1].Visible=false;
                DataGridView1.Columns[4].Visible=false;
                DataGridView1.Columns[7].Visible=false;
                DataGridView1.Columns[8].Visible=false;
                DataGridView1.Columns[9].Visible=false;

                DataGridView1.Sort(DataGridView1.Columns[3], System.ComponentModel.ListSortDirection.Descending);

                int i=0;
                while (i < DataGridView1.Rows.Count)
                {
                    DataRow DRow=MainForm.PersonTable.Select("P_Num='" + DataGridView1.Rows[i].Cells[2].Value + "'").FirstOrDefault();
                    if (DRow != null)
                    {
                        if (DRow["Line_Num"].ToString() == AppState.UserLnum || AppState.UserLevel == 1)
                        {
                            DataGridView1.Rows[i].Cells[0].Value=DRow["FName"] + " " + DRow["Family"];
                            i++;
                        }
                        else
                        {
                            DataGridView1.Rows.RemoveAt(i);
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

        public void Button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        public void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridView2.Visible=false;
            Button2.Enabled=false;
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            int i;
            if (MessageBoxFa.Show("تغییرات حذف خواهد شد. آیا مطمئن هستید؟", "تایید", MessageBoxIcon.Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    for (i=DataGridView2.Rows.Count - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            using (OleDbCommand CMD=new OleDbCommand("UPDATE Ezafeh SET Fad=Null WHERE Fad=" + DataGridView2.Rows[i].Cells[6].Value.ToString(), StrConnec))
                            {
                                CMD.ExecuteNonQuery();
                            }

                        }
                        else
                        {
                            //Using CMD As New OleDbCommand("DELETE FROM Ezafeh WHERE ID=" & DataGridView2.Rows(i).Cells(6).Value.ToString
                        }
                    }

                    Full(StrConnec);
                }

            }
        }

        public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView2.Visible=true;
            Button2.Enabled=true;
            try
            {
                int RID=Convert.ToInt32(DataGridView1.CurrentRow.Cells[7].Value);
                bool FID=true;
                string ChaStr="";

                DataGridView2.Rows.Clear();

                if (RID < 0)
                {
                    RID *= -1;
                    ChaStr=" حذف شده ";
                }
                else
                {
                    ChaStr="ویرایش شده";
                }
                DataGridView2.Rows.Add(ChaStr, DataGridView1.CurrentRow.Cells[0].Value, DataGridView1.CurrentRow.Cells[2].Value, DataGridView1.CurrentRow.Cells[4].Value, DataGridView1.CurrentRow.Cells[5].Value, DataGridView1.CurrentRow.Cells[6].Value, RID);
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    while (FID)
                    {
                        using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Ezafeh WHERE ID=" + RID.ToString(), StrConnec))
                        using (OleDbDataReader Reader=CMD.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (Reader["Fad"].ToString() != "")
                                {
                                    RID=Convert.ToInt32(Reader["Fad"]);
                                    ChaStr="ویرایش شده";
                                }
                                else
                                {
                                    FID=false;
                                    ChaStr="ثبت شده";
                                }
                                DataGridView2.Rows.Add(ChaStr, DataGridView1.CurrentRow.Cells[0].Value, Reader["P_Num"].ToString(), Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["U_Reg"].ToString(), Reader["ID"].ToString());
                            }
                        }
                        //FID=False
                    }
                }

                DataGridView2.CurrentRow.Selected=false;
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i=0; i <= DataGridView1.RowCount - 1; i++)
            {
                DataRow[] DRow=MainForm.PersonTable.Select("P_Num='" + DataGridView1.Rows[i].Cells[2].Value + "'");
                foreach (DataRow DtR in DRow)
                {
                    DataGridView1.Rows[i].Cells[0].Value=DtR["FName"].ToString() + " " + DtR["Family"].ToString();
                }
            }
        }
    }
}
