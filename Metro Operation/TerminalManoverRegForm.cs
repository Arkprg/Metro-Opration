using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class TerminalManoverRegForm
    {
        public TerminalManoverRegForm()
        {
            InitializeComponent();
        }

        private string ManName;
        private string ManFamily;
        private string ManNum;
        private string PName;
        private string PFamily;
        private string PNum;

        private void ErrorShow(Control control, string message)
        {
            MainForm.ErrorTip.Show(message, control);
            MainForm.ErrorTip.Show(message, control, 3000);
        }

        public void TeamManagButton_Click(object sender, EventArgs e)
        {
            TeamManagBox.Text="";
            ManFamily="";
            ManName="";
            ManNum="";
            TeamNameButton.Image=Properties.Resources.user;
            PersonalSelectForm.Per="پایانه";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                ManFamily=PersonalSelectForm.PFamily;
                ManName=PersonalSelectForm.PName;
                ManNum=PersonalSelectForm.PNum;
                TeamManagBox.Text=ManName + " " + ManFamily;
                TeamManagButton.Image=Properties.Resources.cancel1;
            }
        }

        public void TeamNameButton_Click(object sender, EventArgs e)
        {
            TeamNameBox.Text="";
            TeamNameButton.Image=Properties.Resources.user;
            PersonalSelectForm.Per="پایانه";
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {

                PFamily=PersonalSelectForm.PFamily;
                PName=PersonalSelectForm.PName;
                PNum=PersonalSelectForm.PNum;
                TeamNameBox.Text=PName + " " + PFamily;
                TeamNameButton.Image=Properties.Resources.cancel1;
            }
        }

        public void TerminalManoverRegForm_Load(object sender, EventArgs e)
        {
            ManovrCalendar.Today_Click(null, null);
            RequstCalendar.Today_Click(null, null);
            StartLocaCombo.Items.Clear();
            EndLocaCombo.Items.Clear();

            string[] TehTerm=new string[] {
                    "خط 2 پارک 1 تهران",
                    "خط 2 پارک 2 تهران",
                    "خط 3 پارک 1 تهران",
                    "خط 3 پارک 2 تهران",
                    "چاله سرویس تهران"};

            string[] MehTerm=new string[] {
                        "خط 1 پارکینگ مهرشهر",
                        "خط 2 پارکینگ مهرشهر",
                        "خط 3 پارکینگ مهرشهر",
                        "خط 4 پارکینگ مهرشهر",
                        "خط 5 پارکینگ مهرشهر",
                        "خط 6 پارکینگ مهرشهر",
                        "خط 7 پارکینگ مهرشهر",
                        "خط 8 پارکینگ مهرشهر",
                        "خط 9 پارکینگ مهرشهر",
                        "خط 10 پارکینگ مهرشهر",
                        "دوار جنوبی 1 مهرشهر",
                        "دوار جنوبی 2 مهرشهر",
                        "دوار جنوبی 3 مهرشهر",
                        "دوار شمالی مهرشهر",
                        "خط 3 تعمیرات مهرشهر",
                        "خط 4 تعمیرات مهرشهر",
                        "خط 5 تعمیرات مهرشهر",
                        "بیرون خط 5 تعمیرات مهرشهر",
                        "خط 6 تعمیرات مهرشهر",
                        "بیرون خط 6 تعمیرات مهرشهر",
                        "خط 7 تعمیرات مهرشهر",
                        "بیرون خط 7 تعمیرات مهرشهر",
                        "خط 8 تعمیرات مهرشهر",
                        "خط 9 واگن سازی مهرشهر",
                        "خط 10 واگن سازی مهرشهر",
                        "خط 11 واگن سازی مهرشهر",
                        "خط 12 تراش مهرشهر",
                        "خط 13 سوله رنگ مهرشهر",
                        "خط 14 تعمیرات مهرشهر",
                        "خط 15 دیزل شاپ مهرشهر",
                        "خط 16 دیزل شاپ مهرشهر",
                        "خط 17 OCS مهرشهر",
                        "خط شمالی AG مهرشهر",
                        "خط جنوبی BG مهرشهر"};

            if (AppState.UserLevel < 3)
            {
                StartLocaCombo.Items.AddRange(TehTerm);
                StartLocaCombo.Items.AddRange(MehTerm);
            }
            else
            {
                if (AppState.UserLocal == "پایانه تهران")
                {
                    StartLocaCombo.Items.AddRange(TehTerm);
                }
                else
                {
                    StartLocaCombo.Items.AddRange(MehTerm);
                }
            }
            StartLocaCombo.Items.Add("طول خط");

            EndLocaCombo.Items.AddRange(StartLocaCombo.Items.Cast<string>().ToArray());
        }

        public void TeamAddButton_Click(object sender, EventArgs e)
        {
            TeamGridView.Rows.Add(PName, PFamily, PNum, TitleCombo.Text, "حذف");
            PName="";
            PFamily="";
            PNum="";
            TeamNameBox.Text="";
            TitleCombo.Text="";

            if (TeamGridView.Rows.Count > 0)
            {
                TeamGridView.CurrentRow.Selected=false;
            }
        }

        public void TeamGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                TeamGridView.Rows.RemoveAt(TeamGridView.CurrentRow.Index);
            }
            if (TeamGridView.Rows.Count > 0)
            {
                TeamGridView.CurrentRow.Selected=false;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void TrainCompltCheck_CheckedChanged(object sender, EventArgs e)
        {
            AcceptBox.Enabled=TrainCompltCheck.Checked;
        }

        public void StartBox_Leave(object sender, EventArgs e)
        {
            TimeLabel.Text="--:--";
            if (StartBox.Text == null && EndBox.Text == null)
            {
                double StartTime=ConvertClass.TimeToDouble(StartBox.Text);
                double EndTime=ConvertClass.TimeToDouble(EndBox.Text);

                if (StartTime > EndTime)
                {
                    TimeLabel.Text=ConvertClass.DoubleToTime(EndTime - StartTime + 24);
                }
                else
                {
                    TimeLabel.Text=ConvertClass.DoubleToTime(EndTime - StartTime);
                }
            }
        }
    }
}
