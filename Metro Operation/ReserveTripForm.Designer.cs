using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using System.Linq.Expressions;
 
using System.Collections;
using System.Windows.Forms;

using Metro_Operation;

namespace Metro_Operation
{
	public partial class ReserveTripForm : BaseForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)  {
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components=new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1=new System.Windows.Forms.DataGridView();
            this.AddButton=new System.Windows.Forms.Button();
            this.Label4=new System.Windows.Forms.Label();
            this.ExitTimeBox=new System.Windows.Forms.MaskedTextBox();
            this.Label10=new System.Windows.Forms.Label();
            this.EnterTimeBox=new System.Windows.Forms.MaskedTextBox();
            this.Trip2TimeBox=new System.Windows.Forms.MaskedTextBox();
            this.Label1=new System.Windows.Forms.Label();
            this.Trip3TimeBox=new System.Windows.Forms.MaskedTextBox();
            this.Trip1TimeBox=new System.Windows.Forms.MaskedTextBox();
            this.Label3=new System.Windows.Forms.Label();
            this.Label9=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.RegButton=new System.Windows.Forms.Button();
            this.DelButton=new System.Windows.Forms.Button();
            this.ShiftCombo=new System.Windows.Forms.ComboBox();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.Label6=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label13=new System.Windows.Forms.Label();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RName=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Num=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNum=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRNam=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTNum=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAmal=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAmal=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSNum=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESum=new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            this.DataGridView1.BackgroundColor=System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.RName,
            this.Column1,
            this.P_Num,
            this.RNum,
            this.TRNam,
            this.LTNum,
            this.PAmal,
            this.NAmal,
            this.MSNum,
            this.Column4,
            this.Column3,
            this.ESum});
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(10, 87);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.RowHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(798, 259);
            this.DataGridView1.TabIndex=4;
            this.DataGridView1.TabStop=false;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            // 
            // AddButton
            // 
            this.AddButton.BackColor=System.Drawing.Color.Transparent;
            this.AddButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.AddButton.Image=global::Metro_Operation.Properties.Resources.add_241;
            this.AddButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location=new System.Drawing.Point(134, 15);
            this.AddButton.Name="AddButton";
            this.AddButton.Size=new System.Drawing.Size(107, 34);
            this.AddButton.TabIndex=4;
            this.AddButton.Text="اضافه";
            this.AddButton.UseVisualStyleBackColor=false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.ForeColor=System.Drawing.Color.Red;
            this.Label4.Location=new System.Drawing.Point(208, 40);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(380, 23);
            this.Label4.TabIndex=21;
            this.Label4.Text="توجه: ثبت ورود و خروج راهبران رزرو تا یک روز قبل ممکن است";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitTimeBox
            // 
            this.ExitTimeBox.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitTimeBox.Location=new System.Drawing.Point(645, 48);
            this.ExitTimeBox.Mask="00:00";
            this.ExitTimeBox.Name="ExitTimeBox";
            this.ExitTimeBox.Size=new System.Drawing.Size(50, 23);
            this.ExitTimeBox.TabIndex=2;
            this.ExitTimeBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitTimeBox.ValidatingType=typeof(System.DateTime);
            this.ExitTimeBox.TextChanged += new System.EventHandler(this.ExitMaskedBox_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize=true;
            this.Label10.Location=new System.Drawing.Point(695, 51);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(81, 16);
            this.Label10.TabIndex=22;
            this.Label10.Text="ساعت خروج:";
            // 
            // EnterTimeBox
            // 
            this.EnterTimeBox.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EnterTimeBox.Location=new System.Drawing.Point(645, 13);
            this.EnterTimeBox.Mask="00:00";
            this.EnterTimeBox.Name="EnterTimeBox";
            this.EnterTimeBox.Size=new System.Drawing.Size(50, 23);
            this.EnterTimeBox.TabIndex=1;
            this.EnterTimeBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterTimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // Trip2TimeBox
            // 
            this.Trip2TimeBox.Location=new System.Drawing.Point(346, 13);
            this.Trip2TimeBox.Mask="00:00";
            this.Trip2TimeBox.Name="Trip2TimeBox";
            this.Trip2TimeBox.Size=new System.Drawing.Size(50, 23);
            this.Trip2TimeBox.TabIndex=3;
            this.Trip2TimeBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.Trip2TimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(695, 16);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(75, 16);
            this.Label1.TabIndex=20;
            this.Label1.Text="ساعت ورود:";
            // 
            // Trip3TimeBox
            // 
            this.Trip3TimeBox.Location=new System.Drawing.Point(208, 13);
            this.Trip3TimeBox.Mask="00:00";
            this.Trip3TimeBox.Name="Trip3TimeBox";
            this.Trip3TimeBox.Size=new System.Drawing.Size(50, 23);
            this.Trip3TimeBox.TabIndex=5;
            this.Trip3TimeBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.Trip3TimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // Trip1TimeBox
            // 
            this.Trip1TimeBox.Location=new System.Drawing.Point(482, 13);
            this.Trip1TimeBox.Mask="00:00";
            this.Trip1TimeBox.Name="Trip1TimeBox";
            this.Trip1TimeBox.Size=new System.Drawing.Size(50, 23);
            this.Trip1TimeBox.TabIndex=4;
            this.Trip1TimeBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.Trip1TimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(398, 16);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(61, 16);
            this.Label3.TabIndex=18;
            this.Label3.Text="تریپ دوم:";
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.Location=new System.Drawing.Point(533, 16);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(58, 16);
            this.Label9.TabIndex=17;
            this.Label9.Text="تریپ اول:";
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(259, 16);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(69, 16);
            this.Label2.TabIndex=17;
            this.Label2.Text="تریپ سوم:";
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(22, 27);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(138, 34);
            this.RegButton.TabIndex=6;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor=System.Drawing.Color.Transparent;
            this.DelButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DelButton.Image=global::Metro_Operation.Properties.Resources.close_24;
            this.DelButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DelButton.Location=new System.Drawing.Point(15, 15);
            this.DelButton.Name="DelButton";
            this.DelButton.Size=new System.Drawing.Size(107, 34);
            this.DelButton.TabIndex=5;
            this.DelButton.Text="حذف";
            this.DelButton.UseVisualStyleBackColor=false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Items.AddRange(new object[] {
            "صبح",
            "عصر"});
            this.ShiftCombo.Location=new System.Drawing.Point(277, 20);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(78, 24);
            this.ShiftCombo.TabIndex=3;
            this.ShiftCombo.Visible=false;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            this.ShiftCombo.TextChanged += new System.EventHandler(this.ShiftCombo_TextChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(415, 20);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(119, 24);
            this.LocalCombo.TabIndex=2;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.LocalCombo.TextChanged += new System.EventHandler(this.LocalCombo_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(534, 24);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(35, 16);
            this.Label6.TabIndex=22;
            this.Label6.Text="مبدا:";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(734, 24);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(39, 16);
            this.Label7.TabIndex=22;
            this.Label7.Text="تاریخ:";
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(355, 24);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(50, 16);
            this.Label8.TabIndex=22;
            this.Label8.Text="شیفت:";
            this.Label8.Visible=false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.DelButton);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.AddButton);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Location=new System.Drawing.Point(10, 10);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(798, 67);
            this.Panel1.TabIndex=0;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(609, 21);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Controls.Add(this.ExitTimeBox);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.EnterTimeBox);
            this.Panel2.Controls.Add(this.Trip2TimeBox);
            this.Panel2.Controls.Add(this.Trip1TimeBox);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Trip3TimeBox);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Location=new System.Drawing.Point(10, 356);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(798, 90);
            this.Panel2.TabIndex=1;
            this.Panel2.Leave += new System.EventHandler(this.Panel2_Leave);
            // 
            // Label13
            // 
            this.Label13.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label13.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label13.ForeColor=System.Drawing.Color.Red;
            this.Label13.Location=new System.Drawing.Point(208, 63);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(380, 23);
            this.Label13.TabIndex=23;
            this.Label13.Text="ثبت زمان 00:00 در ساعت ورود یا خروج به معنای عدم اعلام است";
            this.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column2
            // 
            this.Column2.HeaderText="ردیف";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=40;
            // 
            // RName
            // 
            this.RName.HeaderText="نام";
            this.RName.Name="RName";
            this.RName.ReadOnly=true;
            this.RName.Width=80;
            // 
            // Column1
            // 
            this.Column1.HeaderText="نام خانوادگی";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=150;
            // 
            // P_Num
            // 
            this.P_Num.HeaderText="شماره پرسنلی";
            this.P_Num.Name="P_Num";
            this.P_Num.ReadOnly=true;
            this.P_Num.Width=70;
            // 
            // RNum
            // 
            this.RNum.HeaderText="تعداد رزرو";
            this.RNum.Name="RNum";
            this.RNum.ReadOnly=true;
            this.RNum.Width=60;
            // 
            // TRNam
            // 
            this.TRNam.HeaderText="تریپ رزرو";
            this.TRNam.Name="TRNam";
            this.TRNam.ReadOnly=true;
            this.TRNam.Width=60;
            // 
            // LTNum
            // 
            this.LTNum.HeaderText="تریپ آخروقت";
            this.LTNum.Name="LTNum";
            this.LTNum.ReadOnly=true;
            this.LTNum.Visible=false;
            this.LTNum.Width=60;
            // 
            // PAmal
            // 
            this.PAmal.HeaderText="امتیاز مثبت";
            this.PAmal.Name="PAmal";
            this.PAmal.ReadOnly=true;
            this.PAmal.Visible=false;
            this.PAmal.Width=60;
            // 
            // NAmal
            // 
            this.NAmal.HeaderText="امتیاز منفی";
            this.NAmal.Name="NAmal";
            this.NAmal.ReadOnly=true;
            this.NAmal.Visible=false;
            this.NAmal.Width=60;
            // 
            // MSNum
            // 
            this.MSNum.HeaderText="مرخصی ساعتی";
            this.MSNum.Name="MSNum";
            this.MSNum.ReadOnly=true;
            this.MSNum.Width=60;
            // 
            // Column4
            // 
            this.Column4.HeaderText="مرخصی روزانه";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText="شیفت";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            // 
            // ESum
            // 
            this.ESum.HeaderText="امتیاز";
            this.ESum.Name="ESum";
            this.ESum.ReadOnly=true;
            this.ESum.Width=70;
            // 
            // ReserveTripForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(818, 456);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.Margin=new System.Windows.Forms.Padding(4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ReserveTripForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="نام راهبران رزرو بر اساس اولوبت تریپ";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ReserveTripForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.ReserveTripForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		private DataGridView DataGridView1;
		private Button AddButton;
		private MaskedTextBox Trip3TimeBox;
		private MaskedTextBox Trip1TimeBox;
		private Label Label3;
		private Label Label2;
		private Button RegButton;
		private ComboBox ShiftCombo;
		private MaskedTextBox Trip2TimeBox;
		private Label Label1;
		private Label Label4;
		private ComboBox LocalCombo;
		private Label Label6;
		private Label Label7;
		private Label Label8;
		private MaskedTextBox ExitTimeBox;
		private Label Label10;
		private MaskedTextBox EnterTimeBox;
		private Label Label9;
		private Button DelButton;
		private Panel Panel1;
		private Panel Panel2;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private Label Label13;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn RName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn P_Num;
        private DataGridViewTextBoxColumn RNum;
        private DataGridViewTextBoxColumn TRNam;
        private DataGridViewTextBoxColumn LTNum;
        private DataGridViewTextBoxColumn PAmal;
        private DataGridViewTextBoxColumn NAmal;
        private DataGridViewTextBoxColumn MSNum;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn ESum;
        private System.ComponentModel.IContainer components;
    }
	
}
