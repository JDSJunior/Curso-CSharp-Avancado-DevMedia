using GenericsQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypeCasting
{
    class Program
    {
        //metodo que aceita um objeto do tipo pessoa
        public static void Imprimir(Pessoa pessoa)
        {
            //teste q verifica o tipo de pessoa
            //pessoa é PessoaFisica
            if (pessoa is PessoaFisica)
            {
                //converte o objeto pessoa em PessoaFisica
                Console.WriteLine((pessoa as PessoaFisica).Nome);
                Console.WriteLine((pessoa as PessoaFisica).CPF);
            }
            //teste q verifica o tipo pessoa
            //pessoa é PessoaJuridica
            if (pessoa is PessoaJuridica)
            {
                //converte o objeto pessoa em PessoaJuridica
                Console.WriteLine((pessoa as PessoaJuridica).Nome);
                Console.WriteLine((pessoa as PessoaJuridica).CNPJ);
            }
        }
        static void Main(string[] args)
        {
            PessoaJuridica pj = new PessoaJuridica() { Nome = "Dariana", CNPJ = "123" };
            PessoaFisica pf = new PessoaFisica() { Nome = "Júnior", CPF = "456" };

            Imprimir(pf);
            Imprimir(pj);

            Console.ReadKey();
        }
    }
}
