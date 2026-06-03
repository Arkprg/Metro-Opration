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
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class TechnicalFunctionEditForm : BaseForm
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

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TechnicalFunctionEditForm));
            this.SearchNameBox=new TextBox();
            this.SearchNameButton=new Button();
            this.SearchTimeBox=new MaskedTextBox();
            this.SearchLocoBox=new TextBox();
            this.Label9=new Label();
            this.Label7=new Label();
            this.SearchLocalCombo=new ComboBox();
            this.Label8=new Label();
            this.Label2=new Label();
            this.Label1=new Label();
            this.SearchButton=new Button();
            this.SearchLetterBox=new TextBox();
            this.Label10=new Label();
            this.AnalyzerCombo=new ComboBox();
            this.Label14=new Label();
            this.DeletButton=new Button();
            this.ExitButton=new Button();
            this.RegButton=new Button();
            this.NameBox=new TextBox();
            this.NameButton=new Button();
            this.TimeBox=new MaskedTextBox();
            this.LocoBox=new TextBox();
            this.LetterBox=new TextBox();
            this.Label4=new Label();
            this.Label5=new Label();
            this.Label6=new Label();
            this.LocalCombo=new ComboBox();
            this.Label11=new Label();
            this.ATPCheck=new CheckBox();
            this.OtherPoseCheck=new CheckBox();
            this.BlowerCheck=new CheckBox();
            this.BerakeCheck=new CheckBox();
            this.OtherNegaCheck=new CheckBox();
            this.NachCheck=new CheckBox();
            this.NotDoorCheck=new CheckBox();
            this.OpenDoorCheck=new CheckBox();
            this.ArnoCheck=new CheckBox();
            this.MemBox=new RichTextBox();
            this.RMCheck=new CheckBox();
            this.SoozSpeedCheck=new CheckBox();
            this.HighSpeedCheck=new CheckBox();
            this.AlarmCheck=new CheckBox();
            this.SignalCheck=new CheckBox();
            this.ATPSpeedCheck=new CheckBox();
            this.FaultCheck=new CheckBox();
            this.Label12=new Label();
            this.Label13=new Label();
            this.Panel1=new Panel();
            this.SearchPersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel3=new Panel();
            this.Label17=new Label();
            this.Label16=new Label();
            this.Panel2=new Panel();
            this.Panel4=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel5=new Panel();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchNameBox
            // 
            this.SearchNameBox.BackColor=System.Drawing.SystemColors.Window;
            this.SearchNameBox.Location=new System.Drawing.Point(38, 20);
            this.SearchNameBox.Name="SearchNameBox";
            this.SearchNameBox.ReadOnly=true;
            this.SearchNameBox.Size=new System.Drawing.Size(127, 23);
            this.SearchNameBox.TabIndex=32;
            // 
            // SearchNameButton
            // 
            this.SearchNameButton.Image=((System.Drawing.Image)(resources.GetObject("SearchNameButton.Image")));
            this.SearchNameButton.Location=new System.Drawing.Point(8, 16);
            this.SearchNameButton.Name="SearchNameButton";
            this.SearchNameButton.Size=new System.Drawing.Size(30, 31);
            this.SearchNameButton.TabIndex=1;
            this.SearchNameButton.UseVisualStyleBackColor=true;
            this.SearchNameButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // SearchTimeBox
            // 
            this.SearchTimeBox.Location=new System.Drawing.Point(114, 173);
            this.SearchTimeBox.Mask="00:00";
            this.SearchTimeBox.Name="SearchTimeBox";
            this.SearchTimeBox.Size=new System.Drawing.Size(51, 23);
            this.SearchTimeBox.TabIndex=6;
            this.SearchTimeBox.TextAlign=HorizontalAlignment.Center;
            this.SearchTimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // SearchLocoBox
            // 
            this.SearchLocoBox.Location=new System.Drawing.Point(114, 211);
            this.SearchLocoBox.MaxLength=3;
            this.SearchLocoBox.Name="SearchLocoBox";
            this.SearchLocoBox.Size=new System.Drawing.Size(51, 23);
            this.SearchLocoBox.TabIndex=5;
            this.SearchLocoBox.TextAlign=HorizontalAlignment.Center;
            // 
            // Label9
            // 
            this.Label9.AutoSize=true;
            this.Label9.ForeColor=System.Drawing.Color.White;
            this.Label9.Location=new System.Drawing.Point(171, 214);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(70, 16);
            this.Label9.TabIndex=43;
            this.Label9.Text="شماره لکو:";
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.ForeColor=System.Drawing.Color.White;
            this.Label7.Location=new System.Drawing.Point(171, 176);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(81, 16);
            this.Label7.TabIndex=42;
            this.Label7.Text="ساعت اعزام:";
            // 
            // SearchLocalCombo
            // 
            this.SearchLocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.SearchLocalCombo.FormattingEnabled=true;
            this.SearchLocalCombo.Location=new System.Drawing.Point(65, 134);
            this.SearchLocalCombo.Name="SearchLocalCombo";
            this.SearchLocalCombo.Size=new System.Drawing.Size(100, 24);
            this.SearchLocalCombo.TabIndex=4;
            this.SearchLocalCombo.SelectedIndexChanged += new System.EventHandler(this.SearchLocalCombo_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.ForeColor=System.Drawing.Color.White;
            this.Label8.Location=new System.Drawing.Point(171, 138);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(35, 16);
            this.Label8.TabIndex=41;
            this.Label8.Text="مبدا:";
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.ForeColor=System.Drawing.Color.White;
            this.Label2.Location=new System.Drawing.Point(171, 62);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(39, 16);
            this.Label2.TabIndex=40;
            this.Label2.Text="تاریخ:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.ForeColor=System.Drawing.Color.White;
            this.Label1.Location=new System.Drawing.Point(171, 24);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(60, 16);
            this.Label1.TabIndex=39;
            this.Label1.Text="نام راهبر:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor=System.Drawing.Color.Gold;
            this.SearchButton.Image=global::Metro_Operation.Properties.Resources.srch_32;
            this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Cursor=Cursors.Hand;
            this.SearchButton.Location=new System.Drawing.Point(40, 253);
            this.SearchButton.Name="SearchButton";
            this.SearchButton.Size=new System.Drawing.Size(178, 34);
            this.SearchButton.TabIndex=45;
            this.SearchButton.Text="جستجو";
            this.SearchButton.UseVisualStyleBackColor=false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchLetterBox
            // 
            this.SearchLetterBox.Location=new System.Drawing.Point(65, 96);
            this.SearchLetterBox.MaxLength=10;
            this.SearchLetterBox.Name="SearchLetterBox";
            this.SearchLetterBox.Size=new System.Drawing.Size(100, 23);
            this.SearchLetterBox.TabIndex=3;
            this.SearchLetterBox.TextAlign=HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize=true;
            this.Label10.ForeColor=System.Drawing.Color.White;
            this.Label10.Location=new System.Drawing.Point(171, 100);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(75, 16);
            this.Label10.TabIndex=47;
            this.Label10.Text="شماره نامه:";
            // 
            // AnalyzerCombo
            // 
            this.AnalyzerCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.AnalyzerCombo.FormattingEnabled=true;
            this.AnalyzerCombo.Location=new System.Drawing.Point(20, 62);
            this.AnalyzerCombo.Name="AnalyzerCombo";
            this.AnalyzerCombo.Size=new System.Drawing.Size(153, 24);
            this.AnalyzerCombo.Sorted=true;
            this.AnalyzerCombo.TabIndex=2;
            // 
            // Label14
            // 
            this.Label14.AutoSize=true;
            this.Label14.ForeColor=System.Drawing.Color.Black;
            this.Label14.Location=new System.Drawing.Point(174, 66);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(60, 16);
            this.Label14.TabIndex=50;
            this.Label14.Text="تحلیل گر:";
            // 
            // DeletButton
            // 
            this.DeletButton.BackColor=System.Drawing.Color.DarkSalmon;
            this.DeletButton.Image=global::Metro_Operation.Properties.Resources.cancel1;
            this.DeletButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletButton.Cursor=Cursors.Hand;
            this.DeletButton.DialogResult=DialogResult.None;
            this.DeletButton.Location=new System.Drawing.Point(221, 11);
            this.DeletButton.Name="DeletButton";
            this.DeletButton.Size=new System.Drawing.Size(107, 34);
            this.DeletButton.TabIndex=2;
            this.DeletButton.Text="حذف";
            this.DeletButton.UseVisualStyleBackColor=false;
            this.DeletButton.Click += new System.EventHandler(this.DeletButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources.close_24;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.None;
            this.ExitButton.Location=new System.Drawing.Point(84, 11);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(107, 34);
            this.ExitButton.TabIndex=3;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.opts_24;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.DialogResult=DialogResult.None;
            this.RegButton.Location=new System.Drawing.Point(355, 11);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(107, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(46, 23);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(127, 23);
            this.NameBox.TabIndex=32;
            // 
            // NameButton
            // 
            this.NameButton.Image=((System.Drawing.Image)(resources.GetObject("NameButton.Image")));
            this.NameButton.Location=new System.Drawing.Point(16, 19);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 31);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location=new System.Drawing.Point(122, 215);
            this.TimeBox.Mask="00:00";
            this.TimeBox.Name="TimeBox";
            this.TimeBox.Size=new System.Drawing.Size(51, 23);
            this.TimeBox.TabIndex=6;
            this.TimeBox.TextAlign=HorizontalAlignment.Center;
            this.TimeBox.ValidatingType=typeof(System.DateTime);
            // 
            // LocoBox
            // 
            this.LocoBox.Location=new System.Drawing.Point(122, 253);
            this.LocoBox.Name="LocoBox";
            this.LocoBox.Size=new System.Drawing.Size(51, 23);
            this.LocoBox.TabIndex=7;
            this.LocoBox.TextAlign=HorizontalAlignment.Center;
            // 
            // LetterBox
            // 
            this.LetterBox.Location=new System.Drawing.Point(48, 138);
            this.LetterBox.Name="LetterBox";
            this.LetterBox.Size=new System.Drawing.Size(125, 23);
            this.LetterBox.TabIndex=4;
            this.LetterBox.TextAlign=HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.ForeColor=System.Drawing.Color.Black;
            this.Label4.Location=new System.Drawing.Point(176, 142);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(75, 16);
            this.Label4.TabIndex=47;
            this.Label4.Text="شماره نامه:";
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.ForeColor=System.Drawing.Color.Black;
            this.Label5.Location=new System.Drawing.Point(176, 256);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(70, 16);
            this.Label5.TabIndex=46;
            this.Label5.Text="شماره لکو:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.ForeColor=System.Drawing.Color.Black;
            this.Label6.Location=new System.Drawing.Point(176, 218);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(81, 16);
            this.Label6.TabIndex=45;
            this.Label6.Text="ساعت اعزام:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(48, 176);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(125, 24);
            this.LocalCombo.TabIndex=5;
            // 
            // Label11
            // 
            this.Label11.AutoSize=true;
            this.Label11.ForeColor=System.Drawing.Color.Black;
            this.Label11.Location=new System.Drawing.Point(176, 180);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(35, 16);
            this.Label11.TabIndex=44;
            this.Label11.Text="مبدا:";
            // 
            // ATPCheck
            // 
            this.ATPCheck.AutoSize=true;
            this.ATPCheck.ForeColor=System.Drawing.Color.Black;
            this.ATPCheck.Location=new System.Drawing.Point(49, 82);
            this.ATPCheck.Name="ATPCheck";
            this.ATPCheck.Size=new System.Drawing.Size(133, 20);
            this.ATPCheck.TabIndex=11;
            this.ATPCheck.Text="خاموش نمودن ATP";
            this.ATPCheck.UseVisualStyleBackColor=true;
            // 
            // OtherPoseCheck
            // 
            this.OtherPoseCheck.AutoSize=true;
            this.OtherPoseCheck.ForeColor=System.Drawing.Color.Green;
            this.OtherPoseCheck.Location=new System.Drawing.Point(86, 202);
            this.OtherPoseCheck.Name="OtherPoseCheck";
            this.OtherPoseCheck.Size=new System.Drawing.Size(96, 36);
            this.OtherPoseCheck.TabIndex=15;
            this.OtherPoseCheck.Text="ساير (مثبت)\r\n\n";
            this.OtherPoseCheck.UseVisualStyleBackColor=true;
            // 
            // BlowerCheck
            // 
            this.BlowerCheck.AutoSize=true;
            this.BlowerCheck.ForeColor=System.Drawing.Color.Black;
            this.BlowerCheck.Location=new System.Drawing.Point(41, 26);
            this.BlowerCheck.Name="BlowerCheck";
            this.BlowerCheck.Size=new System.Drawing.Size(141, 20);
            this.BlowerCheck.TabIndex=9;
            this.BlowerCheck.Text="حركت با بلور خاموش";
            this.BlowerCheck.UseVisualStyleBackColor=true;
            // 
            // BerakeCheck
            // 
            this.BerakeCheck.AutoSize=true;
            this.BerakeCheck.ForeColor=System.Drawing.Color.Black;
            this.BerakeCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.BerakeCheck.Location=new System.Drawing.Point(230, 54);
            this.BerakeCheck.Name="BerakeCheck";
            this.BerakeCheck.Size=new System.Drawing.Size(199, 20);
            this.BerakeCheck.TabIndex=2;
            this.BerakeCheck.Text="عدم استفاده صحيح از ترمز قطار";
            this.BerakeCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.BerakeCheck.UseVisualStyleBackColor=true;
            // 
            // OtherNegaCheck
            // 
            this.OtherNegaCheck.AutoSize=true;
            this.OtherNegaCheck.ForeColor=System.Drawing.Color.Red;
            this.OtherNegaCheck.Location=new System.Drawing.Point(83, 224);
            this.OtherNegaCheck.Name="OtherNegaCheck";
            this.OtherNegaCheck.Size=new System.Drawing.Size(99, 36);
            this.OtherNegaCheck.TabIndex=16;
            this.OtherNegaCheck.Text="ساير (منفي)\r\n\n";
            this.OtherNegaCheck.UseVisualStyleBackColor=true;
            // 
            // NachCheck
            // 
            this.NachCheck.AutoSize=true;
            this.NachCheck.ForeColor=System.Drawing.Color.Black;
            this.NachCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NachCheck.Location=new System.Drawing.Point(220, 26);
            this.NachCheck.Name="NachCheck";
            this.NachCheck.Size=new System.Drawing.Size(209, 20);
            this.NachCheck.TabIndex=1;
            this.NachCheck.Text="عدم استفاده صحيح از ناچ حركتی";
            this.NachCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NachCheck.UseVisualStyleBackColor=true;
            // 
            // NotDoorCheck
            // 
            this.NotDoorCheck.AutoSize=true;
            this.NotDoorCheck.ForeColor=System.Drawing.Color.Black;
            this.NotDoorCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NotDoorCheck.Location=new System.Drawing.Point(247, 110);
            this.NotDoorCheck.Name="NotDoorCheck";
            this.NotDoorCheck.Size=new System.Drawing.Size(182, 20);
            this.NotDoorCheck.TabIndex=4;
            this.NotDoorCheck.Text="باز نكردن دربها در طول مسير";
            this.NotDoorCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NotDoorCheck.UseVisualStyleBackColor=true;
            // 
            // OpenDoorCheck
            // 
            this.OpenDoorCheck.AutoSize=true;
            this.OpenDoorCheck.ForeColor=System.Drawing.Color.Black;
            this.OpenDoorCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.OpenDoorCheck.Location=new System.Drawing.Point(247, 138);
            this.OpenDoorCheck.Name="OpenDoorCheck";
            this.OpenDoorCheck.Size=new System.Drawing.Size(182, 20);
            this.OpenDoorCheck.TabIndex=5;
            this.OpenDoorCheck.Text="حركت با درب باز بر روی سکو";
            this.OpenDoorCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.OpenDoorCheck.UseVisualStyleBackColor=true;
            // 
            // ArnoCheck
            // 
            this.ArnoCheck.AutoSize=true;
            this.ArnoCheck.ForeColor=System.Drawing.Color.Black;
            this.ArnoCheck.Location=new System.Drawing.Point(54, 54);
            this.ArnoCheck.Name="ArnoCheck";
            this.ArnoCheck.Size=new System.Drawing.Size(128, 20);
            this.ArnoCheck.TabIndex=10;
            this.ArnoCheck.Text="خاموش نمودن آرنو";
            this.ArnoCheck.UseVisualStyleBackColor=true;
            // 
            // MemBox
            // 
            this.MemBox.Location=new System.Drawing.Point(26, 326);
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(403, 45);
            this.MemBox.TabIndex=17;
            this.MemBox.Text="";
            // 
            // RMCheck
            // 
            this.RMCheck.AutoSize=true;
            this.RMCheck.ForeColor=System.Drawing.Color.Black;
            this.RMCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RMCheck.Location=new System.Drawing.Point(271, 222);
            this.RMCheck.Name="RMCheck";
            this.RMCheck.Size=new System.Drawing.Size(158, 20);
            this.RMCheck.TabIndex=8;
            this.RMCheck.Text="فعال كردن مد RM(تهران)";
            this.RMCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RMCheck.UseVisualStyleBackColor=true;
            // 
            // SoozSpeedCheck
            // 
            this.SoozSpeedCheck.AutoSize=true;
            this.SoozSpeedCheck.ForeColor=System.Drawing.Color.Black;
            this.SoozSpeedCheck.Location=new System.Drawing.Point(29, 166);
            this.SoozSpeedCheck.Name="SoozSpeedCheck";
            this.SoozSpeedCheck.Size=new System.Drawing.Size(153, 20);
            this.SoozSpeedCheck.TabIndex=14;
            this.SoozSpeedCheck.Text="سرعت بالا روي سوزنها";
            this.SoozSpeedCheck.UseVisualStyleBackColor=true;
            // 
            // HighSpeedCheck
            // 
            this.HighSpeedCheck.AutoSize=true;
            this.HighSpeedCheck.ForeColor=System.Drawing.Color.Black;
            this.HighSpeedCheck.Location=new System.Drawing.Point(97, 138);
            this.HighSpeedCheck.Name="HighSpeedCheck";
            this.HighSpeedCheck.Size=new System.Drawing.Size(85, 36);
            this.HighSpeedCheck.TabIndex=13;
            this.HighSpeedCheck.Text="سرعت بالا\r\n\n";
            this.HighSpeedCheck.UseVisualStyleBackColor=true;
            // 
            // AlarmCheck
            // 
            this.AlarmCheck.AutoSize=true;
            this.AlarmCheck.ForeColor=System.Drawing.Color.Black;
            this.AlarmCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.AlarmCheck.Location=new System.Drawing.Point(258, 194);
            this.AlarmCheck.Name="AlarmCheck";
            this.AlarmCheck.Size=new System.Drawing.Size(171, 20);
            this.AlarmCheck.TabIndex=7;
            this.AlarmCheck.Text="عدم اطلاع رسانی به موقع";
            this.AlarmCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.AlarmCheck.UseVisualStyleBackColor=true;
            // 
            // SignalCheck
            // 
            this.SignalCheck.AutoSize=true;
            this.SignalCheck.ForeColor=System.Drawing.Color.Black;
            this.SignalCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.SignalCheck.Location=new System.Drawing.Point(238, 82);
            this.SignalCheck.Name="SignalCheck";
            this.SignalCheck.Size=new System.Drawing.Size(191, 20);
            this.SignalCheck.TabIndex=3;
            this.SignalCheck.Text="عبور از چراغ قرمز یا آبی شانت";
            this.SignalCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.SignalCheck.UseVisualStyleBackColor=true;
            // 
            // ATPSpeedCheck
            // 
            this.ATPSpeedCheck.AutoSize=true;
            this.ATPSpeedCheck.ForeColor=System.Drawing.Color.Black;
            this.ATPSpeedCheck.Location=new System.Drawing.Point(51, 110);
            this.ATPSpeedCheck.Name="ATPSpeedCheck";
            this.ATPSpeedCheck.Size=new System.Drawing.Size(131, 20);
            this.ATPSpeedCheck.TabIndex=12;
            this.ATPSpeedCheck.Text="عدم رعايت كد ATP";
            this.ATPSpeedCheck.UseVisualStyleBackColor=true;
            // 
            // FaultCheck
            // 
            this.FaultCheck.AutoSize=true;
            this.FaultCheck.ForeColor=System.Drawing.Color.Black;
            this.FaultCheck.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.FaultCheck.Location=new System.Drawing.Point(254, 166);
            this.FaultCheck.Name="FaultCheck";
            this.FaultCheck.Size=new System.Drawing.Size(175, 20);
            this.FaultCheck.TabIndex=6;
            this.FaultCheck.Text="مسافرگيري قبل از رفع فالت";
            this.FaultCheck.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.FaultCheck.UseVisualStyleBackColor=true;
            // 
            // Label12
            // 
            this.Label12.AutoSize=true;
            this.Label12.ForeColor=System.Drawing.Color.Black;
            this.Label12.Location=new System.Drawing.Point(174, 104);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(39, 16);
            this.Label12.TabIndex=41;
            this.Label12.Text="تاریخ:";
            // 
            // Label13
            // 
            this.Label13.AutoSize=true;
            this.Label13.ForeColor=System.Drawing.Color.Black;
            this.Label13.Location=new System.Drawing.Point(176, 27);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(60, 16);
            this.Label13.TabIndex=40;
            this.Label13.Text="نام راهبر:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.SystemColors.HotTrack;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.SearchPersianCalendar);
            this.Panel1.Controls.Add(this.SearchButton);
            this.Panel1.Controls.Add(this.SearchLetterBox);
            this.Panel1.Controls.Add(this.SearchTimeBox);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.SearchLocalCombo);
            this.Panel1.Controls.Add(this.SearchNameButton);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.SearchLocoBox);
            this.Panel1.Controls.Add(this.SearchNameBox);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location=new System.Drawing.Point(790, 20);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(262, 303);
            this.Panel1.TabIndex=0;
            // 
            // SearchPersianCalendar
            // 
            this.SearchPersianCalendar.Location=new System.Drawing.Point(40, 59);
            this.SearchPersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.SearchPersianCalendar.Name="SearchPersianCalendar";
            this.SearchPersianCalendar.NowDateSelected=true;
            this.SearchPersianCalendar.ReadOnly=true;
            this.SearchPersianCalendar.SelectedDate=null;
            this.SearchPersianCalendar.Shamsi=null;
            this.SearchPersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.SearchPersianCalendar.TabIndex=98;
            this.SearchPersianCalendar.TextAlign=HorizontalAlignment.Center;
            this.SearchPersianCalendar.TextChanged += new System.EventHandler(this.SearchPersianCalendar_TextChanged);
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Label17);
            this.Panel3.Controls.Add(this.Label16);
            this.Panel3.Controls.Add(this.ATPCheck);
            this.Panel3.Controls.Add(this.BlowerCheck);
            this.Panel3.Controls.Add(this.MemBox);
            this.Panel3.Controls.Add(this.FaultCheck);
            this.Panel3.Controls.Add(this.OtherPoseCheck);
            this.Panel3.Controls.Add(this.ATPSpeedCheck);
            this.Panel3.Controls.Add(this.SignalCheck);
            this.Panel3.Controls.Add(this.BerakeCheck);
            this.Panel3.Controls.Add(this.AlarmCheck);
            this.Panel3.Controls.Add(this.OtherNegaCheck);
            this.Panel3.Controls.Add(this.HighSpeedCheck);
            this.Panel3.Controls.Add(this.NachCheck);
            this.Panel3.Controls.Add(this.SoozSpeedCheck);
            this.Panel3.Controls.Add(this.NotDoorCheck);
            this.Panel3.Controls.Add(this.RMCheck);
            this.Panel3.Controls.Add(this.OpenDoorCheck);
            this.Panel3.Controls.Add(this.ArnoCheck);
            this.Panel3.Location=new System.Drawing.Point(15, 20);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(456, 392);
            this.Panel3.TabIndex=2;
            // 
            // Label17
            // 
            this.Label17.BackColor=System.Drawing.Color.LightGreen;
            this.Label17.BorderStyle=BorderStyle.FixedSingle;
            this.Label17.ForeColor=System.Drawing.Color.Black;
            this.Label17.Location=new System.Drawing.Point(361, 298);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(68, 24);
            this.Label17.TabIndex=54;
            this.Label17.Text="توضیحات";
            this.Label17.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label16
            // 
            this.Label16.AutoSize=true;
            this.Label16.Location=new System.Drawing.Point(39, 268);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(363, 16);
            this.Label16.TabIndex=51;
            this.Label16.Text="-----------------------------------------------------------------------";
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.DeletButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Location=new System.Drawing.Point(492, 350);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(560, 58);
            this.Panel2.TabIndex=3;
            // 
            // Panel4
            // 
            this.Panel4.BackColor=System.Drawing.Color.LightBlue;
            this.Panel4.BorderStyle=BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.PersianCalendar);
            this.Panel4.Controls.Add(this.LocoBox);
            this.Panel4.Controls.Add(this.NameButton);
            this.Panel4.Controls.Add(this.Label12);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.LetterBox);
            this.Panel4.Controls.Add(this.AnalyzerCombo);
            this.Panel4.Controls.Add(this.Label14);
            this.Panel4.Controls.Add(this.NameBox);
            this.Panel4.Controls.Add(this.LocalCombo);
            this.Panel4.Controls.Add(this.Label11);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.Label13);
            this.Panel4.Controls.Add(this.TimeBox);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Location=new System.Drawing.Point(492, 20);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(274, 303);
            this.Panel4.TabIndex=1;
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location=new System.Drawing.Point(48, 101);
            this.PersianCalendar.Miladi=new System.DateTime(((long)(0)));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            // 
            // Panel5
            // 
            this.Panel5.BackColor=System.Drawing.Color.Black;
            this.Panel5.Location=new System.Drawing.Point(488, 362);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(556, 51);
            this.Panel5.TabIndex=54;
            // 
            // TechnicalFunctionEditForm
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Silver;
            this.ClientSize=new System.Drawing.Size(1071, 429);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel5);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TechnicalFunctionEditForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ویرایش عملکرد فنی راهبران";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.TechnicalFunctionEditForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form48_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        private Label Label9;
        private Label Label7;
        private Label Label8;
        private Label Label2;
        private Label Label1;
        private Label Label4;
        private Label Label5;
        private Label Label6;
        private Label Label11;
        private Label Label12;
        private Label Label13;
        private Label Label14;
        private Label Label16;
        private Label Label17;
        private Panel Panel1;
        private CheckBox ATPCheck;
        private CheckBox OtherPoseCheck;
        private CheckBox BlowerCheck;
        private CheckBox BerakeCheck;
        private CheckBox OtherNegaCheck;
        private CheckBox NachCheck;
        private CheckBox NotDoorCheck;
        private CheckBox OpenDoorCheck;
        private CheckBox ArnoCheck;
        private CheckBox RMCheck;
        private CheckBox SoozSpeedCheck;
        private CheckBox HighSpeedCheck;
        private CheckBox AlarmCheck;
        private CheckBox SignalCheck;
        private CheckBox ATPSpeedCheck;
        private CheckBox FaultCheck;
        private RichTextBox MemBox;
        private Button SearchButton;
        private Button ExitButton;
        private Button RegButton;
        private Button NameButton;
        internal TextBox SearchNameBox;
        private TextBox NameBox;
        private MaskedTextBox TimeBox;
        private TextBox LocoBox;
        private TextBox LetterBox;
        private ComboBox LocalCombo;
        private Button SearchNameButton;
        internal MaskedTextBox SearchTimeBox;
        internal TextBox SearchLocoBox;
        internal ComboBox SearchLocalCombo;
        private Button DeletButton;
        internal TextBox SearchLetterBox;
        private Label Label10;
        private ComboBox AnalyzerCombo;
        private Panel Panel3;
        private Panel Panel2;
        private Panel Panel4;
        private Panel Panel5;
        internal BPersianCalender.BPersianCalenderTextBox SearchPersianCalendar;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private System.ComponentModel.IContainer components;
    }

}
