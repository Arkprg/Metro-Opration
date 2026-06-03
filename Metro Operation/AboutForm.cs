using System;
using System.Reflection;

namespace Metro_Operation
{
    public partial class AboutForm : BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        public void OKButton_Click(object sender, EventArgs e)
        {
            AboutProgramForm showForm=new AboutProgramForm();
            showForm.ShowDialog(Owner);
        }

        public void AboutBox1_Load(object sender, EventArgs e)
        {
            Version version=Assembly.GetExecutingAssembly().GetName().Version;
            LabelVersion.Text="نسخه: " + "(" + MainForm.TrlTime + ") " + version.ToString();
        }
    }
}
