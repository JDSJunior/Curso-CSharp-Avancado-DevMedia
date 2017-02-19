using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciasDeTipo
{
    //fabrica de connection
    public static class Fabrica
    {
        //cria a connection
        public static Connection CriarConnection()
        {
            //retorna um objeto connection
            return new Connection();
        }
    }
}
