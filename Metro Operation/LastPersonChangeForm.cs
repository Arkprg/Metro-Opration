using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class LastPersonChangeForm
    {
        public LastPersonChangeForm()
        {
            InitializeComponent();
        }

        public void LastPersonChangeForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Mess="";
                int i;
                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT TOP 10 Person.Fname, Person.Family, Person.P_Num, PostHis.Shift_name, PostHis.Shift_Time, PostHis.Shift_Loc, PostHis.P_Staff, PostHis.P_Post, PostHis.U_Reg, PostHis.T_Reg FROM PostHis INNER JOIN Person ON Person.P_Num=PostHis.P_Num ORDER BY PostHis.ID DESC", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Mess=Reader["Shift_Time"] + " " + Reader["Shift_Name"] + " " + Reader["Shift_Loc"] + "  واحد " + Reader["P_Staff"];
                            ShowGridView.Rows.Add(0, Reader["Fname"], Reader["Family"], Reader["P_Num"], Mess, Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString());
                        }
                    }

                    i=0;
                    using (OleDbCommand CMD=new OleDbCommand("SELECT TOP 10 Person.Fname, Person.Family, Person.P_Num, Permis.OverTime, Permis.Trip, Permis.Reserv, Permis.Mem, Permis.U_Reg, Permis.T_Reg FROM Permis INNER JOIN Person ON Person.P_Num=Permis.P_Num ORDER BY Permis.ID DESC", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Mess="مجوز اضافه کار:";
                            if ((bool)Reader["OverTime"])
                            {
                                Mess += "دارد";
                            }
                            else
                            {
                                Mess += "ندارد";
                            }

                            Mess += ", مجوز تریپ:";
                            if ((bool)Reader["Trip"])
                            {
                                Mess += "دارد";
                            }
                            else
                            {
                                Mess += "ندارد";
                            }

                            Mess += ", مجوز رزرو:";
                            if ((bool)Reader["Reserv"])
                            {
                                Mess += "دارد";
                            }
                            else
                            {
                                Mess += "ندارد";
                            }

                            Mess += " (" + Reader["Mem"] + ")";
                            ShowGridView.Rows.Add(0, Reader["Fname"], Reader["Family"], Reader["P_Num"], Mess, Reader["U_Reg"].ToString(), Reader["T_Reg"].ToString());
                        }
                    }
                }


                ShowGridView.Sort(ShowGridView.Columns[6], System.ComponentModel.ListSortDirection.Descending);
                for (i=0; i <= ShowGridView.RowCount - 1; i++)
                {
                    ShowGridView.Rows[i].Cells[0].Value=i + 1;
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
