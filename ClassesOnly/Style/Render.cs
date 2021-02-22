using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ClassesOnly.Style
{
    public static class Render
    {
        public static void RenderPaintEventArgs(ref PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.High;
        }

        public static void RenderDrawListViewColumnHeaderEventArgs(ref DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.High;
        }
    }
}
