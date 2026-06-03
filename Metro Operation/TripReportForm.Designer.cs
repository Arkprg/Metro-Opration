using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripReportForm : BaseForm
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

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label4 = new System.Windows.Forms.Label();
            this.EndCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NameButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TransCheck = new System.Windows.Forms.CheckBox();
            this.LocaCombo = new System.Windows.Forms.ComboBox();
            this.LineCombo = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.KindCombo = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(937, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 16);
            this.Label4.TabIndex = 56;
            this.Label4.Text = "نام:";
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location = new System.Drawing.Point(203, 50);
            this.EndCalendar.Miladi = new System.DateTime(((long)(0)));
            this.EndCalendar.Name = "EndCalendar";
            this.EndCalendar.NowDateSelected = true;
            this.EndCalendar.ReadOnly = true;
            this.EndCalendar.SelectedDate = null;
            this.EndCalendar.Shamsi = null;
            this.EndCalendar.Size = new System.Drawing.Size(120, 23);
            this.EndCalendar.TabIndex = 55;
            this.EndCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location = new System.Drawing.Point(203, 13);
            this.StartCalendar.Miladi = new System.DateTime(((long)(0)));
            this.StartCalendar.Name = "StartCalendar";
            this.StartCalendar.NowDateSelected = true;
            this.StartCalendar.ReadOnly = true;
            this.StartCalendar.SelectedDate = null;
            this.StartCalendar.Shamsi = null;
            this.StartCalendar.Size = new System.Drawing.Size(120, 23);
            this.StartCalendar.TabIndex = 54;
            this.StartCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(16, 44);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(155, 34);
            this.ExportButton.TabIndex = 34;
            this.ExportButton.Text = "ذخیره";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(16, 7);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(155, 34);
            this.ShowButton.TabIndex = 5;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ShowGridView
            // 
            this.ShowGridView.AllowUserToAddRows = false;
            this.ShowGridView.AllowUserToDeleteRows = false;
            this.ShowGridView.AllowUserToResizeColumns = false;
            this.ShowGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            this.ShowGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ShowGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ShowGridView.ColumnHeadersHeight = 40;
            this.ShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column14,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column10,
            this.Column23,
            this.Column15,
            this.Column16,
            this.Column8,
            this.Column2,
            this.Column11,
            this.Column24,
            this.Column17,
            this.Column18,
            this.Column13,
            this.Column9,
            this.Column12,
            this.Column25,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(8, 102);
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(994, 460);
            this.ShowGridView.TabIndex = 51;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameBox.Location = new System.Drawing.Point(802, 31);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(135, 23);
            this.NameBox.TabIndex = 33;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(322, 16);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 16);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "از تاریخ:";
            // 
            // NameButton
            // 
            this.NameButton.Image = global::Metro_Operation.Properties.Resources.user;
            this.NameButton.Location = new System.Drawing.Point(773, 30);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex = 1;
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(322, 53);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 16);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "تا تاریخ:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.TransCheck);
            this.Panel1.Controls.Add(this.LocaCombo);
            this.Panel1.Controls.Add(this.LineCombo);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(8, 8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(994, 86);
            this.Panel1.TabIndex = 50;
            // 
            // TransCheck
            // 
            this.TransCheck.AutoSize = true;
            this.TransCheck.Location = new System.Drawing.Point(597, 51);
            this.TransCheck.Name = "TransCheck";
            this.TransCheck.Size = new System.Drawing.Size(99, 20);
            this.TransCheck.TabIndex = 61;
            this.TransCheck.Text = "تحویل و تحول";
            this.TransCheck.UseVisualStyleBackColor = true;
            // 
            // LocaCombo
            // 
            this.LocaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocaCombo.FormattingEnabled = true;
            this.LocaCombo.Location = new System.Drawing.Point(412, 49);
            this.LocaCombo.Name = "LocaCombo";
            this.LocaCombo.Size = new System.Drawing.Size(105, 24);
            this.LocaCombo.TabIndex = 60;
            this.LocaCombo.SelectedIndexChanged += new System.EventHandler(this.LocaCombo_SelectedIndexChanged);
            // 
            // LineCombo
            // 
            this.LineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineCombo.FormattingEnabled = true;
            this.LineCombo.Items.AddRange(new object[] {
            "همه موارد",
            "خط اصلی",
            "خط هشتگرد"});
            this.LineCombo.Location = new System.Drawing.Point(412, 12);
            this.LineCombo.Name = "LineCombo";
            this.LineCombo.Size = new System.Drawing.Size(105, 24);
            this.LineCombo.TabIndex = 58;
            this.LineCombo.SelectedIndexChanged += new System.EventHandler(this.LineCombo_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(517, 16);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(31, 16);
            this.Label5.TabIndex = 59;
            this.Label5.Text = "خط:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(517, 53);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 16);
            this.Label6.TabIndex = 57;
            this.Label6.Text = "مبدا:";
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled = true;
            this.KindCombo.Items.AddRange(new object[] {
            "اولیه",
            "اجرا شده",
            "نهایی"});
            this.KindCombo.Location = new System.Drawing.Point(594, 12);
            this.KindCombo.Name = "KindCombo";
            this.KindCombo.Size = new System.Drawing.Size(105, 24);
            this.KindCombo.TabIndex = 58;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(698, 16);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 16);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "لوحه:";
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
            this.Column14.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ساعت ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "مبدا";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 85;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "مقصد";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
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
            this.Column4.Width = 66;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "زمان تحویل";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "تا اعزام";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Visible = false;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "نوع شیفت";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "نام شیفت";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "راهبر آموزشی";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "پرسنلی.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 66;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "زمان تحویل.";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "تا اعزام.";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Visible = false;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "نوع شیفت.";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "نام شیفت.";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "راهبر کمکی";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "پرسنلی,";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 66;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "زمان تحویل,";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "تا اعزام,";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Visible = false;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "نوع شیفت,";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "نام شیفت,";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "کاربر";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Visible = false;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "تاریخ ثبت";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            // 
            // TripReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1009, 571);
            this.Controls.Add(this.ShowGridView);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TripReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش تریپ روزانه";
            this.Load += new System.EventHandler(this.TripReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label Label4;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Button ExportButton;
        private Button ShowButton;
        private DataGridView ShowGridView;
        private TextBox NameBox;
        private Label Label3;
        private Button NameButton;
        private Label Label2;
        private Panel Panel1;
        private Label Label1;
        private ComboBox KindCombo;
        private ComboBox LocaCombo;
        private Label Label5;
        private ComboBox LineCombo;
        private Label Label6;
        private CheckBox TransCheck;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private System.ComponentModel.IContainer components;
    }

}
