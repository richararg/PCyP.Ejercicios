using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Colecciones.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementar un diccionario que contendrá los siguientes valores:
            // values.Add("Juan", "55423412");
            // values.Add("Ernesto", "56985623");
            // values.Add("Mariana", "54787451");
            // Realice las siguientes operaciones:
            // a.Revisar en el diccionario si existe un índice llamado “Juan”. En caso de que exista,
            // mostrar su valor(utilice el método ContainsKey)
            // b.Revisar en el diccionario si existe un índice llamado “Pedro”. En caso de que exista,
            // mostrar su valor, si no existe imprimir por pantalla “No contiene la llave” (utilice el método TryGetValue)
            // c.Recorrer el diccionario y mostrar todos sus datos (índice y valor).
            // d.Alterar el valor cuyo índice es “Mariana” por “58251425”. Imprimir el nuevo valor.


            // Inicializo Dictionary nombrado values
            Dictionary<String, String> values = new Dictionary<string, string>();

            // Agrego Valores
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            // a.
            Console.WriteLine("Ejercicio a.\n");
            String buscado = "Juan";

            if (values.ContainsKey(buscado))
            {
                foreach (KeyValuePair<string, string> x in values)
                {
                    if (x.Key.Equals(buscado))
                    {
                        Console.WriteLine("El valor de " + buscado + " es de: " + x.Value);
                    }
                }
            }


            // b.
            Console.WriteLine("\nEjercicio b.\n");
            buscado = "Pedro";
            String valor;
            if (values.TryGetValue(buscado, out valor))
            {
                        Console.WriteLine("El valor de " + buscado + " es de: " + valor);
            } else
            {
                Console.WriteLine("No contiene llave");
            }

            //c.
            Console.WriteLine("\nEjercicio c.\n");
            foreach (KeyValuePair<string,string> z in values)
            {
                Console.WriteLine("Indice: {0} \t Valor: {1}", z.Key, z.Value);
            }

            //d.
            Console.WriteLine("\nEjercicio d.\n");
            Console.WriteLine("El valor de Mariana es de: {0}", values["Mariana"]);
            values["Mariana"] = "58251425";
            Console.WriteLine("El nuevo valor de Mariana es de: {0}", values["Mariana"]);

        }
    }
}
