using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAssesores
{
    class Cliente
    {
        private string _cliente;
        private double _valor;

        //metodo tradicional de acesso aos fields
        public string getCliente()
        {
            return this._cliente;
        }
        public void setCliente(string cliente)
        {
            this._cliente = cliente;
        }
        public void Sacar(double saque)
        {
            //operador de atribuição decremental
            //this._valor -= saque;

            this._valor = this._valor - saque;
        }
        public void Depositar(double deposito)
        {
            //operador de atribuicao incremental
            //this._valor += deposito;
            this._valor = this._valor + deposito;
        }
        public void Saldo()
        {
            Console.WriteLine(this._valor);
        }
    }
}
