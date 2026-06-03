using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class AboutProgramForm : BaseForm
    {
        private System.ComponentModel.IContainer components=null;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            this.PictureBox1=new System.Windows.Forms.PictureBox();
            this.Label1=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.ExitButton=new System.Windows.Forms.Button();
            this.WebBrowser1=new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage=global::Metro_Operation.Properties.Resources.about1;
            this.PictureBox1.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Dock=System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location=new System.Drawing.Point(0, 0);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(576, 370);
            this.PictureBox1.TabIndex=0;
            this.PictureBox1.TabStop=false;
            // 
            // Label1
            // 
            this.Label1.BackColor=System.Drawing.Color.Black;
            this.Label1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font=new System.Drawing.Font("Tahoma", 12F);
            this.Label1.ForeColor=System.Drawing.Color.Yellow;
            this.Label1.Location=new System.Drawing.Point(34, 85);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(100, 27);
            this.Label1.TabIndex=2;
            this.Label1.Text="1395/03/01";
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor=System.Drawing.Color.Black;
            this.Label2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Font=new System.Drawing.Font("Tahoma", 12F);
            this.Label2.ForeColor=System.Drawing.Color.Yellow;
            this.Label2.Location=new System.Drawing.Point(255, 85);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(100, 27);
            this.Label2.TabIndex=3;
            this.Label2.Text="2.00.00.00";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImageLayout=System.Windows.Forms.ImageLayout.None;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources.close_24;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(464, 311);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.ExitButton.Size=new System.Drawing.Size(100, 33);
            this.ExitButton.TabIndex=4;
            this.ExitButton.Text="بستن";
            this.ExitButton.TextAlign=System.Drawing.ContentAlignment.TopRight;
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location=new System.Drawing.Point(10, 122);
            this.WebBrowser1.MinimumSize=new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name="WebBrowser1";
            this.WebBrowser1.Size=new System.Drawing.Size(438, 238);
            this.WebBrowser1.TabIndex=5;
            // 
            // AboutProgramForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(576, 370);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Font=new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            this.Name="AboutProgramForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="تغییرات";
            this.Load += new System.EventHandler(this.Aboutprogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox PictureBox1;
        private Label Label1;
        private Label Label2;
        private Button ExitButton;
        private WebBrowser WebBrowser1;
    }
}
