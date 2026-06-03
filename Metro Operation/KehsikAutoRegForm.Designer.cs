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
		public partial class KehsikAutoRegForm : BaseForm
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label16 = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.EndCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AnalysButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.R9Check = new System.Windows.Forms.CheckBox();
            this.R12Check = new System.Windows.Forms.CheckBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.AsrFBox = new System.Windows.Forms.MaskedTextBox();
            this.SobhFBox = new System.Windows.Forms.MaskedTextBox();
            this.LabelAsrF = new System.Windows.Forms.Label();
            this.LabelSobhF = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Asr5Box = new System.Windows.Forms.MaskedTextBox();
            this.Sobh5Box = new System.Windows.Forms.MaskedTextBox();
            this.LabelAsr5 = new System.Windows.Forms.Label();
            this.LabelSobh5 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.EmptLoc1Box = new System.Windows.Forms.TextBox();
            this.AllCounBox = new System.Windows.Forms.TextBox();
            this.Loc1CouBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.AsrBox = new System.Windows.Forms.MaskedTextBox();
            this.SobhBox = new System.Windows.Forms.MaskedTextBox();
            this.LabelAsr = new System.Windows.Forms.Label();
            this.LabelSobh = new System.Windows.Forms.Label();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel6.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(704, 291);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(220, 24);
            this.Label16.TabIndex = 74;
            this.Label16.Text = "کشیک شنبه تا چهارشنبه ";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.LightBlue;
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.LocalCombo);
            this.Panel6.Controls.Add(this.Label7);
            this.Panel6.Controls.Add(this.TabControl1);
            this.Panel6.Controls.Add(this.R9Check);
            this.Panel6.Controls.Add(this.R12Check);
            this.Panel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel6.Location = new System.Drawing.Point(704, 12);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(220, 260);
            this.Panel6.TabIndex = 0;
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(36, 21);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(115, 24);
            this.LocalCombo.TabIndex = 67;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(151, 25);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 16);
            this.Label7.TabIndex = 68;
            this.Label7.Text = "مبدا:";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl1.ItemSize = new System.Drawing.Size(70, 22);
            this.TabControl1.Location = new System.Drawing.Point(0, 138);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(218, 120);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 1;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.TabPage1.Controls.Add(this.MonthCombo);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 26);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(210, 90);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "ماهانه";
            // 
            // MonthCombo
            // 
            this.MonthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Location = new System.Drawing.Point(44, 32);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(100, 24);
            this.MonthCombo.TabIndex = 0;
            this.MonthCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(144, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(30, 16);
            this.Label1.TabIndex = 63;
            this.Label1.Text = "ماه:";
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.TabPage2.Controls.Add(this.EndCalendar);
            this.TabPage2.Controls.Add(this.StartCalendar);
            this.TabPage2.Controls.Add(this.Label14);
            this.TabPage2.Controls.Add(this.Label15);
            this.TabPage2.Location = new System.Drawing.Point(4, 26);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(210, 90);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "بازه تاریخی";
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location = new System.Drawing.Point(21, 52);
            this.EndCalendar.Miladi = new System.DateTime(((long)(0)));
            this.EndCalendar.Name = "EndCalendar";
            this.EndCalendar.NowDateSelected = true;
            this.EndCalendar.ReadOnly = true;
            this.EndCalendar.SelectedDate = null;
            this.EndCalendar.Shamsi = null;
            this.EndCalendar.Size = new System.Drawing.Size(107, 23);
            this.EndCalendar.TabIndex = 2;
            this.EndCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location = new System.Drawing.Point(21, 17);
            this.StartCalendar.Miladi = new System.DateTime(((long)(0)));
            this.StartCalendar.Name = "StartCalendar";
            this.StartCalendar.NowDateSelected = true;
            this.StartCalendar.ReadOnly = true;
            this.StartCalendar.SelectedDate = null;
            this.StartCalendar.Shamsi = null;
            this.StartCalendar.Size = new System.Drawing.Size(107, 23);
            this.StartCalendar.TabIndex = 1;
            this.StartCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label14.Location = new System.Drawing.Point(127, 55);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(55, 16);
            this.Label14.TabIndex = 114;
            this.Label14.Text = "تا تاریخ :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label15.Location = new System.Drawing.Point(127, 20);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 16);
            this.Label15.TabIndex = 113;
            this.Label15.Text = "از تاریخ :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(this.AnalysButton);
            this.tabPage3.Controls.Add(this.FileNameBox);
            this.tabPage3.Controls.Add(this.SelectButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(210, 90);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "بارگذاری";
            // 
            // AnalysButton
            // 
            this.AnalysButton.Location = new System.Drawing.Point(58, 51);
            this.AnalysButton.Name = "AnalysButton";
            this.AnalysButton.Size = new System.Drawing.Size(98, 29);
            this.AnalysButton.TabIndex = 127;
            this.AnalysButton.Text = "تحلیل فایل";
            this.AnalysButton.UseVisualStyleBackColor = true;
            this.AnalysButton.Click += new System.EventHandler(this.AnalysButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.BackColor = System.Drawing.SystemColors.Control;
            this.FileNameBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FileNameBox.Location = new System.Drawing.Point(43, 19);
            this.FileNameBox.MaxLength = 100;
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.ReadOnly = true;
            this.FileNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileNameBox.Size = new System.Drawing.Size(150, 22);
            this.FileNameBox.TabIndex = 126;
            this.FileNameBox.TabStop = false;
            this.FileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SelectButton
            // 
            this.SelectButton.Image = global::Metro_Operation.Properties.Resources.docs_24;
            this.SelectButton.Location = new System.Drawing.Point(17, 17);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(25, 26);
            this.SelectButton.TabIndex = 125;
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // R9Check
            // 
            this.R9Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.R9Check.ForeColor = System.Drawing.Color.Black;
            this.R9Check.Location = new System.Drawing.Point(36, 93);
            this.R9Check.Name = "R9Check";
            this.R9Check.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.R9Check.Size = new System.Drawing.Size(145, 25);
            this.R9Check.TabIndex = 3;
            this.R9Check.Text = "راهبران 9 ساعته";
            this.R9Check.UseVisualStyleBackColor = false;
            // 
            // R12Check
            // 
            this.R12Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.R12Check.ForeColor = System.Drawing.Color.Black;
            this.R12Check.Location = new System.Drawing.Point(36, 65);
            this.R12Check.Name = "R12Check";
            this.R12Check.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.R12Check.Size = new System.Drawing.Size(145, 25);
            this.R12Check.TabIndex = 2;
            this.R12Check.Text = "راهبران 12 ساعته";
            this.R12Check.UseVisualStyleBackColor = false;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label24.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Location = new System.Drawing.Point(704, 476);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(220, 24);
            this.Label24.TabIndex = 78;
            this.Label24.Text = " کشیک جمعه و تعطیل";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.LightBlue;
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.AsrFBox);
            this.Panel5.Controls.Add(this.SobhFBox);
            this.Panel5.Controls.Add(this.LabelAsrF);
            this.Panel5.Controls.Add(this.LabelSobhF);
            this.Panel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel5.Location = new System.Drawing.Point(704, 500);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(220, 50);
            this.Panel5.TabIndex = 3;
            // 
            // AsrFBox
            // 
            this.AsrFBox.Location = new System.Drawing.Point(33, 13);
            this.AsrFBox.Mask = "99";
            this.AsrFBox.Name = "AsrFBox";
            this.AsrFBox.PromptChar = ' ';
            this.AsrFBox.Size = new System.Drawing.Size(30, 23);
            this.AsrFBox.TabIndex = 3;
            this.AsrFBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SobhFBox
            // 
            this.SobhFBox.Location = new System.Drawing.Point(121, 13);
            this.SobhFBox.Mask = "99";
            this.SobhFBox.Name = "SobhFBox";
            this.SobhFBox.PromptChar = ' ';
            this.SobhFBox.Size = new System.Drawing.Size(30, 23);
            this.SobhFBox.TabIndex = 2;
            this.SobhFBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAsrF
            // 
            this.LabelAsrF.AutoSize = true;
            this.LabelAsrF.Location = new System.Drawing.Point(63, 13);
            this.LabelAsrF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAsrF.Name = "LabelAsrF";
            this.LabelAsrF.Size = new System.Drawing.Size(36, 16);
            this.LabelAsrF.TabIndex = 30;
            this.LabelAsrF.Text = "عصر:";
            // 
            // LabelSobhF
            // 
            this.LabelSobhF.AutoSize = true;
            this.LabelSobhF.Location = new System.Drawing.Point(151, 13);
            this.LabelSobhF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSobhF.Name = "LabelSobhF";
            this.LabelSobhF.Size = new System.Drawing.Size(37, 16);
            this.LabelSobhF.TabIndex = 28;
            this.LabelSobhF.Text = "صبح:";
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(704, 384);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(220, 24);
            this.Label17.TabIndex = 76;
            this.Label17.Text = " کشیک پنج شنبه";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Asr5Box);
            this.Panel3.Controls.Add(this.Sobh5Box);
            this.Panel3.Controls.Add(this.LabelAsr5);
            this.Panel3.Controls.Add(this.LabelSobh5);
            this.Panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel3.Location = new System.Drawing.Point(704, 408);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(220, 50);
            this.Panel3.TabIndex = 2;
            // 
            // Asr5Box
            // 
            this.Asr5Box.Location = new System.Drawing.Point(33, 13);
            this.Asr5Box.Mask = "99";
            this.Asr5Box.Name = "Asr5Box";
            this.Asr5Box.PromptChar = ' ';
            this.Asr5Box.Size = new System.Drawing.Size(30, 23);
            this.Asr5Box.TabIndex = 3;
            this.Asr5Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sobh5Box
            // 
            this.Sobh5Box.Location = new System.Drawing.Point(121, 13);
            this.Sobh5Box.Mask = "99";
            this.Sobh5Box.Name = "Sobh5Box";
            this.Sobh5Box.PromptChar = ' ';
            this.Sobh5Box.Size = new System.Drawing.Size(30, 23);
            this.Sobh5Box.TabIndex = 2;
            this.Sobh5Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAsr5
            // 
            this.LabelAsr5.AutoSize = true;
            this.LabelAsr5.Location = new System.Drawing.Point(63, 13);
            this.LabelAsr5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAsr5.Name = "LabelAsr5";
            this.LabelAsr5.Size = new System.Drawing.Size(36, 16);
            this.LabelAsr5.TabIndex = 30;
            this.LabelAsr5.Text = "عصر:";
            // 
            // LabelSobh5
            // 
            this.LabelSobh5.AutoSize = true;
            this.LabelSobh5.Location = new System.Drawing.Point(151, 13);
            this.LabelSobh5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSobh5.Name = "LabelSobh5";
            this.LabelSobh5.Size = new System.Drawing.Size(37, 16);
            this.LabelSobh5.TabIndex = 28;
            this.LabelSobh5.Text = "صبح:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.RegButton);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(679, 59);
            this.Panel1.TabIndex = 4;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(252, 13);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(172, 33);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(28, 13);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(172, 33);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "      اکسل   ";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(476, 13);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(172, 33);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.LightBlue;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.EmptLoc1Box);
            this.Panel4.Controls.Add(this.AllCounBox);
            this.Panel4.Controls.Add(this.Loc1CouBox);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.Label8);
            this.Panel4.Controls.Add(this.Label9);
            this.Panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel4.Location = new System.Drawing.Point(11, 488);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(680, 61);
            this.Panel4.TabIndex = 71;
            // 
            // EmptLoc1Box
            // 
            this.EmptLoc1Box.Location = new System.Drawing.Point(55, 17);
            this.EmptLoc1Box.Name = "EmptLoc1Box";
            this.EmptLoc1Box.ReadOnly = true;
            this.EmptLoc1Box.Size = new System.Drawing.Size(41, 23);
            this.EmptLoc1Box.TabIndex = 40;
            this.EmptLoc1Box.Text = "0";
            this.EmptLoc1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllCounBox
            // 
            this.AllCounBox.Location = new System.Drawing.Point(468, 17);
            this.AllCounBox.Name = "AllCounBox";
            this.AllCounBox.ReadOnly = true;
            this.AllCounBox.Size = new System.Drawing.Size(41, 23);
            this.AllCounBox.TabIndex = 35;
            this.AllCounBox.Text = "0";
            this.AllCounBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Loc1CouBox
            // 
            this.Loc1CouBox.Location = new System.Drawing.Point(248, 17);
            this.Loc1CouBox.Name = "Loc1CouBox";
            this.Loc1CouBox.ReadOnly = true;
            this.Loc1CouBox.Size = new System.Drawing.Size(41, 23);
            this.Loc1CouBox.TabIndex = 36;
            this.Loc1CouBox.Text = "0";
            this.Loc1CouBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(509, 20);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 16);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "تعداد کشیک های لازم:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(291, 20);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 16);
            this.Label8.TabIndex = 33;
            this.Label8.Text = "تعداد درخواست ";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(98, 20);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(72, 16);
            this.Label9.TabIndex = 39;
            this.Label9.Text = "تعداد خالی ";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.AsrBox);
            this.Panel2.Controls.Add(this.SobhBox);
            this.Panel2.Controls.Add(this.LabelAsr);
            this.Panel2.Controls.Add(this.LabelSobh);
            this.Panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel2.Location = new System.Drawing.Point(704, 315);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(220, 50);
            this.Panel2.TabIndex = 1;
            // 
            // AsrBox
            // 
            this.AsrBox.Location = new System.Drawing.Point(33, 13);
            this.AsrBox.Mask = "99";
            this.AsrBox.Name = "AsrBox";
            this.AsrBox.PromptChar = ' ';
            this.AsrBox.Size = new System.Drawing.Size(30, 23);
            this.AsrBox.TabIndex = 3;
            this.AsrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SobhBox
            // 
            this.SobhBox.Location = new System.Drawing.Point(125, 13);
            this.SobhBox.Mask = "99";
            this.SobhBox.Name = "SobhBox";
            this.SobhBox.PromptChar = ' ';
            this.SobhBox.Size = new System.Drawing.Size(30, 23);
            this.SobhBox.TabIndex = 2;
            this.SobhBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAsr
            // 
            this.LabelAsr.AutoSize = true;
            this.LabelAsr.Location = new System.Drawing.Point(62, 13);
            this.LabelAsr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAsr.Name = "LabelAsr";
            this.LabelAsr.Size = new System.Drawing.Size(36, 16);
            this.LabelAsr.TabIndex = 30;
            this.LabelAsr.Text = "عصر:";
            // 
            // LabelSobh
            // 
            this.LabelSobh.AutoSize = true;
            this.LabelSobh.Location = new System.Drawing.Point(154, 13);
            this.LabelSobh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSobh.Name = "LabelSobh";
            this.LabelSobh.Size = new System.Drawing.Size(37, 16);
            this.LabelSobh.TabIndex = 28;
            this.LabelSobh.Text = "صبح:";
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows = false;
            this.DetailGridView.AllowUserToDeleteRows = false;
            this.DetailGridView.AllowUserToResizeColumns = false;
            this.DetailGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DetailGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DetailGridView.ColumnHeadersHeight = 40;
            this.DetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.DataGridViewTextBoxColumn4,
            this.Column4,
            this.Column11,
            this.Column2,
            this.DataGridViewTextBoxColumn5,
            this.Column3,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column9});
            this.DetailGridView.Location = new System.Drawing.Point(83, 188);
            this.DetailGridView.MultiSelect = false;
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.ReadOnly = true;
            this.DetailGridView.RowHeadersVisible = false;
            this.DetailGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DetailGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DetailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetailGridView.Size = new System.Drawing.Size(561, 223);
            this.DetailGridView.TabIndex = 64;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "نام";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "نام خانوادگی";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "شماره پرسنلی";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "شیفت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "مبدا";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "کل";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 35;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "صبح";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Width = 35;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "عصر";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 35;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "شب 5";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 35;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "روز 6";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 35;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "شب 6";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 35;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "امتیاز";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 35;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "روز";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 35;
            // 
            // ShowGridView
            // 
            this.ShowGridView.AllowUserToAddRows = false;
            this.ShowGridView.AllowUserToDeleteRows = false;
            this.ShowGridView.AllowUserToResizeColumns = false;
            this.ShowGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ShowGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ShowGridView.ColumnHeadersHeight = 40;
            this.ShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column16,
            this.Column8,
            this.Column1,
            this.Column10,
            this.Column15,
            this.Column21});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(11, 82);
            this.ShowGridView.MultiSelect = false;
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(680, 395);
            this.ShowGridView.TabIndex = 24;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "ردیف";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 40;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "نام";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "نام خانوادگی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "شماره پرسنلی";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "روز هفته";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "تاریخ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "کشیک";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "مبدا";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "شیفت";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 45;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "New";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column21.Visible = false;
            // 
            // KehsikAutoRegForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.DetailGridView);
            this.Controls.Add(this.ShowGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KehsikAutoRegForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت خودکار کشیک ";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.KehsikAutoRegForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.KehsikAutoRegForm_Load);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.ResumeLayout(false);

		}
		private ComboBox LocalCombo;
        private System.ComponentModel.IContainer components;
        private Button ShowButton;
        private DataGridView ShowGridView;
        private Label Label1;
        private ComboBox MonthCombo;
        private DataGridView DetailGridView;
        private Button RegButton;
        private Button ExportButton;
        private TextBox Loc1CouBox;
        private TextBox AllCounBox;
        private Label Label8;
        private Label Label2;
        private TextBox EmptLoc1Box;
        private Label Label9;
        private Panel Panel2;
        private Panel Panel4;
        private Panel Panel1;
        private CheckBox R12Check;
        private TabControl TabControl1;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Label Label14;
        private Label Label15;
        private Label Label16;
        private Label Label17;
        private Panel Panel3;
        private MaskedTextBox Asr5Box;
        private MaskedTextBox Sobh5Box;
        private Label LabelAsr5;
        private Label LabelSobh5;
        private Label Label24;
        private Panel Panel5;
        private MaskedTextBox AsrFBox;
        private MaskedTextBox SobhFBox;
        private Label LabelAsrF;
        private Label LabelSobhF;
        private Panel Panel6;
        private CheckBox R9Check;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column9;
        private MaskedTextBox AsrBox;
        private MaskedTextBox SobhBox;
        private Label LabelAsr;
        private Label LabelSobh;
        private Label Label7;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column21;
        private TabPage tabPage3;
        private TextBox FileNameBox;
        private Button SelectButton;
        private Button AnalysButton;
    }
	
}
