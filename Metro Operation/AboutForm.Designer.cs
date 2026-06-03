using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class AboutForm : BaseForm
    {
        private System.ComponentModel.IContainer components=null;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                    components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TableLayoutPanel=new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox=new System.Windows.Forms.PictureBox();
            this.LabelVersion=new System.Windows.Forms.Label();
            this.Copyright=new System.Windows.Forms.Label();
            this.OKButton=new System.Windows.Forms.Button();
            this.LabelProductName=new System.Windows.Forms.Label();
            this.Label1=new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoSize=true;
            this.TableLayoutPanel.ColumnCount=2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.2F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.8F));
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.Copyright, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.OKButton, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.Label1, 1, 3);
            this.TableLayoutPanel.Dock=System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location=new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin=new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel.Name="TableLayoutPanel";
            this.TableLayoutPanel.RowCount=5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TableLayoutPanel.Size=new System.Drawing.Size(516, 248);
            this.TableLayoutPanel.TabIndex=1;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock=System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image=((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location=new System.Drawing.Point(369, 3);
            this.LogoPictureBox.Name="LogoPictureBox";
            this.LogoPictureBox.Padding=new System.Windows.Forms.Padding(5);
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 4);
            this.LogoPictureBox.Size=new System.Drawing.Size(144, 201);
            this.LogoPictureBox.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex=0;
            this.LogoPictureBox.TabStop=false;
            // 
            // LabelVersion
            // 
            this.LabelVersion.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LabelVersion.Dock=System.Windows.Forms.DockStyle.Fill;
            this.LabelVersion.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.LabelVersion.Location=new System.Drawing.Point(3, 32);
            this.LabelVersion.Name="LabelVersion";
            this.LabelVersion.Size=new System.Drawing.Size(360, 32);
            this.LabelVersion.TabIndex=0;
            this.LabelVersion.Text="نسخه:";
            this.LabelVersion.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Copyright
            // 
            this.Copyright.BackColor=System.Drawing.Color.Blue;
            this.Copyright.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Copyright.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.Copyright.ForeColor=System.Drawing.Color.Lime;
            this.Copyright.Location=new System.Drawing.Point(3, 64);
            this.Copyright.Name="Copyright";
            this.Copyright.Size=new System.Drawing.Size(360, 32);
            this.Copyright.TabIndex=0;
            this.Copyright.Text="طراحی و  پیاده سازی: تیم برنامه نویسی K2";
            this.Copyright.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OKButton
            // 
            this.OKButton.BackColor=System.Drawing.Color.Khaki;
            this.OKButton.Dock=System.Windows.Forms.DockStyle.Fill;
            this.OKButton.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Location=new System.Drawing.Point(369, 210);
            this.OKButton.Name="OKButton";
            this.OKButton.Size=new System.Drawing.Size(144, 35);
            this.OKButton.TabIndex=0;
            this.OKButton.Text="تغییرات نسخه جدید";
            this.OKButton.UseVisualStyleBackColor=false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // LabelProductName
            // 
            this.LabelProductName.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LabelProductName.Dock=System.Windows.Forms.DockStyle.Fill;
            this.LabelProductName.Font=new System.Drawing.Font("Tahoma", 9.75F);
            this.LabelProductName.Location=new System.Drawing.Point(3, 0);
            this.LabelProductName.Name="LabelProductName";
            this.LabelProductName.Size=new System.Drawing.Size(360, 32);
            this.LabelProductName.TabIndex=0;
            this.LabelProductName.Text="نام نرم افزار: سیر و حرکت";
            this.LabelProductName.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize=true;
            this.Label1.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label1.Dock=System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font=new System.Drawing.Font("Tahoma", 10F);
            this.Label1.ForeColor=System.Drawing.Color.White;
            this.Label1.Location=new System.Drawing.Point(3, 96);
            this.Label1.Name="Label1";
            this.TableLayoutPanel.SetRowSpan(this.Label1, 2);
            this.Label1.Size=new System.Drawing.Size(360, 152);
            this.Label1.TabIndex=8;
            this.Label1.Text=resources.GetString("Label1.Text");
            this.Label1.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize=new System.Drawing.Size(516, 248);
            this.Controls.Add(this.TableLayoutPanel);
            this.Font=new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="AboutForm";
            this.ShowInTaskbar=false;
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="درباره برنامه";
            this.Load += new System.EventHandler(this.AboutBox1_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TableLayoutPanel TableLayoutPanel;
        private PictureBox LogoPictureBox;
        private Label LabelProductName;
        private Label LabelVersion;
        private Label Copyright;
        private Button OKButton;
        private Label Label1;
    }
}
