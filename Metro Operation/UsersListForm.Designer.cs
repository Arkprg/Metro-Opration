using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class UsersListForm : BaseForm
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
            this.DataGridView1=new DataGridView();
            base.Load += new System.EventHandler(Form16_Load);
            this.DataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
            this.SuspendLayout();
            //
            //DataGridView1
            //
            this.DataGridView1.AllowUserToAddRows=false;
            this.DataGridView1.AllowUserToDeleteRows=false;
            this.DataGridView1.AllowUserToResizeColumns=false;
            this.DataGridView1.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.DataGridView1.AlternatingRowsDefaultCellStyle=DataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersBorderStyle=DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.Color.Black;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.Color.Yellow;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight=40;
            this.DataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column10, this.Column1, this.Column2, this.Column3, this.Column4, this.Column5, this.Column6, this.Column7, this.Column8, this.Column9, this.Column11 });
            this.DataGridView1.Dock=DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles=false;
            this.DataGridView1.Location=new System.Drawing.Point(0, 0);
            this.DataGridView1.MultiSelect=false;
            this.DataGridView1.Name="DataGridView1";
            this.DataGridView1.ReadOnly=true;
            this.DataGridView1.RowHeadersVisible=false;
            this.DataGridView1.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView1.RowTemplate.ReadOnly=true;
            this.DataGridView1.RowTemplate.Resizable=DataGridViewTriState.False;
            this.DataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size=new System.Drawing.Size(1114, 527);
            this.DataGridView1.TabIndex=36;
            //
            //Column10
            //
            this.Column10.HeaderText="ردیف";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            this.Column10.Width=40;
            //
            //Column1
            //
            this.Column1.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText="نام کاربری";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            //
            //Column2
            //
            this.Column2.HeaderText="نام";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            this.Column2.Width=80;
            //
            //Column3
            //
            this.Column3.HeaderText="نام خانوادگی";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=120;
            //
            //Column4
            //
            this.Column4.HeaderText="شماره پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=70;
            //
            //Column5
            //
            this.Column5.HeaderText="سطح دسترسی";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            this.Column5.Width=150;
            //
            //Column6
            //
            this.Column6.HeaderText="تاریخ ساخت";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=135;
            //
            //Column7
            //
            this.Column7.HeaderText="آخرین تغییر";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=135;
            //
            //Column8
            //
            this.Column8.HeaderText="کاربر";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            //
            //Column9
            //
            this.Column9.HeaderText="آخرین ورود";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            this.Column9.Width=135;
            //
            //Column11
            //
            this.Column11.HeaderText="Acti";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Visible=false;
            //
            //UsersListForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(1114, 527);
            this.Controls.Add(this.DataGridView1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="UsersListForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="لسیت کاربران نرم افزار";
            ((System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
            this.ResumeLayout(false);

        }
        private DataGridView DataGridView1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
    }

}
