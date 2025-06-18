using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            libro1.Titulo = "Las aventuras de Sissi";
            libro1.GetTitulo();

        }
        class Libro
        {
            private string titulo;

            public string Titulo
            {
                get { return titulo; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        titulo = value;
                    }
                }
            }
            public void GetTitulo()
            {
                Console.WriteLine($"Título del libro: {titulo}");
            }
        }
    }
}
