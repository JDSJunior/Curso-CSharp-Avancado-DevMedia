using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciasDeTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = new Connection() { ConnectionString = "Banco" };
            con.Conectar();
            con.Fechar();

            //define o tipo da variavel estaticamente em tempo de compilação
            var con2 = new Connection() { ConnectionString = "Banco" };
            con2.Conectar();
            con2.Fechar();

            //define o tipo da variavel dinamicamente em de execução
            //o compilador não verefica atributos e métodos do objeto dinamicos
            dynamic con3 = new Connection();
            //con3.XXXXXX = 10; o compilador na verifica se existe realmente o campo
            con3.Conectar();
            con3.Fechar();

            var con4 = Fabrica.CriarConnection();
            con4.Conectar();
            con4.Fechar(); 

            Console.ReadKey();
        }
    }
}
