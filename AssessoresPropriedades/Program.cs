using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessoresPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //bloco try tenta executar o bloco caso ocorra um erro
            //passa a executar o bloco cacth
            try
            {
                Aluno Al = new Aluno();

                Al.Matricula = -123;//<-----Erro
                Al.Nome = "Junior";
                Al.Tipo = Tipo.Regular;

                Console.WriteLine("Matricula: {0}.", Al.Matricula);
                Console.WriteLine("Nome: {0}.", Al.Nome);
                Console.WriteLine("Tipo: {0}.", Al.Tipo);
            }
            //o bloco catch recebe um objeto e do tipo ExcessaoPersonalizada
            catch(ExcessaoPersonalizada e)
            {
                //escreve na tela a string que foi setada na exception
                //na property
                Console.WriteLine(e.Message);
            }

            //devemos tratar varias excessoes para limitar o numero de erros
            //sendo sempre da mais especifica para a menos
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
