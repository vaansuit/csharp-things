using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class TipoNumerico3
    {
        public static void Run()
        {
            float minValue =  float.MinValue;
            float maxValue = float.MaxValue;
            Console.WriteLine("Float Min Value: " + minValue);
            Console.WriteLine("Float Max Value: " + maxValue);
            double doubleMaxValue = double.MaxValue; //Double é o que tem mais casas depois da virgula, melhor para empresas que lidam com mercado financeiro, bancos, etc por conta do arredondamento
            double doubleMinValue = double.MinValue;
            Console.WriteLine("Double Max Value: " + doubleMaxValue);
            Console.WriteLine("Double Min Value: " + doubleMinValue);
            decimal decimalMaxValue = decimal.MaxValue; 
            decimal decimalMinValue = decimal.MinValue;
            Console.WriteLine("Decimal max value: " + decimalMaxValue);
            Console.WriteLine("Decimal min value: " + decimalMinValue);

            double x = 10.1;
            double y = 20.2;
            double resultOne = x + y;
            double resultTwo = 30.3;

            Console.WriteLine(resultOne);
            Console.WriteLine((resultOne) == (resultTwo)); //Aqui da false, porque na variavel resultTwo, como declaramos o valor, o sistema coloca 30.3 mockando 9999999999999, por isso nesta logica booleana retorna false

            //Decimal não aceita o . direto, como foi criado para moeda,  colocamos como 10.1m de monetary
            //Quando verificar questões monetárias, utilizar o decimal

            decimal decimalOne = 10.5m;
            decimal decimalTwo = 20.3m;
            decimal result = 30.8m;

            Console.WriteLine((decimalOne + decimalTwo) == result);
            Console.WriteLine(decimalOne + decimalTwo);
        }
    }
}
