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
    partial class TerminalTableTripRegForm : BaseForm
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
            base.Load += new System.EventHandler(TerminalTableTripRegForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TerminalTableTripRegForm));
            this.ShowGridView=new DataGridView();
            this.ShowGridView.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridViewTextBoxColumn7=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Panel11=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            this.TimeLabel=new Label();
            this.Label13=new Label();
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.EndLocaCombo=new ComboBox();
            this.EndLocaCombo.SelectedIndexChanged += new System.EventHandler(this.EndLocaCombo_SelectedIndexChanged);
            this.StartLocaCombo=new ComboBox();
            this.StartLocaCombo.SelectedIndexChanged += new System.EventHandler(this.StartLocaCombo_SelectedIndexChanged);
            this.Label9=new Label();
            this.Label10=new Label();
            this.StartBox=new MaskedTextBox();
            this.StartBox.Leave += new System.EventHandler(this.StartBox_Leave);
            this.TrainNumBox=new MaskedTextBox();
            this.EndBox=new MaskedTextBox();
            this.EndBox.Leave += new System.EventHandler(this.StartBox_Leave);
            this.KindLabel=new Label();
            this.Label4=new Label();
            this.Label6=new Label();
            this.Name1Box=new TextBox();
            this.Label2=new Label();
            this.Name3Box=new TextBox();
            this.Label8=new Label();
            this.Name1Button=new Button();
            this.Name1Button.Click += new System.EventHandler(this.Name1Button_Click);
            this.Name3Button=new Button();
            this.Name3Button.Click += new System.EventHandler(this.Name3Button_Click);
            this.Label24=new Label();
            this.Label1=new Label();
            this.Label40=new Label();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.Panel11.SuspendLayout();
            this.SuspendLayout();
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight=40;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn7, this.DataGridViewTextBoxColumn8, this.Column2, this.DataGridViewTextBoxColumn9, this.DataGridViewTextBoxColumn10, this.Column3, this.DataGridViewTextBoxColumn11, this.Column4, this.Column1, this.Column5, this.Column6, this.Column7, this.Column8 });
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(10, 156);
            this.ShowGridView.MultiSelect=false;
            this.ShowGridView.Name="ShowGridView";
            this.ShowGridView.ReadOnly=true;
            this.ShowGridView.RowHeadersVisible=false;
            this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShowGridView.RowTemplate.ReadOnly=true;
            this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size=new System.Drawing.Size(893, 460);
            this.ShowGridView.TabIndex=1;
            //
            //DataGridViewTextBoxColumn7
            //
            this.DataGridViewTextBoxColumn7.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn7.Name="DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly=true;
            this.DataGridViewTextBoxColumn7.Resizable=DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn7.Width=45;
            //
            //DataGridViewTextBoxColumn8
            //
            this.DataGridViewTextBoxColumn8.HeaderText="ساعت اعزام";
            this.DataGridViewTextBoxColumn8.Name="DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly=true;
            this.DataGridViewTextBoxColumn8.Width=55;
            //
            //Column2
            //
            this.Column2.HeaderText="نوع";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn9
            //
            this.DataGridViewTextBoxColumn9.HeaderText="مبداء";
            this.DataGridViewTextBoxColumn9.Name="DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly=true;
            this.DataGridViewTextBoxColumn9.Width=150;
            //
            //DataGridViewTextBoxColumn10
            //
            this.DataGridViewTextBoxColumn10.HeaderText="مقصد";
            this.DataGridViewTextBoxColumn10.Name="DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly=true;
            this.DataGridViewTextBoxColumn10.Width=150;
            //
            //Column3
            //
            this.Column3.HeaderText="شروع یا پایان";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=60;
            //
            //DataGridViewTextBoxColumn11
            //
            this.DataGridViewTextBoxColumn11.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn11.HeaderText="راهبر Master";
            this.DataGridViewTextBoxColumn11.Name="DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly=true;
            //
            //Column4
            //
            this.Column4.HeaderText="پرسنلی Master";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Visible=false;
            //
            //Column1
            //
            this.Column1.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.TopRight;
            this.Column1.DefaultCellStyle=DataGridViewCellStyle3;
            this.Column1.HeaderText="راهبر Slave";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            //
            //Column5
            //
            this.Column5.HeaderText="پرسنلی Slave";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Visible=false;
            //
            //Column6
            //
            this.Column6.HeaderText="شماره قطار";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Visible=false;
            //
            //Column7
            //
            this.Column7.HeaderText="ID";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Visible=false;
            //
            //Column8
            //
            this.Column8.HeaderText="Local";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Visible=false;
            //
            //Panel11
            //
            this.Panel11.BackColor=System.Drawing.Color.LightBlue;
            this.Panel11.BorderStyle=BorderStyle.FixedSingle;
            this.Panel11.Controls.Add(this.PersianCalendar);
            this.Panel11.Controls.Add(this.TimeLabel);
            this.Panel11.Controls.Add(this.Label13);
            this.Panel11.Controls.Add(this.RegButton);
            this.Panel11.Controls.Add(this.EndLocaCombo);
            this.Panel11.Controls.Add(this.StartLocaCombo);
            this.Panel11.Controls.Add(this.Label9);
            this.Panel11.Controls.Add(this.Label10);
            this.Panel11.Controls.Add(this.StartBox);
            this.Panel11.Controls.Add(this.TrainNumBox);
            this.Panel11.Controls.Add(this.EndBox);
            this.Panel11.Controls.Add(this.KindLabel);
            this.Panel11.Controls.Add(this.Label4);
            this.Panel11.Controls.Add(this.Label6);
            this.Panel11.Controls.Add(this.Name1Box);
            this.Panel11.Controls.Add(this.Label2);
            this.Panel11.Controls.Add(this.Name3Box);
            this.Panel11.Controls.Add(this.Label8);
            this.Panel11.Controls.Add(this.Name1Button);
            this.Panel11.Controls.Add(this.Name3Button);
            this.Panel11.Controls.Add(this.Label24);
            this.Panel11.Controls.Add(this.Label1);
            this.Panel11.Controls.Add(this.Label40);
            this.Panel11.Location=new System.Drawing.Point(10, 12);
            this.Panel11.Name="Panel11";
            this.Panel11.Size=new System.Drawing.Size(893, 134);
            this.Panel11.TabIndex=0;
            //
            //PersianCalendar
            //
            this.PersianCalendar.Location=new System.Drawing.Point(701, 16);
            this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=1;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //TimeLabel
            //
            this.TimeLabel.AutoSize=true;
            this.TimeLabel.Font=new System.Drawing.Font("Tahoma", (float)(11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.TimeLabel.Location=new System.Drawing.Point(294, 94);
            this.TimeLabel.Name="TimeLabel";
            this.TimeLabel.Size=new System.Drawing.Size(45, 18);
            this.TimeLabel.TabIndex=98;
            this.TimeLabel.Text="00:00";
            //
            //Label13
            //
            this.Label13.AutoSize=true;
            this.Label13.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label13.Location=new System.Drawing.Point(343, 95);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(67, 16);
            this.Label13.TabIndex=99;
            this.Label13.Text="مدت زمان:";
            //
            //RegButton
            //
            this.RegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.RegButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.RegButton.Image=global::Metro_Operation.Properties.Resources._checked;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.RegButton.Location=new System.Drawing.Point(13, 86);
            this.RegButton.Name="RegButton";
            this.RegButton.Padding=new Padding(10, 0, 10, 0);
            this.RegButton.Size=new System.Drawing.Size(184, 35);
            this.RegButton.TabIndex=9;
            this.RegButton.Text="تایید";
            this.RegButton.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //EndLocaCombo
            //
            this.EndLocaCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            this.EndLocaCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.EndLocaCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.EndLocaCombo.FormattingEnabled=true;
            this.EndLocaCombo.Location=new System.Drawing.Point(294, 50);
            this.EndLocaCombo.Margin=new Padding(4, 5, 4, 5);
            this.EndLocaCombo.MaxLength=50;
            this.EndLocaCombo.Name="EndLocaCombo";
            this.EndLocaCombo.Size=new System.Drawing.Size(196, 24);
            this.EndLocaCombo.TabIndex=6;
            //
            //StartLocaCombo
            //
            this.StartLocaCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            this.StartLocaCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.StartLocaCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.StartLocaCombo.FormattingEnabled=true;
            this.StartLocaCombo.Location=new System.Drawing.Point(294, 15);
            this.StartLocaCombo.Margin=new Padding(4, 5, 4, 5);
            this.StartLocaCombo.MaxLength=50;
            this.StartLocaCombo.Name="StartLocaCombo";
            this.StartLocaCombo.Size=new System.Drawing.Size(196, 24);
            this.StartLocaCombo.TabIndex=5;
            //
            //Label9
            //
            this.Label9.AutoSize=true;
            this.Label9.BackColor=System.Drawing.Color.Transparent;
            this.Label9.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label9.Location=new System.Drawing.Point(490, 19);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(71, 16);
            this.Label9.TabIndex=96;
            this.Label9.Text="مبدا حرکت:";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //Label10
            //
            this.Label10.AutoSize=true;
            this.Label10.BackColor=System.Drawing.Color.Transparent;
            this.Label10.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label10.Location=new System.Drawing.Point(490, 54);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(80, 16);
            this.Label10.TabIndex=97;
            this.Label10.Text="مقصد حرکت:";
            this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //StartBox
            //
            this.StartBox.Enabled=false;
            this.StartBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.StartBox.Location=new System.Drawing.Point(735, 92);
            this.StartBox.Mask="00:00";
            this.StartBox.Name="StartBox";
            this.StartBox.Size=new System.Drawing.Size(51, 23);
            this.StartBox.TabIndex=2;
            this.StartBox.TextAlign=HorizontalAlignment.Center;
            //
            //TrainNumBox
            //
            this.TrainNumBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.TrainNumBox.Location=new System.Drawing.Point(439, 92);
            this.TrainNumBox.Mask=">A9->A9";
            this.TrainNumBox.Name="TrainNumBox";
            this.TrainNumBox.Size=new System.Drawing.Size(51, 23);
            this.TrainNumBox.TabIndex=4;
            this.TrainNumBox.TextAlign=HorizontalAlignment.Center;
            //
            //EndBox
            //
            this.EndBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.EndBox.Location=new System.Drawing.Point(584, 92);
            this.EndBox.Mask="00:00";
            this.EndBox.Name="EndBox";
            this.EndBox.Size=new System.Drawing.Size(51, 23);
            this.EndBox.TabIndex=3;
            this.EndBox.TextAlign=HorizontalAlignment.Center;
            this.EndBox.ValidatingType=typeof(DateTime);
            //
            //KindLabel
            //
            this.KindLabel.Font=new System.Drawing.Font("Tahoma", (float)(12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.KindLabel.ForeColor=System.Drawing.Color.Maroon;
            this.KindLabel.Location=new System.Drawing.Point(636, 50);
            this.KindLabel.Name="KindLabel";
            this.KindLabel.Size=new System.Drawing.Size(194, 25);
            this.KindLabel.TabIndex=0;
            this.KindLabel.Text="ورودی";
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label4.ForeColor=System.Drawing.Color.Black;
            this.Label4.Location=new System.Drawing.Point(490, 95);
            this.Label4.Margin=new Padding(5, 0, 5, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(76, 16);
            this.Label4.TabIndex=90;
            this.Label4.Text="شماره قطار:";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label6
            //
            this.Label6.AutoSize=true;
            this.Label6.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label6.Location=new System.Drawing.Point(636, 95);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(85, 16);
            this.Label6.TabIndex=92;
            this.Label6.Text="ساعت شروع:";
            //
            //Name1Box
            //
            this.Name1Box.BackColor=System.Drawing.SystemColors.Window;
            this.Name1Box.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Name1Box.Location=new System.Drawing.Point(43, 16);
            this.Name1Box.Name="Name1Box";
            this.Name1Box.ReadOnly=true;
            this.Name1Box.Size=new System.Drawing.Size(154, 23);
            this.Name1Box.TabIndex=85;
            this.Name1Box.TabStop=false;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.BackColor=System.Drawing.Color.Transparent;
            this.Label2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label2.Location=new System.Drawing.Point(198, 19);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(83, 16);
            this.Label2.TabIndex=83;
            this.Label2.Text="راهبر Master:";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //Name3Box
            //
            this.Name3Box.BackColor=System.Drawing.SystemColors.Window;
            this.Name3Box.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Name3Box.Location=new System.Drawing.Point(43, 51);
            this.Name3Box.Name="Name3Box";
            this.Name3Box.ReadOnly=true;
            this.Name3Box.Size=new System.Drawing.Size(154, 23);
            this.Name3Box.TabIndex=86;
            this.Name3Box.TabStop=false;
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.BackColor=System.Drawing.Color.Transparent;
            this.Label8.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label8.Location=new System.Drawing.Point(198, 54);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(79, 16);
            this.Label8.TabIndex=84;
            this.Label8.Text="راهبر  Slave:";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //Name1Button
            //
            this.Name1Button.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Name1Button.Image=(System.Drawing.Image)(resources.GetObject("Name1Button.Image"));
            this.Name1Button.Location=new System.Drawing.Point(13, 15);
            this.Name1Button.Name="Name1Button";
            this.Name1Button.Size=new System.Drawing.Size(30, 25);
            this.Name1Button.TabIndex=7;
            this.Name1Button.UseVisualStyleBackColor=true;
            //
            //Name3Button
            //
            this.Name3Button.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Name3Button.Image=(System.Drawing.Image)(resources.GetObject("Name3Button.Image"));
            this.Name3Button.Location=new System.Drawing.Point(13, 50);
            this.Name3Button.Name="Name3Button";
            this.Name3Button.Size=new System.Drawing.Size(30, 25);
            this.Name3Button.TabIndex=8;
            this.Name3Button.UseVisualStyleBackColor=true;
            //
            //Label24
            //
            this.Label24.AutoSize=true;
            this.Label24.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label24.Location=new System.Drawing.Point(838, 54);
            this.Label24.Margin=new Padding(3);
            this.Label24.Name="Label24";
            this.Label24.Size=new System.Drawing.Size(31, 16);
            this.Label24.TabIndex=0;
            this.Label24.Text="نوع:";
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Font=new System.Drawing.Font("Tahoma", (float)(12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.Location=new System.Drawing.Point(825, 18);
            this.Label1.Margin=new Padding(3);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(45, 19);
            this.Label1.TabIndex=0;
            this.Label1.Text="تاریخ:";
            //
            //Label40
            //
            this.Label40.AutoSize=true;
            this.Label40.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label40.Location=new System.Drawing.Point(786, 95);
            this.Label40.Margin=new Padding(3);
            this.Label40.Name="Label40";
            this.Label40.Size=new System.Drawing.Size(81, 16);
            this.Label40.TabIndex=0;
            this.Label40.Text="ساعت اعزام:";
            //
            //TerminalTableTripRegForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(916, 621);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel11);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TerminalTableTripRegForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="پردازش لوحه پایانه";
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataGridView ShowGridView;
        private Panel Panel11;
        private Button RegButton;
        private Label KindLabel;
        private Label Label24;
        private Label Label40;
        private TextBox Name1Box;
        private Label Label2;
        private TextBox Name3Box;
        private Label Label8;
        private Button Name1Button;
        private Button Name3Button;
        private Label Label1;
        private Label Label4;
        private MaskedTextBox TrainNumBox;
        private MaskedTextBox EndBox;
        private Label Label6;
        private MaskedTextBox StartBox;
        private ComboBox EndLocaCombo;
        private ComboBox StartLocaCombo;
        private Label Label9;
        private Label Label10;
        private Label TimeLabel;
        private Label Label13;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }

}
