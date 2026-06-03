using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TripAnalyzeForm : BaseForm
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
            DataGridViewCellStyle DataGridViewCellStyle3=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle4=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle5=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle6=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle7=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle8=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle9=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle10=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle11=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle12=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle13=new DataGridViewCellStyle();
            DataGridViewCellStyle DataGridViewCellStyle14=new DataGridViewCellStyle();
            this.NameBox=new TextBox();
            this.ImportButton=new Button();
            this.ImportButton.Click += new System.EventHandler(this.NameButton_Click);
            this.Label1=new Label();
            this.Label2=new Label();
            this.UserNameLabel=new Label();
            this.LineLabel=new Label();
            this.Label5=new Label();
            this.DatabaseButton=new Button();
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
            this.DatabaseButton.EnabledChanged += new System.EventHandler(this.DatabaseButton_EnabledChanged);
            this.InternetButton=new Button();
            this.InternetButton.Click += new System.EventHandler(this.InternetButton_Click);
            this.TabControl1=new TabControl();
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            this.AllTab=new TabPage();
            this.ShowGridView=new DataGridView();
            this.DataGridViewTextBoxColumn1=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2=new DataGridViewTextBoxColumn();
            this.Column9=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4=new DataGridViewTextBoxColumn();
            this.Column2=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5=new DataGridViewTextBoxColumn();
            this.Column10=new DataGridViewTextBoxColumn();
            this.Column11=new DataGridViewTextBoxColumn();
            this.FaultTab=new TabPage();
            this.FaultGridView=new DataGridView();
            this.FaultGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.FaultGridView_CellDoubleClick);
            this.DataGridViewTextBoxColumn6=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14=new DataGridViewTextBoxColumn();
            this.Column12=new DataGridViewTextBoxColumn();
            this.OverTimeTab=new TabPage();
            this.OverTimeGrid=new DataGridView();
            this.DataGridViewTextBoxColumn25=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn26=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn27=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn28=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn33=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn30=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn31=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn32=new DataGridViewTextBoxColumn();
            this.Column16=new DataGridViewTextBoxColumn();
            this.LeaveTab=new TabPage();
            this.LeavGridView=new DataGridView();
            this.DataGridViewTextBoxColumn12=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18=new DataGridViewTextBoxColumn();
            this.TimeTab=new TabPage();
            this.TimeLeaveGridView=new DataGridView();
            this.DataGridViewTextBoxColumn29=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn34=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn35=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn36=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn37=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn38=new DataGridViewTextBoxColumn();
            this.Column15=new DataGridViewTextBoxColumn();
            this.ReservTab=new TabPage();
            this.ReservGridView=new DataGridView();
            this.DataGridViewTextBoxColumn19=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn20=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn21=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn22=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn23=new DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn24=new DataGridViewTextBoxColumn();
            this.TripTab=new TabPage();
            this.TripGridView=new DataGridView();
            this.Column1=new DataGridViewTextBoxColumn();
            this.Column5=new DataGridViewTextBoxColumn();
            this.Column13=new DataGridViewTextBoxColumn();
            this.Column4=new DataGridViewTextBoxColumn();
            this.Column3=new DataGridViewTextBoxColumn();
            this.Column6=new DataGridViewTextBoxColumn();
            this.Column7=new DataGridViewTextBoxColumn();
            this.Column8=new DataGridViewTextBoxColumn();
            this.Column14=new DataGridViewTextBoxColumn();
            this.Label3=new Label();
            this.DateLabel=new Label();
            this.Label4=new Label();
            this.FaltLabel=new Label();
            this.TripRegButton=new Button();
            this.TripRegButton.Click += new System.EventHandler(this.TripRegButton_Click);
            this.Label9=new Label();
            this.Shift2Label=new Label();
            this.Label7=new Label();
            this.Shift1Label=new Label();
            this.LastShiftLabel=new Label();
            this.Label8=new Label();
            this.SelectButton=new Button();
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            this.TabControl1.SuspendLayout();
            this.AllTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).BeginInit();
            this.FaultTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.FaultGridView).BeginInit();
            this.OverTimeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.OverTimeGrid).BeginInit();
            this.LeaveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.LeavGridView).BeginInit();
            this.TimeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.TimeLeaveGridView).BeginInit();
            this.ReservTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.ReservGridView).BeginInit();
            this.TripTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.TripGridView).BeginInit();
            this.SuspendLayout();
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Control;
            this.NameBox.Location=new System.Drawing.Point(750, 12);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.RightToLeft=RightToLeft.No;
            this.NameBox.Size=new System.Drawing.Size(179, 23);
            this.NameBox.TabIndex=44;
            this.NameBox.TabStop=false;
            //
            //ImportButton
            //
            this.ImportButton.Location=new System.Drawing.Point(555, 11);
            this.ImportButton.Name="ImportButton";
            this.ImportButton.Size=new System.Drawing.Size(98, 25);
            this.ImportButton.TabIndex=45;
            this.ImportButton.Text="تحلیل فایل";
            this.ImportButton.UseVisualStyleBackColor=true;
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(929, 15);
            this.Label1.Margin=new Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(55, 16);
            this.Label1.TabIndex=46;
            this.Label1.Text="نام فایل:";
            //
            //label2
            //
            this.Label2.Location=new System.Drawing.Point(477, 14);
            this.Label2.Margin=new Padding(4, 0, 4, 0);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(57, 18);
            this.Label2.TabIndex=48;
            this.Label2.Text="نام کاربر:";
            this.Label2.Visible=false;
            //
            //UserNameLabel
            //
            this.UserNameLabel.Location=new System.Drawing.Point(349, 14);
            this.UserNameLabel.Margin=new Padding(4, 0, 4, 0);
            this.UserNameLabel.Name="UserNameLabel";
            this.UserNameLabel.Size=new System.Drawing.Size(128, 18);
            this.UserNameLabel.TabIndex=49;
            this.UserNameLabel.Text="کاربر";
            this.UserNameLabel.Visible=false;
            //
            //LineLabel
            //
            this.LineLabel.Location=new System.Drawing.Point(41, 14);
            this.LineLabel.Margin=new Padding(4, 0, 4, 0);
            this.LineLabel.Name="LineLabel";
            this.LineLabel.Size=new System.Drawing.Size(55, 18);
            this.LineLabel.TabIndex=51;
            this.LineLabel.Text="خط";
            this.LineLabel.Visible=false;
            //
            //Label5
            //
            this.Label5.Location=new System.Drawing.Point(96, 14);
            this.Label5.Margin=new Padding(4, 0, 4, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(51, 18);
            this.Label5.TabIndex=50;
            this.Label5.Text="نام خط:";
            this.Label5.Visible=false;
            //
            //DatabaseButton
            //
            this.DatabaseButton.BackColor=System.Drawing.Color.Lime;
            this.DatabaseButton.Enabled=false;
            this.DatabaseButton.Location=new System.Drawing.Point(38, 562);
            this.DatabaseButton.Name="DatabaseButton";
            this.DatabaseButton.Size=new System.Drawing.Size(140, 32);
            this.DatabaseButton.TabIndex=0;
            this.DatabaseButton.Text="ذخیره";
            this.DatabaseButton.UseVisualStyleBackColor=false;
            //
            //InternetButton
            //
            this.InternetButton.Enabled=false;
            this.InternetButton.Location=new System.Drawing.Point(228, 562);
            this.InternetButton.Name="InternetButton";
            this.InternetButton.Size=new System.Drawing.Size(140, 32);
            this.InternetButton.TabIndex=54;
            this.InternetButton.Text="ارسال به اینترنت";
            this.InternetButton.UseVisualStyleBackColor=true;
            this.InternetButton.Visible=false;
            //
            //TabControl1
            //
            this.TabControl1.Controls.Add(this.AllTab);
            this.TabControl1.Controls.Add(this.FaultTab);
            this.TabControl1.Controls.Add(this.OverTimeTab);
            this.TabControl1.Controls.Add(this.LeaveTab);
            this.TabControl1.Controls.Add(this.TimeTab);
            this.TabControl1.Controls.Add(this.ReservTab);
            this.TabControl1.Controls.Add(this.TripTab);
            this.TabControl1.ItemSize=new System.Drawing.Size(95, 22);
            this.TabControl1.Location=new System.Drawing.Point(0, 49);
            this.TabControl1.Name="TabControl1";
            this.TabControl1.RightToLeftLayout=true;
            this.TabControl1.SelectedIndex=0;
            this.TabControl1.Size=new System.Drawing.Size(990, 500);
            this.TabControl1.SizeMode=TabSizeMode.Fixed;
            this.TabControl1.TabIndex=60;
            //
            //AllTab
            //
            this.AllTab.Controls.Add(this.ShowGridView);
            this.AllTab.Location=new System.Drawing.Point(4, 26);
            this.AllTab.Name="AllTab";
            this.AllTab.Size=new System.Drawing.Size(982, 470);
            this.AllTab.TabIndex=0;
            this.AllTab.Text="تحلیل کلی";
            //
            //ShowGridView
            //
            this.ShowGridView.AllowUserToAddRows=false;
            this.ShowGridView.AllowUserToDeleteRows=false;
            this.ShowGridView.AllowUserToResizeColumns=false;
            this.ShowGridView.AllowUserToResizeRows=false;
            DataGridViewCellStyle1.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle1.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle1;
            this.ShowGridView.ColumnHeadersHeight=28;
            this.ShowGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ShowGridView.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn1, this.DataGridViewTextBoxColumn2, this.Column9, this.DataGridViewTextBoxColumn3, this.DataGridViewTextBoxColumn4, this.Column2, this.DataGridViewTextBoxColumn5, this.Column10, this.Column11 });
            DataGridViewCellStyle2.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle2.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle2.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle2.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode=DataGridViewTriState.False;
            this.ShowGridView.DefaultCellStyle=DataGridViewCellStyle2;
            this.ShowGridView.Dock=DockStyle.Fill;
            this.ShowGridView.Location=new System.Drawing.Point(0, 0);
            this.ShowGridView.Name="ShowGridView";
            this.ShowGridView.ReadOnly=true;
            this.ShowGridView.RowHeadersVisible=false;
            this.ShowGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ShowGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ShowGridView.Size=new System.Drawing.Size(982, 470);
            this.ShowGridView.TabIndex=48;
            //
            //DataGridViewTextBoxColumn1
            //
            this.DataGridViewTextBoxColumn1.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn1.Name="DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly=true;
            this.DataGridViewTextBoxColumn1.Width=45;
            //
            //DataGridViewTextBoxColumn2
            //
            this.DataGridViewTextBoxColumn2.HeaderText="نام";
            this.DataGridViewTextBoxColumn2.Name="DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly=true;
            //
            //Column9
            //
            this.Column9.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText="نام خانوادگی";
            this.Column9.Name="Column9";
            this.Column9.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn3
            //
            this.DataGridViewTextBoxColumn3.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn3.Name="DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly=true;
            this.DataGridViewTextBoxColumn3.Width=80;
            //
            //DataGridViewTextBoxColumn4
            //
            this.DataGridViewTextBoxColumn4.HeaderText="شیفت ";
            this.DataGridViewTextBoxColumn4.Name="DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly=true;
            this.DataGridViewTextBoxColumn4.Width=130;
            //
            //Column2
            //
            this.Column2.HeaderText="مبدا";
            this.Column2.Name="Column2";
            this.Column2.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn5
            //
            this.DataGridViewTextBoxColumn5.HeaderText="تعداد حرکت";
            this.DataGridViewTextBoxColumn5.Name="DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly=true;
            this.DataGridViewTextBoxColumn5.Width=90;
            //
            //Column10
            //
            this.Column10.HeaderText="وضعیت";
            this.Column10.Name="Column10";
            this.Column10.ReadOnly=true;
            //
            //Column11
            //
            this.Column11.HeaderText="کارکرد";
            this.Column11.Name="Column11";
            this.Column11.ReadOnly=true;
            this.Column11.Width=90;
            //
            //FaultTab
            //
            this.FaultTab.Controls.Add(this.FaultGridView);
            this.FaultTab.Location=new System.Drawing.Point(4, 26);
            this.FaultTab.Name="FaultTab";
            this.FaultTab.Size=new System.Drawing.Size(982, 470);
            this.FaultTab.TabIndex=5;
            this.FaultTab.Text="عدم انطباق";
            this.FaultTab.UseVisualStyleBackColor=true;
            //
            //FaultGridView
            //
            this.FaultGridView.AllowUserToAddRows=false;
            this.FaultGridView.AllowUserToDeleteRows=false;
            this.FaultGridView.ClipboardCopyMode=DataGridViewClipboardCopyMode.Disable;
            DataGridViewCellStyle3.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle3.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle3.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode=DataGridViewTriState.False;
            this.FaultGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle3;
            this.FaultGridView.ColumnHeadersHeight=28;
            this.FaultGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FaultGridView.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn6, this.DataGridViewTextBoxColumn7, this.DataGridViewTextBoxColumn8, this.DataGridViewTextBoxColumn9, this.DataGridViewTextBoxColumn10, this.DataGridViewTextBoxColumn11, this.DataGridViewTextBoxColumn14, this.Column12 });
            DataGridViewCellStyle4.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle4.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle4.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle4.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle4.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode=DataGridViewTriState.False;
            this.FaultGridView.DefaultCellStyle=DataGridViewCellStyle4;
            this.FaultGridView.Dock=DockStyle.Fill;
            this.FaultGridView.Location=new System.Drawing.Point(0, 0);
            this.FaultGridView.Name="FaultGridView";
            this.FaultGridView.ReadOnly=true;
            this.FaultGridView.RowHeadersVisible=false;
            this.FaultGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FaultGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.FaultGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.FaultGridView.Size=new System.Drawing.Size(982, 470);
            this.FaultGridView.TabIndex=49;
            //
            //DataGridViewTextBoxColumn6
            //
            this.DataGridViewTextBoxColumn6.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn6.Name="DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly=true;
            this.DataGridViewTextBoxColumn6.Width=45;
            //
            //DataGridViewTextBoxColumn7
            //
            this.DataGridViewTextBoxColumn7.HeaderText="نام";
            this.DataGridViewTextBoxColumn7.Name="DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn8
            //
            this.DataGridViewTextBoxColumn8.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn8.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn8.Name="DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn9
            //
            this.DataGridViewTextBoxColumn9.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn9.Name="DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly=true;
            this.DataGridViewTextBoxColumn9.Width=80;
            //
            //DataGridViewTextBoxColumn10
            //
            this.DataGridViewTextBoxColumn10.HeaderText="شیفت ";
            this.DataGridViewTextBoxColumn10.Name="DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly=true;
            this.DataGridViewTextBoxColumn10.Width=130;
            //
            //DataGridViewTextBoxColumn11
            //
            this.DataGridViewTextBoxColumn11.HeaderText="مبدا";
            this.DataGridViewTextBoxColumn11.Name="DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn14
            //
            this.DataGridViewTextBoxColumn14.HeaderText="توضیحات";
            this.DataGridViewTextBoxColumn14.Name="DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly=true;
            this.DataGridViewTextBoxColumn14.Width=260;
            //
            //Column12
            //
            this.Column12.HeaderText="ID";
            this.Column12.Name="Column12";
            this.Column12.ReadOnly=true;
            this.Column12.Visible=false;
            //
            //OverTimeTab
            //
            this.OverTimeTab.Controls.Add(this.OverTimeGrid);
            this.OverTimeTab.Location=new System.Drawing.Point(4, 26);
            this.OverTimeTab.Name="OverTimeTab";
            this.OverTimeTab.Size=new System.Drawing.Size(982, 470);
            this.OverTimeTab.TabIndex=6;
            this.OverTimeTab.Text="اضافه کار";
            this.OverTimeTab.UseVisualStyleBackColor=true;
            //
            //OverTimeGrid
            //
            this.OverTimeGrid.AllowUserToAddRows=false;
            this.OverTimeGrid.AllowUserToDeleteRows=false;
            this.OverTimeGrid.ClipboardCopyMode=DataGridViewClipboardCopyMode.Disable;
            DataGridViewCellStyle5.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle5.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle5.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle5.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle5.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode=DataGridViewTriState.False;
            this.OverTimeGrid.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle5;
            this.OverTimeGrid.ColumnHeadersHeight=28;
            this.OverTimeGrid.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OverTimeGrid.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn25, this.DataGridViewTextBoxColumn26, this.DataGridViewTextBoxColumn27, this.DataGridViewTextBoxColumn28, this.DataGridViewTextBoxColumn33, this.DataGridViewTextBoxColumn30, this.DataGridViewTextBoxColumn31, this.DataGridViewTextBoxColumn32, this.Column16 });
            DataGridViewCellStyle6.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle6.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle6.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle6.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle6.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle6.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode=DataGridViewTriState.False;
            this.OverTimeGrid.DefaultCellStyle=DataGridViewCellStyle6;
            this.OverTimeGrid.Dock=DockStyle.Fill;
            this.OverTimeGrid.Location=new System.Drawing.Point(0, 0);
            this.OverTimeGrid.Name="OverTimeGrid";
            this.OverTimeGrid.ReadOnly=true;
            this.OverTimeGrid.RowHeadersVisible=false;
            this.OverTimeGrid.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OverTimeGrid.RowTemplate.Resizable=DataGridViewTriState.False;
            this.OverTimeGrid.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.OverTimeGrid.Size=new System.Drawing.Size(982, 470);
            this.OverTimeGrid.TabIndex=49;
            //
            //DataGridViewTextBoxColumn25
            //
            this.DataGridViewTextBoxColumn25.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn25.Name="DataGridViewTextBoxColumn25";
            this.DataGridViewTextBoxColumn25.ReadOnly=true;
            this.DataGridViewTextBoxColumn25.Width=45;
            //
            //DataGridViewTextBoxColumn26
            //
            this.DataGridViewTextBoxColumn26.HeaderText="نام";
            this.DataGridViewTextBoxColumn26.Name="DataGridViewTextBoxColumn26";
            this.DataGridViewTextBoxColumn26.ReadOnly=true;
            this.DataGridViewTextBoxColumn26.Width=85;
            //
            //DataGridViewTextBoxColumn27
            //
            this.DataGridViewTextBoxColumn27.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn27.Name="DataGridViewTextBoxColumn27";
            this.DataGridViewTextBoxColumn27.ReadOnly=true;
            this.DataGridViewTextBoxColumn27.Width=140;
            //
            //DataGridViewTextBoxColumn28
            //
            this.DataGridViewTextBoxColumn28.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn28.Name="DataGridViewTextBoxColumn28";
            this.DataGridViewTextBoxColumn28.ReadOnly=true;
            this.DataGridViewTextBoxColumn28.Width=70;
            //
            //DataGridViewTextBoxColumn33
            //
            this.DataGridViewTextBoxColumn33.HeaderText="مدت";
            this.DataGridViewTextBoxColumn33.Name="DataGridViewTextBoxColumn33";
            this.DataGridViewTextBoxColumn33.ReadOnly=true;
            this.DataGridViewTextBoxColumn33.Width=65;
            //
            //DataGridViewTextBoxColumn30
            //
            this.DataGridViewTextBoxColumn30.HeaderText="مبدا";
            this.DataGridViewTextBoxColumn30.Name="DataGridViewTextBoxColumn30";
            this.DataGridViewTextBoxColumn30.ReadOnly=true;
            this.DataGridViewTextBoxColumn30.Width=90;
            //
            //DataGridViewTextBoxColumn31
            //
            this.DataGridViewTextBoxColumn31.HeaderText="تعداد حرکت";
            this.DataGridViewTextBoxColumn31.Name="DataGridViewTextBoxColumn31";
            this.DataGridViewTextBoxColumn31.ReadOnly=true;
            this.DataGridViewTextBoxColumn31.Width=80;
            //
            //DataGridViewTextBoxColumn32
            //
            this.DataGridViewTextBoxColumn32.HeaderText="توضیحات";
            this.DataGridViewTextBoxColumn32.Name="DataGridViewTextBoxColumn32";
            this.DataGridViewTextBoxColumn32.ReadOnly=true;
            this.DataGridViewTextBoxColumn32.Width=350;
            //
            //Column16
            //
            this.Column16.HeaderText="کاربر";
            this.Column16.Name="Column16";
            this.Column16.ReadOnly=true;
            //
            //LeaveTab
            //
            this.LeaveTab.Controls.Add(this.LeavGridView);
            this.LeaveTab.Location=new System.Drawing.Point(4, 26);
            this.LeaveTab.Name="LeaveTab";
            this.LeaveTab.Size=new System.Drawing.Size(982, 470);
            this.LeaveTab.TabIndex=2;
            this.LeaveTab.Text="مرخصی روزانه";
            this.LeaveTab.UseVisualStyleBackColor=true;
            //
            //LeavGridView
            //
            this.LeavGridView.AllowUserToAddRows=false;
            this.LeavGridView.AllowUserToDeleteRows=false;
            this.LeavGridView.ClipboardCopyMode=DataGridViewClipboardCopyMode.Disable;
            DataGridViewCellStyle7.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle7.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle7.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle7.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode=DataGridViewTriState.False;
            this.LeavGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle7;
            this.LeavGridView.ColumnHeadersHeight=28;
            this.LeavGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LeavGridView.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn12, this.DataGridViewTextBoxColumn13, this.DataGridViewTextBoxColumn15, this.DataGridViewTextBoxColumn16, this.DataGridViewTextBoxColumn17, this.DataGridViewTextBoxColumn18 });
            DataGridViewCellStyle8.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle8.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle8.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle8.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle8.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode=DataGridViewTriState.False;
            this.LeavGridView.DefaultCellStyle=DataGridViewCellStyle8;
            this.LeavGridView.Dock=DockStyle.Fill;
            this.LeavGridView.Location=new System.Drawing.Point(0, 0);
            this.LeavGridView.Name="LeavGridView";
            this.LeavGridView.ReadOnly=true;
            this.LeavGridView.RowHeadersVisible=false;
            this.LeavGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LeavGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.LeavGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.LeavGridView.Size=new System.Drawing.Size(982, 470);
            this.LeavGridView.TabIndex=50;
            //
            //DataGridViewTextBoxColumn12
            //
            this.DataGridViewTextBoxColumn12.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn12.Name="DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly=true;
            this.DataGridViewTextBoxColumn12.Width=45;
            //
            //DataGridViewTextBoxColumn13
            //
            this.DataGridViewTextBoxColumn13.HeaderText="نام";
            this.DataGridViewTextBoxColumn13.Name="DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly=true;
            this.DataGridViewTextBoxColumn13.Width=120;
            //
            //DataGridViewTextBoxColumn15
            //
            this.DataGridViewTextBoxColumn15.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn15.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn15.Name="DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn16
            //
            this.DataGridViewTextBoxColumn16.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn16.Name="DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn17
            //
            this.DataGridViewTextBoxColumn17.HeaderText="شیفت ";
            this.DataGridViewTextBoxColumn17.Name="DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.ReadOnly=true;
            this.DataGridViewTextBoxColumn17.Width=160;
            //
            //DataGridViewTextBoxColumn18
            //
            this.DataGridViewTextBoxColumn18.HeaderText="مبدا";
            this.DataGridViewTextBoxColumn18.Name="DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.ReadOnly=true;
            this.DataGridViewTextBoxColumn18.Width=140;
            //
            //TimeTab
            //
            this.TimeTab.Controls.Add(this.TimeLeaveGridView);
            this.TimeTab.Location=new System.Drawing.Point(4, 26);
            this.TimeTab.Name="TimeTab";
            this.TimeTab.Size=new System.Drawing.Size(982, 470);
            this.TimeTab.TabIndex=7;
            this.TimeTab.Text="مرخصی ساعتی";
            this.TimeTab.UseVisualStyleBackColor=true;
            //
            //TimeLeaveGridView
            //
            this.TimeLeaveGridView.AllowUserToAddRows=false;
            this.TimeLeaveGridView.AllowUserToDeleteRows=false;
            this.TimeLeaveGridView.ClipboardCopyMode=DataGridViewClipboardCopyMode.Disable;
            DataGridViewCellStyle9.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle9.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle9.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle9.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle9.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode=DataGridViewTriState.False;
            this.TimeLeaveGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle9;
            this.TimeLeaveGridView.ColumnHeadersHeight=28;
            this.TimeLeaveGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TimeLeaveGridView.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn29, this.DataGridViewTextBoxColumn34, this.DataGridViewTextBoxColumn35, this.DataGridViewTextBoxColumn36, this.DataGridViewTextBoxColumn37, this.DataGridViewTextBoxColumn38, this.Column15 });
            DataGridViewCellStyle10.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle10.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle10.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle10.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle10.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle10.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode=DataGridViewTriState.False;
            this.TimeLeaveGridView.DefaultCellStyle=DataGridViewCellStyle10;
            this.TimeLeaveGridView.Dock=DockStyle.Fill;
            this.TimeLeaveGridView.Location=new System.Drawing.Point(0, 0);
            this.TimeLeaveGridView.Name="TimeLeaveGridView";
            this.TimeLeaveGridView.ReadOnly=true;
            this.TimeLeaveGridView.RowHeadersVisible=false;
            this.TimeLeaveGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TimeLeaveGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.TimeLeaveGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.TimeLeaveGridView.Size=new System.Drawing.Size(982, 470);
            this.TimeLeaveGridView.TabIndex=51;
            //
            //DataGridViewTextBoxColumn29
            //
            this.DataGridViewTextBoxColumn29.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn29.Name="DataGridViewTextBoxColumn29";
            this.DataGridViewTextBoxColumn29.ReadOnly=true;
            this.DataGridViewTextBoxColumn29.Width=45;
            //
            //DataGridViewTextBoxColumn34
            //
            this.DataGridViewTextBoxColumn34.HeaderText="نام";
            this.DataGridViewTextBoxColumn34.Name="DataGridViewTextBoxColumn34";
            this.DataGridViewTextBoxColumn34.ReadOnly=true;
            this.DataGridViewTextBoxColumn34.Width=110;
            //
            //DataGridViewTextBoxColumn35
            //
            this.DataGridViewTextBoxColumn35.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn35.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn35.Name="DataGridViewTextBoxColumn35";
            this.DataGridViewTextBoxColumn35.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn36
            //
            this.DataGridViewTextBoxColumn36.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn36.Name="DataGridViewTextBoxColumn36";
            this.DataGridViewTextBoxColumn36.ReadOnly=true;
            this.DataGridViewTextBoxColumn36.Width=90;
            //
            //DataGridViewTextBoxColumn37
            //
            this.DataGridViewTextBoxColumn37.HeaderText="شیفت ";
            this.DataGridViewTextBoxColumn37.Name="DataGridViewTextBoxColumn37";
            this.DataGridViewTextBoxColumn37.ReadOnly=true;
            this.DataGridViewTextBoxColumn37.Width=140;
            //
            //DataGridViewTextBoxColumn38
            //
            this.DataGridViewTextBoxColumn38.HeaderText="مبدا";
            this.DataGridViewTextBoxColumn38.Name="DataGridViewTextBoxColumn38";
            this.DataGridViewTextBoxColumn38.ReadOnly=true;
            this.DataGridViewTextBoxColumn38.Width=120;
            //
            //Column15
            //
            this.Column15.HeaderText="مدت";
            this.Column15.Name="Column15";
            this.Column15.ReadOnly=true;
            this.Column15.Width=120;
            //
            //ReservTab
            //
            this.ReservTab.Controls.Add(this.ReservGridView);
            this.ReservTab.Location=new System.Drawing.Point(4, 26);
            this.ReservTab.Name="ReservTab";
            this.ReservTab.Size=new System.Drawing.Size(982, 470);
            this.ReservTab.TabIndex=3;
            this.ReservTab.Text="راهبران رزرو";
            this.ReservTab.UseVisualStyleBackColor=true;
            //
            //ReservGridView
            //
            this.ReservGridView.AllowUserToAddRows=false;
            this.ReservGridView.AllowUserToDeleteRows=false;
            this.ReservGridView.ClipboardCopyMode=DataGridViewClipboardCopyMode.Disable;
            DataGridViewCellStyle11.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle11.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle11.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle11.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle11.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode=DataGridViewTriState.False;
            this.ReservGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle11;
            this.ReservGridView.ColumnHeadersHeight=28;
            this.ReservGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReservGridView.Columns.AddRange(new DataGridViewColumn[] { this.DataGridViewTextBoxColumn19, this.DataGridViewTextBoxColumn20, this.DataGridViewTextBoxColumn21, this.DataGridViewTextBoxColumn22, this.DataGridViewTextBoxColumn23, this.DataGridViewTextBoxColumn24 });
            DataGridViewCellStyle12.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle12.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle12.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle12.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle12.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle12.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode=DataGridViewTriState.False;
            this.ReservGridView.DefaultCellStyle=DataGridViewCellStyle12;
            this.ReservGridView.Dock=DockStyle.Fill;
            this.ReservGridView.Location=new System.Drawing.Point(0, 0);
            this.ReservGridView.Name="ReservGridView";
            this.ReservGridView.ReadOnly=true;
            this.ReservGridView.RowHeadersVisible=false;
            this.ReservGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReservGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.ReservGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.ReservGridView.Size=new System.Drawing.Size(982, 470);
            this.ReservGridView.TabIndex=51;
            //
            //DataGridViewTextBoxColumn19
            //
            this.DataGridViewTextBoxColumn19.HeaderText="ردیف";
            this.DataGridViewTextBoxColumn19.Name="DataGridViewTextBoxColumn19";
            this.DataGridViewTextBoxColumn19.ReadOnly=true;
            this.DataGridViewTextBoxColumn19.Width=45;
            //
            //DataGridViewTextBoxColumn20
            //
            this.DataGridViewTextBoxColumn20.HeaderText="نام";
            this.DataGridViewTextBoxColumn20.Name="DataGridViewTextBoxColumn20";
            this.DataGridViewTextBoxColumn20.ReadOnly=true;
            this.DataGridViewTextBoxColumn20.Width=110;
            //
            //DataGridViewTextBoxColumn21
            //
            this.DataGridViewTextBoxColumn21.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn21.HeaderText="نام خانوادگی";
            this.DataGridViewTextBoxColumn21.Name="DataGridViewTextBoxColumn21";
            this.DataGridViewTextBoxColumn21.ReadOnly=true;
            //
            //DataGridViewTextBoxColumn22
            //
            this.DataGridViewTextBoxColumn22.HeaderText="پرسنلی";
            this.DataGridViewTextBoxColumn22.Name="DataGridViewTextBoxColumn22";
            this.DataGridViewTextBoxColumn22.ReadOnly=true;
            this.DataGridViewTextBoxColumn22.Width=90;
            //
            //DataGridViewTextBoxColumn23
            //
            this.DataGridViewTextBoxColumn23.HeaderText="شیفت ";
            this.DataGridViewTextBoxColumn23.Name="DataGridViewTextBoxColumn23";
            this.DataGridViewTextBoxColumn23.ReadOnly=true;
            this.DataGridViewTextBoxColumn23.Width=150;
            //
            //DataGridViewTextBoxColumn24
            //
            this.DataGridViewTextBoxColumn24.HeaderText="مبدا";
            this.DataGridViewTextBoxColumn24.Name="DataGridViewTextBoxColumn24";
            this.DataGridViewTextBoxColumn24.ReadOnly=true;
            this.DataGridViewTextBoxColumn24.Width=130;
            //
            //TripTab
            //
            this.TripTab.Controls.Add(this.TripGridView);
            this.TripTab.Location=new System.Drawing.Point(4, 26);
            this.TripTab.Name="TripTab";
            this.TripTab.Size=new System.Drawing.Size(982, 470);
            this.TripTab.TabIndex=1;
            this.TripTab.Text="جزئیات تریپ";
            this.TripTab.UseVisualStyleBackColor=true;
            //
            //TripGridView
            //
            this.TripGridView.AllowUserToAddRows=false;
            this.TripGridView.AllowUserToDeleteRows=false;
            this.TripGridView.ClipboardCopyMode=DataGridViewClipboardCopyMode.Disable;
            DataGridViewCellStyle13.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle13.BackColor=System.Drawing.SystemColors.Control;
            DataGridViewCellStyle13.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle13.ForeColor=System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle13.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle13.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle13.WrapMode=DataGridViewTriState.False;
            this.TripGridView.ColumnHeadersDefaultCellStyle=DataGridViewCellStyle13;
            this.TripGridView.ColumnHeadersHeight=28;
            this.TripGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TripGridView.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column5, this.Column13, this.Column4, this.Column3, this.Column6, this.Column7, this.Column8, this.Column14 });
            DataGridViewCellStyle14.Alignment=DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle14.BackColor=System.Drawing.SystemColors.Window;
            DataGridViewCellStyle14.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            DataGridViewCellStyle14.ForeColor=System.Drawing.SystemColors.ControlText;
            DataGridViewCellStyle14.SelectionBackColor=System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle14.SelectionForeColor=System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode=DataGridViewTriState.False;
            this.TripGridView.DefaultCellStyle=DataGridViewCellStyle14;
            this.TripGridView.Dock=DockStyle.Fill;
            this.TripGridView.Location=new System.Drawing.Point(0, 0);
            this.TripGridView.Name="TripGridView";
            this.TripGridView.ReadOnly=true;
            this.TripGridView.RowHeadersVisible=false;
            this.TripGridView.RowHeadersWidthSizeMode=DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TripGridView.RowTemplate.Resizable=DataGridViewTriState.False;
            this.TripGridView.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            this.TripGridView.Size=new System.Drawing.Size(982, 470);
            this.TripGridView.TabIndex=48;
            //
            //Column1
            //
            this.Column1.HeaderText="ردیف";
            this.Column1.Name="Column1";
            this.Column1.ReadOnly=true;
            this.Column1.Width=45;
            //
            //Column5
            //
            this.Column5.HeaderText="نام";
            this.Column5.Name="Column5";
            this.Column5.ReadOnly=true;
            //
            //Column13
            //
            this.Column13.AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText="نام خانوادگی";
            this.Column13.Name="Column13";
            this.Column13.ReadOnly=true;
            //
            //Column4
            //
            this.Column4.HeaderText="پرسنلی";
            this.Column4.Name="Column4";
            this.Column4.ReadOnly=true;
            this.Column4.Width=80;
            //
            //Column3
            //
            this.Column3.HeaderText="ساعت اعزام";
            this.Column3.Name="Column3";
            this.Column3.ReadOnly=true;
            this.Column3.Width=110;
            //
            //Column6
            //
            this.Column6.HeaderText="مبدا";
            this.Column6.Name="Column6";
            this.Column6.ReadOnly=true;
            this.Column6.Width=115;
            //
            //Column7
            //
            this.Column7.HeaderText="مقصد";
            this.Column7.Name="Column7";
            this.Column7.ReadOnly=true;
            this.Column7.Width=115;
            //
            //Column8
            //
            this.Column8.HeaderText="نوع اعزام";
            this.Column8.Name="Column8";
            this.Column8.ReadOnly=true;
            this.Column8.Width=125;
            //
            //Column14
            //
            this.Column14.HeaderText="تاریخ اعزام";
            this.Column14.Name="Column14";
            this.Column14.ReadOnly=true;
            this.Column14.Visible=false;
            this.Column14.Width=120;
            //
            //Label3
            //
            this.Label3.Location=new System.Drawing.Point(264, 14);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(39, 18);
            this.Label3.TabIndex=57;
            this.Label3.Text="تاریخ:";
            this.Label3.Visible=false;
            //
            //DateLabel
            //
            this.DateLabel.Location=new System.Drawing.Point(184, 14);
            this.DateLabel.Name="DateLabel";
            this.DateLabel.Size=new System.Drawing.Size(80, 18);
            this.DateLabel.TabIndex=58;
            this.DateLabel.Text="0000/00/00";
            this.DateLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DateLabel.Visible=false;
            //
            //Label4
            //
            this.Label4.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.Label4.Location=new System.Drawing.Point(45, 46);
            this.Label4.Margin=new Padding(4, 0, 4, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(108, 23);
            this.Label4.TabIndex=59;
            this.Label4.Text="عدم انطباق:";
            this.Label4.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            this.Label4.Visible=false;
            //
            //FaltLabel
            //
            this.FaltLabel.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(90)), System.Convert.ToInt32(System.Convert.ToByte(90)));
            this.FaltLabel.Location=new System.Drawing.Point(11, 46);
            this.FaltLabel.Margin=new Padding(4, 0, 4, 0);
            this.FaltLabel.Name="FaltLabel";
            this.FaltLabel.Size=new System.Drawing.Size(34, 23);
            this.FaltLabel.TabIndex=60;
            this.FaltLabel.Text="0";
            this.FaltLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.FaltLabel.Visible=false;
            //
            //TripRegButton
            //
            this.TripRegButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(192)));
            this.TripRegButton.Location=new System.Drawing.Point(408, 562);
            this.TripRegButton.Name="TripRegButton";
            this.TripRegButton.Size=new System.Drawing.Size(140, 32);
            this.TripRegButton.TabIndex=61;
            this.TripRegButton.Text="ثبت تریپ";
            this.TripRegButton.UseVisualStyleBackColor=false;
            this.TripRegButton.Visible=false;
            //
            //Label9
            //
            this.Label9.AutoSize=true;
            this.Label9.Location=new System.Drawing.Point(868, 580);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(79, 16);
            this.Label9.TabIndex=62;
            this.Label9.Text="شیفت شب:";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //Shift2Label
            //
            this.Shift2Label.Location=new System.Drawing.Point(823, 579);
            this.Shift2Label.Name="Shift2Label";
            this.Shift2Label.Size=new System.Drawing.Size(45, 18);
            this.Shift2Label.TabIndex=64;
            this.Shift2Label.Text=" - ";
            this.Shift2Label.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Location=new System.Drawing.Point(868, 557);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(69, 16);
            this.Label7.TabIndex=63;
            this.Label7.Text="شیفت روز:";
            this.Label7.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //Shift1Label
            //
            this.Shift1Label.Location=new System.Drawing.Point(823, 557);
            this.Shift1Label.Name="Shift1Label";
            this.Shift1Label.Size=new System.Drawing.Size(45, 18);
            this.Shift1Label.TabIndex=65;
            this.Shift1Label.Text=" - ";
            this.Shift1Label.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //LastShiftLabel
            //
            this.LastShiftLabel.Location=new System.Drawing.Point(631, 569);
            this.LastShiftLabel.Name="LastShiftLabel";
            this.LastShiftLabel.Size=new System.Drawing.Size(45, 18);
            this.LastShiftLabel.TabIndex=64;
            this.LastShiftLabel.Text=" - ";
            this.LastShiftLabel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.Location=new System.Drawing.Point(676, 570);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(102, 16);
            this.Label8.TabIndex=62;
            this.Label8.Text="شیفت شب قبل:";
            this.Label8.TextAlign=System.Drawing.ContentAlignment.MiddleRight;
            //
            //SelectButton
            //
            this.SelectButton.Image=global::Metro_Operation.Properties.Resources.docs_24;
            this.SelectButton.BackgroundImageLayout=ImageLayout.Stretch;
            this.SelectButton.Location=new System.Drawing.Point(724, 11);
            this.SelectButton.Name="SelectButton";
            this.SelectButton.Size=new System.Drawing.Size(25, 25);
            this.SelectButton.TabIndex=66;
            this.SelectButton.UseVisualStyleBackColor=true;
            //
            //TripAnalyzeForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.ClientSize=new System.Drawing.Size(991, 604);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.LastShiftLabel);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Shift2Label);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Shift1Label);
            this.Controls.Add(this.TripRegButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.FaltLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.InternetButton);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LineLabel);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TripAnalyzeForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="تحلیل لوحه اعزام";
            this.TabControl1.ResumeLayout(false);
            this.AllTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.ShowGridView).EndInit();
            this.FaultTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.FaultGridView).EndInit();
            this.OverTimeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.OverTimeGrid).EndInit();
            this.LeaveTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.LeavGridView).EndInit();
            this.TimeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.TimeLeaveGridView).EndInit();
            this.ReservTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.ReservGridView).EndInit();
            this.TripTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.TripGridView).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private TextBox NameBox;
        private Button ImportButton;
        private Label Label1;
        private Label Label2;
        private Label UserNameLabel;
        private Label LineLabel;
        private Label Label5;
        private Button DatabaseButton;
        private Button InternetButton;
        private TabControl TabControl1;
        private TabPage AllTab;
        private TabPage TripTab;
        private DataGridView ShowGridView;
        private DataGridView TripGridView;
        private Label Label3;
        private Label DateLabel;
        private Label Label4;
        private Label FaltLabel;
        private TabPage LeaveTab;
        private TabPage ReservTab;
        private TabPage FaultTab;
        private DataGridView FaultGridView;
        private DataGridView LeavGridView;
        private DataGridView ReservGridView;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn24;
        private Button TripRegButton;
        private TabPage OverTimeTab;
        private DataGridView OverTimeGrid;
        private TabPage TimeTab;
        private DataGridView TimeLeaveGridView;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn Column16;
        private Label Label9;
        private Label Shift2Label;
        private Label Label7;
        private Label Shift1Label;
        private Label LastShiftLabel;
        private Label Label8;
        private Button SelectButton;
    }

}
