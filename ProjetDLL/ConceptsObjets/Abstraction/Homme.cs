using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Abstraction
{
    public class Homme : Humain
    {
       public Homme(string nom, string prenom) : base(nom, prenom) 
        {

        }

        public Homme() 
        {

        }

        public override void Identite()
        {
            Console.WriteLine( "Homme.....");
        }
    }
}
