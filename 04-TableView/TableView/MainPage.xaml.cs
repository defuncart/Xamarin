using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace TableView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback when the switch in the SwitchCell is toggled on/off.
        /// </summary>
        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            Debug.WriteLine($"SwitchCell_OnChanged: {e.Value}");
        }

        /// <summary>
        /// Callback when text input on EntryCell has completed.
        /// </summary>
        private void EntryCell_OnCompleted(object sender, EventArgs e)
        {
            Debug.WriteLine($"EntryCell_OnCompleted: {((EntryCell)sender).Text}");
        }

        /// <summary>
        /// Callback when the custom cell is tapped.
        /// </summary>
        private void CustomCell_OnTapped(object sender, EventArgs e)
        {
            Debug.WriteLine("CustomCell_OnTapped");
        }
    }
}
