using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.ScrollViewer.Bug.iOS;

[assembly: ExportRenderer(typeof(ScrollView), typeof(ScrollViewRendererEx))]
namespace Xamarin.Forms.ScrollViewer.Bug.iOS
{
    public class ScrollViewRendererEx : ScrollViewRenderer
    {
        public override CGSize ContentSize
        {
            get => base.ContentSize;
            set
            {
                if (Element is ScrollView scrollView && RendererFixer.GetScrollViewerFix(scrollView))
                {
                    if (!scrollView.ContentSize.IsZero && value != scrollView.ContentSize.ToSizeF())
                    {
                        return;
                    }
                }
                base.ContentSize = value;
            }
        }
    }
}