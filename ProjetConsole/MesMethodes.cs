using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    //Classe service (classe utilitaire)
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

        //Méthode avec des paramètres optionnels:
        /*
         * Possèdent une valeur initiale et sont définis après les params obligatoires
         */

        public static void MethodeOptionnelle(int x , int alpha = 10, int beta = 15)
        {
            Console.WriteLine($"x = {x} - apha = {alpha} - beta = {beta}");
        }

        public static double PrixTTC(double prixHT, double tva = 0.2)
        {
            return prixHT * (1 + tva);
        }
        //Passage de paramètres par réference: concerne uniquement les types simples, car les types complèxes par définition
        // sont des types réference
        public static void Permuter(ref int v1, ref int v2)
        {
            int tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        //Paramètres en sortie d'une méthode:

        public static double Calculs(double x, double y, out double produit, out double moyenne)
        {
            produit = x * y;
            moyenne = (x + y) / 2;
            return x + y;
        }


        //Méthode avec un nombre variable de paramètres: permet d'éviter de définir les différentes surcharges possibles d'une méthode
      /*  public static int Produit(int x, int y)
        {
            return x * y;
        }

        public static int Produit(int x, int y, int z)
        {
            return x * y * z;
        }

        public static int Produit(int x, int y, int z, int v)
        {
            return x * y * z * v;
        }*/

        //params: il s'agit d'un tableau à taille variable
        public static int Produit(params int[] tab)
        {
            int p = 1;
            foreach (var item in tab)
            {
                p *= item;
            }
            return p;
        }

        public static void Test(string nom, params string[] chaines)
        {

        }
    }
}
