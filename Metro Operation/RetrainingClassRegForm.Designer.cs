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
	public partial class RetrainingClassRegForm : BaseForm
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
			base.Load += new System.EventHandler(RetrainingClassRegForm_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			this.Panel1=new Panel();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.ShiftCombo=new ComboBox();
			this.Label1=new Label();
			this.Label4=new Label();
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label2=new Label();
			this.Label3=new Label();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.PosetiveBox=new CheckedListBox();
			this.PosetiveBox.SelectedIndexChanged += new System.EventHandler(this.PosetiveBox_SelectedIndexChanged);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.Panel2=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.ClassKindCombo=new ComboBox();
			this.ClassLocalCombo=new ComboBox();
			this.TimeBox=new MaskedTextBox();
			this.AllPosetCheck=new CheckBox();
			this.AllPosetCheck.CheckedChanged += new System.EventHandler(this.AllPosetCheck_CheckedChanged);
			this.Label8=new Label();
			this.Label6=new Label();
			this.Label5=new Label();
			this.Label7=new Label();
			this.DataGridView1=new DataGridView();
			this.Column8=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Location=new System.Drawing.Point(10, 11);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(675, 71);
			this.Panel1.TabIndex=0;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Location=new System.Drawing.Point(9, 7);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(134, 54);
			this.ShowButton.TabIndex=4;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(196, 37);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(118, 24);
			this.ShiftCombo.TabIndex=3;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(599, 41);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(43, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="پست:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(315, 41);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(70, 16);
			this.Label4.TabIndex=6;
			this.Label4.Text="نام شیفت:";
			//
			//PostCombo
			//
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(411, 37);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(188, 24);
			this.PostCombo.TabIndex=0;
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(196, 7);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(118, 24);
			this.TimeCombo.TabIndex=2;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(599, 11);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(35, 16);
			this.Label2.TabIndex=2;
			this.Label2.Text="مبدا:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(315, 11);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(72, 16);
			this.Label3.TabIndex=4;
			this.Label3.Text="نوع شیفت:";
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(411, 7);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(188, 24);
			this.LocalCombo.TabIndex=1;
			//
			//PosetiveBox
			//
			this.PosetiveBox.BackColor=System.Drawing.Color.White;
			this.PosetiveBox.BorderStyle=BorderStyle.FixedSingle;
			this.PosetiveBox.CheckOnClick=true;
			this.PosetiveBox.FormattingEnabled=true;
			this.PosetiveBox.Location=new System.Drawing.Point(9, 32);
			this.PosetiveBox.Name="PosetiveBox";
			this.PosetiveBox.Size=new System.Drawing.Size(349, 146);
			this.PosetiveBox.Sorted=true;
			this.PosetiveBox.TabIndex=6;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.ForeColor=System.Drawing.Color.Black;
			this.RegButton.Location=new System.Drawing.Point(384, 145);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(279, 34);
			this.RegButton.TabIndex=7;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.PersianCalendar);
			this.Panel2.Controls.Add(this.ClassKindCombo);
			this.Panel2.Controls.Add(this.ClassLocalCombo);
			this.Panel2.Controls.Add(this.TimeBox);
			this.Panel2.Controls.Add(this.AllPosetCheck);
			this.Panel2.Controls.Add(this.RegButton);
			this.Panel2.Controls.Add(this.PosetiveBox);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Location=new System.Drawing.Point(10, 94);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(675, 190);
			this.Panel2.TabIndex=1;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(446, 12);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
			this.PersianCalendar.TabIndex=98;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//ClassKindCombo
			//
			this.ClassKindCombo.FormattingEnabled=true;
			this.ClassKindCombo.Location=new System.Drawing.Point(384, 73);
			this.ClassKindCombo.Name="ClassKindCombo";
			this.ClassKindCombo.Size=new System.Drawing.Size(187, 24);
			this.ClassKindCombo.Sorted=true;
			this.ClassKindCombo.TabIndex=3;
			//
			//ClassLocalCombo
			//
			this.ClassLocalCombo.FormattingEnabled=true;
			this.ClassLocalCombo.Location=new System.Drawing.Point(384, 105);
			this.ClassLocalCombo.Name="ClassLocalCombo";
			this.ClassLocalCombo.Size=new System.Drawing.Size(187, 24);
			this.ClassLocalCombo.Sorted=true;
			this.ClassLocalCombo.TabIndex=2;
			//
			//TimeBox
			//
			this.TimeBox.BackColor=System.Drawing.Color.White;
			this.TimeBox.Location=new System.Drawing.Point(521, 42);
			this.TimeBox.Mask="00:00";
			this.TimeBox.Name="TimeBox";
			this.TimeBox.Size=new System.Drawing.Size(50, 23);
			this.TimeBox.TabIndex=2;
			this.TimeBox.TextAlign=HorizontalAlignment.Center;
			this.TimeBox.ValidatingType=typeof(DateTime);
			//
			//AllPosetCheck
			//
			this.AllPosetCheck.BackColor=System.Drawing.Color.Silver;
			this.AllPosetCheck.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AllPosetCheck.Location=new System.Drawing.Point(9, 12);
			this.AllPosetCheck.Name="AllPosetCheck";
			this.AllPosetCheck.Padding=new Padding(0, 0, 1, 0);
			this.AllPosetCheck.Size=new System.Drawing.Size(349, 20);
			this.AllPosetCheck.TabIndex=5;
			this.AllPosetCheck.Text="همه موارد";
			this.AllPosetCheck.TextAlign=System.Drawing.ContentAlignment.TopLeft;
			this.AllPosetCheck.ThreeState=true;
			this.AllPosetCheck.UseVisualStyleBackColor=false;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(572, 78);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(44, 16);
			this.Label8.TabIndex=38;
			this.Label8.Text="عنوان:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(572, 110);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(83, 16);
			this.Label6.TabIndex=38;
			this.Label6.Text="محل برگذاری:";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(572, 15);
			this.Label5.Margin=new Padding(4, 0, 4, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(39, 16);
			this.Label5.TabIndex=45;
			this.Label5.Text="تاریخ:";
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(572, 46);
			this.Label7.Margin=new Padding(4, 0, 4, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(85, 16);
			this.Label7.TabIndex=47;
			this.Label7.Text="ساعت شروع:";
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
			this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.DataGridView1.ColumnHeadersHeight=40;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column8, this.Column1, this.Column7, this.Column2, this.Column6, this.Column4, this.Column3});
			this.DataGridView1.EnableHeadersVisualStyles=false;
			this.DataGridView1.Location=new System.Drawing.Point(10, 293);
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
			this.DataGridView1.Size=new System.Drawing.Size(675, 268);
			this.DataGridView1.TabIndex=34;
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
			this.Column7.Width=105;
			//
			//Column2
			//
			this.Column2.HeaderText="ش پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=80;
			//
			//Column6
			//
			this.Column6.HeaderText="تاریخ";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=80;
			//
			//Column4
			//
			this.Column4.HeaderText="عنوان دوره";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=125;
			//
			//Column3
			//
			this.Column3.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText="ساعت و محل برگذاری";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			//
			//RetrainingClassRegForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.ClientSize=new System.Drawing.Size(696, 573);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="RetrainingClassRegForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت کلاس های بازآموزی";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		private Panel Panel1;
		private Button ShowButton;
		private ComboBox ShiftCombo;
		private Label Label1;
		private Label Label4;
		private ComboBox PostCombo;
		private ComboBox TimeCombo;
		private Label Label2;
		private Label Label3;
		private ComboBox LocalCombo;
		private CheckedListBox PosetiveBox;
		private Button RegButton;
		private Panel Panel2;
		private ComboBox ClassLocalCombo;
		private Label Label6;
		private Label Label5;
		private Label Label7;
		private MaskedTextBox TimeBox;
		private CheckBox AllPosetCheck;
		private ComboBox ClassKindCombo;
		private Label Label8;
		private DataGridView DataGridView1;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column3;
	}
	
}
