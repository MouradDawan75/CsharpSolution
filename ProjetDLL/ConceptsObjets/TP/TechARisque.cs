using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    public class TechARisque : Technicien
    {
        
        public static double PRIME_TECHNICIEN { get; set; } = 200;
        public TechARisque(string nom, string prenom, int age, string dateEntree, double unites) : base(nom, prenom, age, dateEntree, unites)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME_TECHNICIEN;
        }
    }
}
