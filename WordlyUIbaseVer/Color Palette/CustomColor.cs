using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordly_alpha
{
    [TypeConverter(typeof(CustomColorTypeConverter))]
    public class CustomColor
    {
        public static CustomColor Neutral0  = new CustomColor { Color = Color.FromArgb(0  ,0  ,0  ) };
        public static CustomColor Neutral1  = new CustomColor { Color = Color.FromArgb(1  ,5  ,4  ) };
        public static CustomColor Neutral2  = new CustomColor { Color = Color.FromArgb(2  ,8  ,6  ) };
        public static CustomColor Neutral3  = new CustomColor { Color = Color.FromArgb(6  ,13 ,11 ) };
        public static CustomColor Neutral4  = new CustomColor { Color = Color.FromArgb(11 ,20 ,17 ) };
        public static CustomColor Neutral5  = new CustomColor { Color = Color.FromArgb(15 ,23 ,21 ) };
        public static CustomColor Neutral6  = new CustomColor { Color = Color.FromArgb(21 ,31 ,28 ) };
        public static CustomColor Neutral7  = new CustomColor { Color = Color.FromArgb(41 ,51 ,48 ) };
        public static CustomColor Neutral8  = new CustomColor { Color = Color.FromArgb(67 ,77 ,74 ) };
        public static CustomColor Neutral9  = new CustomColor { Color = Color.FromArgb(94 ,102,99 ) };
        public static CustomColor Neutral10 = new CustomColor { Color = Color.FromArgb(109,116,114) };
        public static CustomColor Neutral11 = new CustomColor { Color = Color.FromArgb(133,140,138) };
        public static CustomColor Neutral12 = new CustomColor { Color = Color.FromArgb(166,172,170) };
        public static CustomColor Neutral13 = new CustomColor { Color = Color.FromArgb(198,204,202) };
        public static CustomColor Neutral14 = new CustomColor { Color = Color.FromArgb(225,229,228) };
        public static CustomColor Neutral15 = new CustomColor { Color = Color.FromArgb(240,242,241) };
        public static CustomColor Neutral16 = new CustomColor { Color = Color.FromArgb(255,255,255) };

        public Color Color { get; private set; }

        public CustomColor()
        {

        }

        internal static CustomColor Find(Color color)
        {
            if (color == Neutral0.Color)
                return Neutral0;
            else if (color == Neutral1.Color)
                return Neutral1;
            else if (color == Neutral2.Color)
                return Neutral2;
            else if (color == Neutral3.Color)
                return Neutral3;
            else if (color == Neutral4.Color)
                return Neutral4;
            else if (color == Neutral5.Color)
                return Neutral5;
            else if (color == Neutral6.Color)
                return Neutral6;
            else if (color == Neutral7.Color)
                return Neutral7;
            else if (color == Neutral8.Color)
                return Neutral8;
            else if (color == Neutral9.Color)
                return Neutral9;
            else if (color == Neutral10.Color)
                return Neutral10;
            else if (color == Neutral11.Color)
                return Neutral11;
            else if (color == Neutral12.Color)
                return Neutral12;
            else if (color == Neutral13.Color)
                return Neutral13;
            else if (color == Neutral14.Color)
                return Neutral14;
            else if (color == Neutral15.Color)
                return Neutral15;
            else if (color == Neutral16.Color)
                return Neutral16;

            return new CustomColor { Color = Color.Transparent };
        }
    }
}
