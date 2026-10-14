namespace _10_Indexerare_med_strängnyckel__Ordbok_;

public class EnkelOrdbok
{
    // Indexerare som tar en sträng istället för ett heltal
    public string this[string svensktOrd]
    {
        get
        {
            string nyckel = svensktOrd.ToLower();
            if (nyckel == "programmering") return "programming";
            if (nyckel == "lärare") return "teacher";
            if (nyckel == "skola") return "school";

            return "Ordet hittades inte i ordlistan.";
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 10: Indexerare (strängnyckel)\n");

        EnkelOrdbok ordbok = new EnkelOrdbok();

        Console.WriteLine($"Översättning av 'programmering': {ordbok["programmering"]}");
        Console.WriteLine($"Översättning av 'skola': {ordbok["skola"]}");
        Console.WriteLine($"Översättning av 'matsal': {ordbok["matsal"]}");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
