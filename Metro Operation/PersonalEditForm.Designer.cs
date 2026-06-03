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
		public partial class PersonalEditForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(PersonnelEditForm_HelpButtonClicked);
			base.Load += new System.EventHandler(Form9_Load);
			this.PersonBox=new TextBox();
			this.PersonalButton=new Button();
			this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.Button5_Click);
			this.Label1=new Label();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.DelButton=new Button();
			this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
			this.GavahiCombo=new ComboBox();
			this.Label19=new Label();
			this.Label5=new Label();
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label17=new Label();
			this.ShiftCombo=new ComboBox();
			this.Label13=new Label();
			this.NumBox=new TextBox();
			this.Label3=new Label();
			this.NatIDBox=new TextBox();
			this.Label7=new Label();
			this.FamilyBox=new TextBox();
			this.NameBox=new TextBox();
			this.Label4=new Label();
			this.Label20=new Label();
			this.PostCombo=new ComboBox();
			this.NoteLabel=new Label();
			this.PicLoadButton=new Button();
			this.PicLoadButton.Click += new System.EventHandler(this.PicButton_Click);
			this.PictureBox1=new PictureBox();
			this.LineCombo=new ComboBox();
			this.LocalCombo=new ComboBox();
			this.Label8=new Label();
			this.Label22=new Label();
			this.Panel1=new Panel();
			this.CalcCombo=new ComboBox();
			this.Label11=new Label();
			this.OGroupBox=new TextBox();
			this.Label10=new Label();
			this.BirthdayCalender=new BPersianCalender.BPersianCalenderTextBox();
			this.GavahiCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EmpolyCalender=new BPersianCalender.BPersianCalenderTextBox();
			this.Label6=new Label();
			this.Label27=new Label();
			this.Label26=new Label();
			this.Label15=new Label();
			this.UnitCombo=new ComboBox();
			this.Label9=new Label();
			this.Panel2=new Panel();
			this.PicDelButton=new Button();
			this.PicDelButton.Click += new System.EventHandler(this.PicDelButton_Click);
			this.Label2=new Label();
			this.Label18=new Label();
			this.Panel3=new Panel();
			this.Panel4=new Panel();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
			//
			//PersonBox
			//
			this.PersonBox.BackColor=System.Drawing.SystemColors.Window;
			this.PersonBox.Location=new System.Drawing.Point(507, 17);
			this.PersonBox.Name="PersonBox";
			this.PersonBox.ReadOnly=true;
			this.PersonBox.Size=new System.Drawing.Size(172, 23);
			this.PersonBox.TabIndex=39;
			this.PersonBox.TabStop=false;
			//
			//PersonalButton
			//
			this.PersonalButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.PersonalButton.Location=new System.Drawing.Point(478, 16);
			this.PersonalButton.Name="PersonalButton";
			this.PersonalButton.Size=new System.Drawing.Size(30, 25);
			this.PersonalButton.TabIndex=0;
			this.PersonalButton.UseVisualStyleBackColor=true;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			
			this.ShowButton.Location=new System.Drawing.Point(25, 11);
			this.ShowButton.Margin=new Padding(4, 5, 4, 5);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(359, 34);
			this.ShowButton.TabIndex=1;
			this.ShowButton.Text="جستجو";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(679, 20);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(69, 16);
			this.Label1.TabIndex=35;
			this.Label1.Text="نام پرسنل:";
			//
			//ExitButton
			//
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(18, 9);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(173, 34);
			this.ExitButton.TabIndex=3;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			this.RegButton.Enabled=false;
			this.RegButton.Location=new System.Drawing.Point(612, 9);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(173, 34);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//DelButton
			//
			this.DelButton.BackColor=System.Drawing.Color.Tomato;
			this.DelButton.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
			this.DelButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.DelButton.Cursor=Cursors.Hand;
			this.DelButton.Enabled=false;
			this.DelButton.Location=new System.Drawing.Point(407, 9);
			this.DelButton.Name="DelButton";
			this.DelButton.Size=new System.Drawing.Size(173, 34);
			this.DelButton.TabIndex=2;
			this.DelButton.Text="حذف";
			this.DelButton.UseVisualStyleBackColor=false;
			//
			//GavahiCombo
			//
			this.GavahiCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.GavahiCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.GavahiCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.GavahiCombo.FormattingEnabled=true;
			this.GavahiCombo.Items.AddRange(new object[] {"بدون گواهینامه", "پایه دو", "پایه یک"});
			this.GavahiCombo.Location=new System.Drawing.Point(228, 178);
			this.GavahiCombo.Name="GavahiCombo";
			this.GavahiCombo.Size=new System.Drawing.Size(171, 24);
			this.GavahiCombo.Sorted=true;
			this.GavahiCombo.TabIndex=13;
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.Location=new System.Drawing.Point(401, 182);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(87, 16);
			this.Label19.TabIndex=87;
			this.Label19.Text="نوع گواهینامه:";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(401, 17);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(97, 16);
			this.Label5.TabIndex=85;
			this.Label5.Text="پست سازمانی:";
			//
			//TimeCombo
			//
			this.TimeCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Items.AddRange(new object[] {"12 ساعته", "9 ساعته", "ستادی"});
			this.TimeCombo.Location=new System.Drawing.Point(228, 46);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(171, 24);
			this.TimeCombo.Sorted=true;
			this.TimeCombo.TabIndex=11;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(401, 50);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(72, 16);
			this.Label17.TabIndex=84;
			this.Label17.Text="نوع شیفت:";
			//
			//ShiftCombo
			//
			this.ShiftCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(228, 79);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(171, 24);
			this.ShiftCombo.Sorted=true;
			this.ShiftCombo.TabIndex=12;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Location=new System.Drawing.Point(401, 83);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=80;
			this.Label13.Text="نام شیفت:";
			//
			//NumBox
			//
			this.NumBox.Enabled=false;
			this.NumBox.Location=new System.Drawing.Point(522, 146);
			this.NumBox.MaxLength=10;
			this.NumBox.Name="NumBox";
			this.NumBox.Size=new System.Drawing.Size(171, 23);
			this.NumBox.TabIndex=4;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(693, 149);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(98, 16);
			this.Label3.TabIndex=75;
			this.Label3.Text="شماره پرسنلی:";
			//
			//NatIDBox
			//
			this.NatIDBox.Location=new System.Drawing.Point(522, 80);
			this.NatIDBox.MaxLength=10;
			this.NatIDBox.Name="NatIDBox";
			this.NatIDBox.Size=new System.Drawing.Size(171, 23);
			this.NatIDBox.TabIndex=2;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(693, 83);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(59, 16);
			this.Label7.TabIndex=74;
			this.Label7.Text="کد ملی :";
			//
			//FamilyBox
			//
			this.FamilyBox.Location=new System.Drawing.Point(522, 47);
			this.FamilyBox.MaxLength=50;
			this.FamilyBox.Name="FamilyBox";
			this.FamilyBox.Size=new System.Drawing.Size(171, 23);
			this.FamilyBox.TabIndex=1;
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(522, 14);
			this.NameBox.MaxLength=50;
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(171, 23);
			this.NameBox.TabIndex=0;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(693, 17);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(29, 16);
			this.Label4.TabIndex=66;
			this.Label4.Text="نام:";
			//
			//Label20
			//
			this.Label20.AutoSize=true;
			this.Label20.Location=new System.Drawing.Point(693, 50);
			this.Label20.Name="Label20";
			this.Label20.Size=new System.Drawing.Size(84, 16);
			this.Label20.TabIndex=63;
			this.Label20.Text="نام خانوادگی:";
			//
			//PostCombo
			//
			this.PostCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.PostCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Items.AddRange(new object[] {"تکنیسین پذیرش و اعزام", "راهبر پایانه", "راهبر قطار", "رئیس سیر و حرکت", "سرپرست سیر و حرکت", "کارشناس سیر و حرکت", "مدیر عملیات و نگهداری تعمیرات", "مسئول سیر و حرکت"});
			this.PostCombo.Location=new System.Drawing.Point(228, 13);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(171, 24);
			this.PostCombo.Sorted=true;
			this.PostCombo.TabIndex=9;
			//
			//NoteLabel
			//
			this.NoteLabel.AutoSize=true;
			this.NoteLabel.ForeColor=System.Drawing.Color.Maroon;
			this.NoteLabel.Location=new System.Drawing.Point(580, 330);
			this.NoteLabel.Name="NoteLabel";
			this.NoteLabel.Size=new System.Drawing.Size(175, 16);
			this.NoteLabel.TabIndex=11;
			this.NoteLabel.Text="ثبت تمامی موارد الزامی است ";
			this.NoteLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//PicLoadButton
			//
			this.PicLoadButton.Image=global::Metro_Operation.Properties.Resources.up_16;
			this.PicLoadButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.PicLoadButton.Location=new System.Drawing.Point(97, 229);
			this.PicLoadButton.Name="PicLoadButton";
			this.PicLoadButton.Size=new System.Drawing.Size(81, 29);
			this.PicLoadButton.TabIndex=0;
			this.PicLoadButton.Text="بارگذاری";
			this.PicLoadButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.PicLoadButton.UseVisualStyleBackColor=true;
			//
			//PictureBox1
			//
			this.PictureBox1.BackColor=System.Drawing.Color.White;
			this.PictureBox1.Location=new System.Drawing.Point(11, 11);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(167, 210);
			this.PictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex=52;
			this.PictureBox1.TabStop=false;
			//
			//LineCombo
			//
			this.LineCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LineCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LineCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LineCombo.Enabled=false;
			this.LineCombo.FormattingEnabled=true;
			this.LineCombo.Items.AddRange(new object[] {"1", "2", "3", "4", "5"});
			this.LineCombo.Location=new System.Drawing.Point(522, 211);
			this.LineCombo.Name="LineCombo";
			this.LineCombo.Size=new System.Drawing.Size(171, 24);
			this.LineCombo.Sorted=true;
			this.LineCombo.TabIndex=7;
			//
			//LocalCombo
			//
			this.LocalCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(522, 277);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(171, 24);
			this.LocalCombo.Sorted=true;
			this.LocalCombo.TabIndex=10;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(693, 215);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(77, 16);
			this.Label8.TabIndex=97;
			this.Label8.Text="محل خدمت:";
			//
			//Label22
			//
			this.Label22.AutoSize=true;
			this.Label22.Location=new System.Drawing.Point(693, 281);
			this.Label22.Name="Label22";
			this.Label22.Size=new System.Drawing.Size(92, 16);
			this.Label22.TabIndex=95;
			this.Label22.Text="محل شروع کار:";
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.CalcCombo);
			this.Panel1.Controls.Add(this.Label11);
			this.Panel1.Controls.Add(this.OGroupBox);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.BirthdayCalender);
			this.Panel1.Controls.Add(this.GavahiCalendar);
			this.Panel1.Controls.Add(this.EmpolyCalender);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label27);
			this.Panel1.Controls.Add(this.Label26);
			this.Panel1.Controls.Add(this.LineCombo);
			this.Panel1.Controls.Add(this.NatIDBox);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.GavahiCombo);
			this.Panel1.Controls.Add(this.UnitCombo);
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.NumBox);
			this.Panel1.Controls.Add(this.FamilyBox);
			this.Panel1.Controls.Add(this.Label20);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Label22);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Controls.Add(this.NoteLabel);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Location=new System.Drawing.Point(12, 76);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(803, 361);
			this.Panel1.TabIndex=1;
			//
			//CalcCombo
			//
			this.CalcCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.CalcCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.CalcCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.CalcCombo.FormattingEnabled=true;
			this.CalcCombo.Items.AddRange(new object[] {"راهبر پایانه", "راهبر خط", "سایر پرسنل", "بدون محاسبه"});
			this.CalcCombo.Location=new System.Drawing.Point(228, 112);
			this.CalcCombo.Name="CalcCombo";
			this.CalcCombo.Size=new System.Drawing.Size(171, 24);
			this.CalcCombo.TabIndex=120;
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.Location=new System.Drawing.Point(399, 116);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(94, 16);
			this.Label11.TabIndex=121;
			this.Label11.Text="محاسبه کارکرد:";
			//
			//OGroupBox
			//
			this.OGroupBox.Location=new System.Drawing.Point(228, 245);
			this.OGroupBox.MaxLength=3;
			this.OGroupBox.Name="OGroupBox";
			this.OGroupBox.Size=new System.Drawing.Size(171, 23);
			this.OGroupBox.TabIndex=118;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Location=new System.Drawing.Point(400, 248);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(77, 16);
			this.Label10.TabIndex=119;
			this.Label10.Text="گروه راهبری:";
			//
			//BirthdayCalender
			//
			this.BirthdayCalender.Location=new System.Drawing.Point(522, 113);
			this.BirthdayCalender.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.BirthdayCalender.Name="BirthdayCalender";
			this.BirthdayCalender.NowDateSelected=true;
			this.BirthdayCalender.ReadOnly=true;
			this.BirthdayCalender.SelectedDate=null;
			this.BirthdayCalender.Shamsi=null;
			this.BirthdayCalender.Size=new System.Drawing.Size(171, 23);
			this.BirthdayCalender.TabIndex=117;
			this.BirthdayCalender.TextAlign=HorizontalAlignment.Center;
			//
			//GavahiCalendar
			//
			this.GavahiCalendar.Location=new System.Drawing.Point(228, 212);
			this.GavahiCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.GavahiCalendar.Name="GavahiCalendar";
			this.GavahiCalendar.NowDateSelected=true;
			this.GavahiCalendar.ReadOnly=true;
			this.GavahiCalendar.SelectedDate=null;
			this.GavahiCalendar.Shamsi=null;
			this.GavahiCalendar.Size=new System.Drawing.Size(171, 23);
			this.GavahiCalendar.TabIndex=116;
			this.GavahiCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//EmpolyCalender
			//
			this.EmpolyCalender.Location=new System.Drawing.Point(522, 179);
			this.EmpolyCalender.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EmpolyCalender.Name="EmpolyCalender";
			this.EmpolyCalender.NowDateSelected=true;
			this.EmpolyCalender.ReadOnly=true;
			this.EmpolyCalender.SelectedDate=null;
			this.EmpolyCalender.Shamsi=null;
			this.EmpolyCalender.Size=new System.Drawing.Size(171, 23);
			this.EmpolyCalender.TabIndex=116;
			this.EmpolyCalender.TextAlign=HorizontalAlignment.Center;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(400, 220);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(95, 16);
			this.Label6.TabIndex=107;
			this.Label6.Text="تاریخ گواهینامه:";
			//
			//Label27
			//
			this.Label27.AutoSize=true;
			this.Label27.Location=new System.Drawing.Point(693, 116);
			this.Label27.Name="Label27";
			this.Label27.Size=new System.Drawing.Size(68, 16);
			this.Label27.TabIndex=108;
			this.Label27.Text="تاریخ تولد :";
			//
			//Label26
			//
			this.Label26.AutoSize=true;
			this.Label26.Location=new System.Drawing.Point(693, 182);
			this.Label26.Name="Label26";
			this.Label26.Size=new System.Drawing.Size(91, 16);
			this.Label26.TabIndex=107;
			this.Label26.Text="تاریخ استخدام:";
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.ForeColor=System.Drawing.Color.Black;
			this.Label15.Location=new System.Drawing.Point(3, 312);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(798, 16);
			this.Label15.TabIndex=101;
			this.Label15.Text="---------------------------------------------------------------------------------" +
				"-----------------------------------------------------------------------------";
			//
			//UnitCombo
			//
			this.UnitCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.UnitCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.UnitCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.UnitCombo.Enabled=false;
			this.UnitCombo.FormattingEnabled=true;
			this.UnitCombo.Items.AddRange(new object[] {"سیر و حرکت", "عملیات پارکینگ و مانور"});
			this.UnitCombo.Location=new System.Drawing.Point(522, 244);
			this.UnitCombo.Name="UnitCombo";
			this.UnitCombo.Size=new System.Drawing.Size(171, 24);
			this.UnitCombo.Sorted=true;
			this.UnitCombo.TabIndex=8;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Location=new System.Drawing.Point(693, 248);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(82, 16);
			this.Label9.TabIndex=85;
			this.Label9.Text="واحد خدمتی:";
			//
			//Panel2
			//
			this.Panel2.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.PicDelButton);
			this.Panel2.Controls.Add(this.PicLoadButton);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Location=new System.Drawing.Point(18, 25);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(190, 272);
			this.Panel2.TabIndex=15;
			//
			//PicDelButton
			//
			this.PicDelButton.Image=global::Metro_Operation.Properties.Resources.close_16;
			this.PicDelButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.PicDelButton.Location=new System.Drawing.Point(11, 229);
			this.PicDelButton.Name="PicDelButton";
			this.PicDelButton.Size=new System.Drawing.Size(81, 29);
			this.PicDelButton.TabIndex=1;
			this.PicDelButton.Text="حذف";
			this.PicDelButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.PicDelButton.UseVisualStyleBackColor=true;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.ForeColor=System.Drawing.Color.Maroon;
			this.Label2.Location=new System.Drawing.Point(54, 330);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(237, 16);
			this.Label2.TabIndex=100;
			this.Label2.Text="حجم تصویر باید حداکثر 100 کیلوبایت باشد";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.BackColor=System.Drawing.Color.Transparent;
			this.Label18.ForeColor=System.Drawing.Color.Maroon;
			this.Label18.Location=new System.Drawing.Point(308, 330);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(255, 16);
			this.Label18.TabIndex=100;
			this.Label18.Text="ابعاد تصویر حداکثر باید 600*600 پیکسل باشد";
			this.Label18.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.PersonBox);
			this.Panel3.Controls.Add(this.ShowButton);
			this.Panel3.Controls.Add(this.PersonalButton);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Location=new System.Drawing.Point(12, 9);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(803, 55);
			this.Panel3.TabIndex=0;
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.LightBlue;
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.DelButton);
			this.Panel4.Controls.Add(this.RegButton);
			this.Panel4.Controls.Add(this.ExitButton);
			this.Panel4.Location=new System.Drawing.Point(13, 449);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(802, 55);
			this.Panel4.TabIndex=2;
			//
			//PersonalEditForm
			//
			this.AcceptButton=this.ShowButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(829, 516);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel4);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="PersonalEditForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ویرایش مشخصات پرسنل";
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private Button ShowButton;
		private Label Label1;
		private Button ExitButton;
		private Button RegButton;
		private TextBox PersonBox;
		private Button PersonalButton;
		private Button DelButton;
		private ComboBox GavahiCombo;
		private Label Label19;
		private Label Label5;
		private ComboBox TimeCombo;
		private Label Label17;
		private ComboBox ShiftCombo;
		private Label Label13;
		private TextBox NumBox;
		private Label Label3;
		private TextBox NatIDBox;
		private Label Label7;
		private TextBox FamilyBox;
		private TextBox NameBox;
		private Label Label4;
		private Label Label20;
		private ComboBox PostCombo;
		private Label NoteLabel;
		private Button PicLoadButton;
		private PictureBox PictureBox1;
		private ComboBox LineCombo;
		private ComboBox LocalCombo;
		private Label Label8;
		private Label Label22;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Label Label18;
		private Panel Panel4;
		private Label Label15;
		private Label Label27;
		private Label Label26;
		private Button PicDelButton;
		private ComboBox UnitCombo;
		private Label Label9;
		private Label Label2;
		private BPersianCalender.BPersianCalenderTextBox BirthdayCalender;
		private BPersianCalender.BPersianCalenderTextBox EmpolyCalender;
		private BPersianCalender.BPersianCalenderTextBox GavahiCalendar;
		private Label Label6;
		private TextBox OGroupBox;
		private Label Label10;
		private ComboBox CalcCombo;
		private Label Label11;
	}
	
}
