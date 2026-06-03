using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripDailyReportForm : BaseForm
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
            base.Load += new System.EventHandler(TripDailyReportForm_Load);
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            this.EndCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.ExportButton=new Button();
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            this.Panel1=new Panel();
            this.ShowCheck=new CheckBox();
            this.KindCombo=new ComboBox();
            this.Label1=new Label();
            this.ShowButton=new Button();
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.Label3=new Label();
            this.Label2=new Label();
            this.ShowGridView=new DataGridView();
            this.ShowGridView.Sorted += new System.EventHandler(this.ShowGridView_Sorted);
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.SuspendLayout();
            //
            //EndCalendar
            //
            this.EndCalendar.Location=new System.Drawing.Point(744, 16);
            this.EndCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.EndCalendar.Name="EndCalendar";
            this.EndCalendar.NowDateSelected=true;
            this.EndCalendar.ReadOnly=true;
            this.EndCalendar.SelectedDate=null;
            this.EndCalendar.Shamsi=null;
            this.EndCalendar.Size=new System.Drawing.Size(110, 23);
            this.EndCalendar.TabIndex=64;
            this.EndCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(933, 16);
            this.StartCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.StartCalendar.Name="StartCalendar";
            this.StartCalendar.NowDateSelected=true;
            this.StartCalendar.ReadOnly=true;
            this.StartCalendar.SelectedDate=null;
            this.StartCalendar.Shamsi=null;
            this.StartCalendar.Size=new System.Drawing.Size(110, 23);
            this.StartCalendar.TabIndex=63;
            this.StartCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //ExportButton
            //
            this.ExportButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.ExportButton.Image=global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(14, 10);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(145, 35);
            this.ExportButton.TabIndex=5;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.ShowCheck);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location=new System.Drawing.Point(10, 10);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(1110, 55);
            this.Panel1.TabIndex=41;
            this.Panel1.TabStop=true;
            //
            //ShowCheck
            //
            this.ShowCheck.AutoSize=true;
            this.ShowCheck.Location=new System.Drawing.Point(380, 17);
            this.ShowCheck.Name="ShowCheck";
            this.ShowCheck.Size=new System.Drawing.Size(163, 20);
            this.ShowCheck.TabIndex=67;
            this.ShowCheck.Text="نمایش اختصاری اطلاعات";
            this.ShowCheck.UseVisualStyleBackColor=true;
            //
            //KindCombo
            //
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] { "اولیه", "اجرا شده", "نهایی" });
            this.KindCombo.Location=new System.Drawing.Point(571, 15);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(105, 24);
            this.KindCombo.TabIndex=66;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(676, 19);
            this.Label1.Margin=new Padding(5, 0, 5, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(39, 16);
            this.Label1.TabIndex=65;
            this.Label1.Text="لوحه:";
            //
            //ShowButton
            //
            this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Cursor=Cursors.Hand;
            this.ShowButton.Location=new System.Drawing.Point(169, 10);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(145, 35);
            this.ShowButton.TabIndex=4;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(1042, 19);
            this.Label3.Margin=new Padding(5, 0, 5, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(51, 16);
            this.Label3.TabIndex=24;
            this.Label3.Text="از تاریخ:";
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(853, 19);
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
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight=40;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column10, this.Column1, this.Column7, this.Column2, this.Column6, this.Column3, this.Column4, this.Column5, this.Column8, this.Column9, this.Column11 });
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(10, 75);
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
            this.ShowGridView.Size=new System.Drawing.Size(1110, 474);
            this.ShowGridView.TabIndex=42;
            this.ShowGridView.TabStop=false;
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
            this.Column1.Width=70;
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
            //Column3
            //
            this.Column3.HeaderText="حرکت اول";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=105;
            //
            //Column4
            //
            this.Column4.HeaderText="حرکت دوم";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=105;
            //
            //Column5
            //
            this.Column5.HeaderText="حرکت سوم";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=105;
            //
            //Column8
            //
            this.Column8.HeaderText="حرکت چهارم";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=105;
            //
            //Column9
            //
            this.Column9.HeaderText="حرکت پنجم";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=105;
            //
            //Column11
            //
            this.Column11.HeaderText="حرکت ششم";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=105;
            //
            //TripDailyReportForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Tan;
            this.ClientSize=new System.Drawing.Size(1129, 556);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShowGridView);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripDailyReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش عملکرد روزانه راهبران";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.ResumeLayout(false);

        }
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Button ExportButton;
        private Panel Panel1;
        private Button ShowButton;
        private Label Label3;
        private Label Label2;
        private DataGridView ShowGridView;
        private ComboBox KindCombo;
        private Label Label1;
        private CheckBox ShowCheck;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
    }

}
