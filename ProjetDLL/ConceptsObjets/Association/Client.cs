using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Association
{
    public class Client
    {
        public string Nom { get; set; }

        //Association (composition d'objets):
        //c'est le fait qu'un objet de type Adresse puisse faire partie des attributs d'un objet de type Client
        public Adresse Adresse { get; set; }

        public Client() { }

        public Client(string nom, Adresse adresse)
        {
            Nom = nom;
            Adresse = adresse;
        }
    }
}
