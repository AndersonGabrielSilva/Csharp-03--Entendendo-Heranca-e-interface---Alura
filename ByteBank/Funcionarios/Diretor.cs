using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        //Neste construtor eu informo que está classe somente pode ser inicializada com os argumentos CPF e Base Salarial
        //Atravez desta ação torna impossivel ela ser instanciada sem informar estes dados
        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }


        //Neste metodo abaixo eu acabo definindo como sera a bonificação do funcionario
        //neste caso será 50% do salario
        public override double GetBonificao()
        {
            //Com a palavra reservada "base" eu consigo acessar os atributos(membros) da classe base(PAI) 
            return Salario * 0.5;
        }


        //No metodo a seguir é realizado o aumento de salario do funcionario
        //neste exemplo o aumento foi de 50% do salario
        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario *1.1;
            Salario *= 1.50;
        }    
    }
}