using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Encapsulation
{
    public class Rectangle
    {
        //private double hauteur;
        //private double largeur;
        //private int age;

        //public double GetHauteur()
        //{
        //    return hauteur;
        //}

        //public void SetHauteur(double hauteur)
        //{
        //    if (hauteur < 0)
        //    {
        //        Console.WriteLine("Hauteur doit être positive");
        //    }
        //    else
        //    {
        //        this.hauteur = hauteur;
        //    }
            
        //}

        //public double GetLargeur()
        //{
        //    return largeur;
        //}

        //public void SetAge(int age)
        //{
        //    if(age >= 18 && age <= 64)
        //    {
        //        this.age = age;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Age doit eptre compris entre 18 et 64");
        //    }
            
        //}

        //public void SetLargeur(double largeur)
        //{
        //    this.largeur = largeur;
        //}
        //public double Surface()
        //{
        //    return hauteur * largeur;   
        //}

        //Syntaxe simplifiée pour la gestion des attributs

        //Si contrainte à gérer: utilisez la propriété full (propfull)

        private double hauteur;

        // .net utilise la notion de propriété qui contient les 2 accès: get/set
        public double Hauteur
        {
            get { return hauteur; }
            set 
            { 
                if (value > 0)
                {
                    hauteur = value;
                }
                else
                {
                    Console.WriteLine("Hauteur doit être positive");
                }
                
            }
        }

        // si aucune contrainte à gérer: utilisez la propriété automatique: (prop)

        public double Largeur { get; set; }

        //Le nom est en lecture seule: pas de set
        public string  Nom { get; }
       


    }
}
