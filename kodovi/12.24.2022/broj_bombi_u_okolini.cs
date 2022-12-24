using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static bool ValidnoPolje(int i, int j, int n, int m)
        {
            return i >= 0 && i < n && j >= 0 && j < m;
        }

        static void Main(string[] args)
        {
            // Ucitavamo n i m koji se unose u istom redu
            string[] dimenzije = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(dimenzije[0]);
            int m = Convert.ToInt32(dimenzije[1]);

            int[,] t = new int[n, m];

            // Ucitavamo matricu t
            for (int i = 0; i < n; i++)
            {
                // Splitujemo brojeve u trenutnom redu
                string[] brojevi = Console.ReadLine().Split(' ');
                // Upisujemo brojeve iz trenutnog reda u matricu
                for (int j = 0; j < m; j++)
                    t[i,j] = Convert.ToInt32(brojevi[j]);
            }

            int[,] bombe = new int[n, m]; // Matrica u kojoj cemo cuvati broj bomi za polje i,j

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Niz suseda (tj. matrica 8x2 gde je npr. susedi[0] -> [i-1,j-1])
                    int[,] susedi = {
                        { i - 1, j - 1 }, { i - 1, j }, { i - 1, j + 1 },
                        { i, j-1 }, { i, j+1 },
                        { i + 1, j - 1}, { i + 1, j }, { i+ 1, j + 1} };

                    for (int k = 0; k < 8; k++)
                    {
                        // Provera da li je k-ti sused validno polje
                        int red_sused = susedi[k, 0];
                        int kolona_sused = susedi[k, 1];
                        if (ValidnoPolje(red_sused, kolona_sused, n, m))
                            bombe[i,j] += t[red_sused,kolona_sused];
                    }
                }
            }

            // Ispisujemo matricu bombe
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(bombe[i,j] + " ");
                
                Console.WriteLine();
            }
        }
    }
}