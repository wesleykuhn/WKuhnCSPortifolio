using System.Drawing;

namespace ClassesOnly.Style
{
    public static class Mixer
    {
        /// <summary>
        /// Gets a color and makes it darker, for hover effect. Level 1 of darkness.
        /// </summary>
        /// <param name="color">The target color.</param>
        /// <returns>Color a little darker.</returns>
        public static Color GetHoveredColor1(Color color)
        {
            int r = color.R - 20;
            int g = color.G - 20;
            int b = color.B - 20;

            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;

            return Color.FromArgb(r, g, b);
        }
    }
}
