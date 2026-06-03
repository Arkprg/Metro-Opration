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
	partial class FunctionRegisterForm : BaseForm
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components=new System.ComponentModel.Container();
            this.NameBox=new TextBox();
            this.NameButton=new Button();
            this.Label4=new Label();
            this.MemBox=new RichTextBox();
            this.Label3=new Label();
            this.RegButton=new Button();
            this.ExitButton=new Button();
            this.Label1=new Label();
            this.Label6=new Label();
            this.KindCombo=new ComboBox();
            this.Label5=new Label();
            this.Timer1=new Timer(this.components);
            this.Panel1=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new Panel();
            this.Panel3=new Panel();
            this.LevelCombo=new ComboBox();
            this.label2=new Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(235, 12);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(127, 23);
            this.NameBox.TabIndex=21;
            // 
            // NameButton
            // 
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(206, 11);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=0;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(368, 60);
            this.Label4.Margin=new Padding(4, 0, 4, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(62, 16);
            this.Label4.TabIndex=32;
            this.Label4.Text="توضیحات:";
            // 
            // MemBox
            // 
            this.MemBox.Location=new System.Drawing.Point(12, 81);
            this.MemBox.Margin=new Padding(4, 5, 4, 5);
            this.MemBox.MaxLength=250;
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(418, 84);
            this.MemBox.TabIndex=3;
            this.MemBox.Text="";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(141, 15);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(39, 16);
            this.Label3.TabIndex=30;
            this.Label3.Text="تاریخ:";
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(228, 10);
            this.RegButton.Margin=new Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(195, 34);
            this.RegButton.TabIndex=0;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.Cancel;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(17, 10);
            this.ExitButton.Margin=new Padding(4, 5, 4, 5);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(107, 34);
            this.ExitButton.TabIndex=1;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(363, 15);
            this.Label1.Margin=new Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(69, 16);
            this.Label1.TabIndex=23;
            this.Label1.Text="نام پرسنل:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Location=new System.Drawing.Point(283, 20);
            this.Label6.Margin=new Padding(4, 0, 4, 0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(44, 16);
            this.Label6.TabIndex=38;
            this.Label6.Text="عنوان:";
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Location=new System.Drawing.Point(12, 16);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(271, 24);
            this.KindCombo.TabIndex=2;
            // 
            // Label5
            // 
            this.Label5.BackColor=System.Drawing.Color.Transparent;
            this.Label5.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.ForeColor=System.Drawing.Color.Brown;
            this.Label5.ImageAlign=System.Drawing.ContentAlignment.BottomRight;
            this.Label5.Location=new System.Drawing.Point(10, 63);
            this.Label5.Margin=new Padding(4, 0, 4, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(445, 26);
            this.Label5.TabIndex=47;
            this.Label5.Text="تذکر: ارائه توضیحات تکمیلی الزامی است";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled=true;
            this.Timer1.Interval=1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Location=new System.Drawing.Point(10, 11);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(445, 49);
            this.Panel1.TabIndex=0;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(16, 12);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=99;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.MemBox);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.LevelCombo);
            this.Panel2.Controls.Add(this.KindCombo);
            this.Panel2.Location=new System.Drawing.Point(10, 92);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(445, 179);
            this.Panel2.TabIndex=1;
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Location=new System.Drawing.Point(10, 280);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(445, 55);
            this.Panel3.TabIndex=2;
            // 
            // LevelCombo
            // 
            this.LevelCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LevelCombo.FormattingEnabled=true;
            this.LevelCombo.Items.AddRange(new object[] {
            "مثبت",
            "منفی"});
            this.LevelCombo.Location=new System.Drawing.Point(336, 16);
            this.LevelCombo.Name="LevelCombo";
            this.LevelCombo.Size=new System.Drawing.Size(58, 24);
            this.LevelCombo.TabIndex=2;
            this.LevelCombo.SelectedIndexChanged += new System.EventHandler(this.LevelCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize=true;
            this.label2.Location=new System.Drawing.Point(394, 20);
            this.label2.Margin=new Padding(4, 0, 4, 0);
            this.label2.Name="label2";
            this.label2.Size=new System.Drawing.Size(42, 16);
            this.label2.TabIndex=38;
            this.label2.Text="امتیاز:";
            // 
            // FunctionRegisterForm
            // 
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(468, 348);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label5);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="FunctionRegisterForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ثبت امتیاز پرسنل";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FunctionRegisterForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form13_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private Label label2;
        private ComboBox LevelCombo;
        private System.ComponentModel.IContainer components;
        private TextBox NameBox;
        private Button NameButton;
        private Label Label4;
        private RichTextBox MemBox;
        private Label Label3;
        private Button RegButton;
        private Button ExitButton;
        private Label Label1;
        private Label Label6;
        private ComboBox KindCombo;
        private Label Label5;
        private Timer Timer1;
        private Panel Panel1;
        private Panel Panel2;
        private Panel Panel3;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
    }
	
}
