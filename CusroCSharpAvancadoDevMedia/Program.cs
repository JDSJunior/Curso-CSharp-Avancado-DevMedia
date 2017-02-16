using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{
    public class PosicaoClass
    {
        public int x;
        public int y;
    }


    class Program
    {
        //usando a sobrecarga de metodos em DobrarValue()

        //passa um parametro valuetype
        public static void DobrarValue(int _valor)
        {
            _valor = _valor * 2;
        }

        //passa um reftype como parametro
        //não precisa da keyworld ref
        public static void DobrarValue(PosicaoClass pos)
        {
            pos.x = pos.x * 2;
            pos.y = pos.y * 2;
        }

        //passa um parametro valuetype como se fosse um reftype
        public static void DobrarValue(ref int _valor)
        {
            _valor = _valor * 2;
        }

        static void Main(string[] args)
        {

            PosicaoClass pos1 = new PosicaoClass();
            pos1.x = 10;
            pos1.y = 20;

            DobrarValue(pos1);

            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);

            Console.ReadKey();
        }

        private static void DobrarValor()
        {
            int x = 10;

            DobrarValue(x);
            //nao dobra o valor pois faz uma copia de x para ser usado
            //dentro do metodo
            Console.WriteLine(x);

            DobrarValue(ref x);
            //dobra o valor de x porque passa o parametro como referencia
            //a variavel passada como parametro agora aponta para onde x está alocado
            Console.WriteLine(x);
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();
            PosicaoClass pos2 = new PosicaoClass();

            pos1.x = 10;
            pos1.y = 20;
            pos2.x = 30;
            pos2.y = 40;

            //faz com que pos2 aponte para o mesmo lugar que pos1
            //agora sao objetos que apontão que para o mesmo lugar
            pos2 = pos1;

            //altera os valores de pos1 e pos2
            //porque pos2 esta apontando para o mesmo lugar onde pos1 está alocado

            pos2.x = 50;

            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);
        }

        private static void ValueType()
        {
            int x = 10;
            int y = 20;

            //faz a cópia do valor de x em y
            //nao apontando para x
            //deepcopy
            y = x;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
