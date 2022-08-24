using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class PessoaFisicaRepository
    {
        //CREATE READ UPDATE DELETE

        //criando a lista
        private List<PessoaFisica> list;

        //iniciando a variavel
        public PessoaFisicaRepository()
        {
            this.list = new List<PessoaFisica>();
            
        }

        public string Create(PessoaFisica pessoa)
        {
            this.list.Add(pessoa);
            return "Pessoa " + pessoa.Name + " Salva com sucesso!";
        }

        public List<PessoaFisica> Read()
        {
            
            return list;
        }

        public string Update(PessoaFisica pessoa)
        {
            return "Pessoa> " + pessoa.Name + " alterado com sucesso";
        }

        public string Delete(int id)
        {
            
            return "Pesoa de id: " + id + " deletada com sucesso";
        }
    }
}
