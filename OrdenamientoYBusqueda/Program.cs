using System;
using System.Diagnostics;

namespace OrdenamientoYBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            Utilidades.OperarMenu();
            timeMeasure.Stop();
            Console.WriteLine("Tiempo de ejecucion del programa: " + timeMeasure.Elapsed.TotalMilliseconds);
        }
    }
}
