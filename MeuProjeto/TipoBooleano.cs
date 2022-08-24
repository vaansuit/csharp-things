using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class TipoBooleano
    {
        public static void Run()
        {
            bool verdade = true;
            bool naoVerdade = false;
            Boolean verdadeDois = true;
            Boolean naoVerdadeDois = false;

            bool eMaior = 10 > 11;
            bool eIgual = 10 + 11 == 21;

            //If checa se é true, se não for true ele sai do bloco
            if(eMaior)
            {
                System.Console.WriteLine("É maior");
            } else
            {
                System.Console.WriteLine("É menor");
            }

        }
    }
}
