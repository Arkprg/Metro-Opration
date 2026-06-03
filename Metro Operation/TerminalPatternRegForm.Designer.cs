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
	public partial class TerminalPatternRegForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle9=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle10=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle11=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle12=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle13=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle14=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle15=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle16=new DataGridViewCellStyle();
			this.TabPage4=new TabPage();
			base.Load += new System.EventHandler(TerminalPatternRegForm_Load);
			this.DataGridView22=new DataGridView();
			this.DataGridView22.CellClick += new DataGridViewCellEventHandler(this.DataGridView22_CellClick);
			this.DataGridViewTextBoxColumn6=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn12=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn13=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn14=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn15=new DataGridViewTextBoxColumn();
			this.DataGridView12=new DataGridView();
			this.DataGridView12.CellClick += new DataGridViewCellEventHandler(this.DataGridView12_CellClick);
			this.DataGridViewTextBoxColumn16=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn17=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn18=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn19=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn20=new DataGridViewTextBoxColumn();
			this.Panel12=new Panel();
			this.Mab22Label=new Label();
			this.Add4Button=new Button();
			this.Add4Button.Click += new System.EventHandler(this.Add4Button_Click);
			this.R22=new ComboBox();
			this.Magh22Label=new Label();
			this.Label25=new Label();
			this.Label28=new Label();
			this.Kind22Label=new Label();
			this.Label42=new Label();
			this.Time22Label=new Label();
			this.Label46=new Label();
			this.Label47=new Label();
			this.Panel13=new Panel();
			this.Mab12Label=new Label();
			this.Add3Button=new Button();
			this.Add3Button.Click += new System.EventHandler(this.Add3Button_Click);
			this.R12=new ComboBox();
			this.Magh12Label=new Label();
			this.Label50=new Label();
			this.Label51=new Label();
			this.Kind12Label=new Label();
			this.Label53=new Label();
			this.Time12Label=new Label();
			this.Label55=new Label();
			this.Label56=new Label();
			this.PictureBox3=new PictureBox();
			this.PictureBox4=new PictureBox();
			this.Panel14=new Panel();
			this.NameBox=new TextBox();
			this.Label17=new Label();
			this.Back2Button=new Button();
			this.Back2Button.Click += new System.EventHandler(this.Back2Button_Click);
			this.RegButton=new Button();
			this.TabPage2=new TabPage();
			this.DataGridView21=new DataGridView();
			this.DataGridView21.CellClick += new DataGridViewCellEventHandler(this.DataGridView21_CellClick);
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
			this.DataGridView11=new DataGridView();
			this.DataGridView11.CellClick += new DataGridViewCellEventHandler(this.DataGridView11_CellClick);
			this.DataGridViewTextBoxColumn7=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn8=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn9=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn10=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn11=new DataGridViewTextBoxColumn();
			this.Panel10=new Panel();
			this.Mab21Label=new Label();
			this.Add2Button=new Button();
			this.Add2Button.Click += new System.EventHandler(this.Add2Button_Click);
			this.R21=new ComboBox();
			this.Magh21Label=new Label();
			this.Label29=new Label();
			this.Label35=new Label();
			this.Kind21Label=new Label();
			this.Label38=new Label();
			this.Time21Label=new Label();
			this.Label43=new Label();
			this.Label44=new Label();
			this.Panel11=new Panel();
			this.Mab11Label=new Label();
			this.Add1Button=new Button();
			this.Add1Button.Click += new System.EventHandler(this.Add1Button_Click);
			this.R11=new ComboBox();
			this.Magh11Label=new Label();
			this.Label32=new Label();
			this.Label39=new Label();
			this.Kind11Label=new Label();
			this.Label24=new Label();
			this.Time11Label=new Label();
			this.Label40=new Label();
			this.Label41=new Label();
			this.PictureBox1=new PictureBox();
			this.PictureBox2=new PictureBox();
			this.Panel3=new Panel();
			this.Back1Button=new Button();
			this.Back1Button.Click += new System.EventHandler(this.Back1Button_Click);
			this.Button1=new Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.TabPage1=new TabPage();
			this.PictureBox8=new PictureBox();
			this.PictureBox9=new PictureBox();
			this.Panel7=new Panel();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.Label15=new Label();
			this.NameCombo=new ComboBox();
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.Label16=new Label();
			this.Panel8=new Panel();
			this.Panel1=new Panel();
			this.Gol2Box=new MaskedTextBox();
			this.ResMeh2Box=new MaskedTextBox();
			this.KeshMeh2Box=new MaskedTextBox();
			this.Label9=new Label();
			this.Label5=new Label();
			this.Label6=new Label();
			this.Mehr2Box=new MaskedTextBox();
			this.Label7=new Label();
			this.Label8=new Label();
			this.Label12=new Label();
			this.Panel2=new Panel();
			this.Gol3Box=new MaskedTextBox();
			this.ResMeh3Box=new MaskedTextBox();
			this.KeshMeh3Box=new MaskedTextBox();
			this.Label14=new Label();
			this.Label10=new Label();
			this.Label11=new Label();
			this.Mehr3Box=new MaskedTextBox();
			this.Label13=new Label();
			this.Panel9=new Panel();
			this.Panel4=new Panel();
			this.Label30=new Label();
			this.ResTeh3Box=new MaskedTextBox();
			this.Teh3Box=new MaskedTextBox();
			this.Label3=new Label();
			this.KeshTeh3Box=new MaskedTextBox();
			this.Label22=new Label();
			this.Label34=new Label();
			this.Label33=new Label();
			this.Panel6=new Panel();
			this.Label21=new Label();
			this.ResTeh2Box=new MaskedTextBox();
			this.Teh2Box=new MaskedTextBox();
			this.Label2=new Label();
			this.KeshTeh2Box=new MaskedTextBox();
			this.Label31=new Label();
			this.TabControl1=new TabControl();
			this.TabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView22).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView12).BeginInit();
			this.Panel12.SuspendLayout();
			this.Panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).BeginInit();
			this.Panel14.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView21).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView11).BeginInit();
			this.Panel10.SuspendLayout();
			this.Panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).BeginInit();
			this.Panel3.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			this.Panel7.SuspendLayout();
			this.Panel8.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel9.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel6.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.SuspendLayout();
			//
			//TabPage4
			//
			this.TabPage4.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage4.Controls.Add(this.DataGridView22);
			this.TabPage4.Controls.Add(this.DataGridView12);
			this.TabPage4.Controls.Add(this.Panel12);
			this.TabPage4.Controls.Add(this.Panel13);
			this.TabPage4.Controls.Add(this.PictureBox3);
			this.TabPage4.Controls.Add(this.PictureBox4);
			this.TabPage4.Controls.Add(this.Panel14);
			this.TabPage4.Location=new System.Drawing.Point(4, 9);
			this.TabPage4.Name="TabPage4";
			this.TabPage4.Padding=new Padding(3);
			this.TabPage4.Size=new System.Drawing.Size(831, 579);
			this.TabPage4.TabIndex=3;
			this.TabPage4.Text="TabPage4";
			//
			//DataGridView22
			//
			this.DataGridView22.AllowUserToAddRows=false;
			this.DataGridView22.AllowUserToDeleteRows=false;
			this.DataGridView22.AllowUserToResizeColumns=false;
			this.DataGridView22.AllowUserToResizeRows=false;
			DataGridViewCellStyle9.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle9.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView22.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle9;
			this.DataGridView22.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle10.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle10.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle10.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle10.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle10.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle10.WrapMode=DataGridViewTriState.True;
			this.DataGridView22.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle10;
			this.DataGridView22.ColumnHeadersHeight=40;
			this.DataGridView22.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn6, this.DataGridViewTextBoxColumn12, this.Column4, this.DataGridViewTextBoxColumn13, this.DataGridViewTextBoxColumn14, this.DataGridViewTextBoxColumn15});
			this.DataGridView22.EnableHeadersVisualStyles=false;
			this.DataGridView22.Location=new System.Drawing.Point(8, 145);
			this.DataGridView22.MultiSelect=false;
			this.DataGridView22.Name="DataGridView22";
			this.DataGridView22.ReadOnly=true;
			this.DataGridView22.RowHeadersVisible=false;
			this.DataGridView22.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView22.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView22.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView22.RowTemplate.ReadOnly=true;
			this.DataGridView22.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView22.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView22.Size=new System.Drawing.Size(403, 372);
			this.DataGridView22.TabIndex=78;
			//
			//DataGridViewTextBoxColumn6
			//
			this.DataGridViewTextBoxColumn6.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
			this.DataGridViewTextBoxColumn6.ReadOnly=true;
			this.DataGridViewTextBoxColumn6.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn6.Width=45;
			//
			//DataGridViewTextBoxColumn12
			//
			this.DataGridViewTextBoxColumn12.HeaderText="ساعت اعزام";
			this.DataGridViewTextBoxColumn12.Name="DataGridViewTextBoxColumn12";
			this.DataGridViewTextBoxColumn12.ReadOnly=true;
			this.DataGridViewTextBoxColumn12.Width=65;
			//
			//Column4
			//
			this.Column4.HeaderText="نوع";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Visible=false;
			//
			//DataGridViewTextBoxColumn13
			//
			this.DataGridViewTextBoxColumn13.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn13.Name="DataGridViewTextBoxColumn13";
			this.DataGridViewTextBoxColumn13.ReadOnly=true;
			this.DataGridViewTextBoxColumn13.Width=80;
			//
			//DataGridViewTextBoxColumn14
			//
			this.DataGridViewTextBoxColumn14.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn14.Name="DataGridViewTextBoxColumn14";
			this.DataGridViewTextBoxColumn14.ReadOnly=true;
			this.DataGridViewTextBoxColumn14.Width=80;
			//
			//DataGridViewTextBoxColumn15
			//
			this.DataGridViewTextBoxColumn15.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn15.HeaderText="نام گروه";
			this.DataGridViewTextBoxColumn15.Name="DataGridViewTextBoxColumn15";
			this.DataGridViewTextBoxColumn15.ReadOnly=true;
			//
			//DataGridView12
			//
			this.DataGridView12.AllowUserToAddRows=false;
			this.DataGridView12.AllowUserToDeleteRows=false;
			this.DataGridView12.AllowUserToResizeColumns=false;
			this.DataGridView12.AllowUserToResizeRows=false;
			DataGridViewCellStyle11.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle11.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle11.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView12.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle11;
			this.DataGridView12.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle12.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle12.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle12.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle12.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle12.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle12.WrapMode=DataGridViewTriState.True;
			this.DataGridView12.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle12;
			this.DataGridView12.ColumnHeadersHeight=40;
			this.DataGridView12.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn16, this.DataGridViewTextBoxColumn17, this.Column1, this.DataGridViewTextBoxColumn18, this.DataGridViewTextBoxColumn19, this.DataGridViewTextBoxColumn20});
			this.DataGridView12.EnableHeadersVisualStyles=false;
			this.DataGridView12.Location=new System.Drawing.Point(420, 145);
			this.DataGridView12.MultiSelect=false;
			this.DataGridView12.Name="DataGridView12";
			this.DataGridView12.ReadOnly=true;
			this.DataGridView12.RowHeadersVisible=false;
			this.DataGridView12.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView12.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView12.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView12.RowTemplate.ReadOnly=true;
			this.DataGridView12.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView12.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView12.Size=new System.Drawing.Size(403, 372);
			this.DataGridView12.TabIndex=78;
			//
			//DataGridViewTextBoxColumn16
			//
			this.DataGridViewTextBoxColumn16.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn16.Name="DataGridViewTextBoxColumn16";
			this.DataGridViewTextBoxColumn16.ReadOnly=true;
			this.DataGridViewTextBoxColumn16.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn16.Width=45;
			//
			//DataGridViewTextBoxColumn17
			//
			this.DataGridViewTextBoxColumn17.HeaderText="ساعت اعزام";
			this.DataGridViewTextBoxColumn17.Name="DataGridViewTextBoxColumn17";
			this.DataGridViewTextBoxColumn17.ReadOnly=true;
			this.DataGridViewTextBoxColumn17.Width=65;
			//
			//Column1
			//
			this.Column1.HeaderText="نوع";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Visible=false;
			//
			//DataGridViewTextBoxColumn18
			//
			this.DataGridViewTextBoxColumn18.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn18.Name="DataGridViewTextBoxColumn18";
			this.DataGridViewTextBoxColumn18.ReadOnly=true;
			this.DataGridViewTextBoxColumn18.Width=80;
			//
			//DataGridViewTextBoxColumn19
			//
			this.DataGridViewTextBoxColumn19.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn19.Name="DataGridViewTextBoxColumn19";
			this.DataGridViewTextBoxColumn19.ReadOnly=true;
			this.DataGridViewTextBoxColumn19.Width=80;
			//
			//DataGridViewTextBoxColumn20
			//
			this.DataGridViewTextBoxColumn20.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn20.HeaderText="نام گروه";
			this.DataGridViewTextBoxColumn20.Name="DataGridViewTextBoxColumn20";
			this.DataGridViewTextBoxColumn20.ReadOnly=true;
			//
			//Panel12
			//
			this.Panel12.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel12.BorderStyle=BorderStyle.FixedSingle;
			this.Panel12.Controls.Add(this.Mab22Label);
			this.Panel12.Controls.Add(this.Add4Button);
			this.Panel12.Controls.Add(this.R22);
			this.Panel12.Controls.Add(this.Magh22Label);
			this.Panel12.Controls.Add(this.Label25);
			this.Panel12.Controls.Add(this.Label28);
			this.Panel12.Controls.Add(this.Kind22Label);
			this.Panel12.Controls.Add(this.Label42);
			this.Panel12.Controls.Add(this.Time22Label);
			this.Panel12.Controls.Add(this.Label46);
			this.Panel12.Controls.Add(this.Label47);
			this.Panel12.Location=new System.Drawing.Point(8, 70);
			this.Panel12.Name="Panel12";
			this.Panel12.Size=new System.Drawing.Size(403, 67);
			this.Panel12.TabIndex=79;
			//
			//Mab22Label
			//
			this.Mab22Label.Location=new System.Drawing.Point(111, 8);
			this.Mab22Label.Margin=new Padding(3);
			this.Mab22Label.Name="Mab22Label";
			this.Mab22Label.Size=new System.Drawing.Size(87, 18);
			this.Mab22Label.TabIndex=4;
			this.Mab22Label.Text="پایانه مهرشهر";
			//
			//Add4Button
			//
			this.Add4Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Add4Button.Image=global::Metro_Operation.Properties.Resources._checked;
			this.Add4Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Add4Button.Location=new System.Drawing.Point(6, 31);
			this.Add4Button.Name="Add4Button";
			this.Add4Button.Padding=new Padding(5, 0, 5, 0);
			this.Add4Button.Size=new System.Drawing.Size(100, 30);
			this.Add4Button.TabIndex=80;
			this.Add4Button.Text="تایید";
			this.Add4Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add4Button.UseVisualStyleBackColor=false;
			//
			//R22
			//
			this.R22.DropDownStyle=ComboBoxStyle.DropDownList;
			this.R22.FormattingEnabled=true;
			this.R22.Items.AddRange(new object[] {"تهران", "پایانه تهران"});
			this.R22.Location=new System.Drawing.Point(160, 35);
			this.R22.Name="R22";
			this.R22.Size=new System.Drawing.Size(158, 24);
			this.R22.TabIndex=3;
			//
			//Magh22Label
			//
			this.Magh22Label.Location=new System.Drawing.Point(3, 8);
			this.Magh22Label.Margin=new Padding(3);
			this.Magh22Label.Name="Magh22Label";
			this.Magh22Label.Size=new System.Drawing.Size(87, 18);
			this.Magh22Label.TabIndex=0;
			this.Magh22Label.Text="پایانه مهرشهر";
			//
			//Label25
			//
			this.Label25.AutoSize=true;
			this.Label25.Location=new System.Drawing.Point(90, 9);
			this.Label25.Margin=new Padding(3);
			this.Label25.Name="Label25";
			this.Label25.Size=new System.Drawing.Size(19, 16);
			this.Label25.TabIndex=0;
			this.Label25.Text="به";
			//
			//Label28
			//
			this.Label28.AutoSize=true;
			this.Label28.Location=new System.Drawing.Point(318, 39);
			this.Label28.Margin=new Padding(3);
			this.Label28.Name="Label28";
			this.Label28.Size=new System.Drawing.Size(66, 16);
			this.Label28.TabIndex=0;
			this.Label28.Text="گروه راهبر:";
			//
			//Kind22Label
			//
			this.Kind22Label.Location=new System.Drawing.Point(216, 9);
			this.Kind22Label.Margin=new Padding(3);
			this.Kind22Label.Name="Kind22Label";
			this.Kind22Label.Size=new System.Drawing.Size(56, 16);
			this.Kind22Label.TabIndex=0;
			this.Kind22Label.Text="ورودی";
			//
			//Label42
			//
			this.Label42.AutoSize=true;
			this.Label42.Location=new System.Drawing.Point(268, 9);
			this.Label42.Margin=new Padding(3);
			this.Label42.Name="Label42";
			this.Label42.Size=new System.Drawing.Size(31, 16);
			this.Label42.TabIndex=0;
			this.Label42.Text="نوع:";
			//
			//Time22Label
			//
			this.Time22Label.Location=new System.Drawing.Point(301, 9);
			this.Time22Label.Margin=new Padding(3);
			this.Time22Label.Name="Time22Label";
			this.Time22Label.Size=new System.Drawing.Size(45, 16);
			this.Time22Label.TabIndex=0;
			this.Time22Label.Text="00:00";
			//
			//Label46
			//
			this.Label46.AutoSize=true;
			this.Label46.Location=new System.Drawing.Point(342, 9);
			this.Label46.Margin=new Padding(3);
			this.Label46.Name="Label46";
			this.Label46.Size=new System.Drawing.Size(50, 16);
			this.Label46.TabIndex=0;
			this.Label46.Text="ساعت:";
			//
			//Label47
			//
			this.Label47.AutoSize=true;
			this.Label47.Location=new System.Drawing.Point(196, 9);
			this.Label47.Margin=new Padding(3);
			this.Label47.Name="Label47";
			this.Label47.Size=new System.Drawing.Size(16, 16);
			this.Label47.TabIndex=0;
			this.Label47.Text="از";
			//
			//Panel13
			//
			this.Panel13.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel13.BorderStyle=BorderStyle.FixedSingle;
			this.Panel13.Controls.Add(this.Mab12Label);
			this.Panel13.Controls.Add(this.Add3Button);
			this.Panel13.Controls.Add(this.R12);
			this.Panel13.Controls.Add(this.Magh12Label);
			this.Panel13.Controls.Add(this.Label50);
			this.Panel13.Controls.Add(this.Label51);
			this.Panel13.Controls.Add(this.Kind12Label);
			this.Panel13.Controls.Add(this.Label53);
			this.Panel13.Controls.Add(this.Time12Label);
			this.Panel13.Controls.Add(this.Label55);
			this.Panel13.Controls.Add(this.Label56);
			this.Panel13.Location=new System.Drawing.Point(420, 70);
			this.Panel13.Name="Panel13";
			this.Panel13.Size=new System.Drawing.Size(403, 67);
			this.Panel13.TabIndex=79;
			//
			//Mab12Label
			//
			this.Mab12Label.Location=new System.Drawing.Point(111, 8);
			this.Mab12Label.Margin=new Padding(3);
			this.Mab12Label.Name="Mab12Label";
			this.Mab12Label.Size=new System.Drawing.Size(87, 18);
			this.Mab12Label.TabIndex=4;
			this.Mab12Label.Text="پایانه مهرشهر";
			//
			//Add3Button
			//
			this.Add3Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Add3Button.Image=global::Metro_Operation.Properties.Resources._checked;
			this.Add3Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Add3Button.Location=new System.Drawing.Point(6, 31);
			this.Add3Button.Name="Add3Button";
			this.Add3Button.Padding=new Padding(5, 0, 5, 0);
			this.Add3Button.Size=new System.Drawing.Size(100, 30);
			this.Add3Button.TabIndex=80;
			this.Add3Button.Text="تایید";
			this.Add3Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add3Button.UseVisualStyleBackColor=false;
			//
			//R12
			//
			this.R12.DropDownStyle=ComboBoxStyle.DropDownList;
			this.R12.FormattingEnabled=true;
			this.R12.Items.AddRange(new object[] {"تهران", "پایانه تهران"});
			this.R12.Location=new System.Drawing.Point(169, 35);
			this.R12.Name="R12";
			this.R12.Size=new System.Drawing.Size(158, 24);
			this.R12.TabIndex=3;
			//
			//Magh12Label
			//
			this.Magh12Label.Location=new System.Drawing.Point(3, 8);
			this.Magh12Label.Margin=new Padding(3);
			this.Magh12Label.Name="Magh12Label";
			this.Magh12Label.Size=new System.Drawing.Size(87, 18);
			this.Magh12Label.TabIndex=0;
			this.Magh12Label.Text="پایانه مهرشهر";
			//
			//Label50
			//
			this.Label50.AutoSize=true;
			this.Label50.Location=new System.Drawing.Point(90, 9);
			this.Label50.Margin=new Padding(3);
			this.Label50.Name="Label50";
			this.Label50.Size=new System.Drawing.Size(19, 16);
			this.Label50.TabIndex=0;
			this.Label50.Text="به";
			//
			//Label51
			//
			this.Label51.AutoSize=true;
			this.Label51.Location=new System.Drawing.Point(327, 39);
			this.Label51.Margin=new Padding(3);
			this.Label51.Name="Label51";
			this.Label51.Size=new System.Drawing.Size(66, 16);
			this.Label51.TabIndex=0;
			this.Label51.Text="گروه راهبر:";
			//
			//Kind12Label
			//
			this.Kind12Label.Location=new System.Drawing.Point(216, 9);
			this.Kind12Label.Margin=new Padding(3);
			this.Kind12Label.Name="Kind12Label";
			this.Kind12Label.Size=new System.Drawing.Size(56, 16);
			this.Kind12Label.TabIndex=0;
			this.Kind12Label.Text="ورودی";
			//
			//Label53
			//
			this.Label53.AutoSize=true;
			this.Label53.Location=new System.Drawing.Point(268, 9);
			this.Label53.Margin=new Padding(3);
			this.Label53.Name="Label53";
			this.Label53.Size=new System.Drawing.Size(31, 16);
			this.Label53.TabIndex=0;
			this.Label53.Text="نوع:";
			//
			//Time12Label
			//
			this.Time12Label.Location=new System.Drawing.Point(301, 9);
			this.Time12Label.Margin=new Padding(3);
			this.Time12Label.Name="Time12Label";
			this.Time12Label.Size=new System.Drawing.Size(45, 16);
			this.Time12Label.TabIndex=0;
			this.Time12Label.Text="00:00";
			//
			//Label55
			//
			this.Label55.AutoSize=true;
			this.Label55.Location=new System.Drawing.Point(342, 9);
			this.Label55.Margin=new Padding(3);
			this.Label55.Name="Label55";
			this.Label55.Size=new System.Drawing.Size(50, 16);
			this.Label55.TabIndex=0;
			this.Label55.Text="ساعت:";
			//
			//Label56
			//
			this.Label56.AutoSize=true;
			this.Label56.Location=new System.Drawing.Point(196, 9);
			this.Label56.Margin=new Padding(3);
			this.Label56.Name="Label56";
			this.Label56.Size=new System.Drawing.Size(16, 16);
			this.Label56.TabIndex=0;
			this.Label56.Text="از";
			//
			//PictureBox3
			//
			this.PictureBox3.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox3.Location=new System.Drawing.Point(58, 6);
			this.PictureBox3.Name="PictureBox3";
			this.PictureBox3.Size=new System.Drawing.Size(303, 65);
			this.PictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox3.TabIndex=76;
			this.PictureBox3.TabStop=false;
			//
			//PictureBox4
			//
			this.PictureBox4.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox4.Location=new System.Drawing.Point(508, 6);
			this.PictureBox4.Name="PictureBox4";
			this.PictureBox4.Size=new System.Drawing.Size(226, 65);
			this.PictureBox4.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox4.TabIndex=75;
			this.PictureBox4.TabStop=false;
			//
			//Panel14
			//
			this.Panel14.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel14.BorderStyle=BorderStyle.FixedSingle;
			this.Panel14.Controls.Add(this.NameBox);
			this.Panel14.Controls.Add(this.Label17);
			this.Panel14.Controls.Add(this.Back2Button);
			this.Panel14.Controls.Add(this.RegButton);
			this.Panel14.Location=new System.Drawing.Point(52, 525);
			this.Panel14.Name="Panel14";
			this.Panel14.Size=new System.Drawing.Size(726, 50);
			this.Panel14.TabIndex=69;
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(257, 13);
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(176, 23);
			this.NameBox.TabIndex=54;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.BackColor=System.Drawing.Color.Transparent;
			this.Label17.ForeColor=System.Drawing.Color.Black;
			this.Label17.Location=new System.Drawing.Point(434, 16);
			this.Label17.Margin=new Padding(3);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(53, 16);
			this.Label17.TabIndex=55;
			this.Label17.Text="نام الگو:";
			this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Back2Button
			//
			this.Back2Button.BackColor=System.Drawing.Color.White;
			this.Back2Button.Image=global::Metro_Operation.Properties.Resources._32;
			this.Back2Button.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Back2Button.Location=new System.Drawing.Point(566, 7);
			this.Back2Button.Name="Back2Button";
			this.Back2Button.Size=new System.Drawing.Size(142, 35);
			this.Back2Button.TabIndex=53;
			this.Back2Button.Text="بازگشت";
			this.Back2Button.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.Yellow;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.RegButton.Location=new System.Drawing.Point(11, 7);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(170, 35);
			this.RegButton.TabIndex=52;
			this.RegButton.Text="تاید نهایی";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//TabPage2
			//
			this.TabPage2.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage2.Controls.Add(this.DataGridView21);
			this.TabPage2.Controls.Add(this.DataGridView11);
			this.TabPage2.Controls.Add(this.Panel10);
			this.TabPage2.Controls.Add(this.Panel11);
			this.TabPage2.Controls.Add(this.PictureBox1);
			this.TabPage2.Controls.Add(this.PictureBox2);
			this.TabPage2.Controls.Add(this.Panel3);
			this.TabPage2.Location=new System.Drawing.Point(4, 9);
			this.TabPage2.Name="TabPage2";
			this.TabPage2.Padding=new Padding(3);
			this.TabPage2.Size=new System.Drawing.Size(831, 579);
			this.TabPage2.TabIndex=1;
			this.TabPage2.Text="TabPage2";
			//
			//DataGridView21
			//
			this.DataGridView21.AllowUserToAddRows=false;
			this.DataGridView21.AllowUserToDeleteRows=false;
			this.DataGridView21.AllowUserToResizeColumns=false;
			this.DataGridView21.AllowUserToResizeRows=false;
			DataGridViewCellStyle13.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle13.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle13.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView21.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle13;
			this.DataGridView21.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle14.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle14.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle14.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle14.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle14.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle14.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle14.WrapMode=DataGridViewTriState.True;
			this.DataGridView21.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle14;
			this.DataGridView21.ColumnHeadersHeight=40;
			this.DataGridView21.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.Column3, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn5});
			this.DataGridView21.EnableHeadersVisualStyles=false;
			this.DataGridView21.Location=new System.Drawing.Point(8, 145);
			this.DataGridView21.MultiSelect=false;
			this.DataGridView21.Name="DataGridView21";
			this.DataGridView21.ReadOnly=true;
			this.DataGridView21.RowHeadersVisible=false;
			this.DataGridView21.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView21.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView21.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView21.RowTemplate.ReadOnly=true;
			this.DataGridView21.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView21.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView21.Size=new System.Drawing.Size(403, 372);
			this.DataGridView21.TabIndex=78;
			//
			//DataGridViewTextBoxColumn1
			//
			this.DataGridViewTextBoxColumn1.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly=true;
			this.DataGridViewTextBoxColumn1.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn1.Width=45;
			//
			//DataGridViewTextBoxColumn2
			//
			this.DataGridViewTextBoxColumn2.HeaderText="ساعت اعزام";
			this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly=true;
			this.DataGridViewTextBoxColumn2.Width=65;
			//
			//Column3
			//
			this.Column3.HeaderText="نوع";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Visible=false;
			//
			//DataGridViewTextBoxColumn3
			//
			this.DataGridViewTextBoxColumn3.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly=true;
			this.DataGridViewTextBoxColumn3.Width=80;
			//
			//DataGridViewTextBoxColumn4
			//
			this.DataGridViewTextBoxColumn4.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly=true;
			this.DataGridViewTextBoxColumn4.Width=80;
			//
			//DataGridViewTextBoxColumn5
			//
			this.DataGridViewTextBoxColumn5.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn5.HeaderText="نام گروه";
			this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly=true;
			//
			//DataGridView11
			//
			this.DataGridView11.AllowUserToAddRows=false;
			this.DataGridView11.AllowUserToDeleteRows=false;
			this.DataGridView11.AllowUserToResizeColumns=false;
			this.DataGridView11.AllowUserToResizeRows=false;
			DataGridViewCellStyle15.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle15.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle15.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView11.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle15;
			this.DataGridView11.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle16.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle16.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle16.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle16.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle16.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle16.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle16.WrapMode=DataGridViewTriState.True;
			this.DataGridView11.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle16;
			this.DataGridView11.ColumnHeadersHeight=40;
			this.DataGridView11.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn7, this.DataGridViewTextBoxColumn8, this.Column2, this.DataGridViewTextBoxColumn9, this.DataGridViewTextBoxColumn10, this.DataGridViewTextBoxColumn11});
			this.DataGridView11.EnableHeadersVisualStyles=false;
			this.DataGridView11.Location=new System.Drawing.Point(420, 145);
			this.DataGridView11.MultiSelect=false;
			this.DataGridView11.Name="DataGridView11";
			this.DataGridView11.ReadOnly=true;
			this.DataGridView11.RowHeadersVisible=false;
			this.DataGridView11.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView11.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView11.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView11.RowTemplate.ReadOnly=true;
			this.DataGridView11.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView11.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView11.Size=new System.Drawing.Size(403, 372);
			this.DataGridView11.TabIndex=78;
			//
			//DataGridViewTextBoxColumn7
			//
			this.DataGridViewTextBoxColumn7.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn7.Name="DataGridViewTextBoxColumn7";
			this.DataGridViewTextBoxColumn7.ReadOnly=true;
			this.DataGridViewTextBoxColumn7.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn7.Width=45;
			//
			//DataGridViewTextBoxColumn8
			//
			this.DataGridViewTextBoxColumn8.HeaderText="ساعت اعزام";
			this.DataGridViewTextBoxColumn8.Name="DataGridViewTextBoxColumn8";
			this.DataGridViewTextBoxColumn8.ReadOnly=true;
			this.DataGridViewTextBoxColumn8.Width=65;
			//
			//Column2
			//
			this.Column2.HeaderText="نوع";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Visible=false;
			//
			//DataGridViewTextBoxColumn9
			//
			this.DataGridViewTextBoxColumn9.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn9.Name="DataGridViewTextBoxColumn9";
			this.DataGridViewTextBoxColumn9.ReadOnly=true;
			this.DataGridViewTextBoxColumn9.Width=80;
			//
			//DataGridViewTextBoxColumn10
			//
			this.DataGridViewTextBoxColumn10.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn10.Name="DataGridViewTextBoxColumn10";
			this.DataGridViewTextBoxColumn10.ReadOnly=true;
			this.DataGridViewTextBoxColumn10.Width=80;
			//
			//DataGridViewTextBoxColumn11
			//
			this.DataGridViewTextBoxColumn11.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn11.HeaderText="نام گروه";
			this.DataGridViewTextBoxColumn11.Name="DataGridViewTextBoxColumn11";
			this.DataGridViewTextBoxColumn11.ReadOnly=true;
			//
			//Panel10
			//
			this.Panel10.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel10.BorderStyle=BorderStyle.FixedSingle;
			this.Panel10.Controls.Add(this.Mab21Label);
			this.Panel10.Controls.Add(this.Add2Button);
			this.Panel10.Controls.Add(this.R21);
			this.Panel10.Controls.Add(this.Magh21Label);
			this.Panel10.Controls.Add(this.Label29);
			this.Panel10.Controls.Add(this.Label35);
			this.Panel10.Controls.Add(this.Kind21Label);
			this.Panel10.Controls.Add(this.Label38);
			this.Panel10.Controls.Add(this.Time21Label);
			this.Panel10.Controls.Add(this.Label43);
			this.Panel10.Controls.Add(this.Label44);
			this.Panel10.Location=new System.Drawing.Point(8, 70);
			this.Panel10.Name="Panel10";
			this.Panel10.Size=new System.Drawing.Size(403, 67);
			this.Panel10.TabIndex=79;
			//
			//Mab21Label
			//
			this.Mab21Label.Location=new System.Drawing.Point(111, 8);
			this.Mab21Label.Margin=new Padding(3);
			this.Mab21Label.Name="Mab21Label";
			this.Mab21Label.Size=new System.Drawing.Size(87, 18);
			this.Mab21Label.TabIndex=4;
			this.Mab21Label.Text="پایانه مهرشهر";
			//
			//Add2Button
			//
			this.Add2Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Add2Button.Image=global::Metro_Operation.Properties.Resources._checked;
			this.Add2Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Add2Button.Location=new System.Drawing.Point(6, 31);
			this.Add2Button.Name="Add2Button";
			this.Add2Button.Padding=new Padding(5, 0, 5, 0);
			this.Add2Button.Size=new System.Drawing.Size(100, 30);
			this.Add2Button.TabIndex=80;
			this.Add2Button.Text="تایید";
			this.Add2Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add2Button.UseVisualStyleBackColor=false;
			//
			//R21
			//
			this.R21.DropDownStyle=ComboBoxStyle.DropDownList;
			this.R21.FormattingEnabled=true;
			this.R21.Items.AddRange(new object[] {"تهران", "پایانه تهران"});
			this.R21.Location=new System.Drawing.Point(160, 35);
			this.R21.Name="R21";
			this.R21.Size=new System.Drawing.Size(158, 24);
			this.R21.TabIndex=3;
			//
			//Magh21Label
			//
			this.Magh21Label.Location=new System.Drawing.Point(3, 8);
			this.Magh21Label.Margin=new Padding(3);
			this.Magh21Label.Name="Magh21Label";
			this.Magh21Label.Size=new System.Drawing.Size(87, 18);
			this.Magh21Label.TabIndex=0;
			this.Magh21Label.Text="پایانه مهرشهر";
			//
			//Label29
			//
			this.Label29.AutoSize=true;
			this.Label29.Location=new System.Drawing.Point(90, 9);
			this.Label29.Margin=new Padding(3);
			this.Label29.Name="Label29";
			this.Label29.Size=new System.Drawing.Size(19, 16);
			this.Label29.TabIndex=0;
			this.Label29.Text="به";
			//
			//Label35
			//
			this.Label35.AutoSize=true;
			this.Label35.Location=new System.Drawing.Point(318, 39);
			this.Label35.Margin=new Padding(3);
			this.Label35.Name="Label35";
			this.Label35.Size=new System.Drawing.Size(66, 16);
			this.Label35.TabIndex=0;
			this.Label35.Text="گروه راهبر:";
			//
			//Kind21Label
			//
			this.Kind21Label.Location=new System.Drawing.Point(216, 9);
			this.Kind21Label.Margin=new Padding(3);
			this.Kind21Label.Name="Kind21Label";
			this.Kind21Label.Size=new System.Drawing.Size(56, 16);
			this.Kind21Label.TabIndex=0;
			this.Kind21Label.Text="ورودی";
			//
			//Label38
			//
			this.Label38.AutoSize=true;
			this.Label38.Location=new System.Drawing.Point(268, 9);
			this.Label38.Margin=new Padding(3);
			this.Label38.Name="Label38";
			this.Label38.Size=new System.Drawing.Size(31, 16);
			this.Label38.TabIndex=0;
			this.Label38.Text="نوع:";
			//
			//Time21Label
			//
			this.Time21Label.Location=new System.Drawing.Point(301, 9);
			this.Time21Label.Margin=new Padding(3);
			this.Time21Label.Name="Time21Label";
			this.Time21Label.Size=new System.Drawing.Size(45, 16);
			this.Time21Label.TabIndex=0;
			this.Time21Label.Text="00:00";
			//
			//Label43
			//
			this.Label43.AutoSize=true;
			this.Label43.Location=new System.Drawing.Point(342, 9);
			this.Label43.Margin=new Padding(3);
			this.Label43.Name="Label43";
			this.Label43.Size=new System.Drawing.Size(50, 16);
			this.Label43.TabIndex=0;
			this.Label43.Text="ساعت:";
			//
			//Label44
			//
			this.Label44.AutoSize=true;
			this.Label44.Location=new System.Drawing.Point(196, 9);
			this.Label44.Margin=new Padding(3);
			this.Label44.Name="Label44";
			this.Label44.Size=new System.Drawing.Size(16, 16);
			this.Label44.TabIndex=0;
			this.Label44.Text="از";
			//
			//Panel11
			//
			this.Panel11.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel11.BorderStyle=BorderStyle.FixedSingle;
			this.Panel11.Controls.Add(this.Mab11Label);
			this.Panel11.Controls.Add(this.Add1Button);
			this.Panel11.Controls.Add(this.R11);
			this.Panel11.Controls.Add(this.Magh11Label);
			this.Panel11.Controls.Add(this.Label32);
			this.Panel11.Controls.Add(this.Label39);
			this.Panel11.Controls.Add(this.Kind11Label);
			this.Panel11.Controls.Add(this.Label24);
			this.Panel11.Controls.Add(this.Time11Label);
			this.Panel11.Controls.Add(this.Label40);
			this.Panel11.Controls.Add(this.Label41);
			this.Panel11.Location=new System.Drawing.Point(420, 70);
			this.Panel11.Name="Panel11";
			this.Panel11.Size=new System.Drawing.Size(403, 67);
			this.Panel11.TabIndex=79;
			//
			//Mab11Label
			//
			this.Mab11Label.Location=new System.Drawing.Point(111, 8);
			this.Mab11Label.Margin=new Padding(3);
			this.Mab11Label.Name="Mab11Label";
			this.Mab11Label.Size=new System.Drawing.Size(87, 18);
			this.Mab11Label.TabIndex=4;
			this.Mab11Label.Text="پایانه مهرشهر";
			//
			//Add1Button
			//
			this.Add1Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Add1Button.Image=global::Metro_Operation.Properties.Resources._checked;
			this.Add1Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Add1Button.Location=new System.Drawing.Point(6, 31);
			this.Add1Button.Name="Add1Button";
			this.Add1Button.Padding=new Padding(5, 0, 5, 0);
			this.Add1Button.Size=new System.Drawing.Size(100, 30);
			this.Add1Button.TabIndex=80;
			this.Add1Button.Text="تایید";
			this.Add1Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add1Button.UseVisualStyleBackColor=false;
			//
			//R11
			//
			this.R11.DropDownStyle=ComboBoxStyle.DropDownList;
			this.R11.FormattingEnabled=true;
			this.R11.Items.AddRange(new object[] {"تهران", "پایانه تهران"});
			this.R11.Location=new System.Drawing.Point(169, 35);
			this.R11.Name="R11";
			this.R11.Size=new System.Drawing.Size(158, 24);
			this.R11.TabIndex=3;
			//
			//Magh11Label
			//
			this.Magh11Label.Location=new System.Drawing.Point(3, 8);
			this.Magh11Label.Margin=new Padding(3);
			this.Magh11Label.Name="Magh11Label";
			this.Magh11Label.Size=new System.Drawing.Size(87, 18);
			this.Magh11Label.TabIndex=0;
			this.Magh11Label.Text="پایانه مهرشهر";
			//
			//Label32
			//
			this.Label32.AutoSize=true;
			this.Label32.Location=new System.Drawing.Point(90, 9);
			this.Label32.Margin=new Padding(3);
			this.Label32.Name="Label32";
			this.Label32.Size=new System.Drawing.Size(19, 16);
			this.Label32.TabIndex=0;
			this.Label32.Text="به";
			//
			//Label39
			//
			this.Label39.AutoSize=true;
			this.Label39.Location=new System.Drawing.Point(327, 39);
			this.Label39.Margin=new Padding(3);
			this.Label39.Name="Label39";
			this.Label39.Size=new System.Drawing.Size(66, 16);
			this.Label39.TabIndex=0;
			this.Label39.Text="گروه راهبر:";
			//
			//Kind11Label
			//
			this.Kind11Label.Location=new System.Drawing.Point(216, 9);
			this.Kind11Label.Margin=new Padding(3);
			this.Kind11Label.Name="Kind11Label";
			this.Kind11Label.Size=new System.Drawing.Size(56, 16);
			this.Kind11Label.TabIndex=0;
			this.Kind11Label.Text="ورودی";
			//
			//Label24
			//
			this.Label24.AutoSize=true;
			this.Label24.Location=new System.Drawing.Point(268, 9);
			this.Label24.Margin=new Padding(3);
			this.Label24.Name="Label24";
			this.Label24.Size=new System.Drawing.Size(31, 16);
			this.Label24.TabIndex=0;
			this.Label24.Text="نوع:";
			//
			//Time11Label
			//
			this.Time11Label.Location=new System.Drawing.Point(301, 9);
			this.Time11Label.Margin=new Padding(3);
			this.Time11Label.Name="Time11Label";
			this.Time11Label.Size=new System.Drawing.Size(45, 16);
			this.Time11Label.TabIndex=0;
			this.Time11Label.Text="00:00";
			//
			//Label40
			//
			this.Label40.AutoSize=true;
			this.Label40.Location=new System.Drawing.Point(342, 9);
			this.Label40.Margin=new Padding(3);
			this.Label40.Name="Label40";
			this.Label40.Size=new System.Drawing.Size(50, 16);
			this.Label40.TabIndex=0;
			this.Label40.Text="ساعت:";
			//
			//Label41
			//
			this.Label41.AutoSize=true;
			this.Label41.Location=new System.Drawing.Point(196, 9);
			this.Label41.Margin=new Padding(3);
			this.Label41.Name="Label41";
			this.Label41.Size=new System.Drawing.Size(16, 16);
			this.Label41.TabIndex=0;
			this.Label41.Text="از";
			//
			//PictureBox1
			//
			this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox1.Location=new System.Drawing.Point(58, 6);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(303, 65);
			this.PictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex=76;
			this.PictureBox1.TabStop=false;
			//
			//PictureBox2
			//
			this.PictureBox2.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox2.Location=new System.Drawing.Point(508, 6);
			this.PictureBox2.Name="PictureBox2";
			this.PictureBox2.Size=new System.Drawing.Size(226, 65);
			this.PictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox2.TabIndex=75;
			this.PictureBox2.TabStop=false;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.Back1Button);
			this.Panel3.Controls.Add(this.Button1);
			this.Panel3.Location=new System.Drawing.Point(52, 525);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(726, 50);
			this.Panel3.TabIndex=69;
			//
			//Back1Button
			//
			this.Back1Button.BackColor=System.Drawing.Color.White;
			this.Back1Button.Image=global::Metro_Operation.Properties.Resources._32;
			this.Back1Button.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Back1Button.Location=new System.Drawing.Point(566, 7);
			this.Back1Button.Name="Back1Button";
			this.Back1Button.Size=new System.Drawing.Size(142, 35);
			this.Back1Button.TabIndex=54;
			this.Back1Button.Text="بازگشت";
			this.Back1Button.UseVisualStyleBackColor=false;
			//
			//Button1
			//
			this.Button1.BackColor=System.Drawing.Color.White;
			this.Button1.Image=global::Metro_Operation.Properties.Resources._31;
			this.Button1.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Button1.Location=new System.Drawing.Point(12, 7);
			this.Button1.Name="Button1";
			this.Button1.Size=new System.Drawing.Size(142, 35);
			this.Button1.TabIndex=49;
			this.Button1.Text="مرحله بعدی";
			this.Button1.UseVisualStyleBackColor=false;
			//
			//TabPage1
			//
			this.TabPage1.BackColor=System.Drawing.Color.PowderBlue;
			this.TabPage1.Controls.Add(this.PictureBox8);
			this.TabPage1.Controls.Add(this.PictureBox9);
			this.TabPage1.Controls.Add(this.Panel7);
			this.TabPage1.Controls.Add(this.Panel8);
			this.TabPage1.Controls.Add(this.Panel9);
			this.TabPage1.Location=new System.Drawing.Point(4, 9);
			this.TabPage1.Name="TabPage1";
			this.TabPage1.Padding=new Padding(3);
			this.TabPage1.Size=new System.Drawing.Size(831, 579);
			this.TabPage1.TabIndex=0;
			this.TabPage1.Text="TabPage1";
			//
			//PictureBox8
			//
			this.PictureBox8.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox8.Location=new System.Drawing.Point(443, 248);
			this.PictureBox8.Name="PictureBox8";
			this.PictureBox8.Size=new System.Drawing.Size(303, 65);
			this.PictureBox8.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox8.TabIndex=74;
			this.PictureBox8.TabStop=false;
			//
			//PictureBox9
			//
			this.PictureBox9.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox9.Location=new System.Drawing.Point(520, 9);
			this.PictureBox9.Name="PictureBox9";
			this.PictureBox9.Size=new System.Drawing.Size(226, 65);
			this.PictureBox9.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox9.TabIndex=73;
			this.PictureBox9.TabStop=false;
			//
			//Panel7
			//
			this.Panel7.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel7.BorderStyle=BorderStyle.FixedSingle;
			this.Panel7.Controls.Add(this.ShowButton);
			this.Panel7.Controls.Add(this.Label15);
			this.Panel7.Controls.Add(this.NameCombo);
			this.Panel7.Controls.Add(this.KindCombo);
			this.Panel7.Controls.Add(this.Label16);
			this.Panel7.Location=new System.Drawing.Point(52, 525);
			this.Panel7.Name="Panel7";
			this.Panel7.Size=new System.Drawing.Size(726, 50);
			this.Panel7.TabIndex=68;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=System.Drawing.Color.White;
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources._31;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.ShowButton.Location=new System.Drawing.Point(12, 7);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(142, 35);
			this.ShowButton.TabIndex=49;
			this.ShowButton.Text="مرحله بعدی";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.BackColor=System.Drawing.Color.Transparent;
			this.Label15.ForeColor=System.Drawing.Color.Black;
			this.Label15.Location=new System.Drawing.Point(406, 16);
			this.Label15.Margin=new Padding(3);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(62, 16);
			this.Label15.TabIndex=46;
			this.Label15.Text="نام جدول:";
			this.Label15.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//NameCombo
			//
			this.NameCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.NameCombo.FormattingEnabled=true;
			this.NameCombo.Items.AddRange(new object[] {"روز عادی", "روز تعطیل"});
			this.NameCombo.Location=new System.Drawing.Point(225, 13);
			this.NameCombo.Name="NameCombo";
			this.NameCombo.Size=new System.Drawing.Size(181, 24);
			this.NameCombo.TabIndex=43;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"روز عادی", "روز تعطیل"});
			this.KindCombo.Location=new System.Drawing.Point(500, 12);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(134, 24);
			this.KindCombo.TabIndex=43;
			//
			//Label16
			//
			this.Label16.AutoSize=true;
			this.Label16.BackColor=System.Drawing.Color.Transparent;
			this.Label16.ForeColor=System.Drawing.Color.Black;
			this.Label16.Location=new System.Drawing.Point(634, 16);
			this.Label16.Margin=new Padding(3);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(74, 16);
			this.Label16.TabIndex=45;
			this.Label16.Text="نوع پردازش:";
			this.Label16.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel8
			//
			this.Panel8.BackColor=System.Drawing.Color.Transparent;
			this.Panel8.BorderStyle=BorderStyle.FixedSingle;
			this.Panel8.Controls.Add(this.Panel1);
			this.Panel8.Controls.Add(this.Label8);
			this.Panel8.Controls.Add(this.Label12);
			this.Panel8.Controls.Add(this.Panel2);
			this.Panel8.Location=new System.Drawing.Point(85, 313);
			this.Panel8.Name="Panel8";
			this.Panel8.Size=new System.Drawing.Size(661, 203);
			this.Panel8.TabIndex=66;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Silver;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Gol2Box);
			this.Panel1.Controls.Add(this.ResMeh2Box);
			this.Panel1.Controls.Add(this.KeshMeh2Box);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Mehr2Box);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Location=new System.Drawing.Point(239, 46);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(184, 142);
			this.Panel1.TabIndex=1;
			//
			//Gol2Box
			//
			this.Gol2Box.BackColor=System.Drawing.Color.White;
			this.Gol2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Gol2Box.Location=new System.Drawing.Point(25, 13);
			this.Gol2Box.Mask="90";
			this.Gol2Box.Name="Gol2Box";
			this.Gol2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Gol2Box.Size=new System.Drawing.Size(45, 23);
			this.Gol2Box.TabIndex=1;
			this.Gol2Box.Text="0";
			this.Gol2Box.TextAlign=HorizontalAlignment.Center;
			//
			//ResMeh2Box
			//
			this.ResMeh2Box.BackColor=System.Drawing.Color.White;
			this.ResMeh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.ResMeh2Box.Location=new System.Drawing.Point(25, 98);
			this.ResMeh2Box.Mask="90";
			this.ResMeh2Box.Name="ResMeh2Box";
			this.ResMeh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ResMeh2Box.Size=new System.Drawing.Size(45, 23);
			this.ResMeh2Box.TabIndex=2;
			this.ResMeh2Box.Text="0";
			this.ResMeh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshMeh2Box
			//
			this.KeshMeh2Box.BackColor=System.Drawing.Color.White;
			this.KeshMeh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshMeh2Box.Location=new System.Drawing.Point(25, 69);
			this.KeshMeh2Box.Mask="90";
			this.KeshMeh2Box.Name="KeshMeh2Box";
			this.KeshMeh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshMeh2Box.Size=new System.Drawing.Size(45, 23);
			this.KeshMeh2Box.TabIndex=2;
			this.KeshMeh2Box.Text="0";
			this.KeshMeh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.Location=new System.Drawing.Point(70, 101);
			this.Label9.Margin=new Padding(3);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(81, 16);
			this.Label9.TabIndex=30;
			this.Label9.Text="رزرو مهرشهر:";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.Location=new System.Drawing.Point(70, 16);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(81, 16);
			this.Label5.TabIndex=28;
			this.Label5.Text="راهبر گلشهر:";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.BackColor=System.Drawing.Color.Transparent;
			this.Label6.Location=new System.Drawing.Point(70, 72);
			this.Label6.Margin=new Padding(3);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(99, 16);
			this.Label6.TabIndex=30;
			this.Label6.Text="کشیک مهرشهر:";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Mehr2Box
			//
			this.Mehr2Box.BackColor=System.Drawing.Color.White;
			this.Mehr2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Mehr2Box.Location=new System.Drawing.Point(25, 41);
			this.Mehr2Box.Mask="90";
			this.Mehr2Box.Name="Mehr2Box";
			this.Mehr2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Mehr2Box.Size=new System.Drawing.Size(45, 23);
			this.Mehr2Box.TabIndex=3;
			this.Mehr2Box.Text="0";
			this.Mehr2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.BackColor=System.Drawing.Color.Transparent;
			this.Label7.Location=new System.Drawing.Point(70, 44);
			this.Label7.Margin=new Padding(3);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(88, 16);
			this.Label7.TabIndex=28;
			this.Label7.Text="راهبر مهرشهر:";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label8
			//
			this.Label8.BackColor=System.Drawing.Color.Black;
			this.Label8.BorderStyle=BorderStyle.FixedSingle;
			this.Label8.ForeColor=System.Drawing.Color.Yellow;
			this.Label8.Location=new System.Drawing.Point(239, 19);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(184, 27);
			this.Label8.TabIndex=39;
			this.Label8.Text="تعداد گروه شیفت روز کار";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label12
			//
			this.Label12.BackColor=System.Drawing.Color.Black;
			this.Label12.BorderStyle=BorderStyle.FixedSingle;
			this.Label12.ForeColor=System.Drawing.Color.Yellow;
			this.Label12.Location=new System.Drawing.Point(25, 19);
			this.Label12.Margin=new Padding(3);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(184, 27);
			this.Label12.TabIndex=39;
			this.Label12.Text="تعداد گروه شیفت شب کار";
			this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Silver;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Gol3Box);
			this.Panel2.Controls.Add(this.ResMeh3Box);
			this.Panel2.Controls.Add(this.KeshMeh3Box);
			this.Panel2.Controls.Add(this.Label14);
			this.Panel2.Controls.Add(this.Label10);
			this.Panel2.Controls.Add(this.Label11);
			this.Panel2.Controls.Add(this.Mehr3Box);
			this.Panel2.Controls.Add(this.Label13);
			this.Panel2.Location=new System.Drawing.Point(25, 46);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(184, 142);
			this.Panel2.TabIndex=2;
			//
			//Gol3Box
			//
			this.Gol3Box.BackColor=System.Drawing.Color.White;
			this.Gol3Box.BorderStyle=BorderStyle.FixedSingle;
			this.Gol3Box.Location=new System.Drawing.Point(25, 13);
			this.Gol3Box.Mask="90";
			this.Gol3Box.Name="Gol3Box";
			this.Gol3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Gol3Box.Size=new System.Drawing.Size(45, 23);
			this.Gol3Box.TabIndex=1;
			this.Gol3Box.Text="0";
			this.Gol3Box.TextAlign=HorizontalAlignment.Center;
			//
			//ResMeh3Box
			//
			this.ResMeh3Box.BackColor=System.Drawing.Color.White;
			this.ResMeh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.ResMeh3Box.Location=new System.Drawing.Point(25, 97);
			this.ResMeh3Box.Mask="90";
			this.ResMeh3Box.Name="ResMeh3Box";
			this.ResMeh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ResMeh3Box.Size=new System.Drawing.Size(45, 23);
			this.ResMeh3Box.TabIndex=2;
			this.ResMeh3Box.Text="0";
			this.ResMeh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//KeshMeh3Box
			//
			this.KeshMeh3Box.BackColor=System.Drawing.Color.White;
			this.KeshMeh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshMeh3Box.Location=new System.Drawing.Point(25, 69);
			this.KeshMeh3Box.Mask="90";
			this.KeshMeh3Box.Name="KeshMeh3Box";
			this.KeshMeh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.KeshMeh3Box.Size=new System.Drawing.Size(45, 23);
			this.KeshMeh3Box.TabIndex=2;
			this.KeshMeh3Box.Text="0";
			this.KeshMeh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.BackColor=System.Drawing.Color.Transparent;
			this.Label14.Location=new System.Drawing.Point(70, 100);
			this.Label14.Margin=new Padding(3);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(81, 16);
			this.Label14.TabIndex=30;
			this.Label14.Text="رزرو مهرشهر:";
			this.Label14.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.Location=new System.Drawing.Point(70, 16);
			this.Label10.Margin=new Padding(3);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(81, 16);
			this.Label10.TabIndex=28;
			this.Label10.Text="راهبر گلشهر:";
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.BackColor=System.Drawing.Color.Transparent;
			this.Label11.Location=new System.Drawing.Point(70, 72);
			this.Label11.Margin=new Padding(3);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(99, 16);
			this.Label11.TabIndex=30;
			this.Label11.Text="کشیک مهرشهر:";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Mehr3Box
			//
			this.Mehr3Box.BackColor=System.Drawing.Color.White;
			this.Mehr3Box.BorderStyle=BorderStyle.FixedSingle;
			this.Mehr3Box.Location=new System.Drawing.Point(25, 41);
			this.Mehr3Box.Mask="90";
			this.Mehr3Box.Name="Mehr3Box";
			this.Mehr3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Mehr3Box.Size=new System.Drawing.Size(45, 23);
			this.Mehr3Box.TabIndex=3;
			this.Mehr3Box.Text="0";
			this.Mehr3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.Location=new System.Drawing.Point(70, 44);
			this.Label13.Margin=new Padding(3);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(88, 16);
			this.Label13.TabIndex=28;
			this.Label13.Text="راهبر مهرشهر:";
			this.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Panel9
			//
			this.Panel9.BackColor=System.Drawing.Color.Transparent;
			this.Panel9.BorderStyle=BorderStyle.FixedSingle;
			this.Panel9.Controls.Add(this.Panel4);
			this.Panel9.Controls.Add(this.Label34);
			this.Panel9.Controls.Add(this.Label33);
			this.Panel9.Controls.Add(this.Panel6);
			this.Panel9.Location=new System.Drawing.Point(85, 74);
			this.Panel9.Name="Panel9";
			this.Panel9.Size=new System.Drawing.Size(661, 165);
			this.Panel9.TabIndex=64;
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.Silver;
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.Label30);
			this.Panel4.Controls.Add(this.ResTeh3Box);
			this.Panel4.Controls.Add(this.Teh3Box);
			this.Panel4.Controls.Add(this.Label3);
			this.Panel4.Controls.Add(this.KeshTeh3Box);
			this.Panel4.Controls.Add(this.Label22);
			this.Panel4.Location=new System.Drawing.Point(29, 37);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(184, 111);
			this.Panel4.TabIndex=2;
			//
			//Label30
			//
			this.Label30.AutoSize=true;
			this.Label30.BackColor=System.Drawing.Color.Transparent;
			this.Label30.Location=new System.Drawing.Point(81, 15);
			this.Label30.Margin=new Padding(3);
			this.Label30.Name="Label30";
			this.Label30.Size=new System.Drawing.Size(72, 16);
			this.Label30.TabIndex=36;
			this.Label30.Text="راهبر تهران:";
			this.Label30.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//ResTeh3Box
			//
			this.ResTeh3Box.BackColor=System.Drawing.Color.White;
			this.ResTeh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.ResTeh3Box.Location=new System.Drawing.Point(36, 69);
			this.ResTeh3Box.Mask="90";
			this.ResTeh3Box.Name="ResTeh3Box";
			this.ResTeh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ResTeh3Box.Size=new System.Drawing.Size(45, 23);
			this.ResTeh3Box.TabIndex=2;
			this.ResTeh3Box.Text="0";
			this.ResTeh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Teh3Box
			//
			this.Teh3Box.BackColor=System.Drawing.Color.White;
			this.Teh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.Teh3Box.Location=new System.Drawing.Point(36, 12);
			this.Teh3Box.Mask="90";
			this.Teh3Box.Name="Teh3Box";
			this.Teh3Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Teh3Box.Size=new System.Drawing.Size(45, 23);
			this.Teh3Box.TabIndex=1;
			this.Teh3Box.Text="0";
			this.Teh3Box.TextAlign=HorizontalAlignment.Center;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.Location=new System.Drawing.Point(81, 72);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(65, 16);
			this.Label3.TabIndex=30;
			this.Label3.Text="رزرو تهران:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//KeshTeh3Box
			//
			this.KeshTeh3Box.BackColor=System.Drawing.Color.White;
			this.KeshTeh3Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshTeh3Box.Location=new System.Drawing.Point(36, 40);
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
			this.Label22.Location=new System.Drawing.Point(80, 43);
			this.Label22.Margin=new Padding(3);
			this.Label22.Name="Label22";
			this.Label22.Size=new System.Drawing.Size(83, 16);
			this.Label22.TabIndex=30;
			this.Label22.Text="کشیک تهران:";
			this.Label22.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label34
			//
			this.Label34.BackColor=System.Drawing.Color.Black;
			this.Label34.BorderStyle=BorderStyle.FixedSingle;
			this.Label34.ForeColor=System.Drawing.Color.Yellow;
			this.Label34.Location=new System.Drawing.Point(243, 10);
			this.Label34.Margin=new Padding(3);
			this.Label34.Name="Label34";
			this.Label34.Size=new System.Drawing.Size(184, 27);
			this.Label34.TabIndex=54;
			this.Label34.Text="تعداد گروه شیفت روز کار";
			this.Label34.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label33
			//
			this.Label33.BackColor=System.Drawing.Color.Black;
			this.Label33.BorderStyle=BorderStyle.FixedSingle;
			this.Label33.ForeColor=System.Drawing.Color.Yellow;
			this.Label33.Location=new System.Drawing.Point(29, 10);
			this.Label33.Margin=new Padding(3);
			this.Label33.Name="Label33";
			this.Label33.Size=new System.Drawing.Size(184, 27);
			this.Label33.TabIndex=53;
			this.Label33.Text="تعداد گروه شیفت شب کار";
			this.Label33.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel6
			//
			this.Panel6.BackColor=System.Drawing.Color.Silver;
			this.Panel6.BorderStyle=BorderStyle.FixedSingle;
			this.Panel6.Controls.Add(this.Label21);
			this.Panel6.Controls.Add(this.ResTeh2Box);
			this.Panel6.Controls.Add(this.Teh2Box);
			this.Panel6.Controls.Add(this.Label2);
			this.Panel6.Controls.Add(this.KeshTeh2Box);
			this.Panel6.Controls.Add(this.Label31);
			this.Panel6.Location=new System.Drawing.Point(243, 37);
			this.Panel6.Name="Panel6";
			this.Panel6.Size=new System.Drawing.Size(184, 111);
			this.Panel6.TabIndex=1;
			//
			//Label21
			//
			this.Label21.AutoSize=true;
			this.Label21.BackColor=System.Drawing.Color.Transparent;
			this.Label21.Location=new System.Drawing.Point(82, 15);
			this.Label21.Margin=new Padding(3);
			this.Label21.Name="Label21";
			this.Label21.Size=new System.Drawing.Size(72, 16);
			this.Label21.TabIndex=36;
			this.Label21.Text="راهبر تهران:";
			this.Label21.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//ResTeh2Box
			//
			this.ResTeh2Box.BackColor=System.Drawing.Color.White;
			this.ResTeh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.ResTeh2Box.Location=new System.Drawing.Point(37, 69);
			this.ResTeh2Box.Mask="90";
			this.ResTeh2Box.Name="ResTeh2Box";
			this.ResTeh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.ResTeh2Box.Size=new System.Drawing.Size(45, 23);
			this.ResTeh2Box.TabIndex=2;
			this.ResTeh2Box.Text="0";
			this.ResTeh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Teh2Box
			//
			this.Teh2Box.BackColor=System.Drawing.Color.White;
			this.Teh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Teh2Box.Location=new System.Drawing.Point(37, 12);
			this.Teh2Box.Mask="90";
			this.Teh2Box.Name="Teh2Box";
			this.Teh2Box.PromptChar=global::Microsoft.VisualBasic.Strings.ChrW(32);
			this.Teh2Box.Size=new System.Drawing.Size(45, 23);
			this.Teh2Box.TabIndex=1;
			this.Teh2Box.Text="0";
			this.Teh2Box.TextAlign=HorizontalAlignment.Center;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.Location=new System.Drawing.Point(81, 72);
			this.Label2.Margin=new Padding(3);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(65, 16);
			this.Label2.TabIndex=30;
			this.Label2.Text="رزرو تهران:";
			this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//KeshTeh2Box
			//
			this.KeshTeh2Box.BackColor=System.Drawing.Color.White;
			this.KeshTeh2Box.BorderStyle=BorderStyle.FixedSingle;
			this.KeshTeh2Box.Location=new System.Drawing.Point(37, 40);
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
			this.Label31.Location=new System.Drawing.Point(81, 43);
			this.Label31.Margin=new Padding(3);
			this.Label31.Name="Label31";
			this.Label31.Size=new System.Drawing.Size(83, 16);
			this.Label31.TabIndex=30;
			this.Label31.Text="کشیک تهران:";
			this.Label31.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Dock=DockStyle.Fill;
			this.TabControl1.ItemSize=new System.Drawing.Size(96, 5);
			this.TabControl1.Location=new System.Drawing.Point(0, 0);
			this.TabControl1.Name="TabControl1";
			this.TabControl1.RightToLeftLayout=true;
			this.TabControl1.SelectedIndex=0;
			this.TabControl1.Size=new System.Drawing.Size(839, 592);
			this.TabControl1.SizeMode=TabSizeMode.Fixed;
			this.TabControl1.TabIndex=0;
			//
			//TerminalPatternRegForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.SystemColors.Control;
			this.ClientSize=new System.Drawing.Size(839, 592);
			this.Controls.Add(this.TabControl1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalPatternRegForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت الگوی تریپ پایانه";
			this.TabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView22).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView12).EndInit();
			this.Panel12.ResumeLayout(false);
			this.Panel12.PerformLayout();
			this.Panel13.ResumeLayout(false);
			this.Panel13.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).EndInit();
			this.Panel14.ResumeLayout(false);
			this.Panel14.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView21).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView11).EndInit();
			this.Panel10.ResumeLayout(false);
			this.Panel10.PerformLayout();
			this.Panel11.ResumeLayout(false);
			this.Panel11.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).EndInit();
			this.Panel3.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			this.Panel7.ResumeLayout(false);
			this.Panel7.PerformLayout();
			this.Panel8.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel9.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.Panel6.ResumeLayout(false);
			this.Panel6.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		private TabPage TabPage4;
		private DataGridView DataGridView22;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
		private DataGridView DataGridView12;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
		private Panel Panel12;
		private Label Mab22Label;
		private Button Add4Button;
		private ComboBox R22;
		private Label Magh22Label;
		private Label Label25;
		private Label Label28;
		private Label Kind22Label;
		private Label Label42;
		private Label Time22Label;
		private Label Label46;
		private Label Label47;
		private Panel Panel13;
		private Label Mab12Label;
		private Button Add3Button;
		private ComboBox R12;
		private Label Magh12Label;
		private Label Label50;
		private Label Label51;
		private Label Kind12Label;
		private Label Label53;
		private Label Time12Label;
		private Label Label55;
		private Label Label56;
		private PictureBox PictureBox3;
		private PictureBox PictureBox4;
		private Panel Panel14;
		private TextBox NameBox;
		private Label Label17;
		private Button Back2Button;
		private Button RegButton;
		private TabPage TabPage2;
		private DataGridView DataGridView21;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private DataGridView DataGridView11;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
		private Panel Panel10;
		private Label Mab21Label;
		private Button Add2Button;
		private ComboBox R21;
		private Label Magh21Label;
		private Label Label29;
		private Label Label35;
		private Label Kind21Label;
		private Label Label38;
		private Label Time21Label;
		private Label Label43;
		private Label Label44;
		private Panel Panel11;
		private Label Mab11Label;
		private Button Add1Button;
		private ComboBox R11;
		private Label Magh11Label;
		private Label Label32;
		private Label Label39;
		private Label Kind11Label;
		private Label Label24;
		private Label Time11Label;
		private Label Label40;
		private Label Label41;
		private PictureBox PictureBox1;
		private PictureBox PictureBox2;
		private Panel Panel3;
		private Button Back1Button;
		private Button Button1;
		private TabPage TabPage1;
		private PictureBox PictureBox8;
		private PictureBox PictureBox9;
		private Panel Panel7;
		private Button ShowButton;
		private Label Label15;
		private ComboBox NameCombo;
		private ComboBox KindCombo;
		private Label Label16;
		private Panel Panel8;
		private Panel Panel1;
		private MaskedTextBox Gol2Box;
		private MaskedTextBox ResMeh2Box;
		private MaskedTextBox KeshMeh2Box;
		private Label Label9;
		private Label Label5;
		private Label Label6;
		private MaskedTextBox Mehr2Box;
		private Label Label7;
		private Label Label8;
		private Label Label12;
		private Panel Panel2;
		private MaskedTextBox Gol3Box;
		private MaskedTextBox ResMeh3Box;
		private MaskedTextBox KeshMeh3Box;
		private Label Label14;
		private Label Label10;
		private Label Label11;
		private MaskedTextBox Mehr3Box;
		private Label Label13;
		private Panel Panel9;
		private Panel Panel4;
		private Label Label30;
		private MaskedTextBox ResTeh3Box;
		private MaskedTextBox Teh3Box;
		private Label Label3;
		private MaskedTextBox KeshTeh3Box;
		private Label Label22;
		private Label Label34;
		private Label Label33;
		private Panel Panel6;
		private Label Label21;
		private MaskedTextBox ResTeh2Box;
		private MaskedTextBox Teh2Box;
		private Label Label2;
		private MaskedTextBox KeshTeh2Box;
		private Label Label31;
		private TabControl TabControl1;
	}
	
}
