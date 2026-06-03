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
	partial class ElectionPartyForm : BaseForm
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
			this.Panel2=new Panel();
			base.Load += new System.EventHandler(ElectionPartyForm_Load);
			this.Closing += new System.ComponentModel.CancelEventHandler(ElectionPartyForm_Closing);
			this.NumBox=new Label();
			this.Label2=new Label();
			this.EndCalendar=new Label();
			this.StartCalendar=new Label();
			this.Label17=new Label();
			this.Label4=new Label();
			this.TitrBox=new Label();
			this.Label5=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.CandidListBox=new CheckedListBox();
			this.Label1=new Label();
			this.Label3=new Label();
			this.MemText=new TextBox();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel2
			//
			this.Panel2.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.MemText);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.NumBox);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.EndCalendar);
			this.Panel2.Controls.Add(this.StartCalendar);
			this.Panel2.Controls.Add(this.Label17);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.TitrBox);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Location=new System.Drawing.Point(346, 34);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(275, 265);
			this.Panel2.TabIndex=3;
			this.Panel2.TabStop=true;
			//
			//NumBox
			//
			this.NumBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NumBox.Location=new System.Drawing.Point(58, 44);
			this.NumBox.Margin=new Padding(3);
			this.NumBox.Name="NumBox";
			this.NumBox.Size=new System.Drawing.Size(124, 20);
			this.NumBox.TabIndex=87;
			this.NumBox.Text="--";
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label2.Location=new System.Drawing.Point(188, 46);
			this.Label2.Margin=new Padding(3);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(79, 16);
			this.Label2.TabIndex=87;
			this.Label2.Text="تعداد انتخاب:";
			//
			//EndCalendar
			//
			this.EndCalendar.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.EndCalendar.Location=new System.Drawing.Point(58, 102);
			this.EndCalendar.Margin=new Padding(3);
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.Size=new System.Drawing.Size(124, 20);
			this.EndCalendar.TabIndex=80;
			this.EndCalendar.Text="--";
			//
			//StartCalendar
			//
			this.StartCalendar.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.StartCalendar.Location=new System.Drawing.Point(58, 73);
			this.StartCalendar.Margin=new Padding(3);
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.Size=new System.Drawing.Size(124, 20);
			this.StartCalendar.TabIndex=80;
			this.StartCalendar.Text="--";
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label17.Location=new System.Drawing.Point(188, 104);
			this.Label17.Margin=new Padding(3);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(68, 16);
			this.Label17.TabIndex=80;
			this.Label17.Text="تاریخ پایان:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(188, 75);
			this.Label4.Margin=new Padding(3);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(74, 16);
			this.Label4.TabIndex=80;
			this.Label4.Text="تاریخ شروع:";
			//
			//TitrBox
			//
			this.TitrBox.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TitrBox.Location=new System.Drawing.Point(58, 15);
			this.TitrBox.Margin=new Padding(3);
			this.TitrBox.Name="TitrBox";
			this.TitrBox.Size=new System.Drawing.Size(124, 20);
			this.TitrBox.TabIndex=87;
			this.TitrBox.Text="--";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.Location=new System.Drawing.Point(188, 17);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(44, 16);
			this.Label5.TabIndex=87;
			this.Label5.Text="عنوان:";
			//
			//RegButton
			//
			this.RegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.RegButton.FlatStyle=FlatStyle.Flat;
			this.RegButton.Location=new System.Drawing.Point(405, 314);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(156, 30);
			this.RegButton.TabIndex=4;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//CandidListBox
			//
			this.CandidListBox.CheckOnClick=true;
			this.CandidListBox.Font=new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CandidListBox.FormattingEnabled=true;
			this.CandidListBox.Location=new System.Drawing.Point(12, 34);
			this.CandidListBox.Name="CandidListBox";
			this.CandidListBox.Size=new System.Drawing.Size(318, 312);
			this.CandidListBox.TabIndex=5;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.Location=new System.Drawing.Point(235, 13);
			this.Label1.Margin=new Padding(3);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(95, 16);
			this.Label1.TabIndex=87;
			this.Label1.Text="اسامی نامزد ها";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.Location=new System.Drawing.Point(188, 133);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(62, 16);
			this.Label3.TabIndex=88;
			this.Label3.Text="توضیحات:";
			//
			//MemText
			//
			this.MemText.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
			this.MemText.BorderStyle=BorderStyle.None;
			this.MemText.Location=new System.Drawing.Point(6, 160);
			this.MemText.Multiline=true;
			this.MemText.Name="MemText";
			this.MemText.ReadOnly=true;
			this.MemText.ScrollBars=ScrollBars.Vertical;
			this.MemText.Size=new System.Drawing.Size(261, 100);
			this.MemText.TabIndex=89;
			this.MemText.TabStop=false;
			//
			//ElectionPartyForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ClientSize=new System.Drawing.Size(633, 358);
			this.Controls.Add(this.CandidListBox);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.RegButton);
			this.Controls.Add(this.Label1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ElectionPartyForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="شرکت در انتخابات";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		private Panel Panel2;
		private Label NumBox;
		private Label Label2;
		private Label EndCalendar;
		private Label StartCalendar;
		private Label Label17;
		private Label Label4;
		private Label TitrBox;
		private Label Label5;
		private Button RegButton;
		private CheckedListBox CandidListBox;
		private Label Label1;
		private Label Label3;
		private TextBox MemText;
	}
	
}
