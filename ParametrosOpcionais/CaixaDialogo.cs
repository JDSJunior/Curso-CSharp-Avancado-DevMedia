using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionais
{
    class CaixaDialogo
    {
        //passando um valor diretamente para o parametro
        //o compilador atribuira o valor caso seja omitido a parametro na chamada
        //do metodo
        //os parametros opcionais devem ser declarados depois de todos os 
        //parametros
        public void Show(string Mensagem, int Delay = 10)
        {
            Console.WriteLine(Mensagem);
        }
    }
}
