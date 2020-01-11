using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class TabAvion : ContentPage
    {
        public TabAvion()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            avionImage.Opacity = 0; 
            avionImage.TranslationX = 0;
            animation();
        }

        private async void animation()
        {
            await avionImage.FadeTo(1, 2000);
            await avionImage.TranslateTo(50, 0, 1000, Easing.BounceIn);
            await avionImage.TranslateTo(1000, 0, 3000);

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            avionImage.Opacity = 0;
            avionImage.TranslationX = 0;
        }
    }
}
