using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflexaoExemplo2
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public Cliente(string nome)
        {
            this._nome = nome;
        }
        public void Imprimir(string titulo)
        {
            Console.WriteLine(titulo + _nome);
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Type t = Type.GetType("ReflexaoExemplo2.Cliente");
            //invocando um construtor sem parametros
            //ConstructorInfo ctor = t.GetConstructor(Type.EmptyTypes);

                                                    //array de parametros do tipo string
            ConstructorInfo ctor = t.GetConstructor(new Type[] { typeof(string) });
            //invocando o contrutor e passando o parametro
            var obj = ctor.Invoke(new object[] { "José Júnior" });

            //chamando o metodo pelo nome
            MethodInfo mi = t.GetMethod("Imprimir");
            //passando o parametro para o metodo
            mi.Invoke(obj, new Object[] { "Sr. " });

            Console.ReadKey();
        }
    }
}
