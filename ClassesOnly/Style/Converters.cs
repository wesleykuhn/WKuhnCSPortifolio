using System.Drawing;

namespace ClassesOnly.Style
{
    public static class Converters
    {
        public static string ColorToHexString(Color color)
        {
            Color hex = ColorTranslator.FromHtml("#FF0000");
            return ColorTranslator.ToHtml(hex);
        }
    }
}
