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
    public
    partial class DetailShwoForm : BaseForm
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
            DataGridViewCellStyle DataGridViewCellStyle19=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle20=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle27=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle21=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle22=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle23=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle24=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle25=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle26=new DataGridViewCellStyle();
            this.DataGridView1=new DataGridView();
            base.Load += new System.EventHandler(DetailShwoForm_Load);
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.TitrLabel=new Label();
            this.Label2=new Label();
            this.UserLabel=new Label();
            this.TimeLabel=new Label();
            ((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
            this.SuspendLayout();
            //
            //DataGridView1
            //
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            DataGridViewCellStyle19.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle19;
            this.DataGridView1.BackgroundColor=System.Drawing.Color.Silver;
            DataGridViewCellStyle20.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle20.BackColor=System.Drawing.Color.Maroon;
            DataGridViewCellStyle20.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            DataGridViewCellStyle20.ForeColor=System.Drawing.Color.White;
            DataGridViewCellStyle20.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle20.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle20;
            this.DataGridView1.ColumnHeadersHeight=40;
            this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column3, this.Column4, this.Column5, this.Column8, this.Column6 });
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(11, 43);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            DataGridViewCellStyle27.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle27.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            DataGridViewCellStyle27.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle27.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle27.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.RowHeadersDefaultCellStyle=DataGridViewCellStyle27;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(1020, 372);
            this.DataGridView1.TabIndex=0;
            //
            //Column1
            //
            DataGridViewCellStyle21.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle=DataGridViewCellStyle21;
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            //
            //Column3
            //
            DataGridViewCellStyle22.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle=DataGridViewCellStyle22;
            this.Column3.HeaderText="نام و نام خانوادگی ";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=170;
            //
            //Column4
            //
            DataGridViewCellStyle23.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle=DataGridViewCellStyle23;
            this.Column4.HeaderText="ش پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=80;
            //
            //Column5
            //
            DataGridViewCellStyle24.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle=DataGridViewCellStyle24;
            this.Column5.HeaderText="تاریخ";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=85;
            //
            //Column8
            //
            this.Column8.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle25.Alignment=DataGridViewContentAlignment.MiddleLeft;
            this.Column8.DefaultCellStyle=DataGridViewCellStyle25;
            this.Column8.HeaderText="توضیحات";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            //
            //Column6
            //
            DataGridViewCellStyle26.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle=DataGridViewCellStyle26;
            this.Column6.HeaderText="کاربر";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=140;
            //
            //TitrLabel
            //
            this.TitrLabel.BorderStyle=BorderStyle.FixedSingle;
            this.TitrLabel.Font=new System.Drawing.Font("Tahoma", (float)(12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.TitrLabel.ForeColor=System.Drawing.Color.Yellow;
            this.TitrLabel.Location=new System.Drawing.Point(735, 7);
            this.TitrLabel.Name="TitrLabel";
            this.TitrLabel.Size=new System.Drawing.Size(295, 28);
            this.TitrLabel.TabIndex=1;
            this.TitrLabel.Text="عنوان گزارش";
            this.TitrLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //label2
            //
            this.Label2.BorderStyle=BorderStyle.FixedSingle;
            this.Label2.ForeColor=System.Drawing.Color.Yellow;
            this.Label2.Location=new System.Drawing.Point(202, 7);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(61, 28);
            this.Label2.TabIndex=2;
            this.Label2.Text="نام کاربر:";
            this.Label2.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //UserLabel
            //
            this.UserLabel.BorderStyle=BorderStyle.FixedSingle;
            this.UserLabel.ForeColor=System.Drawing.Color.Yellow;
            this.UserLabel.Location=new System.Drawing.Point(39, 7);
            this.UserLabel.Name="UserLabel";
            this.UserLabel.Size=new System.Drawing.Size(157, 28);
            this.UserLabel.TabIndex=3;
            this.UserLabel.Text="xxx";
            this.UserLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //TimeLabel
            //
            this.TimeLabel.BorderStyle=BorderStyle.FixedSingle;
            this.TimeLabel.Font=new System.Drawing.Font("Tahoma", (float)(11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.TimeLabel.ForeColor=System.Drawing.Color.White;
            this.TimeLabel.Location=new System.Drawing.Point(396, 7);
            this.TimeLabel.Name="TimeLabel";
            this.TimeLabel.Size=new System.Drawing.Size(244, 28);
            this.TimeLabel.TabIndex=4;
            this.TimeLabel.Text="تاریخ";
            this.TimeLabel.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //DetailShwoForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.Black;
            this.ClientSize=new System.Drawing.Size(1043, 421);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TitrLabel);
            this.Controls.Add(this.DataGridView1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="DetailShwoForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="گزارش جزئیات ";
            ((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
            this.ResumeLayout(false);

        }
        private DataGridView DataGridView1;
        internal Label TitrLabel;
        private Label Label2;
        internal Label UserLabel;
        internal Label TimeLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column6;
    }

}
