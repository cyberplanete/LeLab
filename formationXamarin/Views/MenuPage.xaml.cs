using System;
using System.Collections.Generic;
using formationXamarin.Views.NombreMagique;
using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void CounterButton_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }

        void TabButton_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        void ListeButton_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }

        void MagiqueButton_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new NavigationPage(new WelcomePage()));
        }
    }
}
