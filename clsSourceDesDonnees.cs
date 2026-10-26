using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsBureau2Change
{
    internal class clsSourceDesDonnees
    {
       
        public static List<clsPays> GetTousLesPays()
        {
            List<clsPays> tousLesPays=new List<clsPays>();
            StreamReader monFichier = new StreamReader("paysInfos.txt");
            while (!monFichier.EndOfStream)
            {
               string nom=monFichier.ReadLine();
                string monnaie=monFichier.ReadLine();
                decimal valeur= Convert.ToDecimal(monFichier.ReadLine());

                clsPays unPays = new clsPays(nom, monnaie, valeur);
                tousLesPays.Add(unPays);
            }
            monFichier.Close();
            return tousLesPays;
        }

        public static void SaveTousLesPays(List<clsPays> tousLesPays)
        {

            StreamWriter monFichier = new StreamWriter("paysInfos.txt");
            foreach (clsPays unPays in tousLesPays)
            {
                monFichier.WriteLine(unPays.Nom);
                monFichier.WriteLine(unPays.Monnaie);
                monFichier.WriteLine((1/unPays.Valeur).ToString());
            }
            monFichier.Close(); 
        }
    }
}
