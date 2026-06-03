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
		public partial class PersonalAlbumForm : BaseForm
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
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components=null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			this.Panel1=new Panel();
			base.Load += new System.EventHandler(PersonalAlbumForm_Load);
			this.PostCombo=new ComboBox();
			this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
			this.LocalCombo=new ComboBox();
			this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
			this.ShowButton=new Button();
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			this.ShiftCombo=new ComboBox();
			this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
			this.Label1=new Label();
			this.Label4=new Label();
			this.TimeCombo=new ComboBox();
			this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
			this.Label2=new Label();
			this.Label3=new Label();
			this.MainPanel=new Panel();
			this.PictureBox8=new PictureBox();
			this.Label12=new Label();
			this.PictureBox7=new PictureBox();
			this.Label11=new Label();
			this.PictureBox6=new PictureBox();
			this.Label10=new Label();
			this.PictureBox5=new PictureBox();
			this.Label9=new Label();
			this.PictureBox4=new PictureBox();
			this.Label8=new Label();
			this.PictureBox3=new PictureBox();
			this.Label7=new Label();
			this.PictureBox2=new PictureBox();
			this.Label6=new Label();
			this.PictureBox10=new PictureBox();
			this.Label14=new Label();
			this.PictureBox9=new PictureBox();
			this.Label13=new Label();
			this.PictureBox1=new PictureBox();
			this.Label5=new Label();
			this.Panel1.SuspendLayout();
			this.MainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox10).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.Wheat;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PostCombo);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.ShowButton);
			this.Panel1.Controls.Add(this.ShiftCombo);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.TimeCombo);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Location=new System.Drawing.Point(11, 11);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(933, 57);
			this.Panel1.TabIndex=1;
			//
			//PostCombo
			//
			this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.PostCombo.FormattingEnabled=true;
			this.PostCombo.Location=new System.Drawing.Point(521, 16);
			this.PostCombo.Name="PostCombo";
			this.PostCombo.Size=new System.Drawing.Size(170, 22);
			this.PostCombo.TabIndex=1;
			//
			//LocalCombo
			//
			this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(764, 16);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(112, 22);
			this.LocalCombo.TabIndex=2;
			//
			//ShowButton
			//
			this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowButton.Cursor=Cursors.Hand;
			this.ShowButton.Location=new System.Drawing.Point(13, 10);
			this.ShowButton.Name="ShowButton";
			this.ShowButton.Size=new System.Drawing.Size(124, 34);
			this.ShowButton.TabIndex=5;
			this.ShowButton.Text="نمایش";
			this.ShowButton.UseVisualStyleBackColor=false;
			//
			//ShiftCombo
			//
			this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.ShiftCombo.FormattingEnabled=true;
			this.ShiftCombo.Location=new System.Drawing.Point(159, 16);
			this.ShiftCombo.Name="ShiftCombo";
			this.ShiftCombo.Size=new System.Drawing.Size(90, 22);
			this.ShiftCombo.TabIndex=4;
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(691, 20);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(38, 14);
			this.Label1.TabIndex=0;
			this.Label1.Text="پست:";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(249, 20);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(62, 14);
			this.Label4.TabIndex=6;
			this.Label4.Text="نام شیفت:";
			//
			//TimeCombo
			//
			this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TimeCombo.FormattingEnabled=true;
			this.TimeCombo.Location=new System.Drawing.Point(344, 16);
			this.TimeCombo.Name="TimeCombo";
			this.TimeCombo.Size=new System.Drawing.Size(90, 22);
			this.TimeCombo.TabIndex=3;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(876, 20);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(31, 14);
			this.Label2.TabIndex=2;
			this.Label2.Text="مبدا:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(434, 20);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(63, 14);
			this.Label3.TabIndex=4;
			this.Label3.Text="نوع شیفت:";
			//
			//MainPanel
			//
			this.MainPanel.AutoScroll=true;
			this.MainPanel.BackColor=System.Drawing.Color.Wheat;
			this.MainPanel.BorderStyle=BorderStyle.FixedSingle;
			this.MainPanel.Controls.Add(this.PictureBox8);
			this.MainPanel.Controls.Add(this.Label12);
			this.MainPanel.Controls.Add(this.PictureBox7);
			this.MainPanel.Controls.Add(this.Label11);
			this.MainPanel.Controls.Add(this.PictureBox6);
			this.MainPanel.Controls.Add(this.Label10);
			this.MainPanel.Controls.Add(this.PictureBox5);
			this.MainPanel.Controls.Add(this.Label9);
			this.MainPanel.Controls.Add(this.PictureBox4);
			this.MainPanel.Controls.Add(this.Label8);
			this.MainPanel.Controls.Add(this.PictureBox3);
			this.MainPanel.Controls.Add(this.Label7);
			this.MainPanel.Controls.Add(this.PictureBox2);
			this.MainPanel.Controls.Add(this.Label6);
			this.MainPanel.Controls.Add(this.PictureBox10);
			this.MainPanel.Controls.Add(this.Label14);
			this.MainPanel.Controls.Add(this.PictureBox9);
			this.MainPanel.Controls.Add(this.Label13);
			this.MainPanel.Controls.Add(this.PictureBox1);
			this.MainPanel.Controls.Add(this.Label5);
			this.MainPanel.Font=new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.MainPanel.Location=new System.Drawing.Point(10, 79);
			this.MainPanel.Name="MainPanel";
			this.MainPanel.Size=new System.Drawing.Size(933, 497);
			this.MainPanel.TabIndex=2;
			//
			//PictureBox8
			//
			this.PictureBox8.Location=new System.Drawing.Point(11, 12);
			this.PictureBox8.Name="PictureBox8";
			this.PictureBox8.Size=new System.Drawing.Size(100, 120);
			this.PictureBox8.TabIndex=0;
			this.PictureBox8.TabStop=false;
			//
			//Label12
			//
			this.Label12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label12.Location=new System.Drawing.Point(11, 135);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(100, 34);
			this.Label12.TabIndex=2;
			this.Label12.Text="نام" ;
			this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox7
			//
			this.PictureBox7.Location=new System.Drawing.Point(124, 12);
			this.PictureBox7.Name="PictureBox7";
			this.PictureBox7.Size=new System.Drawing.Size(100, 120);
			this.PictureBox7.TabIndex=0;
			this.PictureBox7.TabStop=false;
			//
			//Label11
			//
			this.Label11.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.Location=new System.Drawing.Point(124, 135);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(100, 34);
			this.Label11.TabIndex=2;
			this.Label11.Text="نام" ;
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox6
			//
			this.PictureBox6.Location=new System.Drawing.Point(237, 12);
			this.PictureBox6.Name="PictureBox6";
			this.PictureBox6.Size=new System.Drawing.Size(100, 120);
			this.PictureBox6.TabIndex=0;
			this.PictureBox6.TabStop=false;
			//
			//Label10
			//
			this.Label10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.Location=new System.Drawing.Point(237, 135);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(100, 34);
			this.Label10.TabIndex=2;
			this.Label10.Text="نام" ;
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox5
			//
			this.PictureBox5.Location=new System.Drawing.Point(350, 12);
			this.PictureBox5.Name="PictureBox5";
			this.PictureBox5.Size=new System.Drawing.Size(100, 120);
			this.PictureBox5.TabIndex=0;
			this.PictureBox5.TabStop=false;
			//
			//Label9
			//
			this.Label9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.Location=new System.Drawing.Point(350, 135);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(100, 34);
			this.Label9.TabIndex=2;
			this.Label9.Text="نام" ;
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox4
			//
			this.PictureBox4.Location=new System.Drawing.Point(463, 12);
			this.PictureBox4.Name="PictureBox4";
			this.PictureBox4.Size=new System.Drawing.Size(100, 120);
			this.PictureBox4.TabIndex=0;
			this.PictureBox4.TabStop=false;
			//
			//Label8
			//
			this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.Location=new System.Drawing.Point(463, 135);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(100, 34);
			this.Label8.TabIndex=2;
			this.Label8.Text="نام" ;
			this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox3
			//
			this.PictureBox3.Location=new System.Drawing.Point(576, 12);
			this.PictureBox3.Name="PictureBox3";
			this.PictureBox3.Size=new System.Drawing.Size(100, 120);
			this.PictureBox3.TabIndex=0;
			this.PictureBox3.TabStop=false;
			//
			//Label7
			//
			this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.Location=new System.Drawing.Point(576, 135);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(100, 34);
			this.Label7.TabIndex=2;
			this.Label7.Text="نام" ;
			this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox2
			//
			this.PictureBox2.Location=new System.Drawing.Point(690, 12);
			this.PictureBox2.Name="PictureBox2";
			this.PictureBox2.Size=new System.Drawing.Size(100, 120);
			this.PictureBox2.TabIndex=0;
			this.PictureBox2.TabStop=false;
			//
			//Label6
			//
			this.Label6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.Location=new System.Drawing.Point(690, 135);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(100, 34);
			this.Label6.TabIndex=2;
			this.Label6.Text="نام" ;
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox10
			//
			this.PictureBox10.Location=new System.Drawing.Point(803, 343);
			this.PictureBox10.Name="PictureBox10";
			this.PictureBox10.Size=new System.Drawing.Size(100, 120);
			this.PictureBox10.TabIndex=0;
			this.PictureBox10.TabStop=false;
			//
			//Label14
			//
			this.Label14.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label14.Location=new System.Drawing.Point(803, 464);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(100, 34);
			this.Label14.TabIndex=2;
			this.Label14.Text="نام" ;
			this.Label14.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox9
			//
			this.PictureBox9.Location=new System.Drawing.Point(803, 177);
			this.PictureBox9.Name="PictureBox9";
			this.PictureBox9.Size=new System.Drawing.Size(100, 120);
			this.PictureBox9.TabIndex=0;
			this.PictureBox9.TabStop=false;
			//
			//Label13
			//
			this.Label13.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label13.Location=new System.Drawing.Point(803, 298);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(100, 34);
			this.Label13.TabIndex=2;
			this.Label13.Text="نام" ;
			this.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PictureBox1
			//
			this.PictureBox1.Location=new System.Drawing.Point(803, 12);
			this.PictureBox1.Name="PictureBox1";
			this.PictureBox1.Size=new System.Drawing.Size(100, 120);
			this.PictureBox1.TabIndex=0;
			this.PictureBox1.TabStop=false;
			//
			//Label5
			//
			this.Label5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location=new System.Drawing.Point(803, 133);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(100, 34);
			this.Label5.TabIndex=2;
			this.Label5.Text="نام";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//PersonalAlbumForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 14.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.Tan;
			this.ClientSize=new System.Drawing.Size(954, 586);
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", 9.0F);
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="PersonalAlbumForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="آلبوم پرسنلی";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.MainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox10).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		private Panel Panel1;
		private ComboBox PostCombo;
		private ComboBox LocalCombo;
		private Button ShowButton;
		private ComboBox ShiftCombo;
		private Label Label1;
		private Label Label4;
		private ComboBox TimeCombo;
		private Label Label2;
		private Label Label3;
		private Panel MainPanel;
		private PictureBox PictureBox8;
		private Label Label12;
		private PictureBox PictureBox7;
		private Label Label11;
		private PictureBox PictureBox6;
		private Label Label10;
		private PictureBox PictureBox5;
		private Label Label9;
		private PictureBox PictureBox4;
		private Label Label8;
		private PictureBox PictureBox3;
		private Label Label7;
		private PictureBox PictureBox2;
		private Label Label6;
		private PictureBox PictureBox10;
		private Label Label14;
		private PictureBox PictureBox9;
		private Label Label13;
		private PictureBox PictureBox1;
		private Label Label5;
	}
	
}
