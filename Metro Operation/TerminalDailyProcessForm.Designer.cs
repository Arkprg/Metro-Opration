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
	public partial class TerminalDailyProcessForm : BaseForm
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
			base.Load += new System.EventHandler(TerminalDailyProcessForm_Load);
			DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
			this.Panel1=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.NameCombo=new ComboBox();
			this.NameCombo.SelectedIndexChanged += new System.EventHandler(this.NameCombo_SelectedIndexChanged);
			this.Label30=new Label();
			this.ProcessButton=new Button();
			this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
			this.Label3=new Label();
			this.Label1=new Label();
			this.PictureBox9=new PictureBox();
			this.PictureBox8=new PictureBox();
			this.DataGridView2=new DataGridView();
			this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
			this.DataGridView1=new DataGridView();
			this.Column9=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewTextBoxColumn();
			this.Column3=new DataGridViewTextBoxColumn();
			this.Column7=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Transparent;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PersianCalendar);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.NameCombo);
			this.Panel1.Controls.Add(this.Label30);
			this.Panel1.Controls.Add(this.ProcessButton);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location=new System.Drawing.Point(12, 12);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(902, 61);
			this.Panel1.TabIndex=1;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(709, 18);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(128, 23);
			this.PersianCalendar.TabIndex=50;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"شنبه تا چهارشنبه", "پنج شنبه", "جمعه و تعطیل"});
			this.KindCombo.Location=new System.Drawing.Point(493, 17);
			this.KindCombo.Margin=new Padding(4, 5, 4, 5);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(129, 24);
			this.KindCombo.TabIndex=1;
			//
			//NameCombo
			//
			this.NameCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.NameCombo.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.NameCombo.FormattingEnabled=true;
			this.NameCombo.Location=new System.Drawing.Point(197, 17);
			this.NameCombo.Margin=new Padding(4, 5, 4, 5);
			this.NameCombo.Name="NameCombo";
			this.NameCombo.Size=new System.Drawing.Size(217, 24);
			this.NameCombo.TabIndex=2;
			//
			//Label30
			//
			this.Label30.AutoSize=true;
			this.Label30.BackColor=System.Drawing.Color.Transparent;
			this.Label30.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label30.ForeColor=System.Drawing.Color.Black;
			this.Label30.Location=new System.Drawing.Point(837, 21);
			this.Label30.Margin=new Padding(4, 0, 4, 0);
			this.Label30.Name="Label30";
			this.Label30.Size=new System.Drawing.Size(39, 16);
			this.Label30.TabIndex=49;
			this.Label30.Text="تاریخ:";
			this.Label30.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//ProcessButton
			//
			this.ProcessButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ProcessButton.Image=global::Metro_Operation.Properties.Resources.to_do_list;
			this.ProcessButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ProcessButton.Cursor=Cursors.Hand;
			this.ProcessButton.DialogResult=DialogResult.None;
			this.ProcessButton.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ProcessButton.ForeColor=System.Drawing.Color.Black;
			this.ProcessButton.Location=new System.Drawing.Point(12, 8);
			this.ProcessButton.Margin=new Padding(5, 6, 5, 6);
			this.ProcessButton.Name="ProcessButton";
			this.ProcessButton.Size=new System.Drawing.Size(135, 43);
			this.ProcessButton.TabIndex=3;
			this.ProcessButton.Text="پردازش";
			this.ProcessButton.UseVisualStyleBackColor=false;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.ForeColor=System.Drawing.Color.Black;
			this.Label3.Location=new System.Drawing.Point(621, 21);
			this.Label3.Margin=new Padding(5, 0, 5, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(74, 16);
			this.Label3.TabIndex=42;
			this.Label3.Text="نوع پردازش:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.BackColor=System.Drawing.Color.Transparent;
			this.Label1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.ForeColor=System.Drawing.Color.Black;
			this.Label1.Location=new System.Drawing.Point(412, 21);
			this.Label1.Margin=new Padding(5, 0, 5, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(72, 16);
			this.Label1.TabIndex=44;
			this.Label1.Text="نام پردازش:";
			this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox9
			//
			this.PictureBox9.Image=global::Metro_Operation.Properties.Resources.p_tehran;
			this.PictureBox9.Location=new System.Drawing.Point(594, 76);
			this.PictureBox9.Name="PictureBox9";
			this.PictureBox9.Size=new System.Drawing.Size(210, 52);
			this.PictureBox9.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox9.TabIndex=76;
			this.PictureBox9.TabStop=false;
			//
			//PictureBox8
			//
			this.PictureBox8.Image=global::Metro_Operation.Properties.Resources.p_mehrshahr;
			this.PictureBox8.Location=new System.Drawing.Point(130, 76);
			this.PictureBox8.Name="PictureBox8";
			this.PictureBox8.Size=new System.Drawing.Size(210, 52);
			this.PictureBox8.SizeMode=PictureBoxSizeMode.StretchImage;
			this.PictureBox8.TabIndex=77;
			this.PictureBox8.TabStop=false;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows=false;
			this.DataGridView2.AllowUserToDeleteRows=false;
			this.DataGridView2.AllowUserToResizeColumns=false;
			this.DataGridView2.AllowUserToResizeRows=false;
			DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
			this.DataGridView2.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
			this.DataGridView2.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
			this.DataGridView2.ColumnHeadersHeight=40;
			this.DataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView2.Columns.AddRange(new DataGridViewColumn[] {this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.DataGridViewTextBoxColumn5});
			this.DataGridView2.EnableHeadersVisualStyles=false;
			this.DataGridView2.Location=new System.Drawing.Point(8, 127);
			this.DataGridView2.MultiSelect=false;
			this.DataGridView2.Name="DataGridView2";
			this.DataGridView2.ReadOnly=true;
			this.DataGridView2.RowHeadersVisible=false;
			this.DataGridView2.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView2.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView2.RowTemplate.ReadOnly=true;
			this.DataGridView2.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size=new System.Drawing.Size(455, 482);
			this.DataGridView2.TabIndex=50;
			//
			//DataGridViewTextBoxColumn1
			//
			this.DataGridViewTextBoxColumn1.HeaderText="ردیف";
			this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly=true;
			this.DataGridViewTextBoxColumn1.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn1.Width=45;
			//
			//DataGridViewTextBoxColumn2
			//
			this.DataGridViewTextBoxColumn2.HeaderText="ساعت اعزام";
			this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly=true;
			this.DataGridViewTextBoxColumn2.Resizable=DataGridViewTriState.False;
			this.DataGridViewTextBoxColumn2.Width=90;
			//
			//DataGridViewTextBoxColumn3
			//
			this.DataGridViewTextBoxColumn3.HeaderText="نوع";
			this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
			this.DataGridViewTextBoxColumn3.ReadOnly=true;
			this.DataGridViewTextBoxColumn3.Width=75;
			//
			//DataGridViewTextBoxColumn4
			//
			this.DataGridViewTextBoxColumn4.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn4.HeaderText="مبداء";
			this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn4.ReadOnly=true;
			this.DataGridViewTextBoxColumn4.Resizable=DataGridViewTriState.False;
			//
			//DataGridViewTextBoxColumn5
			//
			this.DataGridViewTextBoxColumn5.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.DataGridViewTextBoxColumn5.HeaderText="مقصد";
			this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn5.ReadOnly=true;
			this.DataGridViewTextBoxColumn5.Resizable=DataGridViewTriState.False;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows=false;
			this.DataGridView1.AllowUserToDeleteRows=false;
			this.DataGridView1.AllowUserToResizeColumns=false;
			this.DataGridView1.AllowUserToResizeRows=false;
			DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle3.BackColor=System.Drawing.Color.Moccasin;
			DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle3;
			this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
			DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode=DataGridViewTriState.False;
			this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle4;
			this.DataGridView1.ColumnHeadersHeight=40;
			this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {this.Column9, this.Column1, this.Column3, this.Column7, this.Column2});
			this.DataGridView1.EnableHeadersVisualStyles=false;
			this.DataGridView1.Location=new System.Drawing.Point(472, 127);
			this.DataGridView1.MultiSelect=false;
			this.DataGridView1.Name="DataGridView1";
			this.DataGridView1.ReadOnly=true;
			this.DataGridView1.RowHeadersVisible=false;
			this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.DataGridView1.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.DataGridView1.RowTemplate.ReadOnly=true;
			this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
			this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size=new System.Drawing.Size(455, 482);
			this.DataGridView1.TabIndex=49;
			//
			//Column9
			//
			this.Column9.HeaderText="ردیف";
			this.Column9.Name="Column9";
			this.Column9.ReadOnly=true;
			this.Column9.Resizable=DataGridViewTriState.False;
			this.Column9.Width=45;
			//
			//Column1
			//
			this.Column1.HeaderText="ساعت اعزام";
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.Resizable=DataGridViewTriState.False;
			this.Column1.Width=90;
			//
			//Column3
			//
			this.Column3.HeaderText="نوع";
			this.Column3.Name="Column3";
			this.Column3.ReadOnly=true;
			this.Column3.Width=75;
			//
			//Column7
			//
			this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText="مبداء";
			this.Column7.Name="Column7";
			this.Column7.ReadOnly=true;
			this.Column7.Resizable=DataGridViewTriState.False;
			//
			//Column2
			//
			this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText="مقصد";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			this.Column2.Resizable=DataGridViewTriState.False;
			//
			//TerminalDailyProcessForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.ClientSize=new System.Drawing.Size(935, 616);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.DataGridView2);
			this.Controls.Add(this.PictureBox9);
			this.Controls.Add(this.PictureBox8);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalDailyProcessForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowIcon=false;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="پردازش روزانه لوحه پایانه";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		private Panel Panel1;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private ComboBox KindCombo;
		private ComboBox NameCombo;
		private Label Label30;
		private Button ProcessButton;
		private Label Label3;
		private Label Label1;
		private PictureBox PictureBox9;
		private PictureBox PictureBox8;
		private DataGridView DataGridView2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		private DataGridView DataGridView1;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
	}
	
}
