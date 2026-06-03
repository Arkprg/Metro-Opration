using System;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class HelpForm
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        public void HelpForm_Load(object sender, EventArgs e)
        {
            // WebBrowser1.Navigate(AppState.DatabasePath & "\Help\SeirHelp\index.htm")
            Help.ShowHelp(this, AppState.DatabasePath + "\\Help\\help.chm");
        }
    }
}
