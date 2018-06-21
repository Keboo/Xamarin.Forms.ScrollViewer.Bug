namespace Xamarin.Forms.ScrollViewer.Bug
{
    public static class RendererFixer
    {
        public static readonly BindableProperty ScrollViewerFixProperty = BindableProperty.CreateAttached("ScrollViewerFix",
            typeof(bool), typeof(RendererFixer), default(bool));

        public static bool GetScrollViewerFix(BindableObject obj)
        {
            return (bool) obj.GetValue(ScrollViewerFixProperty);
        }

        public static void SetScrollViewerFix(BindableObject obj, bool value)
        {
            obj.SetValue(ScrollViewerFixProperty, value);
        }
    }
}