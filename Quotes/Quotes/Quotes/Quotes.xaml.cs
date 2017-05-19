using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quotes : ContentPage
    {
        private List<string> quotes = new List<string>
        {
            "Hi there sugar tits",
            "yo yo sup",
            "wha gwannnn"
        };

        public Quotes()
        {
            InitializeComponent();
            updateText();
        }

        private int index = -1;

        private void updateText()
        {
            index = index + 1 > quotes.Count - 1 ? 0 : index + 1;
            lblQuotes.Text = quotes[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            updateText();
        }
    }
}