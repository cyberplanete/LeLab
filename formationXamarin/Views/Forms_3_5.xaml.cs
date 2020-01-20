using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class Forms_3_5 : ContentPage
    {
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            //Deux methodes 

           // Device.OpenUri(new System.Uri(url));
            Navigation.PushAsync(new WebViewPage(url));
        });


        public Forms_3_5()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("ImageButtonClick");
        }
    }
}
