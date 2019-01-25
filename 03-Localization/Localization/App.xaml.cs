using System.Linq;
using Localization.Helpers;
using Localization.Resources;
using Plugin.Multilingual;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Localization
{
    public partial class App : Application
    {
        public App()
        {
            //intialize all components
            InitializeComponent();

            //if this is the first launch, initialize the display language to be the same as the device language
            if(!UserSettings.AlreadyLaunched)
            {
                UserSettings.Language = CrossMultilingual.Current.DeviceCultureInfo.TwoLetterISOLanguageName;
                UserSettings.AlreadyLaunched = true;
            }

            //update localization depending on user's setting
            CrossMultilingual.Current.CurrentCultureInfo = CrossMultilingual.Current.NeutralCultureInfoList.ToList().First(element => element.TwoLetterISOLanguageName == UserSettings.Language);
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;

            //set the main page as entry point
            MainPage = new MainPage();
        }
    }
}
