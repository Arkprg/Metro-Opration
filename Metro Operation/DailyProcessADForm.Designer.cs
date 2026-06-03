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
		public partial class DailyProcessADForm : BaseForm
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
			base.Load += new System.EventHandler(DailyProcessADForm_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(DailyProcessADForm));
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.Label3=new Label();
			this.NameCombo=new ComboBox();
			this.NameCombo.SelectedIndexChanged += new System.EventHandler(this.NameCombo_SelectedIndexChanged);
			this.Label1=new Label();
			this.Label1a=new Label();
			this.Label17=new Label();
			this.Shift12R1Box=new MaskedTextBox();
			this.Label18=new Label();
			this.Keshik12R1Box=new MaskedTextBox();
			this.Label2=new Label();
			this.Leave12R1Box=new MaskedTextBox();
			this.Label4=new Label();
			this.Rez12R1Box=new MaskedTextBox();
			this.Rez12R1Box.TextChanged += new System.EventHandler(this.Rez12R1Box_TextChanged);
			this.Label5=new Label();
			this.Over12R1Box=new MaskedTextBox();
			this.Label6=new Label();
			this.Kasr12R1Box=new MaskedTextBox();
			this.Kasr12R1Box.TextChanged += new System.EventHandler(this.Kasr12R1Box_TextChanged);
			this.Label7=new Label();
			this.Over12S1Box=new MaskedTextBox();
			this.Kasr12S1Box=new MaskedTextBox();
			this.Kasr12S1Box.TextChanged += new System.EventHandler(this.Kasr12s1Box_TextChanged);
			this.Leave12S1Box=new MaskedTextBox();
			this.Rez12S1Box=new MaskedTextBox();
			this.Rez12S1Box.TextChanged += new System.EventHandler(this.Rez12S1Box_TextChanged);
			this.Shift12S1Box=new MaskedTextBox();
			this.Keshik12S1Box=new MaskedTextBox();
			this.Over9A1Box=new MaskedTextBox();
			this.Kasr9A1Box=new MaskedTextBox();
			this.Kasr9A1Box.TextChanged += new System.EventHandler(this.Kasr9a1Box_TextChanged);
			this.Leave9A1Box=new MaskedTextBox();
			this.Rez9A1Box=new MaskedTextBox();
			this.Rez9A1Box.TextChanged += new System.EventHandler(this.Rez9A1Box_TextChanged);
			this.Shift9A1Box=new MaskedTextBox();
			this.Keshik9A1Box=new MaskedTextBox();
			this.Label9=new Label();
			this.Over9S1Box=new MaskedTextBox();
			this.Kasr9S1Box=new MaskedTextBox();
			this.Kasr9S1Box.TextChanged += new System.EventHandler(this.Kasr9s1Box_TextChanged);
			this.Leave9S1Box=new MaskedTextBox();
			this.Rez9S1Box=new MaskedTextBox();
			this.Rez9S1Box.TextChanged += new System.EventHandler(this.Rez9S1Box_TextChanged);
			this.Shift9S1Box=new MaskedTextBox();
			this.Keshik9S1Box=new MaskedTextBox();
			this.Label13=new Label();
			this.OverSet1Box=new MaskedTextBox();
			this.KasrSet1Box=new MaskedTextBox();
			this.KasrSet1Box.TextChanged += new System.EventHandler(this.Kasrset1Box_TextChanged);
			this.LeaveSet1Box=new MaskedTextBox();
			this.RezSet1Box=new MaskedTextBox();
			this.RezSet1Box.TextChanged += new System.EventHandler(this.RezSet1Box_TextChanged);
			this.ShiftSet1Box=new MaskedTextBox();
			this.KeshikSet1Box=new MaskedTextBox();
			this.Label16=new Label();
			this.Panel1=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
			this.Label30=new Label();
			this.PrintButton=new Button();
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			this.PrintButton.EnabledChanged += new System.EventHandler(this.PrintButton_EnabledChanged);
			this.ProcessButton=new Button();
			this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
			this.ProcessButton.EnabledChanged += new System.EventHandler(this.ProcessButton_EnabledChanged);
			this.Local1Label=new Label();
			this.Panel2=new Panel();
			this.All12R1Box=new MaskedTextBox();
			this.All12R1Box.TextChanged += new System.EventHandler(this.Rez12R1Box_TextChanged);
			this.Daem12R1Box=new MaskedTextBox();
			this.Daem12R1Box.TextChanged += new System.EventHandler(this.Rez12R1Box_TextChanged);
			this.Class12R1Box=new MaskedTextBox();
			this.All12S1Box=new MaskedTextBox();
			this.All12S1Box.TextChanged += new System.EventHandler(this.Rez12S1Box_TextChanged);
			this.Daem12S1Box=new MaskedTextBox();
			this.Daem12S1Box.TextChanged += new System.EventHandler(this.Rez12S1Box_TextChanged);
			this.Class12S1Box=new MaskedTextBox();
			this.All9S1Box=new MaskedTextBox();
			this.All9S1Box.TextChanged += new System.EventHandler(this.Rez9S1Box_TextChanged);
			this.Daem9S1Box=new MaskedTextBox();
			this.Daem9S1Box.TextChanged += new System.EventHandler(this.Rez9S1Box_TextChanged);
			this.Class9S1Box=new MaskedTextBox();
			this.All9A1Box=new MaskedTextBox();
			this.All9A1Box.TextChanged += new System.EventHandler(this.Rez9A1Box_TextChanged);
			this.Daem9A1Box=new MaskedTextBox();
			this.Daem9A1Box.TextChanged += new System.EventHandler(this.Rez9A1Box_TextChanged);
			this.Class9A1Box=new MaskedTextBox();
			this.Label8=new Label();
			this.AllSet1Box=new MaskedTextBox();
			this.AllSet1Box.TextChanged += new System.EventHandler(this.RezSet1Box_TextChanged);
			this.ClassSet1Box=new MaskedTextBox();
			this.DaemSet1Box=new MaskedTextBox();
			this.DaemSet1Box.TextChanged += new System.EventHandler(this.RezSet1Box_TextChanged);
			this.Label33=new Label();
			this.Label22=new Label();
			this.Label35=new Label();
			this.Label21=new Label();
			this.Label20=new Label();
			this.Label10=new Label();
			this.Label19=new Label();
			this.DataGridView1=new DataGridView();
			this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn6=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn7=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.DataGridView2=new DataGridView();
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Panel3=new Panel();
			this.Keshik12R2Box=new MaskedTextBox();
			this.All12R2Box=new MaskedTextBox();
			this.All12R2Box.TextChanged += new System.EventHandler(this.Rez12R2box_TextChanged);
			this.Shift12R2Box=new MaskedTextBox();
			this.Daem12R2Box=new MaskedTextBox();
			this.Daem12R2Box.TextChanged += new System.EventHandler(this.Rez12R2box_TextChanged);
			this.Class12R2Box=new MaskedTextBox();
			this.Rez12R2Box=new MaskedTextBox();
			this.Rez12R2Box.TextChanged += new System.EventHandler(this.Rez12R2box_TextChanged);
			this.Leave12R2Box=new MaskedTextBox();
			this.Kasr12R2Box=new MaskedTextBox();
			this.Kasr12R2Box.TextChanged += new System.EventHandler(this.Kasr12R2box_TextChanged);
			this.Over12R2Box=new MaskedTextBox();
			this.Label12=new Label();
			this.Keshik12S2Box=new MaskedTextBox();
			this.All12S2Box=new MaskedTextBox();
			this.All12S2Box.TextChanged += new System.EventHandler(this.Rez12S2box_TextChanged);
			this.Shift12S2Box=new MaskedTextBox();
			this.Class12S2Box=new MaskedTextBox();
			this.Daem12S2Box=new MaskedTextBox();
			this.Daem12S2Box.TextChanged += new System.EventHandler(this.Rez12S2box_TextChanged);
			this.Rez12S2Box=new MaskedTextBox();
			this.Rez12S2Box.TextChanged += new System.EventHandler(this.Rez12S2box_TextChanged);
			this.Leave12S2Box=new MaskedTextBox();
			this.Kasr12S2Box=new MaskedTextBox();
			this.Kasr12S2Box.TextChanged += new System.EventHandler(this.Kasr12s2box_TextChanged);
			this.Over12S2Box=new MaskedTextBox();
			this.Label14=new Label();
			this.Keshik9S2Box=new MaskedTextBox();
			this.All9S2Box=new MaskedTextBox();
			this.All9S2Box.TextChanged += new System.EventHandler(this.Rez9S2box_TextChanged);
			this.Shift9S2Box=new MaskedTextBox();
			this.Class9S2Box=new MaskedTextBox();
			this.Daem9S2Box=new MaskedTextBox();
			this.Daem9S2Box.TextChanged += new System.EventHandler(this.Rez9S2box_TextChanged);
			this.Rez9S2Box=new MaskedTextBox();
			this.Rez9S2Box.TextChanged += new System.EventHandler(this.Rez9S2box_TextChanged);
			this.Leave9S2Box=new MaskedTextBox();
			this.Kasr9S2Box=new MaskedTextBox();
			this.Kasr9S2Box.TextChanged += new System.EventHandler(this.Kasr9s2box_TextChanged);
			this.Over9S2Box=new MaskedTextBox();
			this.Label15=new Label();
			this.All9A2Box=new MaskedTextBox();
			this.All9A2Box.TextChanged += new System.EventHandler(this.Rez9A2box_TextChanged);
			this.Keshik9A2Box=new MaskedTextBox();
			this.Shift9A2Box=new MaskedTextBox();
			this.Class9A2Box=new MaskedTextBox();
			this.Rez9A2Box=new MaskedTextBox();
			this.Rez9A2Box.TextChanged += new System.EventHandler(this.Rez9A2box_TextChanged);
			this.Daem9A2Box=new MaskedTextBox();
			this.Daem9A2Box.TextChanged += new System.EventHandler(this.Rez9A2box_TextChanged);
			this.Leave9A2Box=new MaskedTextBox();
			this.Kasr9A2Box=new MaskedTextBox();
			this.Kasr9A2Box.TextChanged += new System.EventHandler(this.Kasr9a2box_TextChanged);
			this.Over9A2Box=new MaskedTextBox();
			this.Label24=new Label();
			this.AllSet2Box=new MaskedTextBox();
			this.AllSet2Box.TextChanged += new System.EventHandler(this.RezSet2box_TextChanged);
			this.KeshikSet2Box=new MaskedTextBox();
			this.ShiftSet2Box=new MaskedTextBox();
			this.OverSet2Box=new MaskedTextBox();
			this.ClassSet2Box=new MaskedTextBox();
			this.RezSet2Box=new MaskedTextBox();
			this.RezSet2Box.TextChanged += new System.EventHandler(this.RezSet2box_TextChanged);
			this.KasrSet2Box=new MaskedTextBox();
			this.KasrSet2Box.TextChanged += new System.EventHandler(this.Kasrset2box_TextChanged);
			this.LeaveSet2Box=new MaskedTextBox();
			this.DaemSet2Box=new MaskedTextBox();
			this.DaemSet2Box.TextChanged += new System.EventHandler(this.RezSet2box_TextChanged);
			this.Label25=new Label();
			this.Label26=new Label();
			this.Label37=new Label();
			this.Label34=new Label();
			this.Label27=new Label();
			this.Label31=new Label();
			this.Label28=new Label();
			this.Label29=new Label();
			this.Local2Label=new Label();
			this.Label11=new Label();
			this.DetailGridView=new DataGridView();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Label23=new Label();
			this.Label32=new Label();
			this.Label36=new Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DetailGridView).BeginInit();
			this.SuspendLayout();
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل", "روز خاص"});
			this.KindCombo.Location=new System.Drawing.Point(589, 15);
			this.KindCombo.Margin=new Padding(4, 5, 4, 5);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(148, 24);
			this.KindCombo.TabIndex=1;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.ForeColor=System.Drawing.Color.Black;
			this.Label3.Location=new System.Drawing.Point(737, 19);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(74, 16);
			this.Label3.TabIndex=42;
			this.Label3.Text="نوع پردازش:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//NameCombo
			//
			this.NameCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.NameCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NameCombo.FormattingEnabled=true;
			this.NameCombo.Location=new System.Drawing.Point(306, 15);
			this.NameCombo.Margin=new Padding(4, 5, 4, 5);
			this.NameCombo.Name="NameCombo";
			this.NameCombo.Size=new System.Drawing.Size(203, 24);
			this.NameCombo.TabIndex=2;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.ForeColor=System.Drawing.Color.Black;
			this.Label1.Location=new System.Drawing.Point(509, 19);
			this.Label1.Margin=new Padding(5, 0, 5, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(72, 16);
			this.Label1.TabIndex=44;
			this.Label1.Text="نام پردازش:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label1a
			//
			this.Label1a.BackColor=System.Drawing.Color.Transparent;
			this.Label1a.BorderStyle=BorderStyle.FixedSingle;
			this.Label1a.Location=new System.Drawing.Point(341, 41);
			this.Label1a.Margin=new Padding(5, 0, 5, 0);
			this.Label1a.Name="Label1a";
			this.Label1a.Size=new System.Drawing.Size(73, 38);
			this.Label1a.TabIndex=48;
			this.Label1a.Text="12 ساعته روز";
			this.Label1a.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.BackColor=System.Drawing.Color.Transparent;
			this.Label17.ForeColor=System.Drawing.Color.Black;
			this.Label17.Location=new System.Drawing.Point(865, 210);
			this.Label17.Margin=new Padding(5, 0, 5, 0);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(118, 16);
			this.Label17.TabIndex=28;
			this.Label17.Text="تعداد راهبران شیفت";
			this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Shift12R1Box
			//
			this.Shift12R1Box.BackColor=System.Drawing.Color.Silver;
			this.Shift12R1Box.BorderStyle=BorderStyle.None;
			this.Shift12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift12R1Box.Location=new System.Drawing.Point(355, 125);
			this.Shift12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift12R1Box.Mask="90";
			this.Shift12R1Box.Name="Shift12R1Box";
			this.Shift12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift12R1Box.ReadOnly=true;
			this.Shift12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Shift12R1Box.TabIndex=0;
			this.Shift12R1Box.TabStop=false;
			this.Shift12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.BackColor=System.Drawing.Color.Transparent;
			this.Label18.ForeColor=System.Drawing.Color.Black;
			this.Label18.Location=new System.Drawing.Point(865, 250);
			this.Label18.Margin=new Padding(5, 0, 5, 0);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(119, 16);
			this.Label18.TabIndex=30;
			this.Label18.Text="تعداد راهبران کشیک";
			this.Label18.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Keshik12R1Box
			//
			this.Keshik12R1Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik12R1Box.BorderStyle=BorderStyle.None;
			this.Keshik12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik12R1Box.Location=new System.Drawing.Point(355, 169);
			this.Keshik12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik12R1Box.Mask="90";
			this.Keshik12R1Box.Name="Keshik12R1Box";
			this.Keshik12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik12R1Box.ReadOnly=true;
			this.Keshik12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik12R1Box.TabIndex=1;
			this.Keshik12R1Box.TabStop=false;
			this.Keshik12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.ForeColor=System.Drawing.Color.Black;
			this.Label2.Location=new System.Drawing.Point(865, 430);
			this.Label2.Margin=new Padding(5, 0, 5, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(101, 16);
			this.Label2.TabIndex=33;
			this.Label2.Text="تعداد راهبران رزرو";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Leave12R1Box
			//
			this.Leave12R1Box.BackColor=System.Drawing.Color.Silver;
			this.Leave12R1Box.BorderStyle=BorderStyle.None;
			this.Leave12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave12R1Box.Location=new System.Drawing.Point(355, 257);
			this.Leave12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave12R1Box.Mask="90";
			this.Leave12R1Box.Name="Leave12R1Box";
			this.Leave12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave12R1Box.ReadOnly=true;
			this.Leave12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Leave12R1Box.TabIndex=2;
			this.Leave12R1Box.TabStop=false;
			this.Leave12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.BackColor=System.Drawing.Color.Transparent;
			this.Label4.ForeColor=System.Drawing.Color.Black;
			this.Label4.Location=new System.Drawing.Point(865, 473);
			this.Label4.Margin=new Padding(5, 0, 5, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(86, 16);
			this.Label4.TabIndex=34;
			this.Label4.Text="تعداد اضافه کار";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Rez12R1Box
			//
			this.Rez12R1Box.BackColor=System.Drawing.Color.White;
			this.Rez12R1Box.BorderStyle=BorderStyle.None;
			this.Rez12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez12R1Box.Location=new System.Drawing.Point(355, 349);
			this.Rez12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez12R1Box.Mask="90";
			this.Rez12R1Box.Name="Rez12R1Box";
			this.Rez12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Rez12R1Box.TabIndex=5;
			this.Rez12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.Font=new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor=System.Drawing.Color.Black;
			this.Label5.Location=new System.Drawing.Point(865, 516);
			this.Label5.Margin=new Padding(5, 0, 5, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(84, 23);
			this.Label5.TabIndex=37;
			this.Label5.Text="تراز نفرات";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Over12R1Box
			//
			this.Over12R1Box.BackColor=System.Drawing.Color.Silver;
			this.Over12R1Box.BorderStyle=BorderStyle.None;
			this.Over12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over12R1Box.Location=new System.Drawing.Point(355, 395);
			this.Over12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Over12R1Box.Mask="90";
			this.Over12R1Box.Name="Over12R1Box";
			this.Over12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over12R1Box.ReadOnly=true;
			this.Over12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Over12R1Box.TabIndex=4;
			this.Over12R1Box.TabStop=false;
			this.Over12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.BackColor=System.Drawing.Color.Transparent;
			this.Label6.ForeColor=System.Drawing.Color.Black;
			this.Label6.Location=new System.Drawing.Point(865, 340);
			this.Label6.Margin=new Padding(5, 0, 5, 0);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(115, 16);
			this.Label6.TabIndex=38;
			this.Label6.Text="تعداد مرخصی روزانه";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Kasr12R1Box
			//
			this.Kasr12R1Box.BackColor=System.Drawing.Color.White;
			this.Kasr12R1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr12R1Box.Location=new System.Drawing.Point(355, 440);
			this.Kasr12R1Box.Mask="###";
			this.Kasr12R1Box.Name="Kasr12R1Box";
			this.Kasr12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr12R1Box.ReadOnly=true;
			this.Kasr12R1Box.RightToLeft=RightToLeft.No;
			this.Kasr12R1Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr12R1Box.TabIndex=5;
			this.Kasr12R1Box.TabStop=false;
			this.Kasr12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label7
			//
			this.Label7.BackColor=System.Drawing.Color.Transparent;
			this.Label7.BorderStyle=BorderStyle.FixedSingle;
			this.Label7.Location=new System.Drawing.Point(258, 41);
			this.Label7.Margin=new Padding(5, 0, 5, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(73, 38);
			this.Label7.TabIndex=55;
			this.Label7.Text="12 ساعته شب";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Over12S1Box
			//
			this.Over12S1Box.BackColor=System.Drawing.Color.Silver;
			this.Over12S1Box.BorderStyle=BorderStyle.None;
			this.Over12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over12S1Box.Location=new System.Drawing.Point(272, 395);
			this.Over12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Over12S1Box.Mask="90";
			this.Over12S1Box.Name="Over12S1Box";
			this.Over12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over12S1Box.ReadOnly=true;
			this.Over12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Over12S1Box.TabIndex=10;
			this.Over12S1Box.TabStop=false;
			this.Over12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr12S1Box
			//
			this.Kasr12S1Box.BackColor=System.Drawing.Color.White;
			this.Kasr12S1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr12S1Box.Location=new System.Drawing.Point(272, 440);
			this.Kasr12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr12S1Box.Mask="###";
			this.Kasr12S1Box.Name="Kasr12S1Box";
			this.Kasr12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr12S1Box.ReadOnly=true;
			this.Kasr12S1Box.RightToLeft=RightToLeft.No;
			this.Kasr12S1Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr12S1Box.TabIndex=11;
			this.Kasr12S1Box.TabStop=false;
			this.Kasr12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave12S1Box
			//
			this.Leave12S1Box.BackColor=System.Drawing.Color.Silver;
			this.Leave12S1Box.BorderStyle=BorderStyle.None;
			this.Leave12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave12S1Box.Location=new System.Drawing.Point(272, 257);
			this.Leave12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave12S1Box.Mask="90";
			this.Leave12S1Box.Name="Leave12S1Box";
			this.Leave12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave12S1Box.ReadOnly=true;
			this.Leave12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Leave12S1Box.TabIndex=8;
			this.Leave12S1Box.TabStop=false;
			this.Leave12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez12S1Box
			//
			this.Rez12S1Box.BackColor=System.Drawing.Color.White;
			this.Rez12S1Box.BorderStyle=BorderStyle.None;
			this.Rez12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez12S1Box.Location=new System.Drawing.Point(272, 349);
			this.Rez12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez12S1Box.Mask="90";
			this.Rez12S1Box.Name="Rez12S1Box";
			this.Rez12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Rez12S1Box.TabIndex=6;
			this.Rez12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift12S1Box
			//
			this.Shift12S1Box.BackColor=System.Drawing.Color.Silver;
			this.Shift12S1Box.BorderStyle=BorderStyle.None;
			this.Shift12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift12S1Box.Location=new System.Drawing.Point(272, 125);
			this.Shift12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift12S1Box.Mask="90";
			this.Shift12S1Box.Name="Shift12S1Box";
			this.Shift12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift12S1Box.ReadOnly=true;
			this.Shift12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Shift12S1Box.TabIndex=6;
			this.Shift12S1Box.TabStop=false;
			this.Shift12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Keshik12S1Box
			//
			this.Keshik12S1Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik12S1Box.BorderStyle=BorderStyle.None;
			this.Keshik12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik12S1Box.Location=new System.Drawing.Point(272, 169);
			this.Keshik12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik12S1Box.Mask="90";
			this.Keshik12S1Box.Name="Keshik12S1Box";
			this.Keshik12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik12S1Box.ReadOnly=true;
			this.Keshik12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik12S1Box.TabIndex=7;
			this.Keshik12S1Box.TabStop=false;
			this.Keshik12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Over9A1Box
			//
			this.Over9A1Box.BackColor=System.Drawing.Color.Silver;
			this.Over9A1Box.BorderStyle=BorderStyle.None;
			this.Over9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over9A1Box.Location=new System.Drawing.Point(106, 395);
			this.Over9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Over9A1Box.Mask="90";
			this.Over9A1Box.Name="Over9A1Box";
			this.Over9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over9A1Box.ReadOnly=true;
			this.Over9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Over9A1Box.TabIndex=22;
			this.Over9A1Box.TabStop=false;
			this.Over9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr9A1Box
			//
			this.Kasr9A1Box.BackColor=System.Drawing.Color.White;
			this.Kasr9A1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr9A1Box.Location=new System.Drawing.Point(106, 440);
			this.Kasr9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr9A1Box.Mask="###";
			this.Kasr9A1Box.Name="Kasr9A1Box";
			this.Kasr9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr9A1Box.ReadOnly=true;
			this.Kasr9A1Box.RightToLeft=RightToLeft.No;
			this.Kasr9A1Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr9A1Box.TabIndex=23;
			this.Kasr9A1Box.TabStop=false;
			this.Kasr9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave9A1Box
			//
			this.Leave9A1Box.BackColor=System.Drawing.Color.Silver;
			this.Leave9A1Box.BorderStyle=BorderStyle.None;
			this.Leave9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave9A1Box.Location=new System.Drawing.Point(106, 257);
			this.Leave9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave9A1Box.Mask="90";
			this.Leave9A1Box.Name="Leave9A1Box";
			this.Leave9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave9A1Box.ReadOnly=true;
			this.Leave9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Leave9A1Box.TabIndex=20;
			this.Leave9A1Box.TabStop=false;
			this.Leave9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez9A1Box
			//
			this.Rez9A1Box.BackColor=System.Drawing.Color.White;
			this.Rez9A1Box.BorderStyle=BorderStyle.None;
			this.Rez9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez9A1Box.Location=new System.Drawing.Point(106, 349);
			this.Rez9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez9A1Box.Mask="90";
			this.Rez9A1Box.Name="Rez9A1Box";
			this.Rez9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Rez9A1Box.TabIndex=8;
			this.Rez9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift9A1Box
			//
			this.Shift9A1Box.BackColor=System.Drawing.Color.Silver;
			this.Shift9A1Box.BorderStyle=BorderStyle.None;
			this.Shift9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift9A1Box.Location=new System.Drawing.Point(106, 125);
			this.Shift9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift9A1Box.Mask="90";
			this.Shift9A1Box.Name="Shift9A1Box";
			this.Shift9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift9A1Box.ReadOnly=true;
			this.Shift9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Shift9A1Box.TabIndex=18;
			this.Shift9A1Box.TabStop=false;
			this.Shift9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Keshik9A1Box
			//
			this.Keshik9A1Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik9A1Box.BorderStyle=BorderStyle.None;
			this.Keshik9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik9A1Box.Location=new System.Drawing.Point(106, 169);
			this.Keshik9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik9A1Box.Mask="90";
			this.Keshik9A1Box.Name="Keshik9A1Box";
			this.Keshik9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik9A1Box.ReadOnly=true;
			this.Keshik9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik9A1Box.TabIndex=19;
			this.Keshik9A1Box.TabStop=false;
			this.Keshik9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label9
			//
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.BorderStyle=BorderStyle.FixedSingle;
			this.Label9.Location=new System.Drawing.Point(175, 41);
			this.Label9.Margin=new Padding(5, 0, 5, 0);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(73, 38);
			this.Label9.TabIndex=62;
			this.Label9.Text="9 ساعته صبح";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Over9S1Box
			//
			this.Over9S1Box.BackColor=System.Drawing.Color.Silver;
			this.Over9S1Box.BorderStyle=BorderStyle.None;
			this.Over9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over9S1Box.Location=new System.Drawing.Point(189, 395);
			this.Over9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Over9S1Box.Mask="90";
			this.Over9S1Box.Name="Over9S1Box";
			this.Over9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over9S1Box.ReadOnly=true;
			this.Over9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Over9S1Box.TabIndex=16;
			this.Over9S1Box.TabStop=false;
			this.Over9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr9S1Box
			//
			this.Kasr9S1Box.BackColor=System.Drawing.Color.White;
			this.Kasr9S1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr9S1Box.Location=new System.Drawing.Point(189, 440);
			this.Kasr9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr9S1Box.Mask="###";
			this.Kasr9S1Box.Name="Kasr9S1Box";
			this.Kasr9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr9S1Box.ReadOnly=true;
			this.Kasr9S1Box.RightToLeft=RightToLeft.No;
			this.Kasr9S1Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr9S1Box.TabIndex=17;
			this.Kasr9S1Box.TabStop=false;
			this.Kasr9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave9S1Box
			//
			this.Leave9S1Box.BackColor=System.Drawing.Color.Silver;
			this.Leave9S1Box.BorderStyle=BorderStyle.None;
			this.Leave9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave9S1Box.Location=new System.Drawing.Point(189, 257);
			this.Leave9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave9S1Box.Mask="90";
			this.Leave9S1Box.Name="Leave9S1Box";
			this.Leave9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave9S1Box.ReadOnly=true;
			this.Leave9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Leave9S1Box.TabIndex=14;
			this.Leave9S1Box.TabStop=false;
			this.Leave9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez9S1Box
			//
			this.Rez9S1Box.BackColor=System.Drawing.Color.White;
			this.Rez9S1Box.BorderStyle=BorderStyle.None;
			this.Rez9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez9S1Box.Location=new System.Drawing.Point(189, 349);
			this.Rez9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez9S1Box.Mask="90";
			this.Rez9S1Box.Name="Rez9S1Box";
			this.Rez9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Rez9S1Box.TabIndex=7;
			this.Rez9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift9S1Box
			//
			this.Shift9S1Box.BackColor=System.Drawing.Color.Silver;
			this.Shift9S1Box.BorderStyle=BorderStyle.None;
			this.Shift9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift9S1Box.Location=new System.Drawing.Point(189, 125);
			this.Shift9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift9S1Box.Mask="90";
			this.Shift9S1Box.Name="Shift9S1Box";
			this.Shift9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift9S1Box.ReadOnly=true;
			this.Shift9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Shift9S1Box.TabIndex=12;
			this.Shift9S1Box.TabStop=false;
			this.Shift9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Keshik9S1Box
			//
			this.Keshik9S1Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik9S1Box.BorderStyle=BorderStyle.None;
			this.Keshik9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik9S1Box.Location=new System.Drawing.Point(189, 169);
			this.Keshik9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik9S1Box.Mask="90";
			this.Keshik9S1Box.Name="Keshik9S1Box";
			this.Keshik9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik9S1Box.ReadOnly=true;
			this.Keshik9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik9S1Box.TabIndex=13;
			this.Keshik9S1Box.TabStop=false;
			this.Keshik9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label13
			//
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.BorderStyle=BorderStyle.FixedSingle;
			this.Label13.Location=new System.Drawing.Point(9, 41);
			this.Label13.Margin=new Padding(5, 0, 5, 0);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(73, 38);
			this.Label13.TabIndex=76;
			this.Label13.Text="ستادی";
			this.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//OverSet1Box
			//
			this.OverSet1Box.BackColor=System.Drawing.Color.Silver;
			this.OverSet1Box.BorderStyle=BorderStyle.None;
			this.OverSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.OverSet1Box.Location=new System.Drawing.Point(23, 395);
			this.OverSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.OverSet1Box.Mask="90";
			this.OverSet1Box.Name="OverSet1Box";
			this.OverSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.OverSet1Box.ReadOnly=true;
			this.OverSet1Box.Size=new System.Drawing.Size(45, 25);
			this.OverSet1Box.TabIndex=28;
			this.OverSet1Box.TabStop=false;
			this.OverSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//KasrSet1Box
			//
			this.KasrSet1Box.BackColor=System.Drawing.Color.White;
			this.KasrSet1Box.BorderStyle=BorderStyle.FixedSingle;
			this.KasrSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KasrSet1Box.Location=new System.Drawing.Point(23, 440);
			this.KasrSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.KasrSet1Box.Mask="###";
			this.KasrSet1Box.Name="KasrSet1Box";
			this.KasrSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KasrSet1Box.ReadOnly=true;
			this.KasrSet1Box.RightToLeft=RightToLeft.No;
			this.KasrSet1Box.Size=new System.Drawing.Size(45, 32);
			this.KasrSet1Box.TabIndex=29;
			this.KasrSet1Box.TabStop=false;
			this.KasrSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//LeaveSet1Box
			//
			this.LeaveSet1Box.BackColor=System.Drawing.Color.Silver;
			this.LeaveSet1Box.BorderStyle=BorderStyle.None;
			this.LeaveSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LeaveSet1Box.Location=new System.Drawing.Point(23, 257);
			this.LeaveSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.LeaveSet1Box.Mask="90";
			this.LeaveSet1Box.Name="LeaveSet1Box";
			this.LeaveSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.LeaveSet1Box.ReadOnly=true;
			this.LeaveSet1Box.Size=new System.Drawing.Size(45, 25);
			this.LeaveSet1Box.TabIndex=26;
			this.LeaveSet1Box.TabStop=false;
			this.LeaveSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//RezSet1Box
			//
			this.RezSet1Box.BackColor=System.Drawing.Color.White;
			this.RezSet1Box.BorderStyle=BorderStyle.None;
			this.RezSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RezSet1Box.Location=new System.Drawing.Point(23, 349);
			this.RezSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.RezSet1Box.Mask="90";
			this.RezSet1Box.Name="RezSet1Box";
			this.RezSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.RezSet1Box.Size=new System.Drawing.Size(45, 25);
			this.RezSet1Box.TabIndex=9;
			this.RezSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftSet1Box
			//
			this.ShiftSet1Box.BackColor=System.Drawing.Color.Silver;
			this.ShiftSet1Box.BorderStyle=BorderStyle.None;
			this.ShiftSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftSet1Box.Location=new System.Drawing.Point(23, 125);
			this.ShiftSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.ShiftSet1Box.Mask="90";
			this.ShiftSet1Box.Name="ShiftSet1Box";
			this.ShiftSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ShiftSet1Box.ReadOnly=true;
			this.ShiftSet1Box.Size=new System.Drawing.Size(45, 25);
			this.ShiftSet1Box.TabIndex=24;
			this.ShiftSet1Box.TabStop=false;
			this.ShiftSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshikSet1Box
			//
			this.KeshikSet1Box.BackColor=System.Drawing.Color.Silver;
			this.KeshikSet1Box.BorderStyle=BorderStyle.None;
			this.KeshikSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KeshikSet1Box.Location=new System.Drawing.Point(23, 169);
			this.KeshikSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.KeshikSet1Box.Mask="90";
			this.KeshikSet1Box.Name="KeshikSet1Box";
			this.KeshikSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshikSet1Box.ReadOnly=true;
			this.KeshikSet1Box.Size=new System.Drawing.Size(45, 25);
			this.KeshikSet1Box.TabIndex=25;
			this.KeshikSet1Box.TabStop=false;
			this.KeshikSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label16
			//
			this.Label16.BackColor=System.Drawing.Color.Transparent;
			this.Label16.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label16.ForeColor=System.Drawing.Color.Black;
			this.Label16.Location=new System.Drawing.Point(2, 146);
			this.Label16.Margin=new Padding(5, 0, 5, 0);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(418, 25);
			this.Label16.TabIndex=116;
			this.Label16.Text=resources.GetString("Label16.Text");
			this.Label16.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Transparent;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PersianCalendar);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.NameCombo);
			this.Panel1.Controls.Add(this.Label30);
			this.Panel1.Controls.Add(this.PrintButton);
			this.Panel1.Controls.Add(this.ProcessButton);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(7, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(983, 56);
			this.Panel1.TabIndex=0;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(819, 17);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(115, 23);
			this.PersianCalendar.TabIndex=50;
			//
			//Label30
			//
			this.Label30.AutoSize=true;
			this.Label30.BackColor=System.Drawing.Color.Transparent;
			this.Label30.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label30.ForeColor=System.Drawing.Color.Black;
			this.Label30.Location=new System.Drawing.Point(934, 19);
			this.Label30.Margin=new Padding(4, 0, 4, 0);
			this.Label30.Name="Label30";
			this.Label30.Size=new System.Drawing.Size(39, 16);
			this.Label30.TabIndex=49;
			this.Label30.Text="تاریخ:";
			this.Label30.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//PrintButton
			//
			this.PrintButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.PrintButton.Image=global::Metro_Operation.Properties.Resources.print_button;
			this.PrintButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.PrintButton.Cursor=Cursors.Hand;
			
			this.PrintButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PrintButton.ForeColor=System.Drawing.Color.Black;
			this.PrintButton.Location=new System.Drawing.Point(11, 8);
			this.PrintButton.Margin=new Padding(5, 6, 5, 6);
			this.PrintButton.Name="PrintButton";
			this.PrintButton.Size=new System.Drawing.Size(135, 39);
			this.PrintButton.TabIndex=4;
			this.PrintButton.Text="چاپ";
			this.PrintButton.UseVisualStyleBackColor=false;
			//
			//ProcessButton
			//
			this.ProcessButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ProcessButton.Image=global::Metro_Operation.Properties.Resources.to_do_list;
			this.ProcessButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ProcessButton.Cursor=Cursors.Hand;
			this.ProcessButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ProcessButton.ForeColor=System.Drawing.Color.Black;
			this.ProcessButton.Location=new System.Drawing.Point(153, 8);
			this.ProcessButton.Margin=new Padding(5, 6, 5, 6);
			this.ProcessButton.Name="ProcessButton";
			this.ProcessButton.Size=new System.Drawing.Size(135, 39);
			this.ProcessButton.TabIndex=3;
			this.ProcessButton.Text="پردازش";
			this.ProcessButton.UseVisualStyleBackColor=false;
			//
			//Local1Label
			//
			this.Local1Label.BackColor=System.Drawing.Color.Blue;
			this.Local1Label.Font=new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Local1Label.ForeColor=System.Drawing.Color.Yellow;
			this.Local1Label.Location=new System.Drawing.Point(0, 0);
			this.Local1Label.Margin=new Padding(5, 0, 5, 0);
			this.Local1Label.Name="Local1Label";
			this.Local1Label.Size=new System.Drawing.Size(422, 31);
			this.Local1Label.TabIndex=122;
			this.Local1Label.Text="9 ساعته صبح";
			this.Local1Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Silver;
			this.Panel2.Controls.Add(this.Local1Label);
			this.Panel2.Controls.Add(this.Label13);
			this.Panel2.Controls.Add(this.Keshik12R1Box);
			this.Panel2.Controls.Add(this.All12R1Box);
			this.Panel2.Controls.Add(this.Shift12R1Box);
			this.Panel2.Controls.Add(this.Daem12R1Box);
			this.Panel2.Controls.Add(this.Rez12R1Box);
			this.Panel2.Controls.Add(this.Leave12R1Box);
			this.Panel2.Controls.Add(this.Kasr12R1Box);
			this.Panel2.Controls.Add(this.Class12R1Box);
			this.Panel2.Controls.Add(this.Over12R1Box);
			this.Panel2.Controls.Add(this.Label1a);
			this.Panel2.Controls.Add(this.All12S1Box);
			this.Panel2.Controls.Add(this.Keshik12S1Box);
			this.Panel2.Controls.Add(this.Shift12S1Box);
			this.Panel2.Controls.Add(this.Daem12S1Box);
			this.Panel2.Controls.Add(this.Rez12S1Box);
			this.Panel2.Controls.Add(this.Leave12S1Box);
			this.Panel2.Controls.Add(this.Class12S1Box);
			this.Panel2.Controls.Add(this.Kasr12S1Box);
			this.Panel2.Controls.Add(this.Over12S1Box);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Controls.Add(this.All9S1Box);
			this.Panel2.Controls.Add(this.Keshik9S1Box);
			this.Panel2.Controls.Add(this.Daem9S1Box);
			this.Panel2.Controls.Add(this.Shift9S1Box);
			this.Panel2.Controls.Add(this.Rez9S1Box);
			this.Panel2.Controls.Add(this.Leave9S1Box);
			this.Panel2.Controls.Add(this.Class9S1Box);
			this.Panel2.Controls.Add(this.Kasr9S1Box);
			this.Panel2.Controls.Add(this.Over9S1Box);
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.All9A1Box);
			this.Panel2.Controls.Add(this.Keshik9A1Box);
			this.Panel2.Controls.Add(this.Daem9A1Box);
			this.Panel2.Controls.Add(this.Shift9A1Box);
			this.Panel2.Controls.Add(this.Rez9A1Box);
			this.Panel2.Controls.Add(this.Leave9A1Box);
			this.Panel2.Controls.Add(this.Class9A1Box);
			this.Panel2.Controls.Add(this.Kasr9A1Box);
			this.Panel2.Controls.Add(this.Over9A1Box);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.AllSet1Box);
			this.Panel2.Controls.Add(this.KeshikSet1Box);
			this.Panel2.Controls.Add(this.ClassSet1Box);
			this.Panel2.Controls.Add(this.ShiftSet1Box);
			this.Panel2.Controls.Add(this.DaemSet1Box);
			this.Panel2.Controls.Add(this.OverSet1Box);
			this.Panel2.Controls.Add(this.RezSet1Box);
			this.Panel2.Controls.Add(this.KasrSet1Box);
			this.Panel2.Controls.Add(this.Label33);
			this.Panel2.Controls.Add(this.LeaveSet1Box);
			this.Panel2.Controls.Add(this.Label22);
			this.Panel2.Controls.Add(this.Label35);
			this.Panel2.Controls.Add(this.Label21);
			this.Panel2.Controls.Add(this.Label20);
			this.Panel2.Controls.Add(this.Label10);
			this.Panel2.Controls.Add(this.Label16);
			this.Panel2.Controls.Add(this.Label19);
			this.Panel2.Location=new System.Drawing.Point(440, 79);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(422, 479);
			this.Panel2.TabIndex=1;
			//
			//All12R1Box
			//
			this.All12R1Box.BackColor=System.Drawing.Color.Silver;
			this.All12R1Box.BorderStyle=BorderStyle.None;
			this.All12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All12R1Box.Location=new System.Drawing.Point(355, 84);
			this.All12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.All12R1Box.Mask="90";
			this.All12R1Box.Name="All12R1Box";
			this.All12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All12R1Box.ReadOnly=true;
			this.All12R1Box.Size=new System.Drawing.Size(45, 25);
			this.All12R1Box.TabIndex=0;
			this.All12R1Box.TabStop=false;
			this.All12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem12R1Box
			//
			this.Daem12R1Box.BackColor=System.Drawing.Color.White;
			this.Daem12R1Box.BorderStyle=BorderStyle.None;
			this.Daem12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem12R1Box.Location=new System.Drawing.Point(355, 213);
			this.Daem12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem12R1Box.Mask="90";
			this.Daem12R1Box.Name="Daem12R1Box";
			this.Daem12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Daem12R1Box.TabIndex=0;
			this.Daem12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class12R1Box
			//
			this.Class12R1Box.BackColor=System.Drawing.Color.Silver;
			this.Class12R1Box.BorderStyle=BorderStyle.None;
			this.Class12R1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class12R1Box.Location=new System.Drawing.Point(355, 303);
			this.Class12R1Box.Margin=new Padding(3, 4, 3, 4);
			this.Class12R1Box.Mask="90";
			this.Class12R1Box.Name="Class12R1Box";
			this.Class12R1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class12R1Box.ReadOnly=true;
			this.Class12R1Box.Size=new System.Drawing.Size(45, 25);
			this.Class12R1Box.TabIndex=4;
			this.Class12R1Box.TabStop=false;
			this.Class12R1Box.TextAlign=HorizontalAlignment.Center;
			//
			//All12S1Box
			//
			this.All12S1Box.BackColor=System.Drawing.Color.Silver;
			this.All12S1Box.BorderStyle=BorderStyle.None;
			this.All12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All12S1Box.Location=new System.Drawing.Point(272, 84);
			this.All12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.All12S1Box.Mask="90";
			this.All12S1Box.Name="All12S1Box";
			this.All12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All12S1Box.ReadOnly=true;
			this.All12S1Box.Size=new System.Drawing.Size(45, 25);
			this.All12S1Box.TabIndex=6;
			this.All12S1Box.TabStop=false;
			this.All12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem12S1Box
			//
			this.Daem12S1Box.BackColor=System.Drawing.Color.White;
			this.Daem12S1Box.BorderStyle=BorderStyle.None;
			this.Daem12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem12S1Box.Location=new System.Drawing.Point(272, 213);
			this.Daem12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem12S1Box.Mask="90";
			this.Daem12S1Box.Name="Daem12S1Box";
			this.Daem12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Daem12S1Box.TabIndex=1;
			this.Daem12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class12S1Box
			//
			this.Class12S1Box.BackColor=System.Drawing.Color.Silver;
			this.Class12S1Box.BorderStyle=BorderStyle.None;
			this.Class12S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class12S1Box.Location=new System.Drawing.Point(272, 303);
			this.Class12S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Class12S1Box.Mask="90";
			this.Class12S1Box.Name="Class12S1Box";
			this.Class12S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class12S1Box.ReadOnly=true;
			this.Class12S1Box.Size=new System.Drawing.Size(45, 25);
			this.Class12S1Box.TabIndex=10;
			this.Class12S1Box.TabStop=false;
			this.Class12S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//All9S1Box
			//
			this.All9S1Box.BackColor=System.Drawing.Color.Silver;
			this.All9S1Box.BorderStyle=BorderStyle.None;
			this.All9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All9S1Box.Location=new System.Drawing.Point(189, 84);
			this.All9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.All9S1Box.Mask="90";
			this.All9S1Box.Name="All9S1Box";
			this.All9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All9S1Box.ReadOnly=true;
			this.All9S1Box.Size=new System.Drawing.Size(45, 25);
			this.All9S1Box.TabIndex=12;
			this.All9S1Box.TabStop=false;
			this.All9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem9S1Box
			//
			this.Daem9S1Box.BackColor=System.Drawing.Color.White;
			this.Daem9S1Box.BorderStyle=BorderStyle.None;
			this.Daem9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem9S1Box.Location=new System.Drawing.Point(189, 213);
			this.Daem9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem9S1Box.Mask="90";
			this.Daem9S1Box.Name="Daem9S1Box";
			this.Daem9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Daem9S1Box.TabIndex=2;
			this.Daem9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class9S1Box
			//
			this.Class9S1Box.BackColor=System.Drawing.Color.Silver;
			this.Class9S1Box.BorderStyle=BorderStyle.None;
			this.Class9S1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class9S1Box.Location=new System.Drawing.Point(189, 303);
			this.Class9S1Box.Margin=new Padding(3, 4, 3, 4);
			this.Class9S1Box.Mask="90";
			this.Class9S1Box.Name="Class9S1Box";
			this.Class9S1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class9S1Box.ReadOnly=true;
			this.Class9S1Box.Size=new System.Drawing.Size(45, 25);
			this.Class9S1Box.TabIndex=16;
			this.Class9S1Box.TabStop=false;
			this.Class9S1Box.TextAlign=HorizontalAlignment.Center;
			//
			//All9A1Box
			//
			this.All9A1Box.BackColor=System.Drawing.Color.Silver;
			this.All9A1Box.BorderStyle=BorderStyle.None;
			this.All9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All9A1Box.Location=new System.Drawing.Point(106, 84);
			this.All9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.All9A1Box.Mask="90";
			this.All9A1Box.Name="All9A1Box";
			this.All9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All9A1Box.ReadOnly=true;
			this.All9A1Box.Size=new System.Drawing.Size(45, 25);
			this.All9A1Box.TabIndex=18;
			this.All9A1Box.TabStop=false;
			this.All9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem9A1Box
			//
			this.Daem9A1Box.BackColor=System.Drawing.Color.White;
			this.Daem9A1Box.BorderStyle=BorderStyle.None;
			this.Daem9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem9A1Box.Location=new System.Drawing.Point(106, 213);
			this.Daem9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem9A1Box.Mask="90";
			this.Daem9A1Box.Name="Daem9A1Box";
			this.Daem9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Daem9A1Box.TabIndex=3;
			this.Daem9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class9A1Box
			//
			this.Class9A1Box.BackColor=System.Drawing.Color.Silver;
			this.Class9A1Box.BorderStyle=BorderStyle.None;
			this.Class9A1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class9A1Box.Location=new System.Drawing.Point(106, 303);
			this.Class9A1Box.Margin=new Padding(3, 4, 3, 4);
			this.Class9A1Box.Mask="90";
			this.Class9A1Box.Name="Class9A1Box";
			this.Class9A1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class9A1Box.ReadOnly=true;
			this.Class9A1Box.Size=new System.Drawing.Size(45, 25);
			this.Class9A1Box.TabIndex=22;
			this.Class9A1Box.TabStop=false;
			this.Class9A1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label8
			//
			this.Label8.BackColor=System.Drawing.Color.Transparent;
			this.Label8.BorderStyle=BorderStyle.FixedSingle;
			this.Label8.Location=new System.Drawing.Point(92, 41);
			this.Label8.Margin=new Padding(5, 0, 5, 0);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(73, 38);
			this.Label8.TabIndex=69;
			this.Label8.Text="9 ساعته عصر";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//AllSet1Box
			//
			this.AllSet1Box.BackColor=System.Drawing.Color.Silver;
			this.AllSet1Box.BorderStyle=BorderStyle.None;
			this.AllSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AllSet1Box.Location=new System.Drawing.Point(23, 84);
			this.AllSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.AllSet1Box.Mask="90";
			this.AllSet1Box.Name="AllSet1Box";
			this.AllSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.AllSet1Box.ReadOnly=true;
			this.AllSet1Box.Size=new System.Drawing.Size(45, 25);
			this.AllSet1Box.TabIndex=24;
			this.AllSet1Box.TabStop=false;
			this.AllSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//ClassSet1Box
			//
			this.ClassSet1Box.BackColor=System.Drawing.Color.Silver;
			this.ClassSet1Box.BorderStyle=BorderStyle.None;
			this.ClassSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ClassSet1Box.Location=new System.Drawing.Point(23, 303);
			this.ClassSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.ClassSet1Box.Mask="90";
			this.ClassSet1Box.Name="ClassSet1Box";
			this.ClassSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ClassSet1Box.ReadOnly=true;
			this.ClassSet1Box.Size=new System.Drawing.Size(45, 25);
			this.ClassSet1Box.TabIndex=28;
			this.ClassSet1Box.TabStop=false;
			this.ClassSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//DaemSet1Box
			//
			this.DaemSet1Box.BackColor=System.Drawing.Color.White;
			this.DaemSet1Box.BorderStyle=BorderStyle.None;
			this.DaemSet1Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DaemSet1Box.Location=new System.Drawing.Point(23, 213);
			this.DaemSet1Box.Margin=new Padding(3, 4, 3, 4);
			this.DaemSet1Box.Mask="90";
			this.DaemSet1Box.Name="DaemSet1Box";
			this.DaemSet1Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.DaemSet1Box.Size=new System.Drawing.Size(45, 25);
			this.DaemSet1Box.TabIndex=4;
			this.DaemSet1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label33
			//
			this.Label33.BackColor=System.Drawing.Color.Transparent;
			this.Label33.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label33.ForeColor=System.Drawing.Color.Black;
			this.Label33.Location=new System.Drawing.Point(2, 373);
			this.Label33.Margin=new Padding(5, 0, 5, 0);
			this.Label33.Name="Label33";
			this.Label33.Size=new System.Drawing.Size(418, 25);
			this.Label33.TabIndex=126;
			this.Label33.Text=resources.GetString("Label33.Text");
			this.Label33.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label22
			//
			this.Label22.BackColor=System.Drawing.Color.Transparent;
			this.Label22.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label22.ForeColor=System.Drawing.Color.Black;
			this.Label22.Location=new System.Drawing.Point(2, 417);
			this.Label22.Margin=new Padding(5, 0, 5, 0);
			this.Label22.Name="Label22";
			this.Label22.Size=new System.Drawing.Size(418, 25);
			this.Label22.TabIndex=126;
			this.Label22.Text=resources.GetString("Label22.Text");
			this.Label22.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label35
			//
			this.Label35.BackColor=System.Drawing.Color.Transparent;
			this.Label35.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label35.ForeColor=System.Drawing.Color.Black;
			this.Label35.Location=new System.Drawing.Point(2, 190);
			this.Label35.Margin=new Padding(5, 0, 5, 0);
			this.Label35.Name="Label35";
			this.Label35.Size=new System.Drawing.Size(418, 25);
			this.Label35.TabIndex=124;
			this.Label35.Text=resources.GetString("Label35.Text");
			this.Label35.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label21
			//
			this.Label21.BackColor=System.Drawing.Color.Transparent;
			this.Label21.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label21.ForeColor=System.Drawing.Color.Black;
			this.Label21.Location=new System.Drawing.Point(2, 281);
			this.Label21.Margin=new Padding(5, 0, 5, 0);
			this.Label21.Name="Label21";
			this.Label21.Size=new System.Drawing.Size(418, 25);
			this.Label21.TabIndex=125;
			this.Label21.Text=resources.GetString("Label21.Text");
			this.Label21.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label20
			//
			this.Label20.BackColor=System.Drawing.Color.Transparent;
			this.Label20.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label20.ForeColor=System.Drawing.Color.Black;
			this.Label20.Location=new System.Drawing.Point(2, 327);
			this.Label20.Margin=new Padding(5, 0, 5, 0);
			this.Label20.Name="Label20";
			this.Label20.Size=new System.Drawing.Size(418, 25);
			this.Label20.TabIndex=124;
			this.Label20.Text=resources.GetString("Label20.Text");
			this.Label20.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label10
			//
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label10.ForeColor=System.Drawing.Color.Black;
			this.Label10.Location=new System.Drawing.Point(2, 104);
			this.Label10.Margin=new Padding(5, 0, 5, 0);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(418, 25);
			this.Label10.TabIndex=116;
			this.Label10.Text=resources.GetString("Label10.Text");
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label19
			//
			this.Label19.BackColor=System.Drawing.Color.Transparent;
			this.Label19.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label19.ForeColor=System.Drawing.Color.Black;
			this.Label19.Location=new System.Drawing.Point(2, 235);
			this.Label19.Margin=new Padding(5, 0, 5, 0);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(418, 25);
			this.Label19.TabIndex=123;
			this.Label19.Text=resources.GetString("Label19.Text");
			this.Label19.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn5, this.DataGridViewTextBoxColumn6, this.DataGridViewTextBoxColumn7, this.Column6});
			this.DataGridView1.Location=new System.Drawing.Point(578, 67);
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.Size=new System.Drawing.Size(281, 220);
			this.DataGridView1.TabIndex=39;
			this.DataGridView1.Visible=false;
			//
			//DataGridViewTextBoxColumn5
			//
			this.DataGridViewTextBoxColumn5.HeaderText="نام";
			this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly=true;
			this.DataGridViewTextBoxColumn5.Width=50;
			//
			//DataGridViewTextBoxColumn6
			//
			this.DataGridViewTextBoxColumn6.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn6.HeaderText="نام خانوادگی";
			this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
			this.DataGridViewTextBoxColumn6.ReadOnly=true;
			//
			//DataGridViewTextBoxColumn7
			//
			this.DataGridViewTextBoxColumn7.HeaderText="پرسنلی";
			this.DataGridViewTextBoxColumn7.Name="DataGridViewTextBoxColumn7";
			this.DataGridViewTextBoxColumn7.ReadOnly=true;
			this.DataGridViewTextBoxColumn7.Width=60;
			//
			//Column6
			//
			this.Column6.HeaderText="شیفت";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=60;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows=false;
			this.DataGridView2.AllowUserToDeleteRows=false;
			this.DataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.Column5});
			this.DataGridView2.Location=new System.Drawing.Point(294, 67);
			this.DataGridView2.Name="DataGridView2";
			this.DataGridView2.ReadOnly=true;
			this.DataGridView2.RowHeadersVisible=false;
			this.DataGridView2.Size=new System.Drawing.Size(281, 220);
			this.DataGridView2.TabIndex=39;
			this.DataGridView2.Visible=false;
			//
			//DataGridViewTextBoxColumn1
			//
			this.DataGridViewTextBoxColumn1.HeaderText="نام";
			this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly=true;
			this.DataGridViewTextBoxColumn1.Width=50;
			//
			//DataGridViewTextBoxColumn2
			//
			this.DataGridViewTextBoxColumn2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn2.HeaderText="نام خانوادگی";
			this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly=true;
			//
			//DataGridViewTextBoxColumn3
			//
			this.DataGridViewTextBoxColumn3.HeaderText="پرسنلی";
			this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly=true;
			this.DataGridViewTextBoxColumn3.Width=60;
			//
			//Column5
			//
			this.Column5.HeaderText="شیفت";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=60;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.Silver;
			this.Panel3.Controls.Add(this.Keshik12R2Box);
			this.Panel3.Controls.Add(this.All12R2Box);
			this.Panel3.Controls.Add(this.Shift12R2Box);
			this.Panel3.Controls.Add(this.Daem12R2Box);
			this.Panel3.Controls.Add(this.Class12R2Box);
			this.Panel3.Controls.Add(this.Rez12R2Box);
			this.Panel3.Controls.Add(this.Leave12R2Box);
			this.Panel3.Controls.Add(this.Kasr12R2Box);
			this.Panel3.Controls.Add(this.Over12R2Box);
			this.Panel3.Controls.Add(this.Label12);
			this.Panel3.Controls.Add(this.Keshik12S2Box);
			this.Panel3.Controls.Add(this.All12S2Box);
			this.Panel3.Controls.Add(this.Shift12S2Box);
			this.Panel3.Controls.Add(this.Class12S2Box);
			this.Panel3.Controls.Add(this.Daem12S2Box);
			this.Panel3.Controls.Add(this.Rez12S2Box);
			this.Panel3.Controls.Add(this.Leave12S2Box);
			this.Panel3.Controls.Add(this.Kasr12S2Box);
			this.Panel3.Controls.Add(this.Over12S2Box);
			this.Panel3.Controls.Add(this.Label14);
			this.Panel3.Controls.Add(this.Keshik9S2Box);
			this.Panel3.Controls.Add(this.All9S2Box);
			this.Panel3.Controls.Add(this.Shift9S2Box);
			this.Panel3.Controls.Add(this.Class9S2Box);
			this.Panel3.Controls.Add(this.Daem9S2Box);
			this.Panel3.Controls.Add(this.Rez9S2Box);
			this.Panel3.Controls.Add(this.Leave9S2Box);
			this.Panel3.Controls.Add(this.Kasr9S2Box);
			this.Panel3.Controls.Add(this.Over9S2Box);
			this.Panel3.Controls.Add(this.Label15);
			this.Panel3.Controls.Add(this.All9A2Box);
			this.Panel3.Controls.Add(this.Keshik9A2Box);
			this.Panel3.Controls.Add(this.Shift9A2Box);
			this.Panel3.Controls.Add(this.Class9A2Box);
			this.Panel3.Controls.Add(this.Rez9A2Box);
			this.Panel3.Controls.Add(this.Daem9A2Box);
			this.Panel3.Controls.Add(this.Leave9A2Box);
			this.Panel3.Controls.Add(this.Kasr9A2Box);
			this.Panel3.Controls.Add(this.Over9A2Box);
			this.Panel3.Controls.Add(this.Label24);
			this.Panel3.Controls.Add(this.AllSet2Box);
			this.Panel3.Controls.Add(this.KeshikSet2Box);
			this.Panel3.Controls.Add(this.ShiftSet2Box);
			this.Panel3.Controls.Add(this.OverSet2Box);
			this.Panel3.Controls.Add(this.ClassSet2Box);
			this.Panel3.Controls.Add(this.RezSet2Box);
			this.Panel3.Controls.Add(this.KasrSet2Box);
			this.Panel3.Controls.Add(this.LeaveSet2Box);
			this.Panel3.Controls.Add(this.DaemSet2Box);
			this.Panel3.Controls.Add(this.Label25);
			this.Panel3.Controls.Add(this.Label26);
			this.Panel3.Controls.Add(this.Label37);
			this.Panel3.Controls.Add(this.Label34);
			this.Panel3.Controls.Add(this.Label27);
			this.Panel3.Controls.Add(this.Label31);
			this.Panel3.Controls.Add(this.Label28);
			this.Panel3.Controls.Add(this.Label29);
			this.Panel3.Controls.Add(this.Local2Label);
			this.Panel3.Controls.Add(this.Label11);
			this.Panel3.Location=new System.Drawing.Point(7, 79);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(422, 479);
			this.Panel3.TabIndex=2;
			//
			//Keshik12R2Box
			//
			this.Keshik12R2Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik12R2Box.BorderStyle=BorderStyle.None;
			this.Keshik12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik12R2Box.Location=new System.Drawing.Point(355, 169);
			this.Keshik12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik12R2Box.Mask="90";
			this.Keshik12R2Box.Name="Keshik12R2Box";
			this.Keshik12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik12R2Box.ReadOnly=true;
			this.Keshik12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik12R2Box.TabIndex=1;
			this.Keshik12R2Box.TabStop=false;
			this.Keshik12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//All12R2Box
			//
			this.All12R2Box.BackColor=System.Drawing.Color.Silver;
			this.All12R2Box.BorderStyle=BorderStyle.None;
			this.All12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All12R2Box.Location=new System.Drawing.Point(355, 88);
			this.All12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.All12R2Box.Mask="90";
			this.All12R2Box.Name="All12R2Box";
			this.All12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All12R2Box.ReadOnly=true;
			this.All12R2Box.Size=new System.Drawing.Size(45, 25);
			this.All12R2Box.TabIndex=0;
			this.All12R2Box.TabStop=false;
			this.All12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift12R2Box
			//
			this.Shift12R2Box.BackColor=System.Drawing.Color.Silver;
			this.Shift12R2Box.BorderStyle=BorderStyle.None;
			this.Shift12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift12R2Box.Location=new System.Drawing.Point(355, 128);
			this.Shift12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift12R2Box.Mask="90";
			this.Shift12R2Box.Name="Shift12R2Box";
			this.Shift12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift12R2Box.ReadOnly=true;
			this.Shift12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Shift12R2Box.TabIndex=0;
			this.Shift12R2Box.TabStop=false;
			this.Shift12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem12R2Box
			//
			this.Daem12R2Box.BackColor=System.Drawing.Color.White;
			this.Daem12R2Box.BorderStyle=BorderStyle.None;
			this.Daem12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem12R2Box.Location=new System.Drawing.Point(353, 213);
			this.Daem12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem12R2Box.Mask="90";
			this.Daem12R2Box.Name="Daem12R2Box";
			this.Daem12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Daem12R2Box.TabIndex=0;
			this.Daem12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class12R2Box
			//
			this.Class12R2Box.BackColor=System.Drawing.Color.Silver;
			this.Class12R2Box.BorderStyle=BorderStyle.None;
			this.Class12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class12R2Box.Location=new System.Drawing.Point(355, 300);
			this.Class12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Class12R2Box.Mask="90";
			this.Class12R2Box.Name="Class12R2Box";
			this.Class12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class12R2Box.ReadOnly=true;
			this.Class12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Class12R2Box.TabIndex=0;
			this.Class12R2Box.TabStop=false;
			this.Class12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez12R2Box
			//
			this.Rez12R2Box.BackColor=System.Drawing.Color.White;
			this.Rez12R2Box.BorderStyle=BorderStyle.None;
			this.Rez12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez12R2Box.Location=new System.Drawing.Point(355, 349);
			this.Rez12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez12R2Box.Mask="90";
			this.Rez12R2Box.Name="Rez12R2Box";
			this.Rez12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Rez12R2Box.TabIndex=5;
			this.Rez12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave12R2Box
			//
			this.Leave12R2Box.BackColor=System.Drawing.Color.Silver;
			this.Leave12R2Box.BorderStyle=BorderStyle.None;
			this.Leave12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave12R2Box.Location=new System.Drawing.Point(355, 257);
			this.Leave12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave12R2Box.Mask="90";
			this.Leave12R2Box.Name="Leave12R2Box";
			this.Leave12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave12R2Box.ReadOnly=true;
			this.Leave12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Leave12R2Box.TabIndex=2;
			this.Leave12R2Box.TabStop=false;
			this.Leave12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr12R2Box
			//
			this.Kasr12R2Box.BackColor=System.Drawing.Color.White;
			this.Kasr12R2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr12R2Box.Location=new System.Drawing.Point(355, 440);
			this.Kasr12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr12R2Box.Mask="###";
			this.Kasr12R2Box.Name="Kasr12R2Box";
			this.Kasr12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr12R2Box.ReadOnly=true;
			this.Kasr12R2Box.RightToLeft=RightToLeft.No;
			this.Kasr12R2Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr12R2Box.TabIndex=5;
			this.Kasr12R2Box.TabStop=false;
			this.Kasr12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Over12R2Box
			//
			this.Over12R2Box.BackColor=System.Drawing.Color.Silver;
			this.Over12R2Box.BorderStyle=BorderStyle.None;
			this.Over12R2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over12R2Box.Location=new System.Drawing.Point(355, 395);
			this.Over12R2Box.Margin=new Padding(3, 4, 3, 4);
			this.Over12R2Box.Mask="90";
			this.Over12R2Box.Name="Over12R2Box";
			this.Over12R2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over12R2Box.ReadOnly=true;
			this.Over12R2Box.Size=new System.Drawing.Size(45, 25);
			this.Over12R2Box.TabIndex=4;
			this.Over12R2Box.TabStop=false;
			this.Over12R2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label12
			//
			this.Label12.BackColor=System.Drawing.Color.Transparent;
			this.Label12.BorderStyle=BorderStyle.FixedSingle;
			this.Label12.Location=new System.Drawing.Point(335, 44);
			this.Label12.Margin=new Padding(5, 0, 5, 0);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(73, 38);
			this.Label12.TabIndex=48;
			this.Label12.Text="12 ساعته روز";
			this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Keshik12S2Box
			//
			this.Keshik12S2Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik12S2Box.BorderStyle=BorderStyle.None;
			this.Keshik12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik12S2Box.Location=new System.Drawing.Point(270, 169);
			this.Keshik12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik12S2Box.Mask="90";
			this.Keshik12S2Box.Name="Keshik12S2Box";
			this.Keshik12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik12S2Box.ReadOnly=true;
			this.Keshik12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik12S2Box.TabIndex=7;
			this.Keshik12S2Box.TabStop=false;
			this.Keshik12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//All12S2Box
			//
			this.All12S2Box.BackColor=System.Drawing.Color.Silver;
			this.All12S2Box.BorderStyle=BorderStyle.None;
			this.All12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All12S2Box.Location=new System.Drawing.Point(270, 88);
			this.All12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.All12S2Box.Mask="90";
			this.All12S2Box.Name="All12S2Box";
			this.All12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All12S2Box.ReadOnly=true;
			this.All12S2Box.Size=new System.Drawing.Size(45, 25);
			this.All12S2Box.TabIndex=6;
			this.All12S2Box.TabStop=false;
			this.All12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift12S2Box
			//
			this.Shift12S2Box.BackColor=System.Drawing.Color.Silver;
			this.Shift12S2Box.BorderStyle=BorderStyle.None;
			this.Shift12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift12S2Box.Location=new System.Drawing.Point(270, 128);
			this.Shift12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift12S2Box.Mask="90";
			this.Shift12S2Box.Name="Shift12S2Box";
			this.Shift12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift12S2Box.ReadOnly=true;
			this.Shift12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Shift12S2Box.TabIndex=6;
			this.Shift12S2Box.TabStop=false;
			this.Shift12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class12S2Box
			//
			this.Class12S2Box.BackColor=System.Drawing.Color.Silver;
			this.Class12S2Box.BorderStyle=BorderStyle.None;
			this.Class12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class12S2Box.Location=new System.Drawing.Point(270, 300);
			this.Class12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Class12S2Box.Mask="90";
			this.Class12S2Box.Name="Class12S2Box";
			this.Class12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class12S2Box.ReadOnly=true;
			this.Class12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Class12S2Box.TabIndex=1;
			this.Class12S2Box.TabStop=false;
			this.Class12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem12S2Box
			//
			this.Daem12S2Box.BackColor=System.Drawing.Color.White;
			this.Daem12S2Box.BorderStyle=BorderStyle.None;
			this.Daem12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem12S2Box.Location=new System.Drawing.Point(270, 213);
			this.Daem12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem12S2Box.Mask="90";
			this.Daem12S2Box.Name="Daem12S2Box";
			this.Daem12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Daem12S2Box.TabIndex=1;
			this.Daem12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez12S2Box
			//
			this.Rez12S2Box.BackColor=System.Drawing.Color.White;
			this.Rez12S2Box.BorderStyle=BorderStyle.None;
			this.Rez12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez12S2Box.Location=new System.Drawing.Point(270, 349);
			this.Rez12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez12S2Box.Mask="90";
			this.Rez12S2Box.Name="Rez12S2Box";
			this.Rez12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Rez12S2Box.TabIndex=6;
			this.Rez12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave12S2Box
			//
			this.Leave12S2Box.BackColor=System.Drawing.Color.Silver;
			this.Leave12S2Box.BorderStyle=BorderStyle.None;
			this.Leave12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave12S2Box.Location=new System.Drawing.Point(270, 257);
			this.Leave12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave12S2Box.Mask="90";
			this.Leave12S2Box.Name="Leave12S2Box";
			this.Leave12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave12S2Box.ReadOnly=true;
			this.Leave12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Leave12S2Box.TabIndex=8;
			this.Leave12S2Box.TabStop=false;
			this.Leave12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr12S2Box
			//
			this.Kasr12S2Box.BackColor=System.Drawing.Color.White;
			this.Kasr12S2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr12S2Box.Location=new System.Drawing.Point(270, 440);
			this.Kasr12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr12S2Box.Mask="###";
			this.Kasr12S2Box.Name="Kasr12S2Box";
			this.Kasr12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr12S2Box.ReadOnly=true;
			this.Kasr12S2Box.RightToLeft=RightToLeft.No;
			this.Kasr12S2Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr12S2Box.TabIndex=11;
			this.Kasr12S2Box.TabStop=false;
			this.Kasr12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Over12S2Box
			//
			this.Over12S2Box.BackColor=System.Drawing.Color.Silver;
			this.Over12S2Box.BorderStyle=BorderStyle.None;
			this.Over12S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over12S2Box.Location=new System.Drawing.Point(270, 395);
			this.Over12S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Over12S2Box.Mask="90";
			this.Over12S2Box.Name="Over12S2Box";
			this.Over12S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over12S2Box.ReadOnly=true;
			this.Over12S2Box.Size=new System.Drawing.Size(45, 25);
			this.Over12S2Box.TabIndex=10;
			this.Over12S2Box.TabStop=false;
			this.Over12S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label14
			//
			this.Label14.BackColor=System.Drawing.Color.Transparent;
			this.Label14.BorderStyle=BorderStyle.FixedSingle;
			this.Label14.Location=new System.Drawing.Point(253, 44);
			this.Label14.Margin=new Padding(5, 0, 5, 0);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(73, 38);
			this.Label14.TabIndex=55;
			this.Label14.Text="12 ساعته شب";
			this.Label14.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Keshik9S2Box
			//
			this.Keshik9S2Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik9S2Box.BorderStyle=BorderStyle.None;
			this.Keshik9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik9S2Box.Location=new System.Drawing.Point(187, 169);
			this.Keshik9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik9S2Box.Mask="90";
			this.Keshik9S2Box.Name="Keshik9S2Box";
			this.Keshik9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik9S2Box.ReadOnly=true;
			this.Keshik9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik9S2Box.TabIndex=13;
			this.Keshik9S2Box.TabStop=false;
			this.Keshik9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//All9S2Box
			//
			this.All9S2Box.BackColor=System.Drawing.Color.Silver;
			this.All9S2Box.BorderStyle=BorderStyle.None;
			this.All9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All9S2Box.Location=new System.Drawing.Point(187, 88);
			this.All9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.All9S2Box.Mask="90";
			this.All9S2Box.Name="All9S2Box";
			this.All9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All9S2Box.ReadOnly=true;
			this.All9S2Box.Size=new System.Drawing.Size(45, 25);
			this.All9S2Box.TabIndex=12;
			this.All9S2Box.TabStop=false;
			this.All9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift9S2Box
			//
			this.Shift9S2Box.BackColor=System.Drawing.Color.Silver;
			this.Shift9S2Box.BorderStyle=BorderStyle.None;
			this.Shift9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift9S2Box.Location=new System.Drawing.Point(187, 128);
			this.Shift9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift9S2Box.Mask="90";
			this.Shift9S2Box.Name="Shift9S2Box";
			this.Shift9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift9S2Box.ReadOnly=true;
			this.Shift9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Shift9S2Box.TabIndex=12;
			this.Shift9S2Box.TabStop=false;
			this.Shift9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class9S2Box
			//
			this.Class9S2Box.BackColor=System.Drawing.Color.Silver;
			this.Class9S2Box.BorderStyle=BorderStyle.None;
			this.Class9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class9S2Box.Location=new System.Drawing.Point(187, 300);
			this.Class9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Class9S2Box.Mask="90";
			this.Class9S2Box.Name="Class9S2Box";
			this.Class9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class9S2Box.ReadOnly=true;
			this.Class9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Class9S2Box.TabIndex=2;
			this.Class9S2Box.TabStop=false;
			this.Class9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem9S2Box
			//
			this.Daem9S2Box.BackColor=System.Drawing.Color.White;
			this.Daem9S2Box.BorderStyle=BorderStyle.None;
			this.Daem9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem9S2Box.Location=new System.Drawing.Point(187, 213);
			this.Daem9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem9S2Box.Mask="90";
			this.Daem9S2Box.Name="Daem9S2Box";
			this.Daem9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Daem9S2Box.TabIndex=2;
			this.Daem9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez9S2Box
			//
			this.Rez9S2Box.BackColor=System.Drawing.Color.White;
			this.Rez9S2Box.BorderStyle=BorderStyle.None;
			this.Rez9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez9S2Box.Location=new System.Drawing.Point(187, 349);
			this.Rez9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez9S2Box.Mask="90";
			this.Rez9S2Box.Name="Rez9S2Box";
			this.Rez9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Rez9S2Box.TabIndex=7;
			this.Rez9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave9S2Box
			//
			this.Leave9S2Box.BackColor=System.Drawing.Color.Silver;
			this.Leave9S2Box.BorderStyle=BorderStyle.None;
			this.Leave9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave9S2Box.Location=new System.Drawing.Point(187, 257);
			this.Leave9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave9S2Box.Mask="90";
			this.Leave9S2Box.Name="Leave9S2Box";
			this.Leave9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave9S2Box.ReadOnly=true;
			this.Leave9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Leave9S2Box.TabIndex=14;
			this.Leave9S2Box.TabStop=false;
			this.Leave9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr9S2Box
			//
			this.Kasr9S2Box.BackColor=System.Drawing.Color.White;
			this.Kasr9S2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr9S2Box.Location=new System.Drawing.Point(187, 440);
			this.Kasr9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr9S2Box.Mask="###";
			this.Kasr9S2Box.Name="Kasr9S2Box";
			this.Kasr9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr9S2Box.ReadOnly=true;
			this.Kasr9S2Box.RightToLeft=RightToLeft.No;
			this.Kasr9S2Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr9S2Box.TabIndex=17;
			this.Kasr9S2Box.TabStop=false;
			this.Kasr9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Over9S2Box
			//
			this.Over9S2Box.BackColor=System.Drawing.Color.Silver;
			this.Over9S2Box.BorderStyle=BorderStyle.None;
			this.Over9S2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over9S2Box.Location=new System.Drawing.Point(187, 395);
			this.Over9S2Box.Margin=new Padding(3, 4, 3, 4);
			this.Over9S2Box.Mask="90";
			this.Over9S2Box.Name="Over9S2Box";
			this.Over9S2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over9S2Box.ReadOnly=true;
			this.Over9S2Box.Size=new System.Drawing.Size(45, 25);
			this.Over9S2Box.TabIndex=16;
			this.Over9S2Box.TabStop=false;
			this.Over9S2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label15
			//
			this.Label15.BackColor=System.Drawing.Color.Transparent;
			this.Label15.BorderStyle=BorderStyle.FixedSingle;
			this.Label15.Location=new System.Drawing.Point(171, 44);
			this.Label15.Margin=new Padding(5, 0, 5, 0);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(73, 38);
			this.Label15.TabIndex=62;
			this.Label15.Text="9 ساعته صبح";
			this.Label15.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//All9A2Box
			//
			this.All9A2Box.BackColor=System.Drawing.Color.Silver;
			this.All9A2Box.BorderStyle=BorderStyle.None;
			this.All9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.All9A2Box.Location=new System.Drawing.Point(104, 88);
			this.All9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.All9A2Box.Mask="90";
			this.All9A2Box.Name="All9A2Box";
			this.All9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.All9A2Box.ReadOnly=true;
			this.All9A2Box.Size=new System.Drawing.Size(45, 25);
			this.All9A2Box.TabIndex=18;
			this.All9A2Box.TabStop=false;
			this.All9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Keshik9A2Box
			//
			this.Keshik9A2Box.BackColor=System.Drawing.Color.Silver;
			this.Keshik9A2Box.BorderStyle=BorderStyle.None;
			this.Keshik9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Keshik9A2Box.Location=new System.Drawing.Point(104, 169);
			this.Keshik9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Keshik9A2Box.Mask="90";
			this.Keshik9A2Box.Name="Keshik9A2Box";
			this.Keshik9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Keshik9A2Box.ReadOnly=true;
			this.Keshik9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Keshik9A2Box.TabIndex=19;
			this.Keshik9A2Box.TabStop=false;
			this.Keshik9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Shift9A2Box
			//
			this.Shift9A2Box.BackColor=System.Drawing.Color.Silver;
			this.Shift9A2Box.BorderStyle=BorderStyle.None;
			this.Shift9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Shift9A2Box.Location=new System.Drawing.Point(104, 128);
			this.Shift9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Shift9A2Box.Mask="90";
			this.Shift9A2Box.Name="Shift9A2Box";
			this.Shift9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Shift9A2Box.ReadOnly=true;
			this.Shift9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Shift9A2Box.TabIndex=18;
			this.Shift9A2Box.TabStop=false;
			this.Shift9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Class9A2Box
			//
			this.Class9A2Box.BackColor=System.Drawing.Color.Silver;
			this.Class9A2Box.BorderStyle=BorderStyle.None;
			this.Class9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Class9A2Box.Location=new System.Drawing.Point(104, 300);
			this.Class9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Class9A2Box.Mask="90";
			this.Class9A2Box.Name="Class9A2Box";
			this.Class9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Class9A2Box.ReadOnly=true;
			this.Class9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Class9A2Box.TabIndex=3;
			this.Class9A2Box.TabStop=false;
			this.Class9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Rez9A2Box
			//
			this.Rez9A2Box.BackColor=System.Drawing.Color.White;
			this.Rez9A2Box.BorderStyle=BorderStyle.None;
			this.Rez9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Rez9A2Box.Location=new System.Drawing.Point(104, 349);
			this.Rez9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Rez9A2Box.Mask="90";
			this.Rez9A2Box.Name="Rez9A2Box";
			this.Rez9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Rez9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Rez9A2Box.TabIndex=8;
			this.Rez9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Daem9A2Box
			//
			this.Daem9A2Box.BackColor=System.Drawing.Color.White;
			this.Daem9A2Box.BorderStyle=BorderStyle.None;
			this.Daem9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Daem9A2Box.Location=new System.Drawing.Point(104, 213);
			this.Daem9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Daem9A2Box.Mask="90";
			this.Daem9A2Box.Name="Daem9A2Box";
			this.Daem9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Daem9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Daem9A2Box.TabIndex=3;
			this.Daem9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Leave9A2Box
			//
			this.Leave9A2Box.BackColor=System.Drawing.Color.Silver;
			this.Leave9A2Box.BorderStyle=BorderStyle.None;
			this.Leave9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Leave9A2Box.Location=new System.Drawing.Point(104, 257);
			this.Leave9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Leave9A2Box.Mask="90";
			this.Leave9A2Box.Name="Leave9A2Box";
			this.Leave9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Leave9A2Box.ReadOnly=true;
			this.Leave9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Leave9A2Box.TabIndex=20;
			this.Leave9A2Box.TabStop=false;
			this.Leave9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Kasr9A2Box
			//
			this.Kasr9A2Box.BackColor=System.Drawing.Color.White;
			this.Kasr9A2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Kasr9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Kasr9A2Box.Location=new System.Drawing.Point(104, 440);
			this.Kasr9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Kasr9A2Box.Mask="###";
			this.Kasr9A2Box.Name="Kasr9A2Box";
			this.Kasr9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Kasr9A2Box.ReadOnly=true;
			this.Kasr9A2Box.RightToLeft=RightToLeft.No;
			this.Kasr9A2Box.Size=new System.Drawing.Size(45, 32);
			this.Kasr9A2Box.TabIndex=23;
			this.Kasr9A2Box.TabStop=false;
			this.Kasr9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Over9A2Box
			//
			this.Over9A2Box.BackColor=System.Drawing.Color.Silver;
			this.Over9A2Box.BorderStyle=BorderStyle.None;
			this.Over9A2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Over9A2Box.Location=new System.Drawing.Point(104, 395);
			this.Over9A2Box.Margin=new Padding(3, 4, 3, 4);
			this.Over9A2Box.Mask="90";
			this.Over9A2Box.Name="Over9A2Box";
			this.Over9A2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Over9A2Box.ReadOnly=true;
			this.Over9A2Box.Size=new System.Drawing.Size(45, 25);
			this.Over9A2Box.TabIndex=22;
			this.Over9A2Box.TabStop=false;
			this.Over9A2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label24
			//
			this.Label24.BackColor=System.Drawing.Color.Transparent;
			this.Label24.BorderStyle=BorderStyle.FixedSingle;
			this.Label24.Location=new System.Drawing.Point(89, 44);
			this.Label24.Margin=new Padding(5, 0, 5, 0);
			this.Label24.Name="Label24";
			this.Label24.Size=new System.Drawing.Size(73, 38);
			this.Label24.TabIndex=69;
			this.Label24.Text="9 ساعته عصر";
			this.Label24.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//AllSet2Box
			//
			this.AllSet2Box.BackColor=System.Drawing.Color.Silver;
			this.AllSet2Box.BorderStyle=BorderStyle.None;
			this.AllSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AllSet2Box.Location=new System.Drawing.Point(21, 88);
			this.AllSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.AllSet2Box.Mask="90";
			this.AllSet2Box.Name="AllSet2Box";
			this.AllSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.AllSet2Box.ReadOnly=true;
			this.AllSet2Box.Size=new System.Drawing.Size(45, 25);
			this.AllSet2Box.TabIndex=24;
			this.AllSet2Box.TabStop=false;
			this.AllSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshikSet2Box
			//
			this.KeshikSet2Box.BackColor=System.Drawing.Color.Silver;
			this.KeshikSet2Box.BorderStyle=BorderStyle.None;
			this.KeshikSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KeshikSet2Box.Location=new System.Drawing.Point(21, 169);
			this.KeshikSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.KeshikSet2Box.Mask="90";
			this.KeshikSet2Box.Name="KeshikSet2Box";
			this.KeshikSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshikSet2Box.ReadOnly=true;
			this.KeshikSet2Box.Size=new System.Drawing.Size(45, 25);
			this.KeshikSet2Box.TabIndex=25;
			this.KeshikSet2Box.TabStop=false;
			this.KeshikSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftSet2Box
			//
			this.ShiftSet2Box.BackColor=System.Drawing.Color.Silver;
			this.ShiftSet2Box.BorderStyle=BorderStyle.None;
			this.ShiftSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftSet2Box.Location=new System.Drawing.Point(21, 128);
			this.ShiftSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.ShiftSet2Box.Mask="90";
			this.ShiftSet2Box.Name="ShiftSet2Box";
			this.ShiftSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ShiftSet2Box.ReadOnly=true;
			this.ShiftSet2Box.Size=new System.Drawing.Size(45, 25);
			this.ShiftSet2Box.TabIndex=24;
			this.ShiftSet2Box.TabStop=false;
			this.ShiftSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//OverSet2Box
			//
			this.OverSet2Box.BackColor=System.Drawing.Color.Silver;
			this.OverSet2Box.BorderStyle=BorderStyle.None;
			this.OverSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.OverSet2Box.Location=new System.Drawing.Point(21, 395);
			this.OverSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.OverSet2Box.Mask="90";
			this.OverSet2Box.Name="OverSet2Box";
			this.OverSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.OverSet2Box.ReadOnly=true;
			this.OverSet2Box.Size=new System.Drawing.Size(45, 25);
			this.OverSet2Box.TabIndex=28;
			this.OverSet2Box.TabStop=false;
			this.OverSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//ClassSet2Box
			//
			this.ClassSet2Box.BackColor=System.Drawing.Color.Silver;
			this.ClassSet2Box.BorderStyle=BorderStyle.None;
			this.ClassSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ClassSet2Box.Location=new System.Drawing.Point(21, 300);
			this.ClassSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.ClassSet2Box.Mask="90";
			this.ClassSet2Box.Name="ClassSet2Box";
			this.ClassSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ClassSet2Box.ReadOnly=true;
			this.ClassSet2Box.Size=new System.Drawing.Size(45, 25);
			this.ClassSet2Box.TabIndex=4;
			this.ClassSet2Box.TabStop=false;
			this.ClassSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//RezSet2Box
			//
			this.RezSet2Box.BackColor=System.Drawing.Color.White;
			this.RezSet2Box.BorderStyle=BorderStyle.None;
			this.RezSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RezSet2Box.Location=new System.Drawing.Point(21, 349);
			this.RezSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.RezSet2Box.Mask="90";
			this.RezSet2Box.Name="RezSet2Box";
			this.RezSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.RezSet2Box.Size=new System.Drawing.Size(45, 25);
			this.RezSet2Box.TabIndex=9;
			this.RezSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//KasrSet2Box
			//
			this.KasrSet2Box.BackColor=System.Drawing.Color.White;
			this.KasrSet2Box.BorderStyle=BorderStyle.FixedSingle;
			this.KasrSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KasrSet2Box.Location=new System.Drawing.Point(21, 440);
			this.KasrSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.KasrSet2Box.Mask="###";
			this.KasrSet2Box.Name="KasrSet2Box";
			this.KasrSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KasrSet2Box.ReadOnly=true;
			this.KasrSet2Box.RightToLeft=RightToLeft.No;
			this.KasrSet2Box.Size=new System.Drawing.Size(45, 32);
			this.KasrSet2Box.TabIndex=29;
			this.KasrSet2Box.TabStop=false;
			this.KasrSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//LeaveSet2Box
			//
			this.LeaveSet2Box.BackColor=System.Drawing.Color.Silver;
			this.LeaveSet2Box.BorderStyle=BorderStyle.None;
			this.LeaveSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LeaveSet2Box.Location=new System.Drawing.Point(21, 257);
			this.LeaveSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.LeaveSet2Box.Mask="90";
			this.LeaveSet2Box.Name="LeaveSet2Box";
			this.LeaveSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.LeaveSet2Box.ReadOnly=true;
			this.LeaveSet2Box.Size=new System.Drawing.Size(45, 25);
			this.LeaveSet2Box.TabIndex=26;
			this.LeaveSet2Box.TabStop=false;
			this.LeaveSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//DaemSet2Box
			//
			this.DaemSet2Box.BackColor=System.Drawing.Color.White;
			this.DaemSet2Box.BorderStyle=BorderStyle.None;
			this.DaemSet2Box.Font=new System.Drawing.Font("B Yekan", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DaemSet2Box.Location=new System.Drawing.Point(21, 213);
			this.DaemSet2Box.Margin=new Padding(3, 4, 3, 4);
			this.DaemSet2Box.Mask="90";
			this.DaemSet2Box.Name="DaemSet2Box";
			this.DaemSet2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.DaemSet2Box.Size=new System.Drawing.Size(45, 25);
			this.DaemSet2Box.TabIndex=4;
			this.DaemSet2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label25
			//
			this.Label25.BackColor=System.Drawing.Color.Transparent;
			this.Label25.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label25.ForeColor=System.Drawing.Color.Black;
			this.Label25.Location=new System.Drawing.Point(2, 413);
			this.Label25.Margin=new Padding(5, 0, 5, 0);
			this.Label25.Name="Label25";
			this.Label25.Size=new System.Drawing.Size(418, 25);
			this.Label25.TabIndex=126;
			this.Label25.Text=resources.GetString("Label25.Text");
			this.Label25.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label26
			//
			this.Label26.BackColor=System.Drawing.Color.Transparent;
			this.Label26.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label26.ForeColor=System.Drawing.Color.Black;
			this.Label26.Location=new System.Drawing.Point(2, 373);
			this.Label26.Margin=new Padding(5, 0, 5, 0);
			this.Label26.Name="Label26";
			this.Label26.Size=new System.Drawing.Size(418, 25);
			this.Label26.TabIndex=125;
			this.Label26.Text=resources.GetString("Label26.Text");
			this.Label26.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label37
			//
			this.Label37.BackColor=System.Drawing.Color.Transparent;
			this.Label37.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label37.ForeColor=System.Drawing.Color.Black;
			this.Label37.Location=new System.Drawing.Point(2, 327);
			this.Label37.Margin=new Padding(5, 0, 5, 0);
			this.Label37.Name="Label37";
			this.Label37.Size=new System.Drawing.Size(418, 25);
			this.Label37.TabIndex=124;
			this.Label37.Text=resources.GetString("Label37.Text");
			this.Label37.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label34
			//
			this.Label34.BackColor=System.Drawing.Color.Transparent;
			this.Label34.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label34.ForeColor=System.Drawing.Color.Black;
			this.Label34.Location=new System.Drawing.Point(2, 277);
			this.Label34.Margin=new Padding(5, 0, 5, 0);
			this.Label34.Name="Label34";
			this.Label34.Size=new System.Drawing.Size(418, 25);
			this.Label34.TabIndex=124;
			this.Label34.Text=resources.GetString("Label34.Text");
			this.Label34.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label27
			//
			this.Label27.BackColor=System.Drawing.Color.Transparent;
			this.Label27.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label27.ForeColor=System.Drawing.Color.Black;
			this.Label27.Location=new System.Drawing.Point(2, 235);
			this.Label27.Margin=new Padding(5, 0, 5, 0);
			this.Label27.Name="Label27";
			this.Label27.Size=new System.Drawing.Size(418, 25);
			this.Label27.TabIndex=124;
			this.Label27.Text=resources.GetString("Label27.Text");
			this.Label27.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label31
			//
			this.Label31.BackColor=System.Drawing.Color.Transparent;
			this.Label31.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label31.ForeColor=System.Drawing.Color.Black;
			this.Label31.Location=new System.Drawing.Point(2, 107);
			this.Label31.Margin=new Padding(5, 0, 5, 0);
			this.Label31.Name="Label31";
			this.Label31.Size=new System.Drawing.Size(418, 25);
			this.Label31.TabIndex=116;
			this.Label31.Text=resources.GetString("Label31.Text");
			this.Label31.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label28
			//
			this.Label28.BackColor=System.Drawing.Color.Transparent;
			this.Label28.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label28.ForeColor=System.Drawing.Color.Black;
			this.Label28.Location=new System.Drawing.Point(2, 188);
			this.Label28.Margin=new Padding(5, 0, 5, 0);
			this.Label28.Name="Label28";
			this.Label28.Size=new System.Drawing.Size(418, 25);
			this.Label28.TabIndex=123;
			this.Label28.Text=resources.GetString("Label28.Text");
			this.Label28.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label29
			//
			this.Label29.BackColor=System.Drawing.Color.Transparent;
			this.Label29.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label29.ForeColor=System.Drawing.Color.Black;
			this.Label29.Location=new System.Drawing.Point(2, 147);
			this.Label29.Margin=new Padding(5, 0, 5, 0);
			this.Label29.Name="Label29";
			this.Label29.Size=new System.Drawing.Size(418, 25);
			this.Label29.TabIndex=116;
			this.Label29.Text=resources.GetString("Label29.Text");
			this.Label29.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Local2Label
			//
			this.Local2Label.BackColor=System.Drawing.Color.Blue;
			this.Local2Label.Font=new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Local2Label.ForeColor=System.Drawing.Color.Yellow;
			this.Local2Label.Location=new System.Drawing.Point(0, 0);
			this.Local2Label.Margin=new Padding(5, 0, 5, 0);
			this.Local2Label.Name="Local2Label";
			this.Local2Label.Size=new System.Drawing.Size(422, 31);
			this.Local2Label.TabIndex=122;
			this.Local2Label.Text="گلش";
			this.Local2Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label11
			//
			this.Label11.BackColor=System.Drawing.Color.Transparent;
			this.Label11.BorderStyle=BorderStyle.FixedSingle;
			this.Label11.Location=new System.Drawing.Point(7, 44);
			this.Label11.Margin=new Padding(5, 0, 5, 0);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(73, 38);
			this.Label11.TabIndex=76;
			this.Label11.Text="ستادی";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//DetailGridView
			//
			this.DetailGridView.AllowUserToAddRows=false;
			this.DetailGridView.AllowUserToDeleteRows=false;
			this.DetailGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DetailGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column1, this.Column2, this.Column3, this.Column4});
			this.DetailGridView.Location=new System.Drawing.Point(10, 67);
			this.DetailGridView.Name="DetailGridView";
			this.DetailGridView.ReadOnly=true;
			this.DetailGridView.RowHeadersVisible=false;
			this.DetailGridView.Size=new System.Drawing.Size(281, 220);
			this.DetailGridView.TabIndex=39;
			this.DetailGridView.Visible=false;
			//
			//Column1
			//
			this.Column1.HeaderText="نام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=50;
			//
			//Column2
			//
			this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText="نام خانوادگی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			//
			//Column3
			//
			this.Column3.HeaderText="پرسنلی";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=60;
			//
			//Column4
			//
			this.Column4.HeaderText="امتیاز";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=50;
			//
			//Label23
			//
			this.Label23.AutoSize=true;
			this.Label23.BackColor=System.Drawing.Color.Transparent;
			this.Label23.ForeColor=System.Drawing.Color.Black;
			this.Label23.Location=new System.Drawing.Point(865, 170);
			this.Label23.Margin=new Padding(5, 0, 5, 0);
			this.Label23.Name="Label23";
			this.Label23.Size=new System.Drawing.Size(97, 16);
			this.Label23.TabIndex=28;
			this.Label23.Text="راهبران مورد نیاز";
			this.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label32
			//
			this.Label32.AutoSize=true;
			this.Label32.BackColor=System.Drawing.Color.Transparent;
			this.Label32.ForeColor=System.Drawing.Color.Black;
			this.Label32.Location=new System.Drawing.Point(865, 385);
			this.Label32.Margin=new Padding(5, 0, 5, 0);
			this.Label32.Name="Label32";
			this.Label32.Size=new System.Drawing.Size(126, 16);
			this.Label32.TabIndex=33;
			this.Label32.Text="تعداد راهبران بازآموزی";
			this.Label32.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label36
			//
			this.Label36.AutoSize=true;
			this.Label36.BackColor=System.Drawing.Color.Transparent;
			this.Label36.ForeColor=System.Drawing.Color.Black;
			this.Label36.Location=new System.Drawing.Point(865, 296);
			this.Label36.Margin=new Padding(5, 0, 5, 0);
			this.Label36.Name="Label36";
			this.Label36.Size=new System.Drawing.Size(95, 16);
			this.Label36.TabIndex=38;
			this.Label36.Text="راهبران غیر دائم";
			this.Label36.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//DailyProcessADForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.SystemColors.Control;
			this.ClientSize=new System.Drawing.Size(1000, 566);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.DetailGridView);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.DataGridView2);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label36);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label32);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label23);
			this.Controls.Add(this.Label17);
			this.Controls.Add(this.Label18);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="DailyProcessADForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="پردازش لوحه راهبری";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.DetailGridView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		private ComboBox KindCombo;
		private Label Label3;
		private ComboBox NameCombo;
		private Label Label1;
		private Label Label1a;
		private Label Label17;
		private MaskedTextBox Shift12R1Box;
		private Label Label18;
		private MaskedTextBox Keshik12R1Box;
		private Label Label2;
		private MaskedTextBox Leave12R1Box;
		private Label Label4;
		private MaskedTextBox Rez12R1Box;
		private Label Label5;
		private MaskedTextBox Over12R1Box;
		private Label Label6;
		private MaskedTextBox Kasr12R1Box;
		private Label Label7;
		private MaskedTextBox Over12S1Box;
		private MaskedTextBox Kasr12S1Box;
		private MaskedTextBox Leave12S1Box;
		private MaskedTextBox Rez12S1Box;
		private MaskedTextBox Shift12S1Box;
		private MaskedTextBox Keshik12S1Box;
		private MaskedTextBox Over9A1Box;
		private MaskedTextBox Kasr9A1Box;
		private MaskedTextBox Leave9A1Box;
		private MaskedTextBox Rez9A1Box;
		private MaskedTextBox Shift9A1Box;
		private MaskedTextBox Keshik9A1Box;
		private Label Label9;
		private MaskedTextBox Over9S1Box;
		private MaskedTextBox Kasr9S1Box;
		private MaskedTextBox Leave9S1Box;
		private MaskedTextBox Rez9S1Box;
		private MaskedTextBox Shift9S1Box;
		private MaskedTextBox Keshik9S1Box;
		private Label Label13;
		private MaskedTextBox OverSet1Box;
		private MaskedTextBox KasrSet1Box;
		private MaskedTextBox LeaveSet1Box;
		private MaskedTextBox RezSet1Box;
		private MaskedTextBox ShiftSet1Box;
		private MaskedTextBox KeshikSet1Box;
		private Label Label16;
		private Panel Panel1;
		private Button PrintButton;
		private Label Local1Label;
		private Panel Panel2;
		private Label Label22;
		private Label Label21;
		private Label Label20;
		private Label Label19;
		private Panel Panel3;
		private Label Local2Label;
		private Label Label11;
		private MaskedTextBox Keshik12R2Box;
		private MaskedTextBox Shift12R2Box;
		private MaskedTextBox Rez12R2Box;
		private MaskedTextBox Leave12R2Box;
		private MaskedTextBox Kasr12R2Box;
		private MaskedTextBox Over12R2Box;
		private Label Label12;
		private MaskedTextBox Keshik12S2Box;
		private MaskedTextBox Shift12S2Box;
		private MaskedTextBox Rez12S2Box;
		private MaskedTextBox Leave12S2Box;
		private MaskedTextBox Kasr12S2Box;
		private MaskedTextBox Over12S2Box;
		private Label Label14;
		private MaskedTextBox Keshik9S2Box;
		private MaskedTextBox Shift9S2Box;
		private MaskedTextBox Rez9S2Box;
		private MaskedTextBox Leave9S2Box;
		private MaskedTextBox Kasr9S2Box;
		private MaskedTextBox Over9S2Box;
		private Label Label15;
		private MaskedTextBox Keshik9A2Box;
		private MaskedTextBox Shift9A2Box;
		private MaskedTextBox Rez9A2Box;
		private MaskedTextBox Leave9A2Box;
		private MaskedTextBox Kasr9A2Box;
		private MaskedTextBox Over9A2Box;
		private Label Label24;
		private MaskedTextBox KeshikSet2Box;
		private MaskedTextBox ShiftSet2Box;
		private MaskedTextBox OverSet2Box;
		private MaskedTextBox RezSet2Box;
		private MaskedTextBox KasrSet2Box;
		private MaskedTextBox LeaveSet2Box;
		private Label Label25;
		private Label Label26;
		private Label Label27;
		private Label Label28;
		private Label Label29;
		private Label Label30;
		private Label Label8;
		private MaskedTextBox All12R1Box;
		private MaskedTextBox All12S1Box;
		private MaskedTextBox All9S1Box;
		private MaskedTextBox All9A1Box;
		private MaskedTextBox AllSet1Box;
		private Label Label10;
		private MaskedTextBox All12R2Box;
		private MaskedTextBox All12S2Box;
		private MaskedTextBox All9S2Box;
		private MaskedTextBox All9A2Box;
		private MaskedTextBox AllSet2Box;
		private Label Label31;
		private Label Label23;
		private MaskedTextBox Class12R1Box;
		private MaskedTextBox Class12S1Box;
		private MaskedTextBox Class9S1Box;
		private MaskedTextBox Class9A1Box;
		private MaskedTextBox ClassSet1Box;
		private Label Label33;
		private MaskedTextBox Class12R2Box;
		private MaskedTextBox Class12S2Box;
		private MaskedTextBox Class9S2Box;
		private MaskedTextBox Class9A2Box;
		private MaskedTextBox ClassSet2Box;
		private Label Label34;
		private Label Label32;
		private DataGridView DataGridView1;
		private DataGridView DetailGridView;
		private DataGridView DataGridView2;
		private MaskedTextBox Daem12R1Box;
		private MaskedTextBox Daem12S1Box;
		private MaskedTextBox Daem9S1Box;
		private MaskedTextBox Daem9A1Box;
		private MaskedTextBox DaemSet1Box;
		private Label Label35;
		private MaskedTextBox Daem12R2Box;
		private MaskedTextBox Daem12S2Box;
		private MaskedTextBox Daem9S2Box;
		private MaskedTextBox Daem9A2Box;
		private MaskedTextBox DaemSet2Box;
		private Label Label37;
		private Label Label36;
		private Button ProcessButton;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
	}
	
}
