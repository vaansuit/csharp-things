using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class TestaPessoas
    {
        public static void Run()
        {
            PessoaFisica pessoaFisica = new PessoaFisica("Victor", "Vansuit", "465-456-464-45");
            PessoaFisica pessoaFisica2 = new PessoaFisica("Young", "TOGURO", "465-456-464-45");
            /* string msg = pessoaFisica.Greetings();
            Console.WriteLine(msg); */
            PessoaFisicaRepository repository = new PessoaFisicaRepository();
            repository.Create(pessoaFisica2);

            string msg = repository.Create(pessoaFisica);
            Console.WriteLine(msg);
            List<PessoaFisica> pessoas = repository.Read();
            foreach (var p in pessoas)
            {
                Console.WriteLine(p.Greetings());
            }

            
            
        }

        public static void RunJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica("Ales Blau", "Pega no meu", "Pé");
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica("Empresa", "LTDA", "02.555.555/0001-89");
            PessoaJuridicaRepository repositoryJuridica = new PessoaJuridicaRepository();
            repositoryJuridica.Create(pessoaJuridica2);

            string msgJur = repositoryJuridica.Create(pessoaJuridica);
            Console.WriteLine(msgJur);
            List<PessoaJuridica> juridica = repositoryJuridica.Read();
            foreach (var j in juridica)
            {
                Console.WriteLine(j.Greetings());
            }
        }
    }
}
