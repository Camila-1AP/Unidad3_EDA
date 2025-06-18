using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversionCaF();
        }
        static void ConversionCaF()
        {
            Console.Write("Ingrese el valor a converir de Celsius a Fahrenheit: ");
            string tryNumero = Console.ReadLine();
            bool exito = double.TryParse(tryNumero, out double numero);

            if (exito)
            {
                double fahrenheit = (numero * 9) / 5 + 32;
                Console.WriteLine($"Conversión: {tryNumero} °C -----> {fahrenheit} °F");
            }else
            {
                Console.WriteLine("Error: Ingrese valores válidos.");
            }
        }
    }
}
