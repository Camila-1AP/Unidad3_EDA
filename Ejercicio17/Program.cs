using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var miTupla = ("Londres", "Madrid", "Santiago", "San Petersburgo", "Estambul");

            List<string> miLista = new List<string> { miTupla.Item1, miTupla.Item2, miTupla.Item3, miTupla.Item4, miTupla.Item5};

            Console.WriteLine($"Lista generada: [{string.Join(", ", miLista)}]");
        }
    }
}
