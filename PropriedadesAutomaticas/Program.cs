using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesAutomaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            
            f.Codigo = 123;
            f.Nome = "junior";
            f.Salario = 10000;
        }
    }
}
