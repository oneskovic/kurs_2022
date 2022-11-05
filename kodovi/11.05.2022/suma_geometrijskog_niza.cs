using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double q = Convert.ToDouble(Console.ReadLine());
            double broj = a;
            double zbir = 0;
            while (n > 0)
            {
                zbir += broj;
                broj *= q;
                n--;
            }
            Console.WriteLine(zbir.ToString("0.00000"));
        }
     }
}