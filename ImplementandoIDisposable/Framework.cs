using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoIDisposable
{
    public class Conexao : IDisposable
    {
        //IDisposable interface que chama o metodo dispose
        //e limpa os recursos que estão sendo utilizados dentro da classe não 
        //sao gerenciados pelo Garbage Colector
        //resource unmanaged pelo GB
        public string Handle;

        public void Conectar()
        {
            //resouce Handle
            Handle = "Recurso Alocado";
            Console.WriteLine(Handle);
        }
        public void Dispose()
        {
            //chama o metodo dispose para liberar recursos
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void LiberarRecursos()
        {
            //libera os recursos
            Handle = String.Empty;
            Console.WriteLine("Recurso Liberado");
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                LiberarRecursos();
            }
        }
    }
}
