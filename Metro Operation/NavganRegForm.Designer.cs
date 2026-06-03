using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class NavganRegForm : BaseForm
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
            this.Loco1Box=new MaskedTextBox();
            this.Wag1Box=new MaskedTextBox();
            this.Wag2Box=new MaskedTextBox();
            this.Wag3Box=new MaskedTextBox();
            this.Wag4Box=new MaskedTextBox();
            this.Wag5Box=new MaskedTextBox();
            this.Wag6Box=new MaskedTextBox();
            this.Wag7Box=new MaskedTextBox();
            this.Wag8Box=new MaskedTextBox();
            this.Wag9Box=new MaskedTextBox();
            this.Loco2Box=new MaskedTextBox();
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.ExitButton=new Button();
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.PictureBox1=new PictureBox();
            this.Label1=new Label();
            this.Panel1=new Panel();
            this.Label3=new Label();
            this.Label2=new Label();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            //
            //Loco1Box
            //
            this.Loco1Box.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(102)));
            this.Loco1Box.BorderStyle=BorderStyle.None;
            this.Loco1Box.Font=new System.Drawing.Font("Tahoma", (float)(18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Loco1Box.Location=new System.Drawing.Point(681, 72);
            this.Loco1Box.Mask=">A0";
            this.Loco1Box.Name="Loco1Box";
            this.Loco1Box.Size=new System.Drawing.Size(50, 29);
            this.Loco1Box.TabIndex=0;
            this.Loco1Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag1Box
            //
            this.Wag1Box.BorderStyle=BorderStyle.None;
            this.Wag1Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag1Box.Location=new System.Drawing.Point(618, 73);
            this.Wag1Box.Mask=">A00";
            this.Wag1Box.Name="Wag1Box";
            this.Wag1Box.Size=new System.Drawing.Size(51, 26);
            this.Wag1Box.TabIndex=1;
            this.Wag1Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag2Box
            //
            this.Wag2Box.BorderStyle=BorderStyle.None;
            this.Wag2Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag2Box.Location=new System.Drawing.Point(554, 73);
            this.Wag2Box.Mask=">A00";
            this.Wag2Box.Name="Wag2Box";
            this.Wag2Box.Size=new System.Drawing.Size(51, 26);
            this.Wag2Box.TabIndex=2;
            this.Wag2Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag3Box
            //
            this.Wag3Box.BorderStyle=BorderStyle.None;
            this.Wag3Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag3Box.Location=new System.Drawing.Point(491, 73);
            this.Wag3Box.Mask=">A00";
            this.Wag3Box.Name="Wag3Box";
            this.Wag3Box.Size=new System.Drawing.Size(51, 26);
            this.Wag3Box.TabIndex=3;
            this.Wag3Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag4Box
            //
            this.Wag4Box.BorderStyle=BorderStyle.None;
            this.Wag4Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag4Box.Location=new System.Drawing.Point(427, 73);
            this.Wag4Box.Mask=">A00";
            this.Wag4Box.Name="Wag4Box";
            this.Wag4Box.Size=new System.Drawing.Size(51, 26);
            this.Wag4Box.TabIndex=4;
            this.Wag4Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag5Box
            //
            this.Wag5Box.BorderStyle=BorderStyle.None;
            this.Wag5Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag5Box.Location=new System.Drawing.Point(364, 73);
            this.Wag5Box.Mask=">A00";
            this.Wag5Box.Name="Wag5Box";
            this.Wag5Box.Size=new System.Drawing.Size(51, 26);
            this.Wag5Box.TabIndex=5;
            this.Wag5Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag6Box
            //
            this.Wag6Box.BorderStyle=BorderStyle.None;
            this.Wag6Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag6Box.Location=new System.Drawing.Point(300, 73);
            this.Wag6Box.Mask=">A00";
            this.Wag6Box.Name="Wag6Box";
            this.Wag6Box.Size=new System.Drawing.Size(51, 26);
            this.Wag6Box.TabIndex=6;
            this.Wag6Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag7Box
            //
            this.Wag7Box.BorderStyle=BorderStyle.None;
            this.Wag7Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag7Box.Location=new System.Drawing.Point(237, 73);
            this.Wag7Box.Mask=">A00";
            this.Wag7Box.Name="Wag7Box";
            this.Wag7Box.Size=new System.Drawing.Size(51, 26);
            this.Wag7Box.TabIndex=7;
            this.Wag7Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag8Box
            //
            this.Wag8Box.BorderStyle=BorderStyle.None;
            this.Wag8Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag8Box.Location=new System.Drawing.Point(173, 73);
            this.Wag8Box.Mask=">A00";
            this.Wag8Box.Name="Wag8Box";
            this.Wag8Box.Size=new System.Drawing.Size(51, 26);
            this.Wag8Box.TabIndex=8;
            this.Wag8Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag9Box
            //
            this.Wag9Box.BorderStyle=BorderStyle.None;
            this.Wag9Box.Font=new System.Drawing.Font("Tahoma", (float)(15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag9Box.Location=new System.Drawing.Point(110, 73);
            this.Wag9Box.Mask=">A00";
            this.Wag9Box.Name="Wag9Box";
            this.Wag9Box.Size=new System.Drawing.Size(51, 26);
            this.Wag9Box.TabIndex=9;
            this.Wag9Box.TextAlign=HorizontalAlignment.Center;
            //
            //Loco2Box
            //
            this.Loco2Box.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(102)));
            this.Loco2Box.BorderStyle=BorderStyle.None;
            this.Loco2Box.Font=new System.Drawing.Font("Tahoma", (float)(18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Loco2Box.Location=new System.Drawing.Point(48, 72);
            this.Loco2Box.Mask=">A0";
            this.Loco2Box.Name="Loco2Box";
            this.Loco2Box.Size=new System.Drawing.Size(50, 29);
            this.Loco2Box.TabIndex=10;
            this.Loco2Box.TextAlign=HorizontalAlignment.Center;
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;

            this.RegButton.Location=new System.Drawing.Point(371, 222);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(217, 34);
            this.RegButton.TabIndex=11;
            this.RegButton.Text="ذخیره";
            this.RegButton.UseVisualStyleBackColor=false;
            //
            //ExitButton
            //
            this.ExitButton.BackColor=System.Drawing.SystemColors.Control;
            this.ExitButton.Image=global::Metro_Operation.Properties.Resources._return;
            this.ExitButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Cursor=Cursors.Hand;
            this.ExitButton.DialogResult=DialogResult.None;
            this.ExitButton.Location=new System.Drawing.Point(203, 222);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(148, 34);
            this.ExitButton.TabIndex=12;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            //
            //PictureBox1
            //
            this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.Train;
            this.PictureBox1.Location=new System.Drawing.Point(4, 23);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(771, 94);
            this.PictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex=16;
            this.PictureBox1.TabStop=false;
            //
            //Label1
            //
            this.Label1.Anchor=AnchorStyles.Top | AnchorStyles.Right;
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(578, 5);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(176, 18);
            this.Label1.TabIndex=17;
            this.Label1.Text="لطفا به نکات زیر توجه کنید:";
            //
            //Panel1
            //
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Font=new System.Drawing.Font("Tahoma", (float)(11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Panel1.Location=new System.Drawing.Point(10, 124);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(759, 82);
            this.Panel1.TabIndex=18;
            //
            //Label3
            //
            this.Label3.Location=new System.Drawing.Point(3, 56);
            this.Label3.Name="Label3";
            this.Label3.Size=new System.Drawing.Size(748, 19);
            this.Label3.TabIndex=17;
            this.Label3.Text="* شماره واگن بایستی یک عدد سه رقمی یا H و عدد دو رقمی باشد (مثال: 001 , 023 , H01" +
                ")";
            //
            //label2
            //
            this.Label2.Location=new System.Drawing.Point(3, 33);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(748, 19);
            this.Label2.TabIndex=17;
            this.Label2.Text="* شماره لکوموتیو بایستی یک عدد دو رقمی یا H و عدد یک رقمی باشد (مثال: 01 , 32 , H" +
                "1)";
            //
            //NavganRegForm
            //
            this.AcceptButton=this.RegButton;
            this.AutoScaleDimensions=new System.Drawing.SizeF((float)(7.0F), (float)(16.0F));
            this.AutoScaleMode=AutoScaleMode.None;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(779, 268);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Wag8Box);
            this.Controls.Add(this.Wag9Box);
            this.Controls.Add(this.Wag6Box);
            this.Controls.Add(this.Wag5Box);
            this.Controls.Add(this.Wag4Box);
            this.Controls.Add(this.Loco2Box);
            this.Controls.Add(this.Wag3Box);
            this.Controls.Add(this.Wag2Box);
            this.Controls.Add(this.Loco1Box);
            this.Controls.Add(this.Wag1Box);
            this.Controls.Add(this.Wag7Box);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PictureBox1);
            this.Font=new System.Drawing.Font("Tahoma", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="NavganRegForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ثبت آرایش ناوگان";
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaskedTextBox Loco1Box;
        private MaskedTextBox Wag1Box;
        private MaskedTextBox Wag2Box;
        private MaskedTextBox Wag3Box;
        private MaskedTextBox Wag4Box;
        private MaskedTextBox Wag5Box;
        private MaskedTextBox Wag6Box;
        private MaskedTextBox Wag7Box;
        private MaskedTextBox Wag8Box;
        private MaskedTextBox Wag9Box;
        private MaskedTextBox Loco2Box;
        private Button RegButton;
        private Button ExitButton;
        private PictureBox PictureBox1;
        private Label Label1;
        private Panel Panel1;
        private Label Label2;
        private Label Label3;
    }

}
