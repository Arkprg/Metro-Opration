using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class LoginForm : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Label1=new System.Windows.Forms.Label();
            this.LoginButton=new System.Windows.Forms.Button();
            this.ExitButton=new System.Windows.Forms.Button();
            this.Label2=new System.Windows.Forms.Label();
            this.PassBox=new System.Windows.Forms.TextBox();
            this.LinkLabel1=new System.Windows.Forms.LinkLabel();
            this.Panel1=new System.Windows.Forms.Panel();
            this.pictureBox2=new System.Windows.Forms.PictureBox();
            this.UserBox=new System.Windows.Forms.TextBox();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.Silver;
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.Location=new System.Drawing.Point(211, 18);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(68, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="نام کاربری:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.LoginButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Image=global::Metro_Operation.Properties.Resources.user__1_;
            this.LoginButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location=new System.Drawing.Point(159, 9);
            this.LoginButton.Margin=new System.Windows.Forms.Padding(2);
            this.LoginButton.Name="LoginButton";
            this.LoginButton.Size=new System.Drawing.Size(117, 34);
            this.LoginButton.TabIndex=2;
            this.LoginButton.Text="ورود";
            this.LoginButton.UseVisualStyleBackColor=false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightGray;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(10, 9);
            this.ExitButton.Margin=new System.Windows.Forms.Padding(2);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(131, 34);
            this.ExitButton.TabIndex=3;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.BackColor=System.Drawing.Color.Silver;
            this.Label2.ForeColor=System.Drawing.Color.Black;
            this.Label2.Location=new System.Drawing.Point(211, 51);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(67, 16);
            this.Label2.TabIndex=5;
            this.Label2.Text="کلمه عبور:";
            // 
            // PassBox
            // 
            this.PassBox.BackColor=System.Drawing.Color.White;
            this.PassBox.Location=new System.Drawing.Point(36, 48);
            this.PassBox.MaxLength=20;
            this.PassBox.Name="PassBox";
            this.PassBox.PasswordChar='*';
            this.PassBox.Size=new System.Drawing.Size(173, 23);
            this.PassBox.TabIndex=1;
            this.PassBox.Tag="";
            this.PassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassBox_KeyPress);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.BackColor=System.Drawing.Color.Transparent;
            this.LinkLabel1.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LinkLabel1.LinkColor=System.Drawing.Color.Blue;
            this.LinkLabel1.Location=new System.Drawing.Point(67, 88);
            this.LinkLabel1.Margin=new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkLabel1.Name="LinkLabel1";
            this.LinkLabel1.Size=new System.Drawing.Size(152, 20);
            this.LinkLabel1.TabIndex=4;
            this.LinkLabel1.TabStop=true;
            this.LinkLabel1.Text="فراموشی کلمه عبور !!!";
            this.LinkLabel1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.Silver;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.pictureBox2);
            this.Panel1.Controls.Add(this.LinkLabel1);
            this.Panel1.Controls.Add(this.PassBox);
            this.Panel1.Controls.Add(this.UserBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location=new System.Drawing.Point(9, 11);
            this.Panel1.Margin=new System.Windows.Forms.Padding(2);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(288, 119);
            this.Panel1.TabIndex=39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor=System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor=System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image=global::Metro_Operation.Properties.Resources.Eye;
            this.pictureBox2.Location=new System.Drawing.Point(12, 51);
            this.pictureBox2.Margin=new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name="pictureBox2";
            this.pictureBox2.Size=new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode=System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex=6;
            this.pictureBox2.TabStop=false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseUp);
            // 
            // UserBox
            // 
            this.UserBox.Location=new System.Drawing.Point(10, 15);
            this.UserBox.MaxLength=20;
            this.UserBox.Name="UserBox";
            this.UserBox.Size=new System.Drawing.Size(199, 23);
            this.UserBox.TabIndex=0;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.Silver;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.LoginButton);
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Location=new System.Drawing.Point(9, 135);
            this.Panel2.Margin=new System.Windows.Forms.Padding(2);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(288, 52);
            this.Panel2.TabIndex=40;
            // 
            // LoginForm
            // 
            this.AcceptButton=this.LoginButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(307, 199);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.Icon=((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin=new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="LoginForm";
            this.ShowIcon=false;
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="ورود";
            this.TopMost=true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Label Label1;
        private Button LoginButton;
        private Button ExitButton;
        private Label Label2;
        private TextBox PassBox;
        private LinkLabel LinkLabel1;
        private Panel Panel2;
        private Panel Panel1;
        private TextBox UserBox;
        private PictureBox pictureBox2;
    }
}
