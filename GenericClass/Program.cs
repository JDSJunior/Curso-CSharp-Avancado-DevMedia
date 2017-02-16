using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando o tipo como parametro
            var p1 = new Pilha<string>();
            p1.Push("Jose Junior");
            p1.Push("Dariana Neumann");

            var p2 = new Pilha<int>();
            p2.Push(123);
            p2.Push(456);

            //usando listas do tipo objeto para listas genericas usando o tipo object
            //podemos adicionar qualquer tipo d objeto na lista 
            //mas para retiar devemos usar o mesmo tipo que está dentro da lista
            var p3 = new Pilha<Cliente>();
            p3.Push(new Cliente(){Cod = 1, Nome = "José Junior"});
            p3.Push(new Cliente(){Cod = 2, Nome = "Dariana Neumann"});
            //temos que fazer um typecast para retiarar os objetos
            //Cliente pessoa = (Cliente)p3.Pop();
            Cliente pessoa = p3.Pop();

            Console.ReadKey();

        }
    }
}
