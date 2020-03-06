using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {

        //Neste construtor eu informo que está classe somente pode ser inicializada com os argumentos CPF e Base Salarial
        //Atravez desta ação torna impossivel ela ser instanciada sem informar estes dados
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {

        }


        //No metodo a seguir é realizado o aumento de salario do funcionario
        //neste exemplo o aumento foi de 15% do salario
        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }


        //Neste metodo abaixo eu acabo definindo como sera a bonificação do funcionario
        //neste caso será 10% do salario
        public override double GetBonificao()
        {
            return Salario *= 0.1;
        }
    }
}