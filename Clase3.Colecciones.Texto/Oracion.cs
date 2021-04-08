using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Colecciones.Texto
{
    class Oracion
    {
        private Dictionary<string, int> parrafo = new Dictionary<string, int>();

        // Metodos
        
        // Constructor con texto
        public Oracion (string t)
        {
            // Separo el texto por espacio
            var texto = t.Split(' ');
            // Por cada string lo almaceno en x
            foreach(string x in texto)
            {
                // Verificando si existe x en el diccionario
                if (parrafo.ContainsKey(x))
                {
                    // Si existe agrego 1 a valor
                    parrafo[x] = parrafo[x] + 1;
                } else
                {
                    // Si no existe lo agrego con valor 1
                    parrafo.Add(x, 1);
                }
            }
        }


        public void resultado()
        {

            // Muestro por consola el analisis
            Console.WriteLine("\nContenido del diccionario:\nKey:\t\tValue:");
            foreach(KeyValuePair<string, int> x in parrafo)
            {
                Console.WriteLine(x.Key + "\t\t" + x.Value);
            }
            Console.WriteLine("Size: {0}", parrafo.Count);

        }


    }
}
