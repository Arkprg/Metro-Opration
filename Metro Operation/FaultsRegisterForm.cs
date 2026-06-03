using System;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class FaultsRegisterForm
    {
        public FaultsRegisterForm()
        {
            InitializeComponent();
        }

        string PN;
        string PF;
        string PNu;
        string PT;
        string PP;
        //string EzTim;

        public void FaultsRegForm_Load(object sender, EventArgs e)
        {
            foreach (string Local in MainForm.Locals)
            {
                if (!string.IsNullOrEmpty(Local))
                {
                    LocalCombo.Items.Add(Local);
                }
            }
            if (LocalCombo.Items.Count > 0)
            {
                LocalCombo.SelectedIndex=0;
            }

            PersianCalendar.Today_Click(null, null);
        }

        public void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CancelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CancelCheckBox.Checked)
            {
                EmptyCheckBox.Checked=false;
                EmptyCheckBox.Enabled=false;
            }
            else
            {
                EmptyCheckBox.Enabled=true;
            }
        }

        public void EmptyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmptyCheckBox.Checked)
            {
                CancelCheckBox.Checked=false;
                CancelCheckBox.Enabled=false;
            }
            else
            {
                CancelCheckBox.Enabled=true;
            }
        }

        public void RegButton_Click(object sender, EventArgs e)
        {
            MessageBoxFa.Show("ثبت با موفقیت انجام شد", "تایید", MessageBoxIcon.Information);
        }

        public void R_SelectButton_Click(object sender, EventArgs e)
        {
            PersonalSelectForm ShowForm=new PersonalSelectForm();
            if (ShowForm.ShowDialog() == DialogResult.OK)
            {
                PF=PersonalSelectForm.PFamily;
                PN=PersonalSelectForm.PName;
                PNu=PersonalSelectForm.PNum;
                PT=PersonalSelectForm.PTime;
                PP=PersonalSelectForm.PPost;
                R_NameTextBox.Text=PN + " " + PF;
            }

        }
    }
}
