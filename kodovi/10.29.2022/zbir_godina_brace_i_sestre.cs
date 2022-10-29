using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godine = int.Parse(Console.ReadLine());
            
            if ((godine - 3) % 4 == 0) {
                Console.WriteLine("da");
            }
            else {
                Console.WriteLine("ne");
            }
        }
    }
}