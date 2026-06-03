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
	partial class ElectionRegisterForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(ElectionRegisterForm));
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle5=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle6=new DataGridViewCellStyle();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.Panel2=new Panel();
			this.Label18=new Label();
			this.Label9=new Label();
			this.AnswerCombo=new ComboBox();
			this.LevelCombo=new ComboBox();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.NumBox=new TextBox();
			this.TitrBox=new TextBox();
			this.Label2=new Label();
			this.Label17=new Label();
			this.Label8=new Label();
			this.Label4=new Label();
			this.Label5=new Label();
			this.Panel1=new Panel();
			this.KandidAddButton=new Button();
			this.KandidAddButton.Click += new System.EventHandler(this.KandidAddButton_Click);
			this.KandidGridView=new DataGridView();
			this.KandidGridView.CellClick += new DataGridViewCellEventHandler(this.KandidGridView_CellClick);
			this.KandidGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.KandidGridView_ColumnHeaderMouseClick);
			this.Column14=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewLinkColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.KandidNameButton=new Button();
			this.KandidNameButton.Click += new System.EventHandler(this.KandidNameButton_Click);
			this.KandidNameBox=new TextBox();
			this.Label1=new Label();
			this.Panel3=new Panel();
			this.MemberAddButton=new Button();
			this.MemberAddButton.Click += new System.EventHandler(this.MemberAddButton_Click);
			this.MemberGridView=new DataGridView();
			this.MemberGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.MemberGridView_ColumnHeaderMouseClick);
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewLinkColumn();
			this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
			this.MemberNameButton=new Button();
			this.MemberNameButton.Click += new System.EventHandler(this.MemberNameButton_Click);
			this.MemberNameBox=new TextBox();
			this.Label3=new Label();
			this.Label6=new Label();
			this.Label7=new Label();
			this.MemBox=new TextBox();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.KandidGridView).BeginInit();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.MemberGridView).BeginInit();
			
			
			this.SuspendLayout();
			//
			//RegButton
			//
			this.RegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.RegButton.FlatStyle=FlatStyle.Flat;
			this.RegButton.Location=new System.Drawing.Point(15, 51);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(98, 30);
			this.RegButton.TabIndex=7;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Silver;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Label18);
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.AnswerCombo);
			this.Panel2.Controls.Add(this.LevelCombo);
			this.Panel2.Controls.Add(this.EndCalendar);
			this.Panel2.Controls.Add(this.StartCalendar);
			this.Panel2.Controls.Add(this.RegButton);
			this.Panel2.Controls.Add(this.NumBox);
			this.Panel2.Controls.Add(this.MemBox);
			this.Panel2.Controls.Add(this.TitrBox);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Label17);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Location=new System.Drawing.Point(9, 447);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(874, 133);
			this.Panel2.TabIndex=2;
			this.Panel2.TabStop=true;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label18.Location=new System.Drawing.Point(245, 18);
			this.Label18.Margin=new Padding(3);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(65, 16);
			this.Label18.TabIndex=90;
			this.Label18.Text="نوع نتیجه:";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label9.Location=new System.Drawing.Point(439, 18);
			this.Label9.Margin=new Padding(3);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(88, 16);
			this.Label9.TabIndex=91;
			this.Label9.Text="اولویت نمایش:";
			//
			//AnswerCombo
			//
			this.AnswerCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.AnswerCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.AnswerCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.AnswerCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AnswerCombo.FormattingEnabled=true;
			this.AnswerCombo.Items.AddRange(new object[] {"عمومی", "محرمانه"});
			this.AnswerCombo.Location=new System.Drawing.Point(134, 14);
			this.AnswerCombo.Name="AnswerCombo";
			this.AnswerCombo.Size=new System.Drawing.Size(112, 24);
			this.AnswerCombo.TabIndex=3;
			//
			//LevelCombo
			//
			this.LevelCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LevelCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LevelCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LevelCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LevelCombo.FormattingEnabled=true;
			this.LevelCombo.Items.AddRange(new object[] {"اختیاری", "اجباری"});
			this.LevelCombo.Location=new System.Drawing.Point(328, 14);
			this.LevelCombo.Name="LevelCombo";
			this.LevelCombo.Size=new System.Drawing.Size(112, 24);
			this.LevelCombo.TabIndex=2;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(134, 95);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.RightToLeft=RightToLeft.Yes;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(112, 23);
			this.EndCalendar.TabIndex=6;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(134, 55);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(112, 23);
			this.StartCalendar.TabIndex=5;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//NumBox
			//
			this.NumBox.BackColor=System.Drawing.Color.White;
			this.NumBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NumBox.Location=new System.Drawing.Point(536, 15);
			this.NumBox.MaxLength=2;
			this.NumBox.Name="NumBox";
			this.NumBox.Size=new System.Drawing.Size(55, 23);
			this.NumBox.TabIndex=1;
			//
			//TitrBox
			//
			this.TitrBox.BackColor=System.Drawing.Color.White;
			this.TitrBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TitrBox.Location=new System.Drawing.Point(679, 15);
			this.TitrBox.MaxLength=48;
			this.TitrBox.Name="TitrBox";
			this.TitrBox.Size=new System.Drawing.Size(125, 23);
			this.TitrBox.TabIndex=0;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label2.Location=new System.Drawing.Point(591, 18);
			this.Label2.Margin=new Padding(3);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(79, 16);
			this.Label2.TabIndex=87;
			this.Label2.Text="تعداد انتخاب:";
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label17.Location=new System.Drawing.Point(245, 98);
			this.Label17.Margin=new Padding(3);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(68, 16);
			this.Label17.TabIndex=80;
			this.Label17.Text="تاریخ پایان:";
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label8.Location=new System.Drawing.Point(805, 55);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(62, 16);
			this.Label8.TabIndex=87;
			this.Label8.Text="توضیحات:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(245, 58);
			this.Label4.Margin=new Padding(3);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(74, 16);
			this.Label4.TabIndex=80;
			this.Label4.Text="تاریخ شروع:";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.Location=new System.Drawing.Point(804, 18);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(44, 16);
			this.Label5.TabIndex=87;
			this.Label5.Text="عنوان:";
			//
			//Panel1
			//
			this.Panel1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(222)));
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.KandidAddButton);
			this.Panel1.Controls.Add(this.KandidGridView);
			this.Panel1.Controls.Add(this.KandidNameButton);
			this.Panel1.Controls.Add(this.KandidNameBox);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(453, 46);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(430, 387);
			this.Panel1.TabIndex=0;
			this.Panel1.TabStop=true;
			//
			//KandidAddButton
			//
			this.KandidAddButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.KandidAddButton.Image=global::Metro_Operation.Properties.Resources.add;
			this.KandidAddButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.KandidAddButton.Location=new System.Drawing.Point(27, 15);
			this.KandidAddButton.Name="KandidAddButton";
			this.KandidAddButton.Padding=new Padding(5, 0, 5, 0);
			this.KandidAddButton.Size=new System.Drawing.Size(100, 32);
			this.KandidAddButton.TabIndex=1;
			this.KandidAddButton.Text="اضافه";
			this.KandidAddButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.KandidAddButton.UseVisualStyleBackColor=false;
			//
			//KandidGridView
			//
			this.KandidGridView.AllowUserToAddRows=false;
			this.KandidGridView.AllowUserToDeleteRows=false;
			this.KandidGridView.AllowUserToResizeColumns=false;
			this.KandidGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.KandidGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.KandidGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.KandidGridView.ColumnHeadersHeight=40;
			this.KandidGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.KandidGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column14, this.Column5, this.Column6, this.Column7, this.Column3, this.Column2});
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
			this.KandidGridView.DefaultCellStyle=DataGridViewCellStyle3;
			this.KandidGridView.EnableHeadersVisualStyles=false;
			this.KandidGridView.Location=new System.Drawing.Point(14, 64);
			this.KandidGridView.MultiSelect=false;
			this.KandidGridView.Name="KandidGridView";
			this.KandidGridView.ReadOnly=true;
			this.KandidGridView.RowHeadersVisible=false;
			this.KandidGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.KandidGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KandidGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.KandidGridView.Size=new System.Drawing.Size(400, 308);
			this.KandidGridView.TabIndex=47;
			//
			//Column14
			//
			this.Column14.HeaderText="ردیف";
			this.Column14.Name="Column14";
			this.Column14.ReadOnly=true;
			this.Column14.Width=45;
			//
			//Column5
			//
			this.Column5.HeaderText="نام";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=90;
			//
			//Column6
			//
			this.Column6.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText="نام خانوادگی";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			//
			//Column7
			//
			this.Column7.HeaderText="پرسنلی";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=80;
			//
			//Column3
			//
			this.Column3.HeaderText="";
			this.Column3.LinkColor=System.Drawing.Color.Red;
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.VisitedLinkColor=System.Drawing.Color.Red;
			this.Column3.Width=55;
			//
			//Column2
			//
			this.Column2.HeaderText="ID";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Visible=false;
			//
			//KandidNameButton
			//
			this.KandidNameButton.Image=(System.Drawing.Image) (resources.GetObject("KandidNameButton.Image"));
			this.KandidNameButton.Location=new System.Drawing.Point(175, 19);
			this.KandidNameButton.Name="KandidNameButton";
			this.KandidNameButton.Size=new System.Drawing.Size(30, 25);
			this.KandidNameButton.TabIndex=0;
			this.KandidNameButton.UseVisualStyleBackColor=true;
			//
			//KandidNameBox
			//
			this.KandidNameBox.BackColor=System.Drawing.SystemColors.Window;
			this.KandidNameBox.Location=new System.Drawing.Point(205, 20);
			this.KandidNameBox.Name="KandidNameBox";
			this.KandidNameBox.ReadOnly=true;
			this.KandidNameBox.Size=new System.Drawing.Size(170, 23);
			this.KandidNameBox.TabIndex=45;
			this.KandidNameBox.TabStop=false;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(375, 23);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(29, 16);
			this.Label1.TabIndex=46;
			this.Label1.Text="نام:";
			//
			//Panel3
			//
			this.Panel3.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(222)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.MemberAddButton);
			this.Panel3.Controls.Add(this.MemberGridView);
			this.Panel3.Controls.Add(this.MemberNameButton);
			this.Panel3.Controls.Add(this.MemberNameBox);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Location=new System.Drawing.Point(10, 46);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(430, 387);
			this.Panel3.TabIndex=1;
			this.Panel3.TabStop=true;
			//
			//MemberAddButton
			//
			this.MemberAddButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.MemberAddButton.Image=global::Metro_Operation.Properties.Resources.add;
			this.MemberAddButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.MemberAddButton.Location=new System.Drawing.Point(22, 15);
			this.MemberAddButton.Name="MemberAddButton";
			this.MemberAddButton.Padding=new Padding(5, 0, 5, 0);
			this.MemberAddButton.Size=new System.Drawing.Size(100, 32);
			this.MemberAddButton.TabIndex=1;
			this.MemberAddButton.Text="اضافه";
			this.MemberAddButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.MemberAddButton.UseVisualStyleBackColor=false;
			//
			//MemberGridView
			//
			this.MemberGridView.AllowUserToAddRows=false;
			this.MemberGridView.AllowUserToDeleteRows=false;
			this.MemberGridView.AllowUserToResizeColumns=false;
			this.MemberGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle4.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.MemberGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle4;
			DataGridViewCellStyle5.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle5.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle5.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle5.WrapMode=DataGridViewTriState.False;
			this.MemberGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle5;
			this.MemberGridView.ColumnHeadersHeight=40;
			this.MemberGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.MemberGridView.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.Column1, this.DataGridViewTextBoxColumn5});
			DataGridViewCellStyle6.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle6.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle6.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle6.WrapMode=DataGridViewTriState.False;
			this.MemberGridView.DefaultCellStyle=DataGridViewCellStyle6;
			this.MemberGridView.EnableHeadersVisualStyles=false;
			this.MemberGridView.Location=new System.Drawing.Point(14, 64);
			this.MemberGridView.MultiSelect=false;
			this.MemberGridView.Name="MemberGridView";
			this.MemberGridView.ReadOnly=true;
			this.MemberGridView.RowHeadersVisible=false;
			this.MemberGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.MemberGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MemberGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.MemberGridView.Size=new System.Drawing.Size(400, 308);
			this.MemberGridView.TabIndex=47;
			//
			//DataGridViewTextBoxColumn1
			//
			this.DataGridViewTextBoxColumn1.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly=true;
			this.DataGridViewTextBoxColumn1.Width=45;
			//
			//DataGridViewTextBoxColumn2
			//
			this.DataGridViewTextBoxColumn2.HeaderText="نام";
			this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly=true;
			//
			//DataGridViewTextBoxColumn3
			//
			this.DataGridViewTextBoxColumn3.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn3.HeaderText="نام خانوادگی";
			this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly=true;
			//
			//DataGridViewTextBoxColumn4
			//
			this.DataGridViewTextBoxColumn4.HeaderText="پرسنلی";
			this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly=true;
			this.DataGridViewTextBoxColumn4.Width=80;
			//
			//Column1
			//
			this.Column1.HeaderText="";
			this.Column1.LinkColor=System.Drawing.Color.Red;
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.VisitedLinkColor=System.Drawing.Color.Red;
			this.Column1.Width=55;
			//
			//DataGridViewTextBoxColumn5
			//
			this.DataGridViewTextBoxColumn5.HeaderText="ID";
			this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly=true;
			this.DataGridViewTextBoxColumn5.Visible=false;
			//
			//MemberNameButton
			//
			this.MemberNameButton.Image=(System.Drawing.Image) (resources.GetObject("MemberNameButton.Image"));
			this.MemberNameButton.Location=new System.Drawing.Point(173, 19);
			this.MemberNameButton.Name="MemberNameButton";
			this.MemberNameButton.Size=new System.Drawing.Size(30, 25);
			this.MemberNameButton.TabIndex=0;
			this.MemberNameButton.UseVisualStyleBackColor=true;
			//
			//MemberNameBox
			//
			this.MemberNameBox.BackColor=System.Drawing.SystemColors.Window;
			this.MemberNameBox.Location=new System.Drawing.Point(200, 20);
			this.MemberNameBox.Name="MemberNameBox";
			this.MemberNameBox.ReadOnly=true;
			this.MemberNameBox.Size=new System.Drawing.Size(170, 23);
			this.MemberNameBox.TabIndex=45;
			this.MemberNameBox.TabStop=false;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(370, 23);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(29, 16);
			this.Label3.TabIndex=46;
			this.Label3.Text="نام:";
			//
			//Label6
			//
			this.Label6.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(222)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.Label6.BorderStyle=BorderStyle.FixedSingle;
			this.Label6.Font=new System.Drawing.Font("B Titr", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label6.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Label6.Location=new System.Drawing.Point(10, 12);
			this.Label6.Margin=new Padding(4, 0, 4, 0);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(430, 35);
			this.Label6.TabIndex=46;
			this.Label6.Text="لیست شرکت کنندگان";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label7
			//
			this.Label7.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(222)));
			this.Label7.BorderStyle=BorderStyle.FixedSingle;
			this.Label7.Font=new System.Drawing.Font("B Titr", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label7.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Label7.Location=new System.Drawing.Point(453, 12);
			this.Label7.Margin=new Padding(4, 0, 4, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(430, 35);
			this.Label7.TabIndex=46;
			this.Label7.Text="لیست کاندید ها";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.White;
			this.MemBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MemBox.Location=new System.Drawing.Point(328, 52);
			this.MemBox.MaxLength=250;
			this.MemBox.Multiline=true;
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(476, 66);
			this.MemBox.TabIndex=5;
			//
			//ElectionRegisterForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(893, 591);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ElectionRegisterForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت رای گیری";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.KandidGridView).EndInit();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.MemberGridView).EndInit();
			this.ResumeLayout(false);
			
		}
		private Button RegButton;
		private Panel Panel2;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private TextBox NumBox;
		private TextBox TitrBox;
		private Label Label2;
		private Label Label17;
		private Label Label4;
		private Label Label5;
		private Panel Panel1;
		private Button KandidNameButton;
		private TextBox KandidNameBox;
		private Label Label1;
		private DataGridView KandidGridView;
		private Button KandidAddButton;
		private Panel Panel3;
		private Button MemberAddButton;
		private DataGridView MemberGridView;
		private Button MemberNameButton;
		private TextBox MemberNameBox;
		private Label Label3;
		private Label Label6;
		private Label Label7;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewLinkColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewLinkColumn Column1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private Label Label8;
		private Label Label18;
		private Label Label9;
		private ComboBox AnswerCombo;
		private ComboBox LevelCombo;
		private TextBox MemBox;
	}
	
}
