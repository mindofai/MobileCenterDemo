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
            var btn = (Button)sender;
            string color = GetBackgroundColorString(btn.BackgroundColor);
            Analytics.TrackEvent("Button", new Dictionary<string, string>() { { "Color", color } });
        }

        public string GetBackgroundColorString(Color color)
        {
            if (color == Color.Red)
            {
                return "Red";
            }
            else if (color == Color.Blue)
            {
                return "Blue";
            }
            else if (color == Color.Green)
            {
                return "Green";
            }
            else if (color == Color.Purple)
            {
                return "Purple";
            }
            else if (color == Color.Orange)
            {
                return "Orange";
            }
            else if (color == Color.Yellow)
            {
                return "Yellow";
            }
            else if (color == Color.Pink)
            {
                return "Pink";
            }
            else if (color == Color.Brown)
            {
                return "Brown";
            }
            else
            {
                return "Cyan";
            }
        }
    }
}
