using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Vial
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Guardo el archivo en un variable array string
                string[] lineas = File.ReadAllLines(@"vial.csv");

                // instancio Objeto
                Objeto ob;
                int cont = 0;

                // por cada linea de mi array 
                foreach (var linea in lineas)
                {
                    // utilizo el separador , en la cadena de caracteres
                    var valores = linea.Split(',');

                    ob = new Objeto(int.Parse(valores[0]), valores[1], long.Parse(valores[2]), valores[3], int.Parse(valores[4]));
                    ob.imprimir();
                    cont++;
                }

                Console.WriteLine("Total de líneas leídas: " + cont);
                Console.ReadLine();
            }

        }
    }
}
