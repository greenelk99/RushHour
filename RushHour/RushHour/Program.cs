using System;

namespace RushHour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Spielfeld spielfeld1 = new Spielfeld();
            spielfeld1.print();
            spielfeld1.FelderFrei((1,2), (1,2))
        }
    }
}