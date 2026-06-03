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
	partial class KeshikReportForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SelfCheck = new System.Windows.Forms.CheckBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Wheat;
            this.Label7.Location = new System.Drawing.Point(435, 21);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 16);
            this.Label7.TabIndex = 66;
            this.Label7.Text = "مبدا:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Wheat;
            this.Label6.Location = new System.Drawing.Point(586, 21);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(30, 16);
            this.Label6.TabIndex = 65;
            this.Label6.Text = "ماه:";
            // 
            // MonthCombo
            // 
            this.MonthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Location = new System.Drawing.Point(487, 17);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(99, 24);
            this.MonthCombo.TabIndex = 1;
            this.MonthCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(336, 17);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(99, 24);
            this.LocalCombo.TabIndex = 2;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(172, 12);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(144, 34);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowGridView
            // 
            this.ShowGridView.AllowUserToAddRows = false;
            this.ShowGridView.AllowUserToDeleteRows = false;
            this.ShowGridView.AllowUserToResizeColumns = false;
            this.ShowGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ShowGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ShowGridView.ColumnHeadersHeight = 40;
            this.ShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column2,
            this.Column1,
            this.Column8,
            this.Column3,
            this.Column4});
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(12, 84);
            this.ShowGridView.MultiSelect = false;
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(830, 438);
            this.ShowGridView.TabIndex = 68;
            this.ShowGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DetailGridView_ColumnHeaderMouseClick);
            // 
            // Column14
            // 
            this.Column14.HeaderText = "ردیف";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "نام";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "نام خانوادگی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ش پرسنلی";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "تاریخ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شیفت";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "مبدا";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "کاربر";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "زمان ثبت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(15, 12);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(145, 34);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "ذخیره";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.SelfCheck);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.MonthCombo);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(829, 60);
            this.Panel1.TabIndex = 0;
            // 
            // SelfCheck
            // 
            this.SelfCheck.BackColor = System.Drawing.Color.White;
            this.SelfCheck.Location = new System.Drawing.Point(630, 41);
            this.SelfCheck.Name = "SelfCheck";
            this.SelfCheck.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.SelfCheck.Size = new System.Drawing.Size(180, 24);
            this.SelfCheck.TabIndex = 67;
            this.SelfCheck.Text = "فقط کشیک های خودم";
            this.SelfCheck.UseVisualStyleBackColor = false;
            this.SelfCheck.CheckedChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(794, 21);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 16);
            this.Label4.TabIndex = 70;
            this.Label4.Text = "نام:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameBox.Location = new System.Drawing.Point(660, 18);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(135, 23);
            this.NameBox.TabIndex = 69;
            // 
            // NameButton
            // 
            this.NameButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameButton.Image = global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location = new System.Drawing.Point(630, 17);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex = 68;
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // KeshikReportForm
            // 
            this.AcceptButton = this.ShowButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(854, 531);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeshikReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کشیک های ماهانه";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.KeshikReportForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.KeshikReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private Label Label7;
		private Label Label6;
		private ComboBox MonthCombo;
		private ComboBox LocalCombo;
		private Button ShowButton;
		private DataGridView ShowGridView;
		private Button ExportButton;
		private Panel Panel1;
		private CheckBox SelfCheck;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label Label4;
        private TextBox NameBox;
        private Button NameButton;
    }
	
}
