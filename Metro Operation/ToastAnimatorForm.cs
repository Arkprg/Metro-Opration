using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Metro_Operation
{
    /// <summary>
    /// Animates a form when it is shown, hidden or closed.
    /// </summary>
    /// <remarks>
    /// MDI child forms do not support the Blend method and only support other methods 
    /// while being displayed for the first time and when closing.
    /// </remarks>
    public sealed class ToastAnimatorForm
    {
        #region Types

        public enum AnimationMethod
        {
            Roll=0x0,
            Centre=0x10,
            Slide=0x40000,
            Blend=0x80000
        }

        [Flags]
        public enum AnimationDirection
        {
            Right=0x1,
            Left=0x2,
            Down=0x4,
            Up=0x8
        }

        #endregion

        #region Constants

        private const int AW_HIDE=0x10000;
        private const int AW_ACTIVATE=0x20000;
        private const int DEFAULT_DURATION=250;

        #endregion

        #region Variables

        private readonly Form ShowForm;
        private AnimationMethod _method;
        private AnimationDirection _direction;
        private int _duration;

        #endregion

        #region Properties

        public AnimationMethod Method
        {
            get => _method;
            set => _method=value;
        }

        public AnimationDirection Direction
        {
            get => _direction;
            set => _direction=value;
        }

        public int Duration
        {
            get => _duration;
            set => _duration=value;
        }

        public Form Form => ShowForm;

        #endregion

        #region API

        [DllImport("user32.dll", SetLastError=true)]
        private static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        #endregion

        #region Constructors

        public ToastAnimatorForm(Form form)
        {
            ShowForm=form ?? throw new ArgumentNullException(nameof(form));
            ShowForm.Load += Form_Load;
            ShowForm.VisibleChanged += Form_VisibleChanged;
            ShowForm.FormClosing += Form_Closing;
            _duration=DEFAULT_DURATION;
        }

        public ToastAnimatorForm(Form form, AnimationMethod method, int duration) : this(form)
        {
            _method=method;
            _duration=duration;
        }

        public ToastAnimatorForm(Form form, AnimationMethod method, AnimationDirection direction, int duration)
            : this(form, method, duration)
        {
            _direction=direction;
        }

        #endregion

        #region Event Handlers

        private void Form_Load(object sender, EventArgs e)
        {
            if (ShowForm.MdiParent == null || _method != AnimationMethod.Blend)
            {
                AnimateWindow(ShowForm.Handle, _duration,
                    AW_ACTIVATE | (int)_method | (int)_direction);
            }
        }

        private void Form_VisibleChanged(object sender, EventArgs e)
        {
            if (ShowForm.MdiParent != null)
            {
                return;
            }

            int flags=(int)_method | (int)_direction;
            flags |= ShowForm.Visible ? AW_ACTIVATE : AW_HIDE;

            AnimateWindow(ShowForm.Handle, _duration, flags);
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel && (ShowForm.MdiParent == null || _method != AnimationMethod.Blend))
            {
                AnimateWindow(ShowForm.Handle, _duration,
                    AW_HIDE | (int)_method | (int)_direction);
            }
        }

        #endregion
    }
}
