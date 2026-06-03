using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class OptimizationForm : BaseForm
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

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components=new System.ComponentModel.Container();
            this.Label1=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.Timer1=new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.ForeColor=System.Drawing.Color.White;
            this.Label1.Location=new System.Drawing.Point(133, 22);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(112, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="لطفا شکیبا باشید";
            // 
            // Label2
            // 
            this.Label2.Font=new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor=System.Drawing.Color.White;
            this.Label2.Location=new System.Drawing.Point(12, 50);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(355, 42);
            this.Label2.TabIndex=1;
            this.Label2.Text="برنامه در حال بهینه سازی داده ها می باشد . . .";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Interval=1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // OptimizationForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Blue;
            this.ClientSize=new System.Drawing.Size(380, 115);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            this.Margin=new System.Windows.Forms.Padding(4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="OptimizationForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="بهینه سازی";
            this.TopMost=true;
            this.Load += new System.EventHandler(this.OptimizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label Label1;
        private Label Label2;
        private Timer Timer1;
        private System.ComponentModel.IContainer components;
    }

}
