using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Model
{
    class M_Stocks
    {
        //Attributs

        string date;
        string company;
        string country;
        string sector;
        string industry;
        double price;
        double average_Volume;

        //Properties
        public string Date { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }
        public double Price { get; set; }
        public double Average_Volume { get; set; }

        //Constructor
        public M_Stocks(string date, string company, string country, string sector, string industry, double price, double average_Volume)
        {
            this.date = date;
            this.company = company;
            this.country = country;
            this.sector = sector;
            this.industry =industry;
            this.price = price;
            this.average_Volume = average_Volume;

        }

        //Methods
        public String AffichageRecherche
        {
            get
            {
                return "Company Name: " + company + " Country: " + country + " Date : " + date + " Sector : " + sector + " Industry : " + industry + " Price : " + price + " Average Volume : " + average_Volume;
            }
        }



    }
}
