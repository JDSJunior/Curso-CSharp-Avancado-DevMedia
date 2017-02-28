using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//partial permite dividir uma classe em varios arquivos diferentes
public partial class ClientePartial
{
    //é possivel acessar os membros da classe que estão no outo arquivo
    public string Nome { get; set; }
}
