using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Camila";
            persona1.Saludar();
        }
        class Persona
        {
            private string nombre;
            public string Nombre
            {
                get { return nombre; }
                set { if (!string.IsNullOrEmpty(value)) {
                        nombre = value;
                    } }
            }
            public void Saludar()
            {
                Console.WriteLine($"Hola, soy {nombre}");
            }
        }
    }
}
