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
	public partial class OvertimeLimitForm : BaseForm
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
			this.NameBox=new TextBox();
			this.FormClosing += new FormClosingEventHandler(OvertimeLimitFor_FormClosing);
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(OvertimeLimitForm_HelpButtonClicked);
			base.Load += new System.EventHandler(Form39_Load);
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.Button7_Click);
			this.Label1=new Label();
			this.LastMonthCheck=new CheckBox();
			this.LastMonthCheck.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.LimitBox=new MaskedTextBox();
			this.Label3=new Label();
			this.OverTimeBox=new TextBox();
			this.Label2=new Label();
			this.DataGridView1=new DataGridView();
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column4=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Panel1=new Panel();
			this.LiceCombo=new ComboBox();
			this.Label4=new Label();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(486, 13);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(147, 23);
			this.NameBox.TabIndex=42;
			//
			//NameButton
			//
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(456, 12);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(633, 15);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(33, 16);
			this.Label1.TabIndex=41;
			this.Label1.Text="نام :";
			//
			//LastMonthCheck
			//
			this.LastMonthCheck.AutoSize=true;
			this.LastMonthCheck.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.LastMonthCheck.Location=new System.Drawing.Point(185, 16);
			this.LastMonthCheck.Name="LastMonthCheck";
			this.LastMonthCheck.Size=new System.Drawing.Size(67, 20);
			this.LastMonthCheck.TabIndex=4;
			this.LastMonthCheck.Text="ماه قبل";
			this.LastMonthCheck.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(16, 9);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(130, 34);
			this.RegButton.TabIndex=3;
			this.RegButton.Text="تایید";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//LimitBox
			//
			this.LimitBox.Location=new System.Drawing.Point(283, 61);
			this.LimitBox.Mask="900:00";
			this.LimitBox.Name="LimitBox";
			this.LimitBox.RightToLeft=RightToLeft.No;
			this.LimitBox.Size=new System.Drawing.Size(59, 23);
			this.LimitBox.TabIndex=2;
			this.LimitBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(341, 64);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(97, 16);
			this.Label3.TabIndex=45;
			this.Label3.Text="سقف اضافه کار:";
			//
			//OverTimeBox
			//
			this.OverTimeBox.BackColor=System.Drawing.SystemColors.Window;
			this.OverTimeBox.Location=new System.Drawing.Point(283, 12);
			this.OverTimeBox.Name="OverTimeBox";
			this.OverTimeBox.ReadOnly=true;
			this.OverTimeBox.Size=new System.Drawing.Size(51, 23);
			this.OverTimeBox.TabIndex=5;
			this.OverTimeBox.Text="00:00";
			this.OverTimeBox.TextAlign=HorizontalAlignment.Center;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(341, 15);
			this.Label2.Margin=new Padding(4, 0, 4, 0);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(82, 16);
			this.Label2.TabIndex=43;
			this.Label2.Text="اضافه کار ماه:";
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Wheat;
			this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.DataGridView1.ColumnHeadersHeight=40;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column6, this.Column1, this.Column7, this.Column2, this.Column3, this.Column4, this.Column5});
			this.DataGridView1.Dock=DockStyle.Bottom;
			this.DataGridView1.EnableHeadersVisualStyles=false;
			this.DataGridView1.Location=new System.Drawing.Point(0, 113);
			this.DataGridView1.MultiSelect=false;
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.RowTemplate.ReadOnly=true;
			this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size=new System.Drawing.Size(705, 324);
			this.DataGridView1.TabIndex=44;
			//
			//Column6
			//
			this.Column6.HeaderText="ردیف";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			this.Column6.Width=45;
			//
			//Column1
			//
			this.Column1.HeaderText="نام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			//
			//Column7
			//
			this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText="نام خانوادگی";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			//
			//Column2
			//
			this.Column2.HeaderText="ش پرسنلی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Width=90;
			//
			//Column3
			//
			this.Column3.HeaderText="مجموع اضافه کار";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=110;
			//
			//Column4
			//
			this.Column4.HeaderText="سقف اضافه کار";
			this.Column4.Name="Column4";
			this.Column4.ReadOnly=true;
			this.Column4.Width=110;
			//
			//Column5
			//
			this.Column5.HeaderText="مجوز اضافه کاری";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=110;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.LiceCombo);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.ExitButton);
			this.Panel1.Controls.Add(this.LastMonthCheck);
			this.Panel1.Controls.Add(this.RegButton);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.LimitBox);
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.OverTimeBox);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Enabled=false;
			this.Panel1.Location=new System.Drawing.Point(12, 7);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(681, 100);
			this.Panel1.TabIndex=0;
			//
			//LiceCombo
			//
			this.LiceCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LiceCombo.FormattingEnabled=true;
			this.LiceCombo.Items.AddRange(new object[] {"دارد", "ندارد"});
			this.LiceCombo.Location=new System.Drawing.Point(456, 60);
			this.LiceCombo.Name="LiceCombo";
			this.LiceCombo.Size=new System.Drawing.Size(113, 24);
			this.LiceCombo.TabIndex=48;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(568, 64);
			this.Label4.Margin=new Padding(4, 0, 4, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(92, 16);
			this.Label4.TabIndex=47;
			this.Label4.Text="مجوز اضافه کار:";
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.Wheat;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ExitButton.Location=new System.Drawing.Point(16, 55);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(130, 34);
			this.ExitButton.TabIndex=46;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//OvertimeLimitForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.BurlyWood;
			this.ClientSize=new System.Drawing.Size(705, 437);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.DataGridView1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="OvertimeLimitForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="تعیین سقف اضافه کاری";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private TextBox NameBox;
		private Button NameButton;
		private Label Label1;
		private MaskedTextBox LimitBox;
		private Label Label3;
		private TextBox OverTimeBox;
		private Label Label2;
		private Button RegButton;
		private DataGridView DataGridView1;
		private CheckBox LastMonthCheck;
		private Panel Panel1;
		private Button ExitButton;
		private ComboBox LiceCombo;
		private Label Label4;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
	}
	
}
