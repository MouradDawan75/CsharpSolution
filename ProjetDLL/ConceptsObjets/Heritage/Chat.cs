using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Heritage
{
    public class Chat : Animal
    {
       

        public string Couleur { get; set; }

        public Chat()
        {
        }

        public Chat(string nom, int age, string couleur) : base(nom, age)
        {
            //base: est un mot clé qui pointe vers la classe mère
            this.Couleur = couleur;
        }

        public void Dormir()
        {
            Console.WriteLine("Chat -> dormir......");
        }



        //Redéfinition de méthode (override): pouvoir modifier les méthodes définies dans la classe mère
        public override void EmettreSon()
        {
            Console.WriteLine("Miauller....");
        }

    }
}
