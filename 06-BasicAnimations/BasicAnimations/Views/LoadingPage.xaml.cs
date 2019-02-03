using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicAnimations.Views
{
    public partial class LoadingPage : ContentPage
    {
        /// <summary>The initial delay length.</summary>
        private const int INITIAL_DELAY_LENGTH = 1000;
        /// <summary>The fade in length.</summary>
        private const int FADE_IN_LENGTH = 500;
        /// <summary>The on screen delay length.</summary>
        private const int ON_SCREEN_DELAY_LENGTH = 500;
        /// <summary>The fade out length.</summary>
        private const int FADE_OUT_LENGTH = 250;

        public LoadingPage()
        {
            InitializeComponent();

            //hide all components
            topLeft.Opacity = 0;
            topRight.Opacity = 0;
            bottomRight.Opacity = 0;
            bottomLeft.Opacity = 0;
            textLabel.Opacity = 0;

            //trigger animation
            Animation();
        }

        /// <summary>
        /// Animates the logo.
        /// </summary>
        async private void Animation()
        {
            //initial delay
            await Task.Delay(INITIAL_DELAY_LENGTH);

            //fade in each square one at a time
            await topLeft.FadeTo(opacity: 1, length: FADE_IN_LENGTH, easing: Easing.Linear);
            await topRight.FadeTo(opacity: 1, length: FADE_IN_LENGTH, easing: Easing.Linear);
            await bottomRight.FadeTo(opacity: 1, length: FADE_IN_LENGTH, easing: Easing.Linear);
            await bottomLeft.FadeTo(opacity: 1, length: FADE_IN_LENGTH, easing: Easing.Linear);
            //fade in text
            await textLabel.FadeTo(opacity: 1, length: FADE_IN_LENGTH, easing: Easing.Linear);

            //wait 500ms
            await Task.Delay(ON_SCREEN_DELAY_LENGTH);

            //fade out all elements at the same time
            topLeft.FadeTo(opacity: 0, length: FADE_OUT_LENGTH, easing: Easing.Linear);
            topRight.FadeTo(opacity: 0, length: FADE_OUT_LENGTH, easing: Easing.Linear);
            bottomRight.FadeTo(opacity: 0, length: FADE_OUT_LENGTH, easing: Easing.Linear);
            bottomLeft.FadeTo(opacity: 0, length: FADE_OUT_LENGTH, easing: Easing.Linear);
            await textLabel.FadeTo(opacity: 0, length: FADE_OUT_LENGTH, easing: Easing.Linear);

            //wait 500ms
            await Task.Delay(ON_SCREEN_DELAY_LENGTH);

            //update root app page
            Application.Current.MainPage = new MainPage();
        }
    }
}
