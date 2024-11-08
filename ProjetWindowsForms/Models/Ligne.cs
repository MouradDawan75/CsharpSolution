using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Models
{
    public class Ligne
    {
        public string Description { get; set; }
        public string NomClient { get; set; }
        public string AdresseClient { get; set; }
        public string Couleur { get; set; }

        public Ligne() { }

        public Ligne(string description, string nomClient, string adresseClient, string couleur)
        {
            Description = description;
            NomClient = nomClient;
            AdresseClient = adresseClient;
            Couleur = couleur;
        }

        public override string ToString()
        {
            return $"Descr: {Description} Nom Client: {NomClient} Adresse Client: {AdresseClient} Couleur: {Couleur}";
        }
    }
}
