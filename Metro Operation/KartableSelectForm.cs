using System;

namespace Metro_Operation
{
    public partial class KartableSelectForm
    {
        public KartableSelectForm()
        {
            InitializeComponent();
        }

        public void TestButton_Click(object sender, EventArgs e)
        {
            ExamShowForm ShowForm=new ExamShowForm();
            ShowForm.ShowDialog(this);
            Close();
        }

        public void QuesButton_Click(object sender, EventArgs e)
        {
            ExamShowForm ShowForm=new ExamShowForm();
            ShowForm.ShowDialog(this);
            Close();
        }

        public void ElectionButton_Click(object sender, EventArgs e)
        {
            ElectionPartyForm ShowForm=new ElectionPartyForm();
            ShowForm.ShowDialog(this);
            Close();
        }

        public void KeshikButton_Click(object sender, EventArgs e)
        {
            KeshikReplaceForm ShowForm=new KeshikReplaceForm();
            ShowForm.ShowDialog(this);
            Close();
        }

        public void KartableSelectForm_Activated(object sender, EventArgs e)
        {
            if (KeshikButton.Visible && !TestButton.Visible && !ElectionButton.Visible && !QuesButton.Visible)
            {
                KeshikButton_Click(sender, e);
            }
            if (!KeshikButton.Visible && TestButton.Visible && !ElectionButton.Visible && !QuesButton.Visible)
            {
                TestButton_Click(sender, e);
            }
            if (!KeshikButton.Visible && !TestButton.Visible && ElectionButton.Visible && !QuesButton.Visible)
            {
                ElectionButton_Click(sender, e);
            }
            if (!KeshikButton.Visible && !TestButton.Visible && !ElectionButton.Visible && QuesButton.Visible)
            {
                QuesButton_Click(sender, e);
            }
        }
    }
}
