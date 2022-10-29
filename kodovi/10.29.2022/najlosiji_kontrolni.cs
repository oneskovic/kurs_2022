using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prva_ocena = Convert.ToInt32(Console.ReadLine());
            int minimum = prva_ocena;
            int suma = prva_ocena;

            int uneto_ocena = 0;
            while (uneto_ocena < 4)
            {
                int ocena = Convert.ToInt32(Console.ReadLine());
                suma += ocena;
                if (ocena < minimum)
                    minimum = ocena;

                uneto_ocena++;
            }
            double prosek = (suma - minimum) / 4.0;
            Console.WriteLine(prosek.ToString("0.00"));
        }
    }
}