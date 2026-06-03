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
	public partial class Reserve9Form : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6=new System.Windows.Forms.DataGridViewCellStyle();
            this.Label3=new System.Windows.Forms.Label();
            this.DelRadioButton=new System.Windows.Forms.RadioButton();
            this.AddRadioButton=new System.Windows.Forms.RadioButton();
            this.RegButton=new System.Windows.Forms.Button();
            this.ReservBox=new System.Windows.Forms.TextBox();
            this.Label4=new System.Windows.Forms.Label();
            this.PNumBox=new System.Windows.Forms.TextBox();
            this.Label2=new System.Windows.Forms.Label();
            this.NameBox=new System.Windows.Forms.TextBox();
            this.Label1=new System.Windows.Forms.Label();
            this.DetailGridView=new System.Windows.Forms.DataGridView();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegGridView=new System.Windows.Forms.DataGridView();
            this.Column12=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label7=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.ShiftCombo=new System.Windows.Forms.ComboBox();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.DelWeekBox=new System.Windows.Forms.TextBox();
            this.Label8=new System.Windows.Forms.Label();
            this.DelSumBox=new System.Windows.Forms.TextBox();
            this.Label9=new System.Windows.Forms.Label();
            this.RegWeekBox=new System.Windows.Forms.TextBox();
            this.Label10=new System.Windows.Forms.Label();
            this.RegSumBox=new System.Windows.Forms.TextBox();
            this.Label11=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.MemBox=new System.Windows.Forms.TextBox();
            this.KindCombo=new System.Windows.Forms.ComboBox();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Panel3=new System.Windows.Forms.Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel4=new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Label3.ForeColor=System.Drawing.Color.Black;
            this.Label3.Location=new System.Drawing.Point(120, 85);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(62, 16);
            this.Label3.TabIndex=18;
            this.Label3.Text="توضیحات:";
            // 
            // DelRadioButton
            // 
            this.DelRadioButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelRadioButton.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.DelRadioButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelRadioButton.ForeColor=System.Drawing.Color.White;
            this.DelRadioButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DelRadioButton.Location=new System.Drawing.Point(104, 44);
            this.DelRadioButton.Name="DelRadioButton";
            this.DelRadioButton.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DelRadioButton.Size=new System.Drawing.Size(80, 23);
            this.DelRadioButton.TabIndex=2;
            this.DelRadioButton.Text="حذف";
            this.DelRadioButton.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.DelRadioButton.UseVisualStyleBackColor=false;
            this.DelRadioButton.CheckedChanged += new System.EventHandler(this.DelRadioButton_CheckedChanged);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddRadioButton.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.AddRadioButton.Checked=true;
            this.AddRadioButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddRadioButton.ForeColor=System.Drawing.Color.White;
            this.AddRadioButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRadioButton.Location=new System.Drawing.Point(104, 16);
            this.AddRadioButton.Name="AddRadioButton";
            this.AddRadioButton.Padding=new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddRadioButton.Size=new System.Drawing.Size(80, 23);
            this.AddRadioButton.TabIndex=1;
            this.AddRadioButton.TabStop=true;
            this.AddRadioButton.Text="اضافه";
            this.AddRadioButton.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRadioButton.UseVisualStyleBackColor=false;
            this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location=new System.Drawing.Point(14, 14);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(84, 53);
            this.RegButton.TabIndex=3;
            this.RegButton.Text="تایید";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ReservBox
            // 
            this.ReservBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.ReservBox.Location=new System.Drawing.Point(14, 85);
            this.ReservBox.Name="ReservBox";
            this.ReservBox.ReadOnly=true;
            this.ReservBox.Size=new System.Drawing.Size(66, 23);
            this.ReservBox.TabIndex=14;
            this.ReservBox.TabStop=false;
            this.ReservBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Label4.ForeColor=System.Drawing.Color.Black;
            this.Label4.Location=new System.Drawing.Point(81, 88);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(63, 16);
            this.Label4.TabIndex=13;
            this.Label4.Text="تعداد رزرو:";
            // 
            // PNumBox
            // 
            this.PNumBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.PNumBox.Location=new System.Drawing.Point(14, 52);
            this.PNumBox.Name="PNumBox";
            this.PNumBox.ReadOnly=true;
            this.PNumBox.Size=new System.Drawing.Size(66, 23);
            this.PNumBox.TabIndex=12;
            this.PNumBox.TabStop=false;
            this.PNumBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Label2.ForeColor=System.Drawing.Color.Black;
            this.Label2.Location=new System.Drawing.Point(81, 55);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(98, 16);
            this.Label2.TabIndex=11;
            this.Label2.Text="شماره پرسنلی:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.NameBox.Location=new System.Drawing.Point(14, 19);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(127, 23);
            this.NameBox.TabIndex=1;
            this.NameBox.TabStop=false;
            this.NameBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.Location=new System.Drawing.Point(142, 22);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(29, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="نام:";
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows=false;
            this.DetailGridView.AllowUserToDeleteRows=false;
            this.DetailGridView.AllowUserToResizeColumns=false;
            this.DetailGridView.AllowUserToResizeRows=false;
            this.DetailGridView.ColumnHeadersHeight=40;
            this.DetailGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column4});
            this.DetailGridView.Location=new System.Drawing.Point(30, 152);
            this.DetailGridView.Name="DetailGridView";
            this.DetailGridView.ReadOnly=true;
            this.DetailGridView.RowHeadersVisible=false;
            this.DetailGridView.Size=new System.Drawing.Size(510, 218);
            this.DetailGridView.TabIndex=9;
            this.DetailGridView.Visible=false;
            // 
            // Column5
            // 
            this.Column5.HeaderText="نام";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=60;
            // 
            // Column6
            // 
            this.Column6.HeaderText="نام خانوادگی";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            // 
            // Column1
            // 
            this.Column1.HeaderText="پرسنلی";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=50;
            // 
            // Column2
            // 
            this.Column2.HeaderText="رزرو";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=40;
            // 
            // Column3
            // 
            this.Column3.HeaderText="تریپ";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=40;
            // 
            // Column7
            // 
            this.Column7.HeaderText="تریپ آخر";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Visible=false;
            this.Column7.Width=40;
            // 
            // Column13
            // 
            this.Column13.HeaderText="روزانه";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            this.Column13.Width=40;
            // 
            // Column14
            // 
            this.Column14.HeaderText="ساعتی";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Width=40;
            // 
            // Column15
            // 
            this.Column15.HeaderText="مثبت";
            this.Column15.Name="Column15";
            this.Column15.ReadOnly=true;
            this.Column15.Visible=false;
            this.Column15.Width=40;
            // 
            // Column16
            // 
            this.Column16.HeaderText="منفی";
            this.Column16.Name="Column16";
            this.Column16.ReadOnly=true;
            this.Column16.Visible=false;
            this.Column16.Width=40;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText="امتیاز";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            // 
            // RegGridView
            // 
            this.RegGridView.AllowUserToAddRows=false;
            this.RegGridView.AllowUserToDeleteRows=false;
            this.RegGridView.AllowUserToResizeColumns=false;
            this.RegGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            this.RegGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle5;
            this.RegGridView.ColumnHeadersHeight=40;
            this.RegGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RegGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle6.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor=System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor=System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.RegGridView.DefaultCellStyle=dataGridViewCellStyle6;
            this.RegGridView.EnableHeadersVisualStyles=false;
            this.RegGridView.Location=new System.Drawing.Point(15, 15);
            this.RegGridView.MultiSelect=false;
            this.RegGridView.Name="RegGridView";
            this.RegGridView.ReadOnly=true;
            this.RegGridView.RowHeadersVisible=false;
            this.RegGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RegGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RegGridView.Size=new System.Drawing.Size(540, 370);
            this.RegGridView.TabIndex=3;
            this.RegGridView.TabStop=false;
            this.RegGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RegGridView_ColumnHeaderMouseClick);
            // 
            // Column12
            // 
            this.Column12.HeaderText="ردیف";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Width=45;
            // 
            // Column8
            // 
            this.Column8.HeaderText="نام";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=85;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText="نام خانوادگی";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            // 
            // Column10
            // 
            this.Column10.HeaderText="شماره پرسنلی";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            // 
            // Column11
            // 
            this.Column11.HeaderText="شیفت";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=135;
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.Location=new System.Drawing.Point(138, 50);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(35, 16);
            this.Label7.TabIndex=19;
            this.Label7.Text="مبدا:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.BackColor=System.Drawing.Color.Transparent;
            this.Label6.Location=new System.Drawing.Point(138, 85);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(50, 16);
            this.Label6.TabIndex=18;
            this.Label6.Text="شیفت:";
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.BackColor=System.Drawing.Color.Transparent;
            this.Label5.Location=new System.Drawing.Point(138, 15);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(39, 16);
            this.Label5.TabIndex=17;
            this.Label5.Text="تاریخ:";
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Items.AddRange(new object[] {
            "صبح",
            "روز",
            "عصر",
            "شب"});
            this.ShiftCombo.Location=new System.Drawing.Point(14, 81);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(125, 24);
            this.ShiftCombo.TabIndex=3;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(14, 46);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(125, 24);
            this.LocalCombo.TabIndex=2;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.LocalCombo.TextChanged += new System.EventHandler(this.LocalCombo_TextChanged);
            // 
            // DelWeekBox
            // 
            this.DelWeekBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.DelWeekBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelWeekBox.ForeColor=System.Drawing.Color.Yellow;
            this.DelWeekBox.Location=new System.Drawing.Point(302, 36);
            this.DelWeekBox.Name="DelWeekBox";
            this.DelWeekBox.ReadOnly=true;
            this.DelWeekBox.Size=new System.Drawing.Size(59, 23);
            this.DelWeekBox.TabIndex=3;
            this.DelWeekBox.TabStop=false;
            this.DelWeekBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.ForeColor=System.Drawing.Color.Black;
            this.Label8.Location=new System.Drawing.Point(365, 38);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(130, 16);
            this.Label8.TabIndex=15;
            this.Label8.Text="تعداد حذف های هفته:";
            // 
            // DelSumBox
            // 
            this.DelSumBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.DelSumBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelSumBox.ForeColor=System.Drawing.Color.Yellow;
            this.DelSumBox.Location=new System.Drawing.Point(44, 36);
            this.DelSumBox.Name="DelSumBox";
            this.DelSumBox.ReadOnly=true;
            this.DelSumBox.Size=new System.Drawing.Size(59, 23);
            this.DelSumBox.TabIndex=2;
            this.DelSumBox.TabStop=false;
            this.DelSumBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.ForeColor=System.Drawing.Color.Black;
            this.Label9.Location=new System.Drawing.Point(104, 37);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(137, 16);
            this.Label9.TabIndex=13;
            this.Label9.Text="مجموع حذف ها از ابتدا:";
            // 
            // RegWeekBox
            // 
            this.RegWeekBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.RegWeekBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegWeekBox.ForeColor=System.Drawing.Color.Yellow;
            this.RegWeekBox.Location=new System.Drawing.Point(302, 7);
            this.RegWeekBox.Name="RegWeekBox";
            this.RegWeekBox.ReadOnly=true;
            this.RegWeekBox.Size=new System.Drawing.Size(59, 23);
            this.RegWeekBox.TabIndex=1;
            this.RegWeekBox.TabStop=false;
            this.RegWeekBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize=true;
            this.Label10.ForeColor=System.Drawing.Color.Black;
            this.Label10.Location=new System.Drawing.Point(365, 12);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(124, 16);
            this.Label10.TabIndex=11;
            this.Label10.Text="تعداد ثبت های هفته:";
            // 
            // RegSumBox
            // 
            this.RegSumBox.BackColor=System.Drawing.Color.LightSteelBlue;
            this.RegSumBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegSumBox.ForeColor=System.Drawing.Color.Yellow;
            this.RegSumBox.Location=new System.Drawing.Point(44, 7);
            this.RegSumBox.Name="RegSumBox";
            this.RegSumBox.ReadOnly=true;
            this.RegSumBox.Size=new System.Drawing.Size(59, 23);
            this.RegSumBox.TabIndex=0;
            this.RegSumBox.TabStop=false;
            this.RegSumBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.AutoSize=true;
            this.Label11.ForeColor=System.Drawing.Color.Black;
            this.Label11.Location=new System.Drawing.Point(104, 11);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(131, 16);
            this.Label11.TabIndex=0;
            this.Label11.Text="مجموع ثبت ها از ابتدا:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.MemBox);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.RegButton);
            this.Panel1.Controls.Add(this.DelRadioButton);
            this.Panel1.Controls.Add(this.AddRadioButton);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location=new System.Drawing.Point(570, 291);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(200, 178);
            this.Panel1.TabIndex=1;
            this.Panel1.EnabledChanged += new System.EventHandler(this.Panel1_EnabledChanged);
            // 
            // MemBox
            // 
            this.MemBox.Location=new System.Drawing.Point(14, 137);
            this.MemBox.MaxLength=50;
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(170, 23);
            this.MemBox.TabIndex=20;
            this.MemBox.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.MemBox.Enter += new System.EventHandler(this.MemBox_Enter);
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] {
            ">> لطفا انتخاب کنید <<",
            "درخواست مسئول شیفت",
            "در خواست راهبر",
            "تشخیص تکنیسین"});
            this.KindCombo.Location=new System.Drawing.Point(14, 106);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(170, 24);
            this.KindCombo.TabIndex=19;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.DelWeekBox);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.DelSumBox);
            this.Panel2.Controls.Add(this.RegSumBox);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.RegWeekBox);
            this.Panel2.Location=new System.Drawing.Point(15, 400);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(540, 69);
            this.Panel2.TabIndex=24;
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.PersianCalendar);
            this.Panel3.Controls.Add(this.ShiftCombo);
            this.Panel3.Controls.Add(this.LocalCombo);
            this.Panel3.Controls.Add(this.Label6);
            this.Panel3.Controls.Add(this.Label5);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Location=new System.Drawing.Point(570, 15);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(200, 121);
            this.Panel3.TabIndex=36;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(14, 12);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=99;
            this.PersianCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Panel4
            // 
            this.Panel4.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Panel4.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.NameBox);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.PNumBox);
            this.Panel4.Controls.Add(this.ReservBox);
            this.Panel4.Controls.Add(this.Label1);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Location=new System.Drawing.Point(570, 153);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(200, 122);
            this.Panel4.TabIndex=37;
            // 
            // Reserve9Form
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(784, 483);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.DetailGridView);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.RegGridView);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="Reserve9Form";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="انتخاب راهبران رزرو";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Reserve9Form_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Reserve9Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

		}
		private DataGridView RegGridView;
		private DataGridView DetailGridView;
		private TextBox NameBox;
		private Label Label1;
		private Button RegButton;
		private TextBox ReservBox;
		private Label Label4;
		private TextBox PNumBox;
		private Label Label2;
		private Label Label7;
		private Label Label6;
		private Label Label5;
		private ComboBox ShiftCombo;
		private ComboBox LocalCombo;
		private TextBox DelWeekBox;
		private Label Label8;
		private TextBox DelSumBox;
		private Label Label9;
		private TextBox RegWeekBox;
		private Label Label10;
		private TextBox RegSumBox;
		private Label Label11;
		private Label Label3;
		private RadioButton DelRadioButton;
		private RadioButton AddRadioButton;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Panel Panel4;
		private TextBox MemBox;
		private ComboBox KindCombo;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private DataGridViewTextBoxColumn Column12;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column15;
		private DataGridViewTextBoxColumn Column16;
		private DataGridViewTextBoxColumn Column4;
        private System.ComponentModel.IContainer components;
    }
	
}
