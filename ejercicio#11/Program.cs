using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        var impares = numeros.Where(n => n % 2 != 0).OrderByDescending(n => n);

        Console.WriteLine("Números impares en orden descendente:");
        foreach (var numero in impares)
        {
            Console.WriteLine(numero);
        }
    }
}
