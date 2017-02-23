using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogo cx = new CaixaDialogo();

            //chamada do metodo Show com seus varios overloads
            cx.Show("Ola mundo");
            cx.Show("Ola Mundo", 10);
            cx.Show("ola Mundo", 10, true);

            Console.ReadKey();
        }
    }
}
