using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UserRegisterForm : BaseForm
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
            this.RegButton=new Button();
            this.ExitButton=new Button();
            this.NameButton=new Button();
            this.UPassBox=new TextBox();
            this.UNameBox=new TextBox();
            this.NameBox=new TextBox();
            this.Label5=new Label();
            this.Label2=new Label();
            this.Label1=new Label();
            this.Panel1=new Panel();
            this.UnitCombo=new ComboBox();
            this.Label8=new Label();
            this.Label6=new Label();
            this.Label7=new Label();
            this.Panel3=new Panel();
            this.RadioButton1=new RadioButton();
            this.Panel2=new Panel();
            this.RadioButton4=new RadioButton();
            this.RadioButton3=new RadioButton();
            this.RadioButton2=new RadioButton();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.ForeColor=System.Drawing.Color.Black;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(137, 11);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(148, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.DialogResult=DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(13, 11);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(91, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="    انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NameButton
            // 
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(10, 26);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=0;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // UPassBox
            // 
            this.UPassBox.Location=new System.Drawing.Point(12, 151);
            this.UPassBox.MaxLength=15;
            this.UPassBox.Name="UPassBox";
            this.UPassBox.Size=new System.Drawing.Size(160, 23);
            this.UPassBox.TabIndex=3;
            // 
            // UNameBox
            // 
            this.UNameBox.Location=new System.Drawing.Point(12, 110);
            this.UNameBox.MaxLength=20;
            this.UNameBox.Name="UNameBox";
            this.UNameBox.Size=new System.Drawing.Size(160, 23);
            this.UNameBox.TabIndex=2;
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(40, 27);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(132, 23);
            this.NameBox.TabIndex=14;
            this.NameBox.TabStop=false;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(174, 30);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(73, 16);
            this.Label5.TabIndex=19;
            this.Label5.Text="نام پرسنل :";
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(174, 154);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(67, 16);
            this.Label2.TabIndex=16;
            this.Label2.Text="کلمه عبور:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(174, 113);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(68, 16);
            this.Label1.TabIndex=15;
            this.Label1.Text="نام کاربری:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.UPassBox);
            this.Panel1.Controls.Add(this.UNameBox);
            this.Panel1.Controls.Add(this.UnitCombo);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Location=new System.Drawing.Point(320, 26);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(265, 202);
            this.Panel1.TabIndex=0;
            // 
            // UnitCombo
            // 
            this.UnitCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.UnitCombo.FormattingEnabled=true;
            this.UnitCombo.Items.AddRange(new object[] {
            "مدیریت",
            "سیر و حرکت",
            "پایانه"});
            this.UnitCombo.Location=new System.Drawing.Point(12, 68);
            this.UnitCombo.Name="UnitCombo";
            this.UnitCombo.Size=new System.Drawing.Size(160, 24);
            this.UnitCombo.TabIndex=1;
            this.UnitCombo.SelectedIndexChanged += new System.EventHandler(this.UnitCombo_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(174, 72);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(82, 16);
            this.Label8.TabIndex=19;
            this.Label8.Text="واحد خدمتی:";
            // 
            // Label6
            // 
            this.Label6.BackColor=System.Drawing.Color.Gray;
            this.Label6.BorderStyle=BorderStyle.FixedSingle;
            this.Label6.Cursor=Cursors.Default;
            this.Label6.ForeColor=System.Drawing.Color.White;
            this.Label6.Location=new System.Drawing.Point(211, 16);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(84, 22);
            this.Label6.TabIndex=23;
            this.Label6.Text="سطح کاربری";
            // 
            // Label7
            // 
            this.Label7.BackColor=System.Drawing.Color.Gray;
            this.Label7.BorderStyle=BorderStyle.FixedSingle;
            this.Label7.Cursor=Cursors.Default;
            this.Label7.ForeColor=System.Drawing.Color.White;
            this.Label7.Location=new System.Drawing.Point(499, 16);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(72, 22);
            this.Label7.TabIndex=24;
            this.Label7.Text="مشخصات ";
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Location=new System.Drawing.Point(10, 168);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(304, 60);
            this.Panel3.TabIndex=2;
            // 
            // RadioButton1
            // 
            this.RadioButton1.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton1.AutoSize=true;
            this.RadioButton1.Checked=true;
            this.RadioButton1.Location=new System.Drawing.Point(246, 34);
            this.RadioButton1.Name="RadioButton1";
            this.RadioButton1.Size=new System.Drawing.Size(41, 20);
            this.RadioButton1.TabIndex=0;
            this.RadioButton1.TabStop=true;
            this.RadioButton1.Text="---";
            this.RadioButton1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton1.UseVisualStyleBackColor=true;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.RadioButton4);
            this.Panel2.Controls.Add(this.RadioButton3);
            this.Panel2.Controls.Add(this.RadioButton2);
            this.Panel2.Controls.Add(this.RadioButton1);
            this.Panel2.Enabled=false;
            this.Panel2.Location=new System.Drawing.Point(10, 26);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(304, 130);
            this.Panel2.TabIndex=1;
            // 
            // RadioButton4
            // 
            this.RadioButton4.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton4.AutoSize=true;
            this.RadioButton4.Location=new System.Drawing.Point(93, 81);
            this.RadioButton4.Name="RadioButton4";
            this.RadioButton4.Size=new System.Drawing.Size(41, 20);
            this.RadioButton4.TabIndex=0;
            this.RadioButton4.Text="---";
            this.RadioButton4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton4.UseVisualStyleBackColor=true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton3.AutoSize=true;
            this.RadioButton3.Location=new System.Drawing.Point(246, 81);
            this.RadioButton3.Name="RadioButton3";
            this.RadioButton3.Size=new System.Drawing.Size(41, 20);
            this.RadioButton3.TabIndex=0;
            this.RadioButton3.Text="---";
            this.RadioButton3.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton3.UseVisualStyleBackColor=true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton2.AutoSize=true;
            this.RadioButton2.Location=new System.Drawing.Point(93, 34);
            this.RadioButton2.Name="RadioButton2";
            this.RadioButton2.Size=new System.Drawing.Size(41, 20);
            this.RadioButton2.TabIndex=0;
            this.RadioButton2.Text="---";
            this.RadioButton2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton2.UseVisualStyleBackColor=true;
            // 
            // UserRegisterForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(598, 241);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="UserRegisterForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="کاربر جدید";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        private Button RegButton;
        private Button ExitButton;
        private Button NameButton;
        private TextBox UPassBox;
        private TextBox UNameBox;
        private TextBox NameBox;
        private Label Label5;
        private Label Label2;
        private Label Label1;
        private Panel Panel1;
        private Label Label6;
        private Label Label7;
        private Panel Panel3;
        private Panel Panel2;
        private ComboBox UnitCombo;
        private Label Label8;
        private RadioButton RadioButton1;
        private RadioButton RadioButton4;
        private RadioButton RadioButton3;
        private RadioButton RadioButton2;
    }

}
