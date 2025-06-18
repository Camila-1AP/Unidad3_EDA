using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CantidadVocales("Hola mundo");
        }
        static void CantidadVocales(string cadena)
        {
              int contador = 0;
              string vocales = "aáeéiíóoúuAÁEÉIÍOÓUÚ";

              foreach (char letra in cadena)
              {
                  if (vocales.Contains(letra))
                  {
                      contador++;
                  }
              }
              Console.WriteLine($"Vocales registradas: {contador}");    
        }
    }
}
