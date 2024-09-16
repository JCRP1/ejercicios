using System;

class Caja<T>
{
    private T contenido;

    public void Agregar(T item)
    {
        contenido = item;
    }

    public T Obtener()
    {
        return contenido;
    }
}

class Program
{
    static void Main()
    {
        Caja<int> numero= new Caja<int>();
        Console.WriteLine("Ingresa un numero");
        int n1 = int.Parse(Console.ReadLine());

        numero.Agregar(n1);
        Console.WriteLine("Contenido de la caja: " + numero.Obtener());

       
    }
}
