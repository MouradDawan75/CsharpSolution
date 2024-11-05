using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class Produit
    {
        //Attributs d'instance
        public string description;
        public double prix;
        public int quantite;

        //Attribut de classe: partagé par tous les produits
        public static string etat = "occasion";

        //Constructeurs
        public Produit(string description, double prix, int quantite)
        {
            this.description = description;
            this.prix = prix;
            this.quantite = quantite;
        }

        public Produit()
        {
        }

        //Méthodes

        public void ModifierPrix(double newPrix)
        {
            this.prix = newPrix;
        }

        public static void ModifierEtat(string newEtat)
        {
            etat = newEtat;
        }

        


    }
}
