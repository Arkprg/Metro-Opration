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
	partial class KeshikReplaceForm : BaseForm
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components=new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7=new System.Windows.Forms.DataGridViewCellStyle();
            this.RegButton=new System.Windows.Forms.Button();
            this.Label12=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.ReplaseShiftCombo=new System.Windows.Forms.ComboBox();
            this.Label3=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.ReplaseLocalCombo=new System.Windows.Forms.ComboBox();
            this.ReplaseNameCombo=new System.Windows.Forms.ComboBox();
            this.Label8=new System.Windows.Forms.Label();
            this.ExitButton=new System.Windows.Forms.Button();
            this.ChangeRadio=new System.Windows.Forms.RadioButton();
            this.ReplaseRadio=new System.Windows.Forms.RadioButton();
            this.Label9=new System.Windows.Forms.Label();
            this.Label10=new System.Windows.Forms.Label();
            this.Timer1=new System.Windows.Forms.Timer(this.components);
            this.Panel2=new System.Windows.Forms.Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel3=new System.Windows.Forms.Panel();
            this.SobhGridView=new System.Windows.Forms.DataGridView();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label13=new System.Windows.Forms.Label();
            this.NameButton=new System.Windows.Forms.Button();
            this.NameBox=new System.Windows.Forms.TextBox();
            this.AsrGridView=new System.Windows.Forms.DataGridView();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowButton=new System.Windows.Forms.Button();
            this.Label11=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.ShiftLabel=new System.Windows.Forms.Label();
            this.LocalLabel=new System.Windows.Forms.Label();
            this.DateLabel=new System.Windows.Forms.Label();
            this.Panel6=new System.Windows.Forms.Panel();
            this.MonthCombo=new System.Windows.Forms.ComboBox();
            this.Label1=new System.Windows.Forms.Label();
            this.ReqAcsButton=new System.Windows.Forms.Button();
            this.ReqRejButton=new System.Windows.Forms.Button();
            this.KeshLabel1=new System.Windows.Forms.Label();
            this.RepPanel=new System.Windows.Forms.Panel();
            this.DataGridView1=new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label14=new System.Windows.Forms.Label();
            this.PictureBox1=new System.Windows.Forms.PictureBox();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SobhGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsrGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.RepPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(357, 5);
            this.RegButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(189, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ثبت";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Label12
            // 
            this.Label12.BackColor=System.Drawing.Color.Gray;
            this.Label12.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label12.ForeColor=System.Drawing.Color.White;
            this.Label12.Location=new System.Drawing.Point(128, 366);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(81, 22);
            this.Label12.TabIndex=10;
            this.Label12.Text="تاریخ جدید ";
            this.Label12.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(145, 82);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(50, 16);
            this.Label2.TabIndex=81;
            this.Label2.Text="شیفت:";
            // 
            // ReplaseShiftCombo
            // 
            this.ReplaseShiftCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReplaseShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReplaseShiftCombo.FormattingEnabled=true;
            this.ReplaseShiftCombo.Location=new System.Drawing.Point(20, 78);
            this.ReplaseShiftCombo.Name="ReplaseShiftCombo";
            this.ReplaseShiftCombo.Size=new System.Drawing.Size(125, 24);
            this.ReplaseShiftCombo.TabIndex=3;
            this.ReplaseShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ReplaseShiftCombo_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(145, 50);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(35, 16);
            this.Label3.TabIndex=79;
            this.Label3.Text="مبدا:";
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(145, 18);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(39, 16);
            this.Label4.TabIndex=78;
            this.Label4.Text="تاریخ:";
            // 
            // ReplaseLocalCombo
            // 
            this.ReplaseLocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReplaseLocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReplaseLocalCombo.FormattingEnabled=true;
            this.ReplaseLocalCombo.Location=new System.Drawing.Point(20, 46);
            this.ReplaseLocalCombo.Name="ReplaseLocalCombo";
            this.ReplaseLocalCombo.Size=new System.Drawing.Size(125, 24);
            this.ReplaseLocalCombo.TabIndex=2;
            this.ReplaseLocalCombo.SelectedIndexChanged += new System.EventHandler(this.ReplaseLocalCombo_SelectedIndexChanged);
            // 
            // ReplaseNameCombo
            // 
            this.ReplaseNameCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReplaseNameCombo.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaseNameCombo.FormattingEnabled=true;
            this.ReplaseNameCombo.Location=new System.Drawing.Point(20, 110);
            this.ReplaseNameCombo.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReplaseNameCombo.Name="ReplaseNameCombo";
            this.ReplaseNameCombo.Size=new System.Drawing.Size(125, 22);
            this.ReplaseNameCombo.TabIndex=4;
            this.ReplaseNameCombo.SelectedIndexChanged += new System.EventHandler(this.ReplaseNameCombo_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.BackColor=System.Drawing.Color.Transparent;
            this.Label8.Location=new System.Drawing.Point(145, 113);
            this.Label8.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(29, 16);
            this.Label8.TabIndex=74;
            this.Label8.Text="نام:";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(20, 5);
            this.ExitButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(107, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeRadio
            // 
            this.ChangeRadio.BackColor=System.Drawing.Color.MediumSeaGreen;
            this.ChangeRadio.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeRadio.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChangeRadio.ForeColor=System.Drawing.Color.Black;
            this.ChangeRadio.Location=new System.Drawing.Point(238, 411);
            this.ChangeRadio.Name="ChangeRadio";
            this.ChangeRadio.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ChangeRadio.Size=new System.Drawing.Size(112, 29);
            this.ChangeRadio.TabIndex=1;
            this.ChangeRadio.Text="تعویض کشیک";
            this.ChangeRadio.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeRadio.UseVisualStyleBackColor=false;
            this.ChangeRadio.CheckedChanged += new System.EventHandler(this.ChangeRadio_CheckedChanged);
            // 
            // ReplaseRadio
            // 
            this.ReplaseRadio.BackColor=System.Drawing.Color.Tomato;
            this.ReplaseRadio.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ReplaseRadio.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReplaseRadio.ForeColor=System.Drawing.Color.Black;
            this.ReplaseRadio.Location=new System.Drawing.Point(238, 446);
            this.ReplaseRadio.Name="ReplaseRadio";
            this.ReplaseRadio.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ReplaseRadio.Size=new System.Drawing.Size(112, 29);
            this.ReplaseRadio.TabIndex=2;
            this.ReplaseRadio.Text="جایگزین کشیک";
            this.ReplaseRadio.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ReplaseRadio.UseVisualStyleBackColor=false;
            this.ReplaseRadio.CheckedChanged += new System.EventHandler(this.ReplaseRadio_CheckedChanged);
            // 
            // Label9
            // 
            this.Label9.ForeColor=System.Drawing.Color.Black;
            this.Label9.Location=new System.Drawing.Point(246, 459);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(98, 16);
            this.Label9.TabIndex=7;
            this.Label9.Text=">>>>>>>>>>>>>>>";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.ForeColor=System.Drawing.Color.Black;
            this.Label10.Location=new System.Drawing.Point(245, 486);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(100, 16);
            this.Label10.TabIndex=8;
            this.Label10.Text=">>>>>>>>>>>>>>>";
            this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer1
            // 
            this.Timer1.Enabled=true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.PersianCalendar);
            this.Panel2.Controls.Add(this.ReplaseShiftCombo);
            this.Panel2.Controls.Add(this.ReplaseNameCombo);
            this.Panel2.Controls.Add(this.ReplaseLocalCombo);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Location=new System.Drawing.Point(13, 380);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(206, 145);
            this.Panel2.TabIndex=1;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(20, 15);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=99;
            this.PersianCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Location=new System.Drawing.Point(13, 536);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(560, 48);
            this.Panel3.TabIndex=2;
            // 
            // SobhGridView
            // 
            this.SobhGridView.AllowUserToAddRows=false;
            this.SobhGridView.AllowUserToDeleteRows=false;
            this.SobhGridView.AllowUserToResizeColumns=false;
            this.SobhGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.Yellow;
            this.SobhGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.SobhGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.SobhGridView.ColumnHeadersHeight=35;
            this.SobhGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SobhGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DataGridViewTextBoxColumn3});
            this.SobhGridView.Cursor=System.Windows.Forms.Cursors.Hand;
            this.SobhGridView.EnableHeadersVisualStyles=false;
            this.SobhGridView.Location=new System.Drawing.Point(320, 77);
            this.SobhGridView.MultiSelect=false;
            this.SobhGridView.Name="SobhGridView";
            this.SobhGridView.ReadOnly=true;
            this.SobhGridView.RowHeadersVisible=false;
            this.SobhGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SobhGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SobhGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SobhGridView.RowTemplate.ReadOnly=true;
            this.SobhGridView.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.SobhGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SobhGridView.Size=new System.Drawing.Size(220, 140);
            this.SobhGridView.TabIndex=38;
            this.SobhGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SobhGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText="ID";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Visible=false;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn3.HeaderText="صبح";
            this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly=true;
            // 
            // Label13
            // 
            this.Label13.AutoSize=true;
            this.Label13.BackColor=System.Drawing.Color.Transparent;
            this.Label13.Location=new System.Drawing.Point(481, 18);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(69, 16);
            this.Label13.TabIndex=35;
            this.Label13.Text="نام پرسنل:";
            // 
            // NameButton
            // 
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(312, 14);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=36;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location=new System.Drawing.Point(342, 15);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(140, 23);
            this.NameBox.TabIndex=37;
            // 
            // AsrGridView
            // 
            this.AsrGridView.AllowUserToAddRows=false;
            this.AsrGridView.AllowUserToDeleteRows=false;
            this.AsrGridView.AllowUserToResizeColumns=false;
            this.AsrGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle3.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor=System.Drawing.Color.Yellow;
            this.AsrGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.AsrGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle4;
            this.AsrGridView.ColumnHeadersHeight=35;
            this.AsrGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AsrGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.DataGridViewTextBoxColumn2});
            this.AsrGridView.Cursor=System.Windows.Forms.Cursors.Hand;
            this.AsrGridView.EnableHeadersVisualStyles=false;
            this.AsrGridView.Location=new System.Drawing.Point(46, 77);
            this.AsrGridView.MultiSelect=false;
            this.AsrGridView.Name="AsrGridView";
            this.AsrGridView.ReadOnly=true;
            this.AsrGridView.RowHeadersVisible=false;
            this.AsrGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AsrGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AsrGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AsrGridView.RowTemplate.ReadOnly=true;
            this.AsrGridView.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.AsrGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AsrGridView.Size=new System.Drawing.Size(220, 140);
            this.AsrGridView.TabIndex=34;
            this.AsrGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsrGridView_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText="ID";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Visible=false;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn2.HeaderText="عصر";
            this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly=true;
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location=new System.Drawing.Point(8, 9);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(119, 34);
            this.ShowButton.TabIndex=73;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Label11
            // 
            this.Label11.BackColor=System.Drawing.Color.Gray;
            this.Label11.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label11.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label11.ForeColor=System.Drawing.Color.White;
            this.Label11.Location=new System.Drawing.Point(482, 366);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(81, 22);
            this.Label11.TabIndex=9;
            this.Label11.Text="تاریخ فعلی ";
            this.Label11.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(140, 33);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(39, 16);
            this.Label5.TabIndex=69;
            this.Label5.Text="تاریخ:";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(141, 67);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(35, 16);
            this.Label7.TabIndex=71;
            this.Label7.Text="مبدا:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(141, 99);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(50, 16);
            this.Label6.TabIndex=73;
            this.Label6.Text="شیفت:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.ShiftLabel);
            this.Panel1.Controls.Add(this.LocalLabel);
            this.Panel1.Controls.Add(this.DateLabel);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Location=new System.Drawing.Point(371, 380);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(202, 145);
            this.Panel1.TabIndex=0;
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShiftLabel.ForeColor=System.Drawing.Color.Maroon;
            this.ShiftLabel.Location=new System.Drawing.Point(11, 98);
            this.ShiftLabel.Name="ShiftLabel";
            this.ShiftLabel.Size=new System.Drawing.Size(129, 20);
            this.ShiftLabel.TabIndex=76;
            this.ShiftLabel.Text="_";
            // 
            // LocalLabel
            // 
            this.LocalLabel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalLabel.ForeColor=System.Drawing.Color.Maroon;
            this.LocalLabel.Location=new System.Drawing.Point(11, 66);
            this.LocalLabel.Name="LocalLabel";
            this.LocalLabel.Size=new System.Drawing.Size(129, 20);
            this.LocalLabel.TabIndex=75;
            this.LocalLabel.Text="_";
            // 
            // DateLabel
            // 
            this.DateLabel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.ForeColor=System.Drawing.Color.Maroon;
            this.DateLabel.Location=new System.Drawing.Point(11, 32);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(129, 20);
            this.DateLabel.TabIndex=74;
            this.DateLabel.Text="_";
            // 
            // Panel6
            // 
            this.Panel6.BackColor=System.Drawing.Color.LightBlue;
            this.Panel6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.NameBox);
            this.Panel6.Controls.Add(this.MonthCombo);
            this.Panel6.Controls.Add(this.Label1);
            this.Panel6.Controls.Add(this.ShowButton);
            this.Panel6.Controls.Add(this.Label13);
            this.Panel6.Controls.Add(this.NameButton);
            this.Panel6.Location=new System.Drawing.Point(13, 11);
            this.Panel6.Name="Panel6";
            this.Panel6.Size=new System.Drawing.Size(560, 55);
            this.Panel6.TabIndex=75;
            // 
            // MonthCombo
            // 
            this.MonthCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthCombo.FormattingEnabled=true;
            this.MonthCombo.Location=new System.Drawing.Point(162, 14);
            this.MonthCombo.Name="MonthCombo";
            this.MonthCombo.Size=new System.Drawing.Size(101, 24);
            this.MonthCombo.TabIndex=74;
            this.MonthCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.Transparent;
            this.Label1.Location=new System.Drawing.Point(262, 18);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(30, 16);
            this.Label1.TabIndex=75;
            this.Label1.Text="ماه:";
            // 
            // ReqAcsButton
            // 
            this.ReqAcsButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ReqAcsButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReqAcsButton.Image=global::Metro_Operation.Properties.Resources.tick_main;
            this.ReqAcsButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ReqAcsButton.Location=new System.Drawing.Point(71, 2);
            this.ReqAcsButton.Name="ReqAcsButton";
            this.ReqAcsButton.Size=new System.Drawing.Size(65, 28);
            this.ReqAcsButton.TabIndex=77;
            this.ReqAcsButton.Text="بلی";
            this.ReqAcsButton.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ReqAcsButton.UseVisualStyleBackColor=true;
            this.ReqAcsButton.Click += new System.EventHandler(this.ReqAcsButton_Click);
            // 
            // ReqRejButton
            // 
            this.ReqRejButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ReqRejButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReqRejButton.Image=global::Metro_Operation.Properties.Resources.cancel1;
            this.ReqRejButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ReqRejButton.Location=new System.Drawing.Point(3, 2);
            this.ReqRejButton.Name="ReqRejButton";
            this.ReqRejButton.Size=new System.Drawing.Size(65, 28);
            this.ReqRejButton.TabIndex=78;
            this.ReqRejButton.Text="خیر";
            this.ReqRejButton.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ReqRejButton.UseVisualStyleBackColor=true;
            this.ReqRejButton.Click += new System.EventHandler(this.ReqRejButton_Click);
            // 
            // KeshLabel1
            // 
            this.KeshLabel1.BackColor=System.Drawing.Color.Transparent;
            this.KeshLabel1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeshLabel1.ForeColor=System.Drawing.Color.Black;
            this.KeshLabel1.Location=new System.Drawing.Point(119, 2);
            this.KeshLabel1.Name="KeshLabel1";
            this.KeshLabel1.Size=new System.Drawing.Size(440, 28);
            this.KeshLabel1.TabIndex=76;
            this.KeshLabel1.Text="آیا درخواست فوق را تایید می نمایید؟";
            this.KeshLabel1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepPanel
            // 
            this.RepPanel.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RepPanel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepPanel.Controls.Add(this.ReqAcsButton);
            this.RepPanel.Controls.Add(this.KeshLabel1);
            this.RepPanel.Controls.Add(this.ReqRejButton);
            this.RepPanel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RepPanel.Location=new System.Drawing.Point(13, 327);
            this.RepPanel.Name="RepPanel";
            this.RepPanel.Size=new System.Drawing.Size(560, 32);
            this.RepPanel.TabIndex=77;
            this.RepPanel.Visible=false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor=System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.ForeColor=System.Drawing.Color.Black;
            this.DataGridView1.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle5;
            this.DataGridView1.CellBorderStyle=System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle6;
            this.DataGridView1.ColumnHeadersHeight=30;
            this.DataGridView1.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ColumnHeadersVisible=false;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.Column8,
            this.DataGridViewTextBoxColumn4,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.DataGridView1.Cursor=System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor=System.Drawing.Color.White;
            dataGridViewCellStyle7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor=System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle=dataGridViewCellStyle7;
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(13, 249);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.RowTemplate.ReadOnly=true;
            this.DataGridView1.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(560, 80);
            this.DataGridView1.TabIndex=78;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText="ID";
            this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly=true;
            this.DataGridViewTextBoxColumn1.Visible=false;
            this.DataGridViewTextBoxColumn1.Width=50;
            // 
            // Column8
            // 
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=40;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText="نام";
            this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly=true;
            this.DataGridViewTextBoxColumn4.Width=120;
            // 
            // Column3
            // 
            this.Column3.HeaderText="شماره پرسنلی";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Visible=false;
            // 
            // Column4
            // 
            this.Column4.HeaderText="مبدا";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=160;
            // 
            // Column6
            // 
            this.Column6.HeaderText="به";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=60;
            // 
            // Column5
            // 
            this.Column5.HeaderText="مقصد";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=160;
            // 
            // Column7
            // 
            this.Column7.HeaderText="Fad";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Visible=false;
            this.Column7.Width=50;
            // 
            // Label14
            // 
            this.Label14.BackColor=System.Drawing.Color.Gray;
            this.Label14.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label14.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label14.ForeColor=System.Drawing.Color.White;
            this.Label14.Location=new System.Drawing.Point(429, 227);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(139, 22);
            this.Label14.TabIndex=79;
            this.Label14.Text="درخواستهای جابجایی";
            this.Label14.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor=System.Drawing.Color.Transparent;
            this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.new1;
            this.PictureBox1.Location=new System.Drawing.Point(394, 232);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(28, 11);
            this.PictureBox1.SizeMode=System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex=80;
            this.PictureBox1.TabStop=false;
            // 
            // KeshikReplaceForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(587, 591);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.RepPanel);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.SobhGridView);
            this.Controls.Add(this.AsrGridView);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ReplaseRadio);
            this.Controls.Add(this.ChangeRadio);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="KeshikReplaceForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="ویرایش کشیک ماهانه";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.KeshikReplaceForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.KeshikEditForm_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SobhGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsrGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.RepPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private Button RegButton;
		private Button ExitButton;
		private RadioButton ChangeRadio;
		private RadioButton ReplaseRadio;
		private Label Label2;
		private ComboBox ReplaseShiftCombo;
		private Label Label3;
		private Label Label4;
		private ComboBox ReplaseLocalCombo;
		private ComboBox ReplaseNameCombo;
		private Label Label8;
		private Label Label12;
		private Label Label9;
		private Label Label10;
		private Timer Timer1;
		private Panel Panel2;
		private Panel Panel3;
		private DataGridView SobhGridView;
		private Label Label13;
		private Button NameButton;
		private TextBox NameBox;
		private DataGridView AsrGridView;
		private Button ShowButton;
		private Label Label11;
		private Label Label5;
		private Label Label7;
		private Label Label6;
		private Panel Panel1;
		private Panel Panel6;
		private ComboBox MonthCombo;
		private Label Label1;
		private Label ShiftLabel;
		private Label LocalLabel;
		private Label DateLabel;
		private Label KeshLabel1;
		private Panel RepPanel;
		private Button ReqRejButton;
		private Button ReqAcsButton;
		private DataGridView DataGridView1;
		private Label Label14;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column7;
		private PictureBox PictureBox1;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.ComponentModel.IContainer components;
    }
}
