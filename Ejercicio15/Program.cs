using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> letras = new List<string> { "a", "b", "c" };

            var tupla = (letras[0], letras[1], letras[2]);

            Console.WriteLine($"Convirtiendo la lista en tupla: ({tupla.Item1}, {tupla.Item2}, {tupla.Item3})");
        }
    }
}
