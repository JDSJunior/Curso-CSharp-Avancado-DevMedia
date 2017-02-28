using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    class Program
    {
        static void Main(string[] args)
        {
            Dialogo dg1 = new Dialogo();
            //metodo tradicional de passar parametros como variaveis
            //string mensagem = "Confirmar Operação?";
            //bool mostrarbotaook = true;
            //bool mostrarbotaoyes = true;
            //bool mostrarbotaocancel = false;
            //int delay = 10;
            //dg1.Show(mensagem, mostrarbotaook, mostrarbotaoyes, mostrarbotaocancel, delay);

            //passando parametros nomeados sem nescessidade de passar na ordem
            //dg1.Show(Mensagem: "Confirmar Operação?", MostrarBotaoOk: true, MostarBotaoYes: true, MostrarBotaoCancel: false, Delay: 10);

            //cria uma instancia da classe que contem os parametros encapsulados 
            //para passar na chamada do metodo
            var parametros = new DialogoParams()
            {
                Mensagem = "Confirmar Operação?",
                MostrarBotaoOk = true,
                MostarBotaoYes = true,
                MostarBotaoCancel = false,
                Delay = 10
            };
            dg1.Show(parameters: parametros);

            Console.ReadKey();
        }
    }
}
