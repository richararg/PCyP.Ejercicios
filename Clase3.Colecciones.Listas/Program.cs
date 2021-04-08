using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Colecciones.Listas
{
    class Program
    {
        static void Main(string[] args)
        {


            // Dado dos vectores:
            // private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            // private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
            // Realice las siguientes operaciones:
            // a.Armar dos listas, una con los valores del vector “colors” y otra con los valores del vector “removeColors”.
            // b.Mostrar la lista de colores por pantalla.
            // c.De la lista de colores eliminar los colores listados en la otra lista(removeColors).
            // d.Volver a mostrar la lista de colores por pantalla.

            // a.
            List<string> colors = new List<string> { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            List<string> removecolors = new List<string> { "RED", "WHITE", "BLUE" };
            
             // b.
            Console.WriteLine("\nEjercicio b.\n");
            
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            // c.
   
            foreach (string borrar in removecolors)
            {
                colors.Remove(borrar);
            }

            // d.

            Console.WriteLine("\nEjercicio d.\n");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}
