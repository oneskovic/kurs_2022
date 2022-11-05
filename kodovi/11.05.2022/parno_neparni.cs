using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uneti_broj;
            bool bilo_neparnih = false;
            bool dobar_niz = true;
            while (true)
            {
                uneti_broj = Console.ReadLine();
                if (uneti_broj == null)
                    break;
                int broj = Convert.ToInt32(uneti_broj);
                if (broj % 2 == 0) // paran
                {
                    if (bilo_neparnih)
                        dobar_niz = false;
                }
                else // neparan
                    bilo_neparnih = true;
            }
            if (dobar_niz)
                Console.WriteLine("da");
            else
                Console.WriteLine("ne");            
        }
     }
}