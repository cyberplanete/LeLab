using System;
using System.Collections.Generic;
using formationXamarin.Views.NombreMagique;
using Xamarin.Forms;

namespace formationXamarin.Views
{
    public partial class GamePage : ContentPage
    {
        const int NB_MIN = 1;
        const int NB_MAX = 10;
        int magicNumber = 0;

        public GamePage()
        {
            InitializeComponent();
            entreMagicNumber.Text = "Entre " + NB_MIN + " et" + NB_MAX;
            magicNumber = new Random().Next(NB_MIN, NB_MAX);
            NavigationPage.SetHasNavigationBar(this, false);

        }

        void Deviner_Clicked(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(numberEntry.Text))
                {
                DisplayAlert("Erreur", "Vous devez entrez un nombre entre 1 et 10 ", "OK");
                return;
            }

            int valeur = 0;
            try 
            {
                valeur = Int32.Parse(numberEntry.Text); 
                numberEntry.Text = null;
            }catch (Exception)
            {
                DisplayAlert("Erreur", "Vous devez entrez uniquement des chiffres ", "OK");
                return;
            }

            if( valeur < NB_MIN || valeur > NB_MAX) 
            {
                DisplayAlert("Erreur", "Entrez un nombre entre 1 et 10 ", "OK");
            }
            else 
            {
                if (valeur.Equals(magicNumber))
                {
                    TaskGagne();
                }
                else if (valeur < magicNumber)
                {
                    DisplayAlert("Oops", valeur + " est en dessous du nombre magique", "OK");
                }
                else
                {
                    DisplayAlert("Oops", valeur + " est au dessus du nombre magique", "OK");
                }
            }


           
          
        }

        private async void TaskGagne()
        {
            await this.Navigation.PushAsync(new WinPage(magicNumber));
        }
    }
}
