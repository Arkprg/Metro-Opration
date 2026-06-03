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
	partial class DailyProcessParametrEditForm : BaseForm
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
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.DelButton=new Button();
			this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.Label8=new Label();
			this.Panel1=new Panel();
			this.SearchNameCombo=new ComboBox();
			this.SearchNameCombo.SelectedIndexChanged += new System.EventHandler(this.SearchNameCombo_SelectedIndexChanged);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label14=new Label();
			this.SearchKindCombo=new ComboBox();
			this.SearchKindCombo.SelectedIndexChanged += new System.EventHandler(this.SearchKindCombo_SelectedIndexChanged);
			this.Label3=new Label();
			this.Panel2=new Panel();
			this.Label7=new Label();
			this.NameBox=new TextBox();
			this.KindCombo=new ComboBox();
			this.Label6=new Label();
			this.Shift1Label=new Label();
			this.Reserv1Label=new Label();
			this.MemBox=new RichTextBox();
			this.Label32=new Label();
			this.Local1Panel1=new Panel();
			this.ShiftSetadi1Box=new MaskedTextBox();
			this.Label35=new Label();
			this.Label21=new Label();
			this.Shift12Rooz1Box=new MaskedTextBox();
			this.Shift12Shab1Box=new MaskedTextBox();
			this.Label10=new Label();
			this.Label11=new Label();
			this.Label19=new Label();
			this.Shift9Asr1Box=new MaskedTextBox();
			this.Label20=new Label();
			this.Shift9Sobh1Box=new MaskedTextBox();
			this.Label22=new Label();
			this.Label23=new Label();
			this.Local1Panel2=new Panel();
			this.Label2=new Label();
			this.Label5=new Label();
			this.Label4=new Label();
			this.Label15=new Label();
			this.Label17=new Label();
			this.RezSetadi1Box=new MaskedTextBox();
			this.Rez12Rooz1Box=new MaskedTextBox();
			this.Rez9Asr1Box=new MaskedTextBox();
			this.Label18=new Label();
			this.Rez12Shab1Box=new MaskedTextBox();
			this.Rez9Sobh1Box=new MaskedTextBox();
			this.Label16=new Label();
			this.Label1=new Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Local1Panel1.SuspendLayout();
			this.Local1Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Enabled=false;
			this.RegButton.ForeColor=System.Drawing.Color.Black;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Location=new System.Drawing.Point(429, 506);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(185, 38);
			this.RegButton.TabIndex=2;
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
			this.DelButton.ForeColor=System.Drawing.Color.Black;
			this.DelButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.DelButton.Location=new System.Drawing.Point(239, 506);
			this.DelButton.Name="DelButton";
			this.DelButton.Size=new System.Drawing.Size(185, 38);
			this.DelButton.TabIndex=3;
			this.DelButton.Text="حذف";
			this.DelButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			
			this.ExitButton.ForeColor=System.Drawing.Color.Black;
			this.ExitButton.Location=new System.Drawing.Point(12, 506);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(158, 38);
			this.ExitButton.TabIndex=4;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.BackColor=System.Drawing.Color.Transparent;
			this.Label8.ForeColor=System.Drawing.Color.Black;
			this.Label8.Location=new System.Drawing.Point(187, 15);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(72, 16);
			this.Label8.TabIndex=59;
			this.Label8.Text="نام پردازش:";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.SearchNameCombo);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.SearchKindCombo);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.ForeColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Location=new System.Drawing.Point(12, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(602, 47);
			this.Panel1.TabIndex=47;
			//
			//SearchNameCombo
			//
			this.SearchNameCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.SearchNameCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F));
			this.SearchNameCombo.FormattingEnabled=true;
			this.SearchNameCombo.Items.AddRange(new object[] {"تهران", "گلشهر", "هشتگرد"});
			this.SearchNameCombo.Location=new System.Drawing.Point(9, 11);
			this.SearchNameCombo.Margin=new Padding(3, 4, 3, 4);
			this.SearchNameCombo.Name="SearchNameCombo";
			this.SearchNameCombo.Size=new System.Drawing.Size(179, 24);
			this.SearchNameCombo.TabIndex=62;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Items.AddRange(new object[] {"تهران", "گلشهر", "هشتگرد"});
			this.LocalCombo.Location=new System.Drawing.Point(463, 11);
			this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(100, 24);
			this.LocalCombo.TabIndex=0;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.BackColor=System.Drawing.Color.Transparent;
			this.Label14.ForeColor=System.Drawing.Color.Black;
			this.Label14.Location=new System.Drawing.Point(563, 15);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(35, 16);
			this.Label14.TabIndex=61;
			this.Label14.Text="مبدا:";
			//
			//SearchKindCombo
			//
			this.SearchKindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.SearchKindCombo.FormattingEnabled=true;
			this.SearchKindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.SearchKindCombo.Location=new System.Drawing.Point(260, 11);
			this.SearchKindCombo.Name="SearchKindCombo";
			this.SearchKindCombo.Size=new System.Drawing.Size(128, 24);
			this.SearchKindCombo.TabIndex=1;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.ForeColor=System.Drawing.Color.Black;
			this.Label3.Location=new System.Drawing.Point(387, 15);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(74, 16);
			this.Label3.TabIndex=58;
			this.Label3.Text="نوع پردازش:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel2
			//
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Controls.Add(this.NameBox);
			this.Panel2.Controls.Add(this.KindCombo);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Shift1Label);
			this.Panel2.Controls.Add(this.Reserv1Label);
			this.Panel2.Controls.Add(this.MemBox);
			this.Panel2.Controls.Add(this.Label32);
			this.Panel2.Controls.Add(this.Local1Panel1);
			this.Panel2.Controls.Add(this.Local1Panel2);
			this.Panel2.Location=new System.Drawing.Point(12, 73);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(602, 417);
			this.Panel2.TabIndex=48;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.BackColor=System.Drawing.Color.Transparent;
			this.Label7.ForeColor=System.Drawing.Color.Black;
			this.Label7.Location=new System.Drawing.Point(314, 16);
			this.Label7.Margin=new Padding(3);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(72, 16);
			this.Label7.TabIndex=63;
			this.Label7.Text="نام پردازش:";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(14, 13);
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(300, 23);
			this.NameBox.TabIndex=61;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.KindCombo.Location=new System.Drawing.Point(388, 12);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(125, 24);
			this.KindCombo.TabIndex=60;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.BackColor=System.Drawing.Color.Transparent;
			this.Label6.ForeColor=System.Drawing.Color.Black;
			this.Label6.Location=new System.Drawing.Point(513, 16);
			this.Label6.Margin=new Padding(3);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(74, 16);
			this.Label6.TabIndex=62;
			this.Label6.Text="نوع پردازش:";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Shift1Label
			//
			this.Shift1Label.BackColor=System.Drawing.Color.Black;
			this.Shift1Label.BorderStyle=BorderStyle.FixedSingle;
			this.Shift1Label.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Shift1Label.ForeColor=System.Drawing.Color.Yellow;
			this.Shift1Label.Location=new System.Drawing.Point(440, 53);
			this.Shift1Label.Margin=new Padding(3);
			this.Shift1Label.Name="Shift1Label";
			this.Shift1Label.Size=new System.Drawing.Size(147, 27);
			this.Shift1Label.TabIndex=57;
			this.Shift1Label.Text="شیفت";
			this.Shift1Label.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Reserv1Label
			//
			this.Reserv1Label.BackColor=System.Drawing.Color.Black;
			this.Reserv1Label.BorderStyle=BorderStyle.FixedSingle;
			this.Reserv1Label.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Reserv1Label.ForeColor=System.Drawing.Color.Lime;
			this.Reserv1Label.Location=new System.Drawing.Point(440, 183);
			this.Reserv1Label.Margin=new Padding(3);
			this.Reserv1Label.Name="Reserv1Label";
			this.Reserv1Label.Size=new System.Drawing.Size(147, 27);
			this.Reserv1Label.TabIndex=58;
			this.Reserv1Label.Text="رزرو";
			this.Reserv1Label.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.Beige;
			this.MemBox.BorderStyle=BorderStyle.FixedSingle;
			this.MemBox.Location=new System.Drawing.Point(14, 331);
			this.MemBox.Margin=new Padding(4, 5, 4, 5);
			this.MemBox.MaxLength=250;
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(573, 72);
			this.MemBox.TabIndex=56;
			this.MemBox.Text="";
			//
			//Label32
			//
			this.Label32.AutoSize=true;
			this.Label32.Location=new System.Drawing.Point(523, 311);
			this.Label32.Margin=new Padding(4, 0, 4, 0);
			this.Label32.Name="Label32";
			this.Label32.Size=new System.Drawing.Size(62, 16);
			this.Label32.TabIndex=59;
			this.Label32.Text="توضیحات:";
			//
			//Local1Panel1
			//
			this.Local1Panel1.BackColor=System.Drawing.Color.LightGray;
			this.Local1Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Local1Panel1.Controls.Add(this.ShiftSetadi1Box);
			this.Local1Panel1.Controls.Add(this.Label35);
			this.Local1Panel1.Controls.Add(this.Label21);
			this.Local1Panel1.Controls.Add(this.Shift12Rooz1Box);
			this.Local1Panel1.Controls.Add(this.Shift12Shab1Box);
			this.Local1Panel1.Controls.Add(this.Label10);
			this.Local1Panel1.Controls.Add(this.Label11);
			this.Local1Panel1.Controls.Add(this.Label19);
			this.Local1Panel1.Controls.Add(this.Shift9Asr1Box);
			this.Local1Panel1.Controls.Add(this.Label20);
			this.Local1Panel1.Controls.Add(this.Shift9Sobh1Box);
			this.Local1Panel1.Controls.Add(this.Label22);
			this.Local1Panel1.Controls.Add(this.Label23);
			this.Local1Panel1.Location=new System.Drawing.Point(14, 78);
			this.Local1Panel1.Name="Local1Panel1";
			this.Local1Panel1.Size=new System.Drawing.Size(573, 91);
			this.Local1Panel1.TabIndex=54;
			//
			//ShiftSetadi1Box
			//
			this.ShiftSetadi1Box.BackColor=System.Drawing.Color.White;
			this.ShiftSetadi1Box.BorderStyle=BorderStyle.FixedSingle;
			this.ShiftSetadi1Box.Location=new System.Drawing.Point(21, 50);
			this.ShiftSetadi1Box.Mask="90";
			this.ShiftSetadi1Box.Name="ShiftSetadi1Box";
			this.ShiftSetadi1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ShiftSetadi1Box.Size=new System.Drawing.Size(45, 23);
			this.ShiftSetadi1Box.TabIndex=4;
			this.ShiftSetadi1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label35
			//
			this.Label35.AutoSize=true;
			this.Label35.BackColor=System.Drawing.Color.Transparent;
			this.Label35.Location=new System.Drawing.Point(65, 53);
			this.Label35.Margin=new Padding(3);
			this.Label35.Name="Label35";
			this.Label35.Size=new System.Drawing.Size(37, 16);
			this.Label35.TabIndex=35;
			this.Label35.Text="صبح:";
			this.Label35.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label21
			//
			this.Label21.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Label21.BorderStyle=BorderStyle.FixedSingle;
			this.Label21.ForeColor=System.Drawing.Color.White;
			this.Label21.Location=new System.Drawing.Point(20, 15);
			this.Label21.Margin=new Padding(3);
			this.Label21.Name="Label21";
			this.Label21.Size=new System.Drawing.Size(82, 25);
			this.Label21.TabIndex=34;
			this.Label21.Text="ستادی";
			this.Label21.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Shift12Rooz1Box
			//
			this.Shift12Rooz1Box.BackColor=System.Drawing.Color.White;
			this.Shift12Rooz1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Shift12Rooz1Box.Location=new System.Drawing.Point(480, 50);
			this.Shift12Rooz1Box.Mask="90";
			this.Shift12Rooz1Box.Name="Shift12Rooz1Box";
			this.Shift12Rooz1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift12Rooz1Box.Size=new System.Drawing.Size(45, 23);
			this.Shift12Rooz1Box.TabIndex=0;
			this.Shift12Rooz1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift12Shab1Box
			//
			this.Shift12Shab1Box.BackColor=System.Drawing.Color.White;
			this.Shift12Shab1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Shift12Shab1Box.Location=new System.Drawing.Point(390, 50);
			this.Shift12Shab1Box.Mask="90";
			this.Shift12Shab1Box.Name="Shift12Shab1Box";
			this.Shift12Shab1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift12Shab1Box.Size=new System.Drawing.Size(45, 23);
			this.Shift12Shab1Box.TabIndex=1;
			this.Shift12Shab1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label10
			//
			this.Label10.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Label10.BorderStyle=BorderStyle.FixedSingle;
			this.Label10.ForeColor=System.Drawing.Color.White;
			this.Label10.Location=new System.Drawing.Point(156, 15);
			this.Label10.Margin=new Padding(3);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(167, 25);
			this.Label10.TabIndex=33;
			this.Label10.Text="9 ساعته";
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label11
			//
			this.Label11.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Label11.BorderStyle=BorderStyle.FixedSingle;
			this.Label11.ForeColor=System.Drawing.Color.White;
			this.Label11.Location=new System.Drawing.Point(388, 15);
			this.Label11.Margin=new Padding(3);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(167, 25);
			this.Label11.TabIndex=33;
			this.Label11.Text="12 ساعته";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.BackColor=System.Drawing.Color.Transparent;
			this.Label19.Location=new System.Drawing.Point(525, 53);
			this.Label19.Margin=new Padding(3);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(28, 16);
			this.Label19.TabIndex=28;
			this.Label19.Text="روز:";
			this.Label19.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Shift9Asr1Box
			//
			this.Shift9Asr1Box.BackColor=System.Drawing.Color.White;
			this.Shift9Asr1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Shift9Asr1Box.Location=new System.Drawing.Point(156, 50);
			this.Shift9Asr1Box.Mask="90";
			this.Shift9Asr1Box.Name="Shift9Asr1Box";
			this.Shift9Asr1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift9Asr1Box.Size=new System.Drawing.Size(45, 23);
			this.Shift9Asr1Box.TabIndex=3;
			this.Shift9Asr1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label20
			//
			this.Label20.AutoSize=true;
			this.Label20.BackColor=System.Drawing.Color.Transparent;
			this.Label20.Location=new System.Drawing.Point(434, 53);
			this.Label20.Margin=new Padding(3);
			this.Label20.Name="Label20";
			this.Label20.Size=new System.Drawing.Size(38, 16);
			this.Label20.TabIndex=30;
			this.Label20.Text="شب:";
			this.Label20.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Shift9Sobh1Box
			//
			this.Shift9Sobh1Box.BackColor=System.Drawing.Color.White;
			this.Shift9Sobh1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Shift9Sobh1Box.Location=new System.Drawing.Point(243, 50);
			this.Shift9Sobh1Box.Mask="90";
			this.Shift9Sobh1Box.Name="Shift9Sobh1Box";
			this.Shift9Sobh1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift9Sobh1Box.Size=new System.Drawing.Size(45, 23);
			this.Shift9Sobh1Box.TabIndex=2;
			this.Shift9Sobh1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label22
			//
			this.Label22.AutoSize=true;
			this.Label22.BackColor=System.Drawing.Color.Transparent;
			this.Label22.Location=new System.Drawing.Point(201, 53);
			this.Label22.Margin=new Padding(3);
			this.Label22.Name="Label22";
			this.Label22.Size=new System.Drawing.Size(36, 16);
			this.Label22.TabIndex=30;
			this.Label22.Text="عصر:";
			this.Label22.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label23
			//
			this.Label23.AutoSize=true;
			this.Label23.BackColor=System.Drawing.Color.Transparent;
			this.Label23.Location=new System.Drawing.Point(288, 53);
			this.Label23.Margin=new Padding(3);
			this.Label23.Name="Label23";
			this.Label23.Size=new System.Drawing.Size(37, 16);
			this.Label23.TabIndex=28;
			this.Label23.Text="صبح:";
			this.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Local1Panel2
			//
			this.Local1Panel2.BackColor=System.Drawing.Color.LightGray;
			this.Local1Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Local1Panel2.Controls.Add(this.Label2);
			this.Local1Panel2.Controls.Add(this.Label5);
			this.Local1Panel2.Controls.Add(this.Label4);
			this.Local1Panel2.Controls.Add(this.Label15);
			this.Local1Panel2.Controls.Add(this.Label17);
			this.Local1Panel2.Controls.Add(this.RezSetadi1Box);
			this.Local1Panel2.Controls.Add(this.Rez12Rooz1Box);
			this.Local1Panel2.Controls.Add(this.Rez9Asr1Box);
			this.Local1Panel2.Controls.Add(this.Label18);
			this.Local1Panel2.Controls.Add(this.Rez12Shab1Box);
			this.Local1Panel2.Controls.Add(this.Rez9Sobh1Box);
			this.Local1Panel2.Controls.Add(this.Label16);
			this.Local1Panel2.Controls.Add(this.Label1);
			this.Local1Panel2.Location=new System.Drawing.Point(14, 208);
			this.Local1Panel2.Name="Local1Panel2";
			this.Local1Panel2.Size=new System.Drawing.Size(573, 91);
			this.Local1Panel2.TabIndex=55;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.Location=new System.Drawing.Point(66, 53);
			this.Label2.Margin=new Padding(3);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(37, 16);
			this.Label2.TabIndex=35;
			this.Label2.Text="صبح:";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Label5.BorderStyle=BorderStyle.FixedSingle;
			this.Label5.ForeColor=System.Drawing.Color.White;
			this.Label5.Location=new System.Drawing.Point(20, 15);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(80, 25);
			this.Label5.TabIndex=34;
			this.Label5.Text="ستادی";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label4
			//
			this.Label4.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Label4.BorderStyle=BorderStyle.FixedSingle;
			this.Label4.ForeColor=System.Drawing.Color.White;
			this.Label4.Location=new System.Drawing.Point(156, 15);
			this.Label4.Margin=new Padding(3);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(167, 25);
			this.Label4.TabIndex=33;
			this.Label4.Text="9 ساعته";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label15
			//
			this.Label15.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.Label15.BorderStyle=BorderStyle.FixedSingle;
			this.Label15.ForeColor=System.Drawing.Color.White;
			this.Label15.Location=new System.Drawing.Point(388, 15);
			this.Label15.Margin=new Padding(3);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(167, 25);
			this.Label15.TabIndex=33;
			this.Label15.Text="12 ساعته";
			this.Label15.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.BackColor=System.Drawing.Color.Transparent;
			this.Label17.Location=new System.Drawing.Point(525, 53);
			this.Label17.Margin=new Padding(3);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(28, 16);
			this.Label17.TabIndex=28;
			this.Label17.Text="روز:";
			this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//RezSetadi1Box
			//
			this.RezSetadi1Box.BackColor=System.Drawing.Color.White;
			this.RezSetadi1Box.BorderStyle=BorderStyle.FixedSingle;
			this.RezSetadi1Box.Location=new System.Drawing.Point(20, 50);
			this.RezSetadi1Box.Mask="90";
			this.RezSetadi1Box.Name="RezSetadi1Box";
			this.RezSetadi1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.RezSetadi1Box.Size=new System.Drawing.Size(45, 23);
			this.RezSetadi1Box.TabIndex=4;
			this.RezSetadi1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez12Rooz1Box
			//
			this.Rez12Rooz1Box.BackColor=System.Drawing.Color.White;
			this.Rez12Rooz1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Rez12Rooz1Box.Location=new System.Drawing.Point(480, 50);
			this.Rez12Rooz1Box.Mask="90";
			this.Rez12Rooz1Box.Name="Rez12Rooz1Box";
			this.Rez12Rooz1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez12Rooz1Box.Size=new System.Drawing.Size(45, 23);
			this.Rez12Rooz1Box.TabIndex=0;
			this.Rez12Rooz1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez9Asr1Box
			//
			this.Rez9Asr1Box.BackColor=System.Drawing.Color.White;
			this.Rez9Asr1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Rez9Asr1Box.Location=new System.Drawing.Point(156, 50);
			this.Rez9Asr1Box.Mask="90";
			this.Rez9Asr1Box.Name="Rez9Asr1Box";
			this.Rez9Asr1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez9Asr1Box.Size=new System.Drawing.Size(45, 23);
			this.Rez9Asr1Box.TabIndex=3;
			this.Rez9Asr1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.BackColor=System.Drawing.Color.Transparent;
			this.Label18.Location=new System.Drawing.Point(435, 53);
			this.Label18.Margin=new Padding(3);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(38, 16);
			this.Label18.TabIndex=30;
			this.Label18.Text="شب:";
			this.Label18.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Rez12Shab1Box
			//
			this.Rez12Shab1Box.BackColor=System.Drawing.Color.White;
			this.Rez12Shab1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Rez12Shab1Box.Location=new System.Drawing.Point(390, 50);
			this.Rez12Shab1Box.Mask="90";
			this.Rez12Shab1Box.Name="Rez12Shab1Box";
			this.Rez12Shab1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez12Shab1Box.Size=new System.Drawing.Size(45, 23);
			this.Rez12Shab1Box.TabIndex=1;
			this.Rez12Shab1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez9Sobh1Box
			//
			this.Rez9Sobh1Box.BackColor=System.Drawing.Color.White;
			this.Rez9Sobh1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Rez9Sobh1Box.Location=new System.Drawing.Point(243, 50);
			this.Rez9Sobh1Box.Mask="90";
			this.Rez9Sobh1Box.Name="Rez9Sobh1Box";
			this.Rez9Sobh1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez9Sobh1Box.Size=new System.Drawing.Size(45, 23);
			this.Rez9Sobh1Box.TabIndex=2;
			this.Rez9Sobh1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label16
			//
			this.Label16.AutoSize=true;
			this.Label16.BackColor=System.Drawing.Color.Transparent;
			this.Label16.Location=new System.Drawing.Point(200, 53);
			this.Label16.Margin=new Padding(3);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(36, 16);
			this.Label16.TabIndex=30;
			this.Label16.Text="عصر:";
			this.Label16.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.Location=new System.Drawing.Point(287, 53);
			this.Label1.Margin=new Padding(3);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(37, 16);
			this.Label1.TabIndex=28;
			this.Label1.Text="صبح:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//DailyProcessParametrEditForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(629, 556);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.DelButton);
			this.Controls.Add(this.RegButton);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="DailyProcessParametrEditForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ویرایش پارامتر های پردازش";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Local1Panel1.ResumeLayout(false);
			this.Local1Panel1.PerformLayout();
			this.Local1Panel2.ResumeLayout(false);
			this.Local1Panel2.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private Button RegButton;
		private Button DelButton;
		private Button ExitButton;
		private Label Label8;
		private Panel Panel1;
		private ComboBox SearchNameCombo;
		private ComboBox LocalCombo;
		private Label Label14;
		private ComboBox SearchKindCombo;
		private Label Label3;
		private Panel Panel2;
		private Label Label7;
		private TextBox NameBox;
		private ComboBox KindCombo;
		private Label Label6;
		private Label Shift1Label;
		private Label Reserv1Label;
		private RichTextBox MemBox;
		private Label Label32;
		private Panel Local1Panel1;
		private MaskedTextBox ShiftSetadi1Box;
		private Label Label35;
		private Label Label21;
		private MaskedTextBox Shift12Rooz1Box;
		private MaskedTextBox Shift12Shab1Box;
		private Label Label10;
		private Label Label11;
		private Label Label19;
		private MaskedTextBox Shift9Asr1Box;
		private Label Label20;
		private MaskedTextBox Shift9Sobh1Box;
		private Label Label22;
		private Label Label23;
		private Panel Local1Panel2;
		private Label Label2;
		private Label Label5;
		private Label Label4;
		private Label Label15;
		private Label Label17;
		private MaskedTextBox RezSetadi1Box;
		private MaskedTextBox Rez12Rooz1Box;
		private MaskedTextBox Rez9Asr1Box;
		private Label Label18;
		private MaskedTextBox Rez12Shab1Box;
		private MaskedTextBox Rez9Sobh1Box;
		private Label Label16;
		private Label Label1;
	}
	
}
