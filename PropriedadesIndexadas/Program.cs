using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos prod = new Produtos();

            //adicionando valores a lista
            prod.Add("Celular");
            prod.Add("Tablet");
            prod.Add("SmartPhone");

            //obtendo os valores atraves do metodo get da List
            Console.WriteLine(prod.Get(0));
            Console.WriteLine(prod.Get(1));
            Console.WriteLine(prod.Get(2));

            //obtendo os elementos da lista atraves da propriedade indexada
            Console.WriteLine(prod[0]);
            Console.WriteLine(prod[1]);
            Console.WriteLine(prod[2]);

            Console.ReadKey();
        }
    }
}
