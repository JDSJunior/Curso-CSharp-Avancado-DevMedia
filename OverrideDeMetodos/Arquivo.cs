using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDeMetodos
{
    class Arquivo
    {
        //classe com metodo override que será sobreescrito nas classes derivadas
        //virtual para parametros completamente iguais
        //abstratc para parametros diferentes

        public string Nome;
        public int Tamanho;
        public virtual void Abrir()
        {   
            Console.WriteLine("Abrindo.....{0}", Nome);
        }

    }

    //classe que herda de arquivo e sobreescreve o metodo virtual
    class Musica : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine("Abrindo musica: " + Nome);
            Console.WriteLine("Tamanho da Musica: " + Tamanho +"MB");
        }
    }

    class Txt : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
        }
    }

    class Imagen : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine("imagem: " + Nome);
        }
    }

    class Windows
    {
        //lista de arquivos
        private List<Arquivo> _arquivo;
        public Windows()
        {
            _arquivo = new List<Arquivo>();
        }

        //adiciona arquivos na lista
        public void Add(Arquivo _item)
        {
            _arquivo.Add(_item);
        }

        //abre todos os arquivos
        //passando a lista como parametro
        public void AbrirTodos()
        {
            foreach(Arquivo arquivo in _arquivo)
            {
                Abrir(arquivo);
            }
        }

        //delegação
        // abre os arquivos individualmente
        public void Abrir(Arquivo arquivo)
        {
            //se o arquivo é Musica
            //if (arquivo is Musica)
            //passe arquivo como musica e use o metodo Abrir();
                //(arquivo as Musica).Abrir();
            //if (arquivo is Imagen)
                //(arquivo as Imagen).Abrir();
            //if (arquivo is Txt)
                //(arquivo as Txt).Abrir();

            //metodo da classe base
            arquivo.Abrir();
        }
    }
}
