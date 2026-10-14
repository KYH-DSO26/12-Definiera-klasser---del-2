namespace _02_Statisk_räknare__InstansRaknare_;

public class InstansRäknare
{
    private static int antalObjekt = 0;     // Gemensam för alla räknare
    public InstansRäknare()
    {
        antalObjekt++;
    }

    public static int HämtaAntal()
    {
        return antalObjekt;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 2: Statiska fält ---");

        InstansRäknare i1 = new InstansRäknare();
        var i2 = new InstansRäknare();
        var i4 = new InstansRäknare();
        InstansRäknare i3 = new();

        Console.WriteLine($"Antal skapade instanser: {InstansRäknare.HämtaAntal()}");







        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
