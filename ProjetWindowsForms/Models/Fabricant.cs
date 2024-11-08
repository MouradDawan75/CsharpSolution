using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Models
{
    public class Fabricant
    {
        public string Nom { get; set; }

        public Fabricant(string nom)
        {
            Nom = nom;
        }

        public Fabricant()
        {
        }

        public override string ToString()
        {
            return $"Nom: {Nom}";
        }
    }
}
