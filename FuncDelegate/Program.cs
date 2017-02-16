using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    public class Produto
    {
        public string Nome;
        public int Preço;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //funcion delegate recebe um metodo com retorno e tipo 
            //tambem é possivel usar como parametro uma expressao lambda
            Func<Produto, Produto> func = new Func<Produto, Produto>(Mostrar);
            
            List<Produto> Produtos = new List<Produto>() 
            {
                new Produto(){Nome = "SmartTv", Preço = 2000},
                new Produto(){Nome = "Celular", Preço = 200},
                new Produto(){Nome = "Sofá", Preço = 500},
                new Produto(){Nome = "Video Game", Preço = 800}
            };

            //metodo tradicional
            //foreach (var item in Produtos)
            //{
            //    Console.WriteLine(item.Nome);
            //}

            //foreach(Produto p in Produtos)
            //{
            //  if(Mostrar(p) != null
            //      Console.WriteLine(p.Nome);
            //}     

            //varrendo o delegate func com o metodo select
            foreach (var p in Produtos.Select(func))
                if (p != null)
                    Console.WriteLine(p.Nome);
            Console.ReadKey();
        }

        public static Produto Mostrar(Produto p)
        {
            if (p.Preço >= 400)

                return p;
            else
                return null;
        }
    }
}
