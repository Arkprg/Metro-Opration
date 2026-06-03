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
	public 
	partial class ReserveReportForm : BaseForm
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
			this.components=new System.ComponentModel.Container();
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(ReserveReportForm_HelpButtonClicked);
			base.Load += new System.EventHandler(Form34_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.NameBox=new TextBox();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.Button5_Click);
			this.Label1=new Label();
			this.Label2=new Label();
			this.Label3=new Label();
			this.ShowGridView=new DataGridView();
			this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
			this.Column10=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column13=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column12=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column11=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column14=new DataGridViewTextBoxColumn();
			this.Label5=new Label();
			this.Panel1=new Panel();
			this.ZeroRowCheck=new CheckBox();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.ExportButton=new Button();
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label9=new Label();
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label6=new Label();
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.Label13=new Label();
			this.ShiftCheck=new CheckBox();
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Location=new System.Drawing.Point(22, 12);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(136, 32);
			this.ShowButton.TabIndex=4;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(439, 20);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(145, 23);
			this.NameBox.TabIndex=33;
			this.NameBox.TabStop=false;
			//
			//NameButton
			//
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(409, 19);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=0;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(583, 23);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(69, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="نام پرسنل:";
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(325, 57);
			this.Label2.Margin=new Padding(5, 0, 5, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(51, 16);
			this.Label2.TabIndex=28;
			this.Label2.Text="تا تاریخ:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(325, 20);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(51, 16);
			this.Label3.TabIndex=24;
			this.Label3.Text="از تاریخ:";
			//
			//ShowGridView
			//
			this.ShowGridView.AllowUserToAddRows=false;
			this.ShowGridView.AllowUserToDeleteRows=false;
			this.ShowGridView.AllowUserToResizeColumns=false;
			this.ShowGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
			this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.ShowGridView.ColumnHeadersHeight=40;
			this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column10, this.Column1, this.Column7, this.Column2, this.Column8, this.Column13, this.Column6, this.Column9, this.Column12, this.Column3, this.Column4, this.Column11, this.Column5, this.Column14});
			this.ShowGridView.EnableHeadersVisualStyles=false;
			this.ShowGridView.Location=new System.Drawing.Point(11, 115);
			this.ShowGridView.MultiSelect=false;
			this.ShowGridView.Name="ShowGridView";
			this.ShowGridView.ReadOnly=true;
			this.ShowGridView.RowHeadersVisible=false;
			this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShowGridView.RowTemplate.ReadOnly=true;
			this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.ShowGridView.Size=new System.Drawing.Size(1095, 407);
			this.ShowGridView.TabIndex=39;
			this.ShowGridView.TabStop=false;
			//
			//Column10
			//
			this.Column10.HeaderText="ردیف";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=45;
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
			this.Column2.HeaderText="ش پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=80;
			//
			//Column8
			//
			this.Column8.HeaderText="نوع شیفت";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Visible=false;
			//
			//Column13
			//
			this.Column13.HeaderText="نام شیفت";
			this.Column13.Name="Column13";
			this.Column13.ReadOnly=true;
			this.Column13.Visible=false;
			//
			//Column6
			//
			this.Column6.HeaderText="تاریخ";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=80;
			//
			//Column9
			//
			this.Column9.HeaderText="ساعت ورود";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Width=85;
			//
			//Column12
			//
			this.Column12.HeaderText="ساعت خروج";
			this.Column12.Name="Column12";
			this.Column12.ReadOnly=true;
			this.Column12.Width=85;
			//
			//Column3
			//
			this.Column3.HeaderText="تریپ اول";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=75;
			//
			//Column4
			//
			this.Column4.HeaderText="تریپ دوم";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=75;
			//
			//Column11
			//
			this.Column11.HeaderText="توضیحات";
			this.Column11.Name="Column11";
			this.Column11.ReadOnly=true;
			this.Column11.Width=155;
			//
			//Column5
			//
			this.Column5.HeaderText="کاربر";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=140;
			//
			//Column14
			//
			this.Column14.HeaderText="شیفت ورود";
			this.Column14.Name="Column14";
			this.Column14.ReadOnly=true;
			this.Column14.Visible=false;
			//
			//Label5
			//
			this.Label5.BackColor=System.Drawing.Color.Black;
			this.Label5.ForeColor=System.Drawing.Color.White;
			this.Label5.Location=new System.Drawing.Point(252, 530);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(606, 22);
			this.Label5.TabIndex=40;
			this.Label5.Text="سطر قرمز توسط کاربر حدف شده است";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.ShiftCheck);
			this.Panel1.Controls.Add(this.ZeroRowCheck);
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.ExportButton);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(12, 11);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(1091, 93);
			this.Panel1.TabIndex=0;
			this.Panel1.TabStop=true;
			//
			//ZeroRowCheck
			//
			this.ZeroRowCheck.AutoSize=true;
			this.ZeroRowCheck.BackColor=System.Drawing.SystemColors.Control;
			this.ZeroRowCheck.ForeColor=System.Drawing.Color.Black;
			this.ZeroRowCheck.Location=new System.Drawing.Point(411, 55);
			this.ZeroRowCheck.Name="ZeroRowCheck";
			this.ZeroRowCheck.Padding=new Padding(5, 2, 5, 2);
			this.ZeroRowCheck.Size=new System.Drawing.Size(211, 24);
			this.ZeroRowCheck.TabIndex=65;
			this.ZeroRowCheck.Text="حذف شده ها نمایش داده نشود";
			this.ZeroRowCheck.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			this.ZeroRowCheck.UseVisualStyleBackColor=false;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(197, 54);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(128, 23);
			this.EndCalendar.TabIndex=64;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(197, 17);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(128, 23);
			this.StartCalendar.TabIndex=63;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//ExportButton
			//
			this.ExportButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
			this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportButton.Location=new System.Drawing.Point(22, 49);
			this.ExportButton.Name="ExportButton";
			this.ExportButton.Size=new System.Drawing.Size(136, 32);
			this.ExportButton.TabIndex=5;
			this.ExportButton.Text="ذخیره";
			this.ExportButton.UseVisualStyleBackColor=false;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(876, 18);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(165, 24);
			this.LocalCombo.TabIndex=6;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Location=new System.Drawing.Point(1040, 22);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(35, 16);
			this.Label9.TabIndex=62;
			this.Label9.Text="مبدا:";
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(685, 16);
			this.TimeCombo.Margin=new Padding(3, 4, 3, 4);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(90, 24);
			this.TimeCombo.TabIndex=7;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.BackColor=System.Drawing.Color.Transparent;
			this.Label6.ForeColor=System.Drawing.Color.Black;
			this.Label6.Location=new System.Drawing.Point(774, 20);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(72, 16);
			this.Label6.TabIndex=61;
			this.Label6.Text="نوع شیفت:";
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(685, 53);
			this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(90, 24);
			this.ShiftCombo.TabIndex=8;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.ForeColor=System.Drawing.Color.Black;
			this.Label13.Location=new System.Drawing.Point(774, 57);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=59;
			this.Label13.Text="نام شیفت:";
			//
			//ShiftCheck
			//
			this.ShiftCheck.AutoSize=true;
			this.ShiftCheck.BackColor=System.Drawing.SystemColors.Control;
			this.ShiftCheck.ForeColor=System.Drawing.Color.Black;
			this.ShiftCheck.Location=new System.Drawing.Point(879, 55);
			this.ShiftCheck.Name="ShiftCheck";
			this.ShiftCheck.Padding=new Padding(5, 2, 5, 2);
			this.ShiftCheck.Size=new System.Drawing.Size(159, 24);
			this.ShiftCheck.TabIndex=65;
			this.ShiftCheck.Text="نمایش مسئول شیفت";
			this.ShiftCheck.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			this.ShiftCheck.UseVisualStyleBackColor=false;
			//
			//ReserveReportForm
			//
			this.AcceptButton=this.ShowButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(1115, 561);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.ShowGridView);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ReserveReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="گزارش کارکرد راهبران رزرو";
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private TextBox NameBox;
		private Button NameButton;
		private Label Label1;
		private Label Label2;
		private Label Label3;
		private DataGridView ShowGridView;
		private Label Label5;
		private Button ShowButton;
		private Panel Panel1;
		private ComboBox TimeCombo;
		private Label Label6;
		private ComboBox ShiftCombo;
		private Label Label13;
		private ComboBox LocalCombo;
		private Label Label9;
		private Button ExportButton;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private CheckBox ZeroRowCheck;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column14;
		private CheckBox ShiftCheck;
	}
	
}
