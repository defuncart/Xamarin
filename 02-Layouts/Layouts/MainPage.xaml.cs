using System;
using Xamarin.Forms;

namespace Layouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnContentView(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ContentViewPage());
        }

        private void OnFrame(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FramePage());
        }

        private void OnScrollView(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ScrollViewPage());
        }

        private void OnStackLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }

        private void OnGridLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void OnAbsoluteLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private void OnRelativeLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RelativeLayoutPage());
        }

        private void OnFlexLayout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}
