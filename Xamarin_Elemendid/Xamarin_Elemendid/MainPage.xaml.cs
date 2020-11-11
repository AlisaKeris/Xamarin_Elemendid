using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace Xamarin_Elemendid
{
    public partial class MainPage : ContentPage
    {
        Button e_btn, l_btn, d_btn, t_btn, w_btn, ti_btn, s_btn, tt_btn, c_btn;
        public MainPage()
        {
            e_btn = new Button()
            {
                Text = "Entry/Editor", BorderWidth = 3, BorderColor = Color.DarkBlue, BackgroundColor= Color.LightBlue, 
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            s_btn = new Button()
            {
                Text = "Stepper",
                BorderWidth = 3,
                BorderColor = Color.DarkBlue,
                BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            l_btn = new Button() { Text="ListView", BorderWidth = 3, BorderColor = Color.DarkBlue, BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            d_btn = new Button() { Text= "DataPicker", BorderWidth = 3, BorderColor = Color.DarkBlue, BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            t_btn = new Button() { Text = "TableView", BorderWidth = 3, BorderColor = Color.DarkBlue, BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            w_btn = new Button() { Text = "WebView", BorderWidth = 3, BorderColor = Color.DarkBlue, BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            ti_btn = new Button() { Text="Speaker", BorderWidth = 3, BorderColor = Color.DarkBlue, BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            tt_btn = new Button()
            {
                Text = "Timer",
                BorderWidth = 3,
                BorderColor = Color.DarkBlue,
                BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            c_btn = new Button()
            {
                Text = "Cards",
                BorderWidth = 3,
                BorderColor = Color.DarkBlue,
                BackgroundColor = Color.LightBlue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            e_btn.Clicked += E_btn_Clicked;
            l_btn.Clicked += L_btn_Clicked;
            d_btn.Clicked += D_btn_Clicked;
            t_btn.Clicked += T_btn_Clicked;
            w_btn.Clicked += W_btn_Clicked;
            ti_btn.Clicked += Ti_btn_Clicked;
            s_btn.Clicked += S_btn_Clicked;
            tt_btn.Clicked += Tt_btn_Clicked;
            c_btn.Clicked += C_btn_Clicked;
            StackLayout stack = new StackLayout(); 
            stack.Children.Add(e_btn);
            stack.Children.Add(c_btn);
            stack.Children.Add(l_btn);
            stack.Children.Add(d_btn);
            stack.Children.Add(ti_btn);
            stack.Children.Add(t_btn);
            stack.Children.Add(w_btn);
            stack.Children.Add(s_btn);
            stack.Children.Add(tt_btn);
            Content = stack;
        }

        private async void C_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cards());
        }

        private async void Tt_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new textToSpeech());
        }

        private async void S_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new stepper_());
        }

        private async void Ti_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new timer_());
        }

        private async void W_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new webview());
        }

        private async void T_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tableview());
        }

        private async void D_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new datapicker());
        }

        private async void L_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new listview());
        }

        private async void E_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new entryeditor());
        }
    }
}
