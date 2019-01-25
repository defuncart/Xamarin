using System;
using System.Linq;
using Localization.Helpers;
using Localization.Resources;
using Plugin.Multilingual;
using Xamarin.Forms;

namespace Localization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback when a language is chosen.
        /// </summary>
        private void OnLanguageChosen(object sender, EventArgs eventArgs)
        {
            //update settings
            UserSettings.Language = ((Button)sender).BindingContext as string;

            //update localization
            CrossMultilingual.Current.CurrentCultureInfo = CrossMultilingual.Current.NeutralCultureInfoList.ToList().First(element => element.TwoLetterISOLanguageName == UserSettings.Language);
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;

            //reload MainPage
            App.Current.MainPage = new MainPage();
        }
    }
}
