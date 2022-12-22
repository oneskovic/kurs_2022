using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = Console.ReadLine();
            string nova_recenica = "";

            // "abc" + "cde" -> "abccde"

            for (int i = 0; i < recenica.Length; i++)
            {
                if (char.IsLetter(recenica[i]))
                {
                    nova_recenica += recenica[i];
                }
            }
            nova_recenica = nova_recenica.ToLower();
            //abcdef.reverse() -> mogu da prolazim od pozadi
            //vraca mi redom f,e,d,c,b,a
            string obrnuta_recenica = "";

            foreach (char c in nova_recenica.Reverse())                 
                obrnuta_recenica += c;

            if (obrnuta_recenica == nova_recenica)           
                Console.WriteLine("da");            
            else
                Console.WriteLine("ne");

        }
    }
}