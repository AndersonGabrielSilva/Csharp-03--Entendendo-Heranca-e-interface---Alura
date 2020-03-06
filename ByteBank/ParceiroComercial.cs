using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    //O parceiro comercial não é um funcionario então ele não precisa necessariamente herdar caracteristicas do Funcionario
    //Então eu somente herdo as caracteristicas da interface Autenticar
    public class ParceiroComercial : IAutenticavel
    {

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
