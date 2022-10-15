using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double d1 = Math.Abs(b);
            double d2 = Math.Abs(-b / a);
            double povrsina = d1 * d2 / 2;

            double c = Math.Sqrt(d1 * d1 + d2 * d2);
            double obim = d1 + d2 + c;

            Console.WriteLine(povrsina.ToString("0.00"));
            Console.WriteLine(obim.ToString("0.00"));
        }
    }
}