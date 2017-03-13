using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef_2
{
    public class Cliente
    {
        private int codigo;
        private string nome;
        private string telefone;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value;  }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        //sobrescrevendo o metodo ToString() da classe object
        //para imprimir os dados da classe
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + this.Codigo.ToString());
            sb.AppendLine("Nome: " + this.Nome);
            sb.AppendLine("Telefone: " + this.Telefone);

            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ImprimeTypeValue();

            ImprimeTypeReference();

            ApontaParaMesmaPosicao();
        }

        private static void ApontaParaMesmaPosicao()
        {
            Cliente c1 = new Cliente();
            Cliente c2 = new Cliente();

            //aponta para a mesma posiçao de memoria
            c2 = c1;

            //compara os tipos de objetos
            if (c2.Equals(c1))
            {
                Console.WriteLine("Objetos Iguais");
            }
            else
            {
                Console.WriteLine("Objetos Diferentes");
            }

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.ReadKey();
        }

        private static void ImprimeTypeReference()
        {
            Cliente c = new Cliente();

            //type reference imprime o namespace e o nome do objeto

            Console.WriteLine(c);

            c.Codigo = 132;
            c.Nome = "junior";
            c.Telefone = "99999999";

            Console.WriteLine(c.Codigo);
            Console.WriteLine(c.Nome);
            Console.WriteLine(c.Telefone);

            Console.WriteLine(c);

            Console.ReadKey();
        }

        private static void ImprimeTypeValue()
        {
            int x = 10;
            string s = "junior";
            bool b = true;

            //type valor imprime o valor atribuido em cada variavel
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
