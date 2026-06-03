using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripLovhehReportForm : BaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.KindCombo = new System.Windows.Forms.ComboBox();
            this.EndCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.StartCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(729, 30);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 16);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "لوحه:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.KindCombo);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.EndCalendar);
            this.Panel1.Controls.Add(this.StartCalendar);
            this.Panel1.Controls.Add(this.ExportButton);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(8, 8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(850, 80);
            this.Panel1.TabIndex = 0;
            // 
            // KindCombo
            // 
            this.KindCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KindCombo.FormattingEnabled = true;
            this.KindCombo.Items.AddRange(new object[] {
            "همه موارد",
            "اولیه",
            "اجرا شده"});
            this.KindCombo.Location = new System.Drawing.Point(565, 26);
            this.KindCombo.Name = "KindCombo";
            this.KindCombo.Size = new System.Drawing.Size(164, 24);
            this.KindCombo.TabIndex = 0;
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            // 
            // EndCalendar
            // 
            this.EndCalendar.Location = new System.Drawing.Point(296, 46);
            this.EndCalendar.Miladi = new System.DateTime(((long)(0)));
            this.EndCalendar.Name = "EndCalendar";
            this.EndCalendar.NowDateSelected = true;
            this.EndCalendar.ReadOnly = true;
            this.EndCalendar.SelectedDate = null;
            this.EndCalendar.Shamsi = null;
            this.EndCalendar.Size = new System.Drawing.Size(128, 23);
            this.EndCalendar.TabIndex = 2;
            this.EndCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // StartCalendar
            // 
            this.StartCalendar.Location = new System.Drawing.Point(296, 11);
            this.StartCalendar.Miladi = new System.DateTime(((long)(0)));
            this.StartCalendar.Name = "StartCalendar";
            this.StartCalendar.NowDateSelected = true;
            this.StartCalendar.ReadOnly = true;
            this.StartCalendar.SelectedDate = null;
            this.StartCalendar.Shamsi = null;
            this.StartCalendar.Size = new System.Drawing.Size(128, 23);
            this.StartCalendar.TabIndex = 1;
            this.StartCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartCalendar.TextChanged += new System.EventHandler(this.StartCalendar_TextChanged);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExportButton.Image = global::Metro_Operation.Properties.Resources.save_file_option;
            this.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportButton.Location = new System.Drawing.Point(30, 40);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(155, 34);
            this.ExportButton.TabIndex = 4;
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
            this.ShowButton.Location = new System.Drawing.Point(30, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(155, 34);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(424, 14);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 16);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "از تاریخ:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(424, 49);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 16);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "تا تاریخ:";
            // 
            // ShowGridView
            // 
            this.ShowGridView.AllowUserToAddRows = false;
            this.ShowGridView.AllowUserToDeleteRows = false;
            this.ShowGridView.AllowUserToResizeColumns = false;
            this.ShowGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            this.ShowGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ShowGridView.ColumnHeadersHeight = 40;
            this.ShowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column14,
            this.Column5,
            this.Column4,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(8, 97);
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(850, 450);
            this.ShowGridView.TabIndex = 1;
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
            this.Column14.HeaderText = "تاریخ اجرا";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "مبدا";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "پردازش گیرنده";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "تاریخ پردازش";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "نوع لوحه";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ثبت کننده لوحه";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "تاریخ ثبت";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // TripLovhehReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(864, 555);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShowGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TripLovhehReportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش لوحه های ثبت شده";
            this.Load += new System.EventHandler(this.TripLovhehReportForm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private Label Label1;
        private Panel Panel1;
        private ComboBox KindCombo;
        private BPersianCalender.BPersianCalenderTextBox EndCalendar;
        private BPersianCalender.BPersianCalenderTextBox StartCalendar;
        private Button ExportButton;
        private Button ShowButton;
        private Label Label3;
        private Label Label2;
        private DataGridView ShowGridView;
        private System.ComponentModel.IContainer components;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column7;
    }

}
