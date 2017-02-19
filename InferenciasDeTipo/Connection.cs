using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciasDeTipo
{
    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando....");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando....");
        }
    }
}
