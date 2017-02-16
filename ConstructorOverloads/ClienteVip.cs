using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloads
{
    class ClienteVip : Cliente
    {
        private int tempo;
        public int Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

        public ClienteVip()
        {
            this.Nome = "Nome da classe de derivada";
            this.Id = 100;
            this.Tempo = 25;
        }

        //sobreescreve o construtor da classe base
        //para ser usado na base derivada
        //vai chamar o contrutor da classe da base
        //e adicionar 10 a o campo tempo da classe derivada
        //o construtor da classe base ja instancia o field Contato
        public ClienteVip(int _id) : base(_id) //construtor da classe base
        {
            this.Tempo = 10;
        }

    }
}
