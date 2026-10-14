namespace _11_Omdefiniering_av_operator_för_Euro__Plusoperator_;

// KLASS MED ÖVERLAGRAD OPERATOR
public class Euro
{
    public double Belopp { get; set; }
    public Euro(double belopp)
    {
        Belopp = belopp;
    }

    // Omdefiniera plus-operatorn (+)
    public static Euro operator +(Euro e1, Euro e2)
    {
        return new Euro(e1.Belopp + e2.Belopp);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 11: Operatoröverlagring (+) ---\n");

        Euro planPlånbok = new Euro(50.50);
        Euro kassaPlånbok = new Euro(20.00);

        // Vi adderar objekten direkt!
        Euro totalt = planPlånbok + kassaPlånbok;

        Console.WriteLine($"Totalt belopp: {totalt.Belopp:F2} EUR");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
