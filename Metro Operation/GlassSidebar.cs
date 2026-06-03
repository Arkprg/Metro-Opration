using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_Operation
{
    public class GlassSidebar : Panel
    {
        public bool IsCollapsed=false;

        private readonly int ExpandedWidth=220;
        private readonly int CollapsedWidth=50;

        public class SidebarItem
        {
            public string Text { get; set; }
            public Image Icon { get; set; }
            public EventHandler Click { get; set; }
            public List<SidebarItem> SubItems { get; set; }
            public int Level { get; set; }
            public Button ButtonRef { get; set; }
            public bool IsExpanded { get; set; }

            public SidebarItem()
            {
                SubItems=new List<SidebarItem>();
            }
        }

        private List<SidebarItem> items=new List<SidebarItem>();

        public void SetItems(List<SidebarItem> list) => items=list;

        public GlassSidebar()
        {
            DoubleBuffered=true;
            Dock=DockStyle.Right;
            Width=ExpandedWidth;

            // شیشه‌ای واقعی
            BackColor=Color.Transparent;
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);

            // Toggle button
            Button toggle=new Button
            {
                Text="≡",
                Font=new Font("Tahoma", 12, FontStyle.Bold),
                Width=40,
                Height=40,
                Left=5,
                Top=5,
                FlatStyle=FlatStyle.Flat,
                BackColor=Color.Transparent,
                ForeColor=Color.Silver
            };
            toggle.FlatAppearance.BorderSize=0;
            toggle.Click += (s, e) => ToggleSidebar();
            Controls.Add(toggle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // پس‌زمینه شفاف، فقط خط دور برای زیبایی
            using (Pen border=new Pen(Color.FromArgb(160, 255, 255, 255)))
                e.Graphics.DrawRectangle(border, 0, 0, Width - 1, Height - 1);
        }

        public void Build()
        {
            var remove=new List<Control>();
            foreach (Control c in Controls)
                if (!(c is Button b && b.Text == "≡"))
                    remove.Add(c);

            foreach (var c in remove)
                Controls.Remove(c);

            int y=55;
            foreach (SidebarItem root in items)
                CreateItem(root, ref y);

            FastRebuild();
        }

        private void CreateItem(SidebarItem item, ref int y)
        {
            Button btn=new Button();
            item.ButtonRef=btn;

            btn.AutoSize=false;
            btn.Left=10;
            btn.Top=y;
            btn.Height=35;
            btn.Width=ExpandedWidth - 20 - (item.Level * 25);


            // لایه نیمه‌شفاف برای خوانایی متن
            //btn.BackColor=Color.FromArgb(120, 100, 100, 100);
            btn.BackColor=Color.FromArgb(item.Level * 70, 100, 100, 100);
            btn.ForeColor=Color.White;
            btn.FlatStyle=FlatStyle.Flat;
            btn.FlatAppearance.BorderSize=0;

            float baseFontSize=11 - item.Level * 0.8f; // فونت اصلی
            btn.Font=new Font("Tahoma", baseFontSize);
            btn.TextAlign=ContentAlignment.MiddleLeft;
            btn.ImageAlign=ContentAlignment.MiddleRight;
            btn.Image=item.Icon;

            UpdateButtonArrow(item);

            Controls.Add(btn);
            y += btn.Height;

            // Hover effect
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor=Color.FromArgb(150, 70, 70, 70);
                btn.Font=new Font("Tahoma", baseFontSize * 0.9f, FontStyle.Bold);
            };
            btn.MouseLeave += (s, e) =>
            {
                //btn.BackColor=Color.FromArgb(120, 100, 100, 100);
                btn.BackColor=Color.FromArgb(item.Level * 70, 100, 100, 100);
                btn.Font=new Font("Tahoma", baseFontSize, FontStyle.Regular);
            };

            if (item.SubItems.Count == 0)
            {
                btn.Click += async (s, e) =>
                {
                    if (!IsCollapsed)
                    {
                        CollapseSidebar();
                        await Task.Delay(80);
                    }
                    item.Click?.Invoke(s, e);
                };
            }
            else
            {
                btn.Click += (s, e) =>
                {
                    ShowSubItems(item, !item.IsExpanded);
                };
            }

            foreach (SidebarItem sub in item.SubItems)
            {
                sub.Level=item.Level + 1;
                CreateItem(sub, ref y);
                sub.ButtonRef.Visible=false;
            }
        }

        private void UpdateButtonArrow(SidebarItem item)
        {
            if (item.SubItems.Count > 0)
            {
                Bitmap bmp=new Bitmap(20, 20);
                using (Graphics g=Graphics.FromImage(bmp))
                using (Font f=new Font("Tahoma", 8, FontStyle.Bold))
                using (SolidBrush b=new SolidBrush(Color.White))
                    g.DrawString(item.IsExpanded ? "▼" : "◄", f, b, 0, 0);

                item.ButtonRef.Image=bmp;
                item.ButtonRef.ImageAlign=ContentAlignment.MiddleRight;
            }
            //else
            //{
            //    item.ButtonRef.Image=null;
            //}

            string indent=item.Level > 0 ? "• " : "  ";
            item.ButtonRef.Text=indent + item.Text;
            item.ButtonRef.TextAlign=ContentAlignment.MiddleLeft;
        }

        private void ShowSubItems(SidebarItem parent, bool show)
        {
            parent.IsExpanded=show;
            UpdateButtonArrow(parent);

            if (parent.Level == 0 && show)
                foreach (SidebarItem other in items)
                    if (other != parent)
                        HideAllSubItems(other);

            if (parent.Level == 1 && show)
            {
                SidebarItem root=FindRootOf(parent);
                if (root != null)
                    foreach (SidebarItem sib in root.SubItems)
                        if (sib != parent)
                            HideAllSubItems(sib);
            }

            foreach (SidebarItem sub in parent.SubItems)
            {
                sub.ButtonRef.Visible=show;
                if (!show)
                    HideAllSubItems(sub);
            }

            FastRebuild();
        }

        private void HideAllSubItems(SidebarItem parent)
        {
            parent.IsExpanded=false;
            UpdateButtonArrow(parent);

            foreach (SidebarItem s in parent.SubItems)
            {
                s.ButtonRef.Visible=false;
                HideAllSubItems(s);
            }
        }

        private SidebarItem FindRootOf(SidebarItem node)
        {
            foreach (SidebarItem root in items)
                if (root.SubItems.Contains(node))
                    return root;
            return null;
        }

        private IEnumerable<SidebarItem> AllItems()
        {
            foreach (SidebarItem i in items)
            {
                yield return i;
                foreach (SidebarItem c in Rec(i))
                    yield return c;
            }
        }

        private IEnumerable<SidebarItem> Rec(SidebarItem p)
        {
            foreach (SidebarItem s in p.SubItems)
            {
                yield return s;
                foreach (SidebarItem ss in Rec(s))
                    yield return ss;
            }
        }

        private void FastRebuild()
        {
            SuspendLayout();
            int y=55;

            foreach (SidebarItem item in AllItems())
            {
                if (!item.ButtonRef.Visible) continue;

                item.ButtonRef.Top=y;
                item.ButtonRef.Width=(IsCollapsed ? CollapsedWidth : ExpandedWidth) - 20 - (item.Level * 25);

                y += item.ButtonRef.Height;
            }

            ResumeLayout(false);
        }

        private void CollapseSidebar()
        {
            IsCollapsed=true;
            Width=CollapsedWidth;

            foreach (SidebarItem i in AllItems())
            {
                i.IsExpanded=false;
                UpdateButtonArrow(i);
                i.ButtonRef.Visible=false;
            }

            FastRebuild();
        }

        private void ToggleSidebar()
        {
            IsCollapsed=!IsCollapsed;
            Width=IsCollapsed ? CollapsedWidth : ExpandedWidth;

            if (IsCollapsed)
            {
                foreach (SidebarItem i in AllItems())
                {
                    i.IsExpanded=false;
                    UpdateButtonArrow(i);
                    i.ButtonRef.Visible=false;
                }
            }
            else
            {
                foreach (SidebarItem root in items)
                    root.ButtonRef.Visible=true;
            }

            FastRebuild();
        }

        public void AttachAutoClose(Form host)
        {
            host.MouseDown += (s, e) =>
            {
                if (IsCollapsed) return;
                Point clickPoint=host.PointToClient(Cursor.Position);
                if (!Bounds.Contains(clickPoint))
                    CollapseSidebar();
            };
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Metro_Operation
//{
//    public class GlassSidebar : Panel
//    {
//        public bool IsCollapsed=false;

//        private readonly int ExpandedWidth=220;
//        private readonly int CollapsedWidth=50;

//        public class SidebarItem
//        {
//            public string Text { get; set; }
//            public Image Icon { get; set; }
//            public EventHandler Click { get; set; }
//            public List<SidebarItem> SubItems { get; set; }
//            public int Level { get; set; }
//            public Button ButtonRef { get; set; }
//            public bool IsExpanded { get; set; }

//            public SidebarItem()
//            {
//                SubItems=new List<SidebarItem>();
//            }
//        }

//        private List<SidebarItem> items=new List<SidebarItem>();

//        public void SetItems(List<SidebarItem> list)
//        {
//            items=list;
//        }

//        public GlassSidebar()
//        {
//            DoubleBuffered=true;
//            BackColor=Color.Transparent;
//            Dock=DockStyle.Right;
//            Width=ExpandedWidth;

//            SetStyle(ControlStyles.UserPaint |
//                     ControlStyles.AllPaintingInWmPaint |
//                     ControlStyles.OptimizedDoubleBuffer, true);

//            // Toggle button
//            Button toggle=new Button
//            {
//                Text="≡",
//                Font=new Font("Tahoma", 12, FontStyle.Bold),
//                Width=40,
//                Height=40,
//                Left=5,
//                Top=5,
//                FlatStyle=FlatStyle.Flat,
//                BackColor=Color.Transparent
//            };
//            toggle.FlatAppearance.BorderSize=0;
//            toggle.Click += (s, e) => ToggleSidebar();

//            Controls.Add(toggle);
//        }

//        protected override void OnPaint(PaintEventArgs e)
//        {
//            base.OnPaint(e);

//            using (SolidBrush bg=new SolidBrush(Color.FromArgb(100, 255, 255, 255)))
//                e.Graphics.FillRectangle(bg, ClientRectangle);

//            using (Pen border=new Pen(Color.FromArgb(160, 255, 255, 255)))
//                e.Graphics.DrawRectangle(border, 0, 0, Width - 1, Height - 1);
//        }

//        public void Build()
//        {
//            var remove=new List<Control>();
//            foreach (Control c in Controls)
//                if (!(c is Button b && b.Text == "≡"))
//                    remove.Add(c);

//            foreach (var c in remove)
//                Controls.Remove(c);

//            int y=55;
//            foreach (SidebarItem root in items)
//                CreateItem(root, ref y);

//            FastRebuild();
//        }

//        private void CreateItem(SidebarItem item, ref int y)
//        {
//            Button btn=new Button();
//            item.ButtonRef=btn;

//            btn.Left=10;
//            btn.Top=y;
//            btn.Height=35;
//            btn.Width=ExpandedWidth - 20 - (item.Level * 25);

//            btn.TextAlign=ContentAlignment.MiddleLeft;
//            btn.ImageAlign=ContentAlignment.MiddleRight;
//            btn.Font=new Font("Tahoma", (float)(11 - item.Level * 0.8));
//            btn.BackColor=Color.FromArgb(item.Level * 70, 100, 100, 120);
//            btn.ForeColor=Color.White;
//            btn.FlatStyle=FlatStyle.Flat;
//            btn.FlatAppearance.BorderSize=0;

//            btn.Image=item.Icon;

//            UpdateButtonArrow(item);

//            Controls.Add(btn);
//            y += btn.Height;

//            btn.MouseEnter += (s, e) =>
//            {
//                btn.BackColor=Color.FromArgb(item.Level * 70, 170, 170, 200);
//                btn.Font=new Font(btn.Font, FontStyle.Bold);
//            };

//            btn.MouseLeave += (s, e) =>
//            {
//                btn.BackColor=Color.FromArgb(item.Level * 70, 100, 100, 120);
//                btn.Font=new Font(btn.Font, FontStyle.Regular);
//            };

//            if (item.SubItems.Count == 0)
//            {
//                btn.Click += async (s, e) =>
//                {
//                    if (!IsCollapsed)
//                    {
//                        CollapseSidebar();
//                        await Task.Delay(80);
//                    }
//                    item.Click?.Invoke(s, e);
//                };
//            }
//            else
//            {
//                btn.Click += (s, e) =>
//                {
//                    ShowSubItems(item, !item.IsExpanded);
//                };
//            }

//            foreach (SidebarItem sub in item.SubItems)
//            {
//                sub.Level=item.Level + 1;
//                CreateItem(sub, ref y);
//                sub.ButtonRef.Visible=false;
//            }
//        }

//        private void UpdateButtonArrow(SidebarItem item)
//        {
//            // فلش سمت راست
//            if (item.SubItems.Count > 0)
//            {
//                // ایجاد Bitmap برای فلش
//                Bitmap bmp=new Bitmap(20, 20);
//                using (Graphics g=Graphics.FromImage(bmp))
//                using (Font f=new Font("Tahoma", 10, FontStyle.Bold))
//                using (SolidBrush b=new SolidBrush(Color.White))
//                {
//                    g.DrawString(item.IsExpanded ? "▼" : "◄", f, b, 0, 0);
//                }

//                item.ButtonRef.Image=bmp;
//                item.ButtonRef.ImageAlign=ContentAlignment.MiddleRight;
//            }
//            else
//            {
//                item.ButtonRef.Image=null;
//            }

//            string indent=item.Level > 0 ? "• " : "  ";
//            item.ButtonRef.Text=indent + item.Text;
//            item.ButtonRef.TextAlign=ContentAlignment.MiddleLeft;
//        }

//        private void ShowSubItems(SidebarItem parent, bool show)
//        {
//            parent.IsExpanded=show;
//            UpdateButtonArrow(parent);

//            if (parent.Level == 0 && show)
//                foreach (SidebarItem other in items)
//                    if (other != parent)
//                        HideAllSubItems(other);

//            if (parent.Level == 1 && show)
//            {
//                SidebarItem root=FindRootOf(parent);
//                if (root != null)
//                    foreach (SidebarItem sib in root.SubItems)
//                        if (sib != parent)
//                            HideAllSubItems(sib);
//            }

//            foreach (SidebarItem sub in parent.SubItems)
//            {
//                sub.ButtonRef.Visible=show;
//                if (!show)
//                    HideAllSubItems(sub);
//            }

//            FastRebuild();
//        }

//        private void HideAllSubItems(SidebarItem parent)
//        {
//            parent.IsExpanded=false;
//            UpdateButtonArrow(parent);

//            foreach (SidebarItem s in parent.SubItems)
//            {
//                s.ButtonRef.Visible=false;
//                HideAllSubItems(s);
//            }
//        }

//        private SidebarItem FindRootOf(SidebarItem node)
//        {
//            foreach (SidebarItem root in items)
//                if (root.SubItems.Contains(node))
//                    return root;
//            return null;
//        }

//        private IEnumerable<SidebarItem> AllItems()
//        {
//            foreach (SidebarItem i in items)
//            {
//                yield return i;
//                foreach (SidebarItem c in Rec(i))
//                    yield return c;
//            }
//        }

//        private IEnumerable<SidebarItem> Rec(SidebarItem p)
//        {
//            foreach (SidebarItem s in p.SubItems)
//            {
//                yield return s;
//                foreach (SidebarItem ss in Rec(s))
//                    yield return ss;
//            }
//        }

//        private void FastRebuild()
//        {
//            SuspendLayout();
//            int y=55;

//            foreach (SidebarItem item in AllItems())
//            {
//                if (!item.ButtonRef.Visible) continue;

//                item.ButtonRef.Top=y;
//                item.ButtonRef.Width =
//                    (IsCollapsed ? CollapsedWidth : ExpandedWidth)
//                    - 20 - (item.Level * 25);

//                y += item.ButtonRef.Height;
//            }

//            ResumeLayout(false);
//        }

//        private void CollapseSidebar()
//        {
//            IsCollapsed=true;
//            Width=CollapsedWidth;

//            foreach (SidebarItem i in AllItems())
//            {
//                i.IsExpanded=false;
//                UpdateButtonArrow(i);
//                i.ButtonRef.Visible=false;
//            }

//            FastRebuild();
//        }

//        public void AttachAutoClose(Form host)
//        {
//            host.MouseDown += (s, e) =>
//            {
//                if (IsCollapsed)
//                    return;

//                Point clickpoint=host.PointToClient(Cursor.Position);
//                if (!Bounds.Contains(clickpoint))
//                    CollapseSidebar();
//            };
//        }

//        private void ToggleSidebar()
//        {
//            IsCollapsed=!IsCollapsed;
//            Width=IsCollapsed ? CollapsedWidth : ExpandedWidth;

//            if (IsCollapsed)
//            {
//                foreach (SidebarItem i in AllItems())
//                {
//                    i.IsExpanded=false;
//                    UpdateButtonArrow(i);
//                    i.ButtonRef.Visible=false;
//                }
//            }
//            else
//            {
//                foreach (SidebarItem root in items)
//                    root.ButtonRef.Visible=true;
//            }

//            FastRebuild();
//        }
//    }
//}