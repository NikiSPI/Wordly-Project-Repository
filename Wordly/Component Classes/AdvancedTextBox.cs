using System.Diagnostics.Eventing.Reader;

namespace Wordly
{
    public class AdvancedTextBox : TextBox
    {
        // | Additions: automatic resizing based on lines; customizable border color

        public AdvancedTextBox()
        {
            TextChanged += AdvancedTextBox_TextChanged;
            currentLineCount = LineCount();
            
            LineCountChanged += AdvancedTextBox_LineCountChanged;
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
                        g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                    }
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            borderColor = BackColor;
        }



        public int LineCount()
        {
            if(Text == "")
                return 1;
            else if (Text[Text.Length - 1] == '\n')
                return (GetLineFromCharIndex(Text.Length - 1) + 2);

            return (GetLineFromCharIndex(Text.Length - 1) + 1);
        }



        private int currentLineCount;

        public event EventHandler LineCountChanged;
        private void AdvancedTextBox_TextChanged(object? sender, EventArgs e)
        {

            // |Invoking the LineCountChanged event|; when there is a new LineCount() value
            if (currentLineCount != LineCount())
            {
                LineCountChanged?.Invoke(this, EventArgs.Empty);
                currentLineCount = LineCount();
            }
        }



        private bool automaticResize = false;
        public bool AutomaticResize
        {
            get { return automaticResize; }
            set { automaticResize = value; }
        }

        private int maxLineCount = 10;
        public int MaxLineCount
        {
            get { return maxLineCount; }
            set { maxLineCount = value; }
        }

        public event EventHandler MaxLineCountReached;

        private void AdvancedTextBox_LineCountChanged(object? sender, EventArgs e)
        {
            if (LineCount() > maxLineCount)
            {
                if (Text[Text.Length - 1] == '\n') //acounting for some strange character that comes alongside the new line 
                    Text = Text.Substring(0, Text.Length - 1);

                Text = Text.Substring(0, Text.Length - 1);
                SelectionStart = Text.Length;


                //'MAX LENGTH REACHED'
                MaxLineCountReached?.Invoke(this, EventArgs.Empty);
            }
            else if (automaticResize)
            {
                Size = new Size(Width, 1 + (PreferredHeight + 1) * LineCount());
            }
            


        }
    }
}
