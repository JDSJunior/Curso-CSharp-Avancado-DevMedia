using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsQueue
{
    class Correntista
    {
        public string Conta;
        public string Nome;
        public string Agencia;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Correntista c1 = new Correntista() { Conta = "123", Nome = "Dariana", Agencia = "123" };
            Correntista c2 = new Correntista() { Conta = "456", Nome = "José Júnior", Agencia = "456" };
            Correntista c3 = new Correntista() { Conta = "789", Nome = "Cinzinha", Agencia = "789" };

            //queue fila do tipo generics
            Queue<Correntista> fila = new Queue<Correntista>();

            //enqueue insere elemnetos na fila
            fila.Enqueue(c1);
            fila.Enqueue(c2);
            fila.Enqueue(c3);

            //varre uma lista
            foreach (var item in fila)
            {
                Console.WriteLine(item.Conta + " " + item .Nome);
            }

            //retorna um elemento da fila
            Console.WriteLine(fila.Peek().Nome);

            //remove os elementos
            while (fila.Count > 0)
            {
                Console.WriteLine("Pressione uma tecla para chamar um Correntista:");
                Console.ReadKey();
                Console.WriteLine("Chamando...:" + fila.Dequeue().Nome);
            }
            Console.ReadKey();
        }
    }
}
