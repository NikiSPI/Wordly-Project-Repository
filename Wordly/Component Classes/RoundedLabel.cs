using System.Drawing.Drawing2D;

namespace Wordly
{
    public class RoundedLabel : Label
    {
        public int CornerRadius
        {
            get { return rdus; }
            set
            {
                rdus = value;
                Invalidate();
            }
        }

        private int rdus = 8;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle tempRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath GraphPath = new GraphicsPath();
            int dmtr = rdus * 2; //used only for the arcs

            GraphPath.AddArc(tempRect.X, tempRect.Y, dmtr, dmtr, 180, 90);
            //GraphPath.AddLine(tempRect.X + rdus, tempRect.Y, tempRect.X + tempRect.Width - rdus, tempRect.Y); //this is purposely not active

            GraphPath.AddArc(tempRect.X + tempRect.Width - dmtr, tempRect.Y, dmtr, dmtr, 270, 90);
            GraphPath.AddLine(tempRect.X + tempRect.Width + 1, tempRect.Y + rdus, tempRect.X + tempRect.Width + 1, tempRect.Y + tempRect.Height - rdus); //for perfect simetry which is ruined without the + 1

            GraphPath.AddArc(tempRect.X + tempRect.Width - dmtr, tempRect.Y + tempRect.Height - dmtr, dmtr, dmtr, 0, 90);
            GraphPath.AddLine(tempRect.X + tempRect.Width - rdus, tempRect.Y + tempRect.Height + 1, tempRect.X + rdus, tempRect.Y + tempRect.Height + 1); //again for simetry

            GraphPath.AddArc(tempRect.X, tempRect.Y + tempRect.Height - dmtr, dmtr, dmtr, 90, 90);
            //GraphPath.AddLine(tempRect.X, tempRect.Y + tempRect.Height - rdus, tempRect.X, tempRect.Y + rdus); //this is purposely not active

            Region = new Region(GraphPath);
        }
    }
}
