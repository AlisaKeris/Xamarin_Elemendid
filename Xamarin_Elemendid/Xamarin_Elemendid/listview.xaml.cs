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
    public partial class listview : ContentPage
    {
        public listview()
        {
            StackLayout stack = new StackLayout();
            var listView1 = new ListView();
            listView1.ItemsSource = new string[]
            {
              "mono",
              "monodroid",
              "monotouch",
              "monorail",
              "monodevelop",
              "monotone",
              "monopoly",
              "monomodal",
              "mononucleosis"
            };
            stack.Children.Add(listView1);
            Content = stack;

        }
    }
}