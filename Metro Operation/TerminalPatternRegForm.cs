using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TerminalPatternRegForm
    {
        public TerminalPatternRegForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void KindCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameCombo.Items.Clear();
            using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
            {
                StrConnec.Open();
                using (OleDbCommand CMD=new OleDbCommand("SELECT T_Name FROM TerminalTable WHERE T_Kind='" + KindCombo.SelectedItem + "' AND Vis=True ORDER BY T_Name", StrConnec))
                {
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            NameCombo.Items.Add(Reader["T_Name"].ToString());
                        }
                    }

                }

            }

        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "نوع جدول را تعیین کنید");
                }
                else if (NameCombo.SelectedIndex < 0)
                {
                    ErrorShow(NameCombo, "نام جدول را تعیین کنید");
                }
                else
                {

                    TabControl1.SelectedIndex=1;
                    R11.Items.Clear();
                    R21.Items.Clear();
                    R12.Items.Clear();
                    R22.Items.Clear();
                    DataGridView11.Rows.Clear();
                    DataGridView21.Rows.Clear();
                    DataGridView12.Rows.Clear();
                    DataGridView22.Rows.Clear();

                    int i;
                    for (i=1; i <= int.Parse(Teh2Box.Text); i++)
                    {
                        R11.Items.Add("پایانه تهران " + i);
                    }
                    for (i=1; i <= int.Parse(KeshTeh2Box.Text); i++)
                    {
                        R11.Items.Add("کشیک پایانه " + i);
                    }
                    for (i=1; i <= int.Parse(ResTeh2Box.Text); i++)
                    {
                        R11.Items.Add("رزرو پایانه" + i.ToString());
                    }

                    for (i=1; i <= int.Parse(Gol2Box.Text); i++)
                    {
                        R21.Items.Add("پایانه گلشهر " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(Mehr2Box.Text); i++)
                    {
                        R21.Items.Add("پایانه مهرشهر " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(KeshMeh2Box.Text); i++)
                    {
                        R21.Items.Add("کشیک مهرشهر " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(ResMeh2Box.Text); i++)
                    {
                        R21.Items.Add("رزرو مهرشهر " + i.ToString());
                    }

                    for (i=1; i <= int.Parse(Teh3Box.Text); i++)
                    {
                        R12.Items.Add("پایانه تهران " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(KeshTeh3Box.Text); i++)
                    {
                        R12.Items.Add("کشیک پایانه " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(ResTeh3Box.Text); i++)
                    {
                        R12.Items.Add("رزرو پایانه" + i.ToString());
                    }

                    for (i=1; i <= int.Parse(Gol3Box.Text); i++)
                    {
                        R22.Items.Add("پایانه گلشهر " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(Mehr3Box.Text); i++)
                    {
                        R22.Items.Add("پایانه مهرشهر " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(KeshMeh3Box.Text); i++)
                    {
                        R22.Items.Add("کشیک مهرشهر " + i.ToString());
                    }
                    for (i=1; i <= int.Parse(ResMeh3Box.Text); i++)
                    {
                        R22.Items.Add("رزرو مهرشهر " + i.ToString());
                    }

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand("SELECT TerminalTableTrip.E_Time, TerminalTableTrip.E_Kind, TerminalTableTrip.E_Start, TerminalTableTrip.E_End FROM TerminalTableTrip INNER JOIN TerminalTable ON TerminalTableTrip.T_ID=TerminalTable.ID WHERE T_Kind='" + KindCombo.SelectedItem + "' AND T_Name='" + NameCombo.SelectedItem + "' AND Vis=True AND TerminalTableTrip.E_Time BETWEEN '07:30' AND '19:30' ORDER BY TerminalTableTrip.E_Time", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (Reader["E_Start"].ToString() == "تهران" || Reader["E_Start"].ToString() == "پایانه تهران")
                                    {
                                        DataGridView11.Rows.Add(DataGridView11.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_End"].ToString());
                                    }
                                    else if (Reader["E_Start"].ToString() == "گلشهر" || Reader["E_Start"].ToString() == "پایانه مهرشهر")
                                    {
                                        DataGridView21.Rows.Add(DataGridView21.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_End"].ToString());
                                    }
                                }
                            }

                        }


                        using (OleDbCommand CMD=new OleDbCommand("SELECT TerminalTableTrip.E_Time, TerminalTableTrip.E_Kind, TerminalTableTrip.E_Start, TerminalTableTrip.E_End FROM TerminalTableTrip INNER JOIN TerminalTable ON TerminalTableTrip.T_ID=TerminalTable.ID WHERE T_Kind='" + KindCombo.SelectedItem + "' AND T_Name='" + NameCombo.SelectedItem + "' AND Vis=True AND (TerminalTableTrip.E_Time>'19:30' OR TerminalTableTrip.E_Time<'07:30') ORDER BY TerminalTableTrip.E_Time", StrConnec))
                        {
                            using (OleDbDataReader Reader=CMD.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    if (Reader["E_Start"].ToString() == "تهران" || Reader["E_Start"].ToString() == "پایانه تهران")
                                    {
                                        DataGridView12.Rows.Add(DataGridView12.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_End"].ToString());
                                    }
                                    else if (Reader["E_Start"].ToString() == "گلشهر" || Reader["E_Start"].ToString() == "پایانه مهرشهر")
                                    {
                                        DataGridView22.Rows.Add(DataGridView22.RowCount + 1, Reader["E_Time"].ToString(), Reader["E_Kind"].ToString(), Reader["E_Start"].ToString(), Reader["E_End"].ToString());
                                    }
                                }
                            }

                        }

                    }


                    if (DataGridView11.RowCount > 0)
                    {
                        DataGridView11.CurrentRow.Selected=false;
                    }
                    if (DataGridView21.RowCount > 0)
                    {
                        DataGridView21.CurrentRow.Selected=false;
                    }
                    if (DataGridView12.RowCount > 0)
                    {
                        DataGridView12.CurrentRow.Selected=false;
                    }
                    if (DataGridView22.RowCount > 0)
                    {
                        DataGridView22.CurrentRow.Selected=false;
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

        public void DataGridView11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Time11Label.Text=DataGridView11.CurrentRow.Cells[1].Value.ToString();
                    Kind11Label.Text=DataGridView11.CurrentRow.Cells[2].Value.ToString();
                    Mab11Label.Text=DataGridView11.CurrentRow.Cells[3].Value.ToString();
                    Magh11Label.Text=DataGridView11.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Add1Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (R11.SelectedIndex >= 0 && DataGridView11.CurrentRow.Selected)
                {
                    DataGridView11.CurrentRow.Cells[5].Value=R11.SelectedItem;
                    R11.SelectedIndex=-1;

                    Time11Label.Text="";
                    Kind11Label.Text="";
                    Mab11Label.Text="";
                    Magh11Label.Text="";
                    DataGridView11.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView21_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Time21Label.Text=DataGridView21.CurrentRow.Cells[1].Value.ToString();
                    Kind21Label.Text=DataGridView21.CurrentRow.Cells[2].Value.ToString();
                    Mab21Label.Text=DataGridView21.CurrentRow.Cells[3].Value.ToString();
                    Magh21Label.Text=DataGridView21.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Add2Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (R21.SelectedIndex >= 0 && DataGridView21.CurrentRow.Selected)
                {
                    DataGridView21.CurrentRow.Cells[5].Value=R21.SelectedItem;
                    R21.SelectedIndex=-1;

                    Time21Label.Text="";
                    Kind21Label.Text="";
                    Mab21Label.Text="";
                    Magh21Label.Text="";
                    DataGridView21.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Time12Label.Text=DataGridView12.CurrentRow.Cells[1].Value.ToString();
                    Kind12Label.Text=DataGridView12.CurrentRow.Cells[2].Value.ToString();
                    Mab12Label.Text=DataGridView12.CurrentRow.Cells[3].Value.ToString();
                    Magh12Label.Text=DataGridView12.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Add3Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (R12.SelectedIndex >= 0 && DataGridView12.CurrentRow.Selected)
                {
                    DataGridView12.CurrentRow.Cells[5].Value=R12.SelectedItem;
                    R12.SelectedIndex=-1;

                    Time12Label.Text="";
                    Kind12Label.Text="";
                    Mab12Label.Text="";
                    Magh12Label.Text="";
                    DataGridView12.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void DataGridView22_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Time22Label.Text=DataGridView22.CurrentRow.Cells[1].Value.ToString();
                    Kind22Label.Text=DataGridView22.CurrentRow.Cells[2].Value.ToString();
                    Mab22Label.Text=DataGridView22.CurrentRow.Cells[3].Value.ToString();
                    Magh22Label.Text=DataGridView22.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Add4Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (R22.SelectedIndex >= 0 && DataGridView22.CurrentRow.Selected)
                {
                    DataGridView22.CurrentRow.Cells[5].Value=R22.SelectedItem;
                    R22.SelectedIndex=-1;

                    Time22Label.Text="";
                    Kind22Label.Text="";
                    Mab22Label.Text="";
                    Magh22Label.Text="";
                    DataGridView22.CurrentRow.Selected=false;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void Back2Button_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex=1;
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex=2;
        }

        public void Back1Button_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex=0;
        }

        public void TerminalPatternRegForm_Load(object sender, EventArgs e)
        {
            TabControl1.ItemSize=new Size(1, 1);

            Time11Label.Text="";
            Kind11Label.Text="";
            Mab11Label.Text="";
            Magh11Label.Text="";
            Time12Label.Text="";
            Kind12Label.Text="";
            Mab12Label.Text="";
            Magh12Label.Text="";
            Time21Label.Text="";
            Kind21Label.Text="";
            Mab21Label.Text="";
            Magh21Label.Text="";
            Time22Label.Text="";
            Kind22Label.Text="";
            Mab22Label.Text="";
            Magh22Label.Text="";
        }
    }
}
