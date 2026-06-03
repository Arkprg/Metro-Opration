using System;
using System.Windows.Forms;
using System.Drawing;

namespace Metro_Operation
{
    partial class AnnounceReportForm  : BaseForm
    {
        private System.ComponentModel.IContainer components=null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components=new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2=new DataGridViewCellStyle();
            this.Panel1=new Panel();
            this.LocalCombo=new ComboBox();
            this.Label8=new Label();
            this.Label4=new Label();
            this.ShiftCombo=new ComboBox();
            this.Label7=new Label();
            this.Label1=new Label();
            this.TimeCombo=new ComboBox();
            this.Label2=new Label();
            this.Label6=new Label();
            this.Label3=new Label();
            this.PostCombo=new ComboBox();
            this.KindCombo=new ComboBox();
            this.LevelCombo=new ComboBox();
            this.Label5=new Label();
            this.ShowButton=new Button();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.Panel2=new Panel();
            this.TitrLabel=new Label();
            this.KindLabel=new Label();
            this.PostLabel=new Label();
            this.LocalLabel=new Label();
            this.ShiftTimeLabel=new Label();
            this.ShiftNameLabel=new Label();
            this.LevelLabel=new Label();
            this.DateLabel=new Label();
            this.RegLabel=new Label();
            this.Label9=new Label();
            this.Label10=new Label();
            this.Label11=new Label();
            this.Label12=new Label();
            this.Label13=new Label();
            this.Label14=new Label();
            this.Label15=new Label();
            this.Label16=new Label();
            this.Label17=new Label();
            this.Panel3=new Panel();
            this.ShowBox=new WebBrowser();
            this.DataGridView1=new DataGridView();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.DataGridView2=new DataGridView();
            this.Label18=new Label();
            this.Label19=new Label();
            this.Label20=new Label();
            this.Label21=new Label();
            this.Label22=new Label();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.LevelCombo);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Location=new System.Drawing.Point(10, 12);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(978, 75);
            this.Panel1.TabIndex=0;
            // 
            // LocalCombo
            // 
            this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.LocalCombo.Location=new System.Drawing.Point(532, 9);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(158, 24);
            this.LocalCombo.TabIndex=0;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize=true;
            this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label8.Location=new System.Drawing.Point(689, 13);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(40, 16);
            this.Label8.TabIndex=1;
            this.Label8.Text="مبداء:";
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label4.Location=new System.Drawing.Point(275, 13);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(55, 16);
            this.Label4.TabIndex=2;
            this.Label4.Text="از تاریخ :";
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.ShiftCombo.Location=new System.Drawing.Point(351, 39);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(102, 24);
            this.ShiftCombo.TabIndex=3;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label7.Location=new System.Drawing.Point(452, 43);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(70, 16);
            this.Label7.TabIndex=4;
            this.Label7.Text="نام شیفت:";
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label1.Location=new System.Drawing.Point(880, 13);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(76, 16);
            this.Label1.TabIndex=5;
            this.Label1.Text="نوع اطلاعیه:";
            // 
            // TimeCombo
            // 
            this.TimeCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.TimeCombo.Location=new System.Drawing.Point(351, 9);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(102, 24);
            this.TimeCombo.TabIndex=6;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize=true;
            this.Label2.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label2.Location=new System.Drawing.Point(689, 43);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(97, 16);
            this.Label2.TabIndex=7;
            this.Label2.Text="پست سازمانی:";
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label6.Location=new System.Drawing.Point(452, 13);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(72, 16);
            this.Label6.TabIndex=8;
            this.Label6.Text="نوع شیفت:";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label3.Location=new System.Drawing.Point(880, 43);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(88, 16);
            this.Label3.TabIndex=9;
            this.Label3.Text="اولویت نمایش:";
            // 
            // PostCombo
            // 
            this.PostCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.PostCombo.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.PostCombo.Location=new System.Drawing.Point(532, 39);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(158, 24);
            this.PostCombo.TabIndex=10;
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            // 
            // KindCombo
            // 
            this.KindCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.KindCombo.Items.AddRange(new object[] {
            "همه موارد",
            "آموزش",
            "اداری",
            "عمومی"});
            this.KindCombo.Location=new System.Drawing.Point(793, 9);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(88, 24);
            this.KindCombo.TabIndex=11;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // LevelCombo
            // 
            this.LevelCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.LevelCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LevelCombo.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.LevelCombo.Items.AddRange(new object[] {
            "همه موارد",
            "عادی",
            "فوری"});
            this.LevelCombo.Location=new System.Drawing.Point(793, 39);
            this.LevelCombo.Name="LevelCombo";
            this.LevelCombo.Size=new System.Drawing.Size(88, 24);
            this.LevelCombo.TabIndex=12;
            this.LevelCombo.SelectedIndexChanged += new System.EventHandler(this.LevelCombo_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Label5.Location=new System.Drawing.Point(275, 43);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(55, 16);
            this.Label5.TabIndex=13;
            this.Label5.Text="تا تاریخ :";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor=System.Drawing.Color.FromArgb(255, 255, ((int)(((byte)(128)))));
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Cursor=Cursors.Hand;
            this.ShowButton.Location=new System.Drawing.Point(13, 9);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(106, 54);
            this.ShowButton.TabIndex=14;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location=new System.Drawing.Point(147, 10);
            this.StartCalendar.Miladi=new System.DateTime(((long)(0)));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=false;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex=15;
            this.StartCalendar.TextAlign=HorizontalAlignment.Center;
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location=new System.Drawing.Point(147, 40);
            this.EndCalendar.Miladi=new System.DateTime(((long)(0)));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=false;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex=16;
            this.EndCalendar.TextAlign=HorizontalAlignment.Center;
            // 
            // Panel2
            // 
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.TitrLabel);
            this.Panel2.Controls.Add(this.KindLabel);
            this.Panel2.Controls.Add(this.PostLabel);
            this.Panel2.Controls.Add(this.LocalLabel);
            this.Panel2.Controls.Add(this.ShiftTimeLabel);
            this.Panel2.Controls.Add(this.ShiftNameLabel);
            this.Panel2.Controls.Add(this.LevelLabel);
            this.Panel2.Controls.Add(this.DateLabel);
            this.Panel2.Controls.Add(this.RegLabel);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label17);
            this.Panel2.Location=new System.Drawing.Point(718, 386);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(270, 299);
            this.Panel2.TabIndex=3;
            // 
            // TitrLabel
            // 
            this.TitrLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.TitrLabel.ForeColor=System.Drawing.Color.Maroon;
            this.TitrLabel.Location=new System.Drawing.Point(3, 18);
            this.TitrLabel.Name="TitrLabel";
            this.TitrLabel.Size=new System.Drawing.Size(169, 16);
            this.TitrLabel.TabIndex=0;
            this.TitrLabel.Text="عنوان اطلاعیه:";
            // 
            // KindLabel
            // 
            this.KindLabel.ForeColor=System.Drawing.Color.Maroon;
            this.KindLabel.Location=new System.Drawing.Point(3, 49);
            this.KindLabel.Name="KindLabel";
            this.KindLabel.Size=new System.Drawing.Size(169, 16);
            this.KindLabel.TabIndex=1;
            this.KindLabel.Text="نوع اطلاعیه:";
            // 
            // PostLabel
            // 
            this.PostLabel.ForeColor=System.Drawing.Color.Maroon;
            this.PostLabel.Location=new System.Drawing.Point(3, 80);
            this.PostLabel.Name="PostLabel";
            this.PostLabel.Size=new System.Drawing.Size(169, 16);
            this.PostLabel.TabIndex=2;
            this.PostLabel.Text="نمایش برای:";
            // 
            // LocalLabel
            // 
            this.LocalLabel.ForeColor=System.Drawing.Color.Maroon;
            this.LocalLabel.Location=new System.Drawing.Point(1, 142);
            this.LocalLabel.Name="LocalLabel";
            this.LocalLabel.Size=new System.Drawing.Size(169, 16);
            this.LocalLabel.TabIndex=3;
            this.LocalLabel.Text="نوع شیفت:";
            // 
            // ShiftTimeLabel
            // 
            this.ShiftTimeLabel.ForeColor=System.Drawing.Color.Maroon;
            this.ShiftTimeLabel.Location=new System.Drawing.Point(3, 111);
            this.ShiftTimeLabel.Name="ShiftTimeLabel";
            this.ShiftTimeLabel.Size=new System.Drawing.Size(169, 16);
            this.ShiftTimeLabel.TabIndex=3;
            this.ShiftTimeLabel.Text="نوع شیفت:";
            // 
            // ShiftNameLabel
            // 
            this.ShiftNameLabel.ForeColor=System.Drawing.Color.Maroon;
            this.ShiftNameLabel.Location=new System.Drawing.Point(3, 173);
            this.ShiftNameLabel.Name="ShiftNameLabel";
            this.ShiftNameLabel.Size=new System.Drawing.Size(169, 16);
            this.ShiftNameLabel.TabIndex=4;
            this.ShiftNameLabel.Text="نام شیفت:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.ForeColor=System.Drawing.Color.Maroon;
            this.LevelLabel.Location=new System.Drawing.Point(3, 204);
            this.LevelLabel.Name="LevelLabel";
            this.LevelLabel.Size=new System.Drawing.Size(169, 16);
            this.LevelLabel.TabIndex=5;
            this.LevelLabel.Text="اولویت نمایش:";
            // 
            // DateLabel
            // 
            this.DateLabel.ForeColor=System.Drawing.Color.Maroon;
            this.DateLabel.Location=new System.Drawing.Point(3, 235);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(169, 16);
            this.DateLabel.TabIndex=6;
            this.DateLabel.Text="تاریخ شروع نمایش :";
            // 
            // RegLabel
            // 
            this.RegLabel.ForeColor=System.Drawing.Color.Maroon;
            this.RegLabel.Location=new System.Drawing.Point(3, 266);
            this.RegLabel.Name="RegLabel";
            this.RegLabel.Size=new System.Drawing.Size(169, 16);
            this.RegLabel.TabIndex=7;
            this.RegLabel.Text="ثبت کننده:";
            // 
            // Label9
            // 
            this.Label9.ForeColor=System.Drawing.Color.Black;
            this.Label9.Location=new System.Drawing.Point(170, 142);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(100, 23);
            this.Label9.TabIndex=8;
            this.Label9.Text="مبداء:";
            // 
            // Label10
            // 
            this.Label10.ForeColor=System.Drawing.Color.Black;
            this.Label10.Location=new System.Drawing.Point(170, 266);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(100, 23);
            this.Label10.TabIndex=9;
            this.Label10.Text="ثبت کننده:";
            // 
            // Label11
            // 
            this.Label11.ForeColor=System.Drawing.Color.Black;
            this.Label11.Location=new System.Drawing.Point(170, 235);
            this.Label11.Name="Label11";
            this.Label11.Size=new System.Drawing.Size(100, 23);
            this.Label11.TabIndex=10;
            this.Label11.Text="تاریخ نمایش :";
            // 
            // Label12
            // 
            this.Label12.ForeColor=System.Drawing.Color.Black;
            this.Label12.Location=new System.Drawing.Point(170, 173);
            this.Label12.Name="Label12";
            this.Label12.Size=new System.Drawing.Size(100, 23);
            this.Label12.TabIndex=11;
            this.Label12.Text="نام شیفت:";
            // 
            // Label13
            // 
            this.Label13.ForeColor=System.Drawing.Color.Black;
            this.Label13.Location=new System.Drawing.Point(170, 49);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(100, 23);
            this.Label13.TabIndex=12;
            this.Label13.Text="نوع اطلاعیه:";
            // 
            // Label14
            // 
            this.Label14.ForeColor=System.Drawing.Color.Black;
            this.Label14.Location=new System.Drawing.Point(170, 80);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(100, 23);
            this.Label14.TabIndex=13;
            this.Label14.Text="نمایش برای:";
            // 
            // Label15
            // 
            this.Label15.ForeColor=System.Drawing.Color.Black;
            this.Label15.Location=new System.Drawing.Point(170, 111);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(100, 23);
            this.Label15.TabIndex=14;
            this.Label15.Text="نوع شیفت:";
            // 
            // Label16
            // 
            this.Label16.ForeColor=System.Drawing.Color.Black;
            this.Label16.Location=new System.Drawing.Point(170, 204);
            this.Label16.Name="Label16";
            this.Label16.Size=new System.Drawing.Size(100, 23);
            this.Label16.TabIndex=15;
            this.Label16.Text="اولویت نمایش:";
            // 
            // Label17
            // 
            this.Label17.ForeColor=System.Drawing.Color.Black;
            this.Label17.Location=new System.Drawing.Point(170, 18);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(100, 23);
            this.Label17.TabIndex=16;
            this.Label17.Text="عنوان اطلاعیه:";
            // 
            // Panel3
            // 
            this.Panel3.BackColor=System.Drawing.Color.FromArgb(0, 0, ((int)(((byte)(64)))));
            this.Panel3.Controls.Add(this.ShowBox);
            this.Panel3.Location=new System.Drawing.Point(10, 386);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(704, 299);
            this.Panel3.TabIndex=4;
            // 
            // ShowBox
            // 
            this.ShowBox.Location=new System.Drawing.Point(2, 2);
            this.ShowBox.MinimumSize=new System.Drawing.Size(20, 20);
            this.ShowBox.Name="ShowBox";
            this.ShowBox.Size=new System.Drawing.Size(700, 295);
            this.ShowBox.TabIndex=0;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            this.DataGridView1.ColumnHeadersHeight=40;
            this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(463, 128);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor=System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode=DataGridViewTriState.False;
            this.DataGridView1.RowsDefaultCellStyle=dataGridViewCellStyle1;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(525, 242);
            this.DataGridView1.TabIndex=1;
            this.DataGridView1.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            // 
            // Column2
            // 
            this.Column2.HeaderText="ID";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Visible=false;
            // 
            // Column3
            // 
            this.Column3.HeaderText="عنوان اطلاعیه";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=120;
            // 
            // Column4
            // 
            this.Column4.HeaderText="تاریخ";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=80;
            // 
            // Column5
            // 
            this.Column5.HeaderText="نوع اطلاعیه";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=70;
            // 
            // Column6
            // 
            this.Column6.HeaderText="اولویت نمایش";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=75;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText="کاربر";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows=false;
            this.DataGridView2.AllowUserToDeleteRows=false;
            this.DataGridView2.AllowUserToResizeColumns=false;
            this.DataGridView2.AllowUserToResizeRows=false;
            this.DataGridView2.ColumnHeadersHeight=40;
            this.DataGridView2.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView2.Columns.AddRange(new DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DataGridView2.EnableHeadersVisualStyles=false;
            this.DataGridView2.Location=new System.Drawing.Point(10, 128);
            this.DataGridView2.MultiSelect=false;
            this.DataGridView2.Name="DataGridView2";
            this.DataGridView2.ReadOnly=true;
            this.DataGridView2.RowHeadersVisible=false;
            this.DataGridView2.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor=System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
            this.DataGridView2.RowsDefaultCellStyle=dataGridViewCellStyle2;
            this.DataGridView2.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size=new System.Drawing.Size(405, 242);
            this.DataGridView2.TabIndex=2;
            // 
            // Label18
            // 
            this.Label18.BackColor=System.Drawing.Color.Gray;
            this.Label18.BorderStyle=BorderStyle.FixedSingle;
            this.Label18.ForeColor=System.Drawing.Color.Yellow;
            this.Label18.Location=new System.Drawing.Point(840, 101);
            this.Label18.Name="Label18";
            this.Label18.Size=new System.Drawing.Size(148, 24);
            this.Label18.TabIndex=5;
            this.Label18.Text="اطلاعیه های ثبت شده";
            this.Label18.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.BackColor=System.Drawing.Color.Gray;
            this.Label19.BorderStyle=BorderStyle.FixedSingle;
            this.Label19.ForeColor=System.Drawing.Color.Lime;
            this.Label19.Location=new System.Drawing.Point(272, 101);
            this.Label19.Name="Label19";
            this.Label19.Size=new System.Drawing.Size(100, 24);
            this.Label19.TabIndex=6;
            this.Label19.Text="مطالعه کنندگان";
            this.Label19.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label20
            // 
            this.Label20.AutoSize=true;
            this.Label20.Location=new System.Drawing.Point(417, 197);
            this.Label20.Name="Label20";
            this.Label20.Size=new System.Drawing.Size(44, 16);
            this.Label20.TabIndex=7;
            this.Label20.Text=">>>>";
            // 
            // Label21
            // 
            this.Label21.AutoSize=true;
            this.Label21.Location=new System.Drawing.Point(417, 236);
            this.Label21.Name="Label21";
            this.Label21.Size=new System.Drawing.Size(44, 16);
            this.Label21.TabIndex=8;
            this.Label21.Text=">>>>";
            // 
            // Label22
            // 
            this.Label22.AutoSize=true;
            this.Label22.Location=new System.Drawing.Point(417, 275);
            this.Label22.Name="Label22";
            this.Label22.Size=new System.Drawing.Size(44, 16);
            this.Label22.TabIndex=9;
            this.Label22.Text=">>>>";
            // 
            // Column8
            // 
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=45;
            // 
            // Column9
            // 
            this.Column9.HeaderText="نام";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=80;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText="نام خانوادگی";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            // 
            // Column11
            // 
            this.Column11.HeaderText="زمان مشاهده";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=135;
            // 
            // AnnounceReportForm
            // 
            this.BackColor=System.Drawing.Color.LightBlue;
            this.ClientSize=new System.Drawing.Size(997, 695);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label22);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="AnnounceReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش اطلاعیه های ثبت شده";
            this.Load += new System.EventHandler(this.AnnounceReportForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Panel Panel1;
        private ComboBox LocalCombo, ShiftCombo, TimeCombo, PostCombo, KindCombo, LevelCombo;
        private Label Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8;
        private Button ShowButton;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar, EndCalendar;
        private DataGridView DataGridView1, DataGridView2;
        private Panel Panel2, Panel3;
        private Label TitrLabel, KindLabel, PostLabel, ShiftTimeLabel, ShiftNameLabel, LevelLabel, DateLabel, RegLabel;
        private Label Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17;
        private Label Label18, Label19, Label20, Label21, Label22;
        private Label LocalLabel;
        private DataGridViewTextBoxColumn Column1, Column2, Column3, Column4, Column5, Column6, Column7;
        private WebBrowser ShowBox;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}
