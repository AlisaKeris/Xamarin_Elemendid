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
    public partial class datapicker : ContentPage
    {
        
        public datapicker()
        {
            StackLayout stack = new StackLayout();
            DatePicker datePicker = new DatePicker()
            {
                Format = "D"
            };
            datePicker.DateSelected += DatePicker_DateSelected;
            stack.Children.Add(datePicker);
            Content = stack;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Label label = new Label();
            label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}