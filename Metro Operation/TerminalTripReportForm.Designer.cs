using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TerminalTripReportForm : BaseForm
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
            base.Load += new System.EventHandler(TerminalTripReportForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            this.Panel1=new Panel();
            this.LocalCombo=new ComboBox();
            this.Label18=new Label();
            this.Label1=new Label();
            this.ExportButton=new Button();
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            this.ShowButton=new Button();
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.NameBox=new TextBox();
            this.Label3=new Label();
            this.NameButton=new Button();
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            this.Label2=new Label();
            this.ShowGridView=new DataGridView();
            this.ShowGridView.CellClick += new DataGridViewCellEventHandler(this.DetailGridView_CellClick);
            this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column18=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.Column12=new DataGridViewTextBoxColumn();
            this.Column16=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column14=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column15=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column13=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column17=new DataGridViewTextBoxColumn();
            this.Column19=new DataGridViewLinkColumn();
            this.Label5=new Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.SuspendLayout();
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label18);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location=new System.Drawing.Point(9, 9);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(1070, 65);
            this.Panel1.TabIndex=1;
            //
            //LocalCombo
            //
            this.LocalCombo.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            this.LocalCombo.AutoCompleteSource=AutoCompleteSource.ListItems;
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Items.AddRange(new object[] { "همه موارد", "پایانه تهران", "پایانه مهرشهر" });
            this.LocalCombo.Location=new System.Drawing.Point(911, 19);
            this.LocalCombo.Margin=new Padding(4, 5, 4, 5);
            this.LocalCombo.MaxLength=50;
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(109, 24);
            this.LocalCombo.TabIndex=102;
            //
            //Label18
            //
            this.Label18.AutoSize=true;
            this.Label18.BackColor=System.Drawing.Color.Transparent;
            this.Label18.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label18.Location=new System.Drawing.Point(1019, 23);
            this.Label18.Name="Label18";
            this.Label18.Size=new System.Drawing.Size(40, 16);
            this.Label18.TabIndex=103;
            this.Label18.Text="پایانه:";
            this.Label18.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(854, 23);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(40, 16);
            this.Label1.TabIndex=61;
            this.Label1.Text="راهبر:";
            //
            //ExportButton
            //
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Cursor=Cursors.Hand;
            this.ExportButton.Location=new System.Drawing.Point(16, 14);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(130, 34);
            this.ExportButton.TabIndex=60;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            //
            //EndCalendar
            //
            this.EndCalendar.Location=new System.Drawing.Point(354, 20);
            this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(104, 23);
            this.EndCalendar.TabIndex=59;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(518, 20);
            this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(104, 23);
            this.StartCalendar.TabIndex=58;
            //
            //ShowButton
            //
            this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Cursor=Cursors.Hand;
            this.ShowButton.Location=new System.Drawing.Point(155, 14);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(130, 34);
            this.ShowButton.TabIndex=5;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(724, 20);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(130, 23);
            this.NameBox.TabIndex=33;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(623, 23);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(51, 16);
            this.Label3.TabIndex=24;
            this.Label3.Text="از تاریخ:";
            //
            //NameButton
            //
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(694, 19);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(459, 23);
            this.Label2.Margin=new Padding(4, 0, 4, 0);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(51, 16);
            this.Label2.TabIndex=28;
            this.Label2.Text="تا تاریخ:";
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
            this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight=40;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column8, this.Column6, this.Column18, this.Column3, this.Column10, this.Column11, this.Column12, this.Column16, this.Column7, this.Column14, this.Column2, this.Column15, this.Column1, this.Column4, this.Column13, this.Column5, this.Column9, this.Column17, this.Column19 });
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(9, 84);
            this.ShowGridView.MultiSelect=false;
            this.ShowGridView.Name="ShowGridView";
            this.ShowGridView.ReadOnly=true;
            this.ShowGridView.RowHeadersVisible=false;
            this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.ShowGridView.RowTemplate.ReadOnly=true;
            this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size=new System.Drawing.Size(1070, 504);
            this.ShowGridView.TabIndex=34;
            //
            //Column8
            //
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=45;
            //
            //Column6
            //
            this.Column6.HeaderText="تاریخ";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=85;
            //
            //Column18
            //
            this.Column18.HeaderText="پایانه";
            this.Column18.Name="Column18";
            this.Column18.ReadOnly=true;
            this.Column18.Visible=false;
            //
            //Column3
            //
            this.Column3.HeaderText="ساعت اعزام";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=75;
            //
            //Column10
            //
            this.Column10.HeaderText="قطار";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=60;
            //
            //Column11
            //
            this.Column11.HeaderText="نوع اعزام";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            //
            //Column12
            //
            this.Column12.HeaderText="وضعیت اعزام";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Width=115;
            //
            //Column16
            //
            this.Column16.HeaderText="ساعت شروع یا پایان";
            this.Column16.Name="Column16";
            this.Column16.ReadOnly=true;
            this.Column16.Width=95;
            //
            //Column7
            //
            this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText="راهبر Master";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            //
            //Column14
            //
            this.Column14.HeaderText="پرسنلی Master";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Visible=false;
            //
            //Column2
            //
            this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText="راهبر Slave";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            //
            //Column15
            //
            this.Column15.HeaderText="پرسنلی Slave";
            this.Column15.Name="Column15";
            this.Column15.ReadOnly=true;
            this.Column15.Visible=false;
            //
            //Column1
            //
            this.Column1.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText="مبدا حرکت";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Visible=false;
            //
            //Column4
            //
            this.Column4.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText="مقصد حرکت";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Visible=false;
            //
            //Column13
            //
            this.Column13.HeaderText="توضیحات";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            this.Column13.Visible=false;
            //
            //Column5
            //
            this.Column5.HeaderText="کاربر";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=120;
            //
            //Column9
            //
            this.Column9.HeaderText="تاریخ ثبت";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Visible=false;
            this.Column9.Width=130;
            //
            //Column17
            //
            this.Column17.HeaderText="مدت زمان";
            this.Column17.Name="Column17";
            this.Column17.ReadOnly=true;
            this.Column17.Visible=false;
            //
            //Column19
            //
            this.Column19.HeaderText="";
            this.Column19.LinkColor=System.Drawing.Color.Red;
            this.Column19.Name="Column19";
            this.Column19.ReadOnly=true;
            this.Column19.Resizable=DataGridViewTriState.True;
            this.Column19.SortMode=DataGridViewColumnSortMode.Automatic;
            this.Column19.VisitedLinkColor=System.Drawing.Color.Red;
            this.Column19.Width=50;
            //
            //Label5
            //
            this.Label5.BackColor=System.Drawing.Color.Black;
            this.Label5.ForeColor=System.Drawing.Color.White;
            this.Label5.Location=new System.Drawing.Point(276, 595);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(494, 24);
            this.Label5.TabIndex=42;
            this.Label5.Text="*       برای مشاهده توضیحات بر روی سطر مورد نظر کلیک کنید       *";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //TerminalTripReportForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Tan;
            this.ClientSize=new System.Drawing.Size(1089, 626);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TerminalTripReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش وضعیت تریپ پایانه";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;
        private Button ShowButton;
        private TextBox NameBox;
        private Label Label3;
        private Button NameButton;
        private Label Label2;
        private DataGridView ShowGridView;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Button ExportButton;
        private Label Label5;
        private Label Label1;
        private ComboBox LocalCombo;
        private Label Label18;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewLinkColumn Column19;
    }

}
