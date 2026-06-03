using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class MyDailyOperationForm : BaseForm
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
            base.Load += new System.EventHandler(MyDailyOperationForm_Load);
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(MyDailyOperationForm));
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            this.Panel1=new Panel();
            this.ShowButton=new Button();
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.StartCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            this.Label3=new Label();
            this.Label4=new Label();
            this.NameBox=new TextBox();
            this.NameButton=new Button();
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            this.ExportButton=new Button();
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            this.ShowGridView=new DataGridView();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Label1=new Label();
            this.Label2=new Label();
            this.Label5=new Label();
            this.Label6=new Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.SuspendLayout();
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.Moccasin;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Location=new System.Drawing.Point(8, 8);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(970, 95);
            this.Panel1.TabIndex=1;
            //
            //ShowButton
            //
            this.ShowButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.ShowButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Cursor=Cursors.Hand;
            this.ShowButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.ShowButton.Location=new System.Drawing.Point(147, 19);
            this.ShowButton.Name="ShowButton";
            this.ShowButton.Size=new System.Drawing.Size(124, 37);
            this.ShowButton.TabIndex=67;
            this.ShowButton.Text="نمایش";
            this.ShowButton.UseVisualStyleBackColor=false;
            //
            //StartCalendar
            //
            this.StartCalendar.Location=new System.Drawing.Point(562, 26);
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
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label3.ForeColor=System.Drawing.Color.Black;
            this.Label3.Location=new System.Drawing.Point(688, 29);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(39, 16);
            this.Label3.TabIndex=65;
            this.Label3.Text="تاریخ:";
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(927, 29);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(29, 16);
            this.Label4.TabIndex=64;
            this.Label4.Text="نام:";
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.NameBox.Location=new System.Drawing.Point(791, 26);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(135, 23);
            this.NameBox.TabIndex=63;
            //
            //NameButton
            //
            this.NameButton.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.NameButton.Image=global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location=new System.Drawing.Point(762, 25);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=62;
            this.NameButton.UseVisualStyleBackColor=true;
            //
            //ExportButton
            //
            this.ExportButton.BackColor=System.Drawing.Color.SandyBrown;
            this.ExportButton.Image=(System.Drawing.Image)(resources.GetObject("ExportButton.BackgroundImage"));
            this.ExportButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location=new System.Drawing.Point(17, 19);
            this.ExportButton.Margin=new Padding(3, 4, 3, 4);
            this.ExportButton.Name="ExportButton";
            this.ExportButton.Size=new System.Drawing.Size(124, 37);
            this.ExportButton.TabIndex=61;
            this.ExportButton.Text="ذخیره";
            this.ExportButton.UseVisualStyleBackColor=false;
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
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
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column8, this.Column1, this.Column7, this.Column2, this.Column6, this.Column9 });
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(8, 106);
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
            this.ShowGridView.Size=new System.Drawing.Size(970, 438);
            this.ShowGridView.TabIndex=36;
            //
            //Column8
            //
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=45;
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
            this.Column7.HeaderText="نام خانوادگی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=120;
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
            this.Column6.Width=85;
            //
            //Column9
            //
            this.Column9.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText="توضیحات";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            //
            //Label1
            //
            this.Label1.BackColor=System.Drawing.Color.Pink;
            this.Label1.BorderStyle=BorderStyle.FixedSingle;
            this.Label1.Location=new System.Drawing.Point(801, 62);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(161, 25);
            this.Label1.TabIndex=64;
            this.Label1.Text="اضافه کار ثبت شده";
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //label2
            //
            this.Label2.BackColor=System.Drawing.Color.LightGreen;
            this.Label2.BorderStyle=BorderStyle.FixedSingle;
            this.Label2.Location=new System.Drawing.Point(632, 62);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(161, 25);
            this.Label2.TabIndex=64;
            this.Label2.Text="مرخصی روزانه ثبت شده";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label5
            //
            this.Label5.BorderStyle=BorderStyle.FixedSingle;
            this.Label5.Location=new System.Drawing.Point(463, 62);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(161, 25);
            this.Label5.TabIndex=64;
            this.Label5.Text="مرخصی ساعتی ثبت شده";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label6
            //
            this.Label6.BackColor=System.Drawing.Color.White;
            this.Label6.BorderStyle=BorderStyle.FixedSingle;
            this.Label6.Location=new System.Drawing.Point(294, 62);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(161, 25);
            this.Label6.TabIndex=64;
            this.Label6.Text="عملکرد ثبت شده";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //MyDailyOperationForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Tan;
            this.ClientSize=new System.Drawing.Size(987, 554);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="MyDailyOperationForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="عملکرد روزانه من";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel1;
        private Button ExportButton;
        private Label Label4;
        private TextBox NameBox;
        private Button NameButton;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Label Label3;
        private DataGridView ShowGridView;
        private Button ShowButton;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column9;
        private Label Label1;
        private Label Label6;
        private Label Label5;
        private Label Label2;
    }

}
