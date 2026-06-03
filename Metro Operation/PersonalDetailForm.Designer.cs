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
		public partial class PersonalDetailForm : BaseForm
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
            this.TabPage1=new System.Windows.Forms.TabPage();
            this.DetailAddressPanel=new System.Windows.Forms.Panel();
            this.ComboBox6=new System.Windows.Forms.ComboBox();
            this.Label36=new System.Windows.Forms.Label();
            this.Label35=new System.Windows.Forms.Label();
            this.Label34=new System.Windows.Forms.Label();
            this.Label33=new System.Windows.Forms.Label();
            this.Label32=new System.Windows.Forms.Label();
            this.Label22=new System.Windows.Forms.Label();
            this.ComboBox4=new System.Windows.Forms.ComboBox();
            this.ComboBox2=new System.Windows.Forms.ComboBox();
            this.ComboBox5=new System.Windows.Forms.ComboBox();
            this.ComboBox3=new System.Windows.Forms.ComboBox();
            this.ComboBox1=new System.Windows.Forms.ComboBox();
            this.AddressBox6=new System.Windows.Forms.TextBox();
            this.AddressBox5=new System.Windows.Forms.TextBox();
            this.AddressBox2=new System.Windows.Forms.TextBox();
            this.AddressBox4=new System.Windows.Forms.TextBox();
            this.Label43=new System.Windows.Forms.Label();
            this.AddressBox1=new System.Windows.Forms.TextBox();
            this.AddressBox3=new System.Windows.Forms.TextBox();
            this.AddressRegButton=new System.Windows.Forms.Button();
            this.Label23=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.AddressEditButton=new System.Windows.Forms.Button();
            this.PhoneBox=new System.Windows.Forms.TextBox();
            this.AddressBox=new System.Windows.Forms.TextBox();
            this.CityCombo=new System.Windows.Forms.ComboBox();
            this.StateCombo=new System.Windows.Forms.ComboBox();
            this.TownCombo=new System.Windows.Forms.ComboBox();
            this.Label1=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.Label3=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Panel6=new System.Windows.Forms.Panel();
            this.Label29=new System.Windows.Forms.Label();
            this.Label31=new System.Windows.Forms.Label();
            this.Panel5=new System.Windows.Forms.Panel();
            this.PicButton=new System.Windows.Forms.Button();
            this.PictureBox1=new System.Windows.Forms.PictureBox();
            this.Label30=new System.Windows.Forms.Label();
            this.Label21=new System.Windows.Forms.Label();
            this.Panel2=new System.Windows.Forms.Panel();
            this.ShirtCombo=new System.Windows.Forms.ComboBox();
            this.PantCombo=new System.Windows.Forms.ComboBox();
            this.CoatCombo=new System.Windows.Forms.ComboBox();
            this.ShoeCombo=new System.Windows.Forms.ComboBox();
            this.HitCombo=new System.Windows.Forms.ComboBox();
            this.OverCombo=new System.Windows.Forms.ComboBox();
            this.Label10=new System.Windows.Forms.Label();
            this.Label16=new System.Windows.Forms.Label();
            this.Label11=new System.Windows.Forms.Label();
            this.Label12=new System.Windows.Forms.Label();
            this.Label13=new System.Windows.Forms.Label();
            this.Label14=new System.Windows.Forms.Label();
            this.Next0Button=new System.Windows.Forms.Button();
            this.Panel4=new System.Windows.Forms.Panel();
            this.ObjectCombo=new System.Windows.Forms.ComboBox();
            this.Label4=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.DegreeCombo=new System.Windows.Forms.ComboBox();
            this.TabControl1=new System.Windows.Forms.TabControl();
            this.TabPage3=new System.Windows.Forms.TabPage();
            this.Prev2Button=new System.Windows.Forms.Button();
            this.RegButton=new System.Windows.Forms.Button();
            this.Panel3=new System.Windows.Forms.Panel();
            this.PictureBox2=new System.Windows.Forms.PictureBox();
            this.Label8=new System.Windows.Forms.Label();
            this.Label9=new System.Windows.Forms.Label();
            this.Label20=new System.Windows.Forms.Label();
            this.PantLabel=new System.Windows.Forms.Label();
            this.PhoneLabel=new System.Windows.Forms.Label();
            this.StateLabel=new System.Windows.Forms.Label();
            this.HitLabel=new System.Windows.Forms.Label();
            this.CoatLabel=new System.Windows.Forms.Label();
            this.OverLabel=new System.Windows.Forms.Label();
            this.Label26=new System.Windows.Forms.Label();
            this.Label15=new System.Windows.Forms.Label();
            this.DegreeLabel=new System.Windows.Forms.Label();
            this.Label27=new System.Windows.Forms.Label();
            this.CityLabel=new System.Windows.Forms.Label();
            this.Label28=new System.Windows.Forms.Label();
            this.ShirtLabel=new System.Windows.Forms.Label();
            this.ObjectLabel=new System.Windows.Forms.Label();
            this.Label18=new System.Windows.Forms.Label();
            this.TownLabel=new System.Windows.Forms.Label();
            this.ShoeLabel=new System.Windows.Forms.Label();
            this.Label19=new System.Windows.Forms.Label();
            this.Label24=new System.Windows.Forms.Label();
            this.AddressLabel=new System.Windows.Forms.Label();
            this.Label17=new System.Windows.Forms.Label();
            this.Label25=new System.Windows.Forms.Label();
            this.TabPage1.SuspendLayout();
            this.DetailAddressPanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor=System.Drawing.Color.LightBlue;
            this.TabPage1.Controls.Add(this.DetailAddressPanel);
            this.TabPage1.Controls.Add(this.Label23);
            this.TabPage1.Controls.Add(this.Panel1);
            this.TabPage1.Controls.Add(this.Panel6);
            this.TabPage1.Controls.Add(this.Panel5);
            this.TabPage1.Controls.Add(this.Label30);
            this.TabPage1.Controls.Add(this.Label21);
            this.TabPage1.Controls.Add(this.Panel2);
            this.TabPage1.Controls.Add(this.Next0Button);
            this.TabPage1.Controls.Add(this.Panel4);
            this.TabPage1.Location=new System.Drawing.Point(4, 14);
            this.TabPage1.Name="TabPage1";
            this.TabPage1.Size=new System.Drawing.Size(768, 418);
            this.TabPage1.TabIndex=0;
            // 
            // DetailAddressPanel
            // 
            this.DetailAddressPanel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailAddressPanel.Controls.Add(this.ComboBox6);
            this.DetailAddressPanel.Controls.Add(this.Label36);
            this.DetailAddressPanel.Controls.Add(this.Label35);
            this.DetailAddressPanel.Controls.Add(this.Label34);
            this.DetailAddressPanel.Controls.Add(this.Label33);
            this.DetailAddressPanel.Controls.Add(this.Label32);
            this.DetailAddressPanel.Controls.Add(this.Label22);
            this.DetailAddressPanel.Controls.Add(this.ComboBox4);
            this.DetailAddressPanel.Controls.Add(this.ComboBox2);
            this.DetailAddressPanel.Controls.Add(this.ComboBox5);
            this.DetailAddressPanel.Controls.Add(this.ComboBox3);
            this.DetailAddressPanel.Controls.Add(this.ComboBox1);
            this.DetailAddressPanel.Controls.Add(this.AddressBox6);
            this.DetailAddressPanel.Controls.Add(this.AddressBox5);
            this.DetailAddressPanel.Controls.Add(this.AddressBox2);
            this.DetailAddressPanel.Controls.Add(this.AddressBox4);
            this.DetailAddressPanel.Controls.Add(this.Label43);
            this.DetailAddressPanel.Controls.Add(this.AddressBox1);
            this.DetailAddressPanel.Controls.Add(this.AddressBox3);
            this.DetailAddressPanel.Controls.Add(this.AddressRegButton);
            this.DetailAddressPanel.Location=new System.Drawing.Point(220, 162);
            this.DetailAddressPanel.Name="DetailAddressPanel";
            this.DetailAddressPanel.Size=new System.Drawing.Size(537, 250);
            this.DetailAddressPanel.TabIndex=4;
            this.DetailAddressPanel.Visible=false;
            // 
            // ComboBox6
            // 
            this.ComboBox6.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox6.Enabled=false;
            this.ComboBox6.FormattingEnabled=true;
            this.ComboBox6.Items.AddRange(new object[] {
            "...",
            "شهرک",
            "بلوار",
            "خیابان",
            "کوچه",
            "ساختمان",
            "پلاک",
            "طبقه",
            "واحد"});
            this.ComboBox6.Location=new System.Drawing.Point(428, 196);
            this.ComboBox6.Name="ComboBox6";
            this.ComboBox6.Size=new System.Drawing.Size(83, 24);
            this.ComboBox6.TabIndex=10;
            this.ComboBox6.SelectedIndexChanged += new System.EventHandler(this.ComboBox6_SelectedIndexChanged);
            // 
            // Label36
            // 
            this.Label36.AutoSize=true;
            this.Label36.Location=new System.Drawing.Point(512, 199);
            this.Label36.Name="Label36";
            this.Label36.Size=new System.Drawing.Size(20, 16);
            this.Label36.TabIndex=0;
            this.Label36.Text="6)";
            // 
            // Label35
            // 
            this.Label35.AutoSize=true;
            this.Label35.Location=new System.Drawing.Point(512, 164);
            this.Label35.Name="Label35";
            this.Label35.Size=new System.Drawing.Size(20, 16);
            this.Label35.TabIndex=0;
            this.Label35.Text="5)";
            // 
            // Label34
            // 
            this.Label34.AutoSize=true;
            this.Label34.Location=new System.Drawing.Point(512, 130);
            this.Label34.Name="Label34";
            this.Label34.Size=new System.Drawing.Size(20, 16);
            this.Label34.TabIndex=0;
            this.Label34.Text="4)";
            // 
            // Label33
            // 
            this.Label33.AutoSize=true;
            this.Label33.Location=new System.Drawing.Point(512, 95);
            this.Label33.Name="Label33";
            this.Label33.Size=new System.Drawing.Size(20, 16);
            this.Label33.TabIndex=0;
            this.Label33.Text="3)";
            // 
            // Label32
            // 
            this.Label32.AutoSize=true;
            this.Label32.Location=new System.Drawing.Point(512, 60);
            this.Label32.Name="Label32";
            this.Label32.Size=new System.Drawing.Size(20, 16);
            this.Label32.TabIndex=0;
            this.Label32.Text="2)";
            // 
            // Label22
            // 
            this.Label22.AutoSize=true;
            this.Label22.Location=new System.Drawing.Point(512, 25);
            this.Label22.Name="Label22";
            this.Label22.Size=new System.Drawing.Size(20, 16);
            this.Label22.TabIndex=0;
            this.Label22.Text="1)";
            // 
            // ComboBox4
            // 
            this.ComboBox4.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox4.Enabled=false;
            this.ComboBox4.FormattingEnabled=true;
            this.ComboBox4.Items.AddRange(new object[] {
            "...",
            "شهرک",
            "بلوار",
            "خیابان",
            "کوچه",
            "ساختمان",
            "پلاک",
            "طبقه",
            "واحد"});
            this.ComboBox4.Location=new System.Drawing.Point(428, 126);
            this.ComboBox4.Name="ComboBox4";
            this.ComboBox4.Size=new System.Drawing.Size(83, 24);
            this.ComboBox4.TabIndex=6;
            this.ComboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.Enabled=false;
            this.ComboBox2.FormattingEnabled=true;
            this.ComboBox2.Items.AddRange(new object[] {
            "...",
            "شهرک",
            "بلوار",
            "خیابان",
            "کوچه",
            "ساختمان",
            "پلاک",
            "طبقه",
            "واحد"});
            this.ComboBox2.Location=new System.Drawing.Point(428, 56);
            this.ComboBox2.Name="ComboBox2";
            this.ComboBox2.Size=new System.Drawing.Size(83, 24);
            this.ComboBox2.TabIndex=2;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // ComboBox5
            // 
            this.ComboBox5.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox5.Enabled=false;
            this.ComboBox5.FormattingEnabled=true;
            this.ComboBox5.Items.AddRange(new object[] {
            "...",
            "شهرک",
            "بلوار",
            "خیابان",
            "کوچه",
            "ساختمان",
            "پلاک",
            "طبقه",
            "واحد"});
            this.ComboBox5.Location=new System.Drawing.Point(428, 161);
            this.ComboBox5.Name="ComboBox5";
            this.ComboBox5.Size=new System.Drawing.Size(83, 24);
            this.ComboBox5.TabIndex=8;
            this.ComboBox5.SelectedIndexChanged += new System.EventHandler(this.ComboBox5_SelectedIndexChanged);
            // 
            // ComboBox3
            // 
            this.ComboBox3.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox3.Enabled=false;
            this.ComboBox3.FormattingEnabled=true;
            this.ComboBox3.Items.AddRange(new object[] {
            "...",
            "شهرک",
            "بلوار",
            "خیابان",
            "کوچه",
            "ساختمان",
            "پلاک",
            "طبقه",
            "واحد"});
            this.ComboBox3.Location=new System.Drawing.Point(428, 91);
            this.ComboBox3.Name="ComboBox3";
            this.ComboBox3.Size=new System.Drawing.Size(83, 24);
            this.ComboBox3.TabIndex=4;
            this.ComboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled=true;
            this.ComboBox1.Items.AddRange(new object[] {
            "شهرک",
            "بلوار",
            "خیابان",
            "کوچه",
            "ساختمان",
            "پلاک",
            "طبقه",
            "واحد"});
            this.ComboBox1.Location=new System.Drawing.Point(428, 21);
            this.ComboBox1.Name="ComboBox1";
            this.ComboBox1.Size=new System.Drawing.Size(83, 24);
            this.ComboBox1.TabIndex=0;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // AddressBox6
            // 
            this.AddressBox6.Enabled=false;
            this.AddressBox6.Location=new System.Drawing.Point(261, 197);
            this.AddressBox6.MaxLength=20;
            this.AddressBox6.Name="AddressBox6";
            this.AddressBox6.Size=new System.Drawing.Size(164, 23);
            this.AddressBox6.TabIndex=11;
            // 
            // AddressBox5
            // 
            this.AddressBox5.Enabled=false;
            this.AddressBox5.Location=new System.Drawing.Point(261, 162);
            this.AddressBox5.MaxLength=20;
            this.AddressBox5.Name="AddressBox5";
            this.AddressBox5.Size=new System.Drawing.Size(164, 23);
            this.AddressBox5.TabIndex=9;
            // 
            // AddressBox2
            // 
            this.AddressBox2.Enabled=false;
            this.AddressBox2.Location=new System.Drawing.Point(261, 57);
            this.AddressBox2.MaxLength=20;
            this.AddressBox2.Name="AddressBox2";
            this.AddressBox2.Size=new System.Drawing.Size(164, 23);
            this.AddressBox2.TabIndex=3;
            // 
            // AddressBox4
            // 
            this.AddressBox4.Enabled=false;
            this.AddressBox4.Location=new System.Drawing.Point(261, 127);
            this.AddressBox4.MaxLength=20;
            this.AddressBox4.Name="AddressBox4";
            this.AddressBox4.Size=new System.Drawing.Size(164, 23);
            this.AddressBox4.TabIndex=7;
            // 
            // Label43
            // 
            this.Label43.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label43.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label43.Location=new System.Drawing.Point(3, 23);
            this.Label43.Name="Label43";
            this.Label43.Size=new System.Drawing.Size(256, 96);
            this.Label43.TabIndex=28;
            this.Label43.Text="* تکمیل حداقل سه عنوان الزامی است \r\n* نام ساختمان یا پلاک الزامی است";
            this.Label43.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressBox1
            // 
            this.AddressBox1.Enabled=false;
            this.AddressBox1.Location=new System.Drawing.Point(261, 22);
            this.AddressBox1.MaxLength=20;
            this.AddressBox1.Name="AddressBox1";
            this.AddressBox1.Size=new System.Drawing.Size(164, 23);
            this.AddressBox1.TabIndex=1;
            // 
            // AddressBox3
            // 
            this.AddressBox3.Enabled=false;
            this.AddressBox3.Location=new System.Drawing.Point(261, 92);
            this.AddressBox3.MaxLength=20;
            this.AddressBox3.Name="AddressBox3";
            this.AddressBox3.Size=new System.Drawing.Size(164, 23);
            this.AddressBox3.TabIndex=5;
            // 
            // AddressRegButton
            // 
            this.AddressRegButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddressRegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.AddressRegButton.Location=new System.Drawing.Point(37, 158);
            this.AddressRegButton.Name="AddressRegButton";
            this.AddressRegButton.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddressRegButton.Size=new System.Drawing.Size(100, 32);
            this.AddressRegButton.TabIndex=12;
            this.AddressRegButton.Text="ذخیره";
            this.AddressRegButton.UseVisualStyleBackColor=false;
            this.AddressRegButton.Click += new System.EventHandler(this.AddressRegButton_Click);
            // 
            // Label23
            // 
            this.Label23.BackColor=System.Drawing.Color.Gray;
            this.Label23.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label23.Cursor=System.Windows.Forms.Cursors.Default;
            this.Label23.ForeColor=System.Drawing.Color.White;
            this.Label23.Location=new System.Drawing.Point(652, 15);
            this.Label23.Name="Label23";
            this.Label23.Size=new System.Drawing.Size(100, 22);
            this.Label23.TabIndex=162;
            this.Label23.Text="محل سکونت";
            this.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.AddressEditButton);
            this.Panel1.Controls.Add(this.PhoneBox);
            this.Panel1.Controls.Add(this.AddressBox);
            this.Panel1.Controls.Add(this.CityCombo);
            this.Panel1.Controls.Add(this.StateCombo);
            this.Panel1.Controls.Add(this.TownCombo);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Location=new System.Drawing.Point(220, 27);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(537, 130);
            this.Panel1.TabIndex=0;
            // 
            // AddressEditButton
            // 
            this.AddressEditButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddressEditButton.BackgroundImageLayout=System.Windows.Forms.ImageLayout.Center;
            this.AddressEditButton.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            this.AddressEditButton.Image=global::Metro_Operation.Properties.Resources.edit_16;
            this.AddressEditButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressEditButton.Location=new System.Drawing.Point(12, 93);
            this.AddressEditButton.Name="AddressEditButton";
            this.AddressEditButton.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddressEditButton.Size=new System.Drawing.Size(22, 22);
            this.AddressEditButton.TabIndex=4;
            this.AddressEditButton.UseVisualStyleBackColor=false;
            this.AddressEditButton.Click += new System.EventHandler(this.AddressEditButton_Click);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location=new System.Drawing.Point(12, 56);
            this.PhoneBox.MaxLength=11;
            this.PhoneBox.Name="PhoneBox";
            this.PhoneBox.Size=new System.Drawing.Size(180, 23);
            this.PhoneBox.TabIndex=3;
            // 
            // AddressBox
            // 
            this.AddressBox.Location=new System.Drawing.Point(37, 93);
            this.AddressBox.MaxLength=240;
            this.AddressBox.Name="AddressBox";
            this.AddressBox.ReadOnly=true;
            this.AddressBox.Size=new System.Drawing.Size(443, 23);
            this.AddressBox.TabIndex=3;
            this.AddressBox.TabStop=false;
            // 
            // CityCombo
            // 
            this.CityCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CityCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CityCombo.Location=new System.Drawing.Point(12, 17);
            this.CityCombo.Margin=new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.CityCombo.MaxLength=10;
            this.CityCombo.Name="CityCombo";
            this.CityCombo.Size=new System.Drawing.Size(180, 24);
            this.CityCombo.Sorted=true;
            this.CityCombo.TabIndex=1;
            this.CityCombo.SelectedIndexChanged += new System.EventHandler(this.CityCombo_SelectedIndexChanged);
            // 
            // StateCombo
            // 
            this.StateCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StateCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StateCombo.Location=new System.Drawing.Point(316, 17);
            this.StateCombo.Margin=new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.StateCombo.MaxLength=10;
            this.StateCombo.Name="StateCombo";
            this.StateCombo.Size=new System.Drawing.Size(164, 24);
            this.StateCombo.Sorted=true;
            this.StateCombo.TabIndex=0;
            this.StateCombo.SelectedIndexChanged += new System.EventHandler(this.StateCombo_SelectedIndexChanged);
            // 
            // TownCombo
            // 
            this.TownCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TownCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TownCombo.Location=new System.Drawing.Point(316, 55);
            this.TownCombo.Margin=new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.TownCombo.MaxLength=15;
            this.TownCombo.Name="TownCombo";
            this.TownCombo.Size=new System.Drawing.Size(164, 24);
            this.TownCombo.Sorted=true;
            this.TownCombo.TabIndex=2;
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.LightBlue;
            this.Label1.Location=new System.Drawing.Point(479, 21);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(47, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="استان:";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(191, 59);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(47, 16);
            this.Label7.TabIndex=0;
            this.Label7.Text="موبایل:";
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(191, 21);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(38, 16);
            this.Label2.TabIndex=0;
            this.Label2.Text="شهر:";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(479, 59);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(41, 16);
            this.Label3.TabIndex=0;
            this.Label3.Text="محله:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(479, 96);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(43, 16);
            this.Label6.TabIndex=0;
            this.Label6.Text="آدرس:";
            // 
            // Panel6
            // 
            this.Panel6.BackColor=System.Drawing.Color.Transparent;
            this.Panel6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.Label29);
            this.Panel6.Controls.Add(this.Label31);
            this.Panel6.Location=new System.Drawing.Point(3, 21);
            this.Panel6.Name="Panel6";
            this.Panel6.Size=new System.Drawing.Size(213, 50);
            this.Panel6.TabIndex=164;
            // 
            // Label29
            // 
            this.Label29.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.ForeColor=System.Drawing.Color.Maroon;
            this.Label29.Location=new System.Drawing.Point(-1, 27);
            this.Label29.Name="Label29";
            this.Label29.Size=new System.Drawing.Size(213, 20);
            this.Label29.TabIndex=5;
            this.Label29.Text="عرض تصویر بین 200 تا 500 پیکسل باشد";
            // 
            // Label31
            // 
            this.Label31.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.ForeColor=System.Drawing.Color.Maroon;
            this.Label31.Location=new System.Drawing.Point(-1, 2);
            this.Label31.Name="Label31";
            this.Label31.Size=new System.Drawing.Size(213, 20);
            this.Label31.TabIndex=4;
            this.Label31.Text="ارتفاع تصویر بین 300 تا 600 پیکسل باشد";
            // 
            // Panel5
            // 
            this.Panel5.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Panel5.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.PicButton);
            this.Panel5.Controls.Add(this.PictureBox1);
            this.Panel5.Location=new System.Drawing.Point(15, 77);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(188, 263);
            this.Panel5.TabIndex=3;
            // 
            // PicButton
            // 
            this.PicButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PicButton.Image=global::Metro_Operation.Properties.Resources.user__1_;
            this.PicButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.PicButton.Location=new System.Drawing.Point(18, 217);
            this.PicButton.Name="PicButton";
            this.PicButton.Size=new System.Drawing.Size(151, 36);
            this.PicButton.TabIndex=53;
            this.PicButton.Text="بارگذاری تصویر";
            this.PicButton.UseVisualStyleBackColor=false;
            this.PicButton.Click += new System.EventHandler(this.PicButton_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor=System.Drawing.Color.White;
            this.PictureBox1.Location=new System.Drawing.Point(16, 8);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(155, 200);
            this.PictureBox1.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex=52;
            this.PictureBox1.TabStop=false;
            // 
            // Label30
            // 
            this.Label30.BackColor=System.Drawing.Color.Gray;
            this.Label30.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label30.Cursor=System.Windows.Forms.Cursors.Default;
            this.Label30.ForeColor=System.Drawing.Color.White;
            this.Label30.Location=new System.Drawing.Point(652, 249);
            this.Label30.Name="Label30";
            this.Label30.Size=new System.Drawing.Size(100, 22);
            this.Label30.TabIndex=162;
            this.Label30.Text="اندازه لباس";
            this.Label30.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            this.Label21.BackColor=System.Drawing.Color.Gray;
            this.Label21.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label21.Cursor=System.Windows.Forms.Cursors.Default;
            this.Label21.ForeColor=System.Drawing.Color.White;
            this.Label21.Location=new System.Drawing.Point(652, 162);
            this.Label21.Name="Label21";
            this.Label21.Size=new System.Drawing.Size(100, 22);
            this.Label21.TabIndex=162;
            this.Label21.Text="تحصیلات";
            this.Label21.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ShirtCombo);
            this.Panel2.Controls.Add(this.PantCombo);
            this.Panel2.Controls.Add(this.CoatCombo);
            this.Panel2.Controls.Add(this.ShoeCombo);
            this.Panel2.Controls.Add(this.HitCombo);
            this.Panel2.Controls.Add(this.OverCombo);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Location=new System.Drawing.Point(220, 263);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(537, 105);
            this.Panel2.TabIndex=2;
            // 
            // ShirtCombo
            // 
            this.ShirtCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShirtCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShirtCombo.FormattingEnabled=true;
            this.ShirtCombo.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.ShirtCombo.Location=new System.Drawing.Point(394, 62);
            this.ShirtCombo.MaxLength=3;
            this.ShirtCombo.Name="ShirtCombo";
            this.ShirtCombo.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.ShirtCombo.Size=new System.Drawing.Size(86, 24);
            this.ShirtCombo.TabIndex=3;
            // 
            // PantCombo
            // 
            this.PantCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PantCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PantCombo.FormattingEnabled=true;
            this.PantCombo.Items.AddRange(new object[] {
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52"});
            this.PantCombo.Location=new System.Drawing.Point(12, 23);
            this.PantCombo.MaxLength=2;
            this.PantCombo.Name="PantCombo";
            this.PantCombo.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.PantCombo.Size=new System.Drawing.Size(86, 24);
            this.PantCombo.TabIndex=2;
            // 
            // CoatCombo
            // 
            this.CoatCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CoatCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CoatCombo.FormattingEnabled=true;
            this.CoatCombo.Items.AddRange(new object[] {
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "56",
            "58",
            "60",
            "62"});
            this.CoatCombo.Location=new System.Drawing.Point(203, 23);
            this.CoatCombo.MaxLength=2;
            this.CoatCombo.Name="CoatCombo";
            this.CoatCombo.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.CoatCombo.Size=new System.Drawing.Size(86, 24);
            this.CoatCombo.TabIndex=1;
            // 
            // ShoeCombo
            // 
            this.ShoeCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShoeCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShoeCombo.FormattingEnabled=true;
            this.ShoeCombo.Items.AddRange(new object[] {
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46"});
            this.ShoeCombo.Location=new System.Drawing.Point(394, 23);
            this.ShoeCombo.MaxLength=2;
            this.ShoeCombo.Name="ShoeCombo";
            this.ShoeCombo.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.ShoeCombo.Size=new System.Drawing.Size(86, 24);
            this.ShoeCombo.TabIndex=0;
            // 
            // HitCombo
            // 
            this.HitCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HitCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HitCombo.FormattingEnabled=true;
            this.HitCombo.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.HitCombo.Location=new System.Drawing.Point(12, 62);
            this.HitCombo.MaxLength=3;
            this.HitCombo.Name="HitCombo";
            this.HitCombo.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.HitCombo.Size=new System.Drawing.Size(86, 24);
            this.HitCombo.TabIndex=5;
            // 
            // OverCombo
            // 
            this.OverCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OverCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OverCombo.FormattingEnabled=true;
            this.OverCombo.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.OverCombo.Location=new System.Drawing.Point(203, 62);
            this.OverCombo.MaxLength=3;
            this.OverCombo.Name="OverCombo";
            this.OverCombo.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.OverCombo.Size=new System.Drawing.Size(86, 24);
            this.OverCombo.TabIndex=4;
            // 
            // Label10
            // 
            this.Label10.AutoSize=true;
            this.Label10.Location=new System.Drawing.Point(480, 27);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(43, 16);
            this.Label10.TabIndex=0;
            this.Label10.Text="کفش:";
            // 
            // Label16
            // 
            this.Label16.AutoSize=true;
            this.Label16.Location=new System.Drawing.Point(97, 66);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(48, 16);
            this.Label16.TabIndex=0;
            this.Label16.Text="گرمکن:";
            // 
            // Label11
            // 
            this.Label11.AutoSize=true;
            this.Label11.Location=new System.Drawing.Point(479, 66);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(49, 16);
            this.Label11.TabIndex=0;
            this.Label11.Text="پیراهن:";
            // 
            // Label12
            // 
            this.Label12.AutoSize=true;
            this.Label12.Location=new System.Drawing.Point(288, 66);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(44, 16);
            this.Label12.TabIndex=0;
            this.Label12.Text="اورکت:";
            // 
            // Label13
            // 
            this.Label13.AutoSize=true;
            this.Label13.Location=new System.Drawing.Point(289, 27);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(31, 16);
            this.Label13.TabIndex=0;
            this.Label13.Text="کت:";
            // 
            // Label14
            // 
            this.Label14.AutoSize=true;
            this.Label14.Location=new System.Drawing.Point(97, 27);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(45, 16);
            this.Label14.TabIndex=0;
            this.Label14.Text="شلوار:";
            // 
            // Next0Button
            // 
            this.Next0Button.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Next0Button.Image=global::Metro_Operation.Properties.Resources._31;
            this.Next0Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.Next0Button.Location=new System.Drawing.Point(39, 346);
            this.Next0Button.Name="Next0Button";
            this.Next0Button.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Next0Button.Size=new System.Drawing.Size(140, 35);
            this.Next0Button.TabIndex=3;
            this.Next0Button.Text="بعدی";
            this.Next0Button.UseVisualStyleBackColor=false;
            this.Next0Button.Click += new System.EventHandler(this.Next0Button_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackColor=System.Drawing.Color.LightBlue;
            this.Panel4.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.ObjectCombo);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.DegreeCombo);
            this.Panel4.Location=new System.Drawing.Point(220, 176);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(537, 68);
            this.Panel4.TabIndex=1;
            // 
            // ObjectCombo
            // 
            this.ObjectCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ObjectCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ObjectCombo.Location=new System.Drawing.Point(12, 23);
            this.ObjectCombo.Margin=new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.ObjectCombo.MaxLength=20;
            this.ObjectCombo.Name="ObjectCombo";
            this.ObjectCombo.Size=new System.Drawing.Size(180, 24);
            this.ObjectCombo.Sorted=true;
            this.ObjectCombo.TabIndex=2;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(431, 27);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(94, 16);
            this.Label4.TabIndex=0;
            this.Label4.Text="مدرک تحصیلی:";
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(192, 27);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(93, 16);
            this.Label5.TabIndex=0;
            this.Label5.Text="رشته تحصیلی:";
            // 
            // DegreeCombo
            // 
            this.DegreeCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DegreeCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DegreeCombo.Items.AddRange(new object[] {
            "دیپلم",
            "فوق دیپلم",
            "لیسانس",
            "فوق لیسانس",
            "دکتری"});
            this.DegreeCombo.Location=new System.Drawing.Point(316, 23);
            this.DegreeCombo.Margin=new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DegreeCombo.MaxLength=15;
            this.DegreeCombo.Name="DegreeCombo";
            this.DegreeCombo.Size=new System.Drawing.Size(115, 24);
            this.DegreeCombo.TabIndex=1;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.ItemSize=new System.Drawing.Size(50, 10);
            this.TabControl1.Location=new System.Drawing.Point(0, -6);
            this.TabControl1.Name="TabControl1";
            this.TabControl1.RightToLeftLayout=true;
            this.TabControl1.SelectedIndex=0;
            this.TabControl1.Size=new System.Drawing.Size(776, 436);
            this.TabControl1.SizeMode=System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex=5;
            this.TabControl1.TabStop=false;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor=System.Drawing.Color.LightBlue;
            this.TabPage3.Controls.Add(this.Prev2Button);
            this.TabPage3.Controls.Add(this.RegButton);
            this.TabPage3.Controls.Add(this.Panel3);
            this.TabPage3.Location=new System.Drawing.Point(4, 14);
            this.TabPage3.Name="TabPage3";
            this.TabPage3.Size=new System.Drawing.Size(768, 418);
            this.TabPage3.TabIndex=2;
            // 
            // Prev2Button
            // 
            this.Prev2Button.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Prev2Button.Image=global::Metro_Operation.Properties.Resources._32;
            this.Prev2Button.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.Prev2Button.Location=new System.Drawing.Point(484, 337);
            this.Prev2Button.Name="Prev2Button";
            this.Prev2Button.Padding=new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Prev2Button.Size=new System.Drawing.Size(140, 35);
            this.Prev2Button.TabIndex=12;
            this.Prev2Button.Text="بازگشت";
            this.Prev2Button.UseVisualStyleBackColor=false;
            this.Prev2Button.Click += new System.EventHandler(this.Prev2Button_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(159, 337);
            this.RegButton.Name="RegButton";
            this.RegButton.Padding=new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.RegButton.Size=new System.Drawing.Size(140, 35);
            this.RegButton.TabIndex=10;
            this.RegButton.Text="تایید";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.PictureBox2);
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.Label9);
            this.Panel3.Controls.Add(this.Label20);
            this.Panel3.Controls.Add(this.PantLabel);
            this.Panel3.Controls.Add(this.PhoneLabel);
            this.Panel3.Controls.Add(this.StateLabel);
            this.Panel3.Controls.Add(this.HitLabel);
            this.Panel3.Controls.Add(this.CoatLabel);
            this.Panel3.Controls.Add(this.OverLabel);
            this.Panel3.Controls.Add(this.Label26);
            this.Panel3.Controls.Add(this.Label15);
            this.Panel3.Controls.Add(this.DegreeLabel);
            this.Panel3.Controls.Add(this.Label27);
            this.Panel3.Controls.Add(this.CityLabel);
            this.Panel3.Controls.Add(this.Label28);
            this.Panel3.Controls.Add(this.ShirtLabel);
            this.Panel3.Controls.Add(this.ObjectLabel);
            this.Panel3.Controls.Add(this.Label18);
            this.Panel3.Controls.Add(this.TownLabel);
            this.Panel3.Controls.Add(this.ShoeLabel);
            this.Panel3.Controls.Add(this.Label19);
            this.Panel3.Controls.Add(this.Label24);
            this.Panel3.Controls.Add(this.AddressLabel);
            this.Panel3.Controls.Add(this.Label17);
            this.Panel3.Controls.Add(this.Label25);
            this.Panel3.Location=new System.Drawing.Point(16, 20);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(732, 297);
            this.Panel3.TabIndex=8;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor=System.Drawing.Color.White;
            this.PictureBox2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox2.Location=new System.Drawing.Point(14, 16);
            this.PictureBox2.Name="PictureBox2";
            this.PictureBox2.Size=new System.Drawing.Size(150, 180);
            this.PictureBox2.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex=53;
            this.PictureBox2.TabStop=false;
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(628, 23);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(94, 16);
            this.Label8.TabIndex=6;
            this.Label8.Text="مدرک تحصیلی:";
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.Location=new System.Drawing.Point(408, 23);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(93, 16);
            this.Label9.TabIndex=7;
            this.Label9.Text="رشته نحصیلی:";
            // 
            // Label20
            // 
            this.Label20.AutoSize=true;
            this.Label20.Location=new System.Drawing.Point(667, 183);
            this.Label20.Name="Label20";
            this.Label20.Size=new System.Drawing.Size(47, 16);
            this.Label20.TabIndex=9;
            this.Label20.Text="موبایل:";
            // 
            // PantLabel
            // 
            this.PantLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PantLabel.Location=new System.Drawing.Point(408, 246);
            this.PantLabel.Name="PantLabel";
            this.PantLabel.Size=new System.Drawing.Size(52, 25);
            this.PantLabel.TabIndex=0;
            this.PantLabel.Text="**";
            this.PantLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneLabel.Location=new System.Drawing.Point(522, 179);
            this.PhoneLabel.Name="PhoneLabel";
            this.PhoneLabel.Size=new System.Drawing.Size(146, 25);
            this.PhoneLabel.TabIndex=3;
            this.PhoneLabel.Text="تلفن";
            this.PhoneLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StateLabel
            // 
            this.StateLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StateLabel.Location=new System.Drawing.Point(565, 76);
            this.StateLabel.Name="StateLabel";
            this.StateLabel.Size=new System.Drawing.Size(100, 25);
            this.StateLabel.TabIndex=3;
            this.StateLabel.Text="استان:";
            this.StateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HitLabel
            // 
            this.HitLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HitLabel.Location=new System.Drawing.Point(22, 246);
            this.HitLabel.Name="HitLabel";
            this.HitLabel.Size=new System.Drawing.Size(52, 25);
            this.HitLabel.TabIndex=0;
            this.HitLabel.Text="**";
            this.HitLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoatLabel
            // 
            this.CoatLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CoatLabel.Location=new System.Drawing.Point(527, 246);
            this.CoatLabel.Name="CoatLabel";
            this.CoatLabel.Size=new System.Drawing.Size(52, 25);
            this.CoatLabel.TabIndex=0;
            this.CoatLabel.Text="**";
            this.CoatLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OverLabel
            // 
            this.OverLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OverLabel.Location=new System.Drawing.Point(144, 246);
            this.OverLabel.Name="OverLabel";
            this.OverLabel.Size=new System.Drawing.Size(52, 25);
            this.OverLabel.TabIndex=0;
            this.OverLabel.Text="**";
            this.OverLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label26
            // 
            this.Label26.AutoSize=true;
            this.Label26.Location=new System.Drawing.Point(74, 250);
            this.Label26.Name="Label26";
            this.Label26.Size=new System.Drawing.Size(48, 16);
            this.Label26.TabIndex=0;
            this.Label26.Text="گرمکن:";
            this.Label26.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.AutoSize=true;
            this.Label15.Location=new System.Drawing.Point(665, 80);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(47, 16);
            this.Label15.TabIndex=3;
            this.Label15.Text="استان:";
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DegreeLabel.Location=new System.Drawing.Point(499, 19);
            this.DegreeLabel.Name="DegreeLabel";
            this.DegreeLabel.Size=new System.Drawing.Size(133, 25);
            this.DegreeLabel.TabIndex=4;
            this.DegreeLabel.Text="مدرک تحصیلی:";
            this.DegreeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label27
            // 
            this.Label27.AutoSize=true;
            this.Label27.Location=new System.Drawing.Point(579, 250);
            this.Label27.Name="Label27";
            this.Label27.Size=new System.Drawing.Size(31, 16);
            this.Label27.TabIndex=0;
            this.Label27.Text="کت:";
            this.Label27.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CityLabel
            // 
            this.CityLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CityLabel.Location=new System.Drawing.Point(400, 76);
            this.CityLabel.Name="CityLabel";
            this.CityLabel.Size=new System.Drawing.Size(100, 25);
            this.CityLabel.TabIndex=4;
            this.CityLabel.Text="شهر:";
            this.CityLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label28
            // 
            this.Label28.AutoSize=true;
            this.Label28.Location=new System.Drawing.Point(460, 250);
            this.Label28.Name="Label28";
            this.Label28.Size=new System.Drawing.Size(45, 16);
            this.Label28.TabIndex=0;
            this.Label28.Text="شلوار:";
            this.Label28.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShirtLabel
            // 
            this.ShirtLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShirtLabel.Location=new System.Drawing.Point(265, 246);
            this.ShirtLabel.Name="ShirtLabel";
            this.ShirtLabel.Size=new System.Drawing.Size(52, 25);
            this.ShirtLabel.TabIndex=0;
            this.ShirtLabel.Text="**";
            this.ShirtLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ObjectLabel
            // 
            this.ObjectLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ObjectLabel.Location=new System.Drawing.Point(170, 19);
            this.ObjectLabel.Name="ObjectLabel";
            this.ObjectLabel.Size=new System.Drawing.Size(241, 25);
            this.ObjectLabel.TabIndex=5;
            this.ObjectLabel.Text="رشته نحصیلی:";
            this.ObjectLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label18
            // 
            this.Label18.AutoSize=true;
            this.Label18.Location=new System.Drawing.Point(500, 80);
            this.Label18.Name="Label18";
            this.Label18.Size=new System.Drawing.Size(38, 16);
            this.Label18.TabIndex=4;
            this.Label18.Text="شهر:";
            // 
            // TownLabel
            // 
            this.TownLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TownLabel.Location=new System.Drawing.Point(224, 76);
            this.TownLabel.Name="TownLabel";
            this.TownLabel.Size=new System.Drawing.Size(100, 25);
            this.TownLabel.TabIndex=5;
            this.TownLabel.Text="منطقه:";
            this.TownLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShoeLabel
            // 
            this.ShoeLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShoeLabel.Location=new System.Drawing.Point(615, 246);
            this.ShoeLabel.Name="ShoeLabel";
            this.ShoeLabel.Size=new System.Drawing.Size(52, 25);
            this.ShoeLabel.TabIndex=0;
            this.ShoeLabel.Text="**";
            this.ShoeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label19
            // 
            this.Label19.AutoSize=true;
            this.Label19.Location=new System.Drawing.Point(324, 80);
            this.Label19.Name="Label19";
            this.Label19.Size=new System.Drawing.Size(48, 16);
            this.Label19.TabIndex=5;
            this.Label19.Text="منطقه:";
            // 
            // Label24
            // 
            this.Label24.AutoSize=true;
            this.Label24.Location=new System.Drawing.Point(666, 250);
            this.Label24.Name="Label24";
            this.Label24.Size=new System.Drawing.Size(43, 16);
            this.Label24.TabIndex=0;
            this.Label24.Text="کفش:";
            this.Label24.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLabel.Location=new System.Drawing.Point(170, 117);
            this.AddressLabel.Name="AddressLabel";
            this.AddressLabel.Size=new System.Drawing.Size(541, 40);
            this.AddressLabel.TabIndex=0;
            this.AddressLabel.Text="پلاک:";
            // 
            // Label17
            // 
            this.Label17.AutoSize=true;
            this.Label17.Location=new System.Drawing.Point(196, 250);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(44, 16);
            this.Label17.TabIndex=0;
            this.Label17.Text="اورکت:";
            this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label25
            // 
            this.Label25.AutoSize=true;
            this.Label25.Location=new System.Drawing.Point(317, 250);
            this.Label25.Name="Label25";
            this.Label25.Size=new System.Drawing.Size(49, 16);
            this.Label25.TabIndex=0;
            this.Label25.Text="پیراهن:";
            this.Label25.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PersonalDetailForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(776, 427);
            this.Controls.Add(this.TabControl1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="PersonalDetailForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="مشخصات پرسنلی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalDetailForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonalDetailForm_Load);
            this.TabPage1.ResumeLayout(false);
            this.DetailAddressPanel.ResumeLayout(false);
            this.DetailAddressPanel.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

		}
		private TabPage TabPage1;
		private Button Next0Button;
		private Panel Panel1;
		private ComboBox TownCombo;
		private Label Label1;
		private Label Label2;
		private Label Label3;
		private ComboBox CityCombo;
		private Label Label6;
		private TextBox AddressBox;
		private ComboBox StateCombo;
		private TabControl TabControl1;
		private TabPage TabPage3;
		private Button Prev2Button;
		private Button RegButton;
		private Panel Panel3;
		private Label PantLabel;
		private Label StateLabel;
		private Label HitLabel;
		private Label CoatLabel;
		private Label OverLabel;
		private Label Label26;
		private Label Label15;
		private Label Label27;
		private Label CityLabel;
		private Label Label28;
		private Label ShirtLabel;
		private Label Label18;
		private Label TownLabel;
		private Label ShoeLabel;
		private Label Label19;
		private Label Label24;
		private Label AddressLabel;
		private Label Label17;
		private Label Label25;
		private Panel Panel2;
		private ComboBox HitCombo;
		private ComboBox OverCombo;
		private Label Label10;
		private Label Label16;
		private Label Label11;
		private Label Label12;
		private Label Label13;
		private ComboBox ShirtCombo;
		private Label Label14;
		private ComboBox PantCombo;
		private ComboBox CoatCombo;
		private ComboBox ShoeCombo;
		private Panel Panel4;
		private Label Label4;
		private Label Label5;
		private ComboBox ObjectCombo;
		private ComboBox DegreeCombo;
		private TextBox PhoneBox;
		private Label Label7;
		private Label Label8;
		private Label Label9;
		private Label Label20;
		private Label PhoneLabel;
		private Label DegreeLabel;
		private Label ObjectLabel;
		private Label Label30;
		private Label Label23;
		private Label Label21;
		private Panel Panel5;
		private PictureBox PictureBox1;
		private PictureBox PictureBox2;
		private Button PicButton;
		private Panel Panel6;
		private Label Label29;
		private Label Label31;
		private Button AddressEditButton;
		private Panel DetailAddressPanel;
		private TextBox AddressBox6;
		private TextBox AddressBox5;
		private TextBox AddressBox4;
		private TextBox AddressBox3;
		private Button AddressRegButton;
		private Label Label43;
		private TextBox AddressBox2;
		private TextBox AddressBox1;
		private ComboBox ComboBox1;
		private ComboBox ComboBox6;
		private ComboBox ComboBox4;
		private ComboBox ComboBox2;
		private ComboBox ComboBox5;
		private ComboBox ComboBox3;
		private Label Label36;
		private Label Label35;
		private Label Label34;
		private Label Label33;
		private Label Label32;
		private Label Label22;
    }
	
}
