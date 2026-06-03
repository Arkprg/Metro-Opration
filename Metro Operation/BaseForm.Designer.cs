using System.Windows.Forms;

namespace Metro_Operation
{
    partial class BaseForm
    {
        private System.ComponentModel.IContainer components=null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ClientSize=new System.Drawing.Size(600, 400);
            this.DoubleBuffered=true;
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name="BaseForm";
            this.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.ResumeLayout(false);

        }
    }
}
