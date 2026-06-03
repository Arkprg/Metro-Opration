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
	partial class ManageOvertimeReviewForm : BaseForm
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
			this.DataGridView1.CurrentCellChanged += new System.EventHandler(this.DataGridView1_CurrentCellChanged);
			this.DataGridView1.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.DataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
			this.Column1=new DataGridViewTextBoxColumn();
			this.DataGridView2=new DataGridView();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Button2=new Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3=new Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.SystemColors.ActiveBorder;
			DataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle1.ForeColor=System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode=DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle1;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column1});
			this.DataGridView1.Location=new System.Drawing.Point(22, 3);
			this.DataGridView1.MultiSelect=false;
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.RowTemplate.ReadOnly=true;
			this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size=new System.Drawing.Size(546, 171);
			this.DataGridView1.TabIndex=34;
			//
			//Column1
			//
			this.Column1.HeaderText="نام پرسنل";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows=false;
			this.DataGridView2.AllowUserToDeleteRows=false;
			this.DataGridView2.AllowUserToResizeColumns=false;
			this.DataGridView2.AllowUserToResizeRows=false;
			this.DataGridView2.BackgroundColor=System.Drawing.SystemColors.ControlLight;
			this.DataGridView2.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.SystemColors.ActiveBorder;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.DataGridView2.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.DataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Columns.AddRange(new DataGridViewColumn[] {this.Column2, this.Column3, this.Column4, this.Column7, this.Column5, this.Column6, this.Column8});
			this.DataGridView2.GridColor=System.Drawing.SystemColors.Control;
			this.DataGridView2.Location=new System.Drawing.Point(1, 176);
			this.DataGridView2.MultiSelect=false;
			this.DataGridView2.Name="DataGridView2";
			this.DataGridView2.ReadOnly=true;
			this.DataGridView2.RowHeadersVisible=false;
			this.DataGridView2.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.RowTemplate.ReadOnly=true;
			this.DataGridView2.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size=new System.Drawing.Size(587, 156);
			this.DataGridView2.TabIndex=36;
			//
			//Column2
			//
			this.Column2.HeaderText="تغییرات";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=70;
			//
			//Column3
			//
			this.Column3.HeaderText="نام پرسنل";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=110;
			//
			//Column4
			//
			this.Column4.HeaderText="شماره پرسنلی";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=70;
			//
			//Column7
			//
			this.Column7.HeaderText="اضافه کاری";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=70;
			//
			//Column5
			//
			this.Column5.HeaderText="توضیحات";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=150;
			//
			//Column6
			//
			this.Column6.HeaderText="کاربر";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			//
			//Column8
			//
			this.Column8.HeaderText="ID";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Visible=false;
			//
			//Button2
			//
			this.Button2.DialogResult=DialogResult.None;
			this.Button2.Location=new System.Drawing.Point(345, 338);
			this.Button2.Name="Button2";
			this.Button2.Size=new System.Drawing.Size(75, 28);
			this.Button2.TabIndex=37;
			this.Button2.Text="تایید";
			this.Button2.UseVisualStyleBackColor=true;
			//
			//Button3
			//
			this.Button3.DialogResult=DialogResult.None;
			this.Button3.Location=new System.Drawing.Point(163, 338);
			this.Button3.Name="Button3";
			this.Button3.Size=new System.Drawing.Size(75, 28);
			this.Button3.TabIndex=38;
			this.Button3.Text="انصراف";
			this.Button3.UseVisualStyleBackColor=true;
			//
			//ManageOvertimeReviewForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 14.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.CancelButton=this.Button3;
			this.ClientSize=new System.Drawing.Size(589, 373);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.DataGridView2);
			this.Controls.Add(this.DataGridView1);
			this.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ManageOvertimeReviewForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="بررسی موارد اضافه کار ویرایش شده";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			this.ResumeLayout(false);
			
		}
		private DataGridView DataGridView1;
		private DataGridView DataGridView2;
		private Button Button2;
		private Button Button3;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column8;
	}
	
}
