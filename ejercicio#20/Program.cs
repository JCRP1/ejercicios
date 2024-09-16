using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task DescargarArchivo(int id)
    {
        Console.WriteLine($"Descargando archivo {id}...");
        await Task.Delay(3000); 
        Console.WriteLine($"Archivo {id} descargado.");
    }

    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Task tarea1 = DescargarArchivo(1);
        Task tarea2 = DescargarArchivo(2);
        

        await Task.WhenAll(tarea1, tarea2);

        stopwatch.Stop();
        Console.WriteLine($"Tiempo total de descarga: {stopwatch.ElapsedMilliseconds} ms");
    }
}
