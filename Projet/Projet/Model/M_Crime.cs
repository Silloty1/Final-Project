using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Model
{
    public class M_Crime
    {
        //Attributs
        string id;
        string date;
        string borough;
        string coor_X;
        string coor_Y;

        //Propriétés
        public int Id { get; set; }
        public string Date { get; set; }
        public string Borough { get; set; }
        public int Coor_X { get; set; }
        public int Coor_Y { get; set; }

        public M_Crime(string[] Tab)
        {
            /*id = "0";
            date = "";
            borough = "";
            coor_X = "0";
            coor_Y = "0";*/
        }
        public M_Crime(string id, string date, string borough, string coor_X, string coor_Y)
        {
            this.id = id;
            this.date = date;
            this.borough = borough;
            this.coor_X = coor_X;
            this.coor_Y = coor_Y;
        }

        public String AffichageRecherche
        {
            get
            {
                return "Id: " + id + " Lieu: " + borough + " Date : " + date;
            }
        }

        

    }
}

