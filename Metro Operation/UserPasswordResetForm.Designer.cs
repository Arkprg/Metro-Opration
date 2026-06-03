using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public    partial class UserPasswordResetForm : BaseForm
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
            this.PersonBox=new TextBox();
             this.Label1=new Label();
            this.ResetButton=new Button();
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.LastLoginLabel=new Label();
            this.Label5=new Label();
            this.UserNameLabel=new Label();
            this.Label2=new Label();
            this.Panel1=new Panel();
            this.PersonalButton=new Button();
            this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
            this.Label3=new Label();
            this.Label4=new Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            //
            //PersonBox
            //
            this.PersonBox.Location=new System.Drawing.Point(91, 20);
            this.PersonBox.Margin=new Padding(5);
            this.PersonBox.MaxLength=50;
            this.PersonBox.Name="PersonBox";
            this.PersonBox.ReadOnly=true;
            this.PersonBox.Size=new System.Drawing.Size(185, 23);
            this.PersonBox.TabIndex=0;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(275, 23);
            this.Label1.Margin=new Padding(5, 0, 5, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(69, 16);
            this.Label1.TabIndex=2;
            this.Label1.Text="نام پرسنل:";
            //
            //ResetButton
            //
            this.ResetButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.ResetButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.ResetButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetButton.Cursor=Cursors.Hand;
            this.ResetButton.DialogResult=DialogResult.None;
            this.ResetButton.Location=new System.Drawing.Point(53, 180);
            this.ResetButton.Name="ResetButton";
            this.ResetButton.Size=new System.Drawing.Size(260, 31);
            this.ResetButton.TabIndex=2;
            this.ResetButton.Text="ریست";
            this.ResetButton.UseVisualStyleBackColor=false;
            //
            //LastLoginLabel
            //
            this.LastLoginLabel.Anchor=AnchorStyles.Top | AnchorStyles.Right;
            this.LastLoginLabel.Font=new System.Drawing.Font("Tahoma", (float)(11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.LastLoginLabel.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.LastLoginLabel.Location=new System.Drawing.Point(24, 34);
            this.LastLoginLabel.Margin=new Padding(5, 0, 5, 0);
            this.LastLoginLabel.Name="LastLoginLabel";
            this.LastLoginLabel.Size=new System.Drawing.Size(196, 28);
            this.LastLoginLabel.TabIndex=6;
            this.LastLoginLabel.Text="نام";
            this.LastLoginLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(220, 40);
            this.Label5.Margin=new Padding(5, 0, 5, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(99, 16);
            this.Label5.TabIndex=5;
            this.Label5.Text="تاریخ آخرین ورود:";
            //
            //UserNameLabel
            //
            this.UserNameLabel.Anchor=AnchorStyles.Top | AnchorStyles.Right;
            this.UserNameLabel.Font=new System.Drawing.Font("Tahoma", (float)(11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.UserNameLabel.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.UserNameLabel.Location=new System.Drawing.Point(24, 6);
            this.UserNameLabel.Margin=new Padding(5, 0, 5, 0);
            this.UserNameLabel.Name="UserNameLabel";
            this.UserNameLabel.Size=new System.Drawing.Size(196, 28);
            this.UserNameLabel.TabIndex=4;
            this.UserNameLabel.Text="نام";
            this.UserNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(220, 12);
            this.Label2.Margin=new Padding(5, 0, 5, 0);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(68, 16);
            this.Label2.TabIndex=3;
            this.Label2.Text="نام کاربری:";
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.LastLoginLabel);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.UserNameLabel);
            this.Panel1.Location=new System.Drawing.Point(16, 72);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(335, 98);
            this.Panel1.TabIndex=3;
            //
            //PersonalButton
            //
            this.PersonalButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.PersonalButton.Location=new System.Drawing.Point(61, 19);
            this.PersonalButton.Name="PersonalButton";
            this.PersonalButton.Size=new System.Drawing.Size(30, 25);
            this.PersonalButton.TabIndex=4;
            this.PersonalButton.UseVisualStyleBackColor=true;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(220, 68);
            this.Label3.Margin=new Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(99, 16);
            this.Label3.TabIndex=5;
            this.Label3.Text="تاریخ آخرین ورود:";
            //
            //Label4
            //
            this.Label4.Anchor=AnchorStyles.Top | AnchorStyles.Right;
            this.Label4.Font=new System.Drawing.Font("Tahoma", (float)(11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label4.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.Label4.Location=new System.Drawing.Point(24, 62);
            this.Label4.Margin=new Padding(5, 0, 5, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(196, 28);
            this.Label4.TabIndex=6;
            this.Label4.Text="نام";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //UserPasswordResetForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.ClientSize=new System.Drawing.Size(366, 217);
            this.Controls.Add(this.PersonalButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PersonBox);
            this.Controls.Add(this.Label1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="UserPasswordResetForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ریست رمز کاربران";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private TextBox PersonBox;
        private Label Label1;
        private Label LastLoginLabel;
        private Label Label5;
        private Label UserNameLabel;
        private Label Label2;
        private Button ResetButton;
        private Panel Panel1;
        private Button PersonalButton;
        private Label Label4;
        private Label Label3;
    }

}
