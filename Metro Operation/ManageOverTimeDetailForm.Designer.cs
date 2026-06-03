using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ManageOverTimeDetailForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10=new System.Windows.Forms.DataGridViewCellStyle();
            this.TimeLeaveGridView=new System.Windows.Forms.DataGridView();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1=new System.Windows.Forms.Panel();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.ZeroRowCheck=new System.Windows.Forms.CheckBox();
            this.PostCombo=new System.Windows.Forms.ComboBox();
            this.Label5=new System.Windows.Forms.Label();
            this.Label3=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.LocalCombo=new System.Windows.Forms.ComboBox();
            this.KindCombo=new System.Windows.Forms.ComboBox();
            this.TimeCombo=new System.Windows.Forms.ComboBox();
            this.ShiftCombo=new System.Windows.Forms.ComboBox();
            this.ExportButton=new System.Windows.Forms.Button();
            this.ShowButton=new System.Windows.Forms.Button();
            this.Label15=new System.Windows.Forms.Label();
            this.Label14=new System.Windows.Forms.Label();
            this.Label12=new System.Windows.Forms.Label();
            this.Label7=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.Label6=new System.Windows.Forms.Label();
            this.Label9=new System.Windows.Forms.Label();
            this.Label13=new System.Windows.Forms.Label();
            this.DailyLeavAutoGridView=new System.Windows.Forms.DataGridView();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn21=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HamkariGridView=new System.Windows.Forms.DataGridView();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EzafeAutoGridView=new System.Windows.Forms.DataGridView();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassGridView=new System.Windows.Forms.DataGridView();
            this.Column8=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeshikGridView=new System.Windows.Forms.DataGridView();
            this.Column9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn19=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn20=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn22=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TashvighGridView=new System.Windows.Forms.DataGridView();
            this.Column10=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn23=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn24=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn25=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn26=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayGridView=new System.Windows.Forms.DataGridView();
            this.Column11=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn27=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn28=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn29=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn30=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyLeavManuGridView=new System.Windows.Forms.DataGridView();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn31=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn32=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn33=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn34=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label17=new System.Windows.Forms.Label();
            this.Label19=new System.Windows.Forms.Label();
            this.Label23=new System.Windows.Forms.Label();
            this.Label27=new System.Windows.Forms.Label();
            this.Label29=new System.Windows.Forms.Label();
            this.Label21=new System.Windows.Forms.Label();
            this.Label26=new System.Windows.Forms.Label();
            this.TotalGridView=new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn35=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn36=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn37=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn38=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn39=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14=new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeaveGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyLeavAutoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HamkariGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EzafeAutoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeshikGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TashvighGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FridayGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyLeavManuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLeaveGridView
            // 
            this.TimeLeaveGridView.AllowUserToAddRows=false;
            this.TimeLeaveGridView.AllowUserToDeleteRows=false;
            this.TimeLeaveGridView.AllowUserToResizeColumns=false;
            this.TimeLeaveGridView.AllowUserToResizeRows=false;
            this.TimeLeaveGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.TimeLeaveGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLeaveGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle1;
            this.TimeLeaveGridView.ColumnHeadersHeight=30;
            this.TimeLeaveGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TimeLeaveGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.DataGridViewTextBoxColumn1,
            this.Column7,
            this.DataGridViewTextBoxColumn2,
            this.Column1});
            this.TimeLeaveGridView.EnableHeadersVisualStyles=false;
            this.TimeLeaveGridView.Location=new System.Drawing.Point(265, 120);
            this.TimeLeaveGridView.MultiSelect=false;
            this.TimeLeaveGridView.Name="TimeLeaveGridView";
            this.TimeLeaveGridView.ReadOnly=true;
            this.TimeLeaveGridView.RowHeadersVisible=false;
            this.TimeLeaveGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TimeLeaveGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.TimeLeaveGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.TimeLeaveGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.TimeLeaveGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimeLeaveGridView.Size=new System.Drawing.Size(247, 257);
            this.TimeLeaveGridView.TabIndex=49;
            this.TimeLeaveGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeLeaveGridView_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText="ردیف";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=35;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly=true;
            this.DataGridViewTextBoxColumn1.Width=130;
            // 
            // Column7
            // 
            this.Column7.HeaderText="پرسنلی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Visible=false;
            this.Column7.Width=55;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly=true;
            this.DataGridViewTextBoxColumn2.Width=64;
            // 
            // Column1
            // 
            this.Column1.HeaderText="Count";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Visible=false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ZeroRowCheck);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.Label14);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.ForeColor=System.Drawing.Color.Black;
            this.Panel1.Location=new System.Drawing.Point(10, 10);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(1265, 80);
            this.Panel1.TabIndex=43;
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location=new System.Drawing.Point(441, 43);
            this.EndCalendar.Miladi=new System.DateTime(((long)(0)));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex=58;
            this.EndCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location=new System.Drawing.Point(441, 10);
            this.StartCalendar.Miladi=new System.DateTime(((long)(0)));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex=57;
            this.StartCalendar.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // ZeroRowCheck
            // 
            this.ZeroRowCheck.BackColor=System.Drawing.Color.Gray;
            this.ZeroRowCheck.ForeColor=System.Drawing.Color.White;
            this.ZeroRowCheck.Location=new System.Drawing.Point(254, 9);
            this.ZeroRowCheck.Name="ZeroRowCheck";
            this.ZeroRowCheck.Padding=new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.ZeroRowCheck.Size=new System.Drawing.Size(160, 61);
            this.ZeroRowCheck.TabIndex=56;
            this.ZeroRowCheck.Text="حذف سطر های دارای اضافه کار صفر ساعت";
            this.ZeroRowCheck.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            this.ZeroRowCheck.UseVisualStyleBackColor=false;
            this.ZeroRowCheck.CheckedChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // PostCombo
            // 
            this.PostCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PostCombo.FormattingEnabled=true;
            this.PostCombo.Location=new System.Drawing.Point(843, 27);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(161, 24);
            this.PostCombo.TabIndex=55;
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(1004, 31);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(42, 16);
            this.Label5.TabIndex=54;
            this.Label5.Text="پست:";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(573, 13);
            this.Label3.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(50, 16);
            this.Label3.TabIndex=52;
            this.Label3.Text="از تاریخ:";
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(573, 46);
            this.Label4.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(50, 16);
            this.Label4.TabIndex=53;
            this.Label4.Text="تا تاریخ:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.BackColor=System.Drawing.Color.White;
            this.LocalCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(1060, 42);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(109, 24);
            this.LocalCombo.TabIndex=48;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // KindCombo
            // 
            this.KindCombo.BackColor=System.Drawing.Color.White;
            this.KindCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] {
            "عملکرد پرسنل",
            "عملکرد کاربران"});
            this.KindCombo.Location=new System.Drawing.Point(1060, 9);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(109, 24);
            this.KindCombo.TabIndex=46;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // TimeCombo
            // 
            this.TimeCombo.BackColor=System.Drawing.Color.White;
            this.TimeCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Location=new System.Drawing.Point(652, 9);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(109, 24);
            this.TimeCombo.TabIndex=43;
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            // 
            // ShiftCombo
            // 
            this.ShiftCombo.BackColor=System.Drawing.Color.White;
            this.ShiftCombo.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Location=new System.Drawing.Point(652, 42);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(109, 24);
            this.ShiftCombo.TabIndex=41;
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(16, 40);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(161, 34);
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
            this.ShowButton.Location=new System.Drawing.Point(16, 3);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(161, 34);
            this.ShowButton.TabIndex=4;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Label15
            // 
            this.Label15.AutoSize=true;
            this.Label15.BackColor=System.Drawing.Color.Transparent;
            this.Label15.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor=System.Drawing.Color.Black;
            this.Label15.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label15.Location=new System.Drawing.Point(1168, 13);
            this.Label15.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label15.Name="Label15";
            this.Label15.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label15.Size=new System.Drawing.Size(69, 16);
            this.Label15.TabIndex=49;
            this.Label15.Text="نوع گزارش:";
            this.Label15.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.AutoSize=true;
            this.Label14.Location=new System.Drawing.Point(1168, 46);
            this.Label14.Name="Label14";
            this.Label14.Size=new System.Drawing.Size(34, 16);
            this.Label14.TabIndex=47;
            this.Label14.Text="مبدا:";
            // 
            // Label12
            // 
            this.Label12.AutoSize=true;
            this.Label12.BackColor=System.Drawing.Color.Transparent;
            this.Label12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor=System.Drawing.Color.Black;
            this.Label12.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label12.Location=new System.Drawing.Point(761, 13);
            this.Label12.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label12.Name="Label12";
            this.Label12.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size=new System.Drawing.Size(71, 16);
            this.Label12.TabIndex=44;
            this.Label12.Text="نوع شیفت:";
            this.Label12.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.AutoSize=true;
            this.Label7.BackColor=System.Drawing.Color.Transparent;
            this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor=System.Drawing.Color.Black;
            this.Label7.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label7.Location=new System.Drawing.Point(761, 46);
            this.Label7.Margin=new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label7.Name="Label7";
            this.Label7.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.Label7.Size=new System.Drawing.Size(49, 16);
            this.Label7.TabIndex=42;
            this.Label7.Text="شیفت:";
            this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Label1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location=new System.Drawing.Point(337, 96);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(174, 28);
            this.Label1.TabIndex=69;
            this.Label1.Text="جایگزین مرخصی ساعتی";
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label6.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label6.Location=new System.Drawing.Point(1102, 388);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(174, 28);
            this.Label6.TabIndex=71;
            this.Label6.Text="همکاری با شیفت";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label9.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label9.Location=new System.Drawing.Point(82, 96);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(174, 28);
            this.Label9.TabIndex=73;
            this.Label9.Text="اضافه کار(پردازش لوحه)";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Label13.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label13.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label13.Location=new System.Drawing.Point(847, 388);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(174, 28);
            this.Label13.TabIndex=75;
            this.Label13.Text="اضافه کار کلاس ";
            this.Label13.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailyLeavAutoGridView
            // 
            this.DailyLeavAutoGridView.AllowUserToAddRows=false;
            this.DailyLeavAutoGridView.AllowUserToDeleteRows=false;
            this.DailyLeavAutoGridView.AllowUserToResizeColumns=false;
            this.DailyLeavAutoGridView.AllowUserToResizeRows=false;
            this.DailyLeavAutoGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DailyLeavAutoGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DailyLeavAutoGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.DailyLeavAutoGridView.ColumnHeadersHeight=30;
            this.DailyLeavAutoGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DailyLeavAutoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn21});
            this.DailyLeavAutoGridView.EnableHeadersVisualStyles=false;
            this.DailyLeavAutoGridView.Location=new System.Drawing.Point(775, 120);
            this.DailyLeavAutoGridView.MultiSelect=false;
            this.DailyLeavAutoGridView.Name="DailyLeavAutoGridView";
            this.DailyLeavAutoGridView.ReadOnly=true;
            this.DailyLeavAutoGridView.RowHeadersVisible=false;
            this.DailyLeavAutoGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DailyLeavAutoGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.DailyLeavAutoGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.DailyLeavAutoGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.DailyLeavAutoGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DailyLeavAutoGridView.Size=new System.Drawing.Size(247, 257);
            this.DailyLeavAutoGridView.TabIndex=81;
            this.DailyLeavAutoGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyLeavAutoGridView_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText="ردیف";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=35;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly=true;
            this.DataGridViewTextBoxColumn3.Width=128;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly=true;
            this.DataGridViewTextBoxColumn4.Visible=false;
            this.DataGridViewTextBoxColumn4.Width=55;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly=true;
            this.DataGridViewTextBoxColumn5.Width=64;
            // 
            // DataGridViewTextBoxColumn21
            // 
            this.DataGridViewTextBoxColumn21.HeaderText="Count";
            this.DataGridViewTextBoxColumn21.Name="DataGridViewTextBoxColumn21";
            this.DataGridViewTextBoxColumn21.ReadOnly=true;
            this.DataGridViewTextBoxColumn21.Visible=false;
            // 
            // HamkariGridView
            // 
            this.HamkariGridView.AllowUserToAddRows=false;
            this.HamkariGridView.AllowUserToDeleteRows=false;
            this.HamkariGridView.AllowUserToResizeColumns=false;
            this.HamkariGridView.AllowUserToResizeRows=false;
            this.HamkariGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.HamkariGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.HamkariGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle3;
            this.HamkariGridView.ColumnHeadersHeight=30;
            this.HamkariGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.HamkariGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9});
            this.HamkariGridView.EnableHeadersVisualStyles=false;
            this.HamkariGridView.Location=new System.Drawing.Point(1030, 412);
            this.HamkariGridView.MultiSelect=false;
            this.HamkariGridView.Name="HamkariGridView";
            this.HamkariGridView.ReadOnly=true;
            this.HamkariGridView.RowHeadersVisible=false;
            this.HamkariGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HamkariGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.HamkariGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.HamkariGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.HamkariGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HamkariGridView.Size=new System.Drawing.Size(247, 257);
            this.HamkariGridView.TabIndex=82;
            this.HamkariGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText="ردیف";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=35;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly=true;
            this.DataGridViewTextBoxColumn6.Width=130;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn7.Name="DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly=true;
            this.DataGridViewTextBoxColumn7.Visible=false;
            this.DataGridViewTextBoxColumn7.Width=55;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn8.Name="DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly=true;
            this.DataGridViewTextBoxColumn8.Width=64;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.HeaderText="Count";
            this.DataGridViewTextBoxColumn9.Name="DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly=true;
            this.DataGridViewTextBoxColumn9.Visible=false;
            // 
            // EzafeAutoGridView
            // 
            this.EzafeAutoGridView.AllowUserToAddRows=false;
            this.EzafeAutoGridView.AllowUserToDeleteRows=false;
            this.EzafeAutoGridView.AllowUserToResizeColumns=false;
            this.EzafeAutoGridView.AllowUserToResizeRows=false;
            this.EzafeAutoGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.EzafeAutoGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.EzafeAutoGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle4;
            this.EzafeAutoGridView.ColumnHeadersHeight=30;
            this.EzafeAutoGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EzafeAutoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13});
            this.EzafeAutoGridView.EnableHeadersVisualStyles=false;
            this.EzafeAutoGridView.Location=new System.Drawing.Point(10, 120);
            this.EzafeAutoGridView.MultiSelect=false;
            this.EzafeAutoGridView.Name="EzafeAutoGridView";
            this.EzafeAutoGridView.ReadOnly=true;
            this.EzafeAutoGridView.RowHeadersVisible=false;
            this.EzafeAutoGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EzafeAutoGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.EzafeAutoGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.EzafeAutoGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.EzafeAutoGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EzafeAutoGridView.Size=new System.Drawing.Size(247, 257);
            this.EzafeAutoGridView.TabIndex=83;
            this.EzafeAutoGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EzafeAutoGridView_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText="ردیف";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=35;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn10.Name="DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly=true;
            this.DataGridViewTextBoxColumn10.Width=130;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn11.Name="DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly=true;
            this.DataGridViewTextBoxColumn11.Visible=false;
            this.DataGridViewTextBoxColumn11.Width=55;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn12.Name="DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly=true;
            this.DataGridViewTextBoxColumn12.Width=64;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.HeaderText="Count";
            this.DataGridViewTextBoxColumn13.Name="DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly=true;
            this.DataGridViewTextBoxColumn13.Visible=false;
            // 
            // ClassGridView
            // 
            this.ClassGridView.AllowUserToAddRows=false;
            this.ClassGridView.AllowUserToDeleteRows=false;
            this.ClassGridView.AllowUserToResizeColumns=false;
            this.ClassGridView.AllowUserToResizeRows=false;
            this.ClassGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.ClassGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.ClassGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle5;
            this.ClassGridView.ColumnHeadersHeight=30;
            this.ClassGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClassGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.DataGridViewTextBoxColumn14,
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn17});
            this.ClassGridView.EnableHeadersVisualStyles=false;
            this.ClassGridView.Location=new System.Drawing.Point(775, 412);
            this.ClassGridView.MultiSelect=false;
            this.ClassGridView.Name="ClassGridView";
            this.ClassGridView.ReadOnly=true;
            this.ClassGridView.RowHeadersVisible=false;
            this.ClassGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.ClassGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.ClassGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.ClassGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassGridView.Size=new System.Drawing.Size(247, 257);
            this.ClassGridView.TabIndex=84;
            this.ClassGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassGridView_CellDoubleClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=35;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn14.Name="DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly=true;
            this.DataGridViewTextBoxColumn14.Width=130;
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn15.Name="DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly=true;
            this.DataGridViewTextBoxColumn15.Visible=false;
            this.DataGridViewTextBoxColumn15.Width=55;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn16.Name="DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.ReadOnly=true;
            this.DataGridViewTextBoxColumn16.Width=64;
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.HeaderText="Count";
            this.DataGridViewTextBoxColumn17.Name="DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.ReadOnly=true;
            this.DataGridViewTextBoxColumn17.Visible=false;
            // 
            // KeshikGridView
            // 
            this.KeshikGridView.AllowUserToAddRows=false;
            this.KeshikGridView.AllowUserToDeleteRows=false;
            this.KeshikGridView.AllowUserToResizeColumns=false;
            this.KeshikGridView.AllowUserToResizeRows=false;
            this.KeshikGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.KeshikGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.KeshikGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle6;
            this.KeshikGridView.ColumnHeadersHeight=30;
            this.KeshikGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KeshikGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.DataGridViewTextBoxColumn18,
            this.DataGridViewTextBoxColumn19,
            this.DataGridViewTextBoxColumn20,
            this.DataGridViewTextBoxColumn22});
            this.KeshikGridView.EnableHeadersVisualStyles=false;
            this.KeshikGridView.Location=new System.Drawing.Point(520, 412);
            this.KeshikGridView.MultiSelect=false;
            this.KeshikGridView.Name="KeshikGridView";
            this.KeshikGridView.ReadOnly=true;
            this.KeshikGridView.RowHeadersVisible=false;
            this.KeshikGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KeshikGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.KeshikGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.KeshikGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.KeshikGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KeshikGridView.Size=new System.Drawing.Size(247, 257);
            this.KeshikGridView.TabIndex=99;
            this.KeshikGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KeshikGridView_CellDoubleClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText="ردیف";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=35;
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn18.Name="DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.ReadOnly=true;
            this.DataGridViewTextBoxColumn18.Width=130;
            // 
            // DataGridViewTextBoxColumn19
            // 
            this.DataGridViewTextBoxColumn19.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn19.Name="DataGridViewTextBoxColumn19";
            this.DataGridViewTextBoxColumn19.ReadOnly=true;
            this.DataGridViewTextBoxColumn19.Visible=false;
            this.DataGridViewTextBoxColumn19.Width=55;
            // 
            // DataGridViewTextBoxColumn20
            // 
            this.DataGridViewTextBoxColumn20.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn20.Name="DataGridViewTextBoxColumn20";
            this.DataGridViewTextBoxColumn20.ReadOnly=true;
            this.DataGridViewTextBoxColumn20.Width=64;
            // 
            // DataGridViewTextBoxColumn22
            // 
            this.DataGridViewTextBoxColumn22.HeaderText="Count";
            this.DataGridViewTextBoxColumn22.Name="DataGridViewTextBoxColumn22";
            this.DataGridViewTextBoxColumn22.ReadOnly=true;
            this.DataGridViewTextBoxColumn22.Visible=false;
            // 
            // TashvighGridView
            // 
            this.TashvighGridView.AllowUserToAddRows=false;
            this.TashvighGridView.AllowUserToDeleteRows=false;
            this.TashvighGridView.AllowUserToResizeColumns=false;
            this.TashvighGridView.AllowUserToResizeRows=false;
            this.TashvighGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.TashvighGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.TashvighGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle7;
            this.TashvighGridView.ColumnHeadersHeight=30;
            this.TashvighGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TashvighGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.DataGridViewTextBoxColumn23,
            this.DataGridViewTextBoxColumn24,
            this.DataGridViewTextBoxColumn25,
            this.DataGridViewTextBoxColumn26});
            this.TashvighGridView.EnableHeadersVisualStyles=false;
            this.TashvighGridView.Location=new System.Drawing.Point(265, 412);
            this.TashvighGridView.MultiSelect=false;
            this.TashvighGridView.Name="TashvighGridView";
            this.TashvighGridView.ReadOnly=true;
            this.TashvighGridView.RowHeadersVisible=false;
            this.TashvighGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TashvighGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.TashvighGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.TashvighGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.TashvighGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TashvighGridView.Size=new System.Drawing.Size(247, 257);
            this.TashvighGridView.TabIndex=98;
            this.TashvighGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TashvighGridView_CellDoubleClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText="ردیف";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=35;
            // 
            // DataGridViewTextBoxColumn23
            // 
            this.DataGridViewTextBoxColumn23.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn23.Name="DataGridViewTextBoxColumn23";
            this.DataGridViewTextBoxColumn23.ReadOnly=true;
            this.DataGridViewTextBoxColumn23.Width=130;
            // 
            // DataGridViewTextBoxColumn24
            // 
            this.DataGridViewTextBoxColumn24.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn24.Name="DataGridViewTextBoxColumn24";
            this.DataGridViewTextBoxColumn24.ReadOnly=true;
            this.DataGridViewTextBoxColumn24.Visible=false;
            this.DataGridViewTextBoxColumn24.Width=55;
            // 
            // DataGridViewTextBoxColumn25
            // 
            this.DataGridViewTextBoxColumn25.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn25.Name="DataGridViewTextBoxColumn25";
            this.DataGridViewTextBoxColumn25.ReadOnly=true;
            this.DataGridViewTextBoxColumn25.Width=64;
            // 
            // DataGridViewTextBoxColumn26
            // 
            this.DataGridViewTextBoxColumn26.HeaderText="Count";
            this.DataGridViewTextBoxColumn26.Name="DataGridViewTextBoxColumn26";
            this.DataGridViewTextBoxColumn26.ReadOnly=true;
            this.DataGridViewTextBoxColumn26.Visible=false;
            // 
            // FridayGridView
            // 
            this.FridayGridView.AllowUserToAddRows=false;
            this.FridayGridView.AllowUserToDeleteRows=false;
            this.FridayGridView.AllowUserToResizeColumns=false;
            this.FridayGridView.AllowUserToResizeRows=false;
            this.FridayGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.FridayGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.FridayGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle8;
            this.FridayGridView.ColumnHeadersHeight=30;
            this.FridayGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FridayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.DataGridViewTextBoxColumn27,
            this.DataGridViewTextBoxColumn28,
            this.DataGridViewTextBoxColumn29,
            this.DataGridViewTextBoxColumn30});
            this.FridayGridView.EnableHeadersVisualStyles=false;
            this.FridayGridView.Location=new System.Drawing.Point(10, 412);
            this.FridayGridView.MultiSelect=false;
            this.FridayGridView.Name="FridayGridView";
            this.FridayGridView.ReadOnly=true;
            this.FridayGridView.RowHeadersVisible=false;
            this.FridayGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FridayGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.FridayGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.FridayGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.FridayGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FridayGridView.Size=new System.Drawing.Size(247, 257);
            this.FridayGridView.TabIndex=97;
            this.FridayGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FridayGridView_CellDoubleClick);
            // 
            // Column11
            // 
            this.Column11.HeaderText="ردیف";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=35;
            // 
            // DataGridViewTextBoxColumn27
            // 
            this.DataGridViewTextBoxColumn27.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn27.Name="DataGridViewTextBoxColumn27";
            this.DataGridViewTextBoxColumn27.ReadOnly=true;
            this.DataGridViewTextBoxColumn27.Width=130;
            // 
            // DataGridViewTextBoxColumn28
            // 
            this.DataGridViewTextBoxColumn28.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn28.Name="DataGridViewTextBoxColumn28";
            this.DataGridViewTextBoxColumn28.ReadOnly=true;
            this.DataGridViewTextBoxColumn28.Visible=false;
            this.DataGridViewTextBoxColumn28.Width=55;
            // 
            // DataGridViewTextBoxColumn29
            // 
            this.DataGridViewTextBoxColumn29.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn29.Name="DataGridViewTextBoxColumn29";
            this.DataGridViewTextBoxColumn29.ReadOnly=true;
            this.DataGridViewTextBoxColumn29.Width=64;
            // 
            // DataGridViewTextBoxColumn30
            // 
            this.DataGridViewTextBoxColumn30.HeaderText="Count";
            this.DataGridViewTextBoxColumn30.Name="DataGridViewTextBoxColumn30";
            this.DataGridViewTextBoxColumn30.ReadOnly=true;
            this.DataGridViewTextBoxColumn30.Visible=false;
            // 
            // DailyLeavManuGridView
            // 
            this.DailyLeavManuGridView.AllowUserToAddRows=false;
            this.DailyLeavManuGridView.AllowUserToDeleteRows=false;
            this.DailyLeavManuGridView.AllowUserToResizeColumns=false;
            this.DailyLeavManuGridView.AllowUserToResizeRows=false;
            this.DailyLeavManuGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.DailyLeavManuGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.DailyLeavManuGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle9;
            this.DailyLeavManuGridView.ColumnHeadersHeight=30;
            this.DailyLeavManuGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DailyLeavManuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.DataGridViewTextBoxColumn31,
            this.DataGridViewTextBoxColumn32,
            this.DataGridViewTextBoxColumn33,
            this.DataGridViewTextBoxColumn34});
            this.DailyLeavManuGridView.EnableHeadersVisualStyles=false;
            this.DailyLeavManuGridView.Location=new System.Drawing.Point(520, 120);
            this.DailyLeavManuGridView.MultiSelect=false;
            this.DailyLeavManuGridView.Name="DailyLeavManuGridView";
            this.DailyLeavManuGridView.ReadOnly=true;
            this.DailyLeavManuGridView.RowHeadersVisible=false;
            this.DailyLeavManuGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DailyLeavManuGridView.RowTemplate.DefaultCellStyle.BackColor=System.Drawing.Color.White;
            this.DailyLeavManuGridView.RowTemplate.DefaultCellStyle.ForeColor=System.Drawing.Color.Black;
            this.DailyLeavManuGridView.RowTemplate.DefaultCellStyle.SelectionForeColor=System.Drawing.Color.White;
            this.DailyLeavManuGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DailyLeavManuGridView.Size=new System.Drawing.Size(247, 257);
            this.DailyLeavManuGridView.TabIndex=96;
            this.DailyLeavManuGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailyLeavManuGridView_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText="ردیف";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=35;
            // 
            // DataGridViewTextBoxColumn31
            // 
            this.DataGridViewTextBoxColumn31.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn31.Name="DataGridViewTextBoxColumn31";
            this.DataGridViewTextBoxColumn31.ReadOnly=true;
            this.DataGridViewTextBoxColumn31.Width=128;
            // 
            // DataGridViewTextBoxColumn32
            // 
            this.DataGridViewTextBoxColumn32.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn32.Name="DataGridViewTextBoxColumn32";
            this.DataGridViewTextBoxColumn32.ReadOnly=true;
            this.DataGridViewTextBoxColumn32.Visible=false;
            this.DataGridViewTextBoxColumn32.Width=55;
            // 
            // DataGridViewTextBoxColumn33
            // 
            this.DataGridViewTextBoxColumn33.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn33.Name="DataGridViewTextBoxColumn33";
            this.DataGridViewTextBoxColumn33.ReadOnly=true;
            this.DataGridViewTextBoxColumn33.Width=64;
            // 
            // DataGridViewTextBoxColumn34
            // 
            this.DataGridViewTextBoxColumn34.HeaderText="Count";
            this.DataGridViewTextBoxColumn34.Name="DataGridViewTextBoxColumn34";
            this.DataGridViewTextBoxColumn34.ReadOnly=true;
            this.DataGridViewTextBoxColumn34.Visible=false;
            // 
            // Label17
            // 
            this.Label17.BackColor=System.Drawing.Color.Tan;
            this.Label17.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label17.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label17.Location=new System.Drawing.Point(592, 388);
            this.Label17.Name="Label17";
            this.Label17.Size=new System.Drawing.Size(174, 28);
            this.Label17.TabIndex=94;
            this.Label17.Text="اضافه کار کشیک";
            this.Label17.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.BackColor=System.Drawing.Color.Violet;
            this.Label19.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label19.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label19.Location=new System.Drawing.Point(337, 388);
            this.Label19.Name="Label19";
            this.Label19.Size=new System.Drawing.Size(174, 28);
            this.Label19.TabIndex=92;
            this.Label19.Text="اضافه کار تشویقی";
            this.Label19.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label23
            // 
            this.Label23.BackColor=System.Drawing.Color.Gold;
            this.Label23.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label23.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label23.Location=new System.Drawing.Point(82, 388);
            this.Label23.Name="Label23";
            this.Label23.Size=new System.Drawing.Size(174, 28);
            this.Label23.TabIndex=90;
            this.Label23.Text="اضافه کار جمعه";
            this.Label23.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label27
            // 
            this.Label27.BackColor=System.Drawing.Color.White;
            this.Label27.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label27.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label27.Location=new System.Drawing.Point(592, 96);
            this.Label27.Name="Label27";
            this.Label27.Size=new System.Drawing.Size(174, 28);
            this.Label27.TabIndex=86;
            this.Label27.Text="جایگزین مرخصی روزانه (دستی)";
            this.Label27.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label29
            // 
            this.Label29.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Label29.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label29.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label29.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label29.Location=new System.Drawing.Point(847, 96);
            this.Label29.Name="Label29";
            this.Label29.Size=new System.Drawing.Size(174, 28);
            this.Label29.TabIndex=100;
            this.Label29.Text="جایگزین مرخصی روزانه (خودکار)";
            this.Label29.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            this.Label21.BackColor=System.Drawing.Color.Orange;
            this.Label21.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label21.Location=new System.Drawing.Point(421, 674);
            this.Label21.Name="Label21";
            this.Label21.Size=new System.Drawing.Size(461, 25);
            this.Label21.TabIndex=101;
            this.Label21.Text="----------     برای دیدن جزئیات بیشتر بر روی سطر مورد نظر کلیک کنید     ---------" +
    "-";
            this.Label21.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label26
            // 
            this.Label26.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label26.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label26.ImageAlign=System.Drawing.ContentAlignment.TopCenter;
            this.Label26.Location=new System.Drawing.Point(1102, 96);
            this.Label26.Name="Label26";
            this.Label26.Size=new System.Drawing.Size(174, 28);
            this.Label26.TabIndex=71;
            this.Label26.Text="مجموع اضافه کار";
            this.Label26.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalGridView
            // 
            this.TotalGridView.AllowUserToAddRows=false;
            this.TotalGridView.AllowUserToDeleteRows=false;
            this.TotalGridView.AllowUserToResizeColumns=false;
            this.TotalGridView.AllowUserToResizeRows=false;
            this.TotalGridView.BackgroundColor=System.Drawing.SystemColors.ActiveCaption;
            this.TotalGridView.BorderStyle=System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor=System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.TotalGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle10;
            this.TotalGridView.ColumnHeadersHeight=30;
            this.TotalGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TotalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn35,
            this.DataGridViewTextBoxColumn36,
            this.DataGridViewTextBoxColumn37,
            this.DataGridViewTextBoxColumn38,
            this.DataGridViewTextBoxColumn39,
            this.Column15,
            this.Column12,
            this.Column13,
            this.Column14});
            this.TotalGridView.EnableHeadersVisualStyles=false;
            this.TotalGridView.Location=new System.Drawing.Point(1030, 120);
            this.TotalGridView.MultiSelect=false;
            this.TotalGridView.Name="TotalGridView";
            this.TotalGridView.ReadOnly=true;
            this.TotalGridView.RowHeadersVisible=false;
            this.TotalGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TotalGridView.Size=new System.Drawing.Size(247, 257);
            this.TotalGridView.TabIndex=82;
            this.TotalGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TotalGridView_CellDoubleClick);
            // 
            // DataGridViewTextBoxColumn35
            // 
            this.DataGridViewTextBoxColumn35.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn35.Name="DataGridViewTextBoxColumn35";
            this.DataGridViewTextBoxColumn35.ReadOnly=true;
            this.DataGridViewTextBoxColumn35.Width=35;
            // 
            // DataGridViewTextBoxColumn36
            // 
            this.DataGridViewTextBoxColumn36.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn36.Name="DataGridViewTextBoxColumn36";
            this.DataGridViewTextBoxColumn36.ReadOnly=true;
            this.DataGridViewTextBoxColumn36.Width=130;
            // 
            // DataGridViewTextBoxColumn37
            // 
            this.DataGridViewTextBoxColumn37.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn37.Name="DataGridViewTextBoxColumn37";
            this.DataGridViewTextBoxColumn37.ReadOnly=true;
            this.DataGridViewTextBoxColumn37.Visible=false;
            this.DataGridViewTextBoxColumn37.Width=55;
            // 
            // DataGridViewTextBoxColumn38
            // 
            this.DataGridViewTextBoxColumn38.HeaderText="ساعت";
            this.DataGridViewTextBoxColumn38.Name="DataGridViewTextBoxColumn38";
            this.DataGridViewTextBoxColumn38.ReadOnly=true;
            this.DataGridViewTextBoxColumn38.Width=64;
            // 
            // DataGridViewTextBoxColumn39
            // 
            this.DataGridViewTextBoxColumn39.HeaderText="Count";
            this.DataGridViewTextBoxColumn39.Name="DataGridViewTextBoxColumn39";
            this.DataGridViewTextBoxColumn39.ReadOnly=true;
            this.DataGridViewTextBoxColumn39.Visible=false;
            // 
            // Column15
            // 
            this.Column15.HeaderText="پست سازمانی";
            this.Column15.Name="Column15";
            this.Column15.ReadOnly=true;
            this.Column15.Visible=false;
            // 
            // Column12
            // 
            this.Column12.HeaderText="مبدا";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Visible=false;
            // 
            // Column13
            // 
            this.Column13.HeaderText="نوع شیفت";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            this.Column13.Visible=false;
            // 
            // Column14
            // 
            this.Column14.HeaderText="نام شیفت";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Visible=false;
            // 
            // ManageOverTimeDetailForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(1286, 701);
            this.Controls.Add(this.KeshikGridView);
            this.Controls.Add(this.TashvighGridView);
            this.Controls.Add(this.FridayGridView);
            this.Controls.Add(this.DailyLeavManuGridView);
            this.Controls.Add(this.ClassGridView);
            this.Controls.Add(this.EzafeAutoGridView);
            this.Controls.Add(this.TotalGridView);
            this.Controls.Add(this.HamkariGridView);
            this.Controls.Add(this.DailyLeavAutoGridView);
            this.Controls.Add(this.TimeLeaveGridView);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton=true;
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="ManageOverTimeDetailForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="گزارش تفکیکی اضافه کار";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ManageOverTimeDetailForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.ManageOverTimeDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeaveGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyLeavAutoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HamkariGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EzafeAutoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeshikGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TashvighGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FridayGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyLeavManuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGridView)).EndInit();
            this.ResumeLayout(false);

        }
        private DataGridView TimeLeaveGridView;
        private Panel Panel1;
        private ComboBox LocalCombo;
        private ComboBox KindCombo;
        private ComboBox TimeCombo;
        private ComboBox ShiftCombo;
        private Button ExportButton;
        private Button ShowButton;
        private Label Label15;
        private Label Label14;
        private Label Label12;
        private Label Label7;
        private Label Label1;
        private Label Label6;
        private Label Label9;
        private Label Label13;
        private DataGridView DailyLeavAutoGridView;
        private DataGridView HamkariGridView;
        private DataGridView EzafeAutoGridView;
        private DataGridView ClassGridView;
        private DataGridView KeshikGridView;
        private DataGridView TashvighGridView;
        private DataGridView FridayGridView;
        private DataGridView DailyLeavManuGridView;
        private Label Label17;
        private Label Label19;
        private Label Label23;
        private Label Label27;
        private Label Label29;
        private Label Label21;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn34;
        private DataGridView TotalGridView;
        private Label Label26;
        private Label Label3;
        private Label Label4;
        private ComboBox PostCombo;
        private Label Label5;
        private CheckBox ZeroRowCheck;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private System.ComponentModel.IContainer components;
    }
}
