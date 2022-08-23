using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class TipoNumerico
    {
        public void Executa()
        {
            byte valorMax = 255; //usa-se isso ao invés de inteiro quando precisar de performance
            byte byteMin = Byte.MinValue; //Descobre o menor valor do tipo de dado, existe também o Max
            byte byteMax = Byte.MaxValue;
            System.Console.WriteLine("Bytes Minimos " + byteMin);
            System.Console.WriteLine("Bytes Máximos " + byteMax);
            sbyte sbyteMin = (sbyte)byteMin;
            sbyte sbyteMax = (sbyte)byteMax;
            System.Console.WriteLine("sbyte Min " + sbyteMin); //para ter valores negativos em um range pequeno, ultima casa vira sinal
            System.Console.WriteLine("sbyte Max " + sbyteMax);
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine("short Min " + shortMin);
            System.Console.WriteLine("short Max " + shortMax);
            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("uShorMin " + ushortMin);
            System.Console.WriteLine("uShortMax " + ushortMax); //tira o sinal do byte
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine("Int Min " + intMin);
            System.Console.WriteLine("Int Max " + intMax);
            Int16 intMini = Int16.MinValue;
            Int16 intMaxi = Int16.MaxValue;
            System.Console.WriteLine("Int16 Min " + intMini);
            System.Console.WriteLine("Int16 Max " + intMaxi);
            Int32 intMinim = Int32.MinValue;
            Int32 intMaxim = Int32.MaxValue;
            System.Console.WriteLine("Int32 Min " + intMinim);
            System.Console.WriteLine("Int32 Max " + intMaxim);
            Int64 intMinimum = Int64.MinValue;
            Int64 intMaximum = Int64.MaxValue;
            System.Console.WriteLine("Int64 Min " + intMinimum);
            System.Console.WriteLine("Int64 Max " + intMaximum);
            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            System.Console.WriteLine ("Long min " + longMin);
            System.Console.WriteLine("Long max " + longMax);

        }
    }
}
