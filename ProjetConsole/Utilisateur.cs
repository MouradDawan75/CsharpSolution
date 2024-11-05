using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    //Classe objet: elle décrit la structure d'un obejt de type utilisateur
    public class Utilisateur
    {

        #region "Attributs - Proriétés"

        //Attributs d'instance: propres à chaque objet

        public string nom;
        public string prenom;
        public int age;

        //Attribut de classe: partagé par tous les objets

        public static string profil = "admin";



        #endregion

        #region "Constructeurs"

        public Utilisateur(string nom, string prenom, int age)
        {
            //this: mot clé qui pointe vers l'objet en cours d'utilisation
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public Utilisateur()
        {
        }

        public Utilisateur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

       


        #endregion

        #region "Méthodes"

        //Méthode d'instance est une méthode qui concerne un objet particulier
        public void AfficherNom()
        {
            Console.WriteLine(this.nom);
        }

        public static void ChangerProfil(string newProfil)
        {
            profil = newProfil;
        }


        #endregion

    }
}
