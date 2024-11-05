using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Heritage
{
    public class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public Animal()
        {
        }

        //virtual: permet aux classes filles en cas de besoin de modifier cette méthode
        public virtual void EmettreSon()
        {
            Console.WriteLine("Son de l'animal....");
        }

        private void Test()
        {

        }
    }
}
