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
    partial class TechnicalFunctionRegForm : BaseForm
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
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(TechnicalFunctionRegForm_HelpButtonClicked);
            base.Load += new System.EventHandler(TechnicalFunctionRegForm_Load);
            this.SoozSpeedCheck=new CheckBox();
            this.ATPSpeedCheck=new CheckBox();
            this.RMCheck=new CheckBox();
            this.AlarmCheck=new CheckBox();
            this.MemBox=new RichTextBox();
            this.SignalCheck=new CheckBox();
            this.HighSpeedCheck=new CheckBox();
            this.FaultCheck=new CheckBox();
            this.ATPCheck=new CheckBox();
            this.OtherPoseCheck=new CheckBox();
            this.BlowerCheck=new CheckBox();
            this.BrakeCheck=new CheckBox();
            this.OtherNegaCheck=new CheckBox();
            this.NachCheck=new CheckBox();
            this.NotDoorCheck=new CheckBox();
            this.OpenDoorCheck=new CheckBox();
            this.ArnoCheck=new CheckBox();
            this.Label1=new Label();
            this.Label7=new Label();
            this.LocalCombo=new ComboBox();
            this.Label8=new Label();
            this.Label9=new Label();
            this.Label10=new Label();
            this.LetterBox=new TextBox();
            this.LocoBox=new TextBox();
            this.TimeBox=new MaskedTextBox();
            this.NameBox=new TextBox();
            this.SelectButton=new Button();
            this.SelectButton.Click += new System.EventHandler(this.Button5_Click);
            this.Label2=new Label();
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.ExitButton=new Button();
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.AnalyzerCombo=new ComboBox();
            this.Label4=new Label();
            this.Panel1=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new Panel();
            this.Label6=new Label();
            this.Label5=new Label();
            this.Panel3=new Panel();
            this.Label3=new Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            //
            //SoozSpeedCheck
            //
            this.SoozSpeedCheck.AutoSize=true;
            this.SoozSpeedCheck.Location=new System.Drawing.Point(29, 18);
            this.SoozSpeedCheck.Name="SoozSpeedCheck";
            this.SoozSpeedCheck.Size=new System.Drawing.Size(153, 20);
            this.SoozSpeedCheck.TabIndex=9;
            this.SoozSpeedCheck.Text="سرعت بالا روي سوزنها";
            this.SoozSpeedCheck.UseVisualStyleBackColor=true;
            //
            //ATPSpeedCheck
            //
            this.ATPSpeedCheck.AutoSize=true;
            this.ATPSpeedCheck.Location=new System.Drawing.Point(51, 138);
            this.ATPSpeedCheck.Name="ATPSpeedCheck";
            this.ATPSpeedCheck.Size=new System.Drawing.Size(131, 20);
            this.ATPSpeedCheck.TabIndex=13;
            this.ATPSpeedCheck.Text="عدم رعايت كد ATP";
            this.ATPSpeedCheck.UseVisualStyleBackColor=true;
            //
            //RMCheck
            //
            this.RMCheck.AutoSize=true;
            this.RMCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RMCheck.Location=new System.Drawing.Point(282, 228);
            this.RMCheck.Name="RMCheck";
            this.RMCheck.Size=new System.Drawing.Size(158, 20);
            this.RMCheck.TabIndex=8;
            this.RMCheck.Text="فعال كردن مد RM(تهران)";
            this.RMCheck.UseVisualStyleBackColor=true;
            //
            //AlarmCheck
            //
            this.AlarmCheck.AutoSize=true;
            this.AlarmCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.AlarmCheck.Location=new System.Drawing.Point(269, 198);
            this.AlarmCheck.Name="AlarmCheck";
            this.AlarmCheck.Size=new System.Drawing.Size(171, 20);
            this.AlarmCheck.TabIndex=7;
            this.AlarmCheck.Text="عدم اطلاع رسانی به موقع";
            this.AlarmCheck.UseVisualStyleBackColor=true;
            //
            //MemBox
            //
            this.MemBox.Location=new System.Drawing.Point(21, 307);
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(418, 34);
            this.MemBox.TabIndex=17;
            this.MemBox.Text="";
            //
            //SignalCheck
            //
            this.SignalCheck.AutoSize=true;
            this.SignalCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.SignalCheck.Location=new System.Drawing.Point(249, 78);
            this.SignalCheck.Name="SignalCheck";
            this.SignalCheck.Size=new System.Drawing.Size(191, 20);
            this.SignalCheck.TabIndex=3;
            this.SignalCheck.Text="عبور از چراغ قرمز یا آبی شانت";
            this.SignalCheck.UseVisualStyleBackColor=true;
            //
            //HighSpeedCheck
            //
            this.HighSpeedCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.HighSpeedCheck.Location=new System.Drawing.Point(97, 168);
            this.HighSpeedCheck.Name="HighSpeedCheck";
            this.HighSpeedCheck.Size=new System.Drawing.Size(85, 20);
            this.HighSpeedCheck.TabIndex=14;
            this.HighSpeedCheck.Text="سرعت بالا";
            this.HighSpeedCheck.UseVisualStyleBackColor=true;
            //
            //FaultCheck
            //
            this.FaultCheck.AutoSize=true;
            this.FaultCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.FaultCheck.Location=new System.Drawing.Point(265, 168);
            this.FaultCheck.Name="FaultCheck";
            this.FaultCheck.Size=new System.Drawing.Size(175, 20);
            this.FaultCheck.TabIndex=6;
            this.FaultCheck.Text="مسافرگيري قبل از رفع فالت";
            this.FaultCheck.UseVisualStyleBackColor=true;
            //
            //ATPCheck
            //
            this.ATPCheck.AutoSize=true;
            this.ATPCheck.Location=new System.Drawing.Point(49, 108);
            this.ATPCheck.Name="ATPCheck";
            this.ATPCheck.Size=new System.Drawing.Size(133, 20);
            this.ATPCheck.TabIndex=12;
            this.ATPCheck.Text="خاموش نمودن ATP";
            this.ATPCheck.UseVisualStyleBackColor=true;
            //
            //OtherPoseCheck
            //
            this.OtherPoseCheck.ForeColor=System.Drawing.Color.Green;
            this.OtherPoseCheck.Location=new System.Drawing.Point(86, 198);
            this.OtherPoseCheck.Name="OtherPoseCheck";
            this.OtherPoseCheck.Size=new System.Drawing.Size(96, 20);
            this.OtherPoseCheck.TabIndex=15;
            this.OtherPoseCheck.Text="ساير (مثبت)";
            this.OtherPoseCheck.UseVisualStyleBackColor=true;
            //
            //BlowerCheck
            //
            this.BlowerCheck.AutoSize=true;
            this.BlowerCheck.Location=new System.Drawing.Point(41, 48);
            this.BlowerCheck.Name="BlowerCheck";
            this.BlowerCheck.Size=new System.Drawing.Size(141, 20);
            this.BlowerCheck.TabIndex=10;
            this.BlowerCheck.Text="حركت با بلور خاموش";
            this.BlowerCheck.UseVisualStyleBackColor=true;
            //
            //BrakeCheck
            //
            this.BrakeCheck.AutoSize=true;
            this.BrakeCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.BrakeCheck.Location=new System.Drawing.Point(241, 48);
            this.BrakeCheck.Name="BrakeCheck";
            this.BrakeCheck.Size=new System.Drawing.Size(199, 20);
            this.BrakeCheck.TabIndex=2;
            this.BrakeCheck.Text="عدم استفاده صحيح از ترمز قطار";
            this.BrakeCheck.UseVisualStyleBackColor=true;
            //
            //OtherNegaCheck
            //
            this.OtherNegaCheck.ForeColor=System.Drawing.Color.Red;
            this.OtherNegaCheck.Location=new System.Drawing.Point(83, 228);
            this.OtherNegaCheck.Name="OtherNegaCheck";
            this.OtherNegaCheck.Size=new System.Drawing.Size(99, 20);
            this.OtherNegaCheck.TabIndex=16;
            this.OtherNegaCheck.Text="ساير (منفي)";
            this.OtherNegaCheck.UseVisualStyleBackColor=true;
            //
            //NachCheck
            //
            this.NachCheck.AutoSize=true;
            this.NachCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NachCheck.Location=new System.Drawing.Point(231, 18);
            this.NachCheck.Name="NachCheck";
            this.NachCheck.Size=new System.Drawing.Size(209, 20);
            this.NachCheck.TabIndex=1;
            this.NachCheck.Text="عدم استفاده صحيح از ناچ حركتی";
            this.NachCheck.UseVisualStyleBackColor=true;
            //
            //NotDoorCheck
            //
            this.NotDoorCheck.AutoSize=true;
            this.NotDoorCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NotDoorCheck.Location=new System.Drawing.Point(258, 108);
            this.NotDoorCheck.Name="NotDoorCheck";
            this.NotDoorCheck.Size=new System.Drawing.Size(182, 20);
            this.NotDoorCheck.TabIndex=4;
            this.NotDoorCheck.Text="باز نكردن دربها در طول مسير";
            this.NotDoorCheck.UseVisualStyleBackColor=true;
            //
            //OpenDoorCheck
            //
            this.OpenDoorCheck.AutoSize=true;
            this.OpenDoorCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.OpenDoorCheck.Location=new System.Drawing.Point(258, 138);
            this.OpenDoorCheck.Name="OpenDoorCheck";
            this.OpenDoorCheck.Size=new System.Drawing.Size(182, 20);
            this.OpenDoorCheck.TabIndex=5;
            this.OpenDoorCheck.Text="حركت با درب باز بر روی سکو";
            this.OpenDoorCheck.UseVisualStyleBackColor=true;
            //
            //ArnoCheck
            //
            this.ArnoCheck.AutoSize=true;
            this.ArnoCheck.Location=new System.Drawing.Point(54, 78);
            this.ArnoCheck.Name="ArnoCheck";
            this.ArnoCheck.Size=new System.Drawing.Size(128, 20);
            this.ArnoCheck.TabIndex=11;
            this.ArnoCheck.Text="خاموش نمودن آرنو";
            this.ArnoCheck.UseVisualStyleBackColor=true;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.ForeColor=System.Drawing.Color.Navy;
            this.Label1.Location=new System.Drawing.Point(189, 26);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(60, 16);
            this.Label1.TabIndex=21;
            this.Label1.Text="نام راهبر:";
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.ForeColor=System.Drawing.Color.Navy;
            this.Label7.Location=new System.Drawing.Point(189, 211);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(81, 16);
            this.Label7.TabIndex=28;
            this.Label7.Text="ساعت اعزام:";
            //
            //LocalCombo
            //
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(55, 172);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(125, 24);
            this.LocalCombo.TabIndex=5;
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.ForeColor=System.Drawing.Color.Navy;
            this.Label8.Location=new System.Drawing.Point(189, 174);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(35, 16);
            this.Label8.TabIndex=26;
            this.Label8.Text="مبدا:";
            //
            //Label9
            //
            this.Label9.AutoSize=true;
            this.Label9.ForeColor=System.Drawing.Color.Navy;
            this.Label9.Location=new System.Drawing.Point(189, 248);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(70, 16);
            this.Label9.TabIndex=30;
            this.Label9.Text="شماره لکو:";
            //
            //Label10
            //
            this.Label10.AutoSize=true;
            this.Label10.ForeColor=System.Drawing.Color.Navy;
            this.Label10.Location=new System.Drawing.Point(189, 137);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(75, 16);
            this.Label10.TabIndex=31;
            this.Label10.Text="شماره نامه:";
            //
            //LetterBox
            //
            this.LetterBox.Location=new System.Drawing.Point(55, 135);
            this.LetterBox.Name="LetterBox";
            this.LetterBox.Size=new System.Drawing.Size(125, 23);
            this.LetterBox.TabIndex=4;
            this.LetterBox.TextAlign=HorizontalAlignment.Center;
            //
            //LocoBox
            //
            this.LocoBox.Location=new System.Drawing.Point(117, 247);
            this.LocoBox.Name="LocoBox";
            this.LocoBox.Size=new System.Drawing.Size(63, 23);
            this.LocoBox.TabIndex=7;
            this.LocoBox.TextAlign=HorizontalAlignment.Center;
            //
            //TimeBox
            //
            this.TimeBox.Location=new System.Drawing.Point(117, 210);
            this.TimeBox.Mask="00:00";
            this.TimeBox.Name="TimeBox";
            this.TimeBox.Size=new System.Drawing.Size(63, 23);
            this.TimeBox.TabIndex=6;
            this.TimeBox.TextAlign=HorizontalAlignment.Center;
            this.TimeBox.ValidatingType=typeof(DateTime);
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(53, 23);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(127, 23);
            this.NameBox.TabIndex=0;
            //
            //SelectButton
            //
            this.SelectButton.Location=new System.Drawing.Point(25, 22);
            this.SelectButton.Name="SelectButton";
            this.SelectButton.Size=new System.Drawing.Size(28, 25);
            this.SelectButton.TabIndex=1;
            this.SelectButton.Text="...";
            this.SelectButton.UseVisualStyleBackColor=true;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.ForeColor=System.Drawing.Color.Navy;
            this.Label2.Location=new System.Drawing.Point(189, 100);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(39, 16);
            this.Label2.TabIndex=23;
            this.Label2.Text="تاریخ:";
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.opts_24;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.DialogResult=DialogResult.None;
            this.RegButton.Location=new System.Drawing.Point(169, 11);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(107, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //ExitButton
            //
            this.ExitButton.BackColor=System.Drawing.Color.Tan;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources.close_24;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.None;
            this.ExitButton.Location=new System.Drawing.Point(33, 11);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(107, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            //
            //AnalyzerCombo
            //
            this.AnalyzerCombo.FormattingEnabled=true;
            this.AnalyzerCombo.Location=new System.Drawing.Point(25, 60);
            this.AnalyzerCombo.Name="AnalyzerCombo";
            this.AnalyzerCombo.Size=new System.Drawing.Size(155, 24);
            this.AnalyzerCombo.Sorted=true;
            this.AnalyzerCombo.TabIndex=2;
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.ForeColor=System.Drawing.Color.Navy;
            this.Label4.Location=new System.Drawing.Point(189, 63);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(60, 16);
            this.Label4.TabIndex=33;
            this.Label4.Text="تحلیل گر:";
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.SelectButton);
            this.Panel1.Controls.Add(this.AnalyzerCombo);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.LocoBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.TimeBox);
            this.Panel1.Controls.Add(this.LetterBox);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Location=new System.Drawing.Point(500, 15);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(303, 293);
            this.Panel1.TabIndex=0;
            //
            //PersianCalendar
            //
            this.PersianCalendar.Location=new System.Drawing.Point(55, 97);
            this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.ATPCheck);
            this.Panel2.Controls.Add(this.NachCheck);
            this.Panel2.Controls.Add(this.OtherPoseCheck);
            this.Panel2.Controls.Add(this.BlowerCheck);
            this.Panel2.Controls.Add(this.MemBox);
            this.Panel2.Controls.Add(this.OtherNegaCheck);
            this.Panel2.Controls.Add(this.FaultCheck);
            this.Panel2.Controls.Add(this.ArnoCheck);
            this.Panel2.Controls.Add(this.SignalCheck);
            this.Panel2.Controls.Add(this.HighSpeedCheck);
            this.Panel2.Controls.Add(this.AlarmCheck);
            this.Panel2.Controls.Add(this.ATPSpeedCheck);
            this.Panel2.Controls.Add(this.BrakeCheck);
            this.Panel2.Controls.Add(this.SoozSpeedCheck);
            this.Panel2.Controls.Add(this.RMCheck);
            this.Panel2.Controls.Add(this.NotDoorCheck);
            this.Panel2.Controls.Add(this.OpenDoorCheck);
            this.Panel2.Location=new System.Drawing.Point(16, 15);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(467, 362);
            this.Panel2.TabIndex=1;
            //
            //Label6
            //
            this.Label6.BackColor=System.Drawing.Color.Gold;
            this.Label6.BorderStyle=BorderStyle.FixedSingle;
            this.Label6.Cursor=Cursors.Default;
            this.Label6.Location=new System.Drawing.Point(367, 282);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(72, 22);
            this.Label6.TabIndex=43;
            this.Label6.Text="توضیحات";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(28, 260);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(413, 16);
            this.Label5.TabIndex=24;
            this.Label5.Text="---------------------------------------------------------------------------------" +
                "";
            //
            //Panel3
            //
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Location=new System.Drawing.Point(500, 319);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(303, 58);
            this.Panel3.TabIndex=2;
            //
            //Label3
            //
            this.Label3.BackColor=System.Drawing.Color.Gold;
            this.Label3.BorderStyle=BorderStyle.FixedSingle;
            this.Label3.Cursor=Cursors.Default;
            this.Label3.Location=new System.Drawing.Point(718, 8);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(72, 22);
            this.Label3.TabIndex=44;
            this.Label3.Text="مشخصات";
            this.Label3.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            //
            //TechnicalFunctionRegForm
            //
            this.AcceptButton=this.RegButton;
            this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.SkyBlue;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(817, 392);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TechnicalFunctionRegForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ثبت عملکرد فنی راهبران";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private CheckBox SoozSpeedCheck;
        private CheckBox ATPSpeedCheck;
        private CheckBox RMCheck;
        private CheckBox AlarmCheck;
        private RichTextBox MemBox;
        private CheckBox SignalCheck;
        private CheckBox HighSpeedCheck;
        private CheckBox FaultCheck;
        private Label Label1;
        private Label Label7;
        private ComboBox LocalCombo;
        private Label Label8;
        private Label Label9;
        private Label Label10;
        private TextBox LetterBox;
        private TextBox LocoBox;
        private CheckBox OtherPoseCheck;
        private CheckBox BlowerCheck;
        private CheckBox BrakeCheck;
        private CheckBox OtherNegaCheck;
        private CheckBox NachCheck;
        private CheckBox NotDoorCheck;
        private CheckBox OpenDoorCheck;
        private CheckBox ArnoCheck;
        private MaskedTextBox TimeBox;
        private TextBox NameBox;
        private Button SelectButton;
        private Label Label2;
        private Button RegButton;
        private Button ExitButton;
        private CheckBox ATPCheck;
        private ComboBox AnalyzerCombo;
        private Label Label4;
        private Panel Panel1;
        private Panel Panel2;
        private Panel Panel3;
        private Label Label5;
        private Label Label6;
        private Label Label3;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
    }

}
