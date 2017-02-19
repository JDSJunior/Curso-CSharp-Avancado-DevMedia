using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializadoreDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ator Dari = new Ator()
            {
                //passa os valores para as variaveis
                //sem a necessidade de desenvolver varios constrututores
                //na classe
                Codigo = 1,
                Nome = "Dariana Neumann",
                //inicia a variavel lista do tipo filme
                //dentro do proprio inicializador de objetos
                Filme = new List<Filme>()
                {   //inicializador de objetos aninhado
                    new Filme() {Nome = "Filme1", Ano = 2010},
                    new Filme() {Nome = "Filme2", Ano = 2015},
                }
     
            };

            //percorre a coleção de List<Filme>
            foreach (var item in Dari.Filme)
            {
                //percorre os campos Nome da coleção LisT<Filmes>
                Console.WriteLine(item.Nome);
            }
        }
    }
}
