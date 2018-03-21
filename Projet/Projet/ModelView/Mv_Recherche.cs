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
    class Mv_Recherche : ICommand
    {
        View_Recherche view;
        string date;
        string quartier;
        public string setDate;
        M_GestionDeDonnees obj ;
        private bool _canExecute;


        #region Constructeurs
        public Mv_Recherche()
        {
            _canExecute = true;
        }


        public  Mv_Recherche(string date)
        {

        }
        public Mv_Recherche(M_GestionDeDonnees obj)
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
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => MyAction(date,quartier), _canExecute));
            }
        }

        public void MyAction(string date, string quartier)
        {
            
            obj = new M_GestionDeDonnees(date,quartier);
            obj.Connexion_Database(date,quartier);
            view.Affichage_Recherche.DataContext = List;

        }



        public ICommand SaveXML
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
