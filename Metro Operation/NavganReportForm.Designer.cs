using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class NavganReportForm : BaseForm
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
            DataGridViewCellStyle DataGridViewCellStyle17=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle18=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle31=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle32=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle19=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle20=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle21=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle22=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle23=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle24=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle25=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle26=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle27=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle28=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle29=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle30=new DataGridViewCellStyle();
            this.ShowGridView=new DataGridView();
            base.Load += new System.EventHandler(NavganReportForm_Load);
            this.ShowGridView.CellClick += new DataGridViewCellEventHandler(this.DataGridView1_CellClick);
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
            this.PictureBox1=new PictureBox();
            this.Loco2Label=new Label();
            this.Loco1Label=new Label();
            this.Wag1Label=new Label();
            this.Wag2Label=new Label();
            this.Wag3Label=new Label();
            this.Wag4Label=new Label();
            this.Wag5Label=new Label();
            this.Wag6Label=new Label();
            this.Wag7Label=new Label();
            this.Wag9Label=new Label();
            this.Wag8Label=new Label();
            this.Label1=new Label();
            this.KindCombo=new ComboBox();
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            this.Label2=new Label();
            this.SearchButton=new Button();
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.Panel1=new Panel();
            this.Panel2=new Panel();
            this.UserLabel=new Label();
            this.DateLabel=new Label();
            this.Button1=new Button();
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.NumBox=new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle17.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle17;
            DataGridViewCellStyle18.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle18.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle18.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle18.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle18.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle18.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle18.WrapMode=DataGridViewTriState.True;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle18;
            this.ShowGridView.ColumnHeadersHeight=45;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column8, this.Column6, this.Column3, this.Column10, this.Column5, this.Column9, this.Column11, this.Column7, this.Column12, this.Column13, this.Column14, this.Column1, this.Column2, this.Column4 });
            DataGridViewCellStyle31.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle31.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle31.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle31.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle31.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle31.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle31.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle31;
            this.ShowGridView.EnableHeadersVisualStyles=false;
            this.ShowGridView.Location=new System.Drawing.Point(11, 12);
            this.ShowGridView.MultiSelect=false;
            this.ShowGridView.Name="ShowGridView";
            this.ShowGridView.ReadOnly=true;
            this.ShowGridView.RowHeadersVisible=false;
            this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewCellStyle32.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowsDefaultCellStyle=DataGridViewCellStyle32;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.ShowGridView.RowTemplate.ReadOnly=true;
            this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size=new System.Drawing.Size(856, 377);
            this.ShowGridView.TabIndex=36;
            //
            //Column8
            //
            DataGridViewCellStyle19.BackColor=System.Drawing.SystemColors.Control;
            this.Column8.DefaultCellStyle=DataGridViewCellStyle19;
            this.Column8.HeaderText="ردیف";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=45;
            //
            //Column6
            //
            this.Column6.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle20.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Column6.DefaultCellStyle=DataGridViewCellStyle20;
            this.Column6.HeaderText="لکوموتیو تهران";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            //
            //Column3
            //
            DataGridViewCellStyle21.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle=DataGridViewCellStyle21;
            this.Column3.HeaderText="واگن 1";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=70;
            //
            //Column10
            //
            DataGridViewCellStyle22.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column10.DefaultCellStyle=DataGridViewCellStyle22;
            this.Column10.HeaderText="واگن 2";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=70;
            //
            //Column5
            //
            DataGridViewCellStyle23.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle=DataGridViewCellStyle23;
            this.Column5.HeaderText="واگن 3";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=70;
            //
            //Column9
            //
            DataGridViewCellStyle24.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column9.DefaultCellStyle=DataGridViewCellStyle24;
            this.Column9.HeaderText="واگن 4";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=70;
            //
            //Column11
            //
            DataGridViewCellStyle25.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column11.DefaultCellStyle=DataGridViewCellStyle25;
            this.Column11.HeaderText="واگن 5";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=70;
            //
            //Column7
            //
            DataGridViewCellStyle26.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle=DataGridViewCellStyle26;
            this.Column7.HeaderText="واگن 6";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=70;
            //
            //Column12
            //
            DataGridViewCellStyle27.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column12.DefaultCellStyle=DataGridViewCellStyle27;
            this.Column12.HeaderText="واگن 7";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Width=70;
            //
            //Column13
            //
            DataGridViewCellStyle28.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column13.DefaultCellStyle=DataGridViewCellStyle28;
            this.Column13.HeaderText="واگن 8";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            this.Column13.Width=70;
            //
            //Column14
            //
            DataGridViewCellStyle29.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column14.DefaultCellStyle=DataGridViewCellStyle29;
            this.Column14.HeaderText="واگن 9";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Width=70;
            //
            //Column1
            //
            this.Column1.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle30.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Column1.DefaultCellStyle=DataGridViewCellStyle30;
            this.Column1.HeaderText="لکوموتیو مهرشهر";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            //
            //Column2
            //
            this.Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText="کاربر";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Visible=false;
            //
            //Column4
            //
            this.Column4.HeaderText="تاریخ ثبت";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Visible=false;
            this.Column4.Width=130;
            //
            //PictureBox1
            //
            this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.Train;
            this.PictureBox1.Location=new System.Drawing.Point(94, 467);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(771, 94);
            this.PictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex=48;
            this.PictureBox1.TabStop=false;
            //
            //Loco2Label
            //
            this.Loco2Label.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(102)));
            this.Loco2Label.Font=new System.Drawing.Font("Tahoma", 18.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Loco2Label.Location=new System.Drawing.Point(137, 516);
            this.Loco2Label.Name="Loco2Label";
            this.Loco2Label.Size=new System.Drawing.Size(51, 30);
            this.Loco2Label.TabIndex=49;
            this.Loco2Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Loco1Label
            //
            this.Loco1Label.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(102)));
            this.Loco1Label.Font=new System.Drawing.Font("Tahoma", 18.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Loco1Label.Location=new System.Drawing.Point(773, 516);
            this.Loco1Label.Name="Loco1Label";
            this.Loco1Label.Size=new System.Drawing.Size(51, 30);
            this.Loco1Label.TabIndex=49;
            this.Loco1Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag1Label
            //
            this.Wag1Label.BackColor=System.Drawing.Color.White;
            this.Wag1Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag1Label.Location=new System.Drawing.Point(709, 516);
            this.Wag1Label.Name="Wag1Label";
            this.Wag1Label.Size=new System.Drawing.Size(51, 30);
            this.Wag1Label.TabIndex=49;
            this.Wag1Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag2Label
            //
            this.Wag2Label.BackColor=System.Drawing.Color.White;
            this.Wag2Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag2Label.Location=new System.Drawing.Point(645, 516);
            this.Wag2Label.Name="Wag2Label";
            this.Wag2Label.Size=new System.Drawing.Size(51, 30);
            this.Wag2Label.TabIndex=49;
            this.Wag2Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag3Label
            //
            this.Wag3Label.BackColor=System.Drawing.Color.White;
            this.Wag3Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag3Label.Location=new System.Drawing.Point(582, 516);
            this.Wag3Label.Name="Wag3Label";
            this.Wag3Label.Size=new System.Drawing.Size(51, 30);
            this.Wag3Label.TabIndex=49;
            this.Wag3Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag4Label
            //
            this.Wag4Label.BackColor=System.Drawing.Color.White;
            this.Wag4Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag4Label.Location=new System.Drawing.Point(518, 516);
            this.Wag4Label.Name="Wag4Label";
            this.Wag4Label.Size=new System.Drawing.Size(51, 30);
            this.Wag4Label.TabIndex=49;
            this.Wag4Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag5Label
            //
            this.Wag5Label.BackColor=System.Drawing.Color.White;
            this.Wag5Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag5Label.Location=new System.Drawing.Point(455, 516);
            this.Wag5Label.Name="Wag5Label";
            this.Wag5Label.Size=new System.Drawing.Size(51, 30);
            this.Wag5Label.TabIndex=49;
            this.Wag5Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag6Label
            //
            this.Wag6Label.BackColor=System.Drawing.Color.White;
            this.Wag6Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag6Label.Location=new System.Drawing.Point(391, 516);
            this.Wag6Label.Name="Wag6Label";
            this.Wag6Label.Size=new System.Drawing.Size(51, 30);
            this.Wag6Label.TabIndex=49;
            this.Wag6Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag7Label
            //
            this.Wag7Label.BackColor=System.Drawing.Color.White;
            this.Wag7Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag7Label.Location=new System.Drawing.Point(328, 516);
            this.Wag7Label.Name="Wag7Label";
            this.Wag7Label.Size=new System.Drawing.Size(51, 30);
            this.Wag7Label.TabIndex=49;
            this.Wag7Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag9Label
            //
            this.Wag9Label.BackColor=System.Drawing.Color.White;
            this.Wag9Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag9Label.Location=new System.Drawing.Point(201, 516);
            this.Wag9Label.Name="Wag9Label";
            this.Wag9Label.Size=new System.Drawing.Size(51, 30);
            this.Wag9Label.TabIndex=49;
            this.Wag9Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Wag8Label
            //
            this.Wag8Label.BackColor=System.Drawing.Color.White;
            this.Wag8Label.Font=new System.Drawing.Font("Tahoma", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag8Label.Location=new System.Drawing.Point(264, 516);
            this.Wag8Label.Name="Wag8Label";
            this.Wag8Label.Size=new System.Drawing.Size(51, 30);
            this.Wag8Label.TabIndex=49;
            this.Wag8Label.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(414, 20);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(109, 16);
            this.Label1.TabIndex=50;
            this.Label1.Text="جستجو بر اساس:";
            //
            //KindCombo
            //
            this.KindCombo.BackColor=System.Drawing.Color.White;
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] { "لکوموتیو", "واگن" });
            this.KindCombo.Location=new System.Drawing.Point(300, 15);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(114, 27);
            this.KindCombo.TabIndex=51;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(230, 20);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(49, 16);
            this.Label2.TabIndex=50;
            this.Label2.Text="شماره:";
            //
            //SearchButton
            //
            this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Cursor=Cursors.Hand;

            this.SearchButton.Location=new System.Drawing.Point(19, 11);
            this.SearchButton.Margin=new Padding(4, 5, 4, 5);
            this.SearchButton.Name="SearchButton";
            this.SearchButton.Size=new System.Drawing.Size(114, 35);
            this.SearchButton.TabIndex=53;
            this.SearchButton.Text="جستجو  ";
            this.SearchButton.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor=false;
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.Silver;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NumBox);
            this.Panel1.Controls.Add(this.SearchButton);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location=new System.Drawing.Point(328, 402);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(539, 57);
            this.Panel1.TabIndex=55;
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.Silver;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.UserLabel);
            this.Panel2.Controls.Add(this.DateLabel);
            this.Panel2.Location=new System.Drawing.Point(11, 402);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(311, 57);
            this.Panel2.TabIndex=56;
            //
            //UserLabel
            //
            this.UserLabel.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.UserLabel.Location=new System.Drawing.Point(142, 15);
            this.UserLabel.Name="UserLabel";
            this.UserLabel.Size=new System.Drawing.Size(164, 25);
            this.UserLabel.TabIndex=50;
            this.UserLabel.Text="--";
            this.UserLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //DateLabel
            //
            this.DateLabel.ForeColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.DateLabel.Location=new System.Drawing.Point(7, 15);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(135, 25);
            this.DateLabel.TabIndex=50;
            this.DateLabel.Text="--";
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Button1
            //
            this.Button1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.Button1.Location=new System.Drawing.Point(11, 496);
            this.Button1.Name="Button1";
            this.Button1.Size=new System.Drawing.Size(77, 54);
            this.Button1.TabIndex=57;
            this.Button1.Text="ویرایش";
            this.Button1.UseVisualStyleBackColor=false;
            //
            //NumBox
            //
            this.NumBox.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.NumBox.Location=new System.Drawing.Point(167, 12);
            this.NumBox.Mask=">A00";
            this.NumBox.Name="NumBox";
            this.NumBox.Size=new System.Drawing.Size(57, 33);
            this.NumBox.TabIndex=54;
            this.NumBox.TextAlign=HorizontalAlignment.Center;
            //
            //NavganReportForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(878, 571);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Wag9Label);
            this.Controls.Add(this.Wag8Label);
            this.Controls.Add(this.Wag7Label);
            this.Controls.Add(this.Wag6Label);
            this.Controls.Add(this.Wag5Label);
            this.Controls.Add(this.Wag4Label);
            this.Controls.Add(this.Wag3Label);
            this.Controls.Add(this.Wag2Label);
            this.Controls.Add(this.Wag1Label);
            this.Controls.Add(this.Loco1Label);
            this.Controls.Add(this.Loco2Label);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ShowGridView);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="NavganReportForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش آرایش ناوگان";
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DataGridView ShowGridView;
        private PictureBox PictureBox1;
        private Label Loco2Label;
        private Label Loco1Label;
        private Label Wag1Label;
        private Label Wag2Label;
        private Label Wag3Label;
        private Label Wag4Label;
        private Label Wag5Label;
        private Label Wag6Label;
        private Label Wag7Label;
        private Label Wag9Label;
        private Label Wag8Label;
        private Label Label1;
        private ComboBox KindCombo;
        private Label Label2;
        private Button SearchButton;
        private Panel Panel1;
        private Panel Panel2;
        private Label UserLabel;
        private Label DateLabel;
        private Button Button1;
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
    }

}
