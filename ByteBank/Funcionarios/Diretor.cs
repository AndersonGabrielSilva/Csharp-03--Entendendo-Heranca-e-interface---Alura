﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {                

        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }
        public override double GetBonificao()
        {
            //Com a palavra reservada "base" eu consigo acessar os atributos(membros) da classe base(PAI) 
            return Salario * 0.5;
        }
        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario *1.1;
            Salario *= 1.50;
        }

       

    }
}