using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloads
{
    class Contato
    {
        private string tipo;
        private string descricao;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Contato()
        {
            this.Tipo = "Nenhum";
            this.Descricao = "Nenhum";
        }

        public override string ToString()
        {
            //sobreescreve o metodo ToString() para retornar uma string
            //contendo os valores dos fields
           return "Tipo : " + this.tipo + "\nDescricao : " + this.descricao;
        }
    }
}
