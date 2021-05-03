using System;
using System.Collections.Generic;
using System.Text;

namespace OrdenamientoYBusqueda
{
    class Buscar
    {

        //secuencial
        
        
        
        public void Secuencial(int[] arreglo, int elementoBuscado)
        {
            int bandera = 0; 
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elementoBuscado)
                {
                    Console.WriteLine($"Se encontro al elemento en la posicion {i}");
                    bandera = 1;
                    break;
                }
            }
            if (bandera == 0)
            {
                Console.WriteLine("No exisiste el elemento dentro del arreglo");
            }
        }

    }
}
