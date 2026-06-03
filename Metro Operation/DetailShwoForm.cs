using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class DetailShwoForm
    {
        public DetailShwoForm()
        {
            InitializeComponent();
        }

        public string Command="";
        public string Seprat=" - ";
        public string FName;
        public string Family;
        public string Pnum;
        public string Week="All"; // All | Friday | NonFriday

        public void DetailShwoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Command))
                {
                    return;
                }

                DataGridView1.Rows.Clear();

                using (OleDbConnection conn=new OleDbConnection(AppState.ConnectionString))
                {
                    conn.Open();
                    using (OleDbCommand cmd=new OleDbCommand(Command, conn))
                    using (OleDbDataReader reader=cmd.ExecuteReader())
                    {
                        int i=0;
                        while (reader.Read())
                        {
                            DateTime date=ConvertClass.ShamsiToMiladi(reader["Tarikh"].ToString());
                            DayOfWeek day=date.DayOfWeek;

                            // --- فیلتر روزها ---
                            if (Week == "Friday" && day != DayOfWeek.Friday)
                            {
                                continue;
                            }

                            if (Week == "NonFriday" && day == DayOfWeek.Friday)
                            {
                                continue;
                            }
                            // اگر Week == "All" بود، هیچ فیلتری اعمال نمی‌شود

                            string extra="";
                            if (!string.IsNullOrWhiteSpace(FName))
                            {
                                // --- افزودن ردیف ---
                                DataGridView1.Rows.Add(i + 1, $"{FName} {Family}", Pnum, reader[0].ToString(), reader[2].ToString(), reader[1].ToString());

                                // --- افزودن اطلاعات اضافه ---
                                for (int j=3; j < reader.FieldCount; j++)
                                {
                                    if (!string.IsNullOrWhiteSpace(reader[j].ToString()))
                                    {
                                        extra += (extra == "" ? " ( " : Seprat) + reader[j].ToString();
                                    }
                                }
                            }
                            else
                            {
                                // --- افزودن ردیف ---
                                DataGridView1.Rows.Add(i + 1, $"{reader[0]} {reader[1]}", reader[2], reader[3].ToString(),"", reader[4].ToString(), reader[5].ToString());

                                // --- افزودن اطلاعات اضافه ---
                                for (int j=6; j < reader.FieldCount; j++)
                                {
                                    if (!string.IsNullOrWhiteSpace(reader[j].ToString()))
                                    {
                                        extra += (extra == "" ? " ( " : Seprat) + reader[j].ToString();
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(extra))
                            {
                                DataGridView1.Rows[i].Cells[4].Value += extra + " )";
                            }

                            i++;
                        }
                    }
                }

                if (DataGridView1.Rows.Count > 0)
                {
                    DataGridView1.CurrentRow.Selected=false;
                }

                Command="";
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفاً دوباره تلاش کنید.", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
