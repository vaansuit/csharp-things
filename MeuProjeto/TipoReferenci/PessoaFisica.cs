using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class PessoaFisica : Pessoa //traz tudo da classe base (pessoa) para a classe que herdoun (pessoa fisica)
    {
        public string Cpf { get; set; } //nao é int pq se o CPF começasse por 0, os 0 a esquerda são ignorados no c#
        public PessoaFisica(string name, string lastName, string cpf) : base(name, lastName)
        {
            this.Cpf = cpf;
        }

        
        public override string Greetings() //override sobreescrevendo
        {
            return base.Greetings() + " - " + this.Cpf ;
        }
    }
}
