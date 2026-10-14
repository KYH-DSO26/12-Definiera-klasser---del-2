namespace _12_Jämförelseoperatorer_för_Tidsintervall;

// KLASS MED JÄMFÖRELSEOPERATORER
public class Tidsintervall
{
    //TODO: Bygg ut så att vi även hanterar timmar
    public int Minuter { get; set; }
    public Tidsintervall(int minuter)
    {
        Minuter = minuter;
    }

    // Operatorerna < och > måste alltid överlagras i par
    public static bool operator >(Tidsintervall t1, Tidsintervall t2)
    {
        return t1.Minuter > t2.Minuter;
    }
    public static bool operator <(Tidsintervall t1, Tidsintervall t2)
    {
        return t1.Minuter < t2.Minuter;
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Uppgift 12: Jämförelseoperatorer ---\n");

        Tidsintervall lektion1 = new Tidsintervall(45);
        Tidsintervall lektion2 = new Tidsintervall(60);

        if (lektion1 > lektion2)
        {
            Console.WriteLine("Lektion 1 är längre");
        }
        else
        {
            Console.WriteLine("Lektion 1 är INTE längre");
        }





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
