using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void IspisiRed(int broj_zvezdica, int broj_praznih)
        {
            for (int i = 0; i < broj_zvezdica; i++)
                Console.Write("*");
            for (int i = 0; i < broj_praznih; i++)
                Console.Write(" ");
            for (int i = 0; i < broj_zvezdica; i++)
                Console.Write("*");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int broj_zvezdica = n;
            int broj_praznih = 0;
            for (int i = 0; i < n; i++)
            {
                IspisiRed(broj_zvezdica, broj_praznih);
                broj_zvezdica--;
                broj_praznih += 2;
            }

            broj_zvezdica = 2;
            broj_praznih -= 4;

            for (int i = 0; i < n-1; i++)
            {
                IspisiRed(broj_zvezdica, broj_praznih);
                broj_zvezdica++;
                broj_praznih -= 2;
            }
        }
     }
}