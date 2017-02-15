using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        //metodo chamado 
        //retorna um onjeto do tipo task
        public static Task<IEnumerable<int>> getNumerosPrimos(int min, int count)
        {
            return Task.Run(() =>Enumerable.Range(min, count).
                Where(num => Enumerable.Range(2, (int)Math.Sqrt(num) - 1).
                All(i => num % i > 0)));
        }
        static void Main(string[] args)
        {
            ImprimirNumerosPrimos();
            Console.ReadKey();
        }

        //metdo async
        private static async void ImprimirNumerosPrimos()
        {
            for (int i = 0; i < 10; i++)
            {
                //operação wait
                var resultado = await getNumerosPrimos(1 * 100000 + 1, i * 1000000);
                    resultado.ToList().ForEach(x => Console.WriteLine(x));
            }
            
        }
    }
}
