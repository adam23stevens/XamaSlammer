using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quotes : ContentPage
    {
        public Quotes()
        {
            InitializeComponent();

            index = -1;
            UpdateText();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UpdateText();
        }

        private List<string> quotes = new List<string>
        {
            "Chelsea is the best!",
            "I am probably the best programmer in the world",
            "This is just a normal sentence."
        };

        private int index;

        private void UpdateText()
        {
            index = index + 1 > quotes.Count - 1 ? 0 : index + 1;
            lblQuotes.Text = quotes[index];
        }
    }
}