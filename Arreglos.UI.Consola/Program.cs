using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");
        MiArreglo oMiarreglo = new MiArreglo(20);

        oMiarreglo.Llenar(5,20);

        Console.WriteLine("\nArreglo desordenado");
        Console.WriteLine(oMiarreglo);

        Console.WriteLine("\nArreglo ordenado ascendente");
        oMiarreglo.Ordenar();
        Console.WriteLine(oMiarreglo);

        Console.WriteLine("\nArreglo ordenado descendente");
        oMiarreglo.Ordenar(false);
        Console.WriteLine(oMiarreglo);
        //oMiarreglo.N = 10;




        //para que no aparezcan las letras
        Console.ReadKey();
    }
}