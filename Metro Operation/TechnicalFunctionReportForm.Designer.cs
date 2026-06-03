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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class TechnicalFunctionReportForm : BaseForm
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
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components=null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components=new System.ComponentModel.Container();
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(TechnicalFunctionReportForm_HelpButtonClicked);
			base.Load += new System.EventHandler(Form19_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TechnicalFunctionReportForm));
			this.CompeletView=new DataGridView();
			this.CompeletView.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column24=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column25=new DataGridViewTextBoxColumn();
			this.Column17=new DataGridViewTextBoxColumn();
			this.Column18=new DataGridViewTextBoxColumn();
			this.Column19=new DataGridViewTextBoxColumn();
			this.DetailView=new DataGridView();
			this.DetailView.CellClick += new DataGridViewCellEventHandler(this.DetailView_CellClick);
			this.Column5=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.Column20=new DataGridViewTextBoxColumn();
			this.Column21=new DataGridViewTextBoxColumn();
			this.Column22=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column23=new DataGridViewTextBoxColumn();
			this.Label1=new Label();
			this.FaultBox=new RichTextBox();
			this.Label3=new Label();
			this.MemBox=new RichTextBox();
			this.EditButton=new Button();
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.Label11=new Label();
			this.Label2=new Label();
			this.Label4=new Label();
			this.Label5=new Label();
			this.Panel1=new Panel();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.UserCombo=new ComboBox();
			this.UserCombo.SelectedIndexChanged += new System.EventHandler(this.UserCombo_SelectedIndexChanged);
			this.Label10=new Label();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.NameBox=new TextBox();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label6=new Label();
			this.Label8=new Label();
			this.Label9=new Label();
			this.Panel2=new Panel();
			((System.ComponentModel.ISupportInitialize) this.CompeletView).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DetailView).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//CompeletView
			//
			this.CompeletView.AllowUserToAddRows=false;
			this.CompeletView.AllowUserToDeleteRows=false;
			this.CompeletView.AllowUserToResizeColumns=false;
			this.CompeletView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Wheat;
			this.CompeletView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.CompeletView.BackgroundColor=System.Drawing.Color.Tan;
			this.CompeletView.CellBorderStyle=DataGridViewCellBorderStyle.Raised;
			this.CompeletView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Lime;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.CompeletView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.CompeletView.ColumnHeadersHeight=35;
			this.CompeletView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.CompeletView.Columns.AddRange(new DataGridViewColumn[] {this.Column4, this.Column1, this.Column24, this.Column2, this.Column25, this.Column17, this.Column18, this.Column19});
			this.CompeletView.EnableHeadersVisualStyles=false;
			this.CompeletView.Location=new System.Drawing.Point(457, 41);
			this.CompeletView.MultiSelect=false;
			this.CompeletView.Name="CompeletView";
			this.CompeletView.ReadOnly=true;
			this.CompeletView.RowHeadersVisible=false;
			this.CompeletView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.CompeletView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.CompeletView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CompeletView.RowTemplate.ReadOnly=true;
			this.CompeletView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.CompeletView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.CompeletView.Size=new System.Drawing.Size(750, 235);
			this.CompeletView.TabIndex=34;
			//
			//Column4
			//
			this.Column4.HeaderText="ردیف";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=45;
			//
			//Column1
			//
			this.Column1.HeaderText="نام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=105;
			//
			//Column24
			//
			this.Column24.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column24.HeaderText="نام خانوادگی";
			this.Column24.Name="Column24";
			this.Column24.ReadOnly=true;
			//
			//Column2
			//
			this.Column2.HeaderText="شماره پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			//
			//Column25
			//
			this.Column25.HeaderText="تعداد پایش";
			this.Column25.Name="Column25";
			this.Column25.ReadOnly=true;
			this.Column25.Width=80;
			//
			//Column17
			//
			this.Column17.HeaderText="تعداد منفی";
			this.Column17.Name="Column17";
			this.Column17.ReadOnly=true;
			this.Column17.Width=80;
			//
			//Column18
			//
			this.Column18.HeaderText="تعداد مثبت";
			this.Column18.Name="Column18";
			this.Column18.ReadOnly=true;
			this.Column18.Width=80;
			//
			//Column19
			//
			this.Column19.HeaderText="امتیاز کلی";
			this.Column19.Name="Column19";
			this.Column19.ReadOnly=true;
			this.Column19.Width=80;
			//
			//DetailView
			//
			this.DetailView.AllowUserToAddRows=false;
			this.DetailView.AllowUserToDeleteRows=false;
			this.DetailView.AllowUserToResizeColumns=false;
			this.DetailView.AllowUserToResizeRows=false;
			DataGridViewCellStyle3.BackColor=System.Drawing.Color.Yellow;
			this.DetailView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle3;
			this.DetailView.BackgroundColor=System.Drawing.Color.Tan;
			this.DetailView.CellBorderStyle=DataGridViewCellBorderStyle.Raised;
			this.DetailView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode=DataGridViewTriState.False;
			this.DetailView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle4;
			this.DetailView.ColumnHeadersHeight=35;
			this.DetailView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DetailView.Columns.AddRange(new DataGridViewColumn[] {this.Column5, this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.Column20, this.Column21, this.Column22, this.Column6, this.Column3, this.Column23});
			this.DetailView.EnableHeadersVisualStyles=false;
			this.DetailView.Location=new System.Drawing.Point(457, 320);
			this.DetailView.MultiSelect=false;
			this.DetailView.Name="DetailView";
			this.DetailView.ReadOnly=true;
			this.DetailView.RowHeadersVisible=false;
			this.DetailView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DetailView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DetailView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DetailView.RowTemplate.ReadOnly=true;
			this.DetailView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DetailView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DetailView.Size=new System.Drawing.Size(750, 170);
			this.DetailView.TabIndex=35;
			//
			//Column5
			//
			this.Column5.HeaderText="ردیف";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=45;
			//
			//DataGridViewTextBoxColumn1
			//
			this.DataGridViewTextBoxColumn1.HeaderText="تاریخ";
			this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly=true;
			this.DataGridViewTextBoxColumn1.Width=75;
			//
			//DataGridViewTextBoxColumn2
			//
			this.DataGridViewTextBoxColumn2.HeaderText="شماره لکو";
			this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly=true;
			this.DataGridViewTextBoxColumn2.Width=75;
			//
			//Column20
			//
			this.Column20.HeaderText="ساعت اعزام";
			this.Column20.Name="Column20";
			this.Column20.ReadOnly=true;
			this.Column20.Width=85;
			//
			//Column21
			//
			this.Column21.HeaderText="مبدا";
			this.Column21.Name="Column21";
			this.Column21.ReadOnly=true;
			this.Column21.Width=70;
			//
			//Column22
			//
			this.Column22.HeaderText="شماره نامه";
			this.Column22.Name="Column22";
			this.Column22.ReadOnly=true;
			this.Column22.Width=80;
			//
			//Column6
			//
			this.Column6.HeaderText="امتیاز";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=50;
			//
			//Column3
			//
			this.Column3.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText="تحلیل گر";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			//
			//Column23
			//
			this.Column23.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column23.HeaderText="کاربر";
			this.Column23.Name="Column23";
			this.Column23.ReadOnly=true;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label1.Location=new System.Drawing.Point(290, 186);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(153, 16);
			this.Label1.TabIndex=43;
			this.Label1.Text="لیست خطاهای ثبت شده:";
			//
			//FaultBox
			//
			this.FaultBox.BackColor=System.Drawing.Color.Wheat;
			this.FaultBox.BorderStyle=BorderStyle.None;
			this.FaultBox.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FaultBox.Location=new System.Drawing.Point(13, 206);
			this.FaultBox.Name="FaultBox";
			this.FaultBox.ReadOnly=true;
			this.FaultBox.Size=new System.Drawing.Size(426, 122);
			this.FaultBox.TabIndex=42;
			this.FaultBox.Text="";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label3.Location=new System.Drawing.Point(381, 338);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(62, 16);
			this.Label3.TabIndex=22;
			this.Label3.Text="توضیحات:";
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.Wheat;
			this.MemBox.BorderStyle=BorderStyle.None;
			this.MemBox.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MemBox.Location=new System.Drawing.Point(13, 357);
			this.MemBox.Name="MemBox";
			this.MemBox.ReadOnly=true;
			this.MemBox.Size=new System.Drawing.Size(426, 52);
			this.MemBox.TabIndex=23;
			this.MemBox.Text="";
			//
			//EditButton
			//
			this.EditButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.EditButton.Cursor=Cursors.Hand;
			this.EditButton.DialogResult=DialogResult.None;
			this.EditButton.Enabled=false;
			this.EditButton.Image=(System.Drawing.Image) (resources.GetObject("EditButton.Image"));
			this.EditButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.EditButton.Location=new System.Drawing.Point(238, 10);
			this.EditButton.Name="EditButton";
			this.EditButton.Size=new System.Drawing.Size(120, 32);
			this.EditButton.TabIndex=51;
			this.EditButton.Text="ویرایش";
			this.EditButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.Silver;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources.close_16;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Location=new System.Drawing.Point(58, 10);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(120, 32);
			this.ExitButton.TabIndex=50;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//Label11
			//
			this.Label11.BackColor=System.Drawing.Color.Lime;
			this.Label11.BorderStyle=BorderStyle.FixedSingle;
			this.Label11.ForeColor=System.Drawing.Color.Black;
			this.Label11.Location=new System.Drawing.Point(1071, 9);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(126, 24);
			this.Label11.TabIndex=70;
			this.Label11.Text="لیست کلی پرسنل";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//label2
			//
			this.Label2.BackColor=System.Drawing.Color.Yellow;
			this.Label2.BorderStyle=BorderStyle.FixedSingle;
			this.Label2.ForeColor=System.Drawing.Color.Black;
			this.Label2.Location=new System.Drawing.Point(1029, 288);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(168, 24);
			this.Label2.TabIndex=71;
			this.Label2.Text="جزئیات مربوط به هر پرسنل ";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label4
			//
			this.Label4.BackColor=System.Drawing.Color.Black;
			this.Label4.BorderStyle=BorderStyle.FixedSingle;
			this.Label4.ForeColor=System.Drawing.Color.Black;
			this.Label4.Location=new System.Drawing.Point(1076, 14);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(126, 24);
			this.Label4.TabIndex=72;
			this.Label4.Text="لیست کلی پرسنل";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label5
			//
			this.Label5.BackColor=System.Drawing.Color.Black;
			this.Label5.BorderStyle=BorderStyle.FixedSingle;
			this.Label5.ForeColor=System.Drawing.Color.Black;
			this.Label5.Location=new System.Drawing.Point(1034, 293);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(168, 24);
			this.Label5.TabIndex=73;
			this.Label5.Text="جزئیات مربوط به هر پرسنل ";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.UserCombo);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Location=new System.Drawing.Point(13, 41);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(425, 133);
			this.Panel1.TabIndex=74;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(8, 48);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(128, 23);
			this.EndCalendar.TabIndex=55;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(8, 12);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(128, 23);
			this.StartCalendar.TabIndex=54;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//UserCombo
			//
			this.UserCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.UserCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.UserCombo.FormattingEnabled=true;
			this.UserCombo.Location=new System.Drawing.Point(191, 47);
			this.UserCombo.Name="UserCombo";
			this.UserCombo.Size=new System.Drawing.Size(163, 24);
			this.UserCombo.TabIndex=34;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Location=new System.Drawing.Point(353, 51);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(57, 16);
			this.Label10.TabIndex=36;
			this.Label10.Text="نام کاربر:";
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.lgicn_24;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Location=new System.Drawing.Point(30, 85);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(360, 34);
			this.ShowButton.TabIndex=5;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NameBox.Location=new System.Drawing.Point(218, 12);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(135, 23);
			this.NameBox.TabIndex=33;
			//
			//NameButton
			//
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(188, 11);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(353, 15);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(69, 16);
			this.Label6.TabIndex=0;
			this.Label6.Text="نام پرسنل:";
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(135, 51);
			this.Label8.Margin=new Padding(5, 0, 5, 0);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(51, 16);
			this.Label8.TabIndex=28;
			this.Label8.Text="تا تاریخ:";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Location=new System.Drawing.Point(135, 15);
			this.Label9.Margin=new Padding(5, 0, 5, 0);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(51, 16);
			this.Label9.TabIndex=24;
			this.Label9.Text="از تاریخ:";
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Wheat;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.ExitButton);
			this.Panel2.Controls.Add(this.EditButton);
			this.Panel2.Location=new System.Drawing.Point(13, 437);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(425, 53);
			this.Panel2.TabIndex=75;
			//
			//TechnicalFunctionReportForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(1215, 507);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.MemBox);
			this.Controls.Add(this.FaultBox);
			this.Controls.Add(this.DetailView);
			this.Controls.Add(this.CompeletView);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TechnicalFunctionReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="عملکرد فنی راهبران";
			((System.ComponentModel.ISupportInitialize) this.CompeletView).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DetailView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		private DataGridView CompeletView;
		private DataGridView DetailView;
		private Label Label3;
		private RichTextBox MemBox;
		private RichTextBox FaultBox;
		private Label Label1;
		private Button EditButton;
		private Button ExitButton;
		private Label Label11;
		private Label Label2;
		private Label Label4;
		private Label Label5;
		private Panel Panel1;
		private Button ShowButton;
		private TextBox NameBox;
		private Button NameButton;
		private Label Label6;
		private Label Label8;
		private Label Label9;
		private Panel Panel2;
		private ComboBox UserCombo;
		private Label Label10;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column24;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column25;
		private DataGridViewTextBoxColumn Column17;
		private DataGridViewTextBoxColumn Column18;
		private DataGridViewTextBoxColumn Column19;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn Column20;
		private DataGridViewTextBoxColumn Column21;
		private DataGridViewTextBoxColumn Column22;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column23;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
	}
}
