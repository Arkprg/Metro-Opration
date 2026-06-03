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
	partial class OverTimeGroupForm : BaseForm
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
			this.FormClosing += new FormClosingEventHandler(ManageOverTimeForm_FormClosing);
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(OverTimeGroupForm_HelpButtonClicked);
			base.Load += new System.EventHandler(ManageOverTimeForm_Load);
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.Label4=new Label();
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label3=new Label();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label2=new Label();
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.Label1=new Label();
			this.KindOverCombo=new ComboBox();
			this.Label8=new Label();
			this.MemoBox=new RichTextBox();
			this.TimeBox=new MaskedTextBox();
			this.Label7=new Label();
			this.Label5=new Label();
			this.Label6=new Label();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.AllPosetCheck=new CheckBox();
			this.AllPosetCheck.CheckedChanged += new System.EventHandler(this.AllPosetCheck_CheckedChanged);
			this.PersonListBox=new CheckedListBox();
			this.PersonListBox.SelectedIndexChanged += new System.EventHandler(this.PosetiveBox_SelectedIndexChanged);
			this.Panel1=new Panel();
			this.Panel2=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Panel3=new Panel();
			this.Panel4=new Panel();
			this.CountLabel=new Label();
			this.Label9=new Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.SuspendLayout();
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Location=new System.Drawing.Point(13, 22);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(113, 61);
			this.ShowButton.TabIndex=5;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(134, 62);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(90, 24);
			this.ShiftCombo.TabIndex=4;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(224, 66);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(70, 16);
			this.Label4.TabIndex=6;
			this.Label4.Text="نام شیفت:";
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(134, 20);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(90, 24);
			this.TimeCombo.TabIndex=3;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(224, 24);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(72, 16);
			this.Label3.TabIndex=4;
			this.Label3.Text="نوع شیفت:";
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(305, 20);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(170, 24);
			this.LocalCombo.TabIndex=2;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(476, 24);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(35, 16);
			this.Label2.TabIndex=2;
			this.Label2.Text="مبدا:";
			//
			//PostCombo
			//
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(305, 62);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(170, 24);
			this.PostCombo.TabIndex=1;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(476, 66);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(43, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="پست:";
			//
			//KindOverCombo
			//
			this.KindOverCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindOverCombo.FormattingEnabled=true;
			this.KindOverCombo.Items.AddRange(new object[] {"کلاس آموزشی", "همکاری با شیفت"});
			this.KindOverCombo.Location=new System.Drawing.Point(114, 21);
			this.KindOverCombo.Name="KindOverCombo";
			this.KindOverCombo.Size=new System.Drawing.Size(155, 24);
			this.KindOverCombo.Sorted=true;
			this.KindOverCombo.TabIndex=2;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(457, 74);
			this.Label8.Margin=new Padding(4, 0, 4, 0);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(62, 16);
			this.Label8.TabIndex=49;
			this.Label8.Text="توضیحات:";
			//
			//MemoBox
			//
			this.MemoBox.Location=new System.Drawing.Point(13, 69);
			this.MemoBox.Margin=new Padding(4, 5, 4, 5);
			this.MemoBox.MaxLength=200;
			this.MemoBox.Name="MemoBox";
			this.MemoBox.Size=new System.Drawing.Size(443, 26);
			this.MemoBox.TabIndex=4;
			this.MemoBox.Text="";
			//
			//TimeBox
			//
			this.TimeBox.BackColor=System.Drawing.Color.White;
			this.TimeBox.Location=new System.Drawing.Point(13, 22);
			this.TimeBox.Mask="00:00";
			this.TimeBox.Name="TimeBox";
			this.TimeBox.Size=new System.Drawing.Size(50, 23);
			this.TimeBox.TabIndex=3;
			this.TimeBox.TextAlign=HorizontalAlignment.Center;
			this.TimeBox.ValidatingType=typeof(DateTime);
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(63, 25);
			this.Label7.Margin=new Padding(4, 0, 4, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(38, 16);
			this.Label7.TabIndex=47;
			this.Label7.Text="مدت:";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Location=new System.Drawing.Point(457, 25);
			this.Label5.Margin=new Padding(4, 0, 4, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(39, 16);
			this.Label5.TabIndex=45;
			this.Label5.Text="تاریخ:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(269, 25);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(44, 16);
			this.Label6.TabIndex=38;
			this.Label6.Text="عنوان:";
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(23, 16);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(127, 34);
			this.ExitButton.TabIndex=2;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(262, 16);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(217, 34);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//AllPosetCheck
			//
			this.AllPosetCheck.BackColor=System.Drawing.Color.Black;
			this.AllPosetCheck.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AllPosetCheck.ForeColor=System.Drawing.Color.White;
			this.AllPosetCheck.Location=new System.Drawing.Point(6, 8);
			this.AllPosetCheck.Name="AllPosetCheck";
			this.AllPosetCheck.Size=new System.Drawing.Size(286, 23);
			this.AllPosetCheck.TabIndex=9;
			this.AllPosetCheck.Text="همه موارد";
			this.AllPosetCheck.ThreeState=true;
			this.AllPosetCheck.UseVisualStyleBackColor=false;
			//
			//PersonListBox
			//
			this.PersonListBox.BackColor=System.Drawing.Color.Honeydew;
			this.PersonListBox.BorderStyle=BorderStyle.FixedSingle;
			this.PersonListBox.CheckOnClick=true;
			this.PersonListBox.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PersonListBox.FormattingEnabled=true;
			this.PersonListBox.Location=new System.Drawing.Point(6, 31);
			this.PersonListBox.Name="PersonListBox";
			this.PersonListBox.Size=new System.Drawing.Size(286, 254);
			this.PersonListBox.Sorted=true;
			this.PersonListBox.TabIndex=8;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Location=new System.Drawing.Point(320, 22);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(526, 107);
			this.Panel1.TabIndex=0;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.PersianCalendar);
			this.Panel2.Controls.Add(this.KindOverCombo);
			this.Panel2.Controls.Add(this.MemoBox);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Controls.Add(this.TimeBox);
			this.Panel2.Location=new System.Drawing.Point(320, 142);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(526, 115);
			this.Panel2.TabIndex=1;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(330, 22);
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
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Location=new System.Drawing.Point(320, 272);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(526, 70);
			this.Panel3.TabIndex=122;
			//
			//Panel4
			//
			this.Panel4.BorderStyle=BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.CountLabel);
			this.Panel4.Controls.Add(this.Label9);
			this.Panel4.Controls.Add(this.AllPosetCheck);
			this.Panel4.Controls.Add(this.PersonListBox);
			this.Panel4.Location=new System.Drawing.Point(7, 22);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(300, 321);
			this.Panel4.TabIndex=13;
			//
			//CountLabel
			//
			this.CountLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CountLabel.Location=new System.Drawing.Point(35, 294);
			this.CountLabel.Margin=new Padding(4, 0, 4, 0);
			this.CountLabel.Name="CountLabel";
			this.CountLabel.Size=new System.Drawing.Size(109, 18);
			this.CountLabel.TabIndex=50;
			this.CountLabel.Text="0";
			//
			//Label9
			//
			this.Label9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label9.Location=new System.Drawing.Point(144, 294);
			this.Label9.Margin=new Padding(4, 0, 4, 0);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(142, 18);
			this.Label9.TabIndex=50;
			this.Label9.Text="مجموع انتخاب شده ها:";
			//
			//OverTimeGroupForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(854, 355);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel4);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="OverTimeGroupForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت اضافه کار گروهی ";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private ComboBox PostCombo;
		private Label Label1;
		private ComboBox TimeCombo;
		private Label Label3;
		private ComboBox LocalCombo;
		private Label Label2;
		private ComboBox ShiftCombo;
		private Label Label4;
		private Label Label6;
		private ComboBox KindOverCombo;
		private Label Label5;
		private MaskedTextBox TimeBox;
		private Label Label7;
		private Label Label8;
		private RichTextBox MemoBox;
		private Button ExitButton;
		private Button RegButton;
		private Button ShowButton;
		private CheckBox AllPosetCheck;
		private CheckedListBox PersonListBox;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Panel Panel4;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private Label CountLabel;
		private Label Label9;
	}
	
}
