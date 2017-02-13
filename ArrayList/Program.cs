using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //array aceita todo tipo de variavel
            //usa boxing para armazenamento
            //transformando os elemento em object
            var familia = new ArrayList();
            familia.Add("dariana");
            familia.Add("junior");
            familia.Add(100);
            StringBuilder sb = new StringBuilder();
            familia.Add(sb.GetType());

            foreach (var item in familia)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(familia[1]);

            Console.WriteLine("Capacidade " + familia.Capacity);
            Console.WriteLine("Count " + familia.Count);
            
            Console.ReadLine();

        }
    }
}
