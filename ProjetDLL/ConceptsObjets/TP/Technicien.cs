using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    public class Technicien : Employe
    {
       
        public double Unites { get; set; }
        public static double FACTEUR_UNITES { get; set; } = 5;

        public Technicien(string nom, string prenom, int age, string dateEntree, double unites) : base(nom, prenom, age, dateEntree)
        {
            this.Unites = unites;
        }

        public override double CalculerSalaire()
        {
            return Unites * FACTEUR_UNITES;
        }

        public override string GetNom()
        {
            return $"Le technicien {Prenom} {Nom}";
        }
    }
}
