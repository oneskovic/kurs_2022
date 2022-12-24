using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {                     
            
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> mapa = new Dictionary<int, int>();

            string s = Console.ReadLine();
            string[] brojevi = s.Split(' ');

            for (int poz = 0; poz < n; poz++)
            {
                int broj = Convert.ToInt32(brojevi[poz]);
                mapa[broj] = poz+1;
            }
            int broj_upita = Convert.ToInt32(Console.ReadLine());
            for (int q = 0; q < broj_upita; q++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (mapa.ContainsKey(x))                
                    Console.WriteLine(mapa[x]);
                else
                    Console.WriteLine(0);               
            }
        }
    }
}