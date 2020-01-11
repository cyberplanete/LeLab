using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class CountPage : ContentPage
    {
        public CountPage()
        {
            InitializeComponent();
        }
        private int number;
        void CountButton_Clicked(object sender, System.EventArgs e)
        {
            number += 1;
            countLabel.Text = number.ToString();
            Console.WriteLine("Bouton cliqué");
        }
    }
}
