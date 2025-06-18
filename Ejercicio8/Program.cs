using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Longitud("Hola mundo");
        }
        static void Longitud(string cadena)
        {
            int longitud = cadena.Length;
            Console.WriteLine($"La longitud de la cadena ingresada: {longitud}");
        }
    }
}
