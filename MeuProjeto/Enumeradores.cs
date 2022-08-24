using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class Enumeradores
    {
        public static void Run()
        {
            Console.WriteLine(DiasDaSemana.DOM);
            Console.WriteLine((byte)DiasDaSemana.DOM); //pode-se usar byte, int, long, etc.. tudo que caiba dentro do tipo da variável

            DiasDaSemana segunda = DiasDaSemana.SEG;
            Console.WriteLine(segunda);
            DiasDaSemana terça = (DiasDaSemana)2; //precisa converter explicitamente
            Console.WriteLine(terça);
        }
    }
    //Serve para dados fixos, dias da semana, sexo em sistemas de hospitais, etc..
    //Salvamos no banco como um inteiro, e puxamos do banco convertendo pra enum
    public enum DiasDaSemana
    {
        DOM,
        SEG,
        TER,
        QUA,
        QUI,
        SEX,
        SAB,
        
    }
}
