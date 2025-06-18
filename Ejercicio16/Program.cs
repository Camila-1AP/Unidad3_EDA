using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tupla = (1, 2, 3, 4, 5);
            int longitud = typeof((int, int, int, int, int)).GetGenericArguments().Length;
            Console.WriteLine($"La tupla tiene {longitud} elementos.");

        }
    }
}
