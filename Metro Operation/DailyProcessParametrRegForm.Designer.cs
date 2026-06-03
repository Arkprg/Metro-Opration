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
	partial class DailyProcessParametrRegForm : BaseForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)  {
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()  {
			this.Reserv1Label=new Label();
			this.MemBox=new RichTextBox();
			this.Label32=new Label();
			this.Panel1=new Panel();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label14=new Label();
			this.NameBox=new TextBox();
			this.Label8=new Label();
			this.KindCombo=new ComboBox();
			this.Label3=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
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
			this.Label34=new Label();
			this.Label23=new Label();
			this.Label22=new Label();
			this.Shift9Sobh1Box=new MaskedTextBox();
			this.Label20=new Label();
			this.Shift9Asr1Box=new MaskedTextBox();
			this.Label19=new Label();
			this.Label11=new Label();
			this.Label10=new Label();
			this.Shift12Shab1Box=new MaskedTextBox();
			this.Shift12Rooz1Box=new MaskedTextBox();
			this.Label21=new Label();
			this.Label35=new Label();
			this.ShiftSetadi1Box=new MaskedTextBox();
			this.Local1Panel1=new Panel();
			this.Shift1Label=new Label();
			this.Panel1.SuspendLayout();
			this.Local1Panel2.SuspendLayout();
			this.Local1Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//Reserv1Label
			//
			this.Reserv1Label.BackColor=System.Drawing.Color.Black;
			this.Reserv1Label.BorderStyle=BorderStyle.FixedSingle;
			this.Reserv1Label.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Reserv1Label.ForeColor=System.Drawing.Color.Lime;
			this.Reserv1Label.Location=new System.Drawing.Point(440, 240);
			this.Reserv1Label.Margin=new Padding(3);
			this.Reserv1Label.Name="Reserv1Label";
			this.Reserv1Label.Size=new System.Drawing.Size(147, 27);
			this.Reserv1Label.TabIndex=38;
			this.Reserv1Label.Text="رزرو";
			this.Reserv1Label.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.Beige;
			this.MemBox.BorderStyle=BorderStyle.FixedSingle;
			this.MemBox.Location=new System.Drawing.Point(14, 392);
			this.MemBox.Margin=new Padding(4, 5, 4, 5);
			this.MemBox.MaxLength=250;
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(573, 72);
			this.MemBox.TabIndex=3;
			this.MemBox.Text="";
			//
			//Label32
			//
			this.Label32.AutoSize=true;
			this.Label32.Location=new System.Drawing.Point(523, 372);
			this.Label32.Margin=new Padding(4, 0, 4, 0);
			this.Label32.Name="Label32";
			this.Label32.Size=new System.Drawing.Size(62, 16);
			this.Label32.TabIndex=46;
			this.Label32.Text="توضیحات:";
			//
			//Panel1
			//
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.RegButton);
			this.Panel1.ForeColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Location=new System.Drawing.Point(14, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(573, 86);
			this.Panel1.TabIndex=0;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Items.AddRange(new object[] {"تهران", "گلشهر", "هشتگرد"});
			this.LocalCombo.Location=new System.Drawing.Point(362, 13);
			this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(134, 24);
			this.LocalCombo.TabIndex=0;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.BackColor=System.Drawing.Color.Transparent;
			this.Label14.ForeColor=System.Drawing.Color.Black;
			this.Label14.Location=new System.Drawing.Point(496, 17);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(35, 16);
			this.Label14.TabIndex=61;
			this.Label14.Text="مبدا:";
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(146, 49);
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(350, 23);
			this.NameBox.TabIndex=2;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.BackColor=System.Drawing.Color.Transparent;
			this.Label8.ForeColor=System.Drawing.Color.Black;
			this.Label8.Location=new System.Drawing.Point(496, 52);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(72, 16);
			this.Label8.TabIndex=59;
			this.Label8.Text="نام پردازش:";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.KindCombo.Location=new System.Drawing.Point(146, 13);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(134, 24);
			this.KindCombo.TabIndex=1;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.ForeColor=System.Drawing.Color.Black;
			this.Label3.Location=new System.Drawing.Point(279, 17);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(74, 16);
			this.Label3.TabIndex=58;
			this.Label3.Text="نوع پردازش:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.ForeColor=System.Drawing.Color.Black;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Location=new System.Drawing.Point(7, 22);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(130, 40);
			this.RegButton.TabIndex=57;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
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
			this.Local1Panel2.Controls.Add(this.Label34);
			this.Local1Panel2.Location=new System.Drawing.Point(14, 265);
			this.Local1Panel2.Name="Local1Panel2";
			this.Local1Panel2.Size=new System.Drawing.Size(573, 91);
			this.Local1Panel2.TabIndex=2;
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
			//Label34
			//
			this.Label34.AutoSize=true;
			this.Label34.BackColor=System.Drawing.Color.Transparent;
			this.Label34.Location=new System.Drawing.Point(287, 53);
			this.Label34.Margin=new Padding(3);
			this.Label34.Name="Label34";
			this.Label34.Size=new System.Drawing.Size(37, 16);
			this.Label34.TabIndex=28;
			this.Label34.Text="صبح:";
			this.Label34.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
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
			this.Local1Panel1.Location=new System.Drawing.Point(14, 135);
			this.Local1Panel1.Name="Local1Panel1";
			this.Local1Panel1.Size=new System.Drawing.Size(573, 91);
			this.Local1Panel1.TabIndex=1;
			//
			//Shift1Label
			//
			this.Shift1Label.BackColor=System.Drawing.Color.Black;
			this.Shift1Label.BorderStyle=BorderStyle.FixedSingle;
			this.Shift1Label.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Shift1Label.ForeColor=System.Drawing.Color.Yellow;
			this.Shift1Label.Location=new System.Drawing.Point(440, 110);
			this.Shift1Label.Margin=new Padding(3);
			this.Shift1Label.Name="Shift1Label";
			this.Shift1Label.Size=new System.Drawing.Size(147, 27);
			this.Shift1Label.TabIndex=38;
			this.Shift1Label.Text="شیفت";
			this.Shift1Label.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//DailyProcessParametrRegForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.ClientSize=new System.Drawing.Size(604, 478);
			this.Controls.Add(this.Shift1Label);
			this.Controls.Add(this.Reserv1Label);
			this.Controls.Add(this.Local1Panel1);
			this.Controls.Add(this.Local1Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.MemBox);
			this.Controls.Add(this.Label32);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="DailyProcessParametrRegForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="پارامتر های پردازش لوحه";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Local1Panel2.ResumeLayout(false);
			this.Local1Panel2.PerformLayout();
			this.Local1Panel1.ResumeLayout(false);
			this.Local1Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		private Label Reserv1Label;
		private RichTextBox MemBox;
		private Label Label32;
		private Panel Panel1;
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
		private Label Label34;
		private Label Label23;
		private Label Label22;
		private MaskedTextBox Shift9Sobh1Box;
		private Label Label20;
		private MaskedTextBox Shift9Asr1Box;
		private Label Label19;
		private Label Label11;
		private Label Label10;
		private MaskedTextBox Shift12Shab1Box;
		private MaskedTextBox Shift12Rooz1Box;
		private Label Label21;
		private Label Label35;
		private MaskedTextBox ShiftSetadi1Box;
		private Panel Local1Panel1;
		private Label Shift1Label;
		private ComboBox LocalCombo;
		private Label Label14;
		private TextBox NameBox;
		private Label Label8;
		private ComboBox KindCombo;
		private Label Label3;
		private Button RegButton;
	}
	
}
