using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{

    //ULTILIZAÇÃO DO POLIMORFISMO
    class GerenciadorBonificacao
        /*Neste Classe vamos gerenciar o tortal de bonificacoes 
         * somando todas já processadas
         */
    {
        private double _totalBonificação;
        public void Registrar(Funcionario funcionario)
        {

            _totalBonificação += funcionario.GetBonificao();
        }

        public double GetTotalBonitficacao()
        {
            return _totalBonificação;
        }
    }
}
