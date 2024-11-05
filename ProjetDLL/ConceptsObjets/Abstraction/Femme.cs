using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Abstraction
{
    public class Femme : Humain
    {
        public override void Identite()
        {
            Console.WriteLine("Femme...");
        }

        public override void Test()
        {
            base.Test();
        }
    }
}
