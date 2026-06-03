using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UserEditForm : BaseForm
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
            this.Label1=new Label();
            this.UNameBox=new TextBox();
            this.Label5=new Label();
            this.ExitButton=new Button();
            this.RegButton=new Button();
            this.Panel1=new Panel();
            this.Panel4=new Panel();
            this.RadioButton4=new RadioButton();
            this.RadioButton3=new RadioButton();
            this.RadioButton2=new RadioButton();
            this.RadioButton1=new RadioButton();
            this.UnitCombo=new ComboBox();
            this.Label4=new Label();
            this.Label8=new Label();
            this.Panel2=new Panel();
            this.Panel3=new Panel();
            this.NameBox=new TextBox();
            this.NameButton=new Button();
            this.Panel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(202, 16);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(73, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="نام پرسنل :";
            // 
            // UNameBox
            // 
            this.UNameBox.Location=new System.Drawing.Point(29, 24);
            this.UNameBox.MaxLength=15;
            this.UNameBox.Name="UNameBox";
            this.UNameBox.Size=new System.Drawing.Size(160, 23);
            this.UNameBox.TabIndex=7;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(191, 27);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(68, 16);
            this.Label5.TabIndex=22;
            this.Label5.Text="نام کاربری:";
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(16, 11);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(85, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="    انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(142, 11);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(149, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.UnitCombo);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.UNameBox);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Location=new System.Drawing.Point(12, 87);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(305, 201);
            this.Panel1.TabIndex=1;
            // 
            // Panel4
            // 
            this.Panel4.BackColor=System.Drawing.Color.LightBlue;
            this.Panel4.BorderStyle=BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.RadioButton4);
            this.Panel4.Controls.Add(this.RadioButton3);
            this.Panel4.Controls.Add(this.RadioButton2);
            this.Panel4.Controls.Add(this.RadioButton1);
            this.Panel4.Enabled=false;
            this.Panel4.Location=new System.Drawing.Point(12, 96);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(281, 90);
            this.Panel4.TabIndex=28;
            // 
            // RadioButton4
            // 
            this.RadioButton4.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton4.AutoSize=true;
            this.RadioButton4.Location=new System.Drawing.Point(87, 57);
            this.RadioButton4.Name="RadioButton4";
            this.RadioButton4.Size=new System.Drawing.Size(41, 20);
            this.RadioButton4.TabIndex=0;
            this.RadioButton4.Text="---";
            this.RadioButton4.UseVisualStyleBackColor=true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton3.AutoSize=true;
            this.RadioButton3.Location=new System.Drawing.Point(228, 57);
            this.RadioButton3.Name="RadioButton3";
            this.RadioButton3.Size=new System.Drawing.Size(41, 20);
            this.RadioButton3.TabIndex=0;
            this.RadioButton3.Text="---";
            this.RadioButton3.UseVisualStyleBackColor=true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton2.AutoSize=true;
            this.RadioButton2.Location=new System.Drawing.Point(87, 15);
            this.RadioButton2.Name="RadioButton2";
            this.RadioButton2.Size=new System.Drawing.Size(41, 20);
            this.RadioButton2.TabIndex=0;
            this.RadioButton2.Text="---";
            this.RadioButton2.UseVisualStyleBackColor=true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.Anchor=((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.RadioButton1.AutoSize=true;
            this.RadioButton1.Checked=true;
            this.RadioButton1.Location=new System.Drawing.Point(228, 15);
            this.RadioButton1.Name="RadioButton1";
            this.RadioButton1.Size=new System.Drawing.Size(41, 20);
            this.RadioButton1.TabIndex=0;
            this.RadioButton1.TabStop=true;
            this.RadioButton1.Text="---";
            this.RadioButton1.UseVisualStyleBackColor=true;
            // 
            // UnitCombo
            // 
            this.UnitCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.UnitCombo.FormattingEnabled=true;
            this.UnitCombo.Items.AddRange(new object[] {
            "مدیریت",
            "سیر و حرکت",
            "پایانه"});
            this.UnitCombo.Location=new System.Drawing.Point(29, 57);
            this.UnitCombo.Name="UnitCombo";
            this.UnitCombo.Size=new System.Drawing.Size(160, 24);
            this.UnitCombo.TabIndex=27;
            this.UnitCombo.SelectedIndexChanged += new System.EventHandler(this.UnitCombo_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(191, 61);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(82, 16);
            this.Label4.TabIndex=26;
            this.Label4.Text="واحد خدمتی:";
            // 
            // Label8
            // 
            this.Label8.BackColor=System.Drawing.Color.Gray;
            this.Label8.BorderStyle=BorderStyle.FixedSingle;
            this.Label8.ForeColor=System.Drawing.Color.White;
            this.Label8.Location=new System.Drawing.Point(222, 74);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(82, 24);
            this.Label8.TabIndex=54;
            this.Label8.Text="سطح کاربری";
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Location=new System.Drawing.Point(12, 300);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(305, 58);
            this.Panel2.TabIndex=2;
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.NameBox);
            this.Panel3.Controls.Add(this.NameButton);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Location=new System.Drawing.Point(12, 13);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(305, 53);
            this.Panel3.TabIndex=0;
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(70, 13);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(132, 23);
            this.NameBox.TabIndex=16;
            this.NameBox.TabStop=false;
            // 
            // NameButton
            // 
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(40, 12);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=15;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // UserEditForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(327, 365);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="UserEditForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ویرایش مشخصات کاربران";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        private Label Label1;
        private TextBox UNameBox;
        private Label Label5;
        private Button ExitButton;
        private Button RegButton;
        private Panel Panel1;
        private Label Label8;
        private Panel Panel2;
        private Panel Panel3;
        private TextBox NameBox;
        private Button NameButton;
        private ComboBox UnitCombo;
        private Label Label4;
        private Panel Panel4;
        private RadioButton RadioButton4;
        private RadioButton RadioButton3;
        private RadioButton RadioButton2;
        private RadioButton RadioButton1;
    }

}
