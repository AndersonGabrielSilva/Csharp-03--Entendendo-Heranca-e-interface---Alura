using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerentedeConta : FuncionarioAutenticavel
    {
        //Neste construtor eu informo que está classe somente pode ser inicializada com os argumentos CPF e Base Salarial
        //Atravez desta ação torna impossivel ela ser instanciada sem informar estes dados
        public GerentedeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }

        //Neste metodo abaixo eu acabo definindo como sera a bonificação do funcionario
        //neste caso será 25% do salario
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
