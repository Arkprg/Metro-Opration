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
	partial class FaultsRegisterForm : BaseForm
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
			base.Load += new System.EventHandler(FaultsRegForm_Load);
			this.Label1=new Label();
			this.E_TimeMaskedTextBox=new MaskedTextBox();
			this.Label8=new Label();
			this.LocoTextBox=new TextBox();
			this.FaultsComboBox=new ComboBox();
			this.Label7=new Label();
			this.Label9=new Label();
			this.TextBox3=new TextBox();
			this.Label2=new Label();
			this.R_NameTextBox=new TextBox();
			this.R_SelectButton=new Button();
			this.R_SelectButton.Click += new System.EventHandler(this.R_SelectButton_Click);
			this.Label10=new Label();
			this.Label3=new Label();
			this.T_TimeMaskedTextBox=new MaskedTextBox();
			this.T_ShiftTextBox=new TextBox();
			this.Label5=new Label();
			this.Label6=new Label();
			this.LocalCombo=new ComboBox();
			this.RegButton=new Button();
			this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
			this.T_ShiftComboBox=new ComboBox();
			this.Label11=new Label();
			this.CancelCheckBox=new CheckBox();
			this.CancelCheckBox.CheckedChanged += new System.EventHandler(this.CancelCheckBox_CheckedChanged);
			this.EmptyCheckBox=new CheckBox();
			this.EmptyCheckBox.CheckedChanged += new System.EventHandler(this.EmptyCheckBox_CheckedChanged);
			this.Label12=new Label();
			this.Label4=new Label();
			this.RichTextBox1=new RichTextBox();
			this.CancelButton1=new Button();
			this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
			this.TextBox2=new TextBox();
			this.Label14=new Label();
			this.TextBox1=new TextBox();
			this.Label13=new Label();
			this.Panel1=new Panel();
			this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Label15=new Label();
			this.Panel2=new Panel();
			this.Panel3=new Panel();
			this.Panel4=new Panel();
			this.Label16=new Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label1.Location=new System.Drawing.Point(304, 83);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(39, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="تاریخ:";
			//
			//E_TimeMaskedTextBox
			//
			this.E_TimeMaskedTextBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.E_TimeMaskedTextBox.Location=new System.Drawing.Point(38, 80);
			this.E_TimeMaskedTextBox.Mask="00:00";
			this.E_TimeMaskedTextBox.Name="E_TimeMaskedTextBox";
			this.E_TimeMaskedTextBox.Size=new System.Drawing.Size(51, 23);
			this.E_TimeMaskedTextBox.TabIndex=4;
			this.E_TimeMaskedTextBox.TextAlign=HorizontalAlignment.Center;
			this.E_TimeMaskedTextBox.ValidatingType=typeof(DateTime);
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label8.Location=new System.Drawing.Point(509, 34);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(57, 16);
			this.Label8.TabIndex=48;
			this.Label8.Text="نوع خطا:";
			//
			//LocoTextBox
			//
			this.LocoTextBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocoTextBox.Location=new System.Drawing.Point(293, 131);
			this.LocoTextBox.Name="LocoTextBox";
			this.LocoTextBox.Size=new System.Drawing.Size(46, 23);
			this.LocoTextBox.TabIndex=6;
			this.LocoTextBox.TextAlign=HorizontalAlignment.Center;
			//
			//FaultsComboBox
			//
			this.FaultsComboBox.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FaultsComboBox.FormattingEnabled=true;
			this.FaultsComboBox.Items.AddRange(new object[] {"اتصالات پنوماتيك بين لكوموتيو و واگنها", "ايرادات مدار راه و Interlocking و مسير سازي", "ايركانديشن راهبر و اينورتر مربوطه و هيترهاي ديواري", "اينورتر اصلي", "بوژي ( چرخ، محور، گيربكس، دمپر، بالشتك)", "پانتوگراف و تجهيزات روي سقف لكوموتيو", "تجهيزات ايمني (كپسول ها، ميله ارت،كفشخط ، JPS)", "تجهيزات كابين راهبر (پرده، صندلي، شيشه، برف پاكن، دوربين، ميله آويز لباس...)", "تجهيزات كنسول كابين راهبر (گيج هاي: سرعت ،ولتاژ، جريان، كليد هاي پيانوي، هندل مار" +
				"ش، ناچ)", "تجهيزات واگن (شيشه، صندلي، روشنايي، تهويه)", "تراكشن موتورها و مدارات مربوطه  (درام هاي حركتي، كنتاكتورهاي الكتروپنوماتيك)", "ترانس اصلي", "ترمز قطار (الكتروپنوماتيك، هوايي، ديناميك، پارك، BCU , BLCU، ترمز اضطراري)", "خطا هايFault indicator (  . . .P.P - C.V - A.E - M - ME1)", "درب واگن ها (درب، دستگيره اضطراري، ميكروكامپيوتر درب ها، Doorcontrol)", "روشنايي كابين و لكوموتيو (H.lamp - M.lamp - Aux لامپ هاي كريدور)", "سيستم ATP و تجهيزات مربوطه ( سنسورها، صفحه  HMI ، STADS ،VISU2 ،VISU1 وساعت HMI)", "سيستم اطلاع رساني مسافري، PIS و PA", "سيستم بيسيم", "كابلها و اتصالات الكتريكي بين لكوموتيو و واگنها", "كامپيوتر لكوموتيو( IDU, CCU, TCU, LCU)", "كليد MCB و مدارات مربوطه", "كليد ها (مينياتوري، اتوسوئيچ، چاقويي، خروسكي، سلكتوري)", "كمپرسورهاي اصلي و كمكي و ادوات هواي فشرده.", "مدارات كمكي 380 ولت (آرنو، موتورهاي كمكي)", "مدارات كنترل 110 ولت (باتري، شارژر)", "موارد مربوط به ريل و سوزن ها", "موارد مربوط به شبكه بالا سري و تجهيزات مرتبط", "ساير موارد"});
			this.FaultsComboBox.Location=new System.Drawing.Point(38, 28);
			this.FaultsComboBox.Name="FaultsComboBox";
			this.FaultsComboBox.Size=new System.Drawing.Size(471, 22);
			this.FaultsComboBox.TabIndex=1;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label7.Location=new System.Drawing.Point(90, 83);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(81, 16);
			this.Label7.TabIndex=49;
			this.Label7.Text="ساعت اعزام:";
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label9.Location=new System.Drawing.Point(340, 134);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(70, 16);
			this.Label9.TabIndex=50;
			this.Label9.Text="شماره لکو:";
			//
			//TextBox3
			//
			this.TextBox3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TextBox3.Location=new System.Drawing.Point(314, 154);
			this.TextBox3.Name="TextBox3";
			this.TextBox3.Size=new System.Drawing.Size(100, 23);
			this.TextBox3.TabIndex=6;
			this.TextBox3.TextAlign=HorizontalAlignment.Center;
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label2.Location=new System.Drawing.Point(509, 83);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(60, 16);
			this.Label2.TabIndex=54;
			this.Label2.Text="نام راهبر:";
			//
			//R_NameTextBox
			//
			this.R_NameTextBox.BackColor=System.Drawing.SystemColors.Window;
			this.R_NameTextBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.R_NameTextBox.Location=new System.Drawing.Point(382, 80);
			this.R_NameTextBox.Name="R_NameTextBox";
			this.R_NameTextBox.ReadOnly=true;
			this.R_NameTextBox.Size=new System.Drawing.Size(127, 23);
			this.R_NameTextBox.TabIndex=51;
			this.R_NameTextBox.TabStop=false;
			//
			//R_SelectButton
			//
			this.R_SelectButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.R_SelectButton.Location=new System.Drawing.Point(353, 79);
			this.R_SelectButton.Name="R_SelectButton";
			this.R_SelectButton.Size=new System.Drawing.Size(28, 25);
			this.R_SelectButton.TabIndex=2;
			this.R_SelectButton.Text="...";
			this.R_SelectButton.UseVisualStyleBackColor=true;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label10.Location=new System.Drawing.Point(418, 157);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(75, 16);
			this.Label10.TabIndex=55;
			this.Label10.Text="شماره نامه:";
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.Location=new System.Drawing.Point(460, 32);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(102, 16);
			this.Label3.TabIndex=49;
			this.Label3.Text="اعلام به تعمیرات:";
			//
			//T_TimeMaskedTextBox
			//
			this.T_TimeMaskedTextBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.T_TimeMaskedTextBox.Location=new System.Drawing.Point(409, 30);
			this.T_TimeMaskedTextBox.Mask="00:00";
			this.T_TimeMaskedTextBox.Name="T_TimeMaskedTextBox";
			this.T_TimeMaskedTextBox.Size=new System.Drawing.Size(51, 23);
			this.T_TimeMaskedTextBox.TabIndex=1;
			this.T_TimeMaskedTextBox.TextAlign=HorizontalAlignment.Center;
			this.T_TimeMaskedTextBox.ValidatingType=typeof(DateTime);
			//
			//T_ShiftTextBox
			//
			this.T_ShiftTextBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.T_ShiftTextBox.Location=new System.Drawing.Point(175, 30);
			this.T_ShiftTextBox.Name="T_ShiftTextBox";
			this.T_ShiftTextBox.Size=new System.Drawing.Size(130, 23);
			this.T_ShiftTextBox.TabIndex=2;
			this.T_ShiftTextBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.Location=new System.Drawing.Point(305, 32);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(92, 16);
			this.Label5.TabIndex=50;
			this.Label5.Text="همکار تعمیرات:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label6.Location=new System.Drawing.Point(509, 136);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(35, 16);
			this.Label6.TabIndex=57;
			this.Label6.Text="مبدا:";
			//
			//LocalCombo
			//
			this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LocalCombo.FormattingEnabled=true;
			this.LocalCombo.Location=new System.Drawing.Point(418, 131);
			this.LocalCombo.Name="LocalCombo";
			this.LocalCombo.Size=new System.Drawing.Size(94, 24);
			this.LocalCombo.Sorted=true;
			this.LocalCombo.TabIndex=5;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=global::Metro_Operation.Properties.Resources.opts_24;
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			this.RegButton.DialogResult=DialogResult.None;
			this.RegButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RegButton.Location=new System.Drawing.Point(128, 10);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(107, 34);
			this.RegButton.TabIndex=8;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//T_ShiftComboBox
			//
			this.T_ShiftComboBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.T_ShiftComboBox.FormattingEnabled=true;
			this.T_ShiftComboBox.Location=new System.Drawing.Point(21, 29);
			this.T_ShiftComboBox.Name="T_ShiftComboBox";
			this.T_ShiftComboBox.Size=new System.Drawing.Size(52, 24);
			this.T_ShiftComboBox.Sorted=true;
			this.T_ShiftComboBox.TabIndex=3;
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label11.Location=new System.Drawing.Point(75, 32);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(96, 16);
			this.Label11.TabIndex=57;
			this.Label11.Text="شیفت تعمیرات:";
			//
			//CancelCheckBox
			//
			this.CancelCheckBox.AutoSize=true;
			this.CancelCheckBox.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.CancelCheckBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CancelCheckBox.Location=new System.Drawing.Point(179, 132);
			this.CancelCheckBox.Name="CancelCheckBox";
			this.CancelCheckBox.Size=new System.Drawing.Size(106, 20);
			this.CancelCheckBox.TabIndex=7;
			this.CancelCheckBox.Text="کنسلی حرکت";
			this.CancelCheckBox.UseVisualStyleBackColor=true;
			//
			//EmptyCheckBox
			//
			this.EmptyCheckBox.AutoSize=true;
			this.EmptyCheckBox.CheckAlign=System.Drawing.ContentAlignment.MiddleRight;
			this.EmptyCheckBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.EmptyCheckBox.Location=new System.Drawing.Point(39, 132);
			this.EmptyCheckBox.Name="EmptyCheckBox";
			this.EmptyCheckBox.Size=new System.Drawing.Size(107, 20);
			this.EmptyCheckBox.TabIndex=8;
			this.EmptyCheckBox.Text="تخلیه مسافری";
			this.EmptyCheckBox.UseVisualStyleBackColor=true;
			//
			//Label12
			//
			this.Label12.AutoSize=true;
			this.Label12.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label12.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.Label12.Location=new System.Drawing.Point(38, 173);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(235, 14);
			this.Label12.TabIndex=64;
			this.Label12.Text="در صورت تخلیه مسافری نام ایستگاه ذکر گردد";
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(483, 172);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(62, 16);
			this.Label4.TabIndex=62;
			this.Label4.Text="توضیحات:";
			//
			//RichTextBox1
			//
			this.RichTextBox1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RichTextBox1.Location=new System.Drawing.Point(34, 192);
			this.RichTextBox1.Name="RichTextBox1";
			this.RichTextBox1.Size=new System.Drawing.Size(523, 51);
			this.RichTextBox1.TabIndex=9;
			this.RichTextBox1.Text="";
			//
			//CancelButton1
			//
			this.CancelButton1.BackColor=System.Drawing.Color.Tan;
			this.CancelButton1.Image=global::Metro_Operation.Properties.Resources.close_24;
			this.CancelButton1.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.CancelButton1.Cursor=Cursors.Hand;
			this.CancelButton1.DialogResult=DialogResult.None;
			this.CancelButton1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CancelButton1.Location=new System.Drawing.Point(15, 10);
			this.CancelButton1.Name="CancelButton1";
			this.CancelButton1.Size=new System.Drawing.Size(107, 34);
			this.CancelButton1.TabIndex=9;
			this.CancelButton1.Text="انصراف";
			this.CancelButton1.UseVisualStyleBackColor=false;
			//
			//TextBox2
			//
			this.TextBox2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TextBox2.Location=new System.Drawing.Point(314, 114);
			this.TextBox2.Name="TextBox2";
			this.TextBox2.Size=new System.Drawing.Size(100, 23);
			this.TextBox2.TabIndex=5;
			this.TextBox2.TextAlign=HorizontalAlignment.Center;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label14.Location=new System.Drawing.Point(418, 117);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(151, 14);
			this.Label14.TabIndex=61;
			this.Label14.Text="ثبت کننده سامانه خرابی ها:";
			//
			//TextBox1
			//
			this.TextBox1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TextBox1.Location=new System.Drawing.Point(314, 74);
			this.TextBox1.Name="TextBox1";
			this.TextBox1.Size=new System.Drawing.Size(100, 23);
			this.TextBox1.TabIndex=4;
			this.TextBox1.TextAlign=HorizontalAlignment.Center;
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label13.Location=new System.Drawing.Point(418, 77);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(135, 14);
			this.Label13.TabIndex=59;
			this.Label13.Text="شماره سامانه خرابی ها:";
			//
			//Panel1
			//
			this.Panel1.BackColor=System.Drawing.Color.LightBlue;
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.PersianCalendar);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.R_SelectButton);
			this.Panel1.Controls.Add(this.RichTextBox1);
			this.Panel1.Controls.Add(this.R_NameTextBox);
			this.Panel1.Controls.Add(this.FaultsComboBox);
			this.Panel1.Controls.Add(this.E_TimeMaskedTextBox);
			this.Panel1.Controls.Add(this.EmptyCheckBox);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.CancelCheckBox);
			this.Panel1.Controls.Add(this.LocalCombo);
			this.Panel1.Controls.Add(this.LocoTextBox);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Location=new System.Drawing.Point(22, 20);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(584, 267);
			this.Panel1.TabIndex=0;
			//
			//PersianCalendar
			//
			this.PersianCalendar.Location=new System.Drawing.Point(179, 80);
			this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.PersianCalendar.Name="PersianCalendar";
			this.PersianCalendar.NowDateSelected=true;
			this.PersianCalendar.ReadOnly=true;
			this.PersianCalendar.SelectedDate=null;
			this.PersianCalendar.Shamsi=null;
			this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
			this.PersianCalendar.TabIndex=97;
			this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Label15
			//
			this.Label15.BackColor=System.Drawing.Color.Gold;
			this.Label15.BorderStyle=BorderStyle.FixedSingle;
			this.Label15.Cursor=Cursors.Default;
			this.Label15.Location=new System.Drawing.Point(483, 9);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(110, 22);
			this.Label15.TabIndex=68;
			this.Label15.Text="داده های اولیه";
			this.Label15.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//Panel2
			//
			this.Panel2.BackColor=System.Drawing.Color.LightBlue;
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Controls.Add(this.T_TimeMaskedTextBox);
			this.Panel2.Controls.Add(this.T_ShiftTextBox);
			this.Panel2.Controls.Add(this.TextBox2);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.Label14);
			this.Panel2.Controls.Add(this.Label10);
			this.Panel2.Controls.Add(this.TextBox1);
			this.Panel2.Controls.Add(this.TextBox3);
			this.Panel2.Controls.Add(this.Label13);
			this.Panel2.Controls.Add(this.T_ShiftComboBox);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.Panel4);
			this.Panel2.Controls.Add(this.Label11);
			this.Panel2.Location=new System.Drawing.Point(22, 307);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(584, 200);
			this.Panel2.TabIndex=1;
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.SystemColors.ScrollBar;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.CancelButton1);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Location=new System.Drawing.Point(20, 111);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(251, 58);
			this.Panel3.TabIndex=7;
			//
			//Panel4
			//
			this.Panel4.BackColor=System.Drawing.Color.Black;
			this.Panel4.Location=new System.Drawing.Point(14, 122);
			this.Panel4.Name="Panel4";
			this.Panel4.Size=new System.Drawing.Size(248, 55);
			this.Panel4.TabIndex=72;
			//
			//Label16
			//
			this.Label16.BackColor=System.Drawing.Color.Lime;
			this.Label16.BorderStyle=BorderStyle.FixedSingle;
			this.Label16.Cursor=Cursors.Default;
			this.Label16.Location=new System.Drawing.Point(483, 294);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(110, 22);
			this.Label16.TabIndex=70;
			this.Label16.Text="اطلاعات تکمیلی";
			this.Label16.TextAlign=System.Drawing.ContentAlignment.TopCenter;
			//
			//FaultsRegisterForm
			//
			this.AcceptButton=this.RegButton;
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.BackColor=System.Drawing.Color.SkyBlue;
			this.CancelButton=this.CancelButton1;
			this.ClientSize=new System.Drawing.Size(625, 526);
			this.Controls.Add(this.Label16);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.Panel1);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.HelpButton=true;
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="FaultsRegisterForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت خرابی های قطار";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		private Label Label1;
		private MaskedTextBox E_TimeMaskedTextBox;
		private Label Label8;
		private TextBox LocoTextBox;
		private ComboBox FaultsComboBox;
		private Label Label7;
		private Label Label9;
		private TextBox TextBox3;
		private Label Label2;
		private TextBox R_NameTextBox;
		private Button R_SelectButton;
		private Label Label10;
		private Label Label3;
		private MaskedTextBox T_TimeMaskedTextBox;
		private TextBox T_ShiftTextBox;
		private Label Label5;
		private Label Label6;
		private ComboBox LocalCombo;
		private Button RegButton;
		private ComboBox T_ShiftComboBox;
		private Label Label11;
		private CheckBox CancelCheckBox;
		private CheckBox EmptyCheckBox;
		private Label Label12;
		private Label Label4;
		private RichTextBox RichTextBox1;
		private Button CancelButton1;
		private TextBox TextBox2;
		private Label Label14;
		private TextBox TextBox1;
		private Label Label13;
		private Panel Panel1;
		private Label Label15;
		private Panel Panel2;
		private Label Label16;
		private Panel Panel3;
		private Panel Panel4;
		private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
	}
	
}
