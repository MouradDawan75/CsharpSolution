using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class Test
    {
        //y est une variable de classe (globale): pas besoin de l'initialiser car elle possède une valeur par défaut

        /*
         * Types numériques: par défaut = 0
         * Type boolean: false
         * Types complèxes: null 
         */
        int y;
        public void minstance()
        {
            //x est une variable locale qui doit être initialisée
            int x = 0;
        }

        public static void mclasse()
        {
            
        }
    }
}
