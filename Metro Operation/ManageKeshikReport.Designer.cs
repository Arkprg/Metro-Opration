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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class ManageKeshikReport : BaseForm
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
			this.components=new System.ComponentModel.Container();
			base.Load += new System.EventHandler(ManageKeshikReport_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label2=new Label();
			this.ShiftCombo=new ComboBox();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label13=new Label();
			this.Label15=new Label();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.Label4=new Label();
			this.ExportButton=new Button();
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			this.ShowGridView=new DataGridView();
			this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
			this.Column12=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column11=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column10=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Label1=new Label();
			this.Panel1=new Panel();
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.Label7=new Label();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(534, 10);
			this.TimeCombo.Margin=new Padding(3, 4, 3, 4);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(101, 24);
			this.TimeCombo.TabIndex=56;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.BackColor=System.Drawing.Color.Transparent;
			this.Label2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label2.ForeColor=System.Drawing.Color.Black;
			this.Label2.Location=new System.Drawing.Point(635, 14);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(72, 16);
			this.Label2.TabIndex=57;
			this.Label2.Text="نوع شیفت:";
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(534, 44);
			this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(101, 24);
			this.ShiftCombo.TabIndex=53;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(743, 10);
			this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(165, 24);
			this.LocalCombo.TabIndex=52;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label13.ForeColor=System.Drawing.Color.Black;
			this.Label13.Location=new System.Drawing.Point(635, 48);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=54;
			this.Label13.Text="نام شیفت:";
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.BackColor=System.Drawing.Color.Transparent;
			this.Label15.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label15.ForeColor=System.Drawing.Color.Black;
			this.Label15.Location=new System.Drawing.Point(908, 14);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(35, 16);
			this.Label15.TabIndex=55;
			this.Label15.Text="مبدا:";
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowButton.Location=new System.Drawing.Point(16, 5);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(148, 34);
			this.ShowButton.TabIndex=3;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.BackColor=System.Drawing.Color.Transparent;
			this.Label4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.ForeColor=System.Drawing.Color.Black;
			this.Label4.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
			this.Label4.Location=new System.Drawing.Point(446, 14);
			this.Label4.Margin=new Padding(5, 0, 5, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(55, 16);
			this.Label4.TabIndex=50;
			this.Label4.Text="از تاریخ :";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ExportButton
			//
			this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
			this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
			this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ExportButton.Location=new System.Drawing.Point(16, 39);
			this.ExportButton.Name="ExportButton";
			this.ExportButton.Size=new System.Drawing.Size(148, 34);
			this.ExportButton.TabIndex=4;
			this.ExportButton.Text="ذخیره";
			this.ExportButton.UseVisualStyleBackColor=false;
			//
			//ShowGridView
			//
			this.ShowGridView.AllowUserToAddRows=false;
			this.ShowGridView.AllowUserToDeleteRows=false;
			this.ShowGridView.AllowUserToResizeColumns=false;
			this.ShowGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			DataGridViewCellStyle1.ForeColor=System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			DataGridViewCellStyle1.SelectionForeColor=System.Drawing.Color.Black;
			this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Single;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.ShowGridView.ColumnHeadersHeight=40;
			this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column12, this.Column1, this.Column3, this.Column11, this.Column7, this.Column10, this.Column2, this.Column5, this.Column6, this.Column8, this.Column4});
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			DataGridViewCellStyle3.SelectionForeColor=System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
			this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle3;
			this.ShowGridView.EnableHeadersVisualStyles=false;
			this.ShowGridView.Location=new System.Drawing.Point(11, 111);
			this.ShowGridView.MultiSelect=false;
			this.ShowGridView.Name="ShowGridView";
			this.ShowGridView.ReadOnly=true;
			this.ShowGridView.RowHeadersVisible=false;
			this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowGridView.RowTemplate.ReadOnly=true;
			this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.ShowGridView.Size=new System.Drawing.Size(965, 482);
			this.ShowGridView.TabIndex=49;
			//
			//Column12
			//
			this.Column12.HeaderText="ردیف";
			this.Column12.Name="Column12";
			this.Column12.ReadOnly=true;
			this.Column12.Width=40;
			//
			//Column1
			//
			this.Column1.HeaderText="نام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=70;
			//
			//Column3
			//
			this.Column3.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText="نام خانوادگی";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			//
			//Column11
			//
			this.Column11.HeaderText="ش پرسنلی";
			this.Column11.Name="Column11";
			this.Column11.ReadOnly=true;
			this.Column11.Width=80;
			//
			//Column7
			//
			this.Column7.HeaderText="شیفت";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=85;
			//
			//Column10
			//
			this.Column10.HeaderText="مبدا";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=70;
			//
			//Column2
			//
			this.Column2.HeaderText=" تعداد کشیک";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=90;
			//
			//Column5
			//
			this.Column5.HeaderText="تعداد کشیک";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=90;
			//
			//Column6
			//
			this.Column6.HeaderText=" تعداد کشیک";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=90;
			//
			//Column8
			//
			this.Column8.HeaderText="تعداد کشیک";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Width=90;
			//
			//Column4
			//
			this.Column4.HeaderText="مجموع";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=80;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.ForeColor=System.Drawing.Color.Black;
			this.Label1.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
			this.Label1.Location=new System.Drawing.Point(446, 48);
			this.Label1.Margin=new Padding(5, 0, 5, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(55, 16);
			this.Label1.TabIndex=51;
			this.Label1.Text="تا تاریخ :";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Controls.Add(this.ExportButton);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(11, 17);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(965, 81);
			this.Panel1.TabIndex=48;
			//
			//PostCombo
			//
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(743, 44);
			this.PostCombo.Margin=new Padding(3, 4, 3, 4);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(165, 24);
			this.PostCombo.TabIndex=60;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(908, 48);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(43, 16);
			this.Label7.TabIndex=61;
			this.Label7.Text="پست:";
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(317, 45);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(128, 23);
			this.EndCalendar.TabIndex=59;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(317, 11);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(128, 23);
			this.StartCalendar.TabIndex=58;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//ManageKeshikReport
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize=new System.Drawing.Size(987, 606);
			this.Controls.Add(this.ShowGridView);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ManageKeshikReport";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="آمار راهبران در لوحه کشیک";
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private DataGridView ShowGridView;
		private Panel Panel1;
		private ComboBox TimeCombo;
		private Label Label2;
		private ComboBox ShiftCombo;
		private ComboBox LocalCombo;
		private Label Label13;
		private Label Label15;
		private Button ExportButton;
		private Button ShowButton;
		private Label Label4;
		private Label Label1;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column4;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private ComboBox PostCombo;
		private Label Label7;
	}
	
}
