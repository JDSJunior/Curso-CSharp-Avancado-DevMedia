using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAssesores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.setCliente("Junior");
            cliente.Depositar(1000);
            cliente.Saldo();

            Console.WriteLine(cliente.getCliente());
            cliente.Sacar(500);
            cliente.Saldo();

            Console.ReadLine();
        }
    }
}
