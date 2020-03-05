using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Desing : Funcionario
    {

        public Desing(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }
        public override double GetBonificao()
        {           
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario *1.1;
            Salario *= 1.11;

        }

    }
}
