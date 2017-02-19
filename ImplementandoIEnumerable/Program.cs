using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var clist = new ListaClientes();
            clist.Add("Bilbo");
            clist.Add("Júnior");
            clist.Add("Dariana");
            clist.Add("José");
            clist.Add("Loreni");

            //atraves da implementação podemos varrer diretamente na classe
            //usando um foreach
            foreach (var item in clist)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
