﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.a = 321;
            b.MethodB();

            Console.WriteLine(b.a); //résultat attendu = 321

            Console.ReadLine();
        }
    }
}
