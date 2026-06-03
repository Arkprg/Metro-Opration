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
	partial class KeshikEditForm : BaseForm
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
            this.Label7=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.ShiftCombo=new System.Windows.Forms.ComboBox();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.NameCombo=new System.Windows.Forms.ComboBox();
            this.Label1=new System.Windows.Forms.Label();
            this.RegButton=new System.Windows.Forms.Button();
            this.DetailGridView=new System.Windows.Forms.DataGridView();
            this.Column14=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleButton=new System.Windows.Forms.Button();
            this.DeletLabel=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label2=new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(286, 15);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(35, 16);
            this.Label7.TabIndex=62;
            this.Label7.Text="مبدا:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(100, 15);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(50, 16);
            this.Label6.TabIndex=61;
            this.Label6.Text="شیفت:";
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(463, 15);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(39, 16);
            this.Label5.TabIndex=60;
            this.Label5.Text="تاریخ:";
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Items.AddRange(new object[] {
            "همه موارد",
            "صبح",
            "عصر",
            "روز",
            "شب"});
            this.ShiftCombo.Location=new System.Drawing.Point(18, 11);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(82, 24);
            this.ShiftCombo.TabIndex=3;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(170, 11);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(116, 24);
            this.LocalCombo.TabIndex=2;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // NameCombo
            // 
            this.NameCombo.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameCombo.FormattingEnabled=true;
            this.NameCombo.Location=new System.Drawing.Point(209, 16);
            this.NameCombo.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameCombo.Name="NameCombo";
            this.NameCombo.Size=new System.Drawing.Size(247, 24);
            this.NameCombo.Sorted=true;
            this.NameCombo.TabIndex=4;
            this.NameCombo.SelectedIndexChanged += new System.EventHandler(this.NameCombo_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.Transparent;
            this.Label1.Location=new System.Drawing.Point(457, 20);
            this.Label1.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(29, 16);
            this.Label1.TabIndex=32;
            this.Label1.Text="نام:";
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegButton
            // 
            this.RegButton.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(11, 11);
            this.RegButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(149, 34);
            this.RegButton.TabIndex=5;
            this.RegButton.Text="ثبت";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows=false;
            this.DetailGridView.AllowUserToDeleteRows=false;
            this.DetailGridView.AllowUserToResizeColumns=false;
            this.DetailGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DetailGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.DetailGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.DetailGridView.ColumnHeadersHeight=40;
            this.DetailGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column2});
            this.DetailGridView.EnableHeadersVisualStyles=false;
            this.DetailGridView.Location=new System.Drawing.Point(11, 87);
            this.DetailGridView.MultiSelect=false;
            this.DetailGridView.Name="DetailGridView";
            this.DetailGridView.ReadOnly=true;
            this.DetailGridView.RowHeadersVisible=false;
            this.DetailGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DetailGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DetailGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetailGridView.Size=new System.Drawing.Size(521, 308);
            this.DetailGridView.TabIndex=23;
            this.DetailGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DetailGridView_CellMouseClick);
            this.DetailGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DetailGridView_ColumnHeaderMouseClick);
            // 
            // Column14
            // 
            this.Column14.HeaderText="ردیف";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Width=50;
            // 
            // Column5
            // 
            this.Column5.HeaderText="نام";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=80;
            // 
            // Column6
            // 
            this.Column6.HeaderText="نام خانوادگی";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=140;
            // 
            // Column7
            // 
            this.Column7.HeaderText="شماره پرسنلی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText="شیفت";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            // 
            // Column2
            // 
            this.Column2.HeaderText="ID";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Visible=false;
            // 
            // DeleButton
            // 
            this.DeleButton.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleButton.BackColor=System.Drawing.Color.Tomato;
            this.DeleButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DeleButton.Enabled=false;
            this.DeleButton.ForeColor=System.Drawing.Color.Black;
            this.DeleButton.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
            this.DeleButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleButton.Location=new System.Drawing.Point(11, 56);
            this.DeleButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleButton.Name="DeleButton";
            this.DeleButton.Size=new System.Drawing.Size(149, 34);
            this.DeleButton.TabIndex=1;
            this.DeleButton.Text="حذف";
            this.DeleButton.UseVisualStyleBackColor=false;
            this.DeleButton.Click += new System.EventHandler(this.DeleButton_Click);
            // 
            // DeletLabel
            // 
            this.DeletLabel.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeletLabel.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeletLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DeletLabel.ForeColor=System.Drawing.Color.Red;
            this.DeletLabel.Location=new System.Drawing.Point(209, 61);
            this.DeletLabel.Name="DeletLabel";
            this.DeletLabel.Size=new System.Drawing.Size(286, 25);
            this.DeletLabel.TabIndex=62;
            this.DeletLabel.Text="شیفت:";
            this.DeletLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Location=new System.Drawing.Point(11, 9);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(521, 47);
            this.Panel1.TabIndex=0;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(338, 12);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_Leave);
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Controls.Add(this.DeleButton);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.DeletLabel);
            this.Panel2.Controls.Add(this.NameCombo);
            this.Panel2.Location=new System.Drawing.Point(11, 405);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(521, 100);
            this.Panel2.TabIndex=1;
            // 
            // Label2
            // 
            this.Label2.BackColor=System.Drawing.Color.Transparent;
            this.Label2.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor=System.Drawing.Color.DarkRed;
            this.Label2.Location=new System.Drawing.Point(84, 61);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(374, 20);
            this.Label2.TabIndex=73;
            this.Label2.Text="سطر های قرمز مجاز به اضافه کار نیستند، لطفا حذف شوند";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.Visible=false;
            // 
            // KeshikEditForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(544, 514);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DetailGridView);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="KeshikEditForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="ویرایش کشیک ماهانه";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.KeshikEditForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.KeshikRegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		private Button RegButton;
		private Label Label1;
		private DataGridView DetailGridView;
		private ComboBox NameCombo;
		private Label Label7;
		private Label Label6;
		private Label Label5;
		private ComboBox ShiftCombo;
		private ComboBox LocalCombo;
		private Button DeleButton;
		private Label DeletLabel;
		private Panel Panel1;
		private Panel Panel2;
		private Label Label2;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private System.ComponentModel.IContainer components;
    }
	
}
