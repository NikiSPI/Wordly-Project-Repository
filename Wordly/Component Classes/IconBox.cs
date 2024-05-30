using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Wordly
{
    public class IconBox : PictureBox
    {

        private Image defaultImg = null;

        private Color newClr = Color.Transparent;
        private bool resizable = false;
        private Size maxSize = new Size(500, 500);

        public IconBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public Color ReplacementColor
        {
            get { return this.newClr; }
            set
            {
                this.newClr = value;

                ChangeImgClr();

                Invalidate();
            }
        }
        public bool Resizable
        {
            get { return this.resizable; }
            set
            {
                this.resizable = value;

                CheckResizeImg();
                ChangeImgClr();

                Invalidate();
            }
        }
        public Size MaxSize
        {
            get { return this.maxSize; }
            set
            {
                this.maxSize = value;

                CheckResizeImg();
                ChangeImgClr();

                Invalidate();
            }
        }



        private void CheckResizeImg()
        {
            if (defaultImg == null)
            {
                defaultImg = this.Image;
            }

            if (resizable)
            {
                if (defaultImg.Width > maxSize.Width || defaultImg.Height > maxSize.Height)
                {
                    this.Image = ResizeImage(defaultImg, maxSize);
                }
                else
                {
                    this.Image = defaultImg;
                }

            }
            else
            {
                this.Image = defaultImg;
            }
        }
        private Image ResizeImage(Image imgToResize, Size size)
        {
            // Calculate width and height with new desired size
            float nPercentW = ((float)size.Width / (float)imgToResize.Width);
            float nPercentH = ((float)size.Height / (float)imgToResize.Height);
            float nPercent = Math.Min(nPercentW, nPercentH);

            // New Width and Height
            int destWidth = (int)(imgToResize.Width * nPercent);
            int destHeight = (int)(imgToResize.Height * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return b;
        }


        private Image ChangeImageColor(Image imgToChange)
        {
            Bitmap bmp = new Bitmap(imgToChange);

            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            var depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8; //bytes per pixel

            var buffer = new byte[data.Width * data.Height * depth];

            //copy pixels to buffer
            Marshal.Copy(data.Scan0, buffer, 0, buffer.Length);

            Parallel.Invoke(
               () => {
                   //upper-left
                   Process(buffer, 0, 0, data.Width / 2, data.Height / 2, data.Width, depth);
               },
               () => {
                   //upper-right
                   Process(buffer, data.Width / 2, 0, data.Width, data.Height / 2, data.Width, depth);
               },
               () => {
                   //lower-left
                   Process(buffer, 0, data.Height / 2, data.Width / 2, data.Height, data.Width, depth);
               },
                () => {
                    //lower-right
                    Process(buffer, data.Width / 2, data.Height / 2, data.Width, data.Height, data.Width, depth);
                }
            );

            //Copy the buffer back to image
            Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);

            bmp.UnlockBits(data);

            return bmp;
        }
        private void Process(byte[] buffer, int x, int y, int endx, int endy, int width, int depth)
        {
            for (int i = x; i < endx; i++)
            {
                for (int j = y; j < endy; j++)
                {
                    var offset = ((j * width) + i) * depth;
                    // Dummy work    
                    // To grayscale: 0.2126 R + 0.7152 G + 0.0722 B ( 0.2126 * buffer[offset + 0] + 0.7152 * buffer[offset + 1] + 0.0722 * buffer[offset + 2] )
                    // +2 = R; +1 = G; +0 = B
                    buffer[offset + 2] = newClr.R;
                    buffer[offset + 1] = newClr.G;
                    buffer[offset + 0] = newClr.B;

                }
            }
        }


        public void ChangeImgClr()
        {
            if (defaultImg == null)
            {
                defaultImg = this.Image;
            }

            if (newClr == Color.Transparent)
            {
                CheckResizeImg();
            }
            else if (this.Image != null)
            {
                this.Image = ChangeImageColor(this.Image);
            }
        }
    }
}
