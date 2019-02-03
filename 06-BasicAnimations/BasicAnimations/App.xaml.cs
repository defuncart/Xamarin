using BasicAnimations.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BasicAnimations
{
    public partial class App : Application
    {
        public App()
        {
            //initialize all components and set the main page
            InitializeComponent();
            MainPage = new LoadingPage();
        }
    }
}
