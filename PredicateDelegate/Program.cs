using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //predicate recebe um metodo que retorna um bool

            //lista de pessoas
            List<Pessoa> Nomes = new List<Pessoa>()
            {
                new Pessoa() { Nome = "José Júnior", Idade = 25},
                new Pessoa() { Nome = "Dariana Neumann", Idade = 23 },
                new Pessoa() { Nome = "José da Silva", Idade = 52 },
                new Pessoa() { Nome = "Loreni Silva", Idade = 50}
            };

            //predicato que recebe uma lista do tipo pessoa
            //recebe como parametro uma expressao lambda ou um metodo que retorna um bool
            Predicate<Pessoa> pred = new Predicate<Pessoa>(p => p.Idade >= 35);

            //inseri os valores do predicado na variavel pred
            var lst = Nomes.FindAll(pred);

            //percorre a variavel lst com um foreach
            foreach (var p in lst)
            {
                Console.WriteLine(p.Nome);
            }

            Console.ReadKey();
        }

        //public static bool Teste(Pessoa p)
        //{
        //    return p.Idade >= 35;
        //}
    }
}
