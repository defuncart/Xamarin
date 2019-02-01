using ListView.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ListView.ViewModels
{
    public static class MainViewModel
    {
        /// <summary>
        /// An obserable collection of countries.
        /// </summary>
        public static ObservableCollection<Country> Countries { get; set; }

        static MainViewModel()
        {
            //manual
            //Countries = new ObservableCollection<Country>
            //{
            //    new Country { Name = "Deutschland", Capital = "Berlin", CountryCode = "de" }
            //};

            //get a reference to the filestream
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("ListView.Resources.countries.json");

            //create json string text
            string text = "";
            using(var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            //deserialize
            Countries = JsonConvert.DeserializeObject<ObservableCollection<Country>>(text);
        }
    }
}
