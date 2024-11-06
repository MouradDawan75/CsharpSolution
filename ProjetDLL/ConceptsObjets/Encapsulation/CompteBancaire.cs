using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Encapsulation
{
    public class CompteBancaire : object
    {
        #region "Attributs"

        //Numéro doit contenir au minimum 6 caractères: contrainte -> propriété full

        private string numero;

        public string Numero
        {
            get { return numero; }
            set 
            { 
                if (value.Length >= 6) 
                {
                    numero = value;
                }
                else
                {
                    //Console.WriteLine("Numéro doit contenir au minimum 6 char");
                    throw new Exception("Numéro doit contenir au minimum 6 char");
                }
                
            }
        }

        //Solde: pas de contrainte -> proriété automatique

        public double Solde { get; set; }

        //Attribut global: partagé par tous les comptes
        public static string Banque = "BNP";



        #endregion

        #region "Constructeurs"

        public CompteBancaire(string numero, double solde)
        {
            Numero = numero;
            Solde = solde;
        }

        //Nécessaire car certaines dll l'exige
        public CompteBancaire()
        {
        }




        #endregion

        #region "Méthodes"

        public void Depot(double montant)
        {
            Solde += montant;
        }

        public void Retrait(double montant) 
        {
            if (Solde < montant)
            {
                //Console.WriteLine("Solde insuffisant....");
                throw new Exception("Solde insuffisant......");
            }
            else
            {
                Solde -= montant;
            }
        }

        public static void ChangerBanque(string nomBanque)
        {
            Banque = nomBanque;
        }

        //Méthode qui permet de personnaliser l'affichage d'un objet: choisir les attributs à afficher
        public override string ToString()
        {
            return $"Numéro: {numero} - Solde: {Solde}";
        }

        //Equal permet de définir les critères d'égaité de 2 objets de type CompteBancaire
        public override bool Equals(object obj)
        {
            return obj is CompteBancaire bancaire &&
                   Numero == bancaire.Numero;
        }

        public override int GetHashCode()
        {
            return -1449941195 + EqualityComparer<string>.Default.GetHashCode(Numero);
        }

     



        #endregion
    }
}
