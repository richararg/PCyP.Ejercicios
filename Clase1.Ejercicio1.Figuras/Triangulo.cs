using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo
    {
        private double bas;
        private double altura;
        private double lado;

        // Constructor

        public Triangulo (double b, double h, double l)
        {
            bas = b;
            altura = h;
            lado = l;
        }

        // Metodos

        public double getBase()
        {
            return bas;
        }

        public void setBase(double b)
        {
            bas = b;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double h)
        {
            altura = h;
        }

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
            return (lado * 2) + bas;
        }

        public double area()
        {
            return (bas * altura) / 2;
        }

    }
}
