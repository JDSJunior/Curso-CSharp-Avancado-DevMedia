using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionListT
{
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public string CPF;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente() { Codigo = 01, Nome = "Dariana", CPF = "123" };
            Cliente c2 = new Cliente() { Codigo = 02, Nome = "Junior", CPF = "456" };
            Cliente c3 = new Cliente() { Codigo = 03, Nome = "Cinzinha", CPF = "789" };
            Cliente c4 = new Cliente() { Codigo = 04, Nome = "Bilbo", CPF = "111" };
            Cliente c5 = new Cliente() { Codigo = 05, Nome = "Luna", CPF = "222" };

            //lista com tipo estatico
            List<Cliente> cli = new List<Cliente>();
            cli.Add(c1);
            cli.Add(c2);
            cli.Add(c3);
            cli.Add(c4);
            cli.Add(c5);
            
            //nao retorna object
            //retorna o tipo especifico da lista 
            foreach (var item in cli)
            {
                Console.WriteLine(item.Nome);
            }

            //extraindo elemento
            //metodo auxiliar da lista que aceita expressoes lamba
            var cl = cli.FirstOrDefault(c => c.CPF == "789");

            //usando LINK
            var qry = from c in cli where c.CPF == "111" select c;
            //varrendo colecao extraida com link
            foreach (var item in qry)
            {
                Console.WriteLine(item.Nome);   
            }

            Console.WriteLine(cl.Nome);

            Console.ReadKey();
        }
    }
}
