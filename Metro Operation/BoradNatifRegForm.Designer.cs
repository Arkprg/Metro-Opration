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
	partial class BoradNatifRegForm : BaseForm
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
			this.components=new System.ComponentModel.Container();
			base.Load += new System.EventHandler(BoradNatifRegForm_Load);
			this.HtmlEditControl1=new Zoople.HTMLEditControl();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Label10=new Label();
			this.Label4=new Label();
			this.Panel3=new Panel();
			this.TitrBox=new TextBox();
			this.Label5=new Label();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//HtmlEditControl1
			//
			this.HtmlEditControl1.AllowDragInternal=true;
			this.HtmlEditControl1.BaseURL=null;
			this.HtmlEditControl1.BorderStyle=BorderStyle.FixedSingle;
			this.HtmlEditControl1.CleanMSWordHTMLOnPaste=true;
			this.HtmlEditControl1.CSSText=null;
			this.HtmlEditControl1.DocumentHTML="";
			this.HtmlEditControl1.EditingDisabled=false;
			this.HtmlEditControl1.FontsList=null;
			this.HtmlEditControl1.HiddenButtons=null;
			this.HtmlEditControl1.ImageStorageLocation=null;
			this.HtmlEditControl1.InCodeView=false;
			this.HtmlEditControl1.LanguageFile=null;
			this.HtmlEditControl1.LicenceKey="KPH0011-6738-B67";
			this.HtmlEditControl1.Location=new System.Drawing.Point(12, 112);
			this.HtmlEditControl1.Margin=new Padding(3, 4, 3, 4);
			this.HtmlEditControl1.Name="HtmlEditControl1";
			this.HtmlEditControl1.Size=new System.Drawing.Size(918, 442);
			this.HtmlEditControl1.TabIndex=0;
			this.HtmlEditControl1.ToolstripImageScalingSize=new System.Drawing.Size(16, 16);
			this.HtmlEditControl1.UseParagraphAsDefault=false;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(249, 53);
			this.EndCalendar.Margin=new Padding(3, 4, 3, 4);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(121, 23);
			this.EndCalendar.TabIndex=82;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(249, 13);
			this.StartCalendar.Margin=new Padding(3, 4, 3, 4);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(121, 23);
			this.StartCalendar.TabIndex=81;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label10.Location=new System.Drawing.Point(369, 56);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(109, 16);
			this.Label10.TabIndex=83;
			this.Label10.Text="تاریخ پایان نمایش:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(369, 16);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(115, 16);
			this.Label4.TabIndex=84;
			this.Label4.Text="تاریخ شروع نمایش:";
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.Transparent;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.TitrBox);
			this.Panel3.Controls.Add(this.Label5);
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Controls.Add(this.EndCalendar);
			this.Panel3.Controls.Add(this.StartCalendar);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Controls.Add(this.Label10);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Location=new System.Drawing.Point(12, 13);
			this.Panel3.Margin=new Padding(3, 4, 3, 4);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(918, 91);
			this.Panel3.TabIndex=85;
			//
			//TitrBox
			//
			this.TitrBox.BackColor=System.Drawing.Color.White;
			this.TitrBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TitrBox.Location=new System.Drawing.Point(614, 32);
			this.TitrBox.MaxLength=150;
			this.TitrBox.Name="TitrBox";
			this.TitrBox.Size=new System.Drawing.Size(146, 23);
			this.TitrBox.TabIndex=88;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.Location=new System.Drawing.Point(759, 35);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(89, 16);
			this.Label5.TabIndex=89;
			this.Label5.Text="عنوان اطلاعیه:";
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.Location=new System.Drawing.Point(8, 47);
			this.ExitButton.Margin=new Padding(5, 6, 5, 6);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(130, 34);
			this.ExitButton.TabIndex=3;
			this.ExitButton.Text="    انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(8, 7);
			this.RegButton.Margin=new Padding(5, 6, 5, 6);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(130, 34);
			this.RegButton.TabIndex=2;
			this.RegButton.Text="ثبت";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//BoradNatifRegForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize=new System.Drawing.Size(942, 561);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.HtmlEditControl1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedSingle;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="BoradNatifRegForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت اطلاعیه در برد الکترونیک";
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private Label Label10;
		private Label Label4;
		private Panel Panel3;
		private Button ExitButton;
		private Button RegButton;
		private TextBox TitrBox;
		private Label Label5;
		private Zoople.HTMLEditControl HtmlEditControl1;
	}
	
}
