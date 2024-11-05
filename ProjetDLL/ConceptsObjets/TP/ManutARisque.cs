using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    public class ManutARisque : Manutentionnaire
    {
        
        public static double PRIME_MANUTENTIONNAIRE { get; set; } = 200;
        public ManutARisque(string nom, string prenom, int age, string dateEntree, double heures) : base(nom, prenom, age, dateEntree, heures)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME_MANUTENTIONNAIRE;
        }
    }
}
