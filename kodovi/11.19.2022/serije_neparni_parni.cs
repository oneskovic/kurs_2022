using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static int IspisiRed(int pocetni_broj, int n)
        {
            int trenutni_broj = pocetni_broj;
            for (int i = 0; i < n; i++)
            {
                Console.Write(trenutni_broj + " ");
                trenutni_broj += 2;
            }
            Console.WriteLine();
            return trenutni_broj-1;
        }
        static void Main(string[] args)
        {
            int broj_redova = Convert.ToInt32(Console.ReadLine());
            int trenutni_broj = 1;
            for (int i = 0; i < broj_redova; i++)
            {
                int sledeci = IspisiRed(trenutni_broj, i + 1);
                trenutni_broj = sledeci;
            }
        }
     }
}