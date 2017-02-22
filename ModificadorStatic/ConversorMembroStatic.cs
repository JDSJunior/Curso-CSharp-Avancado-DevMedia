using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStatic
{
    public class ConversorMembroStatic
    {
        //usando um campo static ele fica associado a classe e nao a instancia
        //e vai ser usado pelos dois metodos que a usam
        public static double temperatura;

        public double CelsiusToFahrenheit()
        {
            return (temperatura * 9 / 5) + 32;
        }

        public double FahrenheintToCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }
    }
}
