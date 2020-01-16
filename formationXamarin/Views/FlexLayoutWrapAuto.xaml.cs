using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class FlexLayoutWrapAuto : ContentPage
    {
        public FlexLayoutWrapAuto()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            monFlexLayout.Wrap = FlexWrap.Wrap;
            monFlexLayout.JustifyContent = FlexJustify.Center;
            start100boxes();


        }
        int nombre = 0;
      

        private void start100boxes()
        {
            var ramdom = new Random();
            while(nombre <100)
            {
                
                int r = ramdom.Next(0, 255);
                int g = ramdom.Next(0, 255);
                int b = ramdom.Next(0, 255);
                BoxView boxView = new BoxView();
                boxView.Margin = new Thickness (5,5);
                boxView.WidthRequest = 40;
                boxView.HeightRequest = 40;

                boxView.BackgroundColor = Color.FromRgb(r,g,b);

                monFlexLayout.Children.Add(boxView);
                nombre++;
            }
        }
    }
}
