using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Models
{
    public class Produit
    {
        public int Id { get; set; } //clé primaire das la table Produit
        public string Description { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public Produit(int id, string description, double prix, int quantite)
        {
            Id = id;
            Description = description;
            Prix = prix;
            Quantite = quantite;
        }

        public Produit(string description, double prix, int quantite)
        {
            Description = description;
            Prix = prix;
            Quantite = quantite;
        }

        public Produit()
        {
        }

        public override string ToString()
        {
            return $"Decription: {Description} Prix: {Prix} Quantité: {Quantite}";
        }
        /*
         * Pour chaque classe objet (définie dans Models): on crée une table
         * Pour chaque classe objet: on crée une classe service pour gérer la persistence en BD
         * 
         */
    }
}
