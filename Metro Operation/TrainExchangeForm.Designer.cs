using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TrainExchangeForm : BaseForm
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
            this.ShowGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label9 = new System.Windows.Forms.Label();
            this.LocalCombo = new System.Windows.Forms.ComboBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.PersianCalendar = new BPersianCalender.BPersianCalenderTextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.EzamLocalCombo = new System.Windows.Forms.ComboBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LineCombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Name3Box = new System.Windows.Forms.TextBox();
            this.Name3Button = new System.Windows.Forms.Button();
            this.Name2Box = new System.Windows.Forms.TextBox();
            this.Name2Button = new System.Windows.Forms.Button();
            this.Name1Box = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Name1Button = new System.Windows.Forms.Button();
            this.Time3Button = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Time2Button = new System.Windows.Forms.Button();
            this.Time1Button = new System.Windows.Forms.Button();
            this.R3TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.R2TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.EzamBox = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.R1TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column10,
            this.Column8,
            this.Column2,
            this.Column11,
            this.Column13,
            this.Column9,
            this.Column12});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShowGridView.EnableHeadersVisualStyles = false;
            this.ShowGridView.Location = new System.Drawing.Point(9, 66);
            this.ShowGridView.Name = "ShowGridView";
            this.ShowGridView.ReadOnly = true;
            this.ShowGridView.RowHeadersVisible = false;
            this.ShowGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size = new System.Drawing.Size(850, 372);
            this.ShowGridView.TabIndex = 1;
            this.ShowGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGridView_CellClick);
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
            this.Column14.Visible = false;
            this.Column14.Width = 75;
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
            this.Column6.Visible = false;
            this.Column6.Width = 85;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "مقصد";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
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
            this.Column4.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "زمان";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 50;
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
            this.Column2.HeaderText = "پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "زمان";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
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
            this.Column9.HeaderText = "پرسنلی";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "زمان";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.LocalCombo);
            this.Panel1.Controls.Add(this.ShowButton);
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Location = new System.Drawing.Point(9, 9);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(850, 50);
            this.Panel1.TabIndex = 0;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(456, 16);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 16);
            this.Label9.TabIndex = 24;
            this.Label9.Text = "مبدا:";
            // 
            // LocalCombo
            // 
            this.LocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LocalCombo.FormattingEnabled = true;
            this.LocalCombo.Location = new System.Drawing.Point(329, 12);
            this.LocalCombo.Name = "LocalCombo";
            this.LocalCombo.Size = new System.Drawing.Size(127, 24);
            this.LocalCombo.TabIndex = 23;
            this.LocalCombo.SelectedIndexChanged += new System.EventHandler(this.LocalCombo_SelectedIndexChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Image = global::Metro_Operation.Properties.Resources.search;
            this.ShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowButton.Location = new System.Drawing.Point(28, 7);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(135, 34);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // PersianCalendar
            // 
            this.PersianCalendar.Location = new System.Drawing.Point(629, 13);
            this.PersianCalendar.Miladi = new System.DateTime(((long)(0)));
            this.PersianCalendar.Name = "PersianCalendar";
            this.PersianCalendar.NowDateSelected = true;
            this.PersianCalendar.ReadOnly = true;
            this.PersianCalendar.SelectedDate = null;
            this.PersianCalendar.Shamsi = null;
            this.PersianCalendar.Size = new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex = 1;
            this.PersianCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(754, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 16);
            this.Label7.TabIndex = 22;
            this.Label7.Text = "تاریخ:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(622, 45);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 16);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "مبدا:";
            // 
            // EzamLocalCombo
            // 
            this.EzamLocalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EzamLocalCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EzamLocalCombo.FormattingEnabled = true;
            this.EzamLocalCombo.Location = new System.Drawing.Point(496, 41);
            this.EzamLocalCombo.Name = "EzamLocalCombo";
            this.EzamLocalCombo.Size = new System.Drawing.Size(126, 24);
            this.EzamLocalCombo.TabIndex = 1;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.LineCombo);
            this.Panel2.Controls.Add(this.label11);
            this.Panel2.Controls.Add(this.Name3Box);
            this.Panel2.Controls.Add(this.Name3Button);
            this.Panel2.Controls.Add(this.Name2Box);
            this.Panel2.Controls.Add(this.Name2Button);
            this.Panel2.Controls.Add(this.Name1Box);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.EzamLocalCombo);
            this.Panel2.Controls.Add(this.Name1Button);
            this.Panel2.Controls.Add(this.Time3Button);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Time2Button);
            this.Panel2.Controls.Add(this.Time1Button);
            this.Panel2.Controls.Add(this.R3TimeBox);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.R2TimeBox);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.EzamBox);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.R1TimeBox);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(177, 446);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(682, 109);
            this.Panel2.TabIndex = 2;
            // 
            // LineCombo
            // 
            this.LineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LineCombo.FormattingEnabled = true;
            this.LineCombo.Items.AddRange(new object[] {
            "تهران - گلشهر",
            "گلشهر - هشتگرد"});
            this.LineCombo.Location = new System.Drawing.Point(496, 7);
            this.LineCombo.Name = "LineCombo";
            this.LineCombo.Size = new System.Drawing.Size(126, 24);
            this.LineCombo.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(622, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "خط:";
            // 
            // Name3Box
            // 
            this.Name3Box.BackColor = System.Drawing.SystemColors.Window;
            this.Name3Box.Location = new System.Drawing.Point(217, 76);
            this.Name3Box.Name = "Name3Box";
            this.Name3Box.ReadOnly = true;
            this.Name3Box.Size = new System.Drawing.Size(157, 23);
            this.Name3Box.TabIndex = 33;
            this.Name3Box.TabStop = false;
            // 
            // Name3Button
            // 
            this.Name3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Name3Button.Image = global::Metro_Operation.Properties.Resources.user;
            this.Name3Button.Location = new System.Drawing.Point(187, 75);
            this.Name3Button.Name = "Name3Button";
            this.Name3Button.Size = new System.Drawing.Size(30, 25);
            this.Name3Button.TabIndex = 3;
            this.Name3Button.UseVisualStyleBackColor = true;
            this.Name3Button.Click += new System.EventHandler(this.Name3Button_Click);
            // 
            // Name2Box
            // 
            this.Name2Box.BackColor = System.Drawing.SystemColors.Window;
            this.Name2Box.Location = new System.Drawing.Point(217, 42);
            this.Name2Box.Name = "Name2Box";
            this.Name2Box.ReadOnly = true;
            this.Name2Box.Size = new System.Drawing.Size(157, 23);
            this.Name2Box.TabIndex = 33;
            this.Name2Box.TabStop = false;
            // 
            // Name2Button
            // 
            this.Name2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Name2Button.Image = global::Metro_Operation.Properties.Resources.user;
            this.Name2Button.Location = new System.Drawing.Point(187, 41);
            this.Name2Button.Name = "Name2Button";
            this.Name2Button.Size = new System.Drawing.Size(30, 25);
            this.Name2Button.TabIndex = 3;
            this.Name2Button.UseVisualStyleBackColor = true;
            this.Name2Button.Click += new System.EventHandler(this.Name2Button_Click);
            // 
            // Name1Box
            // 
            this.Name1Box.BackColor = System.Drawing.SystemColors.Window;
            this.Name1Box.Location = new System.Drawing.Point(217, 8);
            this.Name1Box.Name = "Name1Box";
            this.Name1Box.ReadOnly = true;
            this.Name1Box.Size = new System.Drawing.Size(157, 23);
            this.Name1Box.TabIndex = 33;
            this.Name1Box.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(373, 79);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(91, 16);
            this.Label8.TabIndex = 34;
            this.Label8.Text = "راهبر آموزشی:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(373, 45);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 16);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "راهبر کمکی:";
            // 
            // Name1Button
            // 
            this.Name1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Name1Button.Image = global::Metro_Operation.Properties.Resources.user;
            this.Name1Button.Location = new System.Drawing.Point(187, 7);
            this.Name1Button.Name = "Name1Button";
            this.Name1Button.Size = new System.Drawing.Size(30, 25);
            this.Name1Button.TabIndex = 2;
            this.Name1Button.UseVisualStyleBackColor = true;
            this.Name1Button.Click += new System.EventHandler(this.Name1Button_Click);
            // 
            // Time3Button
            // 
            this.Time3Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Time3Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Time3Button.Image = global::Metro_Operation.Properties.Resources.Time;
            this.Time3Button.Location = new System.Drawing.Point(24, 76);
            this.Time3Button.Name = "Time3Button";
            this.Time3Button.Size = new System.Drawing.Size(23, 23);
            this.Time3Button.TabIndex = 7;
            this.Time3Button.UseVisualStyleBackColor = true;
            this.Time3Button.Click += new System.EventHandler(this.Time3Button_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(373, 11);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 16);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "راهبر اصلی:";
            // 
            // Time2Button
            // 
            this.Time2Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Time2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Time2Button.Image = global::Metro_Operation.Properties.Resources.Time;
            this.Time2Button.Location = new System.Drawing.Point(24, 42);
            this.Time2Button.Name = "Time2Button";
            this.Time2Button.Size = new System.Drawing.Size(23, 23);
            this.Time2Button.TabIndex = 7;
            this.Time2Button.UseVisualStyleBackColor = true;
            this.Time2Button.Click += new System.EventHandler(this.Time2Button_Click);
            // 
            // Time1Button
            // 
            this.Time1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Time1Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Time1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Time1Button.Image = global::Metro_Operation.Properties.Resources.Time;
            this.Time1Button.Location = new System.Drawing.Point(24, 8);
            this.Time1Button.Name = "Time1Button";
            this.Time1Button.Size = new System.Drawing.Size(23, 23);
            this.Time1Button.TabIndex = 6;
            this.Time1Button.UseVisualStyleBackColor = true;
            this.Time1Button.Click += new System.EventHandler(this.Time1Button_Click);
            // 
            // R3TimeBox
            // 
            this.R3TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.R3TimeBox.Location = new System.Drawing.Point(48, 76);
            this.R3TimeBox.Mask = "00:00";
            this.R3TimeBox.Name = "R3TimeBox";
            this.R3TimeBox.Size = new System.Drawing.Size(50, 23);
            this.R3TimeBox.TabIndex = 5;
            this.R3TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R3TimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(97, 79);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 16);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "زمان تحویل:";
            // 
            // R2TimeBox
            // 
            this.R2TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.R2TimeBox.Location = new System.Drawing.Point(48, 42);
            this.R2TimeBox.Mask = "00:00";
            this.R2TimeBox.Name = "R2TimeBox";
            this.R2TimeBox.Size = new System.Drawing.Size(50, 23);
            this.R2TimeBox.TabIndex = 5;
            this.R2TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R2TimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(97, 45);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(74, 16);
            this.Label10.TabIndex = 22;
            this.Label10.Text = "زمان تحویل:";
            // 
            // EzamBox
            // 
            this.EzamBox.BackColor = System.Drawing.Color.White;
            this.EzamBox.Location = new System.Drawing.Point(568, 76);
            this.EzamBox.Mask = "00:00";
            this.EzamBox.Name = "EzamBox";
            this.EzamBox.Size = new System.Drawing.Size(54, 23);
            this.EzamBox.TabIndex = 0;
            this.EzamBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EzamBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(622, 79);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 16);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "اعزام:";
            // 
            // R1TimeBox
            // 
            this.R1TimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.R1TimeBox.Location = new System.Drawing.Point(48, 8);
            this.R1TimeBox.Mask = "00:00";
            this.R1TimeBox.Name = "R1TimeBox";
            this.R1TimeBox.Size = new System.Drawing.Size(50, 23);
            this.R1TimeBox.TabIndex = 4;
            this.R1TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.R1TimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(98, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 16);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "زمان تحویل:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Image = global::Metro_Operation.Properties.Resources.add_24;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(30, 453);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 35);
            this.AddButton.TabIndex = 35;
            this.AddButton.Text = "جدید";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Image = global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Location = new System.Drawing.Point(30, 510);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(125, 35);
            this.RegButton.TabIndex = 8;
            this.RegButton.Text = "ذخیره";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // TrainExchangeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(869, 563);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ShowGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainExchangeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحویل و تحول قطار";
            this.Load += new System.EventHandler(this.TianExchangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private DataGridView ShowGridView;
        private Panel Panel1;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private Label Label7;
        private Label Label6;
        private ComboBox EzamLocalCombo;
        private Button ShowButton;
        private Panel Panel2;
        private Button RegButton;
        private MaskedTextBox R2TimeBox;
        private Label Label10;
        private MaskedTextBox R1TimeBox;
        private Label Label1;
        private Button Time1Button;
        private Button Time2Button;
        private TextBox Name2Box;
        private Button Name2Button;
        private TextBox Name1Box;
        private Label Label3;
        private Button Name1Button;
        private Label Label2;
        private MaskedTextBox EzamBox;
        private Label Label4;
        private Button AddButton;
        private TextBox Name3Box;
        private Button Name3Button;
        private Label Label8;
        private Button Time3Button;
        private MaskedTextBox R3TimeBox;
        private Label Label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column12;
        private Label Label9;
        private ComboBox LocalCombo;
        private ComboBox LineCombo;
        private Label label11;
        private System.ComponentModel.IContainer components;
    }

}
