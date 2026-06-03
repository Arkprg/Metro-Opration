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
    public partial class TimeLeaveRegisterForm : BaseForm
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
            this.components=new System.ComponentModel.Container();
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(TimeLeaveRegisterForm_HelpButtonClicked);
            base.Load += new System.EventHandler(TimeLeaveRegisterForm_Load);
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TimeLeaveRegisterForm));
            this.Label1=new Label();
            this.ExitButton=new Button();
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.Label3=new Label();
            this.NameButton=new Button();
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            this.NameBox=new TextBox();
            this.JNameBox=new TextBox();
            this.JNameButton=new Button();
            this.JNameButton.Click += new System.EventHandler(this.JNameButton_Click);
            this.Label5=new Label();
            this.ReplaceCombo=new ComboBox();
            this.ReplaceCombo.SelectedIndexChanged += new System.EventHandler(this.ReplaceCombo_SelectedIndexChanged);
            this.Label2=new Label();
            this.Label4=new Label();
            this.MemBox=new RichTextBox();
            this.ContextMenuStrip1=new ContextMenuStrip(this.components);
            this.CutToolStripMenuItem=new ToolStripMenuItem();
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            this.ToolStripMenuItem1=new ToolStripMenuItem();
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            this.ToolStripMenuItem2=new ToolStripMenuItem();
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            this.EndBox=new MaskedTextBox();
            this.StartBox=new MaskedTextBox();
            this.StartBox.Leave += new System.EventHandler(this.StartBox_Leave);
            this.Label8=new Label();
            this.Label7=new Label();
            this.Panel1=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new Panel();
            this.TripBox=new CheckBox();
            this.TripBox.CheckedChanged += new System.EventHandler(this.TripBox_CheckedChanged);
            this.Label6=new Label();
            this.Panel3=new Panel();
            this.ContextMenuStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(402, 16);
            this.Label1.Margin=new Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(29, 16);
            this.Label1.TabIndex=0;
            this.Label1.Text="نام:";
            //
            //ExitButton
            //
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.None;
            this.ExitButton.Location=new System.Drawing.Point(21, 11);
            this.ExitButton.Margin=new Padding(4);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(107, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;
            
            this.RegButton.Location=new System.Drawing.Point(251, 11);
            this.RegButton.Margin=new Padding(4);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(180, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(147, 16);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(43, 16);
            this.Label3.TabIndex=17;
            this.Label3.Text="تاریخ :";
            //
            //NameButton
            //
            this.NameButton.Image=(System.Drawing.Image)(resources.GetObject("NameButton.Image"));
            this.NameButton.Location=new System.Drawing.Point(235, 12);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(264, 13);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(138, 23);
            this.NameBox.TabIndex=0;
            this.NameBox.TabStop=false;
            //
            //JNameBox
            //
            this.JNameBox.BackColor=System.Drawing.SystemColors.Window;
            this.JNameBox.Location=new System.Drawing.Point(48, 67);
            this.JNameBox.Name="JNameBox";
            this.JNameBox.ReadOnly=true;
            this.JNameBox.Size=new System.Drawing.Size(120, 23);
            this.JNameBox.TabIndex=39;
            this.JNameBox.TabStop=false;
            //
            //JNameButton
            //
            this.JNameButton.Image=(System.Drawing.Image)(resources.GetObject("JNameButton.Image"));
            this.JNameButton.Location=new System.Drawing.Point(18, 66);
            this.JNameButton.Name="JNameButton";
            this.JNameButton.Size=new System.Drawing.Size(30, 25);
            this.JNameButton.TabIndex=3;
            this.JNameButton.UseVisualStyleBackColor=true;
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(168, 70);
            this.Label5.Margin=new Padding(4, 0, 4, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(76, 16);
            this.Label5.TabIndex=40;
            this.Label5.Text="نام جایگزین:";
            //
            //ReplaceCombo
            //
            this.ReplaceCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ReplaceCombo.FormattingEnabled=true;
            this.ReplaceCombo.Location=new System.Drawing.Point(253, 66);
            this.ReplaceCombo.Name="ReplaceCombo";
            this.ReplaceCombo.Size=new System.Drawing.Size(103, 24);
            this.ReplaceCombo.TabIndex=2;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(356, 70);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(78, 16);
            this.Label2.TabIndex=37;
            this.Label2.Text="نوع جایگزین:";
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(372, 116);
            this.Label4.Margin=new Padding(4, 0, 4, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(62, 16);
            this.Label4.TabIndex=20;
            this.Label4.Text="توضیحات:";
            //
            //MemBox
            //
            this.MemBox.ContextMenuStrip=this.ContextMenuStrip1;
            this.MemBox.Location=new System.Drawing.Point(16, 139);
            this.MemBox.Margin=new Padding(4);
            this.MemBox.MaxLength=50;
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(418, 44);
            this.MemBox.TabIndex=4;
            this.MemBox.Text="";
            //
            //ContextMenuStrip1
            //
            this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.CutToolStripMenuItem, this.ToolStripMenuItem1, this.ToolStripMenuItem2 });
            this.ContextMenuStrip1.Name="ContextMenuStrip1";
            this.ContextMenuStrip1.Size=new System.Drawing.Size(145, 70);
            //
            //CutToolStripMenuItem
            //
            this.CutToolStripMenuItem.Image=(System.Drawing.Image)(resources.GetObject("CutToolStripMenuItem.Image"));
            this.CutToolStripMenuItem.Name="CutToolStripMenuItem";
            this.CutToolStripMenuItem.RightToLeft=RightToLeft.Yes;
            this.CutToolStripMenuItem.ShortcutKeys=(Keys)(Keys.Control | Keys.X);
            this.CutToolStripMenuItem.Size=new System.Drawing.Size(144, 22);
            this.CutToolStripMenuItem.Text="Cut";
            //
            //ToolStripMenuItem1
            //
            this.ToolStripMenuItem1.Image=(System.Drawing.Image)(resources.GetObject("ToolStripMenuItem1.Image"));
            this.ToolStripMenuItem1.Name="ToolStripMenuItem1";
            this.ToolStripMenuItem1.RightToLeft=RightToLeft.Yes;
            this.ToolStripMenuItem1.RightToLeftAutoMirrorImage=true;
            this.ToolStripMenuItem1.ShortcutKeys=(Keys)(Keys.Control | Keys.C);
            this.ToolStripMenuItem1.Size=new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem1.Text="Copy";
            //
            //ToolStripMenuItem2
            //
            this.ToolStripMenuItem2.Image=(System.Drawing.Image)(resources.GetObject("ToolStripMenuItem2.Image"));
            this.ToolStripMenuItem2.Name="ToolStripMenuItem2";
            this.ToolStripMenuItem2.RightToLeft=RightToLeft.Yes;
            this.ToolStripMenuItem2.ShortcutKeys=(Keys)(Keys.Control | Keys.V);
            this.ToolStripMenuItem2.Size=new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem2.Text="Past";
            //
            //EndBox
            //
            this.EndBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.EndBox.Location=new System.Drawing.Point(170, 19);
            this.EndBox.Mask="00:00";
            this.EndBox.Name="EndBox";
            this.EndBox.Size=new System.Drawing.Size(54, 23);
            this.EndBox.TabIndex=1;
            this.EndBox.TextAlign=HorizontalAlignment.Center;
            this.EndBox.ValidatingType=typeof(DateTime);
            //
            //StartBox
            //
            this.StartBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.StartBox.Location=new System.Drawing.Point(318, 19);
            this.StartBox.Mask="00:00";
            this.StartBox.Name="StartBox";
            this.StartBox.Size=new System.Drawing.Size(54, 23);
            this.StartBox.TabIndex=0;
            this.StartBox.TextAlign=HorizontalAlignment.Center;
            this.StartBox.ValidatingType=typeof(DateTime);
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(224, 22);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(62, 16);
            this.Label8.TabIndex=36;
            this.Label8.Text="تا ساعت:";
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(372, 22);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(62, 16);
            this.Label7.TabIndex=35;
            this.Label7.Text="از ساعت:";
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location=new System.Drawing.Point(15, 16);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(453, 51);
            this.Panel1.TabIndex=0;
            //
            //PersianCalendar
            //
            this.PersianCalendar.Location=new System.Drawing.Point(21, 13);
            this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=2;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.TripBox);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.JNameBox);
            this.Panel2.Controls.Add(this.StartBox);
            this.Panel2.Controls.Add(this.MemBox);
            this.Panel2.Controls.Add(this.JNameButton);
            this.Panel2.Controls.Add(this.EndBox);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.ReplaceCombo);
            this.Panel2.Location=new System.Drawing.Point(15, 79);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(453, 200);
            this.Panel2.TabIndex=1;
            //
            //TripBox
            //
            this.TripBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.TripBox.Font=new System.Drawing.Font("Tahoma", (float)(11.0F));
            this.TripBox.Location=new System.Drawing.Point(21, 19);
            this.TripBox.Name="TripBox";
            this.TripBox.Size=new System.Drawing.Size(95, 23);
            this.TripBox.TabIndex=41;
            this.TripBox.Text="حذف تریپ";
            this.TripBox.UseVisualStyleBackColor=false;
            this.TripBox.Visible=false;
            //
            //Label6
            //
            this.Label6.Location=new System.Drawing.Point(21, 111);
            this.Label6.Margin=new Padding(4, 0, 4, 0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(287, 23);
            this.Label6.TabIndex=20;
            this.Label6.Text="---";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Panel3
            //
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Location=new System.Drawing.Point(15, 291);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(453, 58);
            this.Panel3.TabIndex=2;
            //
            //TimeLeaveRegisterForm
            //
            this.AcceptButton=this.RegButton;
            this.AutoScaleMode=AutoScaleMode.Inherit;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(479, 361);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.Margin=new Padding(4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TimeLeaveRegisterForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ثبت مرخصی ساعتی";
            this.ContextMenuStrip1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Label Label1;
        private Button ExitButton;
        private Button RegButton;
        private Label Label3;
        private Button NameButton;
        private TextBox NameBox;
        private Label Label4;
        private RichTextBox MemBox;
        private TextBox JNameBox;
        private Button JNameButton;
        private Label Label5;
        private ComboBox ReplaceCombo;
        private Label Label2;
        private MaskedTextBox EndBox;
        private MaskedTextBox StartBox;
        private Label Label8;
        private Label Label7;
        private ContextMenuStrip ContextMenuStrip1;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItem2;
        private Panel Panel1;
        private Panel Panel2;
        private Panel Panel3;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private Label Label6;
        private CheckBox TripBox;
    }

}
