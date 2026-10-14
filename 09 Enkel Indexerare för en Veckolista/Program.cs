using System.Security.AccessControl;

namespace _09_Enkel_Indexerare_för_en_Veckolista;

// INDEXERAR-KLASS
public class VeckoLista
{
    private string[] dagar = { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };

    // Indexerare
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < dagar.Length)
            {
                return dagar[index];
            }
            return "Ogiltig dag!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Uppgift 9: Indexerare (Int) ---\n\n");

            VeckoLista schema = new VeckoLista();

            // Vi kan använda objektet som om det vore en array:
            Console.WriteLine($"Första dagen på veckan: {schema[0]}");
            Console.WriteLine($"Tredje dagen på veckan: {schema[2]}");







            Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
            Console.ReadKey();
        }
    }
}
