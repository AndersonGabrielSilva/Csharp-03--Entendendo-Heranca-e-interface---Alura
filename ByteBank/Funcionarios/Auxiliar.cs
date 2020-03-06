using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {

        //Neste construtor eu informo que está classe somente pode ser inicializada com os argumentos CPF e Base Salarial
        //Atravez desta ação torna impossivel ela ser instanciada sem informar estes dados
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }


        //Neste metodo abaixo eu acabo definindo como sera a bonificação do funcionario
        //neste caso será 20% do salario
        public override double GetBonificao()
        {            
            return Salario * 0.20;
        }


        //No metodo a seguir é realizado o aumento de salario do funcionario
        //neste exemplo o aumento foi de 10% do salario
        public override void AumentarSalario()
        {            
            Salario *= 1.10;
        }        
    }
}
