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

            //Busqueda

            Buscar buscar = new Buscar();

            buscar.Secuencial(arreglo,6);



        }
    }
}
