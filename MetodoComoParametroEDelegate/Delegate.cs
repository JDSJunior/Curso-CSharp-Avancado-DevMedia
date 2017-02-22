using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoComoParametroEDelegate
{
    //delegate 
    public delegate void PagarEvent(double valor);

    public class Boleto
    {
        //campo para inserção do valor no metodo
        public double valor;

        //metodo que aponta para o evento
        //recebe um delegate como parametro
        public void Fechar(PagarEvent Pagar)
        {
            Pagar(valor);
        }
    }
}
