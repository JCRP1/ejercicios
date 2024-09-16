using System;

class Program
{
    static void Main()
    {
        dynamic variable = 10;
        Console.WriteLine($"Valor de variable: {variable}, Tipo: {variable.GetType()}");

        variable = "Hola, Mundo";
        Console.WriteLine($"Valor de variable: {variable}, Tipo: {variable.GetType()}");

        variable = new Persona { Nombre = "Juan" };
        Console.WriteLine($"Valor de variable: {variable.Nombre}, Tipo: {variable.GetType()}");
    }
}

class Persona
{
    public string Nombre { get; set; }
}
