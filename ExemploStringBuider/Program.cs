using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploStringBuider
{
    class Program
    {
        static void Main(string[] args)
        {
            //definindo a capacidade maxima do StringBuider 
            //mehlora de performance
            //pode ser inicializado pelo construtor da classe
            var sb = new StringBuilder("Teste 1",10);
            sb.Append("Teste");
            Console.WriteLine(sb);
            Console.ReadKey();
        }

        private static void Exemplo6()
        {
            var sb = new StringBuilder();
            sb.Append("asdfghjklçkdasdfgh");
            //remove uma quantdade de caracteres a partir de uma posição
            sb.Remove(5, 10);
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        private static void Exemplo5()
        {
            var sb = new StringBuilder();
            //usando ToUpper para deixar os caracteres em maiusculo
            sb.Append("asdfghjklçkdasdfgh".ToUpper());
            //retornando um caracter pelo seu indice
            Console.WriteLine(sb[2]);
            Console.ReadLine();
        }

        private static void Exemplo4()
        {
            var sb = new StringBuilder();
            //metodo Replace substitui a string desejada por outra definida
            sb.Append("Qualquer tolo pode escrever codigo que um computador possa entender. Bons programadores escrevem codugo que humanos podem entender. Martin Fowler");
            sb.Replace("codigo", "code");
            Console.WriteLine(sb);
            Console.ReadKey();
        }

        private static void Exemplo3()
        {
            var sb = new StringBuilder();
            //AppendLine escreve uma linha 
            sb.AppendLine("Primeira Linha");
            sb.Append("Segunda Linha");
            Console.WriteLine(sb);
            Console.ReadKey();
        }

        private static void Exemplo2()
        {
            //classe StringBuilder para manipulação de strings
            var sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i).Append("");
                Console.WriteLine(sb);
            }
        }

        private static void Exemplo1()
        {
            //usando strings imutavel
            var str = "";
            for (int i = 0; i < 100000; i++)
            {
                str = str + i.ToString();
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
