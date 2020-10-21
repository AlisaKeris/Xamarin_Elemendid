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
    public partial class entryeditor : ContentPage
    {
        public entryeditor()
        {
            StackLayout stack = new StackLayout();
            Editor editor = new Editor
            {
                Text = "Text",
                CharacterSpacing = 5
            };
            stack.Children.Add(editor);
            Content = stack;

        }
    }
}