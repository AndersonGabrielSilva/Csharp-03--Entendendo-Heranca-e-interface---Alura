﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {

            bool UsuarioAutenticado = funcionario.Autenticar (senha);

            if (UsuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }

        }
    }
}
