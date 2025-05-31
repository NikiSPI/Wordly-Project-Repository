using System.Drawing.Drawing2D;

namespace Wordly
{
    public class RoundedPanel : Panel
    {
        private int rdus = 5;
        private Pen borderPen = new Pen(Color.Black, 0);
        public int CornerRadius
        {
            get { return this.rdus; }
            set
            {
                this.rdus = value;

                Invalidate();
            }
        }
        public float BorderThickness
        {
            get {
                if (this.borderPen.Width == 0) return 0;
                return ((this.borderPen.Width - 1) / 2); 
            }
            set
            {
                this.borderPen.Width = (value * 2 + 1);

                Invalidate();
            }
        }
        public Color BorderColor
        {
            get { return this.borderPen.Color; }
            set
            {
                this.borderPen.Color = value;

                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle tR = new Rectangle(0, 0, Width, Height);//temporary Rectangle 
            GraphicsPath GraphPath = new GraphicsPath();
            int dmtr = rdus * 2;

            int addX = 1, addY = 1, addL = 1;
            if (rdus == 1) addX = 0;

            GraphPath.AddArc(tR.X, tR.Y, dmtr, dmtr, 180, 90);
            GraphPath.AddLine(tR.X + rdus, tR.Y, tR.X + Width - rdus, tR.Y); //this is purposely not active

            GraphPath.AddArc(tR.X + Width - dmtr - addX, tR.Y, dmtr, dmtr, 270, 90);
            GraphPath.AddLine(tR.X + Width, tR.Y + rdus + addL, tR.X + Width, tR.Y + Height - rdus - addL);

            GraphPath.AddArc(tR.X + Width - dmtr - addX, tR.Y + Height - dmtr - addY, dmtr, dmtr, 0, 90);
            GraphPath.AddLine(tR.X + Width - rdus, tR.Y + Height, tR.X + rdus, tR.Y + Height);

            GraphPath.AddArc(tR.X, tR.Y + Height - dmtr - addY, dmtr, dmtr, 90, 90);
            GraphPath.AddLine(tR.X, tR.Y + Height - rdus, tR.X, tR.Y + rdus); //this is purposely not active

            Region = new Region(GraphPath);


            //|Border|
            BorderStyle = BorderStyle.None;

            if (borderPen.Width > 2)
            {
                GraphicsPath GraphPathB = new GraphicsPath();
                tR = new Rectangle(0, 0, Width - 1, Height - 1);//temporary Rectangle 

                GraphPathB.AddArc(tR.X, tR.Y, dmtr, dmtr, 180, 90);
                GraphPathB.AddLine(tR.X + rdus + 1, tR.Y, tR.X + tR.Width - rdus - 1, tR.Y); //this is purposely not active

                GraphPathB.AddArc(tR.X + tR.Width - dmtr - addX, tR.Y, dmtr, dmtr, 270, 90);
                GraphPathB.AddLine(tR.X + tR.Width, tR.Y + rdus + 1, tR.X + tR.Width, tR.Y + tR.Height - rdus - 1);

                GraphPathB.AddArc(tR.X + tR.Width - dmtr - addX, tR.Y + tR.Height - dmtr - addY, dmtr, dmtr, 0, 90);
                GraphPathB.AddLine(tR.X + tR.Width - rdus - 1, tR.Y + tR.Height, tR.X + rdus + 1, tR.Y + tR.Height);

                GraphPathB.AddArc(tR.X, tR.Y + tR.Height - dmtr - addY, dmtr, dmtr, 90, 90);
                GraphPathB.AddLine(tR.X, tR.Y + tR.Height - rdus - 1, tR.X, tR.Y + rdus + 1); //this is purposely not active

                e.Graphics.DrawPath(borderPen, GraphPathB);

            }


        }

    }
}

