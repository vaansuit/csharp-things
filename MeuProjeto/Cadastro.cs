using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class Cadastro
    {
        /*Crie um sistema de cadastro de pessoas 
         1 - O sistema deve exibir uma mensagem de boas vindas
        2 - Deve solicitar as seguintes informações ao usuário:
            Nome
            Sobrenome
            Idade
        3- Ao fim da execução, deve exibir o nome completo e idade, juntamente com mensagem de despedida.
        */

        

        public static void Executa()
        {
            Console.WriteLine("Bem vindo ao Bamerindos!");
            Console.WriteLine("Informe seu nome: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Olá, " + firstName + " " + lastName + ". Sua idade é: " + age + " anos.");
        }
    }
}
