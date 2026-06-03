using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripSpecialRegisterForm : BaseForm
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
            this.components=new System.ComponentModel.Container();
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(SingleTripForm_HelpButtonClicked);
            base.Load += new System.EventHandler(SingleTripForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            this.Panel1=new Panel();
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.DelRadioButton=new RadioButton();
            this.MemBox=new TextBox();
            this.AddRadioButton=new RadioButton();
            this.Label3=new Label();
            this.PNumBox=new TextBox();
            this.Label2=new Label();
            this.NameBox=new TextBox();
            this.Label1=new Label();
            this.ReservBox=new TextBox();
            this.Label4=new Label();
            this.Label5=new Label();
            this.Label7=new Label();
            this.Label6=new Label();
            this.ShiftCombo=new ComboBox();
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            this.LocalCombo=new ComboBox();
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.RegGridView=new DataGridView();
            this.RegGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.RegGridView_ColumnHeaderMouseClick);
            this.Column12=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.DetailGridView=new DataGridView();
            this.Panel2=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            this.TripCombo=new ComboBox();
            this.TripCombo.SelectedIndexChanged += new System.EventHandler(this.TripCombo_SelectedIndexChanged);
            this.Label8=new Label();
            this.Panel3=new Panel();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.RegGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.DetailGridView).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.RegButton);
            this.Panel1.Controls.Add(this.DelRadioButton);
            this.Panel1.Controls.Add(this.MemBox);
            this.Panel1.Controls.Add(this.AddRadioButton);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location=new System.Drawing.Point(11, 14);
            this.Panel1.Margin=new Padding(3, 4, 3, 4);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(220, 159);
            this.Panel1.TabIndex=1;
            //
            //RegButton
            //
            this.RegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.Location=new System.Drawing.Point(10, 22);
            this.RegButton.Margin=new Padding(3, 4, 3, 4);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(90, 64);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="تایید";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //DelRadioButton
            //
            this.DelRadioButton.BackColor=System.Drawing.Color.Red;
            this.DelRadioButton.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.DelRadioButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.DelRadioButton.ForeColor=System.Drawing.Color.White;
            this.DelRadioButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DelRadioButton.Location=new System.Drawing.Point(110, 57);
            this.DelRadioButton.Margin=new Padding(3, 4, 3, 4);
            this.DelRadioButton.Name="DelRadioButton";
            this.DelRadioButton.Padding=new Padding(12, 0, 0, 0);
            this.DelRadioButton.Size=new System.Drawing.Size(89, 27);
            this.DelRadioButton.TabIndex=3;
            this.DelRadioButton.Text="حذف";
            this.DelRadioButton.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.DelRadioButton.UseVisualStyleBackColor=false;
            //
            //MemBox
            //
            this.MemBox.BackColor=System.Drawing.Color.LightBlue;
            this.MemBox.BorderStyle=BorderStyle.FixedSingle;
            this.MemBox.Location=new System.Drawing.Point(7, 119);
            this.MemBox.Margin=new Padding(3, 4, 3, 4);
            this.MemBox.MaxLength=50;
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(196, 23);
            this.MemBox.TabIndex=4;
            this.MemBox.TextAlign=HorizontalAlignment.Center;
            //
            //AddRadioButton
            //
            this.AddRadioButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)));
            this.AddRadioButton.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.AddRadioButton.Checked=true;
            this.AddRadioButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.AddRadioButton.ForeColor=System.Drawing.Color.White;
            this.AddRadioButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRadioButton.Location=new System.Drawing.Point(110, 22);
            this.AddRadioButton.Margin=new Padding(3, 4, 3, 4);
            this.AddRadioButton.Name="AddRadioButton";
            this.AddRadioButton.Padding=new Padding(12, 0, 0, 0);
            this.AddRadioButton.Size=new System.Drawing.Size(89, 28);
            this.AddRadioButton.TabIndex=2;
            this.AddRadioButton.TabStop=true;
            this.AddRadioButton.Text="اضافه";
            this.AddRadioButton.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRadioButton.UseVisualStyleBackColor=false;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.BackColor=System.Drawing.Color.Transparent;
            this.Label3.ForeColor=System.Drawing.Color.Black;
            this.Label3.Location=new System.Drawing.Point(142, 100);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(62, 16);
            this.Label3.TabIndex=18;
            this.Label3.Text="توضیحات:";
            //
            //PNumBox
            //
            this.PNumBox.BackColor=System.Drawing.Color.LightBlue;
            this.PNumBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.PNumBox.Location=new System.Drawing.Point(14, 62);
            this.PNumBox.Margin=new Padding(3, 4, 3, 4);
            this.PNumBox.Name="PNumBox";
            this.PNumBox.ReadOnly=true;
            this.PNumBox.Size=new System.Drawing.Size(90, 23);
            this.PNumBox.TabIndex=12;
            this.PNumBox.TabStop=false;
            this.PNumBox.TextAlign=HorizontalAlignment.Center;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.BackColor=System.Drawing.Color.Transparent;
            this.Label2.ForeColor=System.Drawing.Color.Black;
            this.Label2.Location=new System.Drawing.Point(106, 65);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(98, 16);
            this.Label2.TabIndex=11;
            this.Label2.Text="شماره پرسنلی:";
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.Color.LightBlue;
            this.NameBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.NameBox.Location=new System.Drawing.Point(14, 23);
            this.NameBox.Margin=new Padding(3, 4, 3, 4);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(160, 23);
            this.NameBox.TabIndex=1;
            this.NameBox.TabStop=false;
            this.NameBox.TextAlign=HorizontalAlignment.Center;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.Transparent;
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.Location=new System.Drawing.Point(175, 28);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(29, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="نام:";
            //
            //ReservBox
            //
            this.ReservBox.BackColor=System.Drawing.Color.LightBlue;
            this.ReservBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ReservBox.Location=new System.Drawing.Point(14, 98);
            this.ReservBox.Margin=new Padding(3, 4, 3, 4);
            this.ReservBox.Name="ReservBox";
            this.ReservBox.ReadOnly=true;
            this.ReservBox.Size=new System.Drawing.Size(90, 23);
            this.ReservBox.TabIndex=14;
            this.ReservBox.TabStop=false;
            this.ReservBox.TextAlign=HorizontalAlignment.Center;
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.ForeColor=System.Drawing.Color.Black;
            this.Label4.Location=new System.Drawing.Point(115, 101);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(89, 16);
            this.Label4.TabIndex=13;
            this.Label4.Text="تعداد تک تریپ:";
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.BackColor=System.Drawing.Color.Transparent;
            this.Label5.Location=new System.Drawing.Point(157, 21);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(39, 16);
            this.Label5.TabIndex=32;
            this.Label5.Text="تاریخ:";
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.Location=new System.Drawing.Point(157, 55);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(35, 16);
            this.Label7.TabIndex=34;
            this.Label7.Text="مبدا:";
            //
            //Label6
            //
            this.Label6.AutoSize=true;
            this.Label6.BackColor=System.Drawing.Color.Transparent;
            this.Label6.Location=new System.Drawing.Point(157, 123);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(50, 16);
            this.Label6.TabIndex=33;
            this.Label6.Text="شیفت:";
            //
            //ShiftCombo
            //
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Items.AddRange(new object[] { "صبح", "عصر", "روز", "شب" });
            this.ShiftCombo.Location=new System.Drawing.Point(32, 119);
            this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(125, 24);
            this.ShiftCombo.TabIndex=4;
            //
            //LocalCombo
            //
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(32, 51);
            this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(125, 24);
            this.LocalCombo.TabIndex=2;
            //
            //RegGridView
            //
            this.RegGridView.AllowUserToAddRows=false;
            this.RegGridView.AllowUserToDeleteRows=false;
            this.RegGridView.AllowUserToResizeColumns=false;
            this.RegGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(210)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(210)));
            this.RegGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            this.RegGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.RegGridView.ColumnHeadersHeight=40;
            this.RegGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RegGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column12, this.Column8, this.Column9, this.Column10, this.Column3, this.Column11 });
            this.RegGridView.EnableHeadersVisualStyles=false;
            this.RegGridView.Location=new System.Drawing.Point(11, 185);
            this.RegGridView.Margin=new Padding(3, 4, 3, 4);
            this.RegGridView.MultiSelect=false;
            this.RegGridView.Name="RegGridView";
            this.RegGridView.ReadOnly=true;
            this.RegGridView.RowHeadersVisible=false;
            this.RegGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RegGridView.SelectionMode=DataGridViewSelectionMode.CellSelect;
            this.RegGridView.Size=new System.Drawing.Size(690, 372);
            this.RegGridView.TabIndex=30;
            this.RegGridView.TabStop=false;
            //
            //Column12
            //
            this.Column12.HeaderText="ردیف";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Width=40;
            //
            //Column8
            //
            this.Column8.HeaderText="نام";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=85;
            //
            //Column9
            //
            this.Column9.HeaderText="نام خانوادگی";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=140;
            //
            //Column10
            //
            this.Column10.HeaderText="شماره پرسنلی";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=90;
            //
            //Column3
            //
            this.Column3.HeaderText="تریپ";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            //
            //Column11
            //
            this.Column11.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText="شیفت";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            //
            //DetailGridView
            //
            this.DetailGridView.AllowUserToAddRows=false;
            this.DetailGridView.AllowUserToDeleteRows=false;
            this.DetailGridView.AllowUserToResizeColumns=false;
            this.DetailGridView.AllowUserToResizeRows=false;
            this.DetailGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column5, this.Column6, this.Column1, this.Column2, this.Column4, this.Column7 });
            this.DetailGridView.Location=new System.Drawing.Point(86, 307);
            this.DetailGridView.Margin=new Padding(3, 4, 3, 4);
            this.DetailGridView.Name="DetailGridView";
            this.DetailGridView.ReadOnly=true;
            this.DetailGridView.RowHeadersVisible=false;
            this.DetailGridView.Size=new System.Drawing.Size(458, 231);
            this.DetailGridView.TabIndex=31;
            this.DetailGridView.Visible=false;
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.PersianCalendar);
            this.Panel2.Controls.Add(this.TripCombo);
            this.Panel2.Controls.Add(this.ShiftCombo);
            this.Panel2.Controls.Add(this.LocalCombo);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Location=new System.Drawing.Point(481, 14);
            this.Panel2.Margin=new Padding(3, 4, 3, 4);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(220, 159);
            this.Panel2.TabIndex=0;
            //
            //PersianCalendar
            //
            this.PersianCalendar.Location=new System.Drawing.Point(32, 18);
            this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //TripCombo
            //
            this.TripCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.TripCombo.FormattingEnabled=true;
            this.TripCombo.Items.AddRange(new object[] { "تک تریپ ", "دو تریپ ", "ستادی ", "هشتگرد" });
            this.TripCombo.Location=new System.Drawing.Point(32, 85);
            this.TripCombo.Margin=new Padding(3, 4, 3, 4);
            this.TripCombo.Name="TripCombo";
            this.TripCombo.Size=new System.Drawing.Size(125, 24);
            this.TripCombo.TabIndex=3;
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.BackColor=System.Drawing.Color.Transparent;
            this.Label8.Location=new System.Drawing.Point(157, 89);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(38, 16);
            this.Label8.TabIndex=36;
            this.Label8.Text="تریپ:";
            //
            //Panel3
            //
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ReservBox);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Controls.Add(this.PNumBox);
            this.Panel3.Controls.Add(this.NameBox);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Location=new System.Drawing.Point(246, 14);
            this.Panel3.Margin=new Padding(3, 4, 3, 4);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(220, 159);
            this.Panel3.TabIndex=36;
            //
            //Column5
            //
            this.Column5.HeaderText="نام";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=70;
            //
            //Column6
            //
            this.Column6.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText="نام خانوادگی";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            //
            //Column1
            //
            this.Column1.HeaderText="پرسنلی";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=70;
            //
            //Column2
            //
            this.Column2.HeaderText="تریپ";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=50;
            //
            //Column4
            //
            this.Column4.HeaderText="امتیاز";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=70;
            //
            //Column7
            //
            this.Column7.HeaderText="نوع شیفت";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=80;
            //
            //TripSpecialRegisterForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.ClientSize=new System.Drawing.Size(712, 566);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.DetailGridView);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.RegGridView);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.Margin=new Padding(3, 4, 3, 4);
            this.Name="TripSpecialRegisterForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="اولویت تریپ خاص";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.RegGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.DetailGridView).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        private Panel Panel1;
        private Button RegButton;
        private RadioButton DelRadioButton;
        private TextBox PNumBox;
        private TextBox MemBox;
        private Label Label2;
        private RadioButton AddRadioButton;
        private TextBox NameBox;
        private Label Label3;
        private Label Label1;
        private TextBox ReservBox;
        private Label Label4;
        private Label Label5;
        private Label Label7;
        private Label Label6;
        private ComboBox ShiftCombo;
        private ComboBox LocalCombo;
        private DataGridView RegGridView;
        private DataGridView DetailGridView;
        private Panel Panel2;
        private ComboBox TripCombo;
        private Label Label8;
        private Panel Panel3;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column11;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
    }

}
