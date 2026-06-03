using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripSpecialReportForm : BaseForm
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
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(TripDetailReportForm_HelpButtonClicked);
            base.Load += new System.EventHandler(TripDetailReportForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
            this.Panel1=new Panel();
            this.ExportButton=new Button();
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            this.ShowButton=new Button();
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.Label4=new Label();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            this.ShiftCombo=new ComboBox();
            this.ShiftCombo.SelectedIndexChanged += new System.EventHandler(this.ShiftCombo_SelectedIndexChanged);
            this.PostCombo=new ComboBox();
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            this.TimeCombo=new ComboBox();
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            this.LocalCombo=new ComboBox();
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.Label7=new Label();
            this.Label8=new Label();
            this.Label9=new Label();
            this.Label10=new Label();
            this.NameBox=new TextBox();
            this.Label3=new Label();
            this.NameButton=new Button();
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            this.Label2=new Label();
            this.ShowGridView=new DataGridView();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column12=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.SuspendLayout();
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
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
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location=new System.Drawing.Point(10, 10);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(938, 80);
            this.Panel1.TabIndex=40;
            //
            //ExportButton
            //
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(4, 40);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(122, 34);
            this.ExportButton.TabIndex=70;
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
            this.ShowButton.Location=new System.Drawing.Point(4, 4);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(122, 34);
            this.ShowButton.TabIndex=69;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(496, 13);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(29, 16);
            this.Label4.TabIndex=68;
            this.Label4.Text="نام:";
            //
            //EndCalendar
            //
            this.EndCalendar.Location=new System.Drawing.Point(144, 46);
            this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex=67;
            this.EndCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(144, 10);
            this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex=66;
            this.StartCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //ShiftCombo
            //
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Location=new System.Drawing.Point(530, 45);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(90, 24);
            this.ShiftCombo.TabIndex=63;
            //
            //PostCombo
            //
            this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.PostCombo.FormattingEnabled=true;
            this.PostCombo.Location=new System.Drawing.Point(697, 45);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(192, 24);
            this.PostCombo.TabIndex=59;
            //
            //TimeCombo
            //
            this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Location=new System.Drawing.Point(530, 9);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(90, 24);
            this.TimeCombo.TabIndex=62;
            //
            //LocalCombo
            //
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(697, 9);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(192, 24);
            this.LocalCombo.TabIndex=61;
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(888, 49);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(43, 16);
            this.Label7.TabIndex=58;
            this.Label7.Text="پست:";
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(619, 49);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(70, 16);
            this.Label8.TabIndex=65;
            this.Label8.Text="نام شیفت:";
            //
            //Label9
            //
            this.Label9.AutoSize=true;
            this.Label9.Location=new System.Drawing.Point(888, 13);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(35, 16);
            this.Label9.TabIndex=60;
            this.Label9.Text="مبدا:";
            //
            //Label10
            //
            this.Label10.AutoSize=true;
            this.Label10.Location=new System.Drawing.Point(619, 13);
            this.Label10.Name="Label10";
            this.Label10.Size=new System.Drawing.Size(72, 16);
            this.Label10.TabIndex=64;
            this.Label10.Text="نوع شیفت:";
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(361, 10);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(135, 23);
            this.NameBox.TabIndex=33;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(272, 13);
            this.Label3.Margin=new Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(51, 16);
            this.Label3.TabIndex=24;
            this.Label3.Text="از تاریخ:";
            //
            //NameButton
            //
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(332, 9);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(272, 49);
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
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor=System.Drawing.Color.Moccasin;
            this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle3;
            this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            DataGridViewCellStyle4.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle4;
            this.ShowGridView.ColumnHeadersHeight=40;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column10, this.Column1, this.Column7, this.Column2, this.Column6, this.Column12, this.Column3, this.Column4 });
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(10, 99);
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
            this.ShowGridView.Size=new System.Drawing.Size(938, 404);
            this.ShowGridView.TabIndex=41;
            //
            //Column10
            //
            this.Column10.HeaderText="ردیف";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=45;
            //
            //Column1
            //
            this.Column1.HeaderText="نام";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            //
            //Column7
            //
            this.Column7.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText="نام خانوادگی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            //
            //Column2
            //
            this.Column2.HeaderText="ش پرسنلی";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=80;
            //
            //Column6
            //
            this.Column6.HeaderText="تاریخ";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=80;
            //
            //Column12
            //
            this.Column12.HeaderText="عنوان";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            //
            //Column3
            //
            this.Column3.HeaderText="کاربر";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=140;
            //
            //Column4
            //
            this.Column4.HeaderText="تاریخ ثبت";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=130;
            //
            //TripSpecialReportForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Tan;
            this.ClientSize=new System.Drawing.Size(956, 511);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShowGridView);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripSpecialReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش جزئیات تریپ راهبران";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.ResumeLayout(false);

        }
        private Panel Panel1;
        private TextBox NameBox;
        private Label Label3;
        private Button NameButton;
        private Label Label2;
        private DataGridView ShowGridView;
        private ComboBox ShiftCombo;
        private ComboBox PostCombo;
        private ComboBox TimeCombo;
        private ComboBox LocalCombo;
        private Label Label7;
        private Label Label8;
        private Label Label9;
        private Label Label10;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Label Label4;
        private Button ExportButton;
        private Button ShowButton;
    }

}
