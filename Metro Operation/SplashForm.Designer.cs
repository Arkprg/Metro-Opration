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
	partial class SplashForm : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.ProgressBar1=new ProgressBar();
            this.PictureBox1=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor=System.Drawing.Color.Red;
            this.ProgressBar1.ForeColor=System.Drawing.Color.FromArgb(255, 255, ((int)(((byte)(128)))));
            this.ProgressBar1.Location=new System.Drawing.Point(9, 190);
            this.ProgressBar1.MarqueeAnimationSpeed=20;
            this.ProgressBar1.Name="ProgressBar1";
            this.ProgressBar1.Size=new System.Drawing.Size(890, 5);
            this.ProgressBar1.Style=ProgressBarStyle.Marquee;
            this.ProgressBar1.TabIndex=0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor=System.Drawing.Color.Transparent;
            this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.spl;
            this.PictureBox1.Location=new System.Drawing.Point(3, -1);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(900, 200);
            this.PictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex=6;
            this.PictureBox1.TabStop=false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.SystemColors.Control;
            this.ClientSize=new System.Drawing.Size(905, 201);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle=FormBorderStyle.None;
            this.Icon=((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name="SplashForm";
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.TopMost=true;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private ProgressBar ProgressBar1;
		private PictureBox PictureBox1;		
	}	
}
