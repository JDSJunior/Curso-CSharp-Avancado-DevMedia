using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHashTable
{
    class Aluno
    {
        public int Matricula;
        public string Nome;

        //metodo ToString() sobreescrito para retornar 
        //os valores dos elementos
        public override string ToString()
        {
            return Matricula.ToString() + ":" + Nome;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //HashTable coleção que segue o conceito de tabela
            //armazena os elementos com chave e valor
            Aluno a1 = new Aluno() { Matricula = 1, Nome = "Junior" };
            Aluno a2 = new Aluno() { Matricula = 2, Nome = "Dariana" };

            var lista = new Hashtable();
            //para adicionar os elementos 
            //adicionamos as chaves que podem de qualquer tipo
            //contanto que nao repitam
            //os elementos armazenados sao convertidos em object
            lista.Add(1, a1);
            lista.Add(2, a2);
            
            //para extrair-mos os valores temos que 
            //selecioanar a chave do elemento
            //e fazer type casting 
            Console.WriteLine((lista[1] as Aluno).Nome);
            Console.WriteLine((lista[2] as Aluno).Nome);

            foreach (var item in lista.Values)
            {
                //como é tipo referencia mostra o nome da classe
                //metodo ToString() sobreescrito para mostra os retornar os valores
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
