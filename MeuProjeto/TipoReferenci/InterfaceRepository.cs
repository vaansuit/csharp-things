using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal interface InterfaceRepository
    {
        //Metodos que devem ser implementados por alguém
        //Isso se chama assinatura do metodo: tipo de retorno, nome do metodo e parametros de entrada

        string Create(Pessoa pessoa );
        List<Pessoa> Read();
        string Update(Pessoa pessoa);
        string Delete(int id);
    }
}
