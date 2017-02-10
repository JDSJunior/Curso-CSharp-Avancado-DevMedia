using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Action encapsula um metodo
            //nao retorna valores(void)

            //quando chamamos o foreach da list clientes
            //podemos chamar o metodo diretamente ou encapsula-lo

            //Action<Cliente> mostrarAction new Action<Cliente>(Mostrar);
            Action<Cliente> mostrarAction = new Action<Cliente>(c => Console.WriteLine(c.Nome));
            //instanciando uma action do tipo lista clientes, atribuindo uma função lambda
            var jj = new Cliente() { Id = 01, Nome = "José Júnior" };
            var dn = new Cliente() { Id = 02, Nome = "Dariana Neumann" };
            var js = new Cliente() { Id = 03, Nome = "José da Silva" };
            var ln = new Cliente() { Id = 04, Nome = "Loreni Silva" };

            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(jj);
            clientes.Add(dn);
            clientes.Add(js);
            clientes.Add(ln);

            clientes.ForEach(mostrarAction);

            //metodo tradicional
            //foreach (var c in clientes)
            //{
            //    Console.WriteLine(c.Nome);
            //}

            Console.ReadKey();
        }

        //public static void Mostrar(Cliente c)
        //{
        //    Console.WriteLine(c.Nome);
        //}
    }
}
