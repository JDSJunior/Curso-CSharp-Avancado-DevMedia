using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosNomeados
{
    public class DialogoBad
    {
        //bad smell longer parameters list
        public void Show(string Mensagem, bool MostrarBotaoOk, bool MostarBotaoYes, bool MostarBotaoCancelpublic, int Delay)
        {
            Console.WriteLine(Mensagem);
        }
    }

    public class Dialogo
    {
        //usa uma instancia da classe com os parametros para o metodo
        public void Show(DialogoParams parameters)
        {
            Console.WriteLine(parameters.Mensagem);
        }
    }

    //encapsula os parametros para evitar o bad smell longer parameters list
    public class DialogoParams
    {
        public string Mensagem;
        public bool MostrarBotaoOk;
        public bool MostarBotaoYes;
        public bool MostarBotaoCancel;
        public int Delay;
        //assim é possivel adicionar e alterar parametros sem um efeito domino 
        //nas chamadas de metodo
        public int Modal;
    }
}
