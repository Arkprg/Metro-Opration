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
		public partial class PersonalListForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ShowButton = new System.Windows.Forms.Button();
            this.PostCombo = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.TimeCombo = new System.Windows.Forms.ComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.ShiftCombo = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.PersonGridView = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.UnitCombo = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.PersonGridView2 = new System.Windows.Forms.DataGridView();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.PersonGridView3 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView2)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(28, 8);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(130, 34);
            this.ShowButton.TabIndex = 5;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // PostCombo
            // 
            this.PostCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PostCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PostCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCombo.FormattingEnabled = true;
            this.PostCombo.Location = new System.Drawing.Point(441, 29);
            this.PostCombo.Name = "PostCombo";
            this.PostCombo.Size = new System.Drawing.Size(193, 24);
            this.PostCombo.TabIndex = 2;
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(634, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(97, 16);
            this.Label1.TabIndex = 48;
            this.Label1.Text = "پست سازمانی:";
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(28, 46);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(130, 34);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "ذخیره";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // LocalCombo
            // 
            this.LocalCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LocalCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(775, 51);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(143, 24);
            this.LocalCombo.TabIndex = 1;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(918, 55);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(57, 16);
            this.Label18.TabIndex = 45;
            this.Label18.Text = "محل کار:";
            // 
            // TimeCombo
            // 
            this.TimeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TimeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeCombo.FormattingEnabled = true;
            this.TimeCombo.Location = new System.Drawing.Point(227, 13);
            this.TimeCombo.Name = "TimeCombo";
            this.TimeCombo.Size = new System.Drawing.Size(99, 24);
            this.TimeCombo.TabIndex = 3;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(326, 17);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(72, 16);
            this.Label17.TabIndex = 43;
            this.Label17.Text = "نوع شیفت:";
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ShiftCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ShiftCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShiftCombo.FormattingEnabled = true;
            this.ShiftCombo.Location = new System.Drawing.Point(227, 51);
            this.ShiftCombo.Name = "ShiftCombo";
            this.ShiftCombo.Size = new System.Drawing.Size(99, 24);
            this.ShiftCombo.TabIndex = 4;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(326, 55);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 16);
            this.Label13.TabIndex = 41;
            this.Label13.Text = "نام شیفت:";
            // 
            // PersonGridView
            // 
            this.PersonGridView.AllowUserToAddRows = false;
            this.PersonGridView.AllowUserToDeleteRows = false;
            this.PersonGridView.AllowUserToResizeColumns = false;
            this.PersonGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            this.PersonGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PersonGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PersonGridView.ColumnHeadersHeight = 40;
            this.PersonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PersonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column3,
            this.Column2,
            this.Column1,
            this.Column10,
            this.Column7,
            this.Column6,
            this.Column5,
            this.Column4,
            this.Column14,
            this.Column8});
            this.PersonGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonGridView.EnableHeadersVisualStyles = false;
            this.PersonGridView.Location = new System.Drawing.Point(0, 0);
            this.PersonGridView.MultiSelect = false;
            this.PersonGridView.Name = "PersonGridView";
            this.PersonGridView.ReadOnly = true;
            this.PersonGridView.RowHeadersVisible = false;
            this.PersonGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PersonGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PersonGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonGridView.RowTemplate.ReadOnly = true;
            this.PersonGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonGridView.Size = new System.Drawing.Size(1015, 482);
            this.PersonGridView.TabIndex = 34;
            this.PersonGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PersonGridView3_ColumnHeaderMouseClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText = "ردیف";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نام";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نام خانوادگی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شماره پرسنلی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "واحد خدمتی";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "پست سازمانی";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "مبدا";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "نوع شیفت";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نام شیفت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "گروه راهبری";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 70;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "نوع گواهینامه";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.UnitCombo);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label18);
            this.Panel1.Controls.Add(this.Label17);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Location = new System.Drawing.Point(10, 10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1009, 90);
            this.Panel1.TabIndex = 0;
            // 
            // UnitCombo
            // 
            this.UnitCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UnitCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UnitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UnitCombo.FormattingEnabled = true;
            this.UnitCombo.Location = new System.Drawing.Point(775, 13);
            this.UnitCombo.Name = "UnitCombo";
            this.UnitCombo.Size = new System.Drawing.Size(143, 24);
            this.UnitCombo.TabIndex = 0;
            this.UnitCombo.SelectedIndexChanged += new System.EventHandler(this.UnitCombo_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(918, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(82, 16);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "واحد خدمتی:";
            // 
            // TabControl1
            // 
            this.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl1.ItemSize = new System.Drawing.Size(110, 25);
            this.TabControl1.Location = new System.Drawing.Point(0, 108);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1048, 490);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 35;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.PersonGridView);
            this.TabPage1.Location = new System.Drawing.Point(4, 4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1015, 482);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "اطلاعات پرسنلی";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.PersonGridView2);
            this.TabPage2.Location = new System.Drawing.Point(4, 4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(1015, 482);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "اطلاعات تکمیلی";
            // 
            // PersonGridView2
            // 
            this.PersonGridView2.AllowUserToAddRows = false;
            this.PersonGridView2.AllowUserToDeleteRows = false;
            this.PersonGridView2.AllowUserToResizeColumns = false;
            this.PersonGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            this.PersonGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PersonGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PersonGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.Column16,
            this.Column19,
            this.DataGridViewTextBoxColumn6,
            this.Column24,
            this.Column25,
            this.Column17,
            this.Column18,
            this.DataGridViewTextBoxColumn7,
            this.Column15,
            this.Column26,
            this.Column20,
            this.Column21,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.Column22,
            this.Column23});
            this.PersonGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonGridView2.EnableHeadersVisualStyles = false;
            this.PersonGridView2.Location = new System.Drawing.Point(0, 0);
            this.PersonGridView2.MultiSelect = false;
            this.PersonGridView2.Name = "PersonGridView2";
            this.PersonGridView2.ReadOnly = true;
            this.PersonGridView2.RowHeadersVisible = false;
            this.PersonGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PersonGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PersonGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonGridView2.RowTemplate.ReadOnly = true;
            this.PersonGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonGridView2.Size = new System.Drawing.Size(1015, 482);
            this.PersonGridView2.TabIndex = 35;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.PersonGridView3);
            this.TabPage3.Location = new System.Drawing.Point(4, 4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1015, 482);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "سایز لباس";
            // 
            // PersonGridView3
            // 
            this.PersonGridView3.AllowUserToAddRows = false;
            this.PersonGridView3.AllowUserToDeleteRows = false;
            this.PersonGridView3.AllowUserToResizeColumns = false;
            this.PersonGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Moccasin;
            this.PersonGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.PersonGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PersonGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PersonGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn17,
            this.DataGridViewTextBoxColumn18,
            this.Column9,
            this.Column12,
            this.Column13,
            this.DataGridViewTextBoxColumn14,
            this.DataGridViewTextBoxColumn15});
            this.PersonGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonGridView3.EnableHeadersVisualStyles = false;
            this.PersonGridView3.Location = new System.Drawing.Point(0, 0);
            this.PersonGridView3.MultiSelect = false;
            this.PersonGridView3.Name = "PersonGridView3";
            this.PersonGridView3.ReadOnly = true;
            this.PersonGridView3.RowHeadersVisible = false;
            this.PersonGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PersonGridView3.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PersonGridView3.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonGridView3.RowTemplate.ReadOnly = true;
            this.PersonGridView3.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PersonGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonGridView3.Size = new System.Drawing.Size(1015, 482);
            this.PersonGridView3.TabIndex = 36;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.HeaderText = "ردیف";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly = true;
            this.DataGridViewTextBoxColumn10.Width = 40;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.HeaderText = "نام";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly = true;
            this.DataGridViewTextBoxColumn11.Width = 78;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.HeaderText = "نام خانوادگی";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly = true;
            this.DataGridViewTextBoxColumn12.Width = 140;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.HeaderText = "شماره پرسنلی";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly = true;
            this.DataGridViewTextBoxColumn13.Width = 70;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.HeaderText = "سایز کفش";
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.ReadOnly = true;
            this.DataGridViewTextBoxColumn16.Width = 70;
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.HeaderText = "سایز پیراهن";
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.ReadOnly = true;
            this.DataGridViewTextBoxColumn17.Width = 70;
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.HeaderText = "سایز کت";
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.ReadOnly = true;
            this.DataGridViewTextBoxColumn18.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "سایز شلوار";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "سایز اورکت";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 70;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "سایز گرمکن";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 70;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.HeaderText = "مدرک تحصیلی";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly = true;
            this.DataGridViewTextBoxColumn14.Width = 120;
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn15.HeaderText = "رشته تحصیلی";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.Frozen = true;
            this.DataGridViewTextBoxColumn1.HeaderText = "ردیف";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 40;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.Frozen = true;
            this.DataGridViewTextBoxColumn2.HeaderText = "نام";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 78;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.Frozen = true;
            this.DataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 140;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.Frozen = true;
            this.DataGridViewTextBoxColumn4.HeaderText = "شماره پرسنلی";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 70;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "کد ملی";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Width = 90;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "شماره شناسنامه";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 70;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "نام پدر";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 90;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText = "تاریخ تولد";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            this.DataGridViewTextBoxColumn6.Width = 85;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "سن";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 90;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "سن (روز)";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Visible = false;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "محل تولد";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            this.Column17.Width = 90;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "محل صدور";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            this.Column18.Width = 90;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText = "تاریخ استخدام";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            this.DataGridViewTextBoxColumn7.Width = 85;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "سابقه کار";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 75;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "سابقه کار (روز)";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Visible = false;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "شماره بیمه";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "کد پستی";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Visible = false;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.HeaderText = "شماره همراه";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly = true;
            this.DataGridViewTextBoxColumn8.Width = 90;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.HeaderText = "آدرس";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly = true;
            this.DataGridViewTextBoxColumn9.Width = 250;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "وضعیت تاهل";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            this.Column22.Width = 80;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "تعداد فرزندان";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Visible = false;
            this.Column23.Width = 50;
            // 
            // PersonalListForm
            // 
            this.AcceptButton = this.ShowButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1048, 598);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonalListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست پرسنل";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.PersonnelListForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView2)).EndInit();
            this.TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView3)).EndInit();
            this.ResumeLayout(false);

		}
		private Button ShowButton;
		private DataGridView PersonGridView;
		private ComboBox TimeCombo;
		private Label Label17;
		private ComboBox ShiftCombo;
		private Label Label13;
		private ComboBox LocalCombo;
		private Label Label18;
		private Button ExportButton;
		private ComboBox PostCombo;
		private Label Label1;
		private Panel Panel1;
		private TabControl TabControl1;
		private TabPage TabPage1;
		private TabPage TabPage2;
		private DataGridView PersonGridView2;
		private TabPage TabPage3;
		private DataGridView PersonGridView3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column8;
		private ComboBox UnitCombo;
		private Label Label2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column26;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
    }
	
}
