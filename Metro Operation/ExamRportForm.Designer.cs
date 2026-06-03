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
	partial class ExamRportForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15=new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel2=new System.Windows.Forms.Panel();
            this.SearchTitrCombo=new System.Windows.Forms.ComboBox();
            this.SearchKindCombo=new System.Windows.Forms.ComboBox();
            this.Label2=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.ExportButton=new System.Windows.Forms.Button();
            this.PostLabel=new System.Windows.Forms.Label();
            this.LocalLabel=new System.Windows.Forms.Label();
            this.LineLabel=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.Label9=new System.Windows.Forms.Label();
            this.LevLabel=new System.Windows.Forms.Label();
            this.ShiftLabel=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.TimeLabel=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.DateLabel=new System.Windows.Forms.Label();
            this.Label3=new System.Windows.Forms.Label();
            this.ResultGridView=new System.Windows.Forms.DataGridView();
            this.Column10=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuizGridView=new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndLabel=new System.Windows.Forms.Label();
            this.label11=new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExportButton);
            this.Panel2.Controls.Add(this.SearchTitrCombo);
            this.Panel2.Controls.Add(this.SearchKindCombo);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location=new System.Drawing.Point(9, 7);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(813, 45);
            this.Panel2.TabIndex=1;
            // 
            // SearchTitrCombo
            // 
            this.SearchTitrCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchTitrCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchTitrCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchTitrCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchTitrCombo.FormattingEnabled=true;
            this.SearchTitrCombo.Location=new System.Drawing.Point(182, 9);
            this.SearchTitrCombo.Name="SearchTitrCombo";
            this.SearchTitrCombo.Size=new System.Drawing.Size(310, 24);
            this.SearchTitrCombo.TabIndex=4;
            this.SearchTitrCombo.SelectedIndexChanged += new System.EventHandler(this.TitrCombo_SelectedIndexChanged);
            // 
            // SearchKindCombo
            // 
            this.SearchKindCombo.AutoCompleteMode=System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchKindCombo.AutoCompleteSource=System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SearchKindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchKindCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchKindCombo.FormattingEnabled=true;
            this.SearchKindCombo.Items.AddRange(new object[] {
            "نظر سنجی",
            "آزمون"});
            this.SearchKindCombo.Location=new System.Drawing.Point(588, 9);
            this.SearchKindCombo.Name="SearchKindCombo";
            this.SearchKindCombo.Size=new System.Drawing.Size(120, 24);
            this.SearchKindCombo.TabIndex=3;
            this.SearchKindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(491, 13);
            this.Label2.Margin=new System.Windows.Forms.Padding(3);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(44, 16);
            this.Label2.TabIndex=95;
            this.Label2.Text="عنوان:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(707, 13);
            this.Label1.Margin=new System.Windows.Forms.Padding(3);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(31, 16);
            this.Label1.TabIndex=81;
            this.Label1.Text="نوع:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PostLabel);
            this.Panel1.Controls.Add(this.LocalLabel);
            this.Panel1.Controls.Add(this.LineLabel);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.LevLabel);
            this.Panel1.Controls.Add(this.ShiftLabel);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.TimeLabel);
            this.Panel1.Controls.Add(this.EndLabel);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.DateLabel);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location=new System.Drawing.Point(9, 59);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(813, 67);
            this.Panel1.TabIndex=3;
            // 
            // ExportButton
            // 
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.docs_24;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(6, 5);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(107, 32);
            this.ExportButton.TabIndex=96;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // PostLabel
            // 
            this.PostLabel.BackColor=System.Drawing.Color.Transparent;
            this.PostLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostLabel.Location=new System.Drawing.Point(556, 36);
            this.PostLabel.Name="PostLabel";
            this.PostLabel.Size=new System.Drawing.Size(152, 20);
            this.PostLabel.TabIndex=95;
            this.PostLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocalLabel
            // 
            this.LocalLabel.BackColor=System.Drawing.Color.Transparent;
            this.LocalLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalLabel.Location=new System.Drawing.Point(376, 36);
            this.LocalLabel.Name="LocalLabel";
            this.LocalLabel.Size=new System.Drawing.Size(134, 20);
            this.LocalLabel.TabIndex=95;
            this.LocalLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LineLabel
            // 
            this.LineLabel.BackColor=System.Drawing.Color.Transparent;
            this.LineLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LineLabel.Location=new System.Drawing.Point(9, 8);
            this.LineLabel.Name="LineLabel";
            this.LineLabel.Size=new System.Drawing.Size(98, 20);
            this.LineLabel.TabIndex=95;
            this.LineLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.BackColor=System.Drawing.Color.Transparent;
            this.Label5.Location=new System.Drawing.Point(109, 10);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(31, 16);
            this.Label5.TabIndex=95;
            this.Label5.Text="خط:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.BackColor=System.Drawing.Color.Transparent;
            this.Label6.Location=new System.Drawing.Point(513, 38);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(40, 16);
            this.Label6.TabIndex=93;
            this.Label6.Text="مبداء:";
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.Location=new System.Drawing.Point(513, 10);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(74, 16);
            this.Label4.TabIndex=80;
            this.Label4.Text="تاریخ شروع:";
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.BackColor=System.Drawing.Color.Transparent;
            this.Label9.Location=new System.Drawing.Point(109, 38);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(70, 16);
            this.Label9.TabIndex=91;
            this.Label9.Text="نام شیفت:";
            // 
            // LevLabel
            // 
            this.LevLabel.BackColor=System.Drawing.Color.Transparent;
            this.LevLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LevLabel.Location=new System.Drawing.Point(588, 8);
            this.LevLabel.Name="LevLabel";
            this.LevLabel.Size=new System.Drawing.Size(120, 20);
            this.LevLabel.TabIndex=89;
            this.LevLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.BackColor=System.Drawing.Color.Transparent;
            this.ShiftLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShiftLabel.Location=new System.Drawing.Point(10, 36);
            this.ShiftLabel.Name="ShiftLabel";
            this.ShiftLabel.Size=new System.Drawing.Size(97, 20);
            this.ShiftLabel.TabIndex=89;
            this.ShiftLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.Location=new System.Drawing.Point(711, 38);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(97, 16);
            this.Label7.TabIndex=82;
            this.Label7.Text="پست سازمانی:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor=System.Drawing.Color.Transparent;
            this.TimeLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeLabel.Location=new System.Drawing.Point(182, 36);
            this.TimeLabel.Name="TimeLabel";
            this.TimeLabel.Size=new System.Drawing.Size(116, 20);
            this.TimeLabel.TabIndex=89;
            this.TimeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.BackColor=System.Drawing.Color.Transparent;
            this.Label8.Location=new System.Drawing.Point(301, 38);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(72, 16);
            this.Label8.TabIndex=89;
            this.Label8.Text="نوع شیفت:";
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor=System.Drawing.Color.Transparent;
            this.DateLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.Location=new System.Drawing.Point(394, 8);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(116, 20);
            this.DateLabel.TabIndex=87;
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.BackColor=System.Drawing.Color.Transparent;
            this.Label3.Location=new System.Drawing.Point(711, 10);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(95, 16);
            this.Label3.TabIndex=83;
            this.Label3.Text="نوع پاسخگویی:";
            // 
            // ResultGridView
            // 
            this.ResultGridView.AllowUserToAddRows=false;
            this.ResultGridView.AllowUserToDeleteRows=false;
            this.ResultGridView.AllowUserToResizeColumns=false;
            this.ResultGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle11.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor=System.Drawing.Color.Moccasin;
            this.ResultGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.ResultGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle12;
            this.ResultGridView.ColumnHeadersHeight=40;
            this.ResultGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column11});
            this.ResultGridView.EnableHeadersVisualStyles=false;
            this.ResultGridView.Location=new System.Drawing.Point(9, 405);
            this.ResultGridView.MultiSelect=false;
            this.ResultGridView.Name="ResultGridView";
            this.ResultGridView.ReadOnly=true;
            this.ResultGridView.RowHeadersVisible=false;
            this.ResultGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ResultGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ResultGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ResultGridView.RowTemplate.ReadOnly=true;
            this.ResultGridView.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.ResultGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultGridView.Size=new System.Drawing.Size(813, 265);
            this.ResultGridView.TabIndex=38;
            this.ResultGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowGridView_ColumnHeaderMouseClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText="ردیف";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=45;
            // 
            // Column1
            // 
            this.Column1.HeaderText="نام";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=70;
            // 
            // Column7
            // 
            this.Column7.HeaderText="نام خانوادگی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=115;
            // 
            // Column2
            // 
            this.Column2.HeaderText="ش پرسنلی";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=80;
            // 
            // Column3
            // 
            this.Column3.HeaderText="مبدا";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Visible=false;
            // 
            // Column4
            // 
            this.Column4.HeaderText="نوع شیفت";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Visible=false;
            // 
            // Column5
            // 
            this.Column5.HeaderText="نام شیفت";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Visible=false;
            // 
            // Column11
            // 
            this.Column11.HeaderText="تاریخ ثبت";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=115;
            // 
            // QuizGridView
            // 
            this.QuizGridView.AllowUserToAddRows=false;
            this.QuizGridView.AllowUserToDeleteRows=false;
            this.QuizGridView.AllowUserToResizeColumns=false;
            this.QuizGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle13.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.QuizGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle14.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle14.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.QuizGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle14;
            this.QuizGridView.ColumnHeadersHeight=40;
            this.QuizGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.QuizGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6});
            this.QuizGridView.EnableHeadersVisualStyles=false;
            this.QuizGridView.Location=new System.Drawing.Point(9, 133);
            this.QuizGridView.MultiSelect=false;
            this.QuizGridView.Name="QuizGridView";
            this.QuizGridView.ReadOnly=true;
            this.QuizGridView.RowHeadersVisible=false;
            this.QuizGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.QuizGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.QuizGridView.RowTemplate.ReadOnly=true;
            this.QuizGridView.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.QuizGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuizGridView.Size=new System.Drawing.Size(813, 265);
            this.QuizGridView.TabIndex=38;
            this.QuizGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowGridView_ColumnHeaderMouseClick);
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGridViewTextBoxColumn2.DefaultCellStyle=dataGridViewCellStyle15;
            this.DataGridViewTextBoxColumn2.HeaderText="سوال";
            this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly=true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText="الف";
            this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly=true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText="ب";
            this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly=true;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText="ج";
            this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly=true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText="د";
            this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly=true;
            // 
            // EndLabel
            // 
            this.EndLabel.BackColor=System.Drawing.Color.Transparent;
            this.EndLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EndLabel.Location=new System.Drawing.Point(182, 8);
            this.EndLabel.Name="EndLabel";
            this.EndLabel.Size=new System.Drawing.Size(116, 20);
            this.EndLabel.TabIndex=87;
            this.EndLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize=true;
            this.label11.BackColor=System.Drawing.Color.Transparent;
            this.label11.Location=new System.Drawing.Point(301, 10);
            this.label11.Name="label11";
            this.label11.Size=new System.Drawing.Size(68, 16);
            this.label11.TabIndex=80;
            this.label11.Text="تاریخ پایان:";
            // 
            // ExamRportForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(829, 680);
            this.Controls.Add(this.QuizGridView);
            this.Controls.Add(this.ResultGridView);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ExamRportForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="نتایج آزمون/نظرسنجی";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizGridView)).EndInit();
            this.ResumeLayout(false);

		}
		
		private Panel Panel2;
		private ComboBox SearchTitrCombo;
		private ComboBox SearchKindCombo;
		private Label Label2;
		private Label Label1;
		private Panel Panel1;
		private Label PostLabel;
		private Label LocalLabel;
		private Label LineLabel;
		private Label Label5;
		private Label Label6;
		private Label Label4;
		private Label Label9;
		private Label LevLabel;
		private Label ShiftLabel;
		private Label Label7;
		private Label TimeLabel;
		private Label Label8;
		private Label DateLabel;
		private Label Label3;
		private DataGridView ResultGridView;
		private Button ExportButton;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column11;
		private DataGridView QuizGridView;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private Label label11;
        private Label EndLabel;
    }
	
}
