using System;

namespace RushHour
{
    class Program
    {
        static void Main(string[] args)
        {
            Spielfeld spielfeld1 = new Spielfeld();
            Console.WriteLine(spielfeld1.FelderFrei((0, 0), (5, 5)));
            Console.ReadKey();
        }
    }
}