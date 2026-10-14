namespace _13_Generisk_Repository_simulering__DataLager_T__;

// GENERISKT REPOSITORY MED FINDARE/INDEXERARE
public class DataLager<T>
{
    private T[] lagringsArray = new T[5];
    private int nuvarandeIndex = 0;
    public void Spara(T element)
    {
        if (nuvarandeIndex < lagringsArray.Length)
        {
            lagringsArray[nuvarandeIndex++] = element;
        }
    }
    // Generisk indexerare
    public T this[int i]
    {
        get { return lagringsArray[i]; }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("--- Projekt 13: Generiskt Datalager ---");

        DataLager<string> loggBok = new DataLager<string>();
        loggBok.Spara("Systemstart kl 08:30");
        loggBok.Spara("Code-along påbörjad");

        System.Console.WriteLine($"Logg 1: {loggBok[0]}");
        System.Console.WriteLine($"Logg 2: {loggBok[1]}");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
