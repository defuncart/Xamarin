using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Layouts
{
    public partial class App : Application
    {
        public App()
        {
            //intialize all components and set the main page (which is part of a navigation controller)
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
