using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripPersonReportForm : BaseForm
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
            base.Load += new System.EventHandler(TripReportForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            this.Panel1=new Panel();
            this.Label4=new Label();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.ShiftCombo=new ComboBox();
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            this.PostCombo=new ComboBox();
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            this.TimeCombo=new ComboBox();
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            this.LocalCombo=new ComboBox();
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.LocalCombo.EnabledChanged += new System.EventHandler(this.LocalCombo_EnabledChanged);
            this.Label7=new Label();
            this.Label8=new Label();
            this.Label9=new Label();
            this.Label10=new Label();
            this.ExportButton=new Button();
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            this.ShowButton=new Button();
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.NameBox=new TextBox();
            this.Label3=new Label();
            this.NameButton=new Button();
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            this.Label2=new Label();
            this.ShowGridView=new DataGridView();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column13=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column14=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.SuspendLayout();
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location=new System.Drawing.Point(8, 8);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(922, 80);
            this.Panel1.TabIndex=1;
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(487, 15);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(29, 16);
            this.Label4.TabIndex=56;
            this.Label4.Text="نام:";
            //
            //EndCalendar
            //
            this.EndCalendar.Location=new System.Drawing.Point(130, 45);
            this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex=55;
            this.EndCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(130, 12);
            this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex=54;
            this.StartCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //ShiftCombo
            //
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Location=new System.Drawing.Point(516, 44);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(90, 24);
            this.ShiftCombo.TabIndex=47;
            //
            //PostCombo
            //
            this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.PostCombo.FormattingEnabled=true;
            this.PostCombo.Location=new System.Drawing.Point(683, 44);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(193, 24);
            this.PostCombo.TabIndex=43;
            //
            //TimeCombo
            //
            this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Location=new System.Drawing.Point(516, 11);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(90, 24);
            this.TimeCombo.TabIndex=46;
            //
            //LocalCombo
            //
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(683, 11);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(193, 24);
            this.LocalCombo.TabIndex=45;
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(875, 48);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(43, 16);
            this.Label7.TabIndex=42;
            this.Label7.Text="پست:";
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(605, 48);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(70, 16);
            this.Label8.TabIndex=49;
            this.Label8.Text="نام شیفت:";
            //
            //Label9
            //
            this.Label9.AutoSize=true;
            this.Label9.Location=new System.Drawing.Point(875, 15);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(35, 16);
            this.Label9.TabIndex=44;
            this.Label9.Text="مبدا:";
            //
            //Label10
            //
            this.Label10.AutoSize=true;
            this.Label10.Location=new System.Drawing.Point(605, 15);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(72, 16);
            this.Label10.TabIndex=48;
            this.Label10.Text="نوع شیفت:";
            //
            //ExportButton
            //
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(10, 40);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(107, 34);
            this.ExportButton.TabIndex=34;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            //
            //ShowButton
            //
            this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Cursor=Cursors.Hand;
            this.ShowButton.DialogResult=DialogResult.None;
            this.ShowButton.Location=new System.Drawing.Point(10, 4);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(107, 34);
            this.ShowButton.TabIndex=5;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(352, 12);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(135, 23);
            this.NameBox.TabIndex=33;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(259, 15);
            this.Label3.Margin=new Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(51, 16);
            this.Label3.TabIndex=24;
            this.Label3.Text="از تاریخ:";
            //
            //NameButton
            //
            this.NameButton.DialogResult=DialogResult.None;
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(322, 11);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(259, 48);
            this.Label2.Margin=new Padding(5, 0, 5, 0);
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
            this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight=40;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column5, this.Column13, this.Column4, this.Column14, this.Column3, this.Column6, this.Column7, this.Column8 });
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle3;
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(8, 96);
            this.ShowGridView.Name="ShowGridView";
            this.ShowGridView.ReadOnly=true;
            this.ShowGridView.RowHeadersVisible=false;
            this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size=new System.Drawing.Size(922, 460);
            this.ShowGridView.TabIndex=49;
            //
            //Column1
            //
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            //
            //Column5
            //
            this.Column5.HeaderText="نام";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            //
            //Column13
            //
            this.Column13.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText="نام خانوادگی";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            //
            //Column4
            //
            this.Column4.HeaderText="پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=70;
            //
            //Column14
            //
            this.Column14.HeaderText="تاریخ اعزام";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            //
            //Column3
            //
            this.Column3.HeaderText="ساعت اعزام";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            //
            //Column6
            //
            this.Column6.HeaderText="مبدا";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=105;
            //
            //Column7
            //
            this.Column7.HeaderText="مقصد";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=105;
            //
            //Column8
            //
            this.Column8.HeaderText="نوع اعزام";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=115;
            //
            //TripPersonReportForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Tan;
            this.ClientSize=new System.Drawing.Size(938, 563);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripPersonReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش تریپ های روزانه راهبر";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;
        private ComboBox ShiftCombo;
        private ComboBox PostCombo;
        private ComboBox TimeCombo;
        private ComboBox LocalCombo;
        private Label Label7;
        private Label Label8;
        private Label Label9;
        private Label Label10;
        private Button ExportButton;
        private Button ShowButton;
        private TextBox NameBox;
        private Label Label3;
        private Button NameButton;
        private Label Label2;
        private DataGridView ShowGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Label Label4;
    }

}
