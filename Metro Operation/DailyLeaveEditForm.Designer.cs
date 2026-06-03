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
		public partial class DailyLeaveEditForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(DailyLeaveEditForm_HelpButtonClicked);
			base.Load += new System.EventHandler(Form35_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(DailyLeaveEditForm));
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.ReleaseBox=new TextBox();
			this.ReleaseNameButton=new Button();
			this.ReleaseNameButton.Click += new System.EventHandler(this.ReleaseNameButton_Click);
			this.Label7=new Label();
			this.ShiftNameLabel=new Label();
			this.Label5=new Label();
			this.SearchButton=new Button();
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			this.KindCombo=new ComboBox();
			this.Label2=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.DeleButton=new Button();
			this.DeleButton.Click += new System.EventHandler(this.DeleButton_Click);
			this.Label3=new Label();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label1=new Label();
			this.NameBox=new TextBox();
			this.Panel1=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
			this.Panel2=new Panel();
			this.Label8=new Label();
			this.Panel3=new Panel();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//ExitButton
			//
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(14, 11);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(85, 34);
			this.ExitButton.TabIndex=3;
			this.ExitButton.Text="    انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//ReleaseBox
			//
			this.ReleaseBox.BackColor=System.Drawing.SystemColors.Window;
			this.ReleaseBox.Location=new System.Drawing.Point(92, 121);
			this.ReleaseBox.Name="ReleaseBox";
			this.ReleaseBox.ReadOnly=true;
			this.ReleaseBox.Size=new System.Drawing.Size(156, 23);
			this.ReleaseBox.TabIndex=6;
			this.ReleaseBox.TabStop=false;
			this.ReleaseBox.Visible=false;
			//
			//ReleaseNameButton
			//
			this.ReleaseNameButton.Image=(System.Drawing.Image) (resources.GetObject("ReleaseNameButton.Image"));
			this.ReleaseNameButton.Location=new System.Drawing.Point(60, 120);
			this.ReleaseNameButton.Name="ReleaseNameButton";
			this.ReleaseNameButton.Size=new System.Drawing.Size(30, 25);
			this.ReleaseNameButton.TabIndex=2;
			this.ReleaseNameButton.UseVisualStyleBackColor=true;
			this.ReleaseNameButton.Visible=false;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(247, 124);
			this.Label7.Margin=new Padding(4, 0, 4, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(76, 16);
			this.Label7.TabIndex=22;
			this.Label7.Text="نام جایگزین:";
			this.Label7.Visible=false;
			//
			//ShiftNameLabel
			//
			this.ShiftNameLabel.ForeColor=System.Drawing.Color.Maroon;
			this.ShiftNameLabel.Location=new System.Drawing.Point(25, 29);
			this.ShiftNameLabel.Name="ShiftNameLabel";
			this.ShiftNameLabel.RightToLeft=RightToLeft.Yes;
			this.ShiftNameLabel.Size=new System.Drawing.Size(223, 23);
			this.ShiftNameLabel.TabIndex=4;
			this.ShiftNameLabel.Text="-------------------";
			this.ShiftNameLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(247, 32);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(98, 16);
			this.Label5.TabIndex=3;
			this.Label5.Text="شیفت مرخصی:";
			//
			//SearchButton
			//
			this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.SearchButton.Cursor=Cursors.Hand;
			
			this.SearchButton.Location=new System.Drawing.Point(15, 17);
			this.SearchButton.Margin=new Padding(4, 5, 4, 5);
			this.SearchButton.Name="SearchButton";
			this.SearchButton.Size=new System.Drawing.Size(123, 59);
			this.SearchButton.TabIndex=2;
			this.SearchButton.Text="جستجو";
			this.SearchButton.UseVisualStyleBackColor=false;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Location=new System.Drawing.Point(62, 88);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(186, 24);
			this.KindCombo.TabIndex=1;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(247, 92);
			this.Label2.Margin=new Padding(4, 0, 4, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(79, 16);
			this.Label2.TabIndex=27;
			this.Label2.Text="نوع مرخصی:";
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(238, 11);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(119, 34);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//DeleButton
			//
			this.DeleButton.BackColor=System.Drawing.Color.Tomato;
			this.DeleButton.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
			this.DeleButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.DeleButton.Cursor=Cursors.Hand;
			
			this.DeleButton.Location=new System.Drawing.Point(113, 11);
			this.DeleButton.Margin=new Padding(4, 5, 4, 5);
			this.DeleButton.Name="DeleButton";
			this.DeleButton.Size=new System.Drawing.Size(117, 34);
			this.DeleButton.TabIndex=2;
			this.DeleButton.Text="حذف";
			this.DeleButton.UseVisualStyleBackColor=false;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(322, 56);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(43, 16);
			this.Label3.TabIndex=45;
			this.Label3.Text="تاریخ :";
			//
			//NameButton
			//
			this.NameButton.Image=(System.Drawing.Image) (resources.GetObject("NameButton.Image"));
			this.NameButton.Location=new System.Drawing.Point(156, 17);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=0;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(322, 21);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(29, 16);
			this.Label1.TabIndex=43;
			this.Label1.Text="نام:";
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(183, 18);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(138, 23);
			this.NameBox.TabIndex=1;
			this.NameBox.TabStop=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PersianCalendar);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.SearchButton);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(11, 11);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(373, 100);
			this.Panel1.TabIndex=0;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(156, 53);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=false;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(164, 23);
			this.PersianCalendar.TabIndex=1;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.ReleaseNameButton);
			this.Panel2.Controls.Add(this.KindCombo);
			this.Panel2.Controls.Add(this.ReleaseBox);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.ShiftNameLabel);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Location=new System.Drawing.Point(11, 131);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(373, 191);
			this.Panel2.TabIndex=1;
			//
			//Label8
			//
			this.Label8.BackColor=System.Drawing.Color.Gray;
			this.Label8.BorderStyle=BorderStyle.FixedSingle;
			this.Label8.ForeColor=System.Drawing.Color.White;
			this.Label8.Location=new System.Drawing.Point(304, 119);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(68, 24);
			this.Label8.TabIndex=53;
			this.Label8.Text="مشخصات ";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Controls.Add(this.DeleButton);
			this.Panel3.Location=new System.Drawing.Point(12, 342);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(373, 58);
			this.Panel3.TabIndex=2;
			//
			//DailyLeaveEditForm
			//
			this.AcceptButton=this.SearchButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(404, 412);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="DailyLeaveEditForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ویرایش مرخصی روزانه ثبت شده";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private Button ExitButton;
		private TextBox ReleaseBox;
		private Button ReleaseNameButton;
		private Label Label7;
		private Label ShiftNameLabel;
		private Label Label5;
		private Button SearchButton;
		private Button RegButton;
		private Button DeleButton;
		private Label Label3;
		private Button NameButton;
		private Label Label1;
		private TextBox NameBox;
		private ComboBox KindCombo;
		private Label Label2;
		private Panel Panel1;
		private Panel Panel2;
		private Label Label8;
		private Panel Panel3;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
	}
	
}
