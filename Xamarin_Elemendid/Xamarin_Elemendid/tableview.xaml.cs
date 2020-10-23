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
    public partial class tableview : ContentPage
    {
        public tableview()
        {
            Content = new TableView
            {
                Root = new TableRoot
            {
                new TableSection("Ring")
                {
                  // TableSection constructor takes title as an optional parameter
                  new SwitchCell { Text = "New Voice Mail" },
                  new SwitchCell { Text = "New Mail", On = true }
                }
            },
                Intent = TableIntent.Settings
            };
        }
    }
}