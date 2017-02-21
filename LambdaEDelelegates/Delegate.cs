using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEDelelegates
{

    //delegate/contrato do evento
    public delegate void PagarEvent(double valor);

    public class Boleto
    {
        //evento que dispara o metodo
        public event PagarEvent Pagar;

        //passando o evento como parametro
        public void Fechar(double valor)
        {
            this.Pagar(valor);
        }
    }
}