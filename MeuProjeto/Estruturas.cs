using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class Estruturas
    {
        public static void Run()
        {
            PessoaStruc pessoaStruc2  = new PessoaStruc();
            pessoaStruc2.Age = 20;
            PessoaStruc pessoaStruc = new PessoaStruc();
            pessoaStruc.Name = "Joelma";
            Console.WriteLine(pessoaStruc.Age);
            Console.WriteLine(pessoaStruc.Name);
            PessoaStruc pessoaStruc3 = new PessoaStruc();
            pessoaStruc3 = pessoaStruc;
            Console.WriteLine(pessoaStruc3);
            Console.WriteLine(pessoaStruc3.Name);
            Console.WriteLine("Valor alterado");
            pessoaStruc3.Name = "Brabinho da galera";
            Console.WriteLine(pessoaStruc3.Name);
            
        }
    }

    struct PessoaStruc
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

    }

    class PessoaClasse
    {
        public int id { get; set; }
        /*
        public string Name { get; set; }
        public string LastName { get; set; } mesma coisa que os construtores, só que de forma mais limpa e simplificada
        public byte Age { get; set; }
        */

        private string name;
        string lastName; //quando nao colocamos nada, toma como privado. Colocamos private para especificar
        private byte age; //private nao conseguimos mais acessar diretamente esse campo, isso é encapsulamento, nós chamamos então com o metodo Get

        public string GetName() //c# sempre começa os metodos com maiusculo, get pra pegar o valor privado e Set para mudar ele, setar o valor
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }
}
