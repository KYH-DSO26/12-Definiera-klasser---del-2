
using static System.Console;

using _04_Använda_Namespaces.Geometri;

using Geometri.Forminfo;

namespace Geometri.Forminfo
{
    public class Punkt2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Punkt2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}


namespace _04_Använda_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Punkt3D(1, 2, 3);
            var p2 = new Punkt2D(10, 20);

            Console.WriteLine($"2D-punkt: X: {p2.X}, Y: {p2.Y}");



            Write("\n\nTryck på en tangent för att stänga fönstret...");
            ReadKey();
        }
    }
}
