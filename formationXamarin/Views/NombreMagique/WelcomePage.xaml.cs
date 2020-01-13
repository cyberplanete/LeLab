using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace formationXamarin.Views.NombreMagique
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            ScaleInfinie(bouton, 1000);
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel

        }

        void ButtonJouer_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }


        private async Task ScaleInfinie(View view, uint length)
        {
            bool always = true;
            while (always)
            {
                await view.ScaleTo(1.1, length);
                await view.ScaleTo(1.0,length);

            }
        }
    }
}
