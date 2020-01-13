using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace formationXamarin.Views.NombreMagique
{
    public partial class StarsView : ContentView
    {
        public StarsView()
        {
            InitializeComponent();
#pragma warning disable CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
            RotationInfinie(etoile1, 4000);
            RotationInfinie(etoile2, 5000);
            RotationInfinie(etoile3, 9000);


#pragma warning restore CS4014 // Dans la mesure où cet appel n'est pas attendu, l'exécution de la méthode actuelle continue avant la fin de l'appel
        }
        private async Task RotationInfinie(View view, uint length)
        {
            bool always = true;
            while (always)
            {
                await view.RotateTo(360, length);
                view.Rotation = 0;

            }
        }
    }
   

}
