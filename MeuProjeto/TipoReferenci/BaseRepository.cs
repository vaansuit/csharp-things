using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class BaseRepository : InterfaceRepository
    {
        List<Pessoa> pessoas;

        public BaseRepository()
        {
            this.pessoas = new List<Pessoa>();
        }
        public string Create(Pessoa pessoa)
        {
            this.pessoas.Add(pessoa);
            return "Pessoa " + pessoa.Name + " Salva com sucesso!";
            
        }

        public string Delete(int id)
        {
            return "Pesoa de id: " + id + " deletada com sucesso";
        }

        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Update(Pessoa pessoa)
        {
            return "Pessoa> " + pessoa.Name + " alterado com sucesso";
        }
    }
}
