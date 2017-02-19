using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementcaoMultiplasInterfaces
{
    //interface de armazenamento
    interface IArmazenavel
    {
        void Escrever(string nome);
        void Ler(string nome);
    }

    //interface de compactacao
    interface ICompactavel
    {
        void Compactar(string nome);
        void Descompactar(string nome);
    }

    public class Armazenador: IArmazenavel
    {
        //classe que implementa a interface de armazenamento
        public void Escrever(string nome)
        {
            Console.WriteLine("Armazenando..." + nome);
        }

        public void Ler(string nome)
        {
            Console.WriteLine("Lendo..." + nome);
        }
    }

    public class Compactador : ICompactavel
    {
        //classe que implementa interface de compactacao
        public void Compactar(string nome)
        {
            Console.WriteLine("Compactando..." + nome);
        }

        public void Descompactar(string nome)
        {
            Console.WriteLine("Descompactando..." + nome);
        }
    }
}
