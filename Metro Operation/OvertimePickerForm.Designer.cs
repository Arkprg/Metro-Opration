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
	partial class OvertimePickerForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OvertimePickerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.PersianCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.FullGridView = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PNumBox = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.KindCombo = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.ShiftCombo = new System.Windows.Forms.ComboBox();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LeaveCombo = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.DelRadioButton = new System.Windows.Forms.RadioButton();
            this.MemBox = new System.Windows.Forms.TextBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.Label17 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullGridView)).BeginInit();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows = false;
            this.DetailGridView.AllowUserToDeleteRows = false;
            this.DetailGridView.AllowUserToResizeColumns = false;
            this.DetailGridView.AllowUserToResizeRows = false;
            this.DetailGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column7});
            this.DetailGridView.Location = new System.Drawing.Point(21, 271);
            this.DetailGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.ReadOnly = true;
            this.DetailGridView.RowHeadersVisible = false;
            this.DetailGridView.Size = new System.Drawing.Size(476, 247);
            this.DetailGridView.TabIndex = 58;
            this.DetailGridView.Visible = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.LightBlue;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.PersianCalendar);
            this.Panel4.Controls.Add(this.ShowButton);
            this.Panel4.Controls.Add(this.Label14);
            this.Panel4.Location = new System.Drawing.Point(597, 13);
            this.Panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(256, 59);
            this.Panel4.TabIndex = 96;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location = new System.Drawing.Point(104, 17);
            this.PersianCalendar.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalendar.Name = "PersianCalendar";
            this.PersianCalendar.NowDateSelected = true;
            this.PersianCalendar.ReadOnly = true;
            this.PersianCalendar.SelectedDate = null;
            this.PersianCalendar.Shamsi = null;
            this.PersianCalendar.Size = new System.Drawing.Size(100, 23);
            this.PersianCalendar.TabIndex = 98;
            this.PersianCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowButton.Image")));
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(4, 11);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(89, 34);
            this.ShowButton.TabIndex = 21;
            this.ShowButton.Text = "    نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(204, 20);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(39, 16);
            this.Label14.TabIndex = 17;
            this.Label14.Text = "تاریخ:";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.ForeColor = System.Drawing.Color.Blue;
            this.Label10.Location = new System.Drawing.Point(9, 14);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(580, 24);
            this.Label10.TabIndex = 95;
            this.Label10.Text = "<<<<<<<     موارد ثبت شده بعد از پردازش لوحه       >>>>>>>";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FullGridView
            // 
            this.FullGridView.AllowUserToAddRows = false;
            this.FullGridView.AllowUserToDeleteRows = false;
            this.FullGridView.AllowUserToResizeColumns = false;
            this.FullGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FullGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FullGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.FullGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FullGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FullGridView.ColumnHeadersHeight = 29;
            this.FullGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FullGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.DataGridViewTextBoxColumn1,
            this.Column10,
            this.Column2,
            this.Column9,
            this.Column12,
            this.Column8});
            this.FullGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.FullGridView.EnableHeadersVisualStyles = false;
            this.FullGridView.Location = new System.Drawing.Point(9, 49);
            this.FullGridView.Name = "FullGridView";
            this.FullGridView.ReadOnly = true;
            this.FullGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FullGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FullGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FullGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FullGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FullGridView.Size = new System.Drawing.Size(580, 475);
            this.FullGridView.TabIndex = 94;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "ردیف";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 45;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "نام";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 70;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "نام خانوادگی";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "شیفت";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "مبدا";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "نوع";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.PhoneBox);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.NameBox);
            this.Panel3.Controls.Add(this.PNumBox);
            this.Panel3.Controls.Add(this.Label18);
            this.Panel3.Controls.Add(this.Label16);
            this.Panel3.Location = new System.Drawing.Point(595, 279);
            this.Panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(256, 112);
            this.Panel3.TabIndex = 55;
            // 
            // PhoneBox
            // 
            this.PhoneBox.BackColor = System.Drawing.Color.LightBlue;
            this.PhoneBox.Location = new System.Drawing.Point(17, 75);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.ReadOnly = true;
            this.PhoneBox.Size = new System.Drawing.Size(140, 23);
            this.PhoneBox.TabIndex = 14;
            this.PhoneBox.TabStop = false;
            this.PhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(159, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 16);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "شماره تماس:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.LightBlue;
            this.NameBox.Location = new System.Drawing.Point(17, 11);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(140, 23);
            this.NameBox.TabIndex = 1;
            this.NameBox.TabStop = false;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PNumBox
            // 
            this.PNumBox.BackColor = System.Drawing.Color.LightBlue;
            this.PNumBox.Location = new System.Drawing.Point(17, 43);
            this.PNumBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNumBox.Name = "PNumBox";
            this.PNumBox.ReadOnly = true;
            this.PNumBox.Size = new System.Drawing.Size(140, 23);
            this.PNumBox.TabIndex = 12;
            this.PNumBox.TabStop = false;
            this.PNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(159, 14);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(29, 16);
            this.Label18.TabIndex = 0;
            this.Label18.Text = "نام:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(159, 46);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(78, 16);
            this.Label16.TabIndex = 11;
            this.Label16.Text = "ش پرسنلی:";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.KindCombo);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.SearchButton);
            this.Panel2.Controls.Add(this.TimeBox);
            this.Panel2.Controls.Add(this.ShiftCombo);
            this.Panel2.Controls.Add(this.LocalCombo);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.LeaveCombo);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(597, 83);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(256, 186);
            this.Panel2.TabIndex = 54;
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled = true;
            this.KindCombo.Location = new System.Drawing.Point(17, 16);
            this.KindCombo.Name = "KindCombo";
            this.KindCombo.Size = new System.Drawing.Size(140, 24);
            this.KindCombo.TabIndex = 21;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(157, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 16);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "نوع اضافه کار:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(17, 143);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(220, 34);
            this.SearchButton.TabIndex = 34;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(107, 110);
            this.TimeBox.Mask = "00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(50, 23);
            this.TimeBox.TabIndex = 33;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.ValidatingType = typeof(System.DateTime);
            this.TimeBox.Visible = false;
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled = true;
            this.ShiftCombo.Location = new System.Drawing.Point(17, 78);
            this.ShiftCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShiftCombo.Name = "ShiftCombo";
            this.ShiftCombo.Size = new System.Drawing.Size(140, 24);
            this.ShiftCombo.TabIndex = 3;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(17, 47);
            this.LocalCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(140, 24);
            this.LocalCombo.TabIndex = 2;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.ForeColor = System.Drawing.Color.Black;
            this.Label13.Location = new System.Drawing.Point(157, 82);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(50, 16);
            this.Label13.TabIndex = 18;
            this.Label13.Text = "شیفت:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(157, 51);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(35, 16);
            this.Label15.TabIndex = 19;
            this.Label15.Text = "مبدا:";
            // 
            // LeaveCombo
            // 
            this.LeaveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeaveCombo.FormattingEnabled = true;
            this.LeaveCombo.Items.AddRange(new object[] {
            "جایگزین مرخصی ساعتی",
            "جایگزین مرخصی روزانه",
            "اضافه کار"});
            this.LeaveCombo.Location = new System.Drawing.Point(17, 109);
            this.LeaveCombo.Name = "LeaveCombo";
            this.LeaveCombo.Size = new System.Drawing.Size(140, 24);
            this.LeaveCombo.TabIndex = 23;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(157, 113);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 16);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "مرخصی:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.RegButton);
            this.Panel1.Controls.Add(this.DelRadioButton);
            this.Panel1.Controls.Add(this.MemBox);
            this.Panel1.Controls.Add(this.AddRadioButton);
            this.Panel1.Controls.Add(this.Label17);
            this.Panel1.Controls.Add(this.Panel5);
            this.Panel1.Location = new System.Drawing.Point(595, 401);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(256, 123);
            this.Panel1.TabIndex = 56;
            this.Panel1.EnabledChanged += new System.EventHandler(this.Panel1_EnabledChanged);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Transparent;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(17, 9);
            this.RegButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(105, 52);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "تایید";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // DelRadioButton
            // 
            this.DelRadioButton.BackColor = System.Drawing.Color.Red;
            this.DelRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DelRadioButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelRadioButton.ForeColor = System.Drawing.Color.Black;
            this.DelRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelRadioButton.Location = new System.Drawing.Point(129, 39);
            this.DelRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelRadioButton.Name = "DelRadioButton";
            this.DelRadioButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.DelRadioButton.Size = new System.Drawing.Size(105, 25);
            this.DelRadioButton.TabIndex = 3;
            this.DelRadioButton.Text = "حذف";
            this.DelRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelRadioButton.UseVisualStyleBackColor = false;
            this.DelRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // MemBox
            // 
            this.MemBox.BackColor = System.Drawing.Color.LightBlue;
            this.MemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemBox.ForeColor = System.Drawing.Color.Black;
            this.MemBox.Location = new System.Drawing.Point(14, 87);
            this.MemBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemBox.MaxLength = 90;
            this.MemBox.Name = "MemBox";
            this.MemBox.Size = new System.Drawing.Size(230, 23);
            this.MemBox.TabIndex = 4;
            this.MemBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MemBox.Enter += new System.EventHandler(this.MemBox_Enter);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.BackColor = System.Drawing.Color.Lime;
            this.AddRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddRadioButton.ForeColor = System.Drawing.Color.Black;
            this.AddRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRadioButton.Location = new System.Drawing.Point(129, 9);
            this.AddRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.AddRadioButton.Size = new System.Drawing.Size(105, 25);
            this.AddRadioButton.TabIndex = 2;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "اضافه";
            this.AddRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRadioButton.UseVisualStyleBackColor = false;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.Location = new System.Drawing.Point(179, 68);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(62, 16);
            this.Label17.TabIndex = 18;
            this.Label17.Text = "توضیحات:";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Black;
            this.Panel5.Location = new System.Drawing.Point(12, 15);
            this.Panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(105, 52);
            this.Panel5.TabIndex = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "نام";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "نام خانوادگی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "پرسنلی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "مجموع";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "تلفن";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 95;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "تایید";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 40;
            // 
            // OvertimePickerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(859, 531);
            this.Controls.Add(this.DetailGridView);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.FullGridView);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel4);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OvertimePickerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اولویت اضافه کار";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OvertimePickerForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.OvertimePickerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullGridView)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private TextBox NameBox;
		private TextBox PNumBox;
		private Label Label18;
		private Label Label16;
		private Panel Panel2;
		private ComboBox ShiftCombo;
		private ComboBox LocalCombo;
		private Label Label13;
		private Label Label14;
		private Label Label15;
		private DataGridView DetailGridView;
		private Panel Panel1;
		private Button RegButton;
		private RadioButton DelRadioButton;
		private TextBox MemBox;
		private RadioButton AddRadioButton;
		private Label Label17;
		private Panel Panel5;
		private ComboBox KindCombo;
		private ComboBox LeaveCombo;
		private Label Label1;
		private MaskedTextBox TimeBox;
		private DataGridView FullGridView;
		private Label Label10;
		private Panel Panel4;
		private Button ShowButton;
		private Button SearchButton;
		private Panel Panel3;
		private Label Label3;
		private TextBox PhoneBox;
		private Label Label2;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column8;
        private System.ComponentModel.IContainer components;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column7;
    }
	
}
