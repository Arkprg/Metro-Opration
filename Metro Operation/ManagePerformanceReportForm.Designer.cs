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
		public partial class ManagePerformanceReportForm : BaseForm
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
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
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components=null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			this.components=new System.ComponentModel.Container();
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(ManagePerformanceReportForm_HelpButtonClicked);
			base.Load += new System.EventHandler(ManagePerformanceReportForm_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			this.Label1=new Label();
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.ShowGridView=new DataGridView();
			this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
			this.Column15=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column12=new DataGridViewTextBoxColumn();
			this.Column11=new DataGridViewTextBoxColumn();
			this.Column17=new DataGridViewTextBoxColumn();
			this.Column19=new DataGridViewTextBoxColumn();
			this.Column18=new DataGridViewTextBoxColumn();
			this.Column16=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column13=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column10=new DataGridViewTextBoxColumn();
			this.Column14=new DataGridViewTextBoxColumn();
			this.ExportButton=new Button();
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			this.Label6=new Label();
			this.Label1S=new Label();
			this.Label2S=new Label();
			this.Label4S=new Label();
			this.Label3S=new Label();
			this.Label6S=new Label();
			this.Label5S=new Label();
			this.Label8S=new Label();
			this.Label7S=new Label();
			this.Label10S=new Label();
			this.Label9S=new Label();
			this.Label11S=new Label();
			this.Panel1=new Panel();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label3=new Label();
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.Label13=new Label();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label14=new Label();
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.Label4=new Label();
			this.Label5=new Label();
			this.Label2=new Label();
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
			this.Label1.Location=new System.Drawing.Point(1066, 13);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(70, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="نوع گزارش:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"عملکرد پرسنل", "عملکرد کاربران"});
			this.KindCombo.Location=new System.Drawing.Point(943, 9);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(124, 24);
			this.KindCombo.TabIndex=0;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Location=new System.Drawing.Point(160, 21);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(137, 39);
			this.ShowButton.TabIndex=7;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//ShowGridView
			//
			this.ShowGridView.AllowUserToAddRows=false;
			this.ShowGridView.AllowUserToDeleteRows=false;
			this.ShowGridView.AllowUserToResizeColumns=false;
			this.ShowGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column15, this.Column1, this.Column12, this.Column11, this.Column17, this.Column19, this.Column18, this.Column16, this.Column7, this.Column3, this.Column8, this.Column2, this.Column5, this.Column6, this.Column13, this.Column4, this.Column9, this.Column10, this.Column14});
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			DataGridViewCellStyle3.SelectionForeColor=System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
			this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle3;
			this.ShowGridView.EnableHeadersVisualStyles=false;
			this.ShowGridView.Location=new System.Drawing.Point(9, 93);
			this.ShowGridView.MultiSelect=false;
			this.ShowGridView.Name="ShowGridView";
			this.ShowGridView.ReadOnly=true;
			this.ShowGridView.RowHeadersVisible=false;
			this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowGridView.RowTemplate.ReadOnly=true;
			this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.ShowGridView.Size=new System.Drawing.Size(1150, 484);
			this.ShowGridView.TabIndex=38;
			//
			//Column15
			//
			this.Column15.HeaderText="ردیف";
			this.Column15.Name="Column15";
			this.Column15.ReadOnly=true;
			this.Column15.Width=40;
			//
			//Column1
			//
			this.Column1.HeaderText="نام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=80;
			//
			//Column12
			//
			this.Column12.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column12.HeaderText="نام خانوادگی";
			this.Column12.Name="Column12";
			this.Column12.ReadOnly=true;
			//
			//Column11
			//
			this.Column11.HeaderText="شماره پرسنلی";
			this.Column11.Name="Column11";
			this.Column11.ReadOnly=true;
			this.Column11.Width=60;
			//
			//Column17
			//
			this.Column17.HeaderText="نام شیفت";
			this.Column17.Name="Column17";
			this.Column17.ReadOnly=true;
			this.Column17.Visible=false;
			//
			//Column19
			//
			this.Column19.HeaderText="نوع شیفت";
			this.Column19.Name="Column19";
			this.Column19.ReadOnly=true;
			this.Column19.Visible=false;
			//
			//Column18
			//
			this.Column18.HeaderText="مبدا";
			this.Column18.Name="Column18";
			this.Column18.ReadOnly=true;
			this.Column18.Visible=false;
			//
			//Column16
			//
			this.Column16.HeaderText="پست سازمانی";
			this.Column16.Name="Column16";
			this.Column16.ReadOnly=true;
			this.Column16.Width=120;
			//
			//Column7
			//
			this.Column7.HeaderText="اضافه کار متفرقه";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=80;
			//
			//Column3
			//
			this.Column3.HeaderText="اضافه کار آموزشی";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=70;
			//
			//Column8
			//
			this.Column8.HeaderText="اضافه کار کشیک";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Width=80;
			//
			//Column2
			//
			this.Column2.HeaderText="مرخصی ساعتی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=60;
			//
			//Column5
			//
			this.Column5.HeaderText="مرخصی روزانه";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=60;
			//
			//Column6
			//
			this.Column6.HeaderText="امتیاز مثبت";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=60;
			//
			//Column13
			//
			this.Column13.HeaderText="امتیاز منفی";
			this.Column13.Name="Column13";
			this.Column13.ReadOnly=true;
			this.Column13.Width=60;
			//
			//Column4
			//
			this.Column4.HeaderText="جابجایی تریپ";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=60;
			//
			//Column9
			//
			this.Column9.HeaderText="رزرو راهبران";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Width=60;
			//
			//Column10
			//
			this.Column10.HeaderText="درخواست جایگزین";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=70;
			//
			//Column14
			//
			this.Column14.HeaderText="مجموع موارد";
			this.Column14.Name="Column14";
			this.Column14.ReadOnly=true;
			this.Column14.Width=60;
			//
			//ExportButton
			//
			this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
			this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
			this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportButton.Cursor=Cursors.Hand;
			this.ExportButton.Location=new System.Drawing.Point(10, 21);
			this.ExportButton.Name="ExportButton";
			this.ExportButton.Size=new System.Drawing.Size(137, 39);
			this.ExportButton.TabIndex=8;
			this.ExportButton.Text="ذخیره";
			this.ExportButton.UseVisualStyleBackColor=false;
			//
			//Label6
			//
			this.Label6.BackColor=System.Drawing.Color.Navy;
			this.Label6.BorderStyle=BorderStyle.Fixed3D;
			this.Label6.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor=System.Drawing.Color.Yellow;
			this.Label6.Location=new System.Drawing.Point(747, 577);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(412, 25);
			this.Label6.TabIndex=43;
			this.Label6.Text="مجموع موارد :";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Label1S
			//
			this.Label1S.BackColor=System.Drawing.Color.Cyan;
			this.Label1S.BorderStyle=BorderStyle.Fixed3D;
			this.Label1S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1S.Location=new System.Drawing.Point(667, 577);
			this.Label1S.Name="Label1S";
			this.Label1S.Size=new System.Drawing.Size(80, 25);
			this.Label1S.TabIndex=44;
			this.Label1S.Text="0";
			this.Label1S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label2S
			//
			this.Label2S.BackColor=System.Drawing.Color.Cyan;
			this.Label2S.BorderStyle=BorderStyle.Fixed3D;
			this.Label2S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2S.Location=new System.Drawing.Point(597, 577);
			this.Label2S.Name="Label2S";
			this.Label2S.Size=new System.Drawing.Size(70, 25);
			this.Label2S.TabIndex=45;
			this.Label2S.Text="0";
			this.Label2S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label4S
			//
			this.Label4S.BackColor=System.Drawing.Color.Cyan;
			this.Label4S.BorderStyle=BorderStyle.Fixed3D;
			this.Label4S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4S.Location=new System.Drawing.Point(457, 577);
			this.Label4S.Name="Label4S";
			this.Label4S.Size=new System.Drawing.Size(60, 25);
			this.Label4S.TabIndex=47;
			this.Label4S.Text="0";
			this.Label4S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label3S
			//
			this.Label3S.BackColor=System.Drawing.Color.Cyan;
			this.Label3S.BorderStyle=BorderStyle.Fixed3D;
			this.Label3S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3S.Location=new System.Drawing.Point(517, 577);
			this.Label3S.Name="Label3S";
			this.Label3S.Size=new System.Drawing.Size(80, 25);
			this.Label3S.TabIndex=46;
			this.Label3S.Text="0";
			this.Label3S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label6S
			//
			this.Label6S.BackColor=System.Drawing.Color.Cyan;
			this.Label6S.BorderStyle=BorderStyle.Fixed3D;
			this.Label6S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6S.Location=new System.Drawing.Point(337, 577);
			this.Label6S.Name="Label6S";
			this.Label6S.Size=new System.Drawing.Size(60, 25);
			this.Label6S.TabIndex=49;
			this.Label6S.Text="0";
			this.Label6S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label5S
			//
			this.Label5S.BackColor=System.Drawing.Color.Cyan;
			this.Label5S.BorderStyle=BorderStyle.Fixed3D;
			this.Label5S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5S.Location=new System.Drawing.Point(397, 577);
			this.Label5S.Name="Label5S";
			this.Label5S.Size=new System.Drawing.Size(60, 25);
			this.Label5S.TabIndex=48;
			this.Label5S.Text="0";
			this.Label5S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label8S
			//
			this.Label8S.BackColor=System.Drawing.Color.Cyan;
			this.Label8S.BorderStyle=BorderStyle.Fixed3D;
			this.Label8S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8S.Location=new System.Drawing.Point(217, 577);
			this.Label8S.Name="Label8S";
			this.Label8S.Size=new System.Drawing.Size(60, 25);
			this.Label8S.TabIndex=51;
			this.Label8S.Text="0";
			this.Label8S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label7S
			//
			this.Label7S.BackColor=System.Drawing.Color.Cyan;
			this.Label7S.BorderStyle=BorderStyle.Fixed3D;
			this.Label7S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7S.Location=new System.Drawing.Point(277, 577);
			this.Label7S.Name="Label7S";
			this.Label7S.Size=new System.Drawing.Size(60, 25);
			this.Label7S.TabIndex=50;
			this.Label7S.Text="0";
			this.Label7S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label10S
			//
			this.Label10S.BackColor=System.Drawing.Color.Cyan;
			this.Label10S.BorderStyle=BorderStyle.Fixed3D;
			this.Label10S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10S.Location=new System.Drawing.Point(87, 577);
			this.Label10S.Name="Label10S";
			this.Label10S.Size=new System.Drawing.Size(70, 25);
			this.Label10S.TabIndex=53;
			this.Label10S.Text="0";
			this.Label10S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label9S
			//
			this.Label9S.BackColor=System.Drawing.Color.Cyan;
			this.Label9S.BorderStyle=BorderStyle.Fixed3D;
			this.Label9S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9S.Location=new System.Drawing.Point(157, 577);
			this.Label9S.Name="Label9S";
			this.Label9S.Size=new System.Drawing.Size(60, 25);
			this.Label9S.TabIndex=52;
			this.Label9S.Text="0";
			this.Label9S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label11S
			//
			this.Label11S.BackColor=System.Drawing.Color.Cyan;
			this.Label11S.BorderStyle=BorderStyle.Fixed3D;
			this.Label11S.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11S.Location=new System.Drawing.Point(27, 577);
			this.Label11S.Name="Label11S";
			this.Label11S.Size=new System.Drawing.Size(60, 25);
			this.Label11S.TabIndex=54;
			this.Label11S.Text="0";
			this.Label11S.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.ExportButton);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(9, 9);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(1149, 76);
			this.Panel1.TabIndex=0;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(306, 41);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(128, 23);
			this.EndCalendar.TabIndex=63;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(306, 10);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(128, 23);
			this.StartCalendar.TabIndex=62;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(493, 9);
			this.TimeCombo.Margin=new Padding(3, 4, 3, 4);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(96, 24);
			this.TimeCombo.TabIndex=3;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.ForeColor=System.Drawing.Color.Black;
			this.Label3.Location=new System.Drawing.Point(588, 13);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(72, 16);
			this.Label3.TabIndex=61;
			this.Label3.Text="نوع شیفت:";
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(493, 40);
			this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(96, 24);
			this.ShiftCombo.TabIndex=4;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.ForeColor=System.Drawing.Color.Black;
			this.Label13.Location=new System.Drawing.Point(588, 44);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=59;
			this.Label13.Text="نام شیفت:";
			//
			//LocalCombo
			//
			this.LocalCombo.BackColor=System.Drawing.Color.White;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(672, 9);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(222, 24);
			this.LocalCombo.TabIndex=1;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.Location=new System.Drawing.Point(893, 13);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(35, 16);
			this.Label14.TabIndex=49;
			this.Label14.Text="مبدا:";
			//
			//PostCombo
			//
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(672, 40);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(222, 24);
			this.PostCombo.TabIndex=2;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(438, 13);
			this.Label4.Margin=new Padding(5, 0, 5, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(51, 16);
			this.Label4.TabIndex=41;
			this.Label4.Text="از تاریخ:";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(438, 44);
			this.Label5.Margin=new Padding(5, 0, 5, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(51, 16);
			this.Label5.TabIndex=42;
			this.Label5.Text="تا تاریخ:";
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
			this.Label2.Location=new System.Drawing.Point(893, 44);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(97, 16);
			this.Label2.TabIndex=43;
			this.Label2.Text="پست سازمانی:";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//ManagePerformanceReportForm
			//
			this.AcceptButton=this.ShowButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize=new System.Drawing.Size(1166, 609);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label11S);
			this.Controls.Add(this.Label10S);
			this.Controls.Add(this.Label9S);
			this.Controls.Add(this.Label8S);
			this.Controls.Add(this.Label7S);
			this.Controls.Add(this.Label6S);
			this.Controls.Add(this.Label5S);
			this.Controls.Add(this.Label4S);
			this.Controls.Add(this.Label3S);
			this.Controls.Add(this.Label2S);
			this.Controls.Add(this.Label1S);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.ShowGridView);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ManagePerformanceReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="گزارش دوره ای عملکرد پرسنل";
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private Label Label1;
		private ComboBox KindCombo;
		private Button ShowButton;
		private DataGridView ShowGridView;
		private Button ExportButton;
		private Label Label6;
		private Label Label1S;
		private Label Label2S;
		private Label Label4S;
		private Label Label3S;
		private Label Label6S;
		private Label Label5S;
		private Label Label8S;
		private Label Label7S;
		private Label Label10S;
		private Label Label9S;
		private Label Label11S;
		private Panel Panel1;
		private Label Label4;
		private Label Label5;
		private Label Label2;
		private ComboBox PostCombo;
		private ComboBox LocalCombo;
		private Label Label14;
		private ComboBox TimeCombo;
		private Label Label3;
		private ComboBox ShiftCombo;
		private Label Label13;
		private DataGridViewTextBoxColumn Column15;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column17;
		private DataGridViewTextBoxColumn Column19;
		private DataGridViewTextBoxColumn Column18;
		private DataGridViewTextBoxColumn Column16;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column14;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
	}
	
}
