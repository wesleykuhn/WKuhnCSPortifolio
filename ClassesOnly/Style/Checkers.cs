using System.Drawing;

namespace ClassesOnly.Style
{
    public static class Checkers
    {
        /// <summary>
        /// This method will return black or white, depending of the entered color. This will help to choose black or white to the labels.
        /// </summary>
        /// <param name="backColor">The backcolor of the target.</param>
        /// <returns>Black or White.</returns>
        public static Color UseWhiteOrBlack(Color backColor)
        {
            if (backColor.R + backColor.G + backColor.B < 382) return Color.White;
            else return Color.Black;
        }

        /// <summary>
        /// Compare if the color1 is equals to color2.
        /// </summary>
        /// <param name="c1">Color 1.</param>
        /// <param name="c2">Color 2.</param>
        /// <returns>True if it's the same color, else false.</returns>
        public static bool CompareColors(Color c1, Color c2)
        {
            if (c1.R == c2.R && c1.G == c2.G && c1.B == c2.B) return true;
            else return false;
        }
    }
}
