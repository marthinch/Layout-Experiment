using LayoutExperiment.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutExperiment
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private async void ButtonLayout1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void ButtonLayout2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void ButtonLayout3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void ButtonLayout4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
    }
}
