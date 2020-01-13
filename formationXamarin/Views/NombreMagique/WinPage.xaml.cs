using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace formationXamarin.Views.NombreMagique
{
    public partial class WinPage : ContentPage
    {
        //Utilisé seulement pour l'aperçu - Default Contructeur
        public WinPage():this(5)
            {

            } 

        public WinPage(int magicNumber)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);

            //Animation
            mainLayout.Scale = 0.7;
            mainLayout.ScaleTo(1.0, 1500, Easing.BounceIn);

            texteResultat.Text = "Le nombre magique etait " + magicNumber;
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            NavigateBackToWelcomePage();
#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        }

        private async Task NavigateBackToWelcomePage() 
        {
            await Task.Delay(3000);
            await Navigation.PopToRootAsync();
        
        }
    }
}
