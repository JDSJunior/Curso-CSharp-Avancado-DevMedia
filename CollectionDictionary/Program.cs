using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basicamente uma combinação de List<T> com HashTable
            //Coleções tipadas com uso de Genererics;
            var pedidos = new Dictionary<int, Pedido>();
            Pedido p1 = new Pedido() { Codigo = 1, Nome = "Dariana", Valor = 1586.45 };
            Pedido p2 = new Pedido() { Codigo = 2, Nome = "Junior", Valor = 1523.65 };
            Pedido p3 = new Pedido() { Codigo = 3, Nome = "Cinzinha", Valor = 235.56 };

            //adicionando elementos no Dictionary<T> Key Value Pair
            pedidos.Add(001, p1);
            pedidos.Add(002, p2);
            pedidos.Add(003, p3);

            foreach (var item in pedidos.Values)
            {
                Console.WriteLine(item.Nome);
            }

            //mostrando as chaves e valores em um mesmo foreach
            foreach (KeyValuePair<int, Pedido> kvp in pedidos)
            {
                Console.WriteLine(kvp.Key + " = " + kvp.Value.Nome);
            }

            //somando os valores usando funcao lambda
            var soma = pedidos.Sum(p => p.Value.Valor);

            Console.WriteLine("Soma dos pedidos: " + soma.ToString());


        }
    }
}
