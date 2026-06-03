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
	public partial class DailyLeaveRegisterOpratorForm : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(DailyLeaveRegisterOpratorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5=new System.Windows.Forms.DataGridViewCellStyle();
            this.NameBox=new System.Windows.Forms.TextBox();
            this.NameButton=new System.Windows.Forms.Button();
            this.Label1=new System.Windows.Forms.Label();
            this.RegButton=new System.Windows.Forms.Button();
            this.ExitButton=new System.Windows.Forms.Button();
            this.Label7=new System.Windows.Forms.Label();
            this.KindCombo=new System.Windows.Forms.ComboBox();
            this.MonthLabel=new System.Windows.Forms.Label();
            this.Label02=new System.Windows.Forms.Label();
            this.Label03=new System.Windows.Forms.Label();
            this.Label04=new System.Windows.Forms.Label();
            this.Label05=new System.Windows.Forms.Label();
            this.Label01=new System.Windows.Forms.Label();
            this.NextMonButton=new System.Windows.Forms.Button();
            this.RevMonButton=new System.Windows.Forms.Button();
            this.Panel1=new System.Windows.Forms.Panel();
            this.Label3=new System.Windows.Forms.Label();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label2=new System.Windows.Forms.Label();
            this.Panel3=new System.Windows.Forms.Panel();
            this.Panel6=new System.Windows.Forms.Panel();
            this.Label13=new System.Windows.Forms.Label();
            this.Req9Sobh=new System.Windows.Forms.Label();
            this.Req9Asr=new System.Windows.Forms.Label();
            this.PictureBox2=new System.Windows.Forms.PictureBox();
            this.Req12Asr=new System.Windows.Forms.Label();
            this.Req12Sobh=new System.Windows.Forms.Label();
            this.Label18=new System.Windows.Forms.Label();
            this.Label16=new System.Windows.Forms.Label();
            this.Label15=new System.Windows.Forms.Label();
            this.Label14=new System.Windows.Forms.Label();
            this.Panel5=new System.Windows.Forms.Panel();
            this.Label17=new System.Windows.Forms.Label();
            this.Label21=new System.Windows.Forms.Label();
            this.Mor9Sobh=new System.Windows.Forms.Label();
            this.Mor9Asr=new System.Windows.Forms.Label();
            this.PictureBox1=new System.Windows.Forms.PictureBox();
            this.Label19=new System.Windows.Forms.Label();
            this.Label20=new System.Windows.Forms.Label();
            this.Mor12Asr=new System.Windows.Forms.Label();
            this.Mor12Sobh=new System.Windows.Forms.Label();
            this.Label22=new System.Windows.Forms.Label();
            this.Panel4=new System.Windows.Forms.Panel();
            this.LocalLabel=new System.Windows.Forms.Label();
            this.DayLabel=new System.Windows.Forms.Label();
            this.Label25=new System.Windows.Forms.Label();
            this.DateLabel=new System.Windows.Forms.Label();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGridView=new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(57, 36);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(155, 23);
            this.NameBox.TabIndex=18;
            this.NameBox.TabStop=false;
            // 
            // NameButton
            // 
            this.NameButton.AutoSizeMode=System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(27, 35);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(214, 39);
            this.Label1.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(29, 16);
            this.Label1.TabIndex=19;
            this.Label1.Text="نام:";
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(116, 9);
            this.RegButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(134, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(9, 9);
            this.ExitButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(96, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(214, 75);
            this.Label7.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(31, 16);
            this.Label7.TabIndex=25;
            this.Label7.Text="نوع:";
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Location=new System.Drawing.Point(28, 71);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(185, 24);
            this.KindCombo.Sorted=true;
            this.KindCombo.TabIndex=2;
            // 
            // MonthLabel
            // 
            this.MonthLabel.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthLabel.ForeColor=System.Drawing.Color.Black;
            this.MonthLabel.Location=new System.Drawing.Point(28, 128);
            this.MonthLabel.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthLabel.Name="MonthLabel";
            this.MonthLabel.Size=new System.Drawing.Size(212, 32);
            this.MonthLabel.TabIndex=29;
            this.MonthLabel.Text="00/00";
            this.MonthLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label02
            // 
            this.Label02.BackColor=System.Drawing.Color.Lime;
            this.Label02.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label02.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label02.Location=new System.Drawing.Point(237, 9);
            this.Label02.Margin=new System.Windows.Forms.Padding(0);
            this.Label02.Name="Label02";
            this.Label02.Size=new System.Drawing.Size(70, 25);
            this.Label02.TabIndex=36;
            this.Label02.Text="مرخصی";
            this.Label02.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label03
            // 
            this.Label03.BackColor=System.Drawing.Color.White;
            this.Label03.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label03.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label03.ForeColor=System.Drawing.Color.DarkOrange;
            this.Label03.Location=new System.Drawing.Point(161, 9);
            this.Label03.Margin=new System.Windows.Forms.Padding(0);
            this.Label03.Name="Label03";
            this.Label03.Size=new System.Drawing.Size(70, 25);
            this.Label03.TabIndex=35;
            this.Label03.Text="صبح کار";
            this.Label03.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label04
            // 
            this.Label04.BackColor=System.Drawing.Color.White;
            this.Label04.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label04.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label04.ForeColor=System.Drawing.Color.Blue;
            this.Label04.Location=new System.Drawing.Point(85, 9);
            this.Label04.Margin=new System.Windows.Forms.Padding(0);
            this.Label04.Name="Label04";
            this.Label04.Size=new System.Drawing.Size(70, 25);
            this.Label04.TabIndex=34;
            this.Label04.Text="عصر کار";
            this.Label04.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label05
            // 
            this.Label05.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Label05.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label05.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label05.Location=new System.Drawing.Point(9, 9);
            this.Label05.Margin=new System.Windows.Forms.Padding(0);
            this.Label05.Name="Label05";
            this.Label05.Size=new System.Drawing.Size(70, 25);
            this.Label05.TabIndex=33;
            this.Label05.Text="استراحت";
            this.Label05.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label01
            // 
            this.Label01.BackColor=System.Drawing.Color.Silver;
            this.Label01.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label01.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label01.Location=new System.Drawing.Point(313, 9);
            this.Label01.Margin=new System.Windows.Forms.Padding(0);
            this.Label01.Name="Label01";
            this.Label01.Size=new System.Drawing.Size(70, 25);
            this.Label01.TabIndex=31;
            this.Label01.Text="غیر مجاز";
            this.Label01.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextMonButton
            // 
            this.NextMonButton.BackColor=System.Drawing.Color.LightBlue;
            this.NextMonButton.FlatStyle=System.Windows.Forms.FlatStyle.System;
            this.NextMonButton.ForeColor=System.Drawing.Color.Blue;
            this.NextMonButton.Location=new System.Drawing.Point(28, 183);
            this.NextMonButton.Name="NextMonButton";
            this.NextMonButton.Size=new System.Drawing.Size(105, 28);
            this.NextMonButton.TabIndex=32;
            this.NextMonButton.Text="  ماه بعد  >>";
            this.NextMonButton.UseVisualStyleBackColor=false;
            this.NextMonButton.Click += new System.EventHandler(this.NextMonButton_Click);
            // 
            // RevMonButton
            // 
            this.RevMonButton.BackColor=System.Drawing.Color.Silver;
            this.RevMonButton.FlatStyle=System.Windows.Forms.FlatStyle.System;
            this.RevMonButton.ForeColor=System.Drawing.Color.Blue;
            this.RevMonButton.Location=new System.Drawing.Point(137, 183);
            this.RevMonButton.Name="RevMonButton";
            this.RevMonButton.Size=new System.Drawing.Size(105, 28);
            this.RevMonButton.TabIndex=33;
            this.RevMonButton.Text="<<  ماه قبل ";
            this.RevMonButton.UseVisualStyleBackColor=false;
            this.RevMonButton.Click += new System.EventHandler(this.RevMonButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.RevMonButton);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.NextMonButton);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.MonthLabel);
            this.Panel1.Location=new System.Drawing.Point(417, 22);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(264, 230);
            this.Panel1.TabIndex=0;
            // 
            // Label3
            // 
            this.Label3.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label3.ForeColor=System.Drawing.Color.Black;
            this.Label3.Location=new System.Drawing.Point(17, 99);
            this.Label3.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(229, 29);
            this.Label3.TabIndex=34;
            this.Label3.Text="...................................................";
            this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Location=new System.Drawing.Point(417, 264);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(264, 60);
            this.Panel2.TabIndex=1;
            // 
            // Label2
            // 
            this.Label2.BackColor=System.Drawing.Color.Gray;
            this.Label2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Cursor=System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor=System.Drawing.Color.White;
            this.Label2.Location=new System.Drawing.Point(571, 11);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(100, 20);
            this.Label2.TabIndex=43;
            this.Label2.Text="مشخصات";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Label02);
            this.Panel3.Controls.Add(this.Label03);
            this.Panel3.Controls.Add(this.Label01);
            this.Panel3.Controls.Add(this.Label04);
            this.Panel3.Controls.Add(this.Label05);
            this.Panel3.Location=new System.Drawing.Point(8, 22);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(395, 42);
            this.Panel3.TabIndex=44;
            // 
            // Panel6
            // 
            this.Panel6.BackColor=System.Drawing.Color.Black;
            this.Panel6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.Label13);
            this.Panel6.Controls.Add(this.Req9Sobh);
            this.Panel6.Controls.Add(this.Req9Asr);
            this.Panel6.Controls.Add(this.PictureBox2);
            this.Panel6.Controls.Add(this.Req12Asr);
            this.Panel6.Controls.Add(this.Req12Sobh);
            this.Panel6.Controls.Add(this.Label18);
            this.Panel6.Controls.Add(this.Label16);
            this.Panel6.Controls.Add(this.Label15);
            this.Panel6.Controls.Add(this.Label14);
            this.Panel6.Location=new System.Drawing.Point(210, 336);
            this.Panel6.Name="Panel6";
            this.Panel6.Size=new System.Drawing.Size(193, 160);
            this.Panel6.TabIndex=49;
            // 
            // Label13
            // 
            this.Label13.BackColor=System.Drawing.Color.Transparent;
            this.Label13.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label13.ForeColor=System.Drawing.Color.White;
            this.Label13.Location=new System.Drawing.Point(76, 68);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(112, 18);
            this.Label13.TabIndex=8;
            this.Label13.Text="12 ساعته شب:";
            // 
            // Req9Sobh
            // 
            this.Req9Sobh.BackColor=System.Drawing.Color.Transparent;
            this.Req9Sobh.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Req9Sobh.ForeColor=System.Drawing.Color.Lime;
            this.Req9Sobh.Location=new System.Drawing.Point(2, 100);
            this.Req9Sobh.Name="Req9Sobh";
            this.Req9Sobh.Size=new System.Drawing.Size(80, 26);
            this.Req9Sobh.TabIndex=30;
            this.Req9Sobh.Text="23 عنوان";
            this.Req9Sobh.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Req9Asr
            // 
            this.Req9Asr.BackColor=System.Drawing.Color.Transparent;
            this.Req9Asr.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Req9Asr.ForeColor=System.Drawing.Color.Lime;
            this.Req9Asr.Location=new System.Drawing.Point(2, 126);
            this.Req9Asr.Name="Req9Asr";
            this.Req9Asr.Size=new System.Drawing.Size(80, 26);
            this.Req9Asr.TabIndex=31;
            this.Req9Asr.Text="23 عنوان";
            this.Req9Asr.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor=System.Drawing.Color.Transparent;
            this.PictureBox2.Image=((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location=new System.Drawing.Point(14, 1);
            this.PictureBox2.Name="PictureBox2";
            this.PictureBox2.Size=new System.Drawing.Size(162, 41);
            this.PictureBox2.SizeMode=System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex=23;
            this.PictureBox2.TabStop=false;
            // 
            // Req12Asr
            // 
            this.Req12Asr.BackColor=System.Drawing.Color.Transparent;
            this.Req12Asr.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Req12Asr.ForeColor=System.Drawing.Color.Lime;
            this.Req12Asr.Location=new System.Drawing.Point(2, 64);
            this.Req12Asr.Name="Req12Asr";
            this.Req12Asr.Size=new System.Drawing.Size(80, 26);
            this.Req12Asr.TabIndex=16;
            this.Req12Asr.Text="23 عنوان";
            this.Req12Asr.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Req12Sobh
            // 
            this.Req12Sobh.BackColor=System.Drawing.Color.Transparent;
            this.Req12Sobh.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Req12Sobh.ForeColor=System.Drawing.Color.Lime;
            this.Req12Sobh.Location=new System.Drawing.Point(2, 39);
            this.Req12Sobh.Name="Req12Sobh";
            this.Req12Sobh.Size=new System.Drawing.Size(80, 26);
            this.Req12Sobh.TabIndex=15;
            this.Req12Sobh.Text="23 عنوان";
            this.Req12Sobh.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.AutoSize=true;
            this.Label18.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label18.ForeColor=System.Drawing.Color.Gray;
            this.Label18.Location=new System.Drawing.Point(4, 86);
            this.Label18.Name="Label18";
            this.Label18.Size=new System.Drawing.Size(183, 18);
            this.Label18.TabIndex=27;
            this.Label18.Text="-----------------------------------";
            // 
            // Label16
            // 
            this.Label16.BackColor=System.Drawing.Color.Transparent;
            this.Label16.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label16.ForeColor=System.Drawing.Color.White;
            this.Label16.Location=new System.Drawing.Point(76, 104);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(112, 18);
            this.Label16.TabIndex=28;
            this.Label16.Text="9 ساعته صبح:";
            // 
            // Label15
            // 
            this.Label15.BackColor=System.Drawing.Color.Transparent;
            this.Label15.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label15.ForeColor=System.Drawing.Color.White;
            this.Label15.Location=new System.Drawing.Point(76, 130);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(112, 18);
            this.Label15.TabIndex=29;
            this.Label15.Text="9 ساعته عصر:";
            // 
            // Label14
            // 
            this.Label14.BackColor=System.Drawing.Color.Transparent;
            this.Label14.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label14.ForeColor=System.Drawing.Color.White;
            this.Label14.Location=new System.Drawing.Point(76, 43);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(112, 18);
            this.Label14.TabIndex=7;
            this.Label14.Text="12 ساعته روز:";
            // 
            // Panel5
            // 
            this.Panel5.BackColor=System.Drawing.Color.Black;
            this.Panel5.Controls.Add(this.Label17);
            this.Panel5.Controls.Add(this.Label21);
            this.Panel5.Controls.Add(this.Mor9Sobh);
            this.Panel5.Controls.Add(this.Mor9Asr);
            this.Panel5.Controls.Add(this.PictureBox1);
            this.Panel5.Controls.Add(this.Label19);
            this.Panel5.Controls.Add(this.Label20);
            this.Panel5.Controls.Add(this.Mor12Asr);
            this.Panel5.Controls.Add(this.Mor12Sobh);
            this.Panel5.Controls.Add(this.Label22);
            this.Panel5.Location=new System.Drawing.Point(8, 336);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(193, 160);
            this.Panel5.TabIndex=48;
            // 
            // Label17
            // 
            this.Label17.BackColor=System.Drawing.Color.Transparent;
            this.Label17.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label17.ForeColor=System.Drawing.Color.White;
            this.Label17.Location=new System.Drawing.Point(69, 130);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(112, 18);
            this.Label17.TabIndex=28;
            this.Label17.Text="9 ساعته عصر:";
            // 
            // Label21
            // 
            this.Label21.BackColor=System.Drawing.Color.Transparent;
            this.Label21.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label21.ForeColor=System.Drawing.Color.White;
            this.Label21.Location=new System.Drawing.Point(69, 104);
            this.Label21.Name="Label21";
            this.Label21.Size=new System.Drawing.Size(112, 18);
            this.Label21.TabIndex=27;
            this.Label21.Text="9 ساعته صبح:";
            // 
            // Mor9Sobh
            // 
            this.Mor9Sobh.BackColor=System.Drawing.Color.Transparent;
            this.Mor9Sobh.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Mor9Sobh.ForeColor=System.Drawing.Color.Yellow;
            this.Mor9Sobh.Location=new System.Drawing.Point(6, 101);
            this.Mor9Sobh.Name="Mor9Sobh";
            this.Mor9Sobh.Size=new System.Drawing.Size(60, 24);
            this.Mor9Sobh.TabIndex=29;
            this.Mor9Sobh.Text="23 نفر";
            this.Mor9Sobh.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mor9Asr
            // 
            this.Mor9Asr.BackColor=System.Drawing.Color.Transparent;
            this.Mor9Asr.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Mor9Asr.ForeColor=System.Drawing.Color.Yellow;
            this.Mor9Asr.Location=new System.Drawing.Point(6, 127);
            this.Mor9Asr.Name="Mor9Asr";
            this.Mor9Asr.Size=new System.Drawing.Size(60, 24);
            this.Mor9Asr.TabIndex=30;
            this.Mor9Asr.Text="23 نفر";
            this.Mor9Asr.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor=System.Drawing.Color.Transparent;
            this.PictureBox1.Image=((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location=new System.Drawing.Point(31, 1);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(133, 41);
            this.PictureBox1.TabIndex=22;
            this.PictureBox1.TabStop=false;
            // 
            // Label19
            // 
            this.Label19.BackColor=System.Drawing.Color.Transparent;
            this.Label19.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label19.ForeColor=System.Drawing.Color.White;
            this.Label19.Location=new System.Drawing.Point(69, 43);
            this.Label19.Name="Label19";
            this.Label19.Size=new System.Drawing.Size(112, 18);
            this.Label19.TabIndex=2;
            this.Label19.Text="12 ساعته روز:";
            // 
            // Label20
            // 
            this.Label20.BackColor=System.Drawing.Color.Transparent;
            this.Label20.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label20.ForeColor=System.Drawing.Color.White;
            this.Label20.Location=new System.Drawing.Point(69, 68);
            this.Label20.Name="Label20";
            this.Label20.Size=new System.Drawing.Size(112, 18);
            this.Label20.TabIndex=3;
            this.Label20.Text="12 ساعته شب:";
            // 
            // Mor12Asr
            // 
            this.Mor12Asr.BackColor=System.Drawing.Color.Transparent;
            this.Mor12Asr.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Mor12Asr.ForeColor=System.Drawing.Color.Yellow;
            this.Mor12Asr.Location=new System.Drawing.Point(6, 65);
            this.Mor12Asr.Name="Mor12Asr";
            this.Mor12Asr.Size=new System.Drawing.Size(60, 24);
            this.Mor12Asr.TabIndex=12;
            this.Mor12Asr.Text="23 نفر";
            this.Mor12Asr.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mor12Sobh
            // 
            this.Mor12Sobh.BackColor=System.Drawing.Color.Transparent;
            this.Mor12Sobh.Font=new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Mor12Sobh.ForeColor=System.Drawing.Color.Yellow;
            this.Mor12Sobh.Location=new System.Drawing.Point(6, 40);
            this.Mor12Sobh.Name="Mor12Sobh";
            this.Mor12Sobh.Size=new System.Drawing.Size(60, 24);
            this.Mor12Sobh.TabIndex=11;
            this.Mor12Sobh.Text="23 نفر";
            this.Mor12Sobh.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label22
            // 
            this.Label22.AutoSize=true;
            this.Label22.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label22.ForeColor=System.Drawing.Color.Gray;
            this.Label22.Location=new System.Drawing.Point(5, 86);
            this.Label22.Name="Label22";
            this.Label22.Size=new System.Drawing.Size(173, 18);
            this.Label22.TabIndex=26;
            this.Label22.Text="---------------------------------";
            // 
            // Panel4
            // 
            this.Panel4.BackColor=System.Drawing.Color.LightBlue;
            this.Panel4.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.LocalLabel);
            this.Panel4.Controls.Add(this.DayLabel);
            this.Panel4.Controls.Add(this.Label25);
            this.Panel4.Controls.Add(this.DateLabel);
            this.Panel4.Location=new System.Drawing.Point(417, 336);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(264, 160);
            this.Panel4.TabIndex=49;
            // 
            // LocalLabel
            // 
            this.LocalLabel.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalLabel.Location=new System.Drawing.Point(9, 8);
            this.LocalLabel.Name="LocalLabel";
            this.LocalLabel.Size=new System.Drawing.Size(244, 22);
            this.LocalLabel.TabIndex=15;
            this.LocalLabel.Text="تهران";
            this.LocalLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayLabel
            // 
            this.DayLabel.BackColor=System.Drawing.Color.Transparent;
            this.DayLabel.Font=new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DayLabel.ForeColor=System.Drawing.Color.Black;
            this.DayLabel.Location=new System.Drawing.Point(50, 40);
            this.DayLabel.Name="DayLabel";
            this.DayLabel.Size=new System.Drawing.Size(165, 34);
            this.DayLabel.TabIndex=13;
            this.DayLabel.Text="دوشنبه";
            this.DayLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label25
            // 
            this.Label25.BackColor=System.Drawing.Color.Transparent;
            this.Label25.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label25.ForeColor=System.Drawing.Color.Black;
            this.Label25.Location=new System.Drawing.Point(51, 118);
            this.Label25.Name="Label25";
            this.Label25.Size=new System.Drawing.Size(165, 34);
            this.Label25.TabIndex=6;
            this.Label25.Text="تا این لحظه";
            this.Label25.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor=System.Drawing.Color.Transparent;
            this.DateLabel.Font=new System.Drawing.Font("B Yekan", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.ForeColor=System.Drawing.Color.Black;
            this.DateLabel.Location=new System.Drawing.Point(51, 74);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(165, 34);
            this.DateLabel.TabIndex=14;
            this.DateLabel.Text="1397/05/34";
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column7.DefaultCellStyle=dataGridViewCellStyle1;
            this.Column7.HeaderText="جمعه";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText="پنج شنبه";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText="چهار شنبه";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText="سه شنبه";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText="دو شنبه";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText="یک شنبه";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText="شنبه";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            // 
            // DateGridView
            // 
            this.DateGridView.AllowUserToAddRows=false;
            this.DateGridView.AllowUserToDeleteRows=false;
            this.DateGridView.AllowUserToOrderColumns=true;
            this.DateGridView.AllowUserToResizeColumns=false;
            this.DateGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DateGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle3;
            this.DateGridView.ColumnHeadersHeight=40;
            this.DateGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor=System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor=System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DateGridView.DefaultCellStyle=dataGridViewCellStyle4;
            this.DateGridView.EnableHeadersVisualStyles=false;
            this.DateGridView.Location=new System.Drawing.Point(8, 71);
            this.DateGridView.MultiSelect=false;
            this.DateGridView.Name="DateGridView";
            this.DateGridView.ReadOnly=true;
            this.DateGridView.RowHeadersVisible=false;
            this.DateGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor=System.Drawing.Color.White;
            dataGridViewCellStyle5.Font=new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateGridView.RowsDefaultCellStyle=dataGridViewCellStyle5;
            this.DateGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.DateGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DateGridView.Size=new System.Drawing.Size(395, 252);
            this.DateGridView.TabIndex=28;
            this.DateGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DateGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DateGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_ColumnHeaderMouseClick);
            // 
            // DailyLeaveRegisterOpratorForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(691, 501);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.DateGridView);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="DailyLeaveRegisterOpratorForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="ثبت مرخصی روزانه پرسنل";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.DailyLeaveRegisterOpratortForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.DailyLeaveRegisterOpratorForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateGridView)).EndInit();
            this.ResumeLayout(false);

		}
		private TextBox NameBox;
		private Button NameButton;
		private Label Label1;
		private Button RegButton;
		private Button ExitButton;
		private Label Label7;
		private ComboBox KindCombo;
		private Label MonthLabel;
		private Label Label04;
		private Label Label05;
		private Label Label01;
		private Label Label02;
		private Label Label03;
		private Button NextMonButton;
		private Button RevMonButton;
		private Panel Panel1;
		private Panel Panel2;
		private Label Label2;
		private Panel Panel3;
		private Label Label3;
		private Panel Panel6;
		private PictureBox PictureBox2;
		private Label Label14;
		private Label Req12Asr;
		private Label Label13;
		private Label Req12Sobh;
		private Label Label18;
		private Panel Panel5;
		private PictureBox PictureBox1;
		private Label Label19;
		private Label Label20;
		private Label Mor12Asr;
		private Label Mor12Sobh;
		private Label Label22;
		private Panel Panel4;
		private Label DayLabel;
		private Label Label25;
		private Label DateLabel;
		private Label Label17;
		private Label Label21;
		private Label Mor9Sobh;
		private Label Mor9Asr;
		private Label Req9Sobh;
		private Label Label16;
		private Label Label15;
		private Label Req9Asr;
		private Label LocalLabel;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView DateGridView;
    }
	
}
