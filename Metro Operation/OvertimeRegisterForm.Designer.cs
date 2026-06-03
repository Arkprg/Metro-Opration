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
	public partial class OvertimeRegisterForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(OvertimeRegisterForm_HelpButtonClicked);
			base.Load += new System.EventHandler(OvertimeRegisterForm_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(OvertimeRegisterForm));
			this.ContextMenuStrip1=new ContextMenuStrip(this.components);
			this.CutToolStripMenuItem=new ToolStripMenuItem();
			this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
			this.CopyToolStripMenuItem=new ToolStripMenuItem();
			this.CopyToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
			this.PastToolStripMenuItem=new ToolStripMenuItem();
			this.PastToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.Label3=new Label();
			this.Panel1=new Panel();
			this.TimeBox=new MaskedTextBox();
			this.LeaveCombo=new ComboBox();
			this.KindCombo=new ComboBox();
			this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
			this.Label9=new Label();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_Leave);
			this.ShiftCombo=new ComboBox();
			this.Label10=new Label();
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.Label13=new Label();
			this.Label15=new Label();
			this.Panel3=new Panel();
			this.Panel2=new Panel();
			this.MemBox=new RichTextBox();
			this.NameBox=new TextBox();
			this.Label4=new Label();
			this.Label1=new Label();
			this.Label5=new Label();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.ContextMenuStrip1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.DropShadowEnabled=false;
			this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[] {this.CutToolStripMenuItem, this.CopyToolStripMenuItem, this.PastToolStripMenuItem});
			this.ContextMenuStrip1.Name="ContextMenuStrip1";
			this.ContextMenuStrip1.RenderMode=ToolStripRenderMode.Professional;
			this.ContextMenuStrip1.RightToLeft=RightToLeft.Yes;
			this.ContextMenuStrip1.Size=new System.Drawing.Size(145, 70);
			//
			//CutToolStripMenuItem
			//
			this.CutToolStripMenuItem.Image=(System.Drawing.Image) (resources.GetObject("CutToolStripMenuItem.Image"));
			this.CutToolStripMenuItem.Name="CutToolStripMenuItem";
			this.CutToolStripMenuItem.ShortcutKeys=(Keys) (Keys.Control |  Keys.X);
			this.CutToolStripMenuItem.Size=new System.Drawing.Size(144, 22);
			this.CutToolStripMenuItem.Text="Cut";
			//
			//CopyToolStripMenuItem
			//
			this.CopyToolStripMenuItem.Image=(System.Drawing.Image) (resources.GetObject("CopyToolStripMenuItem.Image"));
			this.CopyToolStripMenuItem.Name="CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.ShortcutKeys=(Keys) (Keys.Control | Keys.C);
			this.CopyToolStripMenuItem.Size=new System.Drawing.Size(144, 22);
			this.CopyToolStripMenuItem.Text="Copy";
			//
			//PastToolStripMenuItem
			//
			this.PastToolStripMenuItem.Image=(System.Drawing.Image) (resources.GetObject("PastToolStripMenuItem.Image"));
			this.PastToolStripMenuItem.Name="PastToolStripMenuItem";
			this.PastToolStripMenuItem.ShortcutKeys=(Keys) (Keys.Control |  Keys.V);
			this.PastToolStripMenuItem.Size=new System.Drawing.Size(144, 22);
			this.PastToolStripMenuItem.Text="Past";
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(18, 12);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(92, 34);
			this.ExitButton.TabIndex=2;
			this.ExitButton.Text="   انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.LightBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Location=new System.Drawing.Point(302, 12);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(212, 34);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="تایید";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(451, 20);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(39, 16);
			this.Label3.TabIndex=43;
			this.Label3.Text="تاریخ:";
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TimeBox);
			this.Panel1.Controls.Add(this.LeaveCombo);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.PersianCalendar);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Location=new System.Drawing.Point(11, 16);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(543, 147);
			this.Panel1.TabIndex=0;
			//
			//TimeBox
			//
			this.TimeBox.Location=new System.Drawing.Point(401, 99);
			this.TimeBox.Mask="00:00";
			this.TimeBox.Name="TimeBox";
			this.TimeBox.Size=new System.Drawing.Size(50, 23);
			this.TimeBox.TabIndex=33;
			this.TimeBox.TextAlign=HorizontalAlignment.Center;
			this.TimeBox.ValidatingType=typeof(DateTime);
			this.TimeBox.Visible=false;
			//
			//LeaveCombo
			//
			this.LeaveCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LeaveCombo.FormattingEnabled=true;
			this.LeaveCombo.Items.AddRange(new object[] {"جایگزین مرخصی ساعتی", "جایگزین مرخصی روزانه", "اضافه کار"});
			this.LeaveCombo.Location=new System.Drawing.Point(304, 98);
			this.LeaveCombo.Name="LeaveCombo";
			this.LeaveCombo.Size=new System.Drawing.Size(147, 24);
			this.LeaveCombo.TabIndex=23;
			this.LeaveCombo.Visible=false;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Location=new System.Drawing.Point(304, 57);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(147, 24);
			this.KindCombo.TabIndex=21;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.ForeColor=System.Drawing.Color.Black;
			this.Label9.Location=new System.Drawing.Point(450, 61);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(83, 16);
			this.Label9.TabIndex=35;
			this.Label9.Text="نوع اضافه کار:";
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(304, 17);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(147, 23);
			this.PersianCalendar.TabIndex=98;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(23, 57);
			this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(147, 24);
			this.ShiftCombo.TabIndex=3;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.ForeColor=System.Drawing.Color.Black;
			this.Label10.Location=new System.Drawing.Point(450, 102);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(60, 16);
			this.Label10.TabIndex=22;
			this.Label10.Text="نام راهبر:";
			this.Label10.Visible=false;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(23, 16);
			this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(147, 24);
			this.LocalCombo.TabIndex=2;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.BackColor=System.Drawing.Color.Transparent;
			this.Label13.ForeColor=System.Drawing.Color.Black;
			this.Label13.Location=new System.Drawing.Point(170, 61);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(50, 16);
			this.Label13.TabIndex=18;
			this.Label13.Text="شیفت:";
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.BackColor=System.Drawing.Color.Transparent;
			this.Label15.ForeColor=System.Drawing.Color.Black;
			this.Label15.Location=new System.Drawing.Point(169, 20);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(35, 16);
			this.Label15.TabIndex=19;
			this.Label15.Text="مبدا:";
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Location=new System.Drawing.Point(11, 356);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(543, 58);
			this.Panel3.TabIndex=2;
			//
			//Panel2
			//
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.MemBox);
			this.Panel2.Controls.Add(this.NameBox);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.NameButton);
			this.Panel2.Location=new System.Drawing.Point(11, 182);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(543, 157);
			this.Panel2.TabIndex=102;
			//
			//MemBox
			//
			this.MemBox.BackColor=System.Drawing.Color.Beige;
			this.MemBox.ContextMenuStrip=this.ContextMenuStrip1;
			this.MemBox.Location=new System.Drawing.Point(25, 68);
			this.MemBox.Margin=new Padding(4, 5, 4, 5);
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(431, 37);
			this.MemBox.TabIndex=46;
			this.MemBox.Text="";
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(306, 25);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(148, 23);
			this.NameBox.TabIndex=50;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(455, 71);
			this.Label4.Margin=new Padding(4, 0, 4, 0);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(62, 16);
			this.Label4.TabIndex=47;
			this.Label4.Text="توضیحات:";
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(455, 28);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(29, 16);
			this.Label1.TabIndex=49;
			this.Label1.Text="نام:";
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.ForeColor=System.Drawing.Color.Maroon;
			this.Label5.Location=new System.Drawing.Point(185, 116);
			this.Label5.Margin=new Padding(4, 0, 4, 0);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(231, 16);
			this.Label5.TabIndex=48;
			this.Label5.Text="تذکر: ارائه توضیحات تکمیلی الزامی است";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//NameButton
			//
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(276, 24);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=45;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//OvertimeRegisterForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(574, 428);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="OvertimeRegisterForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت اضافه کار";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.ResumeLayout(false);
			
		}
		private Button ExitButton;
		private Button RegButton;
		private Label Label3;
		private ContextMenuStrip ContextMenuStrip1;
		private ToolStripMenuItem CopyToolStripMenuItem;
		private ToolStripMenuItem PastToolStripMenuItem;
		private ToolStripMenuItem CutToolStripMenuItem;
		private Panel Panel1;
		private Panel Panel3;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
		private ComboBox KindCombo;
		private Label Label9;
		private MaskedTextBox TimeBox;
		private ComboBox ShiftCombo;
		private ComboBox LocalCombo;
		private Label Label13;
		private Label Label15;
		private ComboBox LeaveCombo;
		private Label Label10;
		private Panel Panel2;
		private RichTextBox MemBox;
		private TextBox NameBox;
		private Label Label4;
		private Label Label1;
		private Label Label5;
		private Button NameButton;
	}
	
}
