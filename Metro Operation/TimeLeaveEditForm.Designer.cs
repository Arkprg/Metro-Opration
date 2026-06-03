using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class TimeLeaveEditForm : BaseForm
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
            this.components=new System.ComponentModel.Container();
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(TimeLeaveEditForm_HelpButtonClicked);
            base.Load += new System.EventHandler(Form20_Load);
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(TimeLeaveEditForm));
            this.NameBox=new TextBox();
            this.NameButton=new Button();
            this.NameButton.Click += new System.EventHandler(this.Button7_Click);
            this.SearchButton=new Button();
            this.SearchButton.Click += new System.EventHandler(this.Button5_Click);
            this.Label3=new Label();
            this.Label1=new Label();
            this.ExitButton=new Button();
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.DeletButton=new Button();
            this.DeletButton.Click += new System.EventHandler(this.Button6_Click);
            this.ReleaseNameBox=new TextBox();
            this.ReleaseNameButton=new Button();
            this.ReleaseNameButton.Click += new System.EventHandler(this.ReleaseNameButton_Click);
            this.Label5=new Label();
            this.ReplaceCombo=new ComboBox();
            this.ReplaceCombo.SelectedIndexChanged += new System.EventHandler(this.ReplaceCombo_SelectedIndexChanged);
            this.Label2=new Label();
            this.EndBox=new MaskedTextBox();
            this.StartBox=new MaskedTextBox();
            this.StartBox.TextChanged += new System.EventHandler(this.MaskedTextBox1_TextChanged);
            this.StartBox.Leave += new System.EventHandler(this.StartBox_Leave);
            this.Label8=new Label();
            this.Label7=new Label();
            this.Label4=new Label();
            this.MemBox=new RichTextBox();
            this.Panel1=new Panel();
            this.PersianCalendar=new BPersianCalender.BPersianCalenderTextBox();
            this.PersianCalendar.TextChanged += new System.EventHandler(this.PersianCalendar_TextChanged);
            this.Panel2=new Panel();
            this.Label6=new Label();
            this.Panel3=new Panel();
            this.Label9=new Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            //
            //NameBox
            //
            this.NameBox.BackColor=System.Drawing.SystemColors.Window;
            this.NameBox.Location=new System.Drawing.Point(302, 14);
            this.NameBox.Name="NameBox";
            this.NameBox.ReadOnly=true;
            this.NameBox.Size=new System.Drawing.Size(125, 23);
            this.NameBox.TabIndex=39;
            //
            //NameButton
            //
            this.NameButton.Image=(System.Drawing.Image)(resources.GetObject("NameButton.Image"));
            this.NameButton.Location=new System.Drawing.Point(273, 13);
            this.NameButton.Name="NameButton";
            this.NameButton.Size=new System.Drawing.Size(30, 25);
            this.NameButton.TabIndex=1;
            this.NameButton.UseVisualStyleBackColor=true;
            //
            //SearchButton
            //
            this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Cursor=Cursors.Hand;

            this.SearchButton.Location=new System.Drawing.Point(20, 13);
            this.SearchButton.Margin=new Padding(4, 5, 4, 5);
            this.SearchButton.Name="SearchButton";
            this.SearchButton.Size=new System.Drawing.Size(167, 55);
            this.SearchButton.TabIndex=3;
            this.SearchButton.Text="جستجو";
            this.SearchButton.UseVisualStyleBackColor=false;
            //
            //Label3
            //
            this.Label3.AutoSize=true;
            this.Label3.Location=new System.Drawing.Point(427, 48);
            this.Label3.Margin=new Padding(4, 0, 4, 0);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(43, 16);
            this.Label3.TabIndex=37;
            this.Label3.Text="تاریخ :";
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(427, 17);
            this.Label1.Margin=new Padding(4, 0, 4, 0);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(33, 16);
            this.Label1.TabIndex=35;
            this.Label1.Text="نام :";
            //
            //ExitButton
            //
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.None;
            this.ExitButton.Location=new System.Drawing.Point(22, 14);
            this.ExitButton.Margin=new Padding(4, 5, 4, 5);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(89, 34);
            this.ExitButton.TabIndex=3;
            this.ExitButton.Text="     انصراف ";
            this.ExitButton.UseVisualStyleBackColor=false;
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;

            this.RegButton.Enabled=false;
            this.RegButton.Location=new System.Drawing.Point(314, 14);
            this.RegButton.Margin=new Padding(4, 5, 4, 5);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(161, 34);
            this.RegButton.TabIndex=1;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //DeletButton
            //
            this.DeletButton.BackColor=System.Drawing.Color.DarkSalmon;
            this.DeletButton.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
            this.DeletButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletButton.Cursor=Cursors.Hand;

            this.DeletButton.Enabled=false;
            this.DeletButton.Location=new System.Drawing.Point(145, 14);
            this.DeletButton.Margin=new Padding(4, 5, 4, 5);
            this.DeletButton.Name="DeletButton";
            this.DeletButton.Size=new System.Drawing.Size(161, 34);
            this.DeletButton.TabIndex=2;
            this.DeletButton.Text="حذف";
            this.DeletButton.UseVisualStyleBackColor=false;
            //
            //ReleaseNameBox
            //
            this.ReleaseNameBox.BackColor=System.Drawing.SystemColors.Window;
            this.ReleaseNameBox.Location=new System.Drawing.Point(50, 54);
            this.ReleaseNameBox.Name="ReleaseNameBox";
            this.ReleaseNameBox.ReadOnly=true;
            this.ReleaseNameBox.Size=new System.Drawing.Size(137, 23);
            this.ReleaseNameBox.TabIndex=39;
            //
            //ReleaseNameButton
            //
            this.ReleaseNameButton.Image=(System.Drawing.Image)(resources.GetObject("ReleaseNameButton.Image"));
            this.ReleaseNameButton.Location=new System.Drawing.Point(20, 53);
            this.ReleaseNameButton.Name="ReleaseNameButton";
            this.ReleaseNameButton.Size=new System.Drawing.Size(30, 25);
            this.ReleaseNameButton.TabIndex=4;
            this.ReleaseNameButton.UseVisualStyleBackColor=true;
            //
            //Label5
            //
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(188, 57);
            this.Label5.Margin=new Padding(4, 0, 4, 0);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(76, 16);
            this.Label5.TabIndex=40;
            this.Label5.Text="نام جایگزین:";
            //
            //ReplaceCombo
            //
            this.ReplaceCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.ReplaceCombo.FormattingEnabled=true;
            this.ReplaceCombo.Location=new System.Drawing.Point(22, 18);
            this.ReplaceCombo.Name="ReplaceCombo";
            this.ReplaceCombo.Size=new System.Drawing.Size(165, 24);
            this.ReplaceCombo.TabIndex=3;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(188, 22);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(78, 16);
            this.Label2.TabIndex=37;
            this.Label2.Text="نوع جایگزین:";
            //
            //EndBox
            //
            this.EndBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.EndBox.Location=new System.Drawing.Point(351, 54);
            this.EndBox.Mask="00:00";
            this.EndBox.Name="EndBox";
            this.EndBox.Size=new System.Drawing.Size(54, 23);
            this.EndBox.TabIndex=2;
            this.EndBox.TextAlign=HorizontalAlignment.Center;
            this.EndBox.ValidatingType=typeof(DateTime);
            //
            //StartBox
            //
            this.StartBox.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)));
            this.StartBox.Location=new System.Drawing.Point(351, 19);
            this.StartBox.Mask="00:00";
            this.StartBox.Name="StartBox";
            this.StartBox.Size=new System.Drawing.Size(54, 23);
            this.StartBox.TabIndex=1;
            this.StartBox.TextAlign=HorizontalAlignment.Center;
            this.StartBox.ValidatingType=typeof(DateTime);
            //
            //Label8
            //
            this.Label8.AutoSize=true;
            this.Label8.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label8.Location=new System.Drawing.Point(408, 57);
            this.Label8.Name="Label8";
            this.Label8.Size=new System.Drawing.Size(65, 16);
            this.Label8.TabIndex=36;
            this.Label8.Text="تا ساعت:";
            //
            //Label7
            //
            this.Label7.AutoSize=true;
            this.Label7.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Label7.Location=new System.Drawing.Point(406, 22);
            this.Label7.Name="Label7";
            this.Label7.Size=new System.Drawing.Size(67, 16);
            this.Label7.TabIndex=35;
            this.Label7.Text="از ساعت:";
            //
            //Label4
            //
            this.Label4.AutoSize=true;
            this.Label4.Location=new System.Drawing.Point(411, 120);
            this.Label4.Margin=new Padding(4, 0, 4, 0);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(62, 16);
            this.Label4.TabIndex=20;
            this.Label4.Text="توضیحات:";
            //
            //MemBox
            //
            this.MemBox.Location=new System.Drawing.Point(22, 141);
            this.MemBox.Margin=new Padding(4, 5, 4, 5);
            this.MemBox.MaxLength=50;
            this.MemBox.Name="MemBox";
            this.MemBox.Size=new System.Drawing.Size(448, 45);
            this.MemBox.TabIndex=5;
            this.MemBox.Text="";
            //
            //Panel1
            //
            this.Panel1.BackColor=System.Drawing.Color.LightBlue;
            this.Panel1.BorderStyle=BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PersianCalendar);
            this.Panel1.Controls.Add(this.NameBox);
            this.Panel1.Controls.Add(this.SearchButton);
            this.Panel1.Controls.Add(this.NameButton);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Location=new System.Drawing.Point(14, 19);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(499, 82);
            this.Panel1.TabIndex=0;
            //
            //PersianCalendar
            //
            this.PersianCalendar.Location=new System.Drawing.Point(302, 45);
            this.PersianCalendar.Miladi=new DateTime(System.Convert.ToInt64(0));
            this.PersianCalendar.Name="PersianCalendar";
            this.PersianCalendar.NowDateSelected=true;
            this.PersianCalendar.ReadOnly=true;
            this.PersianCalendar.SelectedDate=null;
            this.PersianCalendar.Shamsi=null;
            this.PersianCalendar.Size=new System.Drawing.Size(125, 23);
            this.PersianCalendar.TabIndex=98;
            this.PersianCalendar.TextAlign=HorizontalAlignment.Center;
            //
            //Panel2
            //
            this.Panel2.BackColor=System.Drawing.Color.LightBlue;
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.MemBox);
            this.Panel2.Controls.Add(this.ReleaseNameBox);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.ReleaseNameButton);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.ReplaceCombo);
            this.Panel2.Controls.Add(this.StartBox);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.EndBox);
            this.Panel2.Location=new System.Drawing.Point(14, 112);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(499, 202);
            this.Panel2.TabIndex=1;
            //
            //Label6
            //
            this.Label6.Location=new System.Drawing.Point(45, 93);
            this.Label6.Margin=new Padding(4, 0, 4, 0);
            this.Label6.Name="Label6";
            this.Label6.Size=new System.Drawing.Size(407, 19);
            this.Label6.TabIndex=41;
            this.Label6.Text="---";
            this.Label6.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Panel3
            //
            this.Panel3.BackColor=System.Drawing.Color.LightBlue;
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.DeletButton);
            this.Panel3.Controls.Add(this.RegButton);
            this.Panel3.Controls.Add(this.ExitButton);
            this.Panel3.Location=new System.Drawing.Point(14, 356);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(499, 61);
            this.Panel3.TabIndex=2;
            //
            //Label9
            //
            this.Label9.ForeColor=System.Drawing.Color.DarkRed;
            this.Label9.Location=new System.Drawing.Point(72, 325);
            this.Label9.Name="Label9";
            this.Label9.Size=new System.Drawing.Size(363, 20);
            this.Label9.TabIndex=4;
            this.Label9.Text="تذکر: با حذف مرخصی ساعتی، اضافه کار جایگزین حذف می گردد";
            this.Label9.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            //
            //TimeLeaveEditForm
            //
            this.AcceptButton=this.SearchButton;
            this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.BackColor=System.Drawing.Color.LightBlue;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(531, 431);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.HelpButton=true;
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="TimeLeaveEditForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ویرایش مرخصی ساعتی";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private TextBox NameBox;
        private Button NameButton;
        private Button SearchButton;
        private Label Label3;
        private Label Label1;
        private Button ExitButton;
        private Button RegButton;
        private Button DeletButton;
        private TextBox ReleaseNameBox;
        private Button ReleaseNameButton;
        private Label Label5;
        private ComboBox ReplaceCombo;
        private Label Label2;
        private MaskedTextBox EndBox;
        private MaskedTextBox StartBox;
        private Label Label8;
        private Label Label7;
        private Label Label4;
        private RichTextBox MemBox;
        private Panel Panel1;
        private Panel Panel2;
        private Panel Panel3;
        private Label Label9;
        private BPersianCalender.BPersianCalenderTextBox PersianCalendar;
        private Label Label6;
    }

}
