using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando a palavra reservada partial podemos dividir uma classe em varios 
            //arquivos diferentes e usa-la como se fosse u unico arquivo
            var Me = new ClientePartial();
            Me.ID = 100;            //1° parte da classe localizada no 1 arquivo
            Me.Nome = "Junior";     //2° parte da classe localizada no 2 arquivo
            Me.EnviarNotificação(); //3° parte da classe localizada no 3 arquivo
        }
    }
}
