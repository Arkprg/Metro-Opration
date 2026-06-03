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
    partial class CalendarFormAD : BaseForm
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
            this.PanelA2=new System.Windows.Forms.Panel();
            this.Panel42=new System.Windows.Forms.Panel();
            this.Label124=new System.Windows.Forms.Label();
            this.Label125=new System.Windows.Forms.Label();
            this.LabelD42=new System.Windows.Forms.Label();
            this.Panel35=new System.Windows.Forms.Panel();
            this.Label103=new System.Windows.Forms.Label();
            this.Label104=new System.Windows.Forms.Label();
            this.LabelD35=new System.Windows.Forms.Label();
            this.Panel28=new System.Windows.Forms.Panel();
            this.Label82=new System.Windows.Forms.Label();
            this.Label83=new System.Windows.Forms.Label();
            this.LabelD28=new System.Windows.Forms.Label();
            this.Panel14=new System.Windows.Forms.Panel();
            this.Label40=new System.Windows.Forms.Label();
            this.Label41=new System.Windows.Forms.Label();
            this.LabelD14=new System.Windows.Forms.Label();
            this.Panel21=new System.Windows.Forms.Panel();
            this.Label79=new System.Windows.Forms.Label();
            this.Label80=new System.Windows.Forms.Label();
            this.LabelD21=new System.Windows.Forms.Label();
            this.Panel41=new System.Windows.Forms.Panel();
            this.Label121=new System.Windows.Forms.Label();
            this.Label122=new System.Windows.Forms.Label();
            this.LabelD41=new System.Windows.Forms.Label();
            this.Panel7=new System.Windows.Forms.Panel();
            this.Label19=new System.Windows.Forms.Label();
            this.Label20=new System.Windows.Forms.Label();
            this.LabelD7=new System.Windows.Forms.Label();
            this.Panel34=new System.Windows.Forms.Panel();
            this.Label100=new System.Windows.Forms.Label();
            this.Label101=new System.Windows.Forms.Label();
            this.LabelD34=new System.Windows.Forms.Label();
            this.Panel39=new System.Windows.Forms.Panel();
            this.Label118=new System.Windows.Forms.Label();
            this.Label119=new System.Windows.Forms.Label();
            this.LabelD39=new System.Windows.Forms.Label();
            this.Panel27=new System.Windows.Forms.Panel();
            this.Label76=new System.Windows.Forms.Label();
            this.Label77=new System.Windows.Forms.Label();
            this.LabelD27=new System.Windows.Forms.Label();
            this.Panel32=new System.Windows.Forms.Panel();
            this.Label97=new System.Windows.Forms.Label();
            this.Label98=new System.Windows.Forms.Label();
            this.LabelD32=new System.Windows.Forms.Label();
            this.Panel13=new System.Windows.Forms.Panel();
            this.Label37=new System.Windows.Forms.Label();
            this.Label38=new System.Windows.Forms.Label();
            this.LabelD13=new System.Windows.Forms.Label();
            this.Panel25=new System.Windows.Forms.Panel();
            this.Label73=new System.Windows.Forms.Label();
            this.Label74=new System.Windows.Forms.Label();
            this.LabelD25=new System.Windows.Forms.Label();
            this.Panel40=new System.Windows.Forms.Panel();
            this.Label115=new System.Windows.Forms.Label();
            this.Label116=new System.Windows.Forms.Label();
            this.LabelD40=new System.Windows.Forms.Label();
            this.Panel11=new System.Windows.Forms.Panel();
            this.Label34=new System.Windows.Forms.Label();
            this.Label35=new System.Windows.Forms.Label();
            this.LabelD11=new System.Windows.Forms.Label();
            this.Panel33=new System.Windows.Forms.Panel();
            this.Label94=new System.Windows.Forms.Label();
            this.Label95=new System.Windows.Forms.Label();
            this.LabelD33=new System.Windows.Forms.Label();
            this.Panel20=new System.Windows.Forms.Panel();
            this.Label70=new System.Windows.Forms.Label();
            this.Label71=new System.Windows.Forms.Label();
            this.LabelD20=new System.Windows.Forms.Label();
            this.Panel26=new System.Windows.Forms.Panel();
            this.Label67=new System.Windows.Forms.Label();
            this.Label68=new System.Windows.Forms.Label();
            this.LabelD26=new System.Windows.Forms.Label();
            this.Panel6=new System.Windows.Forms.Panel();
            this.Label16=new System.Windows.Forms.Label();
            this.Label17=new System.Windows.Forms.Label();
            this.LabelD6=new System.Windows.Forms.Label();
            this.Panel38=new System.Windows.Forms.Panel();
            this.Label112=new System.Windows.Forms.Label();
            this.Label113=new System.Windows.Forms.Label();
            this.LabelD38=new System.Windows.Forms.Label();
            this.Panel18=new System.Windows.Forms.Panel();
            this.Label64=new System.Windows.Forms.Label();
            this.Label65=new System.Windows.Forms.Label();
            this.LabelD18=new System.Windows.Forms.Label();
            this.Panel31=new System.Windows.Forms.Panel();
            this.Label91=new System.Windows.Forms.Label();
            this.Label92=new System.Windows.Forms.Label();
            this.LabelD31=new System.Windows.Forms.Label();
            this.Panel12=new System.Windows.Forms.Panel();
            this.Label31=new System.Windows.Forms.Label();
            this.Label32=new System.Windows.Forms.Label();
            this.LabelD12=new System.Windows.Forms.Label();
            this.Panel24=new System.Windows.Forms.Panel();
            this.Label61=new System.Windows.Forms.Label();
            this.Label62=new System.Windows.Forms.Label();
            this.LabelD24=new System.Windows.Forms.Label();
            this.Panel4=new System.Windows.Forms.Panel();
            this.Label10=new System.Windows.Forms.Label();
            this.Label11=new System.Windows.Forms.Label();
            this.LabelD4=new System.Windows.Forms.Label();
            this.Panel37=new System.Windows.Forms.Panel();
            this.Label109=new System.Windows.Forms.Label();
            this.Label110=new System.Windows.Forms.Label();
            this.LabelD37=new System.Windows.Forms.Label();
            this.Panel19=new System.Windows.Forms.Panel();
            this.Label58=new System.Windows.Forms.Label();
            this.Label59=new System.Windows.Forms.Label();
            this.LabelD19=new System.Windows.Forms.Label();
            this.Panel30=new System.Windows.Forms.Panel();
            this.Label88=new System.Windows.Forms.Label();
            this.Label89=new System.Windows.Forms.Label();
            this.LabelD30=new System.Windows.Forms.Label();
            this.Panel10=new System.Windows.Forms.Panel();
            this.Label28=new System.Windows.Forms.Label();
            this.Label29=new System.Windows.Forms.Label();
            this.LabelD10=new System.Windows.Forms.Label();
            this.Panel23=new System.Windows.Forms.Panel();
            this.Label55=new System.Windows.Forms.Label();
            this.Label56=new System.Windows.Forms.Label();
            this.LabelD23=new System.Windows.Forms.Label();
            this.Panel5=new System.Windows.Forms.Panel();
            this.Label13=new System.Windows.Forms.Label();
            this.Label14=new System.Windows.Forms.Label();
            this.LabelD5=new System.Windows.Forms.Label();
            this.Panel36=new System.Windows.Forms.Panel();
            this.Label106=new System.Windows.Forms.Label();
            this.Label107=new System.Windows.Forms.Label();
            this.LabelD36=new System.Windows.Forms.Label();
            this.Panel17=new System.Windows.Forms.Panel();
            this.Label52=new System.Windows.Forms.Label();
            this.Label53=new System.Windows.Forms.Label();
            this.LabelD17=new System.Windows.Forms.Label();
            this.Panel29=new System.Windows.Forms.Panel();
            this.Label85=new System.Windows.Forms.Label();
            this.Label86=new System.Windows.Forms.Label();
            this.LabelD29=new System.Windows.Forms.Label();
            this.Panel9=new System.Windows.Forms.Panel();
            this.Label25=new System.Windows.Forms.Label();
            this.Label26=new System.Windows.Forms.Label();
            this.LabelD9=new System.Windows.Forms.Label();
            this.Panel22=new System.Windows.Forms.Panel();
            this.Label49=new System.Windows.Forms.Label();
            this.Label50=new System.Windows.Forms.Label();
            this.LabelD22=new System.Windows.Forms.Label();
            this.Panel3=new System.Windows.Forms.Panel();
            this.Label7=new System.Windows.Forms.Label();
            this.Label8=new System.Windows.Forms.Label();
            this.LabelD3=new System.Windows.Forms.Label();
            this.Panel16=new System.Windows.Forms.Panel();
            this.Label46=new System.Windows.Forms.Label();
            this.Label47=new System.Windows.Forms.Label();
            this.LabelD16=new System.Windows.Forms.Label();
            this.Panel8=new System.Windows.Forms.Panel();
            this.Label22=new System.Windows.Forms.Label();
            this.Label23=new System.Windows.Forms.Label();
            this.LabelD8=new System.Windows.Forms.Label();
            this.Panel15=new System.Windows.Forms.Panel();
            this.Label43=new System.Windows.Forms.Label();
            this.Label44=new System.Windows.Forms.Label();
            this.LabelD15=new System.Windows.Forms.Label();
            this.Panel2=new System.Windows.Forms.Panel();
            this.Label4=new System.Windows.Forms.Label();
            this.Label5=new System.Windows.Forms.Label();
            this.LabelD2=new System.Windows.Forms.Label();
            this.Panel1=new System.Windows.Forms.Panel();
            this.Label3=new System.Windows.Forms.Label();
            this.Label2=new System.Windows.Forms.Label();
            this.LabelD1=new System.Windows.Forms.Label();
            this.NextButton=new System.Windows.Forms.Button();
            this.PervButton=new System.Windows.Forms.Button();
            this.Label07=new System.Windows.Forms.Label();
            this.Label06=new System.Windows.Forms.Label();
            this.Label05=new System.Windows.Forms.Label();
            this.Label04=new System.Windows.Forms.Label();
            this.Label03=new System.Windows.Forms.Label();
            this.Label02=new System.Windows.Forms.Label();
            this.Label01=new System.Windows.Forms.Label();
            this.MainLabel=new System.Windows.Forms.Label();
            this.PanelA1=new System.Windows.Forms.Panel();
            this.LabelPerDate=new System.Windows.Forms.Label();
            this.Label132=new System.Windows.Forms.Label();
            this.LabelG1=new System.Windows.Forms.Label();
            this.LabelG2=new System.Windows.Forms.Label();
            this.LabelG4=new System.Windows.Forms.Label();
            this.Label1333=new System.Windows.Forms.Label();
            this.LabelG3=new System.Windows.Forms.Label();
            this.Label127=new System.Windows.Forms.Label();
            this.Label128=new System.Windows.Forms.Label();
            this.LabelHejDate=new System.Windows.Forms.Label();
            this.LabelMilDate=new System.Windows.Forms.Label();
            this.panel43=new System.Windows.Forms.Panel();
            this.panel44=new System.Windows.Forms.Panel();
            this.panel45=new System.Windows.Forms.Panel();
            this.PanelA2.SuspendLayout();
            this.Panel42.SuspendLayout();
            this.Panel35.SuspendLayout();
            this.Panel28.SuspendLayout();
            this.Panel14.SuspendLayout();
            this.Panel21.SuspendLayout();
            this.Panel41.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel34.SuspendLayout();
            this.Panel39.SuspendLayout();
            this.Panel27.SuspendLayout();
            this.Panel32.SuspendLayout();
            this.Panel13.SuspendLayout();
            this.Panel25.SuspendLayout();
            this.Panel40.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.Panel33.SuspendLayout();
            this.Panel20.SuspendLayout();
            this.Panel26.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel38.SuspendLayout();
            this.Panel18.SuspendLayout();
            this.Panel31.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Panel24.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel37.SuspendLayout();
            this.Panel19.SuspendLayout();
            this.Panel30.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel23.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel36.SuspendLayout();
            this.Panel17.SuspendLayout();
            this.Panel29.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel22.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel16.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel15.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.PanelA1.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel44.SuspendLayout();
            this.panel45.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelA2
            // 
            this.PanelA2.BackColor=System.Drawing.Color.White;
            this.PanelA2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelA2.Controls.Add(this.Panel42);
            this.PanelA2.Controls.Add(this.Panel35);
            this.PanelA2.Controls.Add(this.Panel28);
            this.PanelA2.Controls.Add(this.Panel14);
            this.PanelA2.Controls.Add(this.Panel21);
            this.PanelA2.Controls.Add(this.Panel41);
            this.PanelA2.Controls.Add(this.Panel7);
            this.PanelA2.Controls.Add(this.Panel34);
            this.PanelA2.Controls.Add(this.Panel39);
            this.PanelA2.Controls.Add(this.Panel27);
            this.PanelA2.Controls.Add(this.Panel32);
            this.PanelA2.Controls.Add(this.Panel13);
            this.PanelA2.Controls.Add(this.Panel25);
            this.PanelA2.Controls.Add(this.Panel40);
            this.PanelA2.Controls.Add(this.Panel11);
            this.PanelA2.Controls.Add(this.Panel33);
            this.PanelA2.Controls.Add(this.Panel20);
            this.PanelA2.Controls.Add(this.Panel26);
            this.PanelA2.Controls.Add(this.Panel6);
            this.PanelA2.Controls.Add(this.Panel38);
            this.PanelA2.Controls.Add(this.Panel18);
            this.PanelA2.Controls.Add(this.Panel31);
            this.PanelA2.Controls.Add(this.Panel12);
            this.PanelA2.Controls.Add(this.Panel24);
            this.PanelA2.Controls.Add(this.Panel4);
            this.PanelA2.Controls.Add(this.Panel37);
            this.PanelA2.Controls.Add(this.Panel19);
            this.PanelA2.Controls.Add(this.Panel30);
            this.PanelA2.Controls.Add(this.Panel10);
            this.PanelA2.Controls.Add(this.Panel23);
            this.PanelA2.Controls.Add(this.Panel5);
            this.PanelA2.Controls.Add(this.Panel36);
            this.PanelA2.Controls.Add(this.Panel17);
            this.PanelA2.Controls.Add(this.Panel29);
            this.PanelA2.Controls.Add(this.Panel9);
            this.PanelA2.Controls.Add(this.Panel22);
            this.PanelA2.Controls.Add(this.Panel3);
            this.PanelA2.Controls.Add(this.Panel16);
            this.PanelA2.Controls.Add(this.Panel8);
            this.PanelA2.Controls.Add(this.Panel15);
            this.PanelA2.Controls.Add(this.Panel2);
            this.PanelA2.Controls.Add(this.Panel1);
            this.PanelA2.Location=new System.Drawing.Point(342, 103);
            this.PanelA2.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelA2.Name="PanelA2";
            this.PanelA2.Size=new System.Drawing.Size(422, 356);
            this.PanelA2.TabIndex=53;
            // 
            // Panel42
            // 
            this.Panel42.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel42.Controls.Add(this.Label124);
            this.Panel42.Controls.Add(this.Label125);
            this.Panel42.Controls.Add(this.LabelD42);
            this.Panel42.Location=new System.Drawing.Point(0, 295);
            this.Panel42.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel42.Name="Panel42";
            this.Panel42.Size=new System.Drawing.Size(61, 60);
            this.Panel42.TabIndex=1;
            // 
            // Label124
            // 
            this.Label124.BackColor=System.Drawing.Color.Transparent;
            this.Label124.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label124.Location=new System.Drawing.Point(-1, 37);
            this.Label124.Name="Label124";
            this.Label124.Size=new System.Drawing.Size(22, 22);
            this.Label124.TabIndex=0;
            this.Label124.Text="B";
            this.Label124.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label124.Visible=false;
            this.Label124.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label125
            // 
            this.Label125.BackColor=System.Drawing.Color.Transparent;
            this.Label125.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label125.Location=new System.Drawing.Point(37, 37);
            this.Label125.Name="Label125";
            this.Label125.Size=new System.Drawing.Size(22, 22);
            this.Label125.TabIndex=0;
            this.Label125.Text="A";
            this.Label125.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label125.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD42
            // 
            this.LabelD42.BackColor=System.Drawing.Color.Transparent;
            this.LabelD42.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD42.Location=new System.Drawing.Point(-6, -6);
            this.LabelD42.Name="LabelD42";
            this.LabelD42.Size=new System.Drawing.Size(70, 70);
            this.LabelD42.TabIndex=0;
            this.LabelD42.Text="25";
            this.LabelD42.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD42.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel35
            // 
            this.Panel35.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel35.Controls.Add(this.Label103);
            this.Panel35.Controls.Add(this.Label104);
            this.Panel35.Controls.Add(this.LabelD35);
            this.Panel35.Location=new System.Drawing.Point(0, 236);
            this.Panel35.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel35.Name="Panel35";
            this.Panel35.Size=new System.Drawing.Size(61, 60);
            this.Panel35.TabIndex=1;
            // 
            // Label103
            // 
            this.Label103.BackColor=System.Drawing.Color.Transparent;
            this.Label103.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label103.Location=new System.Drawing.Point(-1, 37);
            this.Label103.Name="Label103";
            this.Label103.Size=new System.Drawing.Size(22, 22);
            this.Label103.TabIndex=0;
            this.Label103.Text="B";
            this.Label103.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label103.Visible=false;
            this.Label103.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label104
            // 
            this.Label104.BackColor=System.Drawing.Color.Transparent;
            this.Label104.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label104.Location=new System.Drawing.Point(37, 37);
            this.Label104.Name="Label104";
            this.Label104.Size=new System.Drawing.Size(22, 22);
            this.Label104.TabIndex=0;
            this.Label104.Text="A";
            this.Label104.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label104.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD35
            // 
            this.LabelD35.BackColor=System.Drawing.Color.Transparent;
            this.LabelD35.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD35.Location=new System.Drawing.Point(-6, -6);
            this.LabelD35.Name="LabelD35";
            this.LabelD35.Size=new System.Drawing.Size(70, 70);
            this.LabelD35.TabIndex=0;
            this.LabelD35.Text="25";
            this.LabelD35.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD35.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel28
            // 
            this.Panel28.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel28.Controls.Add(this.Label82);
            this.Panel28.Controls.Add(this.Label83);
            this.Panel28.Controls.Add(this.LabelD28);
            this.Panel28.Location=new System.Drawing.Point(0, 177);
            this.Panel28.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel28.Name="Panel28";
            this.Panel28.Size=new System.Drawing.Size(61, 60);
            this.Panel28.TabIndex=1;
            // 
            // Label82
            // 
            this.Label82.BackColor=System.Drawing.Color.Transparent;
            this.Label82.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label82.Location=new System.Drawing.Point(-1, 37);
            this.Label82.Name="Label82";
            this.Label82.Size=new System.Drawing.Size(22, 22);
            this.Label82.TabIndex=0;
            this.Label82.Text="B";
            this.Label82.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label82.Visible=false;
            this.Label82.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label83
            // 
            this.Label83.BackColor=System.Drawing.Color.Transparent;
            this.Label83.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label83.Location=new System.Drawing.Point(37, 37);
            this.Label83.Name="Label83";
            this.Label83.Size=new System.Drawing.Size(22, 22);
            this.Label83.TabIndex=0;
            this.Label83.Text="A";
            this.Label83.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label83.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD28
            // 
            this.LabelD28.BackColor=System.Drawing.Color.Transparent;
            this.LabelD28.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD28.Location=new System.Drawing.Point(-6, -6);
            this.LabelD28.Name="LabelD28";
            this.LabelD28.Size=new System.Drawing.Size(70, 70);
            this.LabelD28.TabIndex=0;
            this.LabelD28.Text="25";
            this.LabelD28.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD28.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel14
            // 
            this.Panel14.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel14.Controls.Add(this.Label40);
            this.Panel14.Controls.Add(this.Label41);
            this.Panel14.Controls.Add(this.LabelD14);
            this.Panel14.Location=new System.Drawing.Point(0, 59);
            this.Panel14.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel14.Name="Panel14";
            this.Panel14.Size=new System.Drawing.Size(61, 60);
            this.Panel14.TabIndex=1;
            // 
            // Label40
            // 
            this.Label40.BackColor=System.Drawing.Color.Transparent;
            this.Label40.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label40.Location=new System.Drawing.Point(-1, 37);
            this.Label40.Name="Label40";
            this.Label40.Size=new System.Drawing.Size(22, 22);
            this.Label40.TabIndex=0;
            this.Label40.Text="B";
            this.Label40.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label40.Visible=false;
            this.Label40.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label41
            // 
            this.Label41.BackColor=System.Drawing.Color.Transparent;
            this.Label41.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location=new System.Drawing.Point(37, 37);
            this.Label41.Name="Label41";
            this.Label41.Size=new System.Drawing.Size(22, 22);
            this.Label41.TabIndex=0;
            this.Label41.Text="A";
            this.Label41.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label41.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD14
            // 
            this.LabelD14.BackColor=System.Drawing.Color.Transparent;
            this.LabelD14.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD14.Location=new System.Drawing.Point(-6, -6);
            this.LabelD14.Name="LabelD14";
            this.LabelD14.Size=new System.Drawing.Size(70, 70);
            this.LabelD14.TabIndex=0;
            this.LabelD14.Text="25";
            this.LabelD14.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD14.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel21
            // 
            this.Panel21.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel21.Controls.Add(this.Label79);
            this.Panel21.Controls.Add(this.Label80);
            this.Panel21.Controls.Add(this.LabelD21);
            this.Panel21.Location=new System.Drawing.Point(0, 118);
            this.Panel21.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel21.Name="Panel21";
            this.Panel21.Size=new System.Drawing.Size(61, 60);
            this.Panel21.TabIndex=1;
            // 
            // Label79
            // 
            this.Label79.BackColor=System.Drawing.Color.Transparent;
            this.Label79.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label79.Location=new System.Drawing.Point(-1, 37);
            this.Label79.Name="Label79";
            this.Label79.Size=new System.Drawing.Size(22, 22);
            this.Label79.TabIndex=0;
            this.Label79.Text="B";
            this.Label79.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label79.Visible=false;
            this.Label79.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label80
            // 
            this.Label80.BackColor=System.Drawing.Color.Transparent;
            this.Label80.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label80.Location=new System.Drawing.Point(37, 37);
            this.Label80.Name="Label80";
            this.Label80.Size=new System.Drawing.Size(22, 22);
            this.Label80.TabIndex=0;
            this.Label80.Text="A";
            this.Label80.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label80.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD21
            // 
            this.LabelD21.BackColor=System.Drawing.Color.Transparent;
            this.LabelD21.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD21.Location=new System.Drawing.Point(-6, -6);
            this.LabelD21.Name="LabelD21";
            this.LabelD21.Size=new System.Drawing.Size(70, 70);
            this.LabelD21.TabIndex=0;
            this.LabelD21.Text="25";
            this.LabelD21.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD21.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel41
            // 
            this.Panel41.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel41.Controls.Add(this.Label121);
            this.Panel41.Controls.Add(this.Label122);
            this.Panel41.Controls.Add(this.LabelD41);
            this.Panel41.Location=new System.Drawing.Point(59, 295);
            this.Panel41.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel41.Name="Panel41";
            this.Panel41.Size=new System.Drawing.Size(61, 60);
            this.Panel41.TabIndex=1;
            // 
            // Label121
            // 
            this.Label121.BackColor=System.Drawing.Color.Transparent;
            this.Label121.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label121.Location=new System.Drawing.Point(-1, 37);
            this.Label121.Name="Label121";
            this.Label121.Size=new System.Drawing.Size(22, 22);
            this.Label121.TabIndex=0;
            this.Label121.Text="B";
            this.Label121.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label121.Visible=false;
            this.Label121.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label122
            // 
            this.Label122.BackColor=System.Drawing.Color.Transparent;
            this.Label122.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label122.Location=new System.Drawing.Point(37, 37);
            this.Label122.Name="Label122";
            this.Label122.Size=new System.Drawing.Size(22, 22);
            this.Label122.TabIndex=0;
            this.Label122.Text="A";
            this.Label122.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label122.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD41
            // 
            this.LabelD41.BackColor=System.Drawing.Color.Transparent;
            this.LabelD41.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD41.Location=new System.Drawing.Point(-6, -6);
            this.LabelD41.Name="LabelD41";
            this.LabelD41.Size=new System.Drawing.Size(70, 70);
            this.LabelD41.TabIndex=0;
            this.LabelD41.Text="25";
            this.LabelD41.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD41.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel7
            // 
            this.Panel7.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel7.Controls.Add(this.Label19);
            this.Panel7.Controls.Add(this.Label20);
            this.Panel7.Controls.Add(this.LabelD7);
            this.Panel7.Location=new System.Drawing.Point(0, 0);
            this.Panel7.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel7.Name="Panel7";
            this.Panel7.Size=new System.Drawing.Size(61, 60);
            this.Panel7.TabIndex=1;
            // 
            // Label19
            // 
            this.Label19.BackColor=System.Drawing.Color.Transparent;
            this.Label19.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location=new System.Drawing.Point(-1, 37);
            this.Label19.Name="Label19";
            this.Label19.Size=new System.Drawing.Size(22, 22);
            this.Label19.TabIndex=0;
            this.Label19.Text="B";
            this.Label19.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label19.Visible=false;
            this.Label19.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label20
            // 
            this.Label20.BackColor=System.Drawing.Color.Transparent;
            this.Label20.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location=new System.Drawing.Point(37, 37);
            this.Label20.Name="Label20";
            this.Label20.Size=new System.Drawing.Size(22, 22);
            this.Label20.TabIndex=0;
            this.Label20.Text="A";
            this.Label20.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label20.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD7
            // 
            this.LabelD7.BackColor=System.Drawing.Color.Transparent;
            this.LabelD7.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD7.Location=new System.Drawing.Point(-5, -7);
            this.LabelD7.Name="LabelD7";
            this.LabelD7.Size=new System.Drawing.Size(70, 70);
            this.LabelD7.TabIndex=0;
            this.LabelD7.Text="25";
            this.LabelD7.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD7.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel34
            // 
            this.Panel34.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel34.Controls.Add(this.Label100);
            this.Panel34.Controls.Add(this.Label101);
            this.Panel34.Controls.Add(this.LabelD34);
            this.Panel34.Location=new System.Drawing.Point(59, 236);
            this.Panel34.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel34.Name="Panel34";
            this.Panel34.Size=new System.Drawing.Size(61, 60);
            this.Panel34.TabIndex=1;
            // 
            // Label100
            // 
            this.Label100.BackColor=System.Drawing.Color.Transparent;
            this.Label100.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label100.Location=new System.Drawing.Point(-1, 37);
            this.Label100.Name="Label100";
            this.Label100.Size=new System.Drawing.Size(22, 22);
            this.Label100.TabIndex=0;
            this.Label100.Text="B";
            this.Label100.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label100.Visible=false;
            this.Label100.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label101
            // 
            this.Label101.BackColor=System.Drawing.Color.Transparent;
            this.Label101.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label101.Location=new System.Drawing.Point(37, 37);
            this.Label101.Name="Label101";
            this.Label101.Size=new System.Drawing.Size(22, 22);
            this.Label101.TabIndex=0;
            this.Label101.Text="A";
            this.Label101.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label101.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD34
            // 
            this.LabelD34.BackColor=System.Drawing.Color.Transparent;
            this.LabelD34.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD34.Location=new System.Drawing.Point(-6, -6);
            this.LabelD34.Name="LabelD34";
            this.LabelD34.Size=new System.Drawing.Size(70, 70);
            this.LabelD34.TabIndex=0;
            this.LabelD34.Text="25";
            this.LabelD34.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD34.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel39
            // 
            this.Panel39.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel39.Controls.Add(this.Label118);
            this.Panel39.Controls.Add(this.Label119);
            this.Panel39.Controls.Add(this.LabelD39);
            this.Panel39.Location=new System.Drawing.Point(180, 295);
            this.Panel39.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel39.Name="Panel39";
            this.Panel39.Size=new System.Drawing.Size(61, 60);
            this.Panel39.TabIndex=1;
            // 
            // Label118
            // 
            this.Label118.BackColor=System.Drawing.Color.Transparent;
            this.Label118.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label118.Location=new System.Drawing.Point(-1, 37);
            this.Label118.Name="Label118";
            this.Label118.Size=new System.Drawing.Size(22, 22);
            this.Label118.TabIndex=0;
            this.Label118.Text="B";
            this.Label118.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label118.Visible=false;
            this.Label118.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label119
            // 
            this.Label119.BackColor=System.Drawing.Color.Transparent;
            this.Label119.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label119.Location=new System.Drawing.Point(37, 37);
            this.Label119.Name="Label119";
            this.Label119.Size=new System.Drawing.Size(22, 22);
            this.Label119.TabIndex=0;
            this.Label119.Text="A";
            this.Label119.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label119.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD39
            // 
            this.LabelD39.BackColor=System.Drawing.Color.Transparent;
            this.LabelD39.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD39.Location=new System.Drawing.Point(-6, -6);
            this.LabelD39.Name="LabelD39";
            this.LabelD39.Size=new System.Drawing.Size(70, 70);
            this.LabelD39.TabIndex=0;
            this.LabelD39.Text="25";
            this.LabelD39.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD39.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel27
            // 
            this.Panel27.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel27.Controls.Add(this.Label76);
            this.Panel27.Controls.Add(this.Label77);
            this.Panel27.Controls.Add(this.LabelD27);
            this.Panel27.Location=new System.Drawing.Point(59, 177);
            this.Panel27.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel27.Name="Panel27";
            this.Panel27.Size=new System.Drawing.Size(61, 60);
            this.Panel27.TabIndex=1;
            // 
            // Label76
            // 
            this.Label76.BackColor=System.Drawing.Color.Transparent;
            this.Label76.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label76.Location=new System.Drawing.Point(-1, 37);
            this.Label76.Name="Label76";
            this.Label76.Size=new System.Drawing.Size(22, 22);
            this.Label76.TabIndex=0;
            this.Label76.Text="B";
            this.Label76.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label76.Visible=false;
            this.Label76.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label77
            // 
            this.Label77.BackColor=System.Drawing.Color.Transparent;
            this.Label77.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label77.Location=new System.Drawing.Point(37, 37);
            this.Label77.Name="Label77";
            this.Label77.Size=new System.Drawing.Size(22, 22);
            this.Label77.TabIndex=0;
            this.Label77.Text="A";
            this.Label77.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label77.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD27
            // 
            this.LabelD27.BackColor=System.Drawing.Color.Transparent;
            this.LabelD27.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD27.Location=new System.Drawing.Point(-6, -6);
            this.LabelD27.Name="LabelD27";
            this.LabelD27.Size=new System.Drawing.Size(70, 70);
            this.LabelD27.TabIndex=0;
            this.LabelD27.Text="25";
            this.LabelD27.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD27.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel32
            // 
            this.Panel32.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel32.Controls.Add(this.Label97);
            this.Panel32.Controls.Add(this.Label98);
            this.Panel32.Controls.Add(this.LabelD32);
            this.Panel32.Location=new System.Drawing.Point(180, 236);
            this.Panel32.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel32.Name="Panel32";
            this.Panel32.Size=new System.Drawing.Size(61, 60);
            this.Panel32.TabIndex=1;
            // 
            // Label97
            // 
            this.Label97.BackColor=System.Drawing.Color.Transparent;
            this.Label97.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label97.Location=new System.Drawing.Point(-1, 37);
            this.Label97.Name="Label97";
            this.Label97.Size=new System.Drawing.Size(22, 22);
            this.Label97.TabIndex=0;
            this.Label97.Text="B";
            this.Label97.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label97.Visible=false;
            this.Label97.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label98
            // 
            this.Label98.BackColor=System.Drawing.Color.Transparent;
            this.Label98.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label98.Location=new System.Drawing.Point(37, 37);
            this.Label98.Name="Label98";
            this.Label98.Size=new System.Drawing.Size(22, 22);
            this.Label98.TabIndex=0;
            this.Label98.Text="A";
            this.Label98.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label98.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD32
            // 
            this.LabelD32.BackColor=System.Drawing.Color.Transparent;
            this.LabelD32.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD32.Location=new System.Drawing.Point(-6, -6);
            this.LabelD32.Name="LabelD32";
            this.LabelD32.Size=new System.Drawing.Size(70, 70);
            this.LabelD32.TabIndex=0;
            this.LabelD32.Text="25";
            this.LabelD32.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD32.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel13
            // 
            this.Panel13.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel13.Controls.Add(this.Label37);
            this.Panel13.Controls.Add(this.Label38);
            this.Panel13.Controls.Add(this.LabelD13);
            this.Panel13.Location=new System.Drawing.Point(59, 59);
            this.Panel13.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel13.Name="Panel13";
            this.Panel13.Size=new System.Drawing.Size(61, 60);
            this.Panel13.TabIndex=1;
            // 
            // Label37
            // 
            this.Label37.BackColor=System.Drawing.Color.Transparent;
            this.Label37.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.Location=new System.Drawing.Point(-1, 37);
            this.Label37.Name="Label37";
            this.Label37.Size=new System.Drawing.Size(22, 22);
            this.Label37.TabIndex=0;
            this.Label37.Text="B";
            this.Label37.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label37.Visible=false;
            this.Label37.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label38
            // 
            this.Label38.BackColor=System.Drawing.Color.Transparent;
            this.Label38.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label38.Location=new System.Drawing.Point(37, 37);
            this.Label38.Name="Label38";
            this.Label38.Size=new System.Drawing.Size(22, 22);
            this.Label38.TabIndex=0;
            this.Label38.Text="A";
            this.Label38.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label38.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD13
            // 
            this.LabelD13.BackColor=System.Drawing.Color.Transparent;
            this.LabelD13.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD13.Location=new System.Drawing.Point(-6, -6);
            this.LabelD13.Name="LabelD13";
            this.LabelD13.Size=new System.Drawing.Size(70, 70);
            this.LabelD13.TabIndex=0;
            this.LabelD13.Text="25";
            this.LabelD13.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD13.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel25
            // 
            this.Panel25.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel25.Controls.Add(this.Label73);
            this.Panel25.Controls.Add(this.Label74);
            this.Panel25.Controls.Add(this.LabelD25);
            this.Panel25.Location=new System.Drawing.Point(180, 177);
            this.Panel25.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel25.Name="Panel25";
            this.Panel25.Size=new System.Drawing.Size(61, 60);
            this.Panel25.TabIndex=1;
            // 
            // Label73
            // 
            this.Label73.BackColor=System.Drawing.Color.Transparent;
            this.Label73.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label73.Location=new System.Drawing.Point(-1, 37);
            this.Label73.Name="Label73";
            this.Label73.Size=new System.Drawing.Size(22, 22);
            this.Label73.TabIndex=0;
            this.Label73.Text="B";
            this.Label73.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label73.Visible=false;
            this.Label73.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label74
            // 
            this.Label74.BackColor=System.Drawing.Color.Transparent;
            this.Label74.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label74.Location=new System.Drawing.Point(37, 37);
            this.Label74.Name="Label74";
            this.Label74.Size=new System.Drawing.Size(22, 22);
            this.Label74.TabIndex=0;
            this.Label74.Text="A";
            this.Label74.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label74.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD25
            // 
            this.LabelD25.BackColor=System.Drawing.Color.Transparent;
            this.LabelD25.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD25.Location=new System.Drawing.Point(-6, -6);
            this.LabelD25.Name="LabelD25";
            this.LabelD25.Size=new System.Drawing.Size(70, 70);
            this.LabelD25.TabIndex=0;
            this.LabelD25.Text="25";
            this.LabelD25.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD25.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel40
            // 
            this.Panel40.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel40.Controls.Add(this.Label115);
            this.Panel40.Controls.Add(this.Label116);
            this.Panel40.Controls.Add(this.LabelD40);
            this.Panel40.Location=new System.Drawing.Point(120, 295);
            this.Panel40.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel40.Name="Panel40";
            this.Panel40.Size=new System.Drawing.Size(61, 60);
            this.Panel40.TabIndex=1;
            // 
            // Label115
            // 
            this.Label115.BackColor=System.Drawing.Color.Transparent;
            this.Label115.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label115.Location=new System.Drawing.Point(-1, 37);
            this.Label115.Name="Label115";
            this.Label115.Size=new System.Drawing.Size(22, 22);
            this.Label115.TabIndex=0;
            this.Label115.Text="B";
            this.Label115.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label115.Visible=false;
            this.Label115.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label116
            // 
            this.Label116.BackColor=System.Drawing.Color.Transparent;
            this.Label116.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label116.Location=new System.Drawing.Point(37, 37);
            this.Label116.Name="Label116";
            this.Label116.Size=new System.Drawing.Size(22, 22);
            this.Label116.TabIndex=0;
            this.Label116.Text="A";
            this.Label116.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label116.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD40
            // 
            this.LabelD40.BackColor=System.Drawing.Color.Transparent;
            this.LabelD40.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD40.Location=new System.Drawing.Point(-6, -6);
            this.LabelD40.Name="LabelD40";
            this.LabelD40.Size=new System.Drawing.Size(70, 70);
            this.LabelD40.TabIndex=0;
            this.LabelD40.Text="25";
            this.LabelD40.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD40.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel11
            // 
            this.Panel11.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel11.Controls.Add(this.Label34);
            this.Panel11.Controls.Add(this.Label35);
            this.Panel11.Controls.Add(this.LabelD11);
            this.Panel11.Location=new System.Drawing.Point(180, 59);
            this.Panel11.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel11.Name="Panel11";
            this.Panel11.Size=new System.Drawing.Size(61, 60);
            this.Panel11.TabIndex=1;
            // 
            // Label34
            // 
            this.Label34.BackColor=System.Drawing.Color.Transparent;
            this.Label34.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.Location=new System.Drawing.Point(-1, 37);
            this.Label34.Name="Label34";
            this.Label34.Size=new System.Drawing.Size(22, 22);
            this.Label34.TabIndex=0;
            this.Label34.Text="B";
            this.Label34.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label34.Visible=false;
            this.Label34.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label35
            // 
            this.Label35.BackColor=System.Drawing.Color.Transparent;
            this.Label35.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.Location=new System.Drawing.Point(37, 37);
            this.Label35.Name="Label35";
            this.Label35.Size=new System.Drawing.Size(22, 22);
            this.Label35.TabIndex=0;
            this.Label35.Text="A";
            this.Label35.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label35.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD11
            // 
            this.LabelD11.BackColor=System.Drawing.Color.Transparent;
            this.LabelD11.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD11.Location=new System.Drawing.Point(-6, -6);
            this.LabelD11.Name="LabelD11";
            this.LabelD11.Size=new System.Drawing.Size(70, 70);
            this.LabelD11.TabIndex=0;
            this.LabelD11.Text="25";
            this.LabelD11.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD11.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel33
            // 
            this.Panel33.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel33.Controls.Add(this.Label94);
            this.Panel33.Controls.Add(this.Label95);
            this.Panel33.Controls.Add(this.LabelD33);
            this.Panel33.Location=new System.Drawing.Point(120, 236);
            this.Panel33.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel33.Name="Panel33";
            this.Panel33.Size=new System.Drawing.Size(61, 60);
            this.Panel33.TabIndex=1;
            // 
            // Label94
            // 
            this.Label94.BackColor=System.Drawing.Color.Transparent;
            this.Label94.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label94.Location=new System.Drawing.Point(-1, 37);
            this.Label94.Name="Label94";
            this.Label94.Size=new System.Drawing.Size(22, 22);
            this.Label94.TabIndex=0;
            this.Label94.Text="B";
            this.Label94.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label94.Visible=false;
            this.Label94.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label95
            // 
            this.Label95.BackColor=System.Drawing.Color.Transparent;
            this.Label95.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label95.Location=new System.Drawing.Point(37, 37);
            this.Label95.Name="Label95";
            this.Label95.Size=new System.Drawing.Size(22, 22);
            this.Label95.TabIndex=0;
            this.Label95.Text="A";
            this.Label95.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label95.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD33
            // 
            this.LabelD33.BackColor=System.Drawing.Color.Transparent;
            this.LabelD33.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD33.Location=new System.Drawing.Point(-6, -6);
            this.LabelD33.Name="LabelD33";
            this.LabelD33.Size=new System.Drawing.Size(70, 70);
            this.LabelD33.TabIndex=0;
            this.LabelD33.Text="25";
            this.LabelD33.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD33.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel20
            // 
            this.Panel20.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel20.Controls.Add(this.Label70);
            this.Panel20.Controls.Add(this.Label71);
            this.Panel20.Controls.Add(this.LabelD20);
            this.Panel20.Location=new System.Drawing.Point(59, 118);
            this.Panel20.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel20.Name="Panel20";
            this.Panel20.Size=new System.Drawing.Size(61, 60);
            this.Panel20.TabIndex=1;
            // 
            // Label70
            // 
            this.Label70.BackColor=System.Drawing.Color.Transparent;
            this.Label70.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label70.Location=new System.Drawing.Point(-1, 37);
            this.Label70.Name="Label70";
            this.Label70.Size=new System.Drawing.Size(22, 22);
            this.Label70.TabIndex=0;
            this.Label70.Text="B";
            this.Label70.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label70.Visible=false;
            this.Label70.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label71
            // 
            this.Label71.BackColor=System.Drawing.Color.Transparent;
            this.Label71.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label71.Location=new System.Drawing.Point(37, 37);
            this.Label71.Name="Label71";
            this.Label71.Size=new System.Drawing.Size(22, 22);
            this.Label71.TabIndex=0;
            this.Label71.Text="A";
            this.Label71.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label71.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD20
            // 
            this.LabelD20.BackColor=System.Drawing.Color.Transparent;
            this.LabelD20.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD20.Location=new System.Drawing.Point(-6, -6);
            this.LabelD20.Name="LabelD20";
            this.LabelD20.Size=new System.Drawing.Size(70, 70);
            this.LabelD20.TabIndex=0;
            this.LabelD20.Text="25";
            this.LabelD20.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD20.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel26
            // 
            this.Panel26.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel26.Controls.Add(this.Label67);
            this.Panel26.Controls.Add(this.Label68);
            this.Panel26.Controls.Add(this.LabelD26);
            this.Panel26.Location=new System.Drawing.Point(120, 177);
            this.Panel26.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel26.Name="Panel26";
            this.Panel26.Size=new System.Drawing.Size(61, 60);
            this.Panel26.TabIndex=1;
            // 
            // Label67
            // 
            this.Label67.BackColor=System.Drawing.Color.Transparent;
            this.Label67.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label67.Location=new System.Drawing.Point(-1, 37);
            this.Label67.Name="Label67";
            this.Label67.Size=new System.Drawing.Size(22, 22);
            this.Label67.TabIndex=0;
            this.Label67.Text="B";
            this.Label67.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label67.Visible=false;
            this.Label67.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label68
            // 
            this.Label68.BackColor=System.Drawing.Color.Transparent;
            this.Label68.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label68.Location=new System.Drawing.Point(37, 37);
            this.Label68.Name="Label68";
            this.Label68.Size=new System.Drawing.Size(22, 22);
            this.Label68.TabIndex=0;
            this.Label68.Text="A";
            this.Label68.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label68.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD26
            // 
            this.LabelD26.BackColor=System.Drawing.Color.Transparent;
            this.LabelD26.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD26.Location=new System.Drawing.Point(-6, -6);
            this.LabelD26.Name="LabelD26";
            this.LabelD26.Size=new System.Drawing.Size(70, 70);
            this.LabelD26.TabIndex=0;
            this.LabelD26.Text="25";
            this.LabelD26.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD26.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.Label16);
            this.Panel6.Controls.Add(this.Label17);
            this.Panel6.Controls.Add(this.LabelD6);
            this.Panel6.Location=new System.Drawing.Point(59, 0);
            this.Panel6.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel6.Name="Panel6";
            this.Panel6.Size=new System.Drawing.Size(61, 60);
            this.Panel6.TabIndex=1;
            // 
            // Label16
            // 
            this.Label16.BackColor=System.Drawing.Color.Transparent;
            this.Label16.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location=new System.Drawing.Point(-1, 37);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(22, 22);
            this.Label16.TabIndex=0;
            this.Label16.Text="B";
            this.Label16.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label16.Visible=false;
            this.Label16.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label17
            // 
            this.Label17.BackColor=System.Drawing.Color.Transparent;
            this.Label17.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location=new System.Drawing.Point(37, 37);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(22, 22);
            this.Label17.TabIndex=0;
            this.Label17.Text="A";
            this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label17.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD6
            // 
            this.LabelD6.BackColor=System.Drawing.Color.Transparent;
            this.LabelD6.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD6.Location=new System.Drawing.Point(-5, -7);
            this.LabelD6.Name="LabelD6";
            this.LabelD6.Size=new System.Drawing.Size(70, 70);
            this.LabelD6.TabIndex=0;
            this.LabelD6.Text="25";
            this.LabelD6.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD6.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel38
            // 
            this.Panel38.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel38.Controls.Add(this.Label112);
            this.Panel38.Controls.Add(this.Label113);
            this.Panel38.Controls.Add(this.LabelD38);
            this.Panel38.Location=new System.Drawing.Point(239, 295);
            this.Panel38.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel38.Name="Panel38";
            this.Panel38.Size=new System.Drawing.Size(61, 60);
            this.Panel38.TabIndex=1;
            // 
            // Label112
            // 
            this.Label112.BackColor=System.Drawing.Color.Transparent;
            this.Label112.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label112.Location=new System.Drawing.Point(-1, 37);
            this.Label112.Name="Label112";
            this.Label112.Size=new System.Drawing.Size(22, 22);
            this.Label112.TabIndex=0;
            this.Label112.Text="B";
            this.Label112.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label112.Visible=false;
            this.Label112.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label113
            // 
            this.Label113.BackColor=System.Drawing.Color.Transparent;
            this.Label113.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label113.Location=new System.Drawing.Point(37, 37);
            this.Label113.Name="Label113";
            this.Label113.Size=new System.Drawing.Size(22, 22);
            this.Label113.TabIndex=0;
            this.Label113.Text="A";
            this.Label113.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label113.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD38
            // 
            this.LabelD38.BackColor=System.Drawing.Color.Transparent;
            this.LabelD38.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD38.Location=new System.Drawing.Point(-6, -6);
            this.LabelD38.Name="LabelD38";
            this.LabelD38.Size=new System.Drawing.Size(70, 70);
            this.LabelD38.TabIndex=0;
            this.LabelD38.Text="25";
            this.LabelD38.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD38.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel18
            // 
            this.Panel18.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel18.Controls.Add(this.Label64);
            this.Panel18.Controls.Add(this.Label65);
            this.Panel18.Controls.Add(this.LabelD18);
            this.Panel18.Location=new System.Drawing.Point(180, 118);
            this.Panel18.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel18.Name="Panel18";
            this.Panel18.Size=new System.Drawing.Size(61, 60);
            this.Panel18.TabIndex=1;
            // 
            // Label64
            // 
            this.Label64.BackColor=System.Drawing.Color.Transparent;
            this.Label64.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label64.Location=new System.Drawing.Point(-1, 37);
            this.Label64.Name="Label64";
            this.Label64.Size=new System.Drawing.Size(22, 22);
            this.Label64.TabIndex=0;
            this.Label64.Text="B";
            this.Label64.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label64.Visible=false;
            this.Label64.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label65
            // 
            this.Label65.BackColor=System.Drawing.Color.Transparent;
            this.Label65.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label65.Location=new System.Drawing.Point(37, 37);
            this.Label65.Name="Label65";
            this.Label65.Size=new System.Drawing.Size(22, 22);
            this.Label65.TabIndex=0;
            this.Label65.Text="A";
            this.Label65.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label65.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD18
            // 
            this.LabelD18.BackColor=System.Drawing.Color.Transparent;
            this.LabelD18.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD18.Location=new System.Drawing.Point(-6, -6);
            this.LabelD18.Name="LabelD18";
            this.LabelD18.Size=new System.Drawing.Size(70, 70);
            this.LabelD18.TabIndex=0;
            this.LabelD18.Text="25";
            this.LabelD18.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD18.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel31
            // 
            this.Panel31.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel31.Controls.Add(this.Label91);
            this.Panel31.Controls.Add(this.Label92);
            this.Panel31.Controls.Add(this.LabelD31);
            this.Panel31.Location=new System.Drawing.Point(239, 236);
            this.Panel31.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel31.Name="Panel31";
            this.Panel31.Size=new System.Drawing.Size(61, 60);
            this.Panel31.TabIndex=1;
            // 
            // Label91
            // 
            this.Label91.BackColor=System.Drawing.Color.Transparent;
            this.Label91.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label91.Location=new System.Drawing.Point(-1, 37);
            this.Label91.Name="Label91";
            this.Label91.Size=new System.Drawing.Size(22, 22);
            this.Label91.TabIndex=0;
            this.Label91.Text="B";
            this.Label91.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label91.Visible=false;
            this.Label91.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label92
            // 
            this.Label92.BackColor=System.Drawing.Color.Transparent;
            this.Label92.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label92.Location=new System.Drawing.Point(37, 37);
            this.Label92.Name="Label92";
            this.Label92.Size=new System.Drawing.Size(22, 22);
            this.Label92.TabIndex=0;
            this.Label92.Text="A";
            this.Label92.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label92.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD31
            // 
            this.LabelD31.BackColor=System.Drawing.Color.Transparent;
            this.LabelD31.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD31.Location=new System.Drawing.Point(-6, -6);
            this.LabelD31.Name="LabelD31";
            this.LabelD31.Size=new System.Drawing.Size(70, 70);
            this.LabelD31.TabIndex=0;
            this.LabelD31.Text="25";
            this.LabelD31.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD31.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel12
            // 
            this.Panel12.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel12.Controls.Add(this.Label31);
            this.Panel12.Controls.Add(this.Label32);
            this.Panel12.Controls.Add(this.LabelD12);
            this.Panel12.Location=new System.Drawing.Point(120, 59);
            this.Panel12.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel12.Name="Panel12";
            this.Panel12.Size=new System.Drawing.Size(61, 60);
            this.Panel12.TabIndex=1;
            // 
            // Label31
            // 
            this.Label31.BackColor=System.Drawing.Color.Transparent;
            this.Label31.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label31.Location=new System.Drawing.Point(-1, 37);
            this.Label31.Name="Label31";
            this.Label31.Size=new System.Drawing.Size(22, 22);
            this.Label31.TabIndex=0;
            this.Label31.Text="B";
            this.Label31.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label31.Visible=false;
            this.Label31.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label32
            // 
            this.Label32.BackColor=System.Drawing.Color.Transparent;
            this.Label32.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.Location=new System.Drawing.Point(37, 37);
            this.Label32.Name="Label32";
            this.Label32.Size=new System.Drawing.Size(22, 22);
            this.Label32.TabIndex=0;
            this.Label32.Text="A";
            this.Label32.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label32.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD12
            // 
            this.LabelD12.BackColor=System.Drawing.Color.Transparent;
            this.LabelD12.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD12.Location=new System.Drawing.Point(-6, -6);
            this.LabelD12.Name="LabelD12";
            this.LabelD12.Size=new System.Drawing.Size(70, 70);
            this.LabelD12.TabIndex=0;
            this.LabelD12.Text="25";
            this.LabelD12.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD12.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel24
            // 
            this.Panel24.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel24.Controls.Add(this.Label61);
            this.Panel24.Controls.Add(this.Label62);
            this.Panel24.Controls.Add(this.LabelD24);
            this.Panel24.Location=new System.Drawing.Point(239, 177);
            this.Panel24.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel24.Name="Panel24";
            this.Panel24.Size=new System.Drawing.Size(61, 60);
            this.Panel24.TabIndex=1;
            // 
            // Label61
            // 
            this.Label61.BackColor=System.Drawing.Color.Transparent;
            this.Label61.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label61.Location=new System.Drawing.Point(-1, 37);
            this.Label61.Name="Label61";
            this.Label61.Size=new System.Drawing.Size(22, 22);
            this.Label61.TabIndex=0;
            this.Label61.Text="B";
            this.Label61.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label61.Visible=false;
            this.Label61.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label62
            // 
            this.Label62.BackColor=System.Drawing.Color.Transparent;
            this.Label62.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label62.Location=new System.Drawing.Point(37, 37);
            this.Label62.Name="Label62";
            this.Label62.Size=new System.Drawing.Size(22, 22);
            this.Label62.TabIndex=0;
            this.Label62.Text="A";
            this.Label62.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label62.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD24
            // 
            this.LabelD24.BackColor=System.Drawing.Color.Transparent;
            this.LabelD24.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD24.Location=new System.Drawing.Point(-6, -6);
            this.LabelD24.Name="LabelD24";
            this.LabelD24.Size=new System.Drawing.Size(70, 70);
            this.LabelD24.TabIndex=0;
            this.LabelD24.Text="25";
            this.LabelD24.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD24.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel4
            // 
            this.Panel4.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.Label10);
            this.Panel4.Controls.Add(this.Label11);
            this.Panel4.Controls.Add(this.LabelD4);
            this.Panel4.Location=new System.Drawing.Point(180, 0);
            this.Panel4.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(61, 60);
            this.Panel4.TabIndex=1;
            // 
            // Label10
            // 
            this.Label10.BackColor=System.Drawing.Color.Transparent;
            this.Label10.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location=new System.Drawing.Point(-1, 37);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(22, 22);
            this.Label10.TabIndex=0;
            this.Label10.Text="B";
            this.Label10.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label10.Visible=false;
            this.Label10.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label11
            // 
            this.Label11.BackColor=System.Drawing.Color.Transparent;
            this.Label11.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location=new System.Drawing.Point(37, 37);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(22, 22);
            this.Label11.TabIndex=0;
            this.Label11.Text="A";
            this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label11.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD4
            // 
            this.LabelD4.BackColor=System.Drawing.Color.Transparent;
            this.LabelD4.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD4.Location=new System.Drawing.Point(-5, -7);
            this.LabelD4.Name="LabelD4";
            this.LabelD4.Size=new System.Drawing.Size(70, 70);
            this.LabelD4.TabIndex=0;
            this.LabelD4.Text="25";
            this.LabelD4.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD4.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel37
            // 
            this.Panel37.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel37.Controls.Add(this.Label109);
            this.Panel37.Controls.Add(this.Label110);
            this.Panel37.Controls.Add(this.LabelD37);
            this.Panel37.Location=new System.Drawing.Point(299, 295);
            this.Panel37.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel37.Name="Panel37";
            this.Panel37.Size=new System.Drawing.Size(61, 60);
            this.Panel37.TabIndex=1;
            // 
            // Label109
            // 
            this.Label109.BackColor=System.Drawing.Color.Transparent;
            this.Label109.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label109.Location=new System.Drawing.Point(-1, 37);
            this.Label109.Name="Label109";
            this.Label109.Size=new System.Drawing.Size(22, 22);
            this.Label109.TabIndex=0;
            this.Label109.Text="B";
            this.Label109.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label109.Visible=false;
            this.Label109.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label110
            // 
            this.Label110.BackColor=System.Drawing.Color.Transparent;
            this.Label110.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label110.Location=new System.Drawing.Point(37, 37);
            this.Label110.Name="Label110";
            this.Label110.Size=new System.Drawing.Size(22, 22);
            this.Label110.TabIndex=0;
            this.Label110.Text="A";
            this.Label110.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label110.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD37
            // 
            this.LabelD37.BackColor=System.Drawing.Color.Transparent;
            this.LabelD37.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD37.Location=new System.Drawing.Point(-6, -6);
            this.LabelD37.Name="LabelD37";
            this.LabelD37.Size=new System.Drawing.Size(70, 70);
            this.LabelD37.TabIndex=0;
            this.LabelD37.Text="25";
            this.LabelD37.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD37.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel19
            // 
            this.Panel19.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel19.Controls.Add(this.Label58);
            this.Panel19.Controls.Add(this.Label59);
            this.Panel19.Controls.Add(this.LabelD19);
            this.Panel19.Location=new System.Drawing.Point(120, 118);
            this.Panel19.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel19.Name="Panel19";
            this.Panel19.Size=new System.Drawing.Size(61, 60);
            this.Panel19.TabIndex=1;
            // 
            // Label58
            // 
            this.Label58.BackColor=System.Drawing.Color.Transparent;
            this.Label58.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label58.Location=new System.Drawing.Point(-1, 37);
            this.Label58.Name="Label58";
            this.Label58.Size=new System.Drawing.Size(22, 22);
            this.Label58.TabIndex=0;
            this.Label58.Text="B";
            this.Label58.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label58.Visible=false;
            this.Label58.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label59
            // 
            this.Label59.BackColor=System.Drawing.Color.Transparent;
            this.Label59.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label59.Location=new System.Drawing.Point(37, 37);
            this.Label59.Name="Label59";
            this.Label59.Size=new System.Drawing.Size(22, 22);
            this.Label59.TabIndex=0;
            this.Label59.Text="A";
            this.Label59.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label59.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD19
            // 
            this.LabelD19.BackColor=System.Drawing.Color.Transparent;
            this.LabelD19.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD19.Location=new System.Drawing.Point(-6, -6);
            this.LabelD19.Name="LabelD19";
            this.LabelD19.Size=new System.Drawing.Size(70, 70);
            this.LabelD19.TabIndex=0;
            this.LabelD19.Text="25";
            this.LabelD19.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD19.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel30
            // 
            this.Panel30.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel30.Controls.Add(this.Label88);
            this.Panel30.Controls.Add(this.Label89);
            this.Panel30.Controls.Add(this.LabelD30);
            this.Panel30.Location=new System.Drawing.Point(299, 236);
            this.Panel30.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel30.Name="Panel30";
            this.Panel30.Size=new System.Drawing.Size(61, 60);
            this.Panel30.TabIndex=1;
            // 
            // Label88
            // 
            this.Label88.BackColor=System.Drawing.Color.Transparent;
            this.Label88.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label88.Location=new System.Drawing.Point(-1, 37);
            this.Label88.Name="Label88";
            this.Label88.Size=new System.Drawing.Size(22, 22);
            this.Label88.TabIndex=0;
            this.Label88.Text="B";
            this.Label88.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label88.Visible=false;
            this.Label88.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label89
            // 
            this.Label89.BackColor=System.Drawing.Color.Transparent;
            this.Label89.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label89.Location=new System.Drawing.Point(37, 37);
            this.Label89.Name="Label89";
            this.Label89.Size=new System.Drawing.Size(22, 22);
            this.Label89.TabIndex=0;
            this.Label89.Text="A";
            this.Label89.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label89.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD30
            // 
            this.LabelD30.BackColor=System.Drawing.Color.Transparent;
            this.LabelD30.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD30.Location=new System.Drawing.Point(-6, -6);
            this.LabelD30.Name="LabelD30";
            this.LabelD30.Size=new System.Drawing.Size(70, 70);
            this.LabelD30.TabIndex=0;
            this.LabelD30.Text="25";
            this.LabelD30.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD30.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel10
            // 
            this.Panel10.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel10.Controls.Add(this.Label28);
            this.Panel10.Controls.Add(this.Label29);
            this.Panel10.Controls.Add(this.LabelD10);
            this.Panel10.Location=new System.Drawing.Point(239, 59);
            this.Panel10.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel10.Name="Panel10";
            this.Panel10.Size=new System.Drawing.Size(61, 60);
            this.Panel10.TabIndex=1;
            // 
            // Label28
            // 
            this.Label28.BackColor=System.Drawing.Color.Transparent;
            this.Label28.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label28.Location=new System.Drawing.Point(-1, 37);
            this.Label28.Name="Label28";
            this.Label28.Size=new System.Drawing.Size(22, 22);
            this.Label28.TabIndex=0;
            this.Label28.Text="B";
            this.Label28.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label28.Visible=false;
            this.Label28.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label29
            // 
            this.Label29.BackColor=System.Drawing.Color.Transparent;
            this.Label29.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.Location=new System.Drawing.Point(37, 37);
            this.Label29.Name="Label29";
            this.Label29.Size=new System.Drawing.Size(22, 22);
            this.Label29.TabIndex=0;
            this.Label29.Text="A";
            this.Label29.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label29.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD10
            // 
            this.LabelD10.BackColor=System.Drawing.Color.Transparent;
            this.LabelD10.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD10.Location=new System.Drawing.Point(-6, -6);
            this.LabelD10.Name="LabelD10";
            this.LabelD10.Size=new System.Drawing.Size(70, 70);
            this.LabelD10.TabIndex=0;
            this.LabelD10.Text="25";
            this.LabelD10.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD10.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel23
            // 
            this.Panel23.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel23.Controls.Add(this.Label55);
            this.Panel23.Controls.Add(this.Label56);
            this.Panel23.Controls.Add(this.LabelD23);
            this.Panel23.Location=new System.Drawing.Point(299, 177);
            this.Panel23.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel23.Name="Panel23";
            this.Panel23.Size=new System.Drawing.Size(61, 60);
            this.Panel23.TabIndex=1;
            // 
            // Label55
            // 
            this.Label55.BackColor=System.Drawing.Color.Transparent;
            this.Label55.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label55.Location=new System.Drawing.Point(-1, 37);
            this.Label55.Name="Label55";
            this.Label55.Size=new System.Drawing.Size(22, 22);
            this.Label55.TabIndex=0;
            this.Label55.Text="B";
            this.Label55.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label55.Visible=false;
            this.Label55.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label56
            // 
            this.Label56.BackColor=System.Drawing.Color.Transparent;
            this.Label56.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label56.Location=new System.Drawing.Point(37, 37);
            this.Label56.Name="Label56";
            this.Label56.Size=new System.Drawing.Size(22, 22);
            this.Label56.TabIndex=0;
            this.Label56.Text="A";
            this.Label56.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label56.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD23
            // 
            this.LabelD23.BackColor=System.Drawing.Color.Transparent;
            this.LabelD23.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD23.Location=new System.Drawing.Point(-6, -6);
            this.LabelD23.Name="LabelD23";
            this.LabelD23.Size=new System.Drawing.Size(70, 70);
            this.LabelD23.TabIndex=0;
            this.LabelD23.Text="25";
            this.LabelD23.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD23.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel5
            // 
            this.Panel5.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel5.Controls.Add(this.Label13);
            this.Panel5.Controls.Add(this.Label14);
            this.Panel5.Controls.Add(this.LabelD5);
            this.Panel5.Location=new System.Drawing.Point(120, 0);
            this.Panel5.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel5.Name="Panel5";
            this.Panel5.Size=new System.Drawing.Size(61, 60);
            this.Panel5.TabIndex=1;
            // 
            // Label13
            // 
            this.Label13.BackColor=System.Drawing.Color.Transparent;
            this.Label13.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location=new System.Drawing.Point(-1, 37);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(22, 22);
            this.Label13.TabIndex=0;
            this.Label13.Text="B";
            this.Label13.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label13.Visible=false;
            this.Label13.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label14
            // 
            this.Label14.BackColor=System.Drawing.Color.Transparent;
            this.Label14.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location=new System.Drawing.Point(37, 37);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(22, 22);
            this.Label14.TabIndex=0;
            this.Label14.Text="A";
            this.Label14.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label14.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD5
            // 
            this.LabelD5.BackColor=System.Drawing.Color.Transparent;
            this.LabelD5.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD5.Location=new System.Drawing.Point(-5, -7);
            this.LabelD5.Name="LabelD5";
            this.LabelD5.Size=new System.Drawing.Size(70, 70);
            this.LabelD5.TabIndex=0;
            this.LabelD5.Text="25";
            this.LabelD5.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD5.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel36
            // 
            this.Panel36.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel36.Controls.Add(this.Label106);
            this.Panel36.Controls.Add(this.Label107);
            this.Panel36.Controls.Add(this.LabelD36);
            this.Panel36.Location=new System.Drawing.Point(360, 295);
            this.Panel36.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel36.Name="Panel36";
            this.Panel36.Size=new System.Drawing.Size(60, 60);
            this.Panel36.TabIndex=1;
            // 
            // Label106
            // 
            this.Label106.BackColor=System.Drawing.Color.Transparent;
            this.Label106.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label106.Location=new System.Drawing.Point(-1, 37);
            this.Label106.Name="Label106";
            this.Label106.Size=new System.Drawing.Size(22, 22);
            this.Label106.TabIndex=0;
            this.Label106.Text="B";
            this.Label106.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label106.Visible=false;
            this.Label106.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label107
            // 
            this.Label107.BackColor=System.Drawing.Color.Transparent;
            this.Label107.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label107.Location=new System.Drawing.Point(37, 37);
            this.Label107.Name="Label107";
            this.Label107.Size=new System.Drawing.Size(22, 22);
            this.Label107.TabIndex=0;
            this.Label107.Text="A";
            this.Label107.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label107.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD36
            // 
            this.LabelD36.BackColor=System.Drawing.Color.Transparent;
            this.LabelD36.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD36.Location=new System.Drawing.Point(-6, -6);
            this.LabelD36.Name="LabelD36";
            this.LabelD36.Size=new System.Drawing.Size(70, 70);
            this.LabelD36.TabIndex=0;
            this.LabelD36.Text="25";
            this.LabelD36.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD36.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel17
            // 
            this.Panel17.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel17.Controls.Add(this.Label52);
            this.Panel17.Controls.Add(this.Label53);
            this.Panel17.Controls.Add(this.LabelD17);
            this.Panel17.Location=new System.Drawing.Point(239, 118);
            this.Panel17.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel17.Name="Panel17";
            this.Panel17.Size=new System.Drawing.Size(61, 60);
            this.Panel17.TabIndex=1;
            // 
            // Label52
            // 
            this.Label52.BackColor=System.Drawing.Color.Transparent;
            this.Label52.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label52.Location=new System.Drawing.Point(-1, 37);
            this.Label52.Name="Label52";
            this.Label52.Size=new System.Drawing.Size(22, 22);
            this.Label52.TabIndex=0;
            this.Label52.Text="B";
            this.Label52.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label52.Visible=false;
            this.Label52.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label53
            // 
            this.Label53.BackColor=System.Drawing.Color.Transparent;
            this.Label53.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label53.Location=new System.Drawing.Point(37, 37);
            this.Label53.Name="Label53";
            this.Label53.Size=new System.Drawing.Size(22, 22);
            this.Label53.TabIndex=0;
            this.Label53.Text="A";
            this.Label53.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label53.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD17
            // 
            this.LabelD17.BackColor=System.Drawing.Color.Transparent;
            this.LabelD17.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD17.Location=new System.Drawing.Point(-6, -6);
            this.LabelD17.Name="LabelD17";
            this.LabelD17.Size=new System.Drawing.Size(70, 70);
            this.LabelD17.TabIndex=0;
            this.LabelD17.Text="25";
            this.LabelD17.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD17.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel29
            // 
            this.Panel29.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel29.Controls.Add(this.Label85);
            this.Panel29.Controls.Add(this.Label86);
            this.Panel29.Controls.Add(this.LabelD29);
            this.Panel29.Location=new System.Drawing.Point(360, 236);
            this.Panel29.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel29.Name="Panel29";
            this.Panel29.Size=new System.Drawing.Size(60, 60);
            this.Panel29.TabIndex=1;
            // 
            // Label85
            // 
            this.Label85.BackColor=System.Drawing.Color.Transparent;
            this.Label85.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label85.Location=new System.Drawing.Point(-1, 37);
            this.Label85.Name="Label85";
            this.Label85.Size=new System.Drawing.Size(22, 22);
            this.Label85.TabIndex=0;
            this.Label85.Text="B";
            this.Label85.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label85.Visible=false;
            this.Label85.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label86
            // 
            this.Label86.BackColor=System.Drawing.Color.Transparent;
            this.Label86.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label86.Location=new System.Drawing.Point(37, 37);
            this.Label86.Name="Label86";
            this.Label86.Size=new System.Drawing.Size(22, 22);
            this.Label86.TabIndex=0;
            this.Label86.Text="A";
            this.Label86.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label86.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD29
            // 
            this.LabelD29.BackColor=System.Drawing.Color.Transparent;
            this.LabelD29.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD29.Location=new System.Drawing.Point(-6, -6);
            this.LabelD29.Name="LabelD29";
            this.LabelD29.Size=new System.Drawing.Size(70, 70);
            this.LabelD29.TabIndex=0;
            this.LabelD29.Text="25";
            this.LabelD29.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD29.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel9
            // 
            this.Panel9.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel9.Controls.Add(this.Label25);
            this.Panel9.Controls.Add(this.Label26);
            this.Panel9.Controls.Add(this.LabelD9);
            this.Panel9.Location=new System.Drawing.Point(299, 59);
            this.Panel9.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel9.Name="Panel9";
            this.Panel9.Size=new System.Drawing.Size(61, 60);
            this.Panel9.TabIndex=1;
            // 
            // Label25
            // 
            this.Label25.BackColor=System.Drawing.Color.Transparent;
            this.Label25.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location=new System.Drawing.Point(-1, 37);
            this.Label25.Name="Label25";
            this.Label25.Size=new System.Drawing.Size(22, 22);
            this.Label25.TabIndex=0;
            this.Label25.Text="B";
            this.Label25.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label25.Visible=false;
            this.Label25.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label26
            // 
            this.Label26.BackColor=System.Drawing.Color.Transparent;
            this.Label26.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location=new System.Drawing.Point(37, 37);
            this.Label26.Name="Label26";
            this.Label26.Size=new System.Drawing.Size(22, 22);
            this.Label26.TabIndex=0;
            this.Label26.Text="A";
            this.Label26.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label26.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD9
            // 
            this.LabelD9.BackColor=System.Drawing.Color.Transparent;
            this.LabelD9.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD9.Location=new System.Drawing.Point(-6, -6);
            this.LabelD9.Name="LabelD9";
            this.LabelD9.Size=new System.Drawing.Size(70, 70);
            this.LabelD9.TabIndex=0;
            this.LabelD9.Text="25";
            this.LabelD9.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD9.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel22
            // 
            this.Panel22.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel22.Controls.Add(this.Label49);
            this.Panel22.Controls.Add(this.Label50);
            this.Panel22.Controls.Add(this.LabelD22);
            this.Panel22.Location=new System.Drawing.Point(360, 177);
            this.Panel22.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel22.Name="Panel22";
            this.Panel22.Size=new System.Drawing.Size(60, 60);
            this.Panel22.TabIndex=1;
            // 
            // Label49
            // 
            this.Label49.BackColor=System.Drawing.Color.Transparent;
            this.Label49.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.Location=new System.Drawing.Point(-1, 37);
            this.Label49.Name="Label49";
            this.Label49.Size=new System.Drawing.Size(22, 22);
            this.Label49.TabIndex=0;
            this.Label49.Text="B";
            this.Label49.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label49.Visible=false;
            this.Label49.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label50
            // 
            this.Label50.BackColor=System.Drawing.Color.Transparent;
            this.Label50.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label50.Location=new System.Drawing.Point(37, 37);
            this.Label50.Name="Label50";
            this.Label50.Size=new System.Drawing.Size(22, 22);
            this.Label50.TabIndex=0;
            this.Label50.Text="A";
            this.Label50.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label50.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD22
            // 
            this.LabelD22.BackColor=System.Drawing.Color.Transparent;
            this.LabelD22.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD22.Location=new System.Drawing.Point(-6, -6);
            this.LabelD22.Name="LabelD22";
            this.LabelD22.Size=new System.Drawing.Size(70, 70);
            this.LabelD22.TabIndex=0;
            this.LabelD22.Text="25";
            this.LabelD22.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD22.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.LabelD3);
            this.Panel3.Location=new System.Drawing.Point(239, 0);
            this.Panel3.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(61, 60);
            this.Panel3.TabIndex=1;
            // 
            // Label7
            // 
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location=new System.Drawing.Point(-1, 37);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(22, 22);
            this.Label7.TabIndex=0;
            this.Label7.Text="B";
            this.Label7.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label7.Visible=false;
            this.Label7.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label8
            // 
            this.Label8.BackColor=System.Drawing.Color.Transparent;
            this.Label8.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location=new System.Drawing.Point(37, 37);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(22, 22);
            this.Label8.TabIndex=0;
            this.Label8.Text="A";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label8.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD3
            // 
            this.LabelD3.BackColor=System.Drawing.Color.Transparent;
            this.LabelD3.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD3.Location=new System.Drawing.Point(-5, -7);
            this.LabelD3.Name="LabelD3";
            this.LabelD3.Size=new System.Drawing.Size(70, 70);
            this.LabelD3.TabIndex=0;
            this.LabelD3.Text="25";
            this.LabelD3.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD3.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel16
            // 
            this.Panel16.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel16.Controls.Add(this.Label46);
            this.Panel16.Controls.Add(this.Label47);
            this.Panel16.Controls.Add(this.LabelD16);
            this.Panel16.Location=new System.Drawing.Point(299, 118);
            this.Panel16.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel16.Name="Panel16";
            this.Panel16.Size=new System.Drawing.Size(61, 60);
            this.Panel16.TabIndex=1;
            // 
            // Label46
            // 
            this.Label46.BackColor=System.Drawing.Color.Transparent;
            this.Label46.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label46.Location=new System.Drawing.Point(-1, 37);
            this.Label46.Name="Label46";
            this.Label46.Size=new System.Drawing.Size(22, 22);
            this.Label46.TabIndex=0;
            this.Label46.Text="B";
            this.Label46.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label46.Visible=false;
            this.Label46.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label47
            // 
            this.Label47.BackColor=System.Drawing.Color.Transparent;
            this.Label47.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label47.Location=new System.Drawing.Point(37, 37);
            this.Label47.Name="Label47";
            this.Label47.Size=new System.Drawing.Size(22, 22);
            this.Label47.TabIndex=0;
            this.Label47.Text="A";
            this.Label47.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label47.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD16
            // 
            this.LabelD16.BackColor=System.Drawing.Color.Transparent;
            this.LabelD16.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD16.Location=new System.Drawing.Point(-6, -6);
            this.LabelD16.Name="LabelD16";
            this.LabelD16.Size=new System.Drawing.Size(70, 70);
            this.LabelD16.TabIndex=0;
            this.LabelD16.Text="25";
            this.LabelD16.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD16.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel8
            // 
            this.Panel8.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel8.Controls.Add(this.Label22);
            this.Panel8.Controls.Add(this.Label23);
            this.Panel8.Controls.Add(this.LabelD8);
            this.Panel8.Location=new System.Drawing.Point(360, 59);
            this.Panel8.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel8.Name="Panel8";
            this.Panel8.Size=new System.Drawing.Size(60, 60);
            this.Panel8.TabIndex=1;
            // 
            // Label22
            // 
            this.Label22.BackColor=System.Drawing.Color.Transparent;
            this.Label22.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location=new System.Drawing.Point(-1, 37);
            this.Label22.Name="Label22";
            this.Label22.Size=new System.Drawing.Size(22, 22);
            this.Label22.TabIndex=0;
            this.Label22.Text="B";
            this.Label22.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label22.Visible=false;
            this.Label22.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label23
            // 
            this.Label23.BackColor=System.Drawing.Color.Transparent;
            this.Label23.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location=new System.Drawing.Point(37, 37);
            this.Label23.Name="Label23";
            this.Label23.Size=new System.Drawing.Size(22, 22);
            this.Label23.TabIndex=0;
            this.Label23.Text="A";
            this.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label23.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD8
            // 
            this.LabelD8.BackColor=System.Drawing.Color.Transparent;
            this.LabelD8.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD8.Location=new System.Drawing.Point(-6, -6);
            this.LabelD8.Name="LabelD8";
            this.LabelD8.Size=new System.Drawing.Size(70, 70);
            this.LabelD8.TabIndex=0;
            this.LabelD8.Text="25";
            this.LabelD8.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD8.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel15
            // 
            this.Panel15.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel15.Controls.Add(this.Label43);
            this.Panel15.Controls.Add(this.Label44);
            this.Panel15.Controls.Add(this.LabelD15);
            this.Panel15.Location=new System.Drawing.Point(360, 118);
            this.Panel15.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel15.Name="Panel15";
            this.Panel15.Size=new System.Drawing.Size(60, 60);
            this.Panel15.TabIndex=1;
            // 
            // Label43
            // 
            this.Label43.BackColor=System.Drawing.Color.Transparent;
            this.Label43.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.Location=new System.Drawing.Point(-1, 37);
            this.Label43.Name="Label43";
            this.Label43.Size=new System.Drawing.Size(22, 22);
            this.Label43.TabIndex=0;
            this.Label43.Text="B";
            this.Label43.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label43.Visible=false;
            this.Label43.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label44
            // 
            this.Label44.BackColor=System.Drawing.Color.Transparent;
            this.Label44.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label44.Location=new System.Drawing.Point(37, 37);
            this.Label44.Name="Label44";
            this.Label44.Size=new System.Drawing.Size(22, 22);
            this.Label44.TabIndex=0;
            this.Label44.Text="A";
            this.Label44.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label44.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD15
            // 
            this.LabelD15.BackColor=System.Drawing.Color.Transparent;
            this.LabelD15.Font=new System.Drawing.Font("B Yekan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD15.ForeColor=System.Drawing.Color.Black;
            this.LabelD15.Location=new System.Drawing.Point(-6, -6);
            this.LabelD15.Name="LabelD15";
            this.LabelD15.Size=new System.Drawing.Size(70, 70);
            this.LabelD15.TabIndex=0;
            this.LabelD15.Text="25";
            this.LabelD15.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD15.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.LabelD2);
            this.Panel2.Location=new System.Drawing.Point(299, 0);
            this.Panel2.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(61, 60);
            this.Panel2.TabIndex=1;
            // 
            // Label4
            // 
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location=new System.Drawing.Point(-1, 37);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(22, 22);
            this.Label4.TabIndex=0;
            this.Label4.Text="C";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label4.Visible=false;
            this.Label4.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor=System.Drawing.Color.Transparent;
            this.Label5.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location=new System.Drawing.Point(37, 37);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(22, 22);
            this.Label5.TabIndex=0;
            this.Label5.Text="A";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label5.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD2
            // 
            this.LabelD2.BackColor=System.Drawing.Color.Transparent;
            this.LabelD2.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD2.Location=new System.Drawing.Point(-5, -7);
            this.LabelD2.Name="LabelD2";
            this.LabelD2.Size=new System.Drawing.Size(70, 70);
            this.LabelD2.TabIndex=0;
            this.LabelD2.Text="25";
            this.LabelD2.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD2.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.LabelD1);
            this.Panel1.Location=new System.Drawing.Point(360, 0);
            this.Panel1.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(60, 60);
            this.Panel1.TabIndex=1;
            // 
            // Label3
            // 
            this.Label3.BackColor=System.Drawing.Color.Transparent;
            this.Label3.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location=new System.Drawing.Point(-1, 37);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(22, 22);
            this.Label3.TabIndex=0;
            this.Label3.Text="B";
            this.Label3.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Visible=false;
            this.Label3.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor=System.Drawing.Color.Transparent;
            this.Label2.Font=new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location=new System.Drawing.Point(37, 37);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(22, 22);
            this.Label2.TabIndex=0;
            this.Label2.Text="A";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.Label2.Click += new System.EventHandler(this.Label36_Click);
            // 
            // LabelD1
            // 
            this.LabelD1.BackColor=System.Drawing.Color.Transparent;
            this.LabelD1.Font=new System.Drawing.Font("B Yekan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelD1.Location=new System.Drawing.Point(-5, -7);
            this.LabelD1.Name="LabelD1";
            this.LabelD1.Size=new System.Drawing.Size(70, 70);
            this.LabelD1.TabIndex=0;
            this.LabelD1.Text="25";
            this.LabelD1.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            this.LabelD1.Click += new System.EventHandler(this.Label36_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor=System.Drawing.Color.LightSteelBlue;
            this.NextButton.FlatStyle=System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font=new System.Drawing.Font("B Traffic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextButton.Image=global::Metro_Operation.Properties.Resources._31;
            this.NextButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NextButton.Location=new System.Drawing.Point(6, 6);
            this.NextButton.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextButton.Name="NextButton";
            this.NextButton.Size=new System.Drawing.Size(80, 34);
            this.NextButton.TabIndex=2;
            this.NextButton.Text="ماه بعد";
            this.NextButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.NextButton.UseVisualStyleBackColor=false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PervButton
            // 
            this.PervButton.BackColor=System.Drawing.Color.LightSteelBlue;
            this.PervButton.FlatStyle=System.Windows.Forms.FlatStyle.Popup;
            this.PervButton.Font=new System.Drawing.Font("B Traffic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PervButton.Image=global::Metro_Operation.Properties.Resources._32;
            this.PervButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.PervButton.Location=new System.Drawing.Point(334, 6);
            this.PervButton.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PervButton.Name="PervButton";
            this.PervButton.Size=new System.Drawing.Size(80, 34);
            this.PervButton.TabIndex=2;
            this.PervButton.Text="ماه قبل";
            this.PervButton.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.PervButton.UseVisualStyleBackColor=false;
            this.PervButton.Click += new System.EventHandler(this.PervButton_Click);
            // 
            // Label07
            // 
            this.Label07.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label07.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label07.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label07.Location=new System.Drawing.Point(0, 46);
            this.Label07.Name="Label07";
            this.Label07.Size=new System.Drawing.Size(60, 45);
            this.Label07.TabIndex=0;
            this.Label07.Text="جمعه";
            this.Label07.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label06
            // 
            this.Label06.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label06.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label06.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label06.Location=new System.Drawing.Point(60, 46);
            this.Label06.Name="Label06";
            this.Label06.Size=new System.Drawing.Size(60, 45);
            this.Label06.TabIndex=0;
            this.Label06.Text="پنج شنبه";
            this.Label06.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label05
            // 
            this.Label05.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label05.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label05.Font=new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label05.Location=new System.Drawing.Point(120, 46);
            this.Label05.Name="Label05";
            this.Label05.Size=new System.Drawing.Size(60, 45);
            this.Label05.TabIndex=0;
            this.Label05.Text="چهارشنبه";
            this.Label05.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label04
            // 
            this.Label04.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label04.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label04.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label04.Location=new System.Drawing.Point(180, 46);
            this.Label04.Name="Label04";
            this.Label04.Size=new System.Drawing.Size(60, 45);
            this.Label04.TabIndex=0;
            this.Label04.Text="سه شنبه";
            this.Label04.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label03
            // 
            this.Label03.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label03.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label03.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label03.Location=new System.Drawing.Point(240, 46);
            this.Label03.Name="Label03";
            this.Label03.Size=new System.Drawing.Size(60, 45);
            this.Label03.TabIndex=0;
            this.Label03.Text="دو شنبه";
            this.Label03.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label02
            // 
            this.Label02.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label02.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label02.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label02.Location=new System.Drawing.Point(300, 46);
            this.Label02.Name="Label02";
            this.Label02.Size=new System.Drawing.Size(60, 45);
            this.Label02.TabIndex=0;
            this.Label02.Text="یک شنبه";
            this.Label02.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label01
            // 
            this.Label01.BackColor=System.Drawing.SystemColors.ControlLight;
            this.Label01.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label01.Font=new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label01.Location=new System.Drawing.Point(360, 46);
            this.Label01.Name="Label01";
            this.Label01.Size=new System.Drawing.Size(60, 45);
            this.Label01.TabIndex=0;
            this.Label01.Text="شنبه";
            this.Label01.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor=System.Drawing.Color.Transparent;
            this.MainLabel.Font=new System.Drawing.Font("B Yekan", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainLabel.Location=new System.Drawing.Point(90, 1);
            this.MainLabel.Name="MainLabel";
            this.MainLabel.Size=new System.Drawing.Size(240, 44);
            this.MainLabel.TabIndex=0;
            this.MainLabel.Text="تیر ماه 1401";
            this.MainLabel.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelA1
            // 
            this.PanelA1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelA1.Controls.Add(this.Label07);
            this.PanelA1.Controls.Add(this.Label06);
            this.PanelA1.Controls.Add(this.NextButton);
            this.PanelA1.Controls.Add(this.PervButton);
            this.PanelA1.Controls.Add(this.Label05);
            this.PanelA1.Controls.Add(this.MainLabel);
            this.PanelA1.Controls.Add(this.Label04);
            this.PanelA1.Controls.Add(this.Label03);
            this.PanelA1.Controls.Add(this.Label02);
            this.PanelA1.Controls.Add(this.Label01);
            this.PanelA1.Location=new System.Drawing.Point(342, 12);
            this.PanelA1.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelA1.Name="PanelA1";
            this.PanelA1.Size=new System.Drawing.Size(422, 94);
            this.PanelA1.TabIndex=54;
            // 
            // LabelPerDate
            // 
            this.LabelPerDate.BackColor=System.Drawing.Color.Transparent;
            this.LabelPerDate.Font=new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelPerDate.Location=new System.Drawing.Point(2, 0);
            this.LabelPerDate.Name="LabelPerDate";
            this.LabelPerDate.Size=new System.Drawing.Size(313, 44);
            this.LabelPerDate.TabIndex=0;
            this.LabelPerDate.Text="چهار شنبه 1401/12/32";
            this.LabelPerDate.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label132
            // 
            this.Label132.BackColor=System.Drawing.Color.Transparent;
            this.Label132.Font=new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label132.Location=new System.Drawing.Point(1, 34);
            this.Label132.Name="Label132";
            this.Label132.Size=new System.Drawing.Size(316, 44);
            this.Label132.TabIndex=0;
            this.Label132.Text="صبح : A     عصر: B";
            this.Label132.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelG1
            // 
            this.LabelG1.BackColor=System.Drawing.Color.LightGreen;
            this.LabelG1.Font=new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelG1.Location=new System.Drawing.Point(255, 12);
            this.LabelG1.Name="LabelG1";
            this.LabelG1.Size=new System.Drawing.Size(75, 32);
            this.LabelG1.TabIndex=0;
            this.LabelG1.Text="امروز";
            this.LabelG1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelG1.Click += new System.EventHandler(this.LabelG1_Click);
            // 
            // LabelG2
            // 
            this.LabelG2.BackColor=System.Drawing.Color.Khaki;
            this.LabelG2.Font=new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelG2.Location=new System.Drawing.Point(174, 12);
            this.LabelG2.Name="LabelG2";
            this.LabelG2.Size=new System.Drawing.Size(75, 32);
            this.LabelG2.TabIndex=0;
            this.LabelG2.Text="کسر ساعت";
            this.LabelG2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelG4
            // 
            this.LabelG4.BackColor=System.Drawing.Color.Tomato;
            this.LabelG4.Font=new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelG4.Location=new System.Drawing.Point(10, 12);
            this.LabelG4.Name="LabelG4";
            this.LabelG4.Size=new System.Drawing.Size(75, 32);
            this.LabelG4.TabIndex=0;
            this.LabelG4.Text="تعطیل";
            this.LabelG4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1333
            // 
            this.Label1333.BackColor=System.Drawing.Color.Transparent;
            this.Label1333.Font=new System.Drawing.Font("B Yekan", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1333.Location=new System.Drawing.Point(1, 43);
            this.Label1333.Name="Label1333";
            this.Label1333.Size=new System.Drawing.Size(316, 117);
            this.Label1333.TabIndex=0;
            this.Label1333.Text="25";
            // 
            // LabelG3
            // 
            this.LabelG3.BackColor=System.Drawing.Color.SandyBrown;
            this.LabelG3.Font=new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelG3.Location=new System.Drawing.Point(92, 12);
            this.LabelG3.Name="LabelG3";
            this.LabelG3.Size=new System.Drawing.Size(75, 32);
            this.LabelG3.TabIndex=0;
            this.LabelG3.Text="پنجشنبه";
            this.LabelG3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label127
            // 
            this.Label127.BackColor=System.Drawing.Color.Transparent;
            this.Label127.Font=new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label127.Location=new System.Drawing.Point(1, 0);
            this.Label127.Name="Label127";
            this.Label127.Size=new System.Drawing.Size(316, 34);
            this.Label127.TabIndex=0;
            this.Label127.Text="شیفت:";
            this.Label127.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label128
            // 
            this.Label128.BackColor=System.Drawing.Color.Transparent;
            this.Label128.Font=new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label128.Location=new System.Drawing.Point(1, 1);
            this.Label128.Name="Label128";
            this.Label128.Size=new System.Drawing.Size(316, 46);
            this.Label128.TabIndex=0;
            this.Label128.Text="مناسبت:";
            this.Label128.TextAlign=System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelHejDate
            // 
            this.LabelHejDate.BackColor=System.Drawing.Color.Transparent;
            this.LabelHejDate.Font=new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelHejDate.Location=new System.Drawing.Point(147, 48);
            this.LabelHejDate.Name="LabelHejDate";
            this.LabelHejDate.Size=new System.Drawing.Size(170, 30);
            this.LabelHejDate.TabIndex=0;
            this.LabelHejDate.Text="1444/05/23";
            this.LabelHejDate.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMilDate
            // 
            this.LabelMilDate.BackColor=System.Drawing.Color.Transparent;
            this.LabelMilDate.Font=new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LabelMilDate.Location=new System.Drawing.Point(1, 48);
            this.LabelMilDate.Name="LabelMilDate";
            this.LabelMilDate.RightToLeft=System.Windows.Forms.RightToLeft.No;
            this.LabelMilDate.Size=new System.Drawing.Size(140, 30);
            this.LabelMilDate.TabIndex=0;
            this.LabelMilDate.Text="23/06/2022";
            this.LabelMilDate.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel43
            // 
            this.panel43.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel43.Controls.Add(this.LabelPerDate);
            this.panel43.Controls.Add(this.LabelMilDate);
            this.panel43.Controls.Add(this.LabelHejDate);
            this.panel43.Location=new System.Drawing.Point(10, 59);
            this.panel43.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel43.Name="panel43";
            this.panel43.Size=new System.Drawing.Size(320, 81);
            this.panel43.TabIndex=56;
            // 
            // panel44
            // 
            this.panel44.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel44.Controls.Add(this.Label132);
            this.panel44.Controls.Add(this.Label127);
            this.panel44.Location=new System.Drawing.Point(10, 148);
            this.panel44.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel44.Name="panel44";
            this.panel44.Size=new System.Drawing.Size(320, 81);
            this.panel44.TabIndex=57;
            // 
            // panel45
            // 
            this.panel45.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel45.Controls.Add(this.Label128);
            this.panel45.Controls.Add(this.Label1333);
            this.panel45.Location=new System.Drawing.Point(10, 238);
            this.panel45.Margin=new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel45.Name="panel45";
            this.panel45.Size=new System.Drawing.Size(320, 163);
            this.panel45.TabIndex=58;
            // 
            // CalendarFormAD
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(773, 471);
            this.Controls.Add(this.panel45);
            this.Controls.Add(this.panel44);
            this.Controls.Add(this.panel43);
            this.Controls.Add(this.PanelA2);
            this.Controls.Add(this.PanelA1);
            this.Controls.Add(this.LabelG4);
            this.Controls.Add(this.LabelG3);
            this.Controls.Add(this.LabelG2);
            this.Controls.Add(this.LabelG1);
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="CalendarFormAD";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="تقویم ماهانه";
            this.Load += new System.EventHandler(this.CalendarFormAD_Load);
            this.PanelA2.ResumeLayout(false);
            this.Panel42.ResumeLayout(false);
            this.Panel35.ResumeLayout(false);
            this.Panel28.ResumeLayout(false);
            this.Panel14.ResumeLayout(false);
            this.Panel21.ResumeLayout(false);
            this.Panel41.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel34.ResumeLayout(false);
            this.Panel39.ResumeLayout(false);
            this.Panel27.ResumeLayout(false);
            this.Panel32.ResumeLayout(false);
            this.Panel13.ResumeLayout(false);
            this.Panel25.ResumeLayout(false);
            this.Panel40.ResumeLayout(false);
            this.Panel11.ResumeLayout(false);
            this.Panel33.ResumeLayout(false);
            this.Panel20.ResumeLayout(false);
            this.Panel26.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel38.ResumeLayout(false);
            this.Panel18.ResumeLayout(false);
            this.Panel31.ResumeLayout(false);
            this.Panel12.ResumeLayout(false);
            this.Panel24.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel37.ResumeLayout(false);
            this.Panel19.ResumeLayout(false);
            this.Panel30.ResumeLayout(false);
            this.Panel10.ResumeLayout(false);
            this.Panel23.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel36.ResumeLayout(false);
            this.Panel17.ResumeLayout(false);
            this.Panel29.ResumeLayout(false);
            this.Panel9.ResumeLayout(false);
            this.Panel22.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel16.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.Panel15.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.PanelA1.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel44.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Panel panel43;
        private Panel panel44;
        private Panel panel45;
        private Panel PanelA2;
        private Panel Panel35;
        private Label Label103;
        private Label Label104;
        private Label LabelD35;
        private Panel Panel28;
        private Label Label82;
        private Label Label83;
        private Label LabelD28;
        private Panel Panel14;
        private Label Label40;
        private Label Label41;
        private Label LabelD14;
        private Panel Panel21;
        private Label Label79;
        private Label Label80;
        private Label LabelD21;
        private Panel Panel7;
        private Label Label19;
        private Label Label20;
        private Label LabelD7;
        private Panel Panel34;
        private Label Label100;
        private Label Label101;
        private Label LabelD34;
        private Panel Panel27;
        private Label Label76;
        private Label Label77;
        private Label LabelD27;
        private Panel Panel32;
        private Label Label97;
        private Label Label98;
        private Label LabelD32;
        private Panel Panel13;
        private Label Label37;
        private Label Label38;
        private Label LabelD13;
        private Panel Panel25;
        private Label Label73;
        private Label Label74;
        private Label LabelD25;
        private Panel Panel11;
        private Label Label34;
        private Label Label35;
        private Label LabelD11;
        private Panel Panel33;
        private Label Label94;
        private Label Label95;
        private Label LabelD33;
        private Panel Panel20;
        private Label Label70;
        private Label Label71;
        private Label LabelD20;
        private Panel Panel26;
        private Label Label67;
        private Label Label68;
        private Label LabelD26;
        private Panel Panel6;
        private Label Label16;
        private Label Label17;
        private Label LabelD6;
        private Panel Panel18;
        private Label Label64;
        private Label Label65;
        private Label LabelD18;
        private Panel Panel31;
        private Label Label91;
        private Label Label92;
        private Label LabelD31;
        private Panel Panel12;
        private Label Label31;
        private Label Label32;
        private Label LabelD12;
        private Panel Panel24;
        private Label Label61;
        private Label Label62;
        private Label LabelD24;
        private Panel Panel4;
        private Label Label10;
        private Label Label11;
        private Label LabelD4;
        private Panel Panel19;
        private Label Label58;
        private Label Label59;
        private Label LabelD19;
        private Panel Panel30;
        private Label Label88;
        private Label Label89;
        private Label LabelD30;
        private Panel Panel10;
        private Label Label28;
        private Label Label29;
        private Label LabelD10;
        private Panel Panel23;
        private Label Label55;
        private Label Label56;
        private Label LabelD23;
        private Panel Panel5;
        private Label Label13;
        private Label Label14;
        private Label LabelD5;
        private Panel Panel17;
        private Label Label52;
        private Label Label53;
        private Label LabelD17;
        private Panel Panel29;
        private Label Label85;
        private Label Label86;
        private Label LabelD29;
        private Panel Panel9;
        private Label Label25;
        private Label Label26;
        private Label LabelD9;
        private Panel Panel22;
        private Label Label49;
        private Label Label50;
        private Label LabelD22;
        private Panel Panel3;
        private Label Label7;
        private Label Label8;
        private Label LabelD3;
        private Panel Panel16;
        private Label Label46;
        private Label Label47;
        private Label LabelD16;
        private Panel Panel8;
        private Label Label22;
        private Label Label23;
        private Label LabelD8;
        private Panel Panel15;
        private Label Label43;
        private Label Label44;
        private Label LabelD15;
        private Panel Panel2;
        private Label Label4;
        private Label Label5;
        private Label LabelD2;
        private Panel Panel1;
        private Label Label3;
        private Label Label2;
        private Label LabelD1;
        private Label Label07;
        private Label Label06;
        private Label Label05;
        private Label Label04;
        private Label Label03;
        private Label Label02;
        private Label Label01;
        private Panel Panel42;
        private Label Label124;
        private Label Label125;
        private Label LabelD42;
        private Panel Panel41;
        private Label Label121;
        private Label Label122;
        private Label LabelD41;
        private Panel Panel39;
        private Label Label118;
        private Label Label119;
        private Label LabelD39;
        private Panel Panel40;
        private Label Label115;
        private Label Label116;
        private Label LabelD40;
        private Panel Panel38;
        private Label Label112;
        private Label Label113;
        private Label LabelD38;
        private Panel Panel37;
        private Label Label109;
        private Label Label110;
        private Label LabelD37;
        private Panel Panel36;
        private Label Label106;
        private Label Label107;
        private Label LabelD36;
        private Button NextButton;
        private Button PervButton;
        private Label MainLabel;
        private Panel PanelA1;
        private Label LabelPerDate;
        private Label Label132;
        private Label LabelG1;
        private Label LabelG2;
        private Label LabelG4;
        private Label Label1333;
        private Label LabelG3;
        private Label Label127;
        private Label Label128;
        private Label LabelHejDate;
        private Label LabelMilDate;
    }

}
