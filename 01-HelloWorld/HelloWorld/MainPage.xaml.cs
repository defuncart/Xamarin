using System;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPushClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new PushPage());
        }

        private void OnModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ModalPage());
        }

        private void OnAlert(object sender, EventArgs args)
        {
            DisplayAlert("Hello World!", "This is an alert.", "OK");
        }

        private void OnActionSheet(object sender, EventArgs args)
        {
            DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }
    }
}
