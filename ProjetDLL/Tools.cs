using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL
{
    public class Tools
    {
        public static void Afficher()
        {
            Console.WriteLine("Méthode afficher du projet DLL.....");
        }

        //Méthode de lecture d'un fichier

        /// <summary>
        /// Méthode de lecture d'un fichier texte.
        /// </summary>
        /// <param name="chemin">Chemin absolut du fichier à lire. Ex: c:\dossier\notes.txt</param>
        /// <returns>Le contenu du fichier</returns>
        /// <exception cref="Exception">Si chemin invalide, une exception est générée</exception>
        public static string LectureFichier(string chemin)
        {
            if(File.Exists(chemin))
            {
                StreamReader sr = new StreamReader(chemin);
                string contenu = sr.ReadToEnd();
                sr.Close();
                return contenu;
            }
            else
            {
                throw new Exception("Fichier introuvable......");
            }
        }


        //Méthode d'écriture dans un fichier

        /// <summary>
        /// Méthode d'écriture dans un fichier texte.
        /// </summary>
        /// <param name="chemin">Chemin absolut du fichier. Ex: c:\rep\notes.txt</param>
        /// <param name="contenu">Texte à insérer dans le fichier</param>
        /// <param name="modeAjout">Mettre à true pour insérer le contenu à la suite, sans écraser le fichier existant</param>
        /// <exception cref="Exception">Si chemin invalide, une exception est générée</exception>
        public static void EcritureFichier(string chemin, string contenu, bool modeAjout)
        {
            if(File.Exists(chemin) )
            {
                StreamWriter sw = new StreamWriter(chemin, modeAjout);

                if (modeAjout == true)
                {
                    contenu = "\n" + contenu;
                }

                sw.Write(contenu);
                sw.Close();
            }
            else
            {
                throw new Exception("Chemin invalide......");
            }
        }

        //Méthode de lecture d'une ligne particulière d'un fichier
        /// <summary>
        /// Méthode de lecture d'une ligne particulière à partir d'un fichier.
        /// </summary>
        /// <param name="chemin">Chemin absolut du fichier.</param>
        /// <param name="numLigne">Numéro de la ligne à lire</param>
        /// <returns>Le contenu de la ligne particulière</returns>
        /// <exception cref="Exception">Si chemin invalide ou ligne introuvable, la méthode génère une exception.</exception>
        public static string LectureLigneFichier(string chemin, int numLigne)
        {
            if(File.Exists(chemin) )
            {
                StreamReader sr = new StreamReader (chemin);

                string contenu = "";
                int ligneEncours = 0; //index des ignes commence à 0

                while (!sr.EndOfStream && ligneEncours < numLigne)
                {
                    contenu = sr.ReadLine();
                    ligneEncours++;
                   
                }

                if(ligneEncours < numLigne)
                {
                    throw new Exception("Ligne inexistante dans le fichier...");
                }

                return contenu;
            }
            else
            {
                throw new Exception("Chemin invalide.....");
            }
        }
    }
}
