using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ImplementandoIDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //quando sair do bloco using o metodo
            //dispose é chamado para liberação de recursos
            using(var con = new Conexao())
            {
                con.Conectar();
            }



            Console.ReadKey();
        }
        private static void TesteSqlConection()
        {
            var con = new SqlConnection();

            try
            {
                //...
            }
            finally
            {
                if(con != null)
                con.Dispose();
            }
        }
    }
}
