using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{

    //Nesta Classe do Funcionario autenticavel, ele herda as caracteristicas de Funcionario e assina contrato com a interface
    // Autenticavel, ou seja nela ira conter as caracteristicas de Funcionario com o Metodo de autenticar
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
         public string Senha { get; set; }
        
        //Atraves deste metodo todo Funcionario que herdar tambem está classe receberá junto o metodo autenticar que está na interface
        //Autenticar
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        //Neste construtor eu informo que está classe somente pode ser inicializada com os argumentos CPF e Base Salarial
        //Atravez desta ação torna impossivel ela ser instanciada sem informar estes dados
        public FuncionarioAutenticavel( double salario , string cpf ) : base ( salario , cpf )
        {
            
        
        }
        

        

    }
}
