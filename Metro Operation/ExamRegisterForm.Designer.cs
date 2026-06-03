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
    public
    partial class ExamRegisterForm : BaseForm
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
            base.Load += new System.EventHandler(ExamRegisterForm_Load);
            this.Panel2=new Panel();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.QuesNumBox=new TextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.LocalCombo=new ComboBox();
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.QuesNumButton=new Button();
            this.QuesNumButton.Click += new System.EventHandler(this.QuesNumButton_Click);
            this.TitrBox=new TextBox();
            this.PostCombo=new ComboBox();
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            this.Label14=new Label();
            this.Label18=new Label();
            this.Label3=new Label();
            this.KindCombo=new ComboBox();
            this.Label17=new Label();
            this.Label8=new Label();
            this.Label4=new Label();
            this.Label7=new Label();
            this.Label1=new Label();
            this.Label2=new Label();
            this.Label6=new Label();
            this.Label5=new Label();
            this.ShiftCombo=new ComboBox();
            this.TimeCombo=new ComboBox();
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            this.AnswerCombo=new ComboBox();
            this.LevelCombo=new ComboBox();
            this.MainPanel=new Panel();
            this.Panel1=new Panel();
            this.ComboBox1=new ComboBox();
            this.Label16=new Label();
            this.Label15=new Label();
            this.Label13=new Label();
            this.Label12=new Label();
            this.Label11=new Label();
            this.Label10=new Label();
            this.TextBox5=new TextBox();
            this.TextBox4=new TextBox();
            this.TextBox3=new TextBox();
            this.TextBox2=new TextBox();
            this.TextBox1=new TextBox();
            this.Button2=new Button();
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.MemBox=new TextBox();
            this.Label9=new Label();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.Silver;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.EndCalendar);
            this.Panel2.Controls.Add(this.QuesNumBox);
            this.Panel2.Controls.Add(this.StartCalendar);
            this.Panel2.Controls.Add(this.LocalCombo);
            this.Panel2.Controls.Add(this.QuesNumButton);
            this.Panel2.Controls.Add(this.TitrBox);
            this.Panel2.Controls.Add(this.PostCombo);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label18);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.KindCombo);
            this.Panel2.Controls.Add(this.Label17);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.ShiftCombo);
            this.Panel2.Controls.Add(this.TimeCombo);
            this.Panel2.Controls.Add(this.AnswerCombo);
            this.Panel2.Controls.Add(this.LevelCombo);
            this.Panel2.Location=new System.Drawing.Point(5, 5);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(765, 135);
            this.Panel2.TabIndex=0;
            //
            //EndCalendar
            //
            this.EndCalendar.Location=new System.Drawing.Point(546, 103);
            this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(125, 23);
            this.EndCalendar.TabIndex=3;
            this.EndCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //QuesNumBox
            //
            this.QuesNumBox.BackColor=System.Drawing.Color.White;
            this.QuesNumBox.Location=new System.Drawing.Point(25, 72);
            this.QuesNumBox.MaxLength=150;
            this.QuesNumBox.Name="QuesNumBox";
            this.QuesNumBox.Size=new System.Drawing.Size(125, 23);
            this.QuesNumBox.TabIndex=9;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(546, 72);
            this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(125, 23);
            this.StartCalendar.TabIndex=2;
            this.StartCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //LocalCombo
            //
            this.LocalCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(294, 8);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(125, 24);
            this.LocalCombo.TabIndex=4;
            //
            //QuesNumButton
            //
            this.QuesNumButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.QuesNumButton.FlatStyle=FlatStyle.Flat;
            this.QuesNumButton.Location=new System.Drawing.Point(25, 101);
            this.QuesNumButton.Name="QuesNumButton";
            this.QuesNumButton.Size=new System.Drawing.Size(125, 27);
            this.QuesNumButton.TabIndex=11;
            this.QuesNumButton.Text="نمایش";
            this.QuesNumButton.UseVisualStyleBackColor=false;
            //
            //TitrBox
            //
            this.TitrBox.BackColor=System.Drawing.Color.White;
            this.TitrBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.TitrBox.Location=new System.Drawing.Point(546, 9);
            this.TitrBox.MaxLength=150;
            this.TitrBox.Name="TitrBox";
            this.TitrBox.Size=new System.Drawing.Size(125, 23);
            this.TitrBox.TabIndex=0;
            //
            //PostCombo
            //
            this.PostCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.PostCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.PostCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.PostCombo.FormattingEnabled=true;
            this.PostCombo.Location=new System.Drawing.Point(294, 40);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(125, 24);
            this.PostCombo.TabIndex=5;
            //
            //Label14
            //
            this.Label14.AutoSize=true;
            this.Label14.Location=new System.Drawing.Point(150, 75);
            this.Label14.Margin=new Padding(3);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(84, 16);
            this.Label14.TabIndex=91;
            this.Label14.Text="تعداد سوالات:";
            //
            //Label18
            //
            this.Label18.AutoSize=true;
            this.Label18.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label18.Location=new System.Drawing.Point(151, 44);
            this.Label18.Margin=new Padding(3);
            this.Label18.Name="Label18";
            this.Label18.Size=new System.Drawing.Size(65, 16);
            this.Label18.TabIndex=83;
            this.Label18.Text="نوع نتیجه:";
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label3.Location=new System.Drawing.Point(150, 12);
            this.Label3.Margin=new Padding(3);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(88, 16);
            this.Label3.TabIndex=83;
            this.Label3.Text="اولویت نمایش:";
            //
            //KindCombo
            //
            this.KindCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.KindCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] { "نظر سنجی", "آزمون" });
            this.KindCombo.Location=new System.Drawing.Point(546, 40);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(125, 24);
            this.KindCombo.TabIndex=1;
            //
            //Label17
            //
            this.Label17.AutoSize=true;
            this.Label17.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label17.Location=new System.Drawing.Point(671, 106);
            this.Label17.Margin=new Padding(3);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(68, 16);
            this.Label17.TabIndex=80;
            this.Label17.Text="تاریخ پایان:";
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label8.Location=new System.Drawing.Point(419, 12);
            this.Label8.Margin=new Padding(3);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(40, 16);
            this.Label8.TabIndex=93;
            this.Label8.Text="مبداء:";
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label4.Location=new System.Drawing.Point(671, 75);
            this.Label4.Margin=new Padding(3);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(74, 16);
            this.Label4.TabIndex=80;
            this.Label4.Text="تاریخ شروع:";
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label7.Location=new System.Drawing.Point(419, 106);
            this.Label7.Margin=new Padding(3);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(70, 16);
            this.Label7.TabIndex=91;
            this.Label7.Text="نام شیفت:";
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label1.Location=new System.Drawing.Point(671, 44);
            this.Label1.Margin=new Padding(3);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(70, 16);
            this.Label1.TabIndex=81;
            this.Label1.Text="نوع سئوال:";
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label2.Location=new System.Drawing.Point(419, 44);
            this.Label2.Margin=new Padding(3);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(97, 16);
            this.Label2.TabIndex=82;
            this.Label2.Text="پست سازمانی:";
            //
            //Label6
            //
            this.Label6.AutoSize=true;
            this.Label6.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label6.Location=new System.Drawing.Point(419, 75);
            this.Label6.Margin=new Padding(3);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(72, 16);
            this.Label6.TabIndex=89;
            this.Label6.Text="نوع شیفت:";
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label5.Location=new System.Drawing.Point(671, 12);
            this.Label5.Margin=new Padding(3);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(44, 16);
            this.Label5.TabIndex=87;
            this.Label5.Text="عنوان:";
            //
            //ShiftCombo
            //
            this.ShiftCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Location=new System.Drawing.Point(294, 102);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(125, 24);
            this.ShiftCombo.TabIndex=7;
            //
            //TimeCombo
            //
            this.TimeCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.TimeCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Location=new System.Drawing.Point(294, 71);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(125, 24);
            this.TimeCombo.TabIndex=6;
            //
            //AnswerCombo
            //
            this.AnswerCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.AnswerCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.AnswerCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.AnswerCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.AnswerCombo.FormattingEnabled=true;
            this.AnswerCombo.Items.AddRange(new object[] { "عمومی", "محرمانه" });
            this.AnswerCombo.Location=new System.Drawing.Point(25, 40);
            this.AnswerCombo.Name="AnswerCombo";
            this.AnswerCombo.Size=new System.Drawing.Size(125, 24);
            this.AnswerCombo.TabIndex=10;
            //
            //LevelCombo
            //
            this.LevelCombo.AutoCompleteMode=AutoCompleteMode.Suggest;
            this.LevelCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.LevelCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LevelCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.LevelCombo.FormattingEnabled=true;
            this.LevelCombo.Items.AddRange(new object[] { "اختیاری", "اجباری" });
            this.LevelCombo.Location=new System.Drawing.Point(25, 8);
            this.LevelCombo.Name="LevelCombo";
            this.LevelCombo.Size=new System.Drawing.Size(125, 24);
            this.LevelCombo.TabIndex=8;
            //
            //MainPanel
            //
            this.MainPanel.AutoScroll=true;
            this.MainPanel.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
            this.MainPanel.BorderStyle=BorderStyle.FixedSingle;
            this.MainPanel.Location=new System.Drawing.Point(14, 183);
            this.MainPanel.Name="MainPanel";
            this.MainPanel.Size=new System.Drawing.Size(747, 3);
            this.MainPanel.TabIndex=3;
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightSteelBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.ComboBox1);
            this.Panel1.Controls.Add(this.Label16);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.TextBox5);
            this.Panel1.Controls.Add(this.TextBox4);
            this.Panel1.Controls.Add(this.TextBox3);
            this.Panel1.Controls.Add(this.TextBox2);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Location=new System.Drawing.Point(20, 193);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(735, 90);
            this.Panel1.TabIndex=2;
            this.Panel1.Visible=false;
            //
            //ComboBox1
            //
            this.ComboBox1.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled=true;
            this.ComboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            this.ComboBox1.Location=new System.Drawing.Point(10, 15);
            this.ComboBox1.Name="ComboBox1";
            this.ComboBox1.Size=new System.Drawing.Size(85, 24);
            this.ComboBox1.TabIndex=1;
            //
            //Label16
            //
            this.Label16.AutoSize=true;
            this.Label16.Location=new System.Drawing.Point(95, 20);
            this.Label16.Margin=new Padding(3);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(77, 16);
            this.Label16.TabIndex=0;
            this.Label16.Text="گزینه صحیح:";
            //
            //Label15
            //
            this.Label15.AutoSize=true;
            this.Label15.Location=new System.Drawing.Point(120, 60);
            this.Label15.Margin=new Padding(3);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(51, 16);
            this.Label15.TabIndex=0;
            this.Label15.Text="گزینه 4)";
            //
            //Label13
            //
            this.Label13.AutoSize=true;
            this.Label13.Location=new System.Drawing.Point(290, 60);
            this.Label13.Margin=new Padding(3);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(51, 16);
            this.Label13.TabIndex=0;
            this.Label13.Text="گزینه 3)";
            //
            //Label12
            //
            this.Label12.AutoSize=true;
            this.Label12.Location=new System.Drawing.Point(480, 60);
            this.Label12.Margin=new Padding(3);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(51, 16);
            this.Label12.TabIndex=0;
            this.Label12.Text="گزینه 2)";
            //
            //Label11
            //
            this.Label11.AutoSize=true;
            this.Label11.Location=new System.Drawing.Point(670, 60);
            this.Label11.Margin=new Padding(3);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(51, 16);
            this.Label11.TabIndex=0;
            this.Label11.Text="گزینه 1)";
            //
            //Label10
            //
            this.Label10.AutoSize=true;
            this.Label10.Location=new System.Drawing.Point(670, 20);
            this.Label10.Margin=new Padding(3);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(61, 16);
            this.Label10.TabIndex=0;
            this.Label10.Text="سوال 10)";
            //
            //TextBox5
            //
            this.TextBox5.BackColor=System.Drawing.Color.White;
            this.TextBox5.Location=new System.Drawing.Point(10, 57);
            this.TextBox5.MaxLength=150;
            this.TextBox5.Name="TextBox5";
            this.TextBox5.Size=new System.Drawing.Size(110, 23);
            this.TextBox5.TabIndex=0;
            //
            //TextBox4
            //
            this.TextBox4.BackColor=System.Drawing.Color.White;
            this.TextBox4.Location=new System.Drawing.Point(180, 57);
            this.TextBox4.MaxLength=150;
            this.TextBox4.Name="TextBox4";
            this.TextBox4.Size=new System.Drawing.Size(110, 23);
            this.TextBox4.TabIndex=0;
            //
            //TextBox3
            //
            this.TextBox3.BackColor=System.Drawing.Color.White;
            this.TextBox3.Location=new System.Drawing.Point(370, 57);
            this.TextBox3.MaxLength=150;
            this.TextBox3.Name="TextBox3";
            this.TextBox3.Size=new System.Drawing.Size(110, 23);
            this.TextBox3.TabIndex=0;
            //
            //TextBox2
            //
            this.TextBox2.BackColor=System.Drawing.Color.White;
            this.TextBox2.Location=new System.Drawing.Point(560, 57);
            this.TextBox2.MaxLength=150;
            this.TextBox2.Name="TextBox2";
            this.TextBox2.Size=new System.Drawing.Size(110, 23);
            this.TextBox2.TabIndex=0;
            //
            //TextBox1
            //
            this.TextBox1.BackColor=System.Drawing.Color.White;
            this.TextBox1.Location=new System.Drawing.Point(180, 8);
            this.TextBox1.MaxLength=150;
            this.TextBox1.Multiline=true;
            this.TextBox1.Name="TextBox1";
            this.TextBox1.Size=new System.Drawing.Size(490, 40);
            this.TextBox1.TabIndex=0;
            this.TextBox1.Text="تست1" + "تست2" + "تست3";
            //
            //Button2
            //
            this.Button2.Enabled=false;
            this.Button2.Location=new System.Drawing.Point(34, 149);
            this.Button2.Name="Button2";
            this.Button2.Size=new System.Drawing.Size(123, 25);
            this.Button2.TabIndex=100;
            this.Button2.Text="ذخیره";
            this.Button2.UseVisualStyleBackColor=true;
            //
            //MemBox
            //
            this.MemBox.BackColor=System.Drawing.Color.White;
            this.MemBox.Location=new System.Drawing.Point(163, 145);
            this.MemBox.MaxLength=150;
            this.MemBox.Multiline=true;
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(528, 32);
            this.MemBox.TabIndex=1;
            //
            //Label9
            //
            this.Label9.AutoSize=true;
            this.Label9.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label9.Location=new System.Drawing.Point(691, 153);
            this.Label9.Margin=new Padding(3);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(62, 16);
            this.Label9.TabIndex=87;
            this.Label9.Text="توضیحات:";
            //
            //ExamRegisterForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(774, 291);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.MemBox);
            this.Controls.Add(this.Label9);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ExamRegisterForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="نظر سنجی";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel Panel2;
        private ComboBox LocalCombo;
        private TextBox TitrBox;
        private ComboBox ShiftCombo;
        private ComboBox TimeCombo;
        private ComboBox PostCombo;
        private ComboBox KindCombo;
        private ComboBox LevelCombo;
        private Label Label8;
        private Label Label4;
        private Label Label7;
        private Label Label1;
        private Label Label2;
        private Label Label6;
        private Label Label3;
        private Label Label5;
        private Panel MainPanel;
        private Button QuesNumButton;
        private Button Button2;
        private Label Label14;
        private TextBox QuesNumBox;
        private Panel Panel1;
        private Label Label10;
        private TextBox TextBox4;
        private TextBox TextBox3;
        private TextBox TextBox2;
        private TextBox TextBox1;
        private ComboBox ComboBox1;
        private Label Label16;
        private Label Label15;
        private Label Label13;
        private Label Label12;
        private Label Label11;
        private TextBox TextBox5;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private Label Label17;
        private Label Label18;
        private ComboBox AnswerCombo;
        private TextBox MemBox;
        private Label Label9;
    }

}
