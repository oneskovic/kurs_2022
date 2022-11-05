using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int suma_unetih = 0;
            for (int i = 0; i < n-1; i++)
            {
                int uneti_broj = Convert.ToInt32(Console.ReadLine());
                suma_unetih += uneti_broj;
            }

            int x = n * (n + 1) / 2 - suma_unetih;
            Console.WriteLine(x);
        }
    }
}