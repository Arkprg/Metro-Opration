using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    partial class AnnounceRegisterForm  : BaseForm
    {
        private IContainer components=null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components=new System.ComponentModel.Container();
            this.Panel3=new System.Windows.Forms.Panel();
            this.ExitButton=new System.Windows.Forms.Button();
            this.RegButton=new System.Windows.Forms.Button();
            this.Panel1=new System.Windows.Forms.Panel();
            this.HtmlEditControl1=new Zoople.HTMLEditControl();
            this.PostCombo=new System.Windows.Forms.ComboBox();
            this.KindCombo=new System.Windows.Forms.ComboBox();
            this.LevelCombo=new System.Windows.Forms.ComboBox();
            this.TitrBox=new System.Windows.Forms.TextBox();
            this.TimeCombo=new System.Windows.Forms.ComboBox();
            this.ShiftCombo=new System.Windows.Forms.ComboBox();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label9=new System.Windows.Forms.Label();
            this.label2=new System.Windows.Forms.Label();
            this.Label11=new System.Windows.Forms.Label();
            this.Label12=new System.Windows.Forms.Label();
            this.Label13=new System.Windows.Forms.Label();
            this.label3=new System.Windows.Forms.Label();
            this.label1=new System.Windows.Forms.Label();
            this.Label14=new System.Windows.Forms.Label();
            this.Label15=new System.Windows.Forms.Label();
            this.Label16=new System.Windows.Forms.Label();
            this.Label17=new System.Windows.Forms.Label();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.UnitCombo=new System.Windows.Forms.ComboBox();
            this.LineCombo=new System.Windows.Forms.ComboBox();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Location=new System.Drawing.Point(721, 448);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(270, 62);
            this.Panel3.TabIndex=2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location=new System.Drawing.Point(14, 13);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(87, 34);
            this.ExitButton.TabIndex=0;
            this.ExitButton.Text="    انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Location=new System.Drawing.Point(119, 13);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(137, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ثبت";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.HtmlEditControl1);
            this.Panel1.Location=new System.Drawing.Point(12, 12);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(703, 498);
            this.Panel1.TabIndex=1;
            // 
            // HtmlEditControl1
            // 
            this.HtmlEditControl1.AllowDragInternal=true;
            this.HtmlEditControl1.BaseURL=null;
            this.HtmlEditControl1.CleanMSWordHTMLOnPaste=true;
            this.HtmlEditControl1.CSSText=null;
            this.HtmlEditControl1.Dock=System.Windows.Forms.DockStyle.Fill;
            this.HtmlEditControl1.DocumentHTML=null;
            this.HtmlEditControl1.EditingDisabled=false;
            this.HtmlEditControl1.FontsList=null;
            this.HtmlEditControl1.HiddenButtons=null;
            this.HtmlEditControl1.ImageStorageLocation=null;
            this.HtmlEditControl1.InCodeView=false;
            this.HtmlEditControl1.LanguageFile=null;
            this.HtmlEditControl1.LicenceKey="KPH0011-6738-B67";
            this.HtmlEditControl1.Location=new System.Drawing.Point(0, 0);
            this.HtmlEditControl1.Name="HtmlEditControl1";
            this.HtmlEditControl1.Size=new System.Drawing.Size(701, 496);
            this.HtmlEditControl1.TabIndex=0;
            this.HtmlEditControl1.ToolstripImageScalingSize=new System.Drawing.Size(16, 16);
            this.HtmlEditControl1.UseParagraphAsDefault=true;
            // 
            // PostCombo
            // 
            this.PostCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCombo.Location=new System.Drawing.Point(42, 77);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(121, 24);
            this.PostCombo.TabIndex=7;
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.Items.AddRange(new object[] {
            "آموزش",
            "اداری",
            "عمومی"});
            this.KindCombo.Location=new System.Drawing.Point(42, 46);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(121, 24);
            this.KindCombo.TabIndex=8;
            // 
            // LevelCombo
            // 
            this.LevelCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelCombo.Items.AddRange(new object[] {
            "عادی",
            "فوری"});
            this.LevelCombo.Location=new System.Drawing.Point(42, 263);
            this.LevelCombo.Name="LevelCombo";
            this.LevelCombo.Size=new System.Drawing.Size(121, 24);
            this.LevelCombo.TabIndex=10;
            // 
            // TitrBox
            // 
            this.TitrBox.Location=new System.Drawing.Point(42, 16);
            this.TitrBox.Name="TitrBox";
            this.TitrBox.Size=new System.Drawing.Size(121, 23);
            this.TitrBox.TabIndex=3;
            // 
            // TimeCombo
            // 
            this.TimeCombo.Location=new System.Drawing.Point(42, 201);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(121, 24);
            this.TimeCombo.TabIndex=6;
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.Location=new System.Drawing.Point(42, 232);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(121, 24);
            this.ShiftCombo.TabIndex=5;
            // 
            // LocalCombo
            // 
            this.LocalCombo.Location=new System.Drawing.Point(42, 170);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(121, 24);
            this.LocalCombo.TabIndex=4;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label17);
            this.Panel2.Controls.Add(this.EndCalendar);
            this.Panel2.Controls.Add(this.StartCalendar);
            this.Panel2.Controls.Add(this.UnitCombo);
            this.Panel2.Controls.Add(this.TitrBox);
            this.Panel2.Controls.Add(this.LineCombo);
            this.Panel2.Controls.Add(this.LocalCombo);
            this.Panel2.Controls.Add(this.ShiftCombo);
            this.Panel2.Controls.Add(this.TimeCombo);
            this.Panel2.Controls.Add(this.PostCombo);
            this.Panel2.Controls.Add(this.KindCombo);
            this.Panel2.Controls.Add(this.LevelCombo);
            this.Panel2.Location=new System.Drawing.Point(721, 13);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(270, 424);
            this.Panel2.TabIndex=0;
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.ForeColor=System.Drawing.Color.Black;
            this.Label9.Location=new System.Drawing.Point(169, 172);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(40, 16);
            this.Label9.TabIndex=110;
            this.Label9.Text="مبداء:";
            // 
            // label2
            // 
            this.label2.AutoSize=true;
            this.label2.ForeColor=System.Drawing.Color.Black;
            this.label2.Location=new System.Drawing.Point(169, 328);
            this.label2.Name="label2";
            this.label2.Size=new System.Drawing.Size(68, 16);
            this.label2.TabIndex=103;
            this.label2.Text="تاریخ پایان:";
            // 
            // Label11
            // 
            this.Label11.AutoSize=true;
            this.Label11.ForeColor=System.Drawing.Color.Black;
            this.Label11.Location=new System.Drawing.Point(169, 296);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(84, 16);
            this.Label11.TabIndex=103;
            this.Label11.Text="تاریخ نمایش :";
            // 
            // Label12
            // 
            this.Label12.AutoSize=true;
            this.Label12.ForeColor=System.Drawing.Color.Black;
            this.Label12.Location=new System.Drawing.Point(169, 234);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(70, 16);
            this.Label12.TabIndex=109;
            this.Label12.Text="نام شیفت:";
            // 
            // Label13
            // 
            this.Label13.AutoSize=true;
            this.Label13.ForeColor=System.Drawing.Color.Black;
            this.Label13.Location=new System.Drawing.Point(169, 50);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(76, 16);
            this.Label13.TabIndex=104;
            this.Label13.Text="نوع اطلاعیه:";
            // 
            // label3
            // 
            this.label3.AutoSize=true;
            this.label3.ForeColor=System.Drawing.Color.Black;
            this.label3.Location=new System.Drawing.Point(169, 143);
            this.label3.Name="label3";
            this.label3.Size=new System.Drawing.Size(37, 16);
            this.label3.TabIndex=105;
            this.label3.Text="واحد:";
            // 
            // label1
            // 
            this.label1.AutoSize=true;
            this.label1.ForeColor=System.Drawing.Color.Black;
            this.label1.Location=new System.Drawing.Point(169, 112);
            this.label1.Name="label1";
            this.label1.Size=new System.Drawing.Size(31, 16);
            this.label1.TabIndex=105;
            this.label1.Text="خط:";
            // 
            // Label14
            // 
            this.Label14.AutoSize=true;
            this.Label14.ForeColor=System.Drawing.Color.Black;
            this.Label14.Location=new System.Drawing.Point(169, 81);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(77, 16);
            this.Label14.TabIndex=105;
            this.Label14.Text="نمایش برای:";
            // 
            // Label15
            // 
            this.Label15.AutoSize=true;
            this.Label15.ForeColor=System.Drawing.Color.Black;
            this.Label15.Location=new System.Drawing.Point(169, 203);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(72, 16);
            this.Label15.TabIndex=108;
            this.Label15.Text="نوع شیفت:";
            // 
            // Label16
            // 
            this.Label16.AutoSize=true;
            this.Label16.ForeColor=System.Drawing.Color.Black;
            this.Label16.Location=new System.Drawing.Point(169, 265);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(88, 16);
            this.Label16.TabIndex=106;
            this.Label16.Text="اولویت نمایش:";
            // 
            // Label17
            // 
            this.Label17.AutoSize=true;
            this.Label17.ForeColor=System.Drawing.Color.Black;
            this.Label17.Location=new System.Drawing.Point(169, 19);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(89, 16);
            this.Label17.TabIndex=107;
            this.Label17.Text="عنوان اطلاعیه:";
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location=new System.Drawing.Point(42, 324);
            this.EndCalendar.Miladi=new System.DateTime(((long)(0)));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=false;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(121, 23);
            this.EndCalendar.TabIndex=0;
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location=new System.Drawing.Point(42, 294);
            this.StartCalendar.Miladi=new System.DateTime(((long)(0)));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=false;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(121, 23);
            this.StartCalendar.TabIndex=1;
            // 
            // UnitCombo
            // 
            this.UnitCombo.Location=new System.Drawing.Point(42, 139);
            this.UnitCombo.Name="UnitCombo";
            this.UnitCombo.Size=new System.Drawing.Size(121, 24);
            this.UnitCombo.TabIndex=2;
            // 
            // LineCombo
            // 
            this.LineCombo.Location=new System.Drawing.Point(42, 108);
            this.LineCombo.Name="LineCombo";
            this.LineCombo.Size=new System.Drawing.Size(121, 24);
            this.LineCombo.TabIndex=3;
            // 
            // AnnounceRegisterForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.ClientSize=new System.Drawing.Size(1002, 521);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="AnnounceRegisterForm";
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="پنل ثبت اطلاعیه";
            this.Load += new System.EventHandler(this.AnnounceRegisterForm_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel Panel3;
        private Button ExitButton;
        private Button RegButton;
        private Panel Panel1;
        private ComboBox PostCombo;
        internal ComboBox KindCombo;
        private ComboBox LevelCombo;
        private TextBox TitrBox;
        private ComboBox TimeCombo;
        private ComboBox ShiftCombo;
        private ComboBox LocalCombo;
        private Panel Panel2;
        private ComboBox LineCombo;
        private ComboBox UnitCombo;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Zoople.HTMLEditControl HtmlEditControl1;
        private Label Label9;
        private Label label2;
        private Label Label11;
        private Label Label12;
        private Label Label13;
        private Label label3;
        private Label label1;
        private Label Label14;
        private Label Label15;
        private Label Label16;
        private Label Label17;
    }
}
