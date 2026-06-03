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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class PersonalSelectForm : BaseForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1=new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2=new System.Windows.Forms.DataGridViewCellStyle();
            this.PersonGridView=new System.Windows.Forms.DataGridView();
            this.Column1=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9=new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label1=new System.Windows.Forms.Label();
            this.SearchBox=new System.Windows.Forms.TextBox();
            this.SelectButton=new System.Windows.Forms.Button();
            this.ExitButton=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonGridView
            // 
            this.PersonGridView.AllowUserToAddRows=false;
            this.PersonGridView.AllowUserToDeleteRows=false;
            this.PersonGridView.AllowUserToResizeColumns=false;
            this.PersonGridView.AllowUserToResizeRows=false;
            dataGridViewCellStyle1.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor=System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor=System.Drawing.Color.Black;
            this.PersonGridView.AlternatingRowsDefaultCellStyle=dataGridViewCellStyle1;
            this.PersonGridView.BackgroundColor=System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment=System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor=System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor=System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode=System.Windows.Forms.DataGridViewTriState.True;
            this.PersonGridView.ColumnHeadersDefaultCellStyle=dataGridViewCellStyle2;
            this.PersonGridView.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column9});
            this.PersonGridView.Location=new System.Drawing.Point(8, 9);
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
            this.PersonGridView.Size=new System.Drawing.Size(568, 324);
            this.PersonGridView.TabIndex=34;
            this.PersonGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonGridView_CellClick);
            this.PersonGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonGridView_CellDoubleClick);
            this.PersonGridView.CurrentCellChanged += new System.EventHandler(this.PersonGridView_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText="نام خانوادگی";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=140;
            // 
            // Column2
            // 
            this.Column2.HeaderText="نام";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            // 
            // Column3
            // 
            this.Column3.HeaderText="شماره پرسنلی";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=75;
            // 
            // Column6
            // 
            this.Column6.HeaderText="نوع شیفت";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=70;
            // 
            // Column7
            // 
            this.Column7.HeaderText="پست سازمانی";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Visible=false;
            // 
            // Column4
            // 
            this.Column4.HeaderText="نام شیفت";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode=System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText="مبدا";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            // 
            // Column9
            // 
            this.Column9.HeaderText="واحد";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Visible=false;
            // 
            // Label1
            // 
            this.Label1.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.ForeColor=System.Drawing.Color.Black;
            this.Label1.Location=new System.Drawing.Point(468, 349);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(107, 23);
            this.Label1.TabIndex=36;
            this.Label1.Text="نام خانوادگی:";
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor=System.Drawing.Color.Linen;
            this.SearchBox.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchBox.Location=new System.Drawing.Point(326, 349);
            this.SearchBox.Name="SearchBox";
            this.SearchBox.Size=new System.Drawing.Size(142, 23);
            this.SearchBox.TabIndex=0;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SelectButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.SelectButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SelectButton.Image=global::Metro_Operation.Properties.Resources.tick_main;
            this.SelectButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectButton.Location=new System.Drawing.Point(128, 346);
            this.SelectButton.Name="SelectButton";
            this.SelectButton.Size=new System.Drawing.Size(134, 28);
            this.SelectButton.TabIndex=37;
            this.SelectButton.Text="انتخاب";
            this.SelectButton.UseVisualStyleBackColor=false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.Cursor=System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DialogResult=System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources.return1;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location=new System.Drawing.Point(20, 346);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(96, 28);
            this.ExitButton.TabIndex=38;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            // 
            // PersonalSelectForm
            // 
            this.AcceptButton=this.SelectButton;
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(585, 390);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PersonGridView);
            this.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            this.Name="PersonalSelectForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="لیست راهبران";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalSelectForm_FormClosing);
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private Button SelectButton;
        private Button ExitButton;
        private DataGridView PersonGridView;
        private Label Label1;
        private TextBox SearchBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
    }
	
}
