namespace _05_Enkel_Record_för_en_Anvandare;

// RECORD-DEFINITION (Kort syntax)
public record Användare(int Id, string Namn);

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 5: Records ---");

        Användare user = new Användare(101, "ClaesE");
        //user.Id = 99;   // Ger kompileringsfel

        Console.WriteLine($"Hela objektet: {user}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
