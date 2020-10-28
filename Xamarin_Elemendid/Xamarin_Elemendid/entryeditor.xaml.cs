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
            Entry entry = new Entry
            {
                MaxLength = 10,
                CharacterSpacing = 5,
                IsPassword = true,
                Placeholder = "Password",
                PlaceholderColor = Color.Olive,
            };
            Editor editor = new Editor
            {
                CharacterSpacing = 5,
                Placeholder = "Enter text here", PlaceholderColor = Color.Olive,
                MaxLength = 10
            };
            stack.Children.Add(editor);
            stack.Children.Add(entry);
            Content = stack;
        }
    }
}