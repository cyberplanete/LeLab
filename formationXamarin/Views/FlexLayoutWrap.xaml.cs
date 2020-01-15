using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace formationXamarin.Views
{
    public partial class FlexLayoutWrap : ContentPage
    {
        public FlexLayoutWrap()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }
    }
}
