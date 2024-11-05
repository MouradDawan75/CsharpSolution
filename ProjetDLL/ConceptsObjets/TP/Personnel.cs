using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    //Classe Service (classe utilitaire)
    public class Personnel
    {
        public Employe[] Employes { get; set; }
        public int maxEmployes = 0;
        public int nbEmploye = 0;

        public Personnel(int nbMaxEmployes)
        {
            Employes = new Employe[nbMaxEmployes];
            maxEmployes = nbMaxEmployes;
        }

        public void AjouterEmploye(Employe employe)
        {
            nbEmploye++;
            if (nbEmploye <= maxEmployes)
            {
                Employes[nbEmploye - 1] = employe;
            }
            else
            {
                Console.WriteLine($"Pas plus de {maxEmployes} employés");
            }
        }

        public void AfficherSalaire()
        { 
            //On doit prendre en compte le nombre effectifs d'employés contenu dans la variable nbEmploye
            for (int i = 0; i < nbEmploye; i++)
            {
                Console.WriteLine($"{Employes[i].GetNom()} gagne {Employes[i].CalculerSalaire()} euros.");
            }
        }

        public double SalaireMoyen()
        {
            double somme = 0;
            for (int i = 0; i < nbEmploye; i++)
            {
                somme += Employes[i].CalculerSalaire();
            }

            return somme /nbEmploye;
        }
    }
}
