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
		public partial class ShiftOvertimeForm : BaseForm
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
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label2=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.TextBox00=new System.Windows.Forms.Label();
            this.TextBox01=new System.Windows.Forms.Label();
            this.TextBox02=new System.Windows.Forms.Label();
            this.TextBox03=new System.Windows.Forms.Label();
            this.TextBox04=new System.Windows.Forms.Label();
            this.TextBox05=new System.Windows.Forms.Label();
            this.Panel3=new System.Windows.Forms.Panel();
            this.TextBox10=new System.Windows.Forms.Label();
            this.A9DaysBox=new System.Windows.Forms.Label();
            this.A9TimeBox=new System.Windows.Forms.Label();
            this.A9FOverBox=new System.Windows.Forms.Label();
            this.A9OverBox=new System.Windows.Forms.Label();
            this.A9TotalBox=new System.Windows.Forms.Label();
            this.Panel9=new System.Windows.Forms.Panel();
            this.Label3=new System.Windows.Forms.Label();
            this.Panel13=new System.Windows.Forms.Panel();
            this.Label5=new System.Windows.Forms.Label();
            this.Panel4=new System.Windows.Forms.Panel();
            this.TextBox11=new System.Windows.Forms.Label();
            this.B9DaysBox=new System.Windows.Forms.Label();
            this.B9TimeBox=new System.Windows.Forms.Label();
            this.B9FOverBox=new System.Windows.Forms.Label();
            this.B9OverBox=new System.Windows.Forms.Label();
            this.B9TotalBox=new System.Windows.Forms.Label();
            this.Panel5=new System.Windows.Forms.Panel();
            this.TextBox12=new System.Windows.Forms.Label();
            this.C9DaysBox=new System.Windows.Forms.Label();
            this.C9TimeBox=new System.Windows.Forms.Label();
            this.C9FOverBox=new System.Windows.Forms.Label();
            this.C9OverBox=new System.Windows.Forms.Label();
            this.C9TotalBox=new System.Windows.Forms.Label();
            this.Panel6=new System.Windows.Forms.Panel();
            this.TextBox13=new System.Windows.Forms.Label();
            this.A12DaysBox=new System.Windows.Forms.Label();
            this.A12TimeBox=new System.Windows.Forms.Label();
            this.A12FOverBox=new System.Windows.Forms.Label();
            this.A12OverBox=new System.Windows.Forms.Label();
            this.A12TotalBox=new System.Windows.Forms.Label();
            this.Panel7=new System.Windows.Forms.Panel();
            this.TextBox14=new System.Windows.Forms.Label();
            this.B12DaysBox=new System.Windows.Forms.Label();
            this.B12TimeBox=new System.Windows.Forms.Label();
            this.B12FOverBox=new System.Windows.Forms.Label();
            this.B12OverBox=new System.Windows.Forms.Label();
            this.B12TotalBox=new System.Windows.Forms.Label();
            this.Panel8=new System.Windows.Forms.Panel();
            this.TextBox15=new System.Windows.Forms.Label();
            this.C12DaysBox=new System.Windows.Forms.Label();
            this.C12TimeBox=new System.Windows.Forms.Label();
            this.C12FOverBox=new System.Windows.Forms.Label();
            this.C12OverBox=new System.Windows.Forms.Label();
            this.C12TotalBox=new System.Windows.Forms.Label();
            this.Panel10=new System.Windows.Forms.Panel();
            this.TextBox16=new System.Windows.Forms.Label();
            this.SetDaysBox=new System.Windows.Forms.Label();
            this.SetTimeBox=new System.Windows.Forms.Label();
            this.SetFOverBox=new System.Windows.Forms.Label();
            this.SetOverBox=new System.Windows.Forms.Label();
            this.SetTotalBox=new System.Windows.Forms.Label();
            this.Panel11=new System.Windows.Forms.Panel();
            this.TextBox17=new System.Windows.Forms.Label();
            this.AMDaysBox=new System.Windows.Forms.Label();
            this.AMTimeBox=new System.Windows.Forms.Label();
            this.AMFOverBox=new System.Windows.Forms.Label();
            this.AMOverBox=new System.Windows.Forms.Label();
            this.AMTotalBox=new System.Windows.Forms.Label();
            this.Panel12=new System.Windows.Forms.Panel();
            this.TextBox18=new System.Windows.Forms.Label();
            this.BMDaysBox=new System.Windows.Forms.Label();
            this.BMTimeBox=new System.Windows.Forms.Label();
            this.BMFOverBox=new System.Windows.Forms.Label();
            this.BMOverBox=new System.Windows.Forms.Label();
            this.BMTotalBox=new System.Windows.Forms.Label();
            this.Panel14=new System.Windows.Forms.Panel();
            this.TextBox19=new System.Windows.Forms.Label();
            this.CMDaysBox=new System.Windows.Forms.Label();
            this.CMTimeBox=new System.Windows.Forms.Label();
            this.CMFOverBox=new System.Windows.Forms.Label();
            this.CMOverBox=new System.Windows.Forms.Label();
            this.CMTotalBox=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.MonthWorkBox=new System.Windows.Forms.Label();
            this.MonthTimeBox=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.YearCombo=new System.Windows.Forms.ComboBox();
            this.MonthCombo=new System.Windows.Forms.ComboBox();
            this.Label1=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.MonthOverBox=new System.Windows.Forms.Label();
            this.Panel15=new System.Windows.Forms.Panel();
            this.Label9=new System.Windows.Forms.Label();
            this.Panel16=new System.Windows.Forms.Panel();
            this.TextBox1=new System.Windows.Forms.Label();
            this.AP12DaysBox=new System.Windows.Forms.Label();
            this.AP12TimeBox=new System.Windows.Forms.Label();
            this.AP12FOverBox=new System.Windows.Forms.Label();
            this.AP12OverBox=new System.Windows.Forms.Label();
            this.AP12TotalBox=new System.Windows.Forms.Label();
            this.Panel17=new System.Windows.Forms.Panel();
            this.TextBox7=new System.Windows.Forms.Label();
            this.BP12DaysBox=new System.Windows.Forms.Label();
            this.BP12TimeBox=new System.Windows.Forms.Label();
            this.BP12FOverBox=new System.Windows.Forms.Label();
            this.BP12OverBox=new System.Windows.Forms.Label();
            this.BP12TotalBox=new System.Windows.Forms.Label();
            this.Panel18=new System.Windows.Forms.Panel();
            this.TextBox23=new System.Windows.Forms.Label();
            this.CP12DaysBox=new System.Windows.Forms.Label();
            this.CP12TimeBox=new System.Windows.Forms.Label();
            this.CP12FOverBox=new System.Windows.Forms.Label();
            this.CP12OverBox=new System.Windows.Forms.Label();
            this.CP12TotalBox=new System.Windows.Forms.Label();
            this.NextButton=new System.Windows.Forms.Button();
            this.PrevButton=new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel13.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Panel14.SuspendLayout();
            this.Panel15.SuspendLayout();
            this.Panel16.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.Panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.AutoSize=true;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel2.Location=new System.Drawing.Point(470, 144);
            this.Panel2.Margin=new System.Windows.Forms.Padding(0);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(85, 91);
            this.Panel2.TabIndex=2;
            // 
            // Label2
            // 
            this.Label2.BackColor=System.Drawing.Color.WhiteSmoke;
            this.Label2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.ForeColor=System.Drawing.Color.Black;
            this.Label2.Location=new System.Drawing.Point(0, 0);
            this.Label2.Margin=new System.Windows.Forms.Padding(0);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(85, 91);
            this.Label2.TabIndex=1;
            this.Label2.Text="راهبر\r\n9 ساعته\r\nخط اصلی";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.AutoSize=true;
            this.Panel1.Controls.Add(this.TextBox00);
            this.Panel1.Controls.Add(this.TextBox01);
            this.Panel1.Controls.Add(this.TextBox02);
            this.Panel1.Controls.Add(this.TextBox03);
            this.Panel1.Controls.Add(this.TextBox04);
            this.Panel1.Controls.Add(this.TextBox05);
            this.Panel1.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel1.Location=new System.Drawing.Point(18, 98);
            this.Panel1.Margin=new System.Windows.Forms.Padding(0);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(539, 45);
            this.Panel1.TabIndex=24;
            // 
            // TextBox00
            // 
            this.TextBox00.BackColor=System.Drawing.SystemColors.Control;
            this.TextBox00.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox00.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox00.Location=new System.Drawing.Point(376, 0);
            this.TextBox00.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox00.Name="TextBox00";
            this.TextBox00.Size=new System.Drawing.Size(160, 45);
            this.TextBox00.TabIndex=6;
            // 
            // TextBox01
            // 
            this.TextBox01.BackColor=System.Drawing.SystemColors.Control;
            this.TextBox01.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox01.Cursor=System.Windows.Forms.Cursors.IBeam;
            this.TextBox01.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox01.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox01.ForeColor=System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox01.Location=new System.Drawing.Point(301, 0);
            this.TextBox01.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox01.Name="TextBox01";
            this.TextBox01.Size=new System.Drawing.Size(75, 45);
            this.TextBox01.TabIndex=5;
            this.TextBox01.Text="تعداد روز شیفت";
            // 
            // TextBox02
            // 
            this.TextBox02.BackColor=System.Drawing.SystemColors.Control;
            this.TextBox02.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox02.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox02.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox02.Location=new System.Drawing.Point(226, 0);
            this.TextBox02.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox02.Name="TextBox02";
            this.TextBox02.Size=new System.Drawing.Size(75, 45);
            this.TextBox02.TabIndex=4;
            this.TextBox02.Text="ساعت کارکرد";
            // 
            // TextBox03
            // 
            this.TextBox03.BackColor=System.Drawing.SystemColors.Control;
            this.TextBox03.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox03.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox03.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox03.Location=new System.Drawing.Point(151, 0);
            this.TextBox03.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox03.Name="TextBox03";
            this.TextBox03.Size=new System.Drawing.Size(75, 45);
            this.TextBox03.TabIndex=3;
            this.TextBox03.Text="اضافه کار جمعه";
            // 
            // TextBox04
            // 
            this.TextBox04.BackColor=System.Drawing.SystemColors.Control;
            this.TextBox04.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox04.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox04.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox04.Location=new System.Drawing.Point(76, 0);
            this.TextBox04.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox04.Name="TextBox04";
            this.TextBox04.Size=new System.Drawing.Size(75, 45);
            this.TextBox04.TabIndex=2;
            this.TextBox04.Text="اضافه کار عادی";
            // 
            // TextBox05
            // 
            this.TextBox05.BackColor=System.Drawing.SystemColors.Control;
            this.TextBox05.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox05.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox05.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox05.Location=new System.Drawing.Point(0, 0);
            this.TextBox05.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox05.Name="TextBox05";
            this.TextBox05.Size=new System.Drawing.Size(76, 45);
            this.TextBox05.TabIndex=1;
            this.TextBox05.Text="مجموع اضافه کار";
            // 
            // Panel3
            // 
            this.Panel3.AutoSize=true;
            this.Panel3.BackColor=System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.TextBox10);
            this.Panel3.Controls.Add(this.A9DaysBox);
            this.Panel3.Controls.Add(this.A9TimeBox);
            this.Panel3.Controls.Add(this.A9FOverBox);
            this.Panel3.Controls.Add(this.A9OverBox);
            this.Panel3.Controls.Add(this.A9TotalBox);
            this.Panel3.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel3.Location=new System.Drawing.Point(18, 144);
            this.Panel3.Margin=new System.Windows.Forms.Padding(0);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(454, 31);
            this.Panel3.TabIndex=26;
            // 
            // TextBox10
            // 
            this.TextBox10.BackColor=System.Drawing.Color.White;
            this.TextBox10.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox10.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox10.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox10.Location=new System.Drawing.Point(376, 0);
            this.TextBox10.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox10.Name="TextBox10";
            this.TextBox10.Size=new System.Drawing.Size(76, 31);
            this.TextBox10.TabIndex=6;
            this.TextBox10.Text="شیفت A";
            // 
            // A9DaysBox
            // 
            this.A9DaysBox.BackColor=System.Drawing.Color.White;
            this.A9DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A9DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A9DaysBox.Location=new System.Drawing.Point(301, 0);
            this.A9DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.A9DaysBox.Name="A9DaysBox";
            this.A9DaysBox.Size=new System.Drawing.Size(75, 31);
            this.A9DaysBox.TabIndex=5;
            this.A9DaysBox.Text="21";
            // 
            // A9TimeBox
            // 
            this.A9TimeBox.BackColor=System.Drawing.Color.White;
            this.A9TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A9TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A9TimeBox.Location=new System.Drawing.Point(226, 0);
            this.A9TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.A9TimeBox.Name="A9TimeBox";
            this.A9TimeBox.Size=new System.Drawing.Size(75, 31);
            this.A9TimeBox.TabIndex=4;
            this.A9TimeBox.Text="220";
            // 
            // A9FOverBox
            // 
            this.A9FOverBox.BackColor=System.Drawing.Color.White;
            this.A9FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A9FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A9FOverBox.Location=new System.Drawing.Point(151, 0);
            this.A9FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.A9FOverBox.Name="A9FOverBox";
            this.A9FOverBox.Size=new System.Drawing.Size(75, 31);
            this.A9FOverBox.TabIndex=3;
            this.A9FOverBox.Text="18:00";
            // 
            // A9OverBox
            // 
            this.A9OverBox.BackColor=System.Drawing.Color.White;
            this.A9OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A9OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A9OverBox.Location=new System.Drawing.Point(76, 0);
            this.A9OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.A9OverBox.Name="A9OverBox";
            this.A9OverBox.Size=new System.Drawing.Size(75, 31);
            this.A9OverBox.TabIndex=2;
            this.A9OverBox.Text="155:00";
            // 
            // A9TotalBox
            // 
            this.A9TotalBox.BackColor=System.Drawing.Color.White;
            this.A9TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A9TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A9TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A9TotalBox.Location=new System.Drawing.Point(0, 0);
            this.A9TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.A9TotalBox.Name="A9TotalBox";
            this.A9TotalBox.Size=new System.Drawing.Size(76, 31);
            this.A9TotalBox.TabIndex=1;
            this.A9TotalBox.Text="220:30";
            // 
            // Panel9
            // 
            this.Panel9.AutoSize=true;
            this.Panel9.Controls.Add(this.Label3);
            this.Panel9.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel9.Location=new System.Drawing.Point(470, 236);
            this.Panel9.Margin=new System.Windows.Forms.Padding(0);
            this.Panel9.Name="Panel9";
            this.Panel9.Size=new System.Drawing.Size(85, 90);
            this.Panel9.TabIndex=29;
            // 
            // Label3
            // 
            this.Label3.BackColor=System.Drawing.Color.White;
            this.Label3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Label3.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label3.ForeColor=System.Drawing.Color.Black;
            this.Label3.Location=new System.Drawing.Point(0, 0);
            this.Label3.Margin=new System.Windows.Forms.Padding(0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(85, 90);
            this.Label3.TabIndex=1;
            this.Label3.Text="راهبر\r\n12 ساعته\r\nخط اصلی";
            this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel13
            // 
            this.Panel13.AutoSize=true;
            this.Panel13.Controls.Add(this.Label5);
            this.Panel13.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel13.Location=new System.Drawing.Point(470, 450);
            this.Panel13.Margin=new System.Windows.Forms.Padding(0);
            this.Panel13.Name="Panel13";
            this.Panel13.Size=new System.Drawing.Size(85, 91);
            this.Panel13.TabIndex=33;
            // 
            // Label5
            // 
            this.Label5.BackColor=System.Drawing.Color.White;
            this.Label5.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Label5.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.ForeColor=System.Drawing.Color.Black;
            this.Label5.Location=new System.Drawing.Point(0, 0);
            this.Label5.Margin=new System.Windows.Forms.Padding(0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(85, 91);
            this.Label5.TabIndex=1;
            this.Label5.Text="مسئول و تکنسین";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel4
            // 
            this.Panel4.AutoSize=true;
            this.Panel4.BackColor=System.Drawing.Color.White;
            this.Panel4.Controls.Add(this.TextBox11);
            this.Panel4.Controls.Add(this.B9DaysBox);
            this.Panel4.Controls.Add(this.B9TimeBox);
            this.Panel4.Controls.Add(this.B9FOverBox);
            this.Panel4.Controls.Add(this.B9OverBox);
            this.Panel4.Controls.Add(this.B9TotalBox);
            this.Panel4.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel4.Location=new System.Drawing.Point(18, 174);
            this.Panel4.Margin=new System.Windows.Forms.Padding(0);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(454, 31);
            this.Panel4.TabIndex=34;
            // 
            // TextBox11
            // 
            this.TextBox11.BackColor=System.Drawing.Color.White;
            this.TextBox11.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox11.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox11.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox11.Location=new System.Drawing.Point(376, 0);
            this.TextBox11.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox11.Name="TextBox11";
            this.TextBox11.Size=new System.Drawing.Size(76, 31);
            this.TextBox11.TabIndex=6;
            this.TextBox11.Text="شیفت B";
            // 
            // B9DaysBox
            // 
            this.B9DaysBox.BackColor=System.Drawing.Color.White;
            this.B9DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B9DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B9DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B9DaysBox.Location=new System.Drawing.Point(301, 0);
            this.B9DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.B9DaysBox.Name="B9DaysBox";
            this.B9DaysBox.Size=new System.Drawing.Size(75, 31);
            this.B9DaysBox.TabIndex=5;
            // 
            // B9TimeBox
            // 
            this.B9TimeBox.BackColor=System.Drawing.Color.White;
            this.B9TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B9TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B9TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B9TimeBox.Location=new System.Drawing.Point(226, 0);
            this.B9TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.B9TimeBox.Name="B9TimeBox";
            this.B9TimeBox.Size=new System.Drawing.Size(75, 31);
            this.B9TimeBox.TabIndex=4;
            // 
            // B9FOverBox
            // 
            this.B9FOverBox.BackColor=System.Drawing.Color.White;
            this.B9FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B9FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B9FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B9FOverBox.Location=new System.Drawing.Point(151, 0);
            this.B9FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.B9FOverBox.Name="B9FOverBox";
            this.B9FOverBox.Size=new System.Drawing.Size(75, 31);
            this.B9FOverBox.TabIndex=3;
            // 
            // B9OverBox
            // 
            this.B9OverBox.BackColor=System.Drawing.Color.White;
            this.B9OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B9OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B9OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B9OverBox.Location=new System.Drawing.Point(76, 0);
            this.B9OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.B9OverBox.Name="B9OverBox";
            this.B9OverBox.Size=new System.Drawing.Size(75, 31);
            this.B9OverBox.TabIndex=2;
            // 
            // B9TotalBox
            // 
            this.B9TotalBox.BackColor=System.Drawing.Color.White;
            this.B9TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B9TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B9TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B9TotalBox.Location=new System.Drawing.Point(0, 0);
            this.B9TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.B9TotalBox.Name="B9TotalBox";
            this.B9TotalBox.Size=new System.Drawing.Size(76, 31);
            this.B9TotalBox.TabIndex=1;
            // 
            // Panel5
            // 
            this.Panel5.AutoSize=true;
            this.Panel5.BackColor=System.Drawing.Color.White;
            this.Panel5.Controls.Add(this.TextBox12);
            this.Panel5.Controls.Add(this.C9DaysBox);
            this.Panel5.Controls.Add(this.C9TimeBox);
            this.Panel5.Controls.Add(this.C9FOverBox);
            this.Panel5.Controls.Add(this.C9OverBox);
            this.Panel5.Controls.Add(this.C9TotalBox);
            this.Panel5.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel5.Location=new System.Drawing.Point(18, 204);
            this.Panel5.Margin=new System.Windows.Forms.Padding(0);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(454, 31);
            this.Panel5.TabIndex=35;
            // 
            // TextBox12
            // 
            this.TextBox12.BackColor=System.Drawing.Color.White;
            this.TextBox12.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox12.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox12.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox12.Location=new System.Drawing.Point(376, 0);
            this.TextBox12.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox12.Name="TextBox12";
            this.TextBox12.Size=new System.Drawing.Size(76, 31);
            this.TextBox12.TabIndex=6;
            this.TextBox12.Text="شیفت C";
            // 
            // C9DaysBox
            // 
            this.C9DaysBox.BackColor=System.Drawing.Color.White;
            this.C9DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C9DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C9DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C9DaysBox.Location=new System.Drawing.Point(301, 0);
            this.C9DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.C9DaysBox.Name="C9DaysBox";
            this.C9DaysBox.Size=new System.Drawing.Size(75, 31);
            this.C9DaysBox.TabIndex=5;
            // 
            // C9TimeBox
            // 
            this.C9TimeBox.BackColor=System.Drawing.Color.White;
            this.C9TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C9TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C9TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C9TimeBox.Location=new System.Drawing.Point(226, 0);
            this.C9TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.C9TimeBox.Name="C9TimeBox";
            this.C9TimeBox.Size=new System.Drawing.Size(75, 31);
            this.C9TimeBox.TabIndex=4;
            // 
            // C9FOverBox
            // 
            this.C9FOverBox.BackColor=System.Drawing.Color.White;
            this.C9FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C9FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C9FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C9FOverBox.Location=new System.Drawing.Point(151, 0);
            this.C9FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.C9FOverBox.Name="C9FOverBox";
            this.C9FOverBox.Size=new System.Drawing.Size(75, 31);
            this.C9FOverBox.TabIndex=3;
            // 
            // C9OverBox
            // 
            this.C9OverBox.BackColor=System.Drawing.Color.White;
            this.C9OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C9OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C9OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C9OverBox.Location=new System.Drawing.Point(76, 0);
            this.C9OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.C9OverBox.Name="C9OverBox";
            this.C9OverBox.Size=new System.Drawing.Size(75, 31);
            this.C9OverBox.TabIndex=2;
            // 
            // C9TotalBox
            // 
            this.C9TotalBox.BackColor=System.Drawing.Color.White;
            this.C9TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C9TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C9TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C9TotalBox.Location=new System.Drawing.Point(0, 0);
            this.C9TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.C9TotalBox.Name="C9TotalBox";
            this.C9TotalBox.Size=new System.Drawing.Size(76, 31);
            this.C9TotalBox.TabIndex=1;
            // 
            // Panel6
            // 
            this.Panel6.AutoSize=true;
            this.Panel6.BackColor=System.Drawing.Color.White;
            this.Panel6.Controls.Add(this.TextBox13);
            this.Panel6.Controls.Add(this.A12DaysBox);
            this.Panel6.Controls.Add(this.A12TimeBox);
            this.Panel6.Controls.Add(this.A12FOverBox);
            this.Panel6.Controls.Add(this.A12OverBox);
            this.Panel6.Controls.Add(this.A12TotalBox);
            this.Panel6.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel6.Location=new System.Drawing.Point(18, 236);
            this.Panel6.Margin=new System.Windows.Forms.Padding(0);
            this.Panel6.Name="Panel6";
            this.Panel6.Size=new System.Drawing.Size(454, 31);
            this.Panel6.TabIndex=36;
            // 
            // TextBox13
            // 
            this.TextBox13.BackColor=System.Drawing.Color.White;
            this.TextBox13.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox13.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox13.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox13.Location=new System.Drawing.Point(376, 0);
            this.TextBox13.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox13.Name="TextBox13";
            this.TextBox13.Size=new System.Drawing.Size(76, 31);
            this.TextBox13.TabIndex=6;
            this.TextBox13.Text="شیفت A";
            // 
            // A12DaysBox
            // 
            this.A12DaysBox.BackColor=System.Drawing.Color.White;
            this.A12DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A12DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A12DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A12DaysBox.Location=new System.Drawing.Point(301, 0);
            this.A12DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.A12DaysBox.Name="A12DaysBox";
            this.A12DaysBox.Size=new System.Drawing.Size(75, 31);
            this.A12DaysBox.TabIndex=5;
            // 
            // A12TimeBox
            // 
            this.A12TimeBox.BackColor=System.Drawing.Color.White;
            this.A12TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A12TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A12TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A12TimeBox.Location=new System.Drawing.Point(226, 0);
            this.A12TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.A12TimeBox.Name="A12TimeBox";
            this.A12TimeBox.Size=new System.Drawing.Size(75, 31);
            this.A12TimeBox.TabIndex=4;
            // 
            // A12FOverBox
            // 
            this.A12FOverBox.BackColor=System.Drawing.Color.White;
            this.A12FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A12FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A12FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A12FOverBox.Location=new System.Drawing.Point(151, 0);
            this.A12FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.A12FOverBox.Name="A12FOverBox";
            this.A12FOverBox.Size=new System.Drawing.Size(75, 31);
            this.A12FOverBox.TabIndex=3;
            // 
            // A12OverBox
            // 
            this.A12OverBox.BackColor=System.Drawing.Color.White;
            this.A12OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A12OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A12OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A12OverBox.Location=new System.Drawing.Point(76, 0);
            this.A12OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.A12OverBox.Name="A12OverBox";
            this.A12OverBox.Size=new System.Drawing.Size(75, 31);
            this.A12OverBox.TabIndex=2;
            // 
            // A12TotalBox
            // 
            this.A12TotalBox.BackColor=System.Drawing.Color.White;
            this.A12TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.A12TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.A12TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.A12TotalBox.Location=new System.Drawing.Point(0, 0);
            this.A12TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.A12TotalBox.Name="A12TotalBox";
            this.A12TotalBox.Size=new System.Drawing.Size(76, 31);
            this.A12TotalBox.TabIndex=1;
            // 
            // Panel7
            // 
            this.Panel7.AutoSize=true;
            this.Panel7.BackColor=System.Drawing.Color.White;
            this.Panel7.Controls.Add(this.TextBox14);
            this.Panel7.Controls.Add(this.B12DaysBox);
            this.Panel7.Controls.Add(this.B12TimeBox);
            this.Panel7.Controls.Add(this.B12FOverBox);
            this.Panel7.Controls.Add(this.B12OverBox);
            this.Panel7.Controls.Add(this.B12TotalBox);
            this.Panel7.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel7.Location=new System.Drawing.Point(18, 266);
            this.Panel7.Margin=new System.Windows.Forms.Padding(0);
            this.Panel7.Name="Panel7";
            this.Panel7.Size=new System.Drawing.Size(454, 31);
            this.Panel7.TabIndex=37;
            // 
            // TextBox14
            // 
            this.TextBox14.BackColor=System.Drawing.Color.White;
            this.TextBox14.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox14.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox14.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox14.Location=new System.Drawing.Point(376, 0);
            this.TextBox14.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox14.Name="TextBox14";
            this.TextBox14.Size=new System.Drawing.Size(76, 31);
            this.TextBox14.TabIndex=6;
            this.TextBox14.Text="شیفت B";
            // 
            // B12DaysBox
            // 
            this.B12DaysBox.BackColor=System.Drawing.Color.White;
            this.B12DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B12DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B12DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B12DaysBox.Location=new System.Drawing.Point(301, 0);
            this.B12DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.B12DaysBox.Name="B12DaysBox";
            this.B12DaysBox.Size=new System.Drawing.Size(75, 31);
            this.B12DaysBox.TabIndex=5;
            // 
            // B12TimeBox
            // 
            this.B12TimeBox.BackColor=System.Drawing.Color.White;
            this.B12TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B12TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B12TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B12TimeBox.Location=new System.Drawing.Point(226, 0);
            this.B12TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.B12TimeBox.Name="B12TimeBox";
            this.B12TimeBox.Size=new System.Drawing.Size(75, 31);
            this.B12TimeBox.TabIndex=4;
            // 
            // B12FOverBox
            // 
            this.B12FOverBox.BackColor=System.Drawing.Color.White;
            this.B12FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B12FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B12FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B12FOverBox.Location=new System.Drawing.Point(151, 0);
            this.B12FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.B12FOverBox.Name="B12FOverBox";
            this.B12FOverBox.Size=new System.Drawing.Size(75, 31);
            this.B12FOverBox.TabIndex=3;
            // 
            // B12OverBox
            // 
            this.B12OverBox.BackColor=System.Drawing.Color.White;
            this.B12OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B12OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B12OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B12OverBox.Location=new System.Drawing.Point(76, 0);
            this.B12OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.B12OverBox.Name="B12OverBox";
            this.B12OverBox.Size=new System.Drawing.Size(75, 31);
            this.B12OverBox.TabIndex=2;
            // 
            // B12TotalBox
            // 
            this.B12TotalBox.BackColor=System.Drawing.Color.White;
            this.B12TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.B12TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.B12TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.B12TotalBox.Location=new System.Drawing.Point(0, 0);
            this.B12TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.B12TotalBox.Name="B12TotalBox";
            this.B12TotalBox.Size=new System.Drawing.Size(76, 31);
            this.B12TotalBox.TabIndex=1;
            // 
            // Panel8
            // 
            this.Panel8.AutoSize=true;
            this.Panel8.BackColor=System.Drawing.Color.White;
            this.Panel8.Controls.Add(this.TextBox15);
            this.Panel8.Controls.Add(this.C12DaysBox);
            this.Panel8.Controls.Add(this.C12TimeBox);
            this.Panel8.Controls.Add(this.C12FOverBox);
            this.Panel8.Controls.Add(this.C12OverBox);
            this.Panel8.Controls.Add(this.C12TotalBox);
            this.Panel8.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel8.Location=new System.Drawing.Point(18, 295);
            this.Panel8.Margin=new System.Windows.Forms.Padding(0);
            this.Panel8.Name="Panel8";
            this.Panel8.Size=new System.Drawing.Size(454, 31);
            this.Panel8.TabIndex=38;
            // 
            // TextBox15
            // 
            this.TextBox15.BackColor=System.Drawing.Color.White;
            this.TextBox15.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox15.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox15.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox15.Location=new System.Drawing.Point(376, 0);
            this.TextBox15.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox15.Name="TextBox15";
            this.TextBox15.Size=new System.Drawing.Size(76, 31);
            this.TextBox15.TabIndex=6;
            this.TextBox15.Text="شیفت C";
            // 
            // C12DaysBox
            // 
            this.C12DaysBox.BackColor=System.Drawing.Color.White;
            this.C12DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C12DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C12DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C12DaysBox.Location=new System.Drawing.Point(301, 0);
            this.C12DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.C12DaysBox.Name="C12DaysBox";
            this.C12DaysBox.Size=new System.Drawing.Size(75, 31);
            this.C12DaysBox.TabIndex=5;
            // 
            // C12TimeBox
            // 
            this.C12TimeBox.BackColor=System.Drawing.Color.White;
            this.C12TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C12TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C12TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C12TimeBox.Location=new System.Drawing.Point(226, 0);
            this.C12TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.C12TimeBox.Name="C12TimeBox";
            this.C12TimeBox.Size=new System.Drawing.Size(75, 31);
            this.C12TimeBox.TabIndex=4;
            // 
            // C12FOverBox
            // 
            this.C12FOverBox.BackColor=System.Drawing.Color.White;
            this.C12FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C12FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C12FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C12FOverBox.Location=new System.Drawing.Point(151, 0);
            this.C12FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.C12FOverBox.Name="C12FOverBox";
            this.C12FOverBox.Size=new System.Drawing.Size(75, 31);
            this.C12FOverBox.TabIndex=3;
            // 
            // C12OverBox
            // 
            this.C12OverBox.BackColor=System.Drawing.Color.White;
            this.C12OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C12OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C12OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C12OverBox.Location=new System.Drawing.Point(76, 0);
            this.C12OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.C12OverBox.Name="C12OverBox";
            this.C12OverBox.Size=new System.Drawing.Size(75, 31);
            this.C12OverBox.TabIndex=2;
            // 
            // C12TotalBox
            // 
            this.C12TotalBox.BackColor=System.Drawing.Color.White;
            this.C12TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.C12TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.C12TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.C12TotalBox.Location=new System.Drawing.Point(0, 0);
            this.C12TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.C12TotalBox.Name="C12TotalBox";
            this.C12TotalBox.Size=new System.Drawing.Size(76, 31);
            this.C12TotalBox.TabIndex=1;
            // 
            // Panel10
            // 
            this.Panel10.AutoSize=true;
            this.Panel10.BackColor=System.Drawing.Color.White;
            this.Panel10.Controls.Add(this.TextBox16);
            this.Panel10.Controls.Add(this.SetDaysBox);
            this.Panel10.Controls.Add(this.SetTimeBox);
            this.Panel10.Controls.Add(this.SetFOverBox);
            this.Panel10.Controls.Add(this.SetOverBox);
            this.Panel10.Controls.Add(this.SetTotalBox);
            this.Panel10.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel10.Location=new System.Drawing.Point(18, 327);
            this.Panel10.Margin=new System.Windows.Forms.Padding(0);
            this.Panel10.Name="Panel10";
            this.Panel10.Size=new System.Drawing.Size(539, 31);
            this.Panel10.TabIndex=39;
            // 
            // TextBox16
            // 
            this.TextBox16.BackColor=System.Drawing.Color.White;
            this.TextBox16.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox16.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox16.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox16.Location=new System.Drawing.Point(376, 0);
            this.TextBox16.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox16.Name="TextBox16";
            this.TextBox16.Size=new System.Drawing.Size(161, 31);
            this.TextBox16.TabIndex=6;
            this.TextBox16.Text="راهبر ستادی";
            // 
            // SetDaysBox
            // 
            this.SetDaysBox.BackColor=System.Drawing.Color.White;
            this.SetDaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetDaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.SetDaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SetDaysBox.Location=new System.Drawing.Point(301, 0);
            this.SetDaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.SetDaysBox.Name="SetDaysBox";
            this.SetDaysBox.Size=new System.Drawing.Size(75, 31);
            this.SetDaysBox.TabIndex=5;
            // 
            // SetTimeBox
            // 
            this.SetTimeBox.BackColor=System.Drawing.Color.White;
            this.SetTimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetTimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.SetTimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SetTimeBox.Location=new System.Drawing.Point(226, 0);
            this.SetTimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.SetTimeBox.Name="SetTimeBox";
            this.SetTimeBox.Size=new System.Drawing.Size(75, 31);
            this.SetTimeBox.TabIndex=4;
            // 
            // SetFOverBox
            // 
            this.SetFOverBox.BackColor=System.Drawing.Color.White;
            this.SetFOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetFOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.SetFOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SetFOverBox.Location=new System.Drawing.Point(151, 0);
            this.SetFOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.SetFOverBox.Name="SetFOverBox";
            this.SetFOverBox.Size=new System.Drawing.Size(75, 31);
            this.SetFOverBox.TabIndex=3;
            // 
            // SetOverBox
            // 
            this.SetOverBox.BackColor=System.Drawing.Color.White;
            this.SetOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.SetOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SetOverBox.Location=new System.Drawing.Point(76, 0);
            this.SetOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.SetOverBox.Name="SetOverBox";
            this.SetOverBox.Size=new System.Drawing.Size(75, 31);
            this.SetOverBox.TabIndex=2;
            // 
            // SetTotalBox
            // 
            this.SetTotalBox.BackColor=System.Drawing.Color.White;
            this.SetTotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetTotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.SetTotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SetTotalBox.Location=new System.Drawing.Point(0, 0);
            this.SetTotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.SetTotalBox.Name="SetTotalBox";
            this.SetTotalBox.Size=new System.Drawing.Size(76, 31);
            this.SetTotalBox.TabIndex=1;
            // 
            // Panel11
            // 
            this.Panel11.AutoSize=true;
            this.Panel11.BackColor=System.Drawing.Color.White;
            this.Panel11.Controls.Add(this.TextBox17);
            this.Panel11.Controls.Add(this.AMDaysBox);
            this.Panel11.Controls.Add(this.AMTimeBox);
            this.Panel11.Controls.Add(this.AMFOverBox);
            this.Panel11.Controls.Add(this.AMOverBox);
            this.Panel11.Controls.Add(this.AMTotalBox);
            this.Panel11.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel11.Location=new System.Drawing.Point(18, 450);
            this.Panel11.Margin=new System.Windows.Forms.Padding(0);
            this.Panel11.Name="Panel11";
            this.Panel11.Size=new System.Drawing.Size(454, 31);
            this.Panel11.TabIndex=40;
            // 
            // TextBox17
            // 
            this.TextBox17.BackColor=System.Drawing.Color.White;
            this.TextBox17.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox17.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox17.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox17.Location=new System.Drawing.Point(376, 0);
            this.TextBox17.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox17.Name="TextBox17";
            this.TextBox17.Size=new System.Drawing.Size(76, 31);
            this.TextBox17.TabIndex=6;
            this.TextBox17.Text="شیفت A";
            // 
            // AMDaysBox
            // 
            this.AMDaysBox.BackColor=System.Drawing.Color.White;
            this.AMDaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMDaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AMDaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AMDaysBox.Location=new System.Drawing.Point(301, 0);
            this.AMDaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.AMDaysBox.Name="AMDaysBox";
            this.AMDaysBox.Size=new System.Drawing.Size(75, 31);
            this.AMDaysBox.TabIndex=5;
            // 
            // AMTimeBox
            // 
            this.AMTimeBox.BackColor=System.Drawing.Color.White;
            this.AMTimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMTimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AMTimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AMTimeBox.Location=new System.Drawing.Point(226, 0);
            this.AMTimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.AMTimeBox.Name="AMTimeBox";
            this.AMTimeBox.Size=new System.Drawing.Size(75, 31);
            this.AMTimeBox.TabIndex=4;
            // 
            // AMFOverBox
            // 
            this.AMFOverBox.BackColor=System.Drawing.Color.White;
            this.AMFOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMFOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AMFOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AMFOverBox.Location=new System.Drawing.Point(151, 0);
            this.AMFOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.AMFOverBox.Name="AMFOverBox";
            this.AMFOverBox.Size=new System.Drawing.Size(75, 31);
            this.AMFOverBox.TabIndex=3;
            // 
            // AMOverBox
            // 
            this.AMOverBox.BackColor=System.Drawing.Color.White;
            this.AMOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AMOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AMOverBox.Location=new System.Drawing.Point(76, 0);
            this.AMOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.AMOverBox.Name="AMOverBox";
            this.AMOverBox.Size=new System.Drawing.Size(75, 31);
            this.AMOverBox.TabIndex=2;
            // 
            // AMTotalBox
            // 
            this.AMTotalBox.BackColor=System.Drawing.Color.White;
            this.AMTotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMTotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AMTotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AMTotalBox.Location=new System.Drawing.Point(0, 0);
            this.AMTotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.AMTotalBox.Name="AMTotalBox";
            this.AMTotalBox.Size=new System.Drawing.Size(76, 31);
            this.AMTotalBox.TabIndex=1;
            // 
            // Panel12
            // 
            this.Panel12.AutoSize=true;
            this.Panel12.BackColor=System.Drawing.Color.White;
            this.Panel12.Controls.Add(this.TextBox18);
            this.Panel12.Controls.Add(this.BMDaysBox);
            this.Panel12.Controls.Add(this.BMTimeBox);
            this.Panel12.Controls.Add(this.BMFOverBox);
            this.Panel12.Controls.Add(this.BMOverBox);
            this.Panel12.Controls.Add(this.BMTotalBox);
            this.Panel12.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel12.Location=new System.Drawing.Point(18, 480);
            this.Panel12.Margin=new System.Windows.Forms.Padding(0);
            this.Panel12.Name="Panel12";
            this.Panel12.Size=new System.Drawing.Size(454, 31);
            this.Panel12.TabIndex=41;
            // 
            // TextBox18
            // 
            this.TextBox18.BackColor=System.Drawing.Color.White;
            this.TextBox18.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox18.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox18.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox18.Location=new System.Drawing.Point(376, 0);
            this.TextBox18.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox18.Name="TextBox18";
            this.TextBox18.Size=new System.Drawing.Size(76, 31);
            this.TextBox18.TabIndex=6;
            this.TextBox18.Text="شیفت B";
            // 
            // BMDaysBox
            // 
            this.BMDaysBox.BackColor=System.Drawing.Color.White;
            this.BMDaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMDaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BMDaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BMDaysBox.Location=new System.Drawing.Point(301, 0);
            this.BMDaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.BMDaysBox.Name="BMDaysBox";
            this.BMDaysBox.Size=new System.Drawing.Size(75, 31);
            this.BMDaysBox.TabIndex=5;
            // 
            // BMTimeBox
            // 
            this.BMTimeBox.BackColor=System.Drawing.Color.White;
            this.BMTimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMTimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BMTimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BMTimeBox.Location=new System.Drawing.Point(226, 0);
            this.BMTimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.BMTimeBox.Name="BMTimeBox";
            this.BMTimeBox.Size=new System.Drawing.Size(75, 31);
            this.BMTimeBox.TabIndex=4;
            // 
            // BMFOverBox
            // 
            this.BMFOverBox.BackColor=System.Drawing.Color.White;
            this.BMFOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMFOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BMFOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BMFOverBox.Location=new System.Drawing.Point(151, 0);
            this.BMFOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.BMFOverBox.Name="BMFOverBox";
            this.BMFOverBox.Size=new System.Drawing.Size(75, 31);
            this.BMFOverBox.TabIndex=3;
            // 
            // BMOverBox
            // 
            this.BMOverBox.BackColor=System.Drawing.Color.White;
            this.BMOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BMOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BMOverBox.Location=new System.Drawing.Point(76, 0);
            this.BMOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.BMOverBox.Name="BMOverBox";
            this.BMOverBox.Size=new System.Drawing.Size(75, 31);
            this.BMOverBox.TabIndex=2;
            // 
            // BMTotalBox
            // 
            this.BMTotalBox.BackColor=System.Drawing.Color.White;
            this.BMTotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMTotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BMTotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BMTotalBox.Location=new System.Drawing.Point(0, 0);
            this.BMTotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.BMTotalBox.Name="BMTotalBox";
            this.BMTotalBox.Size=new System.Drawing.Size(76, 31);
            this.BMTotalBox.TabIndex=1;
            // 
            // Panel14
            // 
            this.Panel14.AutoSize=true;
            this.Panel14.BackColor=System.Drawing.Color.White;
            this.Panel14.Controls.Add(this.TextBox19);
            this.Panel14.Controls.Add(this.CMDaysBox);
            this.Panel14.Controls.Add(this.CMTimeBox);
            this.Panel14.Controls.Add(this.CMFOverBox);
            this.Panel14.Controls.Add(this.CMOverBox);
            this.Panel14.Controls.Add(this.CMTotalBox);
            this.Panel14.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel14.Location=new System.Drawing.Point(18, 510);
            this.Panel14.Margin=new System.Windows.Forms.Padding(0);
            this.Panel14.Name="Panel14";
            this.Panel14.Size=new System.Drawing.Size(454, 31);
            this.Panel14.TabIndex=42;
            // 
            // TextBox19
            // 
            this.TextBox19.BackColor=System.Drawing.Color.White;
            this.TextBox19.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox19.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox19.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox19.Location=new System.Drawing.Point(376, 0);
            this.TextBox19.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox19.Name="TextBox19";
            this.TextBox19.Size=new System.Drawing.Size(76, 31);
            this.TextBox19.TabIndex=6;
            this.TextBox19.Text="شیفت C";
            // 
            // CMDaysBox
            // 
            this.CMDaysBox.BackColor=System.Drawing.Color.White;
            this.CMDaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMDaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CMDaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CMDaysBox.Location=new System.Drawing.Point(301, 0);
            this.CMDaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.CMDaysBox.Name="CMDaysBox";
            this.CMDaysBox.Size=new System.Drawing.Size(75, 31);
            this.CMDaysBox.TabIndex=5;
            // 
            // CMTimeBox
            // 
            this.CMTimeBox.BackColor=System.Drawing.Color.White;
            this.CMTimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMTimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CMTimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CMTimeBox.Location=new System.Drawing.Point(226, 0);
            this.CMTimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.CMTimeBox.Name="CMTimeBox";
            this.CMTimeBox.Size=new System.Drawing.Size(75, 31);
            this.CMTimeBox.TabIndex=4;
            // 
            // CMFOverBox
            // 
            this.CMFOverBox.BackColor=System.Drawing.Color.White;
            this.CMFOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMFOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CMFOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CMFOverBox.Location=new System.Drawing.Point(151, 0);
            this.CMFOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.CMFOverBox.Name="CMFOverBox";
            this.CMFOverBox.Size=new System.Drawing.Size(75, 31);
            this.CMFOverBox.TabIndex=3;
            // 
            // CMOverBox
            // 
            this.CMOverBox.BackColor=System.Drawing.Color.White;
            this.CMOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CMOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CMOverBox.Location=new System.Drawing.Point(76, 0);
            this.CMOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.CMOverBox.Name="CMOverBox";
            this.CMOverBox.Size=new System.Drawing.Size(75, 31);
            this.CMOverBox.TabIndex=2;
            // 
            // CMTotalBox
            // 
            this.CMTotalBox.BackColor=System.Drawing.Color.White;
            this.CMTotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMTotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CMTotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CMTotalBox.Location=new System.Drawing.Point(0, 0);
            this.CMTotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.CMTotalBox.Name="CMTotalBox";
            this.CMTotalBox.Size=new System.Drawing.Size(76, 31);
            this.CMTotalBox.TabIndex=1;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.Location=new System.Drawing.Point(456, 58);
            this.Label4.Margin=new System.Windows.Forms.Padding(0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(104, 29);
            this.Label4.TabIndex=43;
            this.Label4.Text="تعداد روزکاری:";
            // 
            // MonthWorkBox
            // 
            this.MonthWorkBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthWorkBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthWorkBox.Location=new System.Drawing.Point(396, 56);
            this.MonthWorkBox.Margin=new System.Windows.Forms.Padding(0);
            this.MonthWorkBox.Name="MonthWorkBox";
            this.MonthWorkBox.Size=new System.Drawing.Size(60, 33);
            this.MonthWorkBox.TabIndex=44;
            this.MonthWorkBox.Text="1234";
            // 
            // MonthTimeBox
            // 
            this.MonthTimeBox.BackColor=System.Drawing.SystemColors.Control;
            this.MonthTimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthTimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthTimeBox.Location=new System.Drawing.Point(216, 56);
            this.MonthTimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.MonthTimeBox.Name="MonthTimeBox";
            this.MonthTimeBox.Size=new System.Drawing.Size(65, 33);
            this.MonthTimeBox.TabIndex=46;
            this.MonthTimeBox.Text="155:00";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label6.Location=new System.Drawing.Point(278, 58);
            this.Label6.Margin=new System.Windows.Forms.Padding(0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(104, 29);
            this.Label6.TabIndex=45;
            this.Label6.Text="کارکرد موظفی:";
            // 
            // YearCombo
            // 
            this.YearCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCombo.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.YearCombo.ItemHeight=29;
            this.YearCombo.Location=new System.Drawing.Point(292, 10);
            this.YearCombo.Margin=new System.Windows.Forms.Padding(0);
            this.YearCombo.Name="YearCombo";
            this.YearCombo.Size=new System.Drawing.Size(73, 37);
            this.YearCombo.TabIndex=0;
            this.YearCombo.SelectedIndexChanged += new System.EventHandler(this.YearCombo_SelectedIndexChanged);
            // 
            // MonthCombo
            // 
            this.MonthCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCombo.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthCombo.Items.AddRange(new object[] {
            " فروردین",
            "اردیبهشت",
            "  خرداد",
            "  تیر",
            "  مرداد",
            "شهریور",
            "  مهر",
            "  آبان",
            "   آذر",
            "  دی",
            " بهمن",
            " اسفند"});
            this.MonthCombo.Location=new System.Drawing.Point(136, 10);
            this.MonthCombo.Margin=new System.Windows.Forms.Padding(0);
            this.MonthCombo.Name="MonthCombo";
            this.MonthCombo.Size=new System.Drawing.Size(100, 37);
            this.MonthCombo.TabIndex=1;
            this.MonthCombo.SelectedIndexChanged += new System.EventHandler(this.MonthCombo_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Font=new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.Location=new System.Drawing.Point(365, 10);
            this.Label1.Margin=new System.Windows.Forms.Padding(0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(49, 33);
            this.Label1.TabIndex=50;
            this.Label1.Text="سال:";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label7.Location=new System.Drawing.Point(235, 10);
            this.Label7.Margin=new System.Windows.Forms.Padding(0);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(42, 33);
            this.Label7.TabIndex=48;
            this.Label7.Text="ماه:";
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label8.Location=new System.Drawing.Point(83, 58);
            this.Label8.Margin=new System.Windows.Forms.Padding(0);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(112, 29);
            this.Label8.TabIndex=45;
            this.Label8.Text="سقف اضافه کاری:";
            // 
            // MonthOverBox
            // 
            this.MonthOverBox.BackColor=System.Drawing.SystemColors.Control;
            this.MonthOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthOverBox.Location=new System.Drawing.Point(20, 56);
            this.MonthOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.MonthOverBox.Name="MonthOverBox";
            this.MonthOverBox.Size=new System.Drawing.Size(65, 33);
            this.MonthOverBox.TabIndex=46;
            this.MonthOverBox.Text="155:00";
            // 
            // Panel15
            // 
            this.Panel15.AutoSize=true;
            this.Panel15.Controls.Add(this.Label9);
            this.Panel15.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel15.Location=new System.Drawing.Point(470, 359);
            this.Panel15.Margin=new System.Windows.Forms.Padding(0);
            this.Panel15.Name="Panel15";
            this.Panel15.Size=new System.Drawing.Size(85, 90);
            this.Panel15.TabIndex=29;
            // 
            // Label9
            // 
            this.Label9.BackColor=System.Drawing.Color.White;
            this.Label9.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Label9.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label9.ForeColor=System.Drawing.Color.Black;
            this.Label9.Location=new System.Drawing.Point(0, 0);
            this.Label9.Margin=new System.Windows.Forms.Padding(0);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(85, 90);
            this.Label9.TabIndex=1;
            this.Label9.Text="راهبر\r\n12 ساعته\r\nپایانه";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel16
            // 
            this.Panel16.AutoSize=true;
            this.Panel16.BackColor=System.Drawing.Color.White;
            this.Panel16.Controls.Add(this.TextBox1);
            this.Panel16.Controls.Add(this.AP12DaysBox);
            this.Panel16.Controls.Add(this.AP12TimeBox);
            this.Panel16.Controls.Add(this.AP12FOverBox);
            this.Panel16.Controls.Add(this.AP12OverBox);
            this.Panel16.Controls.Add(this.AP12TotalBox);
            this.Panel16.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel16.Location=new System.Drawing.Point(18, 359);
            this.Panel16.Margin=new System.Windows.Forms.Padding(0);
            this.Panel16.Name="Panel16";
            this.Panel16.Size=new System.Drawing.Size(454, 31);
            this.Panel16.TabIndex=36;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor=System.Drawing.Color.White;
            this.TextBox1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox1.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox1.Location=new System.Drawing.Point(376, 0);
            this.TextBox1.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox1.Name="TextBox1";
            this.TextBox1.Size=new System.Drawing.Size(76, 31);
            this.TextBox1.TabIndex=6;
            this.TextBox1.Text="شیفت A";
            // 
            // AP12DaysBox
            // 
            this.AP12DaysBox.BackColor=System.Drawing.Color.White;
            this.AP12DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AP12DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AP12DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AP12DaysBox.Location=new System.Drawing.Point(301, 0);
            this.AP12DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.AP12DaysBox.Name="AP12DaysBox";
            this.AP12DaysBox.Size=new System.Drawing.Size(75, 31);
            this.AP12DaysBox.TabIndex=5;
            // 
            // AP12TimeBox
            // 
            this.AP12TimeBox.BackColor=System.Drawing.Color.White;
            this.AP12TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AP12TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AP12TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AP12TimeBox.Location=new System.Drawing.Point(226, 0);
            this.AP12TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.AP12TimeBox.Name="AP12TimeBox";
            this.AP12TimeBox.Size=new System.Drawing.Size(75, 31);
            this.AP12TimeBox.TabIndex=4;
            // 
            // AP12FOverBox
            // 
            this.AP12FOverBox.BackColor=System.Drawing.Color.White;
            this.AP12FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AP12FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AP12FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AP12FOverBox.Location=new System.Drawing.Point(151, 0);
            this.AP12FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.AP12FOverBox.Name="AP12FOverBox";
            this.AP12FOverBox.Size=new System.Drawing.Size(75, 31);
            this.AP12FOverBox.TabIndex=3;
            // 
            // AP12OverBox
            // 
            this.AP12OverBox.BackColor=System.Drawing.Color.White;
            this.AP12OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AP12OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AP12OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AP12OverBox.Location=new System.Drawing.Point(76, 0);
            this.AP12OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.AP12OverBox.Name="AP12OverBox";
            this.AP12OverBox.Size=new System.Drawing.Size(75, 31);
            this.AP12OverBox.TabIndex=2;
            // 
            // AP12TotalBox
            // 
            this.AP12TotalBox.BackColor=System.Drawing.Color.White;
            this.AP12TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.AP12TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.AP12TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AP12TotalBox.Location=new System.Drawing.Point(0, 0);
            this.AP12TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.AP12TotalBox.Name="AP12TotalBox";
            this.AP12TotalBox.Size=new System.Drawing.Size(76, 31);
            this.AP12TotalBox.TabIndex=1;
            // 
            // Panel17
            // 
            this.Panel17.AutoSize=true;
            this.Panel17.BackColor=System.Drawing.Color.White;
            this.Panel17.Controls.Add(this.TextBox7);
            this.Panel17.Controls.Add(this.BP12DaysBox);
            this.Panel17.Controls.Add(this.BP12TimeBox);
            this.Panel17.Controls.Add(this.BP12FOverBox);
            this.Panel17.Controls.Add(this.BP12OverBox);
            this.Panel17.Controls.Add(this.BP12TotalBox);
            this.Panel17.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel17.Location=new System.Drawing.Point(18, 389);
            this.Panel17.Margin=new System.Windows.Forms.Padding(0);
            this.Panel17.Name="Panel17";
            this.Panel17.Size=new System.Drawing.Size(454, 31);
            this.Panel17.TabIndex=37;
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor=System.Drawing.Color.White;
            this.TextBox7.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox7.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox7.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox7.Location=new System.Drawing.Point(376, 0);
            this.TextBox7.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox7.Name="TextBox7";
            this.TextBox7.Size=new System.Drawing.Size(76, 31);
            this.TextBox7.TabIndex=6;
            this.TextBox7.Text="شیفت B";
            // 
            // BP12DaysBox
            // 
            this.BP12DaysBox.BackColor=System.Drawing.Color.White;
            this.BP12DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BP12DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BP12DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BP12DaysBox.Location=new System.Drawing.Point(301, 0);
            this.BP12DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.BP12DaysBox.Name="BP12DaysBox";
            this.BP12DaysBox.Size=new System.Drawing.Size(75, 31);
            this.BP12DaysBox.TabIndex=5;
            // 
            // BP12TimeBox
            // 
            this.BP12TimeBox.BackColor=System.Drawing.Color.White;
            this.BP12TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BP12TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BP12TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BP12TimeBox.Location=new System.Drawing.Point(226, 0);
            this.BP12TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.BP12TimeBox.Name="BP12TimeBox";
            this.BP12TimeBox.Size=new System.Drawing.Size(75, 31);
            this.BP12TimeBox.TabIndex=4;
            // 
            // BP12FOverBox
            // 
            this.BP12FOverBox.BackColor=System.Drawing.Color.White;
            this.BP12FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BP12FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BP12FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BP12FOverBox.Location=new System.Drawing.Point(151, 0);
            this.BP12FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.BP12FOverBox.Name="BP12FOverBox";
            this.BP12FOverBox.Size=new System.Drawing.Size(75, 31);
            this.BP12FOverBox.TabIndex=3;
            // 
            // BP12OverBox
            // 
            this.BP12OverBox.BackColor=System.Drawing.Color.White;
            this.BP12OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BP12OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BP12OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BP12OverBox.Location=new System.Drawing.Point(76, 0);
            this.BP12OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.BP12OverBox.Name="BP12OverBox";
            this.BP12OverBox.Size=new System.Drawing.Size(75, 31);
            this.BP12OverBox.TabIndex=2;
            // 
            // BP12TotalBox
            // 
            this.BP12TotalBox.BackColor=System.Drawing.Color.White;
            this.BP12TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.BP12TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.BP12TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BP12TotalBox.Location=new System.Drawing.Point(0, 0);
            this.BP12TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.BP12TotalBox.Name="BP12TotalBox";
            this.BP12TotalBox.Size=new System.Drawing.Size(76, 31);
            this.BP12TotalBox.TabIndex=1;
            // 
            // Panel18
            // 
            this.Panel18.AutoSize=true;
            this.Panel18.BackColor=System.Drawing.Color.White;
            this.Panel18.Controls.Add(this.TextBox23);
            this.Panel18.Controls.Add(this.CP12DaysBox);
            this.Panel18.Controls.Add(this.CP12TimeBox);
            this.Panel18.Controls.Add(this.CP12FOverBox);
            this.Panel18.Controls.Add(this.CP12OverBox);
            this.Panel18.Controls.Add(this.CP12TotalBox);
            this.Panel18.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel18.Location=new System.Drawing.Point(18, 418);
            this.Panel18.Margin=new System.Windows.Forms.Padding(0);
            this.Panel18.Name="Panel18";
            this.Panel18.Size=new System.Drawing.Size(454, 31);
            this.Panel18.TabIndex=38;
            // 
            // TextBox23
            // 
            this.TextBox23.BackColor=System.Drawing.Color.White;
            this.TextBox23.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox23.Dock=System.Windows.Forms.DockStyle.Left;
            this.TextBox23.Font=new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBox23.Location=new System.Drawing.Point(376, 0);
            this.TextBox23.Margin=new System.Windows.Forms.Padding(0);
            this.TextBox23.Name="TextBox23";
            this.TextBox23.Size=new System.Drawing.Size(76, 31);
            this.TextBox23.TabIndex=6;
            this.TextBox23.Text="شیفت C";
            // 
            // CP12DaysBox
            // 
            this.CP12DaysBox.BackColor=System.Drawing.Color.White;
            this.CP12DaysBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP12DaysBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CP12DaysBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CP12DaysBox.Location=new System.Drawing.Point(301, 0);
            this.CP12DaysBox.Margin=new System.Windows.Forms.Padding(0);
            this.CP12DaysBox.Name="CP12DaysBox";
            this.CP12DaysBox.Size=new System.Drawing.Size(75, 31);
            this.CP12DaysBox.TabIndex=5;
            // 
            // CP12TimeBox
            // 
            this.CP12TimeBox.BackColor=System.Drawing.Color.White;
            this.CP12TimeBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP12TimeBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CP12TimeBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CP12TimeBox.Location=new System.Drawing.Point(226, 0);
            this.CP12TimeBox.Margin=new System.Windows.Forms.Padding(0);
            this.CP12TimeBox.Name="CP12TimeBox";
            this.CP12TimeBox.Size=new System.Drawing.Size(75, 31);
            this.CP12TimeBox.TabIndex=4;
            // 
            // CP12FOverBox
            // 
            this.CP12FOverBox.BackColor=System.Drawing.Color.White;
            this.CP12FOverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP12FOverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CP12FOverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CP12FOverBox.Location=new System.Drawing.Point(151, 0);
            this.CP12FOverBox.Margin=new System.Windows.Forms.Padding(0);
            this.CP12FOverBox.Name="CP12FOverBox";
            this.CP12FOverBox.Size=new System.Drawing.Size(75, 31);
            this.CP12FOverBox.TabIndex=3;
            // 
            // CP12OverBox
            // 
            this.CP12OverBox.BackColor=System.Drawing.Color.White;
            this.CP12OverBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP12OverBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CP12OverBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CP12OverBox.Location=new System.Drawing.Point(76, 0);
            this.CP12OverBox.Margin=new System.Windows.Forms.Padding(0);
            this.CP12OverBox.Name="CP12OverBox";
            this.CP12OverBox.Size=new System.Drawing.Size(75, 31);
            this.CP12OverBox.TabIndex=2;
            // 
            // CP12TotalBox
            // 
            this.CP12TotalBox.BackColor=System.Drawing.Color.White;
            this.CP12TotalBox.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP12TotalBox.Dock=System.Windows.Forms.DockStyle.Left;
            this.CP12TotalBox.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CP12TotalBox.Location=new System.Drawing.Point(0, 0);
            this.CP12TotalBox.Margin=new System.Windows.Forms.Padding(0);
            this.CP12TotalBox.Name="CP12TotalBox";
            this.CP12TotalBox.Size=new System.Drawing.Size(76, 31);
            this.CP12TotalBox.TabIndex=1;
            // 
            // NextButton
            // 
            this.NextButton.Image=global::Metro_Operation.Properties.Resources._31;
            this.NextButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NextButton.Location=new System.Drawing.Point(41, 10);
            this.NextButton.Margin=new System.Windows.Forms.Padding(0);
            this.NextButton.Name="NextButton";
            this.NextButton.Size=new System.Drawing.Size(84, 28);
            this.NextButton.TabIndex=51;
            this.NextButton.Text="ماه بعد";
            this.NextButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.NextButton.UseVisualStyleBackColor=true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Image=global::Metro_Operation.Properties.Resources._32;
            this.PrevButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.PrevButton.Location=new System.Drawing.Point(424, 10);
            this.PrevButton.Margin=new System.Windows.Forms.Padding(0);
            this.PrevButton.Name="PrevButton";
            this.PrevButton.Size=new System.Drawing.Size(84, 28);
            this.PrevButton.TabIndex=51;
            this.PrevButton.Text="ماه قبل";
            this.PrevButton.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.PrevButton.UseVisualStyleBackColor=true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // ShiftOvertimeForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(575, 550);
            this.Controls.Add(this.Panel15);
            this.Controls.Add(this.Panel13);
            this.Controls.Add(this.Panel9);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YearCombo);
            this.Controls.Add(this.MonthCombo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.MonthOverBox);
            this.Controls.Add(this.MonthTimeBox);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.MonthWorkBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Panel14);
            this.Controls.Add(this.Panel12);
            this.Controls.Add(this.Panel11);
            this.Controls.Add(this.Panel10);
            this.Controls.Add(this.Panel18);
            this.Controls.Add(this.Panel17);
            this.Controls.Add(this.Panel8);
            this.Controls.Add(this.Panel16);
            this.Controls.Add(this.Panel7);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ShiftOvertimeForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="اضافه کار شیفت";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ShiftOvertimeForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form21_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel9.ResumeLayout(false);
            this.Panel13.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.Panel10.ResumeLayout(false);
            this.Panel11.ResumeLayout(false);
            this.Panel12.ResumeLayout(false);
            this.Panel14.ResumeLayout(false);
            this.Panel15.ResumeLayout(false);
            this.Panel16.ResumeLayout(false);
            this.Panel17.ResumeLayout(false);
            this.Panel18.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private Panel Panel2;
        private Panel Panel1;
        private Label TextBox02;
        private Label TextBox03;
        private Label TextBox04;
        private Label TextBox05;
        private Panel Panel3;
        private Label A9DaysBox;
        private Label A9TimeBox;
        private Label A9FOverBox;
        private Label A9OverBox;
        private Label A9TotalBox;
        private Panel Panel9;
        private Label Label3;
        private Panel Panel13;
        private Label Label5;
        private Panel Panel4;
        private Label B9DaysBox;
        private Label B9TimeBox;
        private Label B9FOverBox;
        private Label B9OverBox;
        private Label B9TotalBox;
        private Panel Panel5;
        private Label C9DaysBox;
        private Label C9TimeBox;
        private Label C9FOverBox;
        private Label C9OverBox;
        private Label C9TotalBox;
        private Panel Panel6;
        private Label A12DaysBox;
        private Label A12TimeBox;
        private Label A12FOverBox;
        private Label A12OverBox;
        private Label A12TotalBox;
        private Panel Panel7;
        private Label B12DaysBox;
        private Label B12TimeBox;
        private Label B12FOverBox;
        private Label B12OverBox;
        private Label B12TotalBox;
        private Panel Panel8;
        private Label C12DaysBox;
        private Label C12TimeBox;
        private Label C12FOverBox;
        private Label C12OverBox;
        private Label C12TotalBox;
        private Panel Panel10;
        private Label SetDaysBox;
        private Label SetTimeBox;
        private Label SetFOverBox;
        private Label SetOverBox;
        private Label SetTotalBox;
        private Panel Panel11;
        private Label AMDaysBox;
        private Label AMTimeBox;
        private Label AMFOverBox;
        private Label AMOverBox;
        private Label AMTotalBox;
        private Panel Panel12;
        private Label BMDaysBox;
        private Label BMTimeBox;
        private Label BMFOverBox;
        private Label BMOverBox;
        private Label BMTotalBox;
        private Panel Panel14;
        private Label CMDaysBox;
        private Label CMTimeBox;
        private Label CMFOverBox;
        private Label CMOverBox;
        private Label CMTotalBox;
        private Label Label4;
        private Label MonthWorkBox;
        private Label MonthTimeBox;
        private Label Label6;
        private ComboBox YearCombo;
        private ComboBox MonthCombo;
        private Label Label1;
        private Label Label7;
        private Label TextBox00;
        private Label TextBox01;
        private Label TextBox10;
        private Label TextBox11;
        private Label TextBox12;
        private Label TextBox13;
        private Label TextBox14;
        private Label TextBox15;
        private Label TextBox16;
        private Label TextBox17;
        private Label TextBox18;
        private Label TextBox19;
        private Label Label2;
        private Label Label8;
        private Label MonthOverBox;
        private Panel Panel15;
        private Label Label9;
        private Panel Panel16;
        private Label TextBox1;
        private Label AP12DaysBox;
        private Label AP12TimeBox;
        private Label AP12FOverBox;
        private Label AP12OverBox;
        private Label AP12TotalBox;
        private Panel Panel17;
        private Label TextBox7;
        private Label BP12DaysBox;
        private Label BP12TimeBox;
        private Label BP12FOverBox;
        private Label BP12OverBox;
        private Label BP12TotalBox;
        private Panel Panel18;
        private Label TextBox23;
        private Label CP12DaysBox;
        private Label CP12TimeBox;
        private Label CP12FOverBox;
        private Label CP12OverBox;
        private Label CP12TotalBox;
        private Button NextButton;
        private Button PrevButton;
    }
	
}
