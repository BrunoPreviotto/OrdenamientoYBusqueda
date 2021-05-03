using System;
using System.Collections.Generic;
using System.Text;

namespace OrdenamientoYBusqueda
{
    class Utilidades
    {

        public static void ImprimirArreglo(int[] arreglo)
        {
            foreach(int arr in arreglo){
                Console.Write($"{arr}, ");
            }
        }

    }
}
