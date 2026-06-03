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
	public partial class TerminalTableEditForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle5=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle6=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle7=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle8=new DataGridViewCellStyle();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.DelButton=new Button();
			this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
			this.Panel2=new Panel();
			this.SearchKindCombo=new ComboBox();
			this.SearchKindCombo.SelectedIndexChanged += new System.EventHandler(this.SearchKindCombo_SelectedIndexChanged);
			this.SearchNameCombo=new ComboBox();
			this.SearchNameCombo.SelectedIndexChanged += new System.EventHandler(this.SearchNameCombo_SelectedIndexChanged);
			this.Label8=new Label();
			this.Label6=new Label();
			this.SearchButton=new Button();
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			this.Panel1=new Panel();
			this.NameBox=new TextBox();
			this.Label7=new Label();
			this.KindCombo=new ComboBox();
			this.Label9=new Label();
			this.Panel10=new Panel();
			this.DataGridView1=new DataGridView();
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
			this.Panel20=new Panel();
			this.DataGridView2=new DataGridView();
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
			this.PictureBox9=new PictureBox();
			this.PictureBox8=new PictureBox();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.Panel11.SuspendLayout();
			this.Panel20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			this.Panel21.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			this.SuspendLayout();
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.Yellow;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Enabled=false;
			this.RegButton.ForeColor=System.Drawing.Color.Black;
			this.RegButton.Location=new System.Drawing.Point(848, 661);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(200, 38);
			this.RegButton.TabIndex=85;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			
			this.ExitButton.ForeColor=System.Drawing.Color.Black;
			this.ExitButton.Location=new System.Drawing.Point(16, 661);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(200, 38);
			this.ExitButton.TabIndex=87;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
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
			this.DelButton.Location=new System.Drawing.Point(554, 661);
			this.DelButton.Name="DelButton";
			this.DelButton.Size=new System.Drawing.Size(200, 38);
			this.DelButton.TabIndex=86;
			this.DelButton.Text="حذف";
			this.DelButton.UseVisualStyleBackColor=false;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.SearchKindCombo);
			this.Panel2.Controls.Add(this.SearchNameCombo);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.SearchButton);
			this.Panel2.Location=new System.Drawing.Point(113, 10);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(850, 55);
			this.Panel2.TabIndex=88;
			//
			//SearchKindCombo
			//
			this.SearchKindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.SearchKindCombo.FormattingEnabled=true;
			this.SearchKindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.SearchKindCombo.Location=new System.Drawing.Point(596, 14);
			this.SearchKindCombo.Name="SearchKindCombo";
			this.SearchKindCombo.Size=new System.Drawing.Size(137, 24);
			this.SearchKindCombo.TabIndex=0;
			//
			//SearchNameCombo
			//
			this.SearchNameCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.SearchNameCombo.FormattingEnabled=true;
			this.SearchNameCombo.Location=new System.Drawing.Point(216, 14);
			this.SearchNameCombo.Name="SearchNameCombo";
			this.SearchNameCombo.Size=new System.Drawing.Size(243, 24);
			this.SearchNameCombo.TabIndex=1;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.BackColor=System.Drawing.Color.Transparent;
			this.Label8.ForeColor=System.Drawing.Color.Black;
			this.Label8.Location=new System.Drawing.Point(458, 18);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(104, 16);
			this.Label8.TabIndex=80;
			this.Label8.Text="نام جدول حرکتی:";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.BackColor=System.Drawing.Color.Transparent;
			this.Label6.ForeColor=System.Drawing.Color.Black;
			this.Label6.Location=new System.Drawing.Point(732, 18);
			this.Label6.Margin=new Padding(3);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(106, 16);
			this.Label6.TabIndex=79;
			this.Label6.Text="نوع جدول حرکتی:";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//SearchButton
			//
			this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search1;
			this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.SearchButton.Cursor=Cursors.Hand;
			
			this.SearchButton.ForeColor=System.Drawing.Color.Black;
			this.SearchButton.Location=new System.Drawing.Point(13, 9);
			this.SearchButton.Name="SearchButton";
			this.SearchButton.Size=new System.Drawing.Size(144, 35);
			this.SearchButton.TabIndex=2;
			this.SearchButton.Text="جستجو";
			this.SearchButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Panel10);
			this.Panel1.Controls.Add(this.Panel20);
			this.Panel1.Controls.Add(this.PictureBox9);
			this.Panel1.Controls.Add(this.PictureBox8);
			this.Panel1.Enabled=false;
			this.Panel1.Location=new System.Drawing.Point(8, 73);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(1060, 580);
			this.Panel1.TabIndex=89;
			//
			//NameBox
			//
			this.NameBox.Location=new System.Drawing.Point(245, 7);
			this.NameBox.Name="NameBox";
			this.NameBox.Size=new System.Drawing.Size(233, 23);
			this.NameBox.TabIndex=88;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.BackColor=System.Drawing.Color.Transparent;
			this.Label7.ForeColor=System.Drawing.Color.Black;
			this.Label7.Location=new System.Drawing.Point(479, 10);
			this.Label7.Margin=new Padding(3);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(104, 16);
			this.Label7.TabIndex=90;
			this.Label7.Text="نام جدول حرکتی:";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.KindCombo.Location=new System.Drawing.Point(606, 6);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(137, 24);
			this.KindCombo.TabIndex=87;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.ForeColor=System.Drawing.Color.Black;
			this.Label9.Location=new System.Drawing.Point(745, 10);
			this.Label9.Margin=new Padding(3);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(106, 16);
			this.Label9.TabIndex=89;
			this.Label9.Text="نوع جدول حرکتی:";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel10
			//
			this.Panel10.AutoScroll=true;
			this.Panel10.BackColor=System.Drawing.Color.Transparent;
			this.Panel10.BorderStyle=BorderStyle.FixedSingle;
			this.Panel10.Controls.Add(this.DataGridView1);
			this.Panel10.Controls.Add(this.Panel11);
			this.Panel10.Controls.Add(this.Del1Button);
			this.Panel10.Controls.Add(this.Add1Button);
			this.Panel10.Location=new System.Drawing.Point(533, 101);
			this.Panel10.Name="Panel10";
			this.Panel10.Size=new System.Drawing.Size(520, 469);
			this.Panel10.TabIndex=83;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			DataGridViewCellStyle5.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle5.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle5;
			this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle6.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle6.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle6.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle6.WrapMode=DataGridViewTriState.False;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle6;
			this.DataGridView1.ColumnHeadersHeight=40;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column9, this.Column1, this.Column3, this.Column7, this.Column2});
			this.DataGridView1.EnableHeadersVisualStyles=false;
			this.DataGridView1.Location=new System.Drawing.Point(6, 86);
			this.DataGridView1.MultiSelect=false;
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.RowTemplate.ReadOnly=true;
			this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size=new System.Drawing.Size(506, 372);
			this.DataGridView1.TabIndex=49;
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
			this.Del1Button.Location=new System.Drawing.Point(7, 49);
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
			this.Add1Button.Location=new System.Drawing.Point(412, 49);
			this.Add1Button.Name="Add1Button";
			this.Add1Button.Padding=new Padding(5, 0, 5, 0);
			this.Add1Button.Size=new System.Drawing.Size(100, 32);
			this.Add1Button.TabIndex=1;
			this.Add1Button.Text="اضافه";
			this.Add1Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add1Button.UseVisualStyleBackColor=false;
			//
			//Panel20
			//
			this.Panel20.AutoScroll=true;
			this.Panel20.BackColor=System.Drawing.Color.Transparent;
			this.Panel20.BorderStyle=BorderStyle.FixedSingle;
			this.Panel20.Controls.Add(this.DataGridView2);
			this.Panel20.Controls.Add(this.Panel21);
			this.Panel20.Controls.Add(this.Del2Button);
			this.Panel20.Controls.Add(this.Add2Button);
			this.Panel20.Location=new System.Drawing.Point(6, 101);
			this.Panel20.Name="Panel20";
			this.Panel20.Size=new System.Drawing.Size(520, 469);
			this.Panel20.TabIndex=84;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows=false;
			this.DataGridView2.AllowUserToDeleteRows=false;
			this.DataGridView2.AllowUserToResizeColumns=false;
			this.DataGridView2.AllowUserToResizeRows=false;
			DataGridViewCellStyle7.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle7.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle7.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle7;
			this.DataGridView2.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle8.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle8.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle8.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle8.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle8.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle8.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle8.WrapMode=DataGridViewTriState.False;
			this.DataGridView2.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle8;
			this.DataGridView2.ColumnHeadersHeight=40;
			this.DataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView2.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn5});
			this.DataGridView2.EnableHeadersVisualStyles=false;
			this.DataGridView2.Location=new System.Drawing.Point(6, 86);
			this.DataGridView2.MultiSelect=false;
			this.DataGridView2.Name="DataGridView2";
			this.DataGridView2.ReadOnly=true;
			this.DataGridView2.RowHeadersVisible=false;
			this.DataGridView2.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.RowTemplate.ReadOnly=true;
			this.DataGridView2.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size=new System.Drawing.Size(506, 372);
			this.DataGridView2.TabIndex=50;
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
			this.Del2Button.Location=new System.Drawing.Point(7, 49);
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
			this.Add2Button.Location=new System.Drawing.Point(411, 49);
			this.Add2Button.Name="Add2Button";
			this.Add2Button.Padding=new Padding(5, 0, 5, 0);
			this.Add2Button.Size=new System.Drawing.Size(100, 32);
			this.Add2Button.TabIndex=1;
			this.Add2Button.Text="اضافه";
			this.Add2Button.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Add2Button.UseVisualStyleBackColor=false;
			//
			//PictureBox9
			//
			this.PictureBox9.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox9.Location=new System.Drawing.Point(680, 37);
			this.PictureBox9.Name="PictureBox9";
			this.PictureBox9.Size=new System.Drawing.Size(226, 65);
			this.PictureBox9.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox9.TabIndex=85;
			this.PictureBox9.TabStop=false;
			//
			//PictureBox8
			//
			this.PictureBox8.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox8.Location=new System.Drawing.Point(115, 37);
			this.PictureBox8.Name="PictureBox8";
			this.PictureBox8.Size=new System.Drawing.Size(303, 65);
			this.PictureBox8.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox8.TabIndex=86;
			this.PictureBox8.TabStop=false;
			//
			//TerminalTableEditForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(1074, 711);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.DelButton);
			this.Controls.Add(this.RegButton);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalTableEditForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ویرایش جدول تریپ پایانه";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.Panel11.ResumeLayout(false);
			this.Panel11.PerformLayout();
			this.Panel20.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			this.Panel21.ResumeLayout(false);
			this.Panel21.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			this.ResumeLayout(false);
			
		}
		private Button RegButton;
		private Button ExitButton;
		private Button DelButton;
		private Panel Panel2;
		private ComboBox SearchNameCombo;
		private ComboBox SearchKindCombo;
		private Button SearchButton;
		private Label Label8;
		private Label Label6;
		private Panel Panel1;
		private Panel Panel10;
		private DataGridView DataGridView1;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private Panel Panel11;
		private MaskedTextBox Time1Box;
		private ComboBox Magh1Combo;
		private ComboBox Kind1Combo;
		private ComboBox Mabd1Combo;
		private Label Label39;
		private Label Label4;
		private Label Label40;
		private Label Label41;
		private Button Del1Button;
		private Button Add1Button;
		private Panel Panel20;
		private DataGridView DataGridView2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private Panel Panel21;
		private ComboBox Kind2Combo;
		private Label Label5;
		private MaskedTextBox Time2Box;
		private ComboBox Magh2Combo;
		private ComboBox Mabd2Combo;
		private Label Label1;
		private Label Label2;
		private Label Label3;
		private Button Del2Button;
		private Button Add2Button;
		private PictureBox PictureBox9;
		private PictureBox PictureBox8;
		private TextBox NameBox;
		private Label Label7;
		private ComboBox KindCombo;
		private Label Label9;
	}
	
}
