using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            double conversor;
            double conversor2;

            //a classe não precisa ser instanciada para ser usados seus metodos
            //estaticos
            conversor = ConversorStatic.CelsiusToFahreheint(10.0);
            conversor2 = ConversorStatic.FahrenheintToCelsius(10.0);

            //como o field é static ele pertence a classe e nao a instancia
            //assim passamos o valor para a classe
            ConversorMembroStatic ConversorMembro = new ConversorMembroStatic();
            ConversorMembroStatic.temperatura = 10.0;

            Console.WriteLine("Usando uma classe Static");
            Console.WriteLine("Celsius To Fahrenheit: " + conversor);
            Console.WriteLine("Fahrenheit To Celsius: " + conversor2);

            //usando inferencetype
            var membrocnversor = ConversorMembro.CelsiusToFahrenheit();
            var membrocnversor2 = ConversorMembro.FahrenheintToCelsius();
            
            Console.WriteLine("Usando membro static");
            Console.WriteLine("Celsius To Fahrenheit : " + membrocnversor);
            Console.WriteLine("Fahrenheit To Celsius : " + membrocnversor2);

            Console.ReadKey();

        }
    }
}
