using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class NavganHistorForm : BaseForm
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
            DataGridViewCellStyle DataGridViewCellStyle33=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle34=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle47=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle48=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle35=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle36=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle37=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle38=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle39=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle40=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle41=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle42=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle43=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle44=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle45=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle46=new DataGridViewCellStyle();
            this.Panel3=new Panel();
            this.NumBox=new MaskedTextBox();
            this.SearchButton=new Button();
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.Label1=new Label();
            this.Label2=new Label();
            this.KindCombo=new ComboBox();
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            this.ShowGridView=new DataGridView();
            this.ShowGridView.CellClick += new DataGridViewCellEventHandler(this.ShowGridView_CellClick);
            this.ShowGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.ShowGridView_ColumnHeaderMouseClick);
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column12=new DataGridViewTextBoxColumn();
            this.Column13=new DataGridViewTextBoxColumn();
            this.Column14=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Label5=new Label();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.SuspendLayout();
            //
            //Panel3
            //
            this.Panel3.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(234)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.NumBox);
            this.Panel3.Controls.Add(this.SearchButton);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.KindCombo);
            this.Panel3.Location=new System.Drawing.Point(73, 11);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(765, 60);
            this.Panel3.TabIndex=1;
            //
            //NumBox
            //
            this.NumBox.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.NumBox.Location=new System.Drawing.Point(320, 13);
            this.NumBox.Mask=">A00";
            this.NumBox.Name="NumBox";
            this.NumBox.Size=new System.Drawing.Size(57, 33);
            this.NumBox.TabIndex=57;
            this.NumBox.TextAlign=HorizontalAlignment.Center;
            //
            //SearchButton
            //
            this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Cursor=Cursors.Hand;

            this.SearchButton.Location=new System.Drawing.Point(83, 12);
            this.SearchButton.Margin=new Padding(4, 5, 4, 5);
            this.SearchButton.Name="SearchButton";
            this.SearchButton.Size=new System.Drawing.Size(175, 35);
            this.SearchButton.TabIndex=2;
            this.SearchButton.Text="جستجو";
            this.SearchButton.UseVisualStyleBackColor=false;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(578, 21);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(109, 16);
            this.Label1.TabIndex=56;
            this.Label1.Text="جستجو بر اساس:";
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(379, 21);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(49, 16);
            this.Label2.TabIndex=55;
            this.Label2.Text="شماره:";
            //
            //KindCombo
            //
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] { "لکوموتیو", "واگن" });
            this.KindCombo.Location=new System.Drawing.Point(463, 16);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(114, 27);
            this.KindCombo.TabIndex=0;
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle33.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle33;
            DataGridViewCellStyle34.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle34.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle34.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle34.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle34.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle34.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle34.WrapMode=DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle34;
            this.ShowGridView.ColumnHeadersHeight=45;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column8, this.Column6, this.Column3, this.Column10, this.Column5, this.Column9, this.Column11, this.Column7, this.Column12, this.Column13, this.Column14, this.Column1, this.Column2, this.Column4 });
            DataGridViewCellStyle47.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle47.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle47.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle47.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle47.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle47.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle47.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle47;
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(10, 79);
            this.ShowGridView.MultiSelect=false;
            this.ShowGridView.Name="ShowGridView";
            this.ShowGridView.ReadOnly=true;
            this.ShowGridView.RowHeadersVisible=false;
            this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewCellStyle48.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowsDefaultCellStyle=DataGridViewCellStyle48;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.ShowGridView.RowTemplate.ReadOnly=true;
            this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size=new System.Drawing.Size(890, 377);
            this.ShowGridView.TabIndex=37;
            //
            //Column8
            //
            DataGridViewCellStyle35.BackColor=System.Drawing.SystemColors.Control;
            this.Column8.DefaultCellStyle=DataGridViewCellStyle35;
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=45;
            //
            //Column6
            //
            DataGridViewCellStyle36.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Column6.DefaultCellStyle=DataGridViewCellStyle36;
            this.Column6.HeaderText="لکوموتیو تهران";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=60;
            //
            //Column3
            //
            DataGridViewCellStyle37.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle=DataGridViewCellStyle37;
            this.Column3.HeaderText="واگن 1";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=50;
            //
            //Column10
            //
            DataGridViewCellStyle38.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column10.DefaultCellStyle=DataGridViewCellStyle38;
            this.Column10.HeaderText="واگن 2";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=50;
            //
            //Column5
            //
            DataGridViewCellStyle39.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle=DataGridViewCellStyle39;
            this.Column5.HeaderText="واگن 3";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=50;
            //
            //Column9
            //
            DataGridViewCellStyle40.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle=DataGridViewCellStyle40;
            this.Column9.HeaderText="واگن 4";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=50;
            //
            //Column11
            //
            DataGridViewCellStyle41.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column11.DefaultCellStyle=DataGridViewCellStyle41;
            this.Column11.HeaderText="واگن 5";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=50;
            //
            //Column7
            //
            DataGridViewCellStyle42.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle=DataGridViewCellStyle42;
            this.Column7.HeaderText="واگن 6";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=50;
            //
            //Column12
            //
            DataGridViewCellStyle43.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column12.DefaultCellStyle=DataGridViewCellStyle43;
            this.Column12.HeaderText="واگن 7";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Width=50;
            //
            //Column13
            //
            DataGridViewCellStyle44.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column13.DefaultCellStyle=DataGridViewCellStyle44;
            this.Column13.HeaderText="واگن 8";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            this.Column13.Width=50;
            //
            //Column14
            //
            DataGridViewCellStyle45.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column14.DefaultCellStyle=DataGridViewCellStyle45;
            this.Column14.HeaderText="واگن 9";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Width=50;
            //
            //Column1
            //
            DataGridViewCellStyle46.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Column1.DefaultCellStyle=DataGridViewCellStyle46;
            this.Column1.HeaderText="لکوموتیو مهرشهر";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=60;
            //
            //Column2
            //
            this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText="کاربر";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            //
            //Column4
            //
            this.Column4.HeaderText="تاریخ ثبت";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=130;
            //
            //Label5
            //
            this.Label5.BackColor=System.Drawing.Color.Black;
            this.Label5.ForeColor=System.Drawing.Color.White;
            this.Label5.Location=new System.Drawing.Point(246, 464);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(419, 24);
            this.Label5.TabIndex=43;
            this.Label5.Text="*       سطر زرد رنگ ، آرایش ناوگان فعال است       *";
            this.Label5.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //NavganHistorForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(908, 499);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel3);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="NavganHistorForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="تاریخچه ناوگان";
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.ResumeLayout(false);

        }

        private Panel Panel3;
        private Button SearchButton;
        private Label Label1;
        private Label Label2;
        private ComboBox KindCombo;
        private DataGridView ShowGridView;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private MaskedTextBox NumBox;
        private Label Label5;
    }

}
