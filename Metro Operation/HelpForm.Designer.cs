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
		public partial class HelpForm : BaseForm
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
			this.WebBrowser1=new WebBrowser();
			base.Load += new System.EventHandler(HelpForm_Load);
			this.SuspendLayout();
			//
			//WebBrowser1
			//
			this.WebBrowser1.Dock=DockStyle.Fill;
			this.WebBrowser1.Location=new System.Drawing.Point(0, 0);
			this.WebBrowser1.MinimumSize=new System.Drawing.Size(20, 20);
			this.WebBrowser1.Name="WebBrowser1";
			this.WebBrowser1.Size=new System.Drawing.Size(964, 538);
			this.WebBrowser1.TabIndex=0;
			this.WebBrowser1.Url=new Uri("", UriKind.Relative);
			//
			//HelpForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(964, 538);
			this.Controls.Add(this.WebBrowser1);
			this.MinimizeBox=false;
			this.Name="HelpForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="راهنمایی";
			this.TopMost=true;
			this.ResumeLayout(false);
			
		}
		
		internal WebBrowser WebBrowser1;
	}
	
}
