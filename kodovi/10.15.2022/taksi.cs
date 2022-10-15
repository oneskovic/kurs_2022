using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c1 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double c3 = Convert.ToDouble(Console.ReadLine());

            double a = c1 / 3;
            double b = (c2 - a) / 2;
            double c = c3 - a - b;
            
            Console.WriteLine(a.ToString("0.00"));
            Console.WriteLine(b.ToString("0.00"));
            Console.WriteLine(c.ToString("0.00"));
        }
    }
}