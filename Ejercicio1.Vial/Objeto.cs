using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Vial
{
    class Objeto
    {
        int numeroDeHoja;
        string tipoObjeto;
        long idTramo;
        string tipoCamino;
        int longitud;

        public Objeto()
        {
            numeroDeHoja = 0;
            tipoObjeto = null;
            idTramo = 0;
            tipoCamino = null;
            longitud = 0;
        }

        public Objeto(int nro, string tipoO, long id, string tipoC, int long_)
        {
            numeroDeHoja = nro;
            tipoObjeto = tipoO;
            idTramo = id;
            tipoCamino = tipoC;
            longitud = long_;
        }

        public void imprimir()
        {
            Console.WriteLine("Número de hoja: {0}\tTipo de objeto: {1}\tIdentificador de tramo: {2}\tTipo de camino: {3}\tLongitud: {4}", numeroDeHoja, tipoObjeto, idTramo, tipoCamino, longitud);
        }
    }
}
