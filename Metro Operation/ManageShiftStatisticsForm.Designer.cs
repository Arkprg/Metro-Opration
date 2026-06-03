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
	partial class ManageShiftStatisticsForm : BaseForm
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components=new System.ComponentModel.Container();
            this.TitrLabel=new System.Windows.Forms.Label();
            this.Panel5=new System.Windows.Forms.Panel();
            this.LabelC2=new System.Windows.Forms.Label();
            this.LabelB2=new System.Windows.Forms.Label();
            this.LabelA2=new System.Windows.Forms.Label();
            this.HamBoxA=new System.Windows.Forms.TextBox();
            this.FridayBoxA=new System.Windows.Forms.TextBox();
            this.OvertimeEctBoxA=new System.Windows.Forms.TextBox();
            this.NoReqBoxA=new System.Windows.Forms.TextBox();
            this.HamBoxB=new System.Windows.Forms.TextBox();
            this.FridayBoxB=new System.Windows.Forms.TextBox();
            this.OvertimeEctBoxB=new System.Windows.Forms.TextBox();
            this.NoReqBoxB=new System.Windows.Forms.TextBox();
            this.HamBoxC=new System.Windows.Forms.TextBox();
            this.FridayBoxC=new System.Windows.Forms.TextBox();
            this.OvertimeEctBoxC=new System.Windows.Forms.TextBox();
            this.NoReqBoxC=new System.Windows.Forms.TextBox();
            this.TimeLeaveBoxA=new System.Windows.Forms.TextBox();
            this.DailyLeaveBoxA=new System.Windows.Forms.TextBox();
            this.OvertimeReqBoxA=new System.Windows.Forms.TextBox();
            this.OKOvertimeReqBoxA=new System.Windows.Forms.TextBox();
            this.TimeLeaveBoxB=new System.Windows.Forms.TextBox();
            this.DailyLeaveBoxB=new System.Windows.Forms.TextBox();
            this.OvertimeReqBoxB=new System.Windows.Forms.TextBox();
            this.OKOvertimeReqBoxB=new System.Windows.Forms.TextBox();
            this.TimeLeaveBoxC=new System.Windows.Forms.TextBox();
            this.DailyLeaveBoxC=new System.Windows.Forms.TextBox();
            this.OvertimeReqBoxC=new System.Windows.Forms.TextBox();
            this.OKOvertimeReqBoxC=new System.Windows.Forms.TextBox();
            this.LabelC1=new System.Windows.Forms.Label();
            this.LabelB1=new System.Windows.Forms.Label();
            this.LabelA1=new System.Windows.Forms.Label();
            this.ReservBoxA=new System.Windows.Forms.TextBox();
            this.TripBoxA=new System.Windows.Forms.TextBox();
            this.DelBoxA=new System.Windows.Forms.TextBox();
            this.NoTripBoxA=new System.Windows.Forms.TextBox();
            this.ReservBoxB=new System.Windows.Forms.TextBox();
            this.TripBoxB=new System.Windows.Forms.TextBox();
            this.DelBoxB=new System.Windows.Forms.TextBox();
            this.NoTripBoxB=new System.Windows.Forms.TextBox();
            this.ReservBoxC=new System.Windows.Forms.TextBox();
            this.ReservLabel=new System.Windows.Forms.Label();
            this.TripBoxC=new System.Windows.Forms.TextBox();
            this.DelBoxC=new System.Windows.Forms.TextBox();
            this.TimeLeaveLabel=new System.Windows.Forms.Label();
            this.NoTripBoxC=new System.Windows.Forms.TextBox();
            this.DelLabel=new System.Windows.Forms.Label();
            this.HamLabel=new System.Windows.Forms.Label();
            this.NoReqLabel=new System.Windows.Forms.Label();
            this.DailyLeaveLabel=new System.Windows.Forms.Label();
            this.OKOvertimeReqLabel=new System.Windows.Forms.Label();
            this.OvertimeReqLabel=new System.Windows.Forms.Label();
            this.OvertimeEctLabel=new System.Windows.Forms.Label();
            this.FridayLabel=new System.Windows.Forms.Label();
            this.TripLabel=new System.Windows.Forms.Label();
            this.NoTripLabel=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.LabelT4=new System.Windows.Forms.Label();
            this.LabelT2=new System.Windows.Forms.Label();
            this.TimeCombo=new System.Windows.Forms.ComboBox();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.ExportButton=new System.Windows.Forms.Button();
            this.ShowButton=new System.Windows.Forms.Button();
            this.LabelT9=new System.Windows.Forms.Label();
            this.LabelT14=new System.Windows.Forms.Label();
            this.Label50=new System.Windows.Forms.Label();
            this.Label51=new System.Windows.Forms.Label();
            this.Panel5.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitrLabel
            // 
            this.TitrLabel.BackColor=System.Drawing.Color.Gray;
            this.TitrLabel.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitrLabel.Cursor=System.Windows.Forms.Cursors.Default;
            this.TitrLabel.ForeColor=System.Drawing.Color.White;
            this.TitrLabel.Location=new System.Drawing.Point(779, 119);
            this.TitrLabel.Name="TitrLabel";
            this.TitrLabel.Size=new System.Drawing.Size(107, 22);
            this.TitrLabel.TabIndex=50;
            this.TitrLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel5
            // 
            this.Panel5.BackColor=System.Drawing.SystemColors.ActiveCaption;
            this.Panel5.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.LabelC2);
            this.Panel5.Controls.Add(this.LabelB2);
            this.Panel5.Controls.Add(this.LabelA2);
            this.Panel5.Controls.Add(this.HamBoxA);
            this.Panel5.Controls.Add(this.FridayBoxA);
            this.Panel5.Controls.Add(this.OvertimeEctBoxA);
            this.Panel5.Controls.Add(this.NoReqBoxA);
            this.Panel5.Controls.Add(this.HamBoxB);
            this.Panel5.Controls.Add(this.FridayBoxB);
            this.Panel5.Controls.Add(this.OvertimeEctBoxB);
            this.Panel5.Controls.Add(this.NoReqBoxB);
            this.Panel5.Controls.Add(this.HamBoxC);
            this.Panel5.Controls.Add(this.FridayBoxC);
            this.Panel5.Controls.Add(this.OvertimeEctBoxC);
            this.Panel5.Controls.Add(this.NoReqBoxC);
            this.Panel5.Controls.Add(this.TimeLeaveBoxA);
            this.Panel5.Controls.Add(this.DailyLeaveBoxA);
            this.Panel5.Controls.Add(this.OvertimeReqBoxA);
            this.Panel5.Controls.Add(this.OKOvertimeReqBoxA);
            this.Panel5.Controls.Add(this.TimeLeaveBoxB);
            this.Panel5.Controls.Add(this.DailyLeaveBoxB);
            this.Panel5.Controls.Add(this.OvertimeReqBoxB);
            this.Panel5.Controls.Add(this.OKOvertimeReqBoxB);
            this.Panel5.Controls.Add(this.TimeLeaveBoxC);
            this.Panel5.Controls.Add(this.DailyLeaveBoxC);
            this.Panel5.Controls.Add(this.OvertimeReqBoxC);
            this.Panel5.Controls.Add(this.OKOvertimeReqBoxC);
            this.Panel5.Controls.Add(this.LabelC1);
            this.Panel5.Controls.Add(this.LabelB1);
            this.Panel5.Controls.Add(this.LabelA1);
            this.Panel5.Controls.Add(this.ReservBoxA);
            this.Panel5.Controls.Add(this.TripBoxA);
            this.Panel5.Controls.Add(this.DelBoxA);
            this.Panel5.Controls.Add(this.NoTripBoxA);
            this.Panel5.Controls.Add(this.ReservBoxB);
            this.Panel5.Controls.Add(this.TripBoxB);
            this.Panel5.Controls.Add(this.DelBoxB);
            this.Panel5.Controls.Add(this.NoTripBoxB);
            this.Panel5.Controls.Add(this.ReservBoxC);
            this.Panel5.Controls.Add(this.ReservLabel);
            this.Panel5.Controls.Add(this.TripBoxC);
            this.Panel5.Controls.Add(this.DelBoxC);
            this.Panel5.Controls.Add(this.TimeLeaveLabel);
            this.Panel5.Controls.Add(this.NoTripBoxC);
            this.Panel5.Controls.Add(this.DelLabel);
            this.Panel5.Controls.Add(this.HamLabel);
            this.Panel5.Controls.Add(this.NoReqLabel);
            this.Panel5.Controls.Add(this.DailyLeaveLabel);
            this.Panel5.Controls.Add(this.OKOvertimeReqLabel);
            this.Panel5.Controls.Add(this.OvertimeReqLabel);
            this.Panel5.Controls.Add(this.OvertimeEctLabel);
            this.Panel5.Controls.Add(this.FridayLabel);
            this.Panel5.Controls.Add(this.TripLabel);
            this.Panel5.Controls.Add(this.NoTripLabel);
            this.Panel5.ForeColor=System.Drawing.Color.Black;
            this.Panel5.Location=new System.Drawing.Point(12, 132);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(894, 240);
            this.Panel5.TabIndex=49;
            // 
            // LabelC2
            // 
            this.LabelC2.AutoSize=true;
            this.LabelC2.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelC2.Location=new System.Drawing.Point(155, 23);
            this.LabelC2.Name="LabelC2";
            this.LabelC2.Size=new System.Drawing.Size(20, 19);
            this.LabelC2.TabIndex=211;
            this.LabelC2.Text="C";
            // 
            // LabelB2
            // 
            this.LabelB2.AutoSize=true;
            this.LabelB2.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelB2.Location=new System.Drawing.Point(99, 23);
            this.LabelB2.Name="LabelB2";
            this.LabelB2.Size=new System.Drawing.Size(20, 19);
            this.LabelB2.TabIndex=210;
            this.LabelB2.Text="B";
            // 
            // LabelA2
            // 
            this.LabelA2.AutoSize=true;
            this.LabelA2.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelA2.Location=new System.Drawing.Point(43, 23);
            this.LabelA2.Name="LabelA2";
            this.LabelA2.Size=new System.Drawing.Size(21, 19);
            this.LabelA2.TabIndex=209;
            this.LabelA2.Text="A";
            // 
            // HamBoxA
            // 
            this.HamBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HamBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.HamBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HamBoxA.Location=new System.Drawing.Point(28, 101);
            this.HamBoxA.MaxLength=5;
            this.HamBoxA.Name="HamBoxA";
            this.HamBoxA.ReadOnly=true;
            this.HamBoxA.Size=new System.Drawing.Size(50, 23);
            this.HamBoxA.TabIndex=208;
            this.HamBoxA.Tag="25";
            this.HamBoxA.Text="0";
            this.HamBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.HamBoxA.Click += new System.EventHandler(this.AHamBox_Click);
            // 
            // FridayBoxA
            // 
            this.FridayBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FridayBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.FridayBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FridayBoxA.Location=new System.Drawing.Point(28, 128);
            this.FridayBoxA.MaxLength=5;
            this.FridayBoxA.Name="FridayBoxA";
            this.FridayBoxA.ReadOnly=true;
            this.FridayBoxA.Size=new System.Drawing.Size(50, 23);
            this.FridayBoxA.TabIndex=207;
            this.FridayBoxA.Tag="28";
            this.FridayBoxA.Text="0";
            this.FridayBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.FridayBoxA.Click += new System.EventHandler(this.AFridayBox_Click);
            // 
            // OvertimeEctBoxA
            // 
            this.OvertimeEctBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OvertimeEctBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OvertimeEctBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OvertimeEctBoxA.Location=new System.Drawing.Point(28, 155);
            this.OvertimeEctBoxA.MaxLength=5;
            this.OvertimeEctBoxA.Name="OvertimeEctBoxA";
            this.OvertimeEctBoxA.ReadOnly=true;
            this.OvertimeEctBoxA.Size=new System.Drawing.Size(50, 23);
            this.OvertimeEctBoxA.TabIndex=206;
            this.OvertimeEctBoxA.Tag="31";
            this.OvertimeEctBoxA.Text="0";
            this.OvertimeEctBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NoReqBoxA
            // 
            this.NoReqBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NoReqBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.NoReqBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoReqBoxA.Location=new System.Drawing.Point(28, 182);
            this.NoReqBoxA.MaxLength=5;
            this.NoReqBoxA.Name="NoReqBoxA";
            this.NoReqBoxA.ReadOnly=true;
            this.NoReqBoxA.Size=new System.Drawing.Size(50, 23);
            this.NoReqBoxA.TabIndex=205;
            this.NoReqBoxA.Tag="34";
            this.NoReqBoxA.Text="0";
            this.NoReqBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamBoxB
            // 
            this.HamBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HamBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.HamBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HamBoxB.Location=new System.Drawing.Point(84, 101);
            this.HamBoxB.MaxLength=5;
            this.HamBoxB.Name="HamBoxB";
            this.HamBoxB.ReadOnly=true;
            this.HamBoxB.Size=new System.Drawing.Size(50, 23);
            this.HamBoxB.TabIndex=204;
            this.HamBoxB.Tag="26";
            this.HamBoxB.Text="0";
            this.HamBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.HamBoxB.Click += new System.EventHandler(this.BHamBox_Click);
            // 
            // FridayBoxB
            // 
            this.FridayBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FridayBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.FridayBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FridayBoxB.Location=new System.Drawing.Point(84, 128);
            this.FridayBoxB.MaxLength=5;
            this.FridayBoxB.Name="FridayBoxB";
            this.FridayBoxB.ReadOnly=true;
            this.FridayBoxB.Size=new System.Drawing.Size(50, 23);
            this.FridayBoxB.TabIndex=203;
            this.FridayBoxB.Tag="29";
            this.FridayBoxB.Text="0";
            this.FridayBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.FridayBoxB.Click += new System.EventHandler(this.BFridayBox_Click);
            // 
            // OvertimeEctBoxB
            // 
            this.OvertimeEctBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OvertimeEctBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OvertimeEctBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OvertimeEctBoxB.Location=new System.Drawing.Point(84, 155);
            this.OvertimeEctBoxB.MaxLength=5;
            this.OvertimeEctBoxB.Name="OvertimeEctBoxB";
            this.OvertimeEctBoxB.ReadOnly=true;
            this.OvertimeEctBoxB.Size=new System.Drawing.Size(50, 23);
            this.OvertimeEctBoxB.TabIndex=202;
            this.OvertimeEctBoxB.Tag="32";
            this.OvertimeEctBoxB.Text="0";
            this.OvertimeEctBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NoReqBoxB
            // 
            this.NoReqBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NoReqBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.NoReqBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoReqBoxB.Location=new System.Drawing.Point(84, 182);
            this.NoReqBoxB.MaxLength=5;
            this.NoReqBoxB.Name="NoReqBoxB";
            this.NoReqBoxB.ReadOnly=true;
            this.NoReqBoxB.Size=new System.Drawing.Size(50, 23);
            this.NoReqBoxB.TabIndex=201;
            this.NoReqBoxB.Tag="35";
            this.NoReqBoxB.Text="0";
            this.NoReqBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamBoxC
            // 
            this.HamBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HamBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.HamBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HamBoxC.Location=new System.Drawing.Point(140, 101);
            this.HamBoxC.MaxLength=5;
            this.HamBoxC.Name="HamBoxC";
            this.HamBoxC.ReadOnly=true;
            this.HamBoxC.Size=new System.Drawing.Size(50, 23);
            this.HamBoxC.TabIndex=200;
            this.HamBoxC.Tag="27";
            this.HamBoxC.Text="0";
            this.HamBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.HamBoxC.Click += new System.EventHandler(this.CHamBox_Click);
            // 
            // FridayBoxC
            // 
            this.FridayBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FridayBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.FridayBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FridayBoxC.Location=new System.Drawing.Point(140, 128);
            this.FridayBoxC.MaxLength=5;
            this.FridayBoxC.Name="FridayBoxC";
            this.FridayBoxC.ReadOnly=true;
            this.FridayBoxC.Size=new System.Drawing.Size(50, 23);
            this.FridayBoxC.TabIndex=199;
            this.FridayBoxC.Tag="30";
            this.FridayBoxC.Text="0";
            this.FridayBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.FridayBoxC.Click += new System.EventHandler(this.CFridayBox_Click);
            // 
            // OvertimeEctBoxC
            // 
            this.OvertimeEctBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OvertimeEctBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OvertimeEctBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OvertimeEctBoxC.Location=new System.Drawing.Point(140, 155);
            this.OvertimeEctBoxC.MaxLength=5;
            this.OvertimeEctBoxC.Name="OvertimeEctBoxC";
            this.OvertimeEctBoxC.ReadOnly=true;
            this.OvertimeEctBoxC.Size=new System.Drawing.Size(50, 23);
            this.OvertimeEctBoxC.TabIndex=198;
            this.OvertimeEctBoxC.Tag="33";
            this.OvertimeEctBoxC.Text="0";
            this.OvertimeEctBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NoReqBoxC
            // 
            this.NoReqBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NoReqBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.NoReqBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoReqBoxC.Location=new System.Drawing.Point(140, 182);
            this.NoReqBoxC.MaxLength=5;
            this.NoReqBoxC.Name="NoReqBoxC";
            this.NoReqBoxC.ReadOnly=true;
            this.NoReqBoxC.Size=new System.Drawing.Size(50, 23);
            this.NoReqBoxC.TabIndex=197;
            this.NoReqBoxC.Tag="36";
            this.NoReqBoxC.Text="0";
            this.NoReqBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeLeaveBoxA
            // 
            this.TimeLeaveBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimeLeaveBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.TimeLeaveBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeLeaveBoxA.Location=new System.Drawing.Point(571, 155);
            this.TimeLeaveBoxA.MaxLength=5;
            this.TimeLeaveBoxA.Name="TimeLeaveBoxA";
            this.TimeLeaveBoxA.ReadOnly=true;
            this.TimeLeaveBoxA.Size=new System.Drawing.Size(50, 23);
            this.TimeLeaveBoxA.TabIndex=193;
            this.TimeLeaveBoxA.Tag="13";
            this.TimeLeaveBoxA.Text="0";
            this.TimeLeaveBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeLeaveBoxA.Click += new System.EventHandler(this.ATimeLeaveBox_Click);
            // 
            // DailyLeaveBoxA
            // 
            this.DailyLeaveBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DailyLeaveBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DailyLeaveBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DailyLeaveBoxA.Location=new System.Drawing.Point(571, 182);
            this.DailyLeaveBoxA.MaxLength=5;
            this.DailyLeaveBoxA.Name="DailyLeaveBoxA";
            this.DailyLeaveBoxA.ReadOnly=true;
            this.DailyLeaveBoxA.Size=new System.Drawing.Size(50, 23);
            this.DailyLeaveBoxA.TabIndex=192;
            this.DailyLeaveBoxA.Tag="16";
            this.DailyLeaveBoxA.Text="0";
            this.DailyLeaveBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.DailyLeaveBoxA.Click += new System.EventHandler(this.ADailyLeaveBox_Click);
            // 
            // OvertimeReqBoxA
            // 
            this.OvertimeReqBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OvertimeReqBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OvertimeReqBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OvertimeReqBoxA.Location=new System.Drawing.Point(28, 47);
            this.OvertimeReqBoxA.MaxLength=5;
            this.OvertimeReqBoxA.Name="OvertimeReqBoxA";
            this.OvertimeReqBoxA.ReadOnly=true;
            this.OvertimeReqBoxA.Size=new System.Drawing.Size(50, 23);
            this.OvertimeReqBoxA.TabIndex=191;
            this.OvertimeReqBoxA.Tag="19";
            this.OvertimeReqBoxA.Text="0";
            this.OvertimeReqBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.OvertimeReqBoxA.Click += new System.EventHandler(this.AOvertimeReqBox_Click);
            // 
            // OKOvertimeReqBoxA
            // 
            this.OKOvertimeReqBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OKOvertimeReqBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OKOvertimeReqBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OKOvertimeReqBoxA.Location=new System.Drawing.Point(28, 74);
            this.OKOvertimeReqBoxA.MaxLength=5;
            this.OKOvertimeReqBoxA.Name="OKOvertimeReqBoxA";
            this.OKOvertimeReqBoxA.ReadOnly=true;
            this.OKOvertimeReqBoxA.Size=new System.Drawing.Size(50, 23);
            this.OKOvertimeReqBoxA.TabIndex=190;
            this.OKOvertimeReqBoxA.Tag="22";
            this.OKOvertimeReqBoxA.Text="0";
            this.OKOvertimeReqBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.OKOvertimeReqBoxA.Click += new System.EventHandler(this.AOKOvertimeReqBox_Click);
            // 
            // TimeLeaveBoxB
            // 
            this.TimeLeaveBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TimeLeaveBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.TimeLeaveBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeLeaveBoxB.Location=new System.Drawing.Point(627, 155);
            this.TimeLeaveBoxB.MaxLength=5;
            this.TimeLeaveBoxB.Name="TimeLeaveBoxB";
            this.TimeLeaveBoxB.ReadOnly=true;
            this.TimeLeaveBoxB.Size=new System.Drawing.Size(50, 23);
            this.TimeLeaveBoxB.TabIndex=189;
            this.TimeLeaveBoxB.Tag="14";
            this.TimeLeaveBoxB.Text="0";
            this.TimeLeaveBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeLeaveBoxB.Click += new System.EventHandler(this.BTimeLeaveBox_Click);
            // 
            // DailyLeaveBoxB
            // 
            this.DailyLeaveBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DailyLeaveBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DailyLeaveBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DailyLeaveBoxB.Location=new System.Drawing.Point(627, 182);
            this.DailyLeaveBoxB.MaxLength=5;
            this.DailyLeaveBoxB.Name="DailyLeaveBoxB";
            this.DailyLeaveBoxB.ReadOnly=true;
            this.DailyLeaveBoxB.Size=new System.Drawing.Size(50, 23);
            this.DailyLeaveBoxB.TabIndex=188;
            this.DailyLeaveBoxB.Tag="17";
            this.DailyLeaveBoxB.Text="0";
            this.DailyLeaveBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.DailyLeaveBoxB.Click += new System.EventHandler(this.BDailyLeaveBox_Click);
            // 
            // OvertimeReqBoxB
            // 
            this.OvertimeReqBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OvertimeReqBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OvertimeReqBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OvertimeReqBoxB.Location=new System.Drawing.Point(84, 47);
            this.OvertimeReqBoxB.MaxLength=5;
            this.OvertimeReqBoxB.Name="OvertimeReqBoxB";
            this.OvertimeReqBoxB.ReadOnly=true;
            this.OvertimeReqBoxB.Size=new System.Drawing.Size(50, 23);
            this.OvertimeReqBoxB.TabIndex=187;
            this.OvertimeReqBoxB.Tag="20";
            this.OvertimeReqBoxB.Text="0";
            this.OvertimeReqBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.OvertimeReqBoxB.Click += new System.EventHandler(this.BOvertimeReqBox_Click);
            // 
            // OKOvertimeReqBoxB
            // 
            this.OKOvertimeReqBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OKOvertimeReqBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OKOvertimeReqBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OKOvertimeReqBoxB.Location=new System.Drawing.Point(84, 74);
            this.OKOvertimeReqBoxB.MaxLength=5;
            this.OKOvertimeReqBoxB.Name="OKOvertimeReqBoxB";
            this.OKOvertimeReqBoxB.ReadOnly=true;
            this.OKOvertimeReqBoxB.Size=new System.Drawing.Size(50, 23);
            this.OKOvertimeReqBoxB.TabIndex=186;
            this.OKOvertimeReqBoxB.Tag="23";
            this.OKOvertimeReqBoxB.Text="0";
            this.OKOvertimeReqBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.OKOvertimeReqBoxB.Click += new System.EventHandler(this.BOKOvertimeReqBox_Click);
            // 
            // TimeLeaveBoxC
            // 
            this.TimeLeaveBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TimeLeaveBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.TimeLeaveBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeLeaveBoxC.Location=new System.Drawing.Point(683, 155);
            this.TimeLeaveBoxC.MaxLength=5;
            this.TimeLeaveBoxC.Name="TimeLeaveBoxC";
            this.TimeLeaveBoxC.ReadOnly=true;
            this.TimeLeaveBoxC.Size=new System.Drawing.Size(50, 23);
            this.TimeLeaveBoxC.TabIndex=185;
            this.TimeLeaveBoxC.Tag="15";
            this.TimeLeaveBoxC.Text="0";
            this.TimeLeaveBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeLeaveBoxC.Click += new System.EventHandler(this.CTimeLeaveBox_Click);
            // 
            // DailyLeaveBoxC
            // 
            this.DailyLeaveBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DailyLeaveBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DailyLeaveBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DailyLeaveBoxC.Location=new System.Drawing.Point(683, 182);
            this.DailyLeaveBoxC.MaxLength=5;
            this.DailyLeaveBoxC.Name="DailyLeaveBoxC";
            this.DailyLeaveBoxC.ReadOnly=true;
            this.DailyLeaveBoxC.Size=new System.Drawing.Size(50, 23);
            this.DailyLeaveBoxC.TabIndex=184;
            this.DailyLeaveBoxC.Tag="18";
            this.DailyLeaveBoxC.Text="0";
            this.DailyLeaveBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.DailyLeaveBoxC.Click += new System.EventHandler(this.CDailyLeaveBox_Click);
            // 
            // OvertimeReqBoxC
            // 
            this.OvertimeReqBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OvertimeReqBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OvertimeReqBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OvertimeReqBoxC.Location=new System.Drawing.Point(140, 47);
            this.OvertimeReqBoxC.MaxLength=5;
            this.OvertimeReqBoxC.Name="OvertimeReqBoxC";
            this.OvertimeReqBoxC.ReadOnly=true;
            this.OvertimeReqBoxC.Size=new System.Drawing.Size(50, 23);
            this.OvertimeReqBoxC.TabIndex=183;
            this.OvertimeReqBoxC.Tag="21";
            this.OvertimeReqBoxC.Text="0";
            this.OvertimeReqBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.OvertimeReqBoxC.Click += new System.EventHandler(this.COvertimeReqBox_Click);
            // 
            // OKOvertimeReqBoxC
            // 
            this.OKOvertimeReqBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OKOvertimeReqBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.OKOvertimeReqBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OKOvertimeReqBoxC.Location=new System.Drawing.Point(140, 74);
            this.OKOvertimeReqBoxC.MaxLength=5;
            this.OKOvertimeReqBoxC.Name="OKOvertimeReqBoxC";
            this.OKOvertimeReqBoxC.ReadOnly=true;
            this.OKOvertimeReqBoxC.Size=new System.Drawing.Size(50, 23);
            this.OKOvertimeReqBoxC.TabIndex=182;
            this.OKOvertimeReqBoxC.Tag="24";
            this.OKOvertimeReqBoxC.Text="0";
            this.OKOvertimeReqBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.OKOvertimeReqBoxC.Click += new System.EventHandler(this.COKOvertimeReqBox_Click);
            // 
            // LabelC1
            // 
            this.LabelC1.AutoSize=true;
            this.LabelC1.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelC1.Location=new System.Drawing.Point(698, 23);
            this.LabelC1.Name="LabelC1";
            this.LabelC1.Size=new System.Drawing.Size(20, 19);
            this.LabelC1.TabIndex=181;
            this.LabelC1.Text="C";
            // 
            // LabelB1
            // 
            this.LabelB1.AutoSize=true;
            this.LabelB1.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelB1.Location=new System.Drawing.Point(642, 23);
            this.LabelB1.Name="LabelB1";
            this.LabelB1.Size=new System.Drawing.Size(20, 19);
            this.LabelB1.TabIndex=180;
            this.LabelB1.Text="B";
            // 
            // LabelA1
            // 
            this.LabelA1.AutoSize=true;
            this.LabelA1.Font=new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelA1.Location=new System.Drawing.Point(586, 23);
            this.LabelA1.Name="LabelA1";
            this.LabelA1.Size=new System.Drawing.Size(21, 19);
            this.LabelA1.TabIndex=179;
            this.LabelA1.Text="A";
            // 
            // ReservBoxA
            // 
            this.ReservBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReservBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ReservBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReservBoxA.Location=new System.Drawing.Point(571, 47);
            this.ReservBoxA.MaxLength=5;
            this.ReservBoxA.Name="ReservBoxA";
            this.ReservBoxA.ReadOnly=true;
            this.ReservBoxA.Size=new System.Drawing.Size(50, 23);
            this.ReservBoxA.TabIndex=178;
            this.ReservBoxA.Tag="01";
            this.ReservBoxA.Text="0";
            this.ReservBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.ReservBoxA.Click += new System.EventHandler(this.AReservBox_Click);
            // 
            // TripBoxA
            // 
            this.TripBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TripBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.TripBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TripBoxA.Location=new System.Drawing.Point(571, 74);
            this.TripBoxA.MaxLength=5;
            this.TripBoxA.Name="TripBoxA";
            this.TripBoxA.ReadOnly=true;
            this.TripBoxA.Size=new System.Drawing.Size(50, 23);
            this.TripBoxA.TabIndex=177;
            this.TripBoxA.Tag="04";
            this.TripBoxA.Text="0";
            this.TripBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TripBoxA.Click += new System.EventHandler(this.ATripBox_Click);
            // 
            // DelBoxA
            // 
            this.DelBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DelBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DelBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelBoxA.Location=new System.Drawing.Point(571, 101);
            this.DelBoxA.MaxLength=5;
            this.DelBoxA.Name="DelBoxA";
            this.DelBoxA.ReadOnly=true;
            this.DelBoxA.Size=new System.Drawing.Size(50, 23);
            this.DelBoxA.TabIndex=176;
            this.DelBoxA.Tag="07";
            this.DelBoxA.Text="0";
            this.DelBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.DelBoxA.Click += new System.EventHandler(this.ADelBox_Click);
            // 
            // NoTripBoxA
            // 
            this.NoTripBoxA.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NoTripBoxA.Cursor=System.Windows.Forms.Cursors.Hand;
            this.NoTripBoxA.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoTripBoxA.Location=new System.Drawing.Point(571, 128);
            this.NoTripBoxA.MaxLength=5;
            this.NoTripBoxA.Name="NoTripBoxA";
            this.NoTripBoxA.ReadOnly=true;
            this.NoTripBoxA.Size=new System.Drawing.Size(50, 23);
            this.NoTripBoxA.TabIndex=175;
            this.NoTripBoxA.Tag="10";
            this.NoTripBoxA.Text="0";
            this.NoTripBoxA.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.NoTripBoxA.Click += new System.EventHandler(this.ANoTripBox_Click);
            // 
            // ReservBoxB
            // 
            this.ReservBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReservBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ReservBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReservBoxB.Location=new System.Drawing.Point(627, 47);
            this.ReservBoxB.MaxLength=5;
            this.ReservBoxB.Name="ReservBoxB";
            this.ReservBoxB.ReadOnly=true;
            this.ReservBoxB.Size=new System.Drawing.Size(50, 23);
            this.ReservBoxB.TabIndex=174;
            this.ReservBoxB.Tag="02";
            this.ReservBoxB.Text="0";
            this.ReservBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.ReservBoxB.Click += new System.EventHandler(this.BReservBox_Click);
            // 
            // TripBoxB
            // 
            this.TripBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TripBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.TripBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TripBoxB.Location=new System.Drawing.Point(627, 74);
            this.TripBoxB.MaxLength=5;
            this.TripBoxB.Name="TripBoxB";
            this.TripBoxB.ReadOnly=true;
            this.TripBoxB.Size=new System.Drawing.Size(50, 23);
            this.TripBoxB.TabIndex=173;
            this.TripBoxB.Tag="05";
            this.TripBoxB.Text="0";
            this.TripBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TripBoxB.Click += new System.EventHandler(this.BTripBox_Click);
            // 
            // DelBoxB
            // 
            this.DelBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DelBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DelBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelBoxB.Location=new System.Drawing.Point(627, 101);
            this.DelBoxB.MaxLength=5;
            this.DelBoxB.Name="DelBoxB";
            this.DelBoxB.ReadOnly=true;
            this.DelBoxB.Size=new System.Drawing.Size(50, 23);
            this.DelBoxB.TabIndex=172;
            this.DelBoxB.Tag="08";
            this.DelBoxB.Text="0";
            this.DelBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.DelBoxB.Click += new System.EventHandler(this.BDelBox_Click);
            // 
            // NoTripBoxB
            // 
            this.NoTripBoxB.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NoTripBoxB.Cursor=System.Windows.Forms.Cursors.Hand;
            this.NoTripBoxB.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoTripBoxB.Location=new System.Drawing.Point(627, 128);
            this.NoTripBoxB.MaxLength=5;
            this.NoTripBoxB.Name="NoTripBoxB";
            this.NoTripBoxB.ReadOnly=true;
            this.NoTripBoxB.Size=new System.Drawing.Size(50, 23);
            this.NoTripBoxB.TabIndex=171;
            this.NoTripBoxB.Tag="11";
            this.NoTripBoxB.Text="0";
            this.NoTripBoxB.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.NoTripBoxB.Click += new System.EventHandler(this.BNoTripBox_Click);
            // 
            // ReservBoxC
            // 
            this.ReservBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ReservBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ReservBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReservBoxC.Location=new System.Drawing.Point(683, 47);
            this.ReservBoxC.MaxLength=5;
            this.ReservBoxC.Name="ReservBoxC";
            this.ReservBoxC.ReadOnly=true;
            this.ReservBoxC.Size=new System.Drawing.Size(50, 23);
            this.ReservBoxC.TabIndex=162;
            this.ReservBoxC.Tag="03";
            this.ReservBoxC.Text="0";
            this.ReservBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.ReservBoxC.Click += new System.EventHandler(this.CReservBox_Click);
            // 
            // ReservLabel
            // 
            this.ReservLabel.AutoSize=true;
            this.ReservLabel.Location=new System.Drawing.Point(734, 50);
            this.ReservLabel.Name="ReservLabel";
            this.ReservLabel.Size=new System.Drawing.Size(63, 16);
            this.ReservLabel.TabIndex=164;
            this.ReservLabel.Tag="01";
            this.ReservLabel.Text="تعداد رزرو:";
            // 
            // TripBoxC
            // 
            this.TripBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TripBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.TripBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TripBoxC.Location=new System.Drawing.Point(683, 74);
            this.TripBoxC.MaxLength=5;
            this.TripBoxC.Name="TripBoxC";
            this.TripBoxC.ReadOnly=true;
            this.TripBoxC.Size=new System.Drawing.Size(50, 23);
            this.TripBoxC.TabIndex=147;
            this.TripBoxC.Tag="06";
            this.TripBoxC.Text="0";
            this.TripBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.TripBoxC.Click += new System.EventHandler(this.CTripBox_Click);
            // 
            // DelBoxC
            // 
            this.DelBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DelBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.DelBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DelBoxC.Location=new System.Drawing.Point(683, 101);
            this.DelBoxC.MaxLength=5;
            this.DelBoxC.Name="DelBoxC";
            this.DelBoxC.ReadOnly=true;
            this.DelBoxC.Size=new System.Drawing.Size(50, 23);
            this.DelBoxC.TabIndex=145;
            this.DelBoxC.Tag="09";
            this.DelBoxC.Text="0";
            this.DelBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.DelBoxC.Click += new System.EventHandler(this.CDelBox_Click);
            // 
            // TimeLeaveLabel
            // 
            this.TimeLeaveLabel.AutoSize=true;
            this.TimeLeaveLabel.Location=new System.Drawing.Point(734, 158);
            this.TimeLeaveLabel.Name="TimeLeaveLabel";
            this.TimeLeaveLabel.Size=new System.Drawing.Size(134, 16);
            this.TimeLeaveLabel.TabIndex=165;
            this.TimeLeaveLabel.Tag="05";
            this.TimeLeaveLabel.Text="تعداد مرخصی ساعتی:";
            // 
            // NoTripBoxC
            // 
            this.NoTripBoxC.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NoTripBoxC.Cursor=System.Windows.Forms.Cursors.Hand;
            this.NoTripBoxC.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoTripBoxC.Location=new System.Drawing.Point(683, 128);
            this.NoTripBoxC.MaxLength=5;
            this.NoTripBoxC.Name="NoTripBoxC";
            this.NoTripBoxC.ReadOnly=true;
            this.NoTripBoxC.Size=new System.Drawing.Size(50, 23);
            this.NoTripBoxC.TabIndex=141;
            this.NoTripBoxC.Tag="12";
            this.NoTripBoxC.Text="0";
            this.NoTripBoxC.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.NoTripBoxC.Click += new System.EventHandler(this.CNoTripBox_Click);
            // 
            // DelLabel
            // 
            this.DelLabel.AutoSize=true;
            this.DelLabel.Location=new System.Drawing.Point(734, 104);
            this.DelLabel.Name="DelLabel";
            this.DelLabel.Size=new System.Drawing.Size(108, 16);
            this.DelLabel.TabIndex=134;
            this.DelLabel.Tag="03";
            this.DelLabel.Text="تعداد حذفیات رزرو:";
            // 
            // HamLabel
            // 
            this.HamLabel.AutoSize=true;
            this.HamLabel.Location=new System.Drawing.Point(190, 104);
            this.HamLabel.Name="HamLabel";
            this.HamLabel.Size=new System.Drawing.Size(165, 16);
            this.HamLabel.TabIndex=140;
            this.HamLabel.Tag="09";
            this.HamLabel.Text="تعداد اضافه کار (غیر کشیک):";
            // 
            // NoReqLabel
            // 
            this.NoReqLabel.AutoSize=true;
            this.NoReqLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoReqLabel.Location=new System.Drawing.Point(190, 185);
            this.NoReqLabel.Name="NoReqLabel";
            this.NoReqLabel.Size=new System.Drawing.Size(319, 16);
            this.NoReqLabel.TabIndex=133;
            this.NoReqLabel.Tag="12";
            this.NoReqLabel.Text=" تعداد اضافه کار خارج از نوبت با وجود درخواست اضافه کار:";
            // 
            // DailyLeaveLabel
            // 
            this.DailyLeaveLabel.AutoSize=true;
            this.DailyLeaveLabel.Location=new System.Drawing.Point(734, 185);
            this.DailyLeaveLabel.Name="DailyLeaveLabel";
            this.DailyLeaveLabel.Size=new System.Drawing.Size(120, 16);
            this.DailyLeaveLabel.TabIndex=139;
            this.DailyLeaveLabel.Tag="06";
            this.DailyLeaveLabel.Text="تعداد مرخصی روزانه:";
            // 
            // OKOvertimeReqLabel
            // 
            this.OKOvertimeReqLabel.AutoSize=true;
            this.OKOvertimeReqLabel.Location=new System.Drawing.Point(190, 77);
            this.OKOvertimeReqLabel.Name="OKOvertimeReqLabel";
            this.OKOvertimeReqLabel.Size=new System.Drawing.Size(210, 16);
            this.OKOvertimeReqLabel.TabIndex=116;
            this.OKOvertimeReqLabel.Tag="08";
            this.OKOvertimeReqLabel.Text="تعداد اضافه کار درخواستی ثبت شده:";
            // 
            // OvertimeReqLabel
            // 
            this.OvertimeReqLabel.AutoSize=true;
            this.OvertimeReqLabel.Location=new System.Drawing.Point(190, 50);
            this.OvertimeReqLabel.Name="OvertimeReqLabel";
            this.OvertimeReqLabel.Size=new System.Drawing.Size(149, 16);
            this.OvertimeReqLabel.TabIndex=117;
            this.OvertimeReqLabel.Tag="07";
            this.OvertimeReqLabel.Text="تعداد درخواست اضافه کار:";
            // 
            // OvertimeEctLabel
            // 
            this.OvertimeEctLabel.AutoSize=true;
            this.OvertimeEctLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OvertimeEctLabel.Location=new System.Drawing.Point(190, 158);
            this.OvertimeEctLabel.Name="OvertimeEctLabel";
            this.OvertimeEctLabel.Size=new System.Drawing.Size(272, 16);
            this.OvertimeEctLabel.TabIndex=125;
            this.OvertimeEctLabel.Tag="11";
            this.OvertimeEctLabel.Text="تعداد جایگزین مرخصی خارج از نوبت با وجود رزرو:";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize=true;
            this.FridayLabel.Location=new System.Drawing.Point(190, 131);
            this.FridayLabel.Name="FridayLabel";
            this.FridayLabel.Size=new System.Drawing.Size(207, 16);
            this.FridayLabel.TabIndex=130;
            this.FridayLabel.Tag="10";
            this.FridayLabel.Text="تعداد اضافه کار جمعه (خارج از نویت):";
            // 
            // TripLabel
            // 
            this.TripLabel.AutoSize=true;
            this.TripLabel.Location=new System.Drawing.Point(734, 77);
            this.TripLabel.Name="TripLabel";
            this.TripLabel.Size=new System.Drawing.Size(92, 16);
            this.TripLabel.TabIndex=136;
            this.TripLabel.Tag="02";
            this.TripLabel.Text="تعداد تریپ رزرو:";
            // 
            // NoTripLabel
            // 
            this.NoTripLabel.AutoSize=true;
            this.NoTripLabel.Location=new System.Drawing.Point(734, 131);
            this.NoTripLabel.Name="NoTripLabel";
            this.NoTripLabel.Size=new System.Drawing.Size(122, 16);
            this.NoTripLabel.TabIndex=135;
            this.NoTripLabel.Tag="04";
            this.NoTripLabel.Text="تعداد رزرو تریپ نرفته:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.LabelT4);
            this.Panel1.Controls.Add(this.LabelT2);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.LabelT9);
            this.Panel1.Controls.Add(this.LabelT14);
            this.Panel1.ForeColor=System.Drawing.Color.Black;
            this.Panel1.Location=new System.Drawing.Point(12, 15);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(892, 92);
            this.Panel1.TabIndex=51;
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location=new System.Drawing.Point(458, 50);
            this.EndCalendar.Miladi=new System.DateTime(((long)(0)));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex=61;
            this.EndCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location=new System.Drawing.Point(458, 16);
            this.StartCalendar.Miladi=new System.DateTime(((long)(0)));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex=60;
            this.StartCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelT4
            // 
            this.LabelT4.AutoSize=true;
            this.LabelT4.Location=new System.Drawing.Point(586, 53);
            this.LabelT4.Name="LabelT4";
            this.LabelT4.Size=new System.Drawing.Size(51, 16);
            this.LabelT4.TabIndex=54;
            this.LabelT4.Text="تا تاریخ:";
            // 
            // LabelT2
            // 
            this.LabelT2.AutoSize=true;
            this.LabelT2.Location=new System.Drawing.Point(586, 19);
            this.LabelT2.Name="LabelT2";
            this.LabelT2.Size=new System.Drawing.Size(51, 16);
            this.LabelT2.TabIndex=52;
            this.LabelT2.Text="از تاریخ:";
            // 
            // TimeCombo
            // 
            this.TimeCombo.BackColor=System.Drawing.Color.White;
            this.TimeCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Items.AddRange(new object[] {
            "همه موارد",
            "9 ساعته",
            "12 ساعته"});
            this.TimeCombo.Location=new System.Drawing.Point(687, 49);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(109, 24);
            this.TimeCombo.TabIndex=49;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // LocalCombo
            // 
            this.LocalCombo.BackColor=System.Drawing.Color.White;
            this.LocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(687, 15);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(109, 24);
            this.LocalCombo.TabIndex=48;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.ExportButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(31, 27);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(140, 34);
            this.ExportButton.TabIndex=5;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location=new System.Drawing.Point(189, 27);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(140, 34);
            this.ShowButton.TabIndex=4;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // LabelT9
            // 
            this.LabelT9.AutoSize=true;
            this.LabelT9.BackColor=System.Drawing.Color.Transparent;
            this.LabelT9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelT9.ForeColor=System.Drawing.Color.Black;
            this.LabelT9.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.LabelT9.Location=new System.Drawing.Point(795, 53);
            this.LabelT9.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelT9.Name="LabelT9";
            this.LabelT9.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.LabelT9.Size=new System.Drawing.Size(72, 16);
            this.LabelT9.TabIndex=50;
            this.LabelT9.Text="نوع شیفت:";
            this.LabelT9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelT14
            // 
            this.LabelT14.AutoSize=true;
            this.LabelT14.Location=new System.Drawing.Point(794, 19);
            this.LabelT14.Name="LabelT14";
            this.LabelT14.Size=new System.Drawing.Size(35, 16);
            this.LabelT14.TabIndex=47;
            this.LabelT14.Text="مبدا:";
            // 
            // Label50
            // 
            this.Label50.BackColor=System.Drawing.Color.Black;
            this.Label50.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label50.Cursor=System.Windows.Forms.Cursors.Default;
            this.Label50.Location=new System.Drawing.Point(783, 123);
            this.Label50.Name="Label50";
            this.Label50.Size=new System.Drawing.Size(107, 22);
            this.Label50.TabIndex=212;
            this.Label50.Text="9 ساعته ";
            this.Label50.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label51
            // 
            this.Label51.BackColor=System.Drawing.Color.Black;
            this.Label51.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label51.ForeColor=System.Drawing.Color.White;
            this.Label51.Location=new System.Drawing.Point(214, 380);
            this.Label51.Name="Label51";
            this.Label51.Size=new System.Drawing.Size(491, 25);
            this.Label51.TabIndex=213;
            this.Label51.Text="----------     برای دیدن جزئیات بیشتر بر روی عدد مورد نظر دابل کلیک کنید     ----" +
    "------";
            this.Label51.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageShiftStatisticsForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(918, 412);
            this.Controls.Add(this.Label51);
            this.Controls.Add(this.TitrLabel);
            this.Controls.Add(this.Label50);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel5);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton=true;
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ManageShiftStatisticsForm";
            this.ShowIcon=false;
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="گزارش آماری شیفت ها";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ManageShiftStatisticsForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.ManageStatisticsForm_Load);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		private Label TitrLabel;
		private Panel Panel5;
		private TextBox ReservBoxC;
		private Label ReservLabel;
		private TextBox TripBoxC;
		private TextBox DelBoxC;
		private Label TimeLeaveLabel;
		private TextBox NoTripBoxC;
		private Label DelLabel;
		private Label HamLabel;
		private Label NoReqLabel;
		private Label DailyLeaveLabel;
		private Label OKOvertimeReqLabel;
		private Label OvertimeReqLabel;
		private Label OvertimeEctLabel;
		private Label FridayLabel;
		private Label TripLabel;
		private Label NoTripLabel;
		private Label LabelC2;
		private Label LabelB2;
		private Label LabelA2;
		private TextBox HamBoxA;
		private TextBox FridayBoxA;
		private TextBox OvertimeEctBoxA;
		private TextBox NoReqBoxA;
		private TextBox HamBoxB;
		private TextBox FridayBoxB;
		private TextBox OvertimeEctBoxB;
		private TextBox NoReqBoxB;
		private TextBox HamBoxC;
		private TextBox FridayBoxC;
		private TextBox OvertimeEctBoxC;
		private TextBox NoReqBoxC;
		private TextBox TimeLeaveBoxA;
		private TextBox DailyLeaveBoxA;
		private TextBox OvertimeReqBoxA;
		private TextBox OKOvertimeReqBoxA;
		private TextBox TimeLeaveBoxB;
		private TextBox DailyLeaveBoxB;
		private TextBox OvertimeReqBoxB;
		private TextBox OKOvertimeReqBoxB;
		private TextBox TimeLeaveBoxC;
		private TextBox DailyLeaveBoxC;
		private TextBox OvertimeReqBoxC;
		private TextBox OKOvertimeReqBoxC;
		private Label LabelC1;
		private Label LabelB1;
		private Label LabelA1;
		private TextBox ReservBoxA;
		private TextBox TripBoxA;
		private TextBox DelBoxA;
		private TextBox NoTripBoxA;
		private TextBox ReservBoxB;
		private TextBox TripBoxB;
		private TextBox DelBoxB;
		private TextBox NoTripBoxB;
		private Panel Panel1;
		private ComboBox LocalCombo;
		private Button ExportButton;
		private Button ShowButton;
		private Label LabelT14;
		private Label Label50;
		private ComboBox TimeCombo;
		private Label LabelT9;
		private Label LabelT4;
		private Label LabelT2;
		private Label Label51;
		private BPersianCalender.BPersianCalenderTextBox EndCalendar;
		private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private System.ComponentModel.IContainer components;
    }
	
}
