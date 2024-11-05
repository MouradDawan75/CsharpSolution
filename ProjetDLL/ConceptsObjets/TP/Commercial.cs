using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    public abstract class Commercial : Employe
    {
        public double ChiffreAffaire { get; set; }

        public Commercial(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree)
        {
            this.ChiffreAffaire = chiffreAffaire;
        }

    }
}
