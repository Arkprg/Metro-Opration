using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class DailyLeaveRegisterAllForm : BaseForm
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
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(DailyLeaveRegisterAllForm_HelpButtonClicked);
			base.Load += new System.EventHandler(DailyLeaveRegisterAllForm_Load);
			this.Label4=new Label();
			this.DelayComboBox=new ComboBox();
			this.Label8=new Label();
			this.ReplaceBox=new TextBox();
			this.ReplaceButton=new Button();
			this.ReplaceButton.Click += new System.EventHandler(this.Button5_Click);
			this.Label7=new Label();
			this.ShiftLabel=new Label();
			this.Label5=new Label();
			this.PersonPostLabel=new Label();
			this.Label2=new Label();
			this.SearchButton=new Button();
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			this.NameBox=new TextBox();
			this.NameButton=new Button();
			this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
			this.Label3=new Label();
			this.Label1=new Label();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.Panel1=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
			this.Panel2=new Panel();
			this.KindCombo=new ComboBox();
			this.Label9=new Label();
			this.Panel3=new Panel();
			this.Label6=new Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Location=new System.Drawing.Point(21, 86);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(318, 16);
			this.Label4.TabIndex=25;
			this.Label4.Text="--------------------------------------------------------------";
			//
			//DelayComboBox
			//
			this.DelayComboBox.DropDownStyle=ComboBoxStyle.DropDownList;
			this.DelayComboBox.Enabled=false;
			this.DelayComboBox.ForeColor=System.Drawing.Color.Black;
			this.DelayComboBox.FormattingEnabled=true;
			this.DelayComboBox.Items.AddRange(new object[] {"تاخیر در اعلام", "تاخیر در ثبت"});
			this.DelayComboBox.Location=new System.Drawing.Point(69, 180);
			this.DelayComboBox.Name="DelayComboBox";
			this.DelayComboBox.Size=new System.Drawing.Size(173, 24);
			this.DelayComboBox.TabIndex=2;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(241, 183);
			this.Label8.Margin=new Padding(4, 0, 4, 0);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(109, 16);
			this.Label8.TabIndex=23;
			this.Label8.Text="علت تاخیر در ثبت:";
			//
			//ReplaceBox
			//
			this.ReplaceBox.BackColor=System.Drawing.SystemColors.Window;
			this.ReplaceBox.Location=new System.Drawing.Point(99, 147);
			this.ReplaceBox.Name="ReplaceBox";
			this.ReplaceBox.ReadOnly=true;
			this.ReplaceBox.Size=new System.Drawing.Size(143, 23);
			this.ReplaceBox.TabIndex=21;
			this.ReplaceBox.TabStop=false;
			//
			//ReplaceButton
			//
			this.ReplaceButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.ReplaceButton.Location=new System.Drawing.Point(68, 146);
			this.ReplaceButton.Name="ReplaceButton";
			this.ReplaceButton.Size=new System.Drawing.Size(30, 25);
			this.ReplaceButton.TabIndex=1;
			this.ReplaceButton.UseVisualStyleBackColor=true;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(274, 150);
			this.Label7.Margin=new Padding(4, 0, 4, 0);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(76, 16);
			this.Label7.TabIndex=22;
			this.Label7.Text="نام جایگزین:";
			//
			//ShiftLabel
			//
			this.ShiftLabel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ShiftLabel.ForeColor=System.Drawing.Color.Black;
			this.ShiftLabel.Location=new System.Drawing.Point(26, 54);
			this.ShiftLabel.Name="ShiftLabel";
			this.ShiftLabel.Size=new System.Drawing.Size(219, 23);
			this.ShiftLabel.TabIndex=4;
			this.ShiftLabel.Text="شیفت مرخصی:";
			this.ShiftLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.ForeColor=System.Drawing.Color.DimGray;
			this.Label5.Location=new System.Drawing.Point(252, 58);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(98, 16);
			this.Label5.TabIndex=3;
			this.Label5.Text="شیفت مرخصی:";
			//
			//PersonPostLabel
			//
			this.PersonPostLabel.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.PersonPostLabel.ForeColor=System.Drawing.Color.Black;
			this.PersonPostLabel.Location=new System.Drawing.Point(28, 21);
			this.PersonPostLabel.Name="PersonPostLabel";
			this.PersonPostLabel.Size=new System.Drawing.Size(218, 23);
			this.PersonPostLabel.TabIndex=2;
			this.PersonPostLabel.Text="شیفت مرخصی:";
			this.PersonPostLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.ForeColor=System.Drawing.Color.DimGray;
			this.Label2.Location=new System.Drawing.Point(253, 24);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(97, 16);
			this.Label2.TabIndex=0;
			this.Label2.Text="پست سازمانی:";
			//
			//SearchButton
			//
			this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
			this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search;
			this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.SearchButton.Cursor=Cursors.Hand;
			
			this.SearchButton.Location=new System.Drawing.Point(10, 9);
			this.SearchButton.Margin=new Padding(4, 5, 4, 5);
			this.SearchButton.Name="SearchButton";
			this.SearchButton.Size=new System.Drawing.Size(131, 59);
			this.SearchButton.TabIndex=4;
			this.SearchButton.Text="بررسی";
			this.SearchButton.UseVisualStyleBackColor=false;
			//
			//NameBox
			//
			this.NameBox.BackColor=System.Drawing.SystemColors.Window;
			this.NameBox.Location=new System.Drawing.Point(185, 12);
			this.NameBox.Name="NameBox";
			this.NameBox.ReadOnly=true;
			this.NameBox.Size=new System.Drawing.Size(124, 23);
			this.NameBox.TabIndex=30;
			this.NameBox.TabStop=false;
			//
			//NameButton
			//
			this.NameButton.BackgroundImageLayout=ImageLayout.Center;
			this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
			this.NameButton.Location=new System.Drawing.Point(156, 11);
			this.NameButton.Name="NameButton";
			this.NameButton.Size=new System.Drawing.Size(30, 25);
			this.NameButton.TabIndex=1;
			this.NameButton.UseVisualStyleBackColor=true;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Location=new System.Drawing.Point(310, 46);
			this.Label3.Margin=new Padding(4, 0, 4, 0);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(39, 16);
			this.Label3.TabIndex=32;
			this.Label3.Text="تاریخ:";
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(310, 15);
			this.Label1.Margin=new Padding(4, 0, 4, 0);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(29, 16);
			this.Label1.TabIndex=31;
			this.Label1.Text="نام:";
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			
			this.RegButton.Enabled=false;
			this.RegButton.Location=new System.Drawing.Point(146, 10);
			this.RegButton.Margin=new Padding(4, 5, 4, 5);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(197, 34);
			this.RegButton.TabIndex=1;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(20, 10);
			this.ExitButton.Margin=new Padding(4, 5, 4, 5);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(102, 34);
			this.ExitButton.TabIndex=2;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.NameBox);
			this.Panel1.Controls.Add(this.PersianCalendar);
			this.Panel1.Controls.Add(this.NameButton);
			this.Panel1.Controls.Add(this.SearchButton);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Location=new System.Drawing.Point(13, 13);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(362, 79);
			this.Panel1.TabIndex=0;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(156, 43);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(154, 23);
			this.PersianCalendar.TabIndex=33;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.ReplaceButton);
			this.Panel2.Controls.Add(this.KindCombo);
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.DelayComboBox);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.PersonPostLabel);
			this.Panel2.Controls.Add(this.ReplaceBox);
			this.Panel2.Controls.Add(this.ShiftLabel);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Enabled=false;
			this.Panel2.Location=new System.Drawing.Point(13, 111);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(362, 225);
			this.Panel2.TabIndex=1;
			//
			//KindCombo
			//
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Location=new System.Drawing.Point(69, 113);
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(172, 24);
			this.KindCombo.Sorted=true;
			this.KindCombo.TabIndex=35;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Location=new System.Drawing.Point(271, 117);
			this.Label9.Margin=new Padding(4, 0, 4, 0);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(79, 16);
			this.Label9.TabIndex=36;
			this.Label9.Text="نوع مرخصی:";
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.Color.LightBlue;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Location=new System.Drawing.Point(13, 347);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(362, 56);
			this.Panel3.TabIndex=2;
			//
			//Label6
			//
			this.Label6.BackColor=System.Drawing.Color.Gray;
			this.Label6.BorderStyle=BorderStyle.FixedSingle;
			this.Label6.Cursor=Cursors.Default;
			this.Label6.ForeColor=System.Drawing.Color.White;
			this.Label6.Location=new System.Drawing.Point(292, 101);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(71, 23);
			this.Label6.TabIndex=42;
			this.Label6.Text="مشخصات";
			this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
			//
			//DailyLeaveRegisterAllForm
			//
			this.AcceptButton=this.SearchButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.LightBlue;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(387, 409);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="DailyLeaveRegisterAllForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text=" ";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private TextBox ReplaceBox;
		private Button ReplaceButton;
		private Label Label7;
		private Label ShiftLabel;
		private Label Label5;
		private Label PersonPostLabel;
		private Label Label2;
		private Button SearchButton;
		private TextBox NameBox;
		private Button NameButton;
		private Label Label3;
		private Label Label1;
		private Button RegButton;
		private Button ExitButton;
		private ComboBox DelayComboBox;
		private Label Label8;
		private Label Label4;
		private Panel Panel1;
		private Panel Panel2;
		private Panel Panel3;
		private Label Label6;
		private ComboBox KindCombo;
		private Label Label9;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
	}
	
}
