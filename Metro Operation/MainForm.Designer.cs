using System.Drawing;
using System.Windows.Forms;


namespace Metro_Operation
{
    public partial class MainForm : BaseForm
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


        //public MainForm()
        //{
        //    this.SetStyle((ControlStyles)(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint), true);
        //    this.UpdateStyles();

        //    // This call is required by the designer.
        //    InitializeComponent();

        //    // Add any initialization after the InitializeComponent() call.

        //}


        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.کارکردپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقویمکاریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکارشیفتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کارکردماهانهپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem01 = new System.Windows.Forms.ToolStripSeparator();
            this.مرخصیروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرخصیروزانهجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرخصیروزانهویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem04 = new System.Windows.Forms.ToolStripSeparator();
            this.مرخصیروزانهگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرخصیساعتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرخصیساعتیجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرخصیساعتیویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem05 = new System.Windows.Forms.ToolStripSeparator();
            this.مرخصیساعتیگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امتیازانضباطیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امتیازانضباطیثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امتیازانضباطیویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem06 = new System.Windows.Forms.ToolStripSeparator();
            this.امتیازانضباطیگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکارجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکارگروهیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکارویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem07 = new System.Windows.Forms.ToolStripSeparator();
            this.اضافهکارگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem02 = new System.Windows.Forms.ToolStripSeparator();
            this.درخواستاضافهکارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.درخواستاضافهکارجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.درخواستاضافهکارویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem08 = new System.Windows.Forms.ToolStripSeparator();
            this.درخواستاضافهکارگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کشیکماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.درخواستکشیکماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جابجاییکشیکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem09 = new System.Windows.Forms.ToolStripSeparator();
            this.لیستکشیکماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کارکردراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تریپهایخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهبرانرزروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تریپروزانهراهبرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem03 = new System.Windows.Forms.ToolStripSeparator();
            this.نمایشاطلاعیههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پارکینگومانورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آرایشناوگانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آرایشناوگانثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آرایشناوگانویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.آرایشناوگانگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تاریخچهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.وضعیتپارکینگToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.عملیاتقطارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازشلوحهروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem21 = new System.Windows.Forms.ToolStripSeparator();
            this.عملیاتقطارجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طبقجدولاعزامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خارجازجدولاعزامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتقطارویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.عملیاتقطارگزارشعملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتقطارگزارشراهبریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازشلوحهپایانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتجدولحرکتیدستیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتجدولحرکتیازفایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشجدولحرکتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الگویتریپراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پارامترهایپردازشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتمانورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتمانورجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پایشفنیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دورههایبازآموزیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دورههایبازآموزیثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دورههایبازآموزیویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.دورههایبازآموزیگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعلامخرابیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعلامخرابیثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعلامخرابیویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.اعلامخرابیگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملکردفنیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملکردفنیثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملکردفنیویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.عملکردفنیگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعیهآموزشیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعیهآموزشیثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعیهآموزشیویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پذیرشواعزامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اولویترزروراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اولویتتریپرزروهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اولویتاضافهکارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مجموعتریپراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem19 = new System.Windows.Forms.ToolStripSeparator();
            this.تحویلوتحولقطارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملکردروزانهراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.درخواستسرویسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.آخرینتغییراتپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملکردروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جابجاییتریپراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازشلوحهاعزامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازشلوحهروزانهToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازشلوحههشتگردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازش2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem20 = new System.Windows.Forms.ToolStripSeparator();
            this.ویرایشکشیکماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تکتریپToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رزرواضطراریراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رزروراهبران9ساعتهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.لوحهروزانهراهبریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتلوحهاولیهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتلوحهاجراشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتلوحهنهاییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem22 = new System.Windows.Forms.ToolStripSeparator();
            this.گزارشلوحهثبتشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پارامترهایپردازشلوحهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پارامترهایپردازشلوحهجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پارامترهایپردازشلوحهویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رزروراهبران12ساعتهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرسنلعملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرسنلجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرسنلویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem25 = new System.Windows.Forms.ToolStripSeparator();
            this.پرسنلگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مجوزپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مجوزویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem26 = new System.Windows.Forms.ToolStripSeparator();
            this.مجوزگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشجزییاتپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.ویرایشمشخصاتفردیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.شرکتدرانتخاباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نتیجهانتخاباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem24 = new System.Windows.Forms.ToolStripSeparator();
            this.دفترتلفنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتخودکارکشیکماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.ثبتاطلاعیهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتانتخاباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییراتلوحهاعزامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نظرسنجیوآزمونپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتنظرسنجیجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انجامنظرسنجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.نتایجنظرسنجیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتآزمونجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.سقفاضافهکارپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.محاسبهکارکردراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتلوحهاعزامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.کارکردماهانهراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کارکردروزانهراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تریپدرشیفتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بررسیمواردثبتشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بررسیکارکردویرایششدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.برسیامتیازهایویراششدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بررسیئرخواستاضافهکارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem27 = new System.Windows.Forms.ToolStripSeparator();
            this.گزارشمدیریتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاتتفکیکیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشتفکیکیاضافهکارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشآمارماهانهپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشآماریشیفتهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارکشیکراهبرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشعملکردنرمافزارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشامتیازپرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملکردراهبرانرزروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آلبومپرسنلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.نمودارروزانهاضافهکارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمودارمرخصیروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشاطلاعیههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.درخواستکشیکماهانهگزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تریپهایروزانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کاربرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کاربرجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشمشخصاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.تغییرکلمهعبورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ریسترمزکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کمکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem23 = new System.Windows.Forms.ToolStripSeparator();
            this.تماسباادمینToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادمینToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پردازشماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بارگذاریمجدددادههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.تقویمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتنسخهجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErorrLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سابقهجابجاییشیفتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعیهالکترونیکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بهینهسازیتریپToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اجرایمجددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آمارراهبراندرکشیکماهانهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PostStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AdrsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.VersStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayList = new System.Windows.Forms.ListBox();
            this.PerPicture = new System.Windows.Forms.PictureBox();
            this.ErrorLogoBox = new System.Windows.Forms.RichTextBox();
            this.TrdLabel = new System.Windows.Forms.Label();
            this.TrialLabel = new System.Windows.Forms.Label();
            this.newPanel1 = new Metro_Operation.NewPanel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DateLabelPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerPicture)).BeginInit();
            this.DateLabelPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کارکردپرسنلToolStripMenuItem,
            this.پارکینگومانورToolStripMenuItem,
            this.پایشفنیToolStripMenuItem,
            this.پذیرشواعزامToolStripMenuItem,
            this.پردازشلوحهاعزامToolStripMenuItem,
            this.پرسنلToolStripMenuItem,
            this.مدیریتToolStripMenuItem,
            this.گزارشمدیریتیToolStripMenuItem,
            this.کاربرToolStripMenuItem,
            this.راهنماییToolStripMenuItem,
            this.ادمینToolStripMenuItem,
            this.خروجToolStripMenuItem,
            this.اجرایمجددToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMenu.Size = new System.Drawing.Size(1116, 30);
            this.MainMenu.TabIndex = 0;
            // 
            // کارکردپرسنلToolStripMenuItem
            // 
            this.کارکردپرسنلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تقویمکاریToolStripMenuItem,
            this.اضافهکارشیفتToolStripMenuItem,
            this.کارکردماهانهپرسنلToolStripMenuItem,
            this.ToolStripMenuItem01,
            this.مرخصیروزانهToolStripMenuItem,
            this.مرخصیساعتیToolStripMenuItem,
            this.امتیازانضباطیToolStripMenuItem,
            this.اضافهکارToolStripMenuItem,
            this.ToolStripMenuItem02,
            this.درخواستاضافهکارToolStripMenuItem,
            this.کشیکماهانهToolStripMenuItem,
            this.کارکردراهبرانToolStripMenuItem,
            this.ToolStripMenuItem03,
            this.نمایشاطلاعیههاToolStripMenuItem});
            this.کارکردپرسنلToolStripMenuItem.Name = "کارکردپرسنلToolStripMenuItem";
            this.کارکردپرسنلToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.کارکردپرسنلToolStripMenuItem.Text = "کارکرد پرسنل";
            // 
            // تقویمکاریToolStripMenuItem
            // 
            this.تقویمکاریToolStripMenuItem.Name = "تقویمکاریToolStripMenuItem";
            this.تقویمکاریToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.تقویمکاریToolStripMenuItem.Text = "تقویم کاری";
            this.تقویمکاریToolStripMenuItem.Click += new System.EventHandler(this.تقویمکاریToolStripMenuItem_Click);
            // 
            // اضافهکارشیفتToolStripMenuItem
            // 
            this.اضافهکارشیفتToolStripMenuItem.Name = "اضافهکارشیفتToolStripMenuItem";
            this.اضافهکارشیفتToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.اضافهکارشیفتToolStripMenuItem.Text = "اضافه کار شیفت";
            this.اضافهکارشیفتToolStripMenuItem.Click += new System.EventHandler(this.اضافهکارشیفتToolStripMenuItem_Click);
            // 
            // کارکردماهانهپرسنلToolStripMenuItem
            // 
            this.کارکردماهانهپرسنلToolStripMenuItem.Name = "کارکردماهانهپرسنلToolStripMenuItem";
            this.کارکردماهانهپرسنلToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.کارکردماهانهپرسنلToolStripMenuItem.Text = "کارکرد ماهانه پرسنل";
            this.کارکردماهانهپرسنلToolStripMenuItem.Click += new System.EventHandler(this.محاسبهکارکردجدیدپرسنلToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem01
            // 
            this.ToolStripMenuItem01.Name = "ToolStripMenuItem01";
            this.ToolStripMenuItem01.Size = new System.Drawing.Size(169, 6);
            // 
            // مرخصیروزانهToolStripMenuItem
            // 
            this.مرخصیروزانهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مرخصیروزانهجدیدToolStripMenuItem,
            this.مرخصیروزانهویرایشToolStripMenuItem,
            this.ToolStripMenuItem04,
            this.مرخصیروزانهگزارشToolStripMenuItem});
            this.مرخصیروزانهToolStripMenuItem.Name = "مرخصیروزانهToolStripMenuItem";
            this.مرخصیروزانهToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.مرخصیروزانهToolStripMenuItem.Text = "مرخصی روزانه";
            // 
            // مرخصیروزانهجدیدToolStripMenuItem
            // 
            this.مرخصیروزانهجدیدToolStripMenuItem.Name = "مرخصیروزانهجدیدToolStripMenuItem";
            this.مرخصیروزانهجدیدToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مرخصیروزانهجدیدToolStripMenuItem.Text = "جدید";
            this.مرخصیروزانهجدیدToolStripMenuItem.Click += new System.EventHandler(this.مرخصیروزانهجدیدToolStripMenuItem_Click);
            // 
            // مرخصیروزانهویرایشToolStripMenuItem
            // 
            this.مرخصیروزانهویرایشToolStripMenuItem.Name = "مرخصیروزانهویرایشToolStripMenuItem";
            this.مرخصیروزانهویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مرخصیروزانهویرایشToolStripMenuItem.Text = "ویرایش";
            this.مرخصیروزانهویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem04
            // 
            this.ToolStripMenuItem04.Name = "ToolStripMenuItem04";
            this.ToolStripMenuItem04.Size = new System.Drawing.Size(107, 6);
            // 
            // مرخصیروزانهگزارشToolStripMenuItem
            // 
            this.مرخصیروزانهگزارشToolStripMenuItem.Name = "مرخصیروزانهگزارشToolStripMenuItem";
            this.مرخصیروزانهگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مرخصیروزانهگزارشToolStripMenuItem.Text = "گزارش";
            this.مرخصیروزانهگزارشToolStripMenuItem.Click += new System.EventHandler(this.گزارشToolStripMenuItem_Click);
            // 
            // مرخصیساعتیToolStripMenuItem
            // 
            this.مرخصیساعتیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مرخصیساعتیجدیدToolStripMenuItem,
            this.مرخصیساعتیویرایشToolStripMenuItem,
            this.ToolStripMenuItem05,
            this.مرخصیساعتیگزارشToolStripMenuItem});
            this.مرخصیساعتیToolStripMenuItem.Name = "مرخصیساعتیToolStripMenuItem";
            this.مرخصیساعتیToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.مرخصیساعتیToolStripMenuItem.Text = "مرخصی ساعتی";
            // 
            // مرخصیساعتیجدیدToolStripMenuItem
            // 
            this.مرخصیساعتیجدیدToolStripMenuItem.Name = "مرخصیساعتیجدیدToolStripMenuItem";
            this.مرخصیساعتیجدیدToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مرخصیساعتیجدیدToolStripMenuItem.Text = "جدید";
            this.مرخصیساعتیجدیدToolStripMenuItem.Click += new System.EventHandler(this.مرخصیساعتیجدیدToolStripMenuItem_Click);
            // 
            // مرخصیساعتیویرایشToolStripMenuItem
            // 
            this.مرخصیساعتیویرایشToolStripMenuItem.Name = "مرخصیساعتیویرایشToolStripMenuItem";
            this.مرخصیساعتیویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مرخصیساعتیویرایشToolStripMenuItem.Text = "ویرایش";
            this.مرخصیساعتیویرایشToolStripMenuItem.Click += new System.EventHandler(this.مرخصیساعتیویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem05
            // 
            this.ToolStripMenuItem05.Name = "ToolStripMenuItem05";
            this.ToolStripMenuItem05.Size = new System.Drawing.Size(107, 6);
            // 
            // مرخصیساعتیگزارشToolStripMenuItem
            // 
            this.مرخصیساعتیگزارشToolStripMenuItem.Name = "مرخصیساعتیگزارشToolStripMenuItem";
            this.مرخصیساعتیگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مرخصیساعتیگزارشToolStripMenuItem.Text = "گزارش";
            this.مرخصیساعتیگزارشToolStripMenuItem.Click += new System.EventHandler(this.مرخصیساعتیگزارشToolStripMenuItem_Click);
            // 
            // امتیازانضباطیToolStripMenuItem
            // 
            this.امتیازانضباطیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.امتیازانضباطیثبتToolStripMenuItem,
            this.امتیازانضباطیویرایشToolStripMenuItem,
            this.ToolStripMenuItem06,
            this.امتیازانضباطیگزارشToolStripMenuItem});
            this.امتیازانضباطیToolStripMenuItem.Name = "امتیازانضباطیToolStripMenuItem";
            this.امتیازانضباطیToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.امتیازانضباطیToolStripMenuItem.Text = "امتیاز انضباطی";
            // 
            // امتیازانضباطیثبتToolStripMenuItem
            // 
            this.امتیازانضباطیثبتToolStripMenuItem.Name = "امتیازانضباطیثبتToolStripMenuItem";
            this.امتیازانضباطیثبتToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.امتیازانضباطیثبتToolStripMenuItem.Text = "ثبت";
            this.امتیازانضباطیثبتToolStripMenuItem.Click += new System.EventHandler(this.امتیازانضباطیثبتToolStripMenuItem_Click);
            // 
            // امتیازانضباطیویرایشToolStripMenuItem
            // 
            this.امتیازانضباطیویرایشToolStripMenuItem.Name = "امتیازانضباطیویرایشToolStripMenuItem";
            this.امتیازانضباطیویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.امتیازانضباطیویرایشToolStripMenuItem.Text = "ویرایش";
            this.امتیازانضباطیویرایشToolStripMenuItem.Click += new System.EventHandler(this.امتیازانضباطیویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem06
            // 
            this.ToolStripMenuItem06.Name = "ToolStripMenuItem06";
            this.ToolStripMenuItem06.Size = new System.Drawing.Size(107, 6);
            // 
            // امتیازانضباطیگزارشToolStripMenuItem
            // 
            this.امتیازانضباطیگزارشToolStripMenuItem.Name = "امتیازانضباطیگزارشToolStripMenuItem";
            this.امتیازانضباطیگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.امتیازانضباطیگزارشToolStripMenuItem.Text = "گزارش";
            this.امتیازانضباطیگزارشToolStripMenuItem.Click += new System.EventHandler(this.امتیازانضباطیگزارشToolStripMenuItem_Click);
            // 
            // اضافهکارToolStripMenuItem
            // 
            this.اضافهکارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهکارجدیدToolStripMenuItem,
            this.اضافهکارگروهیToolStripMenuItem,
            this.اضافهکارویرایشToolStripMenuItem,
            this.ToolStripMenuItem07,
            this.اضافهکارگزارشToolStripMenuItem});
            this.اضافهکارToolStripMenuItem.Name = "اضافهکارToolStripMenuItem";
            this.اضافهکارToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.اضافهکارToolStripMenuItem.Text = "اضافه کار";
            // 
            // اضافهکارجدیدToolStripMenuItem
            // 
            this.اضافهکارجدیدToolStripMenuItem.Name = "اضافهکارجدیدToolStripMenuItem";
            this.اضافهکارجدیدToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.اضافهکارجدیدToolStripMenuItem.Text = "جدید";
            this.اضافهکارجدیدToolStripMenuItem.Click += new System.EventHandler(this.اضافهکارجدیدToolStripMenuItem_Click);
            // 
            // اضافهکارگروهیToolStripMenuItem
            // 
            this.اضافهکارگروهیToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.اضافهکارگروهیToolStripMenuItem.Name = "اضافهکارگروهیToolStripMenuItem";
            this.اضافهکارگروهیToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.اضافهکارگروهیToolStripMenuItem.Text = "اضافه کار گروهی";
            this.اضافهکارگروهیToolStripMenuItem.Click += new System.EventHandler(this.اضافهکارگروهیToolStripMenuItem_Click);
            // 
            // اضافهکارویرایشToolStripMenuItem
            // 
            this.اضافهکارویرایشToolStripMenuItem.Name = "اضافهکارویرایشToolStripMenuItem";
            this.اضافهکارویرایشToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.اضافهکارویرایشToolStripMenuItem.Text = "ویرایش";
            this.اضافهکارویرایشToolStripMenuItem.Click += new System.EventHandler(this.اضافهکارویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem07
            // 
            this.ToolStripMenuItem07.Name = "ToolStripMenuItem07";
            this.ToolStripMenuItem07.Size = new System.Drawing.Size(155, 6);
            // 
            // اضافهکارگزارشToolStripMenuItem
            // 
            this.اضافهکارگزارشToolStripMenuItem.Name = "اضافهکارگزارشToolStripMenuItem";
            this.اضافهکارگزارشToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.اضافهکارگزارشToolStripMenuItem.Text = "گزارش";
            this.اضافهکارگزارشToolStripMenuItem.Click += new System.EventHandler(this.اضافهکارگزارشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem02
            // 
            this.ToolStripMenuItem02.Name = "ToolStripMenuItem02";
            this.ToolStripMenuItem02.Size = new System.Drawing.Size(169, 6);
            // 
            // درخواستاضافهکارToolStripMenuItem
            // 
            this.درخواستاضافهکارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.درخواستاضافهکارجدیدToolStripMenuItem,
            this.درخواستاضافهکارویرایشToolStripMenuItem,
            this.ToolStripMenuItem08,
            this.درخواستاضافهکارگزارشToolStripMenuItem});
            this.درخواستاضافهکارToolStripMenuItem.Name = "درخواستاضافهکارToolStripMenuItem";
            this.درخواستاضافهکارToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.درخواستاضافهکارToolStripMenuItem.Text = "درخواست اضافه کار";
            // 
            // درخواستاضافهکارجدیدToolStripMenuItem
            // 
            this.درخواستاضافهکارجدیدToolStripMenuItem.Name = "درخواستاضافهکارجدیدToolStripMenuItem";
            this.درخواستاضافهکارجدیدToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.درخواستاضافهکارجدیدToolStripMenuItem.Text = "جدید";
            this.درخواستاضافهکارجدیدToolStripMenuItem.Click += new System.EventHandler(this.درخواستاضافهکارجدیدToolStripMenuItem_Click);
            // 
            // درخواستاضافهکارویرایشToolStripMenuItem
            // 
            this.درخواستاضافهکارویرایشToolStripMenuItem.Name = "درخواستاضافهکارویرایشToolStripMenuItem";
            this.درخواستاضافهکارویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.درخواستاضافهکارویرایشToolStripMenuItem.Text = "ویرایش";
            this.درخواستاضافهکارویرایشToolStripMenuItem.Click += new System.EventHandler(this.درخواستاضافهکارویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem08
            // 
            this.ToolStripMenuItem08.Name = "ToolStripMenuItem08";
            this.ToolStripMenuItem08.Size = new System.Drawing.Size(107, 6);
            // 
            // درخواستاضافهکارگزارشToolStripMenuItem
            // 
            this.درخواستاضافهکارگزارشToolStripMenuItem.Name = "درخواستاضافهکارگزارشToolStripMenuItem";
            this.درخواستاضافهکارگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.درخواستاضافهکارگزارشToolStripMenuItem.Text = "گزارش";
            this.درخواستاضافهکارگزارشToolStripMenuItem.Click += new System.EventHandler(this.درخواستاضافهکارگزارشToolStripMenuItem_Click);
            // 
            // کشیکماهانهToolStripMenuItem
            // 
            this.کشیکماهانهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.درخواستکشیکماهانهToolStripMenuItem,
            this.جابجاییکشیکToolStripMenuItem,
            this.ToolStripMenuItem09,
            this.لیستکشیکماهانهToolStripMenuItem});
            this.کشیکماهانهToolStripMenuItem.Name = "کشیکماهانهToolStripMenuItem";
            this.کشیکماهانهToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.کشیکماهانهToolStripMenuItem.Text = "کشیک ماهانه";
            // 
            // درخواستکشیکماهانهToolStripMenuItem
            // 
            this.درخواستکشیکماهانهToolStripMenuItem.Name = "درخواستکشیکماهانهToolStripMenuItem";
            this.درخواستکشیکماهانهToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.درخواستکشیکماهانهToolStripMenuItem.Text = "درخواست کشیک";
            this.درخواستکشیکماهانهToolStripMenuItem.Click += new System.EventHandler(this.درخواستکشیکماهانهToolStripMenuItem_Click);
            // 
            // جابجاییکشیکToolStripMenuItem
            // 
            this.جابجاییکشیکToolStripMenuItem.Name = "جابجاییکشیکToolStripMenuItem";
            this.جابجاییکشیکToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.جابجاییکشیکToolStripMenuItem.Text = "جابجایی کشیک";
            this.جابجاییکشیکToolStripMenuItem.Click += new System.EventHandler(this.جابجاییکشیکToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem09
            // 
            this.ToolStripMenuItem09.Name = "ToolStripMenuItem09";
            this.ToolStripMenuItem09.Size = new System.Drawing.Size(168, 6);
            // 
            // لیستکشیکماهانهToolStripMenuItem
            // 
            this.لیستکشیکماهانهToolStripMenuItem.Name = "لیستکشیکماهانهToolStripMenuItem";
            this.لیستکشیکماهانهToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.لیستکشیکماهانهToolStripMenuItem.Text = "لیست کشیک ماهانه";
            this.لیستکشیکماهانهToolStripMenuItem.Click += new System.EventHandler(this.لیستکشیکماهانهToolStripMenuItem_Click);
            // 
            // کارکردراهبرانToolStripMenuItem
            // 
            this.کارکردراهبرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تریپهایخاصToolStripMenuItem,
            this.راهبرانرزروToolStripMenuItem,
            this.تریپروزانهراهبرToolStripMenuItem});
            this.کارکردراهبرانToolStripMenuItem.Name = "کارکردراهبرانToolStripMenuItem";
            this.کارکردراهبرانToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.کارکردراهبرانToolStripMenuItem.Text = "کارکرد راهبران";
            // 
            // تریپهایخاصToolStripMenuItem
            // 
            this.تریپهایخاصToolStripMenuItem.Name = "تریپهایخاصToolStripMenuItem";
            this.تریپهایخاصToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.تریپهایخاصToolStripMenuItem.Text = "تریپ های خاص";
            this.تریپهایخاصToolStripMenuItem.Click += new System.EventHandler(this.تریپهایخاصToolStripMenuItem_Click);
            // 
            // راهبرانرزروToolStripMenuItem
            // 
            this.راهبرانرزروToolStripMenuItem.Name = "راهبرانرزروToolStripMenuItem";
            this.راهبرانرزروToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.راهبرانرزروToolStripMenuItem.Text = "راهبران رزرو";
            this.راهبرانرزروToolStripMenuItem.Click += new System.EventHandler(this.راهبرانرزروToolStripMenuItem_Click);
            // 
            // تریپروزانهراهبرToolStripMenuItem
            // 
            this.تریپروزانهراهبرToolStripMenuItem.Name = "تریپروزانهراهبرToolStripMenuItem";
            this.تریپروزانهراهبرToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.تریپروزانهراهبرToolStripMenuItem.Text = "تریپ روزانه راهبر";
            this.تریپروزانهراهبرToolStripMenuItem.Click += new System.EventHandler(this.تریپهایروزانهToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem03
            // 
            this.ToolStripMenuItem03.Name = "ToolStripMenuItem03";
            this.ToolStripMenuItem03.Size = new System.Drawing.Size(169, 6);
            // 
            // نمایشاطلاعیههاToolStripMenuItem
            // 
            this.نمایشاطلاعیههاToolStripMenuItem.Name = "نمایشاطلاعیههاToolStripMenuItem";
            this.نمایشاطلاعیههاToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.نمایشاطلاعیههاToolStripMenuItem.Text = "نمایش اطلاعیه ها";
            this.نمایشاطلاعیههاToolStripMenuItem.Click += new System.EventHandler(this.نمایشاطلاعیههاToolStripMenuItem_Click);
            // 
            // پارکینگومانورToolStripMenuItem
            // 
            this.پارکینگومانورToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آرایشناوگانToolStripMenuItem,
            this.وضعیتپارکینگToolStripMenuItem,
            this.ToolStripMenuItem11,
            this.عملیاتقطارToolStripMenuItem,
            this.پردازشلوحهپایانهToolStripMenuItem,
            this.عملیاتمانورToolStripMenuItem});
            this.پارکینگومانورToolStripMenuItem.Name = "پارکینگومانورToolStripMenuItem";
            this.پارکینگومانورToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.پارکینگومانورToolStripMenuItem.Text = "پارکینگ و مانور";
            // 
            // آرایشناوگانToolStripMenuItem
            // 
            this.آرایشناوگانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.آرایشناوگانثبتToolStripMenuItem,
            this.آرایشناوگانویرایشToolStripMenuItem,
            this.ToolStripMenuItem10,
            this.آرایشناوگانگزارشToolStripMenuItem,
            this.تاریخچهToolStripMenuItem});
            this.آرایشناوگانToolStripMenuItem.Name = "آرایشناوگانToolStripMenuItem";
            this.آرایشناوگانToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.آرایشناوگانToolStripMenuItem.Text = "آرایش ناوگان";
            // 
            // آرایشناوگانثبتToolStripMenuItem
            // 
            this.آرایشناوگانثبتToolStripMenuItem.Name = "آرایشناوگانثبتToolStripMenuItem";
            this.آرایشناوگانثبتToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.آرایشناوگانثبتToolStripMenuItem.Text = "ثبت";
            this.آرایشناوگانثبتToolStripMenuItem.Click += new System.EventHandler(this.آرایشناوگانثبتToolStripMenuItem_Click);
            // 
            // آرایشناوگانویرایشToolStripMenuItem
            // 
            this.آرایشناوگانویرایشToolStripMenuItem.Name = "آرایشناوگانویرایشToolStripMenuItem";
            this.آرایشناوگانویرایشToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.آرایشناوگانویرایشToolStripMenuItem.Text = "ویرایش";
            this.آرایشناوگانویرایشToolStripMenuItem.Click += new System.EventHandler(this.آرایشناوگانویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(111, 6);
            // 
            // آرایشناوگانگزارشToolStripMenuItem
            // 
            this.آرایشناوگانگزارشToolStripMenuItem.Name = "آرایشناوگانگزارشToolStripMenuItem";
            this.آرایشناوگانگزارشToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.آرایشناوگانگزارشToolStripMenuItem.Text = "گزارش";
            this.آرایشناوگانگزارشToolStripMenuItem.Click += new System.EventHandler(this.آرایشناوگانگزارشToolStripMenuItem_Click);
            // 
            // تاریخچهToolStripMenuItem
            // 
            this.تاریخچهToolStripMenuItem.Name = "تاریخچهToolStripMenuItem";
            this.تاریخچهToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.تاریخچهToolStripMenuItem.Text = "تاریخچه ";
            this.تاریخچهToolStripMenuItem.Click += new System.EventHandler(this.تاریخچهToolStripMenuItem_Click);
            // 
            // وضعیتپارکینگToolStripMenuItem
            // 
            this.وضعیتپارکینگToolStripMenuItem.Name = "وضعیتپارکینگToolStripMenuItem";
            this.وضعیتپارکینگToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.وضعیتپارکینگToolStripMenuItem.Text = "وضعیت پارکینگ";
            this.وضعیتپارکینگToolStripMenuItem.Click += new System.EventHandler(this.وضعیتپارکینگToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem11
            // 
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            this.ToolStripMenuItem11.Size = new System.Drawing.Size(150, 6);
            // 
            // عملیاتقطارToolStripMenuItem
            // 
            this.عملیاتقطارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پردازشلوحهروزانهToolStripMenuItem,
            this.ToolStripMenuItem21,
            this.عملیاتقطارجدیدToolStripMenuItem,
            this.عملیاتقطارویرایشToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.عملیاتقطارگزارشعملیاتToolStripMenuItem,
            this.عملیاتقطارگزارشراهبریToolStripMenuItem});
            this.عملیاتقطارToolStripMenuItem.Name = "عملیاتقطارToolStripMenuItem";
            this.عملیاتقطارToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.عملیاتقطارToolStripMenuItem.Text = "عملیات پارکینگ";
            // 
            // پردازشلوحهروزانهToolStripMenuItem
            // 
            this.پردازشلوحهروزانهToolStripMenuItem.Name = "پردازشلوحهروزانهToolStripMenuItem";
            this.پردازشلوحهروزانهToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.پردازشلوحهروزانهToolStripMenuItem.Text = "پردازش لوحه روزانه";
            this.پردازشلوحهروزانهToolStripMenuItem.Click += new System.EventHandler(this.پردازشلوحهروزانهToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem21
            // 
            this.ToolStripMenuItem21.Name = "ToolStripMenuItem21";
            this.ToolStripMenuItem21.Size = new System.Drawing.Size(162, 6);
            this.ToolStripMenuItem21.Visible = false;
            // 
            // عملیاتقطارجدیدToolStripMenuItem
            // 
            this.عملیاتقطارجدیدToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طبقجدولاعزامToolStripMenuItem,
            this.خارجازجدولاعزامToolStripMenuItem});
            this.عملیاتقطارجدیدToolStripMenuItem.Name = "عملیاتقطارجدیدToolStripMenuItem";
            this.عملیاتقطارجدیدToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.عملیاتقطارجدیدToolStripMenuItem.Text = "جدید";
            // 
            // طبقجدولاعزامToolStripMenuItem
            // 
            this.طبقجدولاعزامToolStripMenuItem.Name = "طبقجدولاعزامToolStripMenuItem";
            this.طبقجدولاعزامToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.طبقجدولاعزامToolStripMenuItem.Text = "طبق جدول اعزام";
            this.طبقجدولاعزامToolStripMenuItem.Click += new System.EventHandler(this.طبقجدولاعزامToolStripMenuItem_Click);
            // 
            // خارجازجدولاعزامToolStripMenuItem
            // 
            this.خارجازجدولاعزامToolStripMenuItem.Name = "خارجازجدولاعزامToolStripMenuItem";
            this.خارجازجدولاعزامToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.خارجازجدولاعزامToolStripMenuItem.Text = "خارج از جدول اعزام";
            this.خارجازجدولاعزامToolStripMenuItem.Click += new System.EventHandler(this.خارجازجدولاعزامToolStripMenuItem_Click);
            // 
            // عملیاتقطارویرایشToolStripMenuItem
            // 
            this.عملیاتقطارویرایشToolStripMenuItem.Name = "عملیاتقطارویرایشToolStripMenuItem";
            this.عملیاتقطارویرایشToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.عملیاتقطارویرایشToolStripMenuItem.Text = "ویرایش";
            this.عملیاتقطارویرایشToolStripMenuItem.Click += new System.EventHandler(this.عملیاتقطارویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(162, 6);
            // 
            // عملیاتقطارگزارشعملیاتToolStripMenuItem
            // 
            this.عملیاتقطارگزارشعملیاتToolStripMenuItem.Name = "عملیاتقطارگزارشعملیاتToolStripMenuItem";
            this.عملیاتقطارگزارشعملیاتToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.عملیاتقطارگزارشعملیاتToolStripMenuItem.Text = "گزارش عملیات";
            this.عملیاتقطارگزارشعملیاتToolStripMenuItem.Click += new System.EventHandler(this.عملیاتقطارگزارشعملیاتToolStripMenuItem_Click);
            // 
            // عملیاتقطارگزارشراهبریToolStripMenuItem
            // 
            this.عملیاتقطارگزارشراهبریToolStripMenuItem.Name = "عملیاتقطارگزارشراهبریToolStripMenuItem";
            this.عملیاتقطارگزارشراهبریToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.عملیاتقطارگزارشراهبریToolStripMenuItem.Text = "گزارش راهبری";
            this.عملیاتقطارگزارشراهبریToolStripMenuItem.Click += new System.EventHandler(this.عملیاتقطارگزارشراهبریToolStripMenuItem_Click);
            // 
            // پردازشلوحهپایانهToolStripMenuItem
            // 
            this.پردازشلوحهپایانهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتجدولحرکتیدستیToolStripMenuItem,
            this.ثبتجدولحرکتیازفایلToolStripMenuItem,
            this.ویرایشجدولحرکتیToolStripMenuItem,
            this.الگویتریپراهبرانToolStripMenuItem,
            this.پارامترهایپردازشToolStripMenuItem});
            this.پردازشلوحهپایانهToolStripMenuItem.Name = "پردازشلوحهپایانهToolStripMenuItem";
            this.پردازشلوحهپایانهToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.پردازشلوحهپایانهToolStripMenuItem.Text = "لوحه پایانه";
            // 
            // ثبتجدولحرکتیدستیToolStripMenuItem
            // 
            this.ثبتجدولحرکتیدستیToolStripMenuItem.Name = "ثبتجدولحرکتیدستیToolStripMenuItem";
            this.ثبتجدولحرکتیدستیToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ثبتجدولحرکتیدستیToolStripMenuItem.Text = "ثبت جدول حرکتی ( دستی )";
            this.ثبتجدولحرکتیدستیToolStripMenuItem.Click += new System.EventHandler(this.ثبتجدولحرکتیToolStripMenuItem_Click);
            // 
            // ثبتجدولحرکتیازفایلToolStripMenuItem
            // 
            this.ثبتجدولحرکتیازفایلToolStripMenuItem.Name = "ثبتجدولحرکتیازفایلToolStripMenuItem";
            this.ثبتجدولحرکتیازفایلToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ثبتجدولحرکتیازفایلToolStripMenuItem.Text = "ثبت جدول حرکتی ( از فایل )";
            this.ثبتجدولحرکتیازفایلToolStripMenuItem.Click += new System.EventHandler(this.ثبتجدولحرکتیازفایلToolStripMenuItem_Click);
            // 
            // ویرایشجدولحرکتیToolStripMenuItem
            // 
            this.ویرایشجدولحرکتیToolStripMenuItem.Name = "ویرایشجدولحرکتیToolStripMenuItem";
            this.ویرایشجدولحرکتیToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ویرایشجدولحرکتیToolStripMenuItem.Text = "ویرایش جدول حرکتی";
            this.ویرایشجدولحرکتیToolStripMenuItem.Click += new System.EventHandler(this.ویرایشجدولحرکتیToolStripMenuItem_Click);
            // 
            // الگویتریپراهبرانToolStripMenuItem
            // 
            this.الگویتریپراهبرانToolStripMenuItem.Name = "الگویتریپراهبرانToolStripMenuItem";
            this.الگویتریپراهبرانToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.الگویتریپراهبرانToolStripMenuItem.Text = "الگوی تریپ راهبران";
            this.الگویتریپراهبرانToolStripMenuItem.Visible = false;
            this.الگویتریپراهبرانToolStripMenuItem.Click += new System.EventHandler(this.الگویتریپراهبرانToolStripMenuItem_Click);
            // 
            // پارامترهایپردازشToolStripMenuItem
            // 
            this.پارامترهایپردازشToolStripMenuItem.Name = "پارامترهایپردازشToolStripMenuItem";
            this.پارامترهایپردازشToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.پارامترهایپردازشToolStripMenuItem.Text = "پارامترهای پردازش";
            this.پارامترهایپردازشToolStripMenuItem.Visible = false;
            this.پارامترهایپردازشToolStripMenuItem.Click += new System.EventHandler(this.پارامترهایپردازشToolStripMenuItem_Click);
            // 
            // عملیاتمانورToolStripMenuItem
            // 
            this.عملیاتمانورToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتمانورجدیدToolStripMenuItem});
            this.عملیاتمانورToolStripMenuItem.Name = "عملیاتمانورToolStripMenuItem";
            this.عملیاتمانورToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.عملیاتمانورToolStripMenuItem.Text = "عملیات مانور ";
            // 
            // ثبتمانورجدیدToolStripMenuItem
            // 
            this.ثبتمانورجدیدToolStripMenuItem.Name = "ثبتمانورجدیدToolStripMenuItem";
            this.ثبتمانورجدیدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.ثبتمانورجدیدToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ثبتمانورجدیدToolStripMenuItem.Text = "ثبت مانور جدید";
            this.ثبتمانورجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتمانورجدیدToolStripMenuItem_Click);
            // 
            // پایشفنیToolStripMenuItem
            // 
            this.پایشفنیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دورههایبازآموزیToolStripMenuItem,
            this.اعلامخرابیToolStripMenuItem,
            this.عملکردفنیToolStripMenuItem,
            this.اطلاعیهآموزشیToolStripMenuItem});
            this.پایشفنیToolStripMenuItem.Name = "پایشفنیToolStripMenuItem";
            this.پایشفنیToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.پایشفنیToolStripMenuItem.Text = "پایش فنی";
            // 
            // دورههایبازآموزیToolStripMenuItem
            // 
            this.دورههایبازآموزیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دورههایبازآموزیثبتToolStripMenuItem,
            this.دورههایبازآموزیویرایشToolStripMenuItem,
            this.ToolStripMenuItem4,
            this.دورههایبازآموزیگزارشToolStripMenuItem});
            this.دورههایبازآموزیToolStripMenuItem.Name = "دورههایبازآموزیToolStripMenuItem";
            this.دورههایبازآموزیToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.دورههایبازآموزیToolStripMenuItem.Text = "دوره های بازآموزی ";
            // 
            // دورههایبازآموزیثبتToolStripMenuItem
            // 
            this.دورههایبازآموزیثبتToolStripMenuItem.Name = "دورههایبازآموزیثبتToolStripMenuItem";
            this.دورههایبازآموزیثبتToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.دورههایبازآموزیثبتToolStripMenuItem.Text = "ثبت";
            this.دورههایبازآموزیثبتToolStripMenuItem.Click += new System.EventHandler(this.دورههایبازآموزیثبتToolStripMenuItem_Click);
            // 
            // دورههایبازآموزیویرایشToolStripMenuItem
            // 
            this.دورههایبازآموزیویرایشToolStripMenuItem.Enabled = false;
            this.دورههایبازآموزیویرایشToolStripMenuItem.Name = "دورههایبازآموزیویرایشToolStripMenuItem";
            this.دورههایبازآموزیویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.دورههایبازآموزیویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(107, 6);
            // 
            // دورههایبازآموزیگزارشToolStripMenuItem
            // 
            this.دورههایبازآموزیگزارشToolStripMenuItem.Name = "دورههایبازآموزیگزارشToolStripMenuItem";
            this.دورههایبازآموزیگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.دورههایبازآموزیگزارشToolStripMenuItem.Text = "گزارش ";
            this.دورههایبازآموزیگزارشToolStripMenuItem.Click += new System.EventHandler(this.دورههایبازآموزیگزارشToolStripMenuItem_Click);
            // 
            // اعلامخرابیToolStripMenuItem
            // 
            this.اعلامخرابیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اعلامخرابیثبتToolStripMenuItem,
            this.اعلامخرابیویرایشToolStripMenuItem,
            this.ToolStripMenuItem5,
            this.اعلامخرابیگزارشToolStripMenuItem});
            this.اعلامخرابیToolStripMenuItem.Enabled = false;
            this.اعلامخرابیToolStripMenuItem.Name = "اعلامخرابیToolStripMenuItem";
            this.اعلامخرابیToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.اعلامخرابیToolStripMenuItem.Text = "اعلام خرابی";
            // 
            // اعلامخرابیثبتToolStripMenuItem
            // 
            this.اعلامخرابیثبتToolStripMenuItem.Name = "اعلامخرابیثبتToolStripMenuItem";
            this.اعلامخرابیثبتToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.اعلامخرابیثبتToolStripMenuItem.Text = "ثبت";
            this.اعلامخرابیثبتToolStripMenuItem.Click += new System.EventHandler(this.اعلامخرابیثبتToolStripMenuItem_Click);
            // 
            // اعلامخرابیویرایشToolStripMenuItem
            // 
            this.اعلامخرابیویرایشToolStripMenuItem.Name = "اعلامخرابیویرایشToolStripMenuItem";
            this.اعلامخرابیویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.اعلامخرابیویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(107, 6);
            // 
            // اعلامخرابیگزارشToolStripMenuItem
            // 
            this.اعلامخرابیگزارشToolStripMenuItem.Name = "اعلامخرابیگزارشToolStripMenuItem";
            this.اعلامخرابیگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.اعلامخرابیگزارشToolStripMenuItem.Text = "گزارش";
            // 
            // عملکردفنیToolStripMenuItem
            // 
            this.عملکردفنیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عملکردفنیثبتToolStripMenuItem,
            this.عملکردفنیویرایشToolStripMenuItem,
            this.ToolStripMenuItem6,
            this.عملکردفنیگزارشToolStripMenuItem});
            this.عملکردفنیToolStripMenuItem.Name = "عملکردفنیToolStripMenuItem";
            this.عملکردفنیToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.عملکردفنیToolStripMenuItem.Text = "عملکرد فنی";
            // 
            // عملکردفنیثبتToolStripMenuItem
            // 
            this.عملکردفنیثبتToolStripMenuItem.Name = "عملکردفنیثبتToolStripMenuItem";
            this.عملکردفنیثبتToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.عملکردفنیثبتToolStripMenuItem.Text = "ثبت";
            this.عملکردفنیثبتToolStripMenuItem.Click += new System.EventHandler(this.عملکردفنیثبتToolStripMenuItem_Click);
            // 
            // عملکردفنیویرایشToolStripMenuItem
            // 
            this.عملکردفنیویرایشToolStripMenuItem.Name = "عملکردفنیویرایشToolStripMenuItem";
            this.عملکردفنیویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.عملکردفنیویرایشToolStripMenuItem.Text = "ویرایش";
            this.عملکردفنیویرایشToolStripMenuItem.Click += new System.EventHandler(this.عملکردفنیویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(107, 6);
            // 
            // عملکردفنیگزارشToolStripMenuItem
            // 
            this.عملکردفنیگزارشToolStripMenuItem.Name = "عملکردفنیگزارشToolStripMenuItem";
            this.عملکردفنیگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.عملکردفنیگزارشToolStripMenuItem.Text = "گزارش";
            this.عملکردفنیگزارشToolStripMenuItem.Click += new System.EventHandler(this.عملکردفنیگزارشToolStripMenuItem_Click);
            // 
            // اطلاعیهآموزشیToolStripMenuItem
            // 
            this.اطلاعیهآموزشیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعیهآموزشیثبتToolStripMenuItem,
            this.اطلاعیهآموزشیویرایشToolStripMenuItem});
            this.اطلاعیهآموزشیToolStripMenuItem.Name = "اطلاعیهآموزشیToolStripMenuItem";
            this.اطلاعیهآموزشیToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.اطلاعیهآموزشیToolStripMenuItem.Text = "اطلاعیه آموزشی";
            // 
            // اطلاعیهآموزشیثبتToolStripMenuItem
            // 
            this.اطلاعیهآموزشیثبتToolStripMenuItem.Name = "اطلاعیهآموزشیثبتToolStripMenuItem";
            this.اطلاعیهآموزشیثبتToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.اطلاعیهآموزشیثبتToolStripMenuItem.Text = "ثبت";
            this.اطلاعیهآموزشیثبتToolStripMenuItem.Click += new System.EventHandler(this.اطلاعیهآموزشیثبتToolStripMenuItem_Click);
            // 
            // اطلاعیهآموزشیویرایشToolStripMenuItem
            // 
            this.اطلاعیهآموزشیویرایشToolStripMenuItem.Name = "اطلاعیهآموزشیویرایشToolStripMenuItem";
            this.اطلاعیهآموزشیویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.اطلاعیهآموزشیویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // پذیرشواعزامToolStripMenuItem
            // 
            this.پذیرشواعزامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اولویترزروراهبرانToolStripMenuItem,
            this.اولویتتریپرزروهاToolStripMenuItem,
            this.اولویتاضافهکارToolStripMenuItem,
            this.مجموعتریپراهبرانToolStripMenuItem,
            this.ToolStripMenuItem19,
            this.تحویلوتحولقطارToolStripMenuItem,
            this.عملکردروزانهراهبرانToolStripMenuItem,
            this.درخواستسرویسToolStripMenuItem,
            this.ToolStripMenuItem8,
            this.آخرینتغییراتپرسنلToolStripMenuItem,
            this.عملکردروزانهToolStripMenuItem,
            this.جابجاییتریپراهبرانToolStripMenuItem});
            this.پذیرشواعزامToolStripMenuItem.Name = "پذیرشواعزامToolStripMenuItem";
            this.پذیرشواعزامToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.پذیرشواعزامToolStripMenuItem.Text = "پذیرش و اعزام";
            // 
            // اولویترزروراهبرانToolStripMenuItem
            // 
            this.اولویترزروراهبرانToolStripMenuItem.Name = "اولویترزروراهبرانToolStripMenuItem";
            this.اولویترزروراهبرانToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.اولویترزروراهبرانToolStripMenuItem.Text = "اولویت رزرو راهبران";
            this.اولویترزروراهبرانToolStripMenuItem.Click += new System.EventHandler(this.اولویترزروراهبرانToolStripMenuItem_Click);
            // 
            // اولویتتریپرزروهاToolStripMenuItem
            // 
            this.اولویتتریپرزروهاToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.اولویتتریپرزروهاToolStripMenuItem.Name = "اولویتتریپرزروهاToolStripMenuItem";
            this.اولویتتریپرزروهاToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.اولویتتریپرزروهاToolStripMenuItem.Text = "اولویت تریپ رزرو ها";
            this.اولویتتریپرزروهاToolStripMenuItem.Click += new System.EventHandler(this.اولویتتریپرزروهاToolStripMenuItem_Click);
            // 
            // اولویتاضافهکارToolStripMenuItem
            // 
            this.اولویتاضافهکارToolStripMenuItem.Name = "اولویتاضافهکارToolStripMenuItem";
            this.اولویتاضافهکارToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.اولویتاضافهکارToolStripMenuItem.Text = "اولویت اضافه کار";
            this.اولویتاضافهکارToolStripMenuItem.Click += new System.EventHandler(this.اولویتاضافهکارToolStripMenuItem_Click);
            // 
            // مجموعتریپراهبرانToolStripMenuItem
            // 
            this.مجموعتریپراهبرانToolStripMenuItem.Name = "مجموعتریپراهبرانToolStripMenuItem";
            this.مجموعتریپراهبرانToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.مجموعتریپراهبرانToolStripMenuItem.Text = "مجموع تریپ راهبران";
            this.مجموعتریپراهبرانToolStripMenuItem.Click += new System.EventHandler(this.مجموعتریپراهبرانToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem19
            // 
            this.ToolStripMenuItem19.Name = "ToolStripMenuItem19";
            this.ToolStripMenuItem19.Size = new System.Drawing.Size(174, 6);
            // 
            // تحویلوتحولقطارToolStripMenuItem
            // 
            this.تحویلوتحولقطارToolStripMenuItem.Name = "تحویلوتحولقطارToolStripMenuItem";
            this.تحویلوتحولقطارToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.تحویلوتحولقطارToolStripMenuItem.Text = "تحویل و تحول قطار";
            this.تحویلوتحولقطارToolStripMenuItem.Click += new System.EventHandler(this.تحویلوتحولقطارToolStripMenuItem_Click);
            // 
            // عملکردروزانهراهبرانToolStripMenuItem
            // 
            this.عملکردروزانهراهبرانToolStripMenuItem.Name = "عملکردروزانهراهبرانToolStripMenuItem";
            this.عملکردروزانهراهبرانToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.عملکردروزانهراهبرانToolStripMenuItem.Text = "عملکرد روزانه راهبران";
            this.عملکردروزانهراهبرانToolStripMenuItem.Click += new System.EventHandler(this.عملکردروزانهراهبرانToolStripMenuItem_Click);
            // 
            // درخواستسرویسToolStripMenuItem
            // 
            this.درخواستسرویسToolStripMenuItem.Name = "درخواستسرویسToolStripMenuItem";
            this.درخواستسرویسToolStripMenuItem.ShowShortcutKeys = false;
            this.درخواستسرویسToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.درخواستسرویسToolStripMenuItem.Text = "درخواست سرویس ";
            this.درخواستسرویسToolStripMenuItem.Click += new System.EventHandler(this.درخواستسرویسToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem8
            // 
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            this.ToolStripMenuItem8.Size = new System.Drawing.Size(174, 6);
            // 
            // آخرینتغییراتپرسنلToolStripMenuItem
            // 
            this.آخرینتغییراتپرسنلToolStripMenuItem.Name = "آخرینتغییراتپرسنلToolStripMenuItem";
            this.آخرینتغییراتپرسنلToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.آخرینتغییراتپرسنلToolStripMenuItem.Text = "آخرین تغییرات پرسنل";
            this.آخرینتغییراتپرسنلToolStripMenuItem.Click += new System.EventHandler(this.آخرینتغییراتپرسنلToolStripMenuItem_Click);
            // 
            // عملکردروزانهToolStripMenuItem
            // 
            this.عملکردروزانهToolStripMenuItem.Name = "عملکردروزانهToolStripMenuItem";
            this.عملکردروزانهToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.عملکردروزانهToolStripMenuItem.Text = "عملکرد روزانه";
            this.عملکردروزانهToolStripMenuItem.Click += new System.EventHandler(this.عملکردروزانهToolStripMenuItem_Click);
            // 
            // جابجاییتریپراهبرانToolStripMenuItem
            // 
            this.جابجاییتریپراهبرانToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.جابجاییتریپراهبرانToolStripMenuItem.Name = "جابجاییتریپراهبرانToolStripMenuItem";
            this.جابجاییتریپراهبرانToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.جابجاییتریپراهبرانToolStripMenuItem.Text = "جابجایی تریپ راهبران";
            this.جابجاییتریپراهبرانToolStripMenuItem.Click += new System.EventHandler(this.جابجاییتریپراهبرانToolStripMenuItem_Click);
            // 
            // پردازشلوحهاعزامToolStripMenuItem
            // 
            this.پردازشلوحهاعزامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پردازشلوحهروزانهToolStripMenuItem1,
            this.پردازشلوحههشتگردToolStripMenuItem,
            this.پردازش2ToolStripMenuItem,
            this.ToolStripMenuItem20,
            this.ویرایشکشیکماهانهToolStripMenuItem,
            this.تکتریپToolStripMenuItem,
            this.رزرواضطراریراهبرانToolStripMenuItem,
            this.رزروراهبران9ساعتهToolStripMenuItem,
            this.ToolStripMenuItem9,
            this.لوحهروزانهراهبریToolStripMenuItem,
            this.پارامترهایپردازشلوحهToolStripMenuItem,
            this.رزروراهبران12ساعتهToolStripMenuItem});
            this.پردازشلوحهاعزامToolStripMenuItem.Name = "پردازشلوحهاعزامToolStripMenuItem";
            this.پردازشلوحهاعزامToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.پردازشلوحهاعزامToolStripMenuItem.Text = "پردازش لوحه ";
            // 
            // پردازشلوحهروزانهToolStripMenuItem1
            // 
            this.پردازشلوحهروزانهToolStripMenuItem1.Name = "پردازشلوحهروزانهToolStripMenuItem1";
            this.پردازشلوحهروزانهToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.پردازشلوحهروزانهToolStripMenuItem1.Text = "پردازش لوحه روزانه";
            this.پردازشلوحهروزانهToolStripMenuItem1.Click += new System.EventHandler(this.پردازشلوحهروزانهToolStripMenuItem1_Click);
            // 
            // پردازشلوحههشتگردToolStripMenuItem
            // 
            this.پردازشلوحههشتگردToolStripMenuItem.Name = "پردازشلوحههشتگردToolStripMenuItem";
            this.پردازشلوحههشتگردToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.پردازشلوحههشتگردToolStripMenuItem.Text = "پردازش لوحه هشتگرد";
            this.پردازشلوحههشتگردToolStripMenuItem.Visible = false;
            this.پردازشلوحههشتگردToolStripMenuItem.Click += new System.EventHandler(this.پردازشلوحههشتگردToolStripMenuItem_Click);
            // 
            // پردازش2ToolStripMenuItem
            // 
            this.پردازش2ToolStripMenuItem.Name = "پردازش2ToolStripMenuItem";
            this.پردازش2ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.پردازش2ToolStripMenuItem.Text = "پردازش لوحه خط اصلی";
            this.پردازش2ToolStripMenuItem.Visible = false;
            this.پردازش2ToolStripMenuItem.Click += new System.EventHandler(this.پردازش2ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem20
            // 
            this.ToolStripMenuItem20.Name = "ToolStripMenuItem20";
            this.ToolStripMenuItem20.Size = new System.Drawing.Size(184, 6);
            // 
            // ویرایشکشیکماهانهToolStripMenuItem
            // 
            this.ویرایشکشیکماهانهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ویرایشکشیکماهانهToolStripMenuItem.Name = "ویرایشکشیکماهانهToolStripMenuItem";
            this.ویرایشکشیکماهانهToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ویرایشکشیکماهانهToolStripMenuItem.Text = "ویرایش کشیک ماهانه";
            this.ویرایشکشیکماهانهToolStripMenuItem.Click += new System.EventHandler(this.ویرایشکشیکماهانهToolStripMenuItem_Click);
            // 
            // تکتریپToolStripMenuItem
            // 
            this.تکتریپToolStripMenuItem.Name = "تکتریپToolStripMenuItem";
            this.تکتریپToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.تکتریپToolStripMenuItem.Text = "اولویت تریپ خاص";
            this.تکتریپToolStripMenuItem.Click += new System.EventHandler(this.تکتریپToolStripMenuItem_Click);
            // 
            // رزرواضطراریراهبرانToolStripMenuItem
            // 
            this.رزرواضطراریراهبرانToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.رزرواضطراریراهبرانToolStripMenuItem.Name = "رزرواضطراریراهبرانToolStripMenuItem";
            this.رزرواضطراریراهبرانToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.رزرواضطراریراهبرانToolStripMenuItem.Text = "حذف راهبر از لوحه";
            this.رزرواضطراریراهبرانToolStripMenuItem.Click += new System.EventHandler(this.رزرواضطراریراهبرانToolStripMenuItem_Click);
            // 
            // رزروراهبران9ساعتهToolStripMenuItem
            // 
            this.رزروراهبران9ساعتهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.رزروراهبران9ساعتهToolStripMenuItem.Name = "رزروراهبران9ساعتهToolStripMenuItem";
            this.رزروراهبران9ساعتهToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.رزروراهبران9ساعتهToolStripMenuItem.Text = "انتخاب راهبران رزرو";
            this.رزروراهبران9ساعتهToolStripMenuItem.Click += new System.EventHandler(this.اولویترزروراهبران9ساعتهToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem9
            // 
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            this.ToolStripMenuItem9.Size = new System.Drawing.Size(184, 6);
            // 
            // لوحهروزانهراهبریToolStripMenuItem
            // 
            this.لوحهروزانهراهبریToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتلوحهاولیهToolStripMenuItem,
            this.ثبتلوحهاجراشدهToolStripMenuItem,
            this.ثبتلوحهنهاییToolStripMenuItem,
            this.ToolStripMenuItem22,
            this.گزارشلوحهثبتشدهToolStripMenuItem});
            this.لوحهروزانهراهبریToolStripMenuItem.Name = "لوحهروزانهراهبریToolStripMenuItem";
            this.لوحهروزانهراهبریToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.لوحهروزانهراهبریToolStripMenuItem.Text = "لوحه روزانه راهبری";
            // 
            // ثبتلوحهاولیهToolStripMenuItem
            // 
            this.ثبتلوحهاولیهToolStripMenuItem.Name = "ثبتلوحهاولیهToolStripMenuItem";
            this.ثبتلوحهاولیهToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ثبتلوحهاولیهToolStripMenuItem.Text = "ثبت لوحه اولیه";
            this.ثبتلوحهاولیهToolStripMenuItem.Click += new System.EventHandler(this.ثبتلوحهاولیهToolStripMenuItem_Click);
            // 
            // ثبتلوحهاجراشدهToolStripMenuItem
            // 
            this.ثبتلوحهاجراشدهToolStripMenuItem.Name = "ثبتلوحهاجراشدهToolStripMenuItem";
            this.ثبتلوحهاجراشدهToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ثبتلوحهاجراشدهToolStripMenuItem.Text = "ثبت لوحه اجرا شده";
            this.ثبتلوحهاجراشدهToolStripMenuItem.Click += new System.EventHandler(this.ثبتلوحهاجراشدهToolStripMenuItem_Click);
            // 
            // ثبتلوحهنهاییToolStripMenuItem
            // 
            this.ثبتلوحهنهاییToolStripMenuItem.Name = "ثبتلوحهنهاییToolStripMenuItem";
            this.ثبتلوحهنهاییToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ثبتلوحهنهاییToolStripMenuItem.Text = "ثبت لوحه نهایی";
            this.ثبتلوحهنهاییToolStripMenuItem.Click += new System.EventHandler(this.ثبتلوحهنهاییToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem22
            // 
            this.ToolStripMenuItem22.Name = "ToolStripMenuItem22";
            this.ToolStripMenuItem22.Size = new System.Drawing.Size(169, 6);
            // 
            // گزارشلوحهثبتشدهToolStripMenuItem
            // 
            this.گزارشلوحهثبتشدهToolStripMenuItem.Name = "گزارشلوحهثبتشدهToolStripMenuItem";
            this.گزارشلوحهثبتشدهToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.گزارشلوحهثبتشدهToolStripMenuItem.Text = "گزارش پردازش لوحه ";
            this.گزارشلوحهثبتشدهToolStripMenuItem.Click += new System.EventHandler(this.گزارشلوحهثبتشدهToolStripMenuItem_Click);
            // 
            // پارامترهایپردازشلوحهToolStripMenuItem
            // 
            this.پارامترهایپردازشلوحهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پارامترهایپردازشلوحهجدیدToolStripMenuItem,
            this.پارامترهایپردازشلوحهویرایشToolStripMenuItem});
            this.پارامترهایپردازشلوحهToolStripMenuItem.Name = "پارامترهایپردازشلوحهToolStripMenuItem";
            this.پارامترهایپردازشلوحهToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.پارامترهایپردازشلوحهToolStripMenuItem.Text = "پارامترهای پردازش لوحه";
            // 
            // پارامترهایپردازشلوحهجدیدToolStripMenuItem
            // 
            this.پارامترهایپردازشلوحهجدیدToolStripMenuItem.Name = "پارامترهایپردازشلوحهجدیدToolStripMenuItem";
            this.پارامترهایپردازشلوحهجدیدToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.پارامترهایپردازشلوحهجدیدToolStripMenuItem.Text = "جدید";
            this.پارامترهایپردازشلوحهجدیدToolStripMenuItem.Click += new System.EventHandler(this.پارامترهایپردازشلوحهجدیدToolStripMenuItem_Click);
            // 
            // پارامترهایپردازشلوحهویرایشToolStripMenuItem
            // 
            this.پارامترهایپردازشلوحهویرایشToolStripMenuItem.Name = "پارامترهایپردازشلوحهویرایشToolStripMenuItem";
            this.پارامترهایپردازشلوحهویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.پارامترهایپردازشلوحهویرایشToolStripMenuItem.Text = "ویرایش";
            this.پارامترهایپردازشلوحهویرایشToolStripMenuItem.Click += new System.EventHandler(this.پارامترهایپردازشلوحهویرایشToolStripMenuItem_Click);
            // 
            // رزروراهبران12ساعتهToolStripMenuItem
            // 
            this.رزروراهبران12ساعتهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.رزروراهبران12ساعتهToolStripMenuItem.Name = "رزروراهبران12ساعتهToolStripMenuItem";
            this.رزروراهبران12ساعتهToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.رزروراهبران12ساعتهToolStripMenuItem.Text = "رزرو راهبران 12 ساعته";
            this.رزروراهبران12ساعتهToolStripMenuItem.Visible = false;
            this.رزروراهبران12ساعتهToolStripMenuItem.Click += new System.EventHandler(this.رزروراهبران12ساعتهToolStripMenuItem_Click);
            // 
            // پرسنلToolStripMenuItem
            // 
            this.پرسنلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پرسنلعملیاتToolStripMenuItem,
            this.مجوزپرسنلToolStripMenuItem,
            this.گزارشجزییاتپرسنلToolStripMenuItem,
            this.ToolStripMenuItem12,
            this.ویرایشمشخصاتفردیToolStripMenuItem,
            this.ToolStripMenuItem7,
            this.شرکتدرانتخاباتToolStripMenuItem,
            this.نتیجهانتخاباتToolStripMenuItem,
            this.ToolStripMenuItem24,
            this.دفترتلفنToolStripMenuItem});
            this.پرسنلToolStripMenuItem.Name = "پرسنلToolStripMenuItem";
            this.پرسنلToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.پرسنلToolStripMenuItem.Text = "پرسنل";
            // 
            // پرسنلعملیاتToolStripMenuItem
            // 
            this.پرسنلعملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پرسنلجدیدToolStripMenuItem,
            this.پرسنلویرایشToolStripMenuItem,
            this.ToolStripMenuItem25,
            this.پرسنلگزارشToolStripMenuItem});
            this.پرسنلعملیاتToolStripMenuItem.Name = "پرسنلعملیاتToolStripMenuItem";
            this.پرسنلعملیاتToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.پرسنلعملیاتToolStripMenuItem.Text = "پرسنل عملیات";
            // 
            // پرسنلجدیدToolStripMenuItem
            // 
            this.پرسنلجدیدToolStripMenuItem.Name = "پرسنلجدیدToolStripMenuItem";
            this.پرسنلجدیدToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.پرسنلجدیدToolStripMenuItem.Text = "جدید";
            this.پرسنلجدیدToolStripMenuItem.Click += new System.EventHandler(this.جدیدToolStripMenuItem_Click);
            // 
            // پرسنلویرایشToolStripMenuItem
            // 
            this.پرسنلویرایشToolStripMenuItem.Name = "پرسنلویرایشToolStripMenuItem";
            this.پرسنلویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.پرسنلویرایشToolStripMenuItem.Text = "ویرایش";
            this.پرسنلویرایشToolStripMenuItem.Click += new System.EventHandler(this.پرسنلویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem25
            // 
            this.ToolStripMenuItem25.Name = "ToolStripMenuItem25";
            this.ToolStripMenuItem25.Size = new System.Drawing.Size(107, 6);
            // 
            // پرسنلگزارشToolStripMenuItem
            // 
            this.پرسنلگزارشToolStripMenuItem.Name = "پرسنلگزارشToolStripMenuItem";
            this.پرسنلگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.پرسنلگزارشToolStripMenuItem.Text = "گزارش";
            this.پرسنلگزارشToolStripMenuItem.Click += new System.EventHandler(this.پرسنلگزارشToolStripMenuItem_Click);
            // 
            // مجوزپرسنلToolStripMenuItem
            // 
            this.مجوزپرسنلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مجوزویرایشToolStripMenuItem,
            this.ToolStripMenuItem26,
            this.مجوزگزارشToolStripMenuItem});
            this.مجوزپرسنلToolStripMenuItem.Name = "مجوزپرسنلToolStripMenuItem";
            this.مجوزپرسنلToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.مجوزپرسنلToolStripMenuItem.Text = "مجوز پرسنل";
            // 
            // مجوزویرایشToolStripMenuItem
            // 
            this.مجوزویرایشToolStripMenuItem.Name = "مجوزویرایشToolStripMenuItem";
            this.مجوزویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مجوزویرایشToolStripMenuItem.Text = "ویرایش";
            this.مجوزویرایشToolStripMenuItem.Click += new System.EventHandler(this.مجوزویرایشToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem26
            // 
            this.ToolStripMenuItem26.Name = "ToolStripMenuItem26";
            this.ToolStripMenuItem26.Size = new System.Drawing.Size(107, 6);
            // 
            // مجوزگزارشToolStripMenuItem
            // 
            this.مجوزگزارشToolStripMenuItem.Name = "مجوزگزارشToolStripMenuItem";
            this.مجوزگزارشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.مجوزگزارشToolStripMenuItem.Text = "گزارش";
            this.مجوزگزارشToolStripMenuItem.Click += new System.EventHandler(this.مجوزگزارشToolStripMenuItem_Click);
            // 
            // گزارشجزییاتپرسنلToolStripMenuItem
            // 
            this.گزارشجزییاتپرسنلToolStripMenuItem.Name = "گزارشجزییاتپرسنلToolStripMenuItem";
            this.گزارشجزییاتپرسنلToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.گزارشجزییاتپرسنلToolStripMenuItem.Text = "گزارش جزئیات پرسنل";
            this.گزارشجزییاتپرسنلToolStripMenuItem.Click += new System.EventHandler(this.گزارشآمارماهانهToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem12
            // 
            this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
            this.ToolStripMenuItem12.Size = new System.Drawing.Size(188, 6);
            // 
            // ویرایشمشخصاتفردیToolStripMenuItem
            // 
            this.ویرایشمشخصاتفردیToolStripMenuItem.Name = "ویرایشمشخصاتفردیToolStripMenuItem";
            this.ویرایشمشخصاتفردیToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ویرایشمشخصاتفردیToolStripMenuItem.Text = "ویرایش مشخصات فردی";
            this.ویرایشمشخصاتفردیToolStripMenuItem.Click += new System.EventHandler(this.ویرایشمشخصاتفردیToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(188, 6);
            // 
            // شرکتدرانتخاباتToolStripMenuItem
            // 
            this.شرکتدرانتخاباتToolStripMenuItem.Name = "شرکتدرانتخاباتToolStripMenuItem";
            this.شرکتدرانتخاباتToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.شرکتدرانتخاباتToolStripMenuItem.Text = "شرکت در رای گیری";
            this.شرکتدرانتخاباتToolStripMenuItem.Click += new System.EventHandler(this.شرکتدرانتخاباتToolStripMenuItem_Click);
            // 
            // نتیجهانتخاباتToolStripMenuItem
            // 
            this.نتیجهانتخاباتToolStripMenuItem.Name = "نتیجهانتخاباتToolStripMenuItem";
            this.نتیجهانتخاباتToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.نتیجهانتخاباتToolStripMenuItem.Text = "نتیجه رای گیری";
            this.نتیجهانتخاباتToolStripMenuItem.Click += new System.EventHandler(this.نتیجهانتخاباتToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem24
            // 
            this.ToolStripMenuItem24.Name = "ToolStripMenuItem24";
            this.ToolStripMenuItem24.Size = new System.Drawing.Size(188, 6);
            // 
            // دفترتلفنToolStripMenuItem
            // 
            this.دفترتلفنToolStripMenuItem.Name = "دفترتلفنToolStripMenuItem";
            this.دفترتلفنToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.دفترتلفنToolStripMenuItem.Text = "دفتر تلفن";
            this.دفترتلفنToolStripMenuItem.Click += new System.EventHandler(this.PhoneBox_Click);
            // 
            // مدیریتToolStripMenuItem
            // 
            this.مدیریتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتخودکارکشیکماهانهToolStripMenuItem,
            this.ToolStripMenuItem13,
            this.ثبتاطلاعیهToolStripMenuItem,
            this.ثبتانتخاباتToolStripMenuItem,
            this.تغییراتلوحهاعزامToolStripMenuItem,
            this.نظرسنجیوآزمونپرسنلToolStripMenuItem,
            this.ToolStripMenuItem17,
            this.سقفاضافهکارپرسنلToolStripMenuItem,
            this.محاسبهکارکردراهبرانToolStripMenuItem,
            this.بررسیمواردثبتشدهToolStripMenuItem,
            this.ToolStripMenuItem27});
            this.مدیریتToolStripMenuItem.Name = "مدیریتToolStripMenuItem";
            this.مدیریتToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.مدیریتToolStripMenuItem.Text = "مدیریت";
            // 
            // ثبتخودکارکشیکماهانهToolStripMenuItem
            // 
            this.ثبتخودکارکشیکماهانهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ثبتخودکارکشیکماهانهToolStripMenuItem.Name = "ثبتخودکارکشیکماهانهToolStripMenuItem";
            this.ثبتخودکارکشیکماهانهToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ثبتخودکارکشیکماهانهToolStripMenuItem.Text = "پردازش کشیک ماهانه";
            this.ثبتخودکارکشیکماهانهToolStripMenuItem.Click += new System.EventHandler(this.ثبتخودکارکشیکماهانهToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem13
            // 
            this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
            this.ToolStripMenuItem13.Size = new System.Drawing.Size(193, 6);
            this.ToolStripMenuItem13.Visible = false;
            // 
            // ثبتاطلاعیهToolStripMenuItem
            // 
            this.ثبتاطلاعیهToolStripMenuItem.Name = "ثبتاطلاعیهToolStripMenuItem";
            this.ثبتاطلاعیهToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ثبتاطلاعیهToolStripMenuItem.Text = "ثبت اطلاعیه ";
            this.ثبتاطلاعیهToolStripMenuItem.Click += new System.EventHandler(this.اطلاعیهآموزشیثبتToolStripMenuItem_Click);
            // 
            // ثبتانتخاباتToolStripMenuItem
            // 
            this.ثبتانتخاباتToolStripMenuItem.Name = "ثبتانتخاباتToolStripMenuItem";
            this.ثبتانتخاباتToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ثبتانتخاباتToolStripMenuItem.Text = "ثبت رای گیری";
            this.ثبتانتخاباتToolStripMenuItem.Click += new System.EventHandler(this.ثبتانتخاباتToolStripMenuItem_Click);
            // 
            // تغییراتلوحهاعزامToolStripMenuItem
            // 
            this.تغییراتلوحهاعزامToolStripMenuItem.Enabled = false;
            this.تغییراتلوحهاعزامToolStripMenuItem.Name = "تغییراتلوحهاعزامToolStripMenuItem";
            this.تغییراتلوحهاعزامToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.تغییراتلوحهاعزامToolStripMenuItem.Text = "تغییرات لوحه اعزام";
            this.تغییراتلوحهاعزامToolStripMenuItem.Click += new System.EventHandler(this.تغییراتلوحهاعزامToolStripMenuItem_Click);
            // 
            // نظرسنجیوآزمونپرسنلToolStripMenuItem
            // 
            this.نظرسنجیوآزمونپرسنلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتنظرسنجیجدیدToolStripMenuItem,
            this.انجامنظرسنجیToolStripMenuItem,
            this.ToolStripMenuItem14,
            this.نتایجنظرسنجیToolStripMenuItem,
            this.ثبتآزمونجدیدToolStripMenuItem});
            this.نظرسنجیوآزمونپرسنلToolStripMenuItem.Name = "نظرسنجیوآزمونپرسنلToolStripMenuItem";
            this.نظرسنجیوآزمونپرسنلToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.نظرسنجیوآزمونپرسنلToolStripMenuItem.Text = "نظرسنجی و آزمون پرسنل";
            // 
            // ثبتنظرسنجیجدیدToolStripMenuItem
            // 
            this.ثبتنظرسنجیجدیدToolStripMenuItem.Name = "ثبتنظرسنجیجدیدToolStripMenuItem";
            this.ثبتنظرسنجیجدیدToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ثبتنظرسنجیجدیدToolStripMenuItem.Text = "ثبت نظر سنجی جدید";
            this.ثبتنظرسنجیجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتنظرسنجیجدیدToolStripMenuItem_Click);
            // 
            // انجامنظرسنجیToolStripMenuItem
            // 
            this.انجامنظرسنجیToolStripMenuItem.Name = "انجامنظرسنجیToolStripMenuItem";
            this.انجامنظرسنجیToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.انجامنظرسنجیToolStripMenuItem.Text = "انجام نظرسنجی";
            this.انجامنظرسنجیToolStripMenuItem.Click += new System.EventHandler(this.انجامنظرسنجیToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem14
            // 
            this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
            this.ToolStripMenuItem14.Size = new System.Drawing.Size(172, 6);
            // 
            // نتایجنظرسنجیToolStripMenuItem
            // 
            this.نتایجنظرسنجیToolStripMenuItem.Name = "نتایجنظرسنجیToolStripMenuItem";
            this.نتایجنظرسنجیToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.نتایجنظرسنجیToolStripMenuItem.Text = "نتایج نظر سنجی";
            this.نتایجنظرسنجیToolStripMenuItem.Click += new System.EventHandler(this.نتایجنظرسنجیToolStripMenuItem_Click);
            // 
            // ثبتآزمونجدیدToolStripMenuItem
            // 
            this.ثبتآزمونجدیدToolStripMenuItem.Name = "ثبتآزمونجدیدToolStripMenuItem";
            this.ثبتآزمونجدیدToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ثبتآزمونجدیدToolStripMenuItem.Text = "ثبت آزمون جدید";
            this.ثبتآزمونجدیدToolStripMenuItem.Visible = false;
            // 
            // ToolStripMenuItem17
            // 
            this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
            this.ToolStripMenuItem17.Size = new System.Drawing.Size(193, 6);
            // 
            // سقفاضافهکارپرسنلToolStripMenuItem
            // 
            this.سقفاضافهکارپرسنلToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.سقفاضافهکارپرسنلToolStripMenuItem.Name = "سقفاضافهکارپرسنلToolStripMenuItem";
            this.سقفاضافهکارپرسنلToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.سقفاضافهکارپرسنلToolStripMenuItem.Text = "سقف اضافه کار پرسنل";
            this.سقفاضافهکارپرسنلToolStripMenuItem.Click += new System.EventHandler(this.سقفاضافهکارپرسنلToolStripMenuItem_Click);
            // 
            // محاسبهکارکردراهبرانToolStripMenuItem
            // 
            this.محاسبهکارکردراهبرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتلوحهاعزامToolStripMenuItem,
            this.ToolStripMenuItem18,
            this.کارکردماهانهراهبرانToolStripMenuItem,
            this.کارکردروزانهراهبرانToolStripMenuItem,
            this.تریپدرشیفتToolStripMenuItem});
            this.محاسبهکارکردراهبرانToolStripMenuItem.Name = "محاسبهکارکردراهبرانToolStripMenuItem";
            this.محاسبهکارکردراهبرانToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.محاسبهکارکردراهبرانToolStripMenuItem.Text = "محاسبه کارکرد راهبران";
            // 
            // ثبتلوحهاعزامToolStripMenuItem
            // 
            this.ثبتلوحهاعزامToolStripMenuItem.Name = "ثبتلوحهاعزامToolStripMenuItem";
            this.ثبتلوحهاعزامToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ثبتلوحهاعزامToolStripMenuItem.Text = "تحلیل لوحه راهبری";
            this.ثبتلوحهاعزامToolStripMenuItem.Click += new System.EventHandler(this.ثبتلوحهاعزامToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem18
            // 
            this.ToolStripMenuItem18.Name = "ToolStripMenuItem18";
            this.ToolStripMenuItem18.Size = new System.Drawing.Size(171, 6);
            // 
            // کارکردماهانهراهبرانToolStripMenuItem
            // 
            this.کارکردماهانهراهبرانToolStripMenuItem.Name = "کارکردماهانهراهبرانToolStripMenuItem";
            this.کارکردماهانهراهبرانToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.کارکردماهانهراهبرانToolStripMenuItem.Text = "کارکرد ماهانه راهبران";
            this.کارکردماهانهراهبرانToolStripMenuItem.Click += new System.EventHandler(this.کارکردماهانهراهبرانToolStripMenuItem_Click);
            // 
            // کارکردروزانهراهبرانToolStripMenuItem
            // 
            this.کارکردروزانهراهبرانToolStripMenuItem.Name = "کارکردروزانهراهبرانToolStripMenuItem";
            this.کارکردروزانهراهبرانToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.کارکردروزانهراهبرانToolStripMenuItem.Text = "کارکرد روزانه راهبران";
            this.کارکردروزانهراهبرانToolStripMenuItem.Click += new System.EventHandler(this.کارکردروزانهراهبرانToolStripMenuItem_Click);
            // 
            // تریپدرشیفتToolStripMenuItem
            // 
            this.تریپدرشیفتToolStripMenuItem.Name = "تریپدرشیفتToolStripMenuItem";
            this.تریپدرشیفتToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.تریپدرشیفتToolStripMenuItem.Text = "تریپ در شیفت";
            this.تریپدرشیفتToolStripMenuItem.Click += new System.EventHandler(this.تریپدرشیفتToolStripMenuItem_Click);
            // 
            // بررسیمواردثبتشدهToolStripMenuItem
            // 
            this.بررسیمواردثبتشدهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بررسیکارکردویرایششدهToolStripMenuItem,
            this.برسیامتیازهایویراششدهToolStripMenuItem,
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem,
            this.بررسیئرخواستاضافهکارToolStripMenuItem});
            this.بررسیمواردثبتشدهToolStripMenuItem.Name = "بررسیمواردثبتشدهToolStripMenuItem";
            this.بررسیمواردثبتشدهToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.بررسیمواردثبتشدهToolStripMenuItem.Text = "بررسی موارد ثبت شده";
            this.بررسیمواردثبتشدهToolStripMenuItem.Visible = false;
            // 
            // بررسیکارکردویرایششدهToolStripMenuItem
            // 
            this.بررسیکارکردویرایششدهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.بررسیکارکردویرایششدهToolStripMenuItem.Name = "بررسیکارکردویرایششدهToolStripMenuItem";
            this.بررسیکارکردویرایششدهToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.بررسیکارکردویرایششدهToolStripMenuItem.Text = "بررسی اضافه کار ثبت شده";
            this.بررسیکارکردویرایششدهToolStripMenuItem.Visible = false;
            // 
            // برسیامتیازهایویراششدهToolStripMenuItem
            // 
            this.برسیامتیازهایویراششدهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.برسیامتیازهایویراششدهToolStripMenuItem.Name = "برسیامتیازهایویراششدهToolStripMenuItem";
            this.برسیامتیازهایویراششدهToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.برسیامتیازهایویراششدهToolStripMenuItem.Text = "بررسی امتیاز ثبت شده";
            this.برسیامتیازهایویراششدهToolStripMenuItem.Visible = false;
            // 
            // بررسیمرخصیهایثبتشدهToolStripMenuItem
            // 
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem.Name = "بررسیمرخصیهایثبتشدهToolStripMenuItem";
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem.Text = "بررسی مرخصی ثبت شده";
            this.بررسیمرخصیهایثبتشدهToolStripMenuItem.Visible = false;
            // 
            // بررسیئرخواستاضافهکارToolStripMenuItem
            // 
            this.بررسیئرخواستاضافهکارToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.بررسیئرخواستاضافهکارToolStripMenuItem.Name = "بررسیئرخواستاضافهکارToolStripMenuItem";
            this.بررسیئرخواستاضافهکارToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.بررسیئرخواستاضافهکارToolStripMenuItem.Text = "بررسی درخواست اضافه کار";
            this.بررسیئرخواستاضافهکارToolStripMenuItem.Visible = false;
            // 
            // ToolStripMenuItem27
            // 
            this.ToolStripMenuItem27.Name = "ToolStripMenuItem27";
            this.ToolStripMenuItem27.Size = new System.Drawing.Size(193, 6);
            // 
            // گزارشمدیریتیToolStripMenuItem
            // 
            this.گزارشمدیریتیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشاتتفکیکیToolStripMenuItem,
            this.گزارشعملکردنرمافزارToolStripMenuItem,
            this.گزارشامتیازپرسنلToolStripMenuItem,
            this.عملکردراهبرانرزروToolStripMenuItem,
            this.آلبومپرسنلیToolStripMenuItem,
            this.ToolStripMenuItem15,
            this.نمودارروزانهاضافهکارToolStripMenuItem,
            this.نمودارمرخصیروزانهToolStripMenuItem,
            this.گزارشاطلاعیههاToolStripMenuItem,
            this.درخواستکشیکماهانهگزارشToolStripMenuItem,
            this.تریپهایروزانهToolStripMenuItem});
            this.گزارشمدیریتیToolStripMenuItem.Name = "گزارشمدیریتیToolStripMenuItem";
            this.گزارشمدیریتیToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.گزارشمدیریتیToolStripMenuItem.Text = "گزارش مدیریتی";
            // 
            // گزارشاتتفکیکیToolStripMenuItem
            // 
            this.گزارشاتتفکیکیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشتفکیکیاضافهکارToolStripMenuItem,
            this.گزارشآمارماهانهپرسنلToolStripMenuItem,
            this.گزارشآماریشیفتهاToolStripMenuItem,
            this.آمارکشیکراهبرانToolStripMenuItem});
            this.گزارشاتتفکیکیToolStripMenuItem.Name = "گزارشاتتفکیکیToolStripMenuItem";
            this.گزارشاتتفکیکیToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.گزارشاتتفکیکیToolStripMenuItem.Text = "گزارشات تفکیکی";
            // 
            // گزارشتفکیکیاضافهکارToolStripMenuItem
            // 
            this.گزارشتفکیکیاضافهکارToolStripMenuItem.Name = "گزارشتفکیکیاضافهکارToolStripMenuItem";
            this.گزارشتفکیکیاضافهکارToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.گزارشتفکیکیاضافهکارToolStripMenuItem.Text = "اضافه کار ثبت شده ";
            this.گزارشتفکیکیاضافهکارToolStripMenuItem.Click += new System.EventHandler(this.گزارشتفکیکیاضافهکارToolStripMenuItem_Click);
            // 
            // گزارشآمارماهانهپرسنلToolStripMenuItem
            // 
            this.گزارشآمارماهانهپرسنلToolStripMenuItem.Name = "گزارشآمارماهانهپرسنلToolStripMenuItem";
            this.گزارشآمارماهانهپرسنلToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.گزارشآمارماهانهپرسنلToolStripMenuItem.Text = "عملکرد پرسنل";
            this.گزارشآمارماهانهپرسنلToolStripMenuItem.Click += new System.EventHandler(this.گزارشآمارماهانهپرسنلToolStripMenuItem_Click);
            // 
            // گزارشآماریشیفتهاToolStripMenuItem
            // 
            this.گزارشآماریشیفتهاToolStripMenuItem.Name = "گزارشآماریشیفتهاToolStripMenuItem";
            this.گزارشآماریشیفتهاToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.گزارشآماریشیفتهاToolStripMenuItem.Text = "آمار شیفت ها";
            this.گزارشآماریشیفتهاToolStripMenuItem.Click += new System.EventHandler(this.گزارشآماریشیفتهاToolStripMenuItem_Click);
            // 
            // آمارکشیکراهبرانToolStripMenuItem
            // 
            this.آمارکشیکراهبرانToolStripMenuItem.Name = "آمارکشیکراهبرانToolStripMenuItem";
            this.آمارکشیکراهبرانToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.آمارکشیکراهبرانToolStripMenuItem.Text = "آمار کشیک راهبران";
            this.آمارکشیکراهبرانToolStripMenuItem.Click += new System.EventHandler(this.آمارکشیکراهبرانToolStripMenuItem_Click);
            // 
            // گزارشعملکردنرمافزارToolStripMenuItem
            // 
            this.گزارشعملکردنرمافزارToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.گزارشعملکردنرمافزارToolStripMenuItem.Name = "گزارشعملکردنرمافزارToolStripMenuItem";
            this.گزارشعملکردنرمافزارToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.گزارشعملکردنرمافزارToolStripMenuItem.Text = "گزارش دوره ای عملکرد پرسنل";
            this.گزارشعملکردنرمافزارToolStripMenuItem.Click += new System.EventHandler(this.گزارشامتیازنرمافزارToolStripMenuItem_Click);
            // 
            // گزارشامتیازپرسنلToolStripMenuItem
            // 
            this.گزارشامتیازپرسنلToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.گزارشامتیازپرسنلToolStripMenuItem.Name = "گزارشامتیازپرسنلToolStripMenuItem";
            this.گزارشامتیازپرسنلToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.گزارشامتیازپرسنلToolStripMenuItem.Text = "گزارش امتیاز انضباطی پرسنل";
            this.گزارشامتیازپرسنلToolStripMenuItem.Click += new System.EventHandler(this.گزارشامتیازپرسنلToolStripMenuItem_Click);
            // 
            // عملکردراهبرانرزروToolStripMenuItem
            // 
            this.عملکردراهبرانرزروToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.عملکردراهبرانرزروToolStripMenuItem.Name = "عملکردراهبرانرزروToolStripMenuItem";
            this.عملکردراهبرانرزروToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.عملکردراهبرانرزروToolStripMenuItem.Text = "عملکرد راهبران رزرو";
            this.عملکردراهبرانرزروToolStripMenuItem.Click += new System.EventHandler(this.امتیازراهبرانرزروToolStripMenuItem_Click);
            // 
            // آلبومپرسنلیToolStripMenuItem
            // 
            this.آلبومپرسنلیToolStripMenuItem.Name = "آلبومپرسنلیToolStripMenuItem";
            this.آلبومپرسنلیToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.آلبومپرسنلیToolStripMenuItem.Text = "آلبوم پرسنلی";
            this.آلبومپرسنلیToolStripMenuItem.Click += new System.EventHandler(this.آلبومپرسنلیToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem15
            // 
            this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
            this.ToolStripMenuItem15.Size = new System.Drawing.Size(213, 6);
            // 
            // نمودارروزانهاضافهکارToolStripMenuItem
            // 
            this.نمودارروزانهاضافهکارToolStripMenuItem.Name = "نمودارروزانهاضافهکارToolStripMenuItem";
            this.نمودارروزانهاضافهکارToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.نمودارروزانهاضافهکارToolStripMenuItem.Text = "نمودار روزانه اضافه کار ";
            this.نمودارروزانهاضافهکارToolStripMenuItem.Click += new System.EventHandler(this.نمودارروزانهاضافهکارToolStripMenuItem_Click);
            // 
            // نمودارمرخصیروزانهToolStripMenuItem
            // 
            this.نمودارمرخصیروزانهToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.نمودارمرخصیروزانهToolStripMenuItem.Name = "نمودارمرخصیروزانهToolStripMenuItem";
            this.نمودارمرخصیروزانهToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.نمودارمرخصیروزانهToolStripMenuItem.Text = "نمودار مرخصی روزانه";
            this.نمودارمرخصیروزانهToolStripMenuItem.Click += new System.EventHandler(this.نمودارمرخصیروزانهToolStripMenuItem_Click);
            // 
            // گزارشاطلاعیههاToolStripMenuItem
            // 
            this.گزارشاطلاعیههاToolStripMenuItem.Name = "گزارشاطلاعیههاToolStripMenuItem";
            this.گزارشاطلاعیههاToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.گزارشاطلاعیههاToolStripMenuItem.Text = "گزارش اطلاعیه ها";
            this.گزارشاطلاعیههاToolStripMenuItem.Click += new System.EventHandler(this.گزارشاطلاعیههاToolStripMenuItem_Click);
            // 
            // درخواستکشیکماهانهگزارشToolStripMenuItem
            // 
            this.درخواستکشیکماهانهگزارشToolStripMenuItem.Name = "درخواستکشیکماهانهگزارشToolStripMenuItem";
            this.درخواستکشیکماهانهگزارشToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.درخواستکشیکماهانهگزارشToolStripMenuItem.Text = "گزارش درخواست کشیک";
            this.درخواستکشیکماهانهگزارشToolStripMenuItem.Click += new System.EventHandler(this.درخواستکشیکماهانهگزارشToolStripMenuItem_Click);
            // 
            // تریپهایروزانهToolStripMenuItem
            // 
            this.تریپهایروزانهToolStripMenuItem.Name = "تریپهایروزانهToolStripMenuItem";
            this.تریپهایروزانهToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.تریپهایروزانهToolStripMenuItem.Text = "تریپ های روزانه";
            this.تریپهایروزانهToolStripMenuItem.Click += new System.EventHandler(this.تریپهایروزانهToolStripMenuItem_Click);
            // 
            // کاربرToolStripMenuItem
            // 
            this.کاربرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کاربرجدیدToolStripMenuItem,
            this.ویرایشمشخصاتToolStripMenuItem,
            this.لیستکاربرانToolStripMenuItem,
            this.ToolStripMenuItem16,
            this.تغییرکلمهعبورToolStripMenuItem,
            this.ریسترمزکاربرانToolStripMenuItem});
            this.کاربرToolStripMenuItem.Name = "کاربرToolStripMenuItem";
            this.کاربرToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.کاربرToolStripMenuItem.Text = "کاربر";
            // 
            // کاربرجدیدToolStripMenuItem
            // 
            this.کاربرجدیدToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.کاربرجدیدToolStripMenuItem.Name = "کاربرجدیدToolStripMenuItem";
            this.کاربرجدیدToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.کاربرجدیدToolStripMenuItem.Text = "تعریف کاربر جدید";
            this.کاربرجدیدToolStripMenuItem.Click += new System.EventHandler(this.کاربرجدیدToolStripMenuItem_Click);
            // 
            // ویرایشمشخصاتToolStripMenuItem
            // 
            this.ویرایشمشخصاتToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ویرایشمشخصاتToolStripMenuItem.Name = "ویرایشمشخصاتToolStripMenuItem";
            this.ویرایشمشخصاتToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ویرایشمشخصاتToolStripMenuItem.Text = "ویرایش دسترسی کاربران";
            this.ویرایشمشخصاتToolStripMenuItem.Click += new System.EventHandler(this.ویرایشمشخصاتToolStripMenuItem_Click);
            // 
            // لیستکاربرانToolStripMenuItem
            // 
            this.لیستکاربرانToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.لیستکاربرانToolStripMenuItem.Name = "لیستکاربرانToolStripMenuItem";
            this.لیستکاربرانToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.لیستکاربرانToolStripMenuItem.Text = "لیست کاربران";
            this.لیستکاربرانToolStripMenuItem.Click += new System.EventHandler(this.لیستکاربرانToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem16
            // 
            this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
            this.ToolStripMenuItem16.Size = new System.Drawing.Size(187, 6);
            // 
            // تغییرکلمهعبورToolStripMenuItem
            // 
            this.تغییرکلمهعبورToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.تغییرکلمهعبورToolStripMenuItem.Name = "تغییرکلمهعبورToolStripMenuItem";
            this.تغییرکلمهعبورToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.تغییرکلمهعبورToolStripMenuItem.Text = "تغییر کلمه عبور";
            this.تغییرکلمهعبورToolStripMenuItem.Click += new System.EventHandler(this.تغییرکلمهعبورToolStripMenuItem_Click);
            // 
            // ریسترمزکاربرانToolStripMenuItem
            // 
            this.ریسترمزکاربرانToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ریسترمزکاربرانToolStripMenuItem.Name = "ریسترمزکاربرانToolStripMenuItem";
            this.ریسترمزکاربرانToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ریسترمزکاربرانToolStripMenuItem.Text = "ریست رمز کاربران";
            this.ریسترمزکاربرانToolStripMenuItem.Click += new System.EventHandler(this.ریسترمزکاربرانToolStripMenuItem_Click);
            // 
            // راهنماییToolStripMenuItem
            // 
            this.راهنماییToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کمکToolStripMenuItem,
            this.دربارهToolStripMenuItem,
            this.ToolStripMenuItem23,
            this.تماسباادمینToolStripMenuItem});
            this.راهنماییToolStripMenuItem.Name = "راهنماییToolStripMenuItem";
            this.راهنماییToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.راهنماییToolStripMenuItem.Text = "راهنمایی";
            // 
            // کمکToolStripMenuItem
            // 
            this.کمکToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.کمکToolStripMenuItem.Name = "کمکToolStripMenuItem";
            this.کمکToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.کمکToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.کمکToolStripMenuItem.Text = "کمک";
            this.کمکToolStripMenuItem.Click += new System.EventHandler(this.کمکToolStripMenuItem_Click);
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.دربارهToolStripMenuItem.Text = "درباره";
            this.دربارهToolStripMenuItem.Click += new System.EventHandler(this.دربارهToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem23
            // 
            this.ToolStripMenuItem23.Name = "ToolStripMenuItem23";
            this.ToolStripMenuItem23.Size = new System.Drawing.Size(140, 6);
            // 
            // تماسباادمینToolStripMenuItem
            // 
            this.تماسباادمینToolStripMenuItem.Name = "تماسباادمینToolStripMenuItem";
            this.تماسباادمینToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.تماسباادمینToolStripMenuItem.Text = "تماس با ادمین";
            this.تماسباادمینToolStripMenuItem.Click += new System.EventHandler(this.تماسباادمینToolStripMenuItem_Click);
            // 
            // ادمینToolStripMenuItem
            // 
            this.ادمینToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پردازشماهانهToolStripMenuItem,
            this.بارگذاریمجدددادههاToolStripMenuItem,
            this.ToolStripMenuItem2,
            this.تقویمToolStripMenuItem,
            this.ثبتنسخهجدیدToolStripMenuItem,
            this.ErorrLogoToolStripMenuItem,
            this.سابقهجابجاییشیفتToolStripMenuItem,
            this.اطلاعیهالکترونیکToolStripMenuItem,
            this.بهینهسازیتریپToolStripMenuItem});
            this.ادمینToolStripMenuItem.Name = "ادمینToolStripMenuItem";
            this.ادمینToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.ادمینToolStripMenuItem.Text = "ادمین";
            // 
            // پردازشماهانهToolStripMenuItem
            // 
            this.پردازشماهانهToolStripMenuItem.Name = "پردازشماهانهToolStripMenuItem";
            this.پردازشماهانهToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.پردازشماهانهToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.پردازشماهانهToolStripMenuItem.Text = "بهینه سازی داده ها";
            this.پردازشماهانهToolStripMenuItem.Click += new System.EventHandler(this.پردازشماهانهToolStripMenuItem_Click);
            // 
            // بارگذاریمجدددادههاToolStripMenuItem
            // 
            this.بارگذاریمجدددادههاToolStripMenuItem.Name = "بارگذاریمجدددادههاToolStripMenuItem";
            this.بارگذاریمجدددادههاToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.بارگذاریمجدددادههاToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.بارگذاریمجدددادههاToolStripMenuItem.Text = "بارگذاری داده ها";
            this.بارگذاریمجدددادههاToolStripMenuItem.Click += new System.EventHandler(this.بارگذاریمجدددادههاToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // تقویمToolStripMenuItem
            // 
            this.تقویمToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.تقویمToolStripMenuItem.Name = "تقویمToolStripMenuItem";
            this.تقویمToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.تقویمToolStripMenuItem.Text = "تقویم";
            this.تقویمToolStripMenuItem.Click += new System.EventHandler(this.تقویمToolStripMenuItem_Click);
            // 
            // ثبتنسخهجدیدToolStripMenuItem
            // 
            this.ثبتنسخهجدیدToolStripMenuItem.Name = "ثبتنسخهجدیدToolStripMenuItem";
            this.ثبتنسخهجدیدToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ثبتنسخهجدیدToolStripMenuItem.Text = "ثبت نسخه جدید";
            this.ثبتنسخهجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتنسخهجدیدToolStripMenuItem_Click);
            // 
            // ErorrLogoToolStripMenuItem
            // 
            this.ErorrLogoToolStripMenuItem.Name = "ErorrLogoToolStripMenuItem";
            this.ErorrLogoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.ErorrLogoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ErorrLogoToolStripMenuItem.Text = "Erorr Logo";
            this.ErorrLogoToolStripMenuItem.Click += new System.EventHandler(this.ErorrLogoToolStripMenuItem_Click);
            // 
            // سابقهجابجاییشیفتToolStripMenuItem
            // 
            this.سابقهجابجاییشیفتToolStripMenuItem.Name = "سابقهجابجاییشیفتToolStripMenuItem";
            this.سابقهجابجاییشیفتToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.سابقهجابجاییشیفتToolStripMenuItem.Text = "سابقه جابجایی شیفت";
            this.سابقهجابجاییشیفتToolStripMenuItem.Click += new System.EventHandler(this.سابقهجابجاییشیفتToolStripMenuItem_Click);
            // 
            // اطلاعیهالکترونیکToolStripMenuItem
            // 
            this.اطلاعیهالکترونیکToolStripMenuItem.Name = "اطلاعیهالکترونیکToolStripMenuItem";
            this.اطلاعیهالکترونیکToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.اطلاعیهالکترونیکToolStripMenuItem.Text = "اطلاعیه الکترونیک";
            this.اطلاعیهالکترونیکToolStripMenuItem.Click += new System.EventHandler(this.اطلاعیهالکترونیکToolStripMenuItem_Click);
            // 
            // بهینهسازیتریپToolStripMenuItem
            // 
            this.بهینهسازیتریپToolStripMenuItem.Name = "بهینهسازیتریپToolStripMenuItem";
            this.بهینهسازیتریپToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.بهینهسازیتریپToolStripMenuItem.Text = "بهینه سازی تریپ کارکرد";
            this.بهینهسازیتریپToolStripMenuItem.Click += new System.EventHandler(this.بهینهسازیتریپToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.خروجToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.خروجToolStripMenuItem.Image = global::Metro_Operation.Properties.Resources.Users_Exit_icon;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // اجرایمجددToolStripMenuItem
            // 
            this.اجرایمجددToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.اجرایمجددToolStripMenuItem.Image = global::Metro_Operation.Properties.Resources.restart;
            this.اجرایمجددToolStripMenuItem.Name = "اجرایمجددToolStripMenuItem";
            this.اجرایمجددToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.اجرایمجددToolStripMenuItem.Text = "اجرای مجدد";
            this.اجرایمجددToolStripMenuItem.Click += new System.EventHandler(this.اجرایمجددToolStripMenuItem_Click);
            // 
            // آمارراهبراندرکشیکماهانهToolStripMenuItem
            // 
            this.آمارراهبراندرکشیکماهانهToolStripMenuItem.Name = "آمارراهبراندرکشیکماهانهToolStripMenuItem";
            this.آمارراهبراندرکشیکماهانهToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.آمارراهبراندرکشیکماهانهToolStripMenuItem.Click += new System.EventHandler(this.آمارراهبراندرکشیکماهانهToolStripMenuItem_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameStatusLabel,
            this.PostStatusLabel,
            this.LineStatusLabel,
            this.AdrsStatusLabel,
            this.DateStatusLabel,
            this.VersStatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 690);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1116, 30);
            this.StatusStrip1.TabIndex = 15;
            // 
            // NameStatusLabel
            // 
            this.NameStatusLabel.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.NameStatusLabel.AutoSize = false;
            this.NameStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NameStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.NameStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.NameStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.NameStatusLabel.Name = "NameStatusLabel";
            this.NameStatusLabel.Size = new System.Drawing.Size(165, 25);
            // 
            // PostStatusLabel
            // 
            this.PostStatusLabel.AutoSize = false;
            this.PostStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.PostStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.PostStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.PostStatusLabel.Name = "PostStatusLabel";
            this.PostStatusLabel.Size = new System.Drawing.Size(165, 25);
            // 
            // LineStatusLabel
            // 
            this.LineStatusLabel.AutoSize = false;
            this.LineStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LineStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.LineStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.LineStatusLabel.Name = "LineStatusLabel";
            this.LineStatusLabel.Size = new System.Drawing.Size(166, 25);
            // 
            // AdrsStatusLabel
            // 
            this.AdrsStatusLabel.AutoSize = false;
            this.AdrsStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.AdrsStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.AdrsStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.AdrsStatusLabel.Name = "AdrsStatusLabel";
            this.AdrsStatusLabel.Size = new System.Drawing.Size(166, 25);
            // 
            // DateStatusLabel
            // 
            this.DateStatusLabel.AutoSize = false;
            this.DateStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.DateStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.DateStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.DateStatusLabel.Name = "DateStatusLabel";
            this.DateStatusLabel.Size = new System.Drawing.Size(166, 25);
            // 
            // VersStatusLabel
            // 
            this.VersStatusLabel.AutoSize = false;
            this.VersStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.VersStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.VersStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.VersStatusLabel.Name = "VersStatusLabel";
            this.VersStatusLabel.Size = new System.Drawing.Size(166, 25);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::Metro_Operation.Properties.Resources.Untitled_6;
            this.PictureBox1.Location = new System.Drawing.Point(1, 643);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(258, 47);
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.Black;
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(1, 1);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(233, 28);
            this.DateLabel.TabIndex = 19;
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthdayLabel.BackColor = System.Drawing.Color.White;
            this.BirthdayLabel.ForeColor = System.Drawing.Color.Black;
            this.BirthdayLabel.Location = new System.Drawing.Point(497, 51);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(120, 150);
            this.BirthdayLabel.TabIndex = 25;
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BirthdayLabel.Visible = false;
            // 
            // BirthdayList
            // 
            this.BirthdayList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthdayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BirthdayList.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.BirthdayList.FormattingEnabled = true;
            this.BirthdayList.ItemHeight = 16;
            this.BirthdayList.Location = new System.Drawing.Point(488, 44);
            this.BirthdayList.Name = "BirthdayList";
            this.BirthdayList.Size = new System.Drawing.Size(140, 164);
            this.BirthdayList.TabIndex = 41;
            this.BirthdayList.Visible = false;
            // 
            // PerPicture
            // 
            this.PerPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerPicture.Image = ((System.Drawing.Image)(resources.GetObject("PerPicture.Image")));
            this.PerPicture.Location = new System.Drawing.Point(944, 20);
            this.PerPicture.Name = "PerPicture";
            this.PerPicture.Size = new System.Drawing.Size(100, 120);
            this.PerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PerPicture.TabIndex = 18;
            this.PerPicture.TabStop = false;
            this.PerPicture.Visible = false;
            // 
            // ErrorLogoBox
            // 
            this.ErrorLogoBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ErrorLogoBox.BackColor = System.Drawing.Color.Black;
            this.ErrorLogoBox.ForeColor = System.Drawing.Color.Yellow;
            this.ErrorLogoBox.Location = new System.Drawing.Point(291, 584);
            this.ErrorLogoBox.Name = "ErrorLogoBox";
            this.ErrorLogoBox.ReadOnly = true;
            this.ErrorLogoBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorLogoBox.Size = new System.Drawing.Size(536, 96);
            this.ErrorLogoBox.TabIndex = 43;
            this.ErrorLogoBox.Text = "";
            this.ErrorLogoBox.Visible = false;
            // 
            // TrdLabel
            // 
            this.TrdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TrdLabel.BackColor = System.Drawing.Color.White;
            this.TrdLabel.Font = new System.Drawing.Font("B Titr", 20.25F, System.Drawing.FontStyle.Bold);
            this.TrdLabel.Location = new System.Drawing.Point(77, 598);
            this.TrdLabel.Name = "TrdLabel";
            this.TrdLabel.Size = new System.Drawing.Size(45, 45);
            this.TrdLabel.TabIndex = 44;
            this.TrdLabel.Text = "5";
            this.TrdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrdLabel.Visible = false;
            // 
            // TrialLabel
            // 
            this.TrialLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrialLabel.BackColor = System.Drawing.Color.White;
            this.TrialLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrialLabel.Font = new System.Drawing.Font("B Titr", 24F, System.Drawing.FontStyle.Bold);
            this.TrialLabel.Location = new System.Drawing.Point(439, 522);
            this.TrialLabel.Name = "TrialLabel";
            this.TrialLabel.Size = new System.Drawing.Size(260, 117);
            this.TrialLabel.TabIndex = 14;
            this.TrialLabel.Text = "نسخه جهت استفاده سیر و حرکت خطوط شرکت بهره برداری ";
            this.TrialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrialLabel.Visible = false;
            // 
            // newPanel1
            // 
            this.newPanel1.BackgroundImage = global::Metro_Operation.Properties.Resources.Background2;
            this.newPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPanel1.Location = new System.Drawing.Point(0, 0);
            this.newPanel1.Name = "newPanel1";
            this.newPanel1.Size = new System.Drawing.Size(1116, 720);
            this.newPanel1.TabIndex = 53;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.PhoneLabel.ForeColor = System.Drawing.Color.Black;
            this.PhoneLabel.Image = global::Metro_Operation.Properties.Resources.phone;
            this.PhoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneLabel.Location = new System.Drawing.Point(1, 1);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(100, 28);
            this.PhoneLabel.TabIndex = 20;
            this.PhoneLabel.Text = "دفتر تلفن";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
            // 
            // DateLabelPanel
            // 
            this.DateLabelPanel.Controls.Add(this.DateLabel);
            this.DateLabelPanel.Location = new System.Drawing.Point(20, 74);
            this.DateLabelPanel.Name = "DateLabelPanel";
            this.DateLabelPanel.Size = new System.Drawing.Size(235, 30);
            this.DateLabelPanel.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.PhoneLabel);
            this.panel2.Location = new System.Drawing.Point(943, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 30);
            this.panel2.TabIndex = 55;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::Metro_Operation.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DateLabelPanel);
            this.Controls.Add(this.PerPicture);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.TrdLabel);
            this.Controls.Add(this.ErrorLogoBox);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.BirthdayList);
            this.Controls.Add(this.TrialLabel);
            this.Controls.Add(this.newPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "نرم افزار سیر و حرکت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerPicture)).EndInit();
            this.DateLabelPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip MainMenu;
        private ToolStripMenuItem کاربرToolStripMenuItem;
        private ToolStripMenuItem کاربرجدیدToolStripMenuItem;
        private ToolStripMenuItem تغییرکلمهعبورToolStripMenuItem;
        private ToolStripMenuItem ویرایشمشخصاتToolStripMenuItem;
        private ToolStripMenuItem راهنماییToolStripMenuItem;
        private ToolStripMenuItem کمکToolStripMenuItem;
        private ToolStripMenuItem دربارهToolStripMenuItem;
        private ToolStripMenuItem پرسنلToolStripMenuItem;
        private ToolStripMenuItem مدیریتToolStripMenuItem;
        private ToolStripMenuItem خروجToolStripMenuItem;
        private ToolStripMenuItem لیستکاربرانToolStripMenuItem;
        private ToolStripMenuItem پذیرشواعزامToolStripMenuItem;
        private ToolStripMenuItem اولویتتریپرزروهاToolStripMenuItem;
        private ToolStripMenuItem سقفاضافهکارپرسنلToolStripMenuItem;
        private Timer MainTimer;
        private ToolStripSeparator ToolStripMenuItem16;
        private ToolStripSeparator ToolStripMenuItem12;
        private ToolStripMenuItem ریسترمزکاربرانToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem13;
        private ToolStripMenuItem گزارشمدیریتیToolStripMenuItem;
        private ToolStripMenuItem گزارشعملکردنرمافزارToolStripMenuItem;
        private ToolStripMenuItem گزارشامتیازپرسنلToolStripMenuItem;
        private ToolStripMenuItem عملکردراهبرانرزروToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem15;
        private ToolStripMenuItem نمودارمرخصیروزانهToolStripMenuItem;
        private ToolStripMenuItem ادمینToolStripMenuItem;
        private ToolStripMenuItem پردازشماهانهToolStripMenuItem;
        private ToolStripMenuItem ثبتخودکارکشیکماهانهToolStripMenuItem;
        private ToolStripMenuItem ویرایشکشیکماهانهToolStripMenuItem;
        private StatusStrip StatusStrip1;
        private ToolStripStatusLabel NameStatusLabel;
        private ToolStripStatusLabel PostStatusLabel;
        private ToolStripStatusLabel LineStatusLabel;
        private ToolStripStatusLabel AdrsStatusLabel;
        private ToolStripStatusLabel DateStatusLabel;
        private ToolStripStatusLabel VersStatusLabel;
        private PictureBox PictureBox1;
        private Label DateLabel;
        private ToolStripMenuItem گزارشاتتفکیکیToolStripMenuItem;
        private ToolStripMenuItem گزارشتفکیکیاضافهکارToolStripMenuItem;
        private ToolStripMenuItem گزارشآمارماهانهپرسنلToolStripMenuItem;
        private ToolStripMenuItem گزارشآماریشیفتهاToolStripMenuItem;
        private ToolStripMenuItem گزارشجزییاتپرسنلToolStripMenuItem;
        private Label BirthdayLabel;
        private ToolStripMenuItem اولویتاضافهکارToolStripMenuItem;
        private ToolStripMenuItem ثبتنسخهجدیدToolStripMenuItem;
        private ToolStripMenuItem آمارراهبراندرکشیکماهانهToolStripMenuItem;
        private ToolStripMenuItem آمارکشیکراهبرانToolStripMenuItem;
        private ToolStripMenuItem اجرایمجددToolStripMenuItem;
        private ListBox BirthdayList;
        private ToolStripMenuItem اولویترزروراهبرانToolStripMenuItem;
        private PictureBox PerPicture;
        private ToolStripMenuItem گزارشاطلاعیههاToolStripMenuItem;
        private ToolStripMenuItem ثبتاطلاعیهToolStripMenuItem;
        private ToolStripMenuItem پردازشلوحهاعزامToolStripMenuItem;
        private ToolStripMenuItem رزروراهبران9ساعتهToolStripMenuItem;
        private ToolStripMenuItem رزروراهبران12ساعتهToolStripMenuItem;
        private ToolStripMenuItem تکتریپToolStripMenuItem;
        private ToolStripMenuItem تغییراتلوحهاعزامToolStripMenuItem;
        private RichTextBox ErrorLogoBox;
        private ToolStripMenuItem ErorrLogoToolStripMenuItem;
        private ToolStripMenuItem نظرسنجیوآزمونپرسنلToolStripMenuItem;
        private ToolStripMenuItem ثبتنظرسنجیجدیدToolStripMenuItem;
        private ToolStripMenuItem نتایجنظرسنجیToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem14;
        private ToolStripMenuItem ثبتآزمونجدیدToolStripMenuItem;
        private ToolStripMenuItem بررسیمواردثبتشدهToolStripMenuItem;
        private ToolStripMenuItem بررسیکارکردویرایششدهToolStripMenuItem;
        private ToolStripMenuItem برسیامتیازهایویراششدهToolStripMenuItem;
        private ToolStripMenuItem بررسیمرخصیهایثبتشدهToolStripMenuItem;
        private ToolStripMenuItem بررسیئرخواستاضافهکارToolStripMenuItem;
        private ToolStripMenuItem انجامنظرسنجیToolStripMenuItem;
        private ToolStripMenuItem پردازش2ToolStripMenuItem;
        private ToolStripMenuItem پارامترهایپردازشلوحهToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem9;
        private ToolStripSeparator ToolStripMenuItem17;
        private ToolStripMenuItem محاسبهکارکردراهبرانToolStripMenuItem;
        private ToolStripMenuItem ثبتلوحهاعزامToolStripMenuItem;
        private ToolStripMenuItem کارکردماهانهراهبرانToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem18;
        private ToolStripMenuItem کارکردروزانهراهبرانToolStripMenuItem;
        private Label TrdLabel;
        private ToolStripMenuItem رزرواضطراریراهبرانToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem20;
        private ToolStripMenuItem کارکردپرسنلToolStripMenuItem;
        private ToolStripMenuItem مرخصیروزانهToolStripMenuItem;
        private ToolStripMenuItem مرخصیروزانهجدیدToolStripMenuItem;
        private ToolStripMenuItem مرخصیروزانهویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem04;
        private ToolStripMenuItem مرخصیروزانهگزارشToolStripMenuItem;
        private ToolStripMenuItem مرخصیساعتیToolStripMenuItem;
        private ToolStripMenuItem مرخصیساعتیجدیدToolStripMenuItem;
        private ToolStripMenuItem مرخصیساعتیویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem05;
        private ToolStripMenuItem مرخصیساعتیگزارشToolStripMenuItem;
        private ToolStripMenuItem اضافهکارToolStripMenuItem;
        private ToolStripMenuItem اضافهکارجدیدToolStripMenuItem;
        private ToolStripMenuItem اضافهکارویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem07;
        private ToolStripMenuItem اضافهکارگزارشToolStripMenuItem;
        private ToolStripMenuItem درخواستاضافهکارToolStripMenuItem;
        private ToolStripMenuItem درخواستاضافهکارجدیدToolStripMenuItem;
        private ToolStripMenuItem درخواستاضافهکارویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem08;
        private ToolStripMenuItem درخواستاضافهکارگزارشToolStripMenuItem;
        private ToolStripMenuItem کشیکماهانهToolStripMenuItem;
        private ToolStripMenuItem درخواستکشیکماهانهToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem09;
        private ToolStripMenuItem لیستکشیکماهانهToolStripMenuItem;
        private ToolStripMenuItem اضافهکارشیفتToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem01;
        private ToolStripMenuItem جابجاییکشیکToolStripMenuItem;
        private ToolStripMenuItem امتیازانضباطیToolStripMenuItem;
        private ToolStripMenuItem امتیازانضباطیثبتToolStripMenuItem;
        private ToolStripMenuItem امتیازانضباطیویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem06;
        private ToolStripMenuItem امتیازانضباطیگزارشToolStripMenuItem;
        private ToolStripMenuItem پایشفنیToolStripMenuItem;
        private ToolStripMenuItem دورههایبازآموزیToolStripMenuItem;
        private ToolStripMenuItem دورههایبازآموزیثبتToolStripMenuItem;
        private ToolStripMenuItem دورههایبازآموزیویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem4;
        private ToolStripMenuItem دورههایبازآموزیگزارشToolStripMenuItem;
        private ToolStripMenuItem اعلامخرابیToolStripMenuItem;
        private ToolStripMenuItem اعلامخرابیثبتToolStripMenuItem;
        private ToolStripMenuItem اعلامخرابیویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem5;
        private ToolStripMenuItem اعلامخرابیگزارشToolStripMenuItem;
        private ToolStripMenuItem عملکردفنیToolStripMenuItem;
        private ToolStripMenuItem عملکردفنیثبتToolStripMenuItem;
        private ToolStripMenuItem عملکردفنیویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem6;
        private ToolStripMenuItem عملکردفنیگزارشToolStripMenuItem;
        private ToolStripMenuItem جابجاییتریپراهبرانToolStripMenuItem;
        private ToolStripMenuItem کارکردراهبرانToolStripMenuItem;
        private ToolStripMenuItem تریپهایخاصToolStripMenuItem;
        private ToolStripMenuItem راهبرانرزروToolStripMenuItem;
        private ToolStripMenuItem پارکینگومانورToolStripMenuItem;
        private ToolStripMenuItem آرایشناوگانToolStripMenuItem;
        private ToolStripMenuItem آرایشناوگانثبتToolStripMenuItem;
        private ToolStripMenuItem آرایشناوگانویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem10;
        private ToolStripMenuItem آرایشناوگانگزارشToolStripMenuItem;
        private ToolStripMenuItem عملیاتقطارToolStripMenuItem;
        private ToolStripMenuItem عملیاتقطارگزارشعملیاتToolStripMenuItem;
        private ToolStripMenuItem عملیاتقطارگزارشراهبریToolStripMenuItem;
        private ToolStripMenuItem نمایشاطلاعیههاToolStripMenuItem;
        private ToolStripMenuItem اطلاعیهآموزشیToolStripMenuItem;
        private ToolStripMenuItem اطلاعیهآموزشیثبتToolStripMenuItem;
        private ToolStripMenuItem اطلاعیهآموزشیویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem02;
        private ToolStripSeparator ToolStripMenuItem03;
        private ToolStripMenuItem پارامترهایپردازشلوحهویرایشToolStripMenuItem;
        private ToolStripMenuItem پارامترهایپردازشلوحهجدیدToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem2;
        private ToolStripMenuItem عملیاتقطارویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem3;
        private ToolStripMenuItem ویرایشمشخصاتفردیToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem7;
        private ToolStripMenuItem دفترتلفنToolStripMenuItem;
        private ToolStripMenuItem سابقهجابجاییشیفتToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem11;
        private ToolStripMenuItem درخواستکشیکماهانهگزارشToolStripMenuItem;
        private ToolStripMenuItem بارگذاریمجدددادههاToolStripMenuItem;
        private ToolStripMenuItem آخرینتغییراتپرسنلToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem19;
        private ToolStripMenuItem پردازشلوحهپایانهToolStripMenuItem;
        private ToolStripMenuItem پارامترهایپردازشToolStripMenuItem;
        private ToolStripMenuItem ثبتجدولحرکتیدستیToolStripMenuItem;
        private ToolStripMenuItem الگویتریپراهبرانToolStripMenuItem;
        private ToolStripMenuItem عملیاتقطارجدیدToolStripMenuItem;
        private ToolStripMenuItem طبقجدولاعزامToolStripMenuItem;
        private ToolStripMenuItem خارجازجدولاعزامToolStripMenuItem;
        private ToolStripMenuItem ویرایشجدولحرکتیToolStripMenuItem;
        private ToolStripMenuItem تقویمToolStripMenuItem;
        private Label TrialLabel;
        private ToolStripMenuItem تریپروزانهراهبرToolStripMenuItem;
        private ToolStripMenuItem تریپهایروزانهToolStripMenuItem;
        private ToolStripMenuItem لوحهروزانهراهبریToolStripMenuItem;
        private ToolStripMenuItem ثبتلوحهاولیهToolStripMenuItem;
        private ToolStripMenuItem ثبتلوحهاجراشدهToolStripMenuItem;
        private ToolStripMenuItem ثبتلوحهنهاییToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem22;
        private ToolStripMenuItem گزارشلوحهثبتشدهToolStripMenuItem;
        private ToolStripMenuItem وضعیتپارکینگToolStripMenuItem;
        private ToolStripMenuItem تاریخچهToolStripMenuItem;
        private ToolStripMenuItem عملیاتمانورToolStripMenuItem;
        private ToolStripMenuItem ثبتمانورجدیدToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem23;
        private ToolStripMenuItem تماسباادمینToolStripMenuItem;
        private ToolStripMenuItem تریپدرشیفتToolStripMenuItem;
        private ToolStripMenuItem ثبتانتخاباتToolStripMenuItem;
        private ToolStripMenuItem شرکتدرانتخاباتToolStripMenuItem;
        private ToolStripMenuItem نتیجهانتخاباتToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem24;
        private ToolStripMenuItem اضافهکارگروهیToolStripMenuItem;
        private ToolStripMenuItem آلبومپرسنلیToolStripMenuItem;
        private ToolStripMenuItem کارکردماهانهپرسنلToolStripMenuItem;
        private ToolStripMenuItem تقویمکاریToolStripMenuItem;
        private ToolStripMenuItem اطلاعیهالکترونیکToolStripMenuItem;
        private ToolStripMenuItem عملکردروزانهToolStripMenuItem;
        private ToolStripMenuItem تحویلوتحولقطارToolStripMenuItem;
        private ToolStripMenuItem پردازشلوحههشتگردToolStripMenuItem;
        private ToolStripMenuItem درخواستسرویسToolStripMenuItem;
        private ToolStripMenuItem بهینهسازیتریپToolStripMenuItem;
        private ToolStripMenuItem مجموعتریپراهبرانToolStripMenuItem;
        private ToolStripMenuItem نمودارروزانهاضافهکارToolStripMenuItem;
        private ToolStripMenuItem ثبتجدولحرکتیازفایلToolStripMenuItem;
        private ToolStripMenuItem پردازشلوحهروزانهToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem21;
        private ToolStripMenuItem پرسنلعملیاتToolStripMenuItem;
        private ToolStripMenuItem پرسنلجدیدToolStripMenuItem;
        private ToolStripMenuItem پرسنلویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem25;
        private ToolStripMenuItem پرسنلگزارشToolStripMenuItem;
        private ToolStripMenuItem مجوزپرسنلToolStripMenuItem;
        private ToolStripMenuItem مجوزویرایشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem26;
        private ToolStripMenuItem مجوزگزارشToolStripMenuItem;
        private ToolStripSeparator ToolStripMenuItem8;
        private ToolStripSeparator ToolStripMenuItem27;
        private ToolStripMenuItem عملکردروزانهراهبرانToolStripMenuItem;
        private ToolStripMenuItem پردازشلوحهروزانهToolStripMenuItem1;
        private System.ComponentModel.IContainer components;
        private NewPanel newPanel1;
        private Label PhoneLabel;
        private Panel DateLabelPanel;
        private Panel panel2;
    }
}
