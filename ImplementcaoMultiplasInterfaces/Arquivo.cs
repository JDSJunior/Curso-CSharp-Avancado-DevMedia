using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementcaoMultiplasInterfaces
{
    public class Arquivo
    {
        //classe mae
        public string Nome { get; set; }
    }

    public class Imagem : Arquivo
    {
        //classe que herda de arquivo
        //variavel que implementa a interface 
        //a implementacao multipla permita de interfaces permite injetar metodos de outras classes
        //na classe Imagem atraves da delegação
        private Armazenador _armazenador = new Armazenador();
        private Compactador _compactador = new Compactador();

        public void Ler()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe
            this._armazenador.Ler(Nome);
        }

        public void Armazenar()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe

            this._armazenador.Escrever(Nome);
        }

        public void Compactar()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe

            this._compactador.Compactar(Nome);
        }

        public void Descompactar()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe

            this._compactador.Descompactar(Nome);
        }

    }

    public class Documento : Arquivo
    {
        //classe que herda de arquivo
        //variavel que implementa a interface
        //a implementacao multipla permita de interfaces permite injetar metodos de outras classes
        //na classe Documento atraves da delegação
        private Armazenador _armazenador = new Armazenador();
        private Compactador _compactador = new Compactador();

        public void Ler()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe
            this._armazenador.Ler(Nome);
        }

        public void Armazenar()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe
            this._armazenador.Escrever(Nome);
        }

        public void Compactar()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe
            this._compactador.Compactar(Nome);
        }

        public void Descompactar()
        {
            //DELEGAÇÃO
            //metodo que utiliza a implementaçao para chamar o metodo de outra classe
            this._compactador.Descompactar(Nome);
        }
    }
}
