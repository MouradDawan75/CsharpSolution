﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.TP
{
    public class Representant : Commercial
    {
        
        public static double BONUS_REPRESENTANT { get; set; } = 800;
        public static double POURCENT_REPRESENTANT { get; set; } = 0.2;

        public Representant(string nom, string prenom, int age, string dateEntree, double chiffreAffaire) : base(nom, prenom, age, dateEntree, chiffreAffaire)
        {
        }

        public override double CalculerSalaire()
        {
            return ChiffreAffaire * POURCENT_REPRESENTANT + BONUS_REPRESENTANT;
        }

        public override string GetNom()
        {
            return $"Le représentant {Prenom} {Nom}";
        }
    }
}
