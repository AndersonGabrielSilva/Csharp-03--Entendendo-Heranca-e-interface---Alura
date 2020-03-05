using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerentedeConta : Autenticavel
    {

        public GerentedeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }
        public override double GetBonificao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {           
            Salario *= 1.05;
        }

    }
}
