using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Elemendid
{
    public partial class MainPage : ContentPage
    {
        Button e_btn, l_btn, d_btn, t_btn, w_btn, ti_btn;
        public MainPage()
        {
            e_btn = new Button()
            {
                Text = "Entry/Editor"
            };
            l_btn = new Button() { Text="ListView" };
            d_btn = new Button() { Text= "DataPicker" };
            t_btn = new Button() { Text = "TableView" };
            w_btn = new Button() { Text = "WebView"};
            ti_btn = new Button() { Text="Timer"};
            e_btn.Clicked += E_btn_Clicked;
            l_btn.Clicked += L_btn_Clicked;
            d_btn.Clicked += D_btn_Clicked;
            t_btn.Clicked += T_btn_Clicked;
            w_btn.Clicked += W_btn_Clicked;
            ti_btn.Clicked += Ti_btn_Clicked;
            StackLayout stack = new StackLayout(); 
            stack.Children.Add(e_btn);
            stack.Children.Add(l_btn);
            stack.Children.Add(d_btn);
            stack.Children.Add(ti_btn);
            stack.Children.Add(t_btn);
            stack.Children.Add(w_btn);
            Content = stack;
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
