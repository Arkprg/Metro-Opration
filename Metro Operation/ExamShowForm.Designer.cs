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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class ExamShowForm : BaseForm
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
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label4=new System.Windows.Forms.Label();
            this.MemLabel=new System.Windows.Forms.Label();
            this.LevLabel=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.KindLabel=new System.Windows.Forms.Label();
            this.DateLabel=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.Label3=new System.Windows.Forms.Label();
            this.TitrLabel=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.MainPanel=new System.Windows.Forms.Panel();
            this.QuesPanel1=new System.Windows.Forms.Panel();
            this.Ques1Label=new System.Windows.Forms.Label();
            this.RadioButton4=new System.Windows.Forms.RadioButton();
            this.RadioButton3=new System.Windows.Forms.RadioButton();
            this.RadioButton2=new System.Windows.Forms.RadioButton();
            this.RadioButton1=new System.Windows.Forms.RadioButton();
            this.Label10=new System.Windows.Forms.Label();
            this.RegButton=new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.QuesPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.Silver;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.MemLabel);
            this.Panel2.Controls.Add(this.LevLabel);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.KindLabel);
            this.Panel2.Controls.Add(this.DateLabel);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.TitrLabel);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Location=new System.Drawing.Point(10, 9);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(800, 105);
            this.Panel2.TabIndex=1;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(478, 18);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(74, 16);
            this.Label4.TabIndex=80;
            this.Label4.Text="تاریخ شروع:";
            // 
            // MemLabel
            // 
            this.MemLabel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MemLabel.Location=new System.Drawing.Point(11, 42);
            this.MemLabel.Name="MemLabel";
            this.MemLabel.Size=new System.Drawing.Size(722, 50);
            this.MemLabel.TabIndex=89;
            // 
            // LevLabel
            // 
            this.LevLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LevLabel.Location=new System.Drawing.Point(12, 14);
            this.LevLabel.Name="LevLabel";
            this.LevLabel.Size=new System.Drawing.Size(123, 24);
            this.LevLabel.TabIndex=89;
            this.LevLabel.Text="--";
            this.LevLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(334, 18);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(31, 16);
            this.Label1.TabIndex=81;
            this.Label1.Text="نوع:";
            // 
            // KindLabel
            // 
            this.KindLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KindLabel.Location=new System.Drawing.Point(239, 14);
            this.KindLabel.Name="KindLabel";
            this.KindLabel.Size=new System.Drawing.Size(95, 24);
            this.KindLabel.TabIndex=87;
            this.KindLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateLabel
            // 
            this.DateLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.Location=new System.Drawing.Point(382, 14);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(96, 24);
            this.DateLabel.TabIndex=87;
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(733, 59);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(62, 16);
            this.Label2.TabIndex=83;
            this.Label2.Text="توضیحات:";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(136, 18);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(88, 16);
            this.Label3.TabIndex=83;
            this.Label3.Text="اولویت نمایش:";
            // 
            // TitrLabel
            // 
            this.TitrLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TitrLabel.Location=new System.Drawing.Point(560, 14);
            this.TitrLabel.Name="TitrLabel";
            this.TitrLabel.Size=new System.Drawing.Size(175, 24);
            this.TitrLabel.TabIndex=87;
            this.TitrLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(735, 18);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(44, 16);
            this.Label5.TabIndex=87;
            this.Label5.Text="عنوان:";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll=true;
            this.MainPanel.BackColor=System.Drawing.Color.Wheat;
            this.MainPanel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location=new System.Drawing.Point(18, 122);
            this.MainPanel.Name="MainPanel";
            this.MainPanel.Size=new System.Drawing.Size(785, 3);
            this.MainPanel.TabIndex=1;
            // 
            // QuesPanel1
            // 
            this.QuesPanel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuesPanel1.Controls.Add(this.Ques1Label);
            this.QuesPanel1.Controls.Add(this.RadioButton4);
            this.QuesPanel1.Controls.Add(this.RadioButton3);
            this.QuesPanel1.Controls.Add(this.RadioButton2);
            this.QuesPanel1.Controls.Add(this.RadioButton1);
            this.QuesPanel1.Controls.Add(this.Label10);
            this.QuesPanel1.Location=new System.Drawing.Point(24, 130);
            this.QuesPanel1.Name="QuesPanel1";
            this.QuesPanel1.Size=new System.Drawing.Size(772, 100);
            this.QuesPanel1.TabIndex=89;
            this.QuesPanel1.Visible=false;
            // 
            // Ques1Label
            // 
            this.Ques1Label.BackColor=System.Drawing.Color.Transparent;
            this.Ques1Label.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Ques1Label.Location=new System.Drawing.Point(10, 5);
            this.Ques1Label.Name="Ques1Label";
            this.Ques1Label.Size=new System.Drawing.Size(725, 36);
            this.Ques1Label.TabIndex=87;
            this.Ques1Label.Text="تست1تست2";
            this.Ques1Label.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RadioButton4
            // 
            this.RadioButton4.Location=new System.Drawing.Point(10, 75);
            this.RadioButton4.Name="RadioButton4";
            this.RadioButton4.Size=new System.Drawing.Size(375, 20);
            this.RadioButton4.TabIndex=88;
            this.RadioButton4.TabStop=true;
            this.RadioButton4.Text="RadioButton1";
            this.RadioButton4.UseVisualStyleBackColor=true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.Location=new System.Drawing.Point(10, 50);
            this.RadioButton3.Name="RadioButton3";
            this.RadioButton3.Size=new System.Drawing.Size(375, 20);
            this.RadioButton3.TabIndex=88;
            this.RadioButton3.TabStop=true;
            this.RadioButton3.Text="RadioButton1";
            this.RadioButton3.UseVisualStyleBackColor=true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.Location=new System.Drawing.Point(390, 75);
            this.RadioButton2.Name="RadioButton2";
            this.RadioButton2.Size=new System.Drawing.Size(370, 20);
            this.RadioButton2.TabIndex=88;
            this.RadioButton2.TabStop=true;
            this.RadioButton2.Text="RadioButton1";
            this.RadioButton2.UseVisualStyleBackColor=true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.Location=new System.Drawing.Point(390, 50);
            this.RadioButton1.Name="RadioButton1";
            this.RadioButton1.Size=new System.Drawing.Size(370, 20);
            this.RadioButton1.TabIndex=88;
            this.RadioButton1.TabStop=true;
            this.RadioButton1.Text="پاسخ شماره یک";
            this.RadioButton1.UseVisualStyleBackColor=true;
            // 
            // Label10
            // 
            this.Label10.AutoSize=true;
            this.Label10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label10.Location=new System.Drawing.Point(735, 5);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(34, 16);
            this.Label10.TabIndex=87;
            this.Label10.Text=" 10)";
            // 
            // RegButton
            // 
            this.RegButton.Anchor=((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RegButton.DialogResult=System.Windows.Forms.DialogResult.OK;
            this.RegButton.Enabled=false;
            this.RegButton.Location=new System.Drawing.Point(24, 241);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(123, 28);
            this.RegButton.TabIndex=2;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExamShowForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(819, 274);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.QuesPanel1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Panel2);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ExamShowForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamShowForm_FormClosing);
            this.Load += new System.EventHandler(this.ExamShowForm_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.QuesPanel1.ResumeLayout(false);
            this.QuesPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		
		private Panel Panel2;
		private Label Label4;
		private Label LevLabel;
		private Label Label1;
		private Label KindLabel;
		private Label DateLabel;
		private Label Label3;
		private Label TitrLabel;
		private Label Label5;
		private Panel MainPanel;
		private RadioButton RadioButton1;
		private Label Ques1Label;
		private Panel QuesPanel1;
		private RadioButton RadioButton4;
		private RadioButton RadioButton3;
		private RadioButton RadioButton2;
		private Label Label10;
		private Button RegButton;
		private Label MemLabel;
		private Label Label2;
	}
	
}
