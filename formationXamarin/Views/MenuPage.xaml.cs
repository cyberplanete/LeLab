using System;
using System.Collections.Generic;

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
    }
}
