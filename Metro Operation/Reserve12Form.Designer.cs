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
	public partial class Reserve12Form : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(Reserve12Form_HelpButtonClicked);
			base.Load += new System.EventHandler(Reserve12Form_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			this.Panel4=new Panel();
			this.DelWeekBox=new TextBox();
			this.Label9=new Label();
			this.Label11=new Label();
			this.DelSumBox=new TextBox();
			this.RegSumBox=new TextBox();
			this.Label10=new Label();
			this.Label12=new Label();
			this.RegWeekBox=new TextBox();
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label13=new Label();
			this.Label14=new Label();
			this.Label15=new Label();
			this.Panel1=new Panel();
			this.KindCombo=new ComboBox();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.DelRadioButton=new RadioButton();
			this.DelRadioButton.CheckedChanged += new System.EventHandler(this.DelRadioButton_CheckedChanged);
			this.MemBox=new TextBox();
			this.AddRadioButton=new RadioButton();
			this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
			this.Label17=new Label();
			this.PNumBox=new TextBox();
			this.Label16=new Label();
			this.NameBox=new TextBox();
			this.Label18=new Label();
			this.ReservBox=new TextBox();
			this.Label19=new Label();
			this.Panel2=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
			this.RegGridView=new DataGridView();
			this.Column12=new DataGridViewTextBoxColumn();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column10=new DataGridViewTextBoxColumn();
			this.Column11=new DataGridViewTextBoxColumn();
			this.DetailGridView=new DataGridView();
			this.Panel3=new Panel();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column14=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Panel4.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.RegGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DetailGridView).BeginInit();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.LightBlue;
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.DelWeekBox);
			this.Panel4.Controls.Add(this.Label9);
			this.Panel4.Controls.Add(this.Label11);
			this.Panel4.Controls.Add(this.DelSumBox);
			this.Panel4.Controls.Add(this.RegSumBox);
			this.Panel4.Controls.Add(this.Label10);
			this.Panel4.Controls.Add(this.Label12);
			this.Panel4.Controls.Add(this.RegWeekBox);
			this.Panel4.Location=new System.Drawing.Point(18, 363);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(539, 69);
			this.Panel4.TabIndex=50;
			//
			//DelWeekBox
			//
			this.DelWeekBox.BackColor=System.Drawing.Color.LightBlue;
			this.DelWeekBox.BorderStyle=BorderStyle.FixedSingle;
			this.DelWeekBox.ForeColor=System.Drawing.Color.Black;
			this.DelWeekBox.Location=new System.Drawing.Point(322, 36);
			this.DelWeekBox.Name="DelWeekBox";
			this.DelWeekBox.ReadOnly=true;
			this.DelWeekBox.Size=new System.Drawing.Size(59, 23);
			this.DelWeekBox.TabIndex=3;
			this.DelWeekBox.TabStop=false;
			this.DelWeekBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.ForeColor=System.Drawing.Color.Black;
			this.Label9.Location=new System.Drawing.Point(385, 38);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(130, 16);
			this.Label9.TabIndex=15;
			this.Label9.Text="تعداد حذف های هفته:";
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.ForeColor=System.Drawing.Color.Black;
			this.Label11.Location=new System.Drawing.Point(100, 11);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(131, 16);
			this.Label11.TabIndex=0;
			this.Label11.Text="مجموع ثبت ها از ابتدا:";
			//
			//DelSumBox
			//
			this.DelSumBox.BackColor=System.Drawing.Color.LightBlue;
			this.DelSumBox.BorderStyle=BorderStyle.FixedSingle;
			this.DelSumBox.ForeColor=System.Drawing.Color.Black;
			this.DelSumBox.Location=new System.Drawing.Point(37, 36);
			this.DelSumBox.Name="DelSumBox";
			this.DelSumBox.ReadOnly=true;
			this.DelSumBox.Size=new System.Drawing.Size(59, 23);
			this.DelSumBox.TabIndex=2;
			this.DelSumBox.TabStop=false;
			this.DelSumBox.TextAlign=HorizontalAlignment.Center;
			//
			//RegSumBox
			//
			this.RegSumBox.BackColor=System.Drawing.Color.LightBlue;
			this.RegSumBox.BorderStyle=BorderStyle.FixedSingle;
			this.RegSumBox.ForeColor=System.Drawing.Color.Black;
			this.RegSumBox.Location=new System.Drawing.Point(37, 7);
			this.RegSumBox.Name="RegSumBox";
			this.RegSumBox.ReadOnly=true;
			this.RegSumBox.Size=new System.Drawing.Size(59, 23);
			this.RegSumBox.TabIndex=0;
			this.RegSumBox.TabStop=false;
			this.RegSumBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.ForeColor=System.Drawing.Color.Black;
			this.Label10.Location=new System.Drawing.Point(100, 37);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(137, 16);
			this.Label10.TabIndex=13;
			this.Label10.Text="مجموع حذف ها از ابتدا:";
			//
			//Label12
			//
			this.Label12.AutoSize=true;
			this.Label12.ForeColor=System.Drawing.Color.Black;
			this.Label12.Location=new System.Drawing.Point(385, 12);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(124, 16);
			this.Label12.TabIndex=11;
			this.Label12.Text="تعداد ثبت های هفته:";
			//
			//RegWeekBox
			//
			this.RegWeekBox.BackColor=System.Drawing.Color.LightBlue;
			this.RegWeekBox.BorderStyle=BorderStyle.FixedSingle;
			this.RegWeekBox.ForeColor=System.Drawing.Color.Black;
			this.RegWeekBox.Location=new System.Drawing.Point(322, 7);
			this.RegWeekBox.Name="RegWeekBox";
			this.RegWeekBox.ReadOnly=true;
			this.RegWeekBox.Size=new System.Drawing.Size(59, 23);
			this.RegWeekBox.TabIndex=1;
			this.RegWeekBox.TabStop=false;
			this.RegWeekBox.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Items.AddRange(new object[] {"روز", "شب"});
			this.ShiftCombo.Location=new System.Drawing.Point(22, 75);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(125, 24);
			this.ShiftCombo.TabIndex=3;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(22, 42);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(125, 24);
			this.LocalCombo.TabIndex=2;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.Location=new System.Drawing.Point(146, 79);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(50, 16);
			this.Label13.TabIndex=18;
			this.Label13.Text="شیفت:";
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.BackColor=System.Drawing.Color.Transparent;
			this.Label14.Location=new System.Drawing.Point(146, 15);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(39, 16);
			this.Label14.TabIndex=17;
			this.Label14.Text="تاریخ:";
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.BackColor=System.Drawing.Color.Transparent;
			this.Label15.Location=new System.Drawing.Point(146, 46);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(35, 16);
			this.Label15.TabIndex=19;
			this.Label15.Text="مبدا:";
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.RegButton);
			this.Panel1.Controls.Add(this.DelRadioButton);
			this.Panel1.Controls.Add(this.MemBox);
			this.Panel1.Controls.Add(this.AddRadioButton);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Location=new System.Drawing.Point(581, 269);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(210, 163);
			this.Panel1.TabIndex=1;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {">> لطفا انتخاب کنید <<", "درخواست مسئول شیفت", "در خواست راهبر", "تشخیص تکنیسین"});
			this.KindCombo.Location=new System.Drawing.Point(21, 98);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(176, 24);
			this.KindCombo.TabIndex=20;
			//
			//RegButton
			//
			this.RegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			this.RegButton.Location=new System.Drawing.Point(13, 12);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(96, 52);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="تایید";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//DelRadioButton
			//
			this.DelRadioButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.DelRadioButton.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.DelRadioButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DelRadioButton.ForeColor=System.Drawing.Color.White;
			this.DelRadioButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.DelRadioButton.Location=new System.Drawing.Point(115, 41);
			this.DelRadioButton.Name="DelRadioButton";
			this.DelRadioButton.Padding=new Padding(10, 0, 0, 0);
			this.DelRadioButton.Size=new System.Drawing.Size(82, 22);
			this.DelRadioButton.TabIndex=3;
			this.DelRadioButton.Text="حذف";
			this.DelRadioButton.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			this.DelRadioButton.UseVisualStyleBackColor=false;
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.LightBlue;
			this.MemBox.BorderStyle=BorderStyle.FixedSingle;
			this.MemBox.Location=new System.Drawing.Point(21, 127);
			this.MemBox.MaxLength=50;
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(176, 23);
			this.MemBox.TabIndex=4;
			this.MemBox.TextAlign=HorizontalAlignment.Center;
			//
			//AddRadioButton
			//
			this.AddRadioButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.AddRadioButton.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.AddRadioButton.Checked=true;
			this.AddRadioButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AddRadioButton.ForeColor=System.Drawing.Color.White;
			this.AddRadioButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.AddRadioButton.Location=new System.Drawing.Point(115, 14);
			this.AddRadioButton.Name="AddRadioButton";
			this.AddRadioButton.Padding=new Padding(10, 0, 0, 0);
			this.AddRadioButton.Size=new System.Drawing.Size(82, 23);
			this.AddRadioButton.TabIndex=2;
			this.AddRadioButton.TabStop=true;
			this.AddRadioButton.Text="اضافه";
			this.AddRadioButton.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			this.AddRadioButton.UseVisualStyleBackColor=false;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.BackColor=System.Drawing.Color.LightBlue;
			this.Label17.ForeColor=System.Drawing.Color.Black;
			this.Label17.Location=new System.Drawing.Point(135, 77);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(62, 16);
			this.Label17.TabIndex=18;
			this.Label17.Text="توضیحات:";
			//
			//PNumBox
			//
			this.PNumBox.BackColor=System.Drawing.Color.LightBlue;
			this.PNumBox.Location=new System.Drawing.Point(16, 47);
			this.PNumBox.Name="PNumBox";
			this.PNumBox.ReadOnly=true;
			this.PNumBox.Size=new System.Drawing.Size(66, 23);
			this.PNumBox.TabIndex=12;
			this.PNumBox.TabStop=false;
			this.PNumBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label16
			//
			this.Label16.AutoSize=true;
			this.Label16.BackColor=System.Drawing.Color.LightBlue;
			this.Label16.ForeColor=System.Drawing.Color.Black;
			this.Label16.Location=new System.Drawing.Point(88, 51);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(98, 16);
			this.Label16.TabIndex=11;
			this.Label16.Text="شماره پرسنلی:";
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.Color.LightBlue;
			this.NameBox.Location=new System.Drawing.Point(16, 16);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(132, 23);
			this.NameBox.TabIndex=1;
			this.NameBox.TabStop=false;
			this.NameBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.BackColor=System.Drawing.Color.LightBlue;
			this.Label18.ForeColor=System.Drawing.Color.Black;
			this.Label18.Location=new System.Drawing.Point(155, 18);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(29, 16);
			this.Label18.TabIndex=0;
			this.Label18.Text="نام:";
			//
			//ReservBox
			//
			this.ReservBox.BackColor=System.Drawing.Color.LightBlue;
			this.ReservBox.Location=new System.Drawing.Point(16, 78);
			this.ReservBox.Name="ReservBox";
			this.ReservBox.ReadOnly=true;
			this.ReservBox.Size=new System.Drawing.Size(66, 23);
			this.ReservBox.TabIndex=14;
			this.ReservBox.TabStop=false;
			this.ReservBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.BackColor=System.Drawing.Color.LightBlue;
			this.Label19.ForeColor=System.Drawing.Color.Black;
			this.Label19.Location=new System.Drawing.Point(88, 81);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(63, 16);
			this.Label19.TabIndex=13;
			this.Label19.Text="تعداد رزرو:";
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.PersianCalendar);
			this.Panel2.Controls.Add(this.ShiftCombo);
			this.Panel2.Controls.Add(this.LocalCombo);
			this.Panel2.Controls.Add(this.Label13);
			this.Panel2.Controls.Add(this.Label14);
			this.Panel2.Controls.Add(this.Label15);
			this.Panel2.Location=new System.Drawing.Point(581, 24);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(210, 111);
			this.Panel2.TabIndex=0;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(21, 12);
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
			//RegGridView
			//
			this.RegGridView.AllowUserToAddRows=false;
			this.RegGridView.AllowUserToDeleteRows=false;
			this.RegGridView.AllowUserToResizeColumns=false;
			this.RegGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.RegGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.RegGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.RegGridView.ColumnHeadersHeight=40;
			this.RegGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.RegGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column12, this.Column8, this.Column9, this.Column10, this.Column11});
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
			this.RegGridView.DefaultCellStyle=DataGridViewCellStyle3;
			this.RegGridView.EnableHeadersVisualStyles=false;
			this.RegGridView.Location=new System.Drawing.Point(18, 24);
			this.RegGridView.MultiSelect=false;
			this.RegGridView.Name="RegGridView";
			this.RegGridView.ReadOnly=true;
			this.RegGridView.RowHeadersVisible=false;
			this.RegGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.RegGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RegGridView.SelectionMode=DataGridViewSelectionMode.CellSelect;
			this.RegGridView.Size=new System.Drawing.Size(539, 325);
			this.RegGridView.TabIndex=48;
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
			this.Column9.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column9.HeaderText="نام خانوادگی";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			//
			//Column10
			//
			this.Column10.HeaderText="شماره پرسنلی";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=130;
			//
			//Column11
			//
			this.Column11.HeaderText="شیفت";
			this.Column11.Name="Column11";
			this.Column11.ReadOnly=true;
			this.Column11.Width=125;
			//
			//DetailGridView
			//
			this.DetailGridView.AllowUserToAddRows=false;
			this.DetailGridView.AllowUserToDeleteRows=false;
			this.DetailGridView.AllowUserToResizeColumns=false;
			this.DetailGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle4.BackColor=System.Drawing.SystemColors.Control;
			DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle4.ForeColor=System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode=DataGridViewTriState.True;
			this.DetailGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle4;
			this.DetailGridView.ColumnHeadersHeight=40;
			this.DetailGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DetailGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column5, this.Column6, this.Column1, this.Column2, this.Column3, this.Column14, this.Column4, this.Column7});
			this.DetailGridView.EnableHeadersVisualStyles=false;
			this.DetailGridView.Location=new System.Drawing.Point(20, 111);
			this.DetailGridView.Name="DetailGridView";
			this.DetailGridView.ReadOnly=true;
			this.DetailGridView.RowHeadersVisible=false;
			this.DetailGridView.Size=new System.Drawing.Size(400, 196);
			this.DetailGridView.TabIndex=49;
			this.DetailGridView.Visible=false;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.NameBox);
			this.Panel3.Controls.Add(this.Label19);
			this.Panel3.Controls.Add(this.PNumBox);
			this.Panel3.Controls.Add(this.ReservBox);
			this.Panel3.Controls.Add(this.Label18);
			this.Panel3.Controls.Add(this.Label16);
			this.Panel3.Location=new System.Drawing.Point(581, 142);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(210, 120);
			this.Panel3.TabIndex=1;
			//
			//Column5
			//
			this.Column5.HeaderText="نام";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=50;
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
			this.Column1.Width=50;
			//
			//Column2
			//
			this.Column2.HeaderText="تعداد رزرو";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=40;
			//
			//Column3
			//
			this.Column3.HeaderText="تعداد تریپ";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=45;
			//
			//Column14
			//
			this.Column14.HeaderText="مرخصی روزانه";
			this.Column14.Name="Column14";
			this.Column14.ReadOnly=true;
			this.Column14.Width=45;
			//
			//Column4
			//
			this.Column4.HeaderText="مرخصی ساعتی";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=45;
			//
			//Column7
			//
			this.Column7.HeaderText="امتیاز";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=45;
			//
			//Reserve12Form
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.ClientSize=new System.Drawing.Size(808, 442);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.DetailGridView);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.RegGridView);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="Reserve12Form";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="تعیین راهبران رزرو 12 ساعته";
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.RegGridView).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DetailGridView).EndInit();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private Panel Panel4;
		private TextBox DelWeekBox;
		private Label Label9;
		private Label Label11;
		private TextBox DelSumBox;
		private TextBox RegSumBox;
		private Label Label10;
		private Label Label12;
		private TextBox RegWeekBox;
		private ComboBox ShiftCombo;
		private ComboBox LocalCombo;
		private Label Label13;
		private Label Label14;
		private Label Label15;
		private Panel Panel1;
		private Button RegButton;
		private RadioButton DelRadioButton;
		private TextBox PNumBox;
		private TextBox MemBox;
		private Label Label16;
		private RadioButton AddRadioButton;
		private TextBox NameBox;
		private Label Label17;
		private Label Label18;
		private TextBox ReservBox;
		private Label Label19;
		private Panel Panel2;
		private DataGridView RegGridView;
		private DataGridView DetailGridView;
		private Panel Panel3;
		private ComboBox KindCombo;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column7;
	}
	
}
