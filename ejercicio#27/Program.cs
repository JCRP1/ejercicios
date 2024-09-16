using System;

class Recurso : IDisposable
{
    private bool disposed = false;

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine("Liberando recursos...");
            disposed = true;
        }
    }
}

class Program
{
    static void Main()
    {
        using (Recurso recurso = new Recurso())
        {
           
        }  
    }
}
