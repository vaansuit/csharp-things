using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class PessoaJuridicaRepository
    {
        //CREATE READ UPDATE DELETE

        //criando a lista
        private List<PessoaJuridica> list;

        //iniciando a variavel
        public PessoaJuridicaRepository()
        {
            this.list = new List<PessoaJuridica>();
            
        }

        public string Create(PessoaJuridica juridica)
        {
            this.list.Add(juridica);
            return "Pessoa " + juridica.Name + " Salva com sucesso!";
        }

        public List<PessoaJuridica> Read()
        {
            
            return list;
        }

        public string Update(PessoaJuridica juridica)
        {
            return "Pessoa> " + juridica.Name + " alterado com sucesso";
        }

        public string Delete(int id)
        {
            
            return "Pesoa de id: " + id + " deletada com sucesso";
        }
    }
}
