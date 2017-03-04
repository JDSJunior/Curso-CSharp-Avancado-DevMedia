using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesIndexadas
{
    class Produtos
    {
        private List<string> itens;

        public Produtos()
        {
            //construtor que inicializa a lista
            this.itens = new List<string>();
        }

        //metodo que adiciona um valor a lista
        public void Add(string iten)
        {
            this.itens.Add(iten);
        }

        //retorna um valor usando o metodo get da lista
        public string Get(int index)
        {
            return this.itens[index];
        }


        //propriedade indexada
        public string this[int index]
        {
            //usando o get para retornar os valores pelo indice
            get
            {
                //pode ser usado o metodo get
                //return this.Get(index);
                return this.itens[index];
            }

            //pode ser implementado o set também
            //set { };
        }
    }
}
