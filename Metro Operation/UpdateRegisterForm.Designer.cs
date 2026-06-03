using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UpdateRegisterForm : BaseForm
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
            this.ChrCountLabel=new System.Windows.Forms.Label();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.ShowCheck=new System.Windows.Forms.CheckBox();
            this.UpdateCheck=new System.Windows.Forms.CheckBox();
            this.Panel3=new System.Windows.Forms.Panel();
            this.ExitButton=new System.Windows.Forms.Button();
            this.RegButton=new System.Windows.Forms.Button();
            this.Label10=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.Box10=new System.Windows.Forms.TextBox();
            this.Box9=new System.Windows.Forms.TextBox();
            this.Label14=new System.Windows.Forms.Label();
            this.Label15=new System.Windows.Forms.Label();
            this.Box8=new System.Windows.Forms.TextBox();
            this.Box7=new System.Windows.Forms.TextBox();
            this.Box6=new System.Windows.Forms.TextBox();
            this.Box5=new System.Windows.Forms.TextBox();
            this.Box4=new System.Windows.Forms.TextBox();
            this.Box3=new System.Windows.Forms.TextBox();
            this.Box2=new System.Windows.Forms.TextBox();
            this.Box1=new System.Windows.Forms.TextBox();
            this.Label7=new System.Windows.Forms.Label();
            this.Label12=new System.Windows.Forms.Label();
            this.Label13=new System.Windows.Forms.Label();
            this.Label9=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.TimeBox=new System.Windows.Forms.MaskedTextBox();
            this.VersionBox=new System.Windows.Forms.MaskedTextBox();
            this.Label3=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChrCountLabel
            // 
            this.ChrCountLabel.AutoSize=true;
            this.ChrCountLabel.Location=new System.Drawing.Point(12, 80);
            this.ChrCountLabel.Name="ChrCountLabel";
            this.ChrCountLabel.Size=new System.Drawing.Size(29, 16);
            this.ChrCountLabel.TabIndex=2;
            this.ChrCountLabel.Text="255";
            this.ChrCountLabel.Click += new System.EventHandler(this.ChrCountLabel_Click);
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(123, 15);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShowCheck
            // 
            this.ShowCheck.AutoSize=true;
            this.ShowCheck.Enabled=false;
            this.ShowCheck.Location=new System.Drawing.Point(144, 54);
            this.ShowCheck.Name="ShowCheck";
            this.ShowCheck.Size=new System.Drawing.Size(113, 20);
            this.ShowCheck.TabIndex=52;
            this.ShowCheck.Text="قابلیت مشاهده";
            this.ShowCheck.UseVisualStyleBackColor=true;
            // 
            // UpdateCheck
            // 
            this.UpdateCheck.AutoSize=true;
            this.UpdateCheck.Location=new System.Drawing.Point(317, 54);
            this.UpdateCheck.Name="UpdateCheck";
            this.UpdateCheck.Size=new System.Drawing.Size(128, 20);
            this.UpdateCheck.TabIndex=51;
            this.UpdateCheck.Text="قابلیت بروز رسانی";
            this.UpdateCheck.UseVisualStyleBackColor=true;
            this.UpdateCheck.CheckedChanged += new System.EventHandler(this.ShowCheck_CheckedChanged);
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Location=new System.Drawing.Point(7, 453);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(439, 64);
            this.Panel3.TabIndex=50;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(18, 13);
            this.ExitButton.Margin=new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(132, 39);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(207, 13);
            this.RegButton.Margin=new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(194, 39);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Label10
            // 
            this.Label10.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label10.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Cursor=System.Windows.Forms.Cursors.Default;
            this.Label10.Location=new System.Drawing.Point(382, 86);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(56, 22);
            this.Label10.TabIndex=48;
            this.Label10.Text="تغییرات";
            this.Label10.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Box10);
            this.Panel1.Controls.Add(this.Box9);
            this.Panel1.Controls.Add(this.Label14);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.Box8);
            this.Panel1.Controls.Add(this.Box7);
            this.Panel1.Controls.Add(this.Box6);
            this.Panel1.Controls.Add(this.Box5);
            this.Panel1.Controls.Add(this.Box4);
            this.Panel1.Controls.Add(this.Box3);
            this.Panel1.Controls.Add(this.Box2);
            this.Panel1.Controls.Add(this.Box1);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Location=new System.Drawing.Point(7, 100);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(439, 342);
            this.Panel1.TabIndex=47;
            // 
            // Box10
            // 
            this.Box10.Enabled=false;
            this.Box10.Location=new System.Drawing.Point(18, 308);
            this.Box10.Name="Box10";
            this.Box10.Size=new System.Drawing.Size(381, 23);
            this.Box10.TabIndex=61;
            this.Box10.TextChanged += new System.EventHandler(this.Box10_TextChanged);
            // 
            // Box9
            // 
            this.Box9.Enabled=false;
            this.Box9.Location=new System.Drawing.Point(18, 276);
            this.Box9.Name="Box9";
            this.Box9.Size=new System.Drawing.Size(381, 23);
            this.Box9.TabIndex=60;
            this.Box9.TextChanged += new System.EventHandler(this.Box9_TextChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize=true;
            this.Label14.BackColor=System.Drawing.Color.Transparent;
            this.Label14.ForeColor=System.Drawing.Color.Black;
            this.Label14.Location=new System.Drawing.Point(401, 279);
            this.Label14.Margin=new System.Windows.Forms.Padding(0);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(20, 16);
            this.Label14.TabIndex=59;
            this.Label14.Text="9)";
            this.Label14.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.AutoSize=true;
            this.Label15.BackColor=System.Drawing.Color.Transparent;
            this.Label15.ForeColor=System.Drawing.Color.Black;
            this.Label15.Location=new System.Drawing.Point(401, 311);
            this.Label15.Margin=new System.Windows.Forms.Padding(0);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(27, 16);
            this.Label15.TabIndex=58;
            this.Label15.Text="10)";
            this.Label15.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Box8
            // 
            this.Box8.Enabled=false;
            this.Box8.Location=new System.Drawing.Point(18, 244);
            this.Box8.Name="Box8";
            this.Box8.Size=new System.Drawing.Size(381, 23);
            this.Box8.TabIndex=57;
            this.Box8.TextChanged += new System.EventHandler(this.Box8_TextChanged);
            // 
            // Box7
            // 
            this.Box7.Enabled=false;
            this.Box7.Location=new System.Drawing.Point(18, 212);
            this.Box7.Name="Box7";
            this.Box7.Size=new System.Drawing.Size(381, 23);
            this.Box7.TabIndex=56;
            this.Box7.TextChanged += new System.EventHandler(this.Box7_TextChanged);
            // 
            // Box6
            // 
            this.Box6.Enabled=false;
            this.Box6.Location=new System.Drawing.Point(18, 180);
            this.Box6.Name="Box6";
            this.Box6.Size=new System.Drawing.Size(381, 23);
            this.Box6.TabIndex=55;
            this.Box6.TextChanged += new System.EventHandler(this.Box6_TextChanged);
            // 
            // Box5
            // 
            this.Box5.Enabled=false;
            this.Box5.Location=new System.Drawing.Point(18, 148);
            this.Box5.Name="Box5";
            this.Box5.Size=new System.Drawing.Size(381, 23);
            this.Box5.TabIndex=54;
            this.Box5.TextChanged += new System.EventHandler(this.Box5_TextChanged);
            // 
            // Box4
            // 
            this.Box4.Enabled=false;
            this.Box4.Location=new System.Drawing.Point(18, 116);
            this.Box4.Name="Box4";
            this.Box4.Size=new System.Drawing.Size(381, 23);
            this.Box4.TabIndex=53;
            this.Box4.TextChanged += new System.EventHandler(this.Box4_TextChanged);
            // 
            // Box3
            // 
            this.Box3.Enabled=false;
            this.Box3.Location=new System.Drawing.Point(18, 84);
            this.Box3.Name="Box3";
            this.Box3.Size=new System.Drawing.Size(381, 23);
            this.Box3.TabIndex=52;
            this.Box3.TextChanged += new System.EventHandler(this.Box3_TextChanged);
            // 
            // Box2
            // 
            this.Box2.Enabled=false;
            this.Box2.Location=new System.Drawing.Point(18, 52);
            this.Box2.Name="Box2";
            this.Box2.Size=new System.Drawing.Size(381, 23);
            this.Box2.TabIndex=51;
            this.Box2.TextChanged += new System.EventHandler(this.Box2_TextChanged);
            // 
            // Box1
            // 
            this.Box1.Location=new System.Drawing.Point(18, 20);
            this.Box1.Name="Box1";
            this.Box1.Size=new System.Drawing.Size(381, 23);
            this.Box1.TabIndex=50;
            this.Box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.ForeColor=System.Drawing.Color.Black;
            this.Label7.Location=new System.Drawing.Point(401, 215);
            this.Label7.Margin=new System.Windows.Forms.Padding(0);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(20, 16);
            this.Label7.TabIndex=39;
            this.Label7.Text="7)";
            this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.AutoSize=true;
            this.Label12.BackColor=System.Drawing.Color.Transparent;
            this.Label12.ForeColor=System.Drawing.Color.Black;
            this.Label12.Location=new System.Drawing.Point(401, 247);
            this.Label12.Margin=new System.Windows.Forms.Padding(0);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(20, 16);
            this.Label12.TabIndex=38;
            this.Label12.Text="8)";
            this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            this.Label13.AutoSize=true;
            this.Label13.BackColor=System.Drawing.Color.Transparent;
            this.Label13.ForeColor=System.Drawing.Color.Black;
            this.Label13.Location=new System.Drawing.Point(401, 183);
            this.Label13.Margin=new System.Windows.Forms.Padding(0);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(20, 16);
            this.Label13.TabIndex=37;
            this.Label13.Text="6)";
            this.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.BackColor=System.Drawing.Color.Transparent;
            this.Label9.ForeColor=System.Drawing.Color.Black;
            this.Label9.Location=new System.Drawing.Point(401, 55);
            this.Label9.Margin=new System.Windows.Forms.Padding(0);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(20, 16);
            this.Label9.TabIndex=36;
            this.Label9.Text="2)";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.BackColor=System.Drawing.Color.Transparent;
            this.Label5.ForeColor=System.Drawing.Color.Black;
            this.Label5.Location=new System.Drawing.Point(401, 87);
            this.Label5.Margin=new System.Windows.Forms.Padding(0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(20, 16);
            this.Label5.TabIndex=35;
            this.Label5.Text="3)";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.ForeColor=System.Drawing.Color.Black;
            this.Label4.Location=new System.Drawing.Point(401, 24);
            this.Label4.Margin=new System.Windows.Forms.Padding(0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(20, 16);
            this.Label4.TabIndex=31;
            this.Label4.Text="1)";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.BackColor=System.Drawing.Color.Transparent;
            this.Label6.ForeColor=System.Drawing.Color.Black;
            this.Label6.Location=new System.Drawing.Point(401, 119);
            this.Label6.Margin=new System.Windows.Forms.Padding(0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(20, 16);
            this.Label6.TabIndex=34;
            this.Label6.Text="4)";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.BackColor=System.Drawing.Color.Transparent;
            this.Label8.ForeColor=System.Drawing.Color.Black;
            this.Label8.Location=new System.Drawing.Point(401, 151);
            this.Label8.Margin=new System.Windows.Forms.Padding(0);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(20, 16);
            this.Label8.TabIndex=33;
            this.Label8.Text="5)";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeBox
            // 
            this.TimeBox.Location=new System.Drawing.Point(12, 15);
            this.TimeBox.Mask="00:00";
            this.TimeBox.Name="TimeBox";
            this.TimeBox.Size=new System.Drawing.Size(48, 23);
            this.TimeBox.TabIndex=6;
            this.TimeBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // VersionBox
            // 
            this.VersionBox.Location=new System.Drawing.Point(303, 15);
            this.VersionBox.Mask="00.00.00.000";
            this.VersionBox.Name="VersionBox";
            this.VersionBox.Size=new System.Drawing.Size(100, 23);
            this.VersionBox.TabIndex=4;
            this.VersionBox.Text="123456789";
            this.VersionBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(248, 18);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(39, 16);
            this.Label3.TabIndex=3;
            this.Label3.Text="تاریخ:";
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(60, 18);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(50, 16);
            this.Label2.TabIndex=2;
            this.Label2.Text="ساعت:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(402, 18);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(47, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="نسخه:";
            // 
            // UpdateRegisterForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(457, 528);
            this.Controls.Add(this.PersianCalendar);
            this.Controls.Add(this.ShowCheck);
            this.Controls.Add(this.UpdateCheck);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ChrCountLabel);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="UpdateRegisterForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="ثبت نسخه جدید";
            this.Load += new System.EventHandler(this.UpdateRegisterForm_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label Label1;
        private Label Label2;
        private Label Label3;
        private MaskedTextBox VersionBox;
        private MaskedTextBox TimeBox;
        private Label Label10;
        private Panel Panel1;
        private Label Label7;
        private Label Label12;
        private Label Label13;
        private Label Label9;
        private Label Label5;
        private Label Label4;
        private Label Label6;
        private Label Label8;
        private TextBox Box10;
        private TextBox Box9;
        private Label Label14;
        private Label Label15;
        private TextBox Box8;
        private TextBox Box7;
        private TextBox Box6;
        private TextBox Box5;
        private TextBox Box4;
        private TextBox Box3;
        private TextBox Box2;
        private TextBox Box1;
        private Panel Panel3;
        private Button ExitButton;
        private Button RegButton;
        private CheckBox UpdateCheck;
        private CheckBox ShowCheck;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private Label ChrCountLabel;
        private System.ComponentModel.IContainer components;
    }

}
