using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleção para empilhar objetos
            //PUSH - Adiciona Elemento
            //POP - Le e retira elemento
            //PEEK - Le mas nao retira elemento
            var Pilha = new Stack<Pedido>();

            var p1 = new Pedido() { Codigo = 1, Nome = "Dariana", Valor = 4556.23 };
            var p2 = new Pedido() { Codigo = 2, Nome = "Junior", Valor = 9898 };
            var p3 = new Pedido() { Codigo = 3, Nome = "Cinzinha", Valor = 45.9 };

            //adiciona elementos na pilha
            Pilha.Push(p1);
            Pilha.Push(p2);
            Pilha.Push(p3);

            //varrendo uma pilha 
            while (Pilha.Count > 0)
            {
                Console.WriteLine(Pilha.Pop().Nome);
            }

            //numero de elementos na pilha
            Console.WriteLine(Pilha.Count);

            //retira um elemento do topo da pilha
            var objeto1 = Pilha.Pop();
            //unboxing
            Console.WriteLine((objeto1 as Pedido).Nome);

            //retira um elemento do topo da pilha
            var objeto2 = Pilha.Pop();
            Console.WriteLine((objeto2 as Pedido).Nome);

            //apenas le o elemento do topo da pilha
            var objeto3 = Pilha.Peek();
            Console.WriteLine((objeto3 as Pedido).Nome);



            Console.WriteLine(Pilha.Count);
        }
    }
}
