using Newtonsoft.Json;
using System;
using Xamarin.Forms;

namespace ListView.Models
{
    [Serializable]
    public class Country
    {
        /// <summary>A backing property for Name. This is loaded from JSON.</summary>
        [JsonProperty] private string name = null;

        /// <summary>The country's name.</summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>A backing property for Capital. This is loaded from JSON.</summary>
        [JsonProperty] private string capital = null;

        /// <summary>The country's Capital.</summary>
        public string Capital
        {
            get => capital;
            set => capital = value;
        }

        /// <summary>A backing property for CountryCode. This is loaded from JSON.</summary>
        [JsonProperty] private string country_code = null;

        /// <summary>The country's Code.</summary>
        public string CountryCode
        {
            get => country_code;
            set => country_code = value;
        }

        /// <summary>The path to the country's image (i.e. flag).</summary>
        public string ImagePath => $"ListView.Images.{CountryCode.ToLower()}.png";

        /// <summary>The country's image (i.e. flag).</summary>
        public ImageSource Image => ImageSource.FromResource(ImagePath);

        /// <summary>A <see cref="T:System.String"/> representing the current <see cref="T:ListView.Models.Country"/>.</summary>
        public override string ToString() => $"{country_code}: {name}, {capital}";
    }
}
