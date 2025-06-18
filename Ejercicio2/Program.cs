using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCirculo(5);
        }
        static void AreaCirculo(double radio)
        {
            Console.WriteLine($"EL área del círculo con radio de {radio} = {Math.Round( ( Math.PI * Math.Pow(radio, 2)), 2)}");
        }
    }
}
