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
		public partial class TerminalTableRegForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle13=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle14=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle15=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle16=new DataGridViewCellStyle();
			this.PictureBox9=new PictureBox();
			base.Load += new System.EventHandler(TerminalTableRegForm_Load);
			this.Panel10=new Panel();
			this.TehGridView=new DataGridView();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Panel11=new Panel();
			this.Time1Box=new MaskedTextBox();
			this.Magh1Combo=new ComboBox();
			this.Kind1Combo=new ComboBox();
			this.Mabd1Combo=new ComboBox();
			this.Label39=new Label();
			this.Label4=new Label();
			this.Label40=new Label();
			this.Label41=new Label();
			this.Del1Button=new Button();
			this.Del1Button.Click += new System.EventHandler(this.Del1Button_Click);
			this.Add1Button=new Button();
			this.Add1Button.Click += new System.EventHandler(this.Add1Button_Click);
			this.PictureBox8=new PictureBox();
			this.Panel20=new Panel();
			this.MehGridView=new DataGridView();
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
			this.Panel21=new Panel();
			this.Kind2Combo=new ComboBox();
			this.Label5=new Label();
			this.Time2Box=new MaskedTextBox();
			this.Magh2Combo=new ComboBox();
			this.Mabd2Combo=new ComboBox();
			this.Label1=new Label();
			this.Label2=new Label();
			this.Label3=new Label();
			this.Del2Button=new Button();
			this.Del2Button.Click += new System.EventHandler(this.Del2Button_Click);
			this.Add2Button=new Button();
			this.Add2Button.Click += new System.EventHandler(this.Add2Button_Click);
			this.ImportPanel=new Panel();
			this.ImportTableNameBox=new TextBox();
			this.Label6=new Label();
			this.ImportRegButton=new Button();
			this.ImportRegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.ImportKindCombo=new ComboBox();
			this.Label7=new Label();
			this.ImportExitButton=new Button();
			this.ImportExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.SelectButton=new Button();
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			this.Label8=new Label();
			this.NameBox=new TextBox();
			this.NormalPanel=new Panel();
			this.NormalTableNameBox=new TextBox();
			this.Label9=new Label();
			this.NormalRegButton=new Button();
			this.NormalKindCombo=new ComboBox();
			this.Label10=new Label();
			this.NormalExitButton=new Button();
			this.NormalExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			this.Panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.TehGridView).BeginInit();
			this.Panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			this.Panel20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.MehGridView).BeginInit();
			this.Panel21.SuspendLayout();
			this.ImportPanel.SuspendLayout();
			this.NormalPanel.SuspendLayout();
			this.SuspendLayout();
			//
			//PictureBox9
			//
			this.PictureBox9.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox9.Location=new System.Drawing.Point(680, 72);
			this.PictureBox9.Name="PictureBox9";
			this.PictureBox9.Size=new System.Drawing.Size(226, 65);
			this.PictureBox9.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox9.TabIndex=72;
			this.PictureBox9.TabStop=false;
			//
			//Panel10
			//
			this.Panel10.AutoScroll=true;
			this.Panel10.BackColor=System.Drawing.Color.Transparent;
			this.Panel10.BorderStyle=BorderStyle.FixedSingle;
			this.Panel10.Controls.Add(this.TehGridView);
			this.Panel10.Controls.Add(this.Panel11);
			this.Panel10.Controls.Add(this.Del1Button);
			this.Panel10.Controls.Add(this.Add1Button);
			this.Panel10.Location=new System.Drawing.Point(533, 135);
			this.Panel10.Name="Panel10";
			this.Panel10.Size=new System.Drawing.Size(520, 509);
			this.Panel10.TabIndex=0;
			//
			//TehGridView
			//
			this.TehGridView.AllowUserToAddRows=false;
			this.TehGridView.AllowUserToDeleteRows=false;
			this.TehGridView.AllowUserToResizeColumns=false;
			this.TehGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle13.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle13.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle13.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TehGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle13;
			this.TehGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle14.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle14.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle14.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle14.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle14.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle14.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle14.WrapMode=DataGridViewTriState.False;
			this.TehGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle14;
			this.TehGridView.ColumnHeadersHeight=40;
			this.TehGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TehGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column9, this.Column1, this.Column3, this.Column7, this.Column2});
			this.TehGridView.EnableHeadersVisualStyles=false;
			this.TehGridView.Location=new System.Drawing.Point(7, 83);
			this.TehGridView.MultiSelect=false;
			this.TehGridView.Name="TehGridView";
			this.TehGridView.ReadOnly=true;
			this.TehGridView.RowHeadersVisible=false;
			this.TehGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.TehGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.TehGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TehGridView.RowTemplate.ReadOnly=true;
			this.TehGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.TehGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.TehGridView.Size=new System.Drawing.Size(504, 416);
			this.TehGridView.TabIndex=49;
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
			this.Column1.Resizable=DataGridViewTriState.False;
			this.Column1.Width=90;
			//
			//Column3
			//
			this.Column3.HeaderText="نوع";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=75;
			//
			//Column7
			//
			this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText="مبداء";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Resizable=DataGridViewTriState.False;
			//
			//Column2
			//
			this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText="مقصد";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Resizable=DataGridViewTriState.False;
			//
			//Panel11
			//
			this.Panel11.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel11.BorderStyle=BorderStyle.FixedSingle;
			this.Panel11.Controls.Add(this.Time1Box);
			this.Panel11.Controls.Add(this.Magh1Combo);
			this.Panel11.Controls.Add(this.Kind1Combo);
			this.Panel11.Controls.Add(this.Mabd1Combo);
			this.Panel11.Controls.Add(this.Label39);
			this.Panel11.Controls.Add(this.Label4);
			this.Panel11.Controls.Add(this.Label40);
			this.Panel11.Controls.Add(this.Label41);
			this.Panel11.Location=new System.Drawing.Point(6, 8);
			this.Panel11.Name="Panel11";
			this.Panel11.Size=new System.Drawing.Size(506, 35);
			this.Panel11.TabIndex=0;
			//
			//Time1Box
			//
			this.Time1Box.BackColor=System.Drawing.Color.White;
			this.Time1Box.BorderStyle=BorderStyle.FixedSingle;
			this.Time1Box.Location=new System.Drawing.Point(399, 6);
			this.Time1Box.Mask="00:00";
			this.Time1Box.Name="Time1Box";
			this.Time1Box.Size=new System.Drawing.Size(45, 23);
			this.Time1Box.TabIndex=0;
			this.Time1Box.TextAlign=HorizontalAlignment.Center;
			//
			//Magh1Combo
			//
			this.Magh1Combo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.Magh1Combo.FormattingEnabled=true;
			this.Magh1Combo.Items.AddRange(new object[] {"تهران", "پایانه تهران"});
			this.Magh1Combo.Location=new System.Drawing.Point(11, 5);
			this.Magh1Combo.Name="Magh1Combo";
			this.Magh1Combo.Size=new System.Drawing.Size(85, 24);
			this.Magh1Combo.TabIndex=3;
			//
			//Kind1Combo
			//
			this.Kind1Combo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.Kind1Combo.FormattingEnabled=true;
			this.Kind1Combo.Items.AddRange(new object[] {"ورودی", "خروجی"});
			this.Kind1Combo.Location=new System.Drawing.Point(272, 5);
			this.Kind1Combo.Name="Kind1Combo";
			this.Kind1Combo.Size=new System.Drawing.Size(85, 24);
			this.Kind1Combo.TabIndex=1;
			//
			//Mabd1Combo
			//
			this.Mabd1Combo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.Mabd1Combo.FormattingEnabled=true;
			this.Mabd1Combo.Items.AddRange(new object[] {"تهران", "پایانه تهران"});
			this.Mabd1Combo.Location=new System.Drawing.Point(146, 5);
			this.Mabd1Combo.Name="Mabd1Combo";
			this.Mabd1Combo.Size=new System.Drawing.Size(85, 24);
			this.Mabd1Combo.TabIndex=2;
			//
			//Label39
			//
			this.Label39.AutoSize=true;
			this.Label39.Location=new System.Drawing.Point(96, 9);
			this.Label39.Margin=new Padding(3);
			this.Label39.Name="Label39";
			this.Label39.Size=new System.Drawing.Size(44, 16);
			this.Label39.TabIndex=0;
			this.Label39.Text="مقصد:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(357, 9);
			this.Label4.Margin=new Padding(3);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(31, 16);
			this.Label4.TabIndex=0;
			this.Label4.Text="نوع:";
			//
			//Label40
			//
			this.Label40.AutoSize=true;
			this.Label40.Location=new System.Drawing.Point(444, 9);
			this.Label40.Margin=new Padding(3);
			this.Label40.Name="Label40";
			this.Label40.Size=new System.Drawing.Size(50, 16);
			this.Label40.TabIndex=0;
			this.Label40.Text="ساعت:";
			//
			//Label41
			//
			this.Label41.AutoSize=true;
			this.Label41.Location=new System.Drawing.Point(231, 9);
			this.Label41.Margin=new Padding(3);
			this.Label41.Name="Label41";
			this.Label41.Size=new System.Drawing.Size(35, 16);
			this.Label41.TabIndex=0;
			this.Label41.Text="مبدا:";
			//
			//Del1Button
			//
			this.Del1Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.Del1Button.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
			this.Del1Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Del1Button.Location=new System.Drawing.Point(7, 47);
			this.Del1Button.Name="Del1Button";
			this.Del1Button.Padding=new Padding(5, 0, 5, 0);
			this.Del1Button.Size=new System.Drawing.Size(100, 32);
			this.Del1Button.TabIndex=2;
			this.Del1Button.Text="حذف";
			this.Del1Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Del1Button.UseVisualStyleBackColor=false;
			//
			//Add1Button
			//
			this.Add1Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.Add1Button.Image=global::Metro_Operation.Properties.Resources.add;
			this.Add1Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Add1Button.Location=new System.Drawing.Point(412, 47);
			this.Add1Button.Name="Add1Button";
			this.Add1Button.Padding=new Padding(5, 0, 5, 0);
			this.Add1Button.Size=new System.Drawing.Size(100, 32);
			this.Add1Button.TabIndex=1;
			this.Add1Button.Text="اضافه";
			this.Add1Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add1Button.UseVisualStyleBackColor=false;
			//
			//PictureBox8
			//
			this.PictureBox8.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox8.Location=new System.Drawing.Point(115, 72);
			this.PictureBox8.Name="PictureBox8";
			this.PictureBox8.Size=new System.Drawing.Size(303, 65);
			this.PictureBox8.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox8.TabIndex=73;
			this.PictureBox8.TabStop=false;
			//
			//Panel20
			//
			this.Panel20.AutoScroll=true;
			this.Panel20.BackColor=System.Drawing.Color.Transparent;
			this.Panel20.BorderStyle=BorderStyle.FixedSingle;
			this.Panel20.Controls.Add(this.MehGridView);
			this.Panel20.Controls.Add(this.Panel21);
			this.Panel20.Controls.Add(this.Del2Button);
			this.Panel20.Controls.Add(this.Add2Button);
			this.Panel20.Location=new System.Drawing.Point(6, 135);
			this.Panel20.Name="Panel20";
			this.Panel20.Size=new System.Drawing.Size(520, 509);
			this.Panel20.TabIndex=1;
			//
			//MehGridView
			//
			this.MehGridView.AllowUserToAddRows=false;
			this.MehGridView.AllowUserToDeleteRows=false;
			this.MehGridView.AllowUserToResizeColumns=false;
			this.MehGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle15.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle15.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle15.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MehGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle15;
			this.MehGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle16.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle16.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle16.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle16.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle16.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle16.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle16.WrapMode=DataGridViewTriState.False;
			this.MehGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle16;
			this.MehGridView.ColumnHeadersHeight=40;
			this.MehGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.MehGridView.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn5});
			this.MehGridView.EnableHeadersVisualStyles=false;
			this.MehGridView.Location=new System.Drawing.Point(7, 83);
			this.MehGridView.MultiSelect=false;
			this.MehGridView.Name="MehGridView";
			this.MehGridView.ReadOnly=true;
			this.MehGridView.RowHeadersVisible=false;
			this.MehGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.MehGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.MehGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MehGridView.RowTemplate.ReadOnly=true;
			this.MehGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.MehGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.MehGridView.Size=new System.Drawing.Size(504, 416);
			this.MehGridView.TabIndex=50;
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
			this.DataGridViewTextBoxColumn2.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn2.Width=90;
			//
			//DataGridViewTextBoxColumn3
			//
			this.DataGridViewTextBoxColumn3.HeaderText="نوع";
			this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly=true;
			this.DataGridViewTextBoxColumn3.Width=75;
			//
			//DataGridViewTextBoxColumn4
			//
			this.DataGridViewTextBoxColumn4.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn4.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly=true;
			this.DataGridViewTextBoxColumn4.Resizable=DataGridViewTriState.False;
			//
			//DataGridViewTextBoxColumn5
			//
			this.DataGridViewTextBoxColumn5.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn5.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly=true;
			this.DataGridViewTextBoxColumn5.Resizable=DataGridViewTriState.False;
			//
			//Panel21
			//
			this.Panel21.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel21.BorderStyle=BorderStyle.FixedSingle;
			this.Panel21.Controls.Add(this.Kind2Combo);
			this.Panel21.Controls.Add(this.Label5);
			this.Panel21.Controls.Add(this.Time2Box);
			this.Panel21.Controls.Add(this.Magh2Combo);
			this.Panel21.Controls.Add(this.Mabd2Combo);
			this.Panel21.Controls.Add(this.Label1);
			this.Panel21.Controls.Add(this.Label2);
			this.Panel21.Controls.Add(this.Label3);
			this.Panel21.Location=new System.Drawing.Point(6, 8);
			this.Panel21.Name="Panel21";
			this.Panel21.Size=new System.Drawing.Size(506, 35);
			this.Panel21.TabIndex=0;
			//
			//Kind2Combo
			//
			this.Kind2Combo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.Kind2Combo.FormattingEnabled=true;
			this.Kind2Combo.Items.AddRange(new object[] {"ورودی", "خروجی"});
			this.Kind2Combo.Location=new System.Drawing.Point(273, 5);
			this.Kind2Combo.Name="Kind2Combo";
			this.Kind2Combo.Size=new System.Drawing.Size(85, 24);
			this.Kind2Combo.TabIndex=1;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(358, 9);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(31, 16);
			this.Label5.TabIndex=6;
			this.Label5.Text="نوع:";
			//
			//Time2Box
			//
			this.Time2Box.BackColor=System.Drawing.Color.White;
			this.Time2Box.BorderStyle=BorderStyle.FixedSingle;
			this.Time2Box.Location=new System.Drawing.Point(399, 6);
			this.Time2Box.Mask="00:00";
			this.Time2Box.Name="Time2Box";
			this.Time2Box.Size=new System.Drawing.Size(45, 23);
			this.Time2Box.TabIndex=0;
			this.Time2Box.TextAlign=HorizontalAlignment.Center;
			//
			//Magh2Combo
			//
			this.Magh2Combo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.Magh2Combo.FormattingEnabled=true;
			this.Magh2Combo.Items.AddRange(new object[] {"گلشهر", "پایانه مهرشهر"});
			this.Magh2Combo.Location=new System.Drawing.Point(11, 5);
			this.Magh2Combo.Name="Magh2Combo";
			this.Magh2Combo.Size=new System.Drawing.Size(85, 24);
			this.Magh2Combo.TabIndex=3;
			//
			//Mabd2Combo
			//
			this.Mabd2Combo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.Mabd2Combo.FormattingEnabled=true;
			this.Mabd2Combo.Items.AddRange(new object[] {"گلشهر", "پایانه مهرشهر"});
			this.Mabd2Combo.Location=new System.Drawing.Point(146, 5);
			this.Mabd2Combo.Name="Mabd2Combo";
			this.Mabd2Combo.Size=new System.Drawing.Size(85, 24);
			this.Mabd2Combo.TabIndex=2;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(96, 9);
			this.Label1.Margin=new Padding(3);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(44, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="مقصد:";
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(444, 9);
			this.Label2.Margin=new Padding(3);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(50, 16);
			this.Label2.TabIndex=0;
			this.Label2.Text="ساعت:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(231, 9);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(35, 16);
			this.Label3.TabIndex=0;
			this.Label3.Text="مبدا:";
			//
			//Del2Button
			//
			this.Del2Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.Del2Button.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
			this.Del2Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Del2Button.Location=new System.Drawing.Point(7, 47);
			this.Del2Button.Name="Del2Button";
			this.Del2Button.Padding=new Padding(5, 0, 5, 0);
			this.Del2Button.Size=new System.Drawing.Size(100, 32);
			this.Del2Button.TabIndex=2;
			this.Del2Button.Text="حذف";
			this.Del2Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Del2Button.UseVisualStyleBackColor=false;
			//
			//Add2Button
			//
			this.Add2Button.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.Add2Button.Image=global::Metro_Operation.Properties.Resources.add;
			this.Add2Button.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.Add2Button.Location=new System.Drawing.Point(411, 47);
			this.Add2Button.Name="Add2Button";
			this.Add2Button.Padding=new Padding(5, 0, 5, 0);
			this.Add2Button.Size=new System.Drawing.Size(100, 32);
			this.Add2Button.TabIndex=1;
			this.Add2Button.Text="اضافه";
			this.Add2Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add2Button.UseVisualStyleBackColor=false;
			//
			//ImportPanel
			//
			this.ImportPanel.BorderStyle=BorderStyle.FixedSingle;
			this.ImportPanel.Controls.Add(this.ImportTableNameBox);
			this.ImportPanel.Controls.Add(this.Label6);
			this.ImportPanel.Controls.Add(this.ImportRegButton);
			this.ImportPanel.Controls.Add(this.ImportKindCombo);
			this.ImportPanel.Controls.Add(this.Label7);
			this.ImportPanel.Controls.Add(this.ImportExitButton);
			this.ImportPanel.Controls.Add(this.SelectButton);
			this.ImportPanel.Controls.Add(this.Label8);
			this.ImportPanel.Controls.Add(this.NameBox);
			this.ImportPanel.Location=new System.Drawing.Point(6, 12);
			this.ImportPanel.Name="ImportPanel";
			this.ImportPanel.Size=new System.Drawing.Size(1047, 58);
			this.ImportPanel.TabIndex=150;
			//
			//ImportTableNameBox
			//
			this.ImportTableNameBox.Location=new System.Drawing.Point(280, 17);
			this.ImportTableNameBox.Name="ImportTableNameBox";
			this.ImportTableNameBox.Size=new System.Drawing.Size(166, 23);
			this.ImportTableNameBox.TabIndex=142;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.BackColor=System.Drawing.Color.Transparent;
			this.Label6.ForeColor=System.Drawing.Color.Black;
			this.Label6.Location=new System.Drawing.Point(447, 21);
			this.Label6.Margin=new Padding(3);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(104, 16);
			this.Label6.TabIndex=144;
			this.Label6.Text="نام جدول حرکتی:";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ImportRegButton
			//
			this.ImportRegButton.BackColor=System.Drawing.Color.Yellow;
			this.ImportRegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.ImportRegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ImportRegButton.Cursor=Cursors.Hand;
			this.ImportRegButton.DialogResult=DialogResult.None;
			this.ImportRegButton.ForeColor=System.Drawing.Color.Black;
			this.ImportRegButton.Location=new System.Drawing.Point(139, 11);
			this.ImportRegButton.Name="ImportRegButton";
			this.ImportRegButton.Size=new System.Drawing.Size(120, 34);
			this.ImportRegButton.TabIndex=143;
			this.ImportRegButton.Text="ذخیره";
			this.ImportRegButton.UseVisualStyleBackColor=false;
			//
			//ImportKindCombo
			//
			this.ImportKindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ImportKindCombo.FormattingEnabled=true;
			this.ImportKindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.ImportKindCombo.Location=new System.Drawing.Point(583, 17);
			this.ImportKindCombo.Name="ImportKindCombo";
			this.ImportKindCombo.Size=new System.Drawing.Size(119, 24);
			this.ImportKindCombo.TabIndex=140;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.BackColor=System.Drawing.Color.Transparent;
			this.Label7.ForeColor=System.Drawing.Color.Black;
			this.Label7.Location=new System.Drawing.Point(702, 21);
			this.Label7.Margin=new Padding(3);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(106, 16);
			this.Label7.TabIndex=141;
			this.Label7.Text="نوع جدول حرکتی:";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ImportExitButton
			//
			this.ImportExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ImportExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ImportExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ImportExitButton.Cursor=Cursors.Hand;
			this.ImportExitButton.DialogResult=DialogResult.None;
			this.ImportExitButton.Location=new System.Drawing.Point(12, 11);
			this.ImportExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ImportExitButton.Name="ImportExitButton";
			this.ImportExitButton.Size=new System.Drawing.Size(120, 34);
			this.ImportExitButton.TabIndex=133;
			this.ImportExitButton.Text="انصراف";
			this.ImportExitButton.UseVisualStyleBackColor=false;
			//
			//SelectButton
			//
			this.SelectButton.Image=global::Metro_Operation.Properties.Resources.docs_24;
			this.SelectButton.BackgroundImageLayout=ImageLayout.Stretch;
			this.SelectButton.Location=new System.Drawing.Point(813, 16);
			this.SelectButton.Name="SelectButton";
			this.SelectButton.Size=new System.Drawing.Size(25, 25);
			this.SelectButton.TabIndex=139;
			this.SelectButton.UseVisualStyleBackColor=true;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(985, 21);
			this.Label8.Margin=new Padding(4, 0, 4, 0);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(55, 16);
			this.Label8.TabIndex=136;
			this.Label8.Text="نام فایل:";
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Control;
			this.NameBox.Location=new System.Drawing.Point(838, 17);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(147, 23);
			this.NameBox.TabIndex=134;
			this.NameBox.TabStop=false;
			this.NameBox.TextAlign=HorizontalAlignment.Right;
			//
			//NormalPanel
			//
			this.NormalPanel.BorderStyle=BorderStyle.FixedSingle;
			this.NormalPanel.Controls.Add(this.NormalTableNameBox);
			this.NormalPanel.Controls.Add(this.Label9);
			this.NormalPanel.Controls.Add(this.NormalRegButton);
			this.NormalPanel.Controls.Add(this.NormalKindCombo);
			this.NormalPanel.Controls.Add(this.Label10);
			this.NormalPanel.Controls.Add(this.NormalExitButton);
			this.NormalPanel.Location=new System.Drawing.Point(6, 586);
			this.NormalPanel.Name="NormalPanel";
			this.NormalPanel.Size=new System.Drawing.Size(1047, 58);
			this.NormalPanel.TabIndex=151;
			//
			//NormalTableNameBox
			//
			this.NormalTableNameBox.Location=new System.Drawing.Point(485, 17);
			this.NormalTableNameBox.Name="NormalTableNameBox";
			this.NormalTableNameBox.Size=new System.Drawing.Size(166, 23);
			this.NormalTableNameBox.TabIndex=142;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.ForeColor=System.Drawing.Color.Black;
			this.Label9.Location=new System.Drawing.Point(652, 21);
			this.Label9.Margin=new Padding(3);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(104, 16);
			this.Label9.TabIndex=144;
			this.Label9.Text="نام جدول حرکتی:";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//NormalRegButton
			//
			this.NormalRegButton.BackColor=System.Drawing.Color.Yellow;
			this.NormalRegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.NormalRegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.NormalRegButton.Cursor=Cursors.Hand;
			this.NormalRegButton.DialogResult=DialogResult.None;
			this.NormalRegButton.ForeColor=System.Drawing.Color.Black;
			this.NormalRegButton.Location=new System.Drawing.Point(156, 11);
			this.NormalRegButton.Name="NormalRegButton";
			this.NormalRegButton.Size=new System.Drawing.Size(120, 34);
			this.NormalRegButton.TabIndex=143;
			this.NormalRegButton.Text="ذخیره";
			this.NormalRegButton.UseVisualStyleBackColor=false;
			//
			//NormalKindCombo
			//
			this.NormalKindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.NormalKindCombo.FormattingEnabled=true;
			this.NormalKindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.NormalKindCombo.Location=new System.Drawing.Point(788, 17);
			this.NormalKindCombo.Name="NormalKindCombo";
			this.NormalKindCombo.Size=new System.Drawing.Size(119, 24);
			this.NormalKindCombo.TabIndex=140;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.ForeColor=System.Drawing.Color.Black;
			this.Label10.Location=new System.Drawing.Point(907, 21);
			this.Label10.Margin=new Padding(3);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(106, 16);
			this.Label10.TabIndex=141;
			this.Label10.Text="نوع جدول حرکتی:";
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//NormalExitButton
			//
			this.NormalExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.NormalExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.NormalExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.NormalExitButton.Cursor=Cursors.Hand;
			this.NormalExitButton.DialogResult=DialogResult.None;
			this.NormalExitButton.Location=new System.Drawing.Point(12, 11);
			this.NormalExitButton.Margin=new Padding(4, 5, 4, 5);
			this.NormalExitButton.Name="NormalExitButton";
			this.NormalExitButton.Size=new System.Drawing.Size(120, 34);
			this.NormalExitButton.TabIndex=133;
			this.NormalExitButton.Text="انصراف";
			this.NormalExitButton.UseVisualStyleBackColor=false;
			//
			//TerminalTableRegForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.PowderBlue;
			this.ClientSize=new System.Drawing.Size(1059, 652);
			this.Controls.Add(this.NormalPanel);
			this.Controls.Add(this.Panel20);
			this.Controls.Add(this.Panel10);
			this.Controls.Add(this.ImportPanel);
			this.Controls.Add(this.PictureBox9);
			this.Controls.Add(this.PictureBox8);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalTableRegForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت جدول تریپ پایانه";
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			this.Panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.TehGridView).EndInit();
			this.Panel11.ResumeLayout(false);
			this.Panel11.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			this.Panel20.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.MehGridView).EndInit();
			this.Panel21.ResumeLayout(false);
			this.Panel21.PerformLayout();
			this.ImportPanel.ResumeLayout(false);
			this.ImportPanel.PerformLayout();
			this.NormalPanel.ResumeLayout(false);
			this.NormalPanel.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		private PictureBox PictureBox9;
		private Panel Panel10;
		private Panel Panel11;
		private MaskedTextBox Time1Box;
		private ComboBox Magh1Combo;
		private ComboBox Mabd1Combo;
		private Label Label39;
		private Label Label40;
		private Label Label41;
		private Button Add1Button;
		private Button Del1Button;
		private PictureBox PictureBox8;
		private DataGridView TehGridView;
		private Panel Panel20;
		private Panel Panel21;
		private MaskedTextBox Time2Box;
		private ComboBox Magh2Combo;
		private ComboBox Mabd2Combo;
		private Label Label1;
		private Label Label2;
		private Label Label3;
		private Button Del2Button;
		private Button Add2Button;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private ComboBox Kind1Combo;
		private Label Label4;
		private DataGridView MehGridView;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private ComboBox Kind2Combo;
		private Label Label5;
		private Panel ImportPanel;
		private TextBox ImportTableNameBox;
		private Label Label6;
		private Button ImportRegButton;
		private ComboBox ImportKindCombo;
		private Label Label7;
		private Button ImportExitButton;
		private Button SelectButton;
		private Label Label8;
		private TextBox NameBox;
		private Panel NormalPanel;
		private TextBox NormalTableNameBox;
		private Label Label9;
		private Button NormalRegButton;
		private ComboBox NormalKindCombo;
		private Label Label10;
		private Button NormalExitButton;
	}
	
}
