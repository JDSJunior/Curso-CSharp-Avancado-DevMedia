using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexao
{
    class Program
    {
        //reflexao
        //obter informações da classe em runtime
        static void Main(string[] args)
        {
            Type t = typeof(Carro);
            getParametros(t);
            

            Console.ReadKey();
        }
        //varrendo os parametros dos metodos
        private static void getParametros(Type t)
        {
            Console.WriteLine("Parametros");
            MethodInfo[] mi = t.GetMethods();
            foreach (var item in mi)
            {
                string resulatdo = item.ReturnType.FullName;
                StringBuilder str = new StringBuilder();
                foreach (ParameterInfo pi in item.GetParameters())
                {
                    str.AppendLine(string.Format("{0} {1}", pi.ParameterType, pi.Name));

                }
                Console.WriteLine("{0} {1} {2}", resulatdo, item.Name, str);
            }
        }

        //varrendo interfaces
        private static void getInterfaces(Type t)
        {
            Console.WriteLine("Interface");
            Type[] intfs = t.GetInterfaces();
            foreach (var item in intfs)
            {
                Console.WriteLine(item.Name);
            }
               
        }
        //varrendo properties
        private static void getPropriedades(Type t)
        {
            Console.WriteLine("Propriedades");
            PropertyInfo[] pr = t.GetProperties();
            foreach (var item in pr)
            {
                Console.WriteLine(item.Name);
            }
        }
        //varrendo campos
        private static void getCampos(Type t)
        {
            Console.WriteLine("Campos");
            FieldInfo[] cp = t.GetFields();
            foreach (var item in cp)
            {
                Console.WriteLine(item.Name);
            }
        }

        //retornando metodos
        private static void getMethodos(Type t)
        {
            Console.WriteLine("Metodos:");
            //parametros para filtragem dos resultados
            MethodInfo[] metodos = t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.CreateInstance | BindingFlags.Public);
                foreach (var item in metodos)
                {
                    Console.WriteLine(item.Name);
                }
        }

        //retornando um metodo pelo nome
        private static void getMethodo(Type t)
        {
            Console.WriteLine("Metodo:");
            MethodInfo metodo = t.GetMethod("estaMovendo");
            Console.WriteLine(metodo.Name);
        }

        private static void getPropriedade(Type t)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Informações do tipo" + t.Name);
            str.AppendLine("Nome completo: " + t.FullName);
            str.AppendLine("Namespace: " + t.Name);
            Type tbase = t.BaseType;
            if (tbase != null)
            {
                str.AppendLine("Tipo base: " + t.BaseType.Name);
            }
            MemberInfo[] membros = t.GetMembers();
            foreach (var m in membros)
            {
                str.AppendLine(m.MemberType + " " + m.Name);
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }

        private static void Exemplo3()
        {
            Type t = typeof(Carro);
            Console.WriteLine(t.FullName);
            Console.ReadKey();
        }

        private static void Exemplo2()
        {
            Carro c = new Carro();
            Type t = c.GetType();
            Console.WriteLine(t.FullName);
        }
        private static void Exemplo1()
        {
            Type t = Type.GetType("Reflexao.Carro", false, true);
            Console.WriteLine(t.FullName);
            Console.ReadKey();
        }
    }
}
