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
		public partial class OvertimeRequestEditForm : BaseForm
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OvertimeRequestEditForm));
            this.RegButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NameButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PersianCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.HashtCheck = new System.Windows.Forms.CheckBox();
            this.AllCheck = new System.Windows.Forms.CheckBox();
            this.A9Check = new System.Windows.Forms.CheckBox();
            this.S9Check = new System.Windows.Forms.CheckBox();
            this.S12Check = new System.Windows.Forms.CheckBox();
            this.R12Check = new System.Windows.Forms.CheckBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = ((System.Drawing.Image)(resources.GetObject("RegButton.Image")));
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(282, 11);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(132, 34);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image = global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(15, 11);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 34);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "     انصراف ";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(304, 34);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(106, 16);
            this.Label7.TabIndex = 51;
            this.Label7.Text = "ایستگاه مورد نظر:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(115, 31);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(187, 24);
            this.LocalCombo.TabIndex = 1;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(378, 51);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 16);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "تاریخ:";
            // 
            // NameButton
            // 
            this.NameButton.Image = global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location = new System.Drawing.Point(212, 14);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(28, 25);
            this.NameButton.TabIndex = 1;
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search1;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(22, 14);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(152, 57);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "جستجو";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(378, 18);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 16);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "نام:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Location = new System.Drawing.Point(240, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(138, 23);
            this.NameBox.TabIndex = 42;
            this.NameBox.TabStop = false;
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.Tomato;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Image = global::Metro_Operation.Properties.Resources.rubbish_bin;
            this.DelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DelButton.Location = new System.Drawing.Point(137, 11);
            this.DelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(129, 34);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "حذف";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(435, 90);
            this.Panel1.TabIndex = 0;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location = new System.Drawing.Point(212, 48);
            this.PersianCalendar.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalendar.Name = "PersianCalendar";
            this.PersianCalendar.NowDateSelected = true;
            this.PersianCalendar.ReadOnly = true;
            this.PersianCalendar.SelectedDate = null;
            this.PersianCalendar.Shamsi = null;
            this.PersianCalendar.Size = new System.Drawing.Size(166, 23);
            this.PersianCalendar.TabIndex = 51;
            this.PersianCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.DelButton);
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.ForeColor = System.Drawing.Color.Black;
            this.Panel2.Location = new System.Drawing.Point(12, 305);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(435, 58);
            this.Panel2.TabIndex = 2;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Panel4);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Controls.Add(this.LocalCombo);
            this.Panel3.Location = new System.Drawing.Point(12, 120);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(435, 168);
            this.Panel3.TabIndex = 1;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.LightBlue;
            this.Panel4.Controls.Add(this.HashtCheck);
            this.Panel4.Controls.Add(this.AllCheck);
            this.Panel4.Controls.Add(this.A9Check);
            this.Panel4.Controls.Add(this.S9Check);
            this.Panel4.Controls.Add(this.S12Check);
            this.Panel4.Controls.Add(this.R12Check);
            this.Panel4.Location = new System.Drawing.Point(-1, 72);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(435, 95);
            this.Panel4.TabIndex = 53;
            // 
            // HashtCheck
            // 
            this.HashtCheck.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashtCheck.Location = new System.Drawing.Point(8, 45);
            this.HashtCheck.Name = "HashtCheck";
            this.HashtCheck.Size = new System.Drawing.Size(125, 25);
            this.HashtCheck.TabIndex = 22;
            this.HashtCheck.Text = "هشتگرد";
            this.HashtCheck.UseVisualStyleBackColor = false;
            this.HashtCheck.Visible = false;
            // 
            // AllCheck
            // 
            this.AllCheck.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCheck.Location = new System.Drawing.Point(298, 13);
            this.AllCheck.Name = "AllCheck";
            this.AllCheck.Size = new System.Drawing.Size(125, 25);
            this.AllCheck.TabIndex = 22;
            this.AllCheck.Text = "همه موارد";
            this.AllCheck.UseVisualStyleBackColor = true;
            this.AllCheck.CheckedChanged += new System.EventHandler(this.AllCheck_CheckedChanged);
            // 
            // A9Check
            // 
            this.A9Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9Check.Location = new System.Drawing.Point(153, 45);
            this.A9Check.Name = "A9Check";
            this.A9Check.Size = new System.Drawing.Size(125, 25);
            this.A9Check.TabIndex = 22;
            this.A9Check.Text = "9 ساعته عصر";
            this.A9Check.UseVisualStyleBackColor = true;
            // 
            // S9Check
            // 
            this.S9Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S9Check.Location = new System.Drawing.Point(298, 45);
            this.S9Check.Name = "S9Check";
            this.S9Check.Size = new System.Drawing.Size(125, 25);
            this.S9Check.TabIndex = 22;
            this.S9Check.Text = "9 ساعته صبح";
            this.S9Check.UseVisualStyleBackColor = true;
            // 
            // S12Check
            // 
            this.S12Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S12Check.Location = new System.Drawing.Point(8, 13);
            this.S12Check.Name = "S12Check";
            this.S12Check.Size = new System.Drawing.Size(125, 25);
            this.S12Check.TabIndex = 22;
            this.S12Check.Text = "12 ساعته شب";
            this.S12Check.UseVisualStyleBackColor = true;
            // 
            // R12Check
            // 
            this.R12Check.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R12Check.Location = new System.Drawing.Point(153, 13);
            this.R12Check.Name = "R12Check";
            this.R12Check.Size = new System.Drawing.Size(125, 25);
            this.R12Check.TabIndex = 22;
            this.R12Check.Text = "12 ساعته روز";
            this.R12Check.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Gray;
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(305, 111);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(135, 23);
            this.Label8.TabIndex = 52;
            this.Label8.Text = "درخواست اضافه کار";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OvertimeRequestEditForm
            // 
            this.AcceptButton = this.ShowButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(460, 377);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OvertimeRequestEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش در خواست اضافه کار";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OvertimeRequestEditForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.OvertimeRequestEditForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private Button RegButton;
		private Button ExitButton;
		private Label Label7;
		private ComboBox LocalCombo;
		private Label Label3;
		private Button NameButton;
		private Button ShowButton;
		private Label Label1;
		private TextBox NameBox;
		private Button DelButton;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Label Label8;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private System.ComponentModel.IContainer components;
        private Panel Panel4;
        private CheckBox HashtCheck;
        private CheckBox AllCheck;
        private CheckBox A9Check;
        private CheckBox S9Check;
        private CheckBox S12Check;
        private CheckBox R12Check;
    }
	
}
