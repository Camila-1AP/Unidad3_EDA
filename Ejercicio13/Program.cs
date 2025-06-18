using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tupla1 = (1, "Dos", 3, "Cuatro", 5);
            Console.WriteLine($"El tercer elemento de la tupla: {tupla1.Item3} ");
        }
    }
}
