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
	public partial class ImportExcelForm : BaseForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)  {
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()  {
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			this.TripGridView=new DataGridView();
			this.SelectButton=new Button();
			this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
			this.NameBox=new TextBox();
			this.ImportButton=new Button();
			this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
			this.Label1=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			((System.ComponentModel.ISupportInitialize) this.TripGridView).BeginInit();
			this.SuspendLayout();
			//
			//TripGridView
			//
			this.TripGridView.AllowUserToAddRows=false;
			this.TripGridView.AllowUserToDeleteRows=false;
			this.TripGridView.AllowUserToResizeColumns=false;
			this.TripGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
			this.TripGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.TripGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			this.TripGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.TripGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
			this.TripGridView.DefaultCellStyle=DataGridViewCellStyle3;
			this.TripGridView.EnableHeadersVisualStyles=false;
			this.TripGridView.Location=new System.Drawing.Point(13, 58);
			this.TripGridView.Margin=new Padding(3, 4, 3, 4);
			this.TripGridView.Name="TripGridView";
			this.TripGridView.ReadOnly=true;
			this.TripGridView.RowHeadersVisible=false;
			this.TripGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.TripGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TripGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.TripGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.TripGridView.Size=new System.Drawing.Size(907, 482);
			this.TripGridView.TabIndex=136;
			//
			//SelectButton
			//
			this.SelectButton.Image=global::Metro_Operation.Properties.Resources.docs_24;
			this.SelectButton.BackgroundImageLayout=ImageLayout.Stretch;
			this.SelectButton.Location=new System.Drawing.Point(647, 14);
			this.SelectButton.Name="SelectButton";
			this.SelectButton.Size=new System.Drawing.Size(25, 25);
			this.SelectButton.TabIndex=135;
			this.SelectButton.UseVisualStyleBackColor=true;
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Control;
			this.NameBox.Location=new System.Drawing.Point(672, 15);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(179, 23);
			this.NameBox.TabIndex=132;
			this.NameBox.TabStop=false;
			this.NameBox.TextAlign=HorizontalAlignment.Right;
			//
			//ImportButton
			//
			this.ImportButton.Location=new System.Drawing.Point(517, 14);
			this.ImportButton.Name="ImportButton";
			this.ImportButton.Size=new System.Drawing.Size(98, 25);
			this.ImportButton.TabIndex=133;
			this.ImportButton.Text="تحلیل فایل";
			this.ImportButton.UseVisualStyleBackColor=true;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(851, 19);
			this.Label1.Margin=new Padding(3);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(55, 16);
			this.Label1.TabIndex=134;
			this.Label1.Text="نام فایل:";
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(66, 9);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(135, 34);
			this.RegButton.TabIndex=137;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//SundryImportForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(933, 554);
			this.Controls.Add(this.RegButton);
			this.Controls.Add(this.TripGridView);
			this.Controls.Add(this.SelectButton);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.ImportButton);
			this.Controls.Add(this.Label1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedSingle;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="SundryImportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ورود متفرقه";
			((System.ComponentModel.ISupportInitialize) this.TripGridView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		private DataGridView TripGridView;
		private Button SelectButton;
		private TextBox NameBox;
		private Button ImportButton;
		private Label Label1;
		private Button RegButton;
	}
	
}
