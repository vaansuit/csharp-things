using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.TipoReferenci
{
    internal class Pessoa
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        
        public Pessoa(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        
        }

        virtual
        public string Greetings() //na mae eu permito que as filhas reescrevam o metodo
        {
            return "Ola, " + this.Name + " " + this.LastName;
        }
        

        }
 

}

