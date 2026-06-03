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
	partial class ElectionResultForm : BaseForm
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
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			this.NameCombo=new ComboBox();
			base.Load += new System.EventHandler(ElectionResultForm_Load);
			this.NameCombo.SelectedIndexChanged += new System.EventHandler(this.NameCombo_SelectedIndexChanged);
			this.Label2=new Label();
			this.Panel2=new Panel();
			this.AraLabel=new Label();
			this.PercentLabel=new Label();
			this.NumLabel=new Label();
			this.Label3=new Label();
			this.Label6=new Label();
			this.Label1=new Label();
			this.CandidGridView=new DataGridView();
			this.CandidGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.CandidGridView_ColumnHeaderMouseClick);
			this.Column14=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.TotalLabel=new Label();
			this.EndCalendar=new Label();
			this.StartCalendar=new Label();
			this.Label8=new Label();
			this.Label17=new Label();
			this.Label4=new Label();
			this.Panel1=new Panel();
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.Label5=new Label();
			this.TypeLabel=new Label();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.CandidGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//NameCombo
			//
			this.NameCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.NameCombo.FormattingEnabled=true;
			this.NameCombo.Location=new System.Drawing.Point(286, 26);
			this.NameCombo.Name="NameCombo";
			this.NameCombo.Size=new System.Drawing.Size(289, 24);
			this.NameCombo.TabIndex=3;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(576, 30);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(44, 16);
			this.Label2.TabIndex=4;
			this.Label2.Text="عنوان:";
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.Wheat;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.AraLabel);
			this.Panel2.Controls.Add(this.PercentLabel);
			this.Panel2.Controls.Add(this.TypeLabel);
			this.Panel2.Controls.Add(this.NumLabel);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.TotalLabel);
			this.Panel2.Controls.Add(this.EndCalendar);
			this.Panel2.Controls.Add(this.StartCalendar);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label17);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Location=new System.Drawing.Point(451, 98);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(243, 392);
			this.Panel2.TabIndex=5;
			this.Panel2.TabStop=true;
			//
			//AraLabel
			//
			this.AraLabel.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AraLabel.Location=new System.Drawing.Point(21, 226);
			this.AraLabel.Margin=new Padding(3);
			this.AraLabel.Name="AraLabel";
			this.AraLabel.Size=new System.Drawing.Size(91, 20);
			this.AraLabel.TabIndex=88;
			this.AraLabel.Text="--";
			this.AraLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//PercentLabel
			//
			this.PercentLabel.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PercentLabel.Location=new System.Drawing.Point(21, 256);
			this.PercentLabel.Margin=new Padding(3);
			this.PercentLabel.Name="PercentLabel";
			this.PercentLabel.Size=new System.Drawing.Size(91, 20);
			this.PercentLabel.TabIndex=88;
			this.PercentLabel.Text="--";
			this.PercentLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//NumLabel
			//
			this.NumLabel.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NumLabel.Location=new System.Drawing.Point(21, 85);
			this.NumLabel.Margin=new Padding(3);
			this.NumLabel.Name="NumLabel";
			this.NumLabel.Size=new System.Drawing.Size(91, 20);
			this.NumLabel.TabIndex=88;
			this.NumLabel.Text="--";
			this.NumLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.Location=new System.Drawing.Point(115, 228);
			this.Label3.Margin=new Padding(3);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(112, 16);
			this.Label3.TabIndex=89;
			this.Label3.Text="تعداد شرکت کننده:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label6.Location=new System.Drawing.Point(115, 258);
			this.Label6.Margin=new Padding(3);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(93, 16);
			this.Label6.TabIndex=89;
			this.Label6.Text="درصد مشارکت:";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.Location=new System.Drawing.Point(115, 87);
			this.Label1.Margin=new Padding(3);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(79, 16);
			this.Label1.TabIndex=89;
			this.Label1.Text="تعداد انتخاب:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//CandidGridView
			//
			this.CandidGridView.AllowUserToAddRows=false;
			this.CandidGridView.AllowUserToDeleteRows=false;
			this.CandidGridView.AllowUserToResizeColumns=false;
			this.CandidGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.CandidGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.CandidGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.CandidGridView.ColumnHeadersHeight=40;
			this.CandidGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.CandidGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column14, this.Column5, this.Column6, this.Column7, this.Column1, this.Column3, this.Column2});
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
			this.CandidGridView.DefaultCellStyle=DataGridViewCellStyle3;
			this.CandidGridView.EnableHeadersVisualStyles=false;
			this.CandidGridView.Location=new System.Drawing.Point(10, 98);
			this.CandidGridView.MultiSelect=false;
			this.CandidGridView.Name="CandidGridView";
			this.CandidGridView.ReadOnly=true;
			this.CandidGridView.RowHeadersVisible=false;
			this.CandidGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.CandidGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CandidGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.CandidGridView.Size=new System.Drawing.Size(429, 392);
			this.CandidGridView.TabIndex=81;
			//
			//Column14
			//
			this.Column14.HeaderText="ردیف";
			this.Column14.Name="Column14";
			this.Column14.ReadOnly=true;
			this.Column14.Width=45;
			//
			//Column5
			//
			this.Column5.HeaderText="نام";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=90;
			//
			//Column6
			//
			this.Column6.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText="نام خانوادگی";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			//
			//Column7
			//
			this.Column7.HeaderText="پرسنلی";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Width=80;
			//
			//Column1
			//
			this.Column1.HeaderText="تعداد رای";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Width=70;
			//
			//Column3
			//
			this.Column3.HeaderText="رصد";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Visible=false;
			//
			//Column2
			//
			this.Column2.HeaderText="ID";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Visible=false;
			//
			//TotalLabel
			//
			this.TotalLabel.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TotalLabel.Location=new System.Drawing.Point(21, 196);
			this.TotalLabel.Margin=new Padding(3);
			this.TotalLabel.Name="TotalLabel";
			this.TotalLabel.Size=new System.Drawing.Size(91, 20);
			this.TotalLabel.TabIndex=80;
			this.TotalLabel.Text="--";
			this.TotalLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//EndCalendar
			//
			this.EndCalendar.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.EndCalendar.Location=new System.Drawing.Point(21, 55);
			this.EndCalendar.Margin=new Padding(3);
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.Size=new System.Drawing.Size(91, 20);
			this.EndCalendar.TabIndex=80;
			this.EndCalendar.Text="--";
			this.EndCalendar.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//StartCalendar
			//
			this.StartCalendar.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.StartCalendar.Location=new System.Drawing.Point(21, 25);
			this.StartCalendar.Margin=new Padding(3);
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.Size=new System.Drawing.Size(91, 20);
			this.StartCalendar.TabIndex=80;
			this.StartCalendar.Text="--";
			this.StartCalendar.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label8.Location=new System.Drawing.Point(115, 198);
			this.Label8.Margin=new Padding(3);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(89, 16);
			this.Label8.TabIndex=80;
			this.Label8.Text="واجدین شرایط:";
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label17.Location=new System.Drawing.Point(115, 57);
			this.Label17.Margin=new Padding(3);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(68, 16);
			this.Label17.TabIndex=80;
			this.Label17.Text="تاریخ پایان:";
			this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(115, 27);
			this.Label4.Margin=new Padding(3);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(74, 16);
			this.Label4.TabIndex=80;
			this.Label4.Text="تاریخ شروع:";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.NameCombo);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Location=new System.Drawing.Point(10, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(684, 75);
			this.Panel1.TabIndex=90;
			this.Panel1.TabStop=true;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.DialogResult=DialogResult.None;
			this.ShowButton.Location=new System.Drawing.Point(18, 20);
			this.ShowButton.Margin=new Padding(3, 4, 3, 4);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(124, 37);
			this.ShowButton.TabIndex=6;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.Location=new System.Drawing.Point(115, 117);
			this.Label5.Margin=new Padding(3);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(65, 16);
			this.Label5.TabIndex=89;
			this.Label5.Text="نوع نتیجه:";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TypeLabel
			//
			this.TypeLabel.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TypeLabel.Location=new System.Drawing.Point(21, 115);
			this.TypeLabel.Margin=new Padding(3);
			this.TypeLabel.Name="TypeLabel";
			this.TypeLabel.Size=new System.Drawing.Size(91, 20);
			this.TypeLabel.TabIndex=88;
			this.TypeLabel.Text="--";
			this.TypeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//ElectionResultForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(705, 510);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.CandidGridView);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="ElectionResultForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="نتبجه انتخابات";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.CandidGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		private ComboBox NameCombo;
		private Label Label2;
		private Panel Panel2;
		private Label EndCalendar;
		private Label StartCalendar;
		private Label Label17;
		private Label Label4;
		private DataGridView CandidGridView;
		private DataGridViewTextBoxColumn Column14;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private Label NumLabel;
		private Label Label1;
		private Label AraLabel;
		private Label Label3;
		private Label PercentLabel;
		private Label Label6;
		private Label TotalLabel;
		private Label Label8;
		private Panel Panel1;
		private Button ShowButton;
		private Label TypeLabel;
		private Label Label5;
	}
	
}
