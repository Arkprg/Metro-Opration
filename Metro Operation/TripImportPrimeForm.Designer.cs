using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripImportPrimeForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RegButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Name5Box = new System.Windows.Forms.TextBox();
            this.Analys5Button = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Select5Button = new System.Windows.Forms.Button();
            this.TripGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MorFBox = new System.Windows.Forms.TextBox();
            this.TripNBox = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.RezFBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.OddBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Line5Label = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Line51Label = new System.Windows.Forms.Label();
            this.Name51Box = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Select51Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TripGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(12, 8);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(140, 34);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Image = global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(12, 47);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 34);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "انصراف";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label3.Location = new System.Drawing.Point(416, 34);
            this.Label3.Margin = new System.Windows.Forms.Padding(3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 21);
            this.Label3.TabIndex = 127;
            this.Label3.Text = "تاریخ:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DateLabel.Location = new System.Drawing.Point(323, 32);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(97, 25);
            this.DateLabel.TabIndex = 128;
            this.DateLabel.Text = "-- / -- / ----";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name5Box
            // 
            this.Name5Box.BackColor = System.Drawing.SystemColors.Control;
            this.Name5Box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name5Box.Location = new System.Drawing.Point(635, 16);
            this.Name5Box.MaxLength = 100;
            this.Name5Box.Name = "Name5Box";
            this.Name5Box.ReadOnly = true;
            this.Name5Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name5Box.Size = new System.Drawing.Size(150, 22);
            this.Name5Box.TabIndex = 124;
            this.Name5Box.TabStop = false;
            this.Name5Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Analys5Button
            // 
            this.Analys5Button.Location = new System.Drawing.Point(206, 30);
            this.Analys5Button.Name = "Analys5Button";
            this.Analys5Button.Size = new System.Drawing.Size(98, 29);
            this.Analys5Button.TabIndex = 1;
            this.Analys5Button.Text = "تحلیل فایل";
            this.Analys5Button.UseVisualStyleBackColor = true;
            this.Analys5Button.Click += new System.EventHandler(this.Analys5Button_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.Location = new System.Drawing.Point(785, 19);
            this.Label1.Margin = new System.Windows.Forms.Padding(3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 16);
            this.Label1.TabIndex = 126;
            this.Label1.Text = "نام فایل خط اصلی:";
            // 
            // Select5Button
            // 
            this.Select5Button.Image = global::Metro_Operation.Properties.Resources.docs_24;
            this.Select5Button.Location = new System.Drawing.Point(609, 14);
            this.Select5Button.Name = "Select5Button";
            this.Select5Button.Size = new System.Drawing.Size(25, 26);
            this.Select5Button.TabIndex = 0;
            this.Select5Button.UseVisualStyleBackColor = true;
            this.Select5Button.Click += new System.EventHandler(this.Select5Button_Click);
            // 
            // TripGridView
            // 
            this.TripGridView.AllowUserToAddRows = false;
            this.TripGridView.AllowUserToDeleteRows = false;
            this.TripGridView.AllowUserToResizeColumns = false;
            this.TripGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            this.TripGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TripGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TripGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TripGridView.ColumnHeadersHeight = 40;
            this.TripGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TripGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column14,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column13,
            this.Column2,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TripGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TripGridView.EnableHeadersVisualStyles = false;
            this.TripGridView.Location = new System.Drawing.Point(9, 181);
            this.TripGridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TripGridView.Name = "TripGridView";
            this.TripGridView.ReadOnly = true;
            this.TripGridView.RowHeadersVisible = false;
            this.TripGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TripGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TripGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TripGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TripGridView.Size = new System.Drawing.Size(907, 439);
            this.TripGridView.TabIndex = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ردیف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "تاریخ ";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ساعت ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "مبدا";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "مقصد";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 70;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "راهبر اصلی";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "پرسنلی";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "راهبر کمکی";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "راهبر آموزشی";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "پرسنلی";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Moccasin;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.MorFBox);
            this.Panel1.Controls.Add(this.TripNBox);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.RezFBox);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.OddBox);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.TotalBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(9, 115);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(907, 50);
            this.Panel1.TabIndex = 131;
            // 
            // MorFBox
            // 
            this.MorFBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MorFBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MorFBox.Location = new System.Drawing.Point(30, 13);
            this.MorFBox.Name = "MorFBox";
            this.MorFBox.ReadOnly = true;
            this.MorFBox.Size = new System.Drawing.Size(43, 23);
            this.MorFBox.TabIndex = 129;
            this.MorFBox.Text = "0";
            this.MorFBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MorFBox.Click += new System.EventHandler(this.MorFBox_Click);
            // 
            // TripNBox
            // 
            this.TripNBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TripNBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TripNBox.Location = new System.Drawing.Point(572, 13);
            this.TripNBox.Name = "TripNBox";
            this.TripNBox.ReadOnly = true;
            this.TripNBox.Size = new System.Drawing.Size(43, 23);
            this.TripNBox.TabIndex = 129;
            this.TripNBox.Text = "0";
            this.TripNBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TripNBox.Click += new System.EventHandler(this.TripNBox_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label6.Location = new System.Drawing.Point(73, 16);
            this.Label6.Margin = new System.Windows.Forms.Padding(3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(139, 16);
            this.Label6.TabIndex = 128;
            this.Label6.Text = " مرخصی روزانه در لوحه:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label7.Location = new System.Drawing.Point(449, 16);
            this.Label7.Margin = new System.Windows.Forms.Padding(3);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(106, 16);
            this.Label7.TabIndex = 128;
            this.Label7.Text = "خطای نیم راه فرد:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RezFBox
            // 
            this.RezFBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RezFBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RezFBox.Location = new System.Drawing.Point(231, 13);
            this.RezFBox.Name = "RezFBox";
            this.RezFBox.ReadOnly = true;
            this.RezFBox.Size = new System.Drawing.Size(43, 23);
            this.RezFBox.TabIndex = 129;
            this.RezFBox.Text = "0";
            this.RezFBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RezFBox.Click += new System.EventHandler(this.RezFBox_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label5.Location = new System.Drawing.Point(274, 16);
            this.Label5.Margin = new System.Windows.Forms.Padding(3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(111, 16);
            this.Label5.TabIndex = 128;
            this.Label5.Text = "خطای رزرو با تریپ:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OddBox
            // 
            this.OddBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OddBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OddBox.Location = new System.Drawing.Point(406, 13);
            this.OddBox.Name = "OddBox";
            this.OddBox.ReadOnly = true;
            this.OddBox.Size = new System.Drawing.Size(43, 23);
            this.OddBox.TabIndex = 129;
            this.OddBox.Text = "0";
            this.OddBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OddBox.Click += new System.EventHandler(this.OddBox_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.Location = new System.Drawing.Point(615, 16);
            this.Label4.Margin = new System.Windows.Forms.Padding(3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(98, 16);
            this.Label4.TabIndex = 128;
            this.Label4.Text = "راهبر بدون تریپ:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBox
            // 
            this.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalBox.Location = new System.Drawing.Point(728, 13);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(43, 23);
            this.TotalBox.TabIndex = 129;
            this.TotalBox.Text = "0";
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalBox.Click += new System.EventHandler(this.TotalBox_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label2.Location = new System.Drawing.Point(771, 16);
            this.Label2.Margin = new System.Windows.Forms.Padding(3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(123, 16);
            this.Label2.TabIndex = 128;
            this.Label2.Text = "تعداد راهبران شیفت:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Line5Label
            // 
            this.Line5Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Line5Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Line5Label.Location = new System.Drawing.Point(484, 15);
            this.Line5Label.Margin = new System.Windows.Forms.Padding(3);
            this.Line5Label.Name = "Line5Label";
            this.Line5Label.Size = new System.Drawing.Size(92, 25);
            this.Line5Label.TabIndex = 128;
            this.Line5Label.Text = "خط اصلی";
            this.Line5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Line5Label.Visible = false;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Line51Label);
            this.Panel2.Controls.Add(this.Line5Label);
            this.Panel2.Controls.Add(this.Name51Box);
            this.Panel2.Controls.Add(this.DateLabel);
            this.Panel2.Controls.Add(this.Name5Box);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Analys5Button);
            this.Panel2.Controls.Add(this.Select51Button);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Select5Button);
            this.Panel2.Location = new System.Drawing.Point(9, 13);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(907, 90);
            this.Panel2.TabIndex = 132;
            // 
            // Line51Label
            // 
            this.Line51Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Line51Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Line51Label.Location = new System.Drawing.Point(484, 50);
            this.Line51Label.Margin = new System.Windows.Forms.Padding(3);
            this.Line51Label.Name = "Line51Label";
            this.Line51Label.Size = new System.Drawing.Size(92, 25);
            this.Line51Label.TabIndex = 128;
            this.Line51Label.Text = "خط هشتگرد";
            this.Line51Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Line51Label.Visible = false;
            // 
            // Name51Box
            // 
            this.Name51Box.BackColor = System.Drawing.SystemColors.Control;
            this.Name51Box.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name51Box.Location = new System.Drawing.Point(635, 51);
            this.Name51Box.MaxLength = 100;
            this.Name51Box.Name = "Name51Box";
            this.Name51Box.ReadOnly = true;
            this.Name51Box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Name51Box.Size = new System.Drawing.Size(150, 22);
            this.Name51Box.TabIndex = 124;
            this.Name51Box.TabStop = false;
            this.Name51Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label8.Location = new System.Drawing.Point(785, 54);
            this.Label8.Margin = new System.Windows.Forms.Padding(3);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(105, 16);
            this.Label8.TabIndex = 126;
            this.Label8.Text = "نام فایل هشتگرد:";
            // 
            // Select51Button
            // 
            this.Select51Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Select51Button.Image = global::Metro_Operation.Properties.Resources.docs_24;
            this.Select51Button.Location = new System.Drawing.Point(609, 49);
            this.Select51Button.Name = "Select51Button";
            this.Select51Button.Size = new System.Drawing.Size(25, 26);
            this.Select51Button.TabIndex = 0;
            this.Select51Button.UseVisualStyleBackColor = true;
            this.Select51Button.Click += new System.EventHandler(this.Select51Button_Click);
            // 
            // TripImportPrimeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(924, 626);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TripGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TripImportPrimeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت لوحه راهبری: اولیه";
            this.Load += new System.EventHandler(this.TripImportPrimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TripGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private Button RegButton;
        private Button ExitButton;
        private Label Label3;
        private Label DateLabel;
        private TextBox Name5Box;
        private Button Analys5Button;
        private Label Label1;
        private Button Select5Button;
        private DataGridView TripGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Panel Panel1;
        private TextBox RezFBox;
        private Label Label5;
        private TextBox OddBox;
        private Label Label4;
        private TextBox TotalBox;
        private Label Label2;
        private TextBox MorFBox;
        private Label Label6;
        private TextBox TripNBox;
        private Label Label7;
        private Label Line5Label;
        private Panel Panel2;
        private Label Line51Label;
        private TextBox Name51Box;
        private Label Label8;
        private Button Select51Button;
    }

}
