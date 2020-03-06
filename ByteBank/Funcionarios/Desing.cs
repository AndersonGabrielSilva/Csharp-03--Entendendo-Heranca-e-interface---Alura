using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Desing : Funcionario
    {
        //Neste construtor eu informo que está classe somente pode ser inicializada com os argumentos CPF e Base Salarial
        //Atravez desta ação torna impossivel ela ser instanciada sem informar estes dados
        public Desing(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando DESING");

        }


        //Neste metodo abaixo eu acabo definindo como sera a bonificação do funcionario
        //neste caso será 17% do salario
        public override double GetBonificao()
        {           
            return Salario * 0.17;
        }


        //No metodo a seguir é realizado o aumento de salario do funcionario
        //neste exemplo o aumento foi de 11% do salario
        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario *1.1;
            Salario *= 1.11;

        }
    }
}
