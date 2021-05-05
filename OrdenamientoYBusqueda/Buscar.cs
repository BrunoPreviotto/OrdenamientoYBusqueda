using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OrdenamientoYBusqueda
{
    class Buscar
    {
        private Stopwatch timeMeasure = new Stopwatch();

        public Stopwatch GeTimeMeasure()
        {
            return timeMeasure;
        }


        //secuencial



        public void Secuencial(int[] arreglo, int elementoBuscado)
        {
            timeMeasure.Start();
            int bandera = 0; 
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == elementoBuscado)
                {
                    Console.WriteLine($"Se encontro al elemento en la posicion {i}");
                    Console.WriteLine("Tiempo consumido: " + timeMeasure.Elapsed.TotalMilliseconds);
                    bandera = 1;
                    break;
                }
            }
            if (bandera == 0)
            {
                Console.WriteLine("No exisiste el elemento dentro del arreglo");
                Console.WriteLine("Tiempo consumido: " + timeMeasure.Elapsed.TotalMilliseconds);
            }
            timeMeasure.Stop();
        }

        public void BusquedaBinaria(int[] arreglo, int elementoBuscado)
        {
            timeMeasure.Start();
            int medio = (arreglo.Length / 2);
            if (elementoBuscado < arreglo[medio])
            {
                for (int i = 0; i < medio; i++)
                {
                    if (elementoBuscado == arreglo[i])
                    {
                        Console.WriteLine($"El elemento {elementoBuscado} se encuentra en la posicion {i}");
                        Console.WriteLine("Tiempo consumido: " + timeMeasure.Elapsed.TotalMilliseconds);
                    }
                }
            }
            else if(elementoBuscado > arreglo[medio]){
                for (int i = medio; i < arreglo.Length; i++)
                {
                    int el = arreglo[i];
                    if (elementoBuscado == arreglo[i])
                    {
                        Console.WriteLine($"El elemento {elementoBuscado} se encuentra en la posicion {i}");
                        Console.WriteLine("Tiempo consumido: " + timeMeasure.Elapsed.TotalMilliseconds);Console.WriteLine("Tiempo consumido: " + timeMeasure.Elapsed.TotalMilliseconds);
                    }
                }
            }
            else
            {
                Console.WriteLine($"El elemento {elementoBuscado} se encuentra en la posicion {medio}");
                Console.WriteLine("Tiempo consumido: " + timeMeasure.Elapsed.TotalMilliseconds);
            }
            timeMeasure.Stop();

        }

    }
}
