using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Program
    {
        static void Main(string[] args)
        /// Realizar un programa capaz de calcular el área y perímetro de un cuadrado, rectángulo y triángulo. 
        /// Todos los datos necesarios para su funcionamiento se ingresan por teclado.
        {
            // variables
            char opc = ' ';  //opcion
            double l = 0;   // lado
            double b = 0;   // base
            double h = 0;   // altura
            // bucle para repetir la solucion
            do
            {

                // Menu por pantalla                     
                Console.WriteLine("\n\tCalculo de area y perimetro por figura\n");
                Console.WriteLine("1 - Cuadrado");
                Console.WriteLine("2 - Rectangulo");
                Console.WriteLine("3 - Triangulo");
                Console.WriteLine("4 - Salir");
                Console.Write("\nEscriba la opcion deseada: ");
                // comando para tomar la tecla presionada y guardar en la variable opc
                opc = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // switch para ejecutar la solucion de acuerdo a la opcion escrita
                switch (opc)
                {
                    case '1':
                        Console.Write("Ingrese el valor de un lado del cuadrado: ");
                        l = double.Parse(Console.ReadLine());
                        Cuadrado c = new Cuadrado(l);
                        Console.Write("\nEl perimetro del cuadrado es de: {0}", c.perimetro());
                        Console.Write("\nEl area del cuadrado es de: {0} \n\n", c.area());
                        break;
                    case '2':
                        Console.Write("Ingrese el valor del ancho del rectangulo: ");
                        l = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor del alto del rectangulo: ");
                        b = double.Parse(Console.ReadLine());
                        Rectangulo r = new Rectangulo(l, b);
                        Console.Write("\nEl perimetro del rectangulo es de: {0}", r.perimetro());
                        Console.Write("\nEl area del rectangulo es de: {0} \n\n", r.area());
                        break;
                    case '3':
                        Console.Write("Ingrese el valor de la base del triangulo: ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor del altura del triangulo: ");
                        h = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor del lado del triangulo: ");
                        l = double.Parse(Console.ReadLine());
                        Triangulo t = new Triangulo(b, h, l);
                        Console.Write("\nEl perimetro del triangulo es de: {0}", t.perimetro());
                        Console.Write("\nEl area del triangulo es de: {0} \n\n", t.area());
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("La opcion escrita no es valida (opcion entre 1 y 4)");
                        break;
                }

                Console.WriteLine("Pulse cualquier tecla para volver al menu...");
                Console.ReadKey();
                Console.Clear();
            } while (opc != 4);
            

        }
    }
}
