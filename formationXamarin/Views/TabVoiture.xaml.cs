using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();
            voitureImage.Opacity = 0;
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            voitureImage.Opacity = 0 ;
            voitureImage.TranslationX = 0;
            voitureImage.FadeTo(1, 2000);
            //Un mouvement puis continue avec . Voir autre exemple pour avion( Une fontion asynchrone est utilisée)
            voitureImage.TranslateTo(50, 0, 1000, Easing.BounceIn).ContinueWith((arg) => 
            {
                voitureImage.TranslateTo(1000, 0, 3000);
            
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            voitureImage.Opacity = 0;
            voitureImage.TranslationX = 0;
        }
    }

}
