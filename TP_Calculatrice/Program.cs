using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Solution1: boucle finie
            string choix = "x";

            while (choix != "q") 
            {

                Console.WriteLine(@"
                ****************Calculatrice Console*************
                --- Opérations possibles ---
                - Addition: tapez a 
                - Soustraction: tapez s
                - Multiplication: tapez m
                - Division: tapez d
                - Quitter: tapez q
                ");

                Console.WriteLine("Votre choix: ");
                choix = Console.ReadLine();

                if (choix == "q")
                {
                    Console.WriteLine(">>>>>>>>Fin");
                    break;
                }

                if (choix == "a" || choix == "s" || choix == "m" || choix == "d")
                {
                    Console.WriteLine("Premier nombre: ");
                    int nb1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Second nombre: ");
                    int nb2 = Convert.ToInt32(Console.ReadLine());

                    switch (choix)
                    {
                        case "a":
                            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
                            break;

                        case "s":
                            Console.WriteLine($"{nb1} - {nb2} = {nb1 - nb2}");
                            break;

                        case "m":
                            Console.WriteLine($"{nb1} x {nb2} = {nb1 * nb2}");
                            break;

                        case "d":
                            Console.WriteLine($"{nb1} / {nb2} = {nb1 / nb2}");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Choix invalide.............");
                    continue;
                }


            }


            //Pour commenter des lignes sélctionnées: ctr + k + c
            //Pour décommenter des lignes sélctionnées: ctr + k + u

            //            //Solution: boucle infinie
            //            while (true)
            //            {


            //                //Affichage d'un menu
            //                string choix = "";
            //                int nb1 = 0, nb2 = 0;

            //                Console.WriteLine(@"
            //****************Calculatrice Console*************
            //--- Opérations possibles ---
            //- Addition: tapez a 
            //- Soustraction: tapez s
            //- Multiplication: tapez m
            //- Division: tapez d
            //- Quitter: tapez q
            //");

            //                /*
            //                 * Demandez au user de choisir une opération.
            //                 * Tant que le choix est différent de q, le programme s'exécute
            //                 * Tant que le choix saisi n'est pas valide, demandez au user de saisir un autre
            //                 * Demandez la saisie de 2 nombres (entiers)
            //                 * Affichez le résultat selon le type de l'opération choisie
            //                 * 
            //                 * 
            //                 */
            //                Console.WriteLine("Votre choix: ");
            //                choix = Console.ReadLine();
            //                if (choix == "q")
            //                {
            //                    Console.WriteLine(">>> Fin du programme");
            //                    break;
            //                }
            //                else if (choix == "a" || choix == "s" || choix == "m" || choix == "d")
            //                {
            //                    Console.WriteLine("Premier nombre: ");
            //                    nb1 = Convert.ToInt32(Console.ReadLine());

            //                    Console.WriteLine("Second nombre: ");
            //                    nb2 = Convert.ToInt32(Console.ReadLine());

            //                    switch (choix)
            //                    {
            //                        case "a":
            //                            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
            //                            break;

            //                        case "s":
            //                            Console.WriteLine($"{nb1} - {nb2} = {nb1 - nb2}");
            //                            break;

            //                        case "m":
            //                            Console.WriteLine($"{nb1} x {nb2} = {nb1 * nb2}");
            //                            break;

            //                        case "d":
            //                            Console.WriteLine($"{nb1} / {nb2} = {nb1 / nb2}");
            //                            break;
            //                    }

            //                }
            //                else
            //                {
            //                    // Choix est invalide
            //                    Console.WriteLine("Choix invalide...........");
            //                    continue;
            //                }



            //            }

            //Maintenir la console active
            Console.ReadLine();
        }
    }
}
