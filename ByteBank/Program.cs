using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aqui eu informo aonde e´tá minha classe Funcionario
//using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario anderson = new Funcionario();

            anderson.Nome = "Anderson Gabriel";
            anderson.CPF = "427.135.296.56";
            anderson.Salario = 800;

            gerenciador.Registrar(anderson);

            Console.WriteLine(anderson.Nome);
            Console.WriteLine(anderson.GetBonificao());

            Diretor lucas = new Diretor();
            lucas.Nome = "Lucas souza";
            lucas.CPF = "428.745.169.96";
            lucas.Salario = 10000;

            gerenciador.Registrar(lucas);


            Console.WriteLine(lucas.Nome);
            Console.WriteLine(lucas.GetBonificao());

            Console.WriteLine("Total de bonificaçoes: " + gerenciador.GetTotalBonitficacao());

            Console.ReadKey();

        }
    }
}
