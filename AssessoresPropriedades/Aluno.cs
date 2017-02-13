using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessoresPropriedades
{
    public enum Tipo
    {
        Regular, Especial
    }

    //excessao personalizada herdada de Exeception
    //sobreescrevendo o construtor da classe base
    public class ExcessaoPersonalizada : Exception
    {
        public ExcessaoPersonalizada(string message) : base(message)
        {
         //pode-se personalizar as exeções   
        }
    }
    class Aluno
    {
        private int matricula;
        private string nome;
        private Tipo tipo;

        public int Matricula
        {
            get 
            { return matricula; }
            //validação na property
            set 
            {
                if (value < 0)
                {
                    //lança a execessao para o metodo main
                    //seta a string como mensagem da exception
                    throw new ExcessaoPersonalizada("O valor deve ser maior que 0");
                }
                else
                {
                    matricula = value;
                }
            }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


    }
}
