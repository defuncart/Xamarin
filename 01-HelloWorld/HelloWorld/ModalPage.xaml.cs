using System;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private void OnReturn(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }
    }
}
