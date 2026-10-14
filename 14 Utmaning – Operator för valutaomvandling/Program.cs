namespace _14_Utmaning___Operator_för_valutaomvandling;

// RELLA KOPPLINGAR MELLAN KLASSER VIA CASTING
public class Sek
{
    public double Belopp { get; set; }
    public Sek(double b) { Belopp = b; }
}
public class Usd
{
    public double Belopp { get; set; }
    public Usd(double b) { Belopp = b; }

    // Överlagrar explicit typomvandlings-operator (explicit cast)
    public static explicit operator Usd(Sek s)
    {
        double valutakurs = 0.095; // 1 SEK = 0.095 USD
        return new Usd(s.Belopp * valutakurs);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("--- Projekt 14: Explicit Casting-operator ---");

        Sek svenskaKronor = new Sek(1000);

        // Typomvandlar objektet Sek direkt till Usd via vår egna operator!
        Usd amerikanskaDollar = (Usd)svenskaKronor;

        System.Console.WriteLine($"1000 SEK blir {amerikanskaDollar.Belopp} USD.");



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
