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
	partial class OvertimeEditForm : BaseForm
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
            this.components = new System.ComponentModel.Container();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.MemBox = new System.Windows.Forms.RichTextBox();
            this.DeletButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PersianCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.KindCombo = new System.Windows.Forms.ComboBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Location = new System.Drawing.Point(193, 18);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(125, 23);
            this.NameBox.TabIndex = 0;
            // 
            // NameButton
            // 
            this.NameButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameButton.Image = global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location = new System.Drawing.Point(163, 17);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex = 1;
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(20, 16);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(120, 55);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(318, 53);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 16);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "تاریخ:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(318, 21);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 16);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "نام:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(316, 16);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 16);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "عنوان:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.ForeColor = System.Drawing.Color.DarkRed;
            this.Label5.Location = new System.Drawing.Point(18, 208);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(347, 27);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "تذکر: ارائه توضیحات تکمیلی الزامی است";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayLabel
            // 
            this.DayLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DayLabel.ForeColor = System.Drawing.Color.Red;
            this.DayLabel.Location = new System.Drawing.Point(26, 83);
            this.DayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(220, 19);
            this.DayLabel.TabIndex = 35;
            this.DayLabel.Text = "__";
            this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeBox.Location = new System.Drawing.Point(266, 81);
            this.TimeBox.Mask = "00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(50, 23);
            this.TimeBox.TabIndex = 2;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label6.Location = new System.Drawing.Point(316, 84);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 16);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "مدت:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.Location = new System.Drawing.Point(295, 131);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 16);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "توضیحات:";
            // 
            // MemBox
            // 
            this.MemBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MemBox.Location = new System.Drawing.Point(17, 152);
            this.MemBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemBox.Name = "MemBox";
            this.MemBox.Size = new System.Drawing.Size(348, 54);
            this.MemBox.TabIndex = 3;
            this.MemBox.Text = "";
            // 
            // DeletButton
            // 
            this.DeletButton.BackColor = System.Drawing.Color.Tomato;
            this.DeletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletButton.Image = global::Metro_Operation.Properties.Resources.rubbish_bin;
            this.DeletButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletButton.Location = new System.Drawing.Point(121, 14);
            this.DeletButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(118, 34);
            this.DeletButton.TabIndex = 1;
            this.DeletButton.Text = "حذف";
            this.DeletButton.UseVisualStyleBackColor = false;
            this.DeletButton.Click += new System.EventHandler(this.DeletButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(247, 14);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(118, 34);
            this.RegButton.TabIndex = 0;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image = global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(17, 14);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(84, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "    انصراف";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.SearchButton);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location = new System.Drawing.Point(13, 11);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(383, 91);
            this.Panel1.TabIndex = 0;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location = new System.Drawing.Point(164, 50);
            this.PersianCalendar.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalendar.Name = "PersianCalendar";
            this.PersianCalendar.NowDateSelected = true;
            this.PersianCalendar.ReadOnly = true;
            this.PersianCalendar.SelectedDate = null;
            this.PersianCalendar.Shamsi = null;
            this.PersianCalendar.Size = new System.Drawing.Size(154, 23);
            this.PersianCalendar.TabIndex = 98;
            this.PersianCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_Leave);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.LocalCombo);
            this.Panel2.Controls.Add(this.KindCombo);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.MemBox);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.DayLabel);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.TimeBox);
            this.Panel2.Location = new System.Drawing.Point(13, 111);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(383, 247);
            this.Panel2.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(316, 50);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 16);
            this.Label7.TabIndex = 55;
            this.Label7.Text = "مبدا:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(164, 47);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(152, 24);
            this.LocalCombo.TabIndex = 1;
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KindCombo.FormattingEnabled = true;
            this.KindCombo.Location = new System.Drawing.Point(164, 13);
            this.KindCombo.Name = "KindCombo";
            this.KindCombo.Size = new System.Drawing.Size(152, 24);
            this.KindCombo.Sorted = true;
            this.KindCombo.TabIndex = 0;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.DeletButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Location = new System.Drawing.Point(13, 368);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(382, 63);
            this.Panel3.TabIndex = 2;
            // 
            // OvertimeEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(409, 436);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OvertimeEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش اضافه کار ثبت شده";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OvertimeEditForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form36_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private TextBox NameBox;
		private Button NameButton;
		private Button SearchButton;
		private Label Label3;
		private Label Label1;
		private Label Label5;
		private Label DayLabel;
		private MaskedTextBox TimeBox;
		private Label Label6;
		private Label Label4;
		private RichTextBox MemBox;
		private Label Label2;
		private Button DeletButton;
		private Button RegButton;
		private Button ExitButton;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private ComboBox KindCombo;
		private Label Label7;
		private ComboBox LocalCombo;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private System.ComponentModel.IContainer components;
    }
	
}
