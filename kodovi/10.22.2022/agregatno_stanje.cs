using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            if (t <= 0)
            {
                Console.WriteLine("cvrsto");
            }
            else if (t < 100)
            {
                Console.WriteLine("tecno");
            }
            else
            {
                Console.WriteLine("gasovito");
            }
        }
    }
}