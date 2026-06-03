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
	partial class KeshikRequReportForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle5=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle6=new DataGridViewCellStyle();
			this.ShowGridView=new DataGridView();
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(KeshikRequReportForm_HelpButtonClicked);
			base.Load += new System.EventHandler(KeshikRequReportForm_Load);
			this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.ShowGridView_ColumnHeaderMouseClick);
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.Panel1=new Panel();
			this.ExportButton=new Button();
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label18=new Label();
			this.Label17=new Label();
			this.Label13=new Label();
			this.Column14=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column9=new DataGridViewCheckBoxColumn();
			this.Column10=new DataGridViewCheckBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//ShowGridView
			//
			this.ShowGridView.AllowUserToAddRows=false;
			this.ShowGridView.AllowUserToDeleteRows=false;
			this.ShowGridView.AllowUserToResizeColumns=false;
			this.ShowGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle4.BackColor=System.Drawing.Color.Moccasin;
			this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle4;
			DataGridViewCellStyle5.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle5.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle5.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle5.WrapMode=DataGridViewTriState.False;
			this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle5;
			this.ShowGridView.ColumnHeadersHeight=40;
			this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column14, this.Column5, this.Column6, this.Column7, this.Column8, this.Column4, this.Column1, this.Column9, this.Column10, this.Column2, this.Column3});
			this.ShowGridView.EnableHeadersVisualStyles=false;
			this.ShowGridView.Location=new System.Drawing.Point(8, 75);
			this.ShowGridView.MultiSelect=false;
			this.ShowGridView.Name="ShowGridView";
			this.ShowGridView.ReadOnly=true;
			this.ShowGridView.RowHeadersVisible=false;
			this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowGridView.RowsDefaultCellStyle=DataGridViewCellStyle6;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.ShowGridView.Size=new System.Drawing.Size(1069, 482);
			this.ShowGridView.TabIndex=66;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			
			this.ShowButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowButton.Location=new System.Drawing.Point(188, 10);
			this.ShowButton.Margin=new Padding(4, 5, 4, 5);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(145, 35);
			this.ShowButton.TabIndex=4;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.ExportButton);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Location=new System.Drawing.Point(8, 10);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(1069, 55);
			this.Panel1.TabIndex=0;
			//
			//ExportButton
			//
			this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
			this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
			this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportButton.Location=new System.Drawing.Point(20, 10);
			this.ExportButton.Name="ExportButton";
			this.ExportButton.Size=new System.Drawing.Size(145, 35);
			this.ExportButton.TabIndex=5;
			this.ExportButton.Text="ذخیره";
			this.ExportButton.UseVisualStyleBackColor=false;
			//
			//LocalCombo
			//
			this.LocalCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(874, 15);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(143, 24);
			this.LocalCombo.TabIndex=1;
			//
			//ShiftCombo
			//
			this.ShiftCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(453, 15);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(110, 24);
			this.ShiftCombo.TabIndex=3;
			//
			//TimeCombo
			//
			this.TimeCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(666, 15);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(104, 24);
			this.TimeCombo.TabIndex=2;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Location=new System.Drawing.Point(1017, 19);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(35, 16);
			this.Label18.TabIndex=51;
			this.Label18.Text="مبدا:";
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(769, 19);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(72, 16);
			this.Label17.TabIndex=50;
			this.Label17.Text="نوع شیفت:";
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Location=new System.Drawing.Point(563, 19);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=49;
			this.Label13.Text="نام شیفت:";
			//
			//Column14
			//
			this.Column14.HeaderText="ردیف";
			this.Column14.Name="Column14";
			this.Column14.ReadOnly=true;
			this.Column14.Width=50;
			//
			//Column5
			//
			this.Column5.HeaderText="نام";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=80;
			//
			//Column6
			//
			this.Column6.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText="نام خانوادگی";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			//
			//Column7
			//
			this.Column7.HeaderText="ش پرسنلی";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=80;
			//
			//Column8
			//
			this.Column8.HeaderText="مبدا";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			//
			//Column4
			//
			this.Column4.HeaderText="شیفت";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=60;
			//
			//Column1
			//
			this.Column1.HeaderText="تعداد درخواست";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			//
			//Column9
			//
			this.Column9.HeaderText="مجوز اضافه کار";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Width=95;
			//
			//Column10
			//
			this.Column10.HeaderText="مجوز تریپ";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=85;
			//
			//Column2
			//
			this.Column2.HeaderText="کاربر";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=135;
			//
			//Column3
			//
			this.Column3.HeaderText="زمان ثبت";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=130;
			//
			//KeshikRequReportForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(1084, 566);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.ShowGridView);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="KeshikRequReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="در خواست کشیک ثبت شده";
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private DataGridView ShowGridView;
		private Button ShowButton;
		private Panel Panel1;
		private ComboBox LocalCombo;
		private ComboBox ShiftCombo;
		private ComboBox TimeCombo;
		private Label Label18;
		private Label Label17;
		private Label Label13;
		private Button ExportButton;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewCheckBoxColumn Column9;
		private DataGridViewCheckBoxColumn Column10;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
	}
	
}
