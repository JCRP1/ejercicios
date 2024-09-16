using System;

class Program
{
    static void Main()
    {
        int? edad = null;

        if (edad.HasValue)
        {
            Console.WriteLine($"La edad es: {edad.Value}");
        }
        else
        {
            Console.WriteLine("La edad no está disponible.");
        }
    }
}
