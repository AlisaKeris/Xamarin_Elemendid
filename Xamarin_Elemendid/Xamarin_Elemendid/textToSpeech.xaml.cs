using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class textToSpeech : ContentPage
    {
        Slider sld_v,sld_p;
        float volume_, pitch_;
        Entry text;
        public textToSpeech()
        {
            StackLayout stack = new StackLayout();
            Button btn = new Button
            {
                Text = "Speak"
            };
            sld_v = new Slider { Minimum= 0, Maximum= 10};
            sld_p = new Slider { Minimum = 0, Maximum = 10 };
            sld_v.ValueChanged += Sld_ValueChanged;
            sld_p.ValueChanged += Sld_p_ValueChanged;
            text = new Entry { Placeholder ="text"};
            btn.Clicked += Btn_Clicked;
            stack.Children.Add(sld_v);
            stack.Children.Add(sld_p);
            stack.Children.Add(btn);
            stack.Children.Add(text);
            Content = stack;
        }

        private void Sld_p_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            pitch_ = (float)sld_p.Value;
        }

        private void Sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            volume_ = (float)sld_v.Value;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            SpeechOptions settings = new SpeechOptions() { Volume = volume_, Pitch = pitch_ };
            await TextToSpeech.SpeakAsync(text.Text, settings).ConfigureAwait(false);
        }
    }
}