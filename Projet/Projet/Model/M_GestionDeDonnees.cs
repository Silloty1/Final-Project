using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projet.View;
using Projet.ModelView;
using System.ComponentModel;
using System.IO;

namespace Projet.Model
{
    class M_GestionDeDonnees : INotifyPropertyChanged
    {


        #region Attributs
        List<M_Crime> listcrime = new List<M_Crime>();
        string requete = "SELECT * FROM Crime";
        public List<M_Crime> ListCrime { get { return listcrime; } }

        Mv_Recherche obj = new Mv_Recherche();
        #endregion
        public M_GestionDeDonnees(string date, string quartier)
        {

        }

        public M_GestionDeDonnees()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;



        public void Connexion_Database(string date, string quartier)
        {
            string connectionString = "SERVER=localhost; DATABASE=NY_Crimes;UID=esilvs6;PASSWORD=esilvs6;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            //command.CommandText = "SELECT * FROM Crime where id = \"20\"" ;
            //command.CommandText = "SELECT * FROM Crime WHERE date = '" + date + "' AND borough LIKE '" + quartier + "';";

            if (date != "" && date != null || quartier != "" && quartier !=null)
            {
                requete += " WHERE";
                if(date != "")
                { 
                    requete += " date LIKE ('%" + date + "%')";
                }
                if(quartier !="" && date != "")
                {
                    requete += " AND borough LIKE ('%" + quartier + "%')";
                }
                if(date =="" && quartier != "")
                {
                    requete += " borough LIKE('%" + quartier + "%')";
                }

            }
            requete += ";";
            command.CommandText = requete;
            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string currentRowAsString = "";
                string[] Tab = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {

                    string value = reader.GetValue(i).ToString();
                    currentRowAsString += value + ", ";
                }
                string[] tab = currentRowAsString.Split(',');
                M_Crime x = new M_Crime(tab[0], tab[1], tab[2], tab[3], tab[4]);
                listcrime.Add(x);
            }

            connection.Close();

        }

        public void Save_XML(List<M_Crime> list)
        {

            StreamWriter sw = new StreamWriter("Donnees.xml");
            sw.WriteLine("{0}", "<?xml version=" + '"' + "1.0" + '"' + " encoding=" + '"' + "UTF−8" + '"' + "?>");
            sw.WriteLine("{0}", "<!DOCTYPE resultats SYSTEM " + '"' + "resultats.dtd" + '"' + ">");
            sw.WriteLine("{0}", "<!ELEMENT resultats(requete,crime)>");
            sw.WriteLine("{0}", "<!ELEMENT requete" + requete + ">");
            foreach(M_Crime item in list)
            {

            }
        }
    }
}
