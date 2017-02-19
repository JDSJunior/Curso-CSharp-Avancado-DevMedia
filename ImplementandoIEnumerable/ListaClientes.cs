using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoIEnumerable
{
    class ListaClientes : IEnumerable
    {
        private List<string> _clientes = new List<string>();
        private int _index = 0;

        public void Add(string str)
        {
            //adiciona dinamicamente mais elementos
            this._clientes.Add(str);
            this._index++;
        }




        //public IEnumerable<string> getClientes()
        //{
        //   //yield armazena o estado onde parou
        //   //para pular para o outro return
        //   yield return this._clientes[0];
        //   yield return this._clientes[1];
        //   yield return this._clientes[2];
        //   yield return this._clientes[3];
        //}

        //metodo da implementacao da interface IEnumerable
        //permite varer a classe com foreach diretamente
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _index; i++ )
                yield return this._clientes[i];
        }
    }
}
