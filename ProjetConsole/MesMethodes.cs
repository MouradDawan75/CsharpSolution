using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
       // Syntaxe:
       //Visibilité [static] void - type_du_retour NomMethode(paramètres) { instructions; }
       /*
        * Une classe peut contenir 2 types de méthodes
        * - Méthode d'instance: accéssible via une instance de la classe.
        * - Méthode de classe (static): accéssible depuis la classe
        * 
        * 
        */

        public void Afficher()
        {
            Console.WriteLine("Méthode afficher........");
        }

        public static void Imprimer()
        {
            Console.WriteLine("Méthode Imprimer........");
        }

        /// <summary>
        /// Méthode qui renvoie la somme de 2 entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>somme de x et y</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }

        //Surcharge de méthode: pouvoir définir la mm méthode dans la mm classe, en modifier la liste des paramètres soit en
        // nombre, soit en type


        //Surchage en modifiant le nombre de paramètres
        public static int Somme(int x, int y, int z)
        {
            return x + y;
        }


        //Surchage en modifiant le type des paramètres
        public static double Somme(double x, double y)
        {
            return x + y;
        }

        //Méthode qui renvoie la somme des éléments d'un tableau d'entiers

        public static int SommeTableau(int[] tab)
        {
            int s = 0;
            foreach (int x in tab)
            {
                s += x; // s = s + x
            }
            return s;
        }

        //Méthode qui renvoie la moyenne des éléments d'un tableau d'entiers

        public static double MoyenneTableau(int[] tab)
        {
            double s = SommeTableau(tab);
            int nbElements = tab.Length;
            return s / nbElements;  
        }

        //Méthode qui renvoie l'élément le plus petit d'un tableau d'entiers

        public static int MinimumTableau(int[] tab)
        {
            int min = int.MaxValue;
            foreach (int x in tab)
            {
                if (x < min)
                {
                    min = x;
                }
            }
            return min;
        }
    }
}
