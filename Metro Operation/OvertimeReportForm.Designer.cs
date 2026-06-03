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
	partial class OvertimeReportForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ShowButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.EndCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ShiftCombo = new System.Windows.Forms.ComboBox();
            this.PostCombo = new System.Windows.Forms.ComboBox();
            this.TimeCombo = new System.Windows.Forms.ComboBox();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(11, 4);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(124, 34);
            this.ShowButton.TabIndex = 5;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Location = new System.Drawing.Point(396, 11);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(145, 23);
            this.NameBox.TabIndex = 33;
            // 
            // NameButton
            // 
            this.NameButton.Image = global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location = new System.Drawing.Point(366, 10);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex = 1;
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(292, 47);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 16);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "تا تاریخ:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(292, 13);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 16);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "از تاریخ:";
            // 
            // ShowGridView
            // 
            this.ShowGridView.AllowUserToAddRows = false;
            this.ShowGridView.AllowUserToDeleteRows = false;
            this.ShowGridView.AllowUserToResizeColumns = false;
            this.ShowGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            this.ShowGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight = 40;
            this.ShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column9});
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(8, 99);
            this.ShowGridView.MultiSelect = false;
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGridView.RowTemplate.ReadOnly = true;
            this.ShowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(1032, 460);
            this.ShowGridView.TabIndex = 33;
            this.ShowGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGridView_CellClick);
            this.ShowGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(10, 11);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1030, 80);
            this.Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(542, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 16);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "نام:";
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location = new System.Drawing.Point(163, 44);
            this.EndCalendar.Miladi = new System.DateTime(((long)(0)));
            this.EndCalendar.Name = "EndCalendar";
            this.EndCalendar.NowDateSelected = true;
            this.EndCalendar.ReadOnly = true;
            this.EndCalendar.SelectedDate = null;
            this.EndCalendar.Shamsi = null;
            this.EndCalendar.Size = new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex = 60;
            this.EndCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location = new System.Drawing.Point(163, 10);
            this.StartCalendar.Miladi = new System.DateTime(((long)(0)));
            this.StartCalendar.Name = "StartCalendar";
            this.StartCalendar.NowDateSelected = true;
            this.StartCalendar.ReadOnly = true;
            this.StartCalendar.SelectedDate = null;
            this.StartCalendar.Shamsi = null;
            this.StartCalendar.Size = new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex = 59;
            this.StartCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(11, 40);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(124, 34);
            this.ExportButton.TabIndex = 58;
            this.ExportButton.Text = "ذخیره";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled = true;
            this.ShiftCombo.Location = new System.Drawing.Point(596, 43);
            this.ShiftCombo.Name = "ShiftCombo";
            this.ShiftCombo.Size = new System.Drawing.Size(90, 24);
            this.ShiftCombo.TabIndex = 55;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // PostCombo
            // 
            this.PostCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCombo.FormattingEnabled = true;
            this.PostCombo.Location = new System.Drawing.Point(772, 43);
            this.PostCombo.Name = "PostCombo";
            this.PostCombo.Size = new System.Drawing.Size(199, 24);
            this.PostCombo.TabIndex = 51;
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            // 
            // TimeCombo
            // 
            this.TimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.FormattingEnabled = true;
            this.TimeCombo.Location = new System.Drawing.Point(596, 9);
            this.TimeCombo.Name = "TimeCombo";
            this.TimeCombo.Size = new System.Drawing.Size(90, 24);
            this.TimeCombo.TabIndex = 54;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(772, 9);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(199, 24);
            this.LocalCombo.TabIndex = 53;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(970, 47);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 16);
            this.Label7.TabIndex = 50;
            this.Label7.Text = "پست:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(685, 47);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(70, 16);
            this.Label8.TabIndex = 57;
            this.Label8.Text = "نام شیفت:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(970, 13);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 16);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "مبدا:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(685, 13);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(72, 16);
            this.Label10.TabIndex = 56;
            this.Label10.Text = "نوع شیفت:";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ردیف";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "نام";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "نام خانوادگی";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 135;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ش پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "تاریخ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "مدت";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "مبدا";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "توضیحات";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "کاربر";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "تاریخ ثبت";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 130;
            // 
            // OvertimeReportForm
            // 
            this.AcceptButton = this.ShowButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1048, 565);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShowGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OvertimeReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش اضافه کار ثبت شده";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OvertimeReportForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.OvertimeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private Label Label3;
		private Label Label2;
		private DataGridView ShowGridView;
		private TextBox NameBox;
		private Button NameButton;
		private Button ShowButton;
		private Panel Panel1;
		private ComboBox ShiftCombo;
		private ComboBox PostCombo;
		private ComboBox TimeCombo;
		private ComboBox LocalCombo;
		private Label Label7;
		private Label Label8;
		private Label Label9;
		private Label Label10;
		private Button ExportButton;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private Label Label1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private System.ComponentModel.IContainer components;
    }
	
}
