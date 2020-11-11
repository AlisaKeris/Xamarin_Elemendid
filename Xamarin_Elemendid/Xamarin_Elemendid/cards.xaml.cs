using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cards : ContentPage
    {
        public cards()
        {
            StackLayout stack = new StackLayout();
            InitializeComponent();
            Button btn = new Button();
            btn.Clicked += Btn_Clicked;
            stack.Children.Add(btn);
            Content = stack;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            var options = new MapLaunchOptions { Name = "My Location" };
            try
            {
                var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Xamarin.Essentials.Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }
                await Xamarin.Essentials.Map.OpenAsync(location, options);
            }
            catch (Exception) { }
        }
    }
}