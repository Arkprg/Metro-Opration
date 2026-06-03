using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Windows.Forms;

using Metro_Operation;

namespace Metro_Operation
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class PhoneBookForm : BaseForm
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && components != null)  {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            this.PersonGridView=new System.Windows.Forms.DataGridView();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1=new System.Windows.Forms.Panel();
            this.PNumBox=new System.Windows.Forms.TextBox();
            this.PhoneBox=new System.Windows.Forms.TextBox();
            this.Label6=new System.Windows.Forms.Label();
            this.Label3=new System.Windows.Forms.Label();
            this.NameBox=new System.Windows.Forms.TextBox();
            this.FamilyBox=new System.Windows.Forms.TextBox();
            this.Label20=new System.Windows.Forms.Label();
            this.Label4=new System.Windows.Forms.Label();
            this.Panel2=new System.Windows.Forms.Panel();
            this.PhonBox1=new System.Windows.Forms.MaskedTextBox();
            this.NameLabel=new System.Windows.Forms.Label();
            this.CallButton=new System.Windows.Forms.Button();
            this.EditButton=new System.Windows.Forms.Button();
            this.SaveButton=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonGridView
            // 
            this.PersonGridView.AllowUserToAddRows=false;
            this.PersonGridView.AllowUserToDeleteRows=false;
            this.PersonGridView.AllowUserToResizeColumns=false;
            this.PersonGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PersonGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle1;
            this.PersonGridView.ColumnHeadersBorderStyle=System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.False;
            this.PersonGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.PersonGridView.ColumnHeadersHeight=32;
            this.PersonGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PersonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column1,
            this.Column9});
            this.PersonGridView.EnableHeadersVisualStyles=false;
            this.PersonGridView.Location=new System.Drawing.Point(10, 77);
            this.PersonGridView.MultiSelect=false;
            this.PersonGridView.Name="PersonGridView";
            this.PersonGridView.ReadOnly=true;
            this.PersonGridView.RowHeadersVisible=false;
            this.PersonGridView.RowHeadersWidthSizeMode=System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PersonGridView.RowTemplate.DefaultCellStyle.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PersonGridView.RowTemplate.DefaultCellStyle.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonGridView.RowTemplate.ReadOnly=true;
            this.PersonGridView.RowTemplate.Resizable=System.Windows.Forms.DataGridViewTriState.False;
            this.PersonGridView.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonGridView.Size=new System.Drawing.Size(516, 283);
            this.PersonGridView.TabIndex=1;
            this.PersonGridView.CurrentCellChanged += new System.EventHandler(this.PersonGridView_CurrentCellChanged);
            // 
            // Column3
            // 
            this.Column3.HeaderText="نام";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText="نام خانوادگی";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            // 
            // Column1
            // 
            this.Column1.HeaderText="شماره پرسنلی";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            // 
            // Column9
            // 
            this.Column9.HeaderText="تلفن";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PNumBox);
            this.Panel1.Controls.Add(this.PhoneBox);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.FamilyBox);
            this.Panel1.Controls.Add(this.Label20);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Location=new System.Drawing.Point(10, 10);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(516, 60);
            this.Panel1.TabIndex=0;
            // 
            // PNumBox
            // 
            this.PNumBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PNumBox.Location=new System.Drawing.Point(104, 27);
            this.PNumBox.MaxLength=10;
            this.PNumBox.Name="PNumBox";
            this.PNumBox.Size=new System.Drawing.Size(94, 23);
            this.PNumBox.TabIndex=1;
            this.PNumBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhoneBox.Location=new System.Drawing.Point(6, 27);
            this.PhoneBox.MaxLength=11;
            this.PhoneBox.Name="PhoneBox";
            this.PhoneBox.Size=new System.Drawing.Size(90, 23);
            this.PhoneBox.TabIndex=2;
            this.PhoneBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // Label6
            // 
            this.Label6.AutoSize=true;
            this.Label6.BackColor=System.Drawing.Color.Transparent;
            this.Label6.Location=new System.Drawing.Point(15, 5);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(74, 16);
            this.Label6.TabIndex=78;
            this.Label6.Text="شماره تلفن";
            // 
            // Label3
            // 
            this.Label3.AutoSize=true;
            this.Label3.BackColor=System.Drawing.Color.Transparent;
            this.Label3.Location=new System.Drawing.Point(105, 5);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(93, 16);
            this.Label3.TabIndex=79;
            this.Label3.Text="شماره پرسنلی";
            // 
            // NameBox
            // 
            this.NameBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameBox.Location=new System.Drawing.Point(394, 27);
            this.NameBox.MaxLength=50;
            this.NameBox.Name="NameBox";
            this.NameBox.Size=new System.Drawing.Size(112, 23);
            this.NameBox.TabIndex=3;
            this.NameBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // FamilyBox
            // 
            this.FamilyBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FamilyBox.Location=new System.Drawing.Point(206, 27);
            this.FamilyBox.MaxLength=50;
            this.FamilyBox.Name="FamilyBox";
            this.FamilyBox.Size=new System.Drawing.Size(180, 23);
            this.FamilyBox.TabIndex=0;
            this.FamilyBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // Label20
            // 
            this.Label20.AutoSize=true;
            this.Label20.BackColor=System.Drawing.Color.Transparent;
            this.Label20.Location=new System.Drawing.Point(257, 5);
            this.Label20.Name="Label20";
            this.Label20.Size=new System.Drawing.Size(79, 16);
            this.Label20.TabIndex=69;
            this.Label20.Text="نام خانوادگی";
            // 
            // Label4
            // 
            this.Label4.AutoSize=true;
            this.Label4.BackColor=System.Drawing.Color.Transparent;
            this.Label4.Location=new System.Drawing.Point(439, 5);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(24, 16);
            this.Label4.TabIndex=70;
            this.Label4.Text="نام";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.PhonBox1);
            this.Panel2.Controls.Add(this.NameLabel);
            this.Panel2.Font=new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel2.Location=new System.Drawing.Point(10, 367);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(516, 54);
            this.Panel2.TabIndex=2;
            // 
            // PhonBox1
            // 
            this.PhonBox1.BackColor=System.Drawing.Color.Black;
            this.PhonBox1.Font=new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PhonBox1.ForeColor=System.Drawing.Color.Yellow;
            this.PhonBox1.Location=new System.Drawing.Point(12, 3);
            this.PhonBox1.Mask="0000 000 0000";
            this.PhonBox1.Name="PhonBox1";
            this.PhonBox1.PromptChar=' ';
            this.PhonBox1.RightToLeft=System.Windows.Forms.RightToLeft.No;
            this.PhonBox1.Size=new System.Drawing.Size(231, 46);
            this.PhonBox1.TabIndex=3;
            this.PhonBox1.Text="09374550876";
            this.PhonBox1.TextAlign=System.Windows.Forms.HorizontalAlignment.Center;
            this.PhonBox1.Enter += new System.EventHandler(this.PhonBox1_Enter);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor=System.Windows.Forms.AnchorStyles.Right;
            this.NameLabel.BackColor=System.Drawing.Color.Transparent;
            this.NameLabel.Font=new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameLabel.ImageAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.NameLabel.Location=new System.Drawing.Point(250, 6);
            this.NameLabel.Name="NameLabel";
            this.NameLabel.Size=new System.Drawing.Size(252, 41);
            this.NameLabel.TabIndex=102;
            this.NameLabel.Text="--";
            // 
            // CallButton
            // 
            this.CallButton.BackColor=System.Drawing.Color.Snow;
            this.CallButton.Enabled=false;
            this.CallButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CallButton.Image=global::Metro_Operation.Properties.Resources.phone;
            this.CallButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.CallButton.Location=new System.Drawing.Point(14, 433);
            this.CallButton.Name="CallButton";
            this.CallButton.Size=new System.Drawing.Size(120, 30);
            this.CallButton.TabIndex=101;
            this.CallButton.Text="تماس";
            this.CallButton.UseVisualStyleBackColor=false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor=System.Drawing.Color.Snow;
            this.EditButton.Enabled=false;
            this.EditButton.Image=global::Metro_Operation.Properties.Resources.edit_16;
            this.EditButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location=new System.Drawing.Point(348, 433);
            this.EditButton.Name="EditButton";
            this.EditButton.Size=new System.Drawing.Size(170, 30);
            this.EditButton.TabIndex=99;
            this.EditButton.Text="ویرایش";
            this.EditButton.UseVisualStyleBackColor=false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor=System.Drawing.Color.Snow;
            this.SaveButton.Enabled=false;
            this.SaveButton.Image=global::Metro_Operation.Properties.Resources.opts_16;
            this.SaveButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location=new System.Drawing.Point(172, 433);
            this.SaveButton.Name="SaveButton";
            this.SaveButton.Size=new System.Drawing.Size(170, 30);
            this.SaveButton.TabIndex=100;
            this.SaveButton.Text="ذخیره";
            this.SaveButton.UseVisualStyleBackColor=false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PhoneBookForm
            // 
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(535, 466);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.PersonGridView);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.HelpButton=true;
            this.Margin=new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="PhoneBookForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="دفترچه تلفن";
            this.Load += new System.EventHandler(this.PhoneBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		private DataGridView PersonGridView;
		private Panel Panel1;
		private TextBox NameBox;
		private TextBox FamilyBox;
		private Label Label20;
		private Label Label4;
		private TextBox PNumBox;
		private TextBox PhoneBox;
		private Label Label6;
		private Label Label3;
		private Panel Panel2;
		private MaskedTextBox PhonBox1;
		private Button EditButton;
		private Button SaveButton;
		private Button CallButton;
		private Label NameLabel;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column9;
	}
	
}
