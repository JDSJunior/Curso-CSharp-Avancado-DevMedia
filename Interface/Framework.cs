using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IDBConect
    {
        //interface 
        void Open();
        void Close();

    }

    //implementacao da interface
    //a classe abstrata é obrigada a ter todos os metodo da interface
    public abstract class DBConnect : IDBConect
    {
        public string ConnectionString { get; set; }
        
        public virtual void Open()
        {
            Console.WriteLine("Conectando......");
            Console.WriteLine("Conectado a:" + ConnectionString);
        }

        public virtual void Close()
        {
            Console.WriteLine("Conexao Fechada");
        }
    }

    public class SQLConnect : DBConnect
    {
        //classe que herda da classe que implementa a interface
        //usando override para sobre escrever os dados
        //usando .base para chamar os metodos da classe mae

        public override void Open()
        {
 	         base.Open();
        }
        public override void Close()
        {
 	         base.Close();
        }
    }

    public class OracleConnetion : DBConnect
    {

        public override void Open()
        {
            base.Open();
        }

        public override void Close()
        {
            base.Close();
        }
    }
}
