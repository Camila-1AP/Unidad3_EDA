using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRUEBA
            Sumar(5, 6);
        }
        static public void Sumar(double a, double b)
        {
       
            double suma = a + b;
                
            Console.WriteLine($"La suma de {a} + {b} = {suma}");
            
           
           
            
        }
    }
}
