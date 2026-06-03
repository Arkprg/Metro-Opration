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
		public partial class ToastForm : BaseForm
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
			base.Load += new System.EventHandler(ToastForm_Load);
			this.Shown += new System.EventHandler(ToastForm_Shown);
			base.FormClosed += new FormClosedEventHandler(ToastForm_FormClosed);
			this.messageLabel=new Label();
			this.lifeTimer=new Timer(this.components);
			this.lifeTimer.Tick += new System.EventHandler(this.LifeTimer_Tick);
			this.PictureBox1=new PictureBox();
			this.Panel1=new Panel();
			this.CloseButton=new Button();
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			this.TitleLable=new Label();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//messageLabel
			//
			this.messageLabel.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.messageLabel.ForeColor=System.Drawing.Color.White;
			this.messageLabel.Location=new System.Drawing.Point(71, 25);
			this.messageLabel.Name="messageLabel";
			this.messageLabel.RightToLeft=RightToLeft.Yes;
			this.messageLabel.Size=new System.Drawing.Size(290, 50);
			this.messageLabel.TabIndex=0;
			this.messageLabel.Text="Message will appear here";
			this.messageLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//lifeTimer
			//
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor=AnchorStyles.None;
			this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.Tehran_Metro_logo;
			this.PictureBox1.Location=new System.Drawing.Point(4, 4);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(67, 68);
			this.PictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex=1;
			this.PictureBox1.TabStop=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Black;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.CloseButton);
			this.Panel1.Controls.Add(this.TitleLable);
			this.Panel1.Controls.Add(this.messageLabel);
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Dock=DockStyle.Fill;
			this.Panel1.Location=new System.Drawing.Point(0, 0);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(364, 78);
			this.Panel1.TabIndex=2;
			//
			//CloseButton
			//
			this.CloseButton.Image=global::Metro_Operation.Properties.Resources.cancel1;
			this.CloseButton.Location=new System.Drawing.Point(337, 2);
			this.CloseButton.Name="CloseButton";
			this.CloseButton.Size=new System.Drawing.Size(23, 23);
			this.CloseButton.TabIndex=3;
			this.CloseButton.UseVisualStyleBackColor=true;
			//
			//TitleLable
			//
			this.TitleLable.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TitleLable.ForeColor=System.Drawing.Color.Yellow;
			this.TitleLable.Location=new System.Drawing.Point(77, 2);
			this.TitleLable.Name="TitleLable";
			this.TitleLable.RightToLeft=RightToLeft.Yes;
			this.TitleLable.Size=new System.Drawing.Size(254, 23);
			this.TitleLable.TabIndex=2;
			this.TitleLable.Text="آخرین تغییرات";
			this.TitleLable.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ToastForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(364, 78);
			this.Controls.Add(this.Panel1);
			this.FormBorderStyle=FormBorderStyle.None;
			this.Name="ToastForm";
			this.ShowInTaskbar=false;
			this.Text="Toast Form";
			this.TopMost=true;
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private Label messageLabel;
		private Timer lifeTimer;
		private PictureBox PictureBox1;
		private Panel Panel1;
		private Label TitleLable;
		private Button CloseButton;
	}
	
}
