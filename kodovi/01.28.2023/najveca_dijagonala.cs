using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int zbir_dijagonale(int[,] m, int n, int red, int col)
        {
            int zbir = 0;
            while (red < n && col < n)
            {
                zbir += m[red, col];
                red++;
                col++;
            }
            return zbir;
        }
        static int zbir_dijagonale2(int[,] m, int n, int red, int col)
        {
            int zbir = 0;
            while (red < n && col >= 0)
            {
                zbir += m[red, col];
                red++;
                col--;
            }
            return zbir;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] m = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var brojevi = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)                
                    m[i, j] = Convert.ToInt32(brojevi[j]);                
            }

            int max = int.MinValue;
            // Prolazimo kroz 0-ti red
            for (int i = 0; i < n; i++)
                max = Math.Max(zbir_dijagonale(m, n, 0, i), max);
            // Prolazimo kroz 0-tu kolonu
            for (int i = 0; i < n; i++)
                max = Math.Max(zbir_dijagonale(m, n, i, 0), max);
            // Kroz 0-ti red, obrnute dijagonale
            for (int i = 0; i < n; i++)
                max = Math.Max(zbir_dijagonale2(m, n, 0, i), max);
            // Kroz 0-ti kolona, obrnute dijagonale
            for (int i = 0; i < n; i++)
                max = Math.Max(zbir_dijagonale2(m, n, i, n-1), max);

            Console.WriteLine(max);
        }
    }
}