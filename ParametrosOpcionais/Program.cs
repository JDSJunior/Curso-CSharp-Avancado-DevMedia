using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaDialogo cx = new CaixaDialogo();
            //chamando o metodo e omitindo o parametro Delay que recebe
            //valor que foi atribuido na assinatura so metodo na classe base
            cx.Show("Ola mundo");
            Console.ReadKey();
        }
    }
}
