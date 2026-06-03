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
	public partial class PersonalRegisterForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(PersonnelRegisterForm_HelpButtonClicked);
			base.Load += new System.EventHandler(PersonnelRegisterForm_Load);
			this.Label3=new Label();
			this.Label4=new Label();
			this.NameBox=new TextBox();
			this.FamilyBox=new TextBox();
			this.Label7=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.NatIDBox=new TextBox();
			this.NumBox=new TextBox();
			this.Label2=new Label();
			this.ShiftCombo=new ComboBox();
			this.Label13=new Label();
			this.LocalCombo=new ComboBox();
			this.Label18=new Label();
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label17=new Label();
			this.PostCombo=new ComboBox();
			this.Label5=new Label();
			this.GavahiCombo=new ComboBox();
			this.GavahiCombo.SelectedIndexChanged += new System.EventHandler(this.GavahiCombo_SelectedIndexChanged);
			this.Label19=new Label();
			this.PictureBox1=new PictureBox();
			this.PicButton=new Button();
			this.PicButton.Click += new System.EventHandler(this.PicButton_Click);
			this.Panel1=new Panel();
			this.OGroupBox=new TextBox();
			this.Label14=new Label();
			this.GavahiCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Label12=new Label();
			this.UnitCombo=new ComboBox();
			this.Label8=new Label();
			this.BirthdayCalender=new BPersianCalender.BPersianCalenderTextBox();
			this.EmpolyCalender=new BPersianCalender.BPersianCalenderTextBox();
			this.LineCombo=new ComboBox();
			this.CalcCombo=new ComboBox();
			this.Label10=new Label();
			this.Label29=new Label();
			this.Label27=new Label();
			this.Label6=new Label();
			this.Panel2=new Panel();
			this.Panel3=new Panel();
			this.Panel4=new Panel();
			this.Label1=new Label();
			this.Label9=new Label();
			this.Label11=new Label();
			this.Panel5=new Panel();
			this.PostNumBox=new TextBox();
			this.Label15=new Label();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.SuspendLayout();
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(478, 57);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(84, 16);
			this.Label3.TabIndex=2;
			this.Label3.Text="نام خانوادگی:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(478, 23);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(29, 16);
			this.Label4.TabIndex=3;
			this.Label4.Text="نام:";
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(316, 20);
			this.NameBox.MaxLength=50;
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(159, 23);
			this.NameBox.TabIndex=0;
			//
			//FamilyBox
			//
			this.FamilyBox.Location=new System.Drawing.Point(316, 54);
			this.FamilyBox.MaxLength=50;
			this.FamilyBox.Name="FamilyBox";
			this.FamilyBox.Size=new System.Drawing.Size(159, 23);
			this.FamilyBox.TabIndex=1;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(478, 91);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(59, 16);
			this.Label7.TabIndex=10;
			this.Label7.Text="کد ملی :";
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			this.RegButton.Location=new System.Drawing.Point(291, 14);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(274, 34);
			this.RegButton.TabIndex=0;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(12, 14);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(179, 34);
			this.ExitButton.TabIndex=1;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//NatIDBox
			//
			this.NatIDBox.Location=new System.Drawing.Point(316, 88);
			this.NatIDBox.MaxLength=10;
			this.NatIDBox.Name="NatIDBox";
			this.NatIDBox.Size=new System.Drawing.Size(159, 23);
			this.NatIDBox.TabIndex=2;
			//
			//NumBox
			//
			this.NumBox.Location=new System.Drawing.Point(316, 153);
			this.NumBox.MaxLength=6;
			this.NumBox.Name="NumBox";
			this.NumBox.Size=new System.Drawing.Size(159, 23);
			this.NumBox.TabIndex=4;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(478, 156);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(98, 16);
			this.Label2.TabIndex=13;
			this.Label2.Text="شماره پرسنلی:";
			//
			//ShiftCombo
			//
			this.ShiftCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(24, 87);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(159, 24);
			this.ShiftCombo.Sorted=true;
			this.ShiftCombo.TabIndex=11;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Location=new System.Drawing.Point(184, 91);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=31;
			this.Label13.Text="نام شیفت:";
			//
			//LocalCombo
			//
			this.LocalCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(316, 288);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(159, 24);
			this.LocalCombo.Sorted=true;
			this.LocalCombo.TabIndex=8;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Location=new System.Drawing.Point(478, 292);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(92, 16);
			this.Label18.TabIndex=36;
			this.Label18.Text="محل شروع کار:";
			//
			//TimeCombo
			//
			this.TimeCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(24, 53);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(159, 24);
			this.TimeCombo.Sorted=true;
			this.TimeCombo.TabIndex=10;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(184, 57);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(72, 16);
			this.Label17.TabIndex=45;
			this.Label17.Text="نوع شیفت:";
			//
			//PostCombo
			//
			this.PostCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.PostCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(24, 19);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(159, 24);
			this.PostCombo.Sorted=true;
			this.PostCombo.TabIndex=9;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(184, 23);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(97, 16);
			this.Label5.TabIndex=47;
			this.Label5.Text="پست سازمانی:";
			//
			//GavahiCombo
			//
			this.GavahiCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.GavahiCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.GavahiCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.GavahiCombo.FormattingEnabled=true;
			this.GavahiCombo.Items.AddRange(new object[] {"بدون گواهینامه", "پایه دو", "پایه یک"});
			this.GavahiCombo.Location=new System.Drawing.Point(24, 220);
			this.GavahiCombo.Name="GavahiCombo";
			this.GavahiCombo.Size=new System.Drawing.Size(159, 24);
			this.GavahiCombo.TabIndex=12;
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.Location=new System.Drawing.Point(184, 224);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(98, 16);
			this.Label19.TabIndex=50;
			this.Label19.Text="نوع گواهی نامه:";
			//
			//PictureBox1
			//
			this.PictureBox1.BackColor=System.Drawing.Color.White;
			this.PictureBox1.Location=new System.Drawing.Point(11, 11);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(150, 195);
			this.PictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex=52;
			this.PictureBox1.TabStop=false;
			//
			//PicButton
			//
			this.PicButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.PicButton.Image=global::Metro_Operation.Properties.Resources.user__1_;
			this.PicButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.PicButton.Location=new System.Drawing.Point(9, 222);
			this.PicButton.Name="PicButton";
			this.PicButton.Size=new System.Drawing.Size(151, 36);
			this.PicButton.TabIndex=0;
			this.PicButton.Text="بارگذاری تصویر";
			this.PicButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PostNumBox);
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Controls.Add(this.OGroupBox);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.GavahiCalendar);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.Controls.Add(this.UnitCombo);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.BirthdayCalender);
			this.Panel1.Controls.Add(this.EmpolyCalender);
			this.Panel1.Controls.Add(this.LineCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.CalcCombo);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.GavahiCombo);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.Label29);
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Controls.Add(this.Label27);
			this.Panel1.Controls.Add(this.NatIDBox);
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.NumBox);
			this.Panel1.Controls.Add(this.FamilyBox);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Location=new System.Drawing.Point(241, 16);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(597, 333);
			this.Panel1.TabIndex=0;
			//
			//OGroupBox
			//
			this.OGroupBox.Location=new System.Drawing.Point(24, 289);
			this.OGroupBox.MaxLength=3;
			this.OGroupBox.Name="OGroupBox";
			this.OGroupBox.Size=new System.Drawing.Size(159, 23);
			this.OGroupBox.TabIndex=14;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.Location=new System.Drawing.Point(184, 292);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(77, 16);
			this.Label14.TabIndex=122;
			this.Label14.Text="گروه راهبری:";
			//
			//GavahiCalendar
			//
			this.GavahiCalendar.Location=new System.Drawing.Point(24, 255);
			this.GavahiCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.GavahiCalendar.Name="GavahiCalendar";
			this.GavahiCalendar.NowDateSelected=true;
			this.GavahiCalendar.ReadOnly=true;
			this.GavahiCalendar.SelectedDate=null;
			this.GavahiCalendar.Shamsi=null;
			this.GavahiCalendar.Size=new System.Drawing.Size(159, 23);
			this.GavahiCalendar.TabIndex=13;
			this.GavahiCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Label12
			//
			this.Label12.AutoSize=true;
			this.Label12.Location=new System.Drawing.Point(184, 258);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(95, 16);
			this.Label12.TabIndex=118;
			this.Label12.Text="تاریخ گواهینامه:";
			//
			//UnitCombo
			//
			this.UnitCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.UnitCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.UnitCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.UnitCombo.FormattingEnabled=true;
			this.UnitCombo.Items.AddRange(new object[] {"سیر و حرکت", "عملیات پارکینگ و مانور"});
			this.UnitCombo.Location=new System.Drawing.Point(316, 254);
			this.UnitCombo.Name="UnitCombo";
			this.UnitCombo.Size=new System.Drawing.Size(159, 24);
			this.UnitCombo.Sorted=true;
			this.UnitCombo.TabIndex=7;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(478, 258);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(82, 16);
			this.Label8.TabIndex=117;
			this.Label8.Text="واحد خدمتی:";
			//
			//BirthdayCalender
			//
			this.BirthdayCalender.Location=new System.Drawing.Point(316, 122);
			this.BirthdayCalender.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.BirthdayCalender.Name="BirthdayCalender";
			this.BirthdayCalender.NowDateSelected=true;
			this.BirthdayCalender.ReadOnly=true;
			this.BirthdayCalender.SelectedDate=null;
			this.BirthdayCalender.Shamsi=null;
			this.BirthdayCalender.Size=new System.Drawing.Size(159, 23);
			this.BirthdayCalender.TabIndex=3;
			this.BirthdayCalender.TextAlign=HorizontalAlignment.Center;
			//
			//EmpolyCalender
			//
			this.EmpolyCalender.Location=new System.Drawing.Point(316, 187);
			this.EmpolyCalender.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EmpolyCalender.Name="EmpolyCalender";
			this.EmpolyCalender.NowDateSelected=true;
			this.EmpolyCalender.ReadOnly=true;
			this.EmpolyCalender.SelectedDate=null;
			this.EmpolyCalender.Shamsi=null;
			this.EmpolyCalender.Size=new System.Drawing.Size(159, 23);
			this.EmpolyCalender.TabIndex=5;
			this.EmpolyCalender.TextAlign=HorizontalAlignment.Center;
			//
			//LineCombo
			//
			this.LineCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LineCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LineCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LineCombo.FormattingEnabled=true;
			this.LineCombo.Items.AddRange(new object[] {"1", "2", "3", "4", "5"});
			this.LineCombo.Location=new System.Drawing.Point(316, 220);
			this.LineCombo.Name="LineCombo";
			this.LineCombo.RightToLeft=RightToLeft.Yes;
			this.LineCombo.Size=new System.Drawing.Size(159, 24);
			this.LineCombo.Sorted=true;
			this.LineCombo.TabIndex=6;
			//
			//CalcCombo
			//
			this.CalcCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.CalcCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.CalcCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.CalcCombo.FormattingEnabled=true;
			this.CalcCombo.Items.AddRange(new object[] {"راهبر پایانه", "راهبر خط", "سایر پرسنل"});
			this.CalcCombo.Location=new System.Drawing.Point(24, 121);
			this.CalcCombo.Name="CalcCombo";
			this.CalcCombo.Size=new System.Drawing.Size(159, 24);
			this.CalcCombo.Sorted=true;
			this.CalcCombo.TabIndex=11;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Location=new System.Drawing.Point(478, 224);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(31, 16);
			this.Label10.TabIndex=56;
			this.Label10.Text="خط:";
			//
			//Label29
			//
			this.Label29.AutoSize=true;
			this.Label29.Location=new System.Drawing.Point(478, 125);
			this.Label29.Name="Label29";
			this.Label29.Size=new System.Drawing.Size(64, 16);
			this.Label29.TabIndex=112;
			this.Label29.Text="تاریخ تولد:";
			//
			//Label27
			//
			this.Label27.AutoSize=true;
			this.Label27.Location=new System.Drawing.Point(478, 190);
			this.Label27.Name="Label27";
			this.Label27.Size=new System.Drawing.Size(91, 16);
			this.Label27.TabIndex=109;
			this.Label27.Text="تاریخ استخدام:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(184, 125);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(94, 16);
			this.Label6.TabIndex=31;
			this.Label6.Text="محاسبه کارکرد:";
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.RegButton);
			this.Panel2.Controls.Add(this.ExitButton);
			this.Panel2.Location=new System.Drawing.Point(241, 366);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(597, 63);
			this.Panel2.TabIndex=2;
			//
			//Panel3
			//
			this.Panel3.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.PictureBox1);
			this.Panel3.Controls.Add(this.PicButton);
			this.Panel3.Location=new System.Drawing.Point(17, 28);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(175, 275);
			this.Panel3.TabIndex=54;
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.LightBlue;
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Panel3);
			this.Panel4.Location=new System.Drawing.Point(10, 16);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(218, 333);
			this.Panel4.TabIndex=1;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.ForeColor=System.Drawing.Color.Maroon;
			this.Label1.Location=new System.Drawing.Point(61, 4);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(155, 14);
			this.Label1.TabIndex=3;
			this.Label1.Text="ثبت تمامی موارد الزامی است";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Font=new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label9.ForeColor=System.Drawing.Color.Maroon;
			this.Label9.Location=new System.Drawing.Point(3, 25);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(213, 13);
			this.Label9.TabIndex=4;
			this.Label9.Text="ابعاد تصویر حداکثر باید 500*600 پیکسل باشد";
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label11.ForeColor=System.Drawing.Color.Maroon;
			this.Label11.Location=new System.Drawing.Point(-1, 42);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(217, 14);
			this.Label11.TabIndex=5;
			this.Label11.Text="حجم تصویر باید حداکثر 200 کیلوبایت باشد";
			//
			//Panel5
			//
			this.Panel5.BackColor=System.Drawing.Color.Transparent;
			this.Panel5.BorderStyle=BorderStyle.FixedSingle;
			this.Panel5.Controls.Add(this.Label1);
			this.Panel5.Controls.Add(this.Label11);
			this.Panel5.Controls.Add(this.Label9);
			this.Panel5.Location=new System.Drawing.Point(10, 366);
			this.Panel5.Name="Panel5";
			this.Panel5.Size=new System.Drawing.Size(218, 63);
			this.Panel5.TabIndex=6;
			//
			//PostNumBox
			//
			this.PostNumBox.Location=new System.Drawing.Point(24, 153);
			this.PostNumBox.MaxLength=6;
			this.PostNumBox.Name="PostNumBox";
			this.PostNumBox.Size=new System.Drawing.Size(159, 23);
			this.PostNumBox.TabIndex=123;
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.Location=new System.Drawing.Point(186, 156);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(83, 16);
			this.Label15.TabIndex=124;
			this.Label15.Text="شماره پست:";
			//
			//PersonalRegisterForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(861, 440);
			this.Controls.Add(this.Panel5);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel4);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.Margin=new Padding(4, 5, 4, 5);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="PersonalRegisterForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text=" ثبت پرسنل جدید";
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private Label Label3;
		private Label Label4;
		private TextBox NameBox;
		private TextBox FamilyBox;
		private Label Label7;
		private Button RegButton;
		private Button ExitButton;
		private TextBox NatIDBox;
		private TextBox NumBox;
		private Label Label2;
		private ComboBox ShiftCombo;
		private Label Label13;
		private ComboBox LocalCombo;
		private Label Label18;
		private ComboBox TimeCombo;
		private Label Label17;
		private ComboBox PostCombo;
		private Label Label5;
		private ComboBox GavahiCombo;
		private Label Label19;
		private PictureBox PictureBox1;
		private Button PicButton;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Panel Panel4;
		private ComboBox LineCombo;
		private Label Label10;
		private Label Label29;
		private Label Label27;
		private Label Label11;
		private Label Label9;
		private Label Label1;
		private Panel Panel5;
		private BPersianCalender.BPersianCalenderTextBox BirthdayCalender;
		private BPersianCalender.BPersianCalenderTextBox EmpolyCalender;
		private ComboBox UnitCombo;
		private Label Label8;
		private BPersianCalender.BPersianCalenderTextBox GavahiCalendar;
		private Label Label12;
		private TextBox OGroupBox;
		private Label Label14;
		private ComboBox CalcCombo;
		private Label Label6;
		private TextBox PostNumBox;
		private Label Label15;
	}
	
}
