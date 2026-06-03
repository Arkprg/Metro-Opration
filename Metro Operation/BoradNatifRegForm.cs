using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class BoradNatifRegForm
    {
        public BoradNatifRegForm()
        {
            InitializeComponent();
        }

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void BoradNatifRegForm_Load(object sender, EventArgs e)
        {
            StartCalendar.Today_Click(null, null);
            EndCalendar.LastDayOfMonth_Click(null, null);

            HtmlEditControl1.DocumentHTML="<body  style=\"background-color:Black;\"><p align=\"right\"><font Size=5 face=\"B Nazanin\"></font></p></body>";
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate1=ConvertClass.ShamsiToMiladi(StartCalendar.Text);
                DateTime SelectDate2=ConvertClass.ShamsiToMiladi(EndCalendar.Text);

                //if (!Information.IsDate(SelectDate1))
                //{
                //    ErrorShow(StartCalendar, "تاریخ نمایش اطلاعیه را مشخص کنید");
                //}
                //else if (!Information.IsDate(SelectDate2))
                //{
                //    ErrorShow(EndCalendar, "تاریخ پایان اطلاعیه را مشخص کنید");
                //}
                //else
                if (SelectDate1 < DateTime.Today)
                {
                    ErrorShow(StartCalendar, "تاریخ نمایش اطلاعیه صحیح نیست");
                }
                else if (SelectDate2 < SelectDate1)
                {
                    ErrorShow(StartCalendar, "مدت نمایش اطلاعیه صحیح نیست");
                    ErrorShow(EndCalendar, "مدت نمایش اطلاعیه صحیح نیست");
                }
                else if (HtmlEditControl1.DocumentHTML == "")
                {
                    ErrorShow(HtmlEditControl1, "متن اطلاعیه صحیح نیست");
                }
                else
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        using (OleDbCommand CMD=new OleDbCommand($"INSERT INTO BoardNotifi (Tarikh, Titr, Context, U_Reg, T_Reg, Vis) VALUES ('{StartCalendar.Text}', '{TitrBox.Text}', '{HtmlEditControl1.DocumentHTML.Replace("table", "table border='1'")}', '{AppState.UserName}', '{MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss")} ', True)", StrConnec))
                        {
                            CMD.ExecuteNonQuery();
                        }
                    }

                    MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
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
    }
}
