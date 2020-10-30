using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class stepper_ : ContentPage
    {
        Label header;
        public stepper_()
        {
                header = new Label
                {
                    Text = "Stepper",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    HorizontalOptions = LayoutOptions.Center
                };

                Stepper stepper = new Stepper
                {
                    Minimum = 0,
                    Maximum = 10,
                    Increment = 0.1,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                stepper.ValueChanged += OnStepperValueChanged;
                this.Content = new StackLayout { Children = { header, stepper } };
            }

            private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
            {
                header.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
            }
        }
    }