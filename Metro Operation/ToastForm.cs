using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Metro_Operation
{

    public partial class ToastForm
    {

        #region  Variables

        /// <summary>
        /// The list of currently open ToastForms.
        /// </summary>
        private static readonly List<ToastForm> openForms = new List<ToastForm>();

        /// <summary>
        /// Indicates whether the form can receive focus or not.
        /// </summary>
        //private bool allowFocus = false;
        /// <summary>
        /// The object that creates the sliding animation.
        /// </summary>
        private readonly ToastAnimatorForm animator;
        /// <summary>
        /// The handle of the window that currently has focus.
        /// </summary>
        private IntPtr currentForegroundWindow;

        #endregion //Variables

        #region  APIs

        /// <summary>
        /// Gets the handle of the window that currently has focus.
        /// </summary>
        /// <returns>
        /// The handle of the window that currently has focus.
        /// </returns>
        [DllImport("user32")] private static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// Activates the specified window.
        /// </summary>
        /// <param name="hWnd">
        /// The handle of the window to be focused.
        /// </param>
        /// <returns>
        /// True if the window was focused; False otherwise.
        /// </returns>
        [DllImport("user32")] private static extern bool SetForegroundWindow(IntPtr hWnd);

        #endregion //APIs

        #region  Constructors

        /// <summary>
        /// Creates a new ToastForm object that is displayed for the specified length of time.
        /// </summary>
        /// <param name="lifeTime">
        /// The length of time, in milliseconds, that the form will be displayed.
        /// </param>
        ///

        public ToastForm(int lifeTime, string Message)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            //Set the time for which the form should be displayed and the message to display.
            lifeTimer.Interval = lifeTime;
            messageLabel.Text = Message;
            TitleLable.Text = "تغییر در اطلاعات ";

            //Display the form by sliding up.
            animator = new ToastAnimatorForm(this, ToastAnimatorForm.AnimationMethod.Slide, ToastAnimatorForm.AnimationDirection.Up, 500);
        }

        public ToastForm(int lifeTime, string Title, string Message)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            //Set the time for which the form should be displayed and the message to display.
            lifeTimer.Interval = lifeTime;
            messageLabel.Text = Message;
            TitleLable.Text = Title;

            //Display the form by sliding up.
            animator = new ToastAnimatorForm(this, ToastAnimatorForm.AnimationMethod.Slide, ToastAnimatorForm.AnimationDirection.Up, 500);
        }

        public ToastForm(int lifeTime, string Title, string Message, string Picture)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            //Set the time for which the form should be displayed and the message to display.
            lifeTimer.Interval = lifeTime;
            messageLabel.Text = Message;
            TitleLable.Text = Title;
            PictureBox1.Image = Image.FromFile(Picture);

            //Display the form by sliding up.
            animator = new ToastAnimatorForm(this, ToastAnimatorForm.AnimationMethod.Slide, ToastAnimatorForm.AnimationDirection.Up, 500);
        }

        #endregion //Constructors

        #region  Methods

        /// <summary>
        /// Displays the form.
        /// </summary>
        /// <remarks>
        /// Required to allow the form to determine the current foreground window     before being displayed.
        /// </remarks>
        public new void Show()
        {
            //Determine the current foreground window so it can be reactivated each time this form tries to get the focus.
            currentForegroundWindow = GetForegroundWindow();

            //Display the form.
            base.Show();
        }

        #endregion //Methods

        #region  Event Handlers

        public void ToastForm_Load(object sender, EventArgs e)
        {
            //Display the form just above the system tray.
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 5, Screen.PrimaryScreen.WorkingArea.Height - Height - 5);

            //Move each open form upwards to make room for this one.
            foreach (ToastForm openForm in openForms)
            {
                openForm.Top -= Height + 5;
            }

            //Add this form from the open form list.
            openForms.Add(this);

            //Start counting down the form's liftime.
            lifeTimer.Start();
        }


        public void ToastForm_Shown(object sender, EventArgs e)
        {
            //Once the animation has completed the form can receive focus.
            //allowFocus = true;

            //Close the form by sliding down.
            animator.Direction = ToastAnimatorForm.AnimationDirection.Down;
        }

        public void ToastForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Move down any open forms above this one.
            foreach (ToastForm openForm in openForms)
            {
                if (ReferenceEquals(openForm, this))
                {
                    //The remaining forms are below this one.
                    break;
                }

                openForm.Top += Height + 5;
            }

            //Remove this form from the open form list.
            openForms.Remove(this);
        }

        public void LifeTimer_Tick(object sender, EventArgs e)
        {
            //The form's lifetime has expired.
            Close();
        }

        public void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion //Event Handlers
    }
}
