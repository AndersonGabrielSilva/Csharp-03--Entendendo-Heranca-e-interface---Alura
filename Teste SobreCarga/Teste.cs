using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_SobreCarga
{
    class Teste
    {
        public void EscreveNumero(int n)
        {
            Console.WriteLine("Inteiro: " + n);
        }

        public void EscreveNumero(double n)
        {
            Console.WriteLine("Ponto flutuante: " + n );
        }

        public void TestarSobrecarga(int a, int b)
        {
            Console.WriteLine("Testando Sobrecarga (Int, Int)");
        }

        public void TestarSobrecarga(double a, double b)
        {
            Console.WriteLine("Testando Sobrecarga (double, double)");
        }

        public void Teste2(double a, int b)
        {
            Console.WriteLine("Teste (double , int)");
        }

        public void Teste2(int a, double b)
        {
            Console.WriteLine("Teste (int , double)");
        }
    }
}
