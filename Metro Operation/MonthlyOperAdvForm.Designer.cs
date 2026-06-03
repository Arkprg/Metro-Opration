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
    public partial class MonthlyOperAdvForm : BaseForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonthCombo = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.YearCombo = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.PervButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ShiftCombo = new System.Windows.Forms.ComboBox();
            this.PostCombo = new System.Windows.Forms.ComboBox();
            this.TimeCombo = new System.Windows.Forms.ComboBox();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Shift1Label = new System.Windows.Forms.Label();
            this.Post1Label = new System.Windows.Forms.Label();
            this.Local1Label = new System.Windows.Forms.Label();
            this.Time1Label = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.PNum1Label = new System.Windows.Forms.Label();
            this.Family1Label = new System.Windows.Forms.Label();
            this.Name1Label = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.SumFriText = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.SumOverText = new System.Windows.Forms.Label();
            this.NextMonthText = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.FogFriText = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.NegText = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.TimeLeavText = new System.Windows.Forms.Label();
            this.DayLeavText = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.PosText = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LastMonthText = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.ShiftOverText = new System.Windows.Forms.Label();
            this.TripText = new System.Windows.Forms.Label();
            this.OverFriText = new System.Windows.Forms.Label();
            this.ShiftFriText = new System.Windows.Forms.Label();
            this.OverText = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Label92 = new System.Windows.Forms.Label();
            this.Label83 = new System.Windows.Forms.Label();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label65 = new System.Windows.Forms.Label();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.FootOverLabel = new System.Windows.Forms.Label();
            this.HamkOverLabel = new System.Windows.Forms.Label();
            this.JayOverLabel = new System.Windows.Forms.Label();
            this.MotfOverLabel = new System.Windows.Forms.Label();
            this.KeshOverLabel = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label68 = new System.Windows.Forms.Label();
            this.Label70 = new System.Windows.Forms.Label();
            this.Panel11 = new System.Windows.Forms.Panel();
            this.ShftTripLabel = new System.Windows.Forms.Label();
            this.DailyTripLabel = new System.Windows.Forms.Label();
            this.DiffrTripLabel = new System.Windows.Forms.Label();
            this.CalcTripLabel = new System.Windows.Forms.Label();
            this.Label64 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label89 = new System.Windows.Forms.Label();
            this.Label91 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.MorTimeLabel = new System.Windows.Forms.Label();
            this.MorFriLabel = new System.Windows.Forms.Label();
            this.MorNormLabel = new System.Windows.Forms.Label();
            this.Label80 = new System.Windows.Forms.Label();
            this.Label81 = new System.Windows.Forms.Label();
            this.Label82 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.RezTripLabel = new System.Windows.Forms.Label();
            this.RezFriLabel = new System.Windows.Forms.Label();
            this.RezNormLabel = new System.Windows.Forms.Label();
            this.Label71 = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.ShftTotaLabel = new System.Windows.Forms.Label();
            this.ShftFriLabel = new System.Windows.Forms.Label();
            this.ShftNormLabel = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label62 = new System.Windows.Forms.Label();
            this.Label63 = new System.Windows.Forms.Label();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.TptalFog2Label = new System.Windows.Forms.Label();
            this.TotalFri2Label = new System.Windows.Forms.Label();
            this.TotalOver2Label = new System.Windows.Forms.Label();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label60 = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Shift2Label = new System.Windows.Forms.Label();
            this.Post2Label = new System.Windows.Forms.Label();
            this.Local2Label = new System.Windows.Forms.Label();
            this.Time2Label = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.PNum2Label = new System.Windows.Forms.Label();
            this.Family2Label = new System.Windows.Forms.Label();
            this.Name2Label = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.Label33 = new System.Windows.Forms.Label();
            this.Panel13 = new System.Windows.Forms.Panel();
            this.TptalFog3Label = new System.Windows.Forms.Label();
            this.TotalFri3Label = new System.Windows.Forms.Label();
            this.TotalOver3Label = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.Panel14 = new System.Windows.Forms.Panel();
            this.Shift3Label = new System.Windows.Forms.Label();
            this.Post3Label = new System.Windows.Forms.Label();
            this.Local3Label = new System.Windows.Forms.Label();
            this.Time3Label = new System.Windows.Forms.Label();
            this.Label76 = new System.Windows.Forms.Label();
            this.Label77 = new System.Windows.Forms.Label();
            this.Label78 = new System.Windows.Forms.Label();
            this.Label79 = new System.Windows.Forms.Label();
            this.PNum3Label = new System.Windows.Forms.Label();
            this.Family3Label = new System.Windows.Forms.Label();
            this.Name3Label = new System.Windows.Forms.Label();
            this.Label87 = new System.Windows.Forms.Label();
            this.Label88 = new System.Windows.Forms.Label();
            this.Label90 = new System.Windows.Forms.Label();
            this.Daily2GridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daily1GridView = new System.Windows.Forms.DataGridView();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.Panel13.SuspendLayout();
            this.Panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Daily2GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daily1GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthCombo
            // 
            this.MonthCombo.BackColor = System.Drawing.SystemColors.Window;
            this.MonthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombo.FormattingEnabled = true;
            this.MonthCombo.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.MonthCombo.Location = new System.Drawing.Point(340, 29);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.Size = new System.Drawing.Size(90, 22);
            this.MonthCombo.TabIndex = 2;
            this.MonthCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(551, 33);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 14);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "سال:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(430, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 14);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "ماه:";
            // 
            // YearCombo
            // 
            this.YearCombo.BackColor = System.Drawing.Color.White;
            this.YearCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCombo.FormattingEnabled = true;
            this.YearCombo.Location = new System.Drawing.Point(468, 29);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.Size = new System.Drawing.Size(83, 22);
            this.YearCombo.TabIndex = 1;
            this.YearCombo.SelectedIndexChanged += new System.EventHandler(this.YearCombo_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(1006, 49);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(38, 14);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "پست:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(745, 49);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 14);
            this.Label8.TabIndex = 41;
            this.Label8.Text = "نام شیفت:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(1006, 18);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(31, 14);
            this.Label9.TabIndex = 36;
            this.Label9.Text = "مبدا:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(745, 18);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(63, 14);
            this.Label10.TabIndex = 40;
            this.Label10.Text = "نوع شیفت:";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(159, 24);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(120, 35);
            this.ShowButton.TabIndex = 33;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // PervButton
            // 
            this.PervButton.Image = global::Metro_Operation.Properties.Resources._32;
            this.PervButton.Location = new System.Drawing.Point(591, 28);
            this.PervButton.Name = "PervButton";
            this.PervButton.Size = new System.Drawing.Size(29, 27);
            this.PervButton.TabIndex = 42;
            this.PervButton.UseVisualStyleBackColor = true;
            this.PervButton.Click += new System.EventHandler(this.PervButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Image = global::Metro_Operation.Properties.Resources._31;
            this.NextButton.Location = new System.Drawing.Point(305, 28);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(29, 27);
            this.NextButton.TabIndex = 42;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled = true;
            this.ShiftCombo.Location = new System.Drawing.Point(655, 45);
            this.ShiftCombo.Name = "ShiftCombo";
            this.ShiftCombo.Size = new System.Drawing.Size(90, 22);
            this.ShiftCombo.TabIndex = 39;
            // 
            // PostCombo
            // 
            this.PostCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCombo.FormattingEnabled = true;
            this.PostCombo.Location = new System.Drawing.Point(826, 45);
            this.PostCombo.Name = "PostCombo";
            this.PostCombo.Size = new System.Drawing.Size(180, 22);
            this.PostCombo.TabIndex = 35;
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            // 
            // TimeCombo
            // 
            this.TimeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.FormattingEnabled = true;
            this.TimeCombo.Location = new System.Drawing.Point(655, 14);
            this.TimeCombo.Name = "TimeCombo";
            this.TimeCombo.Size = new System.Drawing.Size(90, 22);
            this.TimeCombo.TabIndex = 38;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(826, 14);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(180, 22);
            this.LocalCombo.TabIndex = 37;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PervButton);
            this.Panel1.Controls.Add(this.NextButton);
            this.Panel1.Controls.Add(this.MonthCombo);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.YearCombo);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1060, 83);
            this.Panel1.TabIndex = 3;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(19, 24);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(120, 35);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "ذخیره";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl1.ItemSize = new System.Drawing.Size(95, 25);
            this.TabControl1.Location = new System.Drawing.Point(0, 100);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new System.Drawing.Point(0, 0);
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1084, 530);
            this.TabControl1.TabIndex = 4;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Tan;
            this.TabPage1.Controls.Add(this.ShowGridView);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1076, 497);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "لیست پرسنل";
            // 
            // ShowGridView
            // 
            this.ShowGridView.AllowUserToAddRows = false;
            this.ShowGridView.AllowUserToDeleteRows = false;
            this.ShowGridView.AllowUserToResizeColumns = false;
            this.ShowGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ShowGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight = 55;
            this.ShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column1,
            this.Column11,
            this.Column2,
            this.Column22,
            this.Column4,
            this.Column7,
            this.Column14,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column17,
            this.Column12,
            this.Column10,
            this.Column15,
            this.Column13,
            this.Column18,
            this.Column19,
            this.Column20});
            this.ShowGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(0, 0);
            this.ShowGridView.MultiSelect = false;
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(1076, 497);
            this.ShowGridView.TabIndex = 0;
            this.ShowGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGridView_CellClick);
            this.ShowGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGridView_CellDoubleClick);
            this.ShowGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowGridView_ColumnHeaderMouseClick);
            // 
            // Column16
            // 
            this.Column16.HeaderText = "ردیف";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "نام";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "نام خانوادگی";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "شماره پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "تعداد تریپ";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "مازاد ماه قبل ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "روزکاری";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "کارکرد عادی شیفت";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "کارکرد جمعه شیفت";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 65;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "اضافه کار عادی ثبت شده";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "اضافه کار جمعه ثبت شده";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 65;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "مرخصی ساعتی";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 65;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "مرخصی روزانه";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "فوق العاده جمعه کاری";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 65;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "مجموع اضافه کار جمعه";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 65;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "مجموع اضافه کار عادی";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 65;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "مازاد اضافه کار";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 60;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "محاسبه";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "مبدا";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "نوع شیفت";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "نام شیفت";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TabPage2.Controls.Add(this.Panel3);
            this.TabPage2.Controls.Add(this.Label43);
            this.TabPage2.Controls.Add(this.Panel5);
            this.TabPage2.Controls.Add(this.Label28);
            this.TabPage2.Controls.Add(this.Panel4);
            this.TabPage2.Controls.Add(this.Panel2);
            this.TabPage2.Controls.Add(this.Label44);
            this.TabPage2.Controls.Add(this.Label45);
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(1076, 497);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "نمایش جزئیات";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Shift1Label);
            this.Panel3.Controls.Add(this.Post1Label);
            this.Panel3.Controls.Add(this.Local1Label);
            this.Panel3.Controls.Add(this.Time1Label);
            this.Panel3.Controls.Add(this.Label34);
            this.Panel3.Controls.Add(this.Label50);
            this.Panel3.Controls.Add(this.Label32);
            this.Panel3.Controls.Add(this.Label35);
            this.Panel3.Controls.Add(this.PNum1Label);
            this.Panel3.Controls.Add(this.Family1Label);
            this.Panel3.Controls.Add(this.Name1Label);
            this.Panel3.Controls.Add(this.Label13);
            this.Panel3.Controls.Add(this.Label11);
            this.Panel3.Controls.Add(this.Label12);
            this.Panel3.Location = new System.Drawing.Point(709, 23);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(347, 296);
            this.Panel3.TabIndex = 30;
            // 
            // Shift1Label
            // 
            this.Shift1Label.BackColor = System.Drawing.Color.Transparent;
            this.Shift1Label.ForeColor = System.Drawing.Color.Maroon;
            this.Shift1Label.Location = new System.Drawing.Point(47, 246);
            this.Shift1Label.Name = "Shift1Label";
            this.Shift1Label.Size = new System.Drawing.Size(129, 24);
            this.Shift1Label.TabIndex = 9;
            this.Shift1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Post1Label
            // 
            this.Post1Label.BackColor = System.Drawing.Color.Transparent;
            this.Post1Label.ForeColor = System.Drawing.Color.Maroon;
            this.Post1Label.Location = new System.Drawing.Point(47, 132);
            this.Post1Label.Name = "Post1Label";
            this.Post1Label.Size = new System.Drawing.Size(129, 24);
            this.Post1Label.TabIndex = 8;
            this.Post1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Local1Label
            // 
            this.Local1Label.BackColor = System.Drawing.Color.Transparent;
            this.Local1Label.ForeColor = System.Drawing.Color.Maroon;
            this.Local1Label.Location = new System.Drawing.Point(47, 170);
            this.Local1Label.Name = "Local1Label";
            this.Local1Label.Size = new System.Drawing.Size(129, 24);
            this.Local1Label.TabIndex = 8;
            this.Local1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time1Label
            // 
            this.Time1Label.BackColor = System.Drawing.Color.Transparent;
            this.Time1Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Time1Label.ForeColor = System.Drawing.Color.Maroon;
            this.Time1Label.Location = new System.Drawing.Point(47, 208);
            this.Time1Label.Name = "Time1Label";
            this.Time1Label.Size = new System.Drawing.Size(129, 24);
            this.Time1Label.TabIndex = 8;
            this.Time1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label34.Location = new System.Drawing.Point(174, 248);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(82, 18);
            this.Label34.TabIndex = 7;
            this.Label34.Text = "نام شیفت :";
            // 
            // Label50
            // 
            this.Label50.AutoSize = true;
            this.Label50.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label50.Location = new System.Drawing.Point(174, 172);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(43, 18);
            this.Label50.TabIndex = 6;
            this.Label50.Text = "مبدا :";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label32.Location = new System.Drawing.Point(174, 134);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(112, 18);
            this.Label32.TabIndex = 6;
            this.Label32.Text = "پست سازمانی :";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label35.Location = new System.Drawing.Point(174, 210);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(85, 18);
            this.Label35.TabIndex = 6;
            this.Label35.Text = "نوع شیفت :";
            // 
            // PNum1Label
            // 
            this.PNum1Label.BackColor = System.Drawing.Color.Transparent;
            this.PNum1Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PNum1Label.ForeColor = System.Drawing.Color.Maroon;
            this.PNum1Label.Location = new System.Drawing.Point(47, 94);
            this.PNum1Label.Name = "PNum1Label";
            this.PNum1Label.Size = new System.Drawing.Size(129, 24);
            this.PNum1Label.TabIndex = 5;
            this.PNum1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Family1Label
            // 
            this.Family1Label.BackColor = System.Drawing.Color.Transparent;
            this.Family1Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Family1Label.ForeColor = System.Drawing.Color.Maroon;
            this.Family1Label.Location = new System.Drawing.Point(47, 56);
            this.Family1Label.Name = "Family1Label";
            this.Family1Label.Size = new System.Drawing.Size(129, 24);
            this.Family1Label.TabIndex = 4;
            this.Family1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name1Label
            // 
            this.Name1Label.BackColor = System.Drawing.Color.Transparent;
            this.Name1Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name1Label.ForeColor = System.Drawing.Color.Maroon;
            this.Name1Label.Location = new System.Drawing.Point(47, 18);
            this.Name1Label.Name = "Name1Label";
            this.Name1Label.Size = new System.Drawing.Size(129, 24);
            this.Name1Label.TabIndex = 3;
            this.Name1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label13.Location = new System.Drawing.Point(174, 96);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(88, 18);
            this.Label13.TabIndex = 2;
            this.Label13.Text = "کد پرسنلی :";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label11.Location = new System.Drawing.Point(174, 20);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(35, 18);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "نام :";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label12.Location = new System.Drawing.Point(174, 58);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(98, 18);
            this.Label12.TabIndex = 1;
            this.Label12.Text = "نام خانوادگی :";
            // 
            // Label43
            // 
            this.Label43.BackColor = System.Drawing.Color.Transparent;
            this.Label43.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label43.ForeColor = System.Drawing.Color.White;
            this.Label43.Location = new System.Drawing.Point(843, 276);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(79, 116);
            this.Label43.TabIndex = 36;
            this.Label43.Text = ".";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Transparent;
            this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.SumFriText);
            this.Panel5.Controls.Add(this.Label24);
            this.Panel5.Controls.Add(this.Label26);
            this.Panel5.Controls.Add(this.SumOverText);
            this.Panel5.Controls.Add(this.NextMonthText);
            this.Panel5.Controls.Add(this.Label25);
            this.Panel5.Controls.Add(this.FogFriText);
            this.Panel5.Controls.Add(this.Label23);
            this.Panel5.Location = new System.Drawing.Point(16, 334);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(678, 140);
            this.Panel5.TabIndex = 32;
            // 
            // SumFriText
            // 
            this.SumFriText.BackColor = System.Drawing.Color.Black;
            this.SumFriText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SumFriText.ForeColor = System.Drawing.Color.Yellow;
            this.SumFriText.Location = new System.Drawing.Point(368, 74);
            this.SumFriText.Name = "SumFriText";
            this.SumFriText.Size = new System.Drawing.Size(100, 49);
            this.SumFriText.TabIndex = 26;
            this.SumFriText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label24.Location = new System.Drawing.Point(469, 89);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(175, 19);
            this.Label24.TabIndex = 13;
            this.Label24.Text = "مجموع اضافه کار جمعه :";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label26.Location = new System.Drawing.Point(469, 31);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(172, 19);
            this.Label26.TabIndex = 15;
            this.Label26.Text = "مجموع اضافه کار عادی :";
            // 
            // SumOverText
            // 
            this.SumOverText.BackColor = System.Drawing.Color.Black;
            this.SumOverText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SumOverText.ForeColor = System.Drawing.Color.Yellow;
            this.SumOverText.Location = new System.Drawing.Point(368, 16);
            this.SumOverText.Name = "SumOverText";
            this.SumOverText.Size = new System.Drawing.Size(100, 49);
            this.SumOverText.TabIndex = 27;
            this.SumOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextMonthText
            // 
            this.NextMonthText.BackColor = System.Drawing.Color.Black;
            this.NextMonthText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextMonthText.ForeColor = System.Drawing.Color.Fuchsia;
            this.NextMonthText.Location = new System.Drawing.Point(51, 74);
            this.NextMonthText.Name = "NextMonthText";
            this.NextMonthText.Size = new System.Drawing.Size(100, 49);
            this.NextMonthText.TabIndex = 28;
            this.NextMonthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label25.Location = new System.Drawing.Point(151, 89);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(116, 19);
            this.Label25.TabIndex = 14;
            this.Label25.Text = "مازاد اضافه کار :";
            // 
            // FogFriText
            // 
            this.FogFriText.BackColor = System.Drawing.Color.Black;
            this.FogFriText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FogFriText.ForeColor = System.Drawing.Color.Cyan;
            this.FogFriText.Location = new System.Drawing.Point(51, 16);
            this.FogFriText.Name = "FogFriText";
            this.FogFriText.Size = new System.Drawing.Size(100, 49);
            this.FogFriText.TabIndex = 22;
            this.FogFriText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Label23.Location = new System.Drawing.Point(151, 31);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(171, 19);
            this.Label23.TabIndex = 12;
            this.Label23.Text = "فوق العاده جمعه کاری :";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label28.ForeColor = System.Drawing.Color.Black;
            this.Label28.Location = new System.Drawing.Point(706, 421);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(347, 16);
            this.Label28.TabIndex = 6;
            this.Label28.Text = "با کلیک روی اعداد ستاره دار جزئیات ثبت شده را مشاهده کنید";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Transparent;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.Label27);
            this.Panel4.Controls.Add(this.Label31);
            this.Panel4.Controls.Add(this.NegText);
            this.Panel4.Controls.Add(this.Label30);
            this.Panel4.Controls.Add(this.Label29);
            this.Panel4.Controls.Add(this.Label14);
            this.Panel4.Controls.Add(this.Label15);
            this.Panel4.Controls.Add(this.Label16);
            this.Panel4.Controls.Add(this.TimeLeavText);
            this.Panel4.Controls.Add(this.DayLeavText);
            this.Panel4.Controls.Add(this.Label22);
            this.Panel4.Controls.Add(this.PosText);
            this.Panel4.Location = new System.Drawing.Point(16, 23);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(316, 296);
            this.Panel4.TabIndex = 31;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label27.ForeColor = System.Drawing.Color.Red;
            this.Label27.Location = new System.Drawing.Point(30, 206);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(18, 18);
            this.Label27.TabIndex = 27;
            this.Label27.Text = "*";
            this.Label27.Visible = false;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label31.ForeColor = System.Drawing.Color.Red;
            this.Label31.Location = new System.Drawing.Point(29, 73);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(18, 18);
            this.Label31.TabIndex = 27;
            this.Label31.Text = "*";
            // 
            // NegText
            // 
            this.NegText.BackColor = System.Drawing.Color.Black;
            this.NegText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NegText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NegText.Location = new System.Drawing.Point(51, 237);
            this.NegText.Name = "NegText";
            this.NegText.Size = new System.Drawing.Size(100, 35);
            this.NegText.TabIndex = 23;
            this.NegText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NegText.Visible = false;
            this.NegText.Click += new System.EventHandler(this.NegText_Click);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label30.ForeColor = System.Drawing.Color.Red;
            this.Label30.Location = new System.Drawing.Point(29, 30);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(18, 18);
            this.Label30.TabIndex = 27;
            this.Label30.Text = "*";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label29.ForeColor = System.Drawing.Color.Red;
            this.Label29.Location = new System.Drawing.Point(30, 245);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(18, 18);
            this.Label29.TabIndex = 27;
            this.Label29.Text = "*";
            this.Label29.Visible = false;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label14.Location = new System.Drawing.Point(152, 245);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(90, 18);
            this.Label14.TabIndex = 3;
            this.Label14.Text = "امتیاز منفی :";
            this.Label14.Visible = false;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label15.Location = new System.Drawing.Point(152, 30);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(123, 18);
            this.Label15.TabIndex = 4;
            this.Label15.Text = "مرخصی ساعتی :";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label16.Location = new System.Drawing.Point(152, 73);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(108, 18);
            this.Label16.TabIndex = 5;
            this.Label16.Text = "مرخصی روزانه :";
            // 
            // TimeLeavText
            // 
            this.TimeLeavText.BackColor = System.Drawing.Color.Black;
            this.TimeLeavText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeLeavText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeavText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TimeLeavText.Location = new System.Drawing.Point(51, 22);
            this.TimeLeavText.Name = "TimeLeavText";
            this.TimeLeavText.Size = new System.Drawing.Size(100, 35);
            this.TimeLeavText.TabIndex = 24;
            this.TimeLeavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLeavText.Click += new System.EventHandler(this.TimeLeavText_Click);
            // 
            // DayLeavText
            // 
            this.DayLeavText.BackColor = System.Drawing.Color.Black;
            this.DayLeavText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DayLeavText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLeavText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DayLeavText.Location = new System.Drawing.Point(51, 65);
            this.DayLeavText.Name = "DayLeavText";
            this.DayLeavText.Size = new System.Drawing.Size(100, 35);
            this.DayLeavText.TabIndex = 25;
            this.DayLeavText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DayLeavText.Click += new System.EventHandler(this.DayLeavText_Click);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label22.Location = new System.Drawing.Point(152, 206);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(86, 18);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "امتیاز مثبت :";
            this.Label22.Visible = false;
            // 
            // PosText
            // 
            this.PosText.BackColor = System.Drawing.Color.Black;
            this.PosText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PosText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosText.ForeColor = System.Drawing.Color.Cyan;
            this.PosText.Location = new System.Drawing.Point(51, 198);
            this.PosText.Name = "PosText";
            this.PosText.Size = new System.Drawing.Size(100, 35);
            this.PosText.TabIndex = 21;
            this.PosText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PosText.Visible = false;
            this.PosText.Click += new System.EventHandler(this.PosText_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label37);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.LastMonthText);
            this.Panel2.Controls.Add(this.Label17);
            this.Panel2.Controls.Add(this.Label18);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.Label20);
            this.Panel2.Controls.Add(this.Label36);
            this.Panel2.Controls.Add(this.Label21);
            this.Panel2.Controls.Add(this.ShiftOverText);
            this.Panel2.Controls.Add(this.TripText);
            this.Panel2.Controls.Add(this.OverFriText);
            this.Panel2.Controls.Add(this.ShiftFriText);
            this.Panel2.Controls.Add(this.OverText);
            this.Panel2.Location = new System.Drawing.Point(347, 23);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(347, 296);
            this.Panel2.TabIndex = 29;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label37.ForeColor = System.Drawing.Color.Red;
            this.Label37.Location = new System.Drawing.Point(16, 245);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(18, 18);
            this.Label37.TabIndex = 27;
            this.Label37.Text = "*";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.ForeColor = System.Drawing.Color.Red;
            this.Label4.Location = new System.Drawing.Point(16, 202);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(18, 18);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "*";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label3.ForeColor = System.Drawing.Color.Red;
            this.Label3.Location = new System.Drawing.Point(16, 159);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(18, 18);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "*";
            // 
            // LastMonthText
            // 
            this.LastMonthText.BackColor = System.Drawing.Color.Black;
            this.LastMonthText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastMonthText.ForeColor = System.Drawing.Color.Cyan;
            this.LastMonthText.Location = new System.Drawing.Point(37, 22);
            this.LastMonthText.Name = "LastMonthText";
            this.LastMonthText.Size = new System.Drawing.Size(100, 35);
            this.LastMonthText.TabIndex = 16;
            this.LastMonthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label17.Location = new System.Drawing.Point(137, 30);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(97, 18);
            this.Label17.TabIndex = 6;
            this.Label17.Text = "مازاد ماه قبل :";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label18.Location = new System.Drawing.Point(137, 73);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(139, 18);
            this.Label18.TabIndex = 7;
            this.Label18.Text = "کارکرد عادی شیفت :";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label19.Location = new System.Drawing.Point(137, 116);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(141, 18);
            this.Label19.TabIndex = 8;
            this.Label19.Text = "کارکرد جمعه شیفت :";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label20.Location = new System.Drawing.Point(137, 159);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(175, 18);
            this.Label20.TabIndex = 9;
            this.Label20.Text = "اضافه کار عادی ثبت شده :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label36.Location = new System.Drawing.Point(137, 245);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(81, 18);
            this.Label36.TabIndex = 10;
            this.Label36.Text = "تعداد تریپ :";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label21.Location = new System.Drawing.Point(137, 202);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(177, 18);
            this.Label21.TabIndex = 10;
            this.Label21.Text = "اضافه کار جمعه ثبت شده :";
            // 
            // ShiftOverText
            // 
            this.ShiftOverText.BackColor = System.Drawing.Color.Black;
            this.ShiftOverText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftOverText.ForeColor = System.Drawing.Color.Cyan;
            this.ShiftOverText.Location = new System.Drawing.Point(37, 65);
            this.ShiftOverText.Name = "ShiftOverText";
            this.ShiftOverText.Size = new System.Drawing.Size(100, 35);
            this.ShiftOverText.TabIndex = 17;
            this.ShiftOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TripText
            // 
            this.TripText.BackColor = System.Drawing.Color.Black;
            this.TripText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TripText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TripText.ForeColor = System.Drawing.Color.Cyan;
            this.TripText.Location = new System.Drawing.Point(37, 237);
            this.TripText.Name = "TripText";
            this.TripText.Size = new System.Drawing.Size(100, 35);
            this.TripText.TabIndex = 20;
            this.TripText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TripText.Click += new System.EventHandler(this.TripText_Click);
            // 
            // OverFriText
            // 
            this.OverFriText.BackColor = System.Drawing.Color.Black;
            this.OverFriText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverFriText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverFriText.ForeColor = System.Drawing.Color.Cyan;
            this.OverFriText.Location = new System.Drawing.Point(37, 194);
            this.OverFriText.Name = "OverFriText";
            this.OverFriText.Size = new System.Drawing.Size(100, 35);
            this.OverFriText.TabIndex = 20;
            this.OverFriText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OverFriText.Click += new System.EventHandler(this.OverFriText_Click);
            // 
            // ShiftFriText
            // 
            this.ShiftFriText.BackColor = System.Drawing.Color.Black;
            this.ShiftFriText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftFriText.ForeColor = System.Drawing.Color.Cyan;
            this.ShiftFriText.Location = new System.Drawing.Point(37, 108);
            this.ShiftFriText.Name = "ShiftFriText";
            this.ShiftFriText.Size = new System.Drawing.Size(100, 35);
            this.ShiftFriText.TabIndex = 18;
            this.ShiftFriText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverText
            // 
            this.OverText.BackColor = System.Drawing.Color.Black;
            this.OverText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverText.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverText.ForeColor = System.Drawing.Color.Cyan;
            this.OverText.Location = new System.Drawing.Point(37, 151);
            this.OverText.Name = "OverText";
            this.OverText.Size = new System.Drawing.Size(100, 35);
            this.OverText.TabIndex = 19;
            this.OverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OverText.Click += new System.EventHandler(this.OverText_Click);
            // 
            // Label44
            // 
            this.Label44.BackColor = System.Drawing.Color.Transparent;
            this.Label44.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label44.ForeColor = System.Drawing.Color.White;
            this.Label44.Location = new System.Drawing.Point(922, 276);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(79, 116);
            this.Label44.TabIndex = 37;
            this.Label44.Text = ".";
            // 
            // Label45
            // 
            this.Label45.BackColor = System.Drawing.Color.Transparent;
            this.Label45.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label45.ForeColor = System.Drawing.Color.White;
            this.Label45.Location = new System.Drawing.Point(764, 276);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(79, 116);
            this.Label45.TabIndex = 38;
            this.Label45.Text = ".";
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TabPage3.Controls.Add(this.Label92);
            this.TabPage3.Controls.Add(this.Label83);
            this.TabPage3.Controls.Add(this.Label74);
            this.TabPage3.Controls.Add(this.Label65);
            this.TabPage3.Controls.Add(this.Panel12);
            this.TabPage3.Controls.Add(this.Panel11);
            this.TabPage3.Controls.Add(this.Label57);
            this.TabPage3.Controls.Add(this.Panel10);
            this.TabPage3.Controls.Add(this.Panel9);
            this.TabPage3.Controls.Add(this.Panel8);
            this.TabPage3.Controls.Add(this.Panel7);
            this.TabPage3.Controls.Add(this.Panel6);
            this.TabPage3.Location = new System.Drawing.Point(4, 29);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1076, 497);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "تحلیل کارکرد";
            // 
            // Label92
            // 
            this.Label92.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Label92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label92.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label92.Location = new System.Drawing.Point(632, 169);
            this.Label92.Name = "Label92";
            this.Label92.Size = new System.Drawing.Size(125, 25);
            this.Label92.TabIndex = 34;
            this.Label92.Text = "اضافه کار";
            this.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label83
            // 
            this.Label83.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Label83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label83.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label83.Location = new System.Drawing.Point(399, 13);
            this.Label83.Name = "Label83";
            this.Label83.Size = new System.Drawing.Size(105, 25);
            this.Label83.TabIndex = 34;
            this.Label83.Text = "مرخصی";
            this.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label74
            // 
            this.Label74.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label74.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label74.Location = new System.Drawing.Point(146, 13);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(105, 25);
            this.Label74.TabIndex = 34;
            this.Label74.Text = "رزرو";
            this.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label65
            // 
            this.Label65.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label65.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label65.Location = new System.Drawing.Point(652, 13);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(105, 25);
            this.Label65.TabIndex = 34;
            this.Label65.Text = "روزهای شیفت";
            this.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel12
            // 
            this.Panel12.BackColor = System.Drawing.Color.Transparent;
            this.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel12.Controls.Add(this.FootOverLabel);
            this.Panel12.Controls.Add(this.HamkOverLabel);
            this.Panel12.Controls.Add(this.JayOverLabel);
            this.Panel12.Controls.Add(this.MotfOverLabel);
            this.Panel12.Controls.Add(this.KeshOverLabel);
            this.Panel12.Controls.Add(this.Label61);
            this.Panel12.Controls.Add(this.Label66);
            this.Panel12.Controls.Add(this.Label5);
            this.Panel12.Controls.Add(this.Label68);
            this.Panel12.Controls.Add(this.Label70);
            this.Panel12.Location = new System.Drawing.Point(26, 184);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(736, 130);
            this.Panel12.TabIndex = 33;
            // 
            // FootOverLabel
            // 
            this.FootOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootOverLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FootOverLabel.ForeColor = System.Drawing.Color.Black;
            this.FootOverLabel.Location = new System.Drawing.Point(20, 14);
            this.FootOverLabel.Name = "FootOverLabel";
            this.FootOverLabel.Size = new System.Drawing.Size(55, 28);
            this.FootOverLabel.TabIndex = 16;
            this.FootOverLabel.Text = "00:00";
            this.FootOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HamkOverLabel
            // 
            this.HamkOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.HamkOverLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HamkOverLabel.ForeColor = System.Drawing.Color.Black;
            this.HamkOverLabel.Location = new System.Drawing.Point(208, 14);
            this.HamkOverLabel.Name = "HamkOverLabel";
            this.HamkOverLabel.Size = new System.Drawing.Size(55, 28);
            this.HamkOverLabel.TabIndex = 16;
            this.HamkOverLabel.Text = "00:00";
            this.HamkOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JayOverLabel
            // 
            this.JayOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.JayOverLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.JayOverLabel.ForeColor = System.Drawing.Color.Black;
            this.JayOverLabel.Location = new System.Drawing.Point(405, 14);
            this.JayOverLabel.Name = "JayOverLabel";
            this.JayOverLabel.Size = new System.Drawing.Size(55, 28);
            this.JayOverLabel.TabIndex = 16;
            this.JayOverLabel.Text = "00:00";
            this.JayOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MotfOverLabel
            // 
            this.MotfOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.MotfOverLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MotfOverLabel.ForeColor = System.Drawing.Color.Black;
            this.MotfOverLabel.Location = new System.Drawing.Point(604, 54);
            this.MotfOverLabel.Name = "MotfOverLabel";
            this.MotfOverLabel.Size = new System.Drawing.Size(55, 28);
            this.MotfOverLabel.TabIndex = 16;
            this.MotfOverLabel.Text = "00:00";
            this.MotfOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeshOverLabel
            // 
            this.KeshOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeshOverLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeshOverLabel.ForeColor = System.Drawing.Color.Black;
            this.KeshOverLabel.Location = new System.Drawing.Point(604, 14);
            this.KeshOverLabel.Name = "KeshOverLabel";
            this.KeshOverLabel.Size = new System.Drawing.Size(55, 28);
            this.KeshOverLabel.TabIndex = 16;
            this.KeshOverLabel.Text = "00:00";
            this.KeshOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label61
            // 
            this.Label61.AutoSize = true;
            this.Label61.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label61.Location = new System.Drawing.Point(261, 19);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(122, 18);
            this.Label61.TabIndex = 15;
            this.Label61.Text = "همکاری باشیفت :";
            // 
            // Label66
            // 
            this.Label66.AutoSize = true;
            this.Label66.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label66.Location = new System.Drawing.Point(72, 19);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(113, 18);
            this.Label66.TabIndex = 13;
            this.Label66.Text = "قطار فوق العاده :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.Location = new System.Drawing.Point(656, 59);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 18);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "متفرقه :";
            // 
            // Label68
            // 
            this.Label68.AutoSize = true;
            this.Label68.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label68.Location = new System.Drawing.Point(457, 19);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(122, 18);
            this.Label68.TabIndex = 15;
            this.Label68.Text = "جایگزین مرخصی :";
            // 
            // Label70
            // 
            this.Label70.AutoSize = true;
            this.Label70.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label70.Location = new System.Drawing.Point(656, 19);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(61, 18);
            this.Label70.TabIndex = 15;
            this.Label70.Text = "کشیک :";
            // 
            // Panel11
            // 
            this.Panel11.BackColor = System.Drawing.Color.Transparent;
            this.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel11.Controls.Add(this.ShftTripLabel);
            this.Panel11.Controls.Add(this.DailyTripLabel);
            this.Panel11.Controls.Add(this.DiffrTripLabel);
            this.Panel11.Controls.Add(this.CalcTripLabel);
            this.Panel11.Controls.Add(this.Label64);
            this.Panel11.Controls.Add(this.Label2);
            this.Panel11.Controls.Add(this.Label89);
            this.Panel11.Controls.Add(this.Label91);
            this.Panel11.Location = new System.Drawing.Point(26, 335);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(262, 140);
            this.Panel11.TabIndex = 33;
            // 
            // ShftTripLabel
            // 
            this.ShftTripLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShftTripLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShftTripLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShftTripLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShftTripLabel.ForeColor = System.Drawing.Color.Black;
            this.ShftTripLabel.Location = new System.Drawing.Point(20, 7);
            this.ShftTripLabel.Name = "ShftTripLabel";
            this.ShftTripLabel.Size = new System.Drawing.Size(50, 28);
            this.ShftTripLabel.TabIndex = 16;
            this.ShftTripLabel.Text = "0";
            this.ShftTripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailyTripLabel
            // 
            this.DailyTripLabel.BackColor = System.Drawing.Color.Transparent;
            this.DailyTripLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DailyTripLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailyTripLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DailyTripLabel.ForeColor = System.Drawing.Color.Black;
            this.DailyTripLabel.Location = new System.Drawing.Point(20, 69);
            this.DailyTripLabel.Name = "DailyTripLabel";
            this.DailyTripLabel.Size = new System.Drawing.Size(50, 28);
            this.DailyTripLabel.TabIndex = 16;
            this.DailyTripLabel.Text = "0";
            this.DailyTripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiffrTripLabel
            // 
            this.DiffrTripLabel.BackColor = System.Drawing.Color.Transparent;
            this.DiffrTripLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiffrTripLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiffrTripLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DiffrTripLabel.ForeColor = System.Drawing.Color.Black;
            this.DiffrTripLabel.Location = new System.Drawing.Point(20, 100);
            this.DiffrTripLabel.Name = "DiffrTripLabel";
            this.DiffrTripLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiffrTripLabel.Size = new System.Drawing.Size(50, 28);
            this.DiffrTripLabel.TabIndex = 16;
            this.DiffrTripLabel.Text = "0";
            this.DiffrTripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcTripLabel
            // 
            this.CalcTripLabel.BackColor = System.Drawing.Color.Transparent;
            this.CalcTripLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalcTripLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcTripLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CalcTripLabel.ForeColor = System.Drawing.Color.Black;
            this.CalcTripLabel.Location = new System.Drawing.Point(20, 38);
            this.CalcTripLabel.Name = "CalcTripLabel";
            this.CalcTripLabel.Size = new System.Drawing.Size(50, 28);
            this.CalcTripLabel.TabIndex = 16;
            this.CalcTripLabel.Text = "0";
            this.CalcTripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label64
            // 
            this.Label64.AutoSize = true;
            this.Label64.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label64.Location = new System.Drawing.Point(68, 12);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(128, 18);
            this.Label64.TabIndex = 12;
            this.Label64.Text = "تعداد تریپ شیفت :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.Location = new System.Drawing.Point(68, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 18);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "اختلاف تریپ :";
            // 
            // Label89
            // 
            this.Label89.AutoSize = true;
            this.Label89.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label89.Location = new System.Drawing.Point(68, 43);
            this.Label89.Name = "Label89";
            this.Label89.Size = new System.Drawing.Size(137, 18);
            this.Label89.TabIndex = 13;
            this.Label89.Text = "تریپ محاسبه شده :";
            // 
            // Label91
            // 
            this.Label91.AutoSize = true;
            this.Label91.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label91.Location = new System.Drawing.Point(68, 74);
            this.Label91.Name = "Label91";
            this.Label91.Size = new System.Drawing.Size(117, 18);
            this.Label91.TabIndex = 12;
            this.Label91.Text = "تریپ انجام شده :";
            // 
            // Label57
            // 
            this.Label57.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label57.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label57.Location = new System.Drawing.Point(944, 335);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(105, 25);
            this.Label57.TabIndex = 34;
            this.Label57.Text = "مجموع اضافه کار";
            this.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel10
            // 
            this.Panel10.BackColor = System.Drawing.Color.Transparent;
            this.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel10.Controls.Add(this.MorTimeLabel);
            this.Panel10.Controls.Add(this.MorFriLabel);
            this.Panel10.Controls.Add(this.MorNormLabel);
            this.Panel10.Controls.Add(this.Label80);
            this.Panel10.Controls.Add(this.Label81);
            this.Panel10.Controls.Add(this.Label82);
            this.Panel10.Location = new System.Drawing.Point(279, 28);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(230, 125);
            this.Panel10.TabIndex = 33;
            // 
            // MorTimeLabel
            // 
            this.MorTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MorTimeLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MorTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.MorTimeLabel.Location = new System.Drawing.Point(40, 78);
            this.MorTimeLabel.Name = "MorTimeLabel";
            this.MorTimeLabel.Size = new System.Drawing.Size(35, 28);
            this.MorTimeLabel.TabIndex = 16;
            this.MorTimeLabel.Text = "0";
            this.MorTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MorFriLabel
            // 
            this.MorFriLabel.BackColor = System.Drawing.Color.Transparent;
            this.MorFriLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MorFriLabel.ForeColor = System.Drawing.Color.Black;
            this.MorFriLabel.Location = new System.Drawing.Point(40, 47);
            this.MorFriLabel.Name = "MorFriLabel";
            this.MorFriLabel.Size = new System.Drawing.Size(35, 28);
            this.MorFriLabel.TabIndex = 16;
            this.MorFriLabel.Text = "0";
            this.MorFriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MorNormLabel
            // 
            this.MorNormLabel.BackColor = System.Drawing.Color.Transparent;
            this.MorNormLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MorNormLabel.ForeColor = System.Drawing.Color.Black;
            this.MorNormLabel.Location = new System.Drawing.Point(40, 16);
            this.MorNormLabel.Name = "MorNormLabel";
            this.MorNormLabel.Size = new System.Drawing.Size(35, 28);
            this.MorNormLabel.TabIndex = 16;
            this.MorNormLabel.Text = "0";
            this.MorNormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label80
            // 
            this.Label80.AutoSize = true;
            this.Label80.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label80.Location = new System.Drawing.Point(73, 52);
            this.Label80.Name = "Label80";
            this.Label80.Size = new System.Drawing.Size(99, 18);
            this.Label80.TabIndex = 13;
            this.Label80.Text = " روزانه تعطیل :";
            // 
            // Label81
            // 
            this.Label81.AutoSize = true;
            this.Label81.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label81.Location = new System.Drawing.Point(73, 21);
            this.Label81.Name = "Label81";
            this.Label81.Size = new System.Drawing.Size(89, 18);
            this.Label81.TabIndex = 15;
            this.Label81.Text = "روزانه عادی :";
            // 
            // Label82
            // 
            this.Label82.AutoSize = true;
            this.Label82.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label82.Location = new System.Drawing.Point(73, 83);
            this.Label82.Name = "Label82";
            this.Label82.Size = new System.Drawing.Size(123, 18);
            this.Label82.TabIndex = 12;
            this.Label82.Text = "مرخصی ساعتی :";
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Transparent;
            this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel9.Controls.Add(this.RezTripLabel);
            this.Panel9.Controls.Add(this.RezFriLabel);
            this.Panel9.Controls.Add(this.RezNormLabel);
            this.Panel9.Controls.Add(this.Label71);
            this.Panel9.Controls.Add(this.Label72);
            this.Panel9.Controls.Add(this.Label73);
            this.Panel9.Location = new System.Drawing.Point(26, 28);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(230, 125);
            this.Panel9.TabIndex = 33;
            // 
            // RezTripLabel
            // 
            this.RezTripLabel.BackColor = System.Drawing.Color.Transparent;
            this.RezTripLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RezTripLabel.ForeColor = System.Drawing.Color.Black;
            this.RezTripLabel.Location = new System.Drawing.Point(40, 78);
            this.RezTripLabel.Name = "RezTripLabel";
            this.RezTripLabel.Size = new System.Drawing.Size(35, 28);
            this.RezTripLabel.TabIndex = 16;
            this.RezTripLabel.Text = "0";
            this.RezTripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RezFriLabel
            // 
            this.RezFriLabel.BackColor = System.Drawing.Color.Transparent;
            this.RezFriLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RezFriLabel.ForeColor = System.Drawing.Color.Black;
            this.RezFriLabel.Location = new System.Drawing.Point(40, 47);
            this.RezFriLabel.Name = "RezFriLabel";
            this.RezFriLabel.Size = new System.Drawing.Size(35, 28);
            this.RezFriLabel.TabIndex = 16;
            this.RezFriLabel.Text = "0";
            this.RezFriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RezNormLabel
            // 
            this.RezNormLabel.BackColor = System.Drawing.Color.Transparent;
            this.RezNormLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RezNormLabel.ForeColor = System.Drawing.Color.Black;
            this.RezNormLabel.Location = new System.Drawing.Point(40, 16);
            this.RezNormLabel.Name = "RezNormLabel";
            this.RezNormLabel.Size = new System.Drawing.Size(35, 28);
            this.RezNormLabel.TabIndex = 16;
            this.RezNormLabel.Text = "0";
            this.RezNormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label71
            // 
            this.Label71.AutoSize = true;
            this.Label71.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label71.Location = new System.Drawing.Point(73, 52);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(77, 18);
            this.Label71.TabIndex = 13;
            this.Label71.Text = "روز تعطیل :";
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label72.Location = new System.Drawing.Point(73, 21);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(77, 18);
            this.Label72.TabIndex = 15;
            this.Label72.Text = " روز عادی :";
            // 
            // Label73
            // 
            this.Label73.AutoSize = true;
            this.Label73.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label73.Location = new System.Drawing.Point(73, 83);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(89, 18);
            this.Label73.TabIndex = 12;
            this.Label73.Text = "تریپ در رزرو :";
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.Transparent;
            this.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel8.Controls.Add(this.ShftTotaLabel);
            this.Panel8.Controls.Add(this.ShftFriLabel);
            this.Panel8.Controls.Add(this.ShftNormLabel);
            this.Panel8.Controls.Add(this.Label53);
            this.Panel8.Controls.Add(this.Label62);
            this.Panel8.Controls.Add(this.Label63);
            this.Panel8.Location = new System.Drawing.Point(532, 28);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(230, 125);
            this.Panel8.TabIndex = 33;
            // 
            // ShftTotaLabel
            // 
            this.ShftTotaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShftTotaLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShftTotaLabel.ForeColor = System.Drawing.Color.Black;
            this.ShftTotaLabel.Location = new System.Drawing.Point(40, 78);
            this.ShftTotaLabel.Name = "ShftTotaLabel";
            this.ShftTotaLabel.Size = new System.Drawing.Size(35, 28);
            this.ShftTotaLabel.TabIndex = 16;
            this.ShftTotaLabel.Text = "0";
            this.ShftTotaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShftFriLabel
            // 
            this.ShftFriLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShftFriLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShftFriLabel.ForeColor = System.Drawing.Color.Black;
            this.ShftFriLabel.Location = new System.Drawing.Point(40, 47);
            this.ShftFriLabel.Name = "ShftFriLabel";
            this.ShftFriLabel.Size = new System.Drawing.Size(35, 28);
            this.ShftFriLabel.TabIndex = 16;
            this.ShftFriLabel.Text = "0";
            this.ShftFriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShftNormLabel
            // 
            this.ShftNormLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShftNormLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShftNormLabel.ForeColor = System.Drawing.Color.Black;
            this.ShftNormLabel.Location = new System.Drawing.Point(40, 16);
            this.ShftNormLabel.Name = "ShftNormLabel";
            this.ShftNormLabel.Size = new System.Drawing.Size(35, 28);
            this.ShftNormLabel.TabIndex = 16;
            this.ShftNormLabel.Text = "0";
            this.ShftNormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label53
            // 
            this.Label53.AutoSize = true;
            this.Label53.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label53.Location = new System.Drawing.Point(73, 83);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(129, 18);
            this.Label53.TabIndex = 13;
            this.Label53.Text = "مجموع روز شیفت :";
            // 
            // Label62
            // 
            this.Label62.AutoSize = true;
            this.Label62.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label62.Location = new System.Drawing.Point(73, 52);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(82, 18);
            this.Label62.TabIndex = 13;
            this.Label62.Text = " روز تعطیل :";
            // 
            // Label63
            // 
            this.Label63.AutoSize = true;
            this.Label63.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label63.Location = new System.Drawing.Point(73, 21);
            this.Label63.Name = "Label63";
            this.Label63.Size = new System.Drawing.Size(77, 18);
            this.Label63.TabIndex = 15;
            this.Label63.Text = " روز عادی :";
            // 
            // Panel7
            // 
            this.Panel7.BackColor = System.Drawing.Color.Transparent;
            this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel7.Controls.Add(this.TptalFog2Label);
            this.Panel7.Controls.Add(this.TotalFri2Label);
            this.Panel7.Controls.Add(this.TotalOver2Label);
            this.Panel7.Controls.Add(this.Label54);
            this.Panel7.Controls.Add(this.Label55);
            this.Panel7.Controls.Add(this.Label60);
            this.Panel7.Location = new System.Drawing.Point(785, 350);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(269, 125);
            this.Panel7.TabIndex = 33;
            // 
            // TptalFog2Label
            // 
            this.TptalFog2Label.BackColor = System.Drawing.Color.Transparent;
            this.TptalFog2Label.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TptalFog2Label.ForeColor = System.Drawing.Color.Black;
            this.TptalFog2Label.Location = new System.Drawing.Point(53, 78);
            this.TptalFog2Label.Name = "TptalFog2Label";
            this.TptalFog2Label.Size = new System.Drawing.Size(69, 28);
            this.TptalFog2Label.TabIndex = 16;
            this.TptalFog2Label.Text = "0";
            this.TptalFog2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalFri2Label
            // 
            this.TotalFri2Label.BackColor = System.Drawing.Color.Transparent;
            this.TotalFri2Label.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalFri2Label.ForeColor = System.Drawing.Color.Black;
            this.TotalFri2Label.Location = new System.Drawing.Point(53, 47);
            this.TotalFri2Label.Name = "TotalFri2Label";
            this.TotalFri2Label.Size = new System.Drawing.Size(69, 28);
            this.TotalFri2Label.TabIndex = 16;
            this.TotalFri2Label.Text = "0";
            this.TotalFri2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalOver2Label
            // 
            this.TotalOver2Label.BackColor = System.Drawing.Color.Transparent;
            this.TotalOver2Label.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalOver2Label.ForeColor = System.Drawing.Color.Black;
            this.TotalOver2Label.Location = new System.Drawing.Point(53, 16);
            this.TotalOver2Label.Name = "TotalOver2Label";
            this.TotalOver2Label.Size = new System.Drawing.Size(69, 28);
            this.TotalOver2Label.TabIndex = 16;
            this.TotalOver2Label.Text = "0";
            this.TotalOver2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label54
            // 
            this.Label54.AutoSize = true;
            this.Label54.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label54.Location = new System.Drawing.Point(120, 52);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(114, 18);
            this.Label54.TabIndex = 13;
            this.Label54.Text = "اضافه کار جمعه :";
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label55.Location = new System.Drawing.Point(120, 21);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(112, 18);
            this.Label55.TabIndex = 15;
            this.Label55.Text = "اضافه کار عادی :";
            // 
            // Label60
            // 
            this.Label60.AutoSize = true;
            this.Label60.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label60.Location = new System.Drawing.Point(120, 83);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(122, 18);
            this.Label60.TabIndex = 12;
            this.Label60.Text = "فوق العاده جمعه :";
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Transparent;
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.Shift2Label);
            this.Panel6.Controls.Add(this.Post2Label);
            this.Panel6.Controls.Add(this.Local2Label);
            this.Panel6.Controls.Add(this.Time2Label);
            this.Panel6.Controls.Add(this.Label39);
            this.Panel6.Controls.Add(this.Label40);
            this.Panel6.Controls.Add(this.Label41);
            this.Panel6.Controls.Add(this.Label42);
            this.Panel6.Controls.Add(this.PNum2Label);
            this.Panel6.Controls.Add(this.Family2Label);
            this.Panel6.Controls.Add(this.Name2Label);
            this.Panel6.Controls.Add(this.Label49);
            this.Panel6.Controls.Add(this.Label51);
            this.Panel6.Controls.Add(this.Label52);
            this.Panel6.Location = new System.Drawing.Point(785, 16);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(269, 298);
            this.Panel6.TabIndex = 31;
            // 
            // Shift2Label
            // 
            this.Shift2Label.BackColor = System.Drawing.Color.Transparent;
            this.Shift2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Shift2Label.ForeColor = System.Drawing.Color.Maroon;
            this.Shift2Label.Location = new System.Drawing.Point(21, 252);
            this.Shift2Label.Name = "Shift2Label";
            this.Shift2Label.Size = new System.Drawing.Size(110, 24);
            this.Shift2Label.TabIndex = 9;
            this.Shift2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Post2Label
            // 
            this.Post2Label.BackColor = System.Drawing.Color.Transparent;
            this.Post2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Post2Label.ForeColor = System.Drawing.Color.Maroon;
            this.Post2Label.Location = new System.Drawing.Point(21, 135);
            this.Post2Label.Name = "Post2Label";
            this.Post2Label.Size = new System.Drawing.Size(110, 24);
            this.Post2Label.TabIndex = 8;
            this.Post2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Local2Label
            // 
            this.Local2Label.BackColor = System.Drawing.Color.Transparent;
            this.Local2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Local2Label.ForeColor = System.Drawing.Color.Maroon;
            this.Local2Label.Location = new System.Drawing.Point(21, 174);
            this.Local2Label.Name = "Local2Label";
            this.Local2Label.Size = new System.Drawing.Size(110, 24);
            this.Local2Label.TabIndex = 8;
            this.Local2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time2Label
            // 
            this.Time2Label.BackColor = System.Drawing.Color.Transparent;
            this.Time2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Time2Label.ForeColor = System.Drawing.Color.Maroon;
            this.Time2Label.Location = new System.Drawing.Point(21, 213);
            this.Time2Label.Name = "Time2Label";
            this.Time2Label.Size = new System.Drawing.Size(110, 24);
            this.Time2Label.TabIndex = 8;
            this.Time2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label39.Location = new System.Drawing.Point(127, 255);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(82, 18);
            this.Label39.TabIndex = 7;
            this.Label39.Text = "نام شیفت :";
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label40.Location = new System.Drawing.Point(127, 177);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(43, 18);
            this.Label40.TabIndex = 6;
            this.Label40.Text = "مبدا :";
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label41.Location = new System.Drawing.Point(127, 138);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(112, 18);
            this.Label41.TabIndex = 6;
            this.Label41.Text = "پست سازمانی :";
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label42.Location = new System.Drawing.Point(127, 216);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(85, 18);
            this.Label42.TabIndex = 6;
            this.Label42.Text = "نوع شیفت :";
            // 
            // PNum2Label
            // 
            this.PNum2Label.BackColor = System.Drawing.Color.Transparent;
            this.PNum2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PNum2Label.ForeColor = System.Drawing.Color.Maroon;
            this.PNum2Label.Location = new System.Drawing.Point(21, 96);
            this.PNum2Label.Name = "PNum2Label";
            this.PNum2Label.Size = new System.Drawing.Size(110, 24);
            this.PNum2Label.TabIndex = 5;
            this.PNum2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Family2Label
            // 
            this.Family2Label.BackColor = System.Drawing.Color.Transparent;
            this.Family2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Family2Label.ForeColor = System.Drawing.Color.Maroon;
            this.Family2Label.Location = new System.Drawing.Point(21, 57);
            this.Family2Label.Name = "Family2Label";
            this.Family2Label.Size = new System.Drawing.Size(110, 24);
            this.Family2Label.TabIndex = 4;
            this.Family2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name2Label
            // 
            this.Name2Label.BackColor = System.Drawing.Color.Transparent;
            this.Name2Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name2Label.ForeColor = System.Drawing.Color.Maroon;
            this.Name2Label.Location = new System.Drawing.Point(21, 18);
            this.Name2Label.Name = "Name2Label";
            this.Name2Label.Size = new System.Drawing.Size(110, 24);
            this.Name2Label.TabIndex = 3;
            this.Name2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label49.Location = new System.Drawing.Point(127, 99);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(88, 18);
            this.Label49.TabIndex = 2;
            this.Label49.Text = "کد پرسنلی :";
            // 
            // Label51
            // 
            this.Label51.AutoSize = true;
            this.Label51.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label51.Location = new System.Drawing.Point(127, 21);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(35, 18);
            this.Label51.TabIndex = 0;
            this.Label51.Text = "نام :";
            // 
            // Label52
            // 
            this.Label52.AutoSize = true;
            this.Label52.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label52.Location = new System.Drawing.Point(127, 60);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(98, 18);
            this.Label52.TabIndex = 1;
            this.Label52.Text = "نام خانوادگی :";
            // 
            // TabPage4
            // 
            this.TabPage4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TabPage4.Controls.Add(this.Label33);
            this.TabPage4.Controls.Add(this.Panel13);
            this.TabPage4.Controls.Add(this.Panel14);
            this.TabPage4.Controls.Add(this.Daily2GridView);
            this.TabPage4.Controls.Add(this.Daily1GridView);
            this.TabPage4.Location = new System.Drawing.Point(4, 29);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(1076, 497);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "تحلیل روزانه";
            // 
            // Label33
            // 
            this.Label33.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label33.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label33.Location = new System.Drawing.Point(947, 324);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(105, 25);
            this.Label33.TabIndex = 37;
            this.Label33.Text = "مجموع اضافه کار";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel13
            // 
            this.Panel13.BackColor = System.Drawing.Color.Transparent;
            this.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel13.Controls.Add(this.TptalFog3Label);
            this.Panel13.Controls.Add(this.TotalFri3Label);
            this.Panel13.Controls.Add(this.TotalOver3Label);
            this.Panel13.Controls.Add(this.Label48);
            this.Panel13.Controls.Add(this.Label56);
            this.Panel13.Controls.Add(this.Label58);
            this.Panel13.Location = new System.Drawing.Point(788, 339);
            this.Panel13.Name = "Panel13";
            this.Panel13.Size = new System.Drawing.Size(269, 125);
            this.Panel13.TabIndex = 36;
            // 
            // TptalFog3Label
            // 
            this.TptalFog3Label.BackColor = System.Drawing.Color.Transparent;
            this.TptalFog3Label.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TptalFog3Label.ForeColor = System.Drawing.Color.Black;
            this.TptalFog3Label.Location = new System.Drawing.Point(53, 78);
            this.TptalFog3Label.Name = "TptalFog3Label";
            this.TptalFog3Label.Size = new System.Drawing.Size(69, 28);
            this.TptalFog3Label.TabIndex = 16;
            this.TptalFog3Label.Text = "0";
            this.TptalFog3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalFri3Label
            // 
            this.TotalFri3Label.BackColor = System.Drawing.Color.Transparent;
            this.TotalFri3Label.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalFri3Label.ForeColor = System.Drawing.Color.Black;
            this.TotalFri3Label.Location = new System.Drawing.Point(53, 47);
            this.TotalFri3Label.Name = "TotalFri3Label";
            this.TotalFri3Label.Size = new System.Drawing.Size(69, 28);
            this.TotalFri3Label.TabIndex = 16;
            this.TotalFri3Label.Text = "0";
            this.TotalFri3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalOver3Label
            // 
            this.TotalOver3Label.BackColor = System.Drawing.Color.Transparent;
            this.TotalOver3Label.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalOver3Label.ForeColor = System.Drawing.Color.Black;
            this.TotalOver3Label.Location = new System.Drawing.Point(53, 16);
            this.TotalOver3Label.Name = "TotalOver3Label";
            this.TotalOver3Label.Size = new System.Drawing.Size(69, 28);
            this.TotalOver3Label.TabIndex = 16;
            this.TotalOver3Label.Text = "0";
            this.TotalOver3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label48.Location = new System.Drawing.Point(120, 52);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(114, 18);
            this.Label48.TabIndex = 13;
            this.Label48.Text = "اضافه کار جمعه :";
            // 
            // Label56
            // 
            this.Label56.AutoSize = true;
            this.Label56.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label56.Location = new System.Drawing.Point(120, 21);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(112, 18);
            this.Label56.TabIndex = 15;
            this.Label56.Text = "اضافه کار عادی :";
            // 
            // Label58
            // 
            this.Label58.AutoSize = true;
            this.Label58.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label58.Location = new System.Drawing.Point(120, 83);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(122, 18);
            this.Label58.TabIndex = 12;
            this.Label58.Text = "فوق العاده جمعه :";
            // 
            // Panel14
            // 
            this.Panel14.BackColor = System.Drawing.Color.Transparent;
            this.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel14.Controls.Add(this.Shift3Label);
            this.Panel14.Controls.Add(this.Post3Label);
            this.Panel14.Controls.Add(this.Local3Label);
            this.Panel14.Controls.Add(this.Time3Label);
            this.Panel14.Controls.Add(this.Label76);
            this.Panel14.Controls.Add(this.Label77);
            this.Panel14.Controls.Add(this.Label78);
            this.Panel14.Controls.Add(this.Label79);
            this.Panel14.Controls.Add(this.PNum3Label);
            this.Panel14.Controls.Add(this.Family3Label);
            this.Panel14.Controls.Add(this.Name3Label);
            this.Panel14.Controls.Add(this.Label87);
            this.Panel14.Controls.Add(this.Label88);
            this.Panel14.Controls.Add(this.Label90);
            this.Panel14.Location = new System.Drawing.Point(788, 24);
            this.Panel14.Name = "Panel14";
            this.Panel14.Size = new System.Drawing.Size(269, 291);
            this.Panel14.TabIndex = 35;
            // 
            // Shift3Label
            // 
            this.Shift3Label.BackColor = System.Drawing.Color.Transparent;
            this.Shift3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Shift3Label.ForeColor = System.Drawing.Color.Maroon;
            this.Shift3Label.Location = new System.Drawing.Point(21, 245);
            this.Shift3Label.Name = "Shift3Label";
            this.Shift3Label.Size = new System.Drawing.Size(110, 24);
            this.Shift3Label.TabIndex = 9;
            this.Shift3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Post3Label
            // 
            this.Post3Label.BackColor = System.Drawing.Color.Transparent;
            this.Post3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Post3Label.ForeColor = System.Drawing.Color.Maroon;
            this.Post3Label.Location = new System.Drawing.Point(21, 131);
            this.Post3Label.Name = "Post3Label";
            this.Post3Label.Size = new System.Drawing.Size(110, 24);
            this.Post3Label.TabIndex = 8;
            this.Post3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Local3Label
            // 
            this.Local3Label.BackColor = System.Drawing.Color.Transparent;
            this.Local3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Local3Label.ForeColor = System.Drawing.Color.Maroon;
            this.Local3Label.Location = new System.Drawing.Point(21, 169);
            this.Local3Label.Name = "Local3Label";
            this.Local3Label.Size = new System.Drawing.Size(110, 24);
            this.Local3Label.TabIndex = 8;
            this.Local3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time3Label
            // 
            this.Time3Label.BackColor = System.Drawing.Color.Transparent;
            this.Time3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Time3Label.ForeColor = System.Drawing.Color.Maroon;
            this.Time3Label.Location = new System.Drawing.Point(21, 207);
            this.Time3Label.Name = "Time3Label";
            this.Time3Label.Size = new System.Drawing.Size(110, 24);
            this.Time3Label.TabIndex = 8;
            this.Time3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label76
            // 
            this.Label76.AutoSize = true;
            this.Label76.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label76.Location = new System.Drawing.Point(127, 248);
            this.Label76.Name = "Label76";
            this.Label76.Size = new System.Drawing.Size(82, 18);
            this.Label76.TabIndex = 7;
            this.Label76.Text = "نام شیفت :";
            // 
            // Label77
            // 
            this.Label77.AutoSize = true;
            this.Label77.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label77.Location = new System.Drawing.Point(127, 172);
            this.Label77.Name = "Label77";
            this.Label77.Size = new System.Drawing.Size(43, 18);
            this.Label77.TabIndex = 6;
            this.Label77.Text = "مبدا :";
            // 
            // Label78
            // 
            this.Label78.AutoSize = true;
            this.Label78.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label78.Location = new System.Drawing.Point(127, 134);
            this.Label78.Name = "Label78";
            this.Label78.Size = new System.Drawing.Size(112, 18);
            this.Label78.TabIndex = 6;
            this.Label78.Text = "پست سازمانی :";
            // 
            // Label79
            // 
            this.Label79.AutoSize = true;
            this.Label79.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label79.Location = new System.Drawing.Point(127, 210);
            this.Label79.Name = "Label79";
            this.Label79.Size = new System.Drawing.Size(85, 18);
            this.Label79.TabIndex = 6;
            this.Label79.Text = "نوع شیفت :";
            // 
            // PNum3Label
            // 
            this.PNum3Label.BackColor = System.Drawing.Color.Transparent;
            this.PNum3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PNum3Label.ForeColor = System.Drawing.Color.Maroon;
            this.PNum3Label.Location = new System.Drawing.Point(21, 93);
            this.PNum3Label.Name = "PNum3Label";
            this.PNum3Label.Size = new System.Drawing.Size(110, 24);
            this.PNum3Label.TabIndex = 5;
            this.PNum3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Family3Label
            // 
            this.Family3Label.BackColor = System.Drawing.Color.Transparent;
            this.Family3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Family3Label.ForeColor = System.Drawing.Color.Maroon;
            this.Family3Label.Location = new System.Drawing.Point(21, 55);
            this.Family3Label.Name = "Family3Label";
            this.Family3Label.Size = new System.Drawing.Size(110, 24);
            this.Family3Label.TabIndex = 4;
            this.Family3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name3Label
            // 
            this.Name3Label.BackColor = System.Drawing.Color.Transparent;
            this.Name3Label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name3Label.ForeColor = System.Drawing.Color.Maroon;
            this.Name3Label.Location = new System.Drawing.Point(21, 17);
            this.Name3Label.Name = "Name3Label";
            this.Name3Label.Size = new System.Drawing.Size(110, 24);
            this.Name3Label.TabIndex = 3;
            this.Name3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label87
            // 
            this.Label87.AutoSize = true;
            this.Label87.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label87.Location = new System.Drawing.Point(127, 96);
            this.Label87.Name = "Label87";
            this.Label87.Size = new System.Drawing.Size(88, 18);
            this.Label87.TabIndex = 2;
            this.Label87.Text = "کد پرسنلی :";
            // 
            // Label88
            // 
            this.Label88.AutoSize = true;
            this.Label88.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label88.Location = new System.Drawing.Point(127, 20);
            this.Label88.Name = "Label88";
            this.Label88.Size = new System.Drawing.Size(35, 18);
            this.Label88.TabIndex = 0;
            this.Label88.Text = "نام :";
            // 
            // Label90
            // 
            this.Label90.AutoSize = true;
            this.Label90.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label90.Location = new System.Drawing.Point(127, 58);
            this.Label90.Name = "Label90";
            this.Label90.Size = new System.Drawing.Size(98, 18);
            this.Label90.TabIndex = 1;
            this.Label90.Text = "نام خانوادگی :";
            // 
            // Daily2GridView
            // 
            this.Daily2GridView.AllowUserToAddRows = false;
            this.Daily2GridView.AllowUserToDeleteRows = false;
            this.Daily2GridView.AllowUserToResizeColumns = false;
            this.Daily2GridView.AllowUserToResizeRows = false;
            this.Daily2GridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Daily2GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Daily2GridView.ColumnHeadersHeight = 35;
            this.Daily2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Daily2GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5});
            this.Daily2GridView.EnableHeadersVisualStyles = false;
            this.Daily2GridView.Location = new System.Drawing.Point(10, 24);
            this.Daily2GridView.Name = "Daily2GridView";
            this.Daily2GridView.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Daily2GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Daily2GridView.RowHeadersVisible = false;
            this.Daily2GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Daily2GridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Daily2GridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.Daily2GridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Daily2GridView.RowTemplate.Height = 25;
            this.Daily2GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Daily2GridView.Size = new System.Drawing.Size(378, 445);
            this.Daily2GridView.TabIndex = 0;
            this.Daily2GridView.SelectionChanged += new System.EventHandler(this.Daily2GridView_SelectionChanged);
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "تاریخ";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 85;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "شیفت";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 75;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "تریپ";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 60;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn4.HeaderText = "وضعیت";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "کارکرد";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Width = 65;
            // 
            // Daily1GridView
            // 
            this.Daily1GridView.AllowUserToAddRows = false;
            this.Daily1GridView.AllowUserToDeleteRows = false;
            this.Daily1GridView.AllowUserToResizeColumns = false;
            this.Daily1GridView.AllowUserToResizeRows = false;
            this.Daily1GridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Daily1GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Daily1GridView.ColumnHeadersHeight = 35;
            this.Daily1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Daily1GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column21,
            this.Column23,
            this.Column24,
            this.Column26,
            this.Column25});
            this.Daily1GridView.EnableHeadersVisualStyles = false;
            this.Daily1GridView.Location = new System.Drawing.Point(395, 24);
            this.Daily1GridView.Name = "Daily1GridView";
            this.Daily1GridView.ReadOnly = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Daily1GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Daily1GridView.RowHeadersVisible = false;
            this.Daily1GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Daily1GridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Daily1GridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.Daily1GridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Daily1GridView.RowTemplate.Height = 25;
            this.Daily1GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Daily1GridView.Size = new System.Drawing.Size(378, 445);
            this.Daily1GridView.TabIndex = 0;
            this.Daily1GridView.SelectionChanged += new System.EventHandler(this.Daily1GridView_SelectionChanged);
            // 
            // Column21
            // 
            this.Column21.HeaderText = "تاریخ";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Width = 85;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "شیفت";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 75;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "تریپ";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 60;
            // 
            // Column26
            // 
            this.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column26.HeaderText = "وضعیت";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "کارکرد";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 65;
            // 
            // MonthlyOperAdvForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1084, 630);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonthlyOperAdvForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کارکرد جدید راهبران";
            this.Load += new System.EventHandler(this.MonthlyOperAdvForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            this.Panel10.ResumeLayout(false);
            this.Panel10.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.Panel13.ResumeLayout(false);
            this.Panel13.PerformLayout();
            this.Panel14.ResumeLayout(false);
            this.Panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Daily2GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daily1GridView)).EndInit();
            this.ResumeLayout(false);

        }

        private ComboBox MonthCombo;
        private Label Label6;
        private Label Label1;
        private ComboBox YearCombo;
        private Label Label7;
        private Label Label8;
        private Label Label9;
        private Label Label10;
        private Button ShowButton;
        private Button PervButton;
        private Button NextButton;
        private ComboBox ShiftCombo;
        private ComboBox PostCombo;
        private ComboBox TimeCombo;
        private ComboBox LocalCombo;
        private Panel Panel1;
        private Button ExportButton;
        private TabControl TabControl1;
        private TabPage TabPage1;
        private DataGridView ShowGridView;
        private TabPage TabPage2;
        private Panel Panel3;
        private Label Shift1Label;
        private Label Post1Label;
        private Label Time1Label;
        private Label Label34;
        private Label Label32;
        private Label Label35;
        private Label PNum1Label;
        private Label Family1Label;
        private Label Name1Label;
        private Label Label13;
        private Label Label11;
        private Label Label12;
        private Label Label43;
        private Panel Panel5;
        private Label SumFriText;
        private Label Label24;
        private Label Label26;
        private Label SumOverText;
        private Label NextMonthText;
        private Label Label25;
        private Label FogFriText;
        private Label Label23;
        private Label Label28;
        private Panel Panel4;
        private Label Label27;
        private Label Label31;
        private Label NegText;
        private Label Label30;
        private Label Label29;
        private Label Label14;
        private Label Label15;
        private Label Label16;
        private Label TimeLeavText;
        private Label DayLeavText;
        private Label Label22;
        private Label PosText;
        private Panel Panel2;
        private Label Label37;
        private Label Label4;
        private Label Label3;
        private Label LastMonthText;
        private Label Label17;
        private Label Label18;
        private Label Label19;
        private Label Label20;
        private Label Label36;
        private Label Label21;
        private Label ShiftOverText;
        private Label TripText;
        private Label OverFriText;
        private Label ShiftFriText;
        private Label OverText;
        private Label Label44;
        private Label Label45;
        private TabPage TabPage3;
        private Label Local1Label;
        private Label Label50;
        private Panel Panel6;
        private Label Shift2Label;
        private Label Post2Label;
        private Label Local2Label;
        private Label Time2Label;
        private Label Label39;
        private Label Label40;
        private Label Label41;
        private Label Label42;
        private Label PNum2Label;
        private Label Family2Label;
        private Label Name2Label;
        private Label Label49;
        private Label Label51;
        private Label Label52;
        private Panel Panel7;
        private Label Label54;
        private Label Label55;
        private Label Label60;
        private Panel Panel8;
        private Label ShftTripLabel;
        private Label ShftTotaLabel;
        private Label ShftFriLabel;
        private Label ShftNormLabel;
        private Label Label53;
        private Label Label62;
        private Label Label63;
        private Label Label64;
        private Label TptalFog2Label;
        private Label TotalFri2Label;
        private Label TotalOver2Label;
        private Label Label92;
        private Label Label83;
        private Label Label74;
        private Label Label65;
        private Panel Panel11;
        private Label DailyTripLabel;
        private Label CalcTripLabel;
        private Label Label89;
        private Label Label91;
        private Label Label57;
        private Panel Panel10;
        private Label MorTimeLabel;
        private Label MorFriLabel;
        private Label MorNormLabel;
        private Label Label80;
        private Label Label81;
        private Label Label82;
        private Panel Panel9;
        private Label RezTripLabel;
        private Label RezFriLabel;
        private Label RezNormLabel;
        private Label Label71;
        private Label Label72;
        private Label Label73;
        private Label DiffrTripLabel;
        private Label Label2;
        private Panel Panel12;
        private Label FootOverLabel;
        private Label HamkOverLabel;
        private Label JayOverLabel;
        private Label KeshOverLabel;
        private Label Label61;
        private Label Label66;
        private Label Label68;
        private Label Label70;
        private Label MotfOverLabel;
        private Label Label5;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private TabPage TabPage4;
        private DataGridView Daily1GridView;
        private Label Label33;
        private Panel Panel13;
        private Label TptalFog3Label;
        private Label TotalFri3Label;
        private Label TotalOver3Label;
        private Label Label48;
        private Label Label56;
        private Label Label58;
        private Panel Panel14;
        private Label Shift3Label;
        private Label Post3Label;
        private Label Local3Label;
        private Label Time3Label;
        private Label Label76;
        private Label Label77;
        private Label Label78;
        private Label Label79;
        private Label PNum3Label;
        private Label Family3Label;
        private Label Name3Label;
        private Label Label87;
        private Label Label88;
        private Label Label90;
        private DataGridView Daily2GridView;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column26;
        private DataGridViewTextBoxColumn Column25;
    }

}
