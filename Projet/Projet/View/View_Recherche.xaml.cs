﻿using Projet.Model;
using Projet.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet.View
{/*
    /// <summary>
    /// Logique d'interaction pour View_Recherche.xaml
    /// </summary>
    public partial class View_Recherche : Window
    {
        private Mv_Recherche recherche;
        
        public View_Recherche()
        {
            recherche = new Mv_Recherche();
            recherche.FenetreDeRecherche = this; 
            InitializeComponent();
        }

        public List<M_Crime> Resultats
        {
            set
            {
                Affichage_Recherche.DataContext = value;
            }
        }

        private void button_research(object sender, RoutedEventArgs e)
        {
            Recherche_Delit();
        }

        private void button_add(object sender, RoutedEventArgs e)
        {

        }
        private void Recherche_Delit()
        {

            View_Recherche Recherche_crime = new View_Recherche();
            Recherche_crime.Show();
            // this.Hide();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string date = DateBox.Text;
            string companyName = CompanyName.Text;
            string averageVolume = AverageVolume.Text;
            string country = Country.Text;
            string industry = Industry.Text;
            string price = Price.Text;
            string priceChanging = comboBoxPrice.Text;
            string averageVolumeChanging = comboBoxAverageVolume.Text;

            recherche.MyAction(date, companyName, averageVolume, country, industry, price, priceChanging, averageVolumeChanging);
        }


    }
    */
}
