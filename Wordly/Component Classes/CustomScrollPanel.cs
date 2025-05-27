using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace Experimental
{
    public partial class CustomScrollPanel : Panel
    {
        private Timer thumbRefreshTimer;
        public CustomScrollPanel()
        {
            InitializeComponent();
            this.Load += CustomScrollPanel_Load;

            thumbRefreshTimer = new Timer();
            thumbRefreshTimer.Interval = 10;
            thumbRefreshTimer.Tick += Thumb_TimeCicle;

            SetValues();
            Invalidate();
        }

        #region |Designer Properties|

        private int radius = 10;
        private int thumbClrChange_hover = 10, thumbClrChange_hold = 20;
        private int thumbMinHeight = 20;
        private Size thumbMargin = new Size(4, 8), thumbHoldEnlargement = new Size(1,1);
        public int PanelRadius
        {
            get { return this.radius; }
            set
            {
                this.radius = value;

                Invalidate();
            }
        }
        public int ThumbColorChange_Hover
        {
            get { return this.thumbClrChange_hover; }
            set
            {
                this.thumbClrChange_hover = value;

                Invalidate();
            }
        }
        public int ThumbColorChange_Hold
        {
            get { return this.thumbClrChange_hold; }
            set
            {
                this.thumbClrChange_hold = value;

                Invalidate();
            }
        }

        public Color ThumbColor
        {
            get { return thumb.BackColor; }
            set
            {
                thumb.BackColor = value;

                Invalidate();
                thumb.Invalidate();
            }
        }
        public int ThumbRadius
        {
            get { return thumb.radius; }
            set
            {
                thumb.radius = value;

                Invalidate();
                thumb.Invalidate();
            }
        }
        public Size ThumbMargin
        {
            get { return this.thumbMargin; }
            set
            {
                this.thumbMargin = value;

                SetValues();

                Invalidate();
                thumb.Invalidate();
            }
        }
        public int ThumbWidth
        {
            get { return thumb.Width; }
            set
            {
                thumb.Size = new Size(value, thumb.Height);

                SetValues();

                Invalidate();
                thumb.Invalidate();
            }
        }
        public int ThumbMinHeight
        {
            get { return thumbMinHeight; }
            set
            {
                thumbMinHeight = value;

                SetValues();

                Invalidate();
                thumb.Invalidate();
            }
        }
        public Size ThumbHoldEnlargement
        {
            get { return thumbHoldEnlargement; }
            set
            {
                thumbHoldEnlargement = value;

                Invalidate();
            }
        }

        #endregion




        private void CustomScrollPanel_Load(object? sender, EventArgs e)
        {
            if (!IsInDesignMode())
            {
                Controls.Add(contentPnl);

                this.AutoScroll = false;

                thumbClr_default = thumb.BackColor;
                thumbClr_hover = SetThumbClrVariants(thumb.BackColor, thumbClrChange_hover);
                thumbClr_held = SetThumbClrVariants(thumb.BackColor, thumbClrChange_hold);

                Invalidate();
            }
        }
        private void CustomScrollPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!IsInDesignMode())
            {
                if (e.Control != contentPnl && e.Control != thumb)
                {
                    contentPnl.Controls.Add(e.Control);
                    this.Controls.Remove(e.Control);
                }
                GetMaxPosY();
                SetValues();

                Invalidate();
            }
        }   





        private int maxPosY;
        private float thumbPosPathLength, minThumbYPos, maxThumbYPos;
        private void GetMaxPosY()
        {
            foreach (Control control in contentPnl.Controls)
            {
                int controlBottom = control.Bottom;
                if (controlBottom > maxPosY)
                {
                    maxPosY = controlBottom;
                }
            }

            contentPnl.AutoScrollMargin = new Size(0, this.AutoScrollMargin.Height);
            maxPosY += contentPnl.AutoScrollMargin.Height;
            maxPosY -= this.Height;
        }
        private void SetValues()
        {
            thumb.Size = new Size(thumb.Width, GetThumbHeight());
            thumb.Location = new Point(this.Width - thumb.Width - thumbMargin.Width, thumbMargin.Height);

            thumbPosPathLength = this.Size.Height - thumb.Height - 2 * thumbMargin.Height;
            minThumbYPos = thumbMargin.Height;
            maxThumbYPos = this.Size.Height - thumb.Height - thumbMargin.Height;
        }
        private int GetThumbHeight()
        {
            float relation = (float)this.Height / (float)(maxPosY + this.Height);

            int thumbCalcHeight = (int)(relation * (float)(this.Height - 2 * thumbMargin.Height));

            if (thumbCalcHeight < thumbMinHeight) return thumbMinHeight;

            return thumbCalcHeight;
        }

        private Color thumbClr_default, thumbClr_hover, thumbClr_held;
        private int lightDarkBorder = 128;
        private Color SetThumbClrVariants(Color colorToChange, int changeColorValue)
        {
            int r, g, b;
            if (colorToChange.R > lightDarkBorder)
            {
                r = colorToChange.R - changeColorValue;
            }
            else
            {
                r = colorToChange.R + changeColorValue;
            }
        
            if (colorToChange.G > lightDarkBorder)
            {
                g = colorToChange.G - changeColorValue;
            }
            else
            {
                g = colorToChange.G + changeColorValue;
            }
        
            if (colorToChange.B > lightDarkBorder)
            {
                b = colorToChange.B - changeColorValue;
            }
            else
            {
                b = colorToChange.B + changeColorValue;
            }
        
            return Color.FromArgb(r, g, b);
        }







        private float newThumbYPos, initialYPos, initialCursorPos;
        private float tempRelation;
        private int tempAutoScrPosY;
        
        private void Thumb_MouseDown(object sender, MouseEventArgs e)
        {
            initialCursorPos = Cursor.Position.Y;
            initialYPos = thumb.Location.Y;
        
            contentPnl.ScrollOccurred -= ScrollablePanel_ScrollOccurred;
            thumbRefreshTimer.Start();

            thumb.Location = new Point(thumb.Location.X - thumbHoldEnlargement.Width, thumb.Location.Y - thumbHoldEnlargement.Height);
            thumb.Size = new Size(thumb.Size.Width + 2 * thumbHoldEnlargement.Width, thumb.Size.Height + 2 * thumbHoldEnlargement.Height);

            thumb.BackColor = thumbClr_held;
        }
        private void Thumb_MouseUp(object sender, MouseEventArgs e)
        {
            thumbRefreshTimer.Stop();
            contentPnl.ScrollOccurred += ScrollablePanel_ScrollOccurred;

            thumb.Size = new Size(thumb.Size.Width - 2 * thumbHoldEnlargement.Width, thumb.Size.Height - 2 * thumbHoldEnlargement.Height);
            thumb.Location = new Point(thumb.Location.X + thumbHoldEnlargement.Width, thumb.Location.Y + thumbHoldEnlargement.Height);

            thumb.BackColor = thumbClr_hover;
        }
        
        
        private void Thumb_TimeCicle(object? sender, EventArgs e)
        {
            newThumbYPos = initialYPos + Cursor.Position.Y - initialCursorPos;
        
            if (newThumbYPos < minThumbYPos)
            {
                contentPnl.AutoScrollPosition = new Point(contentPnl.AutoScrollPosition.X, 0);
        
                thumb.Location = new Point(thumb.Location.X, (int)minThumbYPos);
            }
        
            else if (newThumbYPos > maxThumbYPos)
            {
                contentPnl.AutoScrollPosition = new Point(contentPnl.AutoScrollPosition.X, maxPosY);
        
                thumb.Location = new Point(thumb.Location.X, (int)maxThumbYPos);
            }
        
            else if (newThumbYPos != thumb.Location.Y)
            {
                tempRelation = (newThumbYPos - thumbMargin.Height) / thumbPosPathLength;
                contentPnl.AutoScrollPosition = new Point(contentPnl.AutoScrollPosition.X, (int)(tempRelation * maxPosY));
        
                thumb.Location = new Point(thumb.Location.X, (int)newThumbYPos);
            }
        
        }
        
        
        private void ScrollablePanel_ScrollOccurred(object sender, EventArgs e)
        {
            if (tempAutoScrPosY != contentPnl.AutoScrollPosition.Y)
            {
                thumb.Location = new Point(thumb.Location.X, (int)((float)-contentPnl.AutoScrollPosition.Y / maxPosY * thumbPosPathLength) + thumbMargin.Height);
        
                tempAutoScrPosY = contentPnl.AutoScrollPosition.Y;
        
        
                // Invalidate the content panel to force a redraw during scrolling
                contentPnl.Invalidate();
                contentPnl.Update();
        
            }
        
        }
        
        
        private void Thumb_MouseEnter(object sender, EventArgs e)
        {
            thumb.BackColor = thumbClr_hover;
        }
        private void Thumb_MouseLeave(object sender, EventArgs e)
        {
            thumb.BackColor = thumbClr_default;
        }






        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime || this.DesignMode;
        }
        


        //--------------------
        // Load Event Created
        //--------------------
        public event EventHandler Load; // Declare the Load event
        private bool isLoaded = false;

        // Method to trigger the Load event
        private void LoadablePanel_HandleCreated(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                isLoaded = true;
                OnLoad(EventArgs.Empty);  // Trigger Load event
            }
        }
        // Method to raise the Load event
        protected virtual void OnLoad(EventArgs e)
        {
            Load?.Invoke(this, e);
        }



        //-----------
        // Roundness
        //-----------
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.Region = RoundedPanel.GetRect(radius, this.Width, this.Height);
            BorderStyle = BorderStyle.None;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Update the control's region when resized
            this.Region = RoundedPanel.GetRect(radius, this.Width, this.Height);
            this.Invalidate(); // Force the control to redraw
        }





        private class ContentPanel : Panel
        {
            public ContentPanel()
            {
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                this.UpdateStyles();
            }


            //----------------------------------------------------
            // INVISIBLE AUTOSCROLL IMPLEMENTATION
            // Some Complicated Stuff I don't fully understand
            // But basically this is directly tinkering with the microsoft events that are sent for the displaying of the scrollbar 
            //

            private const int SB_HORZ = 0;
            private const int SB_VERT = 1;

            [DllImport("user32.dll")]
            private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                HideScrollbars();

                // Invoke the custom event handler if any
                this.ScrollOccurred?.Invoke(this, EventArgs.Empty);
            }
            private void HideScrollbars()
            {
                // Hide horizontal and vertical scrollbars
                ShowScrollBar(this.Handle, SB_HORZ, 0);
                ShowScrollBar(this.Handle, SB_VERT, 0);
            }

            // Custom event to detect scroll changes
            public event EventHandler ScrollOccurred;
        }




        private  class RoundedPanel : Panel
        {
            public int radius = 3;
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                Region = GetRect(radius, this.Width, this.Height);
                BorderStyle = BorderStyle.None;
            }

            public static Region GetRect(int rdus, int w, int h)
            {
                Rectangle tempRect = new Rectangle(0, 0, w - 1, h - 1);
                GraphicsPath graphPath = new GraphicsPath();
                int dmtr = rdus * 2; //used only for the arcs

                graphPath.AddArc(tempRect.X, tempRect.Y, dmtr, dmtr, 180, 90);
                //GraphPath.AddLine(tempRect.X + rdus, tempRect.Y, tempRect.X + tempRect.Width - rdus, tempRect.Y); //this is purposely not active

                graphPath.AddArc(tempRect.X + tempRect.Width - dmtr, tempRect.Y, dmtr, dmtr, 270, 90);
                graphPath.AddLine(tempRect.X + tempRect.Width + 1, tempRect.Y + rdus, tempRect.X + tempRect.Width + 1, tempRect.Y + tempRect.Height - rdus); //for perfect simetry which is ruined without the + 1

                graphPath.AddArc(tempRect.X + tempRect.Width - dmtr, tempRect.Y + tempRect.Height - dmtr, dmtr, dmtr, 0, 90);
                graphPath.AddLine(tempRect.X + tempRect.Width - rdus, tempRect.Y + tempRect.Height + 1, tempRect.X + rdus, tempRect.Y + tempRect.Height + 1); //again for simetry

                graphPath.AddArc(tempRect.X, tempRect.Y + tempRect.Height - dmtr, dmtr, dmtr, 90, 90);
                //GraphPath.AddLine(tempRect.X, tempRect.Y + tempRect.Height - rdus, tempRect.X, tempRect.Y + rdus); //this is purposely not active

                return new Region(graphPath);
            }
        }

    }

}