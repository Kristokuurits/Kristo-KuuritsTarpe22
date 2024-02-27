using System;
using Microsoft.Maui.Controls;

namespace Views
{
    public partial class retseptPage : ContentPage
    {
        public retseptPage()
        {
            InitializeComponent();
        }

        private async void ExploreButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Explore", "You clicked the Explore button!", "Ok");
        }

    }
}
