using System;
using System.Collections.Generic;
using formationXamarin.DataModele;
using Xamarin.Forms;

namespace formationXamarin.Views
{

    public partial class ListPage : ContentPage
    {
        private List<Article> articles;

        public ListPage()
        {
            InitializeComponent();
            articles = new List<Article>();
            articles.Add(new Article { Nom = "Lait", Prix = "15€" , Description = "Demi-Ecrèmé"});
            articles.Add(new Article { Nom = "Chocolat", Prix = "0,79€",Description = "Chocolat noir" });
            articles.Add(new Article { Nom = "Pain", Prix = "0,80€", Description = "Pain au levain" });
            articles.Add(new Article { Nom = "Biscottes", Prix = "1,35€" , Description = " Biscotte au blé complet"});

            articles.Add(new Article { Nom = "Poulet", Prix = "3,89€", Description = "Poulet fermier aux hormones industrielles" });
            articles.Add(new Article { Nom = "Pommes", Prix = "2,50€", Description = "Pommes bio" });
            articles.Add(new Article { Nom = "Citron", Prix = "1,40€", Description = "Citron bio" });
            articles.Add(new Article { Nom = "Fromages", Prix = "1,12€", Description = "Fromages au lait cru" });

            listeCourse.ItemsSource = articles;

            listeCourse.ItemSelected += (sender, e) => 
            {
                //evite l'apparation d'un deuxieme popup suite au passage à null
                if ( listeCourse.SelectedItem != null) 
                {
                    Article article = listeCourse.SelectedItem as Article;

                    DisplayAlert(article.Nom, article.Description, "OK");
                    //Permet de ne pas garder la selection sur un item
                    listeCourse.SelectedItem = null;
                }
               
            };

        }
    }
}
