namespace _07_Generisk_låda__Lada_T__;

public class Låda<T>
{
    private T _innehåll;
    public void LäggI(T sak)
    {
        _innehåll = sak;
    }

    public T Hämta()
    {
        return _innehåll;
    }

    
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 7: Generics (Enkel) ---");

        // Använd lådan för ett heltal
        Låda<int> nummerLåda = new Låda<int>();
        nummerLåda.LäggI(554);
        Console.WriteLine($"Heltal ur lådan: {nummerLåda.Hämta()}");

        // Återanvänd samma klasstruktur för en textsträng
        Låda<string> textLåda = new Låda<string>();
        textLåda.LäggI("Ett vänligt meddelande");
        Console.WriteLine($"Sträng ur lådan: {textLåda.Hämta()}");

        




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
