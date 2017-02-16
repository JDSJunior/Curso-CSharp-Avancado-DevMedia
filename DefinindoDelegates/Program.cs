using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinindoDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia da classe com o delegate
            Pedido boleto = new Pedido();
            //apontando o delegate para o metodo boleto_Pagar
            boleto.Pagar += boleto_Pagar;
            //chamando o delegate e passando o parametro para o delegate que passa
            //para o metodo
            boleto.Fechar(2000);

            Console.ReadKey();
        }

        //metodo que é apontado pelo delegate
        static void boleto_Pagar(double valor)
        {
            Console.WriteLine("Pagano o boleto: " + valor);
        }
    }
}
