using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = (3, 5, 3, 7, 3, 5);
            int numeroBuscado = 3;

            
            int contador = 0;
            foreach (var item in new[] { numeros.Item1, numeros.Item2, numeros.Item3, numeros.Item4, numeros.Item5, numeros.Item6 })
            {
                if (item == numeroBuscado)
                {
                    contador++;
                }
            }

            Console.WriteLine($"El número {numeroBuscado} aparece {contador} veces en la tupla.");
        }
    }
}
