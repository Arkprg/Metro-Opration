using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class WaitForm : BaseForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.Container components=null;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
            this.PictureBox2=new System.Windows.Forms.PictureBox();
            this.Label1=new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image=((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location=new System.Drawing.Point(28, 24);
            this.PictureBox2.Name="PictureBox2";
            this.PictureBox2.Size=new System.Drawing.Size(105, 16);
            this.PictureBox2.SizeMode=System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex=5;
            this.PictureBox2.TabStop=false;
            // 
            // Label1
            // 
            this.Label1.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.Transparent;
            this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.Location=new System.Drawing.Point(147, 24);
            this.Label1.Name="Label1";
            this.Label1.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size=new System.Drawing.Size(146, 16);
            this.Label1.TabIndex=6;
            this.Label1.Text="در حال اجرای دستور...";
            // 
            // WaitForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.ClientSize=new System.Drawing.Size(320, 65);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="WaitForm";
            this.ShowIcon=false;
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="WaitForm";
            this.TopMost=true;
            this.Load += new System.EventHandler(this.WaitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox PictureBox2;
        private Label Label1;
    }

}
