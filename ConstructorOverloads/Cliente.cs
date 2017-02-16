using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloads
{
    class Cliente
    {
        private int id;
        private string nome;
        private Contato contato;
        
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Contato Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        public Cliente()
        {
            //inicia os objetos do tipo da classe com valores
            //atribuidos
            this.Id = 0;
            this.Nome = "sem nome";

            //ao atribuir os valores dos objetos do tipo Contato
            //nao será necessario inicia-lo na classe program
            //porque está sendo iniciado no cronstrutor da classe
            this.Contato = new Contato();
        }

        public Cliente(int _id)
        {
            //construtor parametrizado com inicializacção do field ID
            this.Id = _id;

            this.Contato = new Contato();
        }

        public override string ToString()
        {
            //sobreescrevendo o metodo ToString()
            //usando um objeto StringBuilder para adicionar os 
            //valores dos fields para serem exibos
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id : " + this.id);
            sb.AppendLine("Nome :" + this.nome);

            //chama o metodo sobreescrito ToString da classe Contato
            sb.AppendLine(contato.ToString());

            //retorna os valores
            return sb.ToString();
        }
    }
}
