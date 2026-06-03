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
	partial class PermisionReportForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			this.DataGridView1=new DataGridView();
			base.Load += new System.EventHandler(PermisionReportForm_Load);
			this.DataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column11=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewCheckBoxColumn();
			this.Column4=new DataGridViewCheckBoxColumn();
			this.Column8=new DataGridViewCheckBoxColumn();
			this.Column12=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column10=new DataGridViewTextBoxColumn();
			this.Panel1=new Panel();
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.Button3=new Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label1=new Label();
			this.Label18=new Label();
			this.Label17=new Label();
			this.Label13=new Label();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.DataGridView1.ColumnHeadersHeight=40;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column9, this.Column1, this.Column7, this.Column2, this.Column11, this.Column6, this.Column3, this.Column4, this.Column8, this.Column12, this.Column5, this.Column10});
			this.DataGridView1.EnableHeadersVisualStyles=false;
			this.DataGridView1.Location=new System.Drawing.Point(10, 78);
			this.DataGridView1.MultiSelect=false;
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.RowTemplate.ReadOnly=true;
			this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size=new System.Drawing.Size(1150, 482);
			this.DataGridView1.TabIndex=38;
			//
			//Column9
			//
			this.Column9.HeaderText="ردیف";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Resizable=DataGridViewTriState.False;
			this.Column9.Width=45;
			//
			//Column1
			//
			this.Column1.HeaderText="نام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=70;
			//
			//Column7
			//
			this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText="نام خانوادگی";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			//
			//Column2
			//
			this.Column2.HeaderText="شماره پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=80;
			//
			//Column11
			//
			this.Column11.HeaderText="مبدا";
			this.Column11.Name="Column11";
			this.Column11.ReadOnly=true;
			//
			//Column6
			//
			this.Column6.HeaderText="شیفت";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=90;
			//
			//Column3
			//
			this.Column3.HeaderText="مجوز اضافه کار";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Resizable=DataGridViewTriState.True;
			this.Column3.SortMode=DataGridViewColumnSortMode.Automatic;
			this.Column3.Width=70;
			//
			//Column4
			//
			this.Column4.HeaderText=" مجوز تریپ";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Resizable=DataGridViewTriState.True;
			this.Column4.SortMode=DataGridViewColumnSortMode.Automatic;
			this.Column4.Width=70;
			//
			//Column8
			//
			this.Column8.HeaderText="مجوز رزرو";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Resizable=DataGridViewTriState.True;
			this.Column8.SortMode=DataGridViewColumnSortMode.Automatic;
			this.Column8.Width=70;
			//
			//Column12
			//
			this.Column12.HeaderText="توضیحات";
			this.Column12.Name="Column12";
			this.Column12.ReadOnly=true;
			this.Column12.Width=150;
			//
			//Column5
			//
			this.Column5.HeaderText="کاربر";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=135;
			//
			//Column10
			//
			this.Column10.HeaderText="تاریخ ثبت";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=130;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Location=new System.Drawing.Point(10, 9);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(1146, 60);
			this.Panel1.TabIndex=39;
			//
			//PostCombo
			//
			this.PostCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.PostCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(638, 18);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(217, 24);
			this.PostCombo.TabIndex=1;
			//
			//Button3
			//
			this.Button3.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.Button3.Image=global::Metro_Operation.Properties.Resources.search;
			this.Button3.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.Button3.Cursor=Cursors.Hand;
			this.Button3.Location=new System.Drawing.Point(16, 13);
			this.Button3.Name="Button3";
			this.Button3.Size=new System.Drawing.Size(141, 34);
			this.Button3.TabIndex=5;
			this.Button3.Text="نمایش";
			this.Button3.UseVisualStyleBackColor=false;
			//
			//LocalCombo
			//
			this.LocalCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(979, 18);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(101, 24);
			this.LocalCombo.TabIndex=2;
			//
			//ShiftCombo
			//
			this.ShiftCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(253, 18);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(89, 24);
			this.ShiftCombo.TabIndex=4;
			//
			//TimeCombo
			//
			this.TimeCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(434, 18);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(89, 24);
			this.TimeCombo.TabIndex=3;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(854, 22);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(97, 16);
			this.Label1.TabIndex=48;
			this.Label1.Text="پست سازمانی:";
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Location=new System.Drawing.Point(1080, 22);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(35, 16);
			this.Label18.TabIndex=45;
			this.Label18.Text="مبدا:";
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(522, 22);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(72, 16);
			this.Label17.TabIndex=43;
			this.Label17.Text="نوع شیفت:";
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Location=new System.Drawing.Point(341, 22);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=41;
			this.Label13.Text="نام شیفت:";
			//
			//PermisionReportForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(1168, 566);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.DataGridView1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="PermisionReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="گزارش مجوز ها";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		private DataGridView DataGridView1;
		private Panel Panel1;
		private ComboBox PostCombo;
		private Button Button3;
		private ComboBox LocalCombo;
		private ComboBox ShiftCombo;
		private ComboBox TimeCombo;
		private Label Label1;
		private Label Label18;
		private Label Label17;
		private Label Label13;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewCheckBoxColumn Column3;
		private DataGridViewCheckBoxColumn Column4;
		private DataGridViewCheckBoxColumn Column8;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column10;
	}
	
}
