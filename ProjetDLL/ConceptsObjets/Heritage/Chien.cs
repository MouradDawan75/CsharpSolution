﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ConceptsObjets.Heritage
{
    public class Chien : Animal
    {
        public override void EmettreSon()
        {
            Console.WriteLine("Aboyer.....");
        }
    }
}
