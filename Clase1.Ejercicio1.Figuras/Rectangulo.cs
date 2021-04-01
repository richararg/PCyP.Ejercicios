using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Rectangulo
    {
        private double alto;
        private double ancho;

        // Constructor
        public Rectangulo(double al, double an)
        {
            alto = al;
            ancho = an;
        }

        // Metodos

        public double getAlto()
        {
            return alto;
        }

        public void setAlto(double l)
        {
            alto = l;
        }

        public double getAncho()
        {
            return ancho;
        }

        public void setAncho(double l)
        {
            ancho = l;
        }

        public double perimetro()
        {
            return alto * 2 + ancho * 2;
        }
        
        public double area()
        {
            return alto * ancho;
        }


    }
}
