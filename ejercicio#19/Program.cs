using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> OperacionLarga()
    {
        await Task.Delay(2000); 
        Random random = new Random();
        return random.Next(1, 100);
    }

    static async Task Main()
    {
        try
        {
            Task<int> tarea1 = OperacionLarga();
            Task<int> tarea2 = OperacionLarga();

            int resultado1 = await tarea1;
            int resultado2 = await tarea2;

            Console.WriteLine($"Resultado 1: {resultado1}");
            Console.WriteLine($"Resultado 2: {resultado2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }
}
