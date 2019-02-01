//taken from https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/images
using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.Helpers
{
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        /// <summary>
        /// The source path for the image.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Provides the value.
        /// </summary>
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            //if the source is null, return null
            if(Source == null)
            {
                return null;
            }

            //otherwise try to load the imagesource from resources
            ImageSource imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            //return the image
            return imageSource;
        }
    }
}
