using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEDelelegates
{
    class Program
    {

        static void Main(string[] args)
        {
            Boleto bt = new Boleto();
            //expressão lambda passada para o evento que aponta para o metodo
            //o compilador identifica automaticamente o tipo do parametro
            bt.Pagar += valor => Console.WriteLine("Pagando boleto no valor: " + valor);
            bt.Fechar(5000);

            Console.ReadKey();
        }
    }
}
