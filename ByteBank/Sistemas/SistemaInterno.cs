using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        //Neste Metodo é feito a Autenticacao da senha, recebendo a senha inserida pelo usuario 
        //Verificando se é a mesma senha que está dentro do funcionario/Parceito comercial
        public bool Logar(IAutenticavel funcionario, string senha)
        {

            //Recebe a senha e verifica com a senha dentro do objeto do funcionario se é a mesma
            //e com isto retorna true e false
            bool UsuarioAutenticado = funcionario.Autenticar (senha);

            if (UsuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }

        }
    }
}
