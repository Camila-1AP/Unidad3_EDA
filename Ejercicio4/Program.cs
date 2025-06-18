using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mayor();
        }
        static void Mayor()
        {
            Console.Write("Ingrese el primer número: ");
            string tryN1 = Console.ReadLine();
            bool exito1 = double.TryParse(tryN1, out double numero1);

            Console.Write("Ingrese el segundo número: ");
            string tryN2 = Console.ReadLine();
            bool exito2 = double.TryParse(tryN2, out double numero2);

            if (exito1 && exito2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"El número {numero1} es mayor al número {numero2}");
                }
                else
                {
                    Console.WriteLine($"El número {numero2} es mayor al número {numero1}");

                }
            }else
            {
                Console.WriteLine("Ingrese valores válidos.");
            }
        }
    }
}
