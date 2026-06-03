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
	partial class PermisionEditForm : BaseForm
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
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label1=new Label();
			this.NameBox=new TextBox();
			this.OverTimeCombo=new ComboBox();
			this.Label4=new Label();
			this.ReservCombo=new ComboBox();
			this.Label2=new Label();
			this.TripCombo=new ComboBox();
			this.Label3=new Label();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.Panel1=new Panel();
			this.Label7=new Label();
			this.MemBox=new RichTextBox();
			this.Label6=new Label();
			this.Label5=new Label();
			this.Label8=new Label();
			this.Label9=new Label();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//NameButton
			//
			this.NameButton.AutoSizeMode=AutoSizeMode.GrowAndShrink;
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(36, 24);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=0;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(257, 28);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(33, 16);
			this.Label1.TabIndex=22;
			this.Label1.Text="نام :";
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(67, 25);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(188, 23);
			this.NameBox.TabIndex=21;
			this.NameBox.TabStop=false;
			//
			//OverTimeCombo
			//
			this.OverTimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.OverTimeCombo.FormattingEnabled=true;
			this.OverTimeCombo.Items.AddRange(new object[] {"ندارد", "دارد"});
			this.OverTimeCombo.Location=new System.Drawing.Point(71, 85);
			this.OverTimeCombo.Name="OverTimeCombo";
			this.OverTimeCombo.Size=new System.Drawing.Size(120, 24);
			this.OverTimeCombo.TabIndex=1;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label4.Location=new System.Drawing.Point(192, 89);
			this.Label4.Margin=new Padding(4, 0, 4, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(92, 16);
			this.Label4.TabIndex=49;
			this.Label4.Text="مجوز اضافه کار:";
			//
			//ReservCombo
			//
			this.ReservCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ReservCombo.FormattingEnabled=true;
			this.ReservCombo.Items.AddRange(new object[] {"ندارد", "دارد"});
			this.ReservCombo.Location=new System.Drawing.Point(71, 155);
			this.ReservCombo.Name="ReservCombo";
			this.ReservCombo.Size=new System.Drawing.Size(120, 24);
			this.ReservCombo.TabIndex=3;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label2.Location=new System.Drawing.Point(192, 159);
			this.Label2.Margin=new Padding(4, 0, 4, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(64, 16);
			this.Label2.TabIndex=51;
			this.Label2.Text="مجوز رزرو:";
			//
			//TripCombo
			//
			this.TripCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TripCombo.FormattingEnabled=true;
			this.TripCombo.Items.AddRange(new object[] {"ندارد", "دارد"});
			this.TripCombo.Location=new System.Drawing.Point(71, 120);
			this.TripCombo.Name="TripCombo";
			this.TripCombo.Size=new System.Drawing.Size(120, 24);
			this.TripCombo.TabIndex=2;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label3.Location=new System.Drawing.Point(192, 124);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(69, 16);
			this.Label3.TabIndex=53;
			this.Label3.Text="مجوز تریپ:";
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ExitButton.Location=new System.Drawing.Point(13, 359);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(98, 34);
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
			
			this.RegButton.Location=new System.Drawing.Point(166, 359);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(173, 34);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.MemBox);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.TripCombo);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.OverTimeCombo);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.ReservCombo);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(12, 19);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(327, 320);
			this.Panel1.TabIndex=0;
			//
			//Label7
			//
			this.Label7.Location=new System.Drawing.Point(1, 198);
			this.Label7.Margin=new Padding(4, 0, 4, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(324, 16);
			this.Label7.TabIndex=58;
			this.Label7.Text="...................................................................";
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.Beige;
			this.MemBox.Location=new System.Drawing.Point(11, 246);
			this.MemBox.Margin=new Padding(4, 5, 4, 5);
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(300, 53);
			this.MemBox.TabIndex=4;
			this.MemBox.Text="";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Location=new System.Drawing.Point(252, 225);
			this.Label6.Margin=new Padding(4, 0, 4, 0);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(62, 16);
			this.Label6.TabIndex=57;
			this.Label6.Text="توضیحات:";
			//
			//Label5
			//
			this.Label5.Location=new System.Drawing.Point(2, 55);
			this.Label5.Margin=new Padding(4, 0, 4, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(324, 16);
			this.Label5.TabIndex=55;
			this.Label5.Text="...................................................................";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(999, 19);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(69, 16);
			this.Label8.TabIndex=0;
			this.Label8.Text="نام پرسنل:";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Location=new System.Drawing.Point(1002, 55);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(57, 16);
			this.Label9.TabIndex=31;
			this.Label9.Text="نام کاربر:";
			//
			//PermisionEditForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(353, 400);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.RegButton);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="PermisionEditForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ویرایش مجوزها";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		private Button NameButton;
		private Label Label1;
		private TextBox NameBox;
		private ComboBox OverTimeCombo;
		private Label Label4;
		private ComboBox ReservCombo;
		private Label Label2;
		private ComboBox TripCombo;
		private Label Label3;
		private Button ExitButton;
		private Button RegButton;
		private Panel Panel1;
		private Label Label8;
		private Label Label9;
		private Label Label5;
		private RichTextBox MemBox;
		private Label Label6;
		private Label Label7;
	}
	
}
