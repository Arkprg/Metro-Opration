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
using System.Windows.Forms.DataVisualization.Charting;
using Metro_Operation;

namespace Metro_Operation
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class DailyLeaveGraphForm : BaseForm
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
			this.components=new System.ComponentModel.Container();
			base.Load += new System.EventHandler(DailyLeaveGraphForm_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(DailyLeaveGraphForm));
			ChartArea ChartArea1=new ChartArea();
			Legend Legend1=new Legend();
			Series Series1=new Series();
			Title Title1=new Title();
			this.Panel1=new Panel();
			this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label7=new Label();
			this.Label8=new Label();
			this.Label9=new Label();
			this.Label10=new Label();
			this.ExportButton=new Button();
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.NameBox=new TextBox();
			this.Label3=new Label();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label2=new Label();
			this.Label1=new Label();
			this.Chart1=new Chart();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.Chart1).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.EndCalendar);
			this.Panel1.Controls.Add(this.StartCalendar);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.ExportButton);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(7, 11);
			this.Panel1.Margin=new Padding(3, 4, 3, 4);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(947, 94);
			this.Panel1.TabIndex=1;
			this.Panel1.TabStop=true;
			//
			//EndCalendar
			//
			this.EndCalendar.Location=new System.Drawing.Point(154, 55);
			this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.EndCalendar.Name="EndCalendar";
			this.EndCalendar.NowDateSelected=true;
			this.EndCalendar.ReadOnly=true;
			this.EndCalendar.SelectedDate=null;
			this.EndCalendar.Shamsi=null;
			this.EndCalendar.Size=new System.Drawing.Size(125, 23);
			this.EndCalendar.TabIndex=51;
			this.EndCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//StartCalendar
			//
			this.StartCalendar.Location=new System.Drawing.Point(154, 14);
			this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.StartCalendar.Name="StartCalendar";
			this.StartCalendar.NowDateSelected=true;
			this.StartCalendar.ReadOnly=true;
			this.StartCalendar.SelectedDate=null;
			this.StartCalendar.Shamsi=null;
			this.StartCalendar.Size=new System.Drawing.Size(125, 23);
			this.StartCalendar.TabIndex=50;
			this.StartCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(547, 54);
			this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(100, 24);
			this.ShiftCombo.TabIndex=10;
			//
			//PostCombo
			//
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(726, 54);
			this.PostCombo.Margin=new Padding(3, 4, 3, 4);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(170, 24);
			this.PostCombo.TabIndex=8;
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(547, 13);
			this.TimeCombo.Margin=new Padding(3, 4, 3, 4);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(100, 24);
			this.TimeCombo.TabIndex=9;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(726, 13);
			this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(170, 24);
			this.LocalCombo.TabIndex=7;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(895, 58);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(43, 16);
			this.Label7.TabIndex=42;
			this.Label7.Text="پست:";
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label8.Location=new System.Drawing.Point(646, 57);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(62, 14);
			this.Label8.TabIndex=49;
			this.Label8.Text="نام شیفت:";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Location=new System.Drawing.Point(895, 17);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(35, 16);
			this.Label9.TabIndex=44;
			this.Label9.Text="مبدا:";
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Font=new System.Drawing.Font("Tahoma", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label10.Location=new System.Drawing.Point(646, 17);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(63, 14);
			this.Label10.TabIndex=48;
			this.Label10.Text="نوع شیفت:";
			//
			//ExportButton
			//
			this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
			this.ExportButton.Image=(System.Drawing.Image) (resources.GetObject("ExportButton.BackgroundImage"));
			this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExportButton.Location=new System.Drawing.Point(10, 49);
			this.ExportButton.Margin=new Padding(3, 4, 3, 4);
			this.ExportButton.Name="ExportButton";
			this.ExportButton.Size=new System.Drawing.Size(124, 37);
			this.ExportButton.TabIndex=6;
			this.ExportButton.Text="ذخیره";
			this.ExportButton.UseVisualStyleBackColor=false;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.DialogResult=DialogResult.None;
			this.ShowButton.Location=new System.Drawing.Point(10, 7);
			this.ShowButton.Margin=new Padding(3, 4, 3, 4);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(124, 37);
			this.ShowButton.TabIndex=5;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(373, 13);
			this.NameBox.Margin=new Padding(3, 4, 3, 4);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(129, 23);
			this.NameBox.TabIndex=33;
			this.NameBox.TabStop=false;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(279, 17);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(51, 16);
			this.Label3.TabIndex=24;
			this.Label3.Text="از تاریخ:";
			//
			//NameButton
			//
			this.NameButton.DialogResult=DialogResult.None;
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(343, 12);
			this.NameButton.Margin=new Padding(3, 4, 3, 4);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(279, 58);
			this.Label2.Margin=new Padding(5, 0, 5, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(51, 16);
			this.Label2.TabIndex=28;
			this.Label2.Text="تا تاریخ:";
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(503, 16);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(29, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="نام:";
			//
			//Chart1
			//
			ChartArea1.AxisX.Interval=1.0D;
			ChartArea1.AxisX.LabelAutoFitStyle=(LabelAutoFitStyles) (LabelAutoFitStyles.IncreaseFont | LabelAutoFitStyles.DecreaseFont
				|  LabelAutoFitStyles.StaggeredLabels 
				| LabelAutoFitStyles.LabelsAngleStep30);
			ChartArea1.AxisX.MajorGrid.LineColor=System.Drawing.Color.Silver;
			ChartArea1.AxisX.MaximumAutoSize=(float) (45.0F);
			ChartArea1.AxisX.ScaleView.SizeType=DateTimeIntervalType.Number;
			ChartArea1.AxisX.ScrollBar.ButtonStyle=ScrollBarButtonStyles.SmallScroll;
			ChartArea1.AxisY.MajorGrid.LineColor=System.Drawing.Color.Silver;
			ChartArea1.CursorX.IsUserEnabled=true;
			ChartArea1.CursorX.IsUserSelectionEnabled=true;
			ChartArea1.Name="ChartArea1";
			this.Chart1.ChartAreas.Add(ChartArea1);
			Legend1.Enabled=false;
			Legend1.Name="Legend1";
			this.Chart1.Legends.Add(Legend1);
			this.Chart1.Location=new System.Drawing.Point(7, 113);
			this.Chart1.Name="Chart1";
			this.Chart1.Palette=ChartColorPalette.Excel;
			this.Chart1.PaletteCustomColors=new System.Drawing.Color[] {Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)))};
			Series1.BorderColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			Series1.BorderWidth=3;
			Series1.ChartArea="ChartArea1";
			Series1.ChartType=SeriesChartType.Line;
			Series1.IsValueShownAsLabel=true;
			Series1.Legend="Legend1";
			Series1.Name="1";
			this.Chart1.Series.Add(Series1);
			this.Chart1.Size=new System.Drawing.Size(947, 415);
			this.Chart1.TabIndex=2;
			this.Chart1.Text="Chart1";
			Title1.Font=new System.Drawing.Font("Tahoma", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			Title1.Name="Title1";
			this.Chart1.Titles.Add(Title1);
			//
			//DailyLeaveGraphForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(960, 533);
			this.Controls.Add(this.Chart1);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="DailyLeaveGraphForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="نمودار مرخصی روزانه";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.Chart1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		private Panel Panel1;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
		private ComboBox ShiftCombo;
		private ComboBox PostCombo;
		private ComboBox TimeCombo;
		private ComboBox LocalCombo;
		private Label Label7;
		private Label Label8;
		private Label Label9;
		private Label Label10;
		private Button ExportButton;
		private Button ShowButton;
		private TextBox NameBox;
		private Label Label3;
		private Button NameButton;
		private Label Label2;
		private Label Label1;
		private Chart Chart1;
	}
	
}
