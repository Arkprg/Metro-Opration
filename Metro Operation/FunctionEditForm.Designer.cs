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
	partial class FunctionEditForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            this.NameBox=new System.Windows.Forms.TextBox();
            this.NameButton=new System.Windows.Forms.Button();
            this.ShowButton=new System.Windows.Forms.Button();
            this.Label3=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.RegButton=new System.Windows.Forms.Button();
            this.ExitButton=new System.Windows.Forms.Button();
            this.DelButton=new System.Windows.Forms.Button();
            this.DataGridView1=new System.Windows.Forms.DataGridView();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label6=new System.Windows.Forms.Label();
            this.KindCombo=new System.Windows.Forms.ComboBox();
            this.Label4=new System.Windows.Forms.Label();
            this.MemBox=new System.Windows.Forms.RichTextBox();
            this.Panel1=new System.Windows.Forms.Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label2=new System.Windows.Forms.Label();
            this.Panel3=new System.Windows.Forms.Panel();
            this.LevelCombo=new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(305, 15);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(137, 23);
            this.NameBox.TabIndex=0;
            // 
            // NameButton
            // 
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(275, 14);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search1;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location=new System.Drawing.Point(5, 8);
            this.ShowButton.Margin=new System.Windows.Forms.Padding(5);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(88, 36);
            this.ShowButton.TabIndex=3;
            this.ShowButton.Text="جستجو ";
            this.ShowButton.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.ShowButton.UseVisualStyleBackColor=false;
            this.ShowButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(230, 18);
            this.Label3.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(39, 16);
            this.Label3.TabIndex=37;
            this.Label3.Text="تاریخ:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(440, 18);
            this.Label1.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(69, 16);
            this.Label1.TabIndex=35;
            this.Label1.Text="نام پرسنل:";
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(343, 12);
            this.RegButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(154, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(13, 12);
            this.ExitButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(104, 34);
            this.ExitButton.TabIndex=3;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor=System.Drawing.Color.Tomato;
            this.DelButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DelButton.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
            this.DelButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DelButton.Location=new System.Drawing.Point(181, 12);
            this.DelButton.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelButton.Name="DelButton";
            this.DelButton.Size=new System.Drawing.Size(154, 34);
            this.DelButton.TabIndex=2;
            this.DelButton.Text="حذف";
            this.DelButton.UseVisualStyleBackColor=false;
            this.DelButton.Click += new System.EventHandler(this.Button6_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            this.DataGridView1.ColumnHeadersBorderStyle=System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridView1.Location=new System.Drawing.Point(9, 75);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView1.RowTemplate.ReadOnly=true;
            this.DataGridView1.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(515, 136);
            this.DataGridView1.TabIndex=4;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            // 
            // Column2
            // 
            this.Column2.HeaderText="نوع امتیاز";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=80;
            // 
            // Column3
            // 
            this.Column3.HeaderText="عنوان امتیاز";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=180;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText="توضیحات";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            // 
            // Column5
            // 
            this.Column5.HeaderText="ID";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Visible=false;
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(455, 19);
            this.Label6.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(42, 16);
            this.Label6.TabIndex=56;
            this.Label6.Text="امتیاز:";
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Location=new System.Drawing.Point(13, 15);
            this.KindCombo.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(313, 24);
            this.KindCombo.TabIndex=1;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(435, 59);
            this.Label4.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(62, 16);
            this.Label4.TabIndex=54;
            this.Label4.Text="توضیحات:";
            // 
            // MemBox
            // 
            this.MemBox.Location=new System.Drawing.Point(13, 80);
            this.MemBox.Margin=new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(484, 51);
            this.MemBox.TabIndex=4;
            this.MemBox.Text="";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location=new System.Drawing.Point(9, 11);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(515, 52);
            this.Panel1.TabIndex=1;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(105, 15);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.LevelCombo);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.MemBox);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.KindCombo);
            this.Panel2.Location=new System.Drawing.Point(9, 226);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(515, 145);
            this.Panel2.TabIndex=2;
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(326, 19);
            this.Label2.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(44, 16);
            this.Label2.TabIndex=57;
            this.Label2.Text="عنوان:";
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.DelButton);
            this.Panel3.Location=new System.Drawing.Point(9, 383);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(515, 59);
            this.Panel3.TabIndex=3;
            // 
            // LevelCombo
            // 
            this.LevelCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelCombo.FormattingEnabled=true;
            this.LevelCombo.Items.AddRange(new object[] {
            "مثبت",
            "منفی"});
            this.LevelCombo.Location=new System.Drawing.Point(397, 15);
            this.LevelCombo.Name="LevelCombo";
            this.LevelCombo.Size=new System.Drawing.Size(58, 24);
            this.LevelCombo.TabIndex=58;
            this.LevelCombo.SelectedIndexChanged += new System.EventHandler(this.LevelCombo_SelectedIndexChanged);
            // 
            // FunctionEditForm
            // 
            this.AcceptButton=this.ShowButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(533, 452);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="FunctionEditForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="ویرایش امتیاز ثبت شده";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FunctionEditForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private TextBox NameBox;
		private Button NameButton;
		private Button ShowButton;
		private Label Label3;
		private Label Label1;
		private Button RegButton;
		private Button ExitButton;
		private Button DelButton;
		private DataGridView DataGridView1;
		private Label Label6;
		private ComboBox KindCombo;
		private Label Label4;
		private RichTextBox MemBox;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Label Label2;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private System.ComponentModel.IContainer components;
        private ComboBox LevelCombo;
    }
	
}
