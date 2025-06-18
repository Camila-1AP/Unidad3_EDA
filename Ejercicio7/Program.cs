using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Find();
        }
        static void Find()
        {
            List<int> numeros = new List<int> { 1, 25, 54, 86, 12, 44, 75, 100 };
            Console.Write("Ingrese el número que desea verificar en la lista: ");
            string tryN = Console.ReadLine();
            bool exito = int.TryParse(tryN, out int numero);

            if (exito)
            {
                if (numeros.Contains(numero))
                {
                    Console.WriteLine($"EL número {numero} se encuentra en la lista!");
                }
                else
                {
                    Console.WriteLine($"EL número {numero} no se encuentra en la lista.");

                }
             }else
            {
                Console.WriteLine("Ingrese valores válidos.");
            }  
        }
    }
}
