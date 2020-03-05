using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
   public abstract class Funcionario
   {

        //Esse Atributo estatico serve para nos informar a quantidade de funcinarios
        //Ela contabiliza toda vez quando um objeto do Tipo Funcionario é Instanciada
        //Para isto criamos o Contrutor Funcionario na linha 20
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //Construtor
        public Funcionario(double salario ,string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }

        public abstract double GetBonificao();
        public abstract void AumentarSalario();

   }
}
