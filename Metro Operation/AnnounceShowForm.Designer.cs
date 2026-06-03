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
	partial class AnnounceShowForm : BaseForm
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
            this.Panel3=new System.Windows.Forms.Panel();
            this.ExitButton=new System.Windows.Forms.Button();
            this.RegButton=new System.Windows.Forms.Button();
            this.Panel1=new System.Windows.Forms.Panel();
            this.WebBrowser1=new System.Windows.Forms.WebBrowser();
            this.Panel2=new System.Windows.Forms.Panel();
            this.RegLabel=new System.Windows.Forms.Label();
            this.Label10=new System.Windows.Forms.Label();
            this.LocalLabel=new System.Windows.Forms.Label();
            this.DateLabel=new System.Windows.Forms.Label();
            this.ShiftNameLabel=new System.Windows.Forms.Label();
            this.KindLabel=new System.Windows.Forms.Label();
            this.PostLabel=new System.Windows.Forms.Label();
            this.ShiftTimeLabel=new System.Windows.Forms.Label();
            this.LevelLabel=new System.Windows.Forms.Label();
            this.TitrLabel=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label3=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.TabControl1=new System.Windows.Forms.TabControl();
            this.TabPage1=new System.Windows.Forms.TabPage();
            this.TabPage2=new System.Windows.Forms.TabPage();
            this.Panel4=new System.Windows.Forms.Panel();
            this.WebBrowser2=new System.Windows.Forms.WebBrowser();
            this.Panel6=new System.Windows.Forms.Panel();
            this.PrevNotifiButton=new System.Windows.Forms.Button();
            this.NextNotifiButton=new System.Windows.Forms.Button();
            this.Panel5=new System.Windows.Forms.Panel();
            this.RegLabel2=new System.Windows.Forms.Label();
            this.Label11=new System.Windows.Forms.Label();
            this.LocalLabel2=new System.Windows.Forms.Label();
            this.DateLabel2=new System.Windows.Forms.Label();
            this.ShiftNameLabel2=new System.Windows.Forms.Label();
            this.KindLabel2=new System.Windows.Forms.Label();
            this.PostLabel2=new System.Windows.Forms.Label();
            this.ShiftTimeLabel2=new System.Windows.Forms.Label();
            this.LevelLabel2=new System.Windows.Forms.Label();
            this.TitrLabel2=new System.Windows.Forms.Label();
            this.Label20=new System.Windows.Forms.Label();
            this.Label21=new System.Windows.Forms.Label();
            this.Label22=new System.Windows.Forms.Label();
            this.Label23=new System.Windows.Forms.Label();
            this.Label24=new System.Windows.Forms.Label();
            this.Label25=new System.Windows.Forms.Label();
            this.Label26=new System.Windows.Forms.Label();
            this.Label27=new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Location=new System.Drawing.Point(648, 366);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(270, 70);
            this.Panel3.TabIndex=81;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(13, 17);
            this.ExitButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(80, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="     انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Enabled=false;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(106, 17);
            this.RegButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(152, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="مطالعه شد";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.WebBrowser1);
            this.Panel1.Location=new System.Drawing.Point(2, 2);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(641, 438);
            this.Panel1.TabIndex=82;
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location=new System.Drawing.Point(6, 6);
            this.WebBrowser1.MinimumSize=new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name="WebBrowser1";
            this.WebBrowser1.Size=new System.Drawing.Size(629, 427);
            this.WebBrowser1.TabIndex=3;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.RegLabel);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.LocalLabel);
            this.Panel2.Controls.Add(this.DateLabel);
            this.Panel2.Controls.Add(this.ShiftNameLabel);
            this.Panel2.Controls.Add(this.KindLabel);
            this.Panel2.Controls.Add(this.PostLabel);
            this.Panel2.Controls.Add(this.ShiftTimeLabel);
            this.Panel2.Controls.Add(this.LevelLabel);
            this.Panel2.Controls.Add(this.TitrLabel);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Location=new System.Drawing.Point(648, 6);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(270, 351);
            this.Panel2.TabIndex=96;
            // 
            // RegLabel
            // 
            this.RegLabel.BackColor=System.Drawing.Color.LightBlue;
            this.RegLabel.ForeColor=System.Drawing.Color.Black;
            this.RegLabel.Location=new System.Drawing.Point(3, 290);
            this.RegLabel.Name="RegLabel";
            this.RegLabel.Size=new System.Drawing.Size(169, 25);
            this.RegLabel.TabIndex=103;
            this.RegLabel.Text="ثبت کننده:";
            this.RegLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.AutoSize=true;
            this.Label10.ForeColor=System.Drawing.Color.Navy;
            this.Label10.Location=new System.Drawing.Point(170, 294);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(67, 16);
            this.Label10.TabIndex=102;
            this.Label10.Text="ثبت کننده:";
            // 
            // LocalLabel
            // 
            this.LocalLabel.BackColor=System.Drawing.Color.LightBlue;
            this.LocalLabel.ForeColor=System.Drawing.Color.Black;
            this.LocalLabel.Location=new System.Drawing.Point(3, 154);
            this.LocalLabel.Name="LocalLabel";
            this.LocalLabel.Size=new System.Drawing.Size(169, 25);
            this.LocalLabel.TabIndex=101;
            this.LocalLabel.Text="مبداء:";
            this.LocalLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor=System.Drawing.Color.LightBlue;
            this.DateLabel.ForeColor=System.Drawing.Color.Black;
            this.DateLabel.Location=new System.Drawing.Point(3, 256);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(169, 25);
            this.DateLabel.TabIndex=94;
            this.DateLabel.Text="تاریخ شروع نمایش :";
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShiftNameLabel
            // 
            this.ShiftNameLabel.BackColor=System.Drawing.Color.LightBlue;
            this.ShiftNameLabel.ForeColor=System.Drawing.Color.Black;
            this.ShiftNameLabel.Location=new System.Drawing.Point(3, 188);
            this.ShiftNameLabel.Name="ShiftNameLabel";
            this.ShiftNameLabel.Size=new System.Drawing.Size(169, 25);
            this.ShiftNameLabel.TabIndex=100;
            this.ShiftNameLabel.Text="نام شیفت:";
            this.ShiftNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KindLabel
            // 
            this.KindLabel.BackColor=System.Drawing.Color.LightBlue;
            this.KindLabel.ForeColor=System.Drawing.Color.Black;
            this.KindLabel.Location=new System.Drawing.Point(3, 52);
            this.KindLabel.Name="KindLabel";
            this.KindLabel.Size=new System.Drawing.Size(169, 25);
            this.KindLabel.TabIndex=95;
            this.KindLabel.Text="نوع اطلاعیه:";
            this.KindLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PostLabel
            // 
            this.PostLabel.BackColor=System.Drawing.Color.LightBlue;
            this.PostLabel.ForeColor=System.Drawing.Color.Black;
            this.PostLabel.Location=new System.Drawing.Point(3, 86);
            this.PostLabel.Name="PostLabel";
            this.PostLabel.Size=new System.Drawing.Size(169, 25);
            this.PostLabel.TabIndex=96;
            this.PostLabel.Text="نمایش برای:";
            this.PostLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShiftTimeLabel
            // 
            this.ShiftTimeLabel.BackColor=System.Drawing.Color.LightBlue;
            this.ShiftTimeLabel.ForeColor=System.Drawing.Color.Black;
            this.ShiftTimeLabel.Location=new System.Drawing.Point(3, 120);
            this.ShiftTimeLabel.Name="ShiftTimeLabel";
            this.ShiftTimeLabel.Size=new System.Drawing.Size(169, 25);
            this.ShiftTimeLabel.TabIndex=99;
            this.ShiftTimeLabel.Text="نوع شیفت:";
            this.ShiftTimeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor=System.Drawing.Color.LightBlue;
            this.LevelLabel.ForeColor=System.Drawing.Color.Black;
            this.LevelLabel.Location=new System.Drawing.Point(3, 222);
            this.LevelLabel.Name="LevelLabel";
            this.LevelLabel.Size=new System.Drawing.Size(169, 25);
            this.LevelLabel.TabIndex=97;
            this.LevelLabel.Text="اولویت نمایش:";
            this.LevelLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitrLabel
            // 
            this.TitrLabel.BackColor=System.Drawing.Color.LightBlue;
            this.TitrLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrLabel.ForeColor=System.Drawing.Color.Black;
            this.TitrLabel.Location=new System.Drawing.Point(3, 17);
            this.TitrLabel.Name="TitrLabel";
            this.TitrLabel.Size=new System.Drawing.Size(169, 25);
            this.TitrLabel.TabIndex=98;
            this.TitrLabel.Text="عنوان اطلاعیه:";
            this.TitrLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.ForeColor=System.Drawing.Color.Navy;
            this.Label8.Location=new System.Drawing.Point(170, 158);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(40, 16);
            this.Label8.TabIndex=93;
            this.Label8.Text="مبداء:";
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.ForeColor=System.Drawing.Color.Navy;
            this.Label4.Location=new System.Drawing.Point(170, 260);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(84, 16);
            this.Label4.TabIndex=80;
            this.Label4.Text="تاریخ نمایش :";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.ForeColor=System.Drawing.Color.Navy;
            this.Label7.Location=new System.Drawing.Point(170, 192);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(70, 16);
            this.Label7.TabIndex=91;
            this.Label7.Text="نام شیفت:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.ForeColor=System.Drawing.Color.Navy;
            this.Label1.Location=new System.Drawing.Point(170, 56);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(76, 16);
            this.Label1.TabIndex=81;
            this.Label1.Text="نوع اطلاعیه:";
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.ForeColor=System.Drawing.Color.Navy;
            this.Label2.Location=new System.Drawing.Point(170, 90);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(77, 16);
            this.Label2.TabIndex=82;
            this.Label2.Text="نمایش برای:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.ForeColor=System.Drawing.Color.Navy;
            this.Label6.Location=new System.Drawing.Point(170, 124);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(72, 16);
            this.Label6.TabIndex=89;
            this.Label6.Text="نوع شیفت:";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.ForeColor=System.Drawing.Color.Navy;
            this.Label3.Location=new System.Drawing.Point(170, 226);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(88, 16);
            this.Label3.TabIndex=83;
            this.Label3.Text="اولویت نمایش:";
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.ForeColor=System.Drawing.Color.Navy;
            this.Label5.Location=new System.Drawing.Point(170, 21);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(89, 16);
            this.Label5.TabIndex=87;
            this.Label5.Text="عنوان اطلاعیه:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock=System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.ItemSize=new System.Drawing.Size(10, 25);
            this.TabControl1.Location=new System.Drawing.Point(0, 0);
            this.TabControl1.Name="TabControl1";
            this.TabControl1.Padding=new System.Drawing.Point(35, 3);
            this.TabControl1.RightToLeftLayout=true;
            this.TabControl1.SelectedIndex=0;
            this.TabControl1.Size=new System.Drawing.Size(932, 475);
            this.TabControl1.TabIndex=97;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Panel1);
            this.TabPage1.Controls.Add(this.Panel2);
            this.TabPage1.Controls.Add(this.Panel3);
            this.TabPage1.Location=new System.Drawing.Point(4, 29);
            this.TabPage1.Name="TabPage1";
            this.TabPage1.Padding=new System.Windows.Forms.Padding(3);
            this.TabPage1.Size=new System.Drawing.Size(924, 442);
            this.TabPage1.TabIndex=0;
            this.TabPage1.Text="جدید";
            this.TabPage1.UseVisualStyleBackColor=true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Panel4);
            this.TabPage2.Controls.Add(this.Panel6);
            this.TabPage2.Controls.Add(this.Panel5);
            this.TabPage2.Location=new System.Drawing.Point(4, 29);
            this.TabPage2.Name="TabPage2";
            this.TabPage2.Padding=new System.Windows.Forms.Padding(3);
            this.TabPage2.Size=new System.Drawing.Size(924, 442);
            this.TabPage2.TabIndex=1;
            this.TabPage2.Text="خوانده شده";
            this.TabPage2.UseVisualStyleBackColor=true;
            // 
            // Panel4
            // 
            this.Panel4.BackColor=System.Drawing.Color.Black;
            this.Panel4.Controls.Add(this.WebBrowser2);
            this.Panel4.Location=new System.Drawing.Point(2, 2);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(641, 438);
            this.Panel4.TabIndex=98;
            // 
            // WebBrowser2
            // 
            this.WebBrowser2.Location=new System.Drawing.Point(6, 6);
            this.WebBrowser2.MinimumSize=new System.Drawing.Size(20, 20);
            this.WebBrowser2.Name="WebBrowser2";
            this.WebBrowser2.Size=new System.Drawing.Size(629, 427);
            this.WebBrowser2.TabIndex=2;
            // 
            // Panel6
            // 
            this.Panel6.BackColor=System.Drawing.Color.LightBlue;
            this.Panel6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.PrevNotifiButton);
            this.Panel6.Controls.Add(this.NextNotifiButton);
            this.Panel6.Location=new System.Drawing.Point(648, 6);
            this.Panel6.Name="Panel6";
            this.Panel6.Size=new System.Drawing.Size(270, 70);
            this.Panel6.TabIndex=0;
            // 
            // PrevNotifiButton
            // 
            this.PrevNotifiButton.Location=new System.Drawing.Point(140, 19);
            this.PrevNotifiButton.Name="PrevNotifiButton";
            this.PrevNotifiButton.Size=new System.Drawing.Size(120, 30);
            this.PrevNotifiButton.TabIndex=1;
            this.PrevNotifiButton.Text="اطلاعیه قبلی";
            this.PrevNotifiButton.UseVisualStyleBackColor=true;
            this.PrevNotifiButton.Click += new System.EventHandler(this.PrevNotifiButton_Click);
            // 
            // NextNotifiButton
            // 
            this.NextNotifiButton.Location=new System.Drawing.Point(9, 19);
            this.NextNotifiButton.Name="NextNotifiButton";
            this.NextNotifiButton.Size=new System.Drawing.Size(120, 30);
            this.NextNotifiButton.TabIndex=0;
            this.NextNotifiButton.Text="اطلاعیه بعدی";
            this.NextNotifiButton.UseVisualStyleBackColor=true;
            this.NextNotifiButton.Click += new System.EventHandler(this.NextNotifiButton_Click);
            // 
            // Panel5
            // 
            this.Panel5.BackColor=System.Drawing.Color.LightBlue;
            this.Panel5.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.RegLabel2);
            this.Panel5.Controls.Add(this.Label11);
            this.Panel5.Controls.Add(this.LocalLabel2);
            this.Panel5.Controls.Add(this.DateLabel2);
            this.Panel5.Controls.Add(this.ShiftNameLabel2);
            this.Panel5.Controls.Add(this.KindLabel2);
            this.Panel5.Controls.Add(this.PostLabel2);
            this.Panel5.Controls.Add(this.ShiftTimeLabel2);
            this.Panel5.Controls.Add(this.LevelLabel2);
            this.Panel5.Controls.Add(this.TitrLabel2);
            this.Panel5.Controls.Add(this.Label20);
            this.Panel5.Controls.Add(this.Label21);
            this.Panel5.Controls.Add(this.Label22);
            this.Panel5.Controls.Add(this.Label23);
            this.Panel5.Controls.Add(this.Label24);
            this.Panel5.Controls.Add(this.Label25);
            this.Panel5.Controls.Add(this.Label26);
            this.Panel5.Controls.Add(this.Label27);
            this.Panel5.Location=new System.Drawing.Point(648, 85);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(270, 351);
            this.Panel5.TabIndex=99;
            // 
            // RegLabel2
            // 
            this.RegLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.RegLabel2.ForeColor=System.Drawing.Color.Black;
            this.RegLabel2.Location=new System.Drawing.Point(3, 289);
            this.RegLabel2.Name="RegLabel2";
            this.RegLabel2.Size=new System.Drawing.Size(169, 25);
            this.RegLabel2.TabIndex=103;
            this.RegLabel2.Text="ثبت کننده:";
            // 
            // Label11
            // 
            this.Label11.AutoSize=true;
            this.Label11.ForeColor=System.Drawing.Color.Navy;
            this.Label11.Location=new System.Drawing.Point(170, 293);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(67, 16);
            this.Label11.TabIndex=102;
            this.Label11.Text="ثبت کننده:";
            // 
            // LocalLabel2
            // 
            this.LocalLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.LocalLabel2.ForeColor=System.Drawing.Color.Black;
            this.LocalLabel2.Location=new System.Drawing.Point(3, 153);
            this.LocalLabel2.Name="LocalLabel2";
            this.LocalLabel2.Size=new System.Drawing.Size(169, 25);
            this.LocalLabel2.TabIndex=101;
            this.LocalLabel2.Text="مبداء:";
            // 
            // DateLabel2
            // 
            this.DateLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.DateLabel2.ForeColor=System.Drawing.Color.Black;
            this.DateLabel2.Location=new System.Drawing.Point(3, 255);
            this.DateLabel2.Name="DateLabel2";
            this.DateLabel2.Size=new System.Drawing.Size(169, 25);
            this.DateLabel2.TabIndex=94;
            this.DateLabel2.Text="تاریخ شروع نمایش :";
            // 
            // ShiftNameLabel2
            // 
            this.ShiftNameLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.ShiftNameLabel2.ForeColor=System.Drawing.Color.Black;
            this.ShiftNameLabel2.Location=new System.Drawing.Point(3, 187);
            this.ShiftNameLabel2.Name="ShiftNameLabel2";
            this.ShiftNameLabel2.Size=new System.Drawing.Size(169, 25);
            this.ShiftNameLabel2.TabIndex=100;
            this.ShiftNameLabel2.Text="نام شیفت:";
            // 
            // KindLabel2
            // 
            this.KindLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.KindLabel2.ForeColor=System.Drawing.Color.Black;
            this.KindLabel2.Location=new System.Drawing.Point(3, 51);
            this.KindLabel2.Name="KindLabel2";
            this.KindLabel2.Size=new System.Drawing.Size(169, 25);
            this.KindLabel2.TabIndex=95;
            this.KindLabel2.Text="نوع اطلاعیه:";
            // 
            // PostLabel2
            // 
            this.PostLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.PostLabel2.ForeColor=System.Drawing.Color.Black;
            this.PostLabel2.Location=new System.Drawing.Point(3, 85);
            this.PostLabel2.Name="PostLabel2";
            this.PostLabel2.Size=new System.Drawing.Size(169, 25);
            this.PostLabel2.TabIndex=96;
            this.PostLabel2.Text="نمایش برای:";
            // 
            // ShiftTimeLabel2
            // 
            this.ShiftTimeLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.ShiftTimeLabel2.ForeColor=System.Drawing.Color.Black;
            this.ShiftTimeLabel2.Location=new System.Drawing.Point(3, 119);
            this.ShiftTimeLabel2.Name="ShiftTimeLabel2";
            this.ShiftTimeLabel2.Size=new System.Drawing.Size(169, 25);
            this.ShiftTimeLabel2.TabIndex=99;
            this.ShiftTimeLabel2.Text="نوع شیفت:";
            // 
            // LevelLabel2
            // 
            this.LevelLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.LevelLabel2.ForeColor=System.Drawing.Color.Black;
            this.LevelLabel2.Location=new System.Drawing.Point(3, 221);
            this.LevelLabel2.Name="LevelLabel2";
            this.LevelLabel2.Size=new System.Drawing.Size(169, 25);
            this.LevelLabel2.TabIndex=97;
            this.LevelLabel2.Text="اولویت نمایش:";
            // 
            // TitrLabel2
            // 
            this.TitrLabel2.BackColor=System.Drawing.Color.LightBlue;
            this.TitrLabel2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrLabel2.ForeColor=System.Drawing.Color.Black;
            this.TitrLabel2.Location=new System.Drawing.Point(3, 17);
            this.TitrLabel2.Name="TitrLabel2";
            this.TitrLabel2.Size=new System.Drawing.Size(169, 25);
            this.TitrLabel2.TabIndex=98;
            this.TitrLabel2.Text="عنوان اطلاعیه:";
            // 
            // Label20
            // 
            this.Label20.AutoSize=true;
            this.Label20.ForeColor=System.Drawing.Color.Navy;
            this.Label20.Location=new System.Drawing.Point(170, 157);
            this.Label20.Name="Label20";
            this.Label20.Size=new System.Drawing.Size(40, 16);
            this.Label20.TabIndex=93;
            this.Label20.Text="مبداء:";
            // 
            // Label21
            // 
            this.Label21.AutoSize=true;
            this.Label21.ForeColor=System.Drawing.Color.Navy;
            this.Label21.Location=new System.Drawing.Point(170, 259);
            this.Label21.Name="Label21";
            this.Label21.Size=new System.Drawing.Size(84, 16);
            this.Label21.TabIndex=80;
            this.Label21.Text="تاریخ نمایش :";
            // 
            // Label22
            // 
            this.Label22.AutoSize=true;
            this.Label22.ForeColor=System.Drawing.Color.Navy;
            this.Label22.Location=new System.Drawing.Point(170, 191);
            this.Label22.Name="Label22";
            this.Label22.Size=new System.Drawing.Size(70, 16);
            this.Label22.TabIndex=91;
            this.Label22.Text="نام شیفت:";
            // 
            // Label23
            // 
            this.Label23.AutoSize=true;
            this.Label23.ForeColor=System.Drawing.Color.Navy;
            this.Label23.Location=new System.Drawing.Point(170, 55);
            this.Label23.Name="Label23";
            this.Label23.Size=new System.Drawing.Size(76, 16);
            this.Label23.TabIndex=81;
            this.Label23.Text="نوع اطلاعیه:";
            // 
            // Label24
            // 
            this.Label24.AutoSize=true;
            this.Label24.ForeColor=System.Drawing.Color.Navy;
            this.Label24.Location=new System.Drawing.Point(170, 89);
            this.Label24.Name="Label24";
            this.Label24.Size=new System.Drawing.Size(77, 16);
            this.Label24.TabIndex=82;
            this.Label24.Text="نمایش برای:";
            // 
            // Label25
            // 
            this.Label25.AutoSize=true;
            this.Label25.ForeColor=System.Drawing.Color.Navy;
            this.Label25.Location=new System.Drawing.Point(170, 123);
            this.Label25.Name="Label25";
            this.Label25.Size=new System.Drawing.Size(72, 16);
            this.Label25.TabIndex=89;
            this.Label25.Text="نوع شیفت:";
            // 
            // Label26
            // 
            this.Label26.AutoSize=true;
            this.Label26.ForeColor=System.Drawing.Color.Navy;
            this.Label26.Location=new System.Drawing.Point(170, 225);
            this.Label26.Name="Label26";
            this.Label26.Size=new System.Drawing.Size(88, 16);
            this.Label26.TabIndex=83;
            this.Label26.Text="اولویت نمایش:";
            // 
            // Label27
            // 
            this.Label27.AutoSize=true;
            this.Label27.ForeColor=System.Drawing.Color.Navy;
            this.Label27.Location=new System.Drawing.Point(170, 21);
            this.Label27.Name="Label27";
            this.Label27.Size=new System.Drawing.Size(89, 16);
            this.Label27.TabIndex=87;
            this.Label27.Text="عنوان اطلاعیه:";
            // 
            // AnnounceShowForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(932, 475);
            this.Controls.Add(this.TabControl1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton=true;
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="AnnounceShowForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="نمایش اطلاعیه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LearningShowForm_FormClosing);
            this.Load += new System.EventHandler(this.LearningShowForm_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.ResumeLayout(false);

		}
		private Panel Panel3;
		private Button ExitButton;
		private Button RegButton;
		private Panel Panel1;
		private Panel Panel2;
		private Label LocalLabel;
		private Label DateLabel;
		private Label ShiftNameLabel;
		private Label KindLabel;
		private Label PostLabel;
		private Label ShiftTimeLabel;
		private Label LevelLabel;
		private Label TitrLabel;
		private Label Label8;
		private Label Label4;
		private Label Label7;
		private Label Label1;
		private Label Label2;
		private Label Label6;
		private Label Label3;
		private Label Label5;
		private Label RegLabel;
		private Label Label10;
		private TabControl TabControl1;
		private TabPage TabPage1;
		private TabPage TabPage2;
		private Panel Panel4;
		private Panel Panel6;
		private Button PrevNotifiButton;
		private Button NextNotifiButton;
		private Panel Panel5;
		private Label RegLabel2;
		private Label Label11;
		private Label LocalLabel2;
		private Label DateLabel2;
		private Label ShiftNameLabel2;
		private Label KindLabel2;
		private Label PostLabel2;
		private Label ShiftTimeLabel2;
		private Label LevelLabel2;
		private Label TitrLabel2;
		private Label Label20;
		private Label Label21;
		private Label Label22;
		private Label Label23;
		private Label Label24;
		private Label Label25;
		private Label Label26;
		private Label Label27;
		private WebBrowser WebBrowser2;
		private WebBrowser WebBrowser1;
	}
	
}
