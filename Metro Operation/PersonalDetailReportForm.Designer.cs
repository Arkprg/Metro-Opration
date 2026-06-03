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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class PersonalDetailReportForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(PersonnelDetailReportForm_HelpButtonClicked);
			base.Load += new System.EventHandler(PersonDetailReport_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(PersonalDetailReportForm));
			this.Panel1=new Panel();
			this.PictureBox1=new PictureBox();
			this.ChangeDateBox=new TextBox();
			this.PhonBox=new TextBox();
			this.LicensDateBox=new TextBox();
			this.LicensNumBox=new TextBox();
			this.ShiftBox=new TextBox();
			this.TimeBox=new TextBox();
			this.UnitBox=new TextBox();
			this.LocalBox=new TextBox();
			this.Panel2=new Panel();
			this.LineBox=new TextBox();
			this.Label10=new Label();
			this.PNumBox=new TextBox();
			this.FamilyBox=new TextBox();
			this.NameBox=new TextBox();
			this.BirthdayBox=new TextBox();
			this.NatIDBox=new TextBox();
			this.EmployDayBox=new TextBox();
			this.PostBox=new TextBox();
			this.Label24=new Label();
			this.Label9=new Label();
			this.Label29=new Label();
			this.Label27=new Label();
			this.Label11=new Label();
			this.Label14=new Label();
			this.Label47=new Label();
			this.Label17=new Label();
			this.Label18=new Label();
			this.Label48=new Label();
			this.Label13=new Label();
			this.Label19=new Label();
			this.Label6=new Label();
			this.Label8=new Label();
			this.Label12=new Label();
			this.AddressBox=new TextBox();
			this.Label46=new Label();
			this.SubjectBox=new TextBox();
			this.DegreeBox=new TextBox();
			this.Label45=new Label();
			this.Label44=new Label();
			this.Label1=new Label();
			this.Panel3=new Panel();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Label2=new Label();
			this.Label4=new Label();
			this.PersonBox=new TextBox();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.PersonalButton=new Button();
			this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
			this.Label15=new Label();
			this.Panel5=new Panel();
			this.OrevtimeReqBox=new TextBox();
			this.ReservBox=new TextBox();
			this.ReservButton=new Button();
			this.ReservButton.Click += new System.EventHandler(this.ReservButton_Click);
			this.Label37=new Label();
			this.OrevtimeReqButton=new Button();
			this.OrevtimeReqButton.Click += new System.EventHandler(this.OrevtimeReqButton_Click);
			this.Label40=new Label();
			this.FullBox=new TextBox();
			this.FullButton=new Button();
			this.FullButton.Click += new System.EventHandler(this.FullButton_Click);
			this.Label3=new Label();
			this.ClassBox=new TextBox();
			this.FridayBox=new TextBox();
			this.KeshikBox=new TextBox();
			this.TashvighBox=new TextBox();
			this.TimeLeavButton=new Button();
			this.TimeLeavButton.Click += new System.EventHandler(this.TimeLeavButton_Click);
			this.TashvighButton=new Button();
			this.TashvighButton.Click += new System.EventHandler(this.TashvighButton_Click);
			this.Label21=new Label();
			this.KeshikButton=new Button();
			this.KeshikButton.Click += new System.EventHandler(this.KeshikButton_Click);
			this.MorSaatBox=new TextBox();
			this.OverTimeButton=new Button();
			this.OverTimeButton.Click += new System.EventHandler(this.OverTimeButton_Click);
			this.FridayButton=new Button();
			this.FridayButton.Click += new System.EventHandler(this.FridayButton_Click);
			this.ClassButton=new Button();
			this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
			this.DalyLeavButton=new Button();
			this.DalyLeavButton.Click += new System.EventHandler(this.DalyLeavButton_Click);
			this.OverTimeBox=new TextBox();
			this.MorDayBox=new TextBox();
			this.Label16=new Label();
			this.Label20=new Label();
			this.Label23=new Label();
			this.Label31=new Label();
			this.Label34=new Label();
			this.Label35=new Label();
			this.Label36=new Label();
			this.Button2=new Button();
			this.Label25=new Label();
			this.Label42=new Label();
			this.Label43=new Label();
			this.Panel4=new Panel();
			this.HitBox=new TextBox();
			this.CoatBox=new TextBox();
			this.ShirtBox=new TextBox();
			this.OverBox=new TextBox();
			this.PantBox=new TextBox();
			this.ShoeBox=new TextBox();
			this.Label53=new Label();
			this.Label54=new Label();
			this.Label55=new Label();
			this.Label57=new Label();
			this.Label58=new Label();
			this.Label61=new Label();
			this.Label66=new Label();
			this.Label67=new Label();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.Panel3.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightSteelBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.ChangeDateBox);
			this.Panel1.Controls.Add(this.PhonBox);
			this.Panel1.Controls.Add(this.LicensDateBox);
			this.Panel1.Controls.Add(this.LicensNumBox);
			this.Panel1.Controls.Add(this.ShiftBox);
			this.Panel1.Controls.Add(this.TimeBox);
			this.Panel1.Controls.Add(this.UnitBox);
			this.Panel1.Controls.Add(this.LocalBox);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Controls.Add(this.LineBox);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.PNumBox);
			this.Panel1.Controls.Add(this.FamilyBox);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.BirthdayBox);
			this.Panel1.Controls.Add(this.NatIDBox);
			this.Panel1.Controls.Add(this.EmployDayBox);
			this.Panel1.Controls.Add(this.PostBox);
			this.Panel1.Controls.Add(this.Label24);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Label29);
			this.Panel1.Controls.Add(this.Label27);
			this.Panel1.Controls.Add(this.Label11);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.Label47);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Controls.Add(this.Label48);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.ForeColor=System.Drawing.Color.Black;
			this.Panel1.Location=new System.Drawing.Point(12, 100);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(988, 176);
			this.Panel1.TabIndex=1;
			//
			//PictureBox1
			//
			this.PictureBox1.BackColor=System.Drawing.Color.White;
			this.PictureBox1.BorderStyle=BorderStyle.FixedSingle;
			this.PictureBox1.Location=new System.Drawing.Point(15, 9);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(125, 150);
			this.PictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex=52;
			this.PictureBox1.TabStop=false;
			//
			//ChangeDateBox
			//
			this.ChangeDateBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.ChangeDateBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ChangeDateBox.ForeColor=System.Drawing.Color.Black;
			this.ChangeDateBox.Location=new System.Drawing.Point(176, 133);
			this.ChangeDateBox.Name="ChangeDateBox";
			this.ChangeDateBox.ReadOnly=true;
			this.ChangeDateBox.Size=new System.Drawing.Size(100, 23);
			this.ChangeDateBox.TabIndex=155;
			this.ChangeDateBox.TabStop=false;
			this.ChangeDateBox.TextAlign=HorizontalAlignment.Center;
			//
			//PhonBox
			//
			this.PhonBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.PhonBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.PhonBox.ForeColor=System.Drawing.Color.Black;
			this.PhonBox.Location=new System.Drawing.Point(176, 96);
			this.PhonBox.Name="PhonBox";
			this.PhonBox.ReadOnly=true;
			this.PhonBox.Size=new System.Drawing.Size(100, 23);
			this.PhonBox.TabIndex=154;
			this.PhonBox.TabStop=false;
			this.PhonBox.TextAlign=HorizontalAlignment.Center;
			//
			//LicensDateBox
			//
			this.LicensDateBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.LicensDateBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LicensDateBox.ForeColor=System.Drawing.Color.Black;
			this.LicensDateBox.Location=new System.Drawing.Point(176, 59);
			this.LicensDateBox.Name="LicensDateBox";
			this.LicensDateBox.ReadOnly=true;
			this.LicensDateBox.Size=new System.Drawing.Size(100, 23);
			this.LicensDateBox.TabIndex=153;
			this.LicensDateBox.TabStop=false;
			this.LicensDateBox.TextAlign=HorizontalAlignment.Center;
			//
			//LicensNumBox
			//
			this.LicensNumBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.LicensNumBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LicensNumBox.ForeColor=System.Drawing.Color.Black;
			this.LicensNumBox.Location=new System.Drawing.Point(176, 22);
			this.LicensNumBox.Name="LicensNumBox";
			this.LicensNumBox.ReadOnly=true;
			this.LicensNumBox.Size=new System.Drawing.Size(100, 23);
			this.LicensNumBox.TabIndex=153;
			this.LicensNumBox.TabStop=false;
			this.LicensNumBox.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftBox
			//
			this.ShiftBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.ShiftBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ShiftBox.ForeColor=System.Drawing.Color.Black;
			this.ShiftBox.Location=new System.Drawing.Point(382, 133);
			this.ShiftBox.Name="ShiftBox";
			this.ShiftBox.ReadOnly=true;
			this.ShiftBox.Size=new System.Drawing.Size(100, 23);
			this.ShiftBox.TabIndex=152;
			this.ShiftBox.TabStop=false;
			this.ShiftBox.TextAlign=HorizontalAlignment.Center;
			//
			//TimeBox
			//
			this.TimeBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.TimeBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.TimeBox.ForeColor=System.Drawing.Color.Black;
			this.TimeBox.Location=new System.Drawing.Point(382, 96);
			this.TimeBox.Name="TimeBox";
			this.TimeBox.ReadOnly=true;
			this.TimeBox.Size=new System.Drawing.Size(100, 23);
			this.TimeBox.TabIndex=151;
			this.TimeBox.TabStop=false;
			this.TimeBox.TextAlign=HorizontalAlignment.Center;
			//
			//UnitBox
			//
			this.UnitBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.UnitBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.UnitBox.ForeColor=System.Drawing.Color.Black;
			this.UnitBox.Location=new System.Drawing.Point(587, 96);
			this.UnitBox.Name="UnitBox";
			this.UnitBox.ReadOnly=true;
			this.UnitBox.Size=new System.Drawing.Size(100, 23);
			this.UnitBox.TabIndex=150;
			this.UnitBox.TabStop=false;
			this.UnitBox.TextAlign=HorizontalAlignment.Center;
			//
			//LocalBox
			//
			this.LocalBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.LocalBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LocalBox.ForeColor=System.Drawing.Color.Black;
			this.LocalBox.Location=new System.Drawing.Point(382, 22);
			this.LocalBox.Name="LocalBox";
			this.LocalBox.ReadOnly=true;
			this.LocalBox.Size=new System.Drawing.Size(100, 23);
			this.LocalBox.TabIndex=150;
			this.LocalBox.TabStop=false;
			this.LocalBox.TextAlign=HorizontalAlignment.Center;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Black;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Location=new System.Drawing.Point(22, 15);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(125, 150);
			this.Panel2.TabIndex=141;
			//
			//LineBox
			//
			this.LineBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.LineBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LineBox.ForeColor=System.Drawing.Color.Black;
			this.LineBox.Location=new System.Drawing.Point(587, 59);
			this.LineBox.Name="LineBox";
			this.LineBox.ReadOnly=true;
			this.LineBox.Size=new System.Drawing.Size(100, 23);
			this.LineBox.TabIndex=149;
			this.LineBox.TabStop=false;
			this.LineBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label10.Location=new System.Drawing.Point(687, 63);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(27, 14);
			this.Label10.TabIndex=137;
			this.Label10.Text="خط:";
			//
			//PNumBox
			//
			this.PNumBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.PNumBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.PNumBox.ForeColor=System.Drawing.Color.Black;
			this.PNumBox.Location=new System.Drawing.Point(587, 22);
			this.PNumBox.Name="PNumBox";
			this.PNumBox.ReadOnly=true;
			this.PNumBox.Size=new System.Drawing.Size(100, 23);
			this.PNumBox.TabIndex=148;
			this.PNumBox.TabStop=false;
			this.PNumBox.TextAlign=HorizontalAlignment.Center;
			//
			//FamilyBox
			//
			this.FamilyBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.FamilyBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FamilyBox.ForeColor=System.Drawing.Color.Black;
			this.FamilyBox.Location=new System.Drawing.Point(795, 59);
			this.FamilyBox.Name="FamilyBox";
			this.FamilyBox.ReadOnly=true;
			this.FamilyBox.Size=new System.Drawing.Size(100, 23);
			this.FamilyBox.TabIndex=147;
			this.FamilyBox.TabStop=false;
			this.FamilyBox.TextAlign=HorizontalAlignment.Center;
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.NameBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.NameBox.ForeColor=System.Drawing.Color.Black;
			this.NameBox.Location=new System.Drawing.Point(795, 22);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(100, 23);
			this.NameBox.TabIndex=146;
			this.NameBox.TabStop=false;
			this.NameBox.TextAlign=HorizontalAlignment.Center;
			//
			//BirthdayBox
			//
			this.BirthdayBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.BirthdayBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.BirthdayBox.ForeColor=System.Drawing.Color.Black;
			this.BirthdayBox.Location=new System.Drawing.Point(795, 133);
			this.BirthdayBox.Name="BirthdayBox";
			this.BirthdayBox.ReadOnly=true;
			this.BirthdayBox.Size=new System.Drawing.Size(100, 23);
			this.BirthdayBox.TabIndex=145;
			this.BirthdayBox.TabStop=false;
			this.BirthdayBox.TextAlign=HorizontalAlignment.Center;
			//
			//NatIDBox
			//
			this.NatIDBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.NatIDBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.NatIDBox.ForeColor=System.Drawing.Color.Black;
			this.NatIDBox.Location=new System.Drawing.Point(795, 96);
			this.NatIDBox.Name="NatIDBox";
			this.NatIDBox.ReadOnly=true;
			this.NatIDBox.Size=new System.Drawing.Size(100, 23);
			this.NatIDBox.TabIndex=144;
			this.NatIDBox.TabStop=false;
			this.NatIDBox.TextAlign=HorizontalAlignment.Center;
			//
			//EmployDayBox
			//
			this.EmployDayBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.EmployDayBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.EmployDayBox.ForeColor=System.Drawing.Color.Black;
			this.EmployDayBox.Location=new System.Drawing.Point(382, 59);
			this.EmployDayBox.Name="EmployDayBox";
			this.EmployDayBox.ReadOnly=true;
			this.EmployDayBox.Size=new System.Drawing.Size(100, 23);
			this.EmployDayBox.TabIndex=143;
			this.EmployDayBox.TabStop=false;
			this.EmployDayBox.TextAlign=HorizontalAlignment.Center;
			//
			//PostBox
			//
			this.PostBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.PostBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.PostBox.ForeColor=System.Drawing.Color.Black;
			this.PostBox.Location=new System.Drawing.Point(587, 133);
			this.PostBox.Name="PostBox";
			this.PostBox.ReadOnly=true;
			this.PostBox.Size=new System.Drawing.Size(100, 23);
			this.PostBox.TabIndex=142;
			this.PostBox.TabStop=false;
			this.PostBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label24
			//
			this.Label24.AutoSize=true;
			this.Label24.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label24.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label24.Location=new System.Drawing.Point(276, 137);
			this.Label24.Name="Label24";
			this.Label24.Size=new System.Drawing.Size(78, 14);
			this.Label24.TabIndex=138;
			this.Label24.Text="آخرین تغییرات:";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label9.Location=new System.Drawing.Point(276, 100);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(70, 14);
			this.Label9.TabIndex=123;
			this.Label9.Text="شماره تلفن:";
			//
			//Label29
			//
			this.Label29.AutoSize=true;
			this.Label29.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label29.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label29.Location=new System.Drawing.Point(895, 137);
			this.Label29.Name="Label29";
			this.Label29.Size=new System.Drawing.Size(55, 14);
			this.Label29.TabIndex=140;
			this.Label29.Text="تاریخ تولد:";
			//
			//Label27
			//
			this.Label27.AutoSize=true;
			this.Label27.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label27.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label27.Location=new System.Drawing.Point(484, 63);
			this.Label27.Name="Label27";
			this.Label27.Size=new System.Drawing.Size(81, 14);
			this.Label27.TabIndex=139;
			this.Label27.Text="تاریخ استخدام:";
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label11.Location=new System.Drawing.Point(895, 100);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(50, 14);
			this.Label11.TabIndex=125;
			this.Label11.Text="کد ملی:";
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label14.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label14.Location=new System.Drawing.Point(687, 137);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(87, 14);
			this.Label14.TabIndex=135;
			this.Label14.Text="پست سازمانی:";
			//
			//Label47
			//
			this.Label47.AutoSize=true;
			this.Label47.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label47.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label47.Location=new System.Drawing.Point(687, 100);
			this.Label47.Name="Label47";
			this.Label47.Size=new System.Drawing.Size(75, 14);
			this.Label47.TabIndex=133;
			this.Label47.Text="واحد خدمتی:";
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label17.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label17.Location=new System.Drawing.Point(484, 100);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(63, 14);
			this.Label17.TabIndex=134;
			this.Label17.Text="نوع شیفت:";
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label18.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label18.Location=new System.Drawing.Point(482, 26);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(85, 14);
			this.Label18.TabIndex=133;
			this.Label18.Text="محل شروع کار:";
			//
			//Label48
			//
			this.Label48.AutoSize=true;
			this.Label48.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label48.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label48.Location=new System.Drawing.Point(276, 63);
			this.Label48.Name="Label48";
			this.Label48.Size=new System.Drawing.Size(84, 14);
			this.Label48.TabIndex=136;
			this.Label48.Text="تاریخ گواهینامه:";
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label13.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label13.Location=new System.Drawing.Point(484, 137);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(62, 14);
			this.Label13.TabIndex=132;
			this.Label13.Text="نام شیفت:";
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label19.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label19.Location=new System.Drawing.Point(276, 26);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(77, 14);
			this.Label19.TabIndex=136;
			this.Label19.Text="نوع گواهینامه:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label6.Location=new System.Drawing.Point(895, 63);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(76, 14);
			this.Label6.TabIndex=116;
			this.Label6.Text="نام خانوادگی:";
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label8.Location=new System.Drawing.Point(895, 26);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(25, 14);
			this.Label8.TabIndex=117;
			this.Label8.Text="نام:";
			//
			//Label12
			//
			this.Label12.AutoSize=true;
			this.Label12.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label12.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label12.Location=new System.Drawing.Point(687, 26);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(88, 14);
			this.Label12.TabIndex=130;
			this.Label12.Text="شماره پرسنلی:";
			//
			//AddressBox
			//
			this.AddressBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.AddressBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.AddressBox.ForeColor=System.Drawing.Color.Black;
			this.AddressBox.Location=new System.Drawing.Point(29, 62);
			this.AddressBox.Name="AddressBox";
			this.AddressBox.ReadOnly=true;
			this.AddressBox.Size=new System.Drawing.Size(619, 23);
			this.AddressBox.TabIndex=149;
			this.AddressBox.TabStop=false;
			this.AddressBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label46
			//
			this.Label46.AutoSize=true;
			this.Label46.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label46.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label46.Location=new System.Drawing.Point(648, 66);
			this.Label46.Name="Label46";
			this.Label46.Size=new System.Drawing.Size(39, 14);
			this.Label46.TabIndex=137;
			this.Label46.Text="آدرس:";
			//
			//SubjectBox
			//
			this.SubjectBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.SubjectBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.SubjectBox.ForeColor=System.Drawing.Color.Black;
			this.SubjectBox.Location=new System.Drawing.Point(710, 62);
			this.SubjectBox.Name="SubjectBox";
			this.SubjectBox.ReadOnly=true;
			this.SubjectBox.Size=new System.Drawing.Size(180, 23);
			this.SubjectBox.TabIndex=154;
			this.SubjectBox.TabStop=false;
			this.SubjectBox.TextAlign=HorizontalAlignment.Center;
			//
			//DegreeBox
			//
			this.DegreeBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.DegreeBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.DegreeBox.ForeColor=System.Drawing.Color.Black;
			this.DegreeBox.Location=new System.Drawing.Point(710, 23);
			this.DegreeBox.Name="DegreeBox";
			this.DegreeBox.ReadOnly=true;
			this.DegreeBox.Size=new System.Drawing.Size(180, 23);
			this.DegreeBox.TabIndex=154;
			this.DegreeBox.TabStop=false;
			this.DegreeBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label45
			//
			this.Label45.AutoSize=true;
			this.Label45.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label45.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label45.Location=new System.Drawing.Point(890, 66);
			this.Label45.Name="Label45";
			this.Label45.Size=new System.Drawing.Size(82, 14);
			this.Label45.TabIndex=123;
			this.Label45.Text="رشته تحصیلی:";
			//
			//Label44
			//
			this.Label44.AutoSize=true;
			this.Label44.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label44.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label44.Location=new System.Drawing.Point(890, 27);
			this.Label44.Name="Label44";
			this.Label44.Size=new System.Drawing.Size(83, 14);
			this.Label44.TabIndex=123;
			this.Label44.Text="مدرک تحصیلی:";
			//
			//Label1
			//
			this.Label1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Label1.BorderStyle=BorderStyle.FixedSingle;
			this.Label1.Cursor=Cursors.Default;
			this.Label1.Location=new System.Drawing.Point(863, 85);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(122, 22);
			this.Label1.TabIndex=44;
			this.Label1.Text="مشخصات";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightSteelBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.EndCalendar);
			this.Panel3.Controls.Add(this.StartCalendar);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.PersonBox);
			this.Panel3.Controls.Add(this.ShowButton);
			this.Panel3.Controls.Add(this.PersonalButton);
			this.Panel3.Controls.Add(this.Label15);
			this.Panel3.Location=new System.Drawing.Point(11, 13);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(988, 63);
			this.Panel3.TabIndex=45;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(277, 19);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(128, 23);
			this.EndCalendar.TabIndex=64;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(473, 19);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(128, 23);
			this.StartCalendar.TabIndex=63;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(602, 22);
			this.Label2.Margin=new Padding(4, 0, 4, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(51, 16);
			this.Label2.TabIndex=61;
			this.Label2.Text="از تاریخ:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(406, 22);
			this.Label4.Margin=new Padding(4, 0, 4, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(51, 16);
			this.Label4.TabIndex=62;
			this.Label4.Text="تا تاریخ:";
			//
			//PersonBox
			//
			this.PersonBox.BackColor=System.Drawing.SystemColors.Window;
			this.PersonBox.Location=new System.Drawing.Point(761, 19);
			this.PersonBox.Name="PersonBox";
			this.PersonBox.ReadOnly=true;
			this.PersonBox.Size=new System.Drawing.Size(140, 23);
			this.PersonBox.TabIndex=39;
			this.PersonBox.TabStop=false;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			
			this.ShowButton.Location=new System.Drawing.Point(14, 13);
			this.ShowButton.Margin=new Padding(4, 5, 4, 5);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(132, 34);
			this.ShowButton.TabIndex=2;
			this.ShowButton.Text="  نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//PersonalButton
			//
			this.PersonalButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.PersonalButton.Location=new System.Drawing.Point(731, 18);
			this.PersonalButton.Name="PersonalButton";
			this.PersonalButton.Size=new System.Drawing.Size(30, 25);
			this.PersonalButton.TabIndex=1;
			this.PersonalButton.UseVisualStyleBackColor=true;
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.Location=new System.Drawing.Point(900, 22);
			this.Label15.Margin=new Padding(4, 0, 4, 0);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(69, 16);
			this.Label15.TabIndex=35;
			this.Label15.Text="نام پرسنل:";
			//
			//Panel5
			//
			this.Panel5.BackColor=System.Drawing.Color.LightSteelBlue;
			this.Panel5.BorderStyle=BorderStyle.FixedSingle;
			this.Panel5.Controls.Add(this.OrevtimeReqBox);
			this.Panel5.Controls.Add(this.ReservBox);
			this.Panel5.Controls.Add(this.ReservButton);
			this.Panel5.Controls.Add(this.Label37);
			this.Panel5.Controls.Add(this.OrevtimeReqButton);
			this.Panel5.Controls.Add(this.Label40);
			this.Panel5.Controls.Add(this.FullBox);
			this.Panel5.Controls.Add(this.FullButton);
			this.Panel5.Controls.Add(this.Label3);
			this.Panel5.Controls.Add(this.ClassBox);
			this.Panel5.Controls.Add(this.FridayBox);
			this.Panel5.Controls.Add(this.KeshikBox);
			this.Panel5.Controls.Add(this.TashvighBox);
			this.Panel5.Controls.Add(this.TimeLeavButton);
			this.Panel5.Controls.Add(this.TashvighButton);
			this.Panel5.Controls.Add(this.Label21);
			this.Panel5.Controls.Add(this.KeshikButton);
			this.Panel5.Controls.Add(this.MorSaatBox);
			this.Panel5.Controls.Add(this.OverTimeButton);
			this.Panel5.Controls.Add(this.FridayButton);
			this.Panel5.Controls.Add(this.ClassButton);
			this.Panel5.Controls.Add(this.DalyLeavButton);
			this.Panel5.Controls.Add(this.OverTimeBox);
			this.Panel5.Controls.Add(this.MorDayBox);
			this.Panel5.Controls.Add(this.Label16);
			this.Panel5.Controls.Add(this.Label20);
			this.Panel5.Controls.Add(this.Label23);
			this.Panel5.Controls.Add(this.Label31);
			this.Panel5.Controls.Add(this.Label34);
			this.Panel5.Controls.Add(this.Label35);
			this.Panel5.ForeColor=System.Drawing.Color.Black;
			this.Panel5.Location=new System.Drawing.Point(11, 425);
			this.Panel5.Name="Panel5";
			this.Panel5.Size=new System.Drawing.Size(989, 138);
			this.Panel5.TabIndex=47;
			//
			//OrevtimeReqBox
			//
			this.OrevtimeReqBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.OrevtimeReqBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.OrevtimeReqBox.Location=new System.Drawing.Point(292, 65);
			this.OrevtimeReqBox.MaxLength=5;
			this.OrevtimeReqBox.Name="OrevtimeReqBox";
			this.OrevtimeReqBox.ReadOnly=true;
			this.OrevtimeReqBox.Size=new System.Drawing.Size(50, 23);
			this.OrevtimeReqBox.TabIndex=187;
			this.OrevtimeReqBox.Text="0";
			this.OrevtimeReqBox.TextAlign=HorizontalAlignment.Center;
			//
			//ReservBox
			//
			this.ReservBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ReservBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ReservBox.Location=new System.Drawing.Point(292, 31);
			this.ReservBox.MaxLength=5;
			this.ReservBox.Name="ReservBox";
			this.ReservBox.ReadOnly=true;
			this.ReservBox.Size=new System.Drawing.Size(50, 23);
			this.ReservBox.TabIndex=186;
			this.ReservBox.Text="0";
			this.ReservBox.TextAlign=HorizontalAlignment.Center;
			//
			//ReservButton
			//
			this.ReservButton.Image=(System.Drawing.Image) (resources.GetObject("ReservButton.BackgroundImage"));
			this.ReservButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ReservButton.Cursor=Cursors.Hand;
			this.ReservButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.ReservButton.Location=new System.Drawing.Point(267, 30);
			this.ReservButton.Name="ReservButton";
			this.ReservButton.Size=new System.Drawing.Size(25, 25);
			this.ReservButton.TabIndex=185;
			this.ReservButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.ReservButton.UseVisualStyleBackColor=true;
			//
			//Label37
			//
			this.Label37.AutoSize=true;
			this.Label37.Location=new System.Drawing.Point(341, 34);
			this.Label37.Name="Label37";
			this.Label37.Size=new System.Drawing.Size(63, 16);
			this.Label37.TabIndex=184;
			this.Label37.Text="تعداد رزرو:";
			//
			//OrevtimeReqButton
			//
			this.OrevtimeReqButton.Image=(System.Drawing.Image) (resources.GetObject("OrevtimeReqButton.BackgroundImage"));
			this.OrevtimeReqButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.OrevtimeReqButton.Cursor=Cursors.Hand;
			this.OrevtimeReqButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.OrevtimeReqButton.Location=new System.Drawing.Point(267, 64);
			this.OrevtimeReqButton.Name="OrevtimeReqButton";
			this.OrevtimeReqButton.Size=new System.Drawing.Size(25, 25);
			this.OrevtimeReqButton.TabIndex=179;
			this.OrevtimeReqButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.OrevtimeReqButton.UseVisualStyleBackColor=true;
			//
			//Label40
			//
			this.Label40.AutoSize=true;
			this.Label40.Location=new System.Drawing.Point(341, 68);
			this.Label40.Name="Label40";
			this.Label40.Size=new System.Drawing.Size(149, 16);
			this.Label40.TabIndex=174;
			this.Label40.Text="تعداد درخواست اضافه کار:";
			//
			//FullBox
			//
			this.FullBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.FullBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FullBox.Location=new System.Drawing.Point(796, 31);
			this.FullBox.MaxLength=5;
			this.FullBox.Name="FullBox";
			this.FullBox.ReadOnly=true;
			this.FullBox.Size=new System.Drawing.Size(50, 23);
			this.FullBox.TabIndex=162;
			this.FullBox.Text="00:00";
			this.FullBox.TextAlign=HorizontalAlignment.Center;
			//
			//FullButton
			//
			this.FullButton.Image=(System.Drawing.Image) (resources.GetObject("FullButton.BackgroundImage"));
			this.FullButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.FullButton.Cursor=Cursors.Hand;
			this.FullButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.FullButton.Location=new System.Drawing.Point(770, 30);
			this.FullButton.Name="FullButton";
			this.FullButton.Size=new System.Drawing.Size(25, 25);
			this.FullButton.TabIndex=170;
			this.FullButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.FullButton.UseVisualStyleBackColor=true;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(845, 34);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(103, 16);
			this.Label3.TabIndex=164;
			this.Label3.Text="مجموع اضافه کار:";
			//
			//ClassBox
			//
			this.ClassBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ClassBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ClassBox.Location=new System.Drawing.Point(542, 65);
			this.ClassBox.MaxLength=5;
			this.ClassBox.Name="ClassBox";
			this.ClassBox.ReadOnly=true;
			this.ClassBox.Size=new System.Drawing.Size(50, 23);
			this.ClassBox.TabIndex=147;
			this.ClassBox.Text="00:00";
			this.ClassBox.TextAlign=HorizontalAlignment.Center;
			//
			//FridayBox
			//
			this.FridayBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.FridayBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FridayBox.Location=new System.Drawing.Point(796, 65);
			this.FridayBox.MaxLength=5;
			this.FridayBox.Name="FridayBox";
			this.FridayBox.ReadOnly=true;
			this.FridayBox.Size=new System.Drawing.Size(50, 23);
			this.FridayBox.TabIndex=145;
			this.FridayBox.Text="00:00";
			this.FridayBox.TextAlign=HorizontalAlignment.Center;
			//
			//KeshikBox
			//
			this.KeshikBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.KeshikBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KeshikBox.Location=new System.Drawing.Point(542, 31);
			this.KeshikBox.MaxLength=5;
			this.KeshikBox.Name="KeshikBox";
			this.KeshikBox.ReadOnly=true;
			this.KeshikBox.Size=new System.Drawing.Size(50, 23);
			this.KeshikBox.TabIndex=141;
			this.KeshikBox.Text="00:00";
			this.KeshikBox.TextAlign=HorizontalAlignment.Center;
			//
			//TashvighBox
			//
			this.TashvighBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.TashvighBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TashvighBox.Location=new System.Drawing.Point(796, 99);
			this.TashvighBox.MaxLength=5;
			this.TashvighBox.Name="TashvighBox";
			this.TashvighBox.ReadOnly=true;
			this.TashvighBox.Size=new System.Drawing.Size(50, 23);
			this.TashvighBox.TabIndex=119;
			this.TashvighBox.Text="00:00";
			this.TashvighBox.TextAlign=HorizontalAlignment.Center;
			//
			//TimeLeavButton
			//
			this.TimeLeavButton.Image=(System.Drawing.Image) (resources.GetObject("TimeLeavButton.BackgroundImage"));
			this.TimeLeavButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.TimeLeavButton.Cursor=Cursors.Hand;
			this.TimeLeavButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.TimeLeavButton.Location=new System.Drawing.Point(30, 64);
			this.TimeLeavButton.Name="TimeLeavButton";
			this.TimeLeavButton.Size=new System.Drawing.Size(25, 25);
			this.TimeLeavButton.TabIndex=152;
			this.TimeLeavButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.TimeLeavButton.UseVisualStyleBackColor=true;
			//
			//TashvighButton
			//
			this.TashvighButton.Image=(System.Drawing.Image) (resources.GetObject("TashvighButton.BackgroundImage"));
			this.TashvighButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.TashvighButton.Cursor=Cursors.Hand;
			this.TashvighButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.TashvighButton.Location=new System.Drawing.Point(770, 98);
			this.TashvighButton.Name="TashvighButton";
			this.TashvighButton.Size=new System.Drawing.Size(25, 25);
			this.TashvighButton.TabIndex=160;
			this.TashvighButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.TashvighButton.UseVisualStyleBackColor=true;
			//
			//Label21
			//
			this.Label21.AutoSize=true;
			this.Label21.Location=new System.Drawing.Point(105, 68);
			this.Label21.Name="Label21";
			this.Label21.Size=new System.Drawing.Size(104, 16);
			this.Label21.TabIndex=140;
			this.Label21.Text="مرخصی ساعتی:";
			//
			//KeshikButton
			//
			this.KeshikButton.Image=(System.Drawing.Image) (resources.GetObject("KeshikButton.BackgroundImage"));
			this.KeshikButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.KeshikButton.Cursor=Cursors.Hand;
			this.KeshikButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.KeshikButton.Location=new System.Drawing.Point(516, 30);
			this.KeshikButton.Name="KeshikButton";
			this.KeshikButton.Size=new System.Drawing.Size(25, 25);
			this.KeshikButton.TabIndex=159;
			this.KeshikButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.KeshikButton.UseVisualStyleBackColor=true;
			//
			//MorSaatBox
			//
			this.MorSaatBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.MorSaatBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MorSaatBox.Location=new System.Drawing.Point(55, 65);
			this.MorSaatBox.MaxLength=50;
			this.MorSaatBox.Name="MorSaatBox";
			this.MorSaatBox.ReadOnly=true;
			this.MorSaatBox.Size=new System.Drawing.Size(50, 23);
			this.MorSaatBox.TabIndex=142;
			this.MorSaatBox.Text="00:00";
			this.MorSaatBox.TextAlign=HorizontalAlignment.Center;
			//
			//OverTimeButton
			//
			this.OverTimeButton.Image=(System.Drawing.Image) (resources.GetObject("OverTimeButton.BackgroundImage"));
			this.OverTimeButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.OverTimeButton.Cursor=Cursors.Hand;
			this.OverTimeButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.OverTimeButton.Location=new System.Drawing.Point(516, 98);
			this.OverTimeButton.Name="OverTimeButton";
			this.OverTimeButton.Size=new System.Drawing.Size(25, 25);
			this.OverTimeButton.TabIndex=158;
			this.OverTimeButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.OverTimeButton.UseVisualStyleBackColor=true;
			//
			//FridayButton
			//
			this.FridayButton.Image=(System.Drawing.Image) (resources.GetObject("FridayButton.BackgroundImage"));
			this.FridayButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.FridayButton.Cursor=Cursors.Hand;
			this.FridayButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.FridayButton.Location=new System.Drawing.Point(770, 64);
			this.FridayButton.Name="FridayButton";
			this.FridayButton.Size=new System.Drawing.Size(25, 25);
			this.FridayButton.TabIndex=157;
			this.FridayButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.FridayButton.UseVisualStyleBackColor=true;
			//
			//ClassButton
			//
			this.ClassButton.Image=(System.Drawing.Image) (resources.GetObject("ClassButton.BackgroundImage"));
			this.ClassButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ClassButton.Cursor=Cursors.Hand;
			this.ClassButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.ClassButton.Location=new System.Drawing.Point(516, 64);
			this.ClassButton.Name="ClassButton";
			this.ClassButton.Size=new System.Drawing.Size(25, 25);
			this.ClassButton.TabIndex=156;
			this.ClassButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.ClassButton.UseVisualStyleBackColor=true;
			//
			//DalyLeavButton
			//
			this.DalyLeavButton.Image=(System.Drawing.Image) (resources.GetObject("DalyLeavButton.BackgroundImage"));
			this.DalyLeavButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.DalyLeavButton.Cursor=Cursors.Hand;
			this.DalyLeavButton.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.DalyLeavButton.Location=new System.Drawing.Point(30, 30);
			this.DalyLeavButton.Name="DalyLeavButton";
			this.DalyLeavButton.Size=new System.Drawing.Size(25, 25);
			this.DalyLeavButton.TabIndex=153;
			this.DalyLeavButton.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.DalyLeavButton.UseVisualStyleBackColor=true;
			//
			//OverTimeBox
			//
			this.OverTimeBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.OverTimeBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.OverTimeBox.Location=new System.Drawing.Point(542, 99);
			this.OverTimeBox.MaxLength=5;
			this.OverTimeBox.Name="OverTimeBox";
			this.OverTimeBox.ReadOnly=true;
			this.OverTimeBox.Size=new System.Drawing.Size(50, 23);
			this.OverTimeBox.TabIndex=146;
			this.OverTimeBox.Text="00:00";
			this.OverTimeBox.TextAlign=HorizontalAlignment.Center;
			//
			//MorDayBox
			//
			this.MorDayBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.MorDayBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MorDayBox.Location=new System.Drawing.Point(55, 31);
			this.MorDayBox.MaxLength=50;
			this.MorDayBox.Name="MorDayBox";
			this.MorDayBox.ReadOnly=true;
			this.MorDayBox.Size=new System.Drawing.Size(50, 23);
			this.MorDayBox.TabIndex=143;
			this.MorDayBox.Text="0";
			this.MorDayBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label16
			//
			this.Label16.AutoSize=true;
			this.Label16.Location=new System.Drawing.Point(845, 102);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(113, 16);
			this.Label16.TabIndex=137;
			this.Label16.Text="اضافه کار تشویقی:";
			//
			//Label20
			//
			this.Label20.AutoSize=true;
			this.Label20.Location=new System.Drawing.Point(845, 68);
			this.Label20.Name="Label20";
			this.Label20.Size=new System.Drawing.Size(95, 16);
			this.Label20.TabIndex=134;
			this.Label20.Text="اضافه کار جمعه:";
			//
			//Label23
			//
			this.Label23.AutoSize=true;
			this.Label23.Location=new System.Drawing.Point(591, 102);
			this.Label23.Name="Label23";
			this.Label23.Size=new System.Drawing.Size(101, 16);
			this.Label23.TabIndex=139;
			this.Label23.Text="اضافه کار متفرقه:";
			//
			//Label31
			//
			this.Label31.AutoSize=true;
			this.Label31.Location=new System.Drawing.Point(105, 34);
			this.Label31.Name="Label31";
			this.Label31.Size=new System.Drawing.Size(90, 16);
			this.Label31.TabIndex=125;
			this.Label31.Text="مرخصی روزانه:";
			//
			//Label34
			//
			this.Label34.AutoSize=true;
			this.Label34.Location=new System.Drawing.Point(591, 68);
			this.Label34.Name="Label34";
			this.Label34.Size=new System.Drawing.Size(96, 16);
			this.Label34.TabIndex=136;
			this.Label34.Text="اضافه کار کلاس:";
			//
			//Label35
			//
			this.Label35.AutoSize=true;
			this.Label35.Location=new System.Drawing.Point(591, 34);
			this.Label35.Name="Label35";
			this.Label35.Size=new System.Drawing.Size(103, 16);
			this.Label35.TabIndex=135;
			this.Label35.Text="اضافه کار کشیک:";
			//
			//Label36
			//
			this.Label36.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Label36.BorderStyle=BorderStyle.FixedSingle;
			this.Label36.Cursor=Cursors.Default;
			this.Label36.Location=new System.Drawing.Point(863, 412);
			this.Label36.Name="Label36";
			this.Label36.Size=new System.Drawing.Size(122, 22);
			this.Label36.TabIndex=48;
			this.Label36.Text="گزارش جزئیات";
			this.Label36.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Button2
			//
			this.Button2.BackColor=System.Drawing.Color.Transparent;
			this.Button2.Image=(System.Drawing.Image) (resources.GetObject("Button2.BackgroundImage"));
			this.Button2.BackgroundImageLayout=ImageLayout.Stretch;
			this.Button2.Cursor=Cursors.Hand;
			this.Button2.Enabled=false;
			this.Button2.FlatStyle=FlatStyle.Flat;
			this.Button2.ForeColor=System.Drawing.Color.White;
			this.Button2.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
			this.Button2.Location=new System.Drawing.Point(124, 419);
			this.Button2.Name="Button2";
			this.Button2.Size=new System.Drawing.Size(18, 18);
			this.Button2.TabIndex=156;
			this.Button2.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			this.Button2.UseVisualStyleBackColor=false;
			//
			//Label25
			//
			this.Label25.BackColor=System.Drawing.Color.Black;
			this.Label25.BorderStyle=BorderStyle.FixedSingle;
			this.Label25.Cursor=Cursors.Default;
			this.Label25.ForeColor=System.Drawing.Color.White;
			this.Label25.Location=new System.Drawing.Point(30, 416);
			this.Label25.Name="Label25";
			this.Label25.Size=new System.Drawing.Size(322, 22);
			this.Label25.TabIndex=157;
			this.Label25.Text="برای دیدن جزئیات بر روی علامت         کلیک کنید";
			this.Label25.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Label42
			//
			this.Label42.BackColor=System.Drawing.Color.Black;
			this.Label42.BorderStyle=BorderStyle.FixedSingle;
			this.Label42.Cursor=Cursors.Default;
			this.Label42.Location=new System.Drawing.Point(869, 91);
			this.Label42.Name="Label42";
			this.Label42.Size=new System.Drawing.Size(122, 22);
			this.Label42.TabIndex=161;
			this.Label42.Text="مشخصات";
			this.Label42.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Label43
			//
			this.Label43.BackColor=System.Drawing.Color.Black;
			this.Label43.BorderStyle=BorderStyle.FixedSingle;
			this.Label43.Cursor=Cursors.Default;
			this.Label43.Location=new System.Drawing.Point(869, 418);
			this.Label43.Name="Label43";
			this.Label43.Size=new System.Drawing.Size(122, 22);
			this.Label43.TabIndex=162;
			this.Label43.Text="گزارش جزئیات";
			this.Label43.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.LightSteelBlue;
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.AddressBox);
			this.Panel4.Controls.Add(this.Label46);
			this.Panel4.Controls.Add(this.SubjectBox);
			this.Panel4.Controls.Add(this.DegreeBox);
			this.Panel4.Controls.Add(this.HitBox);
			this.Panel4.Controls.Add(this.CoatBox);
			this.Panel4.Controls.Add(this.ShirtBox);
			this.Panel4.Controls.Add(this.OverBox);
			this.Panel4.Controls.Add(this.PantBox);
			this.Panel4.Controls.Add(this.ShoeBox);
			this.Panel4.Controls.Add(this.Label53);
			this.Panel4.Controls.Add(this.Label54);
			this.Panel4.Controls.Add(this.Label45);
			this.Panel4.Controls.Add(this.Label55);
			this.Panel4.Controls.Add(this.Label57);
			this.Panel4.Controls.Add(this.Label58);
			this.Panel4.Controls.Add(this.Label44);
			this.Panel4.Controls.Add(this.Label61);
			this.Panel4.ForeColor=System.Drawing.Color.Black;
			this.Panel4.Location=new System.Drawing.Point(12, 300);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(988, 100);
			this.Panel4.TabIndex=1;
			//
			//HitBox
			//
			this.HitBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.HitBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.HitBox.ForeColor=System.Drawing.Color.Black;
			this.HitBox.Location=new System.Drawing.Point(29, 23);
			this.HitBox.Name="HitBox";
			this.HitBox.ReadOnly=true;
			this.HitBox.Size=new System.Drawing.Size(39, 23);
			this.HitBox.TabIndex=154;
			this.HitBox.TabStop=false;
			this.HitBox.TextAlign=HorizontalAlignment.Center;
			//
			//CoatBox
			//
			this.CoatBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.CoatBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CoatBox.ForeColor=System.Drawing.Color.Black;
			this.CoatBox.Location=new System.Drawing.Point(502, 23);
			this.CoatBox.Name="CoatBox";
			this.CoatBox.ReadOnly=true;
			this.CoatBox.Size=new System.Drawing.Size(39, 23);
			this.CoatBox.TabIndex=152;
			this.CoatBox.TabStop=false;
			this.CoatBox.TextAlign=HorizontalAlignment.Center;
			//
			//ShirtBox
			//
			this.ShirtBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.ShirtBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ShirtBox.ForeColor=System.Drawing.Color.Black;
			this.ShirtBox.Location=new System.Drawing.Point(266, 23);
			this.ShirtBox.Name="ShirtBox";
			this.ShirtBox.ReadOnly=true;
			this.ShirtBox.Size=new System.Drawing.Size(39, 23);
			this.ShirtBox.TabIndex=150;
			this.ShirtBox.TabStop=false;
			this.ShirtBox.TextAlign=HorizontalAlignment.Center;
			//
			//OverBox
			//
			this.OverBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.OverBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.OverBox.ForeColor=System.Drawing.Color.Black;
			this.OverBox.Location=new System.Drawing.Point(386, 23);
			this.OverBox.Name="OverBox";
			this.OverBox.ReadOnly=true;
			this.OverBox.Size=new System.Drawing.Size(39, 23);
			this.OverBox.TabIndex=145;
			this.OverBox.TabStop=false;
			this.OverBox.TextAlign=HorizontalAlignment.Center;
			//
			//PantBox
			//
			this.PantBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.PantBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.PantBox.ForeColor=System.Drawing.Color.Black;
			this.PantBox.Location=new System.Drawing.Point(149, 23);
			this.PantBox.Name="PantBox";
			this.PantBox.ReadOnly=true;
			this.PantBox.Size=new System.Drawing.Size(39, 23);
			this.PantBox.TabIndex=143;
			this.PantBox.TabStop=false;
			this.PantBox.TextAlign=HorizontalAlignment.Center;
			//
			//ShoeBox
			//
			this.ShoeBox.BackColor=System.Drawing.Color.LightSteelBlue;
			this.ShoeBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ShoeBox.ForeColor=System.Drawing.Color.Black;
			this.ShoeBox.Location=new System.Drawing.Point(609, 23);
			this.ShoeBox.Name="ShoeBox";
			this.ShoeBox.ReadOnly=true;
			this.ShoeBox.Size=new System.Drawing.Size(39, 23);
			this.ShoeBox.TabIndex=142;
			this.ShoeBox.TabStop=false;
			this.ShoeBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label53
			//
			this.Label53.AutoSize=true;
			this.Label53.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label53.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label53.Location=new System.Drawing.Point(69, 27);
			this.Label53.Name="Label53";
			this.Label53.Size=new System.Drawing.Size(43, 14);
			this.Label53.TabIndex=123;
			this.Label53.Text="گرمکن:";
			//
			//Label54
			//
			this.Label54.AutoSize=true;
			this.Label54.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label54.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label54.Location=new System.Drawing.Point(425, 27);
			this.Label54.Name="Label54";
			this.Label54.Size=new System.Drawing.Size(40, 14);
			this.Label54.TabIndex=140;
			this.Label54.Text="اورکت:";
			//
			//Label55
			//
			this.Label55.AutoSize=true;
			this.Label55.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label55.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label55.Location=new System.Drawing.Point(189, 27);
			this.Label55.Name="Label55";
			this.Label55.Size=new System.Drawing.Size(39, 14);
			this.Label55.TabIndex=139;
			this.Label55.Text="شلوار:";
			//
			//Label57
			//
			this.Label57.AutoSize=true;
			this.Label57.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label57.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label57.Location=new System.Drawing.Point(648, 27);
			this.Label57.Name="Label57";
			this.Label57.Size=new System.Drawing.Size(39, 14);
			this.Label57.TabIndex=135;
			this.Label57.Text="کفش:";
			//
			//Label58
			//
			this.Label58.AutoSize=true;
			this.Label58.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label58.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label58.Location=new System.Drawing.Point(305, 27);
			this.Label58.Name="Label58";
			this.Label58.Size=new System.Drawing.Size(43, 14);
			this.Label58.TabIndex=133;
			this.Label58.Text="پیراهن:";
			//
			//Label61
			//
			this.Label61.AutoSize=true;
			this.Label61.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label61.ForeColor=System.Drawing.Color.MediumBlue;
			this.Label61.Location=new System.Drawing.Point(542, 27);
			this.Label61.Name="Label61";
			this.Label61.Size=new System.Drawing.Size(28, 14);
			this.Label61.TabIndex=132;
			this.Label61.Text="کت:";
			//
			//Label66
			//
			this.Label66.BackColor=System.Drawing.Color.Black;
			this.Label66.BorderStyle=BorderStyle.FixedSingle;
			this.Label66.Cursor=Cursors.Default;
			this.Label66.Location=new System.Drawing.Point(869, 291);
			this.Label66.Name="Label66";
			this.Label66.Size=new System.Drawing.Size(122, 22);
			this.Label66.TabIndex=161;
			this.Label66.Text="مشخصات";
			this.Label66.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Label67
			//
			this.Label67.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Label67.BorderStyle=BorderStyle.FixedSingle;
			this.Label67.Cursor=Cursors.Default;
			this.Label67.Location=new System.Drawing.Point(863, 286);
			this.Label67.Name="Label67";
			this.Label67.Size=new System.Drawing.Size(122, 22);
			this.Label67.TabIndex=44;
			this.Label67.Text="اطلاعات تکمیلی";
			this.Label67.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//PersonalDetailReportForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightGray;
			this.ClientSize=new System.Drawing.Size(1012, 574);
			this.Controls.Add(this.Label36);
			this.Controls.Add(this.Label43);
			this.Controls.Add(this.Label67);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label66);
			this.Controls.Add(this.Label42);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label25);
			this.Controls.Add(this.Panel5);
			this.Controls.Add(this.Panel3);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="PersonalDetailReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="گزارش جزئیات پرسنل ";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private Panel Panel1;
		private Label Label1;
		private Label Label10;
		private Label Label17;
		private Label Label29;
		private Label Label18;
		private Label Label27;
		private Label Label24;
		private Label Label6;
		private Label Label8;
		private Label Label9;
		private Label Label11;
		private Label Label12;
		private Label Label13;
		private Label Label19;
		private Label Label14;
		private Panel Panel2;
		private PictureBox PictureBox1;
		private Panel Panel3;
		private TextBox PersonBox;
		private Button ShowButton;
		private Button PersonalButton;
		private Label Label15;
		private Panel Panel5;
		private TextBox ClassBox;
		private TextBox OverTimeBox;
		private TextBox FridayBox;
		private TextBox MorDayBox;
		private TextBox MorSaatBox;
		private TextBox KeshikBox;
		private Label Label16;
		private Label Label20;
		private Label Label21;
		private Label Label23;
		private TextBox TashvighBox;
		private Label Label31;
		private Label Label34;
		private Label Label35;
		private Label Label36;
		private Button TashvighButton;
		private Button KeshikButton;
		private Button OverTimeButton;
		private Button FridayButton;
		private Button ClassButton;
		private Button DalyLeavButton;
		private Button TimeLeavButton;
		private TextBox ChangeDateBox;
		private TextBox PhonBox;
		private TextBox LicensNumBox;
		private TextBox ShiftBox;
		private TextBox TimeBox;
		private TextBox LocalBox;
		private TextBox LineBox;
		private TextBox PNumBox;
		private TextBox FamilyBox;
		private TextBox NameBox;
		private TextBox BirthdayBox;
		private TextBox NatIDBox;
		private TextBox EmployDayBox;
		private TextBox PostBox;
		private Button Button2;
		private Label Label25;
		private TextBox FullBox;
		private Button FullButton;
		private Label Label3;
		private Button ReservButton;
		private Label Label37;
		private Button OrevtimeReqButton;
		private Label Label40;
		private TextBox OrevtimeReqBox;
		private TextBox ReservBox;
		private Label Label43;
		private Label Label42;
		private TextBox SubjectBox;
		private TextBox DegreeBox;
		private Label Label45;
		private Label Label44;
		private TextBox AddressBox;
		private Label Label46;
		private TextBox UnitBox;
		private Label Label47;
		private TextBox LicensDateBox;
		private Label Label48;
		private Panel Panel4;
		private TextBox HitBox;
		private TextBox CoatBox;
		private TextBox ShirtBox;
		private TextBox OverBox;
		private TextBox PantBox;
		private TextBox ShoeBox;
		private Label Label53;
		private Label Label54;
		private Label Label55;
		private Label Label57;
		private Label Label58;
		private Label Label61;
		private Label Label66;
		private Label Label67;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private Label Label2;
		private Label Label4;
	}
	
}
