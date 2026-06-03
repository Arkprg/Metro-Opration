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
	partial class OvertimeRequestRegForm : BaseForm
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
            this.components = new System.ComponentModel.Container();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PersianCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.ListLabel = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.TitrLabel1 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Mor12Asr = new System.Windows.Forms.Label();
            this.Mor12Sobh = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Mor9Sobh = new System.Windows.Forms.Label();
            this.Mor9Asr = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitrLabel2 = new System.Windows.Forms.Label();
            this.Req9Sobh = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Req12Asr = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Req12Sobh = new System.Windows.Forms.Label();
            this.Req9Asr = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.TitrLabel3 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.HashtCheck = new System.Windows.Forms.CheckBox();
            this.AllCheck = new System.Windows.Forms.CheckBox();
            this.A9Check = new System.Windows.Forms.CheckBox();
            this.S9Check = new System.Windows.Forms.CheckBox();
            this.S12Check = new System.Windows.Forms.CheckBox();
            this.R12Check = new System.Windows.Forms.CheckBox();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Location = new System.Drawing.Point(405, 10);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(133, 23);
            this.NameBox.TabIndex = 25;
            this.NameBox.TabStop = false;
            // 
            // NameButton
            // 
            this.NameButton.Image = global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location = new System.Drawing.Point(375, 9);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex = 1;
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // Label3
            // 
            this.Label3.AccessibleDescription = "66666666";
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(322, 13);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 16);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "تاریخ:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(538, 13);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 16);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "نام:";
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(332, 8);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(194, 34);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Image = global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(52, 8);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "انصراف";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(139, 13);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 16);
            this.Label7.TabIndex = 39;
            this.Label7.Text = "مبدا:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(14, 9);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(124, 24);
            this.LocalCombo.TabIndex = 3;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocaBox_SelectedIndexChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(10, 10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(585, 44);
            this.Panel1.TabIndex = 0;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location = new System.Drawing.Point(196, 10);
            this.PersianCalendar.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalendar.Name = "PersianCalendar";
            this.PersianCalendar.NowDateSelected = true;
            this.PersianCalendar.ReadOnly = true;
            this.PersianCalendar.SelectedDate = null;
            this.PersianCalendar.Shamsi = null;
            this.PersianCalendar.Size = new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex = 98;
            this.PersianCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Location = new System.Drawing.Point(10, 401);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(585, 52);
            this.Panel3.TabIndex = 2;
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Black;
            this.Panel7.Controls.Add(this.ListLabel);
            this.Panel7.Location = new System.Drawing.Point(25, 63);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(555, 40);
            this.Panel7.TabIndex = 26;
            // 
            // ListLabel
            // 
            this.ListLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListLabel.Font = new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListLabel.ForeColor = System.Drawing.Color.White;
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(555, 40);
            this.ListLabel.TabIndex = 20;
            this.ListLabel.Text = "مجموع اضافه کار";
            this.ListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.TitrLabel1);
            this.Panel5.Controls.Add(this.Label9);
            this.Panel5.Controls.Add(this.Label11);
            this.Panel5.Controls.Add(this.Label10);
            this.Panel5.Controls.Add(this.Mor12Asr);
            this.Panel5.Controls.Add(this.Mor12Sobh);
            this.Panel5.Controls.Add(this.Label8);
            this.Panel5.Controls.Add(this.Mor9Sobh);
            this.Panel5.Controls.Add(this.Mor9Asr);
            this.Panel5.Controls.Add(this.Label17);
            this.Panel5.Location = new System.Drawing.Point(305, 112);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(290, 137);
            this.Panel5.TabIndex = 24;
            // 
            // TitrLabel1
            // 
            this.TitrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.TitrLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitrLabel1.ForeColor = System.Drawing.Color.White;
            this.TitrLabel1.Location = new System.Drawing.Point(0, 0);
            this.TitrLabel1.Name = "TitrLabel1";
            this.TitrLabel1.Size = new System.Drawing.Size(288, 30);
            this.TitrLabel1.TabIndex = 27;
            this.TitrLabel1.Text = "مرخصی";
            this.TitrLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(41, 51);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(95, 22);
            this.Label9.TabIndex = 1;
            this.Label9.Text = "9 ساعته عصر:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(197, 101);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(95, 22);
            this.Label11.TabIndex = 2;
            this.Label11.Text = "12 ساعته روز:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(41, 101);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(97, 22);
            this.Label10.TabIndex = 3;
            this.Label10.Text = "12 ساعته شب:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mor12Asr
            // 
            this.Mor12Asr.BackColor = System.Drawing.Color.Transparent;
            this.Mor12Asr.ForeColor = System.Drawing.Color.Yellow;
            this.Mor12Asr.Location = new System.Drawing.Point(1, 101);
            this.Mor12Asr.Name = "Mor12Asr";
            this.Mor12Asr.Size = new System.Drawing.Size(42, 22);
            this.Mor12Asr.TabIndex = 12;
            this.Mor12Asr.Text = "نفر";
            this.Mor12Asr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mor12Sobh
            // 
            this.Mor12Sobh.BackColor = System.Drawing.Color.Transparent;
            this.Mor12Sobh.ForeColor = System.Drawing.Color.Yellow;
            this.Mor12Sobh.Location = new System.Drawing.Point(156, 101);
            this.Mor12Sobh.Name = "Mor12Sobh";
            this.Mor12Sobh.Size = new System.Drawing.Size(42, 22);
            this.Mor12Sobh.TabIndex = 11;
            this.Mor12Sobh.Text = "نفر";
            this.Mor12Sobh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(195, 51);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(95, 22);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "9 ساعته صبح:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mor9Sobh
            // 
            this.Mor9Sobh.BackColor = System.Drawing.Color.Transparent;
            this.Mor9Sobh.ForeColor = System.Drawing.Color.Yellow;
            this.Mor9Sobh.Location = new System.Drawing.Point(154, 51);
            this.Mor9Sobh.Name = "Mor9Sobh";
            this.Mor9Sobh.Size = new System.Drawing.Size(42, 22);
            this.Mor9Sobh.TabIndex = 9;
            this.Mor9Sobh.Text = "نفر";
            this.Mor9Sobh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mor9Asr
            // 
            this.Mor9Asr.BackColor = System.Drawing.Color.Transparent;
            this.Mor9Asr.ForeColor = System.Drawing.Color.Yellow;
            this.Mor9Asr.Location = new System.Drawing.Point(1, 51);
            this.Mor9Asr.Name = "Mor9Asr";
            this.Mor9Asr.Size = new System.Drawing.Size(42, 22);
            this.Mor9Asr.TabIndex = 10;
            this.Mor9Asr.Text = "نفر";
            this.Mor9Asr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            this.Label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.Yellow;
            this.Label17.Location = new System.Drawing.Point(1, 79);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(285, 16);
            this.Label17.TabIndex = 26;
            this.Label17.Text = "--------------------------------------------------------------------";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Black;
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.DetailGridView);
            this.Panel6.Controls.Add(this.TitrLabel2);
            this.Panel6.Controls.Add(this.Req9Sobh);
            this.Panel6.Controls.Add(this.Label16);
            this.Panel6.Controls.Add(this.Label15);
            this.Panel6.Controls.Add(this.Label14);
            this.Panel6.Controls.Add(this.Req12Asr);
            this.Panel6.Controls.Add(this.Label13);
            this.Panel6.Controls.Add(this.Req12Sobh);
            this.Panel6.Controls.Add(this.Req9Asr);
            this.Panel6.Controls.Add(this.Label18);
            this.Panel6.Location = new System.Drawing.Point(10, 112);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(290, 137);
            this.Panel6.TabIndex = 25;
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows = false;
            this.DetailGridView.AllowUserToDeleteRows = false;
            this.DetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DetailGridView.Location = new System.Drawing.Point(3, 19);
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.ReadOnly = true;
            this.DetailGridView.RowHeadersVisible = false;
            this.DetailGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailGridView.Size = new System.Drawing.Size(222, 187);
            this.DetailGridView.TabIndex = 40;
            this.DetailGridView.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "پرسنلی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "امتیاز";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "نام";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // TitrLabel2
            // 
            this.TitrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.TitrLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitrLabel2.ForeColor = System.Drawing.Color.White;
            this.TitrLabel2.Location = new System.Drawing.Point(0, 0);
            this.TitrLabel2.Name = "TitrLabel2";
            this.TitrLabel2.Size = new System.Drawing.Size(288, 30);
            this.TitrLabel2.TabIndex = 28;
            this.TitrLabel2.Text = "درخواست اضافه کار";
            this.TitrLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Req9Sobh
            // 
            this.Req9Sobh.BackColor = System.Drawing.Color.Transparent;
            this.Req9Sobh.ForeColor = System.Drawing.Color.Lime;
            this.Req9Sobh.Location = new System.Drawing.Point(153, 48);
            this.Req9Sobh.Name = "Req9Sobh";
            this.Req9Sobh.Size = new System.Drawing.Size(45, 22);
            this.Req9Sobh.TabIndex = 13;
            this.Req9Sobh.Text = "مورد";
            this.Req9Sobh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(196, 51);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(95, 22);
            this.Label16.TabIndex = 5;
            this.Label16.Text = "9 ساعته صبح:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(44, 51);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(95, 22);
            this.Label15.TabIndex = 6;
            this.Label15.Text = "9 ساعته عصر:";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(196, 101);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(95, 22);
            this.Label14.TabIndex = 7;
            this.Label14.Text = "12 ساعته روز:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Req12Asr
            // 
            this.Req12Asr.BackColor = System.Drawing.Color.Transparent;
            this.Req12Asr.ForeColor = System.Drawing.Color.Lime;
            this.Req12Asr.Location = new System.Drawing.Point(1, 98);
            this.Req12Asr.Name = "Req12Asr";
            this.Req12Asr.Size = new System.Drawing.Size(45, 22);
            this.Req12Asr.TabIndex = 16;
            this.Req12Asr.Text = "مورد";
            this.Req12Asr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(44, 101);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(97, 22);
            this.Label13.TabIndex = 8;
            this.Label13.Text = "12 ساعته شب:";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Req12Sobh
            // 
            this.Req12Sobh.BackColor = System.Drawing.Color.Transparent;
            this.Req12Sobh.ForeColor = System.Drawing.Color.Lime;
            this.Req12Sobh.Location = new System.Drawing.Point(153, 98);
            this.Req12Sobh.Name = "Req12Sobh";
            this.Req12Sobh.Size = new System.Drawing.Size(45, 22);
            this.Req12Sobh.TabIndex = 15;
            this.Req12Sobh.Text = "مورد";
            this.Req12Sobh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Req9Asr
            // 
            this.Req9Asr.BackColor = System.Drawing.Color.Transparent;
            this.Req9Asr.ForeColor = System.Drawing.Color.Lime;
            this.Req9Asr.Location = new System.Drawing.Point(1, 48);
            this.Req9Asr.Name = "Req9Asr";
            this.Req9Asr.Size = new System.Drawing.Size(45, 22);
            this.Req9Asr.TabIndex = 14;
            this.Req9Asr.Text = "مورد";
            this.Req9Asr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label18
            // 
            this.Label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.Lime;
            this.Label18.Location = new System.Drawing.Point(1, 79);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(285, 16);
            this.Label18.TabIndex = 27;
            this.Label18.Text = "--------------------------------------------------------------------";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitrLabel3
            // 
            this.TitrLabel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TitrLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitrLabel3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitrLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.TitrLabel3.Location = new System.Drawing.Point(0, 0);
            this.TitrLabel3.Name = "TitrLabel3";
            this.TitrLabel3.Size = new System.Drawing.Size(583, 30);
            this.TitrLabel3.TabIndex = 21;
            this.TitrLabel3.Text = "تذکر: تعیین جایگزین بر اساس نیاز شیفت بوده و ترتیب انتخاب ها ملاک نمی باشد";
            this.TitrLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.HashtCheck);
            this.Panel2.Controls.Add(this.AllCheck);
            this.Panel2.Controls.Add(this.A9Check);
            this.Panel2.Controls.Add(this.S9Check);
            this.Panel2.Controls.Add(this.S12Check);
            this.Panel2.Controls.Add(this.R12Check);
            this.Panel2.Controls.Add(this.TitrLabel3);
            this.Panel2.Location = new System.Drawing.Point(10, 258);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(585, 133);
            this.Panel2.TabIndex = 1;
            // 
            // HashtCheck
            // 
            this.HashtCheck.BackColor = System.Drawing.Color.Transparent;
            this.HashtCheck.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashtCheck.Location = new System.Drawing.Point(1, 99);
            this.HashtCheck.Name = "HashtCheck";
            this.HashtCheck.Padding = new System.Windows.Forms.Padding(0, 0, 203, 0);
            this.HashtCheck.Size = new System.Drawing.Size(581, 30);
            this.HashtCheck.TabIndex = 22;
            this.HashtCheck.Text = "هشتگرد";
            this.HashtCheck.UseVisualStyleBackColor = false;
            this.HashtCheck.Visible = false;
            this.HashtCheck.CheckedChanged += new System.EventHandler(this.R12Check_CheckedChanged);
            // 
            // AllCheck
            // 
            this.AllCheck.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCheck.Location = new System.Drawing.Point(399, 51);
            this.AllCheck.Name = "AllCheck";
            this.AllCheck.Size = new System.Drawing.Size(150, 30);
            this.AllCheck.TabIndex = 22;
            this.AllCheck.Text = "همه موارد";
            this.AllCheck.UseVisualStyleBackColor = true;
            this.AllCheck.CheckedChanged += new System.EventHandler(this.AllCheck_CheckedChanged);
            // 
            // A9Check
            // 
            this.A9Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9Check.Location = new System.Drawing.Point(229, 68);
            this.A9Check.Name = "A9Check";
            this.A9Check.Size = new System.Drawing.Size(150, 30);
            this.A9Check.TabIndex = 22;
            this.A9Check.Text = "9 ساعته عصر";
            this.A9Check.UseVisualStyleBackColor = true;
            this.A9Check.CheckedChanged += new System.EventHandler(this.R12Check_CheckedChanged);
            // 
            // S9Check
            // 
            this.S9Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S9Check.Location = new System.Drawing.Point(229, 37);
            this.S9Check.Name = "S9Check";
            this.S9Check.Size = new System.Drawing.Size(150, 30);
            this.S9Check.TabIndex = 22;
            this.S9Check.Text = "9 ساعته صبح";
            this.S9Check.UseVisualStyleBackColor = true;
            this.S9Check.CheckedChanged += new System.EventHandler(this.R12Check_CheckedChanged);
            // 
            // S12Check
            // 
            this.S12Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S12Check.Location = new System.Drawing.Point(47, 68);
            this.S12Check.Name = "S12Check";
            this.S12Check.Size = new System.Drawing.Size(150, 30);
            this.S12Check.TabIndex = 22;
            this.S12Check.Text = "12 ساعته شب";
            this.S12Check.UseVisualStyleBackColor = true;
            this.S12Check.CheckedChanged += new System.EventHandler(this.R12Check_CheckedChanged);
            // 
            // R12Check
            // 
            this.R12Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R12Check.Location = new System.Drawing.Point(47, 37);
            this.R12Check.Name = "R12Check";
            this.R12Check.Size = new System.Drawing.Size(150, 30);
            this.R12Check.TabIndex = 22;
            this.R12Check.Text = "12 ساعته روز";
            this.R12Check.UseVisualStyleBackColor = true;
            this.R12Check.CheckedChanged += new System.EventHandler(this.R12Check_CheckedChanged);
            // 
            // OvertimeRequestRegForm
            // 
            this.AcceptButton = this.RegButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(606, 461);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel7);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OvertimeRequestRegForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت درخواست اضافه کار";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OvertimeRequestRegisterForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form27_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private TextBox NameBox;
		private Button NameButton;
		private Label Label3;
		private Label Label1;
		private Button RegButton;
		private Button ExitButton;
		private Label Label7;
		private ComboBox LocalCombo;
		private Panel Panel1;
		private Panel Panel3;
		private Panel Panel7;
		private Panel Panel5;
		private Label Label9;
		private Label Label11;
		private Label Label10;
		private Label Mor12Asr;
		private Label Mor12Sobh;
		private Label Label8;
		private Label Mor9Sobh;
		private Label Mor9Asr;
		private Label Label17;
		private Panel Panel6;
		private Label Req9Sobh;
		private Label Label16;
		private Label Label15;
		private Label Label14;
		private Label Req12Asr;
		private Label Label13;
		private Label Req12Sobh;
		private Label Req9Asr;
		private Label Label18;
		private DataGridView DetailGridView;
		private Label TitrLabel3;
		private Panel Panel2;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private CheckBox AllCheck;
		private CheckBox A9Check;
		private CheckBox S9Check;
		private CheckBox S12Check;
		private CheckBox R12Check;
		private CheckBox HashtCheck;
        private System.ComponentModel.IContainer components;
        private Label ListLabel;
        private Label TitrLabel1;
        private Label TitrLabel2;
    }
	
}
