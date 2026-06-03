using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public
    partial class NavganEditForm : BaseForm
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
            this.RegButton=new Button();
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            this.ExitButton=new Button();
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.DelButton=new Button();
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            this.SearchButton=new Button();
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.KindCombo=new ComboBox();
            this.KindCombo.SelectedIndexChanged += new System.EventHandler(this.KindCombo_SelectedIndexChanged);
            this.Label2=new Label();
            this.Label1=new Label();
            this.Panel1=new Panel();
            this.Wag8Box=new MaskedTextBox();
            this.Wag9Box=new MaskedTextBox();
            this.Wag6Box=new MaskedTextBox();
            this.Wag5Box=new MaskedTextBox();
            this.Wag4Box=new MaskedTextBox();
            this.Loco2Box=new MaskedTextBox();
            this.Wag3Box=new MaskedTextBox();
            this.Wag2Box=new MaskedTextBox();
            this.Loco1Box=new MaskedTextBox();
            this.Wag1Box=new MaskedTextBox();
            this.Wag7Box=new MaskedTextBox();
            this.PictureBox1=new PictureBox();
            this.Panel2=new Panel();
            this.TurnButton=new Button();
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            this.Panel3=new Panel();
            this.Panel4=new Panel();
            this.Label3=new Label();
            this.Label4=new Label();
            this.Label5=new Label();
            this.NumBox=new MaskedTextBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            //
            //RegButton
            //
            this.RegButton.BackColor=System.Drawing.Color.CornflowerBlue;
            this.RegButton.Image=global::Metro_Operation.Properties.Resources.tick_inside_circle;
            this.RegButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.RegButton.Cursor=Cursors.Hand;
            this.RegButton.Location=new System.Drawing.Point(598, 8);
            this.RegButton.Name="RegButton";
            this.RegButton.Size=new System.Drawing.Size(145, 37);
            this.RegButton.TabIndex=0;
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
            this.ExitButton.Location=new System.Drawing.Point(10, 8);
            this.ExitButton.Name="ExitButton";
            this.ExitButton.Size=new System.Drawing.Size(145, 37);
            this.ExitButton.TabIndex=2;
            this.ExitButton.Text="انصراف";
            this.ExitButton.UseVisualStyleBackColor=false;
            //
            //DelButton
            //
            this.DelButton.BackColor=System.Drawing.Color.DarkOrange;
            this.DelButton.Image=global::Metro_Operation.Properties.Resources.rubbish_bin;
            this.DelButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.DelButton.Cursor=Cursors.Hand;
            this.DelButton.Location=new System.Drawing.Point(435, 8);
            this.DelButton.Name="DelButton";
            this.DelButton.Size=new System.Drawing.Size(145, 37);
            this.DelButton.TabIndex=1;
            this.DelButton.Text="حذف";
            this.DelButton.UseVisualStyleBackColor=false;
            //
            //SearchButton
            //
            this.SearchButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.SearchButton.Image=global::Metro_Operation.Properties.Resources.search;
            this.SearchButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Cursor=Cursors.Hand;

            this.SearchButton.Location=new System.Drawing.Point(83, 12);
            this.SearchButton.Margin=new Padding(4, 5, 4, 5);
            this.SearchButton.Name="SearchButton";
            this.SearchButton.Size=new System.Drawing.Size(175, 35);
            this.SearchButton.TabIndex=2;
            this.SearchButton.Text="جستجو";
            this.SearchButton.UseVisualStyleBackColor=false;
            //
            //KindCombo
            //
            this.KindCombo.DropDownStyle=ComboBoxStyle.DropDownList;
            this.KindCombo.Font=new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.KindCombo.FormattingEnabled=true;
            this.KindCombo.Items.AddRange(new object[] { "لکوموتیو", "واگن" });
            this.KindCombo.Location=new System.Drawing.Point(463, 16);
            this.KindCombo.Name="KindCombo";
            this.KindCombo.Size=new System.Drawing.Size(114, 27);
            this.KindCombo.TabIndex=0;
            //
            //label2
            //
            this.Label2.AutoSize=true;
            this.Label2.Location=new System.Drawing.Point(379, 21);
            this.Label2.Name="Label2";
            this.Label2.Size=new System.Drawing.Size(49, 16);
            this.Label2.TabIndex=55;
            this.Label2.Text="شماره:";
            //
            //Label1
            //
            this.Label1.AutoSize=true;
            this.Label1.Location=new System.Drawing.Point(578, 21);
            this.Label1.Name="Label1";
            this.Label1.Size=new System.Drawing.Size(109, 16);
            this.Label1.TabIndex=56;
            this.Label1.Text="جستجو بر اساس:";
            //
            //Panel1
            //
            this.Panel1.Controls.Add(this.Wag8Box);
            this.Panel1.Controls.Add(this.Wag9Box);
            this.Panel1.Controls.Add(this.Wag6Box);
            this.Panel1.Controls.Add(this.Wag5Box);
            this.Panel1.Controls.Add(this.Wag4Box);
            this.Panel1.Controls.Add(this.Loco2Box);
            this.Panel1.Controls.Add(this.Wag3Box);
            this.Panel1.Controls.Add(this.Wag2Box);
            this.Panel1.Controls.Add(this.Loco1Box);
            this.Panel1.Controls.Add(this.Wag1Box);
            this.Panel1.Controls.Add(this.Wag7Box);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location=new System.Drawing.Point(10, 92);
            this.Panel1.Name="Panel1";
            this.Panel1.Size=new System.Drawing.Size(771, 94);
            this.Panel1.TabIndex=1;
            //
            //Wag8Box
            //
            this.Wag8Box.BorderStyle=BorderStyle.None;
            this.Wag8Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag8Box.Location=new System.Drawing.Point(169, 50);
            this.Wag8Box.Mask=">A00";
            this.Wag8Box.Name="Wag8Box";
            this.Wag8Box.Size=new System.Drawing.Size(51, 26);
            this.Wag8Box.TabIndex=39;
            this.Wag8Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag9Box
            //
            this.Wag9Box.BorderStyle=BorderStyle.None;
            this.Wag9Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag9Box.Location=new System.Drawing.Point(106, 50);
            this.Wag9Box.Mask=">A00";
            this.Wag9Box.Name="Wag9Box";
            this.Wag9Box.Size=new System.Drawing.Size(51, 26);
            this.Wag9Box.TabIndex=40;
            this.Wag9Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag6Box
            //
            this.Wag6Box.BorderStyle=BorderStyle.None;
            this.Wag6Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag6Box.Location=new System.Drawing.Point(296, 50);
            this.Wag6Box.Mask=">A00";
            this.Wag6Box.Name="Wag6Box";
            this.Wag6Box.Size=new System.Drawing.Size(51, 26);
            this.Wag6Box.TabIndex=37;
            this.Wag6Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag5Box
            //
            this.Wag5Box.BorderStyle=BorderStyle.None;
            this.Wag5Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag5Box.Location=new System.Drawing.Point(360, 50);
            this.Wag5Box.Mask=">A00";
            this.Wag5Box.Name="Wag5Box";
            this.Wag5Box.Size=new System.Drawing.Size(51, 26);
            this.Wag5Box.TabIndex=36;
            this.Wag5Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag4Box
            //
            this.Wag4Box.BorderStyle=BorderStyle.None;
            this.Wag4Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag4Box.Location=new System.Drawing.Point(423, 50);
            this.Wag4Box.Mask=">A00";
            this.Wag4Box.Name="Wag4Box";
            this.Wag4Box.Size=new System.Drawing.Size(51, 26);
            this.Wag4Box.TabIndex=35;
            this.Wag4Box.TextAlign=HorizontalAlignment.Center;
            //
            //Loco2Box
            //
            this.Loco2Box.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(102)));
            this.Loco2Box.BorderStyle=BorderStyle.None;
            this.Loco2Box.Font=new System.Drawing.Font("Tahoma", 18.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Loco2Box.Location=new System.Drawing.Point(44, 49);
            this.Loco2Box.Mask=">A0";
            this.Loco2Box.Name="Loco2Box";
            this.Loco2Box.Size=new System.Drawing.Size(50, 29);
            this.Loco2Box.TabIndex=41;
            this.Loco2Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag3Box
            //
            this.Wag3Box.BorderStyle=BorderStyle.None;
            this.Wag3Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag3Box.Location=new System.Drawing.Point(487, 50);
            this.Wag3Box.Mask=">A00";
            this.Wag3Box.Name="Wag3Box";
            this.Wag3Box.Size=new System.Drawing.Size(51, 26);
            this.Wag3Box.TabIndex=34;
            this.Wag3Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag2Box
            //
            this.Wag2Box.BorderStyle=BorderStyle.None;
            this.Wag2Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag2Box.Location=new System.Drawing.Point(550, 50);
            this.Wag2Box.Mask=">A00";
            this.Wag2Box.Name="Wag2Box";
            this.Wag2Box.Size=new System.Drawing.Size(51, 26);
            this.Wag2Box.TabIndex=33;
            this.Wag2Box.TextAlign=HorizontalAlignment.Center;
            //
            //Loco1Box
            //
            this.Loco1Box.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(153)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(102)));
            this.Loco1Box.BorderStyle=BorderStyle.None;
            this.Loco1Box.Font=new System.Drawing.Font("Tahoma", 18.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Loco1Box.Location=new System.Drawing.Point(677, 49);
            this.Loco1Box.Mask=">A0";
            this.Loco1Box.Name="Loco1Box";
            this.Loco1Box.Size=new System.Drawing.Size(50, 29);
            this.Loco1Box.TabIndex=1;
            this.Loco1Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag1Box
            //
            this.Wag1Box.BorderStyle=BorderStyle.None;
            this.Wag1Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag1Box.Location=new System.Drawing.Point(614, 50);
            this.Wag1Box.Mask=">A00";
            this.Wag1Box.Name="Wag1Box";
            this.Wag1Box.Size=new System.Drawing.Size(51, 26);
            this.Wag1Box.TabIndex=2;
            this.Wag1Box.TextAlign=HorizontalAlignment.Center;
            //
            //Wag7Box
            //
            this.Wag7Box.BorderStyle=BorderStyle.None;
            this.Wag7Box.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Wag7Box.Location=new System.Drawing.Point(233, 50);
            this.Wag7Box.Mask=">A00";
            this.Wag7Box.Name="Wag7Box";
            this.Wag7Box.Size=new System.Drawing.Size(51, 26);
            this.Wag7Box.TabIndex=38;
            this.Wag7Box.TextAlign=HorizontalAlignment.Center;
            //
            //PictureBox1
            //
            this.PictureBox1.Enabled=false;
            this.PictureBox1.Image=global::Metro_Operation.Properties.Resources.Train;
            this.PictureBox1.Location=new System.Drawing.Point(0, 0);
            this.PictureBox1.Name="PictureBox1";
            this.PictureBox1.Size=new System.Drawing.Size(771, 94);
            this.PictureBox1.SizeMode=PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex=42;
            this.PictureBox1.TabStop=false;
            //
            //Panel2
            //
            this.Panel2.BorderStyle=BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.TurnButton);
            this.Panel2.Controls.Add(this.ExitButton);
            this.Panel2.Controls.Add(this.RegButton);
            this.Panel2.Controls.Add(this.DelButton);
            this.Panel2.Location=new System.Drawing.Point(13, 293);
            this.Panel2.Name="Panel2";
            this.Panel2.Size=new System.Drawing.Size(765, 56);
            this.Panel2.TabIndex=2;
            //
            //TurnButton
            //
            this.TurnButton.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(128)), System.Convert.ToInt32(System.Convert.ToByte(255)), System.Convert.ToInt32(System.Convert.ToByte(128)));
            this.TurnButton.ImageAlign=System.Drawing.ContentAlignment.MiddleLeft;
            this.TurnButton.Cursor=Cursors.Hand;

            this.TurnButton.Location=new System.Drawing.Point(272, 9);
            this.TurnButton.Margin=new Padding(4, 5, 4, 5);
            this.TurnButton.Name="TurnButton";
            this.TurnButton.Size=new System.Drawing.Size(145, 37);
            this.TurnButton.TabIndex=2;
            this.TurnButton.Text="دوار";
            this.TurnButton.UseVisualStyleBackColor=false;
            //
            //Panel3
            //
            this.Panel3.BackColor=Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(234)), System.Convert.ToInt32(System.Convert.ToByte(224)), System.Convert.ToInt32(System.Convert.ToByte(224)));
            this.Panel3.BorderStyle=BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.NumBox);
            this.Panel3.Controls.Add(this.SearchButton);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.KindCombo);
            this.Panel3.Location=new System.Drawing.Point(13, 17);
            this.Panel3.Name="Panel3";
            this.Panel3.Size=new System.Drawing.Size(765, 60);
            this.Panel3.TabIndex=0;
            //
            //Panel4
            //
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Font=new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.Panel4.Location=new System.Drawing.Point(16, 197);
            this.Panel4.Name="Panel4";
            this.Panel4.Size=new System.Drawing.Size(759, 82);
            this.Panel4.TabIndex=19;
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
            //Label4
            //
            this.Label4.Location=new System.Drawing.Point(3, 33);
            this.Label4.Name="Label4";
            this.Label4.Size=new System.Drawing.Size(748, 19);
            this.Label4.TabIndex=17;
            this.Label4.Text="* شماره لکوموتیو بایستی یک عدد دو رقمی یا H و عدد یک رقمی باشد (مثال: 01 , H1)";
            //
            //Label5
            //
            this.Label5.Anchor=AnchorStyles.Top | AnchorStyles.Right;
            this.Label5.AutoSize=true;
            this.Label5.Location=new System.Drawing.Point(578, 5);
            this.Label5.Name="Label5";
            this.Label5.Size=new System.Drawing.Size(176, 18);
            this.Label5.TabIndex=17;
            this.Label5.Text="لطفا به نکات زیر توجه کنید:";
            //
            //NumBox
            //
            this.NumBox.Font=new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.NumBox.Location=new System.Drawing.Point(321, 13);
            this.NumBox.Mask=">A00";
            this.NumBox.Name="NumBox";
            this.NumBox.Size=new System.Drawing.Size(57, 33);
            this.NumBox.TabIndex=57;
            this.NumBox.TextAlign=HorizontalAlignment.Center;
            //
            //NavganEditForm
            //
            this.AutoScaleDimensions=new System.Drawing.SizeF(7.0F, 16.0F);
            this.AutoScaleMode=AutoScaleMode.None;
            this.CancelButton=this.ExitButton;
            this.ClientSize=new System.Drawing.Size(790, 364);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font=new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(178));
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.Margin=new Padding(3, 4, 3, 4);
            this.MaximizeBox=false;
            this.MinimizeBox=false;
            this.Name="NavganEditForm";
            this.RightToLeft=RightToLeft.Yes;
            this.ShowInTaskbar=false;
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text="ویرایش ناوگان";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        private Button RegButton;
        private Button ExitButton;
        private Button DelButton;
        private Button SearchButton;
        private ComboBox KindCombo;
        private Label Label2;
        private Label Label1;
        private Panel Panel1;
        private MaskedTextBox Wag8Box;
        private MaskedTextBox Wag9Box;
        private MaskedTextBox Wag6Box;
        private MaskedTextBox Wag5Box;
        private MaskedTextBox Wag4Box;
        private MaskedTextBox Loco2Box;
        private MaskedTextBox Wag3Box;
        private MaskedTextBox Wag2Box;
        private MaskedTextBox Loco1Box;
        private MaskedTextBox Wag1Box;
        private MaskedTextBox Wag7Box;
        private PictureBox PictureBox1;
        private Panel Panel2;
        private Panel Panel3;
        private Button TurnButton;
        private Panel Panel4;
        private Label Label3;
        private Label Label4;
        private Label Label5;
        private MaskedTextBox NumBox;
    }
}
