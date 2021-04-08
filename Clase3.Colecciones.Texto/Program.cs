using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Colecciones.Texto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Realizar un software que solicite al usuario que ingrese un párrafo 
            // por teclado y el software cuente la cantidad de ocurrencias de cada 
            // palabra. Asimismo, deberá indicar la cantidad de palabras distintas 
            // que existen en el párrafo ingresado por el usuario.

            Console.WriteLine("Ingrese el texto a analizar: ");
            string texto = Console.ReadLine();
            Oracion o = new Oracion(texto);
            o.resultado();

        }
    }
}
