namespace ClassesOnly.Style
{
    public static class ComponentsAdjust
    {
        public static void CenterLabel(int parentWidth, ref System.Windows.Forms.Label label)
        {
            label.Left = (parentWidth - label.Width) / 2;
        }
    }
}
