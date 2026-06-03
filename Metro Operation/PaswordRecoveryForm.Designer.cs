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
	partial class PaswordRecoveryForm : BaseForm
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
            this.QuestionPanel=new System.Windows.Forms.Panel();
            this.Label8=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.UserBox=new System.Windows.Forms.TextBox();
            this.AnswerBox=new System.Windows.Forms.TextBox();
            this.QuesCombo=new System.Windows.Forms.ComboBox();
            this.RegButton=new System.Windows.Forms.Button();
            this.ExitButton=new System.Windows.Forms.Button();
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor=System.Drawing.Color.LightBlue;
            this.QuestionPanel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionPanel.Controls.Add(this.Label8);
            this.QuestionPanel.Controls.Add(this.Label1);
            this.QuestionPanel.Controls.Add(this.Label7);
            this.QuestionPanel.Controls.Add(this.Label6);
            this.QuestionPanel.Controls.Add(this.UserBox);
            this.QuestionPanel.Controls.Add(this.AnswerBox);
            this.QuestionPanel.Controls.Add(this.QuesCombo);
            this.QuestionPanel.Location=new System.Drawing.Point(9, 8);
            this.QuestionPanel.Name="QuestionPanel";
            this.QuestionPanel.Size=new System.Drawing.Size(357, 148);
            this.QuestionPanel.TabIndex=0;
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label8.Location=new System.Drawing.Point(259, 79);
            this.Label8.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(85, 16);
            this.Label8.TabIndex=12;
            this.Label8.Text="سوال امنیتی:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.Location=new System.Drawing.Point(259, 19);
            this.Label1.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(72, 16);
            this.Label1.TabIndex=11;
            this.Label1.Text="نام کاربری :";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label7.Location=new System.Drawing.Point(259, 109);
            this.Label7.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(77, 16);
            this.Label7.TabIndex=11;
            this.Label7.Text="پاسخ سوال:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(25, 46);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(281, 16);
            this.Label6.TabIndex=19;
            this.Label6.Text="_______________________________________";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserBox
            // 
            this.UserBox.Location=new System.Drawing.Point(15, 15);
            this.UserBox.Name="UserBox";
            this.UserBox.Size=new System.Drawing.Size(244, 23);
            this.UserBox.TabIndex=0;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location=new System.Drawing.Point(15, 105);
            this.AnswerBox.Name="AnswerBox";
            this.AnswerBox.Size=new System.Drawing.Size(244, 23);
            this.AnswerBox.TabIndex=2;
            // 
            // QuesCombo
            // 
            this.QuesCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuesCombo.FormattingEnabled=true;
            this.QuesCombo.Items.AddRange(new object[] {
            "نام مدرسه ابتدایی",
            "نام بهترین دوست دوران بچگی",
            "نام پدربزرگ یا مادربزرگ ",
            "نام محله ای که در آن بزرگ شده اید",
            "مقصد اولین مسافرت "});
            this.QuesCombo.Location=new System.Drawing.Point(15, 75);
            this.QuesCombo.Name="QuesCombo";
            this.QuesCombo.Size=new System.Drawing.Size(244, 24);
            this.QuesCombo.TabIndex=1;
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Default;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(170, 165);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(181, 35);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="تایید";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Default;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(20, 165);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(123, 35);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            // 
            // PaswordRecoveryForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(375, 208);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ExitButton);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin=new System.Windows.Forms.Padding(4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="PaswordRecoveryForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PaswordRecoveryForm_Load);
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.ResumeLayout(false);

		}
		
		private Panel QuestionPanel;
		private Label Label8;
		private Label Label1;
		private Label Label7;
		private Label Label6;
		private TextBox UserBox;
		private TextBox AnswerBox;
		private ComboBox QuesCombo;
		private Button RegButton;
		private Button ExitButton;
	}
	
}
