using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsBureau2Change
{
    internal class clsBureau
    {
        private string numero;
        private string nom;
        private string adresse;
        private List<clsPays> pays;
        private string statut;

        public string Numero
        {
            get { return numero; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public List<clsPays> Pays
        {
            get { return pays; }
            set { pays = value; }
        }
        public clsBureau()
        {
            numero = "Non defini";
            nom = "Non defini";
            adresse = "Non definie";
            pays = new List<clsPays>();
            statut = "Non definit";

        }

        public clsBureau(string numero, string nom, string adresse, string statut)
        {
            this.numero= numero;
            this.nom= nom;
            this.adresse= adresse;
            pays=new List<clsPays>();
            this.statut= statut;

        }
        public clsBureau(string numero, string nom,string adresse, List<clsPays> pays, string statut )
        {
            this.numero = numero;
            this.nom= nom;
            this.adresse= adresse;
            this.pays= pays;
            this.statut= statut;
        }

        //methodes
        public clsPays TrouverPays(string nomPays)
        {
            foreach (clsPays unPays in pays)
            {
                if (nomPays==unPays.Nom)
                {
                    return unPays;
                }
            }
            return null;
        }

        public void Afficher()
        {
            string info = "Numero : " + numero +
                "Nom : " + nom +
                "Adresse : " + adresse +
                "Monnaie : " + TrouverPays(nom).Monnaie +
                "Statut : " + statut;
        }
        public void Fermer() { 
                
        }

    }
}
