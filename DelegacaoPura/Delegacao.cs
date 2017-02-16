using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegacaoPura
{
    class Boleto
    {
        public void Pagar(double _boleto)
        {
            Console.WriteLine("Pagando boleto: " + _boleto);
        }
    }

    class Pedido
    {
        //delegação quando passamos a tarefa da classe para outra classe fazer
        //chamamos o metodo da classe Boleto para fechar o pedido
        private Boleto _boleto = new Boleto();
        //delegação em private/oculta
        public void Fechar(double valor)
        {
            this._boleto.Pagar(valor);
        }
    }
}
