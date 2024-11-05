using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Abstraction
{
    /// <summary>
    /// Classes Filles: Homme, Femme
    /// </summary>
    public abstract class Humain
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Humain() { }

        public Humain(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public virtual void Test()
        {

        }

        //Méthode abstraite: méthode non implémentée
        //Cette méthode doit être substituée par toutes les classes filles

        public abstract void Identite();
    }
}
