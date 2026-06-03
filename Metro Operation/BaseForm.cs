using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class BaseForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // ================================
        //           THEME PALETTE
        // ================================

        public static readonly Color FormBackColor = Color.FromArgb(240, 242, 245); // سفیدِ خیلی روشن
        public static readonly Color ControlBack = Color.FromArgb(248, 249, 250); // خاکستری خیلی روشن
        public static readonly Color ControlHover = Color.FromArgb(218, 221, 225); // طوسی روشن هنگام هاور
        public static readonly Color ControlDisable = Color.FromArgb(200, 202, 205); // خاکستری

        // Accent ها (جایگزین Primary های آبی)
        public static readonly Color PrimaryDark = Color.FromArgb(55, 55, 55); // خاکستری تیره (دکمه مهم)
        public static readonly Color PrimaryLight = Color.FromArgb(85, 85, 85); // روشن‌تر
        public static readonly Color PrimaryUltra = Color.FromArgb(230, 230, 230); // خاکستری روشن (برای انتخاب‌ها)

        // Accent های تعاملی
        public static readonly Color AccentNormal = Color.FromArgb(140, 220, 250); //Color.FromArgb(120, 200, 250); // متن/آیکن
        public static readonly Color AccentHover = Color.FromArgb(70, 160, 240); //Color.FromArgb(40, 130, 220);
        public static readonly Color AccentLight = Color.FromArgb(220, 220, 220); // خاکستری روشن برای انتخاب

        // Text
        public static readonly Color TextMain = Color.FromArgb(20, 20, 20);
        public static readonly Color TextSecondary = Color.FromArgb(95, 95, 95);
        public static readonly Color TextWhite = Color.White;

        // Border + Shadow
        public static readonly Color BorderLight = Color.FromArgb(200, 205, 210);
        public static readonly Color ShadowColor = Color.FromArgb(170, 170, 180);

        // Grid
        public static readonly Color HeadColor = Color.FromArgb(220, 216, 204);
        public static readonly Color RowBackColor = ControlBack;
        public static readonly Color SelectedRowColor = AccentLight;
        public static readonly Color SelectedRowText = TextMain;
        // public static Color DefaultColor;

        public BaseForm()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            BackColor = FormBackColor;

            Load += BaseForm_Load;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            BackColor = FormBackColor;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
            ApplyModernStyle(Controls);
        }

        private void ApplyRoundedCorners()
        {
            SetRoundedRegion(this, 12);
            Resize += (s, e) => SetRoundedRegion(this, 12);
        }

        private void SetRoundedRegion(Control ctrl, int radius)
        {
            if (ctrl.Width > 0 && ctrl.Height > 0)
            {
                ctrl.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, radius, radius)
                );
            }
        }

        // ================================
        //         STYLE ENGINE
        // ================================
        private void ApplyModernStyle(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                // ----------------- BUTTON -----------------
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.UseVisualStyleBackColor = true;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.BackColor = AccentNormal;
                    btn.ForeColor = TextMain;// TextWhite;
                    btn.Font = FontManager.IranSans();
                    btn.Cursor = Cursors.Hand;

                    SetRoundedRegion(btn, 10);
                    btn.Resize += (s, e) => SetRoundedRegion(btn, 10);

                    btn.MouseEnter += (s, e) => { btn.BackColor = AccentHover; btn.ForeColor = TextWhite; };
                    btn.MouseLeave += (s, e) => { btn.BackColor = AccentNormal; btn.ForeColor = TextMain; };
                }

                // ----------------- TEXTBOX -----------------
                else if (ctrl is TextBox txt)
                {
                    txt.Multiline = true;
                    txt.BorderStyle = BorderStyle.None;
                    txt.BackColor = ControlBack;
                    txt.ForeColor = TextMain;
                    txt.Font = FontManager.Gandom();
                    txt.Height = 25;
                    txt.TextAlign = HorizontalAlignment.Left;

                    SetRoundedRegion(txt, 10);
                    txt.Resize += (s, e) => SetRoundedRegion(txt, 10);

                    txt.Enter += (s, e) => txt.BackColor = ControlHover;
                    txt.Leave += (s, e) => txt.BackColor = ControlBack;
                }

                // ----------------- MASKED TEXTBOX -----------------
                else if (ctrl is MaskedTextBox mtxt)
                {
                    mtxt.BorderStyle = BorderStyle.None;
                    mtxt.BackColor = ControlBack;
                    mtxt.ForeColor = TextMain;
                    mtxt.Multiline = true;
                    mtxt.Height = 45;
                    mtxt.TextAlign = HorizontalAlignment.Center;
                    mtxt.Font = FontManager.Gandom(12);

                    SetRoundedRegion(mtxt, 10);
                    mtxt.Resize += (s, e) => SetRoundedRegion(mtxt, 10);

                    mtxt.Enter += (s, e) => mtxt.BackColor = ControlHover;
                    mtxt.Leave += (s, e) => mtxt.BackColor = ControlBack;
                }

                // ----------------- PANEL -----------------
                else if (ctrl is Panel pnl)
                {
                    pnl.BackColor = PrimaryUltra;
                    pnl.BorderStyle = BorderStyle.None;
                    SetRoundedRegion(pnl, 10);
                    pnl.Resize += (s, e) => SetRoundedRegion(pnl, 10);
                }

                // ----------------- PictureBox -----------------
                else if (ctrl is PictureBox pic)
                {
                    SetRoundedRegion(pic, 10);
                    pic.Resize += (s, e) => SetRoundedRegion(pic, 10);
                }

                // ----------------- LABEL -----------------
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = TextMain;
                    lbl.BackColor = Color.Transparent;
                    lbl.Font = FontManager.Gandom(10);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    SetRoundedRegion(lbl, 10);
                    lbl.Resize += (s, e) => SetRoundedRegion(lbl, 10);
                }

                // ----------------- COMBOBOX -----------------
                else if (ctrl is ComboBox cb)
                {
                    cb.BackColor = ControlBack;
                    cb.ForeColor = TextMain;
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.Font = FontManager.Gandom();

                    SetRoundedRegion(cb, 10);
                    cb.Resize += (s, e) => SetRoundedRegion(cb, 10);

                    cb.Enter += (s, e) => cb.BackColor = ControlHover;
                    cb.Leave += (s, e) => cb.BackColor = ControlBack;
                }

                // ----------------- CHECKBOX / RADIO -----------------
                else if (ctrl is CheckBox chk)
                {
                    chk.ForeColor = TextMain;
                    chk.Font = FontManager.Gandom(10);
                }
                else if (ctrl is RadioButton rb)
                {
                    rb.ForeColor = TextMain;
                    rb.Font = FontManager.Gandom(10);
                }

                // ----------------- DATAGRIDVIEW -----------------
                else if (ctrl is DataGridView dgv)
                {
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.BackgroundColor = ControlBack;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = HeadColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = TextMain;
                    dgv.ColumnHeadersDefaultCellStyle.Font = FontManager.IranSans(9);
                    dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgv.ColumnHeadersHeight = 40;

                    dgv.RowsDefaultCellStyle.BackColor = ControlBack;
                    dgv.RowsDefaultCellStyle.ForeColor = TextMain;
                    dgv.RowsDefaultCellStyle.Font = FontManager.Gandom();

                    dgv.AlternatingRowsDefaultCellStyle.BackColor = ControlHover;
                    dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextMain;

                    dgv.RowsDefaultCellStyle.SelectionBackColor = AccentNormal;
                    dgv.RowsDefaultCellStyle.SelectionForeColor = TextMain;

                    dgv.RowTemplate.Height = 27;
                    dgv.GridColor = PrimaryDark;

                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    SetRoundedRegion(dgv, 10);
                    dgv.Resize += (s, e) => SetRoundedRegion(dgv, 10);
                }

                // ----------------- TAB CONTROL -----------------
                if (ctrl is TabControl tab)
                {
                    tab.DrawMode = TabDrawMode.Normal;
                    tab.Appearance = TabAppearance.Normal;
                    tab.SizeMode = TabSizeMode.Normal;
                    tab.Font = FontManager.Gandom();
                    tab.ItemSize = new Size(tab.ItemSize.Width + 120, 28);
                    tab.RightToLeft = RightToLeft.Yes;
                    tab.RightToLeftLayout = true;
                    //tab.DrawMode=TabDrawMode.OwnerDrawFixed;


                    foreach (TabPage page in tab.TabPages)
                    {
                        page.BackColor = Color.LightSteelBlue;
                        page.ForeColor = TextMain;

                        page.Paint += (s, e) =>
                        {
                            using (SolidBrush br = new SolidBrush(Color.FromArgb(212, 224, 242)))
                            {
                                e.Graphics.FillRectangle(br, page.ClientRectangle);
                            }
                        };
                    }

                    tab.DrawItem += (s, e) =>
                    {
                        Graphics g = e.Graphics;
                        bool selected = tab.SelectedIndex == e.Index;

                        Rectangle rect = e.Bounds;
                        rect.Inflate(-2, -2);

                        Color back = selected ? PrimaryLight : ControlBack;

                        using (SolidBrush br = new SolidBrush(back))
                        {
                            g.FillRectangle(br, rect);
                        }

                        string text = tab.TabPages[e.Index].Text;
                        using (SolidBrush br = new SolidBrush(TextMain))
                        {
                            StringFormat sf = new StringFormat
                            {
                                Alignment = StringAlignment.Center,
                                LineAlignment = StringAlignment.Center
                            };

                            if (tab.RightToLeftLayout)
                            {
                                sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                            }

                            g.DrawString(text, tab.Font, br, rect, sf);
                        }
                    };
                }

                // اجرای استایل روی کنترل‌های داخل هر کنترل
                if (ctrl.HasChildren)
                {
                    ApplyModernStyle(ctrl.Controls);
                }
            }
        }
    }
}

