using System;

class Program
{
    static void Main()
    {
        int? edad = null;

        int edad2 = edad ?? 18;

        Console.WriteLine($"Edad: {edad2}");
    }
}
