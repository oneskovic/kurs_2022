using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double a = x1 - x2;
            double b = y1 - y2;
            double duzina = Math.Sqrt(a * a + b * b);
            Console.WriteLine(Math.Round(duzina,5));

        }
    }
}