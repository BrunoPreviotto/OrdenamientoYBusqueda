using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OrdenamientoYBusqueda
{
    class Ordenar
    {

        private Stopwatch timeMeasure = new Stopwatch();


        public Stopwatch GeTimeMeasure()
        {
            return timeMeasure;
        }

        //insercion

        public int[] Insercion(int[] arreglo)
        {
            timeMeasure.Start();
            int auxiliar = 0;
            for (int i = 1; i < arreglo.Length; i++)
            {
                for (int s = 0; s < i; s++)
                {
                    if (arreglo[i] < arreglo[s])
                    {
                        auxiliar = arreglo[i];
                        arreglo[i] = arreglo[s];
                        arreglo[s] = auxiliar;
                    }
                }
            }
            timeMeasure.Stop();
            return arreglo;
        }


        //burbuja

        public int[] Burbuja(int[] arreglo)
        {
            timeMeasure.Start();
            bool bandera = true;
            int auxiliar = 0;
            while (bandera)
            {
                bandera = false;
                for (int i = 0; i < arreglo.Length-1; i++)
                {
                    if (arreglo[i+1] < arreglo[i])
                    {
                        auxiliar = arreglo[i];
                        arreglo[i] = arreglo[i+1];
                        arreglo[i+1] = auxiliar;
                        bandera = true;
                    }
                }
            }
            timeMeasure.Stop();
            return arreglo;
        }

        //seleccion

        public int[] Seleccion(int[] arreglo)
        {
            timeMeasure.Start();
            int auxiliar = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int s = i+1; s < arreglo.Length; s++)
                {
                    if (arreglo[i] > arreglo[s])
                    {
                        auxiliar = arreglo[i];
                        arreglo[i] = arreglo[s];
                        arreglo[s] = auxiliar;
                            
                    }
                }
            }
            timeMeasure.Stop();
            return arreglo;
        }

        //quick-short

        public int[] Quick_Sort(int[] arreglo, int izquierda, int derecha)
        {
            timeMeasure.Start();
            if (izquierda < derecha)
            {
                int pivot = Partition(arreglo, izquierda, derecha);

                if (pivot > 1)
                {
                    Quick_Sort(arreglo, izquierda, pivot - 1);
                }
                if (pivot + 1 < derecha)
                {
                    Quick_Sort(arreglo, pivot + 1, derecha);
                }
            }
            timeMeasure.Stop();
            return arreglo;
        }


        public static int Partition(int[] arreglo, int izquierda, int derecha)
        {
            int pivot = arreglo[izquierda];
            while (true)
            {

                while (arreglo[izquierda] < pivot)
                {
                    izquierda++;
                }

                while (arreglo[derecha] > pivot)
                {
                    derecha--;
                }

                if (izquierda < derecha)
                {
                    if (arreglo[izquierda] == arreglo[derecha]) return derecha;

                    int temp = arreglo[izquierda];
                    arreglo[izquierda] = arreglo[derecha];
                    arreglo[derecha] = temp;


                }
                else
                {
                    return derecha;
                }
            }
        }






    }
}
