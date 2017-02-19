using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializadoreDeObjetos
{
    class Ator
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        //lista de filmes que o ator participou
        public List<Filme> Filme { get; set; }
    }
}
