using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripInShiftReportForm : BaseForm
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
            base.Load += new System.EventHandler(TripInShiftReportForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            this.ShowGridView=new DataGridView();
            this.Column12=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Panel1=new Panel();
            this.PostCombo=new ComboBox();
            this.PostCombo.SelectedIndexChanged += new System.EventHandler(this.PostCombo_SelectedIndexChanged);
            this.Label7=new Label();
            this.Label8=new Label();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.KindCombo=new ComboBox();
            this.TimeCombo=new ComboBox();
            this.TimeCombo.SelectedIndexChanged += new System.EventHandler(this.TimeCombo_SelectedIndexChanged);
            this.Label2=new Label();
            this.ShiftCombo=new ComboBox();
            this.LocalCombo=new ComboBox();
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            this.Label13=new Label();
            this.Label15=new Label();
            this.ExportButton=new Button();
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            this.ShowButton=new Button();
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.Label5=new Label();
            this.Label6=new Label();
            this.Label3=new Label();
            this.Label4=new Label();
            this.Label1=new Label();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.ForeColor=System.Drawing.Color.Black;
            DataGridViewCellStyle1.SelectionBackColor=System.Drawing.Color.Empty;
            DataGridViewCellStyle1.SelectionForeColor=System.Drawing.Color.Blue;
            this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            this.ShowGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight=40;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column12, this.Column1, this.Column3, this.Column11, this.Column10, this.Column7, this.Column2, this.Column4, this.Column5 });
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor=System.Drawing.Color.Transparent;
            DataGridViewCellStyle3.SelectionForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle3;
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(12, 110);
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
            this.ShowGridView.Size=new System.Drawing.Size(1025, 482);
            this.ShowGridView.TabIndex=51;
            //
            //Column12
            //
            this.Column12.HeaderText="ردیف";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Width=40;
            //
            //Column1
            //
            this.Column1.HeaderText="نام";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=70;
            //
            //Column3
            //
            this.Column3.HeaderText="نام خانوادگی";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=115;
            //
            //Column11
            //
            this.Column11.HeaderText="شماره پرسنلی";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=70;
            //
            //Column10
            //
            this.Column10.HeaderText="مبدا";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=70;
            //
            //Column7
            //
            this.Column7.HeaderText="نوع شیفت";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=70;
            //
            //Column2
            //
            this.Column2.HeaderText="نام شیفت";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=50;
            //
            //Column4
            //
            this.Column4.HeaderText="تعداد تریپ";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=50;
            //
            //Column5
            //
            this.Column5.HeaderText="تعداد خطا";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=50;
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PostCombo);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.TimeCombo);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.ShiftCombo);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location=new System.Drawing.Point(12, 16);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(1025, 81);
            this.Panel1.TabIndex=50;
            //
            //PostCombo
            //
            this.PostCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.PostCombo.FormattingEnabled=true;
            this.PostCombo.Location=new System.Drawing.Point(832, 44);
            this.PostCombo.Margin=new Padding(3, 4, 3, 4);
            this.PostCombo.Name="PostCombo";
            this.PostCombo.Size=new System.Drawing.Size(147, 24);
            this.PostCombo.TabIndex=60;
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(979, 48);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(43, 16);
            this.Label7.TabIndex=61;
            this.Label7.Text="پست:";
            //
            //Label8
            //
            this.Label8.BackColor=System.Drawing.Color.Orange;
            this.Label8.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label8.ForeColor=System.Drawing.Color.Black;
            this.Label8.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label8.Location=new System.Drawing.Point(234, 9);
            this.Label8.Margin=new Padding(5, 0, 5, 0);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(100, 26);
            this.Label8.TabIndex=50;
            this.Label8.Text="مرخصی روزانه";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //EndCalendar
            //
            this.EndCalendar.Location=new System.Drawing.Point(487, 45);
            this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(108, 23);
            this.EndCalendar.TabIndex=59;
            this.EndCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(487, 11);
            this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(108, 23);
            this.StartCalendar.TabIndex=58;
            this.StartCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //KindCombo
            //
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] { "اولیه", "اجرا شده", "نهایی" });
            this.KindCombo.Location=new System.Drawing.Point(357, 26);
            this.KindCombo.Margin=new Padding(3, 4, 3, 4);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(101, 24);
            this.KindCombo.TabIndex=56;
            //
            //TimeCombo
            //
            this.TimeCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.TimeCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.TimeCombo.FormattingEnabled=true;
            this.TimeCombo.Location=new System.Drawing.Point(657, 10);
            this.TimeCombo.Margin=new Padding(3, 4, 3, 4);
            this.TimeCombo.Name="TimeCombo";
            this.TimeCombo.Size=new System.Drawing.Size(101, 24);
            this.TimeCombo.TabIndex=56;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.BackColor=System.Drawing.Color.Transparent;
            this.Label2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label2.ForeColor=System.Drawing.Color.Black;
            this.Label2.Location=new System.Drawing.Point(758, 14);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(72, 16);
            this.Label2.TabIndex=57;
            this.Label2.Text="نوع شیفت:";
            //
            //ShiftCombo
            //
            this.ShiftCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ShiftCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShiftCombo.FormattingEnabled=true;
            this.ShiftCombo.Location=new System.Drawing.Point(657, 44);
            this.ShiftCombo.Margin=new Padding(3, 4, 3, 4);
            this.ShiftCombo.Name="ShiftCombo";
            this.ShiftCombo.Size=new System.Drawing.Size(101, 24);
            this.ShiftCombo.TabIndex=53;
            //
            //LocalCombo
            //
            this.LocalCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.LocalCombo.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.LocalCombo.FormattingEnabled=true;
            this.LocalCombo.Location=new System.Drawing.Point(832, 10);
            this.LocalCombo.Margin=new Padding(3, 4, 3, 4);
            this.LocalCombo.Name="LocalCombo";
            this.LocalCombo.Size=new System.Drawing.Size(147, 24);
            this.LocalCombo.TabIndex=52;
            //
            //Label13
            //
            this.Label13.AutoSize=true;
            this.Label13.BackColor=System.Drawing.Color.Transparent;
            this.Label13.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label13.ForeColor=System.Drawing.Color.Black;
            this.Label13.Location=new System.Drawing.Point(758, 48);
            this.Label13.Name="Label13";
            this.Label13.Size=new System.Drawing.Size(70, 16);
            this.Label13.TabIndex=54;
            this.Label13.Text="نام شیفت:";
            //
            //Label15
            //
            this.Label15.AutoSize=true;
            this.Label15.BackColor=System.Drawing.Color.Transparent;
            this.Label15.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label15.ForeColor=System.Drawing.Color.Black;
            this.Label15.Location=new System.Drawing.Point(979, 14);
            this.Label15.Name="Label15";
            this.Label15.Size=new System.Drawing.Size(35, 16);
            this.Label15.TabIndex=55;
            this.Label15.Text="مبدا:";
            //
            //ExportButton
            //
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ExportButton.Location=new System.Drawing.Point(16, 39);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(121, 34);
            this.ExportButton.TabIndex=4;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            //
            //ShowButton
            //
            this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Cursor=Cursors.Hand;
            this.ShowButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShowButton.Location=new System.Drawing.Point(16, 5);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(121, 34);
            this.ShowButton.TabIndex=3;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            //
            //Label5
            //
            this.Label5.BackColor=System.Drawing.Color.Tomato;
            this.Label5.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label5.ForeColor=System.Drawing.Color.Black;
            this.Label5.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label5.Location=new System.Drawing.Point(144, 43);
            this.Label5.Margin=new Padding(5, 0, 5, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(75, 26);
            this.Label5.TabIndex=50;
            this.Label5.Text="خطای تریپ";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label6
            //
            this.Label6.BackColor=System.Drawing.Color.Tan;
            this.Label6.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label6.ForeColor=System.Drawing.Color.Black;
            this.Label6.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label6.Location=new System.Drawing.Point(234, 43);
            this.Label6.Margin=new Padding(5, 0, 5, 0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(100, 26);
            this.Label6.TabIndex=50;
            this.Label6.Text="مرخصی ساعتی";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label3
            //
            this.Label3.BackColor=System.Drawing.Color.Yellow;
            this.Label3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label3.ForeColor=System.Drawing.Color.Black;
            this.Label3.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label3.Location=new System.Drawing.Point(144, 9);
            this.Label3.Margin=new Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(75, 26);
            this.Label3.TabIndex=50;
            this.Label3.Text="تریپ رزرو";
            this.Label3.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label4.ForeColor=System.Drawing.Color.Black;
            this.Label4.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label4.Location=new System.Drawing.Point(595, 14);
            this.Label4.Margin=new Padding(5, 0, 5, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(55, 16);
            this.Label4.TabIndex=50;
            this.Label4.Text="از تاریخ :";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.Transparent;
            this.Label1.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.ImageAlign=System.Drawing.ContentAlignment.BottomCenter;
            this.Label1.Location=new System.Drawing.Point(595, 48);
            this.Label1.Margin=new Padding(5, 0, 5, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(55, 16);
            this.Label1.TabIndex=51;
            this.Label1.Text="تا تاریخ :";
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //TripInShiftReportForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize=new System.Drawing.Size(1049, 606);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripInShiftReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="تعداد تریپ در شیفت";
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataGridView ShowGridView;
        private Panel Panel1;
        private ComboBox PostCombo;
        private Label Label7;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private ComboBox TimeCombo;
        private Label Label2;
        private ComboBox ShiftCombo;
        private ComboBox LocalCombo;
        private Label Label13;
        private Label Label15;
        private Button ExportButton;
        private Button ShowButton;
        private Label Label4;
        private Label Label1;
        private Label Label8;
        private Label Label5;
        private Label Label6;
        private Label Label3;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox KindCombo;
    }

}
