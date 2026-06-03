using System;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class CalendarFormAD : BaseForm
    {
        public CalendarFormAD()
        {
            InitializeComponent();

        }

        private readonly Taghvim PersianDate=new Taghvim();
        private Label LabelSelect;

        public void Display()
        {
            try
            {
                LabelPerDate.Text="";
                LabelHejDate.Text="";
                LabelMilDate.Text="";
                Label132.Text="";
                Label1333.Text="";

                foreach (Panel Pan in PanelA2.Controls)
                {
                    Pan.BackColor=Color.White;
                    foreach (Label Lab in Pan.Controls)
                    {
                        Lab.Text="";
                    }
                }

                MainLabel.Text=PersianDate.MonthName() + " " + PersianDate.Year();

                int i=0;
                int Da=1;

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Taghvim WHERE Tarikh LIKE '" + PersianDate.Tarikh().Substring(0, 8) + "%' ORDER BY Tarikh ASC", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {

                            if (i == 0)
                            {
                                i=int.Parse(Reader["Rooz"].ToString());
                            }

                            PanelA2.Controls["Panel" + i.ToString()].Controls[2].Text=Da.ToString();
                            PanelA2.Controls["Panel" + i.ToString()].Controls[1].Text=Reader["Sobh"].ToString();
                            //PanelA2.Controls("Panel" + i.ToString()).Controls(0).Text=Reader.Item("Asr").ToString

                            if (Reader["Rooz"].ToString() == "6")
                            {
                                PanelA2.Controls["Panel" + i.ToString()].BackColor=Color.NavajoWhite;
                            }
                            else if ((bool)Reader["Holi"] || Reader["Rooz"].ToString() == "7")
                            {
                                PanelA2.Controls["Panel" + i.ToString()].BackColor=Color.Tomato;
                            }
                            else if (Reader["kasri"].ToString() != "" && AppState.UserLevel < 1)
                            {
                                PanelA2.Controls["Panel" + i.ToString()].BackColor=Color.Khaki;
                            }
                            if (Reader["Tarikh"].ToString() == MainForm.PersianToday.Tarikh())
                            {
                                PanelA2.Controls["Panel" + i.ToString()].BackColor=Color.LightGreen;
                            }

                            Da++;
                            i++;
                        }
                    }
                }

                if (LabelD36.Text == "")
                {
                    PanelA2.Height=297;
                    Height=450;
                }
                else
                {
                    PanelA2.Height=357;
                    Height=510;
                }
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void DetailShow(string Days)
        {
            try
            {
                Label132.Text="";
                Label1333.Text="";

                PersianDate.SetDate(PersianDate.Tarikh().Substring(0, 8) + int.Parse(Days).ToString("00"));
                LabelPerDate.Text=PersianDate.DayWeek() + " " + PersianDate.Tarikh();
                LabelHejDate.Text=ConvertClass.MiladiToHejri(PersianDate.Miladi(), -2);
                LabelMilDate.Text=PersianDate.Miladi().ToString("dd/MM/yyyy");

                using (OleDbConnection StrConnec=new OleDbConnection(AppState.ConnectionString))
                {
                    StrConnec.Open();
                    using (OleDbCommand CMD=new OleDbCommand("SELECT * FROM Taghvim WHERE Tarikh='" + PersianDate.Tarikh() + "'", StrConnec))
                    using (OleDbDataReader Reader=CMD.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            Label132.Text="صبح: " + Reader["Sobh"].ToString() + "          عصر: " + Reader["Asr"].ToString();
                            if ((bool)Reader["Holi"])
                            {
                                Label1333.ForeColor=Color.Red;
                                Label1333.Text += Reader["mem"] + " (تعطیل)\n";
                            }
                            else
                            {
                                Label1333.ForeColor=Color.Black;
                                if (Reader["kasri"].ToString() != "" && AppState.UserLevel < 1)
                                {
                                    Label1333.Text += "کسر ساعت: " + Reader["kasri"].ToString() + "(" + Reader["mem"] + ")";
                                }
                            }
                        }
                    }
                }

                LabelPerDate.Font=FontManager.Gandom(16, FontStyle.Bold);
                LabelHejDate.Font=FontManager.Gandom(12, FontStyle.Bold);
                Label127.Font=Label132.Font=FontManager.Gandom(14, FontStyle.Bold);
                LabelMilDate.Font=FontManager.Tahoma(14);
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("لطفا دوباره تلاش کنید ", "خطا در اجرای دستور", MessageBoxIcon.Error);
            }
        }

        public void CalendarFormAD_Load(object sender, EventArgs e)
        {
            PersianDate.SetDate(MainForm.PersianToday.Tarikh());
            LabelG1.BackColor=Color.LightGreen;
            LabelG2.BackColor=Color.Khaki;
            LabelG3.BackColor=Color.SandyBrown;
            LabelG4.BackColor=Color.Tomato;

            Label01.BackColor=Label02.BackColor=Label03.BackColor=Label04.BackColor=Label05.BackColor=Label06.BackColor=Label07.BackColor=Color.LightSteelBlue;
            Label01.Font=Label02.Font=Label03.Font=Label04.Font=Label05.Font=Label06.Font=Label07.Font=FontManager.Gandom(8.5f);

            for (int i=1; i <= 42; i++)
            {
                if (Controls.Find($"LabelD{i}", true).FirstOrDefault() is Label lbl)
                {
                    lbl.Font=FontManager.Yekan(26);
                    lbl.TextAlign=ContentAlignment.TopCenter;
                }
            }

            if (AppState.UserLevel > 1)
            {
                LabelG2.Visible=false;
            }

            Display();
            DetailShow(PersianDate.Day().ToString());
        }

        public void PervButton_Click(object sender, EventArgs e)
        {
            PersianDate.AddMonth(-1);
            if (LabelSelect is object)
            {
                LabelSelect.Font=new Font(LabelSelect.Font, FontStyle.Regular);
                LabelSelect.ForeColor=Color.Black;
            }
            Display();
        }

        public void NextButton_Click(object sender, EventArgs e)
        {
            PersianDate.AddMonth(1);
            if (LabelSelect is object)
            {
                LabelSelect.Font=new Font(LabelSelect.Font, FontStyle.Regular);
                LabelSelect.ForeColor=Color.Black;
            }
            Display();
        }

        public void Label36_Click(object sender, EventArgs e)
        {
            LabelHejDate.Text="";
            LabelMilDate.Text="";
            LabelPerDate.Text="";
            Label132.Text="";
            Label1333.Text="";
            if (LabelSelect is object)
            {
                LabelSelect.Font=new Font(LabelSelect.Font, FontStyle.Regular);
                LabelSelect.ForeColor=Color.Black;
            }
            LabelSelect=(Label)sender;

            if (int.TryParse(LabelSelect.Text, out _))
            {
                DetailShow(LabelSelect.Text);
                LabelSelect.Font=new Font(LabelSelect.Font, FontStyle.Bold);
                LabelSelect.ForeColor=Color.FromArgb(0, 0, 200);
            }
        }

        public void LabelG1_Click(object sender, EventArgs e)
        {
            if (LabelSelect is object)
            {
                LabelSelect.Font=new Font(LabelSelect.Font, FontStyle.Regular);
                LabelSelect.ForeColor=Color.Black;
            }
            PersianDate.SetDate(MainForm.PersianToday.Tarikh());
            Display();
            DetailShow(PersianDate.Day().ToString());
        }
    }
}
