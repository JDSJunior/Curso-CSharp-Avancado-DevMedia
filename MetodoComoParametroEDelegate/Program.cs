using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoComoParametroEDelegate
{
    class Program
    {
        //metodo que ira ser passado como parametro
        public static void Pagar(double valor)
        {
            Console.WriteLine("Pagando boleto no valor: " + valor);
        }
        static void Main(string[] args)
        {
            Boleto bt = new Boleto() { valor = 1500 };
            //chamada do evento que recebe o metodo que será 
            //executado
            bt.Fechar(Pagar);

            Console.ReadKey();
        }
    }
}
