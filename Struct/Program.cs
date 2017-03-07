using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    public class PosicaoClass
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return "Valor de X: " + this.x + ". Valor de Y: " + this.y;
        }
    }

    public struct PosicaoStruct
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return "Valor de X: " + this.x + ". Valor de Y: " + this.y;
        }
    }

    public enum Role
    {
        Developer, Engineer, Tester
    }

    public enum Color
    {
        Red = 0, Blue = 2, White = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //typereference
            PosicaoClass pos1 = new PosicaoClass();
            PosicaoClass pos2;

            pos1.x = 10;
            pos1.y = 20;

            //aponta pos3 para o mesmo local de memoria onde pos1 está alocado
            pos2 = pos1;

            //muda os valores de x onde os dois objetos apontam
            pos2.x = 5;

            Console.WriteLine(pos1);

            //typevalue
            PosicaoStruct pos3 = new PosicaoStruct();
            PosicaoStruct pos4;

            pos3.x = 30;
            pos3.y = 40;

            //copia os valores para os fields de pos4
            pos4 = pos3;

            Console.WriteLine(pos3);

            Role role = Role.Developer;
            Color cor = Color.White;

            //retorna o conteudo de cada posição do enum
            Console.WriteLine(role);
            Console.WriteLine(cor);
            Console.WriteLine(Color.Blue);
            Console.WriteLine(Color.Red);

            //retorna o indice do enum
            Console.WriteLine(Convert.ToInt16(Color.Blue));

            Console.ReadKey();

        }
    }
}
