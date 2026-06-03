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
	partial class DailyTripProcessForm : BaseForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)  {
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()  {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyTripProcessForm));
            this.Keshik12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Keshik12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1a = new System.Windows.Forms.Label();
            this.Shift12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Keshik9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Keshik9ABox = new System.Windows.Forms.MaskedTextBox();
            this.KeshikSetBox = new System.Windows.Forms.MaskedTextBox();
            this.All12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Main12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Daem12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Rez12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Leave12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Kasr12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Class12RBox = new System.Windows.Forms.MaskedTextBox();
            this.Over12RBox = new System.Windows.Forms.MaskedTextBox();
            this.All12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Main12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Shift12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Daem12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Rez12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Leave12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Class12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Kasr12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Over12SBox = new System.Windows.Forms.MaskedTextBox();
            this.Main9SBox = new System.Windows.Forms.MaskedTextBox();
            this.All9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Daem9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Shift9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Rez9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Leave9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Class9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Kasr9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Over9SBox = new System.Windows.Forms.MaskedTextBox();
            this.Main9ABox = new System.Windows.Forms.MaskedTextBox();
            this.All9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Daem9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Shift9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Rez9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Leave9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Class9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Kasr9ABox = new System.Windows.Forms.MaskedTextBox();
            this.Over9ABox = new System.Windows.Forms.MaskedTextBox();
            this.AllSetBox = new System.Windows.Forms.MaskedTextBox();
            this.ClassSetBox = new System.Windows.Forms.MaskedTextBox();
            this.MainSetBox = new System.Windows.Forms.MaskedTextBox();
            this.ShiftSetBox = new System.Windows.Forms.MaskedTextBox();
            this.DaemSetBox = new System.Windows.Forms.MaskedTextBox();
            this.OverSetBox = new System.Windows.Forms.MaskedTextBox();
            this.RezSetBox = new System.Windows.Forms.MaskedTextBox();
            this.KasrSetBox = new System.Windows.Forms.MaskedTextBox();
            this.LeaveSetBox = new System.Windows.Forms.MaskedTextBox();
            this.Local1Label = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.PersianCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.KindCombo = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NameCombo = new System.Windows.Forms.ComboBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.TrainnigUseCheck = new System.Windows.Forms.CheckBox();
            this.OvertimeUseCheck = new System.Windows.Forms.CheckBox();
            this.HgrLabel = new System.Windows.Forms.Label();
            this.GolLabel = new System.Windows.Forms.Label();
            this.TehLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Keshik12RBox
            // 
            this.Keshik12RBox.BackColor = System.Drawing.Color.Silver;
            this.Keshik12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keshik12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Keshik12RBox.Location = new System.Drawing.Point(355, 167);
            this.Keshik12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Keshik12RBox.Mask = "90";
            this.Keshik12RBox.Name = "Keshik12RBox";
            this.Keshik12RBox.PromptChar = ' ';
            this.Keshik12RBox.Size = new System.Drawing.Size(45, 25);
            this.Keshik12RBox.TabIndex = 127;
            this.Keshik12RBox.TabStop = false;
            this.Keshik12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Keshik12SBox
            // 
            this.Keshik12SBox.BackColor = System.Drawing.Color.Silver;
            this.Keshik12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keshik12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Keshik12SBox.Location = new System.Drawing.Point(272, 167);
            this.Keshik12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Keshik12SBox.Mask = "90";
            this.Keshik12SBox.Name = "Keshik12SBox";
            this.Keshik12SBox.PromptChar = ' ';
            this.Keshik12SBox.Size = new System.Drawing.Size(45, 25);
            this.Keshik12SBox.TabIndex = 128;
            this.Keshik12SBox.TabStop = false;
            this.Keshik12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Controls.Add(this.Label1a);
            this.Panel2.Controls.Add(this.Shift12RBox);
            this.Panel2.Controls.Add(this.Keshik12RBox);
            this.Panel2.Controls.Add(this.Keshik12SBox);
            this.Panel2.Controls.Add(this.Keshik9SBox);
            this.Panel2.Controls.Add(this.Keshik9ABox);
            this.Panel2.Controls.Add(this.KeshikSetBox);
            this.Panel2.Controls.Add(this.All12RBox);
            this.Panel2.Controls.Add(this.Main12RBox);
            this.Panel2.Controls.Add(this.Daem12RBox);
            this.Panel2.Controls.Add(this.Rez12RBox);
            this.Panel2.Controls.Add(this.Leave12RBox);
            this.Panel2.Controls.Add(this.Kasr12RBox);
            this.Panel2.Controls.Add(this.Class12RBox);
            this.Panel2.Controls.Add(this.Over12RBox);
            this.Panel2.Controls.Add(this.All12SBox);
            this.Panel2.Controls.Add(this.Main12SBox);
            this.Panel2.Controls.Add(this.Shift12SBox);
            this.Panel2.Controls.Add(this.Daem12SBox);
            this.Panel2.Controls.Add(this.Rez12SBox);
            this.Panel2.Controls.Add(this.Leave12SBox);
            this.Panel2.Controls.Add(this.Class12SBox);
            this.Panel2.Controls.Add(this.Kasr12SBox);
            this.Panel2.Controls.Add(this.Over12SBox);
            this.Panel2.Controls.Add(this.Main9SBox);
            this.Panel2.Controls.Add(this.All9SBox);
            this.Panel2.Controls.Add(this.Daem9SBox);
            this.Panel2.Controls.Add(this.Shift9SBox);
            this.Panel2.Controls.Add(this.Rez9SBox);
            this.Panel2.Controls.Add(this.Leave9SBox);
            this.Panel2.Controls.Add(this.Class9SBox);
            this.Panel2.Controls.Add(this.Kasr9SBox);
            this.Panel2.Controls.Add(this.Over9SBox);
            this.Panel2.Controls.Add(this.Main9ABox);
            this.Panel2.Controls.Add(this.All9ABox);
            this.Panel2.Controls.Add(this.Daem9ABox);
            this.Panel2.Controls.Add(this.Shift9ABox);
            this.Panel2.Controls.Add(this.Rez9ABox);
            this.Panel2.Controls.Add(this.Leave9ABox);
            this.Panel2.Controls.Add(this.Class9ABox);
            this.Panel2.Controls.Add(this.Kasr9ABox);
            this.Panel2.Controls.Add(this.Over9ABox);
            this.Panel2.Controls.Add(this.AllSetBox);
            this.Panel2.Controls.Add(this.ClassSetBox);
            this.Panel2.Controls.Add(this.MainSetBox);
            this.Panel2.Controls.Add(this.ShiftSetBox);
            this.Panel2.Controls.Add(this.DaemSetBox);
            this.Panel2.Controls.Add(this.OverSetBox);
            this.Panel2.Controls.Add(this.RezSetBox);
            this.Panel2.Controls.Add(this.KasrSetBox);
            this.Panel2.Controls.Add(this.LeaveSetBox);
            this.Panel2.Controls.Add(this.Local1Label);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label33);
            this.Panel2.Controls.Add(this.Label22);
            this.Panel2.Controls.Add(this.Label35);
            this.Panel2.Controls.Add(this.Label21);
            this.Panel2.Controls.Add(this.Label20);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Location = new System.Drawing.Point(8, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(422, 500);
            this.Panel2.TabIndex = 41;
            // 
            // Label1a
            // 
            this.Label1a.BackColor = System.Drawing.Color.Transparent;
            this.Label1a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1a.Location = new System.Drawing.Point(341, 34);
            this.Label1a.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1a.Name = "Label1a";
            this.Label1a.Size = new System.Drawing.Size(73, 48);
            this.Label1a.TabIndex = 48;
            this.Label1a.Text = "12 ساعته روز";
            this.Label1a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shift12RBox
            // 
            this.Shift12RBox.BackColor = System.Drawing.Color.Silver;
            this.Shift12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Shift12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Shift12RBox.Location = new System.Drawing.Point(355, 125);
            this.Shift12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Shift12RBox.Mask = "90";
            this.Shift12RBox.Name = "Shift12RBox";
            this.Shift12RBox.PromptChar = ' ';
            this.Shift12RBox.Size = new System.Drawing.Size(45, 25);
            this.Shift12RBox.TabIndex = 0;
            this.Shift12RBox.TabStop = false;
            this.Shift12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Keshik9SBox
            // 
            this.Keshik9SBox.BackColor = System.Drawing.Color.Silver;
            this.Keshik9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keshik9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Keshik9SBox.Location = new System.Drawing.Point(189, 167);
            this.Keshik9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Keshik9SBox.Mask = "90";
            this.Keshik9SBox.Name = "Keshik9SBox";
            this.Keshik9SBox.PromptChar = ' ';
            this.Keshik9SBox.Size = new System.Drawing.Size(45, 25);
            this.Keshik9SBox.TabIndex = 129;
            this.Keshik9SBox.TabStop = false;
            this.Keshik9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Keshik9ABox
            // 
            this.Keshik9ABox.BackColor = System.Drawing.Color.Silver;
            this.Keshik9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keshik9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Keshik9ABox.Location = new System.Drawing.Point(106, 167);
            this.Keshik9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Keshik9ABox.Mask = "90";
            this.Keshik9ABox.Name = "Keshik9ABox";
            this.Keshik9ABox.PromptChar = ' ';
            this.Keshik9ABox.Size = new System.Drawing.Size(45, 25);
            this.Keshik9ABox.TabIndex = 130;
            this.Keshik9ABox.TabStop = false;
            this.Keshik9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeshikSetBox
            // 
            this.KeshikSetBox.BackColor = System.Drawing.Color.Silver;
            this.KeshikSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeshikSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeshikSetBox.Location = new System.Drawing.Point(23, 167);
            this.KeshikSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeshikSetBox.Mask = "90";
            this.KeshikSetBox.Name = "KeshikSetBox";
            this.KeshikSetBox.PromptChar = ' ';
            this.KeshikSetBox.Size = new System.Drawing.Size(45, 25);
            this.KeshikSetBox.TabIndex = 131;
            this.KeshikSetBox.TabStop = false;
            this.KeshikSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // All12RBox
            // 
            this.All12RBox.BackColor = System.Drawing.Color.Silver;
            this.All12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.All12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.All12RBox.Location = new System.Drawing.Point(355, 83);
            this.All12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.All12RBox.Mask = "90";
            this.All12RBox.Name = "All12RBox";
            this.All12RBox.PromptChar = ' ';
            this.All12RBox.Size = new System.Drawing.Size(45, 25);
            this.All12RBox.TabIndex = 0;
            this.All12RBox.TabStop = false;
            this.All12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.All12RBox.TextChanged += new System.EventHandler(this.All12RBox_TextChanged);
            // 
            // Main12RBox
            // 
            this.Main12RBox.BackColor = System.Drawing.Color.White;
            this.Main12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Main12RBox.Location = new System.Drawing.Point(355, 209);
            this.Main12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main12RBox.Mask = "90";
            this.Main12RBox.Name = "Main12RBox";
            this.Main12RBox.PromptChar = ' ';
            this.Main12RBox.Size = new System.Drawing.Size(45, 25);
            this.Main12RBox.TabIndex = 0;
            this.Main12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main12RBox.TextChanged += new System.EventHandler(this.All12RBox_TextChanged);
            // 
            // Daem12RBox
            // 
            this.Daem12RBox.BackColor = System.Drawing.Color.White;
            this.Daem12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Daem12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Daem12RBox.Location = new System.Drawing.Point(355, 251);
            this.Daem12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Daem12RBox.Mask = "90";
            this.Daem12RBox.Name = "Daem12RBox";
            this.Daem12RBox.PromptChar = ' ';
            this.Daem12RBox.Size = new System.Drawing.Size(45, 25);
            this.Daem12RBox.TabIndex = 5;
            this.Daem12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Daem12RBox.TextChanged += new System.EventHandler(this.All12RBox_TextChanged);
            // 
            // Rez12RBox
            // 
            this.Rez12RBox.BackColor = System.Drawing.Color.White;
            this.Rez12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rez12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rez12RBox.Location = new System.Drawing.Point(355, 377);
            this.Rez12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rez12RBox.Mask = "90";
            this.Rez12RBox.Name = "Rez12RBox";
            this.Rez12RBox.PromptChar = ' ';
            this.Rez12RBox.Size = new System.Drawing.Size(45, 25);
            this.Rez12RBox.TabIndex = 10;
            this.Rez12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rez12RBox.TextChanged += new System.EventHandler(this.All12RBox_TextChanged);
            // 
            // Leave12RBox
            // 
            this.Leave12RBox.BackColor = System.Drawing.Color.Silver;
            this.Leave12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leave12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Leave12RBox.Location = new System.Drawing.Point(355, 293);
            this.Leave12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Leave12RBox.Mask = "90";
            this.Leave12RBox.Name = "Leave12RBox";
            this.Leave12RBox.PromptChar = ' ';
            this.Leave12RBox.Size = new System.Drawing.Size(45, 25);
            this.Leave12RBox.TabIndex = 2;
            this.Leave12RBox.TabStop = false;
            this.Leave12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kasr12RBox
            // 
            this.Kasr12RBox.BackColor = System.Drawing.Color.White;
            this.Kasr12RBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kasr12RBox.Font = new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Kasr12RBox.Location = new System.Drawing.Point(355, 461);
            this.Kasr12RBox.Mask = "###";
            this.Kasr12RBox.Name = "Kasr12RBox";
            this.Kasr12RBox.PromptChar = ' ';
            this.Kasr12RBox.Size = new System.Drawing.Size(45, 33);
            this.Kasr12RBox.TabIndex = 5;
            this.Kasr12RBox.TabStop = false;
            this.Kasr12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kasr12RBox.TextChanged += new System.EventHandler(this.Kasr12RBox_TextChanged);
            // 
            // Class12RBox
            // 
            this.Class12RBox.BackColor = System.Drawing.Color.Silver;
            this.Class12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Class12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Class12RBox.Location = new System.Drawing.Point(355, 335);
            this.Class12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class12RBox.Mask = "90";
            this.Class12RBox.Name = "Class12RBox";
            this.Class12RBox.PromptChar = ' ';
            this.Class12RBox.Size = new System.Drawing.Size(45, 25);
            this.Class12RBox.TabIndex = 4;
            this.Class12RBox.TabStop = false;
            this.Class12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Over12RBox
            // 
            this.Over12RBox.BackColor = System.Drawing.Color.Silver;
            this.Over12RBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Over12RBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Over12RBox.Location = new System.Drawing.Point(355, 419);
            this.Over12RBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Over12RBox.Mask = "90";
            this.Over12RBox.Name = "Over12RBox";
            this.Over12RBox.PromptChar = ' ';
            this.Over12RBox.Size = new System.Drawing.Size(45, 25);
            this.Over12RBox.TabIndex = 4;
            this.Over12RBox.TabStop = false;
            this.Over12RBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // All12SBox
            // 
            this.All12SBox.BackColor = System.Drawing.Color.Silver;
            this.All12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.All12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.All12SBox.Location = new System.Drawing.Point(272, 83);
            this.All12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.All12SBox.Mask = "90";
            this.All12SBox.Name = "All12SBox";
            this.All12SBox.PromptChar = ' ';
            this.All12SBox.Size = new System.Drawing.Size(45, 25);
            this.All12SBox.TabIndex = 6;
            this.All12SBox.TabStop = false;
            this.All12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.All12SBox.TextChanged += new System.EventHandler(this.All12SBox_TextChanged);
            // 
            // Main12SBox
            // 
            this.Main12SBox.BackColor = System.Drawing.Color.White;
            this.Main12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Main12SBox.Location = new System.Drawing.Point(272, 209);
            this.Main12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main12SBox.Mask = "90";
            this.Main12SBox.Name = "Main12SBox";
            this.Main12SBox.PromptChar = ' ';
            this.Main12SBox.Size = new System.Drawing.Size(45, 25);
            this.Main12SBox.TabIndex = 1;
            this.Main12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main12SBox.TextChanged += new System.EventHandler(this.All12SBox_TextChanged);
            // 
            // Shift12SBox
            // 
            this.Shift12SBox.BackColor = System.Drawing.Color.Silver;
            this.Shift12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Shift12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Shift12SBox.Location = new System.Drawing.Point(272, 125);
            this.Shift12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Shift12SBox.Mask = "90";
            this.Shift12SBox.Name = "Shift12SBox";
            this.Shift12SBox.PromptChar = ' ';
            this.Shift12SBox.Size = new System.Drawing.Size(45, 25);
            this.Shift12SBox.TabIndex = 6;
            this.Shift12SBox.TabStop = false;
            this.Shift12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Daem12SBox
            // 
            this.Daem12SBox.BackColor = System.Drawing.Color.White;
            this.Daem12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Daem12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Daem12SBox.Location = new System.Drawing.Point(272, 251);
            this.Daem12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Daem12SBox.Mask = "90";
            this.Daem12SBox.Name = "Daem12SBox";
            this.Daem12SBox.PromptChar = ' ';
            this.Daem12SBox.Size = new System.Drawing.Size(45, 25);
            this.Daem12SBox.TabIndex = 6;
            this.Daem12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Daem12SBox.TextChanged += new System.EventHandler(this.All12SBox_TextChanged);
            // 
            // Rez12SBox
            // 
            this.Rez12SBox.BackColor = System.Drawing.Color.White;
            this.Rez12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rez12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rez12SBox.Location = new System.Drawing.Point(272, 377);
            this.Rez12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rez12SBox.Mask = "90";
            this.Rez12SBox.Name = "Rez12SBox";
            this.Rez12SBox.PromptChar = ' ';
            this.Rez12SBox.Size = new System.Drawing.Size(45, 25);
            this.Rez12SBox.TabIndex = 11;
            this.Rez12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rez12SBox.TextChanged += new System.EventHandler(this.All12SBox_TextChanged);
            // 
            // Leave12SBox
            // 
            this.Leave12SBox.BackColor = System.Drawing.Color.Silver;
            this.Leave12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leave12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Leave12SBox.Location = new System.Drawing.Point(272, 293);
            this.Leave12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Leave12SBox.Mask = "90";
            this.Leave12SBox.Name = "Leave12SBox";
            this.Leave12SBox.PromptChar = ' ';
            this.Leave12SBox.Size = new System.Drawing.Size(45, 25);
            this.Leave12SBox.TabIndex = 8;
            this.Leave12SBox.TabStop = false;
            this.Leave12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Class12SBox
            // 
            this.Class12SBox.BackColor = System.Drawing.Color.Silver;
            this.Class12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Class12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Class12SBox.Location = new System.Drawing.Point(272, 335);
            this.Class12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class12SBox.Mask = "90";
            this.Class12SBox.Name = "Class12SBox";
            this.Class12SBox.PromptChar = ' ';
            this.Class12SBox.Size = new System.Drawing.Size(45, 25);
            this.Class12SBox.TabIndex = 10;
            this.Class12SBox.TabStop = false;
            this.Class12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kasr12SBox
            // 
            this.Kasr12SBox.BackColor = System.Drawing.Color.White;
            this.Kasr12SBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kasr12SBox.Font = new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Kasr12SBox.Location = new System.Drawing.Point(272, 461);
            this.Kasr12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Kasr12SBox.Mask = "###";
            this.Kasr12SBox.Name = "Kasr12SBox";
            this.Kasr12SBox.PromptChar = ' ';
            this.Kasr12SBox.Size = new System.Drawing.Size(45, 33);
            this.Kasr12SBox.TabIndex = 11;
            this.Kasr12SBox.TabStop = false;
            this.Kasr12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kasr12SBox.TextChanged += new System.EventHandler(this.Kasr12SBox_TextChanged);
            // 
            // Over12SBox
            // 
            this.Over12SBox.BackColor = System.Drawing.Color.Silver;
            this.Over12SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Over12SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Over12SBox.Location = new System.Drawing.Point(272, 419);
            this.Over12SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Over12SBox.Mask = "90";
            this.Over12SBox.Name = "Over12SBox";
            this.Over12SBox.PromptChar = ' ';
            this.Over12SBox.Size = new System.Drawing.Size(45, 25);
            this.Over12SBox.TabIndex = 10;
            this.Over12SBox.TabStop = false;
            this.Over12SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main9SBox
            // 
            this.Main9SBox.BackColor = System.Drawing.Color.White;
            this.Main9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Main9SBox.Location = new System.Drawing.Point(189, 209);
            this.Main9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main9SBox.Mask = "90";
            this.Main9SBox.Name = "Main9SBox";
            this.Main9SBox.PromptChar = ' ';
            this.Main9SBox.Size = new System.Drawing.Size(45, 25);
            this.Main9SBox.TabIndex = 2;
            this.Main9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main9SBox.TextChanged += new System.EventHandler(this.All9SBox_TextChanged);
            // 
            // All9SBox
            // 
            this.All9SBox.BackColor = System.Drawing.Color.Silver;
            this.All9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.All9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.All9SBox.Location = new System.Drawing.Point(189, 83);
            this.All9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.All9SBox.Mask = "90";
            this.All9SBox.Name = "All9SBox";
            this.All9SBox.PromptChar = ' ';
            this.All9SBox.Size = new System.Drawing.Size(45, 25);
            this.All9SBox.TabIndex = 12;
            this.All9SBox.TabStop = false;
            this.All9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.All9SBox.TextChanged += new System.EventHandler(this.All9SBox_TextChanged);
            // 
            // Daem9SBox
            // 
            this.Daem9SBox.BackColor = System.Drawing.Color.White;
            this.Daem9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Daem9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Daem9SBox.Location = new System.Drawing.Point(189, 251);
            this.Daem9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Daem9SBox.Mask = "90";
            this.Daem9SBox.Name = "Daem9SBox";
            this.Daem9SBox.PromptChar = ' ';
            this.Daem9SBox.Size = new System.Drawing.Size(45, 25);
            this.Daem9SBox.TabIndex = 7;
            this.Daem9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Daem9SBox.TextChanged += new System.EventHandler(this.All9SBox_TextChanged);
            // 
            // Shift9SBox
            // 
            this.Shift9SBox.BackColor = System.Drawing.Color.Silver;
            this.Shift9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Shift9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Shift9SBox.Location = new System.Drawing.Point(189, 125);
            this.Shift9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Shift9SBox.Mask = "90";
            this.Shift9SBox.Name = "Shift9SBox";
            this.Shift9SBox.PromptChar = ' ';
            this.Shift9SBox.Size = new System.Drawing.Size(45, 25);
            this.Shift9SBox.TabIndex = 12;
            this.Shift9SBox.TabStop = false;
            this.Shift9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rez9SBox
            // 
            this.Rez9SBox.BackColor = System.Drawing.Color.White;
            this.Rez9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rez9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rez9SBox.Location = new System.Drawing.Point(189, 377);
            this.Rez9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rez9SBox.Mask = "90";
            this.Rez9SBox.Name = "Rez9SBox";
            this.Rez9SBox.PromptChar = ' ';
            this.Rez9SBox.Size = new System.Drawing.Size(45, 25);
            this.Rez9SBox.TabIndex = 12;
            this.Rez9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rez9SBox.TextChanged += new System.EventHandler(this.All9SBox_TextChanged);
            // 
            // Leave9SBox
            // 
            this.Leave9SBox.BackColor = System.Drawing.Color.Silver;
            this.Leave9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leave9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Leave9SBox.Location = new System.Drawing.Point(189, 293);
            this.Leave9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Leave9SBox.Mask = "90";
            this.Leave9SBox.Name = "Leave9SBox";
            this.Leave9SBox.PromptChar = ' ';
            this.Leave9SBox.Size = new System.Drawing.Size(45, 25);
            this.Leave9SBox.TabIndex = 14;
            this.Leave9SBox.TabStop = false;
            this.Leave9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Class9SBox
            // 
            this.Class9SBox.BackColor = System.Drawing.Color.Silver;
            this.Class9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Class9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Class9SBox.Location = new System.Drawing.Point(189, 335);
            this.Class9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class9SBox.Mask = "90";
            this.Class9SBox.Name = "Class9SBox";
            this.Class9SBox.PromptChar = ' ';
            this.Class9SBox.Size = new System.Drawing.Size(45, 25);
            this.Class9SBox.TabIndex = 16;
            this.Class9SBox.TabStop = false;
            this.Class9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kasr9SBox
            // 
            this.Kasr9SBox.BackColor = System.Drawing.Color.White;
            this.Kasr9SBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kasr9SBox.Font = new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Kasr9SBox.Location = new System.Drawing.Point(189, 461);
            this.Kasr9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Kasr9SBox.Mask = "###";
            this.Kasr9SBox.Name = "Kasr9SBox";
            this.Kasr9SBox.PromptChar = ' ';
            this.Kasr9SBox.Size = new System.Drawing.Size(45, 33);
            this.Kasr9SBox.TabIndex = 17;
            this.Kasr9SBox.TabStop = false;
            this.Kasr9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kasr9SBox.TextChanged += new System.EventHandler(this.Kasr9sBox_TextChanged);
            // 
            // Over9SBox
            // 
            this.Over9SBox.BackColor = System.Drawing.Color.Silver;
            this.Over9SBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Over9SBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Over9SBox.Location = new System.Drawing.Point(189, 419);
            this.Over9SBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Over9SBox.Mask = "90";
            this.Over9SBox.Name = "Over9SBox";
            this.Over9SBox.PromptChar = ' ';
            this.Over9SBox.Size = new System.Drawing.Size(45, 25);
            this.Over9SBox.TabIndex = 16;
            this.Over9SBox.TabStop = false;
            this.Over9SBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main9ABox
            // 
            this.Main9ABox.BackColor = System.Drawing.Color.White;
            this.Main9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Main9ABox.Location = new System.Drawing.Point(106, 209);
            this.Main9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main9ABox.Mask = "90";
            this.Main9ABox.Name = "Main9ABox";
            this.Main9ABox.PromptChar = ' ';
            this.Main9ABox.Size = new System.Drawing.Size(45, 25);
            this.Main9ABox.TabIndex = 3;
            this.Main9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Main9ABox.TextChanged += new System.EventHandler(this.All9ABox_TextChanged);
            // 
            // All9ABox
            // 
            this.All9ABox.BackColor = System.Drawing.Color.Silver;
            this.All9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.All9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.All9ABox.Location = new System.Drawing.Point(106, 83);
            this.All9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.All9ABox.Mask = "90";
            this.All9ABox.Name = "All9ABox";
            this.All9ABox.PromptChar = ' ';
            this.All9ABox.Size = new System.Drawing.Size(45, 25);
            this.All9ABox.TabIndex = 18;
            this.All9ABox.TabStop = false;
            this.All9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.All9ABox.TextChanged += new System.EventHandler(this.All9ABox_TextChanged);
            // 
            // Daem9ABox
            // 
            this.Daem9ABox.BackColor = System.Drawing.Color.White;
            this.Daem9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Daem9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Daem9ABox.Location = new System.Drawing.Point(106, 251);
            this.Daem9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Daem9ABox.Mask = "90";
            this.Daem9ABox.Name = "Daem9ABox";
            this.Daem9ABox.PromptChar = ' ';
            this.Daem9ABox.Size = new System.Drawing.Size(45, 25);
            this.Daem9ABox.TabIndex = 9;
            this.Daem9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Daem9ABox.TextChanged += new System.EventHandler(this.All9ABox_TextChanged);
            // 
            // Shift9ABox
            // 
            this.Shift9ABox.BackColor = System.Drawing.Color.Silver;
            this.Shift9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Shift9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Shift9ABox.Location = new System.Drawing.Point(106, 125);
            this.Shift9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Shift9ABox.Mask = "90";
            this.Shift9ABox.Name = "Shift9ABox";
            this.Shift9ABox.PromptChar = ' ';
            this.Shift9ABox.Size = new System.Drawing.Size(45, 25);
            this.Shift9ABox.TabIndex = 18;
            this.Shift9ABox.TabStop = false;
            this.Shift9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rez9ABox
            // 
            this.Rez9ABox.BackColor = System.Drawing.Color.White;
            this.Rez9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rez9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rez9ABox.Location = new System.Drawing.Point(106, 377);
            this.Rez9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rez9ABox.Mask = "90";
            this.Rez9ABox.Name = "Rez9ABox";
            this.Rez9ABox.PromptChar = ' ';
            this.Rez9ABox.Size = new System.Drawing.Size(45, 25);
            this.Rez9ABox.TabIndex = 13;
            this.Rez9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rez9ABox.TextChanged += new System.EventHandler(this.All9ABox_TextChanged);
            // 
            // Leave9ABox
            // 
            this.Leave9ABox.BackColor = System.Drawing.Color.Silver;
            this.Leave9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leave9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Leave9ABox.Location = new System.Drawing.Point(106, 293);
            this.Leave9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Leave9ABox.Mask = "90";
            this.Leave9ABox.Name = "Leave9ABox";
            this.Leave9ABox.PromptChar = ' ';
            this.Leave9ABox.Size = new System.Drawing.Size(45, 25);
            this.Leave9ABox.TabIndex = 20;
            this.Leave9ABox.TabStop = false;
            this.Leave9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Class9ABox
            // 
            this.Class9ABox.BackColor = System.Drawing.Color.Silver;
            this.Class9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Class9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Class9ABox.Location = new System.Drawing.Point(106, 335);
            this.Class9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class9ABox.Mask = "90";
            this.Class9ABox.Name = "Class9ABox";
            this.Class9ABox.PromptChar = ' ';
            this.Class9ABox.Size = new System.Drawing.Size(45, 25);
            this.Class9ABox.TabIndex = 22;
            this.Class9ABox.TabStop = false;
            this.Class9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kasr9ABox
            // 
            this.Kasr9ABox.BackColor = System.Drawing.Color.White;
            this.Kasr9ABox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kasr9ABox.Font = new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Kasr9ABox.Location = new System.Drawing.Point(106, 461);
            this.Kasr9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Kasr9ABox.Mask = "###";
            this.Kasr9ABox.Name = "Kasr9ABox";
            this.Kasr9ABox.PromptChar = ' ';
            this.Kasr9ABox.Size = new System.Drawing.Size(45, 33);
            this.Kasr9ABox.TabIndex = 23;
            this.Kasr9ABox.TabStop = false;
            this.Kasr9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Kasr9ABox.TextChanged += new System.EventHandler(this.Kasr9aBox_TextChanged);
            // 
            // Over9ABox
            // 
            this.Over9ABox.BackColor = System.Drawing.Color.Silver;
            this.Over9ABox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Over9ABox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Over9ABox.Location = new System.Drawing.Point(106, 419);
            this.Over9ABox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Over9ABox.Mask = "90";
            this.Over9ABox.Name = "Over9ABox";
            this.Over9ABox.PromptChar = ' ';
            this.Over9ABox.Size = new System.Drawing.Size(45, 25);
            this.Over9ABox.TabIndex = 22;
            this.Over9ABox.TabStop = false;
            this.Over9ABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllSetBox
            // 
            this.AllSetBox.BackColor = System.Drawing.Color.Silver;
            this.AllSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllSetBox.Location = new System.Drawing.Point(23, 83);
            this.AllSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllSetBox.Mask = "90";
            this.AllSetBox.Name = "AllSetBox";
            this.AllSetBox.PromptChar = ' ';
            this.AllSetBox.Size = new System.Drawing.Size(45, 25);
            this.AllSetBox.TabIndex = 24;
            this.AllSetBox.TabStop = false;
            this.AllSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AllSetBox.TextChanged += new System.EventHandler(this.AllSetBox_TextChanged);
            // 
            // ClassSetBox
            // 
            this.ClassSetBox.BackColor = System.Drawing.Color.Silver;
            this.ClassSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClassSetBox.Location = new System.Drawing.Point(23, 335);
            this.ClassSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClassSetBox.Mask = "90";
            this.ClassSetBox.Name = "ClassSetBox";
            this.ClassSetBox.PromptChar = ' ';
            this.ClassSetBox.Size = new System.Drawing.Size(45, 25);
            this.ClassSetBox.TabIndex = 28;
            this.ClassSetBox.TabStop = false;
            this.ClassSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainSetBox
            // 
            this.MainSetBox.BackColor = System.Drawing.Color.White;
            this.MainSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainSetBox.Location = new System.Drawing.Point(23, 209);
            this.MainSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainSetBox.Mask = "90";
            this.MainSetBox.Name = "MainSetBox";
            this.MainSetBox.PromptChar = ' ';
            this.MainSetBox.Size = new System.Drawing.Size(45, 25);
            this.MainSetBox.TabIndex = 4;
            this.MainSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainSetBox.TextChanged += new System.EventHandler(this.AllSetBox_TextChanged);
            // 
            // ShiftSetBox
            // 
            this.ShiftSetBox.BackColor = System.Drawing.Color.Silver;
            this.ShiftSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShiftSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShiftSetBox.Location = new System.Drawing.Point(23, 125);
            this.ShiftSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShiftSetBox.Mask = "90";
            this.ShiftSetBox.Name = "ShiftSetBox";
            this.ShiftSetBox.PromptChar = ' ';
            this.ShiftSetBox.Size = new System.Drawing.Size(45, 25);
            this.ShiftSetBox.TabIndex = 24;
            this.ShiftSetBox.TabStop = false;
            this.ShiftSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DaemSetBox
            // 
            this.DaemSetBox.BackColor = System.Drawing.Color.White;
            this.DaemSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DaemSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DaemSetBox.Location = new System.Drawing.Point(23, 251);
            this.DaemSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DaemSetBox.Mask = "90";
            this.DaemSetBox.Name = "DaemSetBox";
            this.DaemSetBox.PromptChar = ' ';
            this.DaemSetBox.Size = new System.Drawing.Size(45, 25);
            this.DaemSetBox.TabIndex = 9;
            this.DaemSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DaemSetBox.TextChanged += new System.EventHandler(this.AllSetBox_TextChanged);
            // 
            // OverSetBox
            // 
            this.OverSetBox.BackColor = System.Drawing.Color.Silver;
            this.OverSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OverSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OverSetBox.Location = new System.Drawing.Point(23, 419);
            this.OverSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverSetBox.Mask = "90";
            this.OverSetBox.Name = "OverSetBox";
            this.OverSetBox.PromptChar = ' ';
            this.OverSetBox.Size = new System.Drawing.Size(45, 25);
            this.OverSetBox.TabIndex = 28;
            this.OverSetBox.TabStop = false;
            this.OverSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RezSetBox
            // 
            this.RezSetBox.BackColor = System.Drawing.Color.White;
            this.RezSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RezSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RezSetBox.Location = new System.Drawing.Point(23, 377);
            this.RezSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RezSetBox.Mask = "90";
            this.RezSetBox.Name = "RezSetBox";
            this.RezSetBox.PromptChar = ' ';
            this.RezSetBox.Size = new System.Drawing.Size(45, 25);
            this.RezSetBox.TabIndex = 14;
            this.RezSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RezSetBox.TextChanged += new System.EventHandler(this.AllSetBox_TextChanged);
            // 
            // KasrSetBox
            // 
            this.KasrSetBox.BackColor = System.Drawing.Color.White;
            this.KasrSetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KasrSetBox.Font = new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KasrSetBox.Location = new System.Drawing.Point(23, 461);
            this.KasrSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KasrSetBox.Mask = "###";
            this.KasrSetBox.Name = "KasrSetBox";
            this.KasrSetBox.PromptChar = ' ';
            this.KasrSetBox.Size = new System.Drawing.Size(45, 33);
            this.KasrSetBox.TabIndex = 29;
            this.KasrSetBox.TabStop = false;
            this.KasrSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KasrSetBox.TextChanged += new System.EventHandler(this.KasrsetBox_TextChanged);
            // 
            // LeaveSetBox
            // 
            this.LeaveSetBox.BackColor = System.Drawing.Color.Silver;
            this.LeaveSetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaveSetBox.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LeaveSetBox.Location = new System.Drawing.Point(23, 293);
            this.LeaveSetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LeaveSetBox.Mask = "90";
            this.LeaveSetBox.Name = "LeaveSetBox";
            this.LeaveSetBox.PromptChar = ' ';
            this.LeaveSetBox.Size = new System.Drawing.Size(45, 25);
            this.LeaveSetBox.TabIndex = 26;
            this.LeaveSetBox.TabStop = false;
            this.LeaveSetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Local1Label
            // 
            this.Local1Label.BackColor = System.Drawing.Color.Blue;
            this.Local1Label.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Local1Label.ForeColor = System.Drawing.Color.Yellow;
            this.Local1Label.Location = new System.Drawing.Point(0, 0);
            this.Local1Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Local1Label.Name = "Local1Label";
            this.Local1Label.Size = new System.Drawing.Size(422, 31);
            this.Local1Label.TabIndex = 122;
            this.Local1Label.Text = "---";
            this.Local1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label13.Location = new System.Drawing.Point(9, 34);
            this.Label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(73, 48);
            this.Label13.TabIndex = 76;
            this.Label13.Text = "ستادی";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.Location = new System.Drawing.Point(258, 34);
            this.Label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(73, 48);
            this.Label7.TabIndex = 55;
            this.Label7.Text = "12 ساعته شب";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Location = new System.Drawing.Point(175, 34);
            this.Label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(73, 48);
            this.Label9.TabIndex = 62;
            this.Label9.Text = "9 ساعته صبح";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.Location = new System.Drawing.Point(92, 34);
            this.Label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(73, 48);
            this.Label8.TabIndex = 69;
            this.Label8.Text = "9 ساعته عصر";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(2, 151);
            this.Label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(418, 15);
            this.Label11.TabIndex = 132;
            this.Label11.Text = resources.GetString("Label11.Text");
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label33
            // 
            this.Label33.BackColor = System.Drawing.Color.Transparent;
            this.Label33.ForeColor = System.Drawing.Color.Black;
            this.Label33.Location = new System.Drawing.Point(2, 403);
            this.Label33.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(418, 15);
            this.Label33.TabIndex = 126;
            this.Label33.Text = resources.GetString("Label33.Text");
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.Transparent;
            this.Label22.ForeColor = System.Drawing.Color.Black;
            this.Label22.Location = new System.Drawing.Point(2, 445);
            this.Label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(418, 15);
            this.Label22.TabIndex = 126;
            this.Label22.Text = resources.GetString("Label22.Text");
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label35
            // 
            this.Label35.BackColor = System.Drawing.Color.Transparent;
            this.Label35.ForeColor = System.Drawing.Color.Black;
            this.Label35.Location = new System.Drawing.Point(2, 235);
            this.Label35.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(418, 15);
            this.Label35.TabIndex = 124;
            this.Label35.Text = resources.GetString("Label35.Text");
            this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.ForeColor = System.Drawing.Color.Black;
            this.Label21.Location = new System.Drawing.Point(2, 319);
            this.Label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(418, 15);
            this.Label21.TabIndex = 125;
            this.Label21.Text = resources.GetString("Label21.Text");
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.ForeColor = System.Drawing.Color.Black;
            this.Label20.Location = new System.Drawing.Point(2, 361);
            this.Label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(418, 15);
            this.Label20.TabIndex = 124;
            this.Label20.Text = resources.GetString("Label20.Text");
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(2, 109);
            this.Label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(418, 15);
            this.Label10.TabIndex = 116;
            this.Label10.Text = resources.GetString("Label10.Text");
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(2, 193);
            this.Label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(418, 15);
            this.Label16.TabIndex = 116;
            this.Label16.Text = resources.GetString("Label16.Text");
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.ForeColor = System.Drawing.Color.Black;
            this.Label19.Location = new System.Drawing.Point(2, 277);
            this.Label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(418, 15);
            this.Label19.TabIndex = 123;
            this.Label19.Text = resources.GetString("Label19.Text");
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.PersianCalendar.Location = new System.Drawing.Point(79, 19);
            this.PersianCalendar.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalendar.Name = "PersianCalendar";
            this.PersianCalendar.NowDateSelected = true;
            this.PersianCalendar.ReadOnly = true;
            this.PersianCalendar.SelectedDate = null;
            this.PersianCalendar.Shamsi = null;
            this.PersianCalendar.Size = new System.Drawing.Size(135, 23);
            this.PersianCalendar.TabIndex = 1;
            this.PersianCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.BackColor = System.Drawing.Color.Transparent;
            this.Label30.ForeColor = System.Drawing.Color.Black;
            this.Label30.Location = new System.Drawing.Point(214, 22);
            this.Label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(39, 16);
            this.Label30.TabIndex = 49;
            this.Label30.Text = "تاریخ:";
            this.Label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.BackColor = System.Drawing.Color.Transparent;
            this.Label36.ForeColor = System.Drawing.Color.Black;
            this.Label36.Location = new System.Drawing.Point(433, 270);
            this.Label36.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(95, 16);
            this.Label36.TabIndex = 49;
            this.Label36.Text = "راهبران غیر دائم";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(433, 186);
            this.Label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(89, 16);
            this.Label12.TabIndex = 51;
            this.Label12.Text = "راهبران کشیک";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.Color.Transparent;
            this.Label32.ForeColor = System.Drawing.Color.Black;
            this.Label32.Location = new System.Drawing.Point(433, 354);
            this.Label32.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(96, 16);
            this.Label32.TabIndex = 45;
            this.Label32.Text = "راهبران بازآموزی";
            this.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.ForeColor = System.Drawing.Color.Black;
            this.Label23.Location = new System.Drawing.Point(433, 102);
            this.Label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(97, 16);
            this.Label23.TabIndex = 42;
            this.Label23.Text = "راهبران مورد نیاز";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(433, 312);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(85, 16);
            this.Label6.TabIndex = 50;
            this.Label6.Text = "مرخصی روزانه";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KindCombo.FormattingEnabled = true;
            this.KindCombo.Items.AddRange(new object[] {
            "روز خاص"});
            this.KindCombo.Location = new System.Drawing.Point(79, 84);
            this.KindCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KindCombo.Name = "KindCombo";
            this.KindCombo.Size = new System.Drawing.Size(135, 24);
            this.KindCombo.TabIndex = 2;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(214, 88);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 16);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "نوع پردازش:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameCombo
            // 
            this.NameCombo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameCombo.FormattingEnabled = true;
            this.NameCombo.Location = new System.Drawing.Point(11, 117);
            this.NameCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameCombo.Name = "NameCombo";
            this.NameCombo.Size = new System.Drawing.Size(203, 24);
            this.NameCombo.TabIndex = 3;
            this.NameCombo.SelectedIndexChanged += new System.EventHandler(this.NameCombo_SelectedIndexChanged);
            // 
            // ProcessButton
            // 
            this.ProcessButton.BackColor = System.Drawing.Color.Transparent;
            this.ProcessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessButton.Enabled = false;
            this.ProcessButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProcessButton.ForeColor = System.Drawing.Color.Black;
            this.ProcessButton.Image = global::Metro_Operation.Properties.Resources.to_do_list;
            this.ProcessButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcessButton.Location = new System.Drawing.Point(146, 391);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(135, 39);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "پردازش";
            this.ProcessButton.UseVisualStyleBackColor = false;
            this.ProcessButton.EnabledChanged += new System.EventHandler(this.ProcessButton_EnabledChanged);
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(214, 121);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "نام پردازش:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(433, 478);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 23);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "تراز نفرات";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(433, 396);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 16);
            this.Label2.TabIndex = 46;
            this.Label2.Text = " راهبران رزرو";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(433, 438);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(99, 16);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "راهبران اضافه کار";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.Location = new System.Drawing.Point(433, 144);
            this.Label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(88, 16);
            this.Label17.TabIndex = 43;
            this.Label17.Text = "راهبران شیفت";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(433, 228);
            this.Label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(104, 16);
            this.Label18.TabIndex = 44;
            this.Label18.Text = "راهبران خط اصلی";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeekLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeekLabel.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WeekLabel.ForeColor = System.Drawing.Color.Black;
            this.WeekLabel.Location = new System.Drawing.Point(20, 270);
            this.WeekLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(250, 92);
            this.WeekLabel.TabIndex = 30;
            this.WeekLabel.Text = "جدول اجرا شده :\r\nجمعه و تعطیل\r\n1402070174 جمعه ارديبهشت 1403";
            this.WeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WeekLabel.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.AutoSize = true;
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label15);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.HgrLabel);
            this.Panel1.Controls.Add(this.GolLabel);
            this.Panel1.Controls.Add(this.TehLabel);
            this.Panel1.Controls.Add(this.PrintButton);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label14);
            this.Panel1.Controls.Add(this.ProcessButton);
            this.Panel1.Controls.Add(this.WeekLabel);
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.NameCombo);
            this.Panel1.Controls.Add(this.Label30);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(537, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(295, 500);
            this.Panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(122, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 23);
            this.label15.TabIndex = 56;
            this.label15.Text = "گزینه های پردازش لوحه";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.TrainnigUseCheck);
            this.Panel3.Controls.Add(this.OvertimeUseCheck);
            this.Panel3.Location = new System.Drawing.Point(20, 178);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(250, 77);
            this.Panel3.TabIndex = 55;
            // 
            // TrainnigUseCheck
            // 
            this.TrainnigUseCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TrainnigUseCheck.Location = new System.Drawing.Point(9, 44);
            this.TrainnigUseCheck.Name = "TrainnigUseCheck";
            this.TrainnigUseCheck.Size = new System.Drawing.Size(230, 24);
            this.TrainnigUseCheck.TabIndex = 54;
            this.TrainnigUseCheck.Text = "کمک راهبران بدون مجوز";
            this.TrainnigUseCheck.UseVisualStyleBackColor = false;
            this.TrainnigUseCheck.CheckedChanged += new System.EventHandler(this.TrainnigUseCheck_CheckedChanged);
            // 
            // OvertimeUseCheck
            // 
            this.OvertimeUseCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OvertimeUseCheck.Location = new System.Drawing.Point(9, 14);
            this.OvertimeUseCheck.Name = "OvertimeUseCheck";
            this.OvertimeUseCheck.Size = new System.Drawing.Size(230, 24);
            this.OvertimeUseCheck.TabIndex = 54;
            this.OvertimeUseCheck.Text = "راهبران دارای مازاد اضافه کار";
            this.OvertimeUseCheck.UseVisualStyleBackColor = false;
            this.OvertimeUseCheck.CheckedChanged += new System.EventHandler(this.TrainnigUseCheck_CheckedChanged);
            // 
            // HgrLabel
            // 
            this.HgrLabel.BackColor = System.Drawing.Color.Tomato;
            this.HgrLabel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HgrLabel.ForeColor = System.Drawing.Color.Black;
            this.HgrLabel.Location = new System.Drawing.Point(10, 459);
            this.HgrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HgrLabel.Name = "HgrLabel";
            this.HgrLabel.Size = new System.Drawing.Size(85, 26);
            this.HgrLabel.TabIndex = 53;
            this.HgrLabel.Text = "هشتگرد";
            this.HgrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HgrLabel.BackColorChanged += new System.EventHandler(this.TehLabel_BackColorChanged);
            // 
            // GolLabel
            // 
            this.GolLabel.BackColor = System.Drawing.Color.Tomato;
            this.GolLabel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GolLabel.ForeColor = System.Drawing.Color.Black;
            this.GolLabel.Location = new System.Drawing.Point(104, 459);
            this.GolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GolLabel.Name = "GolLabel";
            this.GolLabel.Size = new System.Drawing.Size(85, 26);
            this.GolLabel.TabIndex = 53;
            this.GolLabel.Text = "گلشهر";
            this.GolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GolLabel.BackColorChanged += new System.EventHandler(this.TehLabel_BackColorChanged);
            // 
            // TehLabel
            // 
            this.TehLabel.BackColor = System.Drawing.Color.Tomato;
            this.TehLabel.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TehLabel.ForeColor = System.Drawing.Color.Black;
            this.TehLabel.Location = new System.Drawing.Point(197, 459);
            this.TehLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TehLabel.Name = "TehLabel";
            this.TehLabel.Size = new System.Drawing.Size(85, 26);
            this.TehLabel.TabIndex = 53;
            this.TehLabel.Text = "تهران";
            this.TehLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TehLabel.BackColorChanged += new System.EventHandler(this.TehLabel_BackColorChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Transparent;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.Enabled = false;
            this.PrintButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintButton.ForeColor = System.Drawing.Color.Black;
            this.PrintButton.Image = global::Metro_Operation.Properties.Resources.print_button;
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.Location = new System.Drawing.Point(9, 391);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(135, 39);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "چاپ";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.EnabledChanged += new System.EventHandler(this.PrintButton_EnabledChanged);
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Items.AddRange(new object[] {
            "تهران",
            "گلشهر",
            "هشتگرد"});
            this.LocalCombo.Location = new System.Drawing.Point(79, 51);
            this.LocalCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(135, 24);
            this.LocalCombo.TabIndex = 0;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(214, 55);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(35, 16);
            this.Label14.TabIndex = 52;
            this.Label14.Text = "مبدا:";
            // 
            // DailyTripProcessForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 521);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label36);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label32);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyTripProcessForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پردازش لوحه روزانه";
            this.Load += new System.EventHandler(this.DailyTripProcessForm_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private MaskedTextBox Keshik12RBox;
		private MaskedTextBox Keshik12SBox;
		private Panel Panel2;
		private MaskedTextBox Shift12RBox;
		private MaskedTextBox Keshik9SBox;
		private MaskedTextBox Keshik9ABox;
		private MaskedTextBox KeshikSetBox;
		private MaskedTextBox All12RBox;
		private MaskedTextBox Main12RBox;
		private MaskedTextBox Daem12RBox;
		private MaskedTextBox Rez12RBox;
		private MaskedTextBox Leave12RBox;
		private MaskedTextBox Kasr12RBox;
		private MaskedTextBox Class12RBox;
		private MaskedTextBox Over12RBox;
		private MaskedTextBox All12SBox;
		private MaskedTextBox Main12SBox;
		private MaskedTextBox Shift12SBox;
		private MaskedTextBox Daem12SBox;
		private MaskedTextBox Rez12SBox;
		private MaskedTextBox Leave12SBox;
		private MaskedTextBox Class12SBox;
		private MaskedTextBox Kasr12SBox;
		private MaskedTextBox Over12SBox;
		private MaskedTextBox Main9SBox;
		private MaskedTextBox All9SBox;
		private MaskedTextBox Daem9SBox;
		private MaskedTextBox Shift9SBox;
		private MaskedTextBox Rez9SBox;
		private MaskedTextBox Leave9SBox;
		private MaskedTextBox Class9SBox;
		private MaskedTextBox Kasr9SBox;
		private MaskedTextBox Over9SBox;
		private MaskedTextBox Main9ABox;
		private MaskedTextBox All9ABox;
		private MaskedTextBox Daem9ABox;
		private MaskedTextBox Shift9ABox;
		private MaskedTextBox Rez9ABox;
		private MaskedTextBox Leave9ABox;
		private MaskedTextBox Class9ABox;
		private MaskedTextBox Kasr9ABox;
		private MaskedTextBox Over9ABox;
		private MaskedTextBox AllSetBox;
		private MaskedTextBox ClassSetBox;
		private MaskedTextBox MainSetBox;
		private MaskedTextBox ShiftSetBox;
		private MaskedTextBox DaemSetBox;
		private MaskedTextBox OverSetBox;
		private MaskedTextBox RezSetBox;
		private MaskedTextBox KasrSetBox;
		private MaskedTextBox LeaveSetBox;
		private Label Local1Label;
		private Label Label13;
		private Label Label1a;
		private Label Label7;
		private Label Label9;
		private Label Label8;
		private Label Label11;
		private Label Label33;
		private Label Label22;
		private Label Label35;
		private Label Label21;
		private Label Label20;
		private Label Label10;
		private Label Label16;
		private Label Label19;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private Label Label30;
		private Label Label36;
		private Label Label12;
		private Label Label32;
		private Label Label23;
		private Label Label6;
		private ComboBox KindCombo;
		private Label Label3;
		private ComboBox NameCombo;
		private Button ProcessButton;
		private Label Label1;
		private Label Label5;
		private Label Label2;
		private Label Label4;
		private Label Label17;
		private Label Label18;
		private Label WeekLabel;
		private Panel Panel1;
		private ComboBox LocalCombo;
		private Label Label14;
		private Button PrintButton;
		private Label HgrLabel;
		private Label GolLabel;
		private Label TehLabel;
		private CheckBox TrainnigUseCheck;
        private System.ComponentModel.IContainer components;
        private Label label15;
        private Panel Panel3;
        private CheckBox OvertimeUseCheck;
    }
	
}
