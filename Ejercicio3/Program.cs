using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Par();
        }
        static void Par()
        {
            Console.Write("Ingrese un número: ");

            string tryNumero = Console.ReadLine();

            bool exito = int.TryParse(tryNumero, out int numero);

            if (exito)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es par!");
                }
                else
                {
                    Console.WriteLine($"El número {numero} no es par.");

                }
            }
            else
            {
                Console.WriteLine("Ingrese valores válidos.");
            }

            
        }
    }
}
