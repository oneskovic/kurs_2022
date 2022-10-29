using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());

            if (x >= 4.5)
                Console.WriteLine("odlican");
            else if (x >= 3.5)
                Console.WriteLine("vrlodobar");
            else if (x >= 2.5)
            {
                Console.WriteLine("dobar");
            }
            else if (x >= 1.5)
                Console.WriteLine("dovoljan");
            else
                Console.WriteLine("nedovoljan");
        }
    }
}