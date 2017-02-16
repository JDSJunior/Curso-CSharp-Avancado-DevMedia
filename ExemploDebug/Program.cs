using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            //classe que escreve log 
            TextWriterTraceListener trl1 = new TextWriterTraceListener("debug_app_log.txt");

            //lista os itens no debug
            Debug.Listeners.Add(trl1);
            TextWriterTraceListener trl2 = new TextWriterTraceListener(Console.Out);
            Debug.Listeners.Add(trl2);

            string NomeProduto = "Ipad";
            int Quantidade = 200;
            double Preco = 1500;

            //escreve as informaçõe no debug
            Debug.WriteLine("Testando o objeto Debug");
            Debug.WriteLine("Produto : " + NomeProduto);
            Debug.WriteLine("Quantidade :" + Quantidade);
            Debug.WriteLine("Preço: " + Preco);
            Debug.WriteLineIf(Preco > 1000, "Debug - Preço maior que 1000");
            Debug.Assert(Quantidade > 300);
            //como um commmit
            Debug.Flush();
            Console.ReadLine();

        }
    }
}
