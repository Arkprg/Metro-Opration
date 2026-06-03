using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class FunctionRegisterForm
    {
        public FunctionRegisterForm()
        {
            InitializeComponent();
        }

        string PNa;
        string PFa;
        string PNum;

        public void ErrorShow(IWin32Window Contrl, string ErrorText)
        {
            ToolTip ErrorTip=new ToolTip()
            {
                IsBalloon=true,
                ToolTipIcon=ToolTipIcon.Error,
                ToolTipTitle="خطا"
            };
            ErrorTip.Show(ErrorText, Contrl);
            ErrorTip.Show(ErrorText, Contrl, 3000);
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime SelectDate=ShamsiToMiladi(PersianCalendar.Text);

                if (NameBox.Text == "")
                {
                    ErrorShow(NameBox, " نام پرسنل را مشخص کنید ");
                }
                else if (SelectDate == null)
                {
                    ErrorShow(PersianCalendar, "تاریخ صحیح نیست");
                }
                else if (!DateChecker(PersianCalendar.Text))
                {
                    ErrorShow(PersianCalendar, "تاریخ وارد شده در بازه قابل ثبت نیست");
                }
                else if (LevelCombo.SelectedIndex < 0)
                {
                    ErrorShow(LevelCombo, "نوع امتیاز را مشخص کنید");
                }
                else if (KindCombo.SelectedIndex < 0)
                {
                    ErrorShow(KindCombo, "عنوان امتیاز را مشخص کنید");
                }
                else if (MemBox.Text.Trim().Length < 10)
                {
                    ErrorShow(MemBox, "ارائه توضیحات تکمیلی الزامی است");
                }
                else
                {
                    Enabled=false;

                    using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                    {
                        StrConnec.Open();
                        string StrQuer="INSERT INTO Amal (P_Num, Tarikh, OnvAmal, Amal, Mem, U_Reg, T_Reg, Vis) VALUES ('" + PNum + "', '" + PersianCalendar.Text + "', '" + LevelCombo.SelectedItem + "', '" + KindCombo.SelectedItem + "', @Mem, '" + AppState.UserName + "', '" + MainForm.PersianToday.Tarikh() + " " + DateTime.Now.ToString("HH:mm:ss") + "', True)";

                        using (OleDbCommand CMD=new OleDbCommand(StrQuer, StrConnec))
                        {
                            CMD.Parameters.AddWithValue("@Mem", MemBox.Text.Trim());

                            CMD.ExecuteNonQuery();
                        }
                        // OptimizationForm.TotaEzafe(PNum, PersianCalendar.Text)  ' محاسبات قدیم
                    }

                    NameBox.Text="";
                    NameButton.Image=Properties.Resources.user;
                    LevelCombo.SelectedIndex=-1;
                    KindCombo.Items.Clear();
                    KindCombo.Text="";
                    MemBox.Text="";
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

        public void Button5_Click(object sender, EventArgs e)
        {
            // ErrorProvider1.Clear()
            NameBox.Text="";
            NameButton.Image=Properties.Resources.user;
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PNa=PersonalSelectForm.PName;
                PFa=PersonalSelectForm.PFamily;
                PNum=PersonalSelectForm.PNum;
                NameBox.Text=PNa + " " + PFa;
                NameButton.Image=Properties.Resources.cancel1;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FunctionRegisterForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0107");
        }

        public void Form13_Load(object sender, EventArgs e)
        {
            PersianCalendar.Today_Click(null, null);
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (Label5.Visible)
            {
                Label5.Visible=false;
            }
            else
            {
                Label5.Visible=true;
            }
        }

        private void LevelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LevelCombo.SelectedIndex == 0)
            {
                KindCombo.SelectedIndex=-1;
                KindCombo.Items.Clear();
                KindCombo.Items.Add("ارائه گزارش های فنی مناسب");
                KindCombo.Items.Add("اطلاع رسانی به موقع معایب قطار، خط و شبکه بالاسری");
                KindCombo.Items.Add("رفع معایب قطار در حداقل زمان (نظر کارشناسی)");
                KindCombo.Items.Add("هماهنگی در شرایط خاص");
                KindCombo.Items.Add("بازدید فنی مناسب قبل از حرکت");
                KindCombo.Items.Add("امتیاز مثبت (سایر)");
                KindCombo.Focus();
            }
            else
            {
                KindCombo.SelectedIndex=-1;
                KindCombo.Items.Clear();
                KindCombo.Items.Add("برخورد نامناسب با مسئولین و سایر همکاران");
                KindCombo.Items.Add("تعویض کشیک پس از پردازش لوحه");
                KindCombo.Items.Add("جابجایی حرکت بدون هماهنگی با مسئول وقت");
                KindCombo.Items.Add("حضور هر دو راهبر در لکوموتیو Master");
                KindCombo.Items.Add("خروج از محل کار بدون هماهنگی با مسئول وقت ");
                KindCombo.Items.Add("عدم ارائه گزارش تاخیر");
                KindCombo.Items.Add("عدم استفاده از لباس فرم");
                KindCombo.Items.Add("عدم اعلام حضور در محل کار به مسئول وقت");
                KindCombo.Items.Add("عدم بازدید فنی مناسب قبل از حرکت");
                KindCombo.Items.Add("عدم تحویل و تحول به موقع قطار");
                KindCombo.Items.Add("عدم حضور در محل کار (در زمان اضافه کار)");
                KindCombo.Items.Add("کشیدن سیگار در محل کار");
                KindCombo.Items.Add("نرسیدن به حرکت");
                KindCombo.Items.Add("امتیاز منفی (سایر)");
                KindCombo.Focus();
            }
        }
    }
}
