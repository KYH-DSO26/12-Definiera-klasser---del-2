namespace _08_Generisk_par_behållare__Par_T__U__;

// GENERISK KLASS MED TVÅ TYPPARAMETRAR
public class Par<T, U>
{
    public T Första { get; set; }
    public U Andra { get; set; }

    public Par(T första, U andra)
    {
        Första = första;
        Andra = andra;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 8: Generics (Par) ---");

        // Lagrar en sträng och ett heltal tillsammans (T. ex. Namn och ID)
        Par<string, int> ProduktId = new Par<string, int>("Kaffe", 4022);

        Console.WriteLine($"Produkt: {ProduktId.Första}, ID-kod: {ProduktId.Andra}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
