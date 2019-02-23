using AutosizeLabel.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AutosizeLabel
{
    public partial class App : Application
    {
        public App()
        {
            //intialize all components and set the main page
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}
