﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ListView
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
