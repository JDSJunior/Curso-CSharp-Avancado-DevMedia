using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegacaoPura
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            //delegação
            //chama o metodo fechar que usa o metodo pagar da classe boleto
            pedido.Fechar(1000);

            Console.ReadKey();
        }
    }
}
