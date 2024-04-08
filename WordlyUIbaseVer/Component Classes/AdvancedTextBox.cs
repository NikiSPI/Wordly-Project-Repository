using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordly_alpha
{
    public class AdvancedTextBox : TextBox
    {
        //additions: auto size - off; customizable border color
        public AdvancedTextBox()
        {
            AutoSize = false;
        }


        private const int WM_PAINT = 0xF;
        Color borderColor;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor, 1))
                    {
                        g.DrawRectangle(p, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                    }
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            borderColor = this.BackColor;
        }
    }
}
