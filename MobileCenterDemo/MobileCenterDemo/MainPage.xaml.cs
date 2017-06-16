using Microsoft.Azure.Mobile.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCenterDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = (Grid)sender;
            var color = btn.BackgroundColor == Color.Red ? "Red" : "Blue";
            Analytics.TrackEvent("Button", new Dictionary<string, string>() { { "Color", color } });
        }
    }
}
