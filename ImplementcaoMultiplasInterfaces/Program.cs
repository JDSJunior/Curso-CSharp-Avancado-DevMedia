using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementcaoMultiplasInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Imagem foto = new Imagem() { Nome = "Praia" };
            foto.Ler();
            foto.Compactar();
            foto.Descompactar();
            foto.Armazenar();
            Console.WriteLine("--------------------------------------");
            Documento texto = new Documento() { Nome = "Relatório.txt" };
            texto.Ler();
            texto.Compactar();
            texto.Descompactar();
            texto.Armazenar();

            Console.ReadKey();
        }
    }
}
