using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutosizeLabel.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            AnimateText();
        }

        private async void AnimateText()
        {
            await Task.Delay(3000);

            labelC.Text = "Now bla bla bla bla ah";
        }
    }
}
