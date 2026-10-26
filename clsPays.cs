using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsBureau2Change
{

    internal class clsPays
    {
        private string nom;
        private string monnaie;
        private decimal valeur;

        public string Nom
        {
            get { return nom; }

            set
            {
                nom = value;
            }
        }
        public string Monnaie
        {
            get { return monnaie; }
            set { monnaie = value; }
        }
        public decimal Valeur
        {
            get { return valeur; } set{ valeur = value; }
        }

        public clsPays()
        {
            nom = "Non défini";
            monnaie = "Non defini";
            valeur = 0;
        }

        public clsPays(string nom, string monnaie, decimal valeur)
        {
            this.nom = nom;
            this.monnaie = monnaie;
            this.valeur= valeur;
        }

        //methodes
        public decimal GetValeurCanada(decimal valeur)
        {
           return 1/valeur;
        }

        public string Afficher()
        {
            string info = "Nom : " + nom +
                "\n Monnaie : " + monnaie +
                "\n Valeur : " + valeur;
            return info;
        }
        
    }

}