using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0)
                    Console.Write(a[i] + " ");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 1)
                    Console.Write(a[i] + " ");

        }
    }
}