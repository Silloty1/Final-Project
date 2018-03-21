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
        public MainWindow()
        {
            InitializeComponent();
           
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
    }
}
