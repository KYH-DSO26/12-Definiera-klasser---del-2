namespace _03_Struktur_för_en_2D_punkt__Punkt2D_;

public struct Punkt2D
{
    public int X;
    public int Y;
    public Punkt2D(int x, int y)
    {
        X = x;
        Y = y;
    }
}
public class Punkt2DClass
{
    public int X { get; set; }
    public int Y { get; set; }
    public Punkt2DClass(int x, int y)
    {
        X = x;
        Y = y;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 3: Strukturer ---");

        Punkt2D p1 = new Punkt2D(10, 20);
        Punkt2D p2 = p1;    // Kopierar hela värdet direkt (eftersom det är en struct)

        Punkt2DClass pc1 = new Punkt2DClass(10, 20);
        Punkt2DClass pc2 = pc1;

        p2.X = 99;

        pc2.X = 99;


        Console.WriteLine($"p1.X: {p1.X} (oförändrad!)");
        Console.WriteLine($"p2.X: {p2.X} (ändrad!)");

        Console.WriteLine("\n\nMed pc1 och pc2 som KLASSER blir det:");
        Console.WriteLine($"\npc1.X: {pc1.X} (OBS! ÄNDRAD!)");
        Console.WriteLine($"pc2.X: {pc2.X} (ändrad)");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
