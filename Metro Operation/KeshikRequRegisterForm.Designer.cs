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
	partial class KeshikRequRegisterForm : BaseForm
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
			this.NameBox=new TextBox();
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(KeshikRequRegisterForm_HelpButtonClicked);
			base.Load += new System.EventHandler(KeshikRequstForm_Load);
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label1=new Label();
			this.TrackBar1=new TrackBar();
			this.TrackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.Label3=new Label();
			this.Panel1=new Panel();
			((System.ComponentModel.ISupportInitialize) this.TrackBar1).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NameBox.Location=new System.Drawing.Point(138, 41);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(135, 23);
			this.NameBox.TabIndex=36;
			//
			//NameButton
			//
			this.NameButton.BackColor=System.Drawing.Color.Transparent;
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(108, 40);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=false;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(272, 44);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(69, 16);
			this.Label1.TabIndex=35;
			this.Label1.Text="نام پرسنل:";
			//
			//TrackBar1
			//
			this.TrackBar1.AllowDrop=true;
			this.TrackBar1.BackColor=System.Drawing.Color.LightBlue;
			this.TrackBar1.Cursor=Cursors.Hand;
			this.TrackBar1.LargeChange=1;
			this.TrackBar1.Location=new System.Drawing.Point(32, 86);
			this.TrackBar1.Maximum=5;
			this.TrackBar1.Name="TrackBar1";
			this.TrackBar1.RightToLeft=RightToLeft.No;
			this.TrackBar1.Size=new System.Drawing.Size(312, 45);
			this.TrackBar1.TabIndex=2;
			this.TrackBar1.TickStyle=TickStyle.None;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(133, 16);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(180, 34);
			this.RegButton.TabIndex=3;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(18, 16);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(107, 34);
			this.ExitButton.TabIndex=4;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//Label3
			//
			this.Label3.BackColor=System.Drawing.Color.LightBlue;
			this.Label3.ForeColor=System.Drawing.Color.DarkRed;
			this.Label3.Location=new System.Drawing.Point(32, 117);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(312, 32);
			this.Label3.TabIndex=42;
			this.Label3.Text="نام پرسنل:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel1
			//
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.RegButton);
			this.Panel1.Controls.Add(this.ExitButton);
			this.Panel1.Location=new System.Drawing.Point(22, 178);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(332, 63);
			this.Panel1.TabIndex=46;
			//
			//KeshikRequRegisterForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(373, 264);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.TrackBar1);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.NameButton);
			this.Controls.Add(this.Label1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="KeshikRequRegisterForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت در خواست کشیک";
			((System.ComponentModel.ISupportInitialize) this.TrackBar1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		private TextBox NameBox;
		private Button NameButton;
		private Label Label1;
		private TrackBar TrackBar1;
		private Button RegButton;
		private Button ExitButton;
		private Label Label3;
		private Panel Panel1;
	}
	
}
