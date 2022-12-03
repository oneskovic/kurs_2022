using System;
namespace ConsoleApp2
{
    internal class Program
    {
        // Uklanja sve brojeve koji dele duzinu niza
        static int[] UkloniBrojeve(int[] niz)
        {
            int n = niz.Length;
            // Prebrojim koliko ima elemenata koje treba da zadrzim (tj. koliko ima el. koji ne dele n)
            int broj_dobrih = 0;
            for (int i = 0; i < n; i++)
                if (n % niz[i] != 0)
                    broj_dobrih++;

            int[] novi_niz = new int[broj_dobrih];
            int poz_u_novom_nizu = 0;
            // Prolazim kroz niz, upisujem elemente koji ne dele n
            for (int i = 0; i < n; i++)
            {
                if (n % niz[i] != 0)
                {
                    novi_niz[poz_u_novom_nizu] = niz[i];
                    poz_u_novom_nizu++;
                }
            }
            return novi_niz;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[n];
            for (int i = 0; i < n; i++)         
                niz[i] = Convert.ToInt32(Console.ReadLine());

            bool uklonjen_element = true;
            while (uklonjen_element)
            {
                int[] novi_niz = UkloniBrojeve(niz);
                if (novi_niz.Length < niz.Length)
                {
                    uklonjen_element = true;
                    niz = novi_niz;
                }
                else
                    uklonjen_element = false;
            }

            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            Console.WriteLine(suma);
        }
    }
}