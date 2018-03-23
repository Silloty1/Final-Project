using Projet.ModelView;
using Projet.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MV_Stocks recherche = new MV_Stocks();
        public MainWindow()
        {
            //recherche = new MV_Stocks();
            //recherche.FenetreDeRecherche = this;
            InitializeComponent();
           
        }

        private void button_research(object sender, RoutedEventArgs e)
        {
            Recherche_Delit();
        }

        private void button_add(object sender, RoutedEventArgs e)
        {

        }

        private void Recherche_stock()
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
            string sector = SectorBox.Text;
            string companyName = CompanyName.Text;
            string averageVolume = AverageVolume.Text;
            string country = Country.Text;
            string industry = Industry.Text;
            string price = Price.Text;
            string priceChanging = comboBoxPrice.Text;
            string averageVolumeChanging = comboBoxAverageVolume.Text;
            
            recherche.MyAction(companyName,country,sector,industry,price,averageVolume);
        }

        
    }
}
