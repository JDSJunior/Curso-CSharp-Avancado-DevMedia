using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo texto = new Txt() { Nome = "relatorio", Tamanho =  10};
            Arquivo mp3 = new Musica(){Nome = "Qualquer" , Tamanho = 20};
            Arquivo foto = new Imagen() { Nome = "ferias", Tamanho = 5};

            Windows windows = new Windows();
            //adiciona os arquivos na lista
            windows.Add(mp3);
            windows.Add(texto);
            windows.Add(foto);

            //abre todos os arquivos
            windows.AbrirTodos();

            Console.ReadKey();

        }
    }
}
