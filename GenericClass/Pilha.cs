using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    //pilha do tipo object
    //public class Pilha
    //{
    //    int pos = 0;
    //    Object[] itens = new Object[100];
    //    public void Push(Object item)
    //    {
    //        itens[pos] = item;
    //        pos++;
    //    }

    //    public Object Pop()
    //    {
    //        pos--;
    //        return itens[pos];
    //    }
    //}


    //classe generica que recebe um tipo como parametro
    public class Pilha<T>
    {
        int pos = 0;
        T[] itens = new T[100];
        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }
        public T Pop()
        {
            pos--;
            return itens[pos];
        }
    }
    public class Cliente
    {
        public int Cod;
        public string Nome;
    }
}
