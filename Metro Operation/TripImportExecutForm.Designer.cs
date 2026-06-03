using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripImportExecutForm : BaseForm
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
            DataGridViewCellStyle DataGridViewCellStyle1=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle2=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            this.SelectButton=new Button();
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            this.Label3=new Label();
            this.DateLabel=new Label();
            this.NameBox=new TextBox();
            this.ImportButton=new Button();
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            this.Label1=new Label();
            this.ExitButton=new Button();
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.TripGridView=new DataGridView();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column14=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column13=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)this.TripGridView).BeginInit();
            this.SuspendLayout();
            //
            //SelectButton
            //
            this.SelectButton.Image=global::Metro_Operation.Properties.Resources.docs_24;
            this.SelectButton.BackgroundImageLayout=ImageLayout.Stretch;
            this.SelectButton.Location=new System.Drawing.Point(639, 18);
            this.SelectButton.Name="SelectButton";
            this.SelectButton.Size=new System.Drawing.Size(25, 25);
            this.SelectButton.TabIndex=74;
            this.SelectButton.UseVisualStyleBackColor=true;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(424, 23);
            this.Label3.Margin=new Padding(3);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(33, 14);
            this.Label3.TabIndex=72;
            this.Label3.Text="تاریخ:";
            //
            //DateLabel
            //
            this.DateLabel.Location=new System.Drawing.Point(344, 21);
            this.DateLabel.Margin=new Padding(3);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(80, 18);
            this.DateLabel.TabIndex=73;
            this.DateLabel.Text="0000/00/00";
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DateLabel.Visible=false;
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Control;
            this.NameBox.Location=new System.Drawing.Point(664, 19);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(179, 22);
            this.NameBox.TabIndex=67;
            this.NameBox.TabStop=false;
            this.NameBox.TextAlign=HorizontalAlignment.Right;
            //
            //ImportButton
            //
            this.ImportButton.Location=new System.Drawing.Point(509, 18);
            this.ImportButton.Name="ImportButton";
            this.ImportButton.Size=new System.Drawing.Size(98, 25);
            this.ImportButton.TabIndex=68;
            this.ImportButton.Text="تحلیل فایل";
            this.ImportButton.UseVisualStyleBackColor=true;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(843, 23);
            this.Label1.Margin=new Padding(3);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(50, 14);
            this.Label1.TabIndex=69;
            this.Label1.Text="نام فایل:";
            //
            //ExitButton
            //
            this.ExitButton.BackColor=System.Drawing.Color.LightBlue;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.None;
            this.ExitButton.Location=new System.Drawing.Point(13, 13);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(135, 34);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;

            this.RegButton.Location=new System.Drawing.Point(157, 13);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(135, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //TripGridView
            //
            this.TripGridView.AllowUserToAddRows=false;
            this.TripGridView.AllowUserToDeleteRows=false;
            this.TripGridView.AllowUserToResizeColumns=false;
            this.TripGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor=System.Drawing.Color.Moccasin;
            this.TripGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            this.TripGridView.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
            this.TripGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.TripGridView.ColumnHeadersHeight=40;
            this.TripGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TripGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column14, this.Column3, this.Column6, this.Column7, this.Column5, this.Column4, this.Column8, this.Column9, this.Column13, this.Column2 });
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
            this.TripGridView.DefaultCellStyle=DataGridViewCellStyle3;
            this.TripGridView.EnableHeadersVisualStyles=false;
            this.TripGridView.Location=new System.Drawing.Point(5, 62);
            this.TripGridView.Margin=new Padding(3, 4, 3, 4);
            this.TripGridView.Name="TripGridView";
            this.TripGridView.ReadOnly=true;
            this.TripGridView.RowHeadersVisible=false;
            this.TripGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TripGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.TripGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.TripGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.TripGridView.Size=new System.Drawing.Size(907, 482);
            this.TripGridView.TabIndex=131;
            //
            //Column1
            //
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            //
            //Column14
            //
            this.Column14.HeaderText="تاریخ ";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Width=80;
            //
            //Column3
            //
            this.Column3.HeaderText="ساعت ";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=60;
            //
            //Column6
            //
            this.Column6.HeaderText="مبدا";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=70;
            //
            //Column7
            //
            this.Column7.HeaderText="مقصد";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=70;
            //
            //Column5
            //
            this.Column5.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText="راهبر اصلی";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            //
            //Column4
            //
            this.Column4.HeaderText="پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=60;
            //
            //Column8
            //
            this.Column8.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText="راهبر آموزشی";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            //
            //Column9
            //
            this.Column9.HeaderText="پرسنلی";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=60;
            //
            //Column13
            //
            this.Column13.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText="راهبر کمکی";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            //
            //Column2
            //
            this.Column2.HeaderText="پرسنلی";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=60;
            //
            //TripImportExecutForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(14.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Tan;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(917, 548);
            this.Controls.Add(this.TripGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.Label1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripImportExecutForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ثبت لوحه راهبری: اجرا شده";
            ((System.ComponentModel.ISupportInitialize)this.TripGridView).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button SelectButton;
        private Label Label3;
        private Label DateLabel;
        private TextBox NameBox;
        private Button ImportButton;
        private Label Label1;
        private Button ExitButton;
        private Button RegButton;
        private DataGridView TripGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column2;
    }

}
