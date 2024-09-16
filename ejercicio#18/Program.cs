using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> OperacionLarga()
    {
        await Task.Delay(2000); 
        return new Random().Next(1, 100);
    }

    static async Task Main()
    {
        Console.WriteLine("¿Cuántas tareas deseas ejecutar?");
        int cantidadTareas = int.Parse(Console.ReadLine());

        Task<int>[] tareas = new Task<int>[cantidadTareas];

       
        for (int i = 0; i < cantidadTareas; i++)
        {
            tareas[i] = OperacionLarga();
        }

        
        int[] resultados = await Task.WhenAll(tareas);

        for (int i = 0; i < resultados.Length; i++)
        {
            Console.WriteLine($"Resultado de la tarea {i + 1}: {resultados[i]}");
        }
    }
}
