using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro canino1 = new Perro();
            canino1.Raza = "Pomerania";
            canino1.RazaDog();
        }
        class Perro
        {
            private string raza;

            public string Raza
            {
                get { return raza; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        raza = value;
                    }
                }
            }
            public void RazaDog()
            {
                Console.WriteLine($"Canino de raza: {raza}");
            }
        }
    }
}
