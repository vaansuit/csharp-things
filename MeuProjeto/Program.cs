using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BemVindo.Mensagem();
            TipoNumerico tipoNumerico = new TipoNumerico();
            tipoNumerico.Executa();
            TipoNumerico2.Executa();
            Cadastro.Executa();
        }
    }
}
