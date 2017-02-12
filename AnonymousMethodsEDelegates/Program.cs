using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsEDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe 
            Pedido pedido = new Pedido();
            //delegação que esta nesse caso atribuindo o metodo
            pedido.Pagar += delegate(double valor)
            //metodo anonimo
            {
                //assim nao precisa criar o metodo
                //o codigo só será executado aqui
                Console.WriteLine("Pagando boleto: " + valor);
            };
            //passando o parametro para o metodo
            pedido.Fechar(2000);

            Console.ReadKey();
        }
    }
}
