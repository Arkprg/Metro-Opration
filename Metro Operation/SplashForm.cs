using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Operation
{
    public partial class SplashForm
    {
        public SplashForm()
        {
            InitializeComponent();
            Opacity=0; // شروع شفاف
        }

        public async void SplashForm_Load(object sender, EventArgs e)
        {
            try
            {
                StartPosition=FormStartPosition.Manual;
                Top=Screen.PrimaryScreen.WorkingArea.Height / 4 - Height / 2;
                Left=(Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
                TransparencyKey=BackColor;

                // محو شدن تدریجی (Fade-In)
                await FadeInAsync();

                // بررسی دیتابیس در ترد جدا
                bool dbReady=await Task.Run(() => AppState.DbChecker());

                if (!dbReady)
                {
                    MessageBoxFa.Show("اتصال به دیتابیس برقرار نشد!", "خطا", MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }

                // مکث کوتاه برای زیبایی
                await Task.Delay(1500);

                // محو شدن تدریجی (Fade-Out)
                await FadeOutAsync();

                DialogResult=DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MainForm.ErrorLogo += $"{this.Text}: {ex.Message}\n";
                MessageBoxFa.Show("خطا در اجرای برنامه. لطفاً دوباره تلاش کنید.", "خطا", MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private async Task FadeInAsync()
        {
            while (Opacity < 1)
            {
                await Task.Delay(20);
                Opacity += 0.02;
            }
        }

        private async Task FadeOutAsync()
        {
            while (Opacity > 0)
            {
                await Task.Delay(20);
                Opacity -= 0.02;
            }
        }
    }
}