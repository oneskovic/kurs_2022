using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int c1 = x % 10;
            int c2 = (x / 10) % 10;
            int c3 = (x / 100) % 10;

            int y = x / 1000;
            y = y * 10 + c1;
            y = y * 10 + c2;
            y = y * 10 + c3;
            
            Console.WriteLine(y);
        }
    }
}