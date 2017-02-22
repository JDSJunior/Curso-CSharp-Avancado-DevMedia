using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStatic
{
    public static class ConversorStatic
    {
        public static double CelsiusToFahreheint(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }

        public static double FahrenheintToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }
    }
}
