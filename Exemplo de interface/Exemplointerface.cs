using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_de_interface
{
    class Exemplointerface
    {

        public abstract class Casa 
        {
            public abstract void AbrirPorta();
        }

        public interface Carro
        {
            void AbrirPorta();
        }

        public class Exemplo : Casa, Carro
        {

            public override void AbrirPorta()
            {
                throw new NotImplementedException();
            }
        }

    }
}
