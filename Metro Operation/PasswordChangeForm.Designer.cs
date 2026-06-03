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
	partial class PasswordChangeForm : BaseForm
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
            this.Label1=new System.Windows.Forms.Label();
            this.CurrentPasBox=new System.Windows.Forms.TextBox();
            this.NewPassBox=new System.Windows.Forms.TextBox();
            this.Label2=new System.Windows.Forms.Label();
            this.ReNewPassBox=new System.Windows.Forms.TextBox();
            this.Label3=new System.Windows.Forms.Label();
            this.RegButton=new System.Windows.Forms.Button();
            this.ExitButton=new System.Windows.Forms.Button();
            this.Label4=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.AnswerBox=new System.Windows.Forms.TextBox();
            this.QuesCombo=new System.Windows.Forms.ComboBox();
            this.Label7=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.PasswordPanel=new System.Windows.Forms.Panel();
            this.QuestionPanel=new System.Windows.Forms.Panel();
            this.QuestionCheck=new System.Windows.Forms.CheckBox();
            this.PasswordCheck=new System.Windows.Forms.CheckBox();
            this.Panel1.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.Label1.Location=new System.Drawing.Point(379, 20);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(100, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="کلمه عبور فعلی:";
            // 
            // CurrentPasBox
            // 
            this.CurrentPasBox.Location=new System.Drawing.Point(15, 18);
            this.CurrentPasBox.MaxLength=50;
            this.CurrentPasBox.Name="CurrentPasBox";
            this.CurrentPasBox.PasswordChar='*';
            this.CurrentPasBox.Size=new System.Drawing.Size(365, 23);
            this.CurrentPasBox.TabIndex=0;
            this.CurrentPasBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location=new System.Drawing.Point(248, 18);
            this.NewPassBox.MaxLength=50;
            this.NewPassBox.Name="NewPassBox";
            this.NewPassBox.PasswordChar='*';
            this.NewPassBox.Size=new System.Drawing.Size(132, 23);
            this.NewPassBox.TabIndex=1;
            this.NewPassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(379, 21);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(98, 16);
            this.Label2.TabIndex=2;
            this.Label2.Text="کلمه عبور جدید:";
            // 
            // ReNewPassBox
            // 
            this.ReNewPassBox.Location=new System.Drawing.Point(15, 18);
            this.ReNewPassBox.MaxLength=50;
            this.ReNewPassBox.Name="ReNewPassBox";
            this.ReNewPassBox.PasswordChar='*';
            this.ReNewPassBox.Size=new System.Drawing.Size(129, 23);
            this.ReNewPassBox.TabIndex=2;
            this.ReNewPassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(144, 21);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(95, 16);
            this.Label3.TabIndex=4;
            this.Label3.Text="تکرار کلمه عبور:";
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Default;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(236, 331);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(252, 38);
            this.RegButton.TabIndex=5;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Default;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(27, 331);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(110, 38);
            this.ExitButton.TabIndex=6;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.ForeColor=System.Drawing.Color.Maroon;
            this.Label4.Location=new System.Drawing.Point(41, 54);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(445, 16);
            this.Label4.TabIndex=8;
            this.Label4.Text="توجه : کلمه عبور جدید باید حداقل 4 حرف باشد و از حروف فارسی استفاده نشود";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.CurrentPasBox);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location=new System.Drawing.Point(15, 12);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(490, 61);
            this.Panel1.TabIndex=0;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location=new System.Drawing.Point(15, 45);
            this.AnswerBox.Name="AnswerBox";
            this.AnswerBox.Size=new System.Drawing.Size(365, 23);
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
            this.QuesCombo.Location=new System.Drawing.Point(15, 11);
            this.QuesCombo.Name="QuesCombo";
            this.QuesCombo.Size=new System.Drawing.Size(365, 24);
            this.QuesCombo.TabIndex=1;
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label7.Location=new System.Drawing.Point(379, 48);
            this.Label7.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(77, 16);
            this.Label7.TabIndex=11;
            this.Label7.Text="پاسخ سوال:";
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label8.Location=new System.Drawing.Point(382, 14);
            this.Label8.Margin=new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(85, 16);
            this.Label8.TabIndex=12;
            this.Label8.Text="سوال امنیتی:";
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor=System.Drawing.Color.LightBlue;
            this.PasswordPanel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.ReNewPassBox);
            this.PasswordPanel.Controls.Add(this.NewPassBox);
            this.PasswordPanel.Controls.Add(this.Label2);
            this.PasswordPanel.Controls.Add(this.Label3);
            this.PasswordPanel.Controls.Add(this.Label4);
            this.PasswordPanel.Enabled=false;
            this.PasswordPanel.Location=new System.Drawing.Point(15, 107);
            this.PasswordPanel.Name="PasswordPanel";
            this.PasswordPanel.Size=new System.Drawing.Size(490, 85);
            this.PasswordPanel.TabIndex=2;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor=System.Drawing.Color.LightBlue;
            this.QuestionPanel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionPanel.Controls.Add(this.AnswerBox);
            this.QuestionPanel.Controls.Add(this.Label8);
            this.QuestionPanel.Controls.Add(this.Label7);
            this.QuestionPanel.Controls.Add(this.QuesCombo);
            this.QuestionPanel.Enabled=false;
            this.QuestionPanel.Location=new System.Drawing.Point(15, 228);
            this.QuestionPanel.Name="QuestionPanel";
            this.QuestionPanel.Size=new System.Drawing.Size(490, 85);
            this.QuestionPanel.TabIndex=4;
            // 
            // QuestionCheck
            // 
            this.QuestionCheck.AutoSize=true;
            this.QuestionCheck.BackColor=System.Drawing.Color.LightBlue;
            this.QuestionCheck.Location=new System.Drawing.Point(377, 207);
            this.QuestionCheck.Name="QuestionCheck";
            this.QuestionCheck.Size=new System.Drawing.Size(128, 20);
            this.QuestionCheck.TabIndex=3;
            this.QuestionCheck.Text="تغییر سوال امنیتی";
            this.QuestionCheck.UseVisualStyleBackColor=false;
            this.QuestionCheck.CheckedChanged += new System.EventHandler(this.QuestionCheck_CheckedChanged);
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.AutoSize=true;
            this.PasswordCheck.BackColor=System.Drawing.Color.LightBlue;
            this.PasswordCheck.Location=new System.Drawing.Point(395, 86);
            this.PasswordCheck.Name="PasswordCheck";
            this.PasswordCheck.Size=new System.Drawing.Size(110, 20);
            this.PasswordCheck.TabIndex=1;
            this.PasswordCheck.Text="تغییر کلمه عبور";
            this.PasswordCheck.UseVisualStyleBackColor=false;
            this.PasswordCheck.CheckedChanged += new System.EventHandler(this.PasswordCheck_CheckedChanged);
            // 
            // PasswordChangeForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(515, 385);
            this.Controls.Add(this.PasswordCheck);
            this.Controls.Add(this.QuestionCheck);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ExitButton);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor=System.Drawing.Color.Black;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="PasswordChangeForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="تغییر رمز";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordChangeForm_FormClosing);
            this.Load += new System.EventHandler(this.PasswordChangeForm_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.PasswordChangeForm_InputLanguageChanged);
            this.Shown += new System.EventHandler(this.PasswordChangeForm_Shown);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private Label Label1;
		private TextBox CurrentPasBox;
		private TextBox NewPassBox;
		private Label Label2;
		private TextBox ReNewPassBox;
		private Label Label3;
		private Button RegButton;
		private Button ExitButton;
		private Label Label4;
		private Panel Panel1;
		private TextBox AnswerBox;
		private ComboBox QuesCombo;
		private Label Label7;
		private Label Label8;
		private Panel PasswordPanel;
		private Panel QuestionPanel;
		private CheckBox QuestionCheck;
		private CheckBox PasswordCheck;
	}
	
}
