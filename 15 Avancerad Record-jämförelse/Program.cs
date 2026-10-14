namespace _15_Avancerad_Record_jämförelse;

// EN VANLIG KLASS
public class StudentKlass
{
    public string Namn { get; set; }
    public StudentKlass(string n) { Namn = n; }
}
// EN RECORD
public record StudentRecord(string Namn);

internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("--- Projekt 15: Värdebaserad jämförelse ---");

        // 1. Testar vanliga klasser (Referensjämförelse)
        StudentKlass k1 = new StudentKlass("Anna");
        StudentKlass k2 = new StudentKlass("Anna");
        bool klassLika = (k1 == k2); // Blir False eftersom de pekar på olika minnesadresser
                                     
        // 2. Testar Records (Inbyggd värdebaserad jämförelse)
        StudentRecord r1 = new StudentRecord("Anna");
        StudentRecord r2 = new StudentRecord("Anna");
        bool recordLika = (r1 == r2); // Blir True eftersom innehållet är identiskt!

        System.Console.WriteLine($"Är klass-objekten lika? {klassLika}");
        System.Console.WriteLine($"Är record-objekten lika? {recordLika}");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
