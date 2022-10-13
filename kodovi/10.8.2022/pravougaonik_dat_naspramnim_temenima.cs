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
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double obim = 2 * a + 2 * b;
            double povrsina = a * b;
            double l = Math.Sqrt(a * a + b * b);
            Console.WriteLine(Math.Round(l,2));
            Console.WriteLine(obim);
            Console.WriteLine(povrsina);

        }
    }
}