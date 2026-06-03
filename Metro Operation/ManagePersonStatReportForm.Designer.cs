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
		public partial class ManagePersonStatReportForm : BaseForm
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
            this.components=new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5=new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView5=new System.Windows.Forms.DataGridView();
            this.Column11=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView4=new System.Windows.Forms.DataGridView();
            this.Column9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView3=new System.Windows.Forms.DataGridView();
            this.Column8=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView2=new System.Windows.Forms.DataGridView();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView1=new System.Windows.Forms.DataGridView();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label10=new System.Windows.Forms.Label();
            this.Label9=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.ZeroRowCheck=new System.Windows.Forms.CheckBox();
            this.PostCombo=new System.Windows.Forms.ComboBox();
            this.Label3=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.Label11=new System.Windows.Forms.Label();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.KindCombo=new System.Windows.Forms.ComboBox();
            this.TimeCombo=new System.Windows.Forms.ComboBox();
            this.ShiftCombo=new System.Windows.Forms.ComboBox();
            this.ExportButton=new System.Windows.Forms.Button();
            this.ShowButton=new System.Windows.Forms.Button();
            this.Label15=new System.Windows.Forms.Label();
            this.Label14=new System.Windows.Forms.Label();
            this.Label12=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView5
            // 
            this.DataGridView5.AllowUserToAddRows=false;
            this.DataGridView5.AllowUserToDeleteRows=false;
            this.DataGridView5.AllowUserToResizeColumns=false;
            this.DataGridView5.AllowUserToResizeRows=false;
            this.DataGridView5.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView5.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView5.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle1;
            this.DataGridView5.ColumnHeadersHeight=30;
            this.DataGridView5.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.DataGridViewTextBoxColumn9,
            this.Column3,
            this.DataGridViewTextBoxColumn10});
            this.DataGridView5.EnableHeadersVisualStyles=false;
            this.DataGridView5.Location=new System.Drawing.Point(7, 136);
            this.DataGridView5.MultiSelect=false;
            this.DataGridView5.Name="DataGridView5";
            this.DataGridView5.ReadOnly=true;
            this.DataGridView5.RowHeadersVisible=false;
            this.DataGridView5.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView5.Size=new System.Drawing.Size(227, 448);
            this.DataGridView5.TabIndex=36;
            this.DataGridView5.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView5_CellDoubleClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText="ردیف";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=45;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn9.Name="DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly=true;
            this.DataGridViewTextBoxColumn9.Width=120;
            // 
            // Column3
            // 
            this.Column3.HeaderText="پرسنلی";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Visible=false;
            this.Column3.Width=53;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.HeaderText="تعداد";
            this.DataGridViewTextBoxColumn10.Name="DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly=true;
            this.DataGridViewTextBoxColumn10.Width=44;
            // 
            // DataGridView4
            // 
            this.DataGridView4.AllowUserToAddRows=false;
            this.DataGridView4.AllowUserToDeleteRows=false;
            this.DataGridView4.AllowUserToResizeColumns=false;
            this.DataGridView4.AllowUserToResizeRows=false;
            this.DataGridView4.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView4.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView4.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.DataGridView4.ColumnHeadersHeight=30;
            this.DataGridView4.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.DataGridViewTextBoxColumn7,
            this.Column4,
            this.DataGridViewTextBoxColumn8});
            this.DataGridView4.EnableHeadersVisualStyles=false;
            this.DataGridView4.Location=new System.Drawing.Point(259, 136);
            this.DataGridView4.MultiSelect=false;
            this.DataGridView4.Name="DataGridView4";
            this.DataGridView4.ReadOnly=true;
            this.DataGridView4.RowHeadersVisible=false;
            this.DataGridView4.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView4.Size=new System.Drawing.Size(227, 448);
            this.DataGridView4.TabIndex=35;
            this.DataGridView4.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView4_CellMouseDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText="ردیف";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=45;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn7.Name="DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly=true;
            this.DataGridViewTextBoxColumn7.Width=120;
            // 
            // Column4
            // 
            this.Column4.HeaderText="پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Visible=false;
            this.Column4.Width=53;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.HeaderText="روز";
            this.DataGridViewTextBoxColumn8.Name="DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly=true;
            this.DataGridViewTextBoxColumn8.Width=44;
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToAddRows=false;
            this.DataGridView3.AllowUserToDeleteRows=false;
            this.DataGridView3.AllowUserToResizeColumns=false;
            this.DataGridView3.AllowUserToResizeRows=false;
            this.DataGridView3.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView3.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle3;
            this.DataGridView3.ColumnHeadersHeight=30;
            this.DataGridView3.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.DataGridViewTextBoxColumn5,
            this.Column5,
            this.DataGridViewTextBoxColumn6,
            this.Column10});
            this.DataGridView3.EnableHeadersVisualStyles=false;
            this.DataGridView3.Location=new System.Drawing.Point(511, 136);
            this.DataGridView3.MultiSelect=false;
            this.DataGridView3.Name="DataGridView3";
            this.DataGridView3.ReadOnly=true;
            this.DataGridView3.RowHeadersVisible=false;
            this.DataGridView3.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView3.Size=new System.Drawing.Size(240, 448);
            this.DataGridView3.TabIndex=34;
            this.DataGridView3.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView3_CellMouseDoubleClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=45;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly=true;
            this.DataGridViewTextBoxColumn5.Width=120;
            // 
            // Column5
            // 
            this.Column5.HeaderText="پرسنلی";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Visible=false;
            this.Column5.Width=53;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly=true;
            this.DataGridViewTextBoxColumn6.Width=57;
            // 
            // Column10
            // 
            this.Column10.HeaderText="Num1";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Visible=false;
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows=false;
            this.DataGridView2.AllowUserToDeleteRows=false;
            this.DataGridView2.AllowUserToResizeColumns=false;
            this.DataGridView2.AllowUserToResizeRows=false;
            this.DataGridView2.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView2.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle4;
            this.DataGridView2.ColumnHeadersHeight=30;
            this.DataGridView2.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.DataGridViewTextBoxColumn3,
            this.Column6,
            this.DataGridViewTextBoxColumn4});
            this.DataGridView2.EnableHeadersVisualStyles=false;
            this.DataGridView2.Location=new System.Drawing.Point(776, 136);
            this.DataGridView2.MultiSelect=false;
            this.DataGridView2.Name="DataGridView2";
            this.DataGridView2.ReadOnly=true;
            this.DataGridView2.RowHeadersVisible=false;
            this.DataGridView2.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size=new System.Drawing.Size(227, 448);
            this.DataGridView2.TabIndex=33;
            this.DataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView2_CellMouseDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText="ردیف";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=45;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly=true;
            this.DataGridViewTextBoxColumn3.Width=120;
            // 
            // Column6
            // 
            this.Column6.HeaderText="پرسنلی";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Visible=false;
            this.Column6.Width=53;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText="تعداد";
            this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly=true;
            this.DataGridViewTextBoxColumn4.Width=44;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            this.DataGridView1.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView1.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle5;
            this.DataGridView1.ColumnHeadersHeight=30;
            this.DataGridView1.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DataGridViewTextBoxColumn1,
            this.Column7,
            this.DataGridViewTextBoxColumn2});
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(1028, 136);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(227, 448);
            this.DataGridView1.TabIndex=32;
            this.DataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly=true;
            this.DataGridViewTextBoxColumn1.Width=120;
            // 
            // Column7
            // 
            this.Column7.HeaderText="پرسنلی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Visible=false;
            this.Column7.Width=55;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText="تعداد";
            this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly=true;
            this.DataGridViewTextBoxColumn2.Width=44;
            // 
            // Label10
            // 
            this.Label10.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label10.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Location=new System.Drawing.Point(377, 107);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(109, 28);
            this.Label10.TabIndex=31;
            this.Label10.Text="مرخصی روزانه";
            this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label9.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Location=new System.Drawing.Point(125, 107);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(109, 28);
            this.Label9.TabIndex=30;
            this.Label9.Text="جابجایی تریپ";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label8.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.Location=new System.Drawing.Point(642, 107);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(109, 28);
            this.Label8.TabIndex=29;
            this.Label8.Text="مرخصی ساعتی";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Location=new System.Drawing.Point(894, 107);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(109, 28);
            this.Label6.TabIndex=27;
            this.Label6.Text="امتیاز مثبت";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Location=new System.Drawing.Point(1146, 107);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(109, 28);
            this.Label2.TabIndex=26;
            this.Label2.Text="امتیاز منفی";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ZeroRowCheck);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.Label14);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.ForeColor=System.Drawing.Color.Black;
            this.Panel1.Location=new System.Drawing.Point(12, 12);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(1251, 80);
            this.Panel1.TabIndex=24;
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location=new System.Drawing.Point(472, 44);
            this.EndCalendar.Miladi=new System.DateTime(((long)(0)));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex=59;
            this.EndCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location=new System.Drawing.Point(472, 11);
            this.StartCalendar.Miladi=new System.DateTime(((long)(0)));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex=58;
            this.StartCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // ZeroRowCheck
            // 
            this.ZeroRowCheck.BackColor=System.Drawing.Color.Gray;
            this.ZeroRowCheck.ForeColor=System.Drawing.Color.White;
            this.ZeroRowCheck.Location=new System.Drawing.Point(300, 10);
            this.ZeroRowCheck.Name="ZeroRowCheck";
            this.ZeroRowCheck.Padding=new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ZeroRowCheck.Size=new System.Drawing.Size(146, 57);
            this.ZeroRowCheck.TabIndex=57;
            this.ZeroRowCheck.Text="حذف سطر های دارای مقدار صفر";
            this.ZeroRowCheck.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.ZeroRowCheck.UseVisualStyleBackColor=false;
            this.ZeroRowCheck.CheckedChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // PostCombo
            // 
            this.PostCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCombo.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.PostCombo.FormattingEnabled=true;
            this.PostCombo.Location=new System.Drawing.Point(844, 43);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(166, 24);
            this.PostCombo.TabIndex=54;
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.BackColor=System.Drawing.Color.Transparent;
            this.Label3.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Label3.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label3.Location=new System.Drawing.Point(1009, 47);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(97, 16);
            this.Label3.TabIndex=55;
            this.Label3.Text="پست سازمانی:";
            this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Label5.Location=new System.Drawing.Point(602, 14);
            this.Label5.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(51, 16);
            this.Label5.TabIndex=52;
            this.Label5.Text="از تاریخ:";
            // 
            // Label11
            // 
            this.Label11.AutoSize=true;
            this.Label11.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Label11.Location=new System.Drawing.Point(601, 47);
            this.Label11.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(51, 16);
            this.Label11.TabIndex=53;
            this.Label11.Text="تا تاریخ:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.BackColor=System.Drawing.Color.White;
            this.LocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(844, 10);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(166, 24);
            this.LocalCombo.TabIndex=48;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // KindCombo
            // 
            this.KindCombo.BackColor=System.Drawing.Color.White;
            this.KindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] {
            "امتیاز پرسنل",
            "امتیاز کاربران"});
            this.KindCombo.Location=new System.Drawing.Point(1060, 10);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(109, 24);
            this.KindCombo.TabIndex=46;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // TimeCombo
            // 
            this.TimeCombo.BackColor=System.Drawing.Color.White;
            this.TimeCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCombo.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Location=new System.Drawing.Point(664, 10);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(109, 24);
            this.TimeCombo.TabIndex=43;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.BackColor=System.Drawing.Color.White;
            this.ShiftCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftCombo.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Location=new System.Drawing.Point(664, 43);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(109, 24);
            this.ShiftCombo.TabIndex=41;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(12, 22);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(123, 34);
            this.ExportButton.TabIndex=5;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location=new System.Drawing.Point(141, 22);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(123, 34);
            this.ShowButton.TabIndex=4;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Label15
            // 
            this.Label15.AutoSize=true;
            this.Label15.BackColor=System.Drawing.Color.Transparent;
            this.Label15.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor=System.Drawing.Color.Black;
            this.Label15.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label15.Location=new System.Drawing.Point(1169, 14);
            this.Label15.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label15.Name="Label15";
            this.Label15.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size=new System.Drawing.Size(70, 16);
            this.Label15.TabIndex=49;
            this.Label15.Text="نوع گزارش:";
            this.Label15.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.AutoSize=true;
            this.Label14.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Label14.Location=new System.Drawing.Point(1009, 14);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(35, 16);
            this.Label14.TabIndex=47;
            this.Label14.Text="مبدا:";
            // 
            // Label12
            // 
            this.Label12.AutoSize=true;
            this.Label12.BackColor=System.Drawing.Color.Transparent;
            this.Label12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Label12.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label12.Location=new System.Drawing.Point(772, 14);
            this.Label12.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label12.Name="Label12";
            this.Label12.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size=new System.Drawing.Size(72, 16);
            this.Label12.TabIndex=44;
            this.Label12.Text="نوع شیفت:";
            this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.Label7.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label7.Location=new System.Drawing.Point(772, 47);
            this.Label7.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label7.Name="Label7";
            this.Label7.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size=new System.Drawing.Size(50, 16);
            this.Label7.TabIndex=42;
            this.Label7.Text="شیفت:";
            this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor=System.Drawing.Color.Orange;
            this.Label1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Location=new System.Drawing.Point(393, 595);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(491, 25);
            this.Label1.TabIndex=43;
            this.Label1.Text="----------     برای دیدن جزئیات بیشتر بر روی سطر مورد نظر دابل کلیک کنید     ----" +
    "------";
            // 
            // ManagePersonStatReportForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(1275, 631);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGridView5);
            this.Controls.Add(this.DataGridView4);
            this.Controls.Add(this.DataGridView3);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton=true;
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ManagePersonStatReportForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="گزارش جزئیات امتیاز پرسنل";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ManagePersonStatReportForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.ManagePersonStatReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private DataGridView DataGridView5;
		private DataGridView DataGridView4;
		private DataGridView DataGridView3;
		private DataGridView DataGridView2;
		private DataGridView DataGridView1;
		private Label Label10;
		private Label Label9;
		private Label Label8;
		private Label Label6;
		private Label Label2;
		private Panel Panel1;
		private Button ExportButton;
		private Button ShowButton;
		private Label Label12;
		private ComboBox TimeCombo;
		private Label Label7;
		private ComboBox ShiftCombo;
		private ComboBox KindCombo;
		private Label Label14;
		private ComboBox LocalCombo;
		private Label Label15;
		private Label Label1;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private Label Label5;
		private Label Label11;
		private ComboBox PostCombo;
		private Label Label3;
		private CheckBox ZeroRowCheck;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private System.ComponentModel.IContainer components;
    }
	
}
