using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class Enumeradores2
    {

        public static void Run()
        {
            Console.WriteLine(DiasDaSemana2.DOM);
            DiasDaSemana2 presencial = (DiasDaSemana2)20; //Somatoria dos dois bits de TER e QUI
            Console.WriteLine(presencial);
        }
    }
    [Flags] //Especifico em cima da classe é para o Enum

    public enum DiasDaSemana2
    {
        DOM = 1,
        SEG = 2,
        TER = 4,
        QUA = 8,
        QUI = 16,
        SEX = 32,
        SAB = 64, //Aqui são bits, começamos pelo 1 pois é o primeiro bit ligado, depois vamos sempre exponenciando em 2 pois é a regra do bit

    }
}
