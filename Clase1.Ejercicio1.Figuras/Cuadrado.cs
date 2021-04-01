using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Cuadrado
    {
        private double lado;

        // Constructor
        public Cuadrado(double l)
        {
            lado = l;
        }

        // Metodos

        public double getLado()
        {
            return lado;
        }

        public void setLado(double l)
        {
            lado = l;
        }

        public double perimetro()
        {
            return lado * 4;
        } 

        public double area()
        {
            return lado * lado;
        }



    }
}
