using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinindoDelegates
{
   //declaração do delegate/contrato
   public delegate void PagarEvent(double valor);

    //classe que implementa o delegate
   public class Pedido
   {
       //implementação do delegate
       public event PagarEvent Pagar;

       //delegate que aponta para um metodo
       public void Fechar(double valor)
       {
           //delegação
           this.Pagar(valor);
       }
   }
}
