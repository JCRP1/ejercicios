using System;

class Persona
{
    public string Apellido { get; set; }
}

class Program
{
    static void Main()
    {
        Persona persona = new Persona { Apellido = null };

        Console.WriteLine($"Apellido: {persona?.Apellido ?? "Apellido no disponible"}");
    }
}
