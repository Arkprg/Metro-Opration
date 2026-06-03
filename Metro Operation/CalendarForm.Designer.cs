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
	partial class CalendarForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.CalendarGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.HolidayCheckBox = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.PervButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MothGenerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearComboBox
            // 
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(192, 11);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(70, 24);
            this.YearComboBox.TabIndex = 1;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.MonthComboBox.Location = new System.Drawing.Point(57, 11);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(90, 24);
            this.MonthComboBox.TabIndex = 2;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(261, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 16);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "سال:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(146, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(30, 16);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "ماه:";
            // 
            // CalendarGridView
            // 
            this.CalendarGridView.AllowUserToAddRows = false;
            this.CalendarGridView.AllowUserToDeleteRows = false;
            this.CalendarGridView.AllowUserToResizeColumns = false;
            this.CalendarGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalendarGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CalendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.CalendarGridView.Location = new System.Drawing.Point(354, 67);
            this.CalendarGridView.MultiSelect = false;
            this.CalendarGridView.Name = "CalendarGridView";
            this.CalendarGridView.ReadOnly = true;
            this.CalendarGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalendarGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CalendarGridView.RowTemplate.Height = 35;
            this.CalendarGridView.Size = new System.Drawing.Size(353, 210);
            this.CalendarGridView.TabIndex = 0;
            this.CalendarGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalendarGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شنبه";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "یک شنبه";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "دو شنبه";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سه شنبه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "چهار شنبه";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "پنچ شنبه";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "جمعه";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 50;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.LightBlue;
            this.DateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(101, 62);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(106, 18);
            this.DateLabel.TabIndex = 20;
            this.DateLabel.Text = "__/__/____";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(156, 10);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(154, 34);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.Location = new System.Drawing.Point(13, 98);
            this.ReasonTextBox.MaxLength = 50;
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.Size = new System.Drawing.Size(250, 23);
            this.ReasonTextBox.TabIndex = 3;
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(167, 18);
            this.TimeBox.Mask = "00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(45, 23);
            this.TimeBox.TabIndex = 1;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(216, 21);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(104, 16);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "ساعت کسری کار";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(262, 101);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "مناسبت:";
            // 
            // HolidayCheckBox
            // 
            this.HolidayCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HolidayCheckBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HolidayCheckBox.Location = new System.Drawing.Point(13, 16);
            this.HolidayCheckBox.Name = "HolidayCheckBox";
            this.HolidayCheckBox.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.HolidayCheckBox.Size = new System.Drawing.Size(115, 26);
            this.HolidayCheckBox.TabIndex = 2;
            this.HolidayCheckBox.Text = "تعطیل رسمی";
            this.HolidayCheckBox.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.HolidayCheckBox);
            this.Panel1.Controls.Add(this.TimeBox);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.DateLabel);
            this.Panel1.Controls.Add(this.ReasonTextBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location = new System.Drawing.Point(10, 69);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(331, 140);
            this.Panel1.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Location = new System.Drawing.Point(10, 221);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(331, 56);
            this.Panel2.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image = global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(15, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "انصراف";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.PervButton);
            this.Panel3.Controls.Add(this.NextButton);
            this.Panel3.Controls.Add(this.MonthComboBox);
            this.Panel3.Controls.Add(this.YearComboBox);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Location = new System.Drawing.Point(354, 10);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(353, 47);
            this.Panel3.TabIndex = 0;
            // 
            // PervButton
            // 
            this.PervButton.Image = global::Metro_Operation.Properties.Resources._32;
            this.PervButton.Location = new System.Drawing.Point(309, 9);
            this.PervButton.Name = "PervButton";
            this.PervButton.Size = new System.Drawing.Size(29, 27);
            this.PervButton.TabIndex = 44;
            this.PervButton.UseVisualStyleBackColor = true;
            this.PervButton.Click += new System.EventHandler(this.PervButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Metro_Operation.Properties.Resources._31;
            this.NextButton.Location = new System.Drawing.Point(11, 10);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(29, 27);
            this.NextButton.TabIndex = 43;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.MothGenerButton);
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 47);
            this.panel4.TabIndex = 3;
            // 
            // MothGenerButton
            // 
            this.MothGenerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MothGenerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MothGenerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MothGenerButton.Image = global::Metro_Operation.Properties.Resources.Calendar;
            this.MothGenerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MothGenerButton.Location = new System.Drawing.Point(85, 6);
            this.MothGenerButton.Name = "MothGenerButton";
            this.MothGenerButton.Size = new System.Drawing.Size(154, 30);
            this.MothGenerButton.TabIndex = 1;
            this.MothGenerButton.Text = "ثبت ماه جدید";
            this.MothGenerButton.UseVisualStyleBackColor = false;
            this.MothGenerButton.Click += new System.EventHandler(this.MothGenerButton_Click);
            // 
            // CalendarForm
            // 
            this.AcceptButton = this.RegButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(717, 286);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.CalendarGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalendarForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقویم";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.CalendarForm_HelpButtonClicked);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.CalendarForm_Closing);
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private ComboBox YearComboBox;
		private ComboBox MonthComboBox;
		private Label Label2;
		private Label Label1;
		private DataGridView CalendarGridView;
		private Label Label3;
		private CheckBox HolidayCheckBox;
		private Button RegButton;
		private TextBox ReasonTextBox;
		private MaskedTextBox TimeBox;
		private Label Label8;
		private Label DateLabel;
		private Panel Panel1;
		private Panel Panel2;
		private Button ExitButton;
		private Panel Panel3;
		private Button NextButton;
		private Button PervButton;
        private Panel panel4;
        private Button MothGenerButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
	
}
