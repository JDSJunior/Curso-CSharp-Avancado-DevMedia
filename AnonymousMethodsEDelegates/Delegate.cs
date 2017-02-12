using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsEDelegates
{
    //declaração do evento
    public delegate void PagarEvent(double valor);

    public class Pedido
    {
        //evento que dispara o metodo
        public event PagarEvent Pagar;

        //metodo que aponta para outro
        public void Fechar(double valor)
        {
            this.Pagar(valor);
        }
    }
}
