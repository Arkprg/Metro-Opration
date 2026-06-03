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
	public partial class KartableSelectForm : BaseForm
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
			this.QuesButton=new Button();
			this.QuesButton.Click += new System.EventHandler(this.QuesButton_Click);
			this.TestButton=new Button();
			this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
			this.KeshikButton=new Button();
			this.KeshikButton.Click += new System.EventHandler(this.KeshikButton_Click);
			this.ElectionButton=new Button();
			this.ElectionButton.Click += new System.EventHandler(this.ElectionButton_Click);
			this.SuspendLayout();
			//
			//QuesButton
			//
			this.QuesButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.QuesButton.Location=new System.Drawing.Point(196, 25);
			this.QuesButton.Name="QuesButton";
			this.QuesButton.Size=new System.Drawing.Size(110, 35);
			this.QuesButton.TabIndex=0;
			this.QuesButton.Text="نظرسنجی";
			this.QuesButton.UseVisualStyleBackColor=false;
			this.QuesButton.Visible=false;
			//
			//TestButton
			//
			this.TestButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.TestButton.Location=new System.Drawing.Point(64, 84);
			this.TestButton.Name="TestButton";
			this.TestButton.Size=new System.Drawing.Size(110, 35);
			this.TestButton.TabIndex=0;
			this.TestButton.Text="آزمون";
			this.TestButton.UseVisualStyleBackColor=false;
			this.TestButton.Visible=false;
			//
			//KeshikButton
			//
			this.KeshikButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.KeshikButton.Location=new System.Drawing.Point(196, 84);
			this.KeshikButton.Name="KeshikButton";
			this.KeshikButton.Size=new System.Drawing.Size(110, 35);
			this.KeshikButton.TabIndex=0;
			this.KeshikButton.Text="تعویض کشیک";
			this.KeshikButton.UseVisualStyleBackColor=false;
			this.KeshikButton.Visible=false;
			//
			//ElectionButton
			//
			this.ElectionButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ElectionButton.Location=new System.Drawing.Point(64, 25);
			this.ElectionButton.Name="ElectionButton";
			this.ElectionButton.Size=new System.Drawing.Size(110, 35);
			this.ElectionButton.TabIndex=0;
			this.ElectionButton.Text="رای گیری";
			this.ElectionButton.UseVisualStyleBackColor=false;
			this.ElectionButton.Visible=false;
			//
			//KartableSelectForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(368, 145);
			this.Controls.Add(this.KeshikButton);
			this.Controls.Add(this.TestButton);
			this.Controls.Add(this.ElectionButton);
			this.Controls.Add(this.QuesButton);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="KartableSelectForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="لطفا انتخاب کنید";
			this.ResumeLayout(false);
			
		}
		
		private Button QuesButton;
		private Button TestButton;
		private Button KeshikButton;
		private Button ElectionButton;
	}
	
}
