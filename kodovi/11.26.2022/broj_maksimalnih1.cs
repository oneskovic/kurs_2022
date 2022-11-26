using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)        
                a[i] = Convert.ToInt32(Console.ReadLine());

            // Trazimo maksimum
            int maksimum = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > maksimum) // Da li je element na poz. i veci od maksimum
                {
                    maksimum = a[i];
                }
            }

            int broj_pojavljivanja = 0;
            // Brojimo koliko puta se pojavljuje maksimum u nizu
            for (int i = 0; i < n; i++)
            {
                if (a[i] == maksimum)
                {
                    broj_pojavljivanja++;
                }
            }
            Console.WriteLine(broj_pojavljivanja);
        }
    }
}