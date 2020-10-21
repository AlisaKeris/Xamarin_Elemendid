using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Elemendid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            { BackgroundColor = Color.BurlyWood};
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
