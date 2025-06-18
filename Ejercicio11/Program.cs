using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();

            coche1.Color = "Dark Blue";
            Console.WriteLine(coche1.CocheColor());

        }
        class Coche
        {
            private string color;

            public string Color
            {
                get { return color; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        color = value;
                    }
                }
            }
            public string CocheColor()
            {
                return $"Coche de color: {color}";
            }
        }
    }
}
