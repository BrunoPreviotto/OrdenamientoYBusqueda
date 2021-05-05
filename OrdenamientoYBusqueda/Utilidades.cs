using System;
using System.Collections.Generic;
using System.Text;

namespace OrdenamientoYBusqueda
{
    class Utilidades
    {
        public static int[] arreglo;

        public static void ImprimirArreglo(int[] arreglo)
        {
            foreach(int arr in arreglo){
                Console.Write($"{arr}, ");
            }
        }

        public static int[] SolicitarArreglo()
        {
            Console.WriteLine("Ingresar el tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            int[] arreglo = new int[n];
            Console.WriteLine($"Ingresar {n} numeros: ");
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            return arreglo;
        } 

        public static bool DeterminarSiArregloOrdenado(int [] arreglo)
        {
            int contador = 0;
            for (int i  = 0; i < arreglo.Length-1; i++)
            {
                if (arreglo[i] < arreglo[i+1])
                {
                    contador++;
                }
            }
            return arreglo.Length == (contador + 1);
        }

        public static void Menu()
        {
            Console.WriteLine("ARREGLOS");
            Console.WriteLine();
            Console.WriteLine("1-INGRESAR ARREGLO");
            Console.WriteLine("2-ORDENAR ARREGLO");
            Console.WriteLine("3-BUSCAR ELEMENTO EN ARREGLO");
            Console.WriteLine("4-SALIR");
        }

        public static void SubMenuOrdenar()
        {
            Console.WriteLine("ELEGIR METODO DE ORDENAMIENTO");
            Console.WriteLine("");
            Console.WriteLine("1-INSERCION");
            Console.WriteLine("2-BURBUJA");
            Console.WriteLine("3-SELECCION");
            Console.WriteLine("4-QUICK-SHORT");
            Console.WriteLine("5-SALIR");
        }

        public static void OperarMenu()
        {
            Menu();
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 4) {
                switch (opcion)
                {
                    case 1:
                        arreglo = SolicitarArreglo();
                        Console.WriteLine("Arreglo guardado");
                        Console.Clear();
                        Menu();
                        break;
                    case 2:
                        Console.Clear();
                        SubMenuOrdenar();
                        int opcionOrdenar = int.Parse(Console.ReadLine());
                        while (opcionOrdenar != 5)
                        {
                            Ordenar ordenar = new Ordenar();
                            switch (opcionOrdenar)
                            {
                                case 1:
                                   Console.WriteLine("Arreglo ordenado por insercion: ");
                                    ImprimirArreglo(ordenar.Insercion(arreglo));
                                    break;
                                case 2:
                                    Console.WriteLine($"Arreglo ordenado por burbuja: {ordenar.Burbuja(arreglo)}");
                                    break;
                                case 3:
                                    Console.WriteLine($"Arreglo ordenado por seleccion: {ordenar.Seleccion(arreglo)}");
                                    break;
                                case 4:
                                    Console.WriteLine($"Arreglo ordenado por quick-sort: {ordenar.Quick_Sort(arreglo,0,arreglo.Length-1)}");
                                    break;
                            }
                            opcionOrdenar = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        Menu();
                        break;
                    case 3:
                        Console.Clear();
                        Buscar buscar = new Buscar();
                        Console.WriteLine("Ingresar el numero a buscar: ");
                        int elementoBuscado = int.Parse(Console.ReadLine());
                        if (DeterminarSiArregloOrdenado(arreglo))
                        {
                            buscar.BusquedaBinaria(arreglo, elementoBuscado);
                        }
                        else {
                            buscar.Secuencial(arreglo, elementoBuscado);
                        }
                        break;
                }
                opcion = int.Parse(Console.ReadLine());
            } 
        } 

    }
}
