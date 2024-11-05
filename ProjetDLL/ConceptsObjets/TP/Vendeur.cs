using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    public class Vendeur : Commercial
    {
        public static double BONUS_VENDEUR { get; set; } = 400;
        public static double POURCENT_VENDEUR { get; set; } = 0.2;

        public override double CalculerSalaire()
        {
            return ChiffreAffaire * POURCENT_VENDEUR + BONUS_VENDEUR;
        }

        public Vendeur(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree, chiffreAffaire)
        {
            
        }

        public override string GetNom()
        {
            return $"Le vendeur {Prenom} {Nom}";
        }
    }
}
