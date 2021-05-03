using System;
using System.Collections.Generic;
using System.Text;

namespace OrdenamientoYBusqueda
{
    class Ordenar
    {

        //insercion

        public int[] Insercion(int[] arreglo)
        {
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
            return arreglo;
        }


        //burbuja

        public int[] Burbuja(int[] arreglo)
        {
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
            return arreglo;
        }

        //seleccion

        public int[] Seleccion(int[] arreglo)
        {
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
            return arreglo;
        }

        //quick-short

        public int[] QuickShort(int[] arreglo)
        {
            
            return arreglo;
        }

    }
}
