using ProjetWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Service
{
    public class CsvTool
    {

        public static void ExportCsv(string chemin, List<Ligne> lst)
        {
            StreamWriter sw = new StreamWriter(chemin);
            foreach (var item in lst)
            {
                sw.WriteLine(item.Description + "," + item.NomClient + "," + item.AdresseClient + "," + item.Couleur);
            }
            sw.Close();
        }

        public static List<Ligne> ImportCsv(string chemin)
        {
            List<Ligne> lignes = new List<Ligne>();

            StreamReader sr = new StreamReader(chemin);

            while (!sr.EndOfStream)
            {
                //Lecture de la ligne en cours
                string row = sr.ReadLine();

                //Découpage de la ligne
                string[] tab = row.Split(',');


                //Conversion en objet de la ligne
                Ligne ligne = new Ligne(tab[0], tab[1], tab[2], tab[3]);

                //Ajout de l'objet dans la liste
                lignes.Add(ligne);
            }

            sr.Close();

            return lignes;
        }
    }
}
