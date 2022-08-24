using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuProjeto.TipoReferenci;

namespace MeuProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* BemVindo.Mensagem();
             TipoNumerico tipoNumerico = new TipoNumerico();
             tipoNumerico.Executa();
             TipoNumerico2.Executa();
             //new TipoNumerico().executa também funcionaria
             Cadastro.Executa(); 
             TipoNumerico3.Run();
             TipoBooleano.Run(); 
            Enumeradores.Run();
            Enumeradores2.Run(); 
            Estruturas.Run();
            PessoaFisica pessoaFisica = new PessoaFisica("Victor", "Vansuit", "465-456-464-45");
            PessoaFisica pessoaFisica2 = new PessoaFisica("Young", "TOGURO", "465-456-464-45");
            /* string msg = pessoaFisica.Greetings();
            Console.WriteLine(msg); 
            Repository repository = new Repository();
            repository.Create(pessoaFisica2);

            string msg = repository.Create(pessoaFisica); 
            Console.WriteLine(msg);
            List<PessoaFisica> pessoas = repository.Read();
            foreach(var p in pessoas)
            {
                Console.WriteLine(p.Greetings());
            } */

            TestaPessoas.Run();
            TestaPessoas.RunJuridica();
            Console.Read();
            
        }
    }
}
