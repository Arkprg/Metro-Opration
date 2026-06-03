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
	partial class ManageFunctionReportForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(ManageFunctionReportForm_HelpButtonClicked);
			base.Load += new System.EventHandler(ManageFunctionReportForm_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.Label2=new Label();
			this.Label3=new Label();
			this.AllPosetCheck=new CheckBox();
			this.AllPosetCheck.CheckedChanged += new System.EventHandler(this.AllPosetCheck_CheckedChanged);
			this.AllPosetCheck.Click += new System.EventHandler(this.AllPosetCheck_Click);
			this.AllNegetCheck=new CheckBox();
			this.AllNegetCheck.CheckedChanged += new System.EventHandler(this.AllNegetCheck_CheckedChanged);
			this.AllNegetCheck.Click += new System.EventHandler(this.AllNegetCheck_Click);
			this.PosetiveBox=new CheckedListBox();
			this.PosetiveBox.SelectedIndexChanged += new System.EventHandler(this.PosetiveBox_SelectedIndexChanged);
			this.NegetiveBox=new CheckedListBox();
			this.NegetiveBox.SelectedIndexChanged += new System.EventHandler(this.NegetiveBox_SelectedIndexChanged);
			this.ShowGridView=new DataGridView();
			this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
			this.ShowGridView.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.ExportButton=new Button();
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			this.Panel1=new Panel();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.Label18=new Label();
			this.Label8=new Label();
			this.Label17=new Label();
			this.UserCombo=new ComboBox();
			this.UserCombo.SelectedIndexChanged += new System.EventHandler(this.UserCombo_SelectedIndexChanged);
			this.Label13=new Label();
			this.Label6=new Label();
			this.Panel2=new Panel();
			this.Label4=new Label();
			this.Label1=new Label();
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Location=new System.Drawing.Point(251, 112);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(137, 34);
			this.ShowButton.TabIndex=3;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(136, 40);
			this.Label2.Margin=new Padding(5, 0, 5, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(51, 16);
			this.Label2.TabIndex=38;
			this.Label2.Text="تا تاریخ:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(136, 10);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(51, 16);
			this.Label3.TabIndex=37;
			this.Label3.Text="از تاریخ:";
			//
			//AllPosetCheck
			//
			this.AllPosetCheck.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.AllPosetCheck.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AllPosetCheck.Location=new System.Drawing.Point(14, 19);
			this.AllPosetCheck.Name="AllPosetCheck";
			this.AllPosetCheck.Size=new System.Drawing.Size(326, 23);
			this.AllPosetCheck.TabIndex=4;
			this.AllPosetCheck.Text="همه موارد";
			this.AllPosetCheck.ThreeState=true;
			this.AllPosetCheck.UseVisualStyleBackColor=false;
			//
			//AllNegetCheck
			//
			this.AllNegetCheck.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.AllNegetCheck.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AllNegetCheck.Location=new System.Drawing.Point(355, 19);
			this.AllNegetCheck.Name="AllNegetCheck";
			this.AllNegetCheck.Size=new System.Drawing.Size(326, 23);
			this.AllNegetCheck.TabIndex=2;
			this.AllNegetCheck.Text="همه موارد";
			this.AllNegetCheck.ThreeState=true;
			this.AllNegetCheck.UseVisualStyleBackColor=false;
			//
			//PosetiveBox
			//
			this.PosetiveBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.PosetiveBox.BorderStyle=BorderStyle.FixedSingle;
			this.PosetiveBox.CheckOnClick=true;
			this.PosetiveBox.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PosetiveBox.FormattingEnabled=true;
			this.PosetiveBox.Location=new System.Drawing.Point(13, 42);
			this.PosetiveBox.Name="PosetiveBox";
			this.PosetiveBox.Size=new System.Drawing.Size(328, 104);
			this.PosetiveBox.TabIndex=3;
			//
			//NegetiveBox
			//
			this.NegetiveBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.NegetiveBox.BorderStyle=BorderStyle.FixedSingle;
			this.NegetiveBox.CheckOnClick=true;
			this.NegetiveBox.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NegetiveBox.ForeColor=System.Drawing.Color.Black;
			this.NegetiveBox.FormattingEnabled=true;
			this.NegetiveBox.Location=new System.Drawing.Point(354, 42);
			this.NegetiveBox.Name="NegetiveBox";
			this.NegetiveBox.Size=new System.Drawing.Size(328, 104);
			this.NegetiveBox.TabIndex=1;
			//
			//ShowGridView
			//
			this.ShowGridView.AllowUserToAddRows=false;
			this.ShowGridView.AllowUserToDeleteRows=false;
			this.ShowGridView.AllowUserToResizeColumns=false;
			this.ShowGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
			this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column8, this.Column1, this.Column7, this.Column2, this.Column5, this.Column6, this.Column3, this.Column4});
			this.ShowGridView.EnableHeadersVisualStyles=false;
			this.ShowGridView.Location=new System.Drawing.Point(13, 182);
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
			this.ShowGridView.Size=new System.Drawing.Size(1143, 423);
			this.ShowGridView.TabIndex=6;
			//
			//Column8
			//
			this.Column8.HeaderText="ردیف";
			this.Column8.Name="Column8";
			this.Column8.ReadOnly=true;
			this.Column8.Width=40;
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
			this.Column7.Width=115;
			//
			//Column2
			//
			this.Column2.HeaderText="شماره پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=60;
			//
			//Column5
			//
			this.Column5.HeaderText="شیفت";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=80;
			//
			//Column6
			//
			this.Column6.HeaderText="مبدا";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=80;
			//
			//Column3
			//
			this.Column3.HeaderText="امتیاز";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=60;
			//
			//Column4
			//
			this.Column4.HeaderText="مجموع تعداد امتیاز";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=70;
			//
			//ExportButton
			//
			this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
			this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
			this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportButton.Cursor=Cursors.Hand;
			this.ExportButton.Location=new System.Drawing.Point(45, 113);
			this.ExportButton.Name="ExportButton";
			this.ExportButton.Size=new System.Drawing.Size(137, 34);
			this.ExportButton.TabIndex=4;
			this.ExportButton.Text="ذخیره";
			this.ExportButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.UserCombo);
			this.Panel1.Controls.Add(this.ExportButton);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Location=new System.Drawing.Point(719, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(437, 158);
			this.Panel1.TabIndex=0;
			//
			//LocalCombo
			//
			this.LocalCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(215, 36);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(145, 24);
			this.LocalCombo.TabIndex=52;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(8, 37);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(128, 23);
			this.EndCalendar.TabIndex=55;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftCombo
			//
			this.ShiftCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(8, 67);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(128, 24);
			this.ShiftCombo.TabIndex=54;
			//
			//TimeCombo
			//
			this.TimeCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
			this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(215, 67);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(145, 24);
			this.TimeCombo.TabIndex=53;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(8, 7);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(128, 23);
			this.StartCalendar.TabIndex=54;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Location=new System.Drawing.Point(360, 40);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(35, 16);
			this.Label18.TabIndex=57;
			this.Label18.Text="مبدا:";
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.ForeColor=System.Drawing.Color.Black;
			this.Label8.Location=new System.Drawing.Point(70, 95);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(293, 16);
			this.Label8.TabIndex=41;
			this.Label8.Text="---------------------------------------------------------";
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(360, 71);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(72, 16);
			this.Label17.TabIndex=56;
			this.Label17.Text="نوع شیفت:";
			//
			//UserCombo
			//
			this.UserCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.UserCombo.FormattingEnabled=true;
			this.UserCombo.Location=new System.Drawing.Point(215, 6);
			this.UserCombo.Name="UserCombo";
			this.UserCombo.Size=new System.Drawing.Size(145, 24);
			this.UserCombo.TabIndex=39;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Location=new System.Drawing.Point(136, 71);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(70, 16);
			this.Label13.TabIndex=55;
			this.Label13.Text="نام شیفت:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(360, 10);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(57, 16);
			this.Label6.TabIndex=40;
			this.Label6.Text="نام کاربر:";
			//
			//Panel2
			//
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.AllPosetCheck);
			this.Panel2.Controls.Add(this.AllNegetCheck);
			this.Panel2.Controls.Add(this.NegetiveBox);
			this.Panel2.Controls.Add(this.PosetiveBox);
			this.Panel2.Location=new System.Drawing.Point(13, 12);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(696, 158);
			this.Panel2.TabIndex=1;
			//
			//Label4
			//
			this.Label4.BackColor=System.Drawing.Color.Lime;
			this.Label4.BorderStyle=BorderStyle.FixedSingle;
			this.Label4.Location=new System.Drawing.Point(25, 5);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(77, 25);
			this.Label4.TabIndex=9;
			this.Label4.Text="موارد مثبت";
			//
			//Label1
			//
			this.Label1.BackColor=System.Drawing.Color.Orange;
			this.Label1.BorderStyle=BorderStyle.FixedSingle;
			this.Label1.Location=new System.Drawing.Point(369, 5);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(77, 25);
			this.Label1.TabIndex=8;
			this.Label1.Text="موارد منفی";
			//
			//ManageFunctionReportForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize=new System.Drawing.Size(1169, 618);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.ShowGridView);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ManageFunctionReportForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="گزارش دوره ای امتیازات ثبت شده";
			((System.ComponentModel.ISupportInitialize) this.ShowGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private Button ShowButton;
		private Label Label2;
		private Label Label3;
		private CheckedListBox NegetiveBox;
		private CheckedListBox PosetiveBox;
		private DataGridView ShowGridView;
		private Button ExportButton;
		private CheckBox AllPosetCheck;
		private CheckBox AllNegetCheck;
		private Panel Panel1;
		private Panel Panel2;
		private Label Label4;
		private Label Label1;
		private ComboBox UserCombo;
		private Label Label6;
		private Label Label8;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private ComboBox LocalCombo;
		private ComboBox ShiftCombo;
		private ComboBox TimeCombo;
		private Label Label18;
		private Label Label17;
		private Label Label13;
	}
	
}
