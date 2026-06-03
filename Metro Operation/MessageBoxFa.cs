using System;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation
{
    public static class MessageBoxFa
    {
        private static DialogResult Btn1Result, Btn2Result, Btn3Result;
        private static string Btn1="", Btn2="", Btn3="";

        public static DialogResult Show(
            string text,
            string caption="",
            MessageBoxIcon icon=MessageBoxIcon.None,
            MessageBoxButtons buttons=MessageBoxButtons.OK,
            MessageBoxDefaultButton defaultButton=MessageBoxDefaultButton.Button1,
            MessageBoxOptions options=MessageBoxOptions.RtlReading)
        {
            SetButtonCaptions(buttons);
            SetButtonResults(buttons);

            Icon sysIcon=null;
            switch (icon)
            {
                case MessageBoxIcon.Error: sysIcon=SystemIcons.Error; break;
                case MessageBoxIcon.Warning: sysIcon=SystemIcons.Warning; break;
                case MessageBoxIcon.Information: sysIcon=SystemIcons.Information; break;
                case MessageBoxIcon.Question: sysIcon=SystemIcons.Question; break;
            }

            using (Form frm=new Form())
            {
                frm.Text=caption;
                frm.FormBorderStyle=FormBorderStyle.FixedDialog;
                frm.StartPosition=FormStartPosition.CenterScreen;
                frm.MinimizeBox=false;
                frm.MaximizeBox=false;
                frm.ShowIcon=false;
                frm.ShowInTaskbar=false;
                frm.TopMost=true;
                frm.RightToLeft=RightToLeft.Yes;
                frm.RightToLeftLayout=false;
                frm.Font=FontManager.Gandom(9.5f);

                Label lbl=new Label
                {
                    Text=text,
                    AutoSize=true,
                    MaximumSize=new Size(400, 0),
                    Location=new Point(15, 30)
                };
                frm.Controls.Add(lbl);

                int iconWidth=0;
                int iconHeight=0;

                if (sysIcon != null)
                {
                    PictureBox pic=new PictureBox
                    {
                        Image=sysIcon.ToBitmap(),
                        SizeMode=PictureBoxSizeMode.AutoSize
                    };

                    iconWidth=pic.Width;
                    iconHeight=pic.Height;

                    pic.Location=new Point(lbl.Right + 10, lbl.Top + (lbl.Height - iconHeight) / 2);
                    frm.Controls.Add(pic);
                }

                int btnTop=Math.Max(lbl.Bottom, iconHeight + 20) + 20;
                int btnLeft=15;
                int spacing=10;

                Button b1=null, b2=null, b3=null;

                if (!string.IsNullOrEmpty(Btn1))
                {
                    b1=CreateButton(Btn1, Btn1Result);
                    frm.Controls.Add(b1);
                }
                if (!string.IsNullOrEmpty(Btn2))
                {
                    b2=CreateButton(Btn2, Btn2Result);
                    frm.Controls.Add(b2);
                }
                if (!string.IsNullOrEmpty(Btn3))
                {
                    b3=CreateButton(Btn3, Btn3Result);
                    frm.Controls.Add(b3);
                }

                if (b1 != null) { b1.Location=new Point(btnLeft, btnTop); btnLeft += b1.Width + spacing; }
                if (b2 != null) { b2.Location=new Point(btnLeft, btnTop); btnLeft += b2.Width + spacing; }
                if (b3 != null) { b3.Location=new Point(btnLeft, btnTop); btnLeft += b3.Width + spacing; }

                frm.ClientSize=new Size(
                    Math.Max(lbl.Right + (sysIcon != null ? iconWidth + 20 : 25), btnLeft + 15),
                    btnTop + 40
                );

                // ========================
                //   DEFAULT BUTTON LOGIC
                // ========================
                Button defaultBtn=b1;

                switch (defaultButton)
                {
                    case MessageBoxDefaultButton.Button1:
                        defaultBtn=b1;
                        break;

                    case MessageBoxDefaultButton.Button2:
                        if (b2 != null)
                        {
                            defaultBtn=b2;
                        }

                        break;

                    case MessageBoxDefaultButton.Button3:
                        if (b3 != null)
                        {
                            defaultBtn=b3;
                        }

                        break;
                }

                frm.AcceptButton=defaultBtn;
                frm.CancelButton=b3 ?? b2 ?? b1;

                frm.Shown += (s, e2) => defaultBtn?.Focus();

                return frm.ShowDialog();
            }
        }

        private static Button CreateButton(string text, DialogResult result)
        {
            Button btn=new Button
            {
                Text=text,
                AutoSize=true,
                DialogResult=result,
                Font=FontManager.IranSans(9)
            };

            btn.Click += (s, e) => ((Form)btn.Parent).DialogResult=result;

            return btn;
        }

        private static void SetButtonCaptions(MessageBoxButtons buttons)
        {
            Btn1=Btn2=Btn3="";

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    Btn1="تایید";
                    break;

                case MessageBoxButtons.OKCancel:
                    Btn1="تایید";
                    Btn2="لغو";
                    break;

                case MessageBoxButtons.YesNo:
                    Btn1="بله";
                    Btn2="خیر";
                    break;

                case MessageBoxButtons.YesNoCancel:
                    Btn1="بله";
                    Btn2="خیر";
                    Btn3="لغو";
                    break;

                case MessageBoxButtons.RetryCancel:
                    Btn1="کوشش مجدد";
                    Btn2="لغو";
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    Btn1="رها کردن";
                    Btn2="کوشش مجدد";
                    Btn3="چشم‌پوشی";
                    break;
            }
        }

        private static void SetButtonResults(MessageBoxButtons buttons)
        {
            Btn1Result=Btn2Result=Btn3Result=DialogResult.None;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    Btn1Result=DialogResult.OK;
                    break;

                case MessageBoxButtons.OKCancel:
                    Btn1Result=DialogResult.OK;
                    Btn2Result=DialogResult.Cancel;
                    break;

                case MessageBoxButtons.YesNo:
                    Btn1Result=DialogResult.Yes;
                    Btn2Result=DialogResult.No;
                    break;

                case MessageBoxButtons.YesNoCancel:
                    Btn1Result=DialogResult.Yes;
                    Btn2Result=DialogResult.No;
                    Btn3Result=DialogResult.Cancel;
                    break;

                case MessageBoxButtons.RetryCancel:
                    Btn1Result=DialogResult.Retry;
                    Btn2Result=DialogResult.Cancel;
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    Btn1Result=DialogResult.Abort;
                    Btn2Result=DialogResult.Retry;
                    Btn3Result=DialogResult.Ignore;
                    break;
            }
        }
    }
}
