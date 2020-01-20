using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

        }

        public WebViewPage(String url)
        {
            InitializeComponent();
            monWebView.Source = url;
        }
    }
}
