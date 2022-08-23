using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class TipoNumerico2
    {
        public static void Executa()
        {
            char letra = 'V'; //
            System.Console.WriteLine("Char " + letra);
            char charMin = char.MinValue;
            char charMax = char.MaxValue;
            System.Console.WriteLine(charMin);
            System.Console.WriteLine(charMax);

            System.Console.WriteLine("Letra V: " + (byte)letra);
        }
    }
}
