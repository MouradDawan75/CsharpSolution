using ProjetDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetConsole
{

    enum Erreur
    {
        MINEURE = 100,
        MAJEURE = 200,
        CRITIQUE = 300
    }

    enum Profil
    {
        ADMIN,
        MANAGER,
        RH
    }

    enum Autorisation
    {
        LECTURE,
        ECRITURE,
        MODIFICATION,
        SUPPRESSION,
        ALL
    }
    class User
    {
        public string nom;
        public Profil profil;
        public List<Autorisation> autorisations = new List<Autorisation> ();

    }
    internal class Program
    {

        // Méthode Main: c'est le point d'entrée d'une application - méthode exécutée au démarrage de l'appication
        static void Main(string[] args)
        {
            Tools.Afficher();

            #region "Variables"

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>> Variables:");

            //Variable: est une zone mémoire contenant une valeur typée
            /*
             * Types simples (types valeurs):
             * entiers: byte (1 octet 8 bits), short (2 o - 16 bits), int (4 o - 32 bits), long(8 o - 64 bits)
             * réels: float (4 o), double (8 o), decimal (16 o)
             * caractère: char (2 o)
             * boolean: bool (1 o)
             * 
             * 
             * Types complèxes (types réferences): string, date, array, classes/objets
             * 
             * En c# le typage est statique: on doit préciser le type d'une variable
             * 
             * 
             * 
             */

            int myInt = 10;
            double myDouble = 10.5;
            char myChar = 'c';
            string myString = "ceci est une chaine";
            bool myBool = false;

            Console.WriteLine(myInt);

            /*Conventions de nommages:
             * PascalCase: classes - méthodes
             * camelCase: variables -> myInt
             * snake_case: convention utilisée par python
             * 
             * 
             */

            //Constante: est une variable dont on ne peut pas modifier le contenu
            //Convention: le nom d'une constante est majuscules
            const int MA_CONSTANTE = 10;
            //MA_CONSTANTE = 15; -> erreur de compilation

            // Variables nulles: par définition, les types simples (types valeurs) ne sont pas nullables
            // Les types complèxes sont nullables
            int? x = null;

            string s = null;

            // Générer des valeurs aléatoires:
            Random random = new Random();
            int n = random.Next(1, 10);

            Console.WriteLine("Nombre aléatoire = " + n); // concaténation



            #endregion

            #region "Formattage de chaines"

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>> Formattage");
            int age = 50;
            string prenom = "Jean";

            //Concaténation:
            Console.WriteLine("Prénom: "+prenom+" Age: "+age);

            //Interpolation:
            //version1:
            Console.WriteLine("Prénom: {0} Age: {1}",prenom,age);

            //version2: syntaxe simplifiée de v1
            Console.WriteLine($"Prénom: {prenom} Age: {age}");

            //Entre accolades: on peut soit insérer des variables, soit des expressions

            Console.WriteLine($"Expression: {2+5}");

            /*
             * Caratères d'echappement:
             * \n: retour à la ligne
             * \t: tabulation
             * \s: éspace
             * \b: back space (retour en arrière)
             * \\: ignorer le \
             * \': ignorer '
             * \": ignorer "
           
             */

            string chemin = "c:\\test\\notes.txt";

            string chaine1 = "\tCeci est une\nchaine sur \nplusieurs lignes.";
            Console.WriteLine(chaine1);

            //Chaine verbatim: pratique pour la gestion des chemins et pour définir des menus

            string chaine2 = @"     Ceci est une
chaine sur
plusieurs lignes.";

            Console.WriteLine(chaine2);

            string chemin2 = @"c:\test\notes.txt"; // Pas besoin de caractères d'échappement

            #endregion

            #region "Opérateurs"

            Console.WriteLine( ">>>>>>>>>>>>>>>>>>>>>> Opérateurs:");

            Console.WriteLine( "\t Arithmétiques:");
            //+, -, *, /, %(Modulo: reste de la division entière)

            int i = 5, j = 3;
            Console.WriteLine($"Modulo: {i % j}");

            Console.WriteLine("\t Opérateurs combinés:");

            //Se sont des syntaxes simplifiées:

            int y = 5;
            y++; // équivalent à: y = y + 1 - incrémentation
            y--; // équivalent à: y = y - 1 - décrementation

            y += 5; // équivalent à: y = y + 5
            y *= 2; // y = y * 2

            Console.WriteLine("\t Opérateurs de comparaison:");

            // >, >=, <, <=, == (égalité), != (différent) -> renvoient un boolean

            Console.WriteLine(i == j);

            Console.WriteLine("\t Opérateurs logiques:");
            //&& (et logique), || (ou logique), ^ (ou exclusif), ! (non logique) -> renvoient un boolean

            /* Table :
             * 
             * A    B   A && B   A || B     A ^ B
             * v    f      f        v         v
             * v    v      v        v         f
             * f    f      f        f         f    
             */

            int v1 = 10, v2 = 15;

            Console.WriteLine((v1 < v2) && (v2 > 0)); //True
            Console.WriteLine((v1 < v2) && (v2 < 0)); //False

            #endregion

            #region "Transtypage: conversion de types"

            Console.WriteLine(">>>>>>>>>>>>>>>>> Conversion de types:");

            //Conversion implicite: concerne le passage d'un type inférieur à un type supérieur

            byte myByte = 10;
            int myInt2 = myByte;


            //Conversion explicite: concerne le passage d'un type supérieur à un type inférieur

            //option1: utilisation du CAST: (int), (long), (short).....
            long myLong = 20;
            short myShort = (short)myLong; //risque de perte de données

            //option2: utilisation de la classe Convert qui propose des méthodes de conversion

            short myShort2 =  Convert.ToInt16(myLong);

            string str = "15";
            int z = Convert.ToInt32( str); // le cast ne fonctionne pas pour les types incompatibles
            int w = int.Parse(str);

            Console.Write("Votre âge:");
            int ageNew = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine($"Age: {ageNew}");

            //Lire 2 nombres saisis à la console et afficher la somme: Somme = résultat
            Console.Write("Premier nombre: ");
            double nb1 = Convert.ToDouble( Console.ReadLine());

            Console.Write("Second nombre: ");
            double nb2 = Convert.ToDouble(Console.ReadLine());

            double somme = nb1 + nb2;

            Console.WriteLine($"Somme = {somme}");
            //Console.WriteLine($"Somme = {nb1 + nb2}");



            #endregion

            #region "Bloc Conditionnel"

            Console.WriteLine(">>>>>>>>>>>>>>>> Conditions:");

            /*
             * Bloc conditionnel: un ensembke d'instructions qui ne s'exécute qui si une condition
             * est vérifiée.
             * 
             */

            int number = 5;
            if( number > 0)
            {
                Console.WriteLine("Number positif");
            }
            else if(number < 0)
            {
                Console.WriteLine("Number négatif");
            }
            else
            {
                Console.WriteLine("Number égale 0");
            }

            // switch case: c'est variante du if/else - permet de remplacer les if/else if qui s'imbriques

            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("Recalé");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Juste la moyenne");
                    break;

                default:
                    Console.WriteLine("Good job");
                    break;
            }

            // Opérateur ternaire: permet de faire des affectations conditionnelles
            // variable = (condition) ? valeur1 si condition vraie: valeur2 si condition fausse

            bool b = (10 > 5) ? false : true;




            #endregion

            #region "Boucles"

            Console.WriteLine(">>>>>>>>>>>>>> Boucles:");

            /*
             * Bloc itératif: 
             * for: si le nombre d'itérations est connu
             * while - do while: boucle conditionnelle: si le nombre d'itérations n'est pas connu, mais que le bloc
             *  dépend d'une condition, on utilise (while ou do while)
             * foreach: permet de parcourir tous les éléments d'une collection
             * 
             * 
             */

            //for:
            for (int index = 1; index < 5; index++)
            {
                Console.WriteLine($"Index: {index}");
                if (index == 3)
                {
                    break;
                }
            }

            //while:

            int v = 1;

            while (v < 5)
            {
                Console.WriteLine($"v = {v}");
                v++;
                if (v == 3)
                {
                    break;
                }
            }

            //do while: s'exécute au moins 1 fois

            do
            {
                Console.WriteLine($"v = {v}");
                v++;
            } while (v < 10);

            //foreach:

            int[] tab = {10,20,30,40,50,60};

            foreach (int item in tab)
            {
                if (item == 40)
                {
                    continue; // force le passage à l'itération suivante -> la suite de la boucle n'est pas exécutée
                }

                if (item == 50)
                {
                    break;
                }

                Console.WriteLine(item); // 10 20 30
            }


            #endregion

            #region "Tableaux"

            Console.WriteLine(">>>>>>>>>>>>>>>> Tableaux");
            //Tableaux statiques:
            //1 dimension
            int[] entiers = new int[3]; //tableau de 3 cases
            entiers[0] = 10;
            entiers[1] = 20;
            entiers[2] = 30;

            //Autre façon de déclarer un tableau: si le contenu est connu d'avance
            int[] t = { 10, 20, 30 };
            string[] Profils = { "ADMIN", "MANAGER", "RH" };

            Console.WriteLine("Taille du tableau: " + t.Length);

            //foreach
            foreach (int item in t)
            {
                Console.WriteLine(t);
            }

            //for
            for (int idx = 0; idx < t.Length; idx++)
            {
                Console.WriteLine(t[idx]);
            }

            //while

            int compteur = 0;

            while (compteur < t.Length)
            {
                Console.WriteLine(t[compteur]);
                compteur++;
            }

            // 2 dimensions
            int[,] matrice = new int[2,3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 20;
            matrice[0, 2] = 30;
            matrice[1, 0] = 40;
            matrice[1, 1] = 50;
            matrice[1, 2] = 60;

            Console.WriteLine("Nombre de lignes: " + matrice.GetLength(0));
            Console.WriteLine("Nombre de colonnes: " + matrice.GetLength(1));

            Console.WriteLine(">>> Parcourir la matrice:");

            //fixer les lignes
            for (int ligne = 0; ligne < matrice.GetLength(0); ligne++)
            {
                //fixer les colonnes
                for (int colonne = 0; colonne < matrice.GetLength(1); colonne++)
                {
                    Console.WriteLine(matrice[ligne,colonne]);
                }
            }


            #endregion

            #region "Enumération"

            Console.WriteLine(">>>>>>>>>>>> Enumération:");
            //Enum: est un ensemble de valeurs constantes

            Erreur er = Erreur.MAJEURE;
            Console.WriteLine(er);

            Console.WriteLine("Code de votre erreur (100 - 200 - 300)");
            int code = Convert.ToInt32(Console.ReadLine());

            Erreur error = (Erreur)code;

            Console.WriteLine("Votre erreur: "+error);

            User u = new User();
            u.nom = "Jean";
            u.profil = Profil.ADMIN;
            u.autorisations.Add(Autorisation.LECTURE);
            u.autorisations.Add(Autorisation.ECRITURE);
            u.autorisations.Add(Autorisation.SUPPRESSION);

            if (u.autorisations.Contains(Autorisation.SUPPRESSION))
            {
                Console.WriteLine("Suppression OK....");
            }
            else
            {
                Console.WriteLine("Action interdite.....");
            }

            Console.WriteLine(">>>> Récupérer tous les éléments d'une Enum:");

            Enum.GetValues(typeof(Profil));

            #endregion

            #region "Méthodes"

            Console.WriteLine(">>>>>>>>>>>> Méthodes:");
            //Méthode: est un ensemble d'instructions réutilisable
            /*
             * 2 types de méthodes:
             * Procédure: est une méthode qui ne renvoie aucun résultat. Ex: WriteLine
             * Fonction: est une méthode qui renvoie un résultat. ReadLine
             * 
             * Syntaxe:
             * Visibilité [static] void - type_du_retour NomMethode(paramètres) {instructions;}
             * 
             */

            //Appel de la méthode d'instance: Afficher
            MesMethodes m = new MesMethodes(); // instancier la classe MesMethodes
            m.Afficher();

            //Appel d'une méthode de classe (static)
            MesMethodes.Imprimer();

            int resultat = MesMethodes.Somme(10, 20);
            Console.WriteLine(resultat);

            int[] tableau = { 10, 2, 15, 15, 1, 9, 55 };

            Console.WriteLine($"Somme tableau: {MesMethodes.SommeTableau(tableau)}");
            Console.WriteLine($"Moyenne tableau: {MesMethodes.MoyenneTableau(tableau)}");
            Console.WriteLine($"Min tableau: {MesMethodes.MinimumTableau(tableau)}");




            #endregion



            // Maintenir la console active

            Console.ReadLine();
        }
    }
}
