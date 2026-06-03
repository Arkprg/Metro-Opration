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
		public partial class TerminalTripRegisterForm : BaseForm
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
			base.Load += new System.EventHandler(TerminalTripRegisterForm_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TerminalTripRegisterForm));
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.Label5=new Label();
			this.Label1=new Label();
			this.TrainNumBox=new MaskedTextBox();
			this.Label3=new Label();
			this.StartBox=new MaskedTextBox();
			this.StartBox.Leave += new System.EventHandler(this.StartBox_Leave);
			this.Label7=new Label();
			this.Name1Box=new TextBox();
			this.Name1Button=new Button();
			this.Name1Button.Click += new System.EventHandler(this.Name1Button_Click);
			this.Label2=new Label();
			this.TypeCombo=new ComboBox();
			this.Label6=new Label();
			this.Label8=new Label();
			this.Name3Button=new Button();
			this.Name3Button.Click += new System.EventHandler(this.Name3Button_Click);
			this.Name3Box=new TextBox();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.Label9=new Label();
			this.Label10=new Label();
			this.StartLocaCombo=new ComboBox();
			this.StartLocaCombo.SelectedIndexChanged += new System.EventHandler(this.StartLocaCombo_SelectedIndexChanged);
			this.EndLocaCombo=new ComboBox();
			this.EndLocaCombo.SelectedIndexChanged += new System.EventHandler(this.EndLocaCombo_SelectedIndexChanged);
			this.MemBox=new RichTextBox();
			this.Label11=new Label();
			this.Panel1=new Panel();
			this.Panel2=new Panel();
			this.CancelCheck=new CheckBox();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EndBox=new MaskedTextBox();
			this.EndBox.Leave += new System.EventHandler(this.StartBox_Leave);
			this.TimeLabel=new Label();
			this.Label13=new Label();
			this.Label4=new Label();
			this.Label12=new Label();
			this.LocalCombo=new ComboBox();
			this.Label14=new Label();
			this.Panel3=new Panel();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"ورود به خط اصلی", "خروج از خط اصلی", "عملیات مانوری"});
			this.KindCombo.Location=new System.Drawing.Point(301, 16);
			this.KindCombo.Margin=new Padding(4, 5, 4, 5);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(166, 24);
			this.KindCombo.TabIndex=0;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.ForeColor=System.Drawing.Color.Black;
			this.Label5.Location=new System.Drawing.Point(467, 20);
			this.Label5.Margin=new Padding(5, 0, 5, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(62, 16);
			this.Label5.TabIndex=53;
			this.Label5.Text="نوع اعزام:";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.ForeColor=System.Drawing.Color.Black;
			this.Label1.Location=new System.Drawing.Point(67, 124);
			this.Label1.Margin=new Padding(5, 0, 5, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(76, 16);
			this.Label1.TabIndex=53;
			this.Label1.Text="شماره قطار:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//TrainNumBox
			//
			this.TrainNumBox.Location=new System.Drawing.Point(16, 121);
			this.TrainNumBox.Mask=">A9->A9";
			this.TrainNumBox.Name="TrainNumBox";
			this.TrainNumBox.Size=new System.Drawing.Size(51, 23);
			this.TrainNumBox.TabIndex=8;
			this.TrainNumBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.Location=new System.Drawing.Point(465, 22);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(74, 16);
			this.Label3.TabIndex=57;
			this.Label3.Text="تاریخ  اعزام:";
			//
			//StartBox
			//
			this.StartBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.StartBox.Location=new System.Drawing.Point(414, 121);
			this.StartBox.Mask="00:00";
			this.StartBox.Name="StartBox";
			this.StartBox.Size=new System.Drawing.Size(51, 23);
			this.StartBox.TabIndex=6;
			this.StartBox.TextAlign=HorizontalAlignment.Center;
			this.StartBox.ValidatingType=typeof(DateTime);
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label7.Location=new System.Drawing.Point(198, 20);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(82, 16);
			this.Label7.TabIndex=59;
			this.Label7.Text="وضعیت اعزام:";
			//
			//Name1Box
			//
			this.Name1Box.BackColor=System.Drawing.SystemColors.Window;
			this.Name1Box.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Name1Box.Location=new System.Drawing.Point(328, 53);
			this.Name1Box.Name="Name1Box";
			this.Name1Box.ReadOnly=true;
			this.Name1Box.Size=new System.Drawing.Size(137, 23);
			this.Name1Box.TabIndex=62;
			this.Name1Box.TabStop=false;
			//
			//Name1Button
			//
			this.Name1Button.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Name1Button.Image=(System.Drawing.Image) (resources.GetObject("Name1Button.Image"));
			this.Name1Button.Location=new System.Drawing.Point(299, 52);
			this.Name1Button.Name="Name1Button";
			this.Name1Button.Size=new System.Drawing.Size(30, 25);
			this.Name1Button.TabIndex=2;
			this.Name1Button.UseVisualStyleBackColor=true;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label2.Location=new System.Drawing.Point(465, 56);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(83, 16);
			this.Label2.TabIndex=61;
			this.Label2.Text="راهبر Master:";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TypeCombo
			//
			this.TypeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TypeCombo.FormattingEnabled=true;
			this.TypeCombo.Location=new System.Drawing.Point(32, 16);
			this.TypeCombo.Margin=new Padding(4, 5, 4, 5);
			this.TypeCombo.Name="TypeCombo";
			this.TypeCombo.Size=new System.Drawing.Size(166, 24);
			this.TypeCombo.TabIndex=1;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label6.Location=new System.Drawing.Point(465, 124);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(85, 16);
			this.Label6.TabIndex=64;
			this.Label6.Text="ساعت شروع:";
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.BackColor=System.Drawing.Color.Transparent;
			this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label8.Location=new System.Drawing.Point(465, 90);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(79, 16);
			this.Label8.TabIndex=61;
			this.Label8.Text="راهبر  Slave:";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Name3Button
			//
			this.Name3Button.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Name3Button.Image=(System.Drawing.Image) (resources.GetObject("Name3Button.Image"));
			this.Name3Button.Location=new System.Drawing.Point(299, 86);
			this.Name3Button.Name="Name3Button";
			this.Name3Button.Size=new System.Drawing.Size(30, 25);
			this.Name3Button.TabIndex=3;
			this.Name3Button.UseVisualStyleBackColor=true;
			//
			//Name3Box
			//
			this.Name3Box.BackColor=System.Drawing.SystemColors.Window;
			this.Name3Box.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Name3Box.Location=new System.Drawing.Point(328, 87);
			this.Name3Box.Name="Name3Box";
			this.Name3Box.ReadOnly=true;
			this.Name3Box.Size=new System.Drawing.Size(137, 23);
			this.Name3Box.TabIndex=62;
			this.Name3Box.TabStop=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=(System.Drawing.Image) (resources.GetObject("RegButton.BackgroundImage"));
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			this.RegButton.DialogResult=DialogResult.None;
			this.RegButton.Location=new System.Drawing.Point(306, 13);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(235, 34);
			this.RegButton.TabIndex=11;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=(System.Drawing.Image) (resources.GetObject("ExitButton.BackgroundImage"));
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(27, 13);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(148, 34);
			this.ExitButton.TabIndex=12;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label9.Location=new System.Drawing.Point(206, 56);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(71, 16);
			this.Label9.TabIndex=61;
			this.Label9.Text="مبدا حرکت:";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label10.Location=new System.Drawing.Point(206, 90);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(80, 16);
			this.Label10.TabIndex=61;
			this.Label10.Text="مقصد حرکت:";
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//StartLocaCombo
			//
			this.StartLocaCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.StartLocaCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.StartLocaCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.StartLocaCombo.FormattingEnabled=true;
			this.StartLocaCombo.Location=new System.Drawing.Point(16, 52);
			this.StartLocaCombo.Margin=new Padding(4, 5, 4, 5);
			this.StartLocaCombo.MaxLength=50;
			this.StartLocaCombo.Name="StartLocaCombo";
			this.StartLocaCombo.Size=new System.Drawing.Size(190, 24);
			this.StartLocaCombo.TabIndex=4;
			//
			//EndLocaCombo
			//
			this.EndLocaCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.EndLocaCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.EndLocaCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.EndLocaCombo.FormattingEnabled=true;
			this.EndLocaCombo.Location=new System.Drawing.Point(16, 86);
			this.EndLocaCombo.Margin=new Padding(4, 5, 4, 5);
			this.EndLocaCombo.MaxLength=50;
			this.EndLocaCombo.Name="EndLocaCombo";
			this.EndLocaCombo.Size=new System.Drawing.Size(190, 24);
			this.EndLocaCombo.TabIndex=5;
			//
			//MemBox
			//
			this.MemBox.Location=new System.Drawing.Point(16, 211);
			this.MemBox.MaxLength=250;
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(525, 60);
			this.MemBox.TabIndex=10;
			this.MemBox.Text="";
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.BackColor=System.Drawing.Color.Transparent;
			this.Label11.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label11.Location=new System.Drawing.Point(473, 191);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(62, 16);
			this.Label11.TabIndex=61;
			this.Label11.Text="توضیحات:";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.TypeCombo);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Location=new System.Drawing.Point(11, 22);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(568, 55);
			this.Panel1.TabIndex=0;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.CancelCheck);
			this.Panel2.Controls.Add(this.PersianCalendar);
			this.Panel2.Controls.Add(this.MemBox);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.TrainNumBox);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.Name1Box);
			this.Panel2.Controls.Add(this.EndBox);
			this.Panel2.Controls.Add(this.StartBox);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.EndLocaCombo);
			this.Panel2.Controls.Add(this.TimeLabel);
			this.Panel2.Controls.Add(this.Label13);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.Label12);
			this.Panel2.Controls.Add(this.LocalCombo);
			this.Panel2.Controls.Add(this.StartLocaCombo);
			this.Panel2.Controls.Add(this.Label14);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.Name3Box);
			this.Panel2.Controls.Add(this.Label11);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label10);
			this.Panel2.Controls.Add(this.Name1Button);
			this.Panel2.Controls.Add(this.Name3Button);
			this.Panel2.Location=new System.Drawing.Point(11, 89);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(568, 291);
			this.Panel2.TabIndex=1;
			//
			//CancelCheck
			//
			this.CancelCheck.AutoSize=true;
			this.CancelCheck.ForeColor=System.Drawing.Color.Black;
			this.CancelCheck.Location=new System.Drawing.Point(46, 170);
			this.CancelCheck.Name="CancelCheck";
			this.CancelCheck.Size=new System.Drawing.Size(129, 20);
			this.CancelCheck.TabIndex=9;
			this.CancelCheck.Text="حرکت کنسل گردید";
			this.CancelCheck.UseVisualStyleBackColor=true;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(328, 19);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(137, 23);
			this.PersianCalendar.TabIndex=0;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//EndBox
			//
			this.EndBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.EndBox.Location=new System.Drawing.Point(155, 121);
			this.EndBox.Mask="00:00";
			this.EndBox.Name="EndBox";
			this.EndBox.Size=new System.Drawing.Size(51, 23);
			this.EndBox.TabIndex=7;
			this.EndBox.TextAlign=HorizontalAlignment.Center;
			this.EndBox.ValidatingType=typeof(DateTime);
			//
			//TimeLabel
			//
			this.TimeLabel.AutoSize=true;
			this.TimeLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeLabel.Location=new System.Drawing.Point(423, 160);
			this.TimeLabel.Name="TimeLabel";
			this.TimeLabel.Size=new System.Drawing.Size(45, 16);
			this.TimeLabel.TabIndex=64;
			this.TimeLabel.Text="00:00";
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label13.Location=new System.Drawing.Point(466, 160);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(67, 16);
			this.Label13.TabIndex=64;
			this.Label13.Text="مدت زمان:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(298, 124);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(119, 16);
			this.Label4.TabIndex=64;
			this.Label4.Text="(طبق جدول حرکتی)";
			this.Label4.Visible=false;
			//
			//Label12
			//
			this.Label12.AutoSize=true;
			this.Label12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label12.Location=new System.Drawing.Point(206, 124);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(79, 16);
			this.Label12.TabIndex=64;
			this.Label12.Text="ساعت پایان:";
			//
			//LocalCombo
			//
			this.LocalCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Items.AddRange(new object[] {"پایانه تهران", "پایانه مهرشهر"});
			this.LocalCombo.Location=new System.Drawing.Point(16, 18);
			this.LocalCombo.Margin=new Padding(4, 5, 4, 5);
			this.LocalCombo.MaxLength=50;
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(190, 24);
			this.LocalCombo.TabIndex=1;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.BackColor=System.Drawing.Color.Transparent;
			this.Label14.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label14.Location=new System.Drawing.Point(206, 22);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(76, 16);
			this.Label14.TabIndex=61;
			this.Label14.Text="پایانه حرکت:";
			this.Label14.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Location=new System.Drawing.Point(11, 392);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(568, 62);
			this.Panel3.TabIndex=2;
			//
			//TerminalTripRegisterForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(593, 465);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalTripRegisterForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت حرکت پایانه";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		private ComboBox KindCombo;
		private Label Label5;
		private Label Label1;
		private MaskedTextBox TrainNumBox;
		private Label Label3;
		private MaskedTextBox StartBox;
		private Label Label7;
		private TextBox Name1Box;
		private Button Name1Button;
		private Label Label2;
		private ComboBox TypeCombo;
		private Label Label6;
		private Label Label8;
		private Button Name3Button;
		private TextBox Name3Box;
		private Button RegButton;
		private Button ExitButton;
		private Label Label9;
		private Label Label10;
		private ComboBox StartLocaCombo;
		private ComboBox EndLocaCombo;
		private RichTextBox MemBox;
		private Label Label11;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private MaskedTextBox EndBox;
		private Label Label12;
		private Label TimeLabel;
		private Label Label13;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private CheckBox CancelCheck;
		private Label Label4;
		private ComboBox LocalCombo;
		private Label Label14;
	}
	
}
