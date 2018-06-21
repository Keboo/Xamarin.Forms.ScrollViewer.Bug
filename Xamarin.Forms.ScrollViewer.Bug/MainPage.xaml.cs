using System;
using System.ComponentModel;

namespace Xamarin.Forms.ScrollViewer.Bug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (sender is VisualElement element)
            {
                element.HeightRequest = (int)element.HeightRequest == 100 ? 200 : 100;
            }
        }
    }
}
