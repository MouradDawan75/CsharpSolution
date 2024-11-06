using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nombre_Aleatoire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Le programme choisit un nombre aléatoire compris entre 1 et 100.
             * Demandez à l'utilisateur de deviner ce nombre.
             * Le nombre de tentatives max est de 6
             * Le programme doit gérer le cas d'un nombre saisi non valide
             * Le programme indiquera à l'utilisateur si le nombre alétoire est supérieur ou inférieur au nombre saisi.
             * 
             * 
             */

            Random rnd = new Random();
            int aleatoire = rnd.Next(1,100);

            Console.WriteLine(">>>>>>>>>>>> Devinez le nombre aléatoire compris entre 1 et 100:");

            int nbTentative = 0;
            int tentative_max = 6;

            while (true)
            {
                nbTentative++;

                if (nbTentative < tentative_max)
                {
                    Console.WriteLine($"{nbTentative} tentative");
                }
                else
                {
                    Console.WriteLine("Dernière tentative......");
                }

                Console.WriteLine("Votre nombre: ");
                
                try
                {
                    int nombre = Convert.ToInt32(Console.ReadLine());

                    if(nombre == aleatoire)
                    {
                        Console.WriteLine($"Trouvé en {nbTentative} tentatives. Aléatoire = {aleatoire}");
                        break;
                    }

                    if(nbTentative == tentative_max)
                    {
                        Console.WriteLine($"Perdu! Aléatoire = {aleatoire}");
                        break;
                    }

                    if(nombre < aleatoire)
                    {
                        Console.WriteLine("Plus grand");
                    }
                    else
                    {
                        Console.WriteLine("Plus petit");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Saisie invalide.....");
                }
            }

            //maintenir la console active
            Console.ReadLine();
        }
    }
}
