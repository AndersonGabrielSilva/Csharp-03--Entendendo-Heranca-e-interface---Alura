using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_SobreCarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste testes = new Teste();

            testes.EscreveNumero(5);
            testes.EscreveNumero(5.0);
            testes.TestarSobrecarga(5,5);
            testes.TestarSobrecarga(5,5.0);
            testes.Teste2(1,2);
            //testes.Teste();
        }
    }
}
