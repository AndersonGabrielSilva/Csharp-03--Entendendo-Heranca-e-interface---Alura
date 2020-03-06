using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
        public object SitemaInterno { get; private set; }

        static void Main(string[] args)
        {
            UsarSistema();
            //CalcularBonificação();
            Console.ReadKey();

        }


        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("428.137.298-65");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
                       
            GerentedeConta camila = new GerentedeConta("428.456.753-45");
            camila.Nome = "Camila";
            camila.Senha = "123456";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "5478";

            sistemaInterno.Logar(roberta, "456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "123456");
            sistemaInterno.Logar(parceiro, "5478");
        }

        //O metodo abaixo cria os objetos e faz o calculo da bonificação
        public static void CalcularBonificação()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Desenvolvedor guimerme = new Desenvolvedor("428.137.265-52");
            guimerme.Nome = "Guilherme";

            Desing pedro = new Desing("428.138.729-94");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("428.137.298-65");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("428.145.236-56");
            igor.Nome = "Igor";

            GerentedeConta camila = new GerentedeConta("428.456.753-45");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificação: " + gerenciadorBonificacao.GetTotalBonitficacao());
            
        }
    }
}
