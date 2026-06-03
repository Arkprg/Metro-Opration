using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripHandlingForm : BaseForm
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
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(TripHandlingForm_HelpButtonClicked);
            base.Load += new System.EventHandler(TripHandlingForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
            this.LocalCombo=new ComboBox();
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.Label2=new Label();
            this.ShiftCombo=new ComboBox();
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            this.Label1=new Label();
            this.DataGridView1=new DataGridView();
            this.DataGridView1.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CurrentCellChanged += new System.EventHandler(this.DataGridView1_CurrentCellChanged);
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.Button5_Click);
            this.TripMaskedBox=new MaskedTextBox();
            this.Label5=new Label();
            this.Label3=new Label();
            this.Label6=new Label();
            this.TodayBox=new TextBox();
            this.MonthBox=new TextBox();
            this.Label7=new Label();
            this.TripLabel4=new Label();
            this.TripLabel3=new Label();
            this.TripLabel2=new Label();
            this.TripLabel1=new Label();
            this.Panel1=new Panel();
            this.Panel2=new Panel();
            this.Label4=new Label();
            this.Panel3=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Label8=new Label();
            ((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            //
            //LocalCombo
            //
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(13, 16);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(139, 24);
            this.LocalCombo.TabIndex=1;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.BackColor=System.Drawing.Color.LightBlue;
            this.Label2.Location=new System.Drawing.Point(157, 22);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(35, 16);
            this.Label2.TabIndex=2;
            this.Label2.Text="مبدا:";
            //
            //ShiftCombo
            //
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Items.AddRange(new object[] { "A", "B", "C" });
            this.ShiftCombo.Location=new System.Drawing.Point(13, 49);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(103, 24);
            this.ShiftCombo.TabIndex=2;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.LightBlue;
            this.Label1.Location=new System.Drawing.Point(122, 55);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(70, 16);
            this.Label1.TabIndex=4;
            this.Label1.Text="نام شیفت:";
            //
            //DataGridView1
            //
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(210)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(210)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight=40;
            this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column4, this.Column3 });
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle=DataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(12, 12);
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            this.DataGridView1.RowHeadersVisible=false;
            DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.TopCenter;
            DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.DataGridView1.RowsDefaultCellStyle=DataGridViewCellStyle4;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(355, 343);
            this.DataGridView1.TabIndex=6;
            this.DataGridView1.TabStop=false;
            //
            //Column1
            //
            this.Column1.HeaderText="نام";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=80;
            //
            //Column2
            //
            this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText="نام خانوادگی";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            //
            //Column4
            //
            this.Column4.HeaderText="شماره پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=60;
            //
            //Column3
            //
            this.Column3.HeaderText="جابجایی ماه جاری";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=70;
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.Location=new System.Drawing.Point(14, 16);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(154, 34);
            this.RegButton.TabIndex=3;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //TripMaskedBox
            //
            this.TripMaskedBox.Location=new System.Drawing.Point(258, 22);
            this.TripMaskedBox.Mask="00:00";
            this.TripMaskedBox.Name="TripMaskedBox";
            this.TripMaskedBox.Size=new System.Drawing.Size(57, 23);
            this.TripMaskedBox.TabIndex=2;
            this.TripMaskedBox.TextAlign=HorizontalAlignment.Center;
            this.TripMaskedBox.ValidatingType=typeof(DateTime);
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(314, 25);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(40, 16);
            this.Label5.TabIndex=19;
            this.Label5.Text="اعزام:";
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(505, 25);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(43, 16);
            this.Label3.TabIndex=37;
            this.Label3.Text="تاریخ :";
            //
            //Label6
            //
            this.Label6.AutoSize=true;
            this.Label6.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label6.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
            this.Label6.Location=new System.Drawing.Point(456, 288);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(117, 16);
            this.Label6.TabIndex=8;
            this.Label6.Text="جابجایی های امروز:";
            //
            //TodayBox
            //
            this.TodayBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.TodayBox.Location=new System.Drawing.Point(396, 286);
            this.TodayBox.Name="TodayBox";
            this.TodayBox.ReadOnly=true;
            this.TodayBox.Size=new System.Drawing.Size(40, 23);
            this.TodayBox.TabIndex=9;
            this.TodayBox.TabStop=false;
            this.TodayBox.TextAlign=HorizontalAlignment.Center;
            //
            //MonthBox
            //
            this.MonthBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.MonthBox.Location=new System.Drawing.Point(396, 315);
            this.MonthBox.Name="MonthBox";
            this.MonthBox.ReadOnly=true;
            this.MonthBox.Size=new System.Drawing.Size(40, 23);
            this.MonthBox.TabIndex=11;
            this.MonthBox.TabStop=false;
            this.MonthBox.TextAlign=HorizontalAlignment.Center;
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label7.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
            this.Label7.Location=new System.Drawing.Point(443, 317);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(130, 16);
            this.Label7.TabIndex=10;
            this.Label7.Text="جابجایی های این ماه:";
            //
            //TripLabel4
            //
            this.TripLabel4.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
            this.TripLabel4.Location=new System.Drawing.Point(26, 81);
            this.TripLabel4.Margin=new Padding(4, 0, 4, 0);
            this.TripLabel4.Name="TripLabel4";
            this.TripLabel4.Size=new System.Drawing.Size(147, 16);
            this.TripLabel4.TabIndex=40;
            this.TripLabel4.Text="نام:";
            this.TripLabel4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.TripLabel4.Visible=false;
            //
            //TripLabel3
            //
            this.TripLabel3.BackColor=System.Drawing.Color.LightBlue;
            this.TripLabel3.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
            this.TripLabel3.Location=new System.Drawing.Point(26, 59);
            this.TripLabel3.Margin=new Padding(4, 0, 4, 0);
            this.TripLabel3.Name="TripLabel3";
            this.TripLabel3.Size=new System.Drawing.Size(147, 16);
            this.TripLabel3.TabIndex=39;
            this.TripLabel3.Text="نام:";
            this.TripLabel3.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.TripLabel3.Visible=false;
            //
            //TripLabel2
            //
            this.TripLabel2.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
            this.TripLabel2.Location=new System.Drawing.Point(26, 37);
            this.TripLabel2.Margin=new Padding(4, 0, 4, 0);
            this.TripLabel2.Name="TripLabel2";
            this.TripLabel2.Size=new System.Drawing.Size(147, 16);
            this.TripLabel2.TabIndex=38;
            this.TripLabel2.Text="نام:";
            this.TripLabel2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.TripLabel2.Visible=false;
            //
            //TripLabel1
            //
            this.TripLabel1.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
            this.TripLabel1.Location=new System.Drawing.Point(26, 16);
            this.TripLabel1.Margin=new Padding(4, 0, 4, 0);
            this.TripLabel1.Name="TripLabel1";
            this.TripLabel1.Size=new System.Drawing.Size(147, 16);
            this.TripLabel1.TabIndex=37;
            this.TripLabel1.Text="نام:";
            this.TripLabel1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.TripLabel1.Visible=false;
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Location=new System.Drawing.Point(382, 12);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(200, 100);
            this.Panel1.TabIndex=0;
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.TripLabel4);
            this.Panel2.Controls.Add(this.TripLabel3);
            this.Panel2.Controls.Add(this.TripLabel1);
            this.Panel2.Controls.Add(this.TripLabel2);
            this.Panel2.Location=new System.Drawing.Point(382, 153);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(200, 113);
            this.Panel2.TabIndex=33;
            //
            //Label4
            //
            this.Label4.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Label4.BorderStyle=BorderStyle.FixedSingle;
            this.Label4.Cursor=Cursors.Default;
            this.Label4.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label4.Location=new System.Drawing.Point(416, 138);
            this.Label4.Name="Label4";
            this.Label4.Padding=new Padding(0, 0, 0, 2);
            this.Label4.Size=new System.Drawing.Size(154, 24);
            this.Label4.TabIndex=43;
            this.Label4.Text="جابجایی تریپهای انجام شده ";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Panel3
            //
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.PersianCalendar);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.TripMaskedBox);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.Label5);
            this.Panel3.Location=new System.Drawing.Point(12, 379);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(570, 67);
            this.Panel3.TabIndex=1;
            //
            //PersianCalendar
            //
            this.PersianCalendar.Location=new System.Drawing.Point(379, 22);
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
            //Label8
            //
            this.Label8.Anchor=AnchorStyles.Top | AnchorStyles.Right;
            this.Label8.AutoSize=true;
            this.Label8.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Label8.BorderStyle=BorderStyle.FixedSingle;
            this.Label8.Cursor=Cursors.Default;
            this.Label8.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label8.Location=new System.Drawing.Point(488, 366);
            this.Label8.Name="Label8";
            this.Label8.Padding=new Padding(0, 0, 0, 4);
            this.Label8.Size=new System.Drawing.Size(82, 22);
            this.Label8.TabIndex=45;
            this.Label8.Text="ثبت جابجایی";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //TripHandlingForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.ClientSize=new System.Drawing.Size(592, 451);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TodayBox);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.DataGridView1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripHandlingForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="جابجایی تریپ راهبران";
            ((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private ComboBox LocalCombo;
        private Label Label2;
        private ComboBox ShiftCombo;
        private Label Label1;
        private DataGridView DataGridView1;
        private Label Label3;
        private MaskedTextBox TripMaskedBox;
        private Label Label5;
        private Button RegButton;
        private Label Label6;
        private TextBox TodayBox;
        private TextBox MonthBox;
        private Label Label7;
        private Label TripLabel4;
        private Label TripLabel3;
        private Label TripLabel2;
        private Label TripLabel1;
        private Panel Panel1;
        private Panel Panel2;
        private Label Label4;
        private Panel Panel3;
        private Label Label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
    }

}
