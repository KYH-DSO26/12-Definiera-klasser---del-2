namespace _01_Statisk_verktygsklass__MatematikVerktyg_;

public static class MatematikVerktyg
{
    public static int HittaStörstaTal(int a, int b)
    {
        //if (a > b)
        //{
        //    return a;
        //}
        //else
        //{
        //    return b;
        //}

        return (a > b) ? a : b; 
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 1: Statiska metoder ---");

        int x = 42;
        int y = 89;

        Console.WriteLine($"Hitta det största av {x} och {y}");

        int störst = MatematikVerktyg.HittaStörstaTal(x, y);  // OBS! Ingen new() behövs

        Console.WriteLine($"Det största talet är {störst}");








        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
