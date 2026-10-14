namespace _06_Oföränderlig_Record_med_with_uttryck;

// RECORD-DEFINITION
public record ProduktRecord(string Produktnamn, double Pris);

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 6: Records och 'with' ---");

        ProduktRecord original = new ProduktRecord("Hörlurar", 1499.00);

        // Skapa en oföränderlig kopia med ett ändrat tillstånd
        ProduktRecord kopia = original with { Pris = 999.00 };

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"rea-kopia: {kopia}");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
