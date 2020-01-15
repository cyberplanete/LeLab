using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class FlexLayoutStack : ContentPage
    {
        int numberLabel = 1;

        public FlexLayoutStack()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            myButton.Clicked += MyButton_Clicked;
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            var label = new Label();
            label.Text = "LABEL" + numberLabel;
            numberLabel++;
            label.Margin = new Thickness(10);
            myFlexLayout.Children.Add(label);
        }
    }
}
