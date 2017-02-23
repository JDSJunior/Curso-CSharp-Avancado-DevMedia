using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDeMetodos
{
    class CaixaDialogo
    {
        //overload de metodo
        //varios metodos com o mesmo nome com parametros diferentes
        public void Show(string Mensagem)
        {
            Console.WriteLine(Mensagem);
        }

        public void Show(string Mensagem, int Delay)
        {

            //chamando um metodo sobrecarregado dentro de outro
            //evita a repetição de codigo

            //configuração do delay
            Show(Mensagem);
            //Console.WriteLine(Mensagem);
        }
        public void Show(string Mensagem, int Delay, bool BotaoOK)
        {
            //configuração do delay e BotaoOK
            Show(Mensagem, Delay);
            //Console.WriteLine(Mensagem);
        }

    }
}
