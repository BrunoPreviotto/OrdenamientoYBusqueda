using System;

namespace OrdenamientoYBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5] { 4, 9, 1, 7, 1 };
            Ordenar ordenar = new Ordenar();

            //Ordenamiento

            //insercion//Utilidades.ImprimirArreglo(ordenar.Insercion(arreglo));

            //burbuja//Utilidades.ImprimirArreglo(ordenar.Burbuja(arreglo));

            //seleccion//Utilidades.ImprimirArreglo(ordenar.Seleccion(arreglo));

            //quick-short//Utilidades.ImprimirArreglo(ordenar.Quick_Sort(arreglo, 0, arreglo.Length-1)); 

            //Busqueda

            Buscar buscar = new Buscar();

            //secuencial//buscar.Secuencial(arreglo,6);

            int[] arregloOrdenado = new int[4] { 1, 2, 3, 4};
            buscar.BusquedaBinaria(arregloOrdenado, 2);


        }
    }
}
