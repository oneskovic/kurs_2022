using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int uneti_broj = Convert.ToInt32(Console.ReadLine());
                if (uneti_broj == 0)
                {
                    Console.WriteLine(s);
                    s = 0;
                }
                s += uneti_broj;
            }
            Console.WriteLine(s);
        }
     }
}