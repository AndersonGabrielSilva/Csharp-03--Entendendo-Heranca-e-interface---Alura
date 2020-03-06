using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    //Com está interface falo que todos os objetos que a ultilizar
    //Será necessario implementar este metodo de Autenticar, para validar as senhas
    
    /*
     * Atravez desta interface é possivel permitir o acesso sem ultilizar a repetição de codigo
     * de Usuarios do tipo Funcionarios e de Usuarios que não sejam tambem funcionarios
     * como por parte de cliente de clintes externos.
     */

    /* 
     */
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);                     

    }
}
