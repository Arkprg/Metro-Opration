using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_Operation.Controls
{
    /// <summary>
    /// یک رقم قابل انیمیشن که هنگام تغییر مقدار عدد قبلی به سمت بالا می‌رود و عدد جدید از پایین وارد می‌شود.
    /// </summary>
    public partial class FlipDigit : Control
    {
        private int _current=0;
        private int _next=0;
        private float _offset=0f;             // offset in pixels: 0 -> current centered, negative -> current moved up
        private readonly Timer _animTimer;
        private int _animSpeed=12;           // pixels per tick
        private bool _animating=false;

        public FlipDigit()
        {
            DoubleBuffered=true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            // defaults
            Font=new Font("Tahoma",20f, FontStyle.Bold, GraphicsUnit.Pixel);
            ForeColor=Color.White;
            BackColor=Color.FromArgb(40, 40, 140);
            Size=new Size(15, 20);

            _animTimer=new Timer { Interval=15 };
            _animTimer.Tick += AnimTimer_Tick;
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            // move offset up by anim speed
            _offset -= _animSpeed;
            if (-_offset >= Height)
            {
                // finished
                _animTimer.Stop();
                _animating=false;
                _current=_next;
                _offset=0;
            }
            Invalidate();
        }

        /// <summary>
        /// مقدار حال حاضر (0..9)
        /// </summary>
        [Browsable(false)]
        public int Current => _current;

        /// <summary>
        /// مقدار هدف (وقتی مقدار جدید داده می‌شود) — تنظیماز طریق property Value
        /// </summary>
        [Browsable(false)]
        public int Next => _next;

        /// <summary>
        /// مقدار رقمی (0..9) — وقتی تغییر کند انیمیشن اجرا می‌شود.
        /// </summary>
        [Browsable(false)]
        public int Value
        {
            get => _current;
            set
            {
                int v=Normalize(value);
                if (v == _current)
                {
                    return;
                }

                _next=v;
                StartAnimation();
            }
        }

        /// <summary>
        /// فورس مقدار بدون انیمیشن (برای مقداردهی اولیه)
        /// </summary>
        public void SetValueImmediate(int v)
        {
            _animTimer.Stop();
            _animating=false;
            _offset=0;
            _current=Normalize(v);
            _next=_current;
            Invalidate();
        }

        /// <summary>
        /// سرعت انیمیشن به پیکسل در هر تیک
        /// </summary>
        [DefaultValue(12)]
        public int AnimSpeed
        {
            get => _animSpeed;
            set => _animSpeed=Math.Max(2, value);
        }

        private int Normalize(int n)
        {
            while (n < 0)
            {
                n += 10;
            }

            return n % 10;
        }

        private void StartAnimation()
        {
            // اگر همین الان در حال انیمیشن بود، فقط next را بروزرسانی کن (انیمیشن ادامه یابد)
            if (_animating)
            {
                // next already set
                return;
            }

            _animating=true;
            _offset=0f;
            _animTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g=e.Graphics;
            g.Clear(Parent?.BackColor ?? BackColor);
            g.TextRenderingHint=System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // draw rounded rect background (simple)
            using (SolidBrush b=new SolidBrush(BackColor))
            {
                g.FillRectangle(b, ClientRectangle);
            }

            // prepare string values
            string curText=_current.ToString();
            string nextText=(_animating ? _next.ToString() : _current.ToString());

            StringFormat sf=new StringFormat { Alignment=StringAlignment.Center, LineAlignment=StringAlignment.Center };

            // rectangles: current at y=offset, next at y=offset + Height
            RectangleF rectCur=new RectangleF(0, _offset, Width, Height);
            RectangleF rectNext=new RectangleF(0, _offset + Height, Width, Height);

            // drop shadow (simple)
            using (SolidBrush shadowBrush=new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            using (SolidBrush textBrush=new SolidBrush(ForeColor))
            {
                // draw current (shadow then text)
                RectangleF shrink=RectangleF.Inflate(rectCur, 0, -6);
                g.DrawString(curText, Font, shadowBrush, shrink, sf);
                g.DrawString(curText, Font, textBrush, rectCur, sf);

                // draw next
                RectangleF shrink2=RectangleF.Inflate(rectNext, 0, -6);
                g.DrawString(nextText, Font, shadowBrush, shrink2, sf);
                g.DrawString(nextText, Font, textBrush, rectNext, sf);
            }

            // optional visual mid-line for flip feel
            using (Pen p=new Pen(Color.FromArgb(60, 0, 0, 0)))
            {
                g.DrawLine(p, 0, Height / 2f, Width, Height / 2f);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }


    /// <summary>
    /// ساعت کامل که از چند FlipDigit تشکیل شده: HH : MM : SS
    /// </summary>
    public class FlipClock : UserControl
    {
        private FlipDigit[] digits;      // 6 digits HHMMSS
        private Label[] separators;      // 2 labels for :
        private readonly Timer secondTimer;

        public FlipClock()
        {
            DoubleBuffered=true;
            BackColor=Color.Transparent;

            InitializeDigits();

            secondTimer=new Timer { Interval=1000 };
            secondTimer.Tick += (s, e) => Tick();
            secondTimer.Start();

            // default size
            Size=new Size(210, 50);
        }

        private void InitializeDigits()
        {
            digits=new FlipDigit[6];
            separators=new Label[2];

            for (int i=0; i < digits.Length; i++)
            {
                digits[i]=new FlipDigit();
                digits[i].BackColor=Color.FromArgb(40, 140, 40);
                digits[i].ForeColor=Color.White;
                digits[i].Font=new Font("Tahoma",32f, FontStyle.Bold, GraphicsUnit.Pixel);
                digits[i].SetValueImmediate(0);
                Controls.Add(digits[i]);
            }

            for (int i=0; i < separators.Length; i++)
            {
                separators[i]=new Label
                {
                    AutoSize=false,
                    TextAlign=ContentAlignment.MiddleCenter,
                    Text=":",
                    Font=new Font("Tahoma",36f, FontStyle.Bold, GraphicsUnit.Pixel),
                    ForeColor=Color.White,
                    BackColor=Color.Transparent
                };
                Controls.Add(separators[i]);
            }

            ArrangeLayout();
            SetTimeImmediate(DateTime.Now);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ArrangeLayout();
        }

        private void ArrangeLayout()
        {
            // compute height from control height (leave some padding)
            int h=Math.Max(40, Height - 4);
            int digitW=(int)(h * 0.65);
            int gap=Math.Max(6, (int)(digitW * 0.12));

            int x=0;
            for (int i=0; i < 2; i++)
            {
                digits[i].Size=new Size(digitW, h);
                digits[i].Location=new Point(x, 0);
                x += digitW + gap;
            }

            separators[0].Size=new Size((int)(digitW * 0.35), h);
            separators[0].Location=new Point(x, 0);
            x += separators[0].Width + gap;

            for (int i=2; i < 4; i++)
            {
                digits[i].Size=new Size(digitW, h);
                digits[i].Location=new Point(x, 0);
                x += digitW + gap;
            }

            separators[1].Size=new Size((int)(digitW * 0.35), h);
            separators[1].Location=new Point(x, 0);
            x += separators[1].Width + gap;

            for (int i=4; i < 6; i++)
            {
                digits[i].Size=new Size(digitW, h);
                digits[i].Location=new Point(x, 0);
                x += digitW + gap;
            }

            // optionally set control width to content
            Width=x;
            foreach (Label s in separators)
            {
                s.ForeColor=digits[0].ForeColor;
            }
        }

        /// <summary>
        /// فورس ست بدون انیمیشن
        /// </summary>
        public void SetTimeImmediate(DateTime dt)
        {
            string parts=dt.ToString("HHmmss");
            for (int i=0; i < parts.Length && i < digits.Length; i++)
            {
                int v=int.Parse(parts[i].ToString());
                digits[i].SetValueImmediate(v);
            }
        }

        private void Tick()
        {
            DateTime now=DateTime.Now;
            string t=now.ToString("HHmmss");

            for (int i=0; i < t.Length && i < digits.Length; i++)
            {
                int newVal=int.Parse(t[i].ToString());
                if (digits[i].Current != newVal)
                {
                    // assign -> will animate
                    digits[i].Value=newVal;
                }
            }
        }

        /// <summary>
        /// Start/Stop public APIs
        /// </summary>
        public void Start() => secondTimer?.Start();
        public void Stop() => secondTimer?.Stop();

        /// <summary>
        /// Allow customizing colors/fonts externally
        /// </summary>
        public Color DigitBackColor
        {
            get => digits.Length > 0 ? digits[0].BackColor : Color.FromArgb(40, 40, 40);
            set { foreach (FlipDigit d in digits) { if (d != null) { d.BackColor=value; } } Invalidate(); }
        }

        public Color DigitForeColor
        {
            get => digits.Length > 0 ? digits[0].ForeColor : Color.White;
            set { foreach (FlipDigit d in digits) { if (d != null) { d.ForeColor=value; } } foreach (Label s in separators) { if (s != null) { s.ForeColor=value; } } Invalidate(); }
        }

        public int DigitAnimSpeed
        {
            get => digits.Length > 0 ? digits[0].AnimSpeed : 12;
            set { foreach (FlipDigit d in digits)
                {
                    if (d != null)
                    {
                        d.AnimSpeed=value;
                    }
                }
            }
        }
    }
}