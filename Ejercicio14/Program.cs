using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var frutas = ("Fresa", "Arandano", "Manzana");
            var verduras = ("Lechuga", "Espinaca", "Zanahoria");
           
            var tuplasConcatenadas = (frutas.Item1, frutas.Item2, frutas.Item3, verduras.Item1, verduras.Item2, verduras.Item3);

            Console.WriteLine($"Tuplas concatenadas: {tuplasConcatenadas}");
        }
    }
}
