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
	public partial class TerminalManoverRegForm : BaseForm
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
			base.Load += new System.EventHandler(TerminalManoverRegForm_Load);
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TerminalManoverRegForm));
			DataGridViewCellStyle DataGridViewCellStyle7=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle8=new DataGridViewCellStyle();
			DataGridViewCellStyle DataGridViewCellStyle9=new DataGridViewCellStyle();
			this.Label1=new Label();
			this.Label2=new Label();
			this.EndBox=new MaskedTextBox();
			this.EndBox.Leave += new System.EventHandler(this.StartBox_Leave);
			this.StartBox=new MaskedTextBox();
			this.StartBox.Leave += new System.EventHandler(this.StartBox_Leave);
			this.TimeLabel=new Label();
			this.Label13=new Label();
			this.Label12=new Label();
			this.Label6=new Label();
			this.TeamManagBox=new TextBox();
			this.Label3=new Label();
			this.TeamManagButton=new Button();
			this.TeamManagButton.Click += new System.EventHandler(this.TeamManagButton_Click);
			this.TeamNameButton=new Button();
			this.TeamNameButton.Click += new System.EventHandler(this.TeamNameButton_Click);
			this.Label4=new Label();
			this.TeamNameBox=new TextBox();
			this.Label5=new Label();
			this.TeamAddButton=new Button();
			this.TeamAddButton.Click += new System.EventHandler(this.TeamAddButton_Click);
			this.EndLocaCombo=new ComboBox();
			this.StartLocaCombo=new ComboBox();
			this.Label9=new Label();
			this.Label10=new Label();
			this.AcceptBox=new TextBox();
			this.Label7=new Label();
			this.CoordBox=new TextBox();
			this.MemBox=new RichTextBox();
			this.Label11=new Label();
			this.TeamGridView=new DataGridView();
			this.TeamGridView.CellClick += new DataGridViewCellEventHandler(this.TeamGridView_CellClick);
			this.Column6=new DataGridViewTextBoxColumn();
			this.Column2=new DataGridViewTextBoxColumn();
			this.Column10=new DataGridViewTextBoxColumn();
			this.Column5=new DataGridViewTextBoxColumn();
			this.Column1=new DataGridViewLinkColumn();
			this.Label8=new Label();
			this.RequstNumBox=new TextBox();
			this.RequstCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Label14=new Label();
			this.Label15=new Label();
			this.LevelNumBox=new TextBox();
			this.Label16=new Label();
			this.ConctNumBox=new TextBox();
			this.Label17=new Label();
			this.Panel1=new Panel();
			this.TrainCompltCheck=new CheckBox();
			this.TrainCompltCheck.CheckedChanged += new System.EventHandler(this.TrainCompltCheck_CheckedChanged);
			this.Label19=new Label();
			this.KindCombo=new ComboBox();
			this.RequstCombo=new ComboBox();
			this.ManovrCalendar=new BPersianCalender.BPersianCalenderTextBox();
			this.Label18=new Label();
			this.Panel2=new Panel();
			this.MaskedTextBox1=new MaskedTextBox();
			this.Panel3=new Panel();
			this.ExitButton=new Button();
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			this.RegButton=new Button();
			this.TitleCombo=new ComboBox();
			((System.ComponentModel.ISupportInitialize) this.TeamGridView).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize=true;
			this.Label1.Location=new System.Drawing.Point(599, 50);
			this.Label1.Name="Label1";
			this.Label1.Size=new System.Drawing.Size(100, 16);
			this.Label1.TabIndex=0;
			this.Label1.Text="درخواست کننده:";
			//
			//label2
			//
			this.Label2.AutoSize=true;
			this.Label2.Location=new System.Drawing.Point(836, 50);
			this.Label2.Name="Label2";
			this.Label2.Size=new System.Drawing.Size(61, 16);
			this.Label2.TabIndex=0;
			this.Label2.Text="نوع مانور:";
			//
			//EndBox
			//
			this.EndBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.EndBox.Location=new System.Drawing.Point(396, 47);
			this.EndBox.Mask="00:00";
			this.EndBox.Name="EndBox";
			this.EndBox.Size=new System.Drawing.Size(51, 23);
			this.EndBox.TabIndex=4;
			this.EndBox.TextAlign=HorizontalAlignment.Center;
			this.EndBox.ValidatingType=typeof(DateTime);
			//
			//StartBox
			//
			this.StartBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.StartBox.Location=new System.Drawing.Point(396, 13);
			this.StartBox.Mask="00:00";
			this.StartBox.Name="StartBox";
			this.StartBox.Size=new System.Drawing.Size(51, 23);
			this.StartBox.TabIndex=3;
			this.StartBox.TextAlign=HorizontalAlignment.Center;
			this.StartBox.ValidatingType=typeof(DateTime);
			//
			//TimeLabel
			//
			this.TimeLabel.AutoSize=true;
			this.TimeLabel.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TimeLabel.Location=new System.Drawing.Point(405, 84);
			this.TimeLabel.Name="TimeLabel";
			this.TimeLabel.Size=new System.Drawing.Size(45, 16);
			this.TimeLabel.TabIndex=67;
			this.TimeLabel.Text="00:00";
			//
			//Label13
			//
			this.Label13.AutoSize=true;
			this.Label13.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label13.Location=new System.Drawing.Point(447, 84);
			this.Label13.Name="Label13";
			this.Label13.Size=new System.Drawing.Size(67, 16);
			this.Label13.TabIndex=68;
			this.Label13.Text="مدت زمان:";
			//
			//Label12
			//
			this.Label12.AutoSize=true;
			this.Label12.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label12.Location=new System.Drawing.Point(447, 50);
			this.Label12.Name="Label12";
			this.Label12.Size=new System.Drawing.Size(79, 16);
			this.Label12.TabIndex=69;
			this.Label12.Text="ساعت پایان:";
			//
			//Label6
			//
			this.Label6.AutoSize=true;
			this.Label6.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label6.Location=new System.Drawing.Point(447, 16);
			this.Label6.Name="Label6";
			this.Label6.Size=new System.Drawing.Size(85, 16);
			this.Label6.TabIndex=70;
			this.Label6.Text="ساعت شروع:";
			//
			//TeamManagBox
			//
			this.TeamManagBox.BackColor=System.Drawing.SystemColors.Window;
			this.TeamManagBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TeamManagBox.Location=new System.Drawing.Point(645, 13);
			this.TeamManagBox.Name="TeamManagBox";
			this.TeamManagBox.ReadOnly=true;
			this.TeamManagBox.Size=new System.Drawing.Size(149, 23);
			this.TeamManagBox.TabIndex=73;
			this.TeamManagBox.TabStop=false;
			//
			//Label3
			//
			this.Label3.AutoSize=true;
			this.Label3.BackColor=System.Drawing.Color.Transparent;
			this.Label3.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label3.Location=new System.Drawing.Point(794, 16);
			this.Label3.Name="Label3";
			this.Label3.Size=new System.Drawing.Size(83, 16);
			this.Label3.TabIndex=72;
			this.Label3.Text="مسئول مانور:";
			this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TeamManagButton
			//
			this.TeamManagButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TeamManagButton.Image=(System.Drawing.Image) (resources.GetObject("TeamManagButton.Image"));
			this.TeamManagButton.Location=new System.Drawing.Point(614, 12);
			this.TeamManagButton.Name="TeamManagButton";
			this.TeamManagButton.Size=new System.Drawing.Size(30, 25);
			this.TeamManagButton.TabIndex=0;
			this.TeamManagButton.UseVisualStyleBackColor=true;
			//
			//TeamNameButton
			//
			this.TeamNameButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TeamNameButton.Image=(System.Drawing.Image) (resources.GetObject("TeamNameButton.Image"));
			this.TeamNameButton.Location=new System.Drawing.Point(679, 248);
			this.TeamNameButton.Name="TeamNameButton";
			this.TeamNameButton.Size=new System.Drawing.Size(30, 25);
			this.TeamNameButton.TabIndex=2;
			this.TeamNameButton.UseVisualStyleBackColor=true;
			//
			//Label4
			//
			this.Label4.AutoSize=true;
			this.Label4.BackColor=System.Drawing.Color.Transparent;
			this.Label4.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label4.Location=new System.Drawing.Point(844, 252);
			this.Label4.Name="Label4";
			this.Label4.Size=new System.Drawing.Size(79, 16);
			this.Label4.TabIndex=72;
			this.Label4.Text="پرسنل مانور:";
			this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TeamNameBox
			//
			this.TeamNameBox.BackColor=System.Drawing.SystemColors.Window;
			this.TeamNameBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.TeamNameBox.Location=new System.Drawing.Point(709, 249);
			this.TeamNameBox.Name="TeamNameBox";
			this.TeamNameBox.ReadOnly=true;
			this.TeamNameBox.Size=new System.Drawing.Size(135, 23);
			this.TeamNameBox.TabIndex=73;
			this.TeamNameBox.TabStop=false;
			//
			//Label5
			//
			this.Label5.AutoSize=true;
			this.Label5.BackColor=System.Drawing.Color.Transparent;
			this.Label5.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label5.Location=new System.Drawing.Point(624, 252);
			this.Label5.Name="Label5";
			this.Label5.Size=new System.Drawing.Size(44, 16);
			this.Label5.TabIndex=72;
			this.Label5.Text="عنوان:";
			this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TeamAddButton
			//
			this.TeamAddButton.Location=new System.Drawing.Point(428, 248);
			this.TeamAddButton.Name="TeamAddButton";
			this.TeamAddButton.Size=new System.Drawing.Size(66, 25);
			this.TeamAddButton.TabIndex=4;
			this.TeamAddButton.Text="اضافه";
			this.TeamAddButton.UseVisualStyleBackColor=true;
			//
			//EndLocaCombo
			//
			this.EndLocaCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.EndLocaCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.EndLocaCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.EndLocaCombo.FormattingEnabled=true;
			this.EndLocaCombo.Location=new System.Drawing.Point(614, 80);
			this.EndLocaCombo.Margin=new Padding(4, 5, 4, 5);
			this.EndLocaCombo.MaxLength=50;
			this.EndLocaCombo.Name="EndLocaCombo";
			this.EndLocaCombo.Size=new System.Drawing.Size(180, 24);
			this.EndLocaCombo.TabIndex=2;
			//
			//StartLocaCombo
			//
			this.StartLocaCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.StartLocaCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.StartLocaCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.StartLocaCombo.FormattingEnabled=true;
			this.StartLocaCombo.Location=new System.Drawing.Point(614, 46);
			this.StartLocaCombo.Margin=new Padding(4, 5, 4, 5);
			this.StartLocaCombo.MaxLength=50;
			this.StartLocaCombo.Name="StartLocaCombo";
			this.StartLocaCombo.Size=new System.Drawing.Size(180, 24);
			this.StartLocaCombo.TabIndex=1;
			//
			//Label9
			//
			this.Label9.AutoSize=true;
			this.Label9.BackColor=System.Drawing.Color.Transparent;
			this.Label9.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label9.Location=new System.Drawing.Point(794, 50);
			this.Label9.Name="Label9";
			this.Label9.Size=new System.Drawing.Size(71, 16);
			this.Label9.TabIndex=77;
			this.Label9.Text="مبدا حرکت:";
			this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label10
			//
			this.Label10.AutoSize=true;
			this.Label10.BackColor=System.Drawing.Color.Transparent;
			this.Label10.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label10.Location=new System.Drawing.Point(794, 84);
			this.Label10.Name="Label10";
			this.Label10.Size=new System.Drawing.Size(80, 16);
			this.Label10.TabIndex=78;
			this.Label10.Text="مقصد حرکت:";
			this.Label10.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//AcceptBox
			//
			this.AcceptBox.BackColor=System.Drawing.SystemColors.Window;
			this.AcceptBox.Enabled=false;
			this.AcceptBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.AcceptBox.Location=new System.Drawing.Point(15, 47);
			this.AcceptBox.Name="AcceptBox";
			this.AcceptBox.Size=new System.Drawing.Size(125, 23);
			this.AcceptBox.TabIndex=7;
			//
			//Label7
			//
			this.Label7.AutoSize=true;
			this.Label7.Location=new System.Drawing.Point(358, 50);
			this.Label7.Name="Label7";
			this.Label7.Size=new System.Drawing.Size(94, 16);
			this.Label7.TabIndex=0;
			this.Label7.Text="هماهنگ کننده:";
			//
			//CoordBox
			//
			this.CoordBox.BackColor=System.Drawing.SystemColors.Window;
			this.CoordBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.CoordBox.Location=new System.Drawing.Point(232, 47);
			this.CoordBox.Name="CoordBox";
			this.CoordBox.Size=new System.Drawing.Size(125, 23);
			this.CoordBox.TabIndex=5;
			//
			//MemBox
			//
			this.MemBox.Location=new System.Drawing.Point(20, 280);
			this.MemBox.MaxLength=250;
			this.MemBox.Name="MemBox";
			this.MemBox.Size=new System.Drawing.Size(385, 248);
			this.MemBox.TabIndex=5;
			this.MemBox.Text="";
			//
			//Label11
			//
			this.Label11.AutoSize=true;
			this.Label11.BackColor=System.Drawing.Color.Transparent;
			this.Label11.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label11.Location=new System.Drawing.Point(325, 257);
			this.Label11.Name="Label11";
			this.Label11.Size=new System.Drawing.Size(69, 16);
			this.Label11.TabIndex=80;
			this.Label11.Text="شرح مانور:";
			this.Label11.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
			//
			//TeamGridView
			//
			this.TeamGridView.AllowUserToAddRows=false;
			this.TeamGridView.AllowUserToDeleteRows=false;
			this.TeamGridView.AllowUserToResizeColumns=false;
			this.TeamGridView.AllowUserToResizeRows=false;
			DataGridViewCellStyle7.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle7.BackColor=System.Drawing.Color.Moccasin;
			this.TeamGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle7;
			DataGridViewCellStyle8.Alignment=DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle8.BackColor=System.Drawing.Color.Black;
			DataGridViewCellStyle8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			DataGridViewCellStyle8.ForeColor=System.Drawing.Color.Yellow;
			DataGridViewCellStyle8.SelectionBackColor=System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle8.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle8.WrapMode=DataGridViewTriState.True;
			this.TeamGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle8;
			this.TeamGridView.ColumnHeadersHeight=40;
			this.TeamGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TeamGridView.Columns.AddRange(new DataGridViewColumn[] {this.Column6, this.Column2, this.Column10, this.Column5, this.Column1});
			this.TeamGridView.EnableHeadersVisualStyles=false;
			this.TeamGridView.Location=new System.Drawing.Point(423, 280);
			this.TeamGridView.MultiSelect=false;
			this.TeamGridView.Name="TeamGridView";
			this.TeamGridView.ReadOnly=true;
			this.TeamGridView.RowHeadersVisible=false;
			this.TeamGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.TeamGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
			this.TeamGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.TeamGridView.RowTemplate.ReadOnly=true;
			this.TeamGridView.RowTemplate.Resizable=DataGridViewTriState.False;
			this.TeamGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
			this.TeamGridView.Size=new System.Drawing.Size(510, 248);
			this.TeamGridView.TabIndex=81;
			this.TeamGridView.TabStop=false;
			//
			//Column6
			//
			this.Column6.HeaderText="نام";
			this.Column6.Name="Column6";
			this.Column6.ReadOnly=true;
			//
			//Column2
			//
			this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText="نام خانوادگی";
			this.Column2.Name="Column2";
			this.Column2.ReadOnly=true;
			//
			//Column10
			//
			this.Column10.HeaderText="پرسنلی";
			this.Column10.Name="Column10";
			this.Column10.ReadOnly=true;
			this.Column10.Width=80;
			//
			//Column5
			//
			this.Column5.HeaderText="عنوان";
			this.Column5.Name="Column5";
			this.Column5.ReadOnly=true;
			this.Column5.Width=130;
			//
			//Column1
			//
			this.Column1.ActiveLinkColor=System.Drawing.Color.Black;
			DataGridViewCellStyle9.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Column1.DefaultCellStyle=DataGridViewCellStyle9;
			this.Column1.HeaderText="";
			this.Column1.LinkColor=System.Drawing.Color.Black;
			this.Column1.Name="Column1";
			this.Column1.ReadOnly=true;
			this.Column1.VisitedLinkColor=System.Drawing.Color.Black;
			this.Column1.Width=60;
			//
			//Label8
			//
			this.Label8.AutoSize=true;
			this.Label8.Location=new System.Drawing.Point(358, 16);
			this.Label8.Name="Label8";
			this.Label8.Size=new System.Drawing.Size(107, 16);
			this.Label8.TabIndex=0;
			this.Label8.Text="شماره درخواست:";
			//
			//RequstNumBox
			//
			this.RequstNumBox.BackColor=System.Drawing.SystemColors.Window;
			this.RequstNumBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.RequstNumBox.Location=new System.Drawing.Point(232, 13);
			this.RequstNumBox.Name="RequstNumBox";
			this.RequstNumBox.Size=new System.Drawing.Size(125, 23);
			this.RequstNumBox.TabIndex=4;
			//
			//RequstCalendar
			//
			this.RequstCalendar.Location=new System.Drawing.Point(474, 13);
			this.RequstCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.RequstCalendar.Name="RequstCalendar";
			this.RequstCalendar.NowDateSelected=true;
			this.RequstCalendar.ReadOnly=true;
			this.RequstCalendar.SelectedDate=null;
			this.RequstCalendar.Shamsi=null;
			this.RequstCalendar.Size=new System.Drawing.Size(125, 23);
			this.RequstCalendar.TabIndex=2;
			this.RequstCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Label14
			//
			this.Label14.AutoSize=true;
			this.Label14.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label14.Location=new System.Drawing.Point(599, 16);
			this.Label14.Margin=new Padding(5, 0, 5, 0);
			this.Label14.Name="Label14";
			this.Label14.Size=new System.Drawing.Size(97, 16);
			this.Label14.TabIndex=83;
			this.Label14.Text="تاریخ درخواست:";
			//
			//Label15
			//
			this.Label15.AutoSize=true;
			this.Label15.Location=new System.Drawing.Point(199, 16);
			this.Label15.Name="Label15";
			this.Label15.Size=new System.Drawing.Size(106, 16);
			this.Label15.TabIndex=0;
			this.Label15.Text="تعداد مراحل مانور:";
			//
			//LevelNumBox
			//
			this.LevelNumBox.BackColor=System.Drawing.SystemColors.Window;
			this.LevelNumBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.LevelNumBox.Location=new System.Drawing.Point(149, 13);
			this.LevelNumBox.Name="LevelNumBox";
			this.LevelNumBox.Size=new System.Drawing.Size(50, 23);
			this.LevelNumBox.TabIndex=5;
			this.LevelNumBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label16
			//
			this.Label16.AutoSize=true;
			this.Label16.Location=new System.Drawing.Point(199, 50);
			this.Label16.Name="Label16";
			this.Label16.Size=new System.Drawing.Size(121, 16);
			this.Label16.TabIndex=0;
			this.Label16.Text="تعداد اتصال و انفصال:";
			//
			//ConctNumBox
			//
			this.ConctNumBox.BackColor=System.Drawing.SystemColors.Window;
			this.ConctNumBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.ConctNumBox.Location=new System.Drawing.Point(149, 47);
			this.ConctNumBox.Name="ConctNumBox";
			this.ConctNumBox.Size=new System.Drawing.Size(50, 23);
			this.ConctNumBox.TabIndex=6;
			this.ConctNumBox.TextAlign=HorizontalAlignment.Center;
			//
			//Label17
			//
			this.Label17.AutoSize=true;
			this.Label17.Location=new System.Drawing.Point(199, 84);
			this.Label17.Name="Label17";
			this.Label17.Size=new System.Drawing.Size(90, 16);
			this.Label17.TabIndex=0;
			this.Label17.Text="وسایل کشنده:";
			//
			//Panel1
			//
			this.Panel1.BorderStyle=BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TrainCompltCheck);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.KindCombo);
			this.Panel1.Controls.Add(this.RequstCombo);
			this.Panel1.Controls.Add(this.CoordBox);
			this.Panel1.Controls.Add(this.ManovrCalendar);
			this.Panel1.Controls.Add(this.RequstCalendar);
			this.Panel1.Controls.Add(this.Label18);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label14);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.RequstNumBox);
			this.Panel1.Controls.Add(this.AcceptBox);
			this.Panel1.Location=new System.Drawing.Point(20, 17);
			this.Panel1.Name="Panel1";
			this.Panel1.Size=new System.Drawing.Size(913, 84);
			this.Panel1.TabIndex=0;
			//
			//TrainCompltCheck
			//
			this.TrainCompltCheck.AutoSize=true;
			this.TrainCompltCheck.Location=new System.Drawing.Point(46, 15);
			this.TrainCompltCheck.Name="TrainCompltCheck";
			this.TrainCompltCheck.Size=new System.Drawing.Size(140, 20);
			this.TrainCompltCheck.TabIndex=6;
			this.TrainCompltCheck.Text="قطار کامل تحویل شد";
			this.TrainCompltCheck.UseVisualStyleBackColor=true;
			//
			//Label19
			//
			this.Label19.AutoSize=true;
			this.Label19.Location=new System.Drawing.Point(140, 50);
			this.Label19.Name="Label19";
			this.Label19.Size=new System.Drawing.Size(82, 16);
			this.Label19.TabIndex=84;
			this.Label19.Text="تحویل گیرنده:";
			//
			//KindCombo
			//
			this.KindCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.KindCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.KindCombo.FormattingEnabled=true;
			this.KindCombo.Items.AddRange(new object[] {"جابجایی لکوموتیو", "جابجایی واگن", "جایگزینی لکوموتیو", "جایگزینی واگن", "سایر موارد"});
			this.KindCombo.Location=new System.Drawing.Point(711, 46);
			this.KindCombo.Margin=new Padding(4, 5, 4, 5);
			this.KindCombo.MaxLength=50;
			this.KindCombo.Name="KindCombo";
			this.KindCombo.Size=new System.Drawing.Size(125, 24);
			this.KindCombo.TabIndex=1;
			//
			//RequstCombo
			//
			this.RequstCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
			this.RequstCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
			this.RequstCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.RequstCombo.FormattingEnabled=true;
			this.RequstCombo.Items.AddRange(new object[] {"واگن سازی", "نظارت", "نت جاری", "ایمنی و سوانح", "متفرقه"});
			this.RequstCombo.Location=new System.Drawing.Point(474, 46);
			this.RequstCombo.Margin=new Padding(4, 5, 4, 5);
			this.RequstCombo.MaxLength=50;
			this.RequstCombo.Name="RequstCombo";
			this.RequstCombo.Size=new System.Drawing.Size(125, 24);
			this.RequstCombo.TabIndex=3;
			//
			//ManovrCalendar
			//
			this.ManovrCalendar.Location=new System.Drawing.Point(711, 13);
			this.ManovrCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
			this.ManovrCalendar.Name="ManovrCalendar";
			this.ManovrCalendar.NowDateSelected=true;
			this.ManovrCalendar.ReadOnly=true;
			this.ManovrCalendar.SelectedDate=null;
			this.ManovrCalendar.Shamsi=null;
			this.ManovrCalendar.Size=new System.Drawing.Size(125, 23);
			this.ManovrCalendar.TabIndex=0;
			this.ManovrCalendar.TextAlign=HorizontalAlignment.Center;
			//
			//Label18
			//
			this.Label18.AutoSize=true;
			this.Label18.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.Label18.Location=new System.Drawing.Point(836, 16);
			this.Label18.Margin=new Padding(5, 0, 5, 0);
			this.Label18.Name="Label18";
			this.Label18.Size=new System.Drawing.Size(69, 16);
			this.Label18.TabIndex=83;
			this.Label18.Text="تاریخ مانور:";
			//
			//Panel2
			//
			this.Panel2.BorderStyle=BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.ConctNumBox);
			this.Panel2.Controls.Add(this.LevelNumBox);
			this.Panel2.Controls.Add(this.MaskedTextBox1);
			this.Panel2.Controls.Add(this.StartLocaCombo);
			this.Panel2.Controls.Add(this.Label15);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label16);
			this.Panel2.Controls.Add(this.Label17);
			this.Panel2.Controls.Add(this.EndLocaCombo);
			this.Panel2.Controls.Add(this.Label12);
			this.Panel2.Controls.Add(this.Label13);
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.TimeLabel);
			this.Panel2.Controls.Add(this.Label10);
			this.Panel2.Controls.Add(this.StartBox);
			this.Panel2.Controls.Add(this.EndBox);
			this.Panel2.Controls.Add(this.TeamManagButton);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.TeamManagBox);
			this.Panel2.Location=new System.Drawing.Point(20, 112);
			this.Panel2.Name="Panel2";
			this.Panel2.Size=new System.Drawing.Size(913, 119);
			this.Panel2.TabIndex=1;
			//
			//MaskedTextBox1
			//
			this.MaskedTextBox1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.MaskedTextBox1.Location=new System.Drawing.Point(113, 81);
			this.MaskedTextBox1.Mask=">A0 و >A0 و >A0";
			this.MaskedTextBox1.Name="MaskedTextBox1";
			this.MaskedTextBox1.Size=new System.Drawing.Size(86, 23);
			this.MaskedTextBox1.TabIndex=7;
			this.MaskedTextBox1.TextAlign=HorizontalAlignment.Center;
			this.MaskedTextBox1.ValidatingType=typeof(DateTime);
			//
			//Panel3
			//
			this.Panel3.BackColor=System.Drawing.SystemColors.Control;
			this.Panel3.BorderStyle=BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.ExitButton);
			this.Panel3.Controls.Add(this.RegButton);
			this.Panel3.Location=new System.Drawing.Point(20, 546);
			this.Panel3.Name="Panel3";
			this.Panel3.Size=new System.Drawing.Size(913, 62);
			this.Panel3.TabIndex=6;
			//
			//ExitButton
			//
			this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
			this.ExitButton.Image=(System.Drawing.Image) (resources.GetObject("ExitButton.BackgroundImage"));
			this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.ExitButton.Cursor=Cursors.Hand;
			this.ExitButton.DialogResult=DialogResult.None;
			this.ExitButton.Location=new System.Drawing.Point(64, 13);
			this.ExitButton.Name="ExitButton";
			this.ExitButton.Size=new System.Drawing.Size(148, 34);
			this.ExitButton.TabIndex=1;
			this.ExitButton.Text="انصراف";
			this.ExitButton.UseVisualStyleBackColor=false;
			//
			//RegButton
			//
			this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
			this.RegButton.Image=(System.Drawing.Image) (resources.GetObject("RegButton.BackgroundImage"));
			this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.RegButton.Cursor=Cursors.Hand;
			this.RegButton.DialogResult=DialogResult.None;
			this.RegButton.Location=new System.Drawing.Point(602, 13);
			this.RegButton.Name="RegButton";
			this.RegButton.Size=new System.Drawing.Size(235, 34);
			this.RegButton.TabIndex=0;
			this.RegButton.Text="ذخیره";
			this.RegButton.UseVisualStyleBackColor=false;
			//
			//TitleCombo
			//
			this.TitleCombo.DropDownStyle=ComboBoxStyle.DropDownList;
			this.TitleCombo.FormattingEnabled=true;
			this.TitleCombo.Items.AddRange(new object[] {"راهبر برقی", "راهبر دیزل", "تکنسین مانور", "کارگر مانور"});
			this.TitleCombo.Location=new System.Drawing.Point(502, 248);
			this.TitleCombo.Name="TitleCombo";
			this.TitleCombo.Size=new System.Drawing.Size(121, 24);
			this.TitleCombo.TabIndex=3;
			//
			//TerminalManoverRegForm
			//
			this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
			this.AutoScaleMode=AutoScaleMode.None;
			this.CancelButton=this.ExitButton;
			this.ClientSize=new System.Drawing.Size(945, 618);
			this.Controls.Add(this.TitleCombo);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.TeamGridView);
			this.Controls.Add(this.MemBox);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.TeamAddButton);
			this.Controls.Add(this.TeamNameBox);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.TeamNameButton);
			this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Margin=new Padding(3, 4, 3, 4);
			this.MaximizeBox=false;
			this.MinimizeBox=false;
			this.Name="TerminalManoverRegForm";
			this.RightToLeft=RightToLeft.Yes;
			this.ShowInTaskbar=false;
			this.StartPosition=FormStartPosition.CenterScreen;
			this.Text="ثبت مانور پایانه";
			((System.ComponentModel.ISupportInitialize) this.TeamGridView).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		private Label Label1;
		private Label Label2;
		private MaskedTextBox EndBox;
		private MaskedTextBox StartBox;
		private Label TimeLabel;
		private Label Label13;
		private Label Label12;
		private Label Label6;
		private TextBox TeamManagBox;
		private Label Label3;
		private Button TeamManagButton;
		private Button TeamNameButton;
		private Label Label4;
		private TextBox TeamNameBox;
		private Label Label5;
		private Button TeamAddButton;
		private ComboBox EndLocaCombo;
		private ComboBox StartLocaCombo;
		private Label Label9;
		private Label Label10;
		private TextBox AcceptBox;
		private Label Label7;
		private TextBox CoordBox;
		private RichTextBox MemBox;
		private Label Label11;
		private DataGridView TeamGridView;
		private Label Label8;
		private TextBox RequstNumBox;
		private Label Label14;
		private Label Label15;
		private TextBox LevelNumBox;
		private Label Label16;
		private TextBox ConctNumBox;
		private Label Label17;
		private Panel Panel1;
		private ComboBox KindCombo;
		private ComboBox RequstCombo;
		private Label Label19;
		private Label Label18;
		private Panel Panel2;
		private MaskedTextBox MaskedTextBox1;
		private CheckBox TrainCompltCheck;
		private Panel Panel3;
		private Button ExitButton;
		private Button RegButton;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewLinkColumn Column1;
		private ComboBox TitleCombo;
		private BPersianCalender.BPersianCalenderTextBox RequstCalendar;
		private BPersianCalender.BPersianCalenderTextBox ManovrCalendar;
	}
	
}
