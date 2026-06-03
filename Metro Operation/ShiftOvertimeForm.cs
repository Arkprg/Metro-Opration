using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using static Metro_Operation.ConvertClass;

namespace Metro_Operation
{

    public partial class ShiftOvertimeForm
    {
        public ShiftOvertimeForm()
        {
            InitializeComponent();
        }


        private readonly Taghvim PersianDate=new Taghvim(DateTime.Today);

        public static string EzafeSh(double Mova, string Kar, string Jom)
        {
            double karSh=TimeToDouble(Kar);
            double JomSh=TimeToDouble(Jom);
            //JomSh=0  // اضافه کار جمعه شیفت
            return DoubleToTime(karSh - Mova - JomSh, true);
        }

        public void DisPlay(string Dat)
        {
            try
            {

                double Movaz=0;
                double Day5=0;
                double RahSob9=0;
                double RahAsr9=0;
                double RahSob12=0;
                double RahAsr12=0;
                double RahPSob12=0;
                double RahPAsr12=0;
                double RahSet=0;
                double Mas12=0;

                switch (AppState.UserLnum)
                {
                    case "1":
                        RahSob9=11;
                        RahAsr9=11;
                        RahSob12=13;
                        RahAsr12=13;
                        RahSet=11;
                        Mas12=12;
                        break;

                    case "2":
                        RahSob9=10.5;
                        RahAsr9=10.5;
                        RahSob12=13;
                        RahAsr12=13;
                        RahSet=11;
                        Mas12=12;
                        break;

                    case "3":
                        RahSob9=11.5;
                        RahAsr9=11.5;
                        RahSob12=13;
                        RahAsr12=13;
                        RahSet=11;
                        Mas12=12;
                        break;

                    case "4":
                        RahSob9=9.25;
                        RahAsr9=13.25;
                        RahSob12=14.25;
                        RahAsr12=13.25;
                        RahSet=11.25;
                        Mas12=12;
                        break;

                    case "5":
                        RahSob9=13;
                        RahAsr9=13;
                        RahSet=13;
                        RahSob12=16;
                        RahAsr12=16;
                        RahPSob12=14;
                        RahPAsr12=14;
                        Mas12=12;
                        break;
                }

                //If ShamsiToMiladi(Ye & "/" & Mon & "/01") < "04/21/2017" And AppState.UserLnum=5 Then
                //    RahSob9=11
                //    RahAsr9=11
                //    RahSob12=13
                //    RahAsr12=13
                //    RahSet=11
                //    RahPSob12=12
                //    RahPAsr12=12
                //    Mas12=12
                //ElseIf ShamsiToMiladi(Ye & "/" & Mon & "/01") < "12/21/2019" And AppState.UserLnum=5 Then
                //    RahSob9=11.5
                //    RahAsr9=11.5
                //    RahSob12=13.75
                //    RahAsr12=13.5
                //    RahSet=11.5
                //    RahPSob12=12
                //    RahPAsr12=12
                //    Mas12=12
                //End If

                MonthTimeBox.Text="00:00";
                MonthWorkBox.Text="0";

                A9DaysBox.Text="0";
                B9DaysBox.Text="0";
                C9DaysBox.Text="0";
                A12DaysBox.Text="0";
                B12DaysBox.Text="0";
                C12DaysBox.Text="0";
                SetDaysBox.Text="0";
                AP12DaysBox.Text="0";
                BP12DaysBox.Text="0";
                CP12DaysBox.Text="0";
                AMDaysBox.Text="0";
                BMDaysBox.Text="0";
                CMDaysBox.Text="0";

                MonthOverBox.Text="00:00";

                A9TimeBox.Text="00:00";
                B9TimeBox.Text="00:00";
                C9TimeBox.Text="00:00";
                A12TimeBox.Text="00:00";
                B12TimeBox.Text="00:00";
                C12TimeBox.Text="00:00";
                SetTimeBox.Text="00:00";
                AP12TimeBox.Text="00:00";
                BP12TimeBox.Text="00:00";
                CP12TimeBox.Text="00:00";
                AMTimeBox.Text="00:00";
                BMTimeBox.Text="00:00";
                CMTimeBox.Text="00:00";

                A9FOverBox.Text="00:00";
                B9FOverBox.Text="00:00";
                C9FOverBox.Text="00:00";
                A12FOverBox.Text="00:00";
                B12FOverBox.Text="00:00";
                C12FOverBox.Text="00:00";
                SetFOverBox.Text="00:00";
                AP12FOverBox.Text="00:00";
                BP12FOverBox.Text="00:00";
                CP12FOverBox.Text="00:00";
                AMFOverBox.Text="00:00";
                BMFOverBox.Text="00:00";
                CMFOverBox.Text="00:00";

                A9OverBox.Text="00:00";
                B9OverBox.Text="00:00";
                C9OverBox.Text="00:00";
                A12OverBox.Text="00:00";
                B12OverBox.Text="00:00";
                C12OverBox.Text="00:00";
                SetOverBox.Text="00:00";
                AP12OverBox.Text="00:00";
                BP12OverBox.Text="00:00";
                CP12OverBox.Text="00:00";
                AMOverBox.Text="00:00";
                BMOverBox.Text="00:00";
                CMOverBox.Text="00:00";

                A9TotalBox.Text="00:00";
                B9TotalBox.Text="00:00";
                C9TotalBox.Text="00:00";
                A12TotalBox.Text="00:00";
                B12TotalBox.Text="00:00";
                C12TotalBox.Text="00:00";
                SetTotalBox.Text="00:00";
                AP12TotalBox.Text="00:00";
                BP12TotalBox.Text="00:00";
                CP12TotalBox.Text="00:00";
                AMTotalBox.Text="00:00";
                BMTotalBox.Text="00:00";
                CMTotalBox.Text="00:00";

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();

                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM ShKar WHERE Tarikh='" + Dat + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            MonthOverBox.Text=Reader["MonthTime"].ToString();
                            Movaz=Convert.ToByte(Reader["Rooz3"]) * 9 + Convert.ToByte(Reader["Rooz4"]) * 8;
                            Day5=Convert.ToByte(Reader["Rooz5"]) * 7.33;
                            if (TimeSpan.TryParse(Reader["Kasri"].ToString(), out _))
                            {
                                Movaz -= TimeToDouble(Reader["Kasri"].ToString());
                            }

                            Movaz -= Day5; // کسر تعطیلی پنجشنبه از موظفی ماه
                            Day5=0;

                            MonthTimeBox.Text=DoubleToTime(Movaz);
                            MonthWorkBox.Text=(Convert.ToByte(Reader["Rooz3"]) + Convert.ToByte(Reader["Rooz4"])).ToString();

                            A9DaysBox.Text=(Convert.ToByte(Reader["ASobh"]) + Convert.ToByte(Reader["AAsr"])).ToString(); //روز
                            B9DaysBox.Text=(Convert.ToByte(Reader["BSobh"]) + Convert.ToByte(Reader["BAsr"])).ToString();
                            C9DaysBox.Text=(Convert.ToByte(Reader["CSobh"]) + Convert.ToByte(Reader["CAsr"])).ToString();
                            A12DaysBox.Text=(Convert.ToByte(Reader["ASobh"]) + Convert.ToByte(Reader["AAsr"])).ToString();
                            B12DaysBox.Text=(Convert.ToByte(Reader["BSobh"]) + Convert.ToByte(Reader["BAsr"])).ToString();
                            C12DaysBox.Text=(Convert.ToByte(Reader["CSobh"]) + Convert.ToByte(Reader["CAsr"])).ToString();
                            SetDaysBox.Text=(Convert.ToByte(Reader["Rooz3"]) + Convert.ToByte(Reader["Rooz4"])).ToString(); //ستادی
                            AP12DaysBox.Text=(Convert.ToByte(Reader["ASobh"]) + Convert.ToByte(Reader["AAsr"])).ToString();
                            BP12DaysBox.Text=(Convert.ToByte(Reader["BSobh"]) + Convert.ToByte(Reader["BAsr"])).ToString();
                            CP12DaysBox.Text=(Convert.ToByte(Reader["CSobh"]) + Convert.ToByte(Reader["CAsr"])).ToString();
                            AMDaysBox.Text=(Convert.ToByte(Reader["ASobh"]) + Convert.ToByte(Reader["AAsr"])).ToString();
                            BMDaysBox.Text=(Convert.ToByte(Reader["BSobh"]) + Convert.ToByte(Reader["BAsr"])).ToString();
                            CMDaysBox.Text=(Convert.ToByte(Reader["CSobh"]) + Convert.ToByte(Reader["CAsr"])).ToString();

                            A9TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["ASobh"]) * RahSob9 + Convert.ToByte(Reader["AAsr"]) * RahAsr9); //کارکرد
                            B9TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["BSobh"]) * RahSob9 + Convert.ToByte(Reader["BAsr"]) * RahAsr9);
                            C9TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["CSobh"]) * RahSob9 + Convert.ToByte(Reader["CAsr"]) * RahAsr9);
                            A12TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["ASobh"]) * RahSob12 + Convert.ToByte(Reader["AAsr"]) * RahAsr12);
                            B12TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["BSobh"]) * RahSob12 + Convert.ToByte(Reader["BAsr"]) * RahAsr12);
                            C12TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["CSobh"]) * RahSob12 + Convert.ToByte(Reader["CAsr"]) * RahAsr12);
                            SetTimeBox.Text=DoubleToTime(Convert.ToByte(Reader["Rooz3"]) * RahSet + Convert.ToByte(Reader["Rooz4"]) * RahSet); //*
                            AP12TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["ASobh"]) * RahPSob12 + Convert.ToByte(Reader["AAsr"]) * RahPAsr12);
                            BP12TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["BSobh"]) * RahPSob12 + Convert.ToByte(Reader["BAsr"]) * RahPAsr12);
                            CP12TimeBox.Text=DoubleToTime(Convert.ToByte(Reader["CSobh"]) * RahPSob12 + Convert.ToByte(Reader["CAsr"]) * RahPAsr12);
                            AMTimeBox.Text=DoubleToTime(Convert.ToByte(Reader["ASobh"]) * Mas12 + Convert.ToByte(Reader["AAsr"]) * Mas12);
                            BMTimeBox.Text=DoubleToTime(Convert.ToByte(Reader["BSobh"]) * Mas12 + Convert.ToByte(Reader["BAsr"]) * Mas12);
                            CMTimeBox.Text=DoubleToTime(Convert.ToByte(Reader["CSobh"]) * Mas12 + Convert.ToByte(Reader["CAsr"]) * Mas12);

                            A9FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["AJom9"]) * 4, true); //// اضافه کار جمعه
                            B9FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["BJom9"]) * 4, true);
                            C9FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["CJom9"]) * 4, true);
                            A12FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["AJom12"]) * 5, true);
                            B12FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["BJom12"]) * 5, true);
                            C12FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["CJom12"]) * 5, true);
                            SetFOverBox.Text="0:0";
                            AP12FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["AJom12"]) * 5, true);
                            BP12FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["BJom12"]) * 5, true);
                            CP12FOverBox.Text=DoubleToTime(Convert.ToByte(Reader["CJom12"]) * 5, true);
                            AMFOverBox.Text=DoubleToTime(Convert.ToByte(Reader["AJom12"]) * 3, true);
                            BMFOverBox.Text=DoubleToTime(Convert.ToByte(Reader["BJom12"]) * 3, true);
                            CMFOverBox.Text=DoubleToTime(Convert.ToByte(Reader["CJom12"]) * 3, true);
                        }
                    }
                }


                A9OverBox.Text=EzafeSh(Movaz - Day5, A9TimeBox.Text, A9FOverBox.Text); //اضافه کار عادی
                B9OverBox.Text=EzafeSh(Movaz - Day5, B9TimeBox.Text, B9FOverBox.Text);
                C9OverBox.Text=EzafeSh(Movaz - Day5, C9TimeBox.Text, C9FOverBox.Text);
                A12OverBox.Text=EzafeSh(Movaz - Day5, A12TimeBox.Text, A12FOverBox.Text);
                B12OverBox.Text=EzafeSh(Movaz - Day5, B12TimeBox.Text, B12FOverBox.Text);
                C12OverBox.Text=EzafeSh(Movaz - Day5, C12TimeBox.Text, C12FOverBox.Text);
                SetOverBox.Text=EzafeSh(Movaz - Day5, SetTimeBox.Text, SetFOverBox.Text);
                AP12OverBox.Text=EzafeSh(Movaz - Day5, AP12TimeBox.Text, AP12FOverBox.Text);
                BP12OverBox.Text=EzafeSh(Movaz - Day5, BP12TimeBox.Text, BP12FOverBox.Text);
                CP12OverBox.Text=EzafeSh(Movaz - Day5, CP12TimeBox.Text, CP12FOverBox.Text);
                AMOverBox.Text=EzafeSh(Movaz - Day5, AMTimeBox.Text, AMFOverBox.Text);
                BMOverBox.Text=EzafeSh(Movaz - Day5, BMTimeBox.Text, BMFOverBox.Text);
                CMOverBox.Text=EzafeSh(Movaz - Day5, CMTimeBox.Text, CMFOverBox.Text);

                A9TotalBox.Text=DoubleToTime(TimeToDouble(A9FOverBox.Text) + TimeToDouble(A9OverBox.Text)); //مجموع اضافه کار
                B9TotalBox.Text=DoubleToTime(TimeToDouble(B9FOverBox.Text) + TimeToDouble(B9OverBox.Text));
                C9TotalBox.Text=DoubleToTime(TimeToDouble(C9FOverBox.Text) + TimeToDouble(C9OverBox.Text));
                A12TotalBox.Text=DoubleToTime(TimeToDouble(A12FOverBox.Text) + TimeToDouble(A12OverBox.Text));
                B12TotalBox.Text=DoubleToTime(TimeToDouble(B12FOverBox.Text) + TimeToDouble(B12OverBox.Text));
                C12TotalBox.Text=DoubleToTime(TimeToDouble(C12FOverBox.Text) + TimeToDouble(C12OverBox.Text));
                SetTotalBox.Text=DoubleToTime(TimeToDouble(SetFOverBox.Text) + TimeToDouble(SetOverBox.Text));
                AP12TotalBox.Text=DoubleToTime(TimeToDouble(AP12FOverBox.Text) + TimeToDouble(AP12OverBox.Text));
                BP12TotalBox.Text=DoubleToTime(TimeToDouble(BP12FOverBox.Text) + TimeToDouble(BP12OverBox.Text));
                CP12TotalBox.Text=DoubleToTime(TimeToDouble(CP12FOverBox.Text) + TimeToDouble(CP12OverBox.Text));
                AMTotalBox.Text=DoubleToTime(TimeToDouble(AMFOverBox.Text) + TimeToDouble(AMOverBox.Text));
                BMTotalBox.Text=DoubleToTime(TimeToDouble(BMFOverBox.Text) + TimeToDouble(BMOverBox.Text));
                CMTotalBox.Text=DoubleToTime(TimeToDouble(CMFOverBox.Text) + TimeToDouble(CMOverBox.Text));

                if (TimeToDouble(MonthTimeBox.Text) == 0 && int.Parse(MonthWorkBox.Text) == 0)
                {
                    MessageBoxFa.Show(" اطلاعات این ماه ثبت نشده است ", "خطا", MessageBoxIcon.Error);
                }
                TextBox00.Focus();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
                Close();
            }
        }

        public void ShiftOvertimeForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm", HelpNavigator.TopicId, "0401");
        }

        public void Form21_Load(object sender, EventArgs e)
        {
            YearCombo.Items.Add(PersianDate.Year() - 1);
            YearCombo.Items.Add(PersianDate.Year());
            if (PersianDate.Month() > 8)
            {
                YearCombo.Items.Add(PersianDate.Year() + 1);
            }

            YearCombo.Text=PersianDate.Year().ToString();
            PersianDate.SetDate(DateTime.Today);
            MonthCombo.SelectedIndex=PersianDate.Month() - 1;
            DisPlay(PersianDate.Tarikh().Substring(0, 7));
            BackColor=Color.White;
            if (AppState.UserLevel > 3)
            {
                Label8.Visible=false;
                MonthOverBox.Visible=false;
            }
            TextBox01.Font=TextBox02.Font=TextBox03.Font=TextBox04.Font=TextBox05.Font=FontManager.IranSans(9);

            foreach (Control c in Controls)
            {
                if (c is Panel Pnl) { Pnl.BackColor=Color.WhiteSmoke; Pnl.BorderStyle=BorderStyle.None; }
                //if (c is Label lbl) lbl.BorderStyle=BorderStyle.None;
            }
        }

        public void YearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthCombo.SelectedIndex=0;
        }

        public void MonthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearCombo.SelectedIndex >= 0 && MonthCombo.SelectedIndex >= 0)
            {
                PersianDate.SetDate(YearCombo.Text.Trim() + "/" + (MonthCombo.SelectedIndex + 1).ToString("00") + "/01");
                DisPlay(PersianDate.Tarikh().Substring(0, 7));
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            HelpForm ShowForm=new HelpForm();
            ShowForm.WebBrowser1.Navigate(MainForm.Path + "\\Help\\Hlp21.mht");
            ShowForm.ShowDialog(this);
        }

        public void PrevButton_Click(object sender, EventArgs e)
        {
            PersianDate.AddMonth(-1);
            YearCombo.Text=PersianDate.Year().ToString();
            MonthCombo.SelectedIndex=PersianDate.Month() - 1;
        }

        public void NextButton_Click(object sender, EventArgs e)
        {
            PersianDate.AddMonth(1);
            YearCombo.Text=PersianDate.Year().ToString();
            MonthCombo.SelectedIndex=PersianDate.Month() - 1;
        }
    }
}
