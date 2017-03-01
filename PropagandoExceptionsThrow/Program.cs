using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropagandoExceptionsThrow
{
    //sem o tratamento da exceção ela percorreia toda a cadeia de chamada(StackTrace) até
    //o metodo main ou outro metodo que a tratase
    class Program
    {
        private static void Estagiario(string tarefa)
        {
            Convert.ToDateTime(tarefa);
        }
        private static void Programador(string tarefa)
        {
            try
            {
                Estagiario(tarefa);
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocorreu um erro: " + E.Message);
                //com a palavra throw pode re-levantar a exceção ou criar outra
                //para que os metodos que fizeram a chamada na StackTrace a tratem
                throw new Exception("Ocorreu um erro, mas o metodo programador o tratou");
            }
        }
        private static void Arquiteto(string tarefa)
        {
            Programador(tarefa);
        }

        private static void Coordenador(string tarefa)
        {
            Arquiteto(tarefa);
        }
        private static void Gerente(string tarefa)
        {
            try
            {
                Coordenador(tarefa);
            }
            catch (Exception E)
            {
                //metodo Gerente trata a nova execeção criada no metodo programador
                //exibi a mensagem
                Console.WriteLine(E.Message);
            }
        }
        static void Main(string[] args)
        {

            string data = "99/99/9999";
            Gerente(data);

            Console.ReadKey();
        }
    }
}
