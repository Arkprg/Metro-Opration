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
		public partial class ReserveEmergencyForm : BaseForm
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
			base.Load += new System.EventHandler(ReserveEmergencyForm_Load);
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(EmergencyReserveForm_HelpButtonClicked);
			this.NameBox=new TextBox();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.Button5_Click);
			this.Label1=new Label();
			this.PointLabel=new Label();
			this.Label4=new Label();
			this.MemBox=new RichTextBox();
			this.Label2=new Label();
			this.Label3=new Label();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegisterButton=new Button();
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			this.Panel1=new Panel();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.Label5=new Label();
			this.Panel2=new Panel();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NameBox.Location=new System.Drawing.Point(283, 21);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(137, 23);
			this.NameBox.TabIndex=36;
			//
			//NameButton
			//
			this.NameButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(253, 20);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label1
			//
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.Location=new System.Drawing.Point(419, 21);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(73, 22);
			this.Label1.TabIndex=35;
			this.Label1.Text="نام پرسنل:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//PointLabel
			//
			this.PointLabel.AutoSize=true;
			this.PointLabel.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PointLabel.ForeColor=System.Drawing.Color.DarkRed;
			this.PointLabel.Location=new System.Drawing.Point(16, 112);
			this.PointLabel.Margin=new Padding(4, 0, 4, 0);
			this.PointLabel.Name="PointLabel";
			this.PointLabel.Size=new System.Drawing.Size(200, 16);
			this.PointLabel.TabIndex=50;
			this.PointLabel.Text="ارائه توضیحات تکمیلی الزامی است";
			this.PointLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(422, 112);
			this.Label4.Margin=new Padding(4, 0, 4, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(62, 16);
			this.Label4.TabIndex=49;
			this.Label4.Text="توضیحات:";
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.White;
			this.MemBox.BorderStyle=BorderStyle.FixedSingle;
			this.MemBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MemBox.Location=new System.Drawing.Point(13, 135);
			this.MemBox.Margin=new Padding(4, 5, 4, 5);
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(475, 50);
			this.MemBox.TabIndex=4;
			this.MemBox.Text="";
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label2.Location=new System.Drawing.Point(167, 66);
			this.Label2.Margin=new Padding(5, 0, 5, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(51, 16);
			this.Label2.TabIndex=45;
			this.Label2.Text="تا تاریخ:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.Location=new System.Drawing.Point(419, 66);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(51, 16);
			this.Label3.TabIndex=44;
			this.Label3.Text="از تاریخ:";
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ExitButton.Location=new System.Drawing.Point(12, 8);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(107, 34);
			this.ExitButton.TabIndex=6;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//RegisterButton
			//
			this.RegisterButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegisterButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegisterButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegisterButton.Cursor=Cursors.Hand;
			this.RegisterButton.DialogResult=DialogResult.None;
			this.RegisterButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RegisterButton.Location=new System.Drawing.Point(266, 8);
			this.RegisterButton.Margin=new Padding(4, 5, 4, 5);
			this.RegisterButton.Name="RegisterButton";
			this.RegisterButton.Size=new System.Drawing.Size(211, 34);
			this.RegisterButton.TabIndex=5;
			this.RegisterButton.Text="ذخیره";
			this.RegisterButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.MemBox);
			this.Panel1.Controls.Add(this.PointLabel);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Panel1.Location=new System.Drawing.Point(13, 13);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(504, 198);
			this.Panel1.TabIndex=0;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(31, 63);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(137, 23);
			this.EndCalendar.TabIndex=55;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(283, 63);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(137, 23);
			this.StartCalendar.TabIndex=54;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"غیر فعال"});
			this.KindCombo.Location=new System.Drawing.Point(31, 20);
			this.KindCombo.Margin=new Padding(4, 5, 4, 5);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(137, 24);
			this.KindCombo.TabIndex=52;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.ForeColor=System.Drawing.Color.Black;
			this.Label5.Location=new System.Drawing.Point(167, 24);
			this.Label5.Margin=new Padding(5, 0, 5, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(44, 16);
			this.Label5.TabIndex=51;
			this.Label5.Text="عنوان:";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.RegisterButton);
			this.Panel2.Controls.Add(this.ExitButton);
			this.Panel2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Panel2.Location=new System.Drawing.Point(13, 227);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(504, 51);
			this.Panel2.TabIndex=1;
			//
			//ReserveEmergencyForm
			//
			this.AcceptButton=this.RegisterButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.ClientSize=new System.Drawing.Size(526, 290);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ReserveEmergencyForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="حذف راهبران از لوحه";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private TextBox NameBox;
		private Button NameButton;
		private Label Label1;
		private Label Label4;
		private RichTextBox MemBox;
		private Label Label2;
		private Label Label3;
		private Label PointLabel;
		private Button ExitButton;
		private Button RegisterButton;
		private Panel Panel1;
		private Panel Panel2;
		private ComboBox KindCombo;
		private Label Label5;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
	}
	
}
