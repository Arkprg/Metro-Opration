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
	public 
	partial class TerminalParametrForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			this.Local1Panel1=new Panel();
			this.All1Box=new MaskedTextBox();
			this.Label35=new Label();
			this.Gol1Box=new MaskedTextBox();
			this.KeshGol1Box=new MaskedTextBox();
			this.Label19=new Label();
			this.Label20=new Label();
			this.Mehr1Box=new MaskedTextBox();
			this.Label23=new Label();
			this.NameBox=new TextBox();
			this.Label8=new Label();
			this.KindCombo=new ComboBox();
			this.Label3=new Label();
			this.Shift1Label=new Label();
			this.Panel1=new Panel();
			this.All2Box=new MaskedTextBox();
			this.Label1=new Label();
			this.Gol2Box=new MaskedTextBox();
			this.KeshGol2Box=new MaskedTextBox();
			this.Label2=new Label();
			this.Label4=new Label();
			this.Mehr2Box=new MaskedTextBox();
			this.Label5=new Label();
			this.Label6=new Label();
			this.Panel2=new Panel();
			this.All3Box=new MaskedTextBox();
			this.Label7=new Label();
			this.Gol3Box=new MaskedTextBox();
			this.KeshGol3Box=new MaskedTextBox();
			this.Label9=new Label();
			this.Label10=new Label();
			this.Mehr3Box=new MaskedTextBox();
			this.Label11=new Label();
			this.Label12=new Label();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.TabPage2=new TabPage();
			this.PictureBox8=new PictureBox();
			this.Panel16=new Panel();
			this.Button3=new Button();
			this.Button7=new Button();
			this.Panel17=new Panel();
			this.Button8=new Button();
			this.MaskedTextBox1=new MaskedTextBox();
			this.ComboBox1=new ComboBox();
			this.ComboBox3=new ComboBox();
			this.Label17=new Label();
			this.Label37=new Label();
			this.Label38=new Label();
			this.Button9=new Button();
			this.PictureBox9=new PictureBox();
			this.Panel18=new Panel();
			this.Button10=new Button();
			this.Button11=new Button();
			this.Panel20=new Panel();
			this.Button12=new Button();
			this.MaskedTextBox3=new MaskedTextBox();
			this.ComboBox4=new ComboBox();
			this.ComboBox7=new ComboBox();
			this.Label39=new Label();
			this.Label40=new Label();
			this.Label41=new Label();
			this.Button13=new Button();
			this.Panel11=new Panel();
			this.Button2=new Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.TabPage1=new TabPage();
			this.Panel9=new Panel();
			this.Panel4=new Panel();
			this.Label30=new Label();
			this.AllTeh3Box=new MaskedTextBox();
			this.Label18=new Label();
			this.Teh3Box=new MaskedTextBox();
			this.KeshTeh3Box=new MaskedTextBox();
			this.Label22=new Label();
			this.Label36=new Label();
			this.Label34=new Label();
			this.Label33=new Label();
			this.Panel5=new Panel();
			this.AllTeh1Box=new MaskedTextBox();
			this.Label25=new Label();
			this.Teh1Box=new MaskedTextBox();
			this.KeshTeh1Box=new MaskedTextBox();
			this.Label26=new Label();
			this.Label27=new Label();
			this.Panel6=new Panel();
			this.Label21=new Label();
			this.AllTeh2Box=new MaskedTextBox();
			this.Label29=new Label();
			this.Teh2Box=new MaskedTextBox();
			this.KeshTeh2Box=new MaskedTextBox();
			this.Label31=new Label();
			this.Panel8=new Panel();
			this.Panel7=new Panel();
			this.PictureBox2=new PictureBox();
			this.PictureBox1=new PictureBox();
			this.TabControl1=new TabControl();
			this.TabPage3=new TabPage();
			this.MainPanel2=new Panel();
			this.Panel14=new Panel();
			this.MaskedTextBox2=new MaskedTextBox();
			this.ComboBox2=new ComboBox();
			this.Label13=new Label();
			this.ComboBox5=new ComboBox();
			this.Label24=new Label();
			this.ComboBox6=new ComboBox();
			this.Label28=new Label();
			this.Label32=new Label();
			this.PictureBox6=new PictureBox();
			this.Panel12=new Panel();
			this.Button4=new Button();
			this.Button5=new Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.TabPage4=new TabPage();
			this.Panel10=new Panel();
			this.Button6=new Button();
			this.Button1=new Button();
			this.DataGridView2=new DataGridView();
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn6=new DataGridViewTextBoxColumn();
			this.PictureBox3=new PictureBox();
			this.PictureBox4=new PictureBox();
			this.DataGridView1=new DataGridView();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column11=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Local1Panel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			this.Panel16.SuspendLayout();
			this.Panel17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			this.Panel18.SuspendLayout();
			this.Panel20.SuspendLayout();
			this.Panel11.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.Panel9.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Panel6.SuspendLayout();
			this.Panel8.SuspendLayout();
			this.Panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.TabControl1.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.MainPanel2.SuspendLayout();
			this.Panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox6).BeginInit();
			this.Panel12.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.Panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Local1Panel1
			//
			this.Local1Panel1.BackColor=System.Drawing.Color.Silver;
			this.Local1Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Local1Panel1.Controls.Add(this.All1Box);
			this.Local1Panel1.Controls.Add(this.Label35);
			this.Local1Panel1.Controls.Add(this.Gol1Box);
			this.Local1Panel1.Controls.Add(this.KeshGol1Box);
			this.Local1Panel1.Controls.Add(this.Label19);
			this.Local1Panel1.Controls.Add(this.Label20);
			this.Local1Panel1.Controls.Add(this.Mehr1Box);
			this.Local1Panel1.Controls.Add(this.Label23);
			this.Local1Panel1.Location=new System.Drawing.Point(450, 56);
			this.Local1Panel1.Name="Local1Panel1";
			this.Local1Panel1.Size=new System.Drawing.Size(184, 142);
			this.Local1Panel1.TabIndex=0;
			//
			//All1Box
			//
			this.All1Box.BackColor=System.Drawing.Color.White;
			this.All1Box.BorderStyle=BorderStyle.FixedSingle;
			this.All1Box.Location=new System.Drawing.Point(14, 18);
			this.All1Box.Mask="90";
			this.All1Box.Name="All1Box";
			this.All1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All1Box.Size=new System.Drawing.Size(45, 23);
			this.All1Box.TabIndex=0;
			this.All1Box.Text="0";
			this.All1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label35
			//
			this.Label35.AutoSize=true;
			this.Label35.BackColor=System.Drawing.Color.Transparent;
			this.Label35.Location=new System.Drawing.Point(62, 21);
			this.Label35.Margin=new Padding(3);
			this.Label35.Name="Label35";
			this.Label35.Size=new System.Drawing.Size(111, 16);
			this.Label35.TabIndex=35;
			this.Label35.Text="تعداد کل حرکت ها:";
			this.Label35.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Gol1Box
			//
			this.Gol1Box.BackColor=System.Drawing.Color.White;
			this.Gol1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Gol1Box.Location=new System.Drawing.Point(14, 46);
			this.Gol1Box.Mask="90";
			this.Gol1Box.Name="Gol1Box";
			this.Gol1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Gol1Box.Size=new System.Drawing.Size(45, 23);
			this.Gol1Box.TabIndex=1;
			this.Gol1Box.Text="0";
			this.Gol1Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshGol1Box
			//
			this.KeshGol1Box.BackColor=System.Drawing.Color.White;
			this.KeshGol1Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshGol1Box.Location=new System.Drawing.Point(14, 74);
			this.KeshGol1Box.Mask="90";
			this.KeshGol1Box.Name="KeshGol1Box";
			this.KeshGol1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshGol1Box.Size=new System.Drawing.Size(45, 23);
			this.KeshGol1Box.TabIndex=2;
			this.KeshGol1Box.Text="0";
			this.KeshGol1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.BackColor=System.Drawing.Color.Transparent;
			this.Label19.Location=new System.Drawing.Point(62, 49);
			this.Label19.Margin=new Padding(3);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(106, 16);
			this.Label19.TabIndex=28;
			this.Label19.Text="تعداد گروه گلشهر:";
			this.Label19.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label20
			//
			this.Label20.AutoSize=true;
			this.Label20.BackColor=System.Drawing.Color.Transparent;
			this.Label20.Location=new System.Drawing.Point(62, 77);
			this.Label20.Margin=new Padding(3);
			this.Label20.Name="Label20";
			this.Label20.Size=new System.Drawing.Size(107, 16);
			this.Label20.TabIndex=30;
			this.Label20.Text="تعداد گروه کشیک:";
			this.Label20.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Mehr1Box
			//
			this.Mehr1Box.BackColor=System.Drawing.Color.White;
			this.Mehr1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Mehr1Box.Location=new System.Drawing.Point(14, 102);
			this.Mehr1Box.Mask="90";
			this.Mehr1Box.Name="Mehr1Box";
			this.Mehr1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Mehr1Box.Size=new System.Drawing.Size(45, 23);
			this.Mehr1Box.TabIndex=3;
			this.Mehr1Box.Text="0";
			this.Mehr1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label23
			//
			this.Label23.AutoSize=true;
			this.Label23.BackColor=System.Drawing.Color.Transparent;
			this.Label23.Location=new System.Drawing.Point(62, 105);
			this.Label23.Margin=new Padding(3);
			this.Label23.Name="Label23";
			this.Label23.Size=new System.Drawing.Size(113, 16);
			this.Label23.TabIndex=28;
			this.Label23.Text="تعداد گروه مهرشهر:";
			this.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(294, 21);
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(176, 23);
			this.NameBox.TabIndex=44;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.BackColor=System.Drawing.Color.Transparent;
			this.Label8.ForeColor=System.Drawing.Color.Black;
			this.Label8.Location=new System.Drawing.Point(471, 24);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(72, 16);
			this.Label8.TabIndex=46;
			this.Label8.Text="نام پردازش:";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"روز عادی", "روز تعطیل"});
			this.KindCombo.Location=new System.Drawing.Point(568, 20);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(134, 24);
			this.KindCombo.TabIndex=43;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.ForeColor=System.Drawing.Color.Black;
			this.Label3.Location=new System.Drawing.Point(702, 24);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(74, 16);
			this.Label3.TabIndex=45;
			this.Label3.Text="نوع پردازش:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Shift1Label
			//
			this.Shift1Label.BackColor=System.Drawing.Color.Black;
			this.Shift1Label.BorderStyle=BorderStyle.FixedSingle;
			this.Shift1Label.ForeColor=System.Drawing.Color.Yellow;
			this.Shift1Label.Location=new System.Drawing.Point(487, 29);
			this.Shift1Label.Margin=new Padding(3);
			this.Shift1Label.Name="Shift1Label";
			this.Shift1Label.Size=new System.Drawing.Size(147, 27);
			this.Shift1Label.TabIndex=39;
			this.Shift1Label.Text="شیفت شب قبل";
			this.Shift1Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Silver;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.All2Box);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Gol2Box);
			this.Panel1.Controls.Add(this.KeshGol2Box);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Mehr2Box);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Location=new System.Drawing.Point(242, 56);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(184, 142);
			this.Panel1.TabIndex=1;
			//
			//All2Box
			//
			this.All2Box.BackColor=System.Drawing.Color.White;
			this.All2Box.BorderStyle=BorderStyle.FixedSingle;
			this.All2Box.Location=new System.Drawing.Point(16, 18);
			this.All2Box.Mask="90";
			this.All2Box.Name="All2Box";
			this.All2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All2Box.Size=new System.Drawing.Size(45, 23);
			this.All2Box.TabIndex=0;
			this.All2Box.Text="0";
			this.All2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.Location=new System.Drawing.Point(61, 21);
			this.Label1.Margin=new Padding(3);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(111, 16);
			this.Label1.TabIndex=35;
			this.Label1.Text="تعداد کل حرکت ها:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Gol2Box
			//
			this.Gol2Box.BackColor=System.Drawing.Color.White;
			this.Gol2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Gol2Box.Location=new System.Drawing.Point(16, 46);
			this.Gol2Box.Mask="90";
			this.Gol2Box.Name="Gol2Box";
			this.Gol2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Gol2Box.Size=new System.Drawing.Size(45, 23);
			this.Gol2Box.TabIndex=1;
			this.Gol2Box.Text="0";
			this.Gol2Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshGol2Box
			//
			this.KeshGol2Box.BackColor=System.Drawing.Color.White;
			this.KeshGol2Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshGol2Box.Location=new System.Drawing.Point(16, 74);
			this.KeshGol2Box.Mask="90";
			this.KeshGol2Box.Name="KeshGol2Box";
			this.KeshGol2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshGol2Box.Size=new System.Drawing.Size(45, 23);
			this.KeshGol2Box.TabIndex=2;
			this.KeshGol2Box.Text="0";
			this.KeshGol2Box.TextAlign=HorizontalAlignment.Center;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.Location=new System.Drawing.Point(61, 49);
			this.Label2.Margin=new Padding(3);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(106, 16);
			this.Label2.TabIndex=28;
			this.Label2.Text="تعداد گروه گلشهر:";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.BackColor=System.Drawing.Color.Transparent;
			this.Label4.Location=new System.Drawing.Point(61, 77);
			this.Label4.Margin=new Padding(3);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(107, 16);
			this.Label4.TabIndex=30;
			this.Label4.Text="تعداد گروه کشیک:";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Mehr2Box
			//
			this.Mehr2Box.BackColor=System.Drawing.Color.White;
			this.Mehr2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Mehr2Box.Location=new System.Drawing.Point(16, 102);
			this.Mehr2Box.Mask="90";
			this.Mehr2Box.Name="Mehr2Box";
			this.Mehr2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Mehr2Box.Size=new System.Drawing.Size(45, 23);
			this.Mehr2Box.TabIndex=3;
			this.Mehr2Box.Text="0";
			this.Mehr2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.Location=new System.Drawing.Point(61, 105);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(113, 16);
			this.Label5.TabIndex=28;
			this.Label5.Text="تعداد گروه مهرشهر:";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.BackColor=System.Drawing.Color.Black;
			this.Label6.BorderStyle=BorderStyle.FixedSingle;
			this.Label6.ForeColor=System.Drawing.Color.Yellow;
			this.Label6.Location=new System.Drawing.Point(279, 29);
			this.Label6.Margin=new Padding(3);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(147, 27);
			this.Label6.TabIndex=39;
			this.Label6.Text="شیفت روز کار";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Silver;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.All3Box);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Controls.Add(this.Gol3Box);
			this.Panel2.Controls.Add(this.KeshGol3Box);
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.Label10);
			this.Panel2.Controls.Add(this.Mehr3Box);
			this.Panel2.Controls.Add(this.Label11);
			this.Panel2.Location=new System.Drawing.Point(31, 56);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(184, 142);
			this.Panel2.TabIndex=2;
			//
			//All3Box
			//
			this.All3Box.BackColor=System.Drawing.Color.White;
			this.All3Box.BorderStyle=BorderStyle.FixedSingle;
			this.All3Box.Location=new System.Drawing.Point(13, 18);
			this.All3Box.Mask="90";
			this.All3Box.Name="All3Box";
			this.All3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All3Box.Size=new System.Drawing.Size(45, 23);
			this.All3Box.TabIndex=0;
			this.All3Box.Text="0";
			this.All3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.BackColor=System.Drawing.Color.Transparent;
			this.Label7.Location=new System.Drawing.Point(59, 21);
			this.Label7.Margin=new Padding(3);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(111, 16);
			this.Label7.TabIndex=35;
			this.Label7.Text="تعداد کل حرکت ها:";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Gol3Box
			//
			this.Gol3Box.BackColor=System.Drawing.Color.White;
			this.Gol3Box.BorderStyle=BorderStyle.FixedSingle;
			this.Gol3Box.Location=new System.Drawing.Point(13, 46);
			this.Gol3Box.Mask="90";
			this.Gol3Box.Name="Gol3Box";
			this.Gol3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Gol3Box.Size=new System.Drawing.Size(45, 23);
			this.Gol3Box.TabIndex=1;
			this.Gol3Box.Text="0";
			this.Gol3Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshGol3Box
			//
			this.KeshGol3Box.BackColor=System.Drawing.Color.White;
			this.KeshGol3Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshGol3Box.Location=new System.Drawing.Point(13, 74);
			this.KeshGol3Box.Mask="90";
			this.KeshGol3Box.Name="KeshGol3Box";
			this.KeshGol3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshGol3Box.Size=new System.Drawing.Size(45, 23);
			this.KeshGol3Box.TabIndex=2;
			this.KeshGol3Box.Text="0";
			this.KeshGol3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.Location=new System.Drawing.Point(59, 49);
			this.Label9.Margin=new Padding(3);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(106, 16);
			this.Label9.TabIndex=28;
			this.Label9.Text="تعداد گروه گلشهر:";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.Location=new System.Drawing.Point(59, 77);
			this.Label10.Margin=new Padding(3);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(107, 16);
			this.Label10.TabIndex=30;
			this.Label10.Text="تعداد گروه کشیک:";
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Mehr3Box
			//
			this.Mehr3Box.BackColor=System.Drawing.Color.White;
			this.Mehr3Box.BorderStyle=BorderStyle.FixedSingle;
			this.Mehr3Box.Location=new System.Drawing.Point(13, 102);
			this.Mehr3Box.Mask="90";
			this.Mehr3Box.Name="Mehr3Box";
			this.Mehr3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Mehr3Box.Size=new System.Drawing.Size(45, 23);
			this.Mehr3Box.TabIndex=3;
			this.Mehr3Box.Text="0";
			this.Mehr3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.BackColor=System.Drawing.Color.Transparent;
			this.Label11.Location=new System.Drawing.Point(59, 105);
			this.Label11.Margin=new Padding(3);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(113, 16);
			this.Label11.TabIndex=28;
			this.Label11.Text="تعداد گروه مهرشهر:";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label12
			//
			this.Label12.BackColor=System.Drawing.Color.Black;
			this.Label12.BorderStyle=BorderStyle.FixedSingle;
			this.Label12.ForeColor=System.Drawing.Color.Yellow;
			this.Label12.Location=new System.Drawing.Point(68, 29);
			this.Label12.Margin=new Padding(3);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(147, 27);
			this.Label12.TabIndex=39;
			this.Label12.Text="شیفت شب کار";
			this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=System.Drawing.Color.White;
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources._31;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.ShowButton.Location=new System.Drawing.Point(31, 15);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(142, 35);
			this.ShowButton.TabIndex=49;
			this.ShowButton.Text="مرحله بعدی";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//TabPage2
			//
			this.TabPage2.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage2.Controls.Add(this.PictureBox8);
			this.TabPage2.Controls.Add(this.Panel16);
			this.TabPage2.Controls.Add(this.PictureBox9);
			this.TabPage2.Controls.Add(this.Panel18);
			this.TabPage2.Controls.Add(this.Panel11);
			this.TabPage2.Location=new System.Drawing.Point(4, 24);
			this.TabPage2.Name="TabPage2";
			this.TabPage2.Padding=new Padding(3);
			this.TabPage2.Size=new System.Drawing.Size(1012, 632);
			this.TabPage2.TabIndex=1;
			this.TabPage2.Text="TabPage2";
			//
			//PictureBox8
			//
			this.PictureBox8.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox8.Location=new System.Drawing.Point(76, 6);
			this.PictureBox8.Name="PictureBox8";
			this.PictureBox8.Size=new System.Drawing.Size(303, 72);
			this.PictureBox8.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox8.TabIndex=72;
			this.PictureBox8.TabStop=false;
			//
			//Panel16
			//
			this.Panel16.AutoScroll=true;
			this.Panel16.BackColor=System.Drawing.Color.Transparent;
			this.Panel16.BorderStyle=BorderStyle.FixedSingle;
			this.Panel16.Controls.Add(this.Button3);
			this.Panel16.Controls.Add(this.Button7);
			this.Panel16.Controls.Add(this.Panel17);
			this.Panel16.Controls.Add(this.Button9);
			this.Panel16.Location=new System.Drawing.Point(8, 83);
			this.Panel16.Name="Panel16";
			this.Panel16.Size=new System.Drawing.Size(461, 85);
			this.Panel16.TabIndex=71;
			//
			//Button3
			//
			this.Button3.BackColor=System.Drawing.Color.Transparent;
			this.Button3.Image=global::Metro_Operation.Properties.Resources._3;
			this.Button3.BackgroundImageLayout=ImageLayout.Center;
			this.Button3.FlatAppearance.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Button3.FlatAppearance.BorderSize=0;
			this.Button3.FlatStyle=FlatStyle.Popup;
			this.Button3.Location=new System.Drawing.Point(43, 11);
			this.Button3.Name="Button3";
			this.Button3.Size=new System.Drawing.Size(24, 22);
			this.Button3.TabIndex=50;
			this.Button3.UseVisualStyleBackColor=true;
			//
			//Button7
			//
			this.Button7.BackColor=System.Drawing.Color.Transparent;
			this.Button7.Image=global::Metro_Operation.Properties.Resources.up;
			this.Button7.BackgroundImageLayout=ImageLayout.Center;
			this.Button7.FlatAppearance.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Button7.FlatAppearance.BorderSize=0;
			this.Button7.FlatStyle=FlatStyle.Popup;
			this.Button7.Location=new System.Drawing.Point(13, 11);
			this.Button7.Name="Button7";
			this.Button7.Size=new System.Drawing.Size(24, 22);
			this.Button7.TabIndex=49;
			this.Button7.UseVisualStyleBackColor=true;
			//
			//Panel17
			//
			this.Panel17.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel17.BorderStyle=BorderStyle.FixedSingle;
			this.Panel17.Controls.Add(this.Button8);
			this.Panel17.Controls.Add(this.MaskedTextBox1);
			this.Panel17.Controls.Add(this.ComboBox1);
			this.Panel17.Controls.Add(this.ComboBox3);
			this.Panel17.Controls.Add(this.Label17);
			this.Panel17.Controls.Add(this.Label37);
			this.Panel17.Controls.Add(this.Label38);
			this.Panel17.Location=new System.Drawing.Point(8, 42);
			this.Panel17.Name="Panel17";
			this.Panel17.Size=new System.Drawing.Size(444, 35);
			this.Panel17.TabIndex=47;
			//
			//Button8
			//
			this.Button8.BackColor=System.Drawing.Color.Transparent;
			this.Button8.Image=global::Metro_Operation.Properties.Resources.close_24;
			this.Button8.BackgroundImageLayout=ImageLayout.Stretch;
			this.Button8.FlatAppearance.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Button8.FlatAppearance.BorderSize=0;
			this.Button8.FlatStyle=FlatStyle.Flat;
			this.Button8.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button8.Location=new System.Drawing.Point(12, 7);
			this.Button8.Name="Button8";
			this.Button8.Size=new System.Drawing.Size(20, 20);
			this.Button8.TabIndex=48;
			this.Button8.UseVisualStyleBackColor=true;
			//
			//MaskedTextBox1
			//
			this.MaskedTextBox1.BackColor=System.Drawing.Color.White;
			this.MaskedTextBox1.BorderStyle=BorderStyle.FixedSingle;
			this.MaskedTextBox1.Location=new System.Drawing.Point(302, 6);
			this.MaskedTextBox1.Mask="00:00";
			this.MaskedTextBox1.Name="MaskedTextBox1";
			this.MaskedTextBox1.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.MaskedTextBox1.Size=new System.Drawing.Size(45, 23);
			this.MaskedTextBox1.TabIndex=5;
			this.MaskedTextBox1.TextAlign=HorizontalAlignment.Center;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled=true;
			this.ComboBox1.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox1.Location=new System.Drawing.Point(50, 5);
			this.ComboBox1.Name="ComboBox1";
			this.ComboBox1.Size=new System.Drawing.Size(85, 24);
			this.ComboBox1.TabIndex=1;
			//
			//ComboBox3
			//
			this.ComboBox3.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox3.FormattingEnabled=true;
			this.ComboBox3.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox3.Location=new System.Drawing.Point(179, 5);
			this.ComboBox3.Name="ComboBox3";
			this.ComboBox3.Size=new System.Drawing.Size(85, 24);
			this.ComboBox3.TabIndex=1;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(134, 9);
			this.Label17.Margin=new Padding(3);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(44, 16);
			this.Label17.TabIndex=0;
			this.Label17.Text="مقصد:";
			//
			//Label37
			//
			this.Label37.AutoSize=true;
			this.Label37.Location=new System.Drawing.Point(345, 9);
			this.Label37.Margin=new Padding(3);
			this.Label37.Name="Label37";
			this.Label37.Size=new System.Drawing.Size(86, 16);
			this.Label37.TabIndex=0;
			this.Label37.Text="ساعت حرکت:";
			//
			//Label38
			//
			this.Label38.AutoSize=true;
			this.Label38.Location=new System.Drawing.Point(265, 9);
			this.Label38.Margin=new Padding(3);
			this.Label38.Name="Label38";
			this.Label38.Size=new System.Drawing.Size(35, 16);
			this.Label38.TabIndex=0;
			this.Label38.Text="مبدا:";
			//
			//Button9
			//
			this.Button9.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Button9.Image=global::Metro_Operation.Properties.Resources.add_241;
			this.Button9.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button9.Location=new System.Drawing.Point(367, 5);
			this.Button9.Name="Button9";
			this.Button9.Size=new System.Drawing.Size(81, 32);
			this.Button9.TabIndex=48;
			this.Button9.Text="اضافه         ";
			this.Button9.UseVisualStyleBackColor=false;
			//
			//PictureBox9
			//
			this.PictureBox9.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox9.Location=new System.Drawing.Point(595, 6);
			this.PictureBox9.Name="PictureBox9";
			this.PictureBox9.Size=new System.Drawing.Size(233, 72);
			this.PictureBox9.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox9.TabIndex=70;
			this.PictureBox9.TabStop=false;
			//
			//Panel18
			//
			this.Panel18.AutoScroll=true;
			this.Panel18.BackColor=System.Drawing.Color.Transparent;
			this.Panel18.BorderStyle=BorderStyle.FixedSingle;
			this.Panel18.Controls.Add(this.Button10);
			this.Panel18.Controls.Add(this.Button11);
			this.Panel18.Controls.Add(this.Panel20);
			this.Panel18.Controls.Add(this.Button13);
			this.Panel18.Location=new System.Drawing.Point(477, 83);
			this.Panel18.Name="Panel18";
			this.Panel18.Size=new System.Drawing.Size(461, 85);
			this.Panel18.TabIndex=69;
			//
			//Button10
			//
			this.Button10.BackColor=System.Drawing.Color.Transparent;
			this.Button10.Image=global::Metro_Operation.Properties.Resources._3;
			this.Button10.BackgroundImageLayout=ImageLayout.Center;
			this.Button10.FlatAppearance.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Button10.FlatAppearance.BorderSize=0;
			this.Button10.FlatStyle=FlatStyle.Popup;
			this.Button10.Location=new System.Drawing.Point(43, 10);
			this.Button10.Name="Button10";
			this.Button10.Size=new System.Drawing.Size(24, 22);
			this.Button10.TabIndex=50;
			this.Button10.UseVisualStyleBackColor=true;
			//
			//Button11
			//
			this.Button11.BackColor=System.Drawing.Color.Transparent;
			this.Button11.Image=global::Metro_Operation.Properties.Resources.up;
			this.Button11.BackgroundImageLayout=ImageLayout.Center;
			this.Button11.FlatAppearance.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Button11.FlatAppearance.BorderSize=0;
			this.Button11.FlatStyle=FlatStyle.Popup;
			this.Button11.Location=new System.Drawing.Point(13, 10);
			this.Button11.Name="Button11";
			this.Button11.Size=new System.Drawing.Size(24, 22);
			this.Button11.TabIndex=49;
			this.Button11.UseVisualStyleBackColor=true;
			//
			//Panel20
			//
			this.Panel20.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel20.BorderStyle=BorderStyle.FixedSingle;
			this.Panel20.Controls.Add(this.Button12);
			this.Panel20.Controls.Add(this.MaskedTextBox3);
			this.Panel20.Controls.Add(this.ComboBox4);
			this.Panel20.Controls.Add(this.ComboBox7);
			this.Panel20.Controls.Add(this.Label39);
			this.Panel20.Controls.Add(this.Label40);
			this.Panel20.Controls.Add(this.Label41);
			this.Panel20.Location=new System.Drawing.Point(8, 42);
			this.Panel20.Name="Panel20";
			this.Panel20.Size=new System.Drawing.Size(444, 35);
			this.Panel20.TabIndex=47;
			//
			//Button12
			//
			this.Button12.BackColor=System.Drawing.Color.Transparent;
			this.Button12.Image=global::Metro_Operation.Properties.Resources.close_24;
			this.Button12.BackgroundImageLayout=ImageLayout.Stretch;
			this.Button12.FlatAppearance.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Button12.FlatAppearance.BorderSize=0;
			this.Button12.FlatStyle=FlatStyle.Flat;
			this.Button12.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button12.Location=new System.Drawing.Point(12, 7);
			this.Button12.Name="Button12";
			this.Button12.Size=new System.Drawing.Size(20, 20);
			this.Button12.TabIndex=48;
			this.Button12.UseVisualStyleBackColor=true;
			//
			//MaskedTextBox3
			//
			this.MaskedTextBox3.BackColor=System.Drawing.Color.White;
			this.MaskedTextBox3.BorderStyle=BorderStyle.FixedSingle;
			this.MaskedTextBox3.Location=new System.Drawing.Point(302, 6);
			this.MaskedTextBox3.Mask="00:00";
			this.MaskedTextBox3.Name="MaskedTextBox3";
			this.MaskedTextBox3.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.MaskedTextBox3.Size=new System.Drawing.Size(45, 23);
			this.MaskedTextBox3.TabIndex=5;
			this.MaskedTextBox3.TextAlign=HorizontalAlignment.Center;
			//
			//ComboBox4
			//
			this.ComboBox4.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox4.FormattingEnabled=true;
			this.ComboBox4.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox4.Location=new System.Drawing.Point(50, 5);
			this.ComboBox4.Name="ComboBox4";
			this.ComboBox4.Size=new System.Drawing.Size(85, 24);
			this.ComboBox4.TabIndex=1;
			//
			//ComboBox7
			//
			this.ComboBox7.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox7.FormattingEnabled=true;
			this.ComboBox7.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox7.Location=new System.Drawing.Point(179, 5);
			this.ComboBox7.Name="ComboBox7";
			this.ComboBox7.Size=new System.Drawing.Size(85, 24);
			this.ComboBox7.TabIndex=1;
			//
			//Label39
			//
			this.Label39.AutoSize=true;
			this.Label39.Location=new System.Drawing.Point(134, 9);
			this.Label39.Margin=new Padding(3);
			this.Label39.Name="Label39";
			this.Label39.Size=new System.Drawing.Size(44, 16);
			this.Label39.TabIndex=0;
			this.Label39.Text="مقصد:";
			//
			//Label40
			//
			this.Label40.AutoSize=true;
			this.Label40.Location=new System.Drawing.Point(345, 9);
			this.Label40.Margin=new Padding(3);
			this.Label40.Name="Label40";
			this.Label40.Size=new System.Drawing.Size(86, 16);
			this.Label40.TabIndex=0;
			this.Label40.Text="ساعت حرکت:";
			//
			//Label41
			//
			this.Label41.AutoSize=true;
			this.Label41.Location=new System.Drawing.Point(265, 9);
			this.Label41.Margin=new Padding(3);
			this.Label41.Name="Label41";
			this.Label41.Size=new System.Drawing.Size(35, 16);
			this.Label41.TabIndex=0;
			this.Label41.Text="مبدا:";
			//
			//Button13
			//
			this.Button13.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Button13.Image=global::Metro_Operation.Properties.Resources.add_241;
			this.Button13.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button13.Location=new System.Drawing.Point(367, 5);
			this.Button13.Name="Button13";
			this.Button13.Size=new System.Drawing.Size(81, 32);
			this.Button13.TabIndex=48;
			this.Button13.Text="اضافه         ";
			this.Button13.UseVisualStyleBackColor=false;
			//
			//Panel11
			//
			this.Panel11.BackColor=System.Drawing.Color.Transparent;
			this.Panel11.BorderStyle=BorderStyle.FixedSingle;
			this.Panel11.Controls.Add(this.Button2);
			this.Panel11.Location=new System.Drawing.Point(22, 568);
			this.Panel11.Name="Panel11";
			this.Panel11.Size=new System.Drawing.Size(934, 52);
			this.Panel11.TabIndex=57;
			//
			//Button2
			//
			this.Button2.BackColor=System.Drawing.Color.White;
			this.Button2.Image=global::Metro_Operation.Properties.Resources._31;
			this.Button2.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button2.Location=new System.Drawing.Point(16, 8);
			this.Button2.Name="Button2";
			this.Button2.Size=new System.Drawing.Size(184, 35);
			this.Button2.TabIndex=49;
			this.Button2.Text="مرحله بعدی";
			this.Button2.UseVisualStyleBackColor=false;
			//
			//TabPage1
			//
			this.TabPage1.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage1.Controls.Add(this.Panel9);
			this.TabPage1.Controls.Add(this.Panel8);
			this.TabPage1.Controls.Add(this.Panel7);
			this.TabPage1.Controls.Add(this.PictureBox2);
			this.TabPage1.Controls.Add(this.PictureBox1);
			this.TabPage1.Location=new System.Drawing.Point(4, 24);
			this.TabPage1.Name="TabPage1";
			this.TabPage1.Padding=new Padding(3);
			this.TabPage1.Size=new System.Drawing.Size(1012, 632);
			this.TabPage1.TabIndex=0;
			this.TabPage1.Text="TabPage1";
			//
			//Panel9
			//
			this.Panel9.BackColor=System.Drawing.Color.Transparent;
			this.Panel9.BorderStyle=BorderStyle.FixedSingle;
			this.Panel9.Controls.Add(this.Panel4);
			this.Panel9.Controls.Add(this.Label36);
			this.Panel9.Controls.Add(this.Label34);
			this.Panel9.Controls.Add(this.Label33);
			this.Panel9.Controls.Add(this.Panel5);
			this.Panel9.Controls.Add(this.Panel6);
			this.Panel9.Location=new System.Drawing.Point(10, 27);
			this.Panel9.Name="Panel9";
			this.Panel9.Size=new System.Drawing.Size(671, 231);
			this.Panel9.TabIndex=0;
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.Silver;
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Label30);
			this.Panel4.Controls.Add(this.AllTeh3Box);
			this.Panel4.Controls.Add(this.Label18);
			this.Panel4.Controls.Add(this.Teh3Box);
			this.Panel4.Controls.Add(this.KeshTeh3Box);
			this.Panel4.Controls.Add(this.Label22);
			this.Panel4.Location=new System.Drawing.Point(31, 57);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(184, 142);
			this.Panel4.TabIndex=2;
			//
			//Label30
			//
			this.Label30.AutoSize=true;
			this.Label30.BackColor=System.Drawing.Color.Transparent;
			this.Label30.Location=new System.Drawing.Point(58, 62);
			this.Label30.Margin=new Padding(3);
			this.Label30.Name="Label30";
			this.Label30.Size=new System.Drawing.Size(97, 16);
			this.Label30.TabIndex=36;
			this.Label30.Text="تعداد گروه تهران:";
			this.Label30.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//AllTeh3Box
			//
			this.AllTeh3Box.BackColor=System.Drawing.Color.White;
			this.AllTeh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.AllTeh3Box.Location=new System.Drawing.Point(12, 31);
			this.AllTeh3Box.Mask="90";
			this.AllTeh3Box.Name="AllTeh3Box";
			this.AllTeh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.AllTeh3Box.Size=new System.Drawing.Size(45, 23);
			this.AllTeh3Box.TabIndex=0;
			this.AllTeh3Box.Text="0";
			this.AllTeh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.BackColor=System.Drawing.Color.Transparent;
			this.Label18.Location=new System.Drawing.Point(57, 34);
			this.Label18.Margin=new Padding(3);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(111, 16);
			this.Label18.TabIndex=35;
			this.Label18.Text="تعداد کل حرکت ها:";
			this.Label18.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Teh3Box
			//
			this.Teh3Box.BackColor=System.Drawing.Color.White;
			this.Teh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.Teh3Box.Location=new System.Drawing.Point(12, 59);
			this.Teh3Box.Mask="90";
			this.Teh3Box.Name="Teh3Box";
			this.Teh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Teh3Box.Size=new System.Drawing.Size(45, 23);
			this.Teh3Box.TabIndex=1;
			this.Teh3Box.Text="0";
			this.Teh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshTeh3Box
			//
			this.KeshTeh3Box.BackColor=System.Drawing.Color.White;
			this.KeshTeh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshTeh3Box.Location=new System.Drawing.Point(12, 87);
			this.KeshTeh3Box.Mask="90";
			this.KeshTeh3Box.Name="KeshTeh3Box";
			this.KeshTeh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshTeh3Box.Size=new System.Drawing.Size(45, 23);
			this.KeshTeh3Box.TabIndex=2;
			this.KeshTeh3Box.Text="0";
			this.KeshTeh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label22
			//
			this.Label22.AutoSize=true;
			this.Label22.BackColor=System.Drawing.Color.Transparent;
			this.Label22.Location=new System.Drawing.Point(57, 90);
			this.Label22.Margin=new Padding(3);
			this.Label22.Name="Label22";
			this.Label22.Size=new System.Drawing.Size(107, 16);
			this.Label22.TabIndex=30;
			this.Label22.Text="تعداد گروه کشیک:";
			this.Label22.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label36
			//
			this.Label36.BackColor=System.Drawing.Color.Black;
			this.Label36.BorderStyle=BorderStyle.FixedSingle;
			this.Label36.ForeColor=System.Drawing.Color.Yellow;
			this.Label36.Location=new System.Drawing.Point(487, 30);
			this.Label36.Margin=new Padding(3);
			this.Label36.Name="Label36";
			this.Label36.Size=new System.Drawing.Size(147, 27);
			this.Label36.TabIndex=55;
			this.Label36.Text="شیفت شب قبل";
			this.Label36.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label34
			//
			this.Label34.BackColor=System.Drawing.Color.Black;
			this.Label34.BorderStyle=BorderStyle.FixedSingle;
			this.Label34.ForeColor=System.Drawing.Color.Yellow;
			this.Label34.Location=new System.Drawing.Point(279, 30);
			this.Label34.Margin=new Padding(3);
			this.Label34.Name="Label34";
			this.Label34.Size=new System.Drawing.Size(147, 27);
			this.Label34.TabIndex=54;
			this.Label34.Text="شیفت روز کار";
			this.Label34.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label33
			//
			this.Label33.BackColor=System.Drawing.Color.Black;
			this.Label33.BorderStyle=BorderStyle.FixedSingle;
			this.Label33.ForeColor=System.Drawing.Color.Yellow;
			this.Label33.Location=new System.Drawing.Point(68, 30);
			this.Label33.Margin=new Padding(3);
			this.Label33.Name="Label33";
			this.Label33.Size=new System.Drawing.Size(147, 27);
			this.Label33.TabIndex=53;
			this.Label33.Text="شیفت شب کار";
			this.Label33.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel5
			//
			this.Panel5.BackColor=System.Drawing.Color.Silver;
			this.Panel5.BorderStyle=BorderStyle.FixedSingle;
			this.Panel5.Controls.Add(this.AllTeh1Box);
			this.Panel5.Controls.Add(this.Label25);
			this.Panel5.Controls.Add(this.Teh1Box);
			this.Panel5.Controls.Add(this.KeshTeh1Box);
			this.Panel5.Controls.Add(this.Label26);
			this.Panel5.Controls.Add(this.Label27);
			this.Panel5.Location=new System.Drawing.Point(450, 57);
			this.Panel5.Name="Panel5";
			this.Panel5.Size=new System.Drawing.Size(184, 142);
			this.Panel5.TabIndex=0;
			//
			//AllTeh1Box
			//
			this.AllTeh1Box.BackColor=System.Drawing.Color.White;
			this.AllTeh1Box.BorderStyle=BorderStyle.FixedSingle;
			this.AllTeh1Box.Location=new System.Drawing.Point(15, 31);
			this.AllTeh1Box.Mask="90";
			this.AllTeh1Box.Name="AllTeh1Box";
			this.AllTeh1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.AllTeh1Box.Size=new System.Drawing.Size(45, 23);
			this.AllTeh1Box.TabIndex=0;
			this.AllTeh1Box.Text="0";
			this.AllTeh1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label25
			//
			this.Label25.AutoSize=true;
			this.Label25.BackColor=System.Drawing.Color.Transparent;
			this.Label25.Location=new System.Drawing.Point(61, 34);
			this.Label25.Margin=new Padding(3);
			this.Label25.Name="Label25";
			this.Label25.Size=new System.Drawing.Size(111, 16);
			this.Label25.TabIndex=35;
			this.Label25.Text="تعداد کل حرکت ها:";
			this.Label25.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Teh1Box
			//
			this.Teh1Box.BackColor=System.Drawing.Color.White;
			this.Teh1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Teh1Box.Location=new System.Drawing.Point(15, 59);
			this.Teh1Box.Mask="90";
			this.Teh1Box.Name="Teh1Box";
			this.Teh1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Teh1Box.Size=new System.Drawing.Size(45, 23);
			this.Teh1Box.TabIndex=1;
			this.Teh1Box.Text="0";
			this.Teh1Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshTeh1Box
			//
			this.KeshTeh1Box.BackColor=System.Drawing.Color.White;
			this.KeshTeh1Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshTeh1Box.Location=new System.Drawing.Point(15, 87);
			this.KeshTeh1Box.Mask="90";
			this.KeshTeh1Box.Name="KeshTeh1Box";
			this.KeshTeh1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshTeh1Box.Size=new System.Drawing.Size(45, 23);
			this.KeshTeh1Box.TabIndex=2;
			this.KeshTeh1Box.Text="0";
			this.KeshTeh1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label26
			//
			this.Label26.AutoSize=true;
			this.Label26.BackColor=System.Drawing.Color.Transparent;
			this.Label26.Location=new System.Drawing.Point(61, 62);
			this.Label26.Margin=new Padding(3);
			this.Label26.Name="Label26";
			this.Label26.Size=new System.Drawing.Size(97, 16);
			this.Label26.TabIndex=28;
			this.Label26.Text="تعداد گروه تهران:";
			this.Label26.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label27
			//
			this.Label27.AutoSize=true;
			this.Label27.BackColor=System.Drawing.Color.Transparent;
			this.Label27.Location=new System.Drawing.Point(61, 90);
			this.Label27.Margin=new Padding(3);
			this.Label27.Name="Label27";
			this.Label27.Size=new System.Drawing.Size(107, 16);
			this.Label27.TabIndex=30;
			this.Label27.Text="تعداد گروه کشیک:";
			this.Label27.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Panel6
			//
			this.Panel6.BackColor=System.Drawing.Color.Silver;
			this.Panel6.BorderStyle=BorderStyle.FixedSingle;
			this.Panel6.Controls.Add(this.Label21);
			this.Panel6.Controls.Add(this.AllTeh2Box);
			this.Panel6.Controls.Add(this.Label29);
			this.Panel6.Controls.Add(this.Teh2Box);
			this.Panel6.Controls.Add(this.KeshTeh2Box);
			this.Panel6.Controls.Add(this.Label31);
			this.Panel6.Location=new System.Drawing.Point(242, 57);
			this.Panel6.Name="Panel6";
			this.Panel6.Size=new System.Drawing.Size(184, 142);
			this.Panel6.TabIndex=1;
			//
			//Label21
			//
			this.Label21.AutoSize=true;
			this.Label21.BackColor=System.Drawing.Color.Transparent;
			this.Label21.Location=new System.Drawing.Point(62, 62);
			this.Label21.Margin=new Padding(3);
			this.Label21.Name="Label21";
			this.Label21.Size=new System.Drawing.Size(97, 16);
			this.Label21.TabIndex=36;
			this.Label21.Text="تعداد گروه تهران:";
			this.Label21.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//AllTeh2Box
			//
			this.AllTeh2Box.BackColor=System.Drawing.Color.White;
			this.AllTeh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.AllTeh2Box.Location=new System.Drawing.Point(15, 31);
			this.AllTeh2Box.Mask="90";
			this.AllTeh2Box.Name="AllTeh2Box";
			this.AllTeh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.AllTeh2Box.Size=new System.Drawing.Size(45, 23);
			this.AllTeh2Box.TabIndex=0;
			this.AllTeh2Box.Text="0";
			this.AllTeh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label29
			//
			this.Label29.AutoSize=true;
			this.Label29.BackColor=System.Drawing.Color.Transparent;
			this.Label29.Location=new System.Drawing.Point(61, 34);
			this.Label29.Margin=new Padding(3);
			this.Label29.Name="Label29";
			this.Label29.Size=new System.Drawing.Size(111, 16);
			this.Label29.TabIndex=35;
			this.Label29.Text="تعداد کل حرکت ها:";
			this.Label29.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Teh2Box
			//
			this.Teh2Box.BackColor=System.Drawing.Color.White;
			this.Teh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Teh2Box.Location=new System.Drawing.Point(15, 59);
			this.Teh2Box.Mask="90";
			this.Teh2Box.Name="Teh2Box";
			this.Teh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Teh2Box.Size=new System.Drawing.Size(45, 23);
			this.Teh2Box.TabIndex=1;
			this.Teh2Box.Text="0";
			this.Teh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshTeh2Box
			//
			this.KeshTeh2Box.BackColor=System.Drawing.Color.White;
			this.KeshTeh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshTeh2Box.Location=new System.Drawing.Point(15, 87);
			this.KeshTeh2Box.Mask="90";
			this.KeshTeh2Box.Name="KeshTeh2Box";
			this.KeshTeh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshTeh2Box.Size=new System.Drawing.Size(45, 23);
			this.KeshTeh2Box.TabIndex=2;
			this.KeshTeh2Box.Text="0";
			this.KeshTeh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label31
			//
			this.Label31.AutoSize=true;
			this.Label31.BackColor=System.Drawing.Color.Transparent;
			this.Label31.Location=new System.Drawing.Point(61, 90);
			this.Label31.Margin=new Padding(3);
			this.Label31.Name="Label31";
			this.Label31.Size=new System.Drawing.Size(107, 16);
			this.Label31.TabIndex=30;
			this.Label31.Text="تعداد گروه کشیک:";
			this.Label31.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Panel8
			//
			this.Panel8.BackColor=System.Drawing.Color.Transparent;
			this.Panel8.BorderStyle=BorderStyle.FixedSingle;
			this.Panel8.Controls.Add(this.Panel1);
			this.Panel8.Controls.Add(this.Shift1Label);
			this.Panel8.Controls.Add(this.Label6);
			this.Panel8.Controls.Add(this.Label12);
			this.Panel8.Controls.Add(this.Local1Panel1);
			this.Panel8.Controls.Add(this.Panel2);
			this.Panel8.Location=new System.Drawing.Point(10, 288);
			this.Panel8.Name="Panel8";
			this.Panel8.Size=new System.Drawing.Size(671, 231);
			this.Panel8.TabIndex=1;
			//
			//Panel7
			//
			this.Panel7.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel7.BorderStyle=BorderStyle.FixedSingle;
			this.Panel7.Controls.Add(this.ShowButton);
			this.Panel7.Controls.Add(this.NameBox);
			this.Panel7.Controls.Add(this.Label8);
			this.Panel7.Controls.Add(this.KindCombo);
			this.Panel7.Controls.Add(this.Label3);
			this.Panel7.Location=new System.Drawing.Point(21, 546);
			this.Panel7.Name="Panel7";
			this.Panel7.Size=new System.Drawing.Size(792, 64);
			this.Panel7.TabIndex=2;
			//
			//PictureBox2
			//
			this.PictureBox2.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox2.Location=new System.Drawing.Point(657, 288);
			this.PictureBox2.Name="PictureBox2";
			this.PictureBox2.Size=new System.Drawing.Size(303, 72);
			this.PictureBox2.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox2.TabIndex=60;
			this.PictureBox2.TabStop=false;
			//
			//PictureBox1
			//
			this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox1.Location=new System.Drawing.Point(676, 27);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(233, 72);
			this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex=59;
			this.PictureBox1.TabStop=false;
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Dock=DockStyle.Fill;
			this.TabControl1.ItemSize=new System.Drawing.Size(70, 20);
			this.TabControl1.Location=new System.Drawing.Point(0, 0);
			this.TabControl1.Name="TabControl1";
			this.TabControl1.RightToLeftLayout=true;
			this.TabControl1.SelectedIndex=0;
			this.TabControl1.Size=new System.Drawing.Size(1020, 660);
			this.TabControl1.SizeMode=TabSizeMode.Fixed;
			this.TabControl1.TabIndex=50;
			//
			//TabPage3
			//
			this.TabPage3.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage3.Controls.Add(this.MainPanel2);
			this.TabPage3.Controls.Add(this.PictureBox6);
			this.TabPage3.Controls.Add(this.Panel12);
			this.TabPage3.Location=new System.Drawing.Point(4, 24);
			this.TabPage3.Name="TabPage3";
			this.TabPage3.Padding=new Padding(3);
			this.TabPage3.Size=new System.Drawing.Size(1012, 632);
			this.TabPage3.TabIndex=2;
			this.TabPage3.Text="TabPage3";
			//
			//MainPanel2
			//
			this.MainPanel2.AutoScroll=true;
			this.MainPanel2.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.MainPanel2.BorderStyle=BorderStyle.FixedSingle;
			this.MainPanel2.Controls.Add(this.Panel14);
			this.MainPanel2.Location=new System.Drawing.Point(195, 80);
			this.MainPanel2.Name="MainPanel2";
			this.MainPanel2.Size=new System.Drawing.Size(595, 50);
			this.MainPanel2.TabIndex=66;
			//
			//Panel14
			//
			this.Panel14.BackColor=System.Drawing.Color.LightSteelBlue;
			this.Panel14.BorderStyle=BorderStyle.FixedSingle;
			this.Panel14.Controls.Add(this.MaskedTextBox2);
			this.Panel14.Controls.Add(this.ComboBox2);
			this.Panel14.Controls.Add(this.Label13);
			this.Panel14.Controls.Add(this.ComboBox5);
			this.Panel14.Controls.Add(this.Label24);
			this.Panel14.Controls.Add(this.ComboBox6);
			this.Panel14.Controls.Add(this.Label28);
			this.Panel14.Controls.Add(this.Label32);
			this.Panel14.Location=new System.Drawing.Point(10, 5);
			this.Panel14.Name="Panel14";
			this.Panel14.Size=new System.Drawing.Size(575, 32);
			this.Panel14.TabIndex=47;
			this.Panel14.Visible=false;
			//
			//MaskedTextBox2
			//
			this.MaskedTextBox2.BackColor=System.Drawing.Color.White;
			this.MaskedTextBox2.BorderStyle=BorderStyle.FixedSingle;
			this.MaskedTextBox2.Location=new System.Drawing.Point(439, 4);
			this.MaskedTextBox2.Mask="00:00";
			this.MaskedTextBox2.Name="MaskedTextBox2";
			this.MaskedTextBox2.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.MaskedTextBox2.Size=new System.Drawing.Size(45, 23);
			this.MaskedTextBox2.TabIndex=5;
			this.MaskedTextBox2.TextAlign=HorizontalAlignment.Center;
			//
			//ComboBox2
			//
			this.ComboBox2.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox2.FormattingEnabled=true;
			this.ComboBox2.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox2.Location=new System.Drawing.Point(10, 3);
			this.ComboBox2.Name="ComboBox2";
			this.ComboBox2.Size=new System.Drawing.Size(85, 24);
			this.ComboBox2.TabIndex=1;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Location=new System.Drawing.Point(95, 7);
			this.Label13.Margin=new Padding(3);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(44, 16);
			this.Label13.TabIndex=0;
			this.Label13.Text="مقصد:";
			//
			//ComboBox5
			//
			this.ComboBox5.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox5.FormattingEnabled=true;
			this.ComboBox5.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox5.Location=new System.Drawing.Point(146, 3);
			this.ComboBox5.Name="ComboBox5";
			this.ComboBox5.Size=new System.Drawing.Size(85, 24);
			this.ComboBox5.TabIndex=1;
			//
			//Label24
			//
			this.Label24.AutoSize=true;
			this.Label24.Location=new System.Drawing.Point(231, 7);
			this.Label24.Margin=new Padding(3);
			this.Label24.Name="Label24";
			this.Label24.Size=new System.Drawing.Size(35, 16);
			this.Label24.TabIndex=0;
			this.Label24.Text="مبدا:";
			//
			//ComboBox6
			//
			this.ComboBox6.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ComboBox6.FormattingEnabled=true;
			this.ComboBox6.Items.AddRange(new object[] {"1", "2", "3", "4"});
			this.ComboBox6.Location=new System.Drawing.Point(269, 3);
			this.ComboBox6.Name="ComboBox6";
			this.ComboBox6.Size=new System.Drawing.Size(85, 24);
			this.ComboBox6.TabIndex=1;
			//
			//Label28
			//
			this.Label28.AutoSize=true;
			this.Label28.Location=new System.Drawing.Point(354, 7);
			this.Label28.Margin=new Padding(0);
			this.Label28.Name="Label28";
			this.Label28.Size=new System.Drawing.Size(77, 16);
			this.Label28.TabIndex=0;
			this.Label28.Text="گروه راهبری:";
			//
			//Label32
			//
			this.Label32.AutoSize=true;
			this.Label32.Location=new System.Drawing.Point(483, 7);
			this.Label32.Margin=new Padding(3);
			this.Label32.Name="Label32";
			this.Label32.Size=new System.Drawing.Size(86, 16);
			this.Label32.TabIndex=0;
			this.Label32.Text="ساعت حرکت:";
			//
			//PictureBox6
			//
			this.PictureBox6.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox6.Location=new System.Drawing.Point(344, 6);
			this.PictureBox6.Name="PictureBox6";
			this.PictureBox6.Size=new System.Drawing.Size(303, 72);
			this.PictureBox6.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox6.TabIndex=65;
			this.PictureBox6.TabStop=false;
			//
			//Panel12
			//
			this.Panel12.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel12.BorderStyle=BorderStyle.FixedSingle;
			this.Panel12.Controls.Add(this.Button4);
			this.Panel12.Controls.Add(this.Button5);
			this.Panel12.Location=new System.Drawing.Point(8, 559);
			this.Panel12.Name="Panel12";
			this.Panel12.Size=new System.Drawing.Size(956, 64);
			this.Panel12.TabIndex=58;
			//
			//Button4
			//
			this.Button4.BackColor=System.Drawing.Color.White;
			this.Button4.Image=global::Metro_Operation.Properties.Resources._32;
			this.Button4.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Button4.Location=new System.Drawing.Point(755, 15);
			this.Button4.Name="Button4";
			this.Button4.Size=new System.Drawing.Size(184, 35);
			this.Button4.TabIndex=50;
			this.Button4.Text="بازگشت";
			this.Button4.UseVisualStyleBackColor=false;
			//
			//Button5
			//
			this.Button5.BackColor=System.Drawing.Color.White;
			this.Button5.Image=global::Metro_Operation.Properties.Resources._31;
			this.Button5.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button5.Location=new System.Drawing.Point(16, 15);
			this.Button5.Name="Button5";
			this.Button5.Size=new System.Drawing.Size(184, 35);
			this.Button5.TabIndex=49;
			this.Button5.Text="مرحله بعدی";
			this.Button5.UseVisualStyleBackColor=false;
			//
			//TabPage4
			//
			this.TabPage4.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage4.Controls.Add(this.Panel10);
			this.TabPage4.Controls.Add(this.DataGridView2);
			this.TabPage4.Controls.Add(this.PictureBox3);
			this.TabPage4.Controls.Add(this.PictureBox4);
			this.TabPage4.Controls.Add(this.DataGridView1);
			this.TabPage4.Location=new System.Drawing.Point(4, 24);
			this.TabPage4.Name="TabPage4";
			this.TabPage4.Padding=new Padding(3);
			this.TabPage4.Size=new System.Drawing.Size(1012, 632);
			this.TabPage4.TabIndex=3;
			this.TabPage4.Text="TabPage4";
			//
			//Panel10
			//
			this.Panel10.BackColor=System.Drawing.Color.Transparent;
			this.Panel10.BorderStyle=BorderStyle.FixedSingle;
			this.Panel10.Controls.Add(this.Button6);
			this.Panel10.Controls.Add(this.Button1);
			this.Panel10.Location=new System.Drawing.Point(10, 568);
			this.Panel10.Name="Panel10";
			this.Panel10.Size=new System.Drawing.Size(932, 52);
			this.Panel10.TabIndex=64;
			//
			//Button6
			//
			this.Button6.BackColor=System.Drawing.Color.White;
			this.Button6.Image=global::Metro_Operation.Properties.Resources._32;
			this.Button6.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Button6.Location=new System.Drawing.Point(730, 8);
			this.Button6.Name="Button6";
			this.Button6.Size=new System.Drawing.Size(184, 35);
			this.Button6.TabIndex=51;
			this.Button6.Text="بازگشت";
			this.Button6.UseVisualStyleBackColor=false;
			//
			//Button1
			//
			this.Button1.BackColor=System.Drawing.Color.Yellow;
			this.Button1.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.Button1.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button1.Location=new System.Drawing.Point(13, 8);
			this.Button1.Name="Button1";
			this.Button1.Size=new System.Drawing.Size(235, 35);
			this.Button1.TabIndex=50;
			this.Button1.Text="تاید نهایی";
			this.Button1.UseVisualStyleBackColor=false;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows=false;
			this.DataGridView2.AllowUserToDeleteRows=false;
			this.DataGridView2.AllowUserToResizeColumns=false;
			this.DataGridView2.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.DataGridView2.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.DataGridView2.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.DataGridView2.ColumnHeadersHeight=40;
			this.DataGridView2.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn5, this.DataGridViewTextBoxColumn6});
			this.DataGridView2.EnableHeadersVisualStyles=false;
			this.DataGridView2.Location=new System.Drawing.Point(10, 81);
			this.DataGridView2.MultiSelect=false;
			this.DataGridView2.Name="DataGridView2";
			this.DataGridView2.ReadOnly=true;
			this.DataGridView2.RowHeadersVisible=false;
			this.DataGridView2.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.RowTemplate.ReadOnly=true;
			this.DataGridView2.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size=new System.Drawing.Size(445, 469);
			this.DataGridView2.TabIndex=63;
			//
			//DataGridViewTextBoxColumn1
			//
			this.DataGridViewTextBoxColumn1.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly=true;
			this.DataGridViewTextBoxColumn1.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn1.Width=60;
			//
			//DataGridViewTextBoxColumn2
			//
			this.DataGridViewTextBoxColumn2.HeaderText="ساعت اعزام";
			this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly=true;
			this.DataGridViewTextBoxColumn2.Width=65;
			//
			//DataGridViewTextBoxColumn3
			//
			this.DataGridViewTextBoxColumn3.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly=true;
			this.DataGridViewTextBoxColumn3.Width=60;
			//
			//DataGridViewTextBoxColumn4
			//
			this.DataGridViewTextBoxColumn4.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly=true;
			this.DataGridViewTextBoxColumn4.Width=64;
			//
			//DataGridViewTextBoxColumn5
			//
			this.DataGridViewTextBoxColumn5.HeaderText="راهبر مستر";
			this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly=true;
			this.DataGridViewTextBoxColumn5.Width=87;
			//
			//DataGridViewTextBoxColumn6
			//
			this.DataGridViewTextBoxColumn6.HeaderText="راهبر اسلیو";
			this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
			this.DataGridViewTextBoxColumn6.ReadOnly=true;
			this.DataGridViewTextBoxColumn6.Width=88;
			//
			//PictureBox3
			//
			this.PictureBox3.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox3.Location=new System.Drawing.Point(63, 6);
			this.PictureBox3.Name="PictureBox3";
			this.PictureBox3.Size=new System.Drawing.Size(303, 72);
			this.PictureBox3.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox3.TabIndex=62;
			this.PictureBox3.TabStop=false;
			//
			//PictureBox4
			//
			this.PictureBox4.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox4.Location=new System.Drawing.Point(613, 6);
			this.PictureBox4.Name="PictureBox4";
			this.PictureBox4.Size=new System.Drawing.Size(233, 72);
			this.PictureBox4.SizeMode=PictureBoxSizeMode.AutoSize;
			this.PictureBox4.TabIndex=61;
			this.PictureBox4.TabStop=false;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle3;
			this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode=DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle4;
			this.DataGridView1.ColumnHeadersHeight=40;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column9, this.Column1, this.Column7, this.Column2, this.Column11, this.Column6});
			this.DataGridView1.EnableHeadersVisualStyles=false;
			this.DataGridView1.Location=new System.Drawing.Point(497, 81);
			this.DataGridView1.MultiSelect=false;
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.RowTemplate.ReadOnly=true;
			this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size=new System.Drawing.Size(445, 469);
			this.DataGridView1.TabIndex=39;
			//
			//Column9
			//
			this.Column9.HeaderText="ردیف";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Resizable=DataGridViewTriState.False;
			this.Column9.Width=60;
			//
			//Column1
			//
			this.Column1.HeaderText="ساعت اعزام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=65;
			//
			//Column7
			//
			this.Column7.HeaderText="مبداء";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=60;
			//
			//Column2
			//
			this.Column2.HeaderText="مقصد";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=64;
			//
			//Column11
			//
			this.Column11.HeaderText="راهبر مستر";
			this.Column11.Name="Column11";
			this.Column11.ReadOnly=true;
			this.Column11.Width=87;
			//
			//Column6
			//
			this.Column6.HeaderText="راهبر اسلیو";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=88;
			//
			//TerminalParametrForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(1020, 660);
			this.Controls.Add(this.TabControl1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalParametrForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="پردازش لوحه پایانه";
			this.Local1Panel1.ResumeLayout(false);
			this.Local1Panel1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			this.Panel16.ResumeLayout(false);
			this.Panel17.ResumeLayout(false);
			this.Panel17.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			this.Panel18.ResumeLayout(false);
			this.Panel20.ResumeLayout(false);
			this.Panel20.PerformLayout();
			this.Panel11.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.Panel9.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.Panel6.ResumeLayout(false);
			this.Panel6.PerformLayout();
			this.Panel8.ResumeLayout(false);
			this.Panel7.ResumeLayout(false);
			this.Panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.TabControl1.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.MainPanel2.ResumeLayout(false);
			this.Panel14.ResumeLayout(false);
			this.Panel14.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox6).EndInit();
			this.Panel12.ResumeLayout(false);
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			this.Panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		private Panel Local1Panel1;
		private MaskedTextBox All1Box;
		private Label Label35;
		private MaskedTextBox Gol1Box;
		private MaskedTextBox KeshGol1Box;
		private Label Label19;
		private Label Label20;
		private MaskedTextBox Mehr1Box;
		private Label Label23;
		private TextBox NameBox;
		private Label Label8;
		private ComboBox KindCombo;
		private Label Label3;
		private Label Shift1Label;
		private Panel Panel1;
		private MaskedTextBox All2Box;
		private Label Label1;
		private MaskedTextBox Gol2Box;
		private MaskedTextBox KeshGol2Box;
		private Label Label2;
		private Label Label4;
		private MaskedTextBox Mehr2Box;
		private Label Label5;
		private Label Label6;
		private Panel Panel2;
		private MaskedTextBox All3Box;
		private Label Label7;
		private MaskedTextBox Gol3Box;
		private MaskedTextBox KeshGol3Box;
		private Label Label9;
		private Label Label10;
		private MaskedTextBox Mehr3Box;
		private Label Label11;
		private Label Label12;
		private Button ShowButton;
		private TabPage TabPage2;
		private TabPage TabPage1;
		private Panel Panel9;
		private Panel Panel4;
		private MaskedTextBox AllTeh3Box;
		private Label Label18;
		private MaskedTextBox Teh3Box;
		private MaskedTextBox KeshTeh3Box;
		private Label Label22;
		private Label Label36;
		private Label Label34;
		private Label Label33;
		private Panel Panel5;
		private MaskedTextBox AllTeh1Box;
		private Label Label25;
		private MaskedTextBox Teh1Box;
		private MaskedTextBox KeshTeh1Box;
		private Label Label26;
		private Label Label27;
		private Panel Panel6;
		private MaskedTextBox AllTeh2Box;
		private Label Label29;
		private MaskedTextBox Teh2Box;
		private MaskedTextBox KeshTeh2Box;
		private Label Label31;
		private Panel Panel8;
		private Panel Panel7;
		private TabControl TabControl1;
		private TabPage TabPage3;
		private TabPage TabPage4;
		private PictureBox PictureBox2;
		private PictureBox PictureBox1;
		private DataGridView DataGridView1;
		private PictureBox PictureBox3;
		private PictureBox PictureBox4;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column6;
		private Panel Panel11;
		private Button Button2;
		private PictureBox PictureBox6;
		private Panel Panel12;
		private Button Button4;
		private Button Button5;
		private Panel Panel10;
		private Button Button6;
		private Button Button1;
		private DataGridView DataGridView2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
		private Label Label30;
		private Label Label21;
		private Panel MainPanel2;
		private Panel Panel14;
		private MaskedTextBox MaskedTextBox2;
		private ComboBox ComboBox2;
		private Label Label13;
		private ComboBox ComboBox5;
		private Label Label24;
		private ComboBox ComboBox6;
		private Label Label28;
		private Label Label32;
		private PictureBox PictureBox8;
		private Panel Panel16;
		private Button Button3;
		private Button Button7;
		private Panel Panel17;
		private Button Button8;
		private MaskedTextBox MaskedTextBox1;
		private ComboBox ComboBox1;
		private ComboBox ComboBox3;
		private Label Label17;
		private Label Label37;
		private Label Label38;
		private Button Button9;
		private PictureBox PictureBox9;
		private Panel Panel18;
		private Button Button10;
		private Button Button11;
		private Panel Panel20;
		private Button Button12;
		private MaskedTextBox MaskedTextBox3;
		private ComboBox ComboBox4;
		private ComboBox ComboBox7;
		private Label Label39;
		private Label Label40;
		private Label Label41;
		private Button Button13;
	}
	
}
