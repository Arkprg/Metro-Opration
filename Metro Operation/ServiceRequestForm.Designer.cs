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
	public partial class ServiceRequestForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			this.Panel1=new Panel();
			base.Load += new System.EventHandler(ServiceRequestForm_Load);
			this.Label5=new Label();
			this.AddressLabel=new Label();
			this.Label4=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.TimeBox=new MaskedTextBox();
			this.NameBox=new TextBox();
			this.DateLabel=new Label();
			this.Label2=new Label();
			this.Label3=new Label();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label7=new Label();
			this.Label1=new Label();
			this.ShowGridView=new DataGridView();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.AddressLabel);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.RegButton);
			this.Panel1.Controls.Add(this.TimeBox);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.DateLabel);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(6, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(826, 122);
			this.Panel1.TabIndex=1;
			//
			//Label5
			//
			this.Label5.AccessibleDescription="66666666";
			this.Label5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.ForeColor=System.Drawing.Color.Red;
			this.Label5.Location=new System.Drawing.Point(2, 93);
			this.Label5.Margin=new Padding(4, 0, 4, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(820, 25);
			this.Label5.TabIndex=46;
			this.Label5.Text="** در صورت عدم ثبت ساعت حضور سرویس ، زمان بر اساس پیاده شده شما تنظیم خواهد شد **" +
				"";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			this.Label5.Visible=false;
			//
			//AddressLabel
			//
			this.AddressLabel.AccessibleDescription="";
			this.AddressLabel.Font=new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AddressLabel.Location=new System.Drawing.Point(44, 13);
			this.AddressLabel.Margin=new Padding(4, 0, 4, 0);
			this.AddressLabel.Name="AddressLabel";
			this.AddressLabel.Size=new System.Drawing.Size(494, 25);
			this.AddressLabel.TabIndex=44;
			this.AddressLabel.Text="1401/11/25";
			this.AddressLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label4
			//
			this.Label4.AccessibleDescription="66666666";
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(538, 17);
			this.Label4.Margin=new Padding(4, 0, 4, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(44, 16);
			this.Label4.TabIndex=45;
			this.Label4.Text="مقصد:";
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RegButton.Location=new System.Drawing.Point(44, 49);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(150, 34);
			this.RegButton.TabIndex=41;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//TimeBox
			//
			this.TimeBox.Location=new System.Drawing.Point(401, 55);
			this.TimeBox.Mask="00:00";
			this.TimeBox.Name="TimeBox";
			this.TimeBox.Size=new System.Drawing.Size(50, 23);
			this.TimeBox.TabIndex=40;
			this.TimeBox.TextAlign=HorizontalAlignment.Center;
			this.TimeBox.ValidatingType=typeof(DateTime);
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(621, 14);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(133, 23);
			this.NameBox.TabIndex=25;
			this.NameBox.TabStop=false;
			//
			//DateLabel
			//
			this.DateLabel.AccessibleDescription="";
			this.DateLabel.Font=new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DateLabel.Location=new System.Drawing.Point(647, 56);
			this.DateLabel.Margin=new Padding(4, 0, 4, 0);
			this.DateLabel.Name="DateLabel";
			this.DateLabel.Size=new System.Drawing.Size(107, 20);
			this.DateLabel.TabIndex=27;
			this.DateLabel.Text="1401/11/25";
			this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//label2
			//
			this.Label2.AccessibleDescription="66666666";
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(302, 58);
			this.Label2.Margin=new Padding(4, 0, 4, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(100, 16);
			this.Label2.TabIndex=27;
			this.Label2.Text="(18:30 تا 23:30)";
			//
			//Label3
			//
			this.Label3.AccessibleDescription="66666666";
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(755, 58);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(39, 16);
			this.Label3.TabIndex=27;
			this.Label3.Text="تاریخ:";
			//
			//NameButton
			//
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(591, 13);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(451, 58);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(132, 16);
			this.Label7.TabIndex=39;
			this.Label7.Text="ساعت حضور سرویس:";
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(755, 17);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(29, 16);
			this.Label1.TabIndex=26;
			this.Label1.Text="نام:";
			//
			//ShowGridView
			//
			this.ShowGridView.AllowUserToAddRows=false;
			this.ShowGridView.AllowUserToDeleteRows=false;
			this.ShowGridView.AllowUserToResizeColumns=false;
			this.ShowGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.Color.Moccasin;
			this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle3;
			this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Single;
			DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode=DataGridViewTriState.False;
			this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle4;
			this.ShowGridView.ColumnHeadersHeight=40;
			this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column8, this.Column1, this.Column7, this.Column2, this.Column3, this.Column4, this.Column5, this.Column9});
			this.ShowGridView.EnableHeadersVisualStyles=false;
			this.ShowGridView.Location=new System.Drawing.Point(6, 143);
			this.ShowGridView.MultiSelect=false;
			this.ShowGridView.Name="ShowGridView";
			this.ShowGridView.ReadOnly=true;
			this.ShowGridView.RowHeadersVisible=false;
			this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ShowGridView.RowTemplate.ReadOnly=true;
			this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.ShowGridView.Size=new System.Drawing.Size(826, 347);
			this.ShowGridView.TabIndex=34;
			//
			//Column8
			//
			this.Column8.HeaderText="ردیف";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Width=45;
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
			this.Column7.HeaderText="نام خانوادگی";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=135;
			//
			//Column2
			//
			this.Column2.HeaderText="ش پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=80;
			//
			//Column3
			//
			this.Column3.HeaderText="ساعت";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=60;
			//
			//Column4
			//
			this.Column4.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText="آدرس";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			//
			//Column5
			//
			this.Column5.HeaderText="کاربر";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=120;
			//
			//Column9
			//
			this.Column9.HeaderText="تاریخ ثبت";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Width=130;
			//
			//ServiceRequestForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.ClientSize=new System.Drawing.Size(840, 498);
			this.Controls.Add(this.ShowGridView);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedSingle;
			this.Margin=new Padding(4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ServiceRequestForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="درخواست سرویس راهبران";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).EndInit();
			this.ResumeLayout(false);
			
		}
		
		private Panel Panel1;
		private TextBox NameBox;
		private Label Label3;
		private Button NameButton;
		private Label Label7;
		private Label Label1;
		private MaskedTextBox TimeBox;
		private Label DateLabel;
		private Button RegButton;
		private DataGridView ShowGridView;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column9;
		private Label AddressLabel;
		private Label Label4;
		private Label Label2;
		private Label Label5;
	}
	
}
