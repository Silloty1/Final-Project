using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet;
using Projet.Model;
using MySql.Data.MySqlClient;
using Projet.View;
using Projet.ModelView;
using System.Windows.Input;
using System.Windows;

namespace Projet.ModelView
{
    class MV_Stocks
    {
        View_Recherche view;
        
        
        string companyName;
        string averageVolume;
        string country;
        string sector;
        string industry;
        string price;
        string priceChanging;
        string averageVolumeChanging;
        public string setDate;
        M_GestionDeDonnees obj;
        private bool _canExecute;


        #region Constructeurs
        public MV_Stocks()
        {
            _canExecute = true;
        }


        public MV_Stocks(string date)
        {

        }
        public MV_Stocks(M_GestionDeDonnees obj)
        {
            this.obj = obj;
        }
        #endregion

        public List<M_Crime> List { get { return obj.ListCrime; } }


        private ICommand _clickCommand;

        public event EventHandler CanExecuteChanged;



        public View_Recherche FenetreDeRecherche
        {
            get
            {
                return view;
            }

            set
            {
                view = value;
            }
        }

        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => MyAction(companyName,country, sector,industry,price, averageVolume), _canExecute));
            }
        }

        public void MyAction(string companyName, string country, string sector, string industry, string price, string averageVolume)
        {

            obj = new M_GestionDeDonnees(companyName,country, sector, industry, price, averageVolume);
            obj.Connect_to_mongo(companyName,country,sector,industry,price,averageVolume);
            view.Affichage_Recherche.DataContext = List;

        }



        /*public ICommand SaveXML
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => XML(), _canExecute));
            }
        }

        public void XML()
        {
            obj = new M_GestionDeDonnees();
            obj.Save_XML(List);

        }
        */
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
    public class CommandHandler : ICommand
    {
        private Action _action;
        private bool _canExecute;
        public CommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
