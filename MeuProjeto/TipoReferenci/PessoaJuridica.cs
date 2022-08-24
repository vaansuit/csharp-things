using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public PessoaJuridica(string name, string lastName, string cnpj) : base(name, lastName)
        {
            this.Cnpj = cnpj;
        }

        public override string Greetings()
        {
            return base.Greetings() + " - " + this.Cnpj;
        }

    }
}
